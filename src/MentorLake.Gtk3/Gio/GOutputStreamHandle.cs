namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GOutputStream` is a base class for implementing streaming output.
/// </para>
/// <para>
/// It has functions to write to a stream ([method@Gio.OutputStream.write]),
/// to close a stream ([method@Gio.OutputStream.close]) and to flush pending
/// writes ([method@Gio.OutputStream.flush]).
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
/// <para>
/// All classes derived from `GOutputStream` *should* implement synchronous
/// writing, splicing, flushing and closing streams, but *may* implement
/// asynchronous versions.
/// </para>
/// </summary>

public class GOutputStreamHandle : GObjectHandle
{
}

public static class GOutputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Clears the pending flag on @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// output stream
/// </param>

	public static T ClearPending<T>(this T stream) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_clear_pending(stream);
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
/// Closing a stream will automatically flush any outstanding buffers in the
/// stream.
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
/// is important to check and report the error to the user, otherwise
/// there might be a loss of data as all data might not be written.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// Cancelling a close will still leave the stream closed, but there some streams
/// can use a faster close that doesn't block to e.g. check errors. On
/// cancellation (as with any error) there is no guarantee that all written
/// data will reach the target.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GOutputStream.
/// </param>
/// <param name="cancellable">
/// optional cancellable object
/// </param>
/// <return>
/// %TRUE on success, %FALSE on failure
/// </return>

	public static bool Close(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_close(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Requests an asynchronous close of the stream, releasing resources
/// related to it. When the operation is finished @callback will be
/// called. You can then call g_output_stream_close_finish() to get
/// the result of the operation.
/// </para>
/// <para>
/// For behaviour details see g_output_stream_close().
/// </para>
/// <para>
/// The asynchronous methods have a default fallback that uses threads
/// to implement asynchronicity, so they are optional for inheriting
/// classes. However, if you override one you must override all.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GOutputStream.
/// </param>
/// <param name="io_priority">
/// the io priority of the request.
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

	public static T CloseAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Closes an output stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if stream was successfully closed, %FALSE otherwise.
/// </return>

	public static bool CloseFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_close_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Forces a write of all user-space buffered data for the given
/// @stream. Will block during the operation. Closing the stream will
/// implicitly cause a flush.
/// </para>
/// <para>
/// This function is optional for inherited classes.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="cancellable">
/// optional cancellable object
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error
/// </return>

	public static bool Flush(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_flush(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Forces an asynchronous write of all user-space buffered data for
/// the given @stream.
/// For behaviour details see g_output_stream_flush().
/// </para>
/// <para>
/// When the operation is finished @callback will be
/// called. You can then call g_output_stream_flush_finish() to get the
/// result of the operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="io_priority">
/// the io priority of the request.
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

	public static T FlushAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_flush_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes flushing an output stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="result">
/// a GAsyncResult.
/// </param>
/// <return>
/// %TRUE if flush operation succeeded, %FALSE otherwise.
/// </return>

	public static bool FlushFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_flush_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if an output stream has pending actions.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <return>
/// %TRUE if @stream has pending actions.
/// </return>

	public static bool HasPending(this MentorLake.Gio.GOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		return GOutputStreamHandleExterns.g_output_stream_has_pending(stream);
	}

/// <summary>
/// <para>
/// Checks if an output stream has already been closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <return>
/// %TRUE if @stream is closed. %FALSE otherwise.
/// </return>

	public static bool IsClosed(this MentorLake.Gio.GOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		return GOutputStreamHandleExterns.g_output_stream_is_closed(stream);
	}

/// <summary>
/// <para>
/// Checks if an output stream is being closed. This can be
/// used inside e.g. a flush implementation to see if the
/// flush (or other i/o operation) is called from within
/// the closing operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <return>
/// %TRUE if @stream is being closed. %FALSE otherwise.
/// </return>

	public static bool IsClosing(this MentorLake.Gio.GOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		return GOutputStreamHandleExterns.g_output_stream_is_closing(stream);
	}

/// <summary>
/// <para>
/// This is a utility function around g_output_stream_write_all(). It
/// uses g_strdup_vprintf() to turn @format and @... into a string that
/// is then written to @stream.
/// </para>
/// <para>
/// See the documentation of g_output_stream_write_all() about the
/// behavior of the actual write operation.
/// </para>
/// <para>
/// Note that partial writes cannot be properly checked with this
/// function due to the variable length of the written string, if you
/// need precise control over partial write failures, you need to
/// create you own printf()-like wrapper around g_output_stream_write()
/// or g_output_stream_write_all().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that was
///     written to the stream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="error">
/// location to store the error occurring, or %NULL to ignore
/// </param>
/// <param name="format">
/// the format string. See the printf() documentation
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool Printf(this MentorLake.Gio.GOutputStreamHandle stream, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string format, IntPtr @__arglist)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		return GOutputStreamHandleExterns.g_output_stream_printf(stream, out bytes_written, cancellable, error, format, @__arglist);
	}

/// <summary>
/// <para>
/// Sets @stream to have actions pending. If the pending flag is
/// already set or @stream is closed, it will return %FALSE and set
/// @error.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <return>
/// %TRUE if pending was previously unset and is now set.
/// </return>

	public static bool SetPending(this MentorLake.Gio.GOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_set_pending(stream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Splices an input stream into an output stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="source">
/// a #GInputStream.
/// </param>
/// <param name="flags">
/// a set of #GOutputStreamSpliceFlags.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a #gssize containing the size of the data spliced, or
///     -1 if an error occurred. Note that if the number of bytes
///     spliced is greater than %G_MAXSSIZE, then that will be
///     returned, and there is no way to determine the actual number
///     of bytes spliced.
/// </return>

	public static UIntPtr Splice(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GInputStreamHandle source, MentorLake.Gio.GOutputStreamSpliceFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_splice(stream, source, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Splices a stream asynchronously.
/// When the operation is finished @callback will be called.
/// You can then call g_output_stream_splice_finish() to get the
/// result of the operation.
/// </para>
/// <para>
/// For the synchronous, blocking version of this function, see
/// g_output_stream_splice().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="source">
/// a #GInputStream.
/// </param>
/// <param name="flags">
/// a set of #GOutputStreamSpliceFlags.
/// </param>
/// <param name="io_priority">
/// the io priority of the request.
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

	public static T SpliceAsync<T>(this T stream, MentorLake.Gio.GInputStreamHandle source, MentorLake.Gio.GOutputStreamSpliceFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_splice_async(stream, source, flags, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous stream splice operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a #gssize of the number of bytes spliced. Note that if the
///     number of bytes spliced is greater than %G_MAXSSIZE, then that
///     will be returned, and there is no way to determine the actual
///     number of bytes spliced.
/// </return>

	public static UIntPtr SpliceFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_splice_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is a utility function around g_output_stream_write_all(). It
/// uses g_strdup_vprintf() to turn @format and @args into a string that
/// is then written to @stream.
/// </para>
/// <para>
/// See the documentation of g_output_stream_write_all() about the
/// behavior of the actual write operation.
/// </para>
/// <para>
/// Note that partial writes cannot be properly checked with this
/// function due to the variable length of the written string, if you
/// need precise control over partial write failures, you need to
/// create you own printf()-like wrapper around g_output_stream_write()
/// or g_output_stream_write_all().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that was
///     written to the stream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="error">
/// location to store the error occurring, or %NULL to ignore
/// </param>
/// <param name="format">
/// the format string. See the printf() documentation
/// </param>
/// <param name="args">
/// the parameters to insert into the format string
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool Vprintf(this MentorLake.Gio.GOutputStreamHandle stream, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string format, IntPtr args)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		return GOutputStreamHandleExterns.g_output_stream_vprintf(stream, out bytes_written, cancellable, error, format, args);
	}

/// <summary>
/// <para>
/// Tries to write @count bytes from @buffer into the stream. Will block
/// during the operation.
/// </para>
/// <para>
/// If count is 0, returns 0 and does nothing. A value of @count
/// larger than %G_MAXSSIZE will cause a %G_IO_ERROR_INVALID_ARGUMENT error.
/// </para>
/// <para>
/// On success, the number of bytes written to the stream is returned.
/// It is not an error if this is not the same as the requested size, as it
/// can happen e.g. on a partial I/O error, or if there is not enough
/// storage in the stream. All writes block until at least one byte
/// is written or an error occurs; 0 is never returned (unless
/// @count is 0).
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
/// a #GOutputStream.
/// </param>
/// <param name="buffer">
/// the buffer containing the data to write.
/// </param>
/// <param name="count">
/// the number of bytes to write
/// </param>
/// <param name="cancellable">
/// optional cancellable object
/// </param>
/// <return>
/// Number of bytes written, or -1 on error
/// </return>

	public static UIntPtr Write(this MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_write(stream, buffer, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to write @count bytes from @buffer into the stream. Will block
/// during the operation.
/// </para>
/// <para>
/// This function is similar to g_output_stream_write(), except it tries to
/// write as many bytes as requested, only stopping on an error.
/// </para>
/// <para>
/// On a successful write of @count bytes, %TRUE is returned, and @bytes_written
/// is set to @count.
/// </para>
/// <para>
/// If there is an error during the operation %FALSE is returned and @error
/// is set to indicate the error status.
/// </para>
/// <para>
/// As a special exception to the normal conventions for functions that
/// use #GError, if this function returns %FALSE (and sets @error) then
/// @bytes_written will be set to the number of bytes that were
/// successfully written before the error was encountered.  This
/// functionality is only available from C.  If you need it from another
/// language then you must write your own loop around
/// g_output_stream_write().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="buffer">
/// the buffer containing the data to write.
/// </param>
/// <param name="count">
/// the number of bytes to write
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that was
///     written to the stream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool WriteAll(this MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_write_all(stream, buffer, count, out bytes_written, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request an asynchronous write of @count bytes from @buffer into
/// the stream. When the operation is finished @callback will be called.
/// You can then call g_output_stream_write_all_finish() to get the result of the
/// operation.
/// </para>
/// <para>
/// This is the asynchronous version of g_output_stream_write_all().
/// </para>
/// <para>
/// Call g_output_stream_write_all_finish() to collect the result.
/// </para>
/// <para>
/// Any outstanding I/O request with higher priority (lower numerical
/// value) will be executed before an outstanding request with lower
/// priority. Default priority is %G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// Note that no copy of @buffer will be made, so it must stay valid
/// until @callback is called.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GOutputStream
/// </param>
/// <param name="buffer">
/// the buffer containing the data to write
/// </param>
/// <param name="count">
/// the number of bytes to write
/// </param>
/// <param name="io_priority">
/// the io priority of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///     to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T WriteAllAsync<T>(this T stream, byte[] buffer, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_write_all_async(stream, buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous stream write operation started with
/// g_output_stream_write_all_async().
/// </para>
/// <para>
/// As a special exception to the normal conventions for functions that
/// use #GError, if this function returns %FALSE (and sets @error) then
/// @bytes_written will be set to the number of bytes that were
/// successfully written before the error was encountered.  This
/// functionality is only available from C.  If you need it from another
/// language then you must write your own loop around
/// g_output_stream_write_async().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that was written to the stream
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool WriteAllFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_write_all_finish(stream, result, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request an asynchronous write of @count bytes from @buffer into
/// the stream. When the operation is finished @callback will be called.
/// You can then call g_output_stream_write_finish() to get the result of the
/// operation.
/// </para>
/// <para>
/// During an async request no other sync and async calls are allowed,
/// and will result in %G_IO_ERROR_PENDING errors.
/// </para>
/// <para>
/// A value of @count larger than %G_MAXSSIZE will cause a
/// %G_IO_ERROR_INVALID_ARGUMENT error.
/// </para>
/// <para>
/// On success, the number of bytes written will be passed to the
/// @callback. It is not an error if this is not the same as the
/// requested size, as it can happen e.g. on a partial I/O error,
/// but generally we try to write as many bytes as requested.
/// </para>
/// <para>
/// You are guaranteed that this method will never fail with
/// %G_IO_ERROR_WOULD_BLOCK - if @stream can't accept more data, the
/// method will just wait until this changes.
/// </para>
/// <para>
/// Any outstanding I/O request with higher priority (lower numerical
/// value) will be executed before an outstanding request with lower
/// priority. Default priority is %G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// The asynchronous methods have a default fallback that uses threads
/// to implement asynchronicity, so they are optional for inheriting
/// classes. However, if you override one you must override all.
/// </para>
/// <para>
/// For the synchronous, blocking version of this function, see
/// g_output_stream_write().
/// </para>
/// <para>
/// Note that no copy of @buffer will be made, so it must stay valid
/// until @callback is called. See g_output_stream_write_bytes_async()
/// for a #GBytes version that will automatically hold a reference to
/// the contents (without copying) for the duration of the call.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GOutputStream.
/// </param>
/// <param name="buffer">
/// the buffer containing the data to write.
/// </param>
/// <param name="count">
/// the number of bytes to write
/// </param>
/// <param name="io_priority">
/// the io priority of the request.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///     to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T WriteAsync<T>(this T stream, byte[] buffer, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_write_async(stream, buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// A wrapper function for g_output_stream_write() which takes a
/// #GBytes as input.  This can be more convenient for use by language
/// bindings or in other cases where the refcounted nature of #GBytes
/// is helpful over a bare pointer interface.
/// </para>
/// <para>
/// However, note that this function may still perform partial writes,
/// just like g_output_stream_write().  If that occurs, to continue
/// writing, you will need to create a new #GBytes containing just the
/// remaining bytes, using g_bytes_new_from_bytes(). Passing the same
/// #GBytes instance multiple times potentially can result in duplicated
/// data in the output stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="bytes">
/// the #GBytes to write
/// </param>
/// <param name="cancellable">
/// optional cancellable object
/// </param>
/// <return>
/// Number of bytes written, or -1 on error
/// </return>

	public static UIntPtr WriteBytes(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.GLib.GBytesHandle bytes, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_write_bytes(stream, bytes, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function is similar to g_output_stream_write_async(), but
/// takes a #GBytes as input.  Due to the refcounted nature of #GBytes,
/// this allows the stream to avoid taking a copy of the data.
/// </para>
/// <para>
/// However, note that this function may still perform partial writes,
/// just like g_output_stream_write_async(). If that occurs, to continue
/// writing, you will need to create a new #GBytes containing just the
/// remaining bytes, using g_bytes_new_from_bytes(). Passing the same
/// #GBytes instance multiple times potentially can result in duplicated
/// data in the output stream.
/// </para>
/// <para>
/// For the synchronous, blocking version of this function, see
/// g_output_stream_write_bytes().
/// </para>
/// </summary>

/// <param name="stream">
/// A #GOutputStream.
/// </param>
/// <param name="bytes">
/// The bytes to write
/// </param>
/// <param name="io_priority">
/// the io priority of the request.
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

	public static T WriteBytesAsync<T>(this T stream, MentorLake.GLib.GBytesHandle bytes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_write_bytes_async(stream, bytes, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes a stream write-from-#GBytes operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a #gssize containing the number of bytes written to the stream.
/// </return>

	public static UIntPtr WriteBytesFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_write_bytes_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes a stream write operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a #gssize containing the number of bytes written to the stream.
/// </return>

	public static UIntPtr WriteFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_write_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to write the bytes contained in the @n_vectors @vectors into the
/// stream. Will block during the operation.
/// </para>
/// <para>
/// If @n_vectors is 0 or the sum of all bytes in @vectors is 0, returns 0 and
/// does nothing.
/// </para>
/// <para>
/// On success, the number of bytes written to the stream is returned.
/// It is not an error if this is not the same as the requested size, as it
/// can happen e.g. on a partial I/O error, or if there is not enough
/// storage in the stream. All writes block until at least one byte
/// is written or an error occurs; 0 is never returned (unless
/// @n_vectors is 0 or the sum of all bytes in @vectors is 0).
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned. If an
/// operation was partially finished when the operation was cancelled the
/// partial result will be returned, without an error.
/// </para>
/// <para>
/// Some implementations of g_output_stream_writev() may have limitations on the
/// aggregate buffer size, and will return %G_IO_ERROR_INVALID_ARGUMENT if these
/// are exceeded. For example, when writing to a local file on UNIX platforms,
/// the aggregate buffer size must not exceed %G_MAXSSIZE bytes.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="vectors">
/// the buffer containing the #GOutputVectors to write.
/// </param>
/// <param name="n_vectors">
/// the number of vectors to write
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that were
///     written to the stream
/// </param>
/// <param name="cancellable">
/// optional cancellable object
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool Writev(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_writev(stream, vectors, n_vectors, out bytes_written, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to write the bytes contained in the @n_vectors @vectors into the
/// stream. Will block during the operation.
/// </para>
/// <para>
/// This function is similar to g_output_stream_writev(), except it tries to
/// write as many bytes as requested, only stopping on an error.
/// </para>
/// <para>
/// On a successful write of all @n_vectors vectors, %TRUE is returned, and
/// @bytes_written is set to the sum of all the sizes of @vectors.
/// </para>
/// <para>
/// If there is an error during the operation %FALSE is returned and @error
/// is set to indicate the error status.
/// </para>
/// <para>
/// As a special exception to the normal conventions for functions that
/// use #GError, if this function returns %FALSE (and sets @error) then
/// @bytes_written will be set to the number of bytes that were
/// successfully written before the error was encountered.  This
/// functionality is only available from C. If you need it from another
/// language then you must write your own loop around
/// g_output_stream_write().
/// </para>
/// <para>
/// The content of the individual elements of @vectors might be changed by this
/// function.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="vectors">
/// the buffer containing the #GOutputVectors to write.
/// </param>
/// <param name="n_vectors">
/// the number of vectors to write
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that were
///     written to the stream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool WritevAll(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_writev_all(stream, vectors, n_vectors, out bytes_written, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request an asynchronous write of the bytes contained in the @n_vectors @vectors into
/// the stream. When the operation is finished @callback will be called.
/// You can then call g_output_stream_writev_all_finish() to get the result of the
/// operation.
/// </para>
/// <para>
/// This is the asynchronous version of g_output_stream_writev_all().
/// </para>
/// <para>
/// Call g_output_stream_writev_all_finish() to collect the result.
/// </para>
/// <para>
/// Any outstanding I/O request with higher priority (lower numerical
/// value) will be executed before an outstanding request with lower
/// priority. Default priority is %G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// Note that no copy of @vectors will be made, so it must stay valid
/// until @callback is called. The content of the individual elements
/// of @vectors might be changed by this function.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GOutputStream
/// </param>
/// <param name="vectors">
/// the buffer containing the #GOutputVectors to write.
/// </param>
/// <param name="n_vectors">
/// the number of vectors to write
/// </param>
/// <param name="io_priority">
/// the I/O priority of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///     to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T WritevAllAsync<T>(this T stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_writev_all_async(stream, vectors, n_vectors, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous stream write operation started with
/// g_output_stream_writev_all_async().
/// </para>
/// <para>
/// As a special exception to the normal conventions for functions that
/// use #GError, if this function returns %FALSE (and sets @error) then
/// @bytes_written will be set to the number of bytes that were
/// successfully written before the error was encountered.  This
/// functionality is only available from C.  If you need it from another
/// language then you must write your own loop around
/// g_output_stream_writev_async().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that were written to the stream
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool WritevAllFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_writev_all_finish(stream, result, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request an asynchronous write of the bytes contained in @n_vectors @vectors into
/// the stream. When the operation is finished @callback will be called.
/// You can then call g_output_stream_writev_finish() to get the result of the
/// operation.
/// </para>
/// <para>
/// During an async request no other sync and async calls are allowed,
/// and will result in %G_IO_ERROR_PENDING errors.
/// </para>
/// <para>
/// On success, the number of bytes written will be passed to the
/// @callback. It is not an error if this is not the same as the
/// requested size, as it can happen e.g. on a partial I/O error,
/// but generally we try to write as many bytes as requested.
/// </para>
/// <para>
/// You are guaranteed that this method will never fail with
/// %G_IO_ERROR_WOULD_BLOCK — if @stream can't accept more data, the
/// method will just wait until this changes.
/// </para>
/// <para>
/// Any outstanding I/O request with higher priority (lower numerical
/// value) will be executed before an outstanding request with lower
/// priority. Default priority is %G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// The asynchronous methods have a default fallback that uses threads
/// to implement asynchronicity, so they are optional for inheriting
/// classes. However, if you override one you must override all.
/// </para>
/// <para>
/// For the synchronous, blocking version of this function, see
/// g_output_stream_writev().
/// </para>
/// <para>
/// Note that no copy of @vectors will be made, so it must stay valid
/// until @callback is called.
/// </para>
/// </summary>

/// <param name="stream">
/// A #GOutputStream.
/// </param>
/// <param name="vectors">
/// the buffer containing the #GOutputVectors to write.
/// </param>
/// <param name="n_vectors">
/// the number of vectors to write
/// </param>
/// <param name="io_priority">
/// the I/O priority of the request.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///     to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T WritevAsync<T>(this T stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		GOutputStreamHandleExterns.g_output_stream_writev_async(stream, vectors, n_vectors, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes a stream writev operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that were written to the stream
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool WritevFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GOutputStreamHandle)");
		var externCallResult = GOutputStreamHandleExterns.g_output_stream_writev_finish(stream, result, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_clear_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_flush_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_flush_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_has_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_is_closing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_printf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_set_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_splice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle source, MentorLake.Gio.GOutputStreamSpliceFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_splice_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle source, MentorLake.Gio.GOutputStreamSpliceFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_splice_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_vprintf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string format, IntPtr args);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_write([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_write_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_write_all_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_write_all_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_write_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_write_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_write_bytes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_write_bytes_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_write_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_writev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_writev_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_writev_all_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_writev_all_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_writev_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_writev_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

}
