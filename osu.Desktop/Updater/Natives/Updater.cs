﻿// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace osu.Desktop.Updater
{
    namespace Appimage
    {
        namespace Updater
        {
            /// <summary>Primary class of AppImageUpdate. Abstracts entire functionality.</summary>
            /// <remarks>Update is run asynchronously in a separate thread. The owner of the instance can query the progress.</remarks>
            public unsafe partial class Updater : IDisposable
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr d;

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7UpdaterC2ERKNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEEEb")]
                    internal static extern void ctor(global::System.IntPtr __instance, global::System.IntPtr pathToAppImage, bool overwrite);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7UpdaterC2ERKS1_")]
                    internal static extern void cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7UpdaterD2Ev")]
                    internal static extern void dtor(global::System.IntPtr __instance);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater5startEv")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool Start(global::System.IntPtr __instance);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater8progressERd")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool Progress(global::System.IntPtr __instance, double* progress);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater17nextStatusMessageERNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEEE")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool NextStatusMessage(global::System.IntPtr __instance, global::System.IntPtr message);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater15checkForChangesERbj")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool CheckForChanges(global::System.IntPtr __instance, bool* updateAvailable, uint method);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZNK8appimage6update7Updater16describeAppImageERNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEEE")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool DescribeAppImage(global::System.IntPtr __instance, global::System.IntPtr description);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZNK8appimage6update7Updater13pathToNewFileERNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEEE")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool PathToNewFile(global::System.IntPtr __instance, global::System.IntPtr path);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater17validateSignatureEv")]
                    internal static extern global::osu.Desktop.Updater.Appimage.Updater.Updater.ValidationState ValidateSignature(global::System.IntPtr __instance);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater26signatureValidationMessageB5cxx11ERKNS1_15ValidationStateE")]
                    internal static extern void SignatureValidationMessage(global::System.IntPtr @return, global::osu.Desktop.Updater.Appimage.Updater.Updater.ValidationState* state);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZNK8appimage6update7Updater14remoteFileSizeERl")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool RemoteFileSize(global::System.IntPtr __instance, long* fileSize);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater19restoreOriginalFileEv")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool RestoreOriginalFile(global::System.IntPtr __instance);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater4stopEv")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool Stop(global::System.IntPtr __instance);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater5stateEv")]
                    internal static extern global::osu.Desktop.Updater.Appimage.Updater.Updater.State state(global::System.IntPtr __instance);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater6isDoneEv")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool IsDone(global::System.IntPtr __instance);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZN8appimage6update7Updater8hasErrorEv")]
                    [return: MarshalAs(UnmanagedType.I1)]
                    internal static extern bool HasError(global::System.IntPtr __instance);

                    [SuppressUnmanagedCodeSecurity]
                    [DllImport("appimageupdate", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                        EntryPoint="_ZNK8appimage6update7Updater17updateInformationB5cxx11Ev")]
                    internal static extern void UpdateInformation(global::System.IntPtr @return, global::System.IntPtr __instance);
                }

                public enum State : uint
                {
                    INITIALIZED = 0,
                    RUNNING = 1,
                    STOPPING = 2,
                    SUCCESS = 3,
                    ERROR = 4
                }

                public enum ValidationState : uint
                {
                    VALIDATION_PASSED = 0,
                    VALIDATION_WARNING = 1000,
                    VALIDATION_NOT_SIGNED = 1001,
                    VALIDATION_GPG2MISSING = 1002,
                    VALIDATION_FAILED = 2000,
                    VALIDATION_KEY_CHANGED = 2001,
                    VALIDATION_GPG2CALL_FAILED = 2002,
                    VALIDATION_TEMPDIR_CREATION_FAILED = 2003,
                    VALIDATION_NO_LONGER_SIGNED = 2004,
                    VALIDATION_BAD_SIGNATURE = 2005
                }

                public global::System.IntPtr __Instance { get; protected set; }

                protected int __PointerAdjustment;
                internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::osu.Desktop.Updater.Appimage.Updater.Updater> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::osu.Desktop.Updater.Appimage.Updater.Updater>();
                protected internal void*[] __OriginalVTables;

                protected bool __ownsNativeInstance;

                internal static global::osu.Desktop.Updater.Appimage.Updater.Updater __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
                {
                    return new global::osu.Desktop.Updater.Appimage.Updater.Updater(native.ToPointer(), skipVTables);
                }

                internal static global::osu.Desktop.Updater.Appimage.Updater.Updater __CreateInstance(global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal native, bool skipVTables = false)
                {
                    return new global::osu.Desktop.Updater.Appimage.Updater.Updater(native, skipVTables);
                }

                private static void* __CopyValue(global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal native)
                {
                    var ret = Marshal.AllocHGlobal(sizeof(global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal));
                    *(global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal*) ret = native;
                    return ret.ToPointer();
                }

                private Updater(global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal native, bool skipVTables = false)
                    : this(__CopyValue(native), skipVTables)
                {
                    __ownsNativeInstance = true;
                    NativeToManagedMap[__Instance] = this;
                }

                protected Updater(void* native, bool skipVTables = false)
                {
                    if (native == null)
                        return;
                    __Instance = new global::System.IntPtr(native);
                }

                public Updater(string pathToAppImage, bool overwrite)
                {
                    __Instance = Marshal.AllocHGlobal(sizeof(global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal));
                    __ownsNativeInstance = true;
                    NativeToManagedMap[__Instance] = this;
                    var __basicString0 = new global::osu.Desktop.Updater.Std.BasicString<sbyte, global::osu.Desktop.Updater.Std.CharTraits<sbyte>, global::osu.Desktop.Updater.Std.Allocator<sbyte>>();
                    global::osu.Desktop.Updater.Std.BasicStringExtensions.Assign(__basicString0, pathToAppImage);
                    var __arg0 = __basicString0.__Instance;
                    __Internal.ctor((__Instance + __PointerAdjustment), __arg0, overwrite);
                    __basicString0.Dispose();
                }

                public Updater(global::osu.Desktop.Updater.Appimage.Updater.Updater _0)
                {
                    __Instance = Marshal.AllocHGlobal(sizeof(global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal));
                    __ownsNativeInstance = true;
                    NativeToManagedMap[__Instance] = this;
                    *((global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal*) __Instance) = *((global::osu.Desktop.Updater.Appimage.Updater.Updater.__Internal*) _0.__Instance);
                }

                public void Dispose()
                {
                    Dispose(disposing: true);
                }

                public virtual void Dispose(bool disposing)
                {
                    if (__Instance == IntPtr.Zero)
                        return;
                    global::osu.Desktop.Updater.Appimage.Updater.Updater __dummy;
                    NativeToManagedMap.TryRemove(__Instance, out __dummy);
                    if (disposing)
                        __Internal.dtor((__Instance + __PointerAdjustment));
                    if (__ownsNativeInstance)
                        Marshal.FreeHGlobal(__Instance);
                    __Instance = IntPtr.Zero;
                }

                public bool Start()
                {
                    var __ret = __Internal.Start((__Instance + __PointerAdjustment));
                    return __ret;
                }

                public bool Progress(ref double progress)
                {
                    fixed (double* __progress0 = &progress)
                    {
                        var __arg0 = __progress0;
                        var __ret = __Internal.Progress((__Instance + __PointerAdjustment), __arg0);
                        return __ret;
                    }
                }

                public bool NextStatusMessage(out string message)
                {
                    message = "";
                    var __basicString0 = new global::osu.Desktop.Updater.Std.BasicString<sbyte, global::osu.Desktop.Updater.Std.CharTraits<sbyte>, global::osu.Desktop.Updater.Std.Allocator<sbyte>>();
                    global::osu.Desktop.Updater.Std.BasicStringExtensions.Assign(__basicString0, message);
                    var __arg0 = __basicString0.__Instance;
                    var __ret = __Internal.NextStatusMessage((__Instance + __PointerAdjustment), __arg0);
                    __basicString0.Dispose();
                    return __ret;
                }

                public bool CheckForChanges(ref bool updateAvailable, uint method)
                {
                    fixed (bool* __updateAvailable0 = &updateAvailable)
                    {
                        var __arg0 = __updateAvailable0;
                        var __ret = __Internal.CheckForChanges((__Instance + __PointerAdjustment), __arg0, method);
                        return __ret;
                    }
                }

                public bool DescribeAppImage(string description)
                {
                    var __basicString0 = new global::osu.Desktop.Updater.Std.BasicString<sbyte, global::osu.Desktop.Updater.Std.CharTraits<sbyte>, global::osu.Desktop.Updater.Std.Allocator<sbyte>>();
                    global::osu.Desktop.Updater.Std.BasicStringExtensions.Assign(__basicString0, description);
                    var __arg0 = __basicString0.__Instance;
                    var __ret = __Internal.DescribeAppImage((__Instance + __PointerAdjustment), __arg0);
                    __basicString0.Dispose();
                    return __ret;
                }

                public bool PathToNewFile(ref string path)
                {
                    var __basicString0 = new global::osu.Desktop.Updater.Std.BasicString<sbyte, global::osu.Desktop.Updater.Std.CharTraits<sbyte>, global::osu.Desktop.Updater.Std.Allocator<sbyte>>();
                    global::osu.Desktop.Updater.Std.BasicStringExtensions.Assign(__basicString0, path);
                    var __arg0 = __basicString0.__Instance;
                    var __ret = __Internal.PathToNewFile((__Instance + __PointerAdjustment), __arg0);
                    __basicString0.Dispose();
                    return __ret;
                }

                public global::osu.Desktop.Updater.Appimage.Updater.Updater.ValidationState ValidateSignature()
                {
                    var __ret = __Internal.ValidateSignature((__Instance + __PointerAdjustment));
                    return __ret;
                }

                public bool RemoteFileSize(ref long fileSize)
                {
                    fixed (long* __fileSize0 = &fileSize)
                    {
                        var __arg0 = __fileSize0;
                        var __ret = __Internal.RemoteFileSize((__Instance + __PointerAdjustment), __arg0);
                        return __ret;
                    }
                }

                public bool RestoreOriginalFile()
                {
                    var __ret = __Internal.RestoreOriginalFile((__Instance + __PointerAdjustment));
                    return __ret;
                }

                public static string SignatureValidationMessage(global::osu.Desktop.Updater.Appimage.Updater.Updater.ValidationState state)
                {
                    var __arg0 = &state;
                    var __ret = new global::osu.Desktop.Updater.Std.BasicString.__Internalc__N_std_N___cxx11_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C();
                    __Internal.SignatureValidationMessage(new IntPtr(&__ret), __arg0);
                    var __basicStringRet0 = global::osu.Desktop.Updater.Std.BasicString<sbyte, global::osu.Desktop.Updater.Std.CharTraits<sbyte>, global::osu.Desktop.Updater.Std.Allocator<sbyte>>.__CreateInstance(new global::System.IntPtr(&__ret));
                    var __retString0 = global::osu.Desktop.Updater.Std.BasicStringExtensions.Data(__basicStringRet0);
                    __basicStringRet0.Dispose();
                    return __retString0;
                }

                public bool Stop
                {
                    get
                    {
                        var __ret = __Internal.Stop((__Instance + __PointerAdjustment));
                        return __ret;
                    }
                }

                public global::osu.Desktop.Updater.Appimage.Updater.Updater.State state
                {
                    get
                    {
                        var __ret = __Internal.state((__Instance + __PointerAdjustment));
                        return __ret;
                    }
                }

                public bool IsDone
                {
                    get
                    {
                        var __ret = __Internal.IsDone((__Instance + __PointerAdjustment));
                        return __ret;
                    }
                }

                public bool HasError
                {
                    get
                    {
                        var __ret = __Internal.HasError((__Instance + __PointerAdjustment));
                        return __ret;
                    }
                }

                public string UpdateInformation
                {
                    get
                    {
                        var __ret = new global::osu.Desktop.Updater.Std.BasicString.__Internalc__N_std_N___cxx11_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C();
                        __Internal.UpdateInformation(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
                        var __basicStringRet0 = global::osu.Desktop.Updater.Std.BasicString<sbyte, global::osu.Desktop.Updater.Std.CharTraits<sbyte>, global::osu.Desktop.Updater.Std.Allocator<sbyte>>.__CreateInstance(new global::System.IntPtr(&__ret));
                        var __retString0 = global::osu.Desktop.Updater.Std.BasicStringExtensions.Data(__basicStringRet0);
                        __basicStringRet0.Dispose();
                        return __retString0;
                    }
                }
            }
        }
    }
}
