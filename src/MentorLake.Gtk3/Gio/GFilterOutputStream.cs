namespace MentorLake.Gtk3.Gio;

public class GFilterOutputStreamHandle : GOutputStreamHandle
{
}

public static class GFilterOutputStreamHandleExtensions
{
	public static GOutputStreamHandle GetBaseStream(this GFilterOutputStreamHandle stream)
	{
		return GFilterOutputStreamExterns.g_filter_output_stream_get_base_stream(stream);
	}

	public static bool GetCloseBaseStream(this GFilterOutputStreamHandle stream)
	{
		return GFilterOutputStreamExterns.g_filter_output_stream_get_close_base_stream(stream);
	}

	public static T SetCloseBaseStream<T>(this T stream, bool close_base) where T : GFilterOutputStreamHandle
	{
		GFilterOutputStreamExterns.g_filter_output_stream_set_close_base_stream(stream, close_base);
		return stream;
	}

}

internal class GFilterOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GOutputStreamHandle g_filter_output_stream_get_base_stream(GFilterOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_filter_output_stream_get_close_base_stream(GFilterOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern void g_filter_output_stream_set_close_base_stream(GFilterOutputStreamHandle stream, bool close_base);

}
