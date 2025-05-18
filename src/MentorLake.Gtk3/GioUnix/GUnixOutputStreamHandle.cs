namespace MentorLake.GioUnix;

public class GUnixOutputStreamHandle : GOutputStreamHandle, GPollableOutputStreamHandle, GFileDescriptorBasedHandle
{
	public static MentorLake.GioUnix.GUnixOutputStreamHandle New(int fd, bool close_fd)
	{
		return GUnixOutputStreamHandleExterns.g_unix_output_stream_new(fd, close_fd);
	}

	public static bool GetCloseFd(MentorLake.Gio.GUnixOutputStreamHandle stream)
	{
		return GUnixOutputStreamHandleExterns.g_unix_output_stream_get_close_fd(stream);
	}

	public static int GetFd(MentorLake.Gio.GUnixOutputStreamHandle stream)
	{
		return GUnixOutputStreamHandleExterns.g_unix_output_stream_get_fd(stream);
	}

	public static void SetCloseFd(MentorLake.Gio.GUnixOutputStreamHandle stream, bool close_fd)
	{
		GUnixOutputStreamHandleExterns.g_unix_output_stream_set_close_fd(stream, close_fd);
	}

}

public static class GUnixOutputStreamHandleExtensions
{
}

internal class GUnixOutputStreamHandleExterns
{
	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GioUnix.GUnixOutputStreamHandle>))]
	internal static extern MentorLake.GioUnix.GUnixOutputStreamHandle g_unix_output_stream_new(int fd, bool close_fd);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_output_stream_get_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern int g_unix_output_stream_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_unix_output_stream_set_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream, bool close_fd);

}
