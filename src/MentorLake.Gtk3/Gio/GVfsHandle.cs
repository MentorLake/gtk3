namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Entry point for using GIO functionality.
/// </para>
/// </summary>

public class GVfsHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Gets the default #GVfs for the system.
/// </para>
/// </summary>

/// <return>
/// a #GVfs, which will be the local
///     file system #GVfs if no other implementation is available.
/// </return>

	public static MentorLake.Gio.GVfsHandle GetDefault()
	{
		return GVfsHandleExterns.g_vfs_get_default();
	}

/// <summary>
/// <para>
/// Gets the local #GVfs for the system.
/// </para>
/// </summary>

/// <return>
/// a #GVfs.
/// </return>

	public static MentorLake.Gio.GVfsHandle GetLocal()
	{
		return GVfsHandleExterns.g_vfs_get_local();
	}

}

public static class GVfsHandleExtensions
{
/// <summary>
/// <para>
/// Gets a #GFile for @path.
/// </para>
/// </summary>

/// <param name="vfs">
/// a #GVfs.
/// </param>
/// <param name="path">
/// a string containing a VFS path.
/// </param>
/// <return>
/// a #GFile.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle GetFileForPath(this MentorLake.Gio.GVfsHandle vfs, string path)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_get_file_for_path(vfs, path);
	}

/// <summary>
/// <para>
/// Gets a #GFile for @uri.
/// </para>
/// <para>
/// This operation never fails, but the returned object
/// might not support any I/O operation if the URI
/// is malformed or if the URI scheme is not supported.
/// </para>
/// </summary>

/// <param name="vfs">
/// a#GVfs.
/// </param>
/// <param name="uri">
/// a string containing a URI
/// </param>
/// <return>
/// a #GFile.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle GetFileForUri(this MentorLake.Gio.GVfsHandle vfs, string uri)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_get_file_for_uri(vfs, uri);
	}

/// <summary>
/// <para>
/// Gets a list of URI schemes supported by @vfs.
/// </para>
/// </summary>

/// <param name="vfs">
/// a #GVfs.
/// </param>
/// <return>
/// a %NULL-terminated array of strings.
///     The returned array belongs to GIO and must
///     not be freed or modified.
/// </return>

	public static string[] GetSupportedUriSchemes(this MentorLake.Gio.GVfsHandle vfs)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_get_supported_uri_schemes(vfs);
	}

/// <summary>
/// <para>
/// Checks if the VFS is active.
/// </para>
/// </summary>

/// <param name="vfs">
/// a #GVfs.
/// </param>
/// <return>
/// %TRUE if construction of the @vfs was successful
///     and it is now active.
/// </return>

	public static bool IsActive(this MentorLake.Gio.GVfsHandle vfs)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_is_active(vfs);
	}

/// <summary>
/// <para>
/// This operation never fails, but the returned object might
/// not support any I/O operations if the @parse_name cannot
/// be parsed by the #GVfs module.
/// </para>
/// </summary>

/// <param name="vfs">
/// a #GVfs.
/// </param>
/// <param name="parse_name">
/// a string to be parsed by the VFS module.
/// </param>
/// <return>
/// a #GFile for the given @parse_name.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle ParseName(this MentorLake.Gio.GVfsHandle vfs, string parse_name)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_parse_name(vfs, parse_name);
	}

/// <summary>
/// <para>
/// Registers @uri_func and @parse_name_func as the #GFile URI and parse name
/// lookup functions for URIs with a scheme matching @scheme.
/// Note that @scheme is registered only within the running application, as
/// opposed to desktop-wide as it happens with GVfs backends.
/// </para>
/// <para>
/// When a #GFile is requested with an URI containing @scheme (e.g. through
/// g_file_new_for_uri()), @uri_func will be called to allow a custom
/// constructor. The implementation of @uri_func should not be blocking, and
/// must not call g_vfs_register_uri_scheme() or g_vfs_unregister_uri_scheme().
/// </para>
/// <para>
/// When g_file_parse_name() is called with a parse name obtained from such file,
/// @parse_name_func will be called to allow the #GFile to be created again. In
/// that case, it&apos;s responsibility of @parse_name_func to make sure the parse
/// name matches what the custom #GFile implementation returned when
/// g_file_get_parse_name() was previously called. The implementation of
/// @parse_name_func should not be blocking, and must not call
/// g_vfs_register_uri_scheme() or g_vfs_unregister_uri_scheme().
/// </para>
/// <para>
/// It&apos;s an error to call this function twice with the same scheme. To unregister
/// a custom URI scheme, use g_vfs_unregister_uri_scheme().
/// </para>
/// </summary>

/// <param name="vfs">
/// a #GVfs
/// </param>
/// <param name="scheme">
/// an URI scheme, e.g. &quot;http&quot;
/// </param>
/// <param name="uri_func">
/// a #GVfsFileLookupFunc
/// </param>
/// <param name="uri_data">
/// custom data passed to be passed to @uri_func, or %NULL
/// </param>
/// <param name="uri_destroy">
/// function to be called when unregistering the
///     URI scheme, or when @vfs is disposed, to free the resources used
///     by the URI lookup function
/// </param>
/// <param name="parse_name_func">
/// a #GVfsFileLookupFunc
/// </param>
/// <param name="parse_name_data">
/// custom data passed to be passed to
///     @parse_name_func, or %NULL
/// </param>
/// <param name="parse_name_destroy">
/// function to be called when unregistering the
///     URI scheme, or when @vfs is disposed, to free the resources used
///     by the parse name lookup function
/// </param>
/// <return>
/// %TRUE if @scheme was successfully registered, or %FALSE if a handler
///     for @scheme already exists.
/// </return>

	public static bool RegisterUriScheme(this MentorLake.Gio.GVfsHandle vfs, string scheme, MentorLake.Gio.GVfsFileLookupFunc uri_func, IntPtr uri_data, MentorLake.GLib.GDestroyNotify uri_destroy, MentorLake.Gio.GVfsFileLookupFunc parse_name_func, IntPtr parse_name_data, MentorLake.GLib.GDestroyNotify parse_name_destroy)
	{
		if (vfs.IsInvalid) throw new Exception("Invalid handle (GVfsHandle)");
		return GVfsHandleExterns.g_vfs_register_uri_scheme(vfs, scheme, uri_func, uri_data, uri_destroy, parse_name_func, parse_name_data, parse_name_destroy);
	}

/// <summary>
/// <para>
/// Unregisters the URI handler for @scheme previously registered with
/// g_vfs_register_uri_scheme().
/// </para>
/// </summary>

/// <param name="vfs">
/// a #GVfs
/// </param>
/// <param name="scheme">
/// an URI scheme, e.g. &quot;http&quot;
/// </param>
/// <return>
/// %TRUE if @scheme was successfully unregistered, or %FALSE if a
///     handler for @scheme does not exist.
/// </return>

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
