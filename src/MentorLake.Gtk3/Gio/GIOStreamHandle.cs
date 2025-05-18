namespace MentorLake.Gio;

public class GIOStreamHandle : GObjectHandle
{
	public static bool SpliceFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GIOStreamHandleExterns.g_io_stream_splice_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GIOStreamHandleExtensions
{
	public static T ClearPending<T>(this T stream) where T : GIOStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		GIOStreamHandleExterns.g_io_stream_clear_pending(stream);
		return stream;
	}

	public static bool Close(this MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		var externCallResult = GIOStreamHandleExterns.g_io_stream_close(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T CloseAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GIOStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		GIOStreamHandleExterns.g_io_stream_close_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static bool CloseFinish(this MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		var externCallResult = GIOStreamHandleExterns.g_io_stream_close_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GInputStreamHandle GetInputStream(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		return GIOStreamHandleExterns.g_io_stream_get_input_stream(stream);
	}

	public static MentorLake.Gio.GOutputStreamHandle GetOutputStream(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		return GIOStreamHandleExterns.g_io_stream_get_output_stream(stream);
	}

	public static bool HasPending(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		return GIOStreamHandleExterns.g_io_stream_has_pending(stream);
	}

	public static bool IsClosed(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		return GIOStreamHandleExterns.g_io_stream_is_closed(stream);
	}

	public static bool SetPending(this MentorLake.Gio.GIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GIOStreamHandle)");
		var externCallResult = GIOStreamHandleExterns.g_io_stream_set_pending(stream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

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
