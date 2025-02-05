namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkListBoxForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxRowHandle>))] GtkListBoxRowHandle row, IntPtr user_data);
