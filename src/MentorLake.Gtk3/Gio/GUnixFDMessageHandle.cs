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
	public static bool AppendFd(this MentorLake.Gio.GUnixFDMessageHandle message, int fd)
	{
		if (message.IsInvalid || message.IsClosed) throw new Exception("Invalid or closed handle (GUnixFDMessageHandle)");
		var externCallResult = GUnixFDMessageHandleExterns.g_unix_fd_message_append_fd(message, fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GUnixFDListHandle GetFdList(this MentorLake.Gio.GUnixFDMessageHandle message)
	{
		if (message.IsInvalid || message.IsClosed) throw new Exception("Invalid or closed handle (GUnixFDMessageHandle)");
		return GUnixFDMessageHandleExterns.g_unix_fd_message_get_fd_list(message);
	}

	public static int[] StealFds(this MentorLake.Gio.GUnixFDMessageHandle message, out int length)
	{
		if (message.IsInvalid || message.IsClosed) throw new Exception("Invalid or closed handle (GUnixFDMessageHandle)");
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
	internal static extern bool g_unix_fd_message_append_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message, int fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_unix_fd_message_get_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_message_steal_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDMessageHandle>))] MentorLake.Gio.GUnixFDMessageHandle message, out int length);

}
