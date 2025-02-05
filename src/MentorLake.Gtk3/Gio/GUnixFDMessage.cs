namespace MentorLake.Gtk3.Gio;

public class GUnixFDMessageHandle : GSocketControlMessageHandle
{
	public static GUnixFDMessageHandle GUnixFdMessageNew()
	{
		return GUnixFDMessageExterns.g_unix_fd_message_new();
	}

	public static GUnixFDMessageHandle GUnixFdMessageNewWithFdList(GUnixFDListHandle fd_list)
	{
		return GUnixFDMessageExterns.g_unix_fd_message_new_with_fd_list(fd_list);
	}

}

public static class GUnixFDMessageHandleExtensions
{
	public static bool GUnixFdMessageAppendFd(this GUnixFDMessageHandle message, int fd, out GErrorHandle error)
	{
		return GUnixFDMessageExterns.g_unix_fd_message_append_fd(message, fd, out error);
	}

	public static GUnixFDListHandle GUnixFdMessageGetFdList(this GUnixFDMessageHandle message)
	{
		return GUnixFDMessageExterns.g_unix_fd_message_get_fd_list(message);
	}

	public static IntPtr GUnixFdMessageStealFds(this GUnixFDMessageHandle message, out int length)
	{
		return GUnixFDMessageExterns.g_unix_fd_message_steal_fds(message, out length);
	}

}

internal class GUnixFDMessageExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GUnixFDMessageHandle g_unix_fd_message_new();

	[DllImport(Libraries.Gio)]
	internal static extern GUnixFDMessageHandle g_unix_fd_message_new_with_fd_list(GUnixFDListHandle fd_list);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_fd_message_append_fd(GUnixFDMessageHandle message, int fd, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GUnixFDListHandle g_unix_fd_message_get_fd_list(GUnixFDMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_unix_fd_message_steal_fds(GUnixFDMessageHandle message, out int length);

}
