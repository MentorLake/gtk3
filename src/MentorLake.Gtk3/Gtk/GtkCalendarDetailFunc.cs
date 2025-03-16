namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GtkCalendarDetailFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, uint year, uint month, uint day, IntPtr user_data);
