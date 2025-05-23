namespace MentorLake.Gio;

public class GBufferedInputStreamHandle : GFilterInputStreamHandle, GSeekableHandle
{
	public static MentorLake.Gio.GBufferedInputStreamHandle New(MentorLake.Gio.GInputStreamHandle base_stream)
	{
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_new(base_stream);
	}

	public static MentorLake.Gio.GBufferedInputStreamHandle NewSized(MentorLake.Gio.GInputStreamHandle base_stream, UIntPtr size)
	{
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_new_sized(base_stream, size);
	}

}

public static class GBufferedInputStreamHandleExtensions
{
	public static UIntPtr Fill(this MentorLake.Gio.GBufferedInputStreamHandle stream, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		var externCallResult = GBufferedInputStreamHandleExterns.g_buffered_input_stream_fill(stream, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T FillAsync<T>(this T stream, UIntPtr count, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GBufferedInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		GBufferedInputStreamHandleExterns.g_buffered_input_stream_fill_async(stream, count, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static UIntPtr FillFinish(this MentorLake.Gio.GBufferedInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		var externCallResult = GBufferedInputStreamHandleExterns.g_buffered_input_stream_fill_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr GetAvailable(this MentorLake.Gio.GBufferedInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_get_available(stream);
	}

	public static UIntPtr GetBufferSize(this MentorLake.Gio.GBufferedInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_get_buffer_size(stream);
	}

	public static UIntPtr Peek(this MentorLake.Gio.GBufferedInputStreamHandle stream, byte[] buffer, UIntPtr offset, UIntPtr count)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_peek(stream, buffer, offset, count);
	}

	public static byte[] PeekBuffer(this MentorLake.Gio.GBufferedInputStreamHandle stream, out UIntPtr count)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		return GBufferedInputStreamHandleExterns.g_buffered_input_stream_peek_buffer(stream, out count);
	}

	public static int ReadByte(this MentorLake.Gio.GBufferedInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GBufferedInputStreamHandle)");
		var externCallResult = GBufferedInputStreamHandleExterns.g_buffered_input_stream_read_byte(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

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
