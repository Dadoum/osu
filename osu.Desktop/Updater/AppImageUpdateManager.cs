// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.IO;
using System.Threading.Tasks;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Colour;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Game;
using osu.Game.Graphics;
using osu.Game.Overlays;
using osu.Game.Overlays.Notifications;
using osuTK;
using osuTK.Graphics;
using Squirrel;

namespace osu.Desktop.Updater
{
    public class AppImageUpdateManager : osu.Game.Updater.UpdateManager
    {
        private Appimage.Updater.Updater updateManager;
        private NotificationOverlay notificationOverlay;
        private bool isDeployedBuild;

        public Task PrepareUpdateAsync() => UpdateManager.RestartAppWhenExited();

        private static readonly osu.Framework.Logging.Logger logger = osu.Framework.Logging.Logger.GetLogger("updater");

        [BackgroundDependencyLoader]
        private void load(NotificationOverlay notification, OsuGameBase game)
        {
            notificationOverlay = notification;

            if (game.IsDeployedBuild)
            {
                isDeployedBuild = true;
                Splat.Locator.CurrentMutable.Register(() => new UpdateLogger(logger), typeof(Splat.ILogger));
                Schedule(() => Task.Run(() => checkForUpdateAsync()));
            }
        }

        private void checkForUpdateAsync(AppImageUpdateManager.UpdateProgressNotification notification = null)
        {
            // should we schedule a retry on completion of this check?
            bool scheduleRecheck = true;

            try
            {
                if (updateManager == null) updateManager = new Appimage.Updater.Updater(Environment.GetEnvironmentVariable("APPIMAGE"), true);

                bool updateAvailable = false;
                updateManager.CheckForChanges(ref updateAvailable, 0);

                // Check if there is any message to log.
                while (updateManager.NextStatusMessage(out string nextMessage))
                    osu.Framework.Logging.Logger.Log(nextMessage);

                if (!updateAvailable)
                    // no updates available. bail and retry later.
                    return;

                if (notification == null)
                {
                    notification = new AppImageUpdateManager.UpdateProgressNotification(this) { State = ProgressNotificationState.Active };
                    Schedule(() => notificationOverlay.Post(notification));
                }

                notification.Progress = 0;
                notification.Text = @"Downloading and installing update...";

                try
                {
                    updateManager.Start();

                    while (!updateManager.IsDone)
                    {
                        double progress = 0d;

                        if (updateManager.Progress(ref progress))
                        {
                            notification.Progress = (float)progress;
                        }

                        // Check if there is any message to log.
                        while (updateManager.NextStatusMessage(out string nextMessage))
                            osu.Framework.Logging.Logger.Log(nextMessage);
                    }

                    if (updateManager.HasError)
                    {
                        while (updateManager.NextStatusMessage(out string nextMessage))
                            osu.Framework.Logging.Logger.Log(nextMessage);

                        throw new AppImageNativeException();
                    }

                    osu.Desktop.Updater.Appimage.Updater.Updater.ValidationState state = updateManager.ValidateSignature();

                    if (isDeployedBuild && state >= osu.Desktop.Updater.Appimage.Updater.Updater.ValidationState.VALIDATION_FAILED)
                    {
                        string msg = osu.Desktop.Updater.Appimage.Updater.Updater.SignatureValidationMessage(state);
                        var exception = new IOException(msg);

                        osu.Framework.Logging.Logger.Error(exception, msg);

                        throw exception;
                    }

                    notification.State = ProgressNotificationState.Completed;
                }
                catch (Exception e)
                {
                    notification.State = ProgressNotificationState.Cancelled;
                    osu.Framework.Logging.Logger.Error(e, @"update failed!");
                }
            }
            catch (Exception)
            {
                // we'll ignore this and retry later. can be triggered by no internet connection or thread abortion.
            }
            finally
            {
                if (scheduleRecheck)
                {
                    // check again in 30 minutes.
                    Scheduler.AddDelayed(() => checkForUpdateAsync(), 60000 * 30);
                }
            }
        }

        protected override void Dispose(bool isDisposing)
        {
            base.Dispose(isDisposing);
            updateManager?.Dispose();
        }

        private class UpdateProgressNotification : ProgressNotification
        {
            private readonly AppImageUpdateManager updateManager;
            private OsuGame game;

            public UpdateProgressNotification(AppImageUpdateManager updateManager)
            {
                this.updateManager = updateManager;
            }

            protected override Notification CreateCompletionNotification()
            {
                return new ProgressCompletionNotification
                {
                    Text = @"Update ready to install. Click to restart!",
                    Activated = () =>
                    {
                        updateManager.PrepareUpdateAsync()
                                     .ContinueWith(_ => updateManager.Schedule(() => game.GracefullyExit()));
                        return true;
                    }
                };
            }

            [BackgroundDependencyLoader]
            private void load(OsuColour colours, OsuGame game)
            {
                this.game = game;

                IconContent.AddRange(new Drawable[]
                {
                    new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                        Colour = ColourInfo.GradientVertical(colours.YellowDark, colours.Yellow)
                    },
                    new SpriteIcon
                    {
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                        Icon = FontAwesome.Solid.Upload,
                        Colour = Color4.White,
                        Size = new Vector2(20),
                    }
                });
            }
        }

        public class AppImageNativeException : Exception
        {
            internal AppImageNativeException()
                : base("An exception occured in the native library used for updating.")
            {
            }
        }
    }
}
