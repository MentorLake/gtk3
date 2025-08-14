namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This [class@Gio.SocketControlMessage] contains a [class@Gio.UnixFDList].
/// It may be sent using [method@Gio.Socket.send_message] and received using
/// [method@Gio.Socket.receive_message] over UNIX sockets (ie: sockets in the
/// `G_SOCKET_FAMILY_UNIX` family). The file descriptors are copied
/// between processes by the kernel.
/// </para>
/// <para>
/// For an easier way to send and receive file descriptors over
/// stream-oriented UNIX sockets, see [method@Gio.UnixConnection.send_fd] and
/// [method@Gio.UnixConnection.receive_fd].
/// </para>
/// <para>
/// Note that `<gio/gunixfdmessage.h>` belongs to the UNIX-specific GIO
/// interfaces, thus you have to use the `gio-unix-2.0.pc` pkg-config
/// file or the `GioUnix-2.0` GIR namespace when using it.
/// </para>
/// </summary>

public class GUnixFDMessageHandle : GSocketControlMessageHandle
{
/// <summary>
/// <para>
/// Creates a new #GUnixFDMessage containing an empty file descriptor
/// list.
/// </para>
/// </summary>

/// <return>
/// a new #GUnixFDMessage
/// </return>

	public static MentorLake.Gio.GUnixFDMessageHandle New()
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_new();
	}

/// <summary>
/// <para>
/// Creates a new #GUnixFDMessage containing @list.
/// </para>
/// </summary>

/// <param name="fd_list">
/// a #GUnixFDList
/// </param>
/// <return>
/// a new #GUnixFDMessage
/// </return>

	public static MentorLake.Gio.GUnixFDMessageHandle NewWithFdList(MentorLake.Gio.GUnixFDListHandle fd_list)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_new_with_fd_list(fd_list);
	}

}

public static class GUnixFDMessageHandleExtensions
{
/// <summary>
/// <para>
/// Adds a file descriptor to @message.
/// </para>
/// <para>
/// The file descriptor is duplicated using dup(). You keep your copy
/// of the descriptor and the copy contained in @message will be closed
/// when @message is finalized.
/// </para>
/// <para>
/// A possible cause of failure is exceeding the per-process or
/// system-wide file descriptor limit.
/// </para>
/// </summary>

/// <param name="message">
/// a #GUnixFDMessage
/// </param>
/// <param name="fd">
/// a valid open file descriptor
/// </param>
/// <return>
/// %TRUE in case of success, else %FALSE (and @error is set)
/// </return>

	public static bool AppendFd(this MentorLake.Gio.GUnixFDMessageHandle message, int fd)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GUnixFDMessageHandle)");
		var externCallResult = GUnixFDMessageHandleExterns.g_unix_fd_message_append_fd(message, fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the #GUnixFDList contained in @message.  This function does not
/// return a reference to the caller, but the returned list is valid for
/// the lifetime of @message.
/// </para>
/// </summary>

/// <param name="message">
/// a #GUnixFDMessage
/// </param>
/// <return>
/// the #GUnixFDList from @message
/// </return>

	public static MentorLake.Gio.GUnixFDListHandle GetFdList(this MentorLake.Gio.GUnixFDMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GUnixFDMessageHandle)");
		return GUnixFDMessageHandleExterns.g_unix_fd_message_get_fd_list(message);
	}

/// <summary>
/// <para>
/// Returns the array of file descriptors that is contained in this
/// object.
/// </para>
/// <para>
/// After this call, the descriptors are no longer contained in
/// @message. Further calls will return an empty list (unless more
/// descriptors have been added).
/// </para>
/// <para>
/// The return result of this function must be freed with g_free().
/// The caller is also responsible for closing all of the file
/// descriptors.
/// </para>
/// <para>
/// If @length is non-%NULL then it is set to the number of file
/// descriptors in the returned array. The returned array is also
/// terminated with -1.
/// </para>
/// <para>
/// This function never returns %NULL. In case there are no file
/// descriptors contained in @message, an empty array is returned.
/// </para>
/// </summary>

/// <param name="message">
/// a #GUnixFDMessage
/// </param>
/// <param name="length">
/// pointer to the length of the returned
///     array, or %NULL
/// </param>
/// <return>
/// an array of file
///     descriptors
/// </return>

	public static int[] StealFds(this MentorLake.Gio.GUnixFDMessageHandle message, out int length)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (GUnixFDMessageHandle)");
		return GUnixFDMessageHandleExterns.g_unix_fd_message_steal_fds(message, out length);
	}

}

internal class GUnixFDMessageHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))]
	internal static extern MentorLake.Gio.GUnixFDMessageHandle g_unix_fd_message_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))]
	internal static extern MentorLake.Gio.GUnixFDMessageHandle g_unix_fd_message_new_with_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_fd_message_append_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message, int fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_unix_fd_message_get_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_message_steal_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message, out int length);

}
