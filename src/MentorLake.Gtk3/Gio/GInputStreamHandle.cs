namespace MentorLake.Gio;

public class GInputStreamHandle : GObjectHandle
{
}

public static class GInputStreamHandleExtensions
{
	public static T ClearPending<T>(this T stream) where T : GInputStreamHandle
	{
		GInputStreamHandleExterns.g_input_stream_clear_pending(stream);
		return stream;
	}

	public static bool Close(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GInputStreamHandleExterns.g_input_stream_close(stream, cancellable);
	}

	public static T CloseAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		GInputStreamHandleExterns.g_input_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool CloseFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GInputStreamHandleExterns.g_input_stream_close_finish(stream, result);
	}

	public static bool HasPending(this MentorLake.Gio.GInputStreamHandle stream)
	{
		return GInputStreamHandleExterns.g_input_stream_has_pending(stream);
	}

	public static bool IsClosed(this MentorLake.Gio.GInputStreamHandle stream)
	{
		return GInputStreamHandleExterns.g_input_stream_is_closed(stream);
	}

	public static UIntPtr Read(this MentorLake.Gio.GInputStreamHandle stream, out byte[] buffer, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GInputStreamHandleExterns.g_input_stream_read(stream, out buffer, count, cancellable);
	}

	public static bool ReadAll(this MentorLake.Gio.GInputStreamHandle stream, out byte[] buffer, UIntPtr count, out UIntPtr bytes_read, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GInputStreamHandleExterns.g_input_stream_read_all(stream, out buffer, count, out bytes_read, cancellable);
	}

	public static T ReadAllAsync<T>(this T stream, out byte[] buffer, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		GInputStreamHandleExterns.g_input_stream_read_all_async(stream, out buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool ReadAllFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_read)
	{
		return GInputStreamHandleExterns.g_input_stream_read_all_finish(stream, result, out bytes_read);
	}

	public static T ReadAsync<T>(this T stream, out byte[] buffer, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		GInputStreamHandleExterns.g_input_stream_read_async(stream, out buffer, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static MentorLake.GLib.GBytesHandle ReadBytes(this MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GInputStreamHandleExterns.g_input_stream_read_bytes(stream, count, cancellable);
	}

	public static T ReadBytesAsync<T>(this T stream, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		GInputStreamHandleExterns.g_input_stream_read_bytes_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static MentorLake.GLib.GBytesHandle ReadBytesFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GInputStreamHandleExterns.g_input_stream_read_bytes_finish(stream, result);
	}

	public static UIntPtr ReadFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GInputStreamHandleExterns.g_input_stream_read_finish(stream, result);
	}

	public static bool SetPending(this MentorLake.Gio.GInputStreamHandle stream)
	{
		return GInputStreamHandleExterns.g_input_stream_set_pending(stream);
	}

	public static UIntPtr Skip(this MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GInputStreamHandleExterns.g_input_stream_skip(stream, count, cancellable);
	}

	public static T SkipAsync<T>(this T stream, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GInputStreamHandle
	{
		GInputStreamHandleExterns.g_input_stream_skip_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr SkipFinish(this MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GInputStreamHandleExterns.g_input_stream_skip_finish(stream, result);
	}

}

internal class GInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_clear_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_has_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_input_stream_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, out byte[] buffer, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_read_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, out byte[] buffer, UIntPtr count, out UIntPtr bytes_read, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_read_all_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, out byte[] buffer, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_read_all_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr bytes_read);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_read_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, out byte[] buffer, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_input_stream_read_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_read_bytes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_input_stream_read_bytes_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_input_stream_read_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_input_stream_set_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_input_stream_skip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_input_stream_skip_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr count, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_input_stream_skip_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

}
