namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GFile` is a high level abstraction for manipulating files on a
/// virtual file system. `GFile`s are lightweight, immutable objects
/// that do no I/O upon creation. It is necessary to understand that
/// `GFile` objects do not represent files, merely an identifier for a
/// file. All file content I/O is implemented as streaming operations
/// (see [class@Gio.InputStream] and [class@Gio.OutputStream]).
/// </para>
/// <para>
/// To construct a `GFile`, you can use:
/// </para>
/// <para>
/// - [func@Gio.File.new_for_path] if you have a path.
/// - [func@Gio.File.new_for_uri] if you have a URI.
/// - [func@Gio.File.new_for_commandline_arg] or
///   [func@Gio.File.new_for_commandline_arg_and_cwd] for a command line
///   argument.
/// - [func@Gio.File.new_tmp] to create a temporary file from a template.
/// - [func@Gio.File.new_tmp_async] to asynchronously create a temporary file.
/// - [func@Gio.File.new_tmp_dir_async] to asynchronously create a temporary
///   directory.
/// - [func@Gio.File.parse_name] from a UTF-8 string gotten from
///   [method@Gio.File.get_parse_name].
/// - [func@Gio.File.new_build_filename] or [func@Gio.File.new_build_filenamev]
///   to create a file from path elements.
/// </para>
/// <para>
/// One way to think of a `GFile` is as an abstraction of a pathname. For
/// normal files the system pathname is what is stored internally, but as
/// `GFile`s are extensible it could also be something else that corresponds
/// to a pathname in a userspace implementation of a filesystem.
/// </para>
/// <para>
/// `GFile`s make up hierarchies of directories and files that correspond to
/// the files on a filesystem. You can move through the file system with
/// `GFile` using [method@Gio.File.get_parent] to get an identifier for the
/// parent directory, [method@Gio.File.get_child] to get a child within a
/// directory, and [method@Gio.File.resolve_relative_path] to resolve a relative
/// path between two `GFile`s. There can be multiple hierarchies, so you may not
/// end up at the same root if you repeatedly call [method@Gio.File.get_parent]
/// on two different files.
/// </para>
/// <para>
/// All `GFile`s have a basename (get with [method@Gio.File.get_basename]). These
/// names are byte strings that are used to identify the file on the filesystem
/// (relative to its parent directory) and there is no guarantees that they
/// have any particular charset encoding or even make any sense at all. If
/// you want to use filenames in a user interface you should use the display
/// name that you can get by requesting the
/// `G_FILE_ATTRIBUTE_STANDARD_DISPLAY_NAME` attribute with
/// [method@Gio.File.query_info]. This is guaranteed to be in UTF-8 and can be
/// used in a user interface. But always store the real basename or the `GFile`
/// to use to actually access the file, because there is no way to go from a
/// display name to the actual name.
/// </para>
/// <para>
/// Using `GFile` as an identifier has the same weaknesses as using a path
/// in that there may be multiple aliases for the same file. For instance,
/// hard or soft links may cause two different `GFile`s to refer to the same
/// file. Other possible causes for aliases are: case insensitive filesystems,
/// short and long names on FAT/NTFS, or bind mounts in Linux. If you want to
/// check if two `GFile`s point to the same file you can query for the
/// `G_FILE_ATTRIBUTE_ID_FILE` attribute. Note that `GFile` does some trivial
/// canonicalization of pathnames passed in, so that trivial differences in
/// the path string used at creation (duplicated slashes, slash at end of
/// path, `.` or `..` path segments, etc) does not create different `GFile`s.
/// </para>
/// <para>
/// Many `GFile` operations have both synchronous and asynchronous versions
/// to suit your application. Asynchronous versions of synchronous functions
/// simply have `_async()` appended to their function names. The asynchronous
/// I/O functions call a [callback@Gio.AsyncReadyCallback] which is then used to
/// finalize the operation, producing a [iface@Gio.AsyncResult] which is then
/// passed to the function’s matching `_finish()` operation.
/// </para>
/// <para>
/// It is highly recommended to use asynchronous calls when running within a
/// shared main loop, such as in the main thread of an application. This avoids
/// I/O operations blocking other sources on the main loop from being dispatched.
/// Synchronous I/O operations should be performed from worker threads. See the
/// [introduction to asynchronous programming section](overview.html#asynchronous-programming)
/// for more.
/// </para>
/// <para>
/// Some `GFile` operations almost always take a noticeable amount of time, and
/// so do not have synchronous analogs. Notable cases include:
/// </para>
/// <para>
/// - [method@Gio.File.mount_mountable] to mount a mountable file.
/// - [method@Gio.File.unmount_mountable_with_operation] to unmount a mountable
///   file.
/// - [method@Gio.File.eject_mountable_with_operation] to eject a mountable file.
/// </para>
/// <para>
/// ## Entity Tags
/// </para>
/// <para>
/// One notable feature of `GFile`s are entity tags, or ‘etags’ for
/// short. Entity tags are somewhat like a more abstract version of the
/// traditional mtime, and can be used to quickly determine if the file
/// has been modified from the version on the file system. See the
/// HTTP 1.1
/// [specification](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html)
/// for HTTP `ETag` headers, which are a very similar concept.
/// </para>
/// </summary>

public interface GFileHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GFileHandleImpl : BaseSafeHandle, GFileHandle
{
}

public static class GFileHandleExtensions
{
/// <summary>
/// <para>
/// Gets an output stream for appending data to the file.
/// If the file doesn't already exist it is created.
/// </para>
/// <para>
/// By default files created are generally readable by everyone,
/// but if you pass %G_FILE_CREATE_PRIVATE in @flags the file
/// will be made readable only to the current user, to the level that
/// is supported on the target filesystem.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled
/// by triggering the cancellable object from another thread. If the
/// operation was cancelled, the error %G_IO_ERROR_CANCELLED will be
/// returned.
/// </para>
/// <para>
/// Some file systems don't allow all file names, and may return an
/// %G_IO_ERROR_INVALID_FILENAME error. If the file is a directory the
/// %G_IO_ERROR_IS_DIRECTORY error will be returned. Other errors are
/// possible too, and depend on what kind of filesystem the file is on.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileOutputStream, or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileOutputStreamHandle AppendTo(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_append_to(file, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously opens @file for appending.
/// </para>
/// <para>
/// For more details, see g_file_append_to() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_append_to_finish() to get the result
/// of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T AppendToAsync<T>(this T file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_append_to_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file append operation started with
/// g_file_append_to_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// #GAsyncResult
/// </param>
/// <return>
/// a valid #GFileOutputStream
///   or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileOutputStreamHandle AppendToFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_append_to_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Prepares the file attribute query string for copying to @file.
/// </para>
/// <para>
/// This function prepares an attribute query string to be
/// passed to g_file_query_info() to get a list of attributes
/// normally copied with the file (see g_file_copy_attributes()
/// for the detailed description). This function is used by the
/// implementation of g_file_copy_attributes() and is useful
/// when one needs to query and set the attributes in two
/// stages (e.g., for recursive move of a directory).
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile to copy attributes to
/// </param>
/// <param name="flags">
/// a set of #GFileCopyFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// an attribute query string for g_file_query_info(),
///   or %NULL if an error occurs.
/// </return>

	public static string BuildAttributeListForCopy(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCopyFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_build_attribute_list_for_copy(file, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Copies the file @source to the location specified by @destination.
/// Can not handle recursive copies of directories.
/// </para>
/// <para>
/// If the flag %G_FILE_COPY_OVERWRITE is specified an already
/// existing @destination file is overwritten.
/// </para>
/// <para>
/// If the flag %G_FILE_COPY_NOFOLLOW_SYMLINKS is specified then symlinks
/// will be copied as symlinks, otherwise the target of the
/// @source symlink will be copied.
/// </para>
/// <para>
/// If the flag %G_FILE_COPY_ALL_METADATA is specified then all the metadata
/// that is possible to copy is copied, not just the default subset (which,
/// for instance, does not include the owner, see #GFileInfo).
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// If @progress_callback is not %NULL, then the operation can be monitored
/// by setting this to a #GFileProgressCallback function.
/// @progress_callback_data will be passed to this function. It is guaranteed
/// that this callback will be called after all data has been transferred with
/// the total number of bytes copied during the operation.
/// </para>
/// <para>
/// If the @source file does not exist, then the %G_IO_ERROR_NOT_FOUND error
/// is returned, independent on the status of the @destination.
/// </para>
/// <para>
/// If %G_FILE_COPY_OVERWRITE is not specified and the target exists, then
/// the error %G_IO_ERROR_EXISTS is returned.
/// </para>
/// <para>
/// If trying to overwrite a file over a directory, the %G_IO_ERROR_IS_DIRECTORY
/// error is returned. If trying to overwrite a directory with a directory the
/// %G_IO_ERROR_WOULD_MERGE error is returned.
/// </para>
/// <para>
/// If the source is a directory and the target does not exist, or
/// %G_FILE_COPY_OVERWRITE is specified and the target is a file, then the
/// %G_IO_ERROR_WOULD_RECURSE error is returned.
/// </para>
/// <para>
/// If you are interested in copying the #GFile object itself (not the on-disk
/// file), see g_file_dup().
/// </para>
/// </summary>

/// <param name="source">
/// input #GFile
/// </param>
/// <param name="destination">
/// destination #GFile
/// </param>
/// <param name="flags">
/// set of #GFileCopyFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="progress_callback">
/// function to callback with
///   progress information, or %NULL if progress information is not needed
/// </param>
/// <param name="progress_callback_data">
/// user data to pass to @progress_callback
/// </param>
/// <return>
/// %TRUE on success, %FALSE otherwise.
/// </return>

	public static bool Copy(this MentorLake.Gio.GFileHandle source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_copy(source, destination, flags, cancellable, progress_callback, progress_callback_data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Copies the file @source to the location specified by @destination
/// asynchronously. For details of the behaviour, see g_file_copy().
/// </para>
/// <para>
/// If @progress_callback is not %NULL, then that function that will be called
/// just like in g_file_copy(). The callback will run in the default main context
/// of the thread calling g_file_copy_async() — the same context as @callback is
/// run in.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// g_file_copy_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="source">
/// input #GFile
/// </param>
/// <param name="destination">
/// destination #GFile
/// </param>
/// <param name="flags">
/// set of #GFileCopyFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="progress_callback">
/// 
///   function to callback with progress information, or %NULL if
///   progress information is not needed
/// </param>
/// <param name="progress_callback_data">
/// user data to pass to @progress_callback
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback
/// </param>

	public static T CopyAsync<T>(this T source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_copy_async(source, destination, flags, io_priority, cancellable, progress_callback, progress_callback_data, callback, user_data);
		return source;
	}

/// <summary>
/// <para>
/// Version of [method@Gio.File.copy_async] using closures instead of callbacks for
/// easier binding in other languages.
/// </para>
/// </summary>

/// <param name="source">
/// input [type@Gio.File]
/// </param>
/// <param name="destination">
/// destination [type@Gio.File]
/// </param>
/// <param name="flags">
/// set of [flags@Gio.FileCopyFlags]
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional [class@Gio.Cancellable] object,
///   `NULL` to ignore
/// </param>
/// <param name="progress_callback_closure">
/// [type@GObject.Closure] to invoke with progress
///   information, or `NULL` if progress information is not needed
/// </param>
/// <param name="ready_callback_closure">
/// [type@GObject.Closure] to invoke when the request is satisfied
/// </param>

	public static T CopyAsyncWithClosures<T>(this T source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GObject.GClosureHandle progress_callback_closure, MentorLake.GObject.GClosureHandle ready_callback_closure) where T : GFileHandle
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_copy_async_with_closures(source, destination, flags, io_priority, cancellable, progress_callback_closure, ready_callback_closure);
		return source;
	}

/// <summary>
/// <para>
/// Copies the file attributes from @source to @destination.
/// </para>
/// <para>
/// Normally only a subset of the file attributes are copied,
/// those that are copies in a normal file copy operation
/// (which for instance does not include e.g. owner). However
/// if %G_FILE_COPY_ALL_METADATA is specified in @flags, then
/// all the metadata that is possible to copy is copied. This
/// is useful when implementing move by copy + delete source.
/// </para>
/// </summary>

/// <param name="source">
/// a #GFile with attributes
/// </param>
/// <param name="destination">
/// a #GFile to copy attributes to
/// </param>
/// <param name="flags">
/// a set of #GFileCopyFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the attributes were copied successfully,
///   %FALSE otherwise.
/// </return>

	public static bool CopyAttributes(this MentorLake.Gio.GFileHandle source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_copy_attributes(source, destination, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes copying the file started with g_file_copy_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a %TRUE on success, %FALSE on error.
/// </return>

	public static bool CopyFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_copy_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new file and returns an output stream for writing to it.
/// The file must not already exist.
/// </para>
/// <para>
/// By default files created are generally readable by everyone,
/// but if you pass %G_FILE_CREATE_PRIVATE in @flags the file
/// will be made readable only to the current user, to the level
/// that is supported on the target filesystem.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled
/// by triggering the cancellable object from another thread. If the
/// operation was cancelled, the error %G_IO_ERROR_CANCELLED will be
/// returned.
/// </para>
/// <para>
/// If a file or directory with this name already exists the
/// %G_IO_ERROR_EXISTS error will be returned. Some file systems don't
/// allow all file names, and may return an %G_IO_ERROR_INVALID_FILENAME
/// error, and if the name is to long %G_IO_ERROR_FILENAME_TOO_LONG will
/// be returned. Other errors are possible too, and depend on what kind
/// of filesystem the file is on.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileOutputStream for the newly created
///   file, or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileOutputStreamHandle Create(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_create(file, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously creates a new file and returns an output stream
/// for writing to it. The file must not already exist.
/// </para>
/// <para>
/// For more details, see g_file_create() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_create_finish() to get the result
/// of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T CreateAsync<T>(this T file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_create_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file create operation started with
/// g_file_create_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFileOutputStream or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileOutputStreamHandle CreateFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_create_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new file and returns a stream for reading and
/// writing to it. The file must not already exist.
/// </para>
/// <para>
/// By default files created are generally readable by everyone,
/// but if you pass %G_FILE_CREATE_PRIVATE in @flags the file
/// will be made readable only to the current user, to the level
/// that is supported on the target filesystem.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled
/// by triggering the cancellable object from another thread. If the
/// operation was cancelled, the error %G_IO_ERROR_CANCELLED will be
/// returned.
/// </para>
/// <para>
/// If a file or directory with this name already exists, the
/// %G_IO_ERROR_EXISTS error will be returned. Some file systems don't
/// allow all file names, and may return an %G_IO_ERROR_INVALID_FILENAME
/// error, and if the name is too long, %G_IO_ERROR_FILENAME_TOO_LONG
/// will be returned. Other errors are possible too, and depend on what
/// kind of filesystem the file is on.
/// </para>
/// <para>
/// Note that in many non-local file cases read and write streams are
/// not supported, so make sure you really need to do read and write
/// streaming, rather than just opening for reading or writing.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileIOStream for the newly created
///   file, or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileIOStreamHandle CreateReadwrite(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_create_readwrite(file, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously creates a new file and returns a stream
/// for reading and writing to it. The file must not already exist.
/// </para>
/// <para>
/// For more details, see g_file_create_readwrite() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_create_readwrite_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T CreateReadwriteAsync<T>(this T file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_create_readwrite_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file create operation started with
/// g_file_create_readwrite_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFileIOStream or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileIOStreamHandle CreateReadwriteFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_create_readwrite_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Deletes a file. If the @file is a directory, it will only be
/// deleted if it is empty. This has the same semantics as g_unlink().
/// </para>
/// <para>
/// If @file doesn’t exist, %G_IO_ERROR_NOT_FOUND will be returned. This allows
/// for deletion to be implemented avoiding
/// [time-of-check to time-of-use races](https://en.wikipedia.org/wiki/Time-of-check_to_time-of-use):
/// |[
/// g_autoptr(GError) local_error = NULL;
/// if (!g_file_delete (my_file, my_cancellable, &local_error) &&
///     !g_error_matches (local_error, G_IO_ERROR, G_IO_ERROR_NOT_FOUND))
///   {
///     // deletion failed for some reason other than the file not existing:
///     // so report the error
///     g_warning ("Failed to delete %s: %s",
///                g_file_peek_path (my_file), local_error->message);
///   }
/// ]|
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the file was deleted. %FALSE otherwise.
/// </return>

	public static bool Delete(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_delete(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously delete a file. If the @file is a directory, it will
/// only be deleted if it is empty.  This has the same semantics as
/// g_unlink().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T DeleteAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_delete_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes deleting a file started with g_file_delete_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the file was deleted. %FALSE otherwise.
/// </return>

	public static bool DeleteFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_delete_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Duplicates a #GFile handle. This operation does not duplicate
/// the actual file or directory represented by the #GFile; see
/// g_file_copy() if attempting to copy a file.
/// </para>
/// <para>
/// g_file_dup() is useful when a second handle is needed to the same underlying
/// file, for use in a separate thread (#GFile is not thread-safe). For use
/// within the same thread, use g_object_ref() to increment the existing object’s
/// reference count.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// a new #GFile that is a duplicate
///   of the given #GFile.
/// </return>

	public static MentorLake.Gio.GFileHandle Dup(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_dup(file);
	}

/// <summary>
/// <para>
/// Starts an asynchronous eject on a mountable.
/// When this operation has completed, @callback will be called with
/// @user_user data, and the operation can be finalized with
/// g_file_eject_mountable_finish().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T EjectMountable<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_eject_mountable(file, flags, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous eject operation started by
/// g_file_eject_mountable().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the @file was ejected successfully.
///   %FALSE otherwise.
/// </return>

	public static bool EjectMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_eject_mountable_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Starts an asynchronous eject on a mountable.
/// When this operation has completed, @callback will be called with
/// @user_user data, and the operation can be finalized with
/// g_file_eject_mountable_with_operation_finish().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation,
///   or %NULL to avoid user interaction
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T EjectMountableWithOperation<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_eject_mountable_with_operation(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous eject operation started by
/// g_file_eject_mountable_with_operation().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the @file was ejected successfully.
///   %FALSE otherwise.
/// </return>

	public static bool EjectMountableWithOperationFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_eject_mountable_with_operation_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the requested information about the files in a directory.
/// The result is a #GFileEnumerator object that will give out
/// #GFileInfo objects for all the files in the directory.
/// </para>
/// <para>
/// The @attributes value is a string that specifies the file
/// attributes that should be gathered. It is not an error if
/// it's not possible to read a particular requested attribute
/// from a file - it just won't be set. @attributes should
/// be a comma-separated list of attributes or attribute wildcards.
/// The wildcard "*" means all attributes, and a wildcard like
/// "standard::*" means all attributes in the standard namespace.
/// An example attribute query be "standard::*,owner::user".
/// The standard attributes are available as defines, like
/// %G_FILE_ATTRIBUTE_STANDARD_NAME. %G_FILE_ATTRIBUTE_STANDARD_NAME should
/// always be specified if you plan to call g_file_enumerator_get_child() or
/// g_file_enumerator_iterate() on the returned enumerator.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled
/// by triggering the cancellable object from another thread. If the
/// operation was cancelled, the error %G_IO_ERROR_CANCELLED will be
/// returned.
/// </para>
/// <para>
/// If the file does not exist, the %G_IO_ERROR_NOT_FOUND error will
/// be returned. If the file is not a directory, the %G_IO_ERROR_NOT_DIRECTORY
/// error will be returned. Other errors are possible too.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attributes">
/// an attribute query string
/// </param>
/// <param name="flags">
/// a set of #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// A #GFileEnumerator if successful,
///   %NULL on error. Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileEnumeratorHandle EnumerateChildren(this MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_enumerate_children(file, attributes, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously gets the requested information about the files
/// in a directory. The result is a #GFileEnumerator object that will
/// give out #GFileInfo objects for all the files in the directory.
/// </para>
/// <para>
/// For more details, see g_file_enumerate_children() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can
/// then call g_file_enumerate_children_finish() to get the result of
/// the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attributes">
/// an attribute query string
/// </param>
/// <param name="flags">
/// a set of #GFileQueryInfoFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T EnumerateChildrenAsync<T>(this T file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_enumerate_children_async(file, attributes, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an async enumerate children operation.
/// See g_file_enumerate_children_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFileEnumerator or %NULL
///   if an error occurred.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileEnumeratorHandle EnumerateChildrenFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_enumerate_children_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if the two given #GFiles refer to the same file.
/// </para>
/// <para>
/// Note that two #GFiles that differ can still refer to the same
/// file on the filesystem due to various forms of filename
/// aliasing.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file1">
/// the first #GFile
/// </param>
/// <param name="file2">
/// the second #GFile
/// </param>
/// <return>
/// %TRUE if @file1 and @file2 are equal.
/// </return>

	public static bool Equal(this MentorLake.Gio.GFileHandle file1, MentorLake.Gio.GFileHandle file2)
	{
		if (file1.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_equal(file1, file2);
	}

/// <summary>
/// <para>
/// Gets a #GMount for the #GFile.
/// </para>
/// <para>
/// #GMount is returned only for user interesting locations, see
/// #GVolumeMonitor. If the #GFileIface for @file does not have a #mount,
/// @error will be set to %G_IO_ERROR_NOT_FOUND and %NULL #will be returned.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GMount where the @file is located
///   or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GMountHandle FindEnclosingMount(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_find_enclosing_mount(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously gets the mount for the file.
/// </para>
/// <para>
/// For more details, see g_file_find_enclosing_mount() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_find_enclosing_mount_finish() to
/// get the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T FindEnclosingMountAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_find_enclosing_mount_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous find mount request.
/// See g_file_find_enclosing_mount_async().
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// #GMount for given @file or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GMountHandle FindEnclosingMountFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_find_enclosing_mount_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the base name (the last component of the path) for a given #GFile.
/// </para>
/// <para>
/// If called for the top level of a system (such as the filesystem root
/// or a uri like sftp://host/) it will return a single directory separator
/// (and on Windows, possibly a drive letter).
/// </para>
/// <para>
/// The base name is a byte string (not UTF-8). It has no defined encoding
/// or rules other than it may not contain zero bytes.  If you want to use
/// filenames in a user interface you should use the display name that you
/// can get by requesting the %G_FILE_ATTRIBUTE_STANDARD_DISPLAY_NAME
/// attribute with g_file_query_info().
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// string containing the #GFile's
///   base name, or %NULL if given #GFile is invalid. The returned string
///   should be freed with g_free() when no longer needed.
/// </return>

	public static string GetBasename(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_get_basename(file);
	}

/// <summary>
/// <para>
/// Gets a child of @file with basename equal to @name.
/// </para>
/// <para>
/// Note that the file with that specific name might not exist, but
/// you can still have a #GFile that points to it. You can use this
/// for instance to create that file.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="name">
/// string containing the child's basename
/// </param>
/// <return>
/// a #GFile to a child specified by @name.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle GetChild(this MentorLake.Gio.GFileHandle file, string name)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_get_child(file, name);
	}

/// <summary>
/// <para>
/// Gets the child of @file for a given @display_name (i.e. a UTF-8
/// version of the name). If this function fails, it returns %NULL
/// and @error will be set. This is very useful when constructing a
/// #GFile for a new file and the user entered the filename in the
/// user interface, for instance when you select a directory and
/// type a filename in the file selector.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="display_name">
/// string to a possible child
/// </param>
/// <return>
/// a #GFile to the specified child, or
///   %NULL if the display name couldn't be converted.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle GetChildForDisplayName(this MentorLake.Gio.GFileHandle file, string display_name)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_get_child_for_display_name(file, display_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the parent directory for the @file.
/// If the @file represents the root directory of the
/// file system, then %NULL will be returned.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// a #GFile structure to the
///   parent of the given #GFile or %NULL if there is no parent. Free
///   the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle GetParent(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_get_parent(file);
	}

/// <summary>
/// <para>
/// Gets the parse name of the @file.
/// A parse name is a UTF-8 string that describes the
/// file such that one can get the #GFile back using
/// g_file_parse_name().
/// </para>
/// <para>
/// This is generally used to show the #GFile as a nice
/// full-pathname kind of string in a user interface,
/// like in a location entry.
/// </para>
/// <para>
/// For local files with names that can safely be converted
/// to UTF-8 the pathname is used, otherwise the IRI is used
/// (a form of URI that allows UTF-8 characters unescaped).
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// a string containing the #GFile's parse name.
///   The returned string should be freed with g_free()
///   when no longer needed.
/// </return>

	public static string GetParseName(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_get_parse_name(file);
	}

/// <summary>
/// <para>
/// Gets the local pathname for #GFile, if one exists. If non-%NULL, this is
/// guaranteed to be an absolute, canonical path. It might contain symlinks.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// string containing the #GFile's path,
///   or %NULL if no such path exists. The returned string should be freed
///   with g_free() when no longer needed.
/// </return>

	public static string GetPath(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_get_path(file);
	}

/// <summary>
/// <para>
/// Gets the path for @descendant relative to @parent.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="parent">
/// input #GFile
/// </param>
/// <param name="descendant">
/// input #GFile
/// </param>
/// <return>
/// string with the relative path from
///   @descendant to @parent, or %NULL if @descendant doesn't have @parent as
///   prefix. The returned string should be freed with g_free() when
///   no longer needed.
/// </return>

	public static string GetRelativePath(this MentorLake.Gio.GFileHandle parent, MentorLake.Gio.GFileHandle descendant)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_get_relative_path(parent, descendant);
	}

/// <summary>
/// <para>
/// Gets the URI for the @file.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// a string containing the #GFile's URI. If the #GFile was constructed
///   with an invalid URI, an invalid URI is returned.
///   The returned string should be freed with g_free()
///   when no longer needed.
/// </return>

	public static string GetUri(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_get_uri(file);
	}

/// <summary>
/// <para>
/// Gets the URI scheme for a #GFile.
/// RFC 3986 decodes the scheme as:
/// |[
/// URI = scheme ":" hier-part [ "?" query ] [ "#" fragment ]
/// ]|
/// Common schemes include "file", "http", "ftp", etc.
/// </para>
/// <para>
/// The scheme can be different from the one used to construct the #GFile,
/// in that it might be replaced with one that is logically equivalent to the #GFile.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// a string containing the URI scheme for the given
///   #GFile or %NULL if the #GFile was constructed with an invalid URI. The
///   returned string should be freed with g_free() when no longer needed.
/// </return>

	public static string GetUriScheme(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_get_uri_scheme(file);
	}

/// <summary>
/// <para>
/// Checks if @file has a parent, and optionally, if it is @parent.
/// </para>
/// <para>
/// If @parent is %NULL then this function returns %TRUE if @file has any
/// parent at all.  If @parent is non-%NULL then %TRUE is only returned
/// if @file is an immediate child of @parent.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="parent">
/// the parent to check for, or %NULL
/// </param>
/// <return>
/// %TRUE if @file is an immediate child of @parent (or any parent in
///   the case that @parent is %NULL).
/// </return>

	public static bool HasParent(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileHandle parent)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_has_parent(file, parent);
	}

/// <summary>
/// <para>
/// Checks whether @file has the prefix specified by @prefix.
/// </para>
/// <para>
/// In other words, if the names of initial elements of @file's
/// pathname match @prefix. Only full pathname elements are matched,
/// so a path like /foo is not considered a prefix of /foobar, only
/// of /foo/bar.
/// </para>
/// <para>
/// A #GFile is not a prefix of itself. If you want to check for
/// equality, use g_file_equal().
/// </para>
/// <para>
/// This call does no I/O, as it works purely on names. As such it can
/// sometimes return %FALSE even if @file is inside a @prefix (from a
/// filesystem point of view), because the prefix of @file is an alias
/// of @prefix.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="prefix">
/// input #GFile
/// </param>
/// <return>
/// %TRUE if the @file's parent, grandparent, etc is @prefix,
///   %FALSE otherwise.
/// </return>

	public static bool HasPrefix(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileHandle prefix)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_has_prefix(file, prefix);
	}

/// <summary>
/// <para>
/// Checks to see if a #GFile has a given URI scheme.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="uri_scheme">
/// a string containing a URI scheme
/// </param>
/// <return>
/// %TRUE if #GFile's backend supports the
///   given URI scheme, %FALSE if URI scheme is %NULL,
///   not supported, or #GFile is invalid.
/// </return>

	public static bool HasUriScheme(this MentorLake.Gio.GFileHandle file, string uri_scheme)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_has_uri_scheme(file, uri_scheme);
	}

/// <summary>
/// <para>
/// Creates a hash value for a #GFile.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// #gconstpointer to a #GFile
/// </param>
/// <return>
/// 0 if @file is not a valid #GFile, otherwise an
///   integer that can be used as hash value for the #GFile.
///   This function is intended for easily hashing a #GFile to
///   add to a #GHashTable or similar data structure.
/// </return>

	public static uint Hash(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_hash(file);
	}

/// <summary>
/// <para>
/// Checks to see if a file is native to the platform.
/// </para>
/// <para>
/// A native file is one expressed in the platform-native filename format,
/// e.g. "C:\Windows" or "/usr/bin/". This does not mean the file is local,
/// as it might be on a locally mounted remote filesystem.
/// </para>
/// <para>
/// On some systems non-native files may be available using the native
/// filesystem via a userspace filesystem (FUSE), in these cases this call
/// will return %FALSE, but g_file_get_path() will still return a native path.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// %TRUE if @file is native
/// </return>

	public static bool IsNative(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_is_native(file);
	}

/// <summary>
/// <para>
/// Loads the contents of @file and returns it as #GBytes.
/// </para>
/// <para>
/// If @file is a resource:// based URI, the resulting bytes will reference the
/// embedded resource instead of a copy. Otherwise, this is equivalent to calling
/// g_file_load_contents() and g_bytes_new_take().
/// </para>
/// <para>
/// For resources, @etag_out will be set to %NULL.
/// </para>
/// <para>
/// The data contained in the resulting #GBytes is always zero-terminated, but
/// this is not included in the #GBytes length. The resulting #GBytes should be
/// freed with g_bytes_unref() when no longer in use.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="etag_out">
/// a location to place the current
///   entity tag for the file, or %NULL if the entity tag is not needed
/// </param>
/// <return>
/// a #GBytes or %NULL and @error is set
/// </return>

	public static MentorLake.GLib.GBytesHandle LoadBytes(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, out string etag_out)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_load_bytes(file, cancellable, out etag_out, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously loads the contents of @file as #GBytes.
/// </para>
/// <para>
/// If @file is a resource:// based URI, the resulting bytes will reference the
/// embedded resource instead of a copy. Otherwise, this is equivalent to calling
/// g_file_load_contents_async() and g_bytes_new_take().
/// </para>
/// <para>
/// @callback should call g_file_load_bytes_finish() to get the result of this
/// asynchronous operation.
/// </para>
/// <para>
/// See g_file_load_bytes() for more information.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T LoadBytesAsync<T>(this T file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_load_bytes_async(file, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Completes an asynchronous request to g_file_load_bytes_async().
/// </para>
/// <para>
/// For resources, @etag_out will be set to %NULL.
/// </para>
/// <para>
/// The data contained in the resulting #GBytes is always zero-terminated, but
/// this is not included in the #GBytes length. The resulting #GBytes should be
/// freed with g_bytes_unref() when no longer in use.
/// </para>
/// <para>
/// See g_file_load_bytes() for more information.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult provided to the callback
/// </param>
/// <param name="etag_out">
/// a location to place the current
///   entity tag for the file, or %NULL if the entity tag is not needed
/// </param>
/// <return>
/// a #GBytes or %NULL and @error is set
/// </return>

	public static MentorLake.GLib.GBytesHandle LoadBytesFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, out string etag_out)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_load_bytes_finish(file, result, out etag_out, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads the content of the file into memory. The data is always
/// zero-terminated, but this is not included in the resultant @length.
/// The returned @contents should be freed with g_free() when no longer
/// needed.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="contents">
/// a location to place the contents of the file
/// </param>
/// <param name="length">
/// a location to place the length of the contents of the file,
///   or %NULL if the length is not needed
/// </param>
/// <param name="etag_out">
/// a location to place the current entity tag for the file,
///   or %NULL if the entity tag is not needed
/// </param>
/// <return>
/// %TRUE if the @file's contents were successfully loaded.
///   %FALSE if there were errors.
/// </return>

	public static bool LoadContents(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, out byte[] contents, out UIntPtr length, out string etag_out)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_load_contents(file, cancellable, out contents, out length, out etag_out, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Starts an asynchronous load of the @file's contents.
/// </para>
/// <para>
/// For more details, see g_file_load_contents() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the load operation has completed, @callback will be called
/// with @user data. To finish the operation, call
/// g_file_load_contents_finish() with the #GAsyncResult returned by
/// the @callback.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T LoadContentsAsync<T>(this T file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_load_contents_async(file, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous load of the @file's contents.
/// The contents are placed in @contents, and @length is set to the
/// size of the @contents string. The @contents should be freed with
/// g_free() when no longer needed. If @etag_out is present, it will be
/// set to the new entity tag for the @file.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <param name="contents">
/// a location to place the contents of the file
/// </param>
/// <param name="length">
/// a location to place the length of the contents of the file,
///   or %NULL if the length is not needed
/// </param>
/// <param name="etag_out">
/// a location to place the current entity tag for the file,
///   or %NULL if the entity tag is not needed
/// </param>
/// <return>
/// %TRUE if the load was successful. If %FALSE and @error is
///   present, it will be set appropriately.
/// </return>

	public static bool LoadContentsFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, out byte[] contents, out UIntPtr length, out string etag_out)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_load_contents_finish(file, res, out contents, out length, out etag_out, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads the partial contents of a file. A #GFileReadMoreCallback should
/// be used to stop reading from the file when appropriate, else this
/// function will behave exactly as g_file_load_contents_async(). This
/// operation can be finished by g_file_load_partial_contents_finish().
/// </para>
/// <para>
/// Users of this function should be aware that @user_data is passed to
/// both the @read_more_callback and the @callback.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="read_more_callback">
/// a
///   #GFileReadMoreCallback to receive partial data
///   and to specify whether further data should be read
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to the callback functions
/// </param>

	public static T LoadPartialContentsAsync<T>(this T file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileReadMoreCallback read_more_callback, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_load_partial_contents_async(file, cancellable, read_more_callback, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous partial load operation that was started
/// with g_file_load_partial_contents_async(). The data is always
/// zero-terminated, but this is not included in the resultant @length.
/// The returned @contents should be freed with g_free() when no longer
/// needed.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <param name="contents">
/// a location to place the contents of the file
/// </param>
/// <param name="length">
/// a location to place the length of the contents of the file,
///   or %NULL if the length is not needed
/// </param>
/// <param name="etag_out">
/// a location to place the current entity tag for the file,
///   or %NULL if the entity tag is not needed
/// </param>
/// <return>
/// %TRUE if the load was successful. If %FALSE and @error is
///   present, it will be set appropriately.
/// </return>

	public static bool LoadPartialContentsFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, out byte[] contents, out UIntPtr length, out string etag_out)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_load_partial_contents_finish(file, res, out contents, out length, out etag_out, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a directory. Note that this will only create a child directory
/// of the immediate parent directory of the path or URI given by the #GFile.
/// To recursively create directories, see g_file_make_directory_with_parents().
/// This function will fail if the parent directory does not exist, setting
/// @error to %G_IO_ERROR_NOT_FOUND. If the file system doesn't support
/// creating directories, this function will fail, setting @error to
/// %G_IO_ERROR_NOT_SUPPORTED.
/// </para>
/// <para>
/// For a local #GFile the newly created directory will have the default
/// (current) ownership and permissions of the current process.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE on successful creation, %FALSE otherwise.
/// </return>

	public static bool MakeDirectory(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_make_directory(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously creates a directory.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T MakeDirectoryAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_make_directory_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous directory creation, started with
/// g_file_make_directory_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE on successful directory creation, %FALSE otherwise.
/// </return>

	public static bool MakeDirectoryFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_make_directory_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a directory and any parent directories that may not
/// exist similar to 'mkdir -p'. If the file system does not support
/// creating directories, this function will fail, setting @error to
/// %G_IO_ERROR_NOT_SUPPORTED. If the directory itself already exists,
/// this function will fail setting @error to %G_IO_ERROR_EXISTS, unlike
/// the similar g_mkdir_with_parents().
/// </para>
/// <para>
/// For a local #GFile the newly created directories will have the default
/// (current) ownership and permissions of the current process.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if all directories have been successfully created, %FALSE
/// otherwise.
/// </return>

	public static bool MakeDirectoryWithParents(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_make_directory_with_parents(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a symbolic link named @file which contains the string
/// @symlink_value.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile with the name of the symlink to create
/// </param>
/// <param name="symlink_value">
/// a string with the path for the target
///   of the new symlink
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE on the creation of a new symlink, %FALSE otherwise.
/// </return>

	public static bool MakeSymbolicLink(this MentorLake.Gio.GFileHandle file, string symlink_value, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_make_symbolic_link(file, symlink_value, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously creates a symbolic link named @file which contains the
/// string @symlink_value.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile with the name of the symlink to create
/// </param>
/// <param name="symlink_value">
/// a string with the path for the target
///   of the new symlink
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T MakeSymbolicLinkAsync<T>(this T file, string symlink_value, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_make_symbolic_link_async(file, symlink_value, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous symbolic link creation, started with
/// g_file_make_symbolic_link_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE on successful directory creation, %FALSE otherwise.
/// </return>

	public static bool MakeSymbolicLinkFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_make_symbolic_link_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Recursively measures the disk usage of @file.
/// </para>
/// <para>
/// This is essentially an analog of the 'du' command, but it also
/// reports the number of directories and non-directory files encountered
/// (including things like symbolic links).
/// </para>
/// <para>
/// By default, errors are only reported against the toplevel file
/// itself.  Errors found while recursing are silently ignored, unless
/// %G_FILE_MEASURE_REPORT_ANY_ERROR is given in @flags.
/// </para>
/// <para>
/// The returned size, @disk_usage, is in bytes and should be formatted
/// with g_format_size() in order to get something reasonable for showing
/// in a user interface.
/// </para>
/// <para>
/// @progress_callback and @progress_data can be given to request
/// periodic progress updates while scanning.  See the documentation for
/// #GFileMeasureProgressCallback for information about when and how the
/// callback will be invoked.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="flags">
/// #GFileMeasureFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable
/// </param>
/// <param name="progress_callback">
/// a #GFileMeasureProgressCallback
/// </param>
/// <param name="progress_data">
/// user_data for @progress_callback
/// </param>
/// <param name="disk_usage">
/// the number of bytes of disk space used
/// </param>
/// <param name="num_dirs">
/// the number of directories encountered
/// </param>
/// <param name="num_files">
/// the number of non-directories encountered
/// </param>
/// <return>
/// %TRUE if successful, with the out parameters set.
///   %FALSE otherwise, with @error set.
/// </return>

	public static bool MeasureDiskUsage(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMeasureFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileMeasureProgressCallback progress_callback, IntPtr progress_data, out ulong disk_usage, out ulong num_dirs, out ulong num_files)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_measure_disk_usage(file, flags, cancellable, progress_callback, progress_data, out disk_usage, out num_dirs, out num_files, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Recursively measures the disk usage of @file.
/// </para>
/// <para>
/// This is the asynchronous version of g_file_measure_disk_usage().  See
/// there for more information.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="flags">
/// #GFileMeasureFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable
/// </param>
/// <param name="progress_callback">
/// a #GFileMeasureProgressCallback
/// </param>
/// <param name="progress_data">
/// user_data for @progress_callback
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when complete
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T MeasureDiskUsageAsync<T>(this T file, MentorLake.Gio.GFileMeasureFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileMeasureProgressCallback progress_callback, IntPtr progress_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_measure_disk_usage_async(file, flags, io_priority, cancellable, progress_callback, progress_data, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Collects the results from an earlier call to
/// g_file_measure_disk_usage_async().  See g_file_measure_disk_usage() for
/// more information.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your #GAsyncReadyCallback
/// </param>
/// <param name="disk_usage">
/// the number of bytes of disk space used
/// </param>
/// <param name="num_dirs">
/// the number of directories encountered
/// </param>
/// <param name="num_files">
/// the number of non-directories encountered
/// </param>
/// <return>
/// %TRUE if successful, with the out parameters set.
///   %FALSE otherwise, with @error set.
/// </return>

	public static bool MeasureDiskUsageFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, out ulong disk_usage, out ulong num_dirs, out ulong num_files)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_measure_disk_usage_finish(file, result, out disk_usage, out num_dirs, out num_files, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtains a file or directory monitor for the given file,
/// depending on the type of the file.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileMonitorFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileMonitor for the given @file,
///   or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileMonitorHandle Monitor(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_monitor(file, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtains a directory monitor for the given file.
/// This may fail if directory monitoring is not supported.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// It does not make sense for @flags to contain
/// %G_FILE_MONITOR_WATCH_HARD_LINKS, since hard links can not be made to
/// directories.  It is not possible to monitor all the files in a
/// directory for changes made via hard links; if you want to do this then
/// you must register individual watches with g_file_monitor().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileMonitorFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileMonitor for the given @file,
///   or %NULL on error. Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileMonitorHandle MonitorDirectory(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_monitor_directory(file, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtains a file monitor for the given file. If no file notification
/// mechanism exists, then regular polling of the file is used.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// If @flags contains %G_FILE_MONITOR_WATCH_HARD_LINKS then the monitor
/// will also attempt to report changes made to the file via another
/// filename (ie, a hard link). Without this flag, you can only rely on
/// changes made through the filename contained in @file to be
/// reported. Using this flag may result in an increase in resource
/// usage, and may not have any effect depending on the #GFileMonitor
/// backend and/or filesystem type.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileMonitorFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileMonitor for the given @file,
///   or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileMonitorHandle MonitorFile(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_monitor_file(file, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Starts a @mount_operation, mounting the volume that contains
/// the file @location.
/// </para>
/// <para>
/// When this operation has completed, @callback will be called with
/// @user_user data, and the operation can be finalized with
/// g_file_mount_enclosing_volume_finish().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="location">
/// input #GFile
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation
///   or %NULL to avoid user interaction
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied, or %NULL
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T MountEnclosingVolume<T>(this T location, MentorLake.Gio.GMountMountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (location.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_mount_enclosing_volume(location, flags, mount_operation, cancellable, callback, user_data);
		return location;
	}

/// <summary>
/// <para>
/// Finishes a mount operation started by g_file_mount_enclosing_volume().
/// </para>
/// </summary>

/// <param name="location">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if successful. If an error has occurred,
///   this function will return %FALSE and set @error
///   appropriately if present.
/// </return>

	public static bool MountEnclosingVolumeFinish(this MentorLake.Gio.GFileHandle location, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (location.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_mount_enclosing_volume_finish(location, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Mounts a file of type G_FILE_TYPE_MOUNTABLE.
/// Using @mount_operation, you can request callbacks when, for instance,
/// passwords are needed during authentication.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_mount_mountable_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation,
///   or %NULL to avoid user interaction
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T MountMountable<T>(this T file, MentorLake.Gio.GMountMountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_mount_mountable(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes a mount operation. See g_file_mount_mountable() for details.
/// </para>
/// <para>
/// Finish an asynchronous mount operation that was started
/// with g_file_mount_mountable().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFile or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle MountMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_mount_mountable_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to move the file or directory @source to the location specified
/// by @destination. If native move operations are supported then this is
/// used, otherwise a copy + delete fallback is used. The native
/// implementation may support moving directories (for instance on moves
/// inside the same filesystem), but the fallback code does not.
/// </para>
/// <para>
/// If the flag %G_FILE_COPY_OVERWRITE is specified an already
/// existing @destination file is overwritten.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// If @progress_callback is not %NULL, then the operation can be monitored
/// by setting this to a #GFileProgressCallback function.
/// @progress_callback_data will be passed to this function. It is
/// guaranteed that this callback will be called after all data has been
/// transferred with the total number of bytes copied during the operation.
/// </para>
/// <para>
/// If the @source file does not exist, then the %G_IO_ERROR_NOT_FOUND
/// error is returned, independent on the status of the @destination.
/// </para>
/// <para>
/// If %G_FILE_COPY_OVERWRITE is not specified and the target exists,
/// then the error %G_IO_ERROR_EXISTS is returned.
/// </para>
/// <para>
/// If trying to overwrite a file over a directory, the %G_IO_ERROR_IS_DIRECTORY
/// error is returned. If trying to overwrite a directory with a directory the
/// %G_IO_ERROR_WOULD_MERGE error is returned.
/// </para>
/// <para>
/// If the source is a directory and the target does not exist, or
/// %G_FILE_COPY_OVERWRITE is specified and the target is a file, then
/// the %G_IO_ERROR_WOULD_RECURSE error may be returned (if the native
/// move operation isn't available).
/// </para>
/// </summary>

/// <param name="source">
/// #GFile pointing to the source location
/// </param>
/// <param name="destination">
/// #GFile pointing to the destination location
/// </param>
/// <param name="flags">
/// set of #GFileCopyFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="progress_callback">
/// #GFileProgressCallback
///   function for updates
/// </param>
/// <param name="progress_callback_data">
/// gpointer to user data for
///   the callback function
/// </param>
/// <return>
/// %TRUE on successful move, %FALSE otherwise.
/// </return>

	public static bool Move(this MentorLake.Gio.GFileHandle source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_move(source, destination, flags, cancellable, progress_callback, progress_callback_data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously moves a file @source to the location of @destination. For details of the behaviour, see g_file_move().
/// </para>
/// <para>
/// If @progress_callback is not %NULL, then that function that will be called
/// just like in g_file_move(). The callback will run in the default main context
/// of the thread calling g_file_move_async() — the same context as @callback is
/// run in.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// g_file_move_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="source">
/// #GFile pointing to the source location
/// </param>
/// <param name="destination">
/// #GFile pointing to the destination location
/// </param>
/// <param name="flags">
/// set of #GFileCopyFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="progress_callback">
/// 
///   #GFileProgressCallback function for updates
/// </param>
/// <param name="progress_callback_data">
/// gpointer to user data for the callback function
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T MoveAsync<T>(this T source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_move_async(source, destination, flags, io_priority, cancellable, progress_callback, progress_callback_data, callback, user_data);
		return source;
	}

/// <summary>
/// <para>
/// Version of [method@Gio.File.move_async] using closures instead of callbacks for
/// easier binding in other languages.
/// </para>
/// </summary>

/// <param name="source">
/// input [type@Gio.File]
/// </param>
/// <param name="destination">
/// destination [type@Gio.File]
/// </param>
/// <param name="flags">
/// set of [flags@Gio.FileCopyFlags]
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional [class@Gio.Cancellable] object,
///   `NULL` to ignore
/// </param>
/// <param name="progress_callback_closure">
/// [type@GObject.Closure] to invoke with progress
///   information, or `NULL` if progress information is not needed
/// </param>
/// <param name="ready_callback_closure">
/// [type@GObject.Closure] to invoke when the request is satisfied
/// </param>

	public static T MoveAsyncWithClosures<T>(this T source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GObject.GClosureHandle progress_callback_closure, MentorLake.GObject.GClosureHandle ready_callback_closure) where T : GFileHandle
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_move_async_with_closures(source, destination, flags, io_priority, cancellable, progress_callback_closure, ready_callback_closure);
		return source;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file movement, started with
/// g_file_move_async().
/// </para>
/// </summary>

/// <param name="file">
/// input source #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE on successful file move, %FALSE otherwise.
/// </return>

	public static bool MoveFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_move_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Opens an existing file for reading and writing. The result is
/// a #GFileIOStream that can be used to read and write the contents
/// of the file.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled
/// by triggering the cancellable object from another thread. If the
/// operation was cancelled, the error %G_IO_ERROR_CANCELLED will be
/// returned.
/// </para>
/// <para>
/// If the file does not exist, the %G_IO_ERROR_NOT_FOUND error will
/// be returned. If the file is a directory, the %G_IO_ERROR_IS_DIRECTORY
/// error will be returned. Other errors are possible too, and depend on
/// what kind of filesystem the file is on. Note that in many non-local
/// file cases read and write streams are not supported, so make sure you
/// really need to do read and write streaming, rather than just opening
/// for reading or writing.
/// </para>
/// </summary>

/// <param name="file">
/// #GFile to open
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// #GFileIOStream or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileIOStreamHandle OpenReadwrite(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_open_readwrite(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously opens @file for reading and writing.
/// </para>
/// <para>
/// For more details, see g_file_open_readwrite() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_open_readwrite_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T OpenReadwriteAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_open_readwrite_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file read operation started with
/// g_file_open_readwrite_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFileIOStream or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileIOStreamHandle OpenReadwriteFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_open_readwrite_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Exactly like g_file_get_path(), but caches the result via
/// g_object_set_qdata_full().  This is useful for example in C
/// applications which mix `g_file_*` APIs with native ones.  It
/// also avoids an extra duplicated string when possible, so will be
/// generally more efficient.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <return>
/// string containing the #GFile's path,
///   or %NULL if no such path exists. The returned string is owned by @file.
/// </return>

	public static string PeekPath(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_peek_path(file);
	}

/// <summary>
/// <para>
/// Polls a file of type %G_FILE_TYPE_MOUNTABLE.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_mount_mountable_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied, or %NULL
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T PollMountable<T>(this T file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_poll_mountable(file, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes a poll operation. See g_file_poll_mountable() for details.
/// </para>
/// <para>
/// Finish an asynchronous poll operation that was polled
/// with g_file_poll_mountable().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the operation finished successfully. %FALSE
/// otherwise.
/// </return>

	public static bool PollMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_poll_mountable_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the #GAppInfo that is registered as the default
/// application to handle the file specified by @file.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile to open
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <return>
/// a #GAppInfo if the handle was found,
///   %NULL if there were errors.
///   When you are done with it, release it with g_object_unref()
/// </return>

	public static MentorLake.Gio.GAppInfoHandle QueryDefaultHandler(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_query_default_handler(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Async version of g_file_query_default_handler().
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile to open
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is done
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>

	public static T QueryDefaultHandlerAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_query_default_handler_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes a g_file_query_default_handler_async() operation.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile to open
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GAppInfo if the handle was found,
///   %NULL if there were errors.
///   When you are done with it, release it with g_object_unref()
/// </return>

	public static MentorLake.Gio.GAppInfoHandle QueryDefaultHandlerFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_query_default_handler_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Utility function to check if a particular file exists.
/// </para>
/// <para>
/// The fallback implementation of this API is using [method@Gio.File.query_info]
/// and therefore may do blocking I/O. To asynchronously query the existence
/// of a file, use [method@Gio.File.query_info_async].
/// </para>
/// <para>
/// Note that in many cases it is [racy to first check for file existence](https://en.wikipedia.org/wiki/Time_of_check_to_time_of_use)
/// and then execute something based on the outcome of that, because the
/// file might have been created or removed in between the operations. The
/// general approach to handling that is to not check, but just do the
/// operation and handle the errors as they come.
/// </para>
/// <para>
/// As an example of race-free checking, take the case of reading a file,
/// and if it doesn't exist, creating it. There are two racy versions: read
/// it, and on error create it; and: check if it exists, if not create it.
/// These can both result in two processes creating the file (with perhaps
/// a partially written file as the result). The correct approach is to
/// always try to create the file with g_file_create() which will either
/// atomically create the file or fail with a %G_IO_ERROR_EXISTS error.
/// </para>
/// <para>
/// However, in many cases an existence check is useful in a user interface,
/// for instance to make a menu item sensitive/insensitive, so that you don't
/// have to fool users that something is possible and then just show an error
/// dialog. If you do this, you should make sure to also handle the errors
/// that can happen due to races when you execute the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the file exists (and can be detected without error),
///   %FALSE otherwise (or if cancelled).
/// </return>

	public static bool QueryExists(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_query_exists(file, cancellable);
	}

/// <summary>
/// <para>
/// Utility function to inspect the #GFileType of a file. This is
/// implemented using g_file_query_info() and as such does blocking I/O.
/// </para>
/// <para>
/// The primary use case of this method is to check if a file is
/// a regular file, directory, or symlink.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// a set of #GFileQueryInfoFlags passed to g_file_query_info()
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// The #GFileType of the file and %G_FILE_TYPE_UNKNOWN
///   if the file does not exist
/// </return>

	public static MentorLake.Gio.GFileType QueryFileType(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_query_file_type(file, flags, cancellable);
	}

/// <summary>
/// <para>
/// Similar to g_file_query_info(), but obtains information
/// about the filesystem the @file is on, rather than the file itself.
/// For instance the amount of space available and the type of
/// the filesystem.
/// </para>
/// <para>
/// The @attributes value is a string that specifies the attributes
/// that should be gathered. It is not an error if it's not possible
/// to read a particular requested attribute from a file - it just
/// won't be set. @attributes should be a comma-separated list of
/// attributes or attribute wildcards. The wildcard "*" means all
/// attributes, and a wildcard like "filesystem::*" means all attributes
/// in the filesystem namespace. The standard namespace for filesystem
/// attributes is "filesystem". Common attributes of interest are
/// %G_FILE_ATTRIBUTE_FILESYSTEM_SIZE (the total size of the filesystem
/// in bytes), %G_FILE_ATTRIBUTE_FILESYSTEM_FREE (number of bytes available),
/// and %G_FILE_ATTRIBUTE_FILESYSTEM_TYPE (type of the filesystem).
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled
/// by triggering the cancellable object from another thread. If the
/// operation was cancelled, the error %G_IO_ERROR_CANCELLED will be
/// returned.
/// </para>
/// <para>
/// If the file does not exist, the %G_IO_ERROR_NOT_FOUND error will
/// be returned. Other errors are possible too, and depend on what
/// kind of filesystem the file is on.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attributes">
/// an attribute query string
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileInfo or %NULL if there was an error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileInfoHandle QueryFilesystemInfo(this MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_query_filesystem_info(file, attributes, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously gets the requested information about the filesystem
/// that the specified @file is on. The result is a #GFileInfo object
/// that contains key-value attributes (such as type or size for the
/// file).
/// </para>
/// <para>
/// For more details, see g_file_query_filesystem_info() which is the
/// synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can
/// then call g_file_query_info_finish() to get the result of the
/// operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attributes">
/// an attribute query string
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T QueryFilesystemInfoAsync<T>(this T file, string attributes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_query_filesystem_info_async(file, attributes, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous filesystem info query.
/// See g_file_query_filesystem_info_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// #GFileInfo for given @file
///   or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileInfoHandle QueryFilesystemInfoFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_query_filesystem_info_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the requested information about specified @file.
/// The result is a #GFileInfo object that contains key-value
/// attributes (such as the type or size of the file).
/// </para>
/// <para>
/// The @attributes value is a string that specifies the file
/// attributes that should be gathered. It is not an error if
/// it's not possible to read a particular requested attribute
/// from a file - it just won't be set. @attributes should be a
/// comma-separated list of attributes or attribute wildcards.
/// The wildcard "*" means all attributes, and a wildcard like
/// "standard::*" means all attributes in the standard namespace.
/// An example attribute query be "standard::*,owner::user".
/// The standard attributes are available as defines, like
/// %G_FILE_ATTRIBUTE_STANDARD_NAME.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled
/// by triggering the cancellable object from another thread. If the
/// operation was cancelled, the error %G_IO_ERROR_CANCELLED will be
/// returned.
/// </para>
/// <para>
/// For symlinks, normally the information about the target of the
/// symlink is returned, rather than information about the symlink
/// itself. However if you pass %G_FILE_QUERY_INFO_NOFOLLOW_SYMLINKS
/// in @flags the information about the symlink itself will be returned.
/// Also, for symlinks that point to non-existing files the information
/// about the symlink itself will be returned.
/// </para>
/// <para>
/// If the file does not exist, the %G_IO_ERROR_NOT_FOUND error will be
/// returned. Other errors are possible too, and depend on what kind of
/// filesystem the file is on.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attributes">
/// an attribute query string
/// </param>
/// <param name="flags">
/// a set of #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileInfo for the given @file, or %NULL
///   on error. Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileInfoHandle QueryInfo(this MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_query_info(file, attributes, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously gets the requested information about specified @file.
/// The result is a #GFileInfo object that contains key-value attributes
/// (such as type or size for the file).
/// </para>
/// <para>
/// For more details, see g_file_query_info() which is the synchronous
/// version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can
/// then call g_file_query_info_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attributes">
/// an attribute query string
/// </param>
/// <param name="flags">
/// a set of #GFileQueryInfoFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T QueryInfoAsync<T>(this T file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_query_info_async(file, attributes, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file info query.
/// See g_file_query_info_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// #GFileInfo for given @file
///   or %NULL on error. Free the returned object with
///   g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileInfoHandle QueryInfoFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_query_info_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtain the list of settable attributes for the file.
/// </para>
/// <para>
/// Returns the type and full attribute name of all the attributes
/// that can be set on this file. This doesn't mean setting it will
/// always succeed though, you might get an access failure, or some
/// specific file may not support a specific attribute.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileAttributeInfoList describing the settable attributes.
///   When you are done with it, release it with
///   g_file_attribute_info_list_unref()
/// </return>

	public static MentorLake.Gio.GFileAttributeInfoListHandle QuerySettableAttributes(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_query_settable_attributes(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtain the list of attribute namespaces where new attributes
/// can be created by a user. An example of this is extended
/// attributes (in the "xattr" namespace).
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileAttributeInfoList describing the writable namespaces.
///   When you are done with it, release it with
///   g_file_attribute_info_list_unref()
/// </return>

	public static MentorLake.Gio.GFileAttributeInfoListHandle QueryWritableNamespaces(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_query_writable_namespaces(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Opens a file for reading. The result is a #GFileInputStream that
/// can be used to read the contents of the file.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// If the file does not exist, the %G_IO_ERROR_NOT_FOUND error will be
/// returned. If the file is a directory, the %G_IO_ERROR_IS_DIRECTORY
/// error will be returned. Other errors are possible too, and depend
/// on what kind of filesystem the file is on.
/// </para>
/// </summary>

/// <param name="file">
/// #GFile to read
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// #GFileInputStream or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileInputStreamHandle Read(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_read(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously opens @file for reading.
/// </para>
/// <para>
/// For more details, see g_file_read() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_read_finish() to get the result
/// of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReadAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_read_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file read operation started with
/// g_file_read_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFileInputStream or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileInputStreamHandle ReadFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_read_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns an output stream for overwriting the file, possibly
/// creating a backup copy of the file first. If the file doesn't exist,
/// it will be created.
/// </para>
/// <para>
/// This will try to replace the file in the safest way possible so
/// that any errors during the writing will not affect an already
/// existing copy of the file. For instance, for local files it
/// may write to a temporary file and then atomically rename over
/// the destination when the stream is closed.
/// </para>
/// <para>
/// By default files created are generally readable by everyone,
/// but if you pass %G_FILE_CREATE_PRIVATE in @flags the file
/// will be made readable only to the current user, to the level that
/// is supported on the target filesystem.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled
/// by triggering the cancellable object from another thread. If the
/// operation was cancelled, the error %G_IO_ERROR_CANCELLED will be
/// returned.
/// </para>
/// <para>
/// If you pass in a non-%NULL @etag value and @file already exists, then
/// this value is compared to the current entity tag of the file, and if
/// they differ an %G_IO_ERROR_WRONG_ETAG error is returned. This
/// generally means that the file has been changed since you last read
/// it. You can get the new etag from g_file_output_stream_get_etag()
/// after you've finished writing and closed the #GFileOutputStream. When
/// you load a new file you can use g_file_input_stream_query_info() to
/// get the etag of the file.
/// </para>
/// <para>
/// If @make_backup is %TRUE, this function will attempt to make a
/// backup of the current file before overwriting it. If this fails
/// a %G_IO_ERROR_CANT_CREATE_BACKUP error will be returned. If you
/// want to replace anyway, try again with @make_backup set to %FALSE.
/// </para>
/// <para>
/// If the file is a directory the %G_IO_ERROR_IS_DIRECTORY error will
/// be returned, and if the file is some other form of non-regular file
/// then a %G_IO_ERROR_NOT_REGULAR_FILE error will be returned. Some
/// file systems don't allow all file names, and may return an
/// %G_IO_ERROR_INVALID_FILENAME error, and if the name is to long
/// %G_IO_ERROR_FILENAME_TOO_LONG will be returned. Other errors are
/// possible too, and depend on what kind of filesystem the file is on.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="etag">
/// an optional [entity tag](#entity-tags)
///   for the current #GFile, or #NULL to ignore
/// </param>
/// <param name="make_backup">
/// %TRUE if a backup should be created
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileOutputStream or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileOutputStreamHandle Replace(this MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_replace(file, etag, make_backup, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously overwrites the file, replacing the contents,
/// possibly creating a backup copy of the file first.
/// </para>
/// <para>
/// For more details, see g_file_replace() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_replace_finish() to get the result
/// of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="etag">
/// an [entity tag](#entity-tags) for the current #GFile,
///   or %NULL to ignore
/// </param>
/// <param name="make_backup">
/// %TRUE if a backup should be created
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReplaceAsync<T>(this T file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_replace_async(file, etag, make_backup, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Replaces the contents of @file with @contents of @length bytes.
/// </para>
/// <para>
/// If @etag is specified (not %NULL), any existing file must have that etag,
/// or the error %G_IO_ERROR_WRONG_ETAG will be returned.
/// </para>
/// <para>
/// If @make_backup is %TRUE, this function will attempt to make a backup
/// of @file. Internally, it uses g_file_replace(), so will try to replace the
/// file contents in the safest way possible. For example, atomic renames are
/// used when replacing local files’ contents.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// The returned @new_etag can be used to verify that the file hasn't
/// changed the next time it is saved over.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="contents">
/// a string containing the new contents for @file
/// </param>
/// <param name="length">
/// the length of @contents in bytes
/// </param>
/// <param name="etag">
/// the old [entity-tag](#entity-tags) for the document,
///   or %NULL
/// </param>
/// <param name="make_backup">
/// %TRUE if a backup should be created
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="new_etag">
/// a location to a new [entity tag](#entity-tags)
///   for the document. This should be freed with g_free() when no longer
///   needed, or %NULL
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <return>
/// %TRUE if successful. If an error has occurred, this function
///   will return %FALSE and set @error appropriately if present.
/// </return>

	public static bool ReplaceContents(this MentorLake.Gio.GFileHandle file, byte[] contents, UIntPtr length, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, out string new_etag, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_replace_contents(file, contents, length, etag, make_backup, flags, out new_etag, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Starts an asynchronous replacement of @file with the given
/// @contents of @length bytes. @etag will replace the document's
/// current entity tag.
/// </para>
/// <para>
/// When this operation has completed, @callback will be called with
/// @user_user data, and the operation can be finalized with
/// g_file_replace_contents_finish().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// If @make_backup is %TRUE, this function will attempt to
/// make a backup of @file.
/// </para>
/// <para>
/// Note that no copy of @contents will be made, so it must stay valid
/// until @callback is called. See g_file_replace_contents_bytes_async()
/// for a #GBytes version that will automatically hold a reference to the
/// contents (without copying) for the duration of the call.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="contents">
/// string of contents to replace the file with
/// </param>
/// <param name="length">
/// the length of @contents in bytes
/// </param>
/// <param name="etag">
/// a new [entity tag](#entity-tags) for the @file, or %NULL
/// </param>
/// <param name="make_backup">
/// %TRUE if a backup should be created
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReplaceContentsAsync<T>(this T file, byte[] contents, UIntPtr length, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_replace_contents_async(file, contents, length, etag, make_backup, flags, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Same as g_file_replace_contents_async() but takes a #GBytes input instead.
/// This function will keep a ref on @contents until the operation is done.
/// Unlike g_file_replace_contents_async() this allows forgetting about the
/// content without waiting for the callback.
/// </para>
/// <para>
/// When this operation has completed, @callback will be called with
/// @user_user data, and the operation can be finalized with
/// g_file_replace_contents_finish().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="contents">
/// a #GBytes
/// </param>
/// <param name="etag">
/// a new [entity tag](#entity-tags) for the @file, or %NULL
/// </param>
/// <param name="make_backup">
/// %TRUE if a backup should be created
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReplaceContentsBytesAsync<T>(this T file, MentorLake.GLib.GBytesHandle contents, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_replace_contents_bytes_async(file, contents, etag, make_backup, flags, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous replace of the given @file. See
/// g_file_replace_contents_async(). Sets @new_etag to the new entity
/// tag for the document, if present.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <param name="new_etag">
/// a location of a new [entity tag](#entity-tags)
///   for the document. This should be freed with g_free() when it is no
///   longer needed, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE on failure.
/// </return>

	public static bool ReplaceContentsFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, out string new_etag)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_replace_contents_finish(file, res, out new_etag, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file replace operation started with
/// g_file_replace_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFileOutputStream, or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileOutputStreamHandle ReplaceFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_replace_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns an output stream for overwriting the file in readwrite mode,
/// possibly creating a backup copy of the file first. If the file doesn't
/// exist, it will be created.
/// </para>
/// <para>
/// For details about the behaviour, see g_file_replace() which does the
/// same thing but returns an output stream only.
/// </para>
/// <para>
/// Note that in many non-local file cases read and write streams are not
/// supported, so make sure you really need to do read and write streaming,
/// rather than just opening for reading or writing.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <param name="etag">
/// an optional [entity tag](#entity-tags)
///   for the current #GFile, or #NULL to ignore
/// </param>
/// <param name="make_backup">
/// %TRUE if a backup should be created
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFileIOStream or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileIOStreamHandle ReplaceReadwrite(this MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_replace_readwrite(file, etag, make_backup, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously overwrites the file in read-write mode,
/// replacing the contents, possibly creating a backup copy
/// of the file first.
/// </para>
/// <para>
/// For more details, see g_file_replace_readwrite() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_replace_readwrite_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="etag">
/// an [entity tag](#entity-tags) for the current #GFile,
///   or %NULL to ignore
/// </param>
/// <param name="make_backup">
/// %TRUE if a backup should be created
/// </param>
/// <param name="flags">
/// a set of #GFileCreateFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReplaceReadwriteAsync<T>(this T file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_replace_readwrite_async(file, etag, make_backup, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file replace operation started with
/// g_file_replace_readwrite_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFileIOStream, or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileIOStreamHandle ReplaceReadwriteFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_replace_readwrite_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Resolves a relative path for @file to an absolute path.
/// </para>
/// <para>
/// This call does no blocking I/O.
/// </para>
/// <para>
/// If the @relative_path is an absolute path name, the resolution
/// is done absolutely (without taking @file path as base).
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="relative_path">
/// a given relative path string
/// </param>
/// <return>
/// a #GFile for the resolved path.
/// </return>

	public static MentorLake.Gio.GFileHandle ResolveRelativePath(this MentorLake.Gio.GFileHandle file, string relative_path)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_resolve_relative_path(file, relative_path);
	}

/// <summary>
/// <para>
/// Sets an attribute in the file with attribute name @attribute to @value_p.
/// </para>
/// <para>
/// Some attributes can be unset by setting @type to
/// %G_FILE_ATTRIBUTE_TYPE_INVALID and @value_p to %NULL.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attribute">
/// a string containing the attribute's name
/// </param>
/// <param name="type">
/// The type of the attribute
/// </param>
/// <param name="value_p">
/// a pointer to the value (or the pointer
///   itself if the type is a pointer type)
/// </param>
/// <param name="flags">
/// a set of #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the attribute was set, %FALSE otherwise.
/// </return>

	public static bool SetAttribute(this MentorLake.Gio.GFileHandle file, string attribute, MentorLake.Gio.GFileAttributeType type, IntPtr value_p, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attribute(file, attribute, type, value_p, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @attribute of type %G_FILE_ATTRIBUTE_TYPE_BYTE_STRING to @value.
/// If @attribute is of a different type, this operation will fail,
/// returning %FALSE.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attribute">
/// a string containing the attribute's name
/// </param>
/// <param name="value">
/// a string containing the attribute's new value
/// </param>
/// <param name="flags">
/// a #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the @attribute was successfully set to @value
///   in the @file, %FALSE otherwise.
/// </return>

	public static bool SetAttributeByteString(this MentorLake.Gio.GFileHandle file, string attribute, string value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attribute_byte_string(file, attribute, value, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @attribute of type %G_FILE_ATTRIBUTE_TYPE_INT32 to @value.
/// If @attribute is of a different type, this operation will fail.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attribute">
/// a string containing the attribute's name
/// </param>
/// <param name="value">
/// a #gint32 containing the attribute's new value
/// </param>
/// <param name="flags">
/// a #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the @attribute was successfully set to @value
///   in the @file, %FALSE otherwise.
/// </return>

	public static bool SetAttributeInt32(this MentorLake.Gio.GFileHandle file, string attribute, int value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attribute_int32(file, attribute, value, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @attribute of type %G_FILE_ATTRIBUTE_TYPE_INT64 to @value.
/// If @attribute is of a different type, this operation will fail.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attribute">
/// a string containing the attribute's name
/// </param>
/// <param name="value">
/// a #guint64 containing the attribute's new value
/// </param>
/// <param name="flags">
/// a #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the @attribute was successfully set, %FALSE otherwise.
/// </return>

	public static bool SetAttributeInt64(this MentorLake.Gio.GFileHandle file, string attribute, long value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attribute_int64(file, attribute, value, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @attribute of type %G_FILE_ATTRIBUTE_TYPE_STRING to @value.
/// If @attribute is of a different type, this operation will fail.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attribute">
/// a string containing the attribute's name
/// </param>
/// <param name="value">
/// a string containing the attribute's value
/// </param>
/// <param name="flags">
/// #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the @attribute was successfully set, %FALSE otherwise.
/// </return>

	public static bool SetAttributeString(this MentorLake.Gio.GFileHandle file, string attribute, string value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attribute_string(file, attribute, value, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @attribute of type %G_FILE_ATTRIBUTE_TYPE_UINT32 to @value.
/// If @attribute is of a different type, this operation will fail.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attribute">
/// a string containing the attribute's name
/// </param>
/// <param name="value">
/// a #guint32 containing the attribute's new value
/// </param>
/// <param name="flags">
/// a #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the @attribute was successfully set to @value
///   in the @file, %FALSE otherwise.
/// </return>

	public static bool SetAttributeUint32(this MentorLake.Gio.GFileHandle file, string attribute, uint value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attribute_uint32(file, attribute, value, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @attribute of type %G_FILE_ATTRIBUTE_TYPE_UINT64 to @value.
/// If @attribute is of a different type, this operation will fail.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="attribute">
/// a string containing the attribute's name
/// </param>
/// <param name="value">
/// a #guint64 containing the attribute's new value
/// </param>
/// <param name="flags">
/// a #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE if the @attribute was successfully set to @value
///   in the @file, %FALSE otherwise.
/// </return>

	public static bool SetAttributeUint64(this MentorLake.Gio.GFileHandle file, string attribute, ulong value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attribute_uint64(file, attribute, value, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously sets the attributes of @file with @info.
/// </para>
/// <para>
/// For more details, see g_file_set_attributes_from_info(),
/// which is the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_set_attributes_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="info">
/// a #GFileInfo
/// </param>
/// <param name="flags">
/// a #GFileQueryInfoFlags
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T SetAttributesAsync<T>(this T file, MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_set_attributes_async(file, info, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes setting an attribute started in g_file_set_attributes_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <param name="info">
/// a #GFileInfo
/// </param>
/// <return>
/// %TRUE if the attributes were set correctly, %FALSE otherwise.
/// </return>

	public static bool SetAttributesFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, out MentorLake.Gio.GFileInfoHandle info)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attributes_finish(file, result, out info, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to set all attributes in the #GFileInfo on the target
/// values, not stopping on the first error.
/// </para>
/// <para>
/// If there is any error during this operation then @error will
/// be set to the first error. Error on particular fields are flagged
/// by setting the "status" field in the attribute value to
/// %G_FILE_ATTRIBUTE_STATUS_ERROR_SETTING, which means you can
/// also detect further errors.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="info">
/// a #GFileInfo
/// </param>
/// <param name="flags">
/// #GFileQueryInfoFlags
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %FALSE if there was any error, %TRUE otherwise.
/// </return>

	public static bool SetAttributesFromInfo(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_attributes_from_info(file, info, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Renames @file to the specified display name.
/// </para>
/// <para>
/// The display name is converted from UTF-8 to the correct encoding
/// for the target filesystem if possible and the @file is renamed to this.
/// </para>
/// <para>
/// If you want to implement a rename operation in the user interface the
/// edit name (%G_FILE_ATTRIBUTE_STANDARD_EDIT_NAME) should be used as the
/// initial value in the rename widget, and then the result after editing
/// should be passed to g_file_set_display_name().
/// </para>
/// <para>
/// On success the resulting converted filename is returned.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="display_name">
/// a string
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// a #GFile specifying what @file was renamed to,
///   or %NULL if there was an error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle SetDisplayName(this MentorLake.Gio.GFileHandle file, string display_name, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_display_name(file, display_name, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously sets the display name for a given #GFile.
/// </para>
/// <para>
/// For more details, see g_file_set_display_name() which is
/// the synchronous version of this call.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_set_display_name_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="display_name">
/// a string
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T SetDisplayNameAsync<T>(this T file, string display_name, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_set_display_name_async(file, display_name, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes setting a display name started with
/// g_file_set_display_name_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="res">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GFile or %NULL on error.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle SetDisplayNameFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_set_display_name_finish(file, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Starts a file of type %G_FILE_TYPE_MOUNTABLE.
/// Using @start_operation, you can request callbacks when, for instance,
/// passwords are needed during authentication.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_mount_mountable_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="start_operation">
/// a #GMountOperation, or %NULL to avoid user interaction
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied, or %NULL
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T StartMountable<T>(this T file, MentorLake.Gio.GDriveStartFlags flags, MentorLake.Gio.GMountOperationHandle start_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_start_mountable(file, flags, start_operation, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes a start operation. See g_file_start_mountable() for details.
/// </para>
/// <para>
/// Finish an asynchronous start operation that was started
/// with g_file_start_mountable().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the operation finished successfully. %FALSE
/// otherwise.
/// </return>

	public static bool StartMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_start_mountable_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Stops a file of type %G_FILE_TYPE_MOUNTABLE.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_stop_mountable_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation,
///   or %NULL to avoid user interaction.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied, or %NULL
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T StopMountable<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_stop_mountable(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes a stop operation, see g_file_stop_mountable() for details.
/// </para>
/// <para>
/// Finish an asynchronous stop operation that was started
/// with g_file_stop_mountable().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the operation finished successfully.
///   %FALSE otherwise.
/// </return>

	public static bool StopMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_stop_mountable_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if @file supports
/// [thread-default contexts][g-main-context-push-thread-default-context].
/// If this returns %FALSE, you cannot perform asynchronous operations on
/// @file in a thread that has a thread-default context.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile
/// </param>
/// <return>
/// Whether or not @file supports thread-default contexts.
/// </return>

	public static bool SupportsThreadContexts(this MentorLake.Gio.GFileHandle file)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		return GFileHandleExterns.g_file_supports_thread_contexts(file);
	}

/// <summary>
/// <para>
/// Sends @file to the "Trashcan", if possible. This is similar to
/// deleting it, but the user can recover it before emptying the trashcan.
/// Trashing is disabled for system mounts by default (see
/// g_unix_mount_entry_is_system_internal()), so this call can return the
/// %G_IO_ERROR_NOT_SUPPORTED error. Since GLib 2.66, the `x-gvfs-notrash` unix
/// mount option can be used to disable g_file_trash() support for particular
/// mounts, the %G_IO_ERROR_NOT_SUPPORTED error will be returned in that case.
/// Since 2.82, the `x-gvfs-trash` unix mount option can be used to enable
/// g_file_trash() support for particular system mounts.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="file">
/// #GFile to send to trash
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <return>
/// %TRUE on successful trash, %FALSE otherwise.
/// </return>

	public static bool Trash(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_trash(file, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously sends @file to the Trash location, if possible.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T TrashAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_trash_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous file trashing operation, started with
/// g_file_trash_async().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE on successful trash, %FALSE otherwise.
/// </return>

	public static bool TrashFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_trash_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Unmounts a file of type G_FILE_TYPE_MOUNTABLE.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_unmount_mountable_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T UnmountMountable<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_unmount_mountable(file, flags, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an unmount operation, see g_file_unmount_mountable() for details.
/// </para>
/// <para>
/// Finish an asynchronous unmount operation that was started
/// with g_file_unmount_mountable().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the operation finished successfully.
///   %FALSE otherwise.
/// </return>

	public static bool UnmountMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_unmount_mountable_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Unmounts a file of type %G_FILE_TYPE_MOUNTABLE.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_file_unmount_mountable_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation,
///   or %NULL to avoid user interaction
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object,
///   %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T UnmountMountableWithOperation<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		GFileHandleExterns.g_file_unmount_mountable_with_operation(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

/// <summary>
/// <para>
/// Finishes an unmount operation,
/// see g_file_unmount_mountable_with_operation() for details.
/// </para>
/// <para>
/// Finish an asynchronous unmount operation that was started
/// with g_file_unmount_mountable_with_operation().
/// </para>
/// </summary>

/// <param name="file">
/// input #GFile
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the operation finished successfully.
///   %FALSE otherwise.
/// </return>

	public static bool UnmountMountableWithOperationFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (file.IsInvalid) throw new Exception("Invalid handle (GFileHandle)");
		var externCallResult = GFileHandleExterns.g_file_unmount_mountable_with_operation_finish(file, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Constructs a #GFile from a series of elements using the correct
/// separator for filenames.
/// </para>
/// <para>
/// Using this function is equivalent to calling g_build_filename(),
/// followed by g_file_new_for_path() on the result.
/// </para>
/// </summary>

/// <param name="first_element">
/// the first element in the path
/// </param>
/// <param name="@__arglist">
/// remaining elements in path, terminated by %NULL
/// </param>
/// <return>
/// a new #GFile
/// </return>

	public static MentorLake.Gio.GFileHandle NewBuildFilename(string first_element, IntPtr @__arglist)
	{
		return GFileHandleExterns.g_file_new_build_filename(first_element, @__arglist);
	}

/// <summary>
/// <para>
/// Constructs a #GFile from a vector of elements using the correct
/// separator for filenames.
/// </para>
/// <para>
/// Using this function is equivalent to calling g_build_filenamev(),
/// followed by g_file_new_for_path() on the result.
/// </para>
/// </summary>

/// <param name="args">
/// %NULL-terminated
///   array of strings containing the path elements.
/// </param>
/// <return>
/// a new #GFile
/// </return>

	public static MentorLake.Gio.GFileHandle NewBuildFilenamev(string[] args)
	{
		return GFileHandleExterns.g_file_new_build_filenamev(args);
	}

/// <summary>
/// <para>
/// Creates a #GFile with the given argument from the command line.
/// The value of @arg can be either a URI, an absolute path or a
/// relative path resolved relative to the current working directory.
/// This operation never fails, but the returned object might not
/// support any I/O operation if @arg points to a malformed path.
/// </para>
/// <para>
/// Note that on Windows, this function expects its argument to be in
/// UTF-8 -- not the system code page.  This means that you
/// should not use this function with string from argv as it is passed
/// to main().  g_win32_get_command_line() will return a UTF-8 version of
/// the commandline.  #GApplication also uses UTF-8 but
/// g_application_command_line_create_file_for_arg() may be more useful
/// for you there.  It is also always possible to use this function with
/// #GOptionContext arguments of type %G_OPTION_ARG_FILENAME.
/// </para>
/// </summary>

/// <param name="arg">
/// a command line string
/// </param>
/// <return>
/// a new #GFile.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle NewForCommandlineArg(string arg)
	{
		return GFileHandleExterns.g_file_new_for_commandline_arg(arg);
	}

/// <summary>
/// <para>
/// Creates a #GFile with the given argument from the command line.
/// </para>
/// <para>
/// This function is similar to g_file_new_for_commandline_arg() except
/// that it allows for passing the current working directory as an
/// argument instead of using the current working directory of the
/// process.
/// </para>
/// <para>
/// This is useful if the commandline argument was given in a context
/// other than the invocation of the current process.
/// </para>
/// <para>
/// See also g_application_command_line_create_file_for_arg().
/// </para>
/// </summary>

/// <param name="arg">
/// a command line string
/// </param>
/// <param name="cwd">
/// the current working directory of the commandline
/// </param>
/// <return>
/// a new #GFile
/// </return>

	public static MentorLake.Gio.GFileHandle NewForCommandlineArgAndCwd(string arg, string cwd)
	{
		return GFileHandleExterns.g_file_new_for_commandline_arg_and_cwd(arg, cwd);
	}

/// <summary>
/// <para>
/// Constructs a #GFile for a given path. This operation never
/// fails, but the returned object might not support any I/O
/// operation if @path is malformed.
/// </para>
/// </summary>

/// <param name="path">
/// a string containing a relative or absolute path.
///   The string must be encoded in the glib filename encoding.
/// </param>
/// <return>
/// a new #GFile for the given @path.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle NewForPath(string path)
	{
		return GFileHandleExterns.g_file_new_for_path(path);
	}

/// <summary>
/// <para>
/// Constructs a #GFile for a given URI. This operation never
/// fails, but the returned object might not support any I/O
/// operation if @uri is malformed or if the uri type is
/// not supported.
/// </para>
/// </summary>

/// <param name="uri">
/// a UTF-8 string containing a URI
/// </param>
/// <return>
/// a new #GFile for the given @uri.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle NewForUri(string uri)
	{
		return GFileHandleExterns.g_file_new_for_uri(uri);
	}

/// <summary>
/// <para>
/// Opens a file in the preferred directory for temporary files (as
/// returned by g_get_tmp_dir()) and returns a #GFile and
/// #GFileIOStream pointing to it.
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding
/// containing a sequence of six 'X' characters, and containing no
/// directory components. If it is %NULL, a default template is used.
/// </para>
/// <para>
/// Unlike the other #GFile constructors, this will return %NULL if
/// a temporary file could not be created.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for the file
///   name, as in g_file_open_tmp(), or %NULL for a default template
/// </param>
/// <param name="iostream">
/// on return, a #GFileIOStream for the created file
/// </param>
/// <return>
/// a new #GFile.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle NewTmp(string tmpl, out MentorLake.Gio.GFileIOStreamHandle iostream)
	{
		var externCallResult = GFileHandleExterns.g_file_new_tmp(tmpl, out iostream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously opens a file in the preferred directory for temporary files
///  (as returned by g_get_tmp_dir()) as g_file_new_tmp().
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding
/// containing a sequence of six 'X' characters, and containing no
/// directory components. If it is %NULL, a default template is used.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for the file
///   name, as in g_file_open_tmp(), or %NULL for a default template
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is done
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>

	public static void NewTmpAsync(string tmpl, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileHandleExterns.g_file_new_tmp_async(tmpl, io_priority, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Asynchronously creates a directory in the preferred directory for
/// temporary files (as returned by g_get_tmp_dir()) as g_dir_make_tmp().
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding
/// containing a sequence of six 'X' characters, and containing no
/// directory components. If it is %NULL, a default template is used.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for the file
///   name, as in g_dir_make_tmp(), or %NULL for a default template
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is done
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>

	public static void NewTmpDirAsync(string tmpl, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileHandleExterns.g_file_new_tmp_dir_async(tmpl, io_priority, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes a temporary directory creation started by
/// g_file_new_tmp_dir_async().
/// </para>
/// </summary>

/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a new #GFile.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle NewTmpDirFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GFileHandleExterns.g_file_new_tmp_dir_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes a temporary file creation started by g_file_new_tmp_async().
/// </para>
/// </summary>

/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <param name="iostream">
/// on return, a #GFileIOStream for the created file
/// </param>
/// <return>
/// a new #GFile.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle NewTmpFinish(MentorLake.Gio.GAsyncResultHandle result, out MentorLake.Gio.GFileIOStreamHandle iostream)
	{
		var externCallResult = GFileHandleExterns.g_file_new_tmp_finish(result, out iostream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Constructs a #GFile with the given @parse_name (i.e. something
/// given by g_file_get_parse_name()). This operation never fails,
/// but the returned object might not support any I/O operation if
/// the @parse_name cannot be parsed.
/// </para>
/// </summary>

/// <param name="parse_name">
/// a file name or path to be parsed
/// </param>
/// <return>
/// a new #GFile.
/// </return>

	public static MentorLake.Gio.GFileHandle ParseName(string parse_name)
	{
		return GFileHandleExterns.g_file_parse_name(parse_name);
	}

}

internal class GFileHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_append_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_append_to_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_append_to_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_build_attribute_list_for_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCopyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_copy_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_copy_async_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle progress_callback_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle ready_callback_closure);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_copy_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_copy_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_create_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_create_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_create_readwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_create_readwrite_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_create_readwrite_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_delete_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_delete_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_dup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_eject_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_eject_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_eject_mountable_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_eject_mountable_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))]
	internal static extern MentorLake.Gio.GFileEnumeratorHandle g_file_enumerate_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_enumerate_children_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))]
	internal static extern MentorLake.Gio.GFileEnumeratorHandle g_file_enumerate_children_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file2);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))]
	internal static extern MentorLake.Gio.GMountHandle g_file_find_enclosing_mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_find_enclosing_mount_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))]
	internal static extern MentorLake.Gio.GMountHandle g_file_find_enclosing_mount_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_basename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_get_child_for_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string display_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_parse_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_relative_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle descendant);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_has_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle parent);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_has_prefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle prefix);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_has_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string uri_scheme);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_file_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_is_native([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_file_load_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out string etag_out, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_load_bytes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_file_load_bytes_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out string etag_out, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_load_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out byte[] contents, out UIntPtr length, out string etag_out, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_load_contents_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_load_contents_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out byte[] contents, out UIntPtr length, out string etag_out, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_load_partial_contents_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileReadMoreCallback read_more_callback, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_load_partial_contents_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out byte[] contents, out UIntPtr length, out string etag_out, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_make_directory_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_directory_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_directory_with_parents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_symbolic_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string symlink_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_make_symbolic_link_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string symlink_value, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_symbolic_link_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_measure_disk_usage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMeasureFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileMeasureProgressCallback progress_callback, IntPtr progress_data, out ulong disk_usage, out ulong num_dirs, out ulong num_files, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_measure_disk_usage_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMeasureFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileMeasureProgressCallback progress_callback, IntPtr progress_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_measure_disk_usage_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out ulong disk_usage, out ulong num_dirs, out ulong num_files, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))]
	internal static extern MentorLake.Gio.GFileMonitorHandle g_file_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))]
	internal static extern MentorLake.Gio.GFileMonitorHandle g_file_monitor_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))]
	internal static extern MentorLake.Gio.GFileMonitorHandle g_file_monitor_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_mount_enclosing_volume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location, MentorLake.Gio.GMountMountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_mount_enclosing_volume_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_mount_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountMountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_mount_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_move_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_move_async_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle progress_callback_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle ready_callback_closure);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_move_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_open_readwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_open_readwrite_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_open_readwrite_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_peek_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_poll_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_poll_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_file_query_default_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_query_default_handler_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_file_query_default_handler_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_query_exists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileType g_file_query_file_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_query_filesystem_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_query_filesystem_info_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_query_filesystem_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_query_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_query_info_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_query_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_query_settable_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_query_writable_namespaces([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInputStreamHandle>))]
	internal static extern MentorLake.Gio.GFileInputStreamHandle g_file_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_read_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInputStreamHandle>))]
	internal static extern MentorLake.Gio.GFileInputStreamHandle g_file_read_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_replace_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_replace_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, byte[] contents, UIntPtr length, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, out string new_etag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_replace_contents_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, byte[] contents, UIntPtr length, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_replace_contents_bytes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle contents, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_replace_contents_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out string new_etag, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_replace_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_replace_readwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_replace_readwrite_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_replace_readwrite_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_resolve_relative_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string relative_path);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, MentorLake.Gio.GFileAttributeType type, IntPtr value_p, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_byte_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, string value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, int value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, long value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, string value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, uint value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, ulong value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_set_attributes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attributes_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] out MentorLake.Gio.GFileInfoHandle info, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attributes_from_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_set_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string display_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_set_display_name_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string display_name, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_set_display_name_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_start_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GDriveStartFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle start_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_start_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_stop_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_stop_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_supports_thread_contexts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_trash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_trash_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_trash_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_unmount_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_unmount_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_unmount_mountable_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_unmount_mountable_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_build_filename(string first_element, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_build_filenamev(string[] args);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_commandline_arg(string arg);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_commandline_arg_and_cwd(string arg, string cwd);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_path(string path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_uri(string uri);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp(string tmpl, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] out MentorLake.Gio.GFileIOStreamHandle iostream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_new_tmp_async(string tmpl, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_new_tmp_dir_async(string tmpl, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp_dir_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] out MentorLake.Gio.GFileIOStreamHandle iostream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_parse_name(string parse_name);

}
