namespace MentorLake.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GObject.GType GDBusProxyTypeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager, string object_path, string interface_name, IntPtr data);
