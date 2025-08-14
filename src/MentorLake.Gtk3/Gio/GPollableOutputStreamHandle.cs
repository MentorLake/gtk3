namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GPollableOutputStream` is implemented by [class@Gio.OutputStream]s that
/// can be polled for readiness to write. This can be used when
/// interfacing with a non-GIO API that expects
/// UNIX-file-descriptor-style asynchronous I/O rather than GIO-style.
/// </para>
/// <para>
/// Some classes may implement `GPollableOutputStream` but have only certain
/// instances of that class be pollable. If [method@Gio.PollableOutputStream.can_poll]
/// returns false, then the behavior of other `GPollableOutputStream` methods is
/// undefined.
/// </para>
/// </summary>

public interface GPollableOutputStreamHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GPollableOutputStreamHandleImpl : BaseSafeHandle, GPollableOutputStreamHandle
{
}

public static class GPollableOutputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Checks if @stream is actually pollable. Some classes may implement
/// #GPollableOutputStream but have only certain instances of that
/// class be pollable. If this method returns %FALSE, then the behavior
/// of other #GPollableOutputStream methods is undefined.
/// </para>
/// <para>
/// For any given stream, the value returned by this method is constant;
/// a stream cannot switch from pollable to non-pollable or vice versa.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableOutputStream.
/// </param>
/// <return>
/// %TRUE if @stream is pollable, %FALSE if not.
/// </return>

	public static bool CanPoll(this MentorLake.Gio.GPollableOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableOutputStreamHandle)");
		return GPollableOutputStreamHandleExterns.g_pollable_output_stream_can_poll(stream);
	}

/// <summary>
/// <para>
/// Creates a #GSource that triggers when @stream can be written, or
/// @cancellable is triggered or an error occurs. The callback on the
/// source is of the #GPollableSourceFunc type.
/// </para>
/// <para>
/// As with g_pollable_output_stream_is_writable(), it is possible that
/// the stream may not actually be writable even after the source
/// triggers, so you should use g_pollable_output_stream_write_nonblocking()
/// rather than g_output_stream_write() from the callback.
/// </para>
/// <para>
/// The behaviour of this method is undefined if
/// g_pollable_output_stream_can_poll() returns %FALSE for @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableOutputStream.
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a new #GSource
/// </return>

	public static MentorLake.GLib.GSourceHandle CreateSource(this MentorLake.Gio.GPollableOutputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableOutputStreamHandle)");
		return GPollableOutputStreamHandleExterns.g_pollable_output_stream_create_source(stream, cancellable);
	}

/// <summary>
/// <para>
/// Checks if @stream can be written.
/// </para>
/// <para>
/// Note that some stream types may not be able to implement this 100%
/// reliably, and it is possible that a call to g_output_stream_write()
/// after this returns %TRUE would still block. To guarantee
/// non-blocking behavior, you should always use
/// g_pollable_output_stream_write_nonblocking(), which will return a
/// %G_IO_ERROR_WOULD_BLOCK error rather than blocking.
/// </para>
/// <para>
/// The behaviour of this method is undefined if
/// g_pollable_output_stream_can_poll() returns %FALSE for @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableOutputStream.
/// </param>
/// <return>
/// %TRUE if @stream is writable, %FALSE if not. If an error
///   has occurred on @stream, this will result in
///   g_pollable_output_stream_is_writable() returning %TRUE, and the
///   next attempt to write will return the error.
/// </return>

	public static bool IsWritable(this MentorLake.Gio.GPollableOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableOutputStreamHandle)");
		return GPollableOutputStreamHandleExterns.g_pollable_output_stream_is_writable(stream);
	}

/// <summary>
/// <para>
/// Attempts to write up to @count bytes from @buffer to @stream, as
/// with g_output_stream_write(). If @stream is not currently writable,
/// this will immediately return %G_IO_ERROR_WOULD_BLOCK, and you can
/// use g_pollable_output_stream_create_source() to create a #GSource
/// that will be triggered when @stream is writable.
/// </para>
/// <para>
/// Note that since this method never blocks, you cannot actually
/// use @cancellable to cancel it. However, it will return an error
/// if @cancellable has already been cancelled when you call, which
/// may happen if you call this method after a source triggers due
/// to having been cancelled.
/// </para>
/// <para>
/// Also note that if %G_IO_ERROR_WOULD_BLOCK is returned some underlying
/// transports like D/TLS require that you re-send the same @buffer and
/// @count in the next write call.
/// </para>
/// <para>
/// The behaviour of this method is undefined if
/// g_pollable_output_stream_can_poll() returns %FALSE for @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableOutputStream
/// </param>
/// <param name="buffer">
/// a buffer to write
///     data from
/// </param>
/// <param name="count">
/// the number of bytes you want to write
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// the number of bytes written, or -1 on error (including
///   %G_IO_ERROR_WOULD_BLOCK).
/// </return>

	public static UIntPtr WriteNonblocking(this MentorLake.Gio.GPollableOutputStreamHandle stream, byte[] buffer, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableOutputStreamHandle)");
		var externCallResult = GPollableOutputStreamHandleExterns.g_pollable_output_stream_write_nonblocking(stream, buffer, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Attempts to write the bytes contained in the @n_vectors @vectors to @stream,
/// as with g_output_stream_writev(). If @stream is not currently writable,
/// this will immediately return %@G_POLLABLE_RETURN_WOULD_BLOCK, and you can
/// use g_pollable_output_stream_create_source() to create a #GSource
/// that will be triggered when @stream is writable. @error will *not* be
/// set in that case.
/// </para>
/// <para>
/// Note that since this method never blocks, you cannot actually
/// use @cancellable to cancel it. However, it will return an error
/// if @cancellable has already been cancelled when you call, which
/// may happen if you call this method after a source triggers due
/// to having been cancelled.
/// </para>
/// <para>
/// Also note that if %G_POLLABLE_RETURN_WOULD_BLOCK is returned some underlying
/// transports like D/TLS require that you re-send the same @vectors and
/// @n_vectors in the next write call.
/// </para>
/// <para>
/// The behaviour of this method is undefined if
/// g_pollable_output_stream_can_poll() returns %FALSE for @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableOutputStream
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
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %@G_POLLABLE_RETURN_OK on success, %G_POLLABLE_RETURN_WOULD_BLOCK
/// if the stream is not currently writable (and @error is *not* set), or
/// %G_POLLABLE_RETURN_FAILED if there was an error in which case @error will
/// be set.
/// </return>

	public static MentorLake.Gio.GPollableReturn WritevNonblocking(this MentorLake.Gio.GPollableOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableOutputStreamHandle)");
		var externCallResult = GPollableOutputStreamHandleExterns.g_pollable_output_stream_writev_nonblocking(stream, vectors, n_vectors, out bytes_written, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GPollableOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_output_stream_can_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_pollable_output_stream_create_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_output_stream_is_writable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_pollable_output_stream_write_nonblocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream, byte[] buffer, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GPollableReturn g_pollable_output_stream_writev_nonblocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
