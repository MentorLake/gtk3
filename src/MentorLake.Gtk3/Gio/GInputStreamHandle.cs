namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GInputStream` is a base class for implementing streaming input.
/// </para>
/// <para>
/// It has functions to read from a stream ([method@Gio.InputStream.read]),
/// to close a stream ([method@Gio.InputStream.close]) and to skip some content
/// ([method@Gio.InputStream.skip]).
/// </para>
/// <para>
/// To copy the content of an input stream to an output stream without
/// manually handling the reads and writes, use [method@Gio.OutputStream.splice].
/// </para>
/// <para>
/// See the documentation for [class@Gio.IOStream] for details of thread safety
/// of streaming APIs.
/// </para>
/// <para>
/// All of these functions have async variants too.
/// </para>
/// </summary>

public class GInputStreamHandle : GObjectHandle
{
}

public static class GInputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Clears the pending flag on @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// input stream
/// </param>

	public static T ClearPending<T>(this T stream) where T : GInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		GInputStreamHandleExterns.g_input_stream_clear_pending(stream);
		return stream;
	}

/// <summary>
/// <para>
/// Closes the stream, releasing resources related to it.
/// </para>
/// <para>
/// Once the stream is closed, all other operations will return %G_IO_ERROR_CLOSED.
/// Closing a stream multiple times will not return an error.
/// </para>
/// <para>
/// Streams will be automatically closed when the last reference
/// is dropped, but you might want to call this function to make sure
/// resources are released as early as possible.
/// </para>
/// <para>
/// Some streams might keep the backing store of the stream (e.g. a file descriptor)
/// open after the stream is closed. See the documentation for the individual
/// stream for details.
/// </para>
/// <para>
/// On failure the first error that happened will be reported, but the close
/// operation will finish as much as possible. A stream that failed to
/// close will still return %G_IO_ERROR_CLOSED for all operations. Still, it
/// is important to check and report the error to the user.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// Cancelling a close will still leave the stream closed, but some streams
/// can use a faster close that doesn&apos;t block to e.g. check errors.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GInputStream.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// %TRUE on success, %FALSE on failure
/// </return>

	public static bool Close(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_close(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Requests an asynchronous closes of the stream, releasing resources related to it.
/// When the operation is finished @callback will be called.
/// You can then call g_input_stream_close_finish() to get the result of the
/// operation.
/// </para>
/// <para>
/// For behaviour details see g_input_stream_close().
/// </para>
/// <para>
/// The asynchronous methods have a default fallback that uses threads to implement
/// asynchronicity, so they are optional for inheriting classes. However, if you
/// override one you must override all.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GInputStream.
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional cancellable object
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T CloseAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		GInputStreamHandleExterns.g_input_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes closing a stream asynchronously, started from g_input_stream_close_async().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the stream was closed successfully.
/// </return>

	public static bool CloseFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_close_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if an input stream has pending actions.
/// </para>
/// </summary>

/// <param name="stream">
/// input stream.
/// </param>
/// <return>
/// %TRUE if @stream has pending actions.
/// </return>

	public static bool HasPending(this MentorLake.Gio.GInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		return GInputStreamHandleExterns.g_input_stream_has_pending(stream);
	}

/// <summary>
/// <para>
/// Checks if an input stream is closed.
/// </para>
/// </summary>

/// <param name="stream">
/// input stream.
/// </param>
/// <return>
/// %TRUE if the stream is closed.
/// </return>

	public static bool IsClosed(this MentorLake.Gio.GInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		return GInputStreamHandleExterns.g_input_stream_is_closed(stream);
	}

/// <summary>
/// <para>
/// Tries to read @count bytes from the stream into the buffer starting at
/// @buffer. Will block during this read.
/// </para>
/// <para>
/// If count is zero returns zero and does nothing. A value of @count
/// larger than %G_MAXSSIZE will cause a %G_IO_ERROR_INVALID_ARGUMENT error.
/// </para>
/// <para>
/// On success, the number of bytes read into the buffer is returned.
/// It is not an error if this is not the same as the requested size, as it
/// can happen e.g. near the end of a file. Zero is returned on end of file
/// (or if @count is zero),  but never otherwise.
/// </para>
/// <para>
/// The returned @buffer is not a nul-terminated string, it can contain nul bytes
/// at any position, and this function doesn&apos;t nul-terminate the @buffer.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned. If an
/// operation was partially finished when the operation was cancelled the
/// partial result will be returned, without an error.
/// </para>
/// <para>
/// On error -1 is returned and @error is set accordingly.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream.
/// </param>
/// <param name="buffer">
/// 
///   a buffer to read data into (which should be at least count bytes long).
/// </param>
/// <param name="count">
/// the number of bytes that will be read from the stream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// Number of bytes read, or -1 on error, or 0 on end of file.
/// </return>

	public static UIntPtr Read(this MentorLake.Gio.GInputStreamHandle stream, out byte[] buffer, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_read(stream, out buffer, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to read @count bytes from the stream into the buffer starting at
/// @buffer. Will block during this read.
/// </para>
/// <para>
/// This function is similar to g_input_stream_read(), except it tries to
/// read as many bytes as requested, only stopping on an error or end of stream.
/// </para>
/// <para>
/// On a successful read of @count bytes, or if we reached the end of the
/// stream,  %TRUE is returned, and @bytes_read is set to the number of bytes
/// read into @buffer.
/// </para>
/// <para>
/// If there is an error during the operation %FALSE is returned and @error
/// is set to indicate the error status.
/// </para>
/// <para>
/// As a special exception to the normal conventions for functions that
/// use #GError, if this function returns %FALSE (and sets @error) then
/// @bytes_read will be set to the number of bytes that were successfully
/// read before the error was encountered.  This functionality is only
/// available from C.  If you need it from another language then you must
/// write your own loop around g_input_stream_read().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream.
/// </param>
/// <param name="buffer">
/// 
///   a buffer to read data into (which should be at least count bytes long).
/// </param>
/// <param name="count">
/// the number of bytes that will be read from the stream
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes that was read from the stream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool ReadAll(this MentorLake.Gio.GInputStreamHandle stream, out byte[] buffer, UIntPtr count, out UIntPtr bytes_read, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_read_all(stream, out buffer, count, out bytes_read, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request an asynchronous read of @count bytes from the stream into the
/// buffer starting at @buffer.
/// </para>
/// <para>
/// This is the asynchronous equivalent of [method@InputStream.read_all].
/// </para>
/// <para>
/// Call [method@InputStream.read_all_finish] to collect the result.
/// </para>
/// <para>
/// Any outstanding I/O request with higher priority (lower numerical
/// value) will be executed before an outstanding request with lower
/// priority. Default priority is %G_PRIORITY_DEFAULT.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GInputStream
/// </param>
/// <param name="buffer">
/// 
///   a buffer to read data into (which should be at least count bytes long)
/// </param>
/// <param name="count">
/// the number of bytes that will be read from the stream
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReadAllAsync<T>(this T stream, out byte[] buffer, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		GInputStreamHandleExterns.g_input_stream_read_all_async(stream, out buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous stream read operation started with
/// [method@InputStream.read_all_async].
/// </para>
/// <para>
/// As a special exception to the normal conventions for functions that
/// use #GError, if this function returns %FALSE (and sets @error) then
/// @bytes_read will be set to the number of bytes that were successfully
/// read before the error was encountered.  This functionality is only
/// available from C.  If you need it from another language then you must
/// write your own loop around g_input_stream_read_async().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes that was read from the stream
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool ReadAllFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_read)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_read_all_finish(stream, result, out bytes_read, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request an asynchronous read of @count bytes from the stream into the buffer
/// starting at @buffer. When the operation is finished @callback will be called.
/// You can then call g_input_stream_read_finish() to get the result of the
/// operation.
/// </para>
/// <para>
/// During an async request no other sync and async calls are allowed on @stream, and will
/// result in %G_IO_ERROR_PENDING errors.
/// </para>
/// <para>
/// A value of @count larger than %G_MAXSSIZE will cause a %G_IO_ERROR_INVALID_ARGUMENT error.
/// </para>
/// <para>
/// On success, the number of bytes read into the buffer will be passed to the
/// callback. It is not an error if this is not the same as the requested size, as it
/// can happen e.g. near the end of a file, but generally we try to read
/// as many bytes as requested. Zero is returned on end of file
/// (or if @count is zero),  but never otherwise.
/// </para>
/// <para>
/// Any outstanding i/o request with higher priority (lower numerical value) will
/// be executed before an outstanding request with lower priority. Default
/// priority is %G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// The asynchronous methods have a default fallback that uses threads to implement
/// asynchronicity, so they are optional for inheriting classes. However, if you
/// override one you must override all.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GInputStream.
/// </param>
/// <param name="buffer">
/// 
///   a buffer to read data into (which should be at least count bytes long).
/// </param>
/// <param name="count">
/// the number of bytes that will be read from the stream
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority)
/// of the request.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReadAsync<T>(this T stream, out byte[] buffer, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		GInputStreamHandleExterns.g_input_stream_read_async(stream, out buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Like g_input_stream_read(), this tries to read @count bytes from
/// the stream in a blocking fashion. However, rather than reading into
/// a user-supplied buffer, this will create a new #GBytes containing
/// the data that was read. This may be easier to use from language
/// bindings.
/// </para>
/// <para>
/// If count is zero, returns a zero-length #GBytes and does nothing. A
/// value of @count larger than %G_MAXSSIZE will cause a
/// %G_IO_ERROR_INVALID_ARGUMENT error.
/// </para>
/// <para>
/// On success, a new #GBytes is returned. It is not an error if the
/// size of this object is not the same as the requested size, as it
/// can happen e.g. near the end of a file. A zero-length #GBytes is
/// returned on end of file (or if @count is zero), but never
/// otherwise.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned. If an
/// operation was partially finished when the operation was cancelled the
/// partial result will be returned, without an error.
/// </para>
/// <para>
/// On error %NULL is returned and @error is set accordingly.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream.
/// </param>
/// <param name="count">
/// maximum number of bytes that will be read from the stream. Common
/// values include 4096 and 8192.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a new #GBytes, or %NULL on error
/// </return>

	public static MentorLake.GLib.GBytesHandle ReadBytes(this MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_read_bytes(stream, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request an asynchronous read of @count bytes from the stream into a
/// new #GBytes. When the operation is finished @callback will be
/// called. You can then call g_input_stream_read_bytes_finish() to get the
/// result of the operation.
/// </para>
/// <para>
/// During an async request no other sync and async calls are allowed
/// on @stream, and will result in %G_IO_ERROR_PENDING errors.
/// </para>
/// <para>
/// A value of @count larger than %G_MAXSSIZE will cause a
/// %G_IO_ERROR_INVALID_ARGUMENT error.
/// </para>
/// <para>
/// On success, the new #GBytes will be passed to the callback. It is
/// not an error if this is smaller than the requested size, as it can
/// happen e.g. near the end of a file, but generally we try to read as
/// many bytes as requested. Zero is returned on end of file (or if
/// @count is zero), but never otherwise.
/// </para>
/// <para>
/// Any outstanding I/O request with higher priority (lower numerical
/// value) will be executed before an outstanding request with lower
/// priority. Default priority is %G_PRIORITY_DEFAULT.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GInputStream.
/// </param>
/// <param name="count">
/// the number of bytes that will be read from the stream
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReadBytesAsync<T>(this T stream, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		GInputStreamHandleExterns.g_input_stream_read_bytes_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous stream read-into-#GBytes operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// the newly-allocated #GBytes, or %NULL on error
/// </return>

	public static MentorLake.GLib.GBytesHandle ReadBytesFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_read_bytes_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous stream read operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// number of bytes read in, or -1 on error, or 0 on end of file.
/// </return>

	public static UIntPtr ReadFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_read_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @stream to have actions pending. If the pending flag is
/// already set or @stream is closed, it will return %FALSE and set
/// @error.
/// </para>
/// </summary>

/// <param name="stream">
/// input stream
/// </param>
/// <return>
/// %TRUE if pending was previously unset and is now set.
/// </return>

	public static bool SetPending(this MentorLake.Gio.GInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_set_pending(stream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to skip @count bytes from the stream. Will block during the operation.
/// </para>
/// <para>
/// This is identical to g_input_stream_read(), from a behaviour standpoint,
/// but the bytes that are skipped are not returned to the user. Some
/// streams have an implementation that is more efficient than reading the data.
/// </para>
/// <para>
/// This function is optional for inherited classes, as the default implementation
/// emulates it using read.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned. If an
/// operation was partially finished when the operation was cancelled the
/// partial result will be returned, without an error.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream.
/// </param>
/// <param name="count">
/// the number of bytes that will be skipped from the stream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// Number of bytes skipped, or -1 on error
/// </return>

	public static UIntPtr Skip(this MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_skip(stream, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request an asynchronous skip of @count bytes from the stream.
/// When the operation is finished @callback will be called.
/// You can then call g_input_stream_skip_finish() to get the result
/// of the operation.
/// </para>
/// <para>
/// During an async request no other sync and async calls are allowed,
/// and will result in %G_IO_ERROR_PENDING errors.
/// </para>
/// <para>
/// A value of @count larger than %G_MAXSSIZE will cause a %G_IO_ERROR_INVALID_ARGUMENT error.
/// </para>
/// <para>
/// On success, the number of bytes skipped will be passed to the callback.
/// It is not an error if this is not the same as the requested size, as it
/// can happen e.g. near the end of a file, but generally we try to skip
/// as many bytes as requested. Zero is returned on end of file
/// (or if @count is zero), but never otherwise.
/// </para>
/// <para>
/// Any outstanding i/o request with higher priority (lower numerical value)
/// will be executed before an outstanding request with lower priority.
/// Default priority is %G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// The asynchronous methods have a default fallback that uses threads to
/// implement asynchronicity, so they are optional for inheriting classes.
/// However, if you override one, you must override all.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GInputStream.
/// </param>
/// <param name="count">
/// the number of bytes that will be skipped from the stream
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T SkipAsync<T>(this T stream, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		GInputStreamHandleExterns.g_input_stream_skip_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes a stream skip operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// the size of the bytes skipped, or `-1` on error.
/// </return>

	public static UIntPtr SkipFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GInputStreamHandle)");
		var externCallResult = GInputStreamHandleExterns.g_input_stream_skip_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_clear_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_has_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_input_stream_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_read_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, UIntPtr count, out UIntPtr bytes_read, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_read_all_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_read_all_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_read, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_read_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_input_stream_read_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_read_bytes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_input_stream_read_bytes_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_input_stream_read_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_set_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_input_stream_skip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_skip_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_input_stream_skip_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
