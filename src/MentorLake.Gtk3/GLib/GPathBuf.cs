namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GPathBuf` is a helper type that allows you to easily build paths from
/// individual elements, using the platform specific conventions for path
/// separators.
/// </para>
/// <para>
/// ```c
/// g_auto (GPathBuf) path;
/// </para>
/// <para>
/// g_path_buf_init (&amp;path);
/// </para>
/// <para>
/// g_path_buf_push (&amp;path, &quot;usr&quot;);
/// g_path_buf_push (&amp;path, &quot;bin&quot;);
/// g_path_buf_push (&amp;path, &quot;echo&quot;);
/// </para>
/// <para>
/// g_autofree char *echo = g_path_buf_to_path (&amp;path);
/// g_assert_cmpstr (echo, ==, &quot;/usr/bin/echo&quot;);
/// ```
/// </para>
/// <para>
/// You can also load a full path and then operate on its components:
/// </para>
/// <para>
/// ```c
/// g_auto (GPathBuf) path;
/// </para>
/// <para>
/// g_path_buf_init_from_path (&amp;path, &quot;/usr/bin/echo&quot;);
/// </para>
/// <para>
/// g_path_buf_pop (&amp;path);
/// g_path_buf_push (&amp;path, &quot;sh&quot;);
/// </para>
/// <para>
/// g_autofree char *sh = g_path_buf_to_path (&amp;path);
/// g_assert_cmpstr (sh, ==, &quot;/usr/bin/sh&quot;);
/// ```
/// </para>
/// </summary>

public class GPathBufHandle : BaseSafeHandle
{
}


public static class GPathBufExtensions
{
/// <summary>
/// <para>
/// Clears the contents of the path buffer.
/// </para>
/// <para>
/// This function should be use to free the resources in a stack-allocated
/// `GPathBuf` initialized using g_path_buf_init() or
/// g_path_buf_init_from_path().
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>

	public static void Clear(this MentorLake.GLib.GPathBufHandle buf)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		GPathBufExterns.g_path_buf_clear(buf);
	}

/// <summary>
/// <para>
/// Clears the contents of the path buffer and returns the built path.
/// </para>
/// <para>
/// This function returns `NULL` if the `GPathBuf` is empty.
/// </para>
/// <para>
/// See also: g_path_buf_to_path()
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <return>
/// the built path
/// </return>

	public static string ClearToPath(this MentorLake.GLib.GPathBufHandle buf)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_clear_to_path(buf);
	}

/// <summary>
/// <para>
/// Copies the contents of a path buffer into a new `GPathBuf`.
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <return>
/// the newly allocated path buffer
/// </return>

	public static MentorLake.GLib.GPathBufHandle Copy(this MentorLake.GLib.GPathBufHandle buf)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_copy(buf);
	}

/// <summary>
/// <para>
/// Frees a `GPathBuf` allocated by g_path_buf_new().
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>

	public static void Free(this MentorLake.GLib.GPathBufHandle buf)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		GPathBufExterns.g_path_buf_free(buf);
	}

/// <summary>
/// <para>
/// Frees a `GPathBuf` allocated by g_path_buf_new(), and
/// returns the path inside the buffer.
/// </para>
/// <para>
/// This function returns `NULL` if the `GPathBuf` is empty.
/// </para>
/// <para>
/// See also: g_path_buf_to_path()
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <return>
/// the path
/// </return>

	public static string FreeToPath(this MentorLake.GLib.GPathBufHandle buf)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_free_to_path(buf);
	}

/// <summary>
/// <para>
/// Initializes a `GPathBuf` instance.
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <return>
/// the initialized path builder
/// </return>

	public static MentorLake.GLib.GPathBufHandle Init(this MentorLake.GLib.GPathBufHandle buf)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_init(buf);
	}

/// <summary>
/// <para>
/// Initializes a `GPathBuf` instance with the given path.
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <param name="path">
/// a file system path
/// </param>
/// <return>
/// the initialized path builder
/// </return>

	public static MentorLake.GLib.GPathBufHandle InitFromPath(this MentorLake.GLib.GPathBufHandle buf, string path)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_init_from_path(buf, path);
	}

/// <summary>
/// <para>
/// Removes the last element of the path buffer.
/// </para>
/// <para>
/// If there is only one element in the path buffer (for example, `/` on
/// Unix-like operating systems or the drive on Windows systems), it will
/// not be removed and %FALSE will be returned instead.
/// </para>
/// <code>
/// GPathBuf buf, cmp;
/// GPathBuf buf, cmp;
/// 
/// g_path_buf_init_from_path (&amp;buf, &quot;/bin/sh&quot;);
/// 
/// g_path_buf_pop (&amp;buf);
/// g_path_buf_init_from_path (&amp;cmp, &quot;/bin&quot;);
/// g_assert_true (g_path_buf_equal (&amp;buf, &amp;cmp));
/// g_path_buf_clear (&amp;cmp);
/// 
/// g_path_buf_pop (&amp;buf);
/// g_path_buf_init_from_path (&amp;cmp, &quot;/&quot;);
/// g_assert_true (g_path_buf_equal (&amp;buf, &amp;cmp));
/// g_path_buf_clear (&amp;cmp);
/// 
/// g_path_buf_clear (&amp;buf);
/// </code>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <return>
/// `TRUE` if the buffer was modified and `FALSE` otherwise
/// </return>

	public static bool Pop(this MentorLake.GLib.GPathBufHandle buf)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_pop(buf);
	}

/// <summary>
/// <para>
/// Extends the given path buffer with @path.
/// </para>
/// <para>
/// If @path is absolute, it replaces the current path.
/// </para>
/// <para>
/// If @path contains a directory separator, the buffer is extended by
/// as many elements the path provides.
/// </para>
/// <para>
/// On Windows, both forward slashes and backslashes are treated as
/// directory separators. On other platforms, %G_DIR_SEPARATOR_S is the
/// only directory separator.
/// </para>
/// <code>
/// GPathBuf buf, cmp;
/// GPathBuf buf, cmp;
/// 
/// g_path_buf_init_from_path (&amp;buf, &quot;/tmp&quot;);
/// g_path_buf_push (&amp;buf, &quot;.X11-unix/X0&quot;);
/// g_path_buf_init_from_path (&amp;cmp, &quot;/tmp/.X11-unix/X0&quot;);
/// g_assert_true (g_path_buf_equal (&amp;buf, &amp;cmp));
/// g_path_buf_clear (&amp;cmp);
/// 
/// g_path_buf_push (&amp;buf, &quot;/etc/locale.conf&quot;);
/// g_path_buf_init_from_path (&amp;cmp, &quot;/etc/locale.conf&quot;);
/// g_assert_true (g_path_buf_equal (&amp;buf, &amp;cmp));
/// g_path_buf_clear (&amp;cmp);
/// 
/// g_path_buf_clear (&amp;buf);
/// </code>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <param name="path">
/// a path
/// </param>
/// <return>
/// the same pointer to @buf, for convenience
/// </return>

	public static MentorLake.GLib.GPathBufHandle Push(this MentorLake.GLib.GPathBufHandle buf, string path)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_push(buf, path);
	}

/// <summary>
/// <para>
/// Adds an extension to the file name in the path buffer.
/// </para>
/// <para>
/// If @extension is `NULL`, the extension will be unset.
/// </para>
/// <para>
/// If the path buffer does not have a file name set, this function returns
/// `FALSE` and leaves the path buffer unmodified.
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <param name="extension">
/// the file extension
/// </param>
/// <return>
/// `TRUE` if the extension was replaced, and `FALSE` otherwise
/// </return>

	public static bool SetExtension(this MentorLake.GLib.GPathBufHandle buf, string extension)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_set_extension(buf, extension);
	}

/// <summary>
/// <para>
/// Sets the file name of the path.
/// </para>
/// <para>
/// If the path buffer is empty, the filename is left unset and this
/// function returns `FALSE`.
/// </para>
/// <para>
/// If the path buffer only contains the root element (on Unix-like operating
/// systems) or the drive (on Windows), this is the equivalent of pushing
/// the new @file_name.
/// </para>
/// <para>
/// If the path buffer contains a path, this is the equivalent of
/// popping the path buffer and pushing @file_name, creating a
/// sibling of the original path.
/// </para>
/// <code>
/// GPathBuf buf, cmp;
/// GPathBuf buf, cmp;
/// 
/// g_path_buf_init_from_path (&amp;buf, &quot;/&quot;);
/// 
/// g_path_buf_set_filename (&amp;buf, &quot;bar&quot;);
/// g_path_buf_init_from_path (&amp;cmp, &quot;/bar&quot;);
/// g_assert_true (g_path_buf_equal (&amp;buf, &amp;cmp));
/// g_path_buf_clear (&amp;cmp);
/// 
/// g_path_buf_set_filename (&amp;buf, &quot;baz.txt&quot;);
/// g_path_buf_init_from_path (&amp;cmp, &quot;/baz.txt&quot;);
/// g_assert_true (g_path_buf_equal (&amp;buf, &amp;cmp);
/// g_path_buf_clear (&amp;cmp);
/// 
/// g_path_buf_clear (&amp;buf);
/// </code>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <param name="file_name">
/// the file name in the path
/// </param>
/// <return>
/// `TRUE` if the file name was replaced, and `FALSE` otherwise
/// </return>

	public static bool SetFilename(this MentorLake.GLib.GPathBufHandle buf, string file_name)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_set_filename(buf, file_name);
	}

/// <summary>
/// <para>
/// Retrieves the built path from the path buffer.
/// </para>
/// <para>
/// On Windows, the result contains backslashes as directory separators,
/// even if forward slashes were used in input.
/// </para>
/// <para>
/// If the path buffer is empty, this function returns `NULL`.
/// </para>
/// </summary>

/// <param name="buf">
/// a path buffer
/// </param>
/// <return>
/// the path
/// </return>

	public static string ToPath(this MentorLake.GLib.GPathBufHandle buf)
	{
		if (buf.IsInvalid) throw new Exception("Invalid handle (GPathBuf)");
		return GPathBufExterns.g_path_buf_to_path(buf);
	}


	public static GPathBuf Dereference(this GPathBufHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPathBuf>(x.DangerousGetHandle());
}
internal class GPathBufExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_path_buf_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_buf_clear_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_path_buf_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_buf_free_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_init_from_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf, string path);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf, string path);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_set_extension([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf, string extension);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_set_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf, string file_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_buf_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_new_from_path(string path);

}

/// <summary>
/// <para>
/// `GPathBuf` is a helper type that allows you to easily build paths from
/// individual elements, using the platform specific conventions for path
/// separators.
/// </para>
/// <para>
/// ```c
/// g_auto (GPathBuf) path;
/// </para>
/// <para>
/// g_path_buf_init (&amp;path);
/// </para>
/// <para>
/// g_path_buf_push (&amp;path, &quot;usr&quot;);
/// g_path_buf_push (&amp;path, &quot;bin&quot;);
/// g_path_buf_push (&amp;path, &quot;echo&quot;);
/// </para>
/// <para>
/// g_autofree char *echo = g_path_buf_to_path (&amp;path);
/// g_assert_cmpstr (echo, ==, &quot;/usr/bin/echo&quot;);
/// ```
/// </para>
/// <para>
/// You can also load a full path and then operate on its components:
/// </para>
/// <para>
/// ```c
/// g_auto (GPathBuf) path;
/// </para>
/// <para>
/// g_path_buf_init_from_path (&amp;path, &quot;/usr/bin/echo&quot;);
/// </para>
/// <para>
/// g_path_buf_pop (&amp;path);
/// g_path_buf_push (&amp;path, &quot;sh&quot;);
/// </para>
/// <para>
/// g_autofree char *sh = g_path_buf_to_path (&amp;path);
/// g_assert_cmpstr (sh, ==, &quot;/usr/bin/sh&quot;);
/// ```
/// </para>
/// </summary>

public struct GPathBuf
{
/// <summary>
/// <para>
/// Compares two path buffers for equality and returns `TRUE`
/// if they are equal.
/// </para>
/// <para>
/// The path inside the paths buffers are not going to be normalized,
/// so `X/Y/Z/A/..`, `X/./Y/Z` and `X/Y/Z` are not going to be considered
/// equal.
/// </para>
/// <para>
/// This function can be passed to g_hash_table_new() as the
/// `key_equal_func` parameter.
/// </para>
/// </summary>

/// <param name="v1">
/// a path buffer to compare
/// </param>
/// <param name="v2">
/// a path buffer to compare
/// </param>
/// <return>
/// `TRUE` if the two path buffers are equal,
///   and `FALSE` otherwise
/// </return>

	public static bool Equal(IntPtr v1, IntPtr v2)
	{
		return GPathBufExterns.g_path_buf_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Allocates a new `GPathBuf`.
/// </para>
/// </summary>

/// <return>
/// the newly allocated path buffer
/// </return>

	public static MentorLake.GLib.GPathBufHandle New()
	{
		return GPathBufExterns.g_path_buf_new();
	}

/// <summary>
/// <para>
/// Allocates a new `GPathBuf` with the given @path.
/// </para>
/// </summary>

/// <param name="path">
/// the path used to initialize the buffer
/// </param>
/// <return>
/// the newly allocated path buffer
/// </return>

	public static MentorLake.GLib.GPathBufHandle NewFromPath(string path)
	{
		return GPathBufExterns.g_path_buf_new_from_path(path);
	}

}
