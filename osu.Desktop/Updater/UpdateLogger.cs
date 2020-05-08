// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using LogLevel = Splat.LogLevel;

namespace osu.Desktop.Updater
{
    internal class UpdateLogger : Splat.ILogger, IDisposable
    {
        public Splat.LogLevel Level { get; set; } = Splat.LogLevel.Info;
        private readonly osu.Framework.Logging.Logger logger;

        internal UpdateLogger(osu.Framework.Logging.Logger logger)
        {
            this.logger = logger;
        }

        public void Write(string message, LogLevel logLevel)
        {
            if (logLevel < Level)
                return;

            logger.Add(message);
        }

        public void Dispose()
        {
        }
    }
}
