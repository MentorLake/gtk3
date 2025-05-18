namespace MentorLake.Gio;

public class GInetAddressHandle : GObjectHandle
{
	public static MentorLake.Gio.GInetAddressHandle NewAny(MentorLake.Gio.GSocketFamily family)
	{
		return GInetAddressHandleExterns.g_inet_address_new_any(family);
	}

	public static MentorLake.Gio.GInetAddressHandle NewFromBytes(byte[] bytes, MentorLake.Gio.GSocketFamily family)
	{
		return GInetAddressHandleExterns.g_inet_address_new_from_bytes(bytes, family);
	}

	public static MentorLake.Gio.GInetAddressHandle NewFromString(string @string)
	{
		return GInetAddressHandleExterns.g_inet_address_new_from_string(@string);
	}

	public static MentorLake.Gio.GInetAddressHandle NewLoopback(MentorLake.Gio.GSocketFamily family)
	{
		return GInetAddressHandleExterns.g_inet_address_new_loopback(family);
	}

}

public static class GInetAddressHandleExtensions
{
	public static bool Equal(this MentorLake.Gio.GInetAddressHandle address, MentorLake.Gio.GInetAddressHandle other_address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_equal(address, other_address);
	}

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_family(address);
	}

	public static bool GetIsAny(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_any(address);
	}

	public static bool GetIsLinkLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_link_local(address);
	}

	public static bool GetIsLoopback(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_loopback(address);
	}

	public static bool GetIsMcGlobal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_global(address);
	}

	public static bool GetIsMcLinkLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_link_local(address);
	}

	public static bool GetIsMcNodeLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_node_local(address);
	}

	public static bool GetIsMcOrgLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_org_local(address);
	}

	public static bool GetIsMcSiteLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_mc_site_local(address);
	}

	public static bool GetIsMulticast(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_multicast(address);
	}

	public static bool GetIsSiteLocal(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_is_site_local(address);
	}

	public static UIntPtr GetNativeSize(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_get_native_size(address);
	}

	public static byte ToBytes(this MentorLake.Gio.GInetAddressHandle address)
	{
		if (address.IsInvalid) throw new Exception("Invalid handle (GInetAddressHandle)");
		return GInetAddressHandleExterns.g_inet_address_to_bytes(address);
	}

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
