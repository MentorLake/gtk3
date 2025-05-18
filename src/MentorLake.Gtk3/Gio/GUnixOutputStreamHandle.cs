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
		if (stream.IsInvalid) throw new Exception("Invalid handle (GUnixOutputStreamHandle)");
		return GUnixOutputStreamHandleExterns.g_unix_output_stream_get_close_fd(stream);
	}

	public static int GetFd(this MentorLake.Gio.GUnixOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GUnixOutputStreamHandle)");
		return GUnixOutputStreamHandleExterns.g_unix_output_stream_get_fd(stream);
	}

	public static T SetCloseFd<T>(this T stream, bool close_fd) where T : GUnixOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GUnixOutputStreamHandle)");
		GUnixOutputStreamHandleExterns.g_unix_output_stream_set_close_fd(stream, close_fd);
		return stream;
	}

}

internal class GUnixOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GUnixOutputStreamHandle g_unix_output_stream_new(int fd, bool close_fd);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_output_stream_get_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_output_stream_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_output_stream_set_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixOutputStreamHandle>))] MentorLake.Gio.GUnixOutputStreamHandle stream, bool close_fd);

}
