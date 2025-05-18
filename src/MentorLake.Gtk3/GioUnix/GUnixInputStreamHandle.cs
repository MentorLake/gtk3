namespace MentorLake.GioUnix;

public class GUnixInputStreamHandle : GInputStreamHandle, GPollableInputStreamHandle, GFileDescriptorBasedHandle
{
	public static MentorLake.GioUnix.GUnixInputStreamHandle New(int fd, bool close_fd)
	{
		return GUnixInputStreamHandleExterns.g_unix_input_stream_new(fd, close_fd);
	}

	public static bool GetCloseFd(MentorLake.Gio.GUnixInputStreamHandle stream)
	{
		return GUnixInputStreamHandleExterns.g_unix_input_stream_get_close_fd(stream);
	}

	public static int GetFd(MentorLake.Gio.GUnixInputStreamHandle stream)
	{
		return GUnixInputStreamHandleExterns.g_unix_input_stream_get_fd(stream);
	}

	public static void SetCloseFd(MentorLake.Gio.GUnixInputStreamHandle stream, bool close_fd)
	{
		GUnixInputStreamHandleExterns.g_unix_input_stream_set_close_fd(stream, close_fd);
	}

}

public static class GUnixInputStreamHandleExtensions
{
}

internal class GUnixInputStreamHandleExterns
{
	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GioUnix.GUnixInputStreamHandle>))]
	internal static extern MentorLake.GioUnix.GUnixInputStreamHandle g_unix_input_stream_new(int fd, bool close_fd);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_input_stream_get_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixInputStreamHandle>))] MentorLake.Gio.GUnixInputStreamHandle stream);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern int g_unix_input_stream_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixInputStreamHandle>))] MentorLake.Gio.GUnixInputStreamHandle stream);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_unix_input_stream_set_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixInputStreamHandle>))] MentorLake.Gio.GUnixInputStreamHandle stream, bool close_fd);

}
