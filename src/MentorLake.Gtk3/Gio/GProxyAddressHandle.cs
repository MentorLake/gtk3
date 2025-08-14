namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A [class@Gio.InetSocketAddress] representing a connection via a proxy server.
/// </para>
/// </summary>

public class GProxyAddressHandle : GInetSocketAddressHandle, GSocketConnectableHandle
{
/// <summary>
/// <para>
/// Creates a new #GProxyAddress for @inetaddr with @protocol that should
/// tunnel through @dest_hostname and @dest_port.
/// </para>
/// <para>
/// (Note that this method doesn't set the #GProxyAddress:uri or
/// #GProxyAddress:destination-protocol fields; use g_object_new()
/// directly if you want to set those.)
/// </para>
/// </summary>

/// <param name="inetaddr">
/// The proxy server #GInetAddress.
/// </param>
/// <param name="port">
/// The proxy server port.
/// </param>
/// <param name="protocol">
/// The proxy protocol to support, in lower case (e.g. socks, http).
/// </param>
/// <param name="dest_hostname">
/// The destination hostname the proxy should tunnel to.
/// </param>
/// <param name="dest_port">
/// The destination port to tunnel to.
/// </param>
/// <param name="username">
/// The username to authenticate to the proxy server
///     (or %NULL).
/// </param>
/// <param name="password">
/// The password to authenticate to the proxy server
///     (or %NULL).
/// </param>
/// <return>
/// a new #GProxyAddress
/// </return>

	public static MentorLake.Gio.GProxyAddressHandle New(MentorLake.Gio.GInetAddressHandle inetaddr, ushort port, string protocol, string dest_hostname, ushort dest_port, string username, string password)
	{
		return GProxyAddressHandleExterns.g_proxy_address_new(inetaddr, port, protocol, dest_hostname, dest_port, username, password);
	}

}

public static class GProxyAddressHandleExtensions
{
/// <summary>
/// <para>
/// Gets @proxy's destination hostname; that is, the name of the host
/// that will be connected to via the proxy, not the name of the proxy
/// itself.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxyAddress
/// </param>
/// <return>
/// the @proxy's destination hostname
/// </return>

	public static string GetDestinationHostname(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_destination_hostname(proxy);
	}

/// <summary>
/// <para>
/// Gets @proxy's destination port; that is, the port on the
/// destination host that will be connected to via the proxy, not the
/// port number of the proxy itself.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxyAddress
/// </param>
/// <return>
/// the @proxy's destination port
/// </return>

	public static ushort GetDestinationPort(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_destination_port(proxy);
	}

/// <summary>
/// <para>
/// Gets the protocol that is being spoken to the destination
/// server; eg, "http" or "ftp".
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxyAddress
/// </param>
/// <return>
/// the @proxy's destination protocol
/// </return>

	public static string GetDestinationProtocol(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_destination_protocol(proxy);
	}

/// <summary>
/// <para>
/// Gets @proxy's password.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxyAddress
/// </param>
/// <return>
/// the @proxy's password
/// </return>

	public static string GetPassword(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_password(proxy);
	}

/// <summary>
/// <para>
/// Gets @proxy's protocol. eg, "socks" or "http"
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxyAddress
/// </param>
/// <return>
/// the @proxy's protocol
/// </return>

	public static string GetProtocol(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_protocol(proxy);
	}

/// <summary>
/// <para>
/// Gets the proxy URI that @proxy was constructed from.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxyAddress
/// </param>
/// <return>
/// the @proxy's URI, or %NULL if unknown
/// </return>

	public static string GetUri(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_uri(proxy);
	}

/// <summary>
/// <para>
/// Gets @proxy's username.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxyAddress
/// </param>
/// <return>
/// the @proxy's username
/// </return>

	public static string GetUsername(this MentorLake.Gio.GProxyAddressHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyAddressHandle)");
		return GProxyAddressHandleExterns.g_proxy_address_get_username(proxy);
	}

}

internal class GProxyAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))]
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
