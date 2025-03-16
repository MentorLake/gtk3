namespace MentorLake.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GInterfaceInitFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, IntPtr iface_data);
