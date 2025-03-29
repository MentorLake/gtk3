namespace MentorLake.Gio;

public class GUnixMountEntryHandle : BaseSafeHandle
{
}


public static class GUnixMountEntryExtensions
{
	public static int Compare(this MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		if (mount1.IsInvalid || mount1.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_compare(mount1, mount2);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle Copy(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_copy(mount_entry);
	}

	public static void Free(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		GUnixMountEntryExterns.g_unix_mount_entry_free(mount_entry);
	}

	public static string GetDevicePath(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_get_device_path(mount_entry);
	}

	public static string GetFsType(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_get_fs_type(mount_entry);
	}

	public static string GetMountPath(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_get_mount_path(mount_entry);
	}

	public static string GetOptions(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_get_options(mount_entry);
	}

	public static string GetRootPath(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_get_root_path(mount_entry);
	}

	public static bool GuessCanEject(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_can_eject(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle GuessIcon(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_icon(mount_entry);
	}

	public static string GuessName(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_name(mount_entry);
	}

	public static bool GuessShouldDisplay(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_should_display(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle GuessSymbolicIcon(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_symbolic_icon(mount_entry);
	}

	public static bool IsReadonly(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_is_readonly(mount_entry);
	}

	public static bool IsSystemInternal(this MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		if (mount_entry.IsInvalid || mount_entry.IsClosed) throw new Exception("Invalid or closed handle (GUnixMountEntry)");
		return GUnixMountEntryExterns.g_unix_mount_entry_is_system_internal(mount_entry);
	}


	public static GUnixMountEntry Dereference(this GUnixMountEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixMountEntry>(x.DangerousGetHandle());
}
internal class GUnixMountEntryExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_mount_entry_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount2);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_mount_entry_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_device_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_fs_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_mount_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_root_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_entry_guess_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_entry_guess_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_guess_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_entry_guess_should_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_entry_guess_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_entry_is_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_entry_is_system_internal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_at(string mount_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_for(string file_path, out ulong time_read);

}

public struct GUnixMountEntry
{
	public static MentorLake.Gio.GUnixMountEntryHandle At(string mount_path, out ulong time_read)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_at(mount_path, out time_read);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle For(string file_path, out ulong time_read)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_for(file_path, out time_read);
	}

}
