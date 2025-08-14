namespace MentorLake.GioUnix;

/// <summary>
/// <para>
/// `GUnixInputStream` implements [class@Gio.InputStream] for reading from a UNIX
/// file descriptor, including asynchronous operations. (If the file
/// descriptor refers to a socket or pipe, this will use `poll()` to do
/// asynchronous I/O. If it refers to a regular file, it will fall back
/// to doing asynchronous I/O in another thread.)
/// </para>
/// <para>
/// Note that `<gio/gunixinputstream.h>` belongs to the UNIX-specific GIO
/// interfaces, thus you have to use the `gio-unix-2.0.pc` pkg-config
/// file or the `GioUnix-2.0` GIR namespace when using it.
/// </para>
/// </summary>

public class GUnixInputStreamHandle : GInputStreamHandle, GPollableInputStreamHandle, GFileDescriptorBasedHandle
{
/// <summary>
/// <para>
/// Creates a new #GUnixInputStream for the given @fd.
/// </para>
/// <para>
/// If @close_fd is %TRUE, the file descriptor will be closed
/// when the stream is closed.
/// </para>
/// </summary>

/// <param name="fd">
/// a UNIX file descriptor
/// </param>
/// <param name="close_fd">
/// %TRUE to close the file descriptor when done
/// </param>
/// <return>
/// a new #GUnixInputStream
/// </return>

	public static MentorLake.GioUnix.GUnixInputStreamHandle New(int fd, bool close_fd)
	{
		return GUnixInputStreamHandleExterns.g_unix_input_stream_new(fd, close_fd);
	}

/// <summary>
/// <para>
/// Returns whether the file descriptor of @stream will be
/// closed when the stream is closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GUnixInputStream
/// </param>
/// <return>
/// %TRUE if the file descriptor is closed when done
/// </return>

	public static bool GetCloseFd(MentorLake.Gio.GUnixInputStreamHandle stream)
	{
		return GUnixInputStreamHandleExterns.g_unix_input_stream_get_close_fd(stream);
	}

/// <summary>
/// <para>
/// Return the UNIX file descriptor that the stream reads from.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GUnixInputStream
/// </param>
/// <return>
/// The file descriptor of @stream
/// </return>

	public static int GetFd(MentorLake.Gio.GUnixInputStreamHandle stream)
	{
		return GUnixInputStreamHandleExterns.g_unix_input_stream_get_fd(stream);
	}

/// <summary>
/// <para>
/// Sets whether the file descriptor of @stream shall be closed
/// when the stream is closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GUnixInputStream
/// </param>
/// <param name="close_fd">
/// %TRUE to close the file descriptor when done
/// </param>

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
