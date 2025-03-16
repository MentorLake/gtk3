namespace MentorLake.Gio;

public class GUnixFDListHandle : GObjectHandle
{
	public static MentorLake.Gio.GUnixFDListHandle New()
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_new();
	}

	public static MentorLake.Gio.GUnixFDListHandle NewFromArray(int[] fds, int n_fds)
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_new_from_array(fds, n_fds);
	}

}

public static class GUnixFDListHandleExtensions
{
	public static int Append(this MentorLake.Gio.GUnixFDListHandle list, int fd)
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_append(list, fd);
	}

	public static int Get(this MentorLake.Gio.GUnixFDListHandle list, int index_)
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_get(list, index_);
	}

	public static int GetLength(this MentorLake.Gio.GUnixFDListHandle list)
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_get_length(list);
	}

	public static int[] PeekFds(this MentorLake.Gio.GUnixFDListHandle list, out int length)
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_peek_fds(list, out length);
	}

	public static int[] StealFds(this MentorLake.Gio.GUnixFDListHandle list, out int length)
	{
		return GUnixFDListHandleExterns.g_unix_fd_list_steal_fds(list, out length);
	}

}

internal class GUnixFDListHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_unix_fd_list_new();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixFDListHandle g_unix_fd_list_new_from_array(int[] fds, int n_fds);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_fd_list_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, int fd);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_fd_list_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, int index_);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_fd_list_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_list_peek_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, out int length);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_list_steal_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, out int length);

}
