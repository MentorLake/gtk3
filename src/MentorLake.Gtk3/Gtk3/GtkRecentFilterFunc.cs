namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkRecentFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRecentFilterInfoHandle>))] GtkRecentFilterInfoHandle filter_info, IntPtr user_data);
