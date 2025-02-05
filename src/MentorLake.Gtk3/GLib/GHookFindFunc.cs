namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GHookFindFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GHookHandle>))] GHookHandle hook, IntPtr data);
