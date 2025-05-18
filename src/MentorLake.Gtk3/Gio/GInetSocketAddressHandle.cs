namespace MentorLake.Gio;

public class GInetSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
	public static MentorLake.Gio.GInetSocketAddressHandle New(MentorLake.Gio.GInetAddressHandle address, ushort port)
	{
		return GInetSocketAddressHandleExterns.g_inet_socket_address_new(address, port);
	}

	public static MentorLake.Gio.GInetSocketAddressHandle NewFromString(string address, uint port)
	{
		return GInetSocketAddressHandleExterns.g_inet_socket_address_new_from_string(address, port);
	}

}

public static class GInetSocketAddressHandleExtensions
{
	public static MentorLake.Gio.GInetAddressHandle GetAddress(this MentorLake.Gio.GInetSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetSocketAddressHandle)");
		return GInetSocketAddressHandleExterns.g_inet_socket_address_get_address(address);
	}

	public static uint GetFlowinfo(this MentorLake.Gio.GInetSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetSocketAddressHandle)");
		return GInetSocketAddressHandleExterns.g_inet_socket_address_get_flowinfo(address);
	}

	public static ushort GetPort(this MentorLake.Gio.GInetSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetSocketAddressHandle)");
		return GInetSocketAddressHandleExterns.g_inet_socket_address_get_port(address);
	}

	public static uint GetScopeId(this MentorLake.Gio.GInetSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetSocketAddressHandle)");
		return GInetSocketAddressHandleExterns.g_inet_socket_address_get_scope_id(address);
	}

}

internal class GInetSocketAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInetSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GInetSocketAddressHandle g_inet_socket_address_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address, ushort port);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInetSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GInetSocketAddressHandle g_inet_socket_address_new_from_string(string address, uint port);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))]
	internal static extern MentorLake.Gio.GInetAddressHandle g_inet_socket_address_get_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetSocketAddressHandle>))] MentorLake.Gio.GInetSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_inet_socket_address_get_flowinfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetSocketAddressHandle>))] MentorLake.Gio.GInetSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_inet_socket_address_get_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetSocketAddressHandle>))] MentorLake.Gio.GInetSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_inet_socket_address_get_scope_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetSocketAddressHandle>))] MentorLake.Gio.GInetSocketAddressHandle address);

}
