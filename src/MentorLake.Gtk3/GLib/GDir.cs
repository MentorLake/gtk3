namespace MentorLake.GLib;

/// <summary>
/// <para>
/// An opaque structure representing an opened directory.
/// </para>
/// </summary>

public class GDirHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Opens a directory for reading. The names of the files in the
/// directory can then be retrieved using g_dir_read_name().  Note
/// that the ordering is not defined.
/// </para>
/// </summary>

/// <param name="path">
/// the path to the directory you are interested in. On Unix
///         in the on-disk encoding. On Windows in UTF-8
/// </param>
/// <param name="flags">
/// Currently must be set to 0. Reserved for future use.
/// </param>
/// <return>
/// a newly allocated #GDir on success, %NULL on failure.
///   If non-%NULL, you must free the result with g_dir_close()
///   when you are finished with it.
/// </return>

	public static MentorLake.GLib.GDirHandle Open(string path, uint flags)
	{
		var externCallResult = GDirExterns.g_dir_open(path, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GDirExtensions
{
/// <summary>
/// <para>
/// Closes the directory immediately and decrements the reference count.
/// </para>
/// <para>
/// Once the reference count reaches zero, the `GDir` structure itself will be
/// freed. Prior to GLib 2.80, `GDir` was not reference counted.
/// </para>
/// <para>
/// It is an error to call any of the `GDir` methods other than
/// [method@GLib.Dir.ref] and [method@GLib.Dir.unref] on a `GDir` after calling
/// [method@GLib.Dir.close] on it.
/// </para>
/// </summary>

/// <param name="dir">
/// a #GDir* created by g_dir_open()
/// </param>

	public static void Close(this MentorLake.GLib.GDirHandle dir)
	{
		if (dir.IsInvalid) throw new Exception("Invalid handle (GDir)");
		GDirExterns.g_dir_close(dir);
	}

/// <summary>
/// <para>
/// Retrieves the name of another entry in the directory, or %NULL.
/// The order of entries returned from this function is not defined,
/// and may vary by file system or other operating-system dependent
/// factors.
/// </para>
/// <para>
/// %NULL may also be returned in case of errors. On Unix, you can
/// check `errno` to find out if %NULL was returned because of an error.
/// </para>
/// <para>
/// On Unix, the &apos;.&apos; and &apos;..&apos; entries are omitted, and the returned
/// name is in the on-disk encoding.
/// </para>
/// <para>
/// On Windows, as is true of all GLib functions which operate on
/// filenames, the returned name is in UTF-8.
/// </para>
/// </summary>

/// <param name="dir">
/// a #GDir* created by g_dir_open()
/// </param>
/// <return>
/// The entry&apos;s name or %NULL if there are no
///   more entries. The return value is owned by GLib and
///   must not be modified or freed.
/// </return>

	public static string ReadName(this MentorLake.GLib.GDirHandle dir)
	{
		if (dir.IsInvalid) throw new Exception("Invalid handle (GDir)");
		return GDirExterns.g_dir_read_name(dir);
	}

/// <summary>
/// <para>
/// Increment the reference count of `dir`.
/// </para>
/// </summary>

/// <param name="dir">
/// a `GDir`
/// </param>
/// <return>
/// the same pointer as `dir`
/// </return>

	public static MentorLake.GLib.GDirHandle Ref(this MentorLake.GLib.GDirHandle dir)
	{
		if (dir.IsInvalid) throw new Exception("Invalid handle (GDir)");
		return GDirExterns.g_dir_ref(dir);
	}

/// <summary>
/// <para>
/// Resets the given directory. The next call to g_dir_read_name()
/// will return the first entry again.
/// </para>
/// </summary>

/// <param name="dir">
/// a #GDir* created by g_dir_open()
/// </param>

	public static void Rewind(this MentorLake.GLib.GDirHandle dir)
	{
		if (dir.IsInvalid) throw new Exception("Invalid handle (GDir)");
		GDirExterns.g_dir_rewind(dir);
	}

/// <summary>
/// <para>
/// Decrements the reference count of `dir`.
/// </para>
/// <para>
/// Once the reference count reaches zero, the directory will be closed and all
/// resources associated with it will be freed. If [method@GLib.Dir.close] is
/// called when the reference count is greater than zero, the directory is closed
/// but the `GDir` structure will not be freed until its reference count reaches
/// zero.
/// </para>
/// <para>
/// It is an error to call any of the `GDir` methods other than
/// [method@GLib.Dir.ref] and [method@GLib.Dir.unref] on a `GDir` after calling
/// [method@GLib.Dir.close] on it.
/// </para>
/// </summary>

/// <param name="dir">
/// a `GDir`
/// </param>

	public static void Unref(this MentorLake.GLib.GDirHandle dir)
	{
		if (dir.IsInvalid) throw new Exception("Invalid handle (GDir)");
		GDirExterns.g_dir_unref(dir);
	}


	public static GDir Dereference(this GDirHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDir>(x.DangerousGetHandle());
}
internal class GDirExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))]
	internal static extern MentorLake.GLib.GDirHandle g_dir_open(string path, uint flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dir_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dir_read_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))]
	internal static extern MentorLake.GLib.GDirHandle g_dir_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dir_rewind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dir_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dir_make_tmp(string tmpl, out MentorLake.GLib.GErrorHandle error);

}

/// <summary>
/// <para>
/// An opaque structure representing an opened directory.
/// </para>
/// </summary>

public struct GDir
{
/// <summary>
/// <para>
/// Creates a subdirectory in the preferred directory for temporary
/// files (as returned by g_get_tmp_dir()).
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding containing
/// a sequence of six &apos;X&apos; characters, as the parameter to g_mkstemp().
/// However, unlike these functions, the template should only be a
/// basename, no directory components are allowed. If template is
/// %NULL, a default template is used.
/// </para>
/// <para>
/// Note that in contrast to g_mkdtemp() (and mkdtemp()) @tmpl is not
/// modified, and might thus be a read-only literal string.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for directory name,
///   as in g_mkdtemp(), basename only, or %NULL for a default template
/// </param>
/// <return>
/// The actual name used. This string
///   should be freed with g_free() when not needed any longer and is
///   is in the GLib file name encoding. In case of errors, %NULL is
///   returned and @error will be set.
/// </return>

	public static string MakeTmp(string tmpl)
	{
		var externCallResult = GDirExterns.g_dir_make_tmp(tmpl, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
