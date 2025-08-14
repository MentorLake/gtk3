namespace MentorLake.GioUnix;

/// <summary>
/// <para>
/// During invocation, g_desktop_app_info_launch_uris_as_manager() may
/// create one or more child processes.  This callback is invoked once
/// for each, providing the process ID.
/// </para>
/// </summary>

/// <param name="appinfo">
/// a #GDesktopAppInfo
/// </param>
/// <param name="pid">
/// Process identifier
/// </param>
/// <param name="user_data">
/// User data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDesktopAppLaunchCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle appinfo, MentorLake.GLib.GPid pid, IntPtr user_data);
