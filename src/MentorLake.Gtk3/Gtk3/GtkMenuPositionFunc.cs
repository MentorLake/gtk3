namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkMenuPositionFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuHandle>))] GtkMenuHandle menu, ref int x, ref int y, out bool push_in, IntPtr user_data);
