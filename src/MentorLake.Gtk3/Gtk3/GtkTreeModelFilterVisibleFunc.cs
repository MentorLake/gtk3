namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTreeModelFilterVisibleFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeModelHandleImpl>))] GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle iter, IntPtr data);
