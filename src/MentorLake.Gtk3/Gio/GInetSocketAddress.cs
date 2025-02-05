namespace MentorLake.Gtk3.Gio;

public class GInetSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
	public static GInetSocketAddressHandle New(GInetAddressHandle address, ushort port)
	{
		return GInetSocketAddressExterns.g_inet_socket_address_new(address, port);
	}

	public static GInetSocketAddressHandle NewFromString(string address, uint port)
	{
		return GInetSocketAddressExterns.g_inet_socket_address_new_from_string(address, port);
	}

}

public static class GInetSocketAddressHandleExtensions
{
	public static GInetAddressHandle GetAddress(this GInetSocketAddressHandle address)
	{
		return GInetSocketAddressExterns.g_inet_socket_address_get_address(address);
	}

	public static uint GetFlowinfo(this GInetSocketAddressHandle address)
	{
		return GInetSocketAddressExterns.g_inet_socket_address_get_flowinfo(address);
	}

	public static ushort GetPort(this GInetSocketAddressHandle address)
	{
		return GInetSocketAddressExterns.g_inet_socket_address_get_port(address);
	}

	public static uint GetScopeId(this GInetSocketAddressHandle address)
	{
		return GInetSocketAddressExterns.g_inet_socket_address_get_scope_id(address);
	}

}

internal class GInetSocketAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GInetSocketAddressHandle g_inet_socket_address_new(GInetAddressHandle address, ushort port);

	[DllImport(Libraries.Gio)]
	internal static extern GInetSocketAddressHandle g_inet_socket_address_new_from_string(string address, uint port);

	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_socket_address_get_address(GInetSocketAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_inet_socket_address_get_flowinfo(GInetSocketAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern ushort g_inet_socket_address_get_port(GInetSocketAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_inet_socket_address_get_scope_id(GInetSocketAddressHandle address);

}
