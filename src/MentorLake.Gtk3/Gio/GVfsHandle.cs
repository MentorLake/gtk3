namespace MentorLake.Gio;

public class GVfsHandle : GObjectHandle
{
	public static MentorLake.Gio.GVfsHandle GetDefault()
	{
		return GVfsHandleExterns.g_vfs_get_default();
	}

	public static MentorLake.Gio.GVfsHandle GetLocal()
	{
		return GVfsHandleExterns.g_vfs_get_local();
	}

}

public static class GVfsHandleExtensions
{
	public static MentorLake.Gio.GFileHandle GetFileForPath(this MentorLake.Gio.GVfsHandle vfs, string path)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_get_file_for_path(vfs, path);
	}

	public static MentorLake.Gio.GFileHandle GetFileForUri(this MentorLake.Gio.GVfsHandle vfs, string uri)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_get_file_for_uri(vfs, uri);
	}

	public static string[] GetSupportedUriSchemes(this MentorLake.Gio.GVfsHandle vfs)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_get_supported_uri_schemes(vfs);
	}

	public static bool IsActive(this MentorLake.Gio.GVfsHandle vfs)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_is_active(vfs);
	}

	public static MentorLake.Gio.GFileHandle ParseName(this MentorLake.Gio.GVfsHandle vfs, string parse_name)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_parse_name(vfs, parse_name);
	}

	public static bool RegisterUriScheme(this MentorLake.Gio.GVfsHandle vfs, string scheme, MentorLake.Gio.GVfsFileLookupFunc uri_func, IntPtr uri_data, MentorLake.GLib.GDestroyNotify uri_destroy, MentorLake.Gio.GVfsFileLookupFunc parse_name_func, IntPtr parse_name_data, MentorLake.GLib.GDestroyNotify parse_name_destroy)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_register_uri_scheme(vfs, scheme, uri_func, uri_data, uri_destroy, parse_name_func, parse_name_data, parse_name_destroy);
	}

	public static bool UnregisterUriScheme(this MentorLake.Gio.GVfsHandle vfs, string scheme)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_unregister_uri_scheme(vfs, scheme);
	}

}

internal class GVfsHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_vfs_get_file_for_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs, string path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_vfs_get_file_for_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs, string uri);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_vfs_get_supported_uri_schemes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_vfs_is_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_vfs_parse_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs, string parse_name);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_vfs_register_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs, string scheme, MentorLake.Gio.GVfsFileLookupFunc uri_func, IntPtr uri_data, MentorLake.GLib.GDestroyNotify uri_destroy, MentorLake.Gio.GVfsFileLookupFunc parse_name_func, IntPtr parse_name_data, MentorLake.GLib.GDestroyNotify parse_name_destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_vfs_unregister_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))] MentorLake.Gio.GVfsHandle vfs, string scheme);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))]
	internal static extern MentorLake.Gio.GVfsHandle g_vfs_get_default();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVfsHandle>))]
	internal static extern MentorLake.Gio.GVfsHandle g_vfs_get_local();

}
