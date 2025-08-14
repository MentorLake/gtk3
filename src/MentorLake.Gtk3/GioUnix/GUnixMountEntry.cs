namespace MentorLake.GioUnix;

/// <summary>
/// <para>
/// Defines a Unix mount entry (e.g. `/media/cdrom`).
/// This corresponds roughly to a mtab entry.
/// </para>
/// </summary>

public class GUnixMountEntryHandle : BaseSafeHandle
{
}


public static class GUnixMountEntryExtensions
{

	public static GUnixMountEntry Dereference(this GUnixMountEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixMountEntry>(x.DangerousGetHandle());
}
internal class GUnixMountEntryExterns
{
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

}

/// <summary>
/// <para>
/// Defines a Unix mount entry (e.g. `/media/cdrom`).
/// This corresponds roughly to a mtab entry.
/// </para>
/// </summary>

public struct GUnixMountEntry
{
/// <summary>
/// <para>
/// Gets a [struct@GioUnix.MountEntry] for a given mount path.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with a Unix timestamp for checking
/// if the mounts have changed since with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// <para>
/// If more mounts have the same mount path, the last matching mount
/// is returned.
/// </para>
/// <para>
/// This will return `NULL` if there is no mount point at @mount_path.
/// </para>
/// </summary>

/// <param name="mount_path">
/// path for a possible Unix mount
/// </param>
/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a [struct@GioUnix.MountEntry]
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle At(string mount_path, out ulong time_read)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_at(mount_path, out time_read);
	}

/// <summary>
/// <para>
/// Compares two Unix mounts.
/// </para>
/// </summary>

/// <param name="mount1">
/// first [struct@GioUnix.MountEntry] to compare
/// </param>
/// <param name="mount2">
/// second [struct@GioUnix.MountEntry] to compare
/// </param>
/// <return>
/// `1`, `0` or `-1` if @mount1 is greater than, equal to,
///    or less than @mount2, respectively
/// </return>

	public static int Compare(MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_compare(mount1, mount2);
	}

/// <summary>
/// <para>
/// Makes a copy of @mount_entry.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a new [struct@GioUnix.MountEntry]
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle Copy(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_copy(mount_entry);
	}

/// <summary>
/// <para>
/// Gets a [struct@GioUnix.MountEntry] for a given file path.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with a Unix timestamp for checking
/// if the mounts have changed since with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// <para>
/// If more mounts have the same mount path, the last matching mount
/// is returned.
/// </para>
/// <para>
/// This will return `NULL` if looking up the mount entry fails, if
/// @file_path doesn’t exist or there is an I/O error.
/// </para>
/// </summary>

/// <param name="file_path">
/// file path on some Unix mount
/// </param>
/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a [struct@GioUnix.MountEntry]
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle For(string file_path, out ulong time_read)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_for(file_path, out time_read);
	}

/// <summary>
/// <para>
/// Frees a Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>

	public static void Free(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		GUnixMountEntryExterns.g_unix_mount_entry_free(mount_entry);
	}

/// <summary>
/// <para>
/// Gets the device path for a Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a string containing the device path
/// </return>

	public static string GetDevicePath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_device_path(mount_entry);
	}

/// <summary>
/// <para>
/// Gets the filesystem type for the Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a string containing the file system type
/// </return>

	public static string GetFsType(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_fs_type(mount_entry);
	}

/// <summary>
/// <para>
/// Gets the mount path for a Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry] to get the mount path for
/// </param>
/// <return>
/// the mount path for @mount_entry
/// </return>

	public static string GetMountPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_mount_path(mount_entry);
	}

/// <summary>
/// <para>
/// Gets a comma separated list of mount options for the Unix mount.
/// </para>
/// <para>
/// For example: `rw,relatime,seclabel,data=ordered`.
/// </para>
/// <para>
/// This is similar to [func@GioUnix.MountPoint.get_options], but it takes
/// a [struct@GioUnix.MountEntry] as an argument.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a string containing the options, or `NULL` if not
///    available.
/// </return>

	public static string GetOptions(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_options(mount_entry);
	}

/// <summary>
/// <para>
/// Gets the root of the mount within the filesystem. This is useful e.g. for
/// mounts created by bind operation, or btrfs subvolumes.
/// </para>
/// <para>
/// For example, the root path is equal to `/` for a mount created by
/// `mount /dev/sda1 /mnt/foo` and `/bar` for
/// `mount --bind /mnt/foo/bar /mnt/bar`.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a string containing the root, or `NULL` if not supported
/// </return>

	public static string GetRootPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_root_path(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses whether a Unix mount entry can be ejected.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// true if @mount_entry is deemed to be ejectable; false otherwise
/// </return>

	public static bool GuessCanEject(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_can_eject(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses the icon of a Unix mount entry.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a [iface@Gio.Icon]
/// </return>

	public static MentorLake.Gio.GIconHandle GuessIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_icon(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses the name of a Unix mount entry.
/// </para>
/// <para>
/// The result is a translated string.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a newly allocated translated string
/// </return>

	public static string GuessName(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_name(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses whether a Unix mount entry should be displayed in the UI.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// true if @mount_entry is deemed to be displayable; false otherwise
/// </return>

	public static bool GuessShouldDisplay(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_should_display(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses the symbolic icon of a Unix mount entry.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a [iface@Gio.Icon]
/// </return>

	public static MentorLake.Gio.GIconHandle GuessSymbolicIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_symbolic_icon(mount_entry);
	}

/// <summary>
/// <para>
/// Checks if a Unix mount is mounted read only.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// true if @mount_entry is read only; false otherwise
/// </return>

	public static bool IsReadonly(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_is_readonly(mount_entry);
	}

/// <summary>
/// <para>
/// Checks if a Unix mount is a system mount.
/// </para>
/// <para>
/// This is the Boolean OR of
/// [func@GioUnix.is_system_fs_type], [func@GioUnix.is_system_device_path] and
/// [func@GioUnix.is_mount_path_system_internal] on @mount_entry’s properties.
/// </para>
/// <para>
/// The definition of what a ‘system’ mount entry is may change over time as new
/// file system types and device paths are ignored.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// true if the Unix mount is for a system path; false otherwise
/// </return>

	public static bool IsSystemInternal(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_is_system_internal(mount_entry);
	}

}
