namespace MentorLake.Gtk3.Gio;

public class GInetAddressHandle : GObjectHandle
{
	public static GInetAddressHandle NewAny(GSocketFamily family)
	{
		return GInetAddressExterns.g_inet_address_new_any(family);
	}

	public static GInetAddressHandle NewFromBytes(byte[] bytes, GSocketFamily family)
	{
		return GInetAddressExterns.g_inet_address_new_from_bytes(bytes, family);
	}

	public static GInetAddressHandle NewFromString(string @string)
	{
		return GInetAddressExterns.g_inet_address_new_from_string(@string);
	}

	public static GInetAddressHandle NewLoopback(GSocketFamily family)
	{
		return GInetAddressExterns.g_inet_address_new_loopback(family);
	}

}

public static class GInetAddressHandleExtensions
{
	public static bool Equal(this GInetAddressHandle address, GInetAddressHandle other_address)
	{
		return GInetAddressExterns.g_inet_address_equal(address, other_address);
	}

	public static GSocketFamily GetFamily(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_family(address);
	}

	public static bool GetIsAny(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_any(address);
	}

	public static bool GetIsLinkLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_link_local(address);
	}

	public static bool GetIsLoopback(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_loopback(address);
	}

	public static bool GetIsMcGlobal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_global(address);
	}

	public static bool GetIsMcLinkLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_link_local(address);
	}

	public static bool GetIsMcNodeLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_node_local(address);
	}

	public static bool GetIsMcOrgLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_org_local(address);
	}

	public static bool GetIsMcSiteLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_mc_site_local(address);
	}

	public static bool GetIsMulticast(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_multicast(address);
	}

	public static bool GetIsSiteLocal(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_is_site_local(address);
	}

	public static UIntPtr GetNativeSize(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_get_native_size(address);
	}

	public static IntPtr ToBytes(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_to_bytes(address);
	}

	public static string ToString(this GInetAddressHandle address)
	{
		return GInetAddressExterns.g_inet_address_to_string(address);
	}

}

internal class GInetAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_new_any(GSocketFamily family);

	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_new_from_bytes(byte[] bytes, GSocketFamily family);

	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_new_from_string(string @string);

	[DllImport(Libraries.Gio)]
	internal static extern GInetAddressHandle g_inet_address_new_loopback(GSocketFamily family);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_equal(GInetAddressHandle address, GInetAddressHandle other_address);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketFamily g_inet_address_get_family(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_any(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_link_local(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_loopback(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_global(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_link_local(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_node_local(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_org_local(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_mc_site_local(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_multicast(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_inet_address_get_is_site_local(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_inet_address_get_native_size(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_inet_address_to_bytes(GInetAddressHandle address);

	[DllImport(Libraries.Gio)]
	internal static extern string g_inet_address_to_string(GInetAddressHandle address);

}
