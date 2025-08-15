namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GIOStream` represents an object that has both read and write streams.
/// Generally the two streams act as separate input and output streams,
/// but they share some common resources and state. For instance, for
/// seekable streams, both streams may use the same position.
/// </para>
/// <para>
/// Examples of `GIOStream` objects are [class@Gio.SocketConnection], which represents
/// a two-way network connection; and [class@Gio.FileIOStream], which represents a
/// file handle opened in read-write mode.
/// </para>
/// <para>
/// To do the actual reading and writing you need to get the substreams
/// with [method@Gio.IOStream.get_input_stream] and
/// [method@Gio.IOStream.get_output_stream].
/// </para>
/// <para>
/// The `GIOStream` object owns the input and the output streams, not the other
/// way around, so keeping the substreams alive will not keep the `GIOStream`
/// object alive. If the `GIOStream` object is freed it will be closed, thus
/// closing the substreams, so even if the substreams stay alive they will
/// always return `G_IO_ERROR_CLOSED` for all operations.
/// </para>
/// <para>
/// To close a stream use [method@Gio.IOStream.close] which will close the common
/// stream object and also the individual substreams. You can also close
/// the substreams themselves. In most cases this only marks the
/// substream as closed, so further I/O on it fails but common state in the
/// `GIOStream` may still be open. However, some streams may support
/// ‘half-closed’ states where one direction of the stream is actually shut down.
/// </para>
/// <para>
/// Operations on `GIOStream`s cannot be started while another operation on the
/// `GIOStream` or its substreams is in progress. Specifically, an application can
/// read from the [class@Gio.InputStream] and write to the
/// [class@Gio.OutputStream] simultaneously (either in separate threads, or as
/// asynchronous operations in the same thread), but an application cannot start
/// any `GIOStream` operation while there is a `GIOStream`, `GInputStream` or
/// `GOutputStream` operation in progress, and an application can’t start any
/// `GInputStream` or `GOutputStream` operation while there is a `GIOStream`
/// operation in progress.
/// </para>
/// <para>
/// This is a product of individual stream operations being associated with a
/// given [type@GLib.MainContext] (the thread-default context at the time the
/// operation was started), rather than entire streams being associated with a
/// single `GMainContext`.
/// </para>
/// <para>
/// GIO may run operations on `GIOStream`s from other (worker) threads, and this
/// may be exposed to application code in the behaviour of wrapper streams, such
/// as [class@Gio.BufferedInputStream] or [class@Gio.TlsConnection]. With such
/// wrapper APIs, application code may only run operations on the base (wrapped)
/// stream when the wrapper stream is idle. Note that the semantics of such
/// operations may not be well-defined due to the state the wrapper stream leaves
/// the base stream in (though they are guaranteed not to crash).
/// </para>
/// </summary>

public class GIOStreamHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Finishes an asynchronous io stream splice operation.
/// </para>
/// </summary>

/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE on success, %FALSE otherwise.
/// </return>

	public static bool SpliceFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GIOStreamHandleExterns.g_io_stream_splice_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GIOStreamHandleExtensions
{
/// <summary>
/// <para>
/// Clears the pending flag on @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>

	public static T ClearPending<T>(this T stream) where T : GIOStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		GIOStreamHandleExterns.g_io_stream_clear_pending(stream);
		return stream;
	}

/// <summary>
/// <para>
/// Closes the stream, releasing resources related to it. This will also
/// close the individual input and output streams, if they are not already
/// closed.
/// </para>
/// <para>
/// Once the stream is closed, all other operations will return
/// %G_IO_ERROR_CLOSED. Closing a stream multiple times will not
/// return an error.
/// </para>
/// <para>
/// Closing a stream will automatically flush any outstanding buffers
/// in the stream.
/// </para>
/// <para>
/// Streams will be automatically closed when the last reference
/// is dropped, but you might want to call this function to make sure
/// resources are released as early as possible.
/// </para>
/// <para>
/// Some streams might keep the backing store of the stream (e.g. a file
/// descriptor) open after the stream is closed. See the documentation for
/// the individual stream for details.
/// </para>
/// <para>
/// On failure the first error that happened will be reported, but the
/// close operation will finish as much as possible. A stream that failed
/// to close will still return %G_IO_ERROR_CLOSED for all operations.
/// Still, it is important to check and report the error to the user,
/// otherwise there might be a loss of data as all data might not be written.
/// </para>
/// <para>
/// If @cancellable is not NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// Cancelling a close will still leave the stream closed, but some streams
/// can use a faster close that doesn&apos;t block to e.g. check errors.
/// </para>
/// <para>
/// The default implementation of this method just calls close on the
/// individual input/output streams.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <return>
/// %TRUE on success, %FALSE on failure
/// </return>

	public static bool Close(this MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		var externCallResult = GIOStreamHandleExterns.g_io_stream_close(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Requests an asynchronous close of the stream, releasing resources
/// related to it. When the operation is finished @callback will be
/// called. You can then call g_io_stream_close_finish() to get
/// the result of the operation.
/// </para>
/// <para>
/// For behaviour details see g_io_stream_close().
/// </para>
/// <para>
/// The asynchronous methods have a default fallback that uses threads
/// to implement asynchronicity, so they are optional for inheriting
/// classes. However, if you override one you must override all.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <param name="io_priority">
/// the io priority of the request
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

	public static T CloseAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GIOStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		GIOStreamHandleExterns.g_io_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Closes a stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if stream was successfully closed, %FALSE otherwise.
/// </return>

	public static bool CloseFinish(this MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		var externCallResult = GIOStreamHandleExterns.g_io_stream_close_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the input stream for this object. This is used
/// for reading.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <return>
/// a #GInputStream, owned by the #GIOStream.
/// Do not free.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle GetInputStream(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		return GIOStreamHandleExterns.g_io_stream_get_input_stream(stream);
	}

/// <summary>
/// <para>
/// Gets the output stream for this object. This is used for
/// writing.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <return>
/// a #GOutputStream, owned by the #GIOStream.
/// Do not free.
/// </return>

	public static MentorLake.Gio.GOutputStreamHandle GetOutputStream(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		return GIOStreamHandleExterns.g_io_stream_get_output_stream(stream);
	}

/// <summary>
/// <para>
/// Checks if a stream has pending actions.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <return>
/// %TRUE if @stream has pending actions.
/// </return>

	public static bool HasPending(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		return GIOStreamHandleExterns.g_io_stream_has_pending(stream);
	}

/// <summary>
/// <para>
/// Checks if a stream is closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <return>
/// %TRUE if the stream is closed.
/// </return>

	public static bool IsClosed(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		return GIOStreamHandleExterns.g_io_stream_is_closed(stream);
	}

/// <summary>
/// <para>
/// Sets @stream to have actions pending. If the pending flag is
/// already set or @stream is closed, it will return %FALSE and set
/// @error.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <return>
/// %TRUE if pending was previously unset and is now set.
/// </return>

	public static bool SetPending(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		var externCallResult = GIOStreamHandleExterns.g_io_stream_set_pending(stream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously splice the output stream of @stream1 to the input stream of
/// @stream2, and splice the output stream of @stream2 to the input stream of
/// @stream1.
/// </para>
/// <para>
/// When the operation is finished @callback will be called.
/// You can then call g_io_stream_splice_finish() to get the
/// result of the operation.
/// </para>
/// </summary>

/// <param name="stream1">
/// a #GIOStream.
/// </param>
/// <param name="stream2">
/// a #GIOStream.
/// </param>
/// <param name="flags">
/// a set of #GIOStreamSpliceFlags.
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

	public static T SpliceAsync<T>(this T stream1, MentorLake.Gio.GIOStreamHandle stream2, MentorLake.Gio.GIOStreamSpliceFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GIOStreamHandle
	{
		if (stream1.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		GIOStreamHandleExterns.g_io_stream_splice_async(stream1, stream2, flags, io_priority, cancellable, callback, user_data);
		return stream1;
	}

}

internal class GIOStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_stream_clear_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_stream_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_io_stream_get_input_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GOutputStreamHandle g_io_stream_get_output_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_has_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_set_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_stream_splice_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream2, MentorLake.Gio.GIOStreamSpliceFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_splice_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
