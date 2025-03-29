namespace MentorLake.Gio;

public class GUnixSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
	public static MentorLake.Gio.GUnixSocketAddressHandle New(string path)
	{
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_new(path);
	}

	public static MentorLake.Gio.GUnixSocketAddressHandle NewAbstract(char[] path, int path_len)
	{
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_new_abstract(path, path_len);
	}

	public static MentorLake.Gio.GUnixSocketAddressHandle NewWithType(char[] path, int path_len, MentorLake.Gio.GUnixSocketAddressType type)
	{
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_new_with_type(path, path_len, type);
	}

	public static bool AbstractNamesSupported()
	{
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_abstract_names_supported();
	}

}

public static class GUnixSocketAddressHandleExtensions
{
	public static MentorLake.Gio.GUnixSocketAddressType GetAddressType(this MentorLake.Gio.GUnixSocketAddressHandle address)
	{
		if (address.IsInvalid || address.IsClosed) throw new Exception("Invalid or closed handle (GUnixSocketAddressHandle)");
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_get_address_type(address);
	}

	public static bool GetIsAbstract(this MentorLake.Gio.GUnixSocketAddressHandle address)
	{
		if (address.IsInvalid || address.IsClosed) throw new Exception("Invalid or closed handle (GUnixSocketAddressHandle)");
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_get_is_abstract(address);
	}

	public static string GetPath(this MentorLake.Gio.GUnixSocketAddressHandle address)
	{
		if (address.IsInvalid || address.IsClosed) throw new Exception("Invalid or closed handle (GUnixSocketAddressHandle)");
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_get_path(address);
	}

	public static UIntPtr GetPathLen(this MentorLake.Gio.GUnixSocketAddressHandle address)
	{
		if (address.IsInvalid || address.IsClosed) throw new Exception("Invalid or closed handle (GUnixSocketAddressHandle)");
		return GUnixSocketAddressHandleExterns.g_unix_socket_address_get_path_len(address);
	}

}

internal class GUnixSocketAddressHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixSocketAddressHandle g_unix_socket_address_new(string path);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixSocketAddressHandle g_unix_socket_address_new_abstract(char[] path, int path_len);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixSocketAddressHandle g_unix_socket_address_new_with_type(char[] path, int path_len, MentorLake.Gio.GUnixSocketAddressType type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixSocketAddressType g_unix_socket_address_get_address_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))] MentorLake.Gio.GUnixSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_socket_address_get_is_abstract([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))] MentorLake.Gio.GUnixSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_socket_address_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))] MentorLake.Gio.GUnixSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_unix_socket_address_get_path_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixSocketAddressHandle>))] MentorLake.Gio.GUnixSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_socket_address_abstract_names_supported();

}
