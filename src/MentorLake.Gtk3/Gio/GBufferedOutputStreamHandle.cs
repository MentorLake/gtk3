namespace MentorLake.Gio;

public class GBufferedOutputStreamHandle : GFilterOutputStreamHandle, GSeekableHandle
{
	public static MentorLake.Gio.GBufferedOutputStreamHandle New(MentorLake.Gio.GOutputStreamHandle base_stream)
	{
		return GBufferedOutputStreamHandleExterns.g_buffered_output_stream_new(base_stream);
	}

	public static MentorLake.Gio.GBufferedOutputStreamHandle NewSized(MentorLake.Gio.GOutputStreamHandle base_stream, UIntPtr size)
	{
		return GBufferedOutputStreamHandleExterns.g_buffered_output_stream_new_sized(base_stream, size);
	}

}

public static class GBufferedOutputStreamHandleExtensions
{
	public static bool GetAutoGrow(this MentorLake.Gio.GBufferedOutputStreamHandle stream)
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GBufferedOutputStreamHandle)");
		return GBufferedOutputStreamHandleExterns.g_buffered_output_stream_get_auto_grow(stream);
	}

	public static UIntPtr GetBufferSize(this MentorLake.Gio.GBufferedOutputStreamHandle stream)
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GBufferedOutputStreamHandle)");
		return GBufferedOutputStreamHandleExterns.g_buffered_output_stream_get_buffer_size(stream);
	}

	public static T SetAutoGrow<T>(this T stream, bool auto_grow) where T : GBufferedOutputStreamHandle
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GBufferedOutputStreamHandle)");
		GBufferedOutputStreamHandleExterns.g_buffered_output_stream_set_auto_grow(stream, auto_grow);
		return stream;
	}

	public static T SetBufferSize<T>(this T stream, UIntPtr size) where T : GBufferedOutputStreamHandle
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GBufferedOutputStreamHandle)");
		GBufferedOutputStreamHandleExterns.g_buffered_output_stream_set_buffer_size(stream, size);
		return stream;
	}

}

internal class GBufferedOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GBufferedOutputStreamHandle g_buffered_output_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle base_stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GBufferedOutputStreamHandle g_buffered_output_stream_new_sized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle base_stream, UIntPtr size);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_buffered_output_stream_get_auto_grow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))] MentorLake.Gio.GBufferedOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_buffered_output_stream_get_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))] MentorLake.Gio.GBufferedOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_buffered_output_stream_set_auto_grow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))] MentorLake.Gio.GBufferedOutputStreamHandle stream, bool auto_grow);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_buffered_output_stream_set_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBufferedOutputStreamHandle>))] MentorLake.Gio.GBufferedOutputStreamHandle stream, UIntPtr size);

}
