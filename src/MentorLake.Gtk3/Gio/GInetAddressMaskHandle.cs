namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GInetAddressMask` represents a range of IPv4 or IPv6 addresses
/// described by a base address and a length indicating how many bits
/// of the base address are relevant for matching purposes. These are
/// often given in string form. For example, `10.0.0.0/8`, or `fe80::/10`.
/// </para>
/// </summary>

public class GInetAddressMaskHandle : GObjectHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Creates a new #GInetAddressMask representing all addresses whose
/// first @length bits match @addr.
/// </para>
/// </summary>

/// <param name="addr">
/// a #GInetAddress
/// </param>
/// <param name="length">
/// number of bits of @addr to use
/// </param>
/// <return>
/// a new #GInetAddressMask, or %NULL on error
/// </return>

	public static MentorLake.Gio.GInetAddressMaskHandle New(MentorLake.Gio.GInetAddressHandle addr, uint length)
	{
		var externCallResult = GInetAddressMaskHandleExterns.g_inet_address_mask_new(addr, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses @mask_string as an IP address and (optional) length, and
/// creates a new #GInetAddressMask. The length, if present, is
/// delimited by a "/". If it is not present, then the length is
/// assumed to be the full length of the address.
/// </para>
/// </summary>

/// <param name="mask_string">
/// an IP address or address/length string
/// </param>
/// <return>
/// a new #GInetAddressMask corresponding to @string, or %NULL
/// on error.
/// </return>

	public static MentorLake.Gio.GInetAddressMaskHandle NewFromString(string mask_string)
	{
		var externCallResult = GInetAddressMaskHandleExterns.g_inet_address_mask_new_from_string(mask_string, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GInetAddressMaskHandleExtensions
{
/// <summary>
/// <para>
/// Tests if @mask and @mask2 are the same mask.
/// </para>
/// </summary>

/// <param name="mask">
/// a #GInetAddressMask
/// </param>
/// <param name="mask2">
/// another #GInetAddressMask
/// </param>
/// <return>
/// whether @mask and @mask2 are the same mask
/// </return>

	public static bool Equal(this MentorLake.Gio.GInetAddressMaskHandle mask, MentorLake.Gio.GInetAddressMaskHandle mask2)
	{
		if (mask.IsInvalid) throw new Exception("Invalid handle (GInetAddressMaskHandle)");
		return GInetAddressMaskHandleExterns.g_inet_address_mask_equal(mask, mask2);
	}

/// <summary>
/// <para>
/// Gets @mask's base address
/// </para>
/// </summary>

/// <param name="mask">
/// a #GInetAddressMask
/// </param>
/// <return>
/// @mask's base address
/// </return>

	public static MentorLake.Gio.GInetAddressHandle GetAddress(this MentorLake.Gio.GInetAddressMaskHandle mask)
	{
		if (mask.IsInvalid) throw new Exception("Invalid handle (GInetAddressMaskHandle)");
		return GInetAddressMaskHandleExterns.g_inet_address_mask_get_address(mask);
	}

/// <summary>
/// <para>
/// Gets the #GSocketFamily of @mask's address
/// </para>
/// </summary>

/// <param name="mask">
/// a #GInetAddressMask
/// </param>
/// <return>
/// the #GSocketFamily of @mask's address
/// </return>

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GInetAddressMaskHandle mask)
	{
		if (mask.IsInvalid) throw new Exception("Invalid handle (GInetAddressMaskHandle)");
		return GInetAddressMaskHandleExterns.g_inet_address_mask_get_family(mask);
	}

/// <summary>
/// <para>
/// Gets @mask's length
/// </para>
/// </summary>

/// <param name="mask">
/// a #GInetAddressMask
/// </param>
/// <return>
/// @mask's length
/// </return>

	public static uint GetLength(this MentorLake.Gio.GInetAddressMaskHandle mask)
	{
		if (mask.IsInvalid) throw new Exception("Invalid handle (GInetAddressMaskHandle)");
		return GInetAddressMaskHandleExterns.g_inet_address_mask_get_length(mask);
	}

/// <summary>
/// <para>
/// Tests if @address falls within the range described by @mask.
/// </para>
/// </summary>

/// <param name="mask">
/// a #GInetAddressMask
/// </param>
/// <param name="address">
/// a #GInetAddress
/// </param>
/// <return>
/// whether @address falls within the range described by
/// @mask.
/// </return>

	public static bool Matches(this MentorLake.Gio.GInetAddressMaskHandle mask, MentorLake.Gio.GInetAddressHandle address)
	{
		if (mask.IsInvalid) throw new Exception("Invalid handle (GInetAddressMaskHandle)");
		return GInetAddressMaskHandleExterns.g_inet_address_mask_matches(mask, address);
	}

/// <summary>
/// <para>
/// Converts @mask back to its corresponding string form.
/// </para>
/// </summary>

/// <param name="mask">
/// a #GInetAddressMask
/// </param>
/// <return>
/// a string corresponding to @mask.
/// </return>

	public static string ToString(this MentorLake.Gio.GInetAddressMaskHandle mask)
	{
		if (mask.IsInvalid) throw new Exception("Invalid handle (GInetAddressMaskHandle)");
		return GInetAddressMaskHandleExterns.g_inet_address_mask_to_string(mask);
	}

}

internal class GInetAddressMaskHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))]
	internal static extern MentorLake.Gio.GInetAddressMaskHandle g_inet_address_mask_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle addr, uint length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))]
	internal static extern MentorLake.Gio.GInetAddressMaskHandle g_inet_address_mask_new_from_string(string mask_string, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_mask_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask2);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))]
	internal static extern MentorLake.Gio.GInetAddressHandle g_inet_address_mask_get_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketFamily g_inet_address_mask_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_inet_address_mask_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_mask_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_inet_address_mask_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask);

}
