namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkFileFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileFilterInfoHandle>))] GtkFileFilterInfoHandle filter_info, IntPtr data);
