namespace MentorLake.Gio;

public class GUnixOutputStreamHandle : GOutputStreamHandle, GFileDescriptorBasedHandle, GPollableOutputStreamHandle
{
	public static MentorLake.Gio.GUnixOutputStreamHandle New(int fd, bool close_fd)
	{
		return GUnixOutputStreamHandleExterns.g_unix_output_stream_new(fd, close_fd);
	}

}

public static class GUnixOutputStreamHandleExtensions
{
	public static bool GetCloseFd(this MentorLake.Gio.GUnixOutputStreamHandle stream)
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GUnixOutputStreamHandle)");
		return GUnixOutputStreamHandleExterns.g_unix_output_stream_get_close_fd(stream);
	}

	public static int GetFd(this MentorLake.Gio.GUnixOutputStreamHandle stream)
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GUnixOutputStreamHandle)");
		return GUnixOutputStreamHandleExterns.g_unix_output_stream_get_fd(stream);
	}

	public static T SetCloseFd<T>(this T stream, bool close_fd) where T : GUnixOutputStreamHandle
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GUnixOutputStreamHandle)");
		GUnixOutputStreamHandleExterns.g_unix_output_stream_set_close_fd(stream, close_fd);
		return stream;
	}

}

internal class GUnixOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixOutputStreamHandle g_unix_output_stream_new(int fd, bool close_fd);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_output_stream_get_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_output_stream_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_output_stream_set_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream, bool close_fd);

}
