namespace MentorLake.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameAppearedCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, string name_owner, IntPtr user_data);
