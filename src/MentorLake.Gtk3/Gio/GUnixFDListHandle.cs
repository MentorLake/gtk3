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
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GUnixFDListHandle)");
		var externCallResult = GUnixFDListHandleExterns.g_unix_fd_list_append(list, fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int Get(this MentorLake.Gio.GUnixFDListHandle list, int index_)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GUnixFDListHandle)");
		var externCallResult = GUnixFDListHandleExterns.g_unix_fd_list_get(list, index_, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int GetLength(this MentorLake.Gio.GUnixFDListHandle list)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GUnixFDListHandle)");
		return GUnixFDListHandleExterns.g_unix_fd_list_get_length(list);
	}

	public static int[] PeekFds(this MentorLake.Gio.GUnixFDListHandle list, out int length)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GUnixFDListHandle)");
		return GUnixFDListHandleExterns.g_unix_fd_list_peek_fds(list, out length);
	}

	public static int[] StealFds(this MentorLake.Gio.GUnixFDListHandle list, out int length)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GUnixFDListHandle)");
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
	internal static extern int g_unix_fd_list_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, int fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_fd_list_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, int index_, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_fd_list_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_list_peek_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, out int length);

	[DllImport(GioLibrary.Name)]
	internal static extern int[] g_unix_fd_list_steal_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle list, out int length);

}
