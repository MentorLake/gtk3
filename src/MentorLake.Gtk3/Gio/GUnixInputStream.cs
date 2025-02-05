namespace MentorLake.Gtk3.Gio;

public class GUnixInputStreamHandle : GInputStreamHandle, GFileDescriptorBasedHandle, GPollableInputStreamHandle
{
	public static GUnixInputStreamHandle New(int fd, bool close_fd)
	{
		return GUnixInputStreamExterns.g_unix_input_stream_new(fd, close_fd);
	}

}

public static class GUnixInputStreamHandleExtensions
{
	public static bool GetCloseFd(this GUnixInputStreamHandle stream)
	{
		return GUnixInputStreamExterns.g_unix_input_stream_get_close_fd(stream);
	}

	public static int GetFd(this GUnixInputStreamHandle stream)
	{
		return GUnixInputStreamExterns.g_unix_input_stream_get_fd(stream);
	}

	public static T SetCloseFd<T>(this T stream, bool close_fd) where T : GUnixInputStreamHandle
	{
		GUnixInputStreamExterns.g_unix_input_stream_set_close_fd(stream, close_fd);
		return stream;
	}

}

internal class GUnixInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GUnixInputStreamHandle g_unix_input_stream_new(int fd, bool close_fd);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_input_stream_get_close_fd(GUnixInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_input_stream_get_fd(GUnixInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_input_stream_set_close_fd(GUnixInputStreamHandle stream, bool close_fd);

}
