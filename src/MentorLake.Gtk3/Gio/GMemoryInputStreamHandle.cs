namespace MentorLake.Gio;

public class GMemoryInputStreamHandle : GInputStreamHandle, GPollableInputStreamHandle, GSeekableHandle
{
	public static MentorLake.Gio.GMemoryInputStreamHandle New()
	{
		return GMemoryInputStreamHandleExterns.g_memory_input_stream_new();
	}

	public static MentorLake.Gio.GMemoryInputStreamHandle NewFromBytes(MentorLake.GLib.GBytesHandle bytes)
	{
		return GMemoryInputStreamHandleExterns.g_memory_input_stream_new_from_bytes(bytes);
	}

	public static MentorLake.Gio.GMemoryInputStreamHandle NewFromData(byte[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify destroy)
	{
		return GMemoryInputStreamHandleExterns.g_memory_input_stream_new_from_data(data, len, destroy);
	}

}

public static class GMemoryInputStreamHandleExtensions
{
	public static T AddBytes<T>(this T stream, MentorLake.GLib.GBytesHandle bytes) where T : GMemoryInputStreamHandle
	{
		GMemoryInputStreamHandleExterns.g_memory_input_stream_add_bytes(stream, bytes);
		return stream;
	}

	public static T AddData<T>(this T stream, byte[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify destroy) where T : GMemoryInputStreamHandle
	{
		GMemoryInputStreamHandleExterns.g_memory_input_stream_add_data(stream, data, len, destroy);
		return stream;
	}

}

internal class GMemoryInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMemoryInputStreamHandle g_memory_input_stream_new();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMemoryInputStreamHandle g_memory_input_stream_new_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMemoryInputStreamHandle g_memory_input_stream_new_from_data(byte[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_memory_input_stream_add_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryInputStreamHandle>))] MentorLake.Gio.GMemoryInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_memory_input_stream_add_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryInputStreamHandle>))] MentorLake.Gio.GMemoryInputStreamHandle stream, byte[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify destroy);

}
