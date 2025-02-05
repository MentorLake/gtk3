namespace MentorLake.Gtk3.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GDBusSubtreeIntrospectFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusConnectionHandle>))] GDBusConnectionHandle connection, string sender, string object_path, string node, IntPtr user_data);
