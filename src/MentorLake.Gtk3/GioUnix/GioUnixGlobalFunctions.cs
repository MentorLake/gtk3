namespace MentorLake.GioUnix;

public class GioUnixGlobalFunctions
{
	public static MentorLake.Gio.GAppInfoHandle DesktopAppInfoLookupGetDefaultForUriScheme(MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme)
	{
		return GioUnixGlobalFunctionsExterns.g_desktop_app_info_lookup_get_default_for_uri_scheme(lookup, uri_scheme);
	}

	public static int FileDescriptorBasedGetFd(MentorLake.Gio.GFileDescriptorBasedHandle fd_based)
	{
		return GioUnixGlobalFunctionsExterns.g_file_descriptor_based_get_fd(fd_based);
	}

	public static bool IsMountPathSystemInternal(string mount_path)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_is_mount_path_system_internal(mount_path);
	}

	public static bool IsSystemDevicePath(string device_path)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_is_system_device_path(device_path);
	}

	public static bool IsSystemFsType(string fs_type)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_is_system_fs_type(fs_type);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle MountAt(string mount_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_at(mount_path, out time_read);
	}

	public static int MountCompare(MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_compare(mount1, mount2);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle MountCopy(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_copy(mount_entry);
	}

	public static bool MountEntriesChangedSince(ulong time)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entries_changed_since(time);
	}

	public static MentorLake.GLib.GListHandle MountEntriesGet(out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entries_get(out time_read);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle[] MountEntriesGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_entries_out)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entries_get_from_file(table_path, out time_read_out, out n_entries_out);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle MountEntryAt(string mount_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_at(mount_path, out time_read);
	}

	public static int MountEntryCompare(MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_compare(mount1, mount2);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle MountEntryCopy(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_copy(mount_entry);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle MountEntryFor(string file_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_for(file_path, out time_read);
	}

	public static void MountEntryFree(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		GioUnixGlobalFunctionsExterns.g_unix_mount_entry_free(mount_entry);
	}

	public static string MountEntryGetDevicePath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_device_path(mount_entry);
	}

	public static string MountEntryGetFsType(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_fs_type(mount_entry);
	}

	public static string MountEntryGetMountPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_mount_path(mount_entry);
	}

	public static string MountEntryGetOptions(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_options(mount_entry);
	}

	public static string MountEntryGetRootPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_root_path(mount_entry);
	}

	public static bool MountEntryGuessCanEject(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_can_eject(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle MountEntryGuessIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_icon(mount_entry);
	}

	public static string MountEntryGuessName(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_name(mount_entry);
	}

	public static bool MountEntryGuessShouldDisplay(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_should_display(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle MountEntryGuessSymbolicIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_symbolic_icon(mount_entry);
	}

	public static bool MountEntryIsReadonly(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_is_readonly(mount_entry);
	}

	public static bool MountEntryIsSystemInternal(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_is_system_internal(mount_entry);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle MountFor(string file_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_for(file_path, out time_read);
	}

	public static void MountFree(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		GioUnixGlobalFunctionsExterns.g_unix_mount_free(mount_entry);
	}

	public static string MountGetDevicePath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_device_path(mount_entry);
	}

	public static string MountGetFsType(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_fs_type(mount_entry);
	}

	public static string MountGetMountPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_mount_path(mount_entry);
	}

	public static string MountGetOptions(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_options(mount_entry);
	}

	public static string MountGetRootPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_root_path(mount_entry);
	}

	public static bool MountGuessCanEject(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_can_eject(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle MountGuessIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_icon(mount_entry);
	}

	public static string MountGuessName(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_name(mount_entry);
	}

	public static bool MountGuessShouldDisplay(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_should_display(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle MountGuessSymbolicIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_symbolic_icon(mount_entry);
	}

	public static bool MountIsReadonly(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_is_readonly(mount_entry);
	}

	public static bool MountIsSystemInternal(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_is_system_internal(mount_entry);
	}

	public static MentorLake.Gio.GUnixMountPointHandle MountPointAt(string mount_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_at(mount_path, out time_read);
	}

	public static int MountPointCompare(MentorLake.Gio.GUnixMountPointHandle mount1, MentorLake.Gio.GUnixMountPointHandle mount2)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_compare(mount1, mount2);
	}

	public static MentorLake.Gio.GUnixMountPointHandle MountPointCopy(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_copy(mount_point);
	}

	public static void MountPointFree(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		GioUnixGlobalFunctionsExterns.g_unix_mount_point_free(mount_point);
	}

	public static string MountPointGetDevicePath(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_get_device_path(mount_point);
	}

	public static string MountPointGetFsType(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_get_fs_type(mount_point);
	}

	public static string MountPointGetMountPath(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_get_mount_path(mount_point);
	}

	public static string MountPointGetOptions(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_get_options(mount_point);
	}

	public static bool MountPointGuessCanEject(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_guess_can_eject(mount_point);
	}

	public static MentorLake.Gio.GIconHandle MountPointGuessIcon(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_guess_icon(mount_point);
	}

	public static string MountPointGuessName(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_guess_name(mount_point);
	}

	public static MentorLake.Gio.GIconHandle MountPointGuessSymbolicIcon(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_guess_symbolic_icon(mount_point);
	}

	public static bool MountPointIsLoopback(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_is_loopback(mount_point);
	}

	public static bool MountPointIsReadonly(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_is_readonly(mount_point);
	}

	public static bool MountPointIsUserMountable(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_is_user_mountable(mount_point);
	}

	public static bool MountPointsChangedSince(ulong time)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_points_changed_since(time);
	}

	public static MentorLake.GLib.GListHandle MountPointsGet(out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_points_get(out time_read);
	}

	public static MentorLake.Gio.GUnixMountPointHandle[] MountPointsGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_points_out)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_points_get_from_file(table_path, out time_read_out, out n_points_out);
	}

	public static bool MountsChangedSince(ulong time)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mounts_changed_since(time);
	}

	public static MentorLake.GLib.GListHandle MountsGet(out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mounts_get(out time_read);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle[] MountsGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_entries_out)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mounts_get_from_file(table_path, out time_read_out, out n_entries_out);
	}

}

internal class GioUnixGlobalFunctionsExterns
{
	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_desktop_app_info_lookup_get_default_for_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoLookupHandleImpl>))] MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern int g_file_descriptor_based_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileDescriptorBasedHandleImpl>))] MentorLake.Gio.GFileDescriptorBasedHandle fd_based);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_is_mount_path_system_internal(string mount_path);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_is_system_device_path(string device_path);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_is_system_fs_type(string fs_type);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_at(string mount_path, out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern int g_unix_mount_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount2);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entries_changed_since(ulong time);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_unix_mount_entries_get(out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle[] g_unix_mount_entries_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_entries_out);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_at(string mount_path, out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern int g_unix_mount_entry_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount2);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_for(string file_path, out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_unix_mount_entry_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_device_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_fs_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_mount_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_root_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entry_guess_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_entry_guess_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_guess_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entry_guess_should_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_entry_guess_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entry_is_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entry_is_system_internal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_for(string file_path, out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_unix_mount_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_device_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_fs_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_mount_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_root_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_guess_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_guess_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_guess_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_guess_should_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_guess_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_is_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_is_system_internal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))]
	internal static extern MentorLake.Gio.GUnixMountPointHandle g_unix_mount_point_at(string mount_path, out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern int g_unix_mount_point_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount2);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))]
	internal static extern MentorLake.Gio.GUnixMountPointHandle g_unix_mount_point_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_unix_mount_point_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_point_get_device_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_point_get_fs_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_point_get_mount_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_point_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_point_guess_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_point_guess_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_point_guess_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_point_guess_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_point_is_loopback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_point_is_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_point_is_user_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))] MentorLake.Gio.GUnixMountPointHandle mount_point);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_points_changed_since(ulong time);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_unix_mount_points_get(out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountPointHandle[] g_unix_mount_points_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_points_out);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mounts_changed_since(ulong time);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_unix_mounts_get(out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle[] g_unix_mounts_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_entries_out);

}
