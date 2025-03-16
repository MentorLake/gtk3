namespace MentorLake.GioUnix;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDesktopAppLaunchCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle appinfo, MentorLake.GLib.GPid pid, IntPtr user_data);
