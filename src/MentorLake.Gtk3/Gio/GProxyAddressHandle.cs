namespace MentorLake.Gio;

public class GProxyAddressHandle : GInetSocketAddressHandle, GSocketConnectableHandle
{
	public static MentorLake.Gio.GProxyAddressHandle New(MentorLake.Gio.GInetAddressHandle inetaddr, ushort port, string protocol, string dest_hostname, ushort dest_port, string username, string password)
	{
		return GProxyAddressHandleExterns.g_proxy_address_new(inetaddr, port, protocol, dest_hostname, dest_port, username, password);
	}

}

public static class GProxyAddressHandleExtensions
{
	public static string GetDestinationHostname(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_destination_hostname(proxy);
	}

	public static ushort GetDestinationPort(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_destination_port(proxy);
	}

	public static string GetDestinationProtocol(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_destination_protocol(proxy);
	}

	public static string GetPassword(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_password(proxy);
	}

	public static string GetProtocol(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_protocol(proxy);
	}

	public static string GetUri(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_uri(proxy);
	}

	public static string GetUsername(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_username(proxy);
	}

}

internal class GProxyAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GProxyAddressHandle g_proxy_address_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle inetaddr, ushort port, string protocol, string dest_hostname, ushort dest_port, string username, string password);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_proxy_address_get_destination_hostname([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_proxy_address_get_destination_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_proxy_address_get_destination_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_proxy_address_get_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_proxy_address_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_proxy_address_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_proxy_address_get_username([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy);

}
