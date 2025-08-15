namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GUnixInputStream` implements [class@Gio.InputStream] for reading from a UNIX
/// file descriptor, including asynchronous operations. (If the file
/// descriptor refers to a socket or pipe, this will use `poll()` to do
/// asynchronous I/O. If it refers to a regular file, it will fall back
/// to doing asynchronous I/O in another thread.)
/// </para>
/// <para>
/// Note that `&amp;lt;gio/gunixinputstream.h&amp;gt;` belongs to the UNIX-specific GIO
/// interfaces, thus you have to use the `gio-unix-2.0.pc` pkg-config
/// file or the `GioUnix-2.0` GIR namespace when using it.
/// </para>
/// </summary>

public class GUnixInputStreamHandle : GInputStreamHandle, GFileDescriptorBasedHandle, GPollableInputStreamHandle
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

	public static MentorLake.Gio.GUnixInputStreamHandle New(int fd, bool close_fd)
	{
		return GUnixInputStreamHandleExterns.g_unix_input_stream_new(fd, close_fd);
	}

}

public static class GUnixInputStreamHandleExtensions
{
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

	public static bool GetCloseFd(this MentorLake.Gio.GUnixInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GUnixInputStreamHandle)");
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

	public static int GetFd(this MentorLake.Gio.GUnixInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GUnixInputStreamHandle)");
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
