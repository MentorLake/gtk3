namespace MentorLake.Gtk3.Gio;

public class GIOStreamHandle : GObjectHandle
{
	public static bool GIoStreamSpliceFinish(GAsyncResultHandle result, out GErrorHandle error)
	{
		return GIOStreamExterns.g_io_stream_splice_finish(result, out error);
	}

}

public static class GIOStreamHandleExtensions
{
	public static T GIoStreamClearPending<T>(this T stream) where T : GIOStreamHandle
	{
		GIOStreamExterns.g_io_stream_clear_pending(stream);
		return stream;
	}

	public static bool GIoStreamClose(this GIOStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GIOStreamExterns.g_io_stream_close(stream, cancellable, out error);
	}

	public static T GIoStreamCloseAsync<T>(this T stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GIOStreamHandle
	{
		GIOStreamExterns.g_io_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool GIoStreamCloseFinish(this GIOStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GIOStreamExterns.g_io_stream_close_finish(stream, result, out error);
	}

	public static GInputStreamHandle GIoStreamGetInputStream(this GIOStreamHandle stream)
	{
		return GIOStreamExterns.g_io_stream_get_input_stream(stream);
	}

	public static GOutputStreamHandle GIoStreamGetOutputStream(this GIOStreamHandle stream)
	{
		return GIOStreamExterns.g_io_stream_get_output_stream(stream);
	}

	public static bool GIoStreamHasPending(this GIOStreamHandle stream)
	{
		return GIOStreamExterns.g_io_stream_has_pending(stream);
	}

	public static bool GIoStreamIsClosed(this GIOStreamHandle stream)
	{
		return GIOStreamExterns.g_io_stream_is_closed(stream);
	}

	public static bool GIoStreamSetPending(this GIOStreamHandle stream, out GErrorHandle error)
	{
		return GIOStreamExterns.g_io_stream_set_pending(stream, out error);
	}

	public static T GIoStreamSpliceAsync<T>(this T stream1, GIOStreamHandle stream2, GIOStreamSpliceFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GIOStreamHandle
	{
		GIOStreamExterns.g_io_stream_splice_async(stream1, stream2, flags, io_priority, cancellable, callback, user_data);
		return stream1;
	}

}

internal class GIOStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_io_stream_clear_pending(GIOStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_io_stream_close(GIOStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_io_stream_close_async(GIOStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_io_stream_close_finish(GIOStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_io_stream_get_input_stream(GIOStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern GOutputStreamHandle g_io_stream_get_output_stream(GIOStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_io_stream_has_pending(GIOStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_io_stream_is_closed(GIOStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_io_stream_set_pending(GIOStreamHandle stream, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_io_stream_splice_async(GIOStreamHandle stream1, GIOStreamHandle stream2, GIOStreamSpliceFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_io_stream_splice_finish(GAsyncResultHandle result, out GErrorHandle error);

}
