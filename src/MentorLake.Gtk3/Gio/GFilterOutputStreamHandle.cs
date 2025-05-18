namespace MentorLake.Gio;

public class GFilterOutputStreamHandle : GOutputStreamHandle
{
}

public static class GFilterOutputStreamHandleExtensions
{
	public static MentorLake.Gio.GOutputStreamHandle GetBaseStream(this MentorLake.Gio.GFilterOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterOutputStreamHandle)");
		return GFilterOutputStreamHandleExterns.g_filter_output_stream_get_base_stream(stream);
	}

	public static bool GetCloseBaseStream(this MentorLake.Gio.GFilterOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterOutputStreamHandle)");
		return GFilterOutputStreamHandleExterns.g_filter_output_stream_get_close_base_stream(stream);
	}

	public static T SetCloseBaseStream<T>(this T stream, bool close_base) where T : GFilterOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFilterOutputStreamHandle)");
		GFilterOutputStreamHandleExterns.g_filter_output_stream_set_close_base_stream(stream, close_base);
		return stream;
	}

}

internal class GFilterOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GOutputStreamHandle g_filter_output_stream_get_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterOutputStreamHandle>))] MentorLake.Gio.GFilterOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_filter_output_stream_get_close_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterOutputStreamHandle>))] MentorLake.Gio.GFilterOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_filter_output_stream_set_close_base_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFilterOutputStreamHandle>))] MentorLake.Gio.GFilterOutputStreamHandle stream, bool close_base);

}
