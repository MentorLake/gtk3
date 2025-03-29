namespace MentorLake.Gio;

public class GInetAddressMaskHandle : GObjectHandle, GInitableHandle
{
	public static MentorLake.Gio.GInetAddressMaskHandle New(MentorLake.Gio.GInetAddressHandle addr, uint length, IntPtr error)
	{
		return GInetAddressMaskHandleExterns.g_inet_address_mask_new(addr, length, error);
	}

	public static MentorLake.Gio.GInetAddressMaskHandle NewFromString(string mask_string, IntPtr error)
	{
		return GInetAddressMaskHandleExterns.g_inet_address_mask_new_from_string(mask_string, error);
	}

}

public static class GInetAddressMaskHandleExtensions
{
	public static bool Equal(this MentorLake.Gio.GInetAddressMaskHandle mask, MentorLake.Gio.GInetAddressMaskHandle mask2)
	{
		return GInetAddressMaskHandleExterns.g_inet_address_mask_equal(mask, mask2);
	}

	public static MentorLake.Gio.GInetAddressHandle GetAddress(this MentorLake.Gio.GInetAddressMaskHandle mask)
	{
		return GInetAddressMaskHandleExterns.g_inet_address_mask_get_address(mask);
	}

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GInetAddressMaskHandle mask)
	{
		return GInetAddressMaskHandleExterns.g_inet_address_mask_get_family(mask);
	}

	public static uint GetLength(this MentorLake.Gio.GInetAddressMaskHandle mask)
	{
		return GInetAddressMaskHandleExterns.g_inet_address_mask_get_length(mask);
	}

	public static bool Matches(this MentorLake.Gio.GInetAddressMaskHandle mask, MentorLake.Gio.GInetAddressHandle address)
	{
		return GInetAddressMaskHandleExterns.g_inet_address_mask_matches(mask, address);
	}

	public static string ToString(this MentorLake.Gio.GInetAddressMaskHandle mask)
	{
		return GInetAddressMaskHandleExterns.g_inet_address_mask_to_string(mask);
	}

}

internal class GInetAddressMaskHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInetAddressMaskHandle g_inet_address_mask_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle addr, uint length, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInetAddressMaskHandle g_inet_address_mask_new_from_string(string mask_string, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_inet_address_mask_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressMaskHandle>))] MentorLake.Gio.GInetAddressMaskHandle mask2);

	[DllImport(GioLibrary.Name)]
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
