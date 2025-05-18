namespace MentorLake.Gio;

public class GUnixInputStreamHandle : GInputStreamHandle, GFileDescriptorBasedHandle, GPollableInputStreamHandle
{
	public static MentorLake.Gio.GUnixInputStreamHandle New(int fd, bool close_fd)
	{
		return GUnixInputStreamHandleExterns.g_unix_input_stream_new(fd, close_fd);
	}

}

public static class GUnixInputStreamHandleExtensions
{
	public static bool GetCloseFd(this MentorLake.Gio.GUnixInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GUnixInputStreamHandle)");
		return GUnixInputStreamHandleExterns.g_unix_input_stream_get_close_fd(stream);
	}

	public static int GetFd(this MentorLake.Gio.GUnixInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GUnixInputStreamHandle)");
		return GUnixInputStreamHandleExterns.g_unix_input_stream_get_fd(stream);
	}

	public static T SetCloseFd<T>(this T stream, bool close_fd) where T : GUnixInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GUnixInputStreamHandle)");
		GUnixInputStreamHandleExterns.g_unix_input_stream_set_close_fd(stream, close_fd);
		return stream;
	}

}

internal class GUnixInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixInputStreamHandle>))]
	internal static extern MentorLake.Gio.GUnixInputStreamHandle g_unix_input_stream_new(int fd, bool close_fd);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_input_stream_get_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixInputStreamHandle>))] MentorLake.Gio.GUnixInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_input_stream_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixInputStreamHandle>))] MentorLake.Gio.GUnixInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_input_stream_set_close_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixInputStreamHandle>))] MentorLake.Gio.GUnixInputStreamHandle stream, bool close_fd);

}
