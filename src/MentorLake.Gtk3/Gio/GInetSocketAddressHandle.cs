namespace MentorLake.Gio;

/// <summary>
/// <para>
/// An IPv4 or IPv6 socket address. That is, the combination of a
/// [class@Gio.InetAddress] and a port number.
/// </para>
/// <para>
/// In UNIX terms, `GInetSocketAddress` corresponds to a
/// <see href="man:sockaddr(3type">struct sockaddr_in` or `struct sockaddr_in6</see>).
/// </para>
/// </summary>

public class GInetSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
/// <summary>
/// <para>
/// Creates a new #GInetSocketAddress for @address and @port.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <param name="port">
/// a port number
/// </param>
/// <return>
/// a new #GInetSocketAddress
/// </return>

	public static MentorLake.Gio.GInetSocketAddressHandle New(MentorLake.Gio.GInetAddressHandle address, ushort port)
	{
		return GInetSocketAddressHandleExterns.g_inet_socket_address_new(address, port);
	}

/// <summary>
/// <para>
/// Creates a new #GInetSocketAddress for @address and @port.
/// </para>
/// <para>
/// If @address is an IPv6 address, it can also contain a scope ID
/// (separated from the address by a `%`).
/// </para>
/// </summary>

/// <param name="address">
/// the string form of an IP address
/// </param>
/// <param name="port">
/// a port number
/// </param>
/// <return>
/// a new #GInetSocketAddress,
/// or %NULL if @address cannot be parsed.
/// </return>

	public static MentorLake.Gio.GInetSocketAddressHandle NewFromString(string address, uint port)
	{
		return GInetSocketAddressHandleExterns.g_inet_socket_address_new_from_string(address, port);
	}

}

public static class GInetSocketAddressHandleExtensions
{
/// <summary>
/// <para>
/// Gets @address's #GInetAddress.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetSocketAddress
/// </param>
/// <return>
/// the #GInetAddress for @address, which must be
/// g_object_ref()'d if it will be stored
/// </return>

	public static MentorLake.Gio.GInetAddressHandle GetAddress(this MentorLake.Gio.GInetSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetSocketAddressHandle)");
		return GInetSocketAddressHandleExterns.g_inet_socket_address_get_address(address);
	}

/// <summary>
/// <para>
/// Gets the `sin6_flowinfo` field from @address,
/// which must be an IPv6 address.
/// </para>
/// </summary>

/// <param name="address">
/// a %G_SOCKET_FAMILY_IPV6 #GInetSocketAddress
/// </param>
/// <return>
/// the flowinfo field
/// </return>

	public static uint GetFlowinfo(this MentorLake.Gio.GInetSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetSocketAddressHandle)");
		return GInetSocketAddressHandleExterns.g_inet_socket_address_get_flowinfo(address);
	}

/// <summary>
/// <para>
/// Gets @address's port.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetSocketAddress
/// </param>
/// <return>
/// the port for @address
/// </return>

	public static ushort GetPort(this MentorLake.Gio.GInetSocketAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetSocketAddressHandle)");
		return GInetSocketAddressHandleExterns.g_inet_socket_address_get_port(address);
	}

/// <summary>
/// <para>
/// Gets the `sin6_scope_id` field from @address,
/// which must be an IPv6 address.
/// </para>
/// </summary>

/// <param name="address">
/// a %G_SOCKET_FAMILY_IPV6 #GInetAddress
/// </param>
/// <return>
/// the scope id field
/// </return>

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
