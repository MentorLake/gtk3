namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeIterCompareFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeModelHandleImpl>))] GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle b, IntPtr user_data);
