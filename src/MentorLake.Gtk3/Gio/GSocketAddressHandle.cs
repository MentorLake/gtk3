namespace MentorLake.Gio;

public class GSocketAddressHandle : GObjectHandle, GSocketConnectableHandle
{
	public static MentorLake.Gio.GSocketAddressHandle NewFromNative(IntPtr native, UIntPtr len)
	{
		return GSocketAddressHandleExterns.g_socket_address_new_from_native(native, len);
	}

}

public static class GSocketAddressHandleExtensions
{
	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GSocketAddressHandle address)
	{
		if (address.IsInvalid || address.IsClosed) throw new Exception("Invalid or closed handle (GSocketAddressHandle)");
		return GSocketAddressHandleExterns.g_socket_address_get_family(address);
	}

	public static UIntPtr GetNativeSize(this MentorLake.Gio.GSocketAddressHandle address)
	{
		if (address.IsInvalid || address.IsClosed) throw new Exception("Invalid or closed handle (GSocketAddressHandle)");
		return GSocketAddressHandleExterns.g_socket_address_get_native_size(address);
	}

	public static bool ToNative(this MentorLake.Gio.GSocketAddressHandle address, IntPtr dest, UIntPtr destlen)
	{
		if (address.IsInvalid || address.IsClosed) throw new Exception("Invalid or closed handle (GSocketAddressHandle)");
		var externCallResult = GSocketAddressHandleExterns.g_socket_address_to_native(address, dest, destlen, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GSocketAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_address_new_from_native(IntPtr native, UIntPtr len);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketFamily g_socket_address_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_socket_address_get_native_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_address_to_native([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, IntPtr dest, UIntPtr destlen, out MentorLake.GLib.GErrorHandle error);

}
