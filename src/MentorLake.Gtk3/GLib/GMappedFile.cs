namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GMappedFile represents a file mapping created with
/// g_mapped_file_new(). It has only private members and should
/// not be accessed directly.
/// </para>
/// </summary>

public class GMappedFileHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Maps a file into memory. On UNIX, this is using the mmap() function.
/// </para>
/// <para>
/// If @writable is %TRUE, the mapped buffer may be modified, otherwise
/// it is an error to modify the mapped buffer. Modifications to the buffer
/// are not visible to other processes mapping the same file, and are not
/// written back to the file.
/// </para>
/// <para>
/// Note that modifications of the underlying file might affect the contents
/// of the #GMappedFile. Therefore, mapping should only be used if the file
/// will not be modified, or if all modifications of the file are done
/// atomically (e.g. using g_file_set_contents()).
/// </para>
/// <para>
/// If @filename is the name of an empty, regular file, the function
/// will successfully return an empty #GMappedFile. In other cases of
/// size 0 (e.g. device files such as /dev/null), @error will be set
/// to the #GFileError value %G_FILE_ERROR_INVAL.
/// </para>
/// </summary>

/// <param name="filename">
/// The path of the file to load, in the GLib
///     filename encoding
/// </param>
/// <param name="writable">
/// whether the mapping should be writable
/// </param>
/// <return>
/// a newly allocated #GMappedFile which must be unref'd
///    with g_mapped_file_unref(), or %NULL if the mapping failed.
/// </return>

	public static MentorLake.GLib.GMappedFileHandle New(string filename, bool writable)
	{
		var externCallResult = GMappedFileExterns.g_mapped_file_new(filename, writable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Maps a file into memory. On UNIX, this is using the mmap() function.
/// </para>
/// <para>
/// If @writable is %TRUE, the mapped buffer may be modified, otherwise
/// it is an error to modify the mapped buffer. Modifications to the buffer
/// are not visible to other processes mapping the same file, and are not
/// written back to the file.
/// </para>
/// <para>
/// Note that modifications of the underlying file might affect the contents
/// of the #GMappedFile. Therefore, mapping should only be used if the file
/// will not be modified, or if all modifications of the file are done
/// atomically (e.g. using g_file_set_contents()).
/// </para>
/// </summary>

/// <param name="fd">
/// The file descriptor of the file to load
/// </param>
/// <param name="writable">
/// whether the mapping should be writable
/// </param>
/// <return>
/// a newly allocated #GMappedFile which must be unref'd
///    with g_mapped_file_unref(), or %NULL if the mapping failed.
/// </return>

	public static MentorLake.GLib.GMappedFileHandle NewFromFd(int fd, bool writable)
	{
		var externCallResult = GMappedFileExterns.g_mapped_file_new_from_fd(fd, writable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GMappedFileExtensions
{
/// <summary>
/// <para>
/// This call existed before #GMappedFile had refcounting and is currently
/// exactly the same as g_mapped_file_unref().
/// </para>
/// </summary>

/// <param name="file">
/// a #GMappedFile
/// </param>

	public static void Free(this MentorLake.GLib.GMappedFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GMappedFile)");
		GMappedFileExterns.g_mapped_file_free(file);
	}

/// <summary>
/// <para>
/// Creates a new #GBytes which references the data mapped from @file.
/// The mapped contents of the file must not be modified after creating this
/// bytes object, because a #GBytes should be immutable.
/// </para>
/// </summary>

/// <param name="file">
/// a #GMappedFile
/// </param>
/// <return>
/// A newly allocated #GBytes referencing data
///     from @file
/// </return>

	public static MentorLake.GLib.GBytesHandle GetBytes(this MentorLake.GLib.GMappedFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GMappedFile)");
		return GMappedFileExterns.g_mapped_file_get_bytes(file);
	}

/// <summary>
/// <para>
/// Returns the contents of a #GMappedFile.
/// </para>
/// <para>
/// Note that the contents may not be zero-terminated,
/// even if the #GMappedFile is backed by a text file.
/// </para>
/// <para>
/// If the file is empty then %NULL is returned.
/// </para>
/// </summary>

/// <param name="file">
/// a #GMappedFile
/// </param>
/// <return>
/// the contents of @file, or %NULL.
/// </return>

	public static string GetContents(this MentorLake.GLib.GMappedFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GMappedFile)");
		return GMappedFileExterns.g_mapped_file_get_contents(file);
	}

/// <summary>
/// <para>
/// Returns the length of the contents of a #GMappedFile.
/// </para>
/// </summary>

/// <param name="file">
/// a #GMappedFile
/// </param>
/// <return>
/// the length of the contents of @file.
/// </return>

	public static UIntPtr GetLength(this MentorLake.GLib.GMappedFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GMappedFile)");
		return GMappedFileExterns.g_mapped_file_get_length(file);
	}

/// <summary>
/// <para>
/// Increments the reference count of @file by one.  It is safe to call
/// this function from any thread.
/// </para>
/// </summary>

/// <param name="file">
/// a #GMappedFile
/// </param>
/// <return>
/// the passed in #GMappedFile.
/// </return>

	public static MentorLake.GLib.GMappedFileHandle Ref(this MentorLake.GLib.GMappedFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GMappedFile)");
		return GMappedFileExterns.g_mapped_file_ref(file);
	}

/// <summary>
/// <para>
/// Decrements the reference count of @file by one.  If the reference count
/// drops to 0, unmaps the buffer of @file and frees it.
/// </para>
/// <para>
/// It is safe to call this function from any thread.
/// </para>
/// <para>
/// Since 2.22
/// </para>
/// </summary>

/// <param name="file">
/// a #GMappedFile
/// </param>

	public static void Unref(this MentorLake.GLib.GMappedFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GMappedFile)");
		GMappedFileExterns.g_mapped_file_unref(file);
	}


	public static GMappedFile Dereference(this GMappedFileHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMappedFile>(x.DangerousGetHandle());
}
internal class GMappedFileExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))]
	internal static extern MentorLake.GLib.GMappedFileHandle g_mapped_file_new(string filename, bool writable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))]
	internal static extern MentorLake.GLib.GMappedFileHandle g_mapped_file_new_from_fd(int fd, bool writable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mapped_file_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_mapped_file_get_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mapped_file_get_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_mapped_file_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))]
	internal static extern MentorLake.GLib.GMappedFileHandle g_mapped_file_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mapped_file_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

}

/// <summary>
/// <para>
/// The #GMappedFile represents a file mapping created with
/// g_mapped_file_new(). It has only private members and should
/// not be accessed directly.
/// </para>
/// </summary>

public struct GMappedFile
{
}
