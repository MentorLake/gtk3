namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHookMarshaller([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GHookHandle>))] GHookHandle hook, IntPtr marshal_data);
