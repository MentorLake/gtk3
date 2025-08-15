namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Buffered input stream implements [class@Gio.FilterInputStream] and provides
/// for buffered reads.
/// </para>
/// <para>
/// By default, `GBufferedInputStream`&apos;s buffer size is set at 4 kilobytes.
/// </para>
/// <para>
/// To create a buffered input stream, use [ctor@Gio.BufferedInputStream.new],
/// or [ctor@Gio.BufferedInputStream.new_sized] to specify the buffer&apos;s size at
/// construction.
/// </para>
/// <para>
/// To get the size of a buffer within a buffered input stream, use
/// [method@Gio.BufferedInputStream.get_buffer_size]. To change the size of a
/// buffered input stream&apos;s buffer, use [method@Gio.BufferedInputStream.set_buffer_size].
/// Note that the buffer&apos;s size cannot be reduced below the size of the data within the buffer.
/// </para>
/// </summary>

public class GBufferedInputStreamHandle : GFilterInputStreamHandle, GSeekableHandle
{
/// <summary>
/// <para>
/// Creates a new [class@Gio.InputStream] from the given @base_stream, with
/// a buffer set to the default size (4 kilobytes).
/// </para>
/// </summary>

/// <param name="base_stream">
/// a [class@Gio.InputStream]
/// </param>
/// <return>
/// a [class@Gio.InputStream] for the given @base_stream.
/// </return>

	public static MentorLake.Gio.GBufferedInputStreamHandle New(MentorLake.Gio.GInputStreamHandle base_stream)
	{
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_new(base_stream);
	}

/// <summary>
/// <para>
/// Creates a new [class@Gio.BufferedInputStream] from the given @base_stream,
/// with a buffer set to @size.
/// </para>
/// </summary>

/// <param name="base_stream">
/// a [class@Gio.InputStream]
/// </param>
/// <param name="size">
/// a #gsize
/// </param>
/// <return>
/// a [class@Gio.InputStream].
/// </return>

	public static MentorLake.Gio.GBufferedInputStreamHandle NewSized(MentorLake.Gio.GInputStreamHandle base_stream, UIntPtr size)
	{
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_new_sized(base_stream, size);
	}

}

public static class GBufferedInputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Tries to read @count bytes from the stream into the buffer.
/// Will block during this read.
/// </para>
/// <para>
/// If @count is zero, returns zero and does nothing. A value of @count
/// larger than `G_MAXSSIZE` will cause a
/// [error@Gio.IOErrorEnum.INVALID_ARGUMENT] error.
/// </para>
/// <para>
/// On success, the number of bytes read into the buffer is returned.
/// It is not an error if this is not the same as the requested size, as it
/// can happen e.g. near the end of a file. Zero is returned on end of file
/// (or if @count is zero),  but never otherwise.
/// </para>
/// <para>
/// If @count is -1 then the attempted read size is equal to the number of
/// bytes that are required to fill the buffer.
/// </para>
/// <para>
/// If @cancellable is not `NULL`, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error [error@Gio.IOErrorEnum.CANCELLED] will be returned.
/// If an operation was partially finished when the operation was cancelled the
/// partial result will be returned, without an error.
/// </para>
/// <para>
/// On error `-1` is returned and @error is set accordingly.
/// </para>
/// <para>
/// For the asynchronous, non-blocking, version of this function, see
/// [method@Gio.BufferedInputStream.fill_async].
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedInputStream]
/// </param>
/// <param name="count">
/// the number of bytes that will be read from the stream
/// </param>
/// <param name="cancellable">
/// optional [class@Gio.Cancellable] object, `NULL` to ignore
/// </param>
/// <return>
/// the number of bytes read into @stream&apos;s buffer, up to @count,
///     or `-1` on error.
/// </return>

	public static UIntPtr Fill(this MentorLake.Gio.GBufferedInputStreamHandle stream, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		var externCallResult = GBufferedInputStreamHandleExterns.g_buffered_input_stream_fill(stream, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads data into @stream&apos;s buffer asynchronously, up to @count size.
/// @io_priority can be used to prioritize reads. For the synchronous
/// version of this function, see [method@Gio.BufferedInputStream.fill].
/// </para>
/// <para>
/// If @count is `-1` then the attempted read size is equal to the number
/// of bytes that are required to fill the buffer.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedInputStream]
/// </param>
/// <param name="count">
/// the number of bytes that will be read from the stream
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional [class@Gio.Cancellable] object
/// </param>
/// <param name="callback">
/// a [callback@Gio.AsyncReadyCallback]
/// </param>
/// <param name="user_data">
/// a #gpointer
/// </param>

	public static T FillAsync<T>(this T stream, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GBufferedInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		GBufferedInputStreamHandleExterns.g_buffered_input_stream_fill_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous read.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedInputStream]
/// </param>
/// <param name="result">
/// a [iface@Gio.AsyncResult]
/// </param>
/// <return>
/// a #gssize of the read stream, or `-1` on an error.
/// </return>

	public static UIntPtr FillFinish(this MentorLake.Gio.GBufferedInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		var externCallResult = GBufferedInputStreamHandleExterns.g_buffered_input_stream_fill_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the size of the available data within the stream.
/// </para>
/// </summary>

/// <param name="stream">
/// [class@Gio.BufferedInputStream]
/// </param>
/// <return>
/// size of the available stream.
/// </return>

	public static UIntPtr GetAvailable(this MentorLake.Gio.GBufferedInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_get_available(stream);
	}

/// <summary>
/// <para>
/// Gets the size of the input buffer.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedInputStream]
/// </param>
/// <return>
/// the current buffer size.
/// </return>

	public static UIntPtr GetBufferSize(this MentorLake.Gio.GBufferedInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_get_buffer_size(stream);
	}

/// <summary>
/// <para>
/// Peeks in the buffer, copying data of size @count into @buffer,
/// offset @offset bytes.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedInputStream]
/// </param>
/// <param name="buffer">
/// a pointer to
///   an allocated chunk of memory
/// </param>
/// <param name="offset">
/// a #gsize
/// </param>
/// <param name="count">
/// a #gsize
/// </param>
/// <return>
/// a #gsize of the number of bytes peeked, or `-1` on error.
/// </return>

	public static UIntPtr Peek(this MentorLake.Gio.GBufferedInputStreamHandle stream, byte[] buffer, UIntPtr offset, UIntPtr count)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_peek(stream, buffer, offset, count);
	}

/// <summary>
/// <para>
/// Returns the buffer with the currently available bytes. The returned
/// buffer must not be modified and will become invalid when reading from
/// the stream or filling the buffer.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedInputStream]
/// </param>
/// <param name="count">
/// a #gsize to get the number of bytes available in the buffer
/// </param>
/// <return>
/// 
///          read-only buffer
/// </return>

	public static byte[] PeekBuffer(this MentorLake.Gio.GBufferedInputStreamHandle stream, out UIntPtr count)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_peek_buffer(stream, out count);
	}

/// <summary>
/// <para>
/// Tries to read a single byte from the stream or the buffer. Will block
/// during this read.
/// </para>
/// <para>
/// On success, the byte read from the stream is returned. On end of stream
/// `-1` is returned but it&apos;s not an exceptional error and @error is not set.
/// </para>
/// <para>
/// If @cancellable is not `NULL`, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error [error@Gio.IOErrorEnum.CANCELLED] will be returned.
/// If an operation was partially finished when the operation was cancelled the
/// partial result will be returned, without an error.
/// </para>
/// <para>
/// On error `-1` is returned and @error is set accordingly.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedInputStream]
/// </param>
/// <param name="cancellable">
/// optional [class@Gio.Cancellable] object, `NULL` to ignore
/// </param>
/// <return>
/// the byte read from the @stream, or `-1` on end of stream or error.
/// </return>

	public static int ReadByte(this MentorLake.Gio.GBufferedInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		var externCallResult = GBufferedInputStreamHandleExterns.g_buffered_input_stream_read_byte(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the size of the internal buffer of @stream to @size, or to the
/// size of the contents of the buffer. The buffer can never be resized
/// smaller than its current contents.
/// </para>
/// </summary>

/// <param name="stream">
/// a [class@Gio.BufferedInputStream]
/// </param>
/// <param name="size">
/// a #gsize
/// </param>

	public static T SetBufferSize<T>(this T stream, UIntPtr size) where T : GBufferedInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		GBufferedInputStreamHandleExterns.g_buffered_input_stream_set_buffer_size(stream, size);
		return stream;
	}

}

internal class GBufferedInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))]
	internal static extern MentorLake.Gio.GBufferedInputStreamHandle g_buffered_input_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle base_stream);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))]
	internal static extern MentorLake.Gio.GBufferedInputStreamHandle g_buffered_input_stream_new_sized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle base_stream, UIntPtr size);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_buffered_input_stream_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_buffered_input_stream_fill_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_buffered_input_stream_fill_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_buffered_input_stream_get_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_buffered_input_stream_get_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_buffered_input_stream_peek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream, byte[] buffer, UIntPtr offset, UIntPtr count);

	[DllImport(GioLibrary.Name)]
	internal static extern byte[] g_buffered_input_stream_peek_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream, out UIntPtr count);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_buffered_input_stream_read_byte([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_buffered_input_stream_set_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedInputStreamHandle>))] MentorLake.Gio.GBufferedInputStreamHandle stream, UIntPtr size);

}
