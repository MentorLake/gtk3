namespace MentorLake.Gio;

public class GUnixFDMessageHandle : GSocketControlMessageHandle
{
	public static MentorLake.Gio.GUnixFDMessageHandle New()
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_new();
	}

	public static MentorLake.Gio.GUnixFDMessageHandle NewWithFdList(MentorLake.Gio.GUnixFDListHandle fd_list)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_new_with_fd_list(fd_list);
	}

}

public static class GUnixFDMessageHandleExtensions
{
	public static bool AppendFd(this MentorLake.Gio.GUnixFDMessageHandle message, int fd, IntPtr error)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_append_fd(message, fd, error);
	}

	public static MentorLake.Gio.GUnixFDListHandle GetFdList(this MentorLake.Gio.GUnixFDMessageHandle message)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_get_fd_list(message);
	}

	public static int[] StealFds(this MentorLake.Gio.GUnixFDMessageHandle message, out int length)
	{
		return GUnixFDMessageHandleExterns.g_unix_fd_message_steal_fds(message, out length);
	}

}

internal class GUnixFDMessageHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixFDMessageHandle g_unix_fd_message_new();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixFDMessageHandle g_unix_fd_message_new_with_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_fd_message_append_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message, int fd, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_unix_fd_message_get_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_message_steal_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message, out int length);

}
