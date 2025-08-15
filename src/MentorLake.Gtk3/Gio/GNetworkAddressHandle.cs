namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GNetworkAddress` provides an easy way to resolve a hostname and
/// then attempt to connect to that host, handling the possibility of
/// multiple IP addresses and multiple address families.
/// </para>
/// <para>
/// The enumeration results of resolved addresses *may* be cached as long
/// as this object is kept alive which may have unexpected results if
/// alive for too long.
/// </para>
/// <para>
/// See [iface@Gio.SocketConnectable] for an example of using the connectable
/// interface.
/// </para>
/// </summary>

public class GNetworkAddressHandle : GObjectHandle, GSocketConnectableHandle
{
/// <summary>
/// <para>
/// Creates a new #GSocketConnectable for connecting to the given
/// @hostname and @port.
/// </para>
/// <para>
/// Note that depending on the configuration of the machine, a
/// @hostname of `localhost` may refer to the IPv4 loopback address
/// only, or to both IPv4 and IPv6; use
/// g_network_address_new_loopback() to create a #GNetworkAddress that
/// is guaranteed to resolve to both addresses.
/// </para>
/// </summary>

/// <param name="hostname">
/// the hostname
/// </param>
/// <param name="port">
/// the port
/// </param>
/// <return>
/// the new #GNetworkAddress
/// </return>

	public static MentorLake.Gio.GNetworkAddressHandle New(string hostname, ushort port)
	{
		return GNetworkAddressHandleExterns.g_network_address_new(hostname, port);
	}

/// <summary>
/// <para>
/// Creates a new #GSocketConnectable for connecting to the local host
/// over a loopback connection to the given @port. This is intended for
/// use in connecting to local services which may be running on IPv4 or
/// IPv6.
/// </para>
/// <para>
/// The connectable will return IPv4 and IPv6 loopback addresses,
/// regardless of how the host resolves `localhost`. By contrast,
/// g_network_address_new() will often only return an IPv4 address when
/// resolving `localhost`, and an IPv6 address for `localhost6`.
/// </para>
/// <para>
/// g_network_address_get_hostname() will always return `localhost` for
/// a #GNetworkAddress created with this constructor.
/// </para>
/// </summary>

/// <param name="port">
/// the port
/// </param>
/// <return>
/// the new #GNetworkAddress
/// </return>

	public static MentorLake.Gio.GNetworkAddressHandle NewLoopback(ushort port)
	{
		return GNetworkAddressHandleExterns.g_network_address_new_loopback(port);
	}

/// <summary>
/// <para>
/// Creates a new #GSocketConnectable for connecting to the given
/// @hostname and @port. May fail and return %NULL in case
/// parsing @host_and_port fails.
/// </para>
/// <para>
/// @host_and_port may be in any of a number of recognised formats; an IPv6
/// address, an IPv4 address, or a domain name (in which case a DNS
/// lookup is performed). Quoting with [] is supported for all address
/// types. A port override may be specified in the usual way with a
/// colon.
/// </para>
/// <para>
/// If no port is specified in @host_and_port then @default_port will be
/// used as the port number to connect to.
/// </para>
/// <para>
/// In general, @host_and_port is expected to be provided by the user
/// (allowing them to give the hostname, and a port override if necessary)
/// and @default_port is expected to be provided by the application.
/// </para>
/// <para>
/// (The port component of @host_and_port can also be specified as a
/// service name rather than as a numeric port, but this functionality
/// is deprecated, because it depends on the contents of /etc/services,
/// which is generally quite sparse on platforms other than Linux.)
/// </para>
/// </summary>

/// <param name="host_and_port">
/// the hostname and optionally a port
/// </param>
/// <param name="default_port">
/// the default port if not in @host_and_port
/// </param>
/// <return>
/// the new
///   #GNetworkAddress, or %NULL on error
/// </return>

	public static MentorLake.Gio.GSocketConnectableHandle Parse(string host_and_port, ushort default_port)
	{
		var externCallResult = GNetworkAddressHandleExterns.g_network_address_parse(host_and_port, default_port, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new #GSocketConnectable for connecting to the given
/// @uri. May fail and return %NULL in case parsing @uri fails.
/// </para>
/// <para>
/// Using this rather than g_network_address_new() or
/// g_network_address_parse() allows #GSocketClient to determine
/// when to use application-specific proxy protocols.
/// </para>
/// </summary>

/// <param name="uri">
/// the hostname and optionally a port
/// </param>
/// <param name="default_port">
/// The default port if none is found in the URI
/// </param>
/// <return>
/// the new
///   #GNetworkAddress, or %NULL on error
/// </return>

	public static MentorLake.Gio.GSocketConnectableHandle ParseUri(string uri, ushort default_port)
	{
		var externCallResult = GNetworkAddressHandleExterns.g_network_address_parse_uri(uri, default_port, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GNetworkAddressHandleExtensions
{
/// <summary>
/// <para>
/// Gets @addr&apos;s hostname. This might be either UTF-8 or ASCII-encoded,
/// depending on what @addr was created with.
/// </para>
/// </summary>

/// <param name="addr">
/// a #GNetworkAddress
/// </param>
/// <return>
/// @addr&apos;s hostname
/// </return>

	public static string GetHostname(this MentorLake.Gio.GNetworkAddressHandle addr)
	{
		if (addr.IsInvalid) throw new Exception("Invalid handle (GNetworkAddressHandle)");
		return GNetworkAddressHandleExterns.g_network_address_get_hostname(addr);
	}

/// <summary>
/// <para>
/// Gets @addr&apos;s port number
/// </para>
/// </summary>

/// <param name="addr">
/// a #GNetworkAddress
/// </param>
/// <return>
/// @addr&apos;s port (which may be 0)
/// </return>

	public static ushort GetPort(this MentorLake.Gio.GNetworkAddressHandle addr)
	{
		if (addr.IsInvalid) throw new Exception("Invalid handle (GNetworkAddressHandle)");
		return GNetworkAddressHandleExterns.g_network_address_get_port(addr);
	}

/// <summary>
/// <para>
/// Gets @addr&apos;s scheme
/// </para>
/// </summary>

/// <param name="addr">
/// a #GNetworkAddress
/// </param>
/// <return>
/// @addr&apos;s scheme (%NULL if not built from URI)
/// </return>

	public static string GetScheme(this MentorLake.Gio.GNetworkAddressHandle addr)
	{
		if (addr.IsInvalid) throw new Exception("Invalid handle (GNetworkAddressHandle)");
		return GNetworkAddressHandleExterns.g_network_address_get_scheme(addr);
	}

}

internal class GNetworkAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))]
	internal static extern MentorLake.Gio.GNetworkAddressHandle g_network_address_new(string hostname, ushort port);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))]
	internal static extern MentorLake.Gio.GNetworkAddressHandle g_network_address_new_loopback(ushort port);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_network_address_get_hostname([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))] MentorLake.Gio.GNetworkAddressHandle addr);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_network_address_get_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))] MentorLake.Gio.GNetworkAddressHandle addr);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_network_address_get_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkAddressHandle>))] MentorLake.Gio.GNetworkAddressHandle addr);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))]
	internal static extern MentorLake.Gio.GSocketConnectableHandle g_network_address_parse(string host_and_port, ushort default_port, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))]
	internal static extern MentorLake.Gio.GSocketConnectableHandle g_network_address_parse_uri(string uri, ushort default_port, out MentorLake.GLib.GErrorHandle error);

}
