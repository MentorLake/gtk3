namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GtkCalendarDetailFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle calendar, uint year, uint month, uint day, IntPtr user_data);
