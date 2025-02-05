namespace MentorLake.Gtk3.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSocketSourceFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketHandle>))] GSocketHandle socket, GIOCondition condition, IntPtr data);
