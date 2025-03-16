namespace MentorLake.Gio;

public class GOutputStreamHandle : GObjectHandle
{
}

public static class GOutputStreamHandleExtensions
{
	public static T ClearPending<T>(this T stream) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_clear_pending(stream);
		return stream;
	}

	public static bool Close(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GOutputStreamHandleExterns.g_output_stream_close(stream, cancellable);
	}

	public static T CloseAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool CloseFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GOutputStreamHandleExterns.g_output_stream_close_finish(stream, result);
	}

	public static bool Flush(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GOutputStreamHandleExterns.g_output_stream_flush(stream, cancellable);
	}

	public static T FlushAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_flush_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool FlushFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GOutputStreamHandleExterns.g_output_stream_flush_finish(stream, result);
	}

	public static bool HasPending(this MentorLake.Gio.GOutputStreamHandle stream)
	{
		return GOutputStreamHandleExterns.g_output_stream_has_pending(stream);
	}

	public static bool IsClosed(this MentorLake.Gio.GOutputStreamHandle stream)
	{
		return GOutputStreamHandleExterns.g_output_stream_is_closed(stream);
	}

	public static bool IsClosing(this MentorLake.Gio.GOutputStreamHandle stream)
	{
		return GOutputStreamHandleExterns.g_output_stream_is_closing(stream);
	}

	public static bool Printf(this MentorLake.Gio.GOutputStreamHandle stream, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string format, IntPtr @__arglist)
	{
		return GOutputStreamHandleExterns.g_output_stream_printf(stream, out bytes_written, cancellable, error, format, @__arglist);
	}

	public static bool SetPending(this MentorLake.Gio.GOutputStreamHandle stream)
	{
		return GOutputStreamHandleExterns.g_output_stream_set_pending(stream);
	}

	public static UIntPtr Splice(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GInputStreamHandle source, MentorLake.Gio.GOutputStreamSpliceFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GOutputStreamHandleExterns.g_output_stream_splice(stream, source, flags, cancellable);
	}

	public static T SpliceAsync<T>(this T stream, MentorLake.Gio.GInputStreamHandle source, MentorLake.Gio.GOutputStreamSpliceFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_splice_async(stream, source, flags, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr SpliceFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GOutputStreamHandleExterns.g_output_stream_splice_finish(stream, result);
	}

	public static bool Vprintf(this MentorLake.Gio.GOutputStreamHandle stream, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string format, IntPtr args)
	{
		return GOutputStreamHandleExterns.g_output_stream_vprintf(stream, out bytes_written, cancellable, error, format, args);
	}

	public static UIntPtr Write(this MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GOutputStreamHandleExterns.g_output_stream_write(stream, buffer, count, cancellable);
	}

	public static bool WriteAll(this MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GOutputStreamHandleExterns.g_output_stream_write_all(stream, buffer, count, out bytes_written, cancellable);
	}

	public static T WriteAllAsync<T>(this T stream, byte[] buffer, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_write_all_async(stream, buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool WriteAllFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written)
	{
		return GOutputStreamHandleExterns.g_output_stream_write_all_finish(stream, result, out bytes_written);
	}

	public static T WriteAsync<T>(this T stream, byte[] buffer, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_write_async(stream, buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr WriteBytes(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.GLib.GBytesHandle bytes, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GOutputStreamHandleExterns.g_output_stream_write_bytes(stream, bytes, cancellable);
	}

	public static T WriteBytesAsync<T>(this T stream, MentorLake.GLib.GBytesHandle bytes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_write_bytes_async(stream, bytes, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr WriteBytesFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GOutputStreamHandleExterns.g_output_stream_write_bytes_finish(stream, result);
	}

	public static UIntPtr WriteFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GOutputStreamHandleExterns.g_output_stream_write_finish(stream, result);
	}

	public static bool Writev(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GOutputStreamHandleExterns.g_output_stream_writev(stream, vectors, n_vectors, out bytes_written, cancellable);
	}

	public static bool WritevAll(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GOutputStreamHandleExterns.g_output_stream_writev_all(stream, vectors, n_vectors, out bytes_written, cancellable);
	}

	public static T WritevAllAsync<T>(this T stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_writev_all_async(stream, vectors, n_vectors, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool WritevAllFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written)
	{
		return GOutputStreamHandleExterns.g_output_stream_writev_all_finish(stream, result, out bytes_written);
	}

	public static T WritevAsync<T>(this T stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GOutputStreamHandle
	{
		GOutputStreamHandleExterns.g_output_stream_writev_async(stream, vectors, n_vectors, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool WritevFinish(this MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written)
	{
		return GOutputStreamHandleExterns.g_output_stream_writev_finish(stream, result, out bytes_written);
	}

}

internal class GOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_clear_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_flush_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_flush_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_has_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_is_closing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_printf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_set_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_splice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle source, MentorLake.Gio.GOutputStreamSpliceFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_splice_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle source, MentorLake.Gio.GOutputStreamSpliceFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_splice_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_vprintf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string format, IntPtr args);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_write([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_write_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_write_all_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_write_all_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_write_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_write_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_write_bytes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_write_bytes_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_output_stream_write_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_writev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_writev_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_writev_all_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_writev_all_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_output_stream_writev_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_output_stream_writev_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_written);

}
