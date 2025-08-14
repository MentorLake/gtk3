namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GInetAddress` represents an IPv4 or IPv6 internet address. Use
/// [method@Gio.Resolver.lookup_by_name] or
/// [method@Gio.Resolver.lookup_by_name_async] to look up the `GInetAddress` for
/// a hostname. Use [method@Gio.Resolver.lookup_by_address] or
/// [method@Gio.Resolver.lookup_by_address_async] to look up the hostname for a
/// `GInetAddress`.
/// </para>
/// <para>
/// To actually connect to a remote host, you will need a
/// [class@Gio.InetSocketAddress] (which includes a `GInetAddress` as well as a
/// port number).
/// </para>
/// </summary>

public class GInetAddressHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a #GInetAddress for the "any" address (unassigned/"don't
/// care") for @family.
/// </para>
/// </summary>

/// <param name="family">
/// the address family
/// </param>
/// <return>
/// a new #GInetAddress corresponding to the "any" address
/// for @family.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GInetAddressHandle NewAny(MentorLake.Gio.GSocketFamily family)
	{
		return GInetAddressHandleExterns.g_inet_address_new_any(family);
	}

/// <summary>
/// <para>
/// Creates a new #GInetAddress from the given @family and @bytes.
/// @bytes should be 4 bytes for %G_SOCKET_FAMILY_IPV4 and 16 bytes for
/// %G_SOCKET_FAMILY_IPV6.
/// </para>
/// </summary>

/// <param name="bytes">
/// raw address data
/// </param>
/// <param name="family">
/// the address family of @bytes
/// </param>
/// <return>
/// a new #GInetAddress corresponding to @family and @bytes.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GInetAddressHandle NewFromBytes(byte[] bytes, MentorLake.Gio.GSocketFamily family)
	{
		return GInetAddressHandleExterns.g_inet_address_new_from_bytes(bytes, family);
	}

/// <summary>
/// <para>
/// Parses @string as an IP address and creates a new #GInetAddress.
/// </para>
/// </summary>

/// <param name="@string">
/// a string representation of an IP address
/// </param>
/// <return>
/// a new #GInetAddress corresponding
/// to @string, or %NULL if @string could not be parsed.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GInetAddressHandle NewFromString(string @string)
	{
		return GInetAddressHandleExterns.g_inet_address_new_from_string(@string);
	}

/// <summary>
/// <para>
/// Creates a #GInetAddress for the loopback address for @family.
/// </para>
/// </summary>

/// <param name="family">
/// the address family
/// </param>
/// <return>
/// a new #GInetAddress corresponding to the loopback address
/// for @family.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GInetAddressHandle NewLoopback(MentorLake.Gio.GSocketFamily family)
	{
		return GInetAddressHandleExterns.g_inet_address_new_loopback(family);
	}

}

public static class GInetAddressHandleExtensions
{
/// <summary>
/// <para>
/// Checks if two #GInetAddress instances are equal, e.g. the same address.
/// </para>
/// </summary>

/// <param name="address">
/// A #GInetAddress.
/// </param>
/// <param name="other_address">
/// Another #GInetAddress.
/// </param>
/// <return>
/// %TRUE if @address and @other_address are equal, %FALSE otherwise.
/// </return>

	public static bool Equal(this MentorLake.Gio.GInetAddressHandle address, MentorLake.Gio.GInetAddressHandle other_address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_equal(address, other_address);
	}

/// <summary>
/// <para>
/// Gets @address's family
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// @address's family
/// </return>

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_family(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is the "any" address for its family.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is the "any" address for its family.
/// </return>

	public static bool GetIsAny(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_any(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is a link-local address (that is, if it
/// identifies a host on a local network that is not connected to the
/// Internet).
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is a link-local address.
/// </return>

	public static bool GetIsLinkLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_link_local(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is the loopback address for its family.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is the loopback address for its family.
/// </return>

	public static bool GetIsLoopback(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_loopback(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is a global multicast address.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is a global multicast address.
/// </return>

	public static bool GetIsMcGlobal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_global(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is a link-local multicast address.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is a link-local multicast address.
/// </return>

	public static bool GetIsMcLinkLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_link_local(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is a node-local multicast address.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is a node-local multicast address.
/// </return>

	public static bool GetIsMcNodeLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_node_local(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is an organization-local multicast address.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is an organization-local multicast address.
/// </return>

	public static bool GetIsMcOrgLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_org_local(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is a site-local multicast address.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is a site-local multicast address.
/// </return>

	public static bool GetIsMcSiteLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_site_local(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is a multicast address.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is a multicast address.
/// </return>

	public static bool GetIsMulticast(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_multicast(address);
	}

/// <summary>
/// <para>
/// Tests whether @address is a site-local address such as 10.0.0.1
/// (that is, the address identifies a host on a local network that can
/// not be reached directly from the Internet, but which may have
/// outgoing Internet connectivity via a NAT or firewall).
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// %TRUE if @address is a site-local address.
/// </return>

	public static bool GetIsSiteLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_site_local(address);
	}

/// <summary>
/// <para>
/// Gets the size of the native raw binary address for @address. This
/// is the size of the data that you get from g_inet_address_to_bytes().
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// the number of bytes used for the native version of @address.
/// </return>

	public static UIntPtr GetNativeSize(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_native_size(address);
	}

/// <summary>
/// <para>
/// Gets the raw binary address data from @address.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// a pointer to an internal array of the bytes in @address,
/// which should not be modified, stored, or freed. The size of this
/// array can be gotten with g_inet_address_get_native_size().
/// </return>

	public static byte ToBytes(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_to_bytes(address);
	}

/// <summary>
/// <para>
/// Converts @address to string form.
/// </para>
/// </summary>

/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// a representation of @address as a string, which should be
/// freed after use.
/// </return>

	public static string ToString(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_to_string(address);
	}

}

internal class GInetAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))]
	internal static extern MentorLake.Gio.GInetAddressHandle g_inet_address_new_any(MentorLake.Gio.GSocketFamily family);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))]
	internal static extern MentorLake.Gio.GInetAddressHandle g_inet_address_new_from_bytes(byte[] bytes, MentorLake.Gio.GSocketFamily family);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))]
	internal static extern MentorLake.Gio.GInetAddressHandle g_inet_address_new_from_string(string @string);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))]
	internal static extern MentorLake.Gio.GInetAddressHandle g_inet_address_new_loopback(MentorLake.Gio.GSocketFamily family);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle other_address);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketFamily g_inet_address_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_any([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_link_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_loopback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_mc_global([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_mc_link_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_mc_node_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_mc_org_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_mc_site_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_multicast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_get_is_site_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_inet_address_get_native_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern byte g_inet_address_to_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_inet_address_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

}
