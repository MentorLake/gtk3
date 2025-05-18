namespace MentorLake.Gio;

public class GFilterInputStreamHandle : GInputStreamHandle
{
}

public static class GFilterInputStreamHandleExtensions
{
	public static MentorLake.Gio.GInputStreamHandle GetBaseStream(this MentorLake.Gio.GFilterInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterInputStreamHandle)");
		return GFilterInputStreamHandleExterns.g_filter_input_stream_get_base_stream(stream);
	}

	public static bool GetCloseBaseStream(this MentorLake.Gio.GFilterInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterInputStreamHandle)");
		return GFilterInputStreamHandleExterns.g_filter_input_stream_get_close_base_stream(stream);
	}

	public static T SetCloseBaseStream<T>(this T stream, bool close_base) where T : GFilterInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterInputStreamHandle)");
		GFilterInputStreamHandleExterns.g_filter_input_stream_set_close_base_stream(stream, close_base);
		return stream;
	}

}

internal class GFilterInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_filter_input_stream_get_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterInputStreamHandle>))] MentorLake.Gio.GFilterInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_filter_input_stream_get_close_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterInputStreamHandle>))] MentorLake.Gio.GFilterInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_filter_input_stream_set_close_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterInputStreamHandle>))] MentorLake.Gio.GFilterInputStreamHandle stream, bool close_base);

}
