namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkBuilderConnectFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkBuilderHandle>))] GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle @object, string signal_name, string handler_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle connect_object, GConnectFlags flags, IntPtr user_data);
