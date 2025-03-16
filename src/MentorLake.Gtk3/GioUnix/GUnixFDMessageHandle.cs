namespace MentorLake.GioUnix;

public class GUnixFDMessageHandle : GSocketControlMessageHandle
{
	public static MentorLake.GioUnix.GUnixFDMessageHandle New()
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_new();
	}

	public static MentorLake.GioUnix.GUnixFDMessageHandle NewWithFdList(MentorLake.Gio.GUnixFDListHandle fd_list)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_new_with_fd_list(fd_list);
	}

	public static bool AppendFd(MentorLake.Gio.GUnixFDMessageHandle message, int fd)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_append_fd(message, fd);
	}

	public static MentorLake.Gio.GUnixFDListHandle GetFdList(MentorLake.Gio.GUnixFDMessageHandle message)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_get_fd_list(message);
	}

	public static int[] StealFds(MentorLake.Gio.GUnixFDMessageHandle message, out int length)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_steal_fds(message, out length);
	}

}

public static class GUnixFDMessageHandleExtensions
{
}

internal class GUnixFDMessageHandleExterns
{
	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.GioUnix.GUnixFDMessageHandle g_unix_fd_message_new();

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.GioUnix.GUnixFDMessageHandle g_unix_fd_message_new_with_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_fd_message_append_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message, int fd);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_unix_fd_message_get_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern int[] g_unix_fd_message_steal_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message, out int length);

}
