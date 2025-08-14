namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GPollableInputStream` is implemented by [class@Gio.InputStream]s that
/// can be polled for readiness to read. This can be used when
/// interfacing with a non-GIO API that expects
/// UNIX-file-descriptor-style asynchronous I/O rather than GIO-style.
/// </para>
/// <para>
/// Some classes may implement `GPollableInputStream` but have only certain
/// instances of that class be pollable. If [method@Gio.PollableInputStream.can_poll]
/// returns false, then the behavior of other `GPollableInputStream` methods is
/// undefined.
/// </para>
/// </summary>

public interface GPollableInputStreamHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GPollableInputStreamHandleImpl : BaseSafeHandle, GPollableInputStreamHandle
{
}

public static class GPollableInputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Checks if @stream is actually pollable. Some classes may implement
/// #GPollableInputStream but have only certain instances of that class
/// be pollable. If this method returns %FALSE, then the behavior of
/// other #GPollableInputStream methods is undefined.
/// </para>
/// <para>
/// For any given stream, the value returned by this method is constant;
/// a stream cannot switch from pollable to non-pollable or vice versa.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableInputStream.
/// </param>
/// <return>
/// %TRUE if @stream is pollable, %FALSE if not.
/// </return>

	public static bool CanPoll(this MentorLake.Gio.GPollableInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableInputStreamHandle)");
		return GPollableInputStreamHandleExterns.g_pollable_input_stream_can_poll(stream);
	}

/// <summary>
/// <para>
/// Creates a #GSource that triggers when @stream can be read, or
/// @cancellable is triggered or an error occurs. The callback on the
/// source is of the #GPollableSourceFunc type.
/// </para>
/// <para>
/// As with g_pollable_input_stream_is_readable(), it is possible that
/// the stream may not actually be readable even after the source
/// triggers, so you should use g_pollable_input_stream_read_nonblocking()
/// rather than g_input_stream_read() from the callback.
/// </para>
/// <para>
/// The behaviour of this method is undefined if
/// g_pollable_input_stream_can_poll() returns %FALSE for @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableInputStream.
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a new #GSource
/// </return>

	public static MentorLake.GLib.GSourceHandle CreateSource(this MentorLake.Gio.GPollableInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableInputStreamHandle)");
		return GPollableInputStreamHandleExterns.g_pollable_input_stream_create_source(stream, cancellable);
	}

/// <summary>
/// <para>
/// Checks if @stream can be read.
/// </para>
/// <para>
/// Note that some stream types may not be able to implement this 100%
/// reliably, and it is possible that a call to g_input_stream_read()
/// after this returns %TRUE would still block. To guarantee
/// non-blocking behavior, you should always use
/// g_pollable_input_stream_read_nonblocking(), which will return a
/// %G_IO_ERROR_WOULD_BLOCK error rather than blocking.
/// </para>
/// <para>
/// The behaviour of this method is undefined if
/// g_pollable_input_stream_can_poll() returns %FALSE for @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableInputStream.
/// </param>
/// <return>
/// %TRUE if @stream is readable, %FALSE if not. If an error
///   has occurred on @stream, this will result in
///   g_pollable_input_stream_is_readable() returning %TRUE, and the
///   next attempt to read will return the error.
/// </return>

	public static bool IsReadable(this MentorLake.Gio.GPollableInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableInputStreamHandle)");
		return GPollableInputStreamHandleExterns.g_pollable_input_stream_is_readable(stream);
	}

/// <summary>
/// <para>
/// Attempts to read up to @count bytes from @stream into @buffer, as
/// with g_input_stream_read(). If @stream is not currently readable,
/// this will immediately return %G_IO_ERROR_WOULD_BLOCK, and you can
/// use g_pollable_input_stream_create_source() to create a #GSource
/// that will be triggered when @stream is readable.
/// </para>
/// <para>
/// Note that since this method never blocks, you cannot actually
/// use @cancellable to cancel it. However, it will return an error
/// if @cancellable has already been cancelled when you call, which
/// may happen if you call this method after a source triggers due
/// to having been cancelled.
/// </para>
/// <para>
/// The behaviour of this method is undefined if
/// g_pollable_input_stream_can_poll() returns %FALSE for @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GPollableInputStream
/// </param>
/// <param name="buffer">
/// a
///     buffer to read data into (which should be at least @count bytes long).
/// </param>
/// <param name="count">
/// the number of bytes you want to read
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// the number of bytes read, or -1 on error (including
///   %G_IO_ERROR_WOULD_BLOCK).
/// </return>

	public static UIntPtr ReadNonblocking(this MentorLake.Gio.GPollableInputStreamHandle stream, out byte[] buffer, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GPollableInputStreamHandle)");
		var externCallResult = GPollableInputStreamHandleExterns.g_pollable_input_stream_read_nonblocking(stream, out buffer, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GPollableInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_input_stream_can_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableInputStreamHandleImpl>))] MentorLake.Gio.GPollableInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_pollable_input_stream_create_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableInputStreamHandleImpl>))] MentorLake.Gio.GPollableInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_input_stream_is_readable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableInputStreamHandleImpl>))] MentorLake.Gio.GPollableInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_pollable_input_stream_read_nonblocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableInputStreamHandleImpl>))] MentorLake.Gio.GPollableInputStreamHandle stream, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
