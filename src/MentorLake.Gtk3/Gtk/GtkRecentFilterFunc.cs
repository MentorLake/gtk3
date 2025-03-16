namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkRecentFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterInfoHandle>))] MentorLake.Gtk.GtkRecentFilterInfoHandle filter_info, IntPtr user_data);
