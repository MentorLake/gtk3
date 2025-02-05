namespace MentorLake.Gtk3.Gio;

public class GProxyAddressHandle : GInetSocketAddressHandle, GSocketConnectableHandle
{
	public static GProxyAddressHandle New(GInetAddressHandle inetaddr, ushort port, string protocol, string dest_hostname, ushort dest_port, string username, string password)
	{
		return GProxyAddressExterns.g_proxy_address_new(inetaddr, port, protocol, dest_hostname, dest_port, username, password);
	}

}

public static class GProxyAddressHandleExtensions
{
	public static string GetDestinationHostname(this GProxyAddressHandle proxy)
	{
		return GProxyAddressExterns.g_proxy_address_get_destination_hostname(proxy);
	}

	public static ushort GetDestinationPort(this GProxyAddressHandle proxy)
	{
		return GProxyAddressExterns.g_proxy_address_get_destination_port(proxy);
	}

	public static string GetDestinationProtocol(this GProxyAddressHandle proxy)
	{
		return GProxyAddressExterns.g_proxy_address_get_destination_protocol(proxy);
	}

	public static string GetPassword(this GProxyAddressHandle proxy)
	{
		return GProxyAddressExterns.g_proxy_address_get_password(proxy);
	}

	public static string GetProtocol(this GProxyAddressHandle proxy)
	{
		return GProxyAddressExterns.g_proxy_address_get_protocol(proxy);
	}

	public static string GetUri(this GProxyAddressHandle proxy)
	{
		return GProxyAddressExterns.g_proxy_address_get_uri(proxy);
	}

	public static string GetUsername(this GProxyAddressHandle proxy)
	{
		return GProxyAddressExterns.g_proxy_address_get_username(proxy);
	}

}

internal class GProxyAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GProxyAddressHandle g_proxy_address_new(GInetAddressHandle inetaddr, ushort port, string protocol, string dest_hostname, ushort dest_port, string username, string password);

	[DllImport(Libraries.Gio)]
	internal static extern string g_proxy_address_get_destination_hostname(GProxyAddressHandle proxy);

	[DllImport(Libraries.Gio)]
	internal static extern ushort g_proxy_address_get_destination_port(GProxyAddressHandle proxy);

	[DllImport(Libraries.Gio)]
	internal static extern string g_proxy_address_get_destination_protocol(GProxyAddressHandle proxy);

	[DllImport(Libraries.Gio)]
	internal static extern string g_proxy_address_get_password(GProxyAddressHandle proxy);

	[DllImport(Libraries.Gio)]
	internal static extern string g_proxy_address_get_protocol(GProxyAddressHandle proxy);

	[DllImport(Libraries.Gio)]
	internal static extern string g_proxy_address_get_uri(GProxyAddressHandle proxy);

	[DllImport(Libraries.Gio)]
	internal static extern string g_proxy_address_get_username(GProxyAddressHandle proxy);

}
