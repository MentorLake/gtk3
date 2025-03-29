namespace MentorLake.Gio;

public class GIOStreamHandle : GObjectHandle
{
	public static bool SpliceFinish(MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GIOStreamHandleExterns.g_io_stream_splice_finish(result, error);
	}

}

public static class GIOStreamHandleExtensions
{
	public static T ClearPending<T>(this T stream) where T : GIOStreamHandle
	{
		GIOStreamHandleExterns.g_io_stream_clear_pending(stream);
		return stream;
	}

	public static bool Close(this MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GIOStreamHandleExterns.g_io_stream_close(stream, cancellable, error);
	}

	public static T CloseAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GIOStreamHandle
	{
		GIOStreamHandleExterns.g_io_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool CloseFinish(this MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GIOStreamHandleExterns.g_io_stream_close_finish(stream, result, error);
	}

	public static MentorLake.Gio.GInputStreamHandle GetInputStream(this MentorLake.Gio.GIOStreamHandle stream)
	{
		return GIOStreamHandleExterns.g_io_stream_get_input_stream(stream);
	}

	public static MentorLake.Gio.GOutputStreamHandle GetOutputStream(this MentorLake.Gio.GIOStreamHandle stream)
	{
		return GIOStreamHandleExterns.g_io_stream_get_output_stream(stream);
	}

	public static bool HasPending(this MentorLake.Gio.GIOStreamHandle stream)
	{
		return GIOStreamHandleExterns.g_io_stream_has_pending(stream);
	}

	public static bool IsClosed(this MentorLake.Gio.GIOStreamHandle stream)
	{
		return GIOStreamHandleExterns.g_io_stream_is_closed(stream);
	}

	public static bool SetPending(this MentorLake.Gio.GIOStreamHandle stream, IntPtr error)
	{
		return GIOStreamHandleExterns.g_io_stream_set_pending(stream, error);
	}

	public static T SpliceAsync<T>(this T stream1, MentorLake.Gio.GIOStreamHandle stream2, MentorLake.Gio.GIOStreamSpliceFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GIOStreamHandle
	{
		GIOStreamHandleExterns.g_io_stream_splice_async(stream1, stream2, flags, io_priority, cancellable, callback, user_data);
		return stream1;
	}

}

internal class GIOStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_stream_clear_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_stream_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInputStreamHandle g_io_stream_get_input_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GOutputStreamHandle g_io_stream_get_output_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_has_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_set_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_stream_splice_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream2, MentorLake.Gio.GIOStreamSpliceFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_stream_splice_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

}
