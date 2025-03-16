namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkBuilderConnectFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string signal_name, string handler_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle connect_object, MentorLake.GObject.GConnectFlags flags, IntPtr user_data);
