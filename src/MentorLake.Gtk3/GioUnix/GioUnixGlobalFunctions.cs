namespace MentorLake.GioUnix;

public class GioUnixGlobalFunctions
{
/// <summary>
/// <para>
/// Gets the default application for launching applications
/// using this URI scheme for a particular [iface@Gio.DesktopAppInfoLookup]
/// implementation.
/// </para>
/// <para>
/// The [iface@Gio.DesktopAppInfoLookup] interface and this function is used
/// to implement [func@Gio.AppInfo.get_default_for_uri_scheme] backends
/// in a GIO module. There is no reason for applications to use it
/// directly. Applications should use
/// [func@Gio.AppInfo.get_default_for_uri_scheme].
/// </para>
/// </summary>

/// <param name="lookup">
/// a [iface@Gio.DesktopAppInfoLookup]
/// </param>
/// <param name="uri_scheme">
/// a string containing a URI scheme.
/// </param>
/// <return>
/// [iface@Gio.AppInfo] for given
///   @uri_scheme or `NULL` on error.
/// </return>

	public static MentorLake.Gio.GAppInfoHandle DesktopAppInfoLookupGetDefaultForUriScheme(MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme)
	{
		return GioUnixGlobalFunctionsExterns.g_desktop_app_info_lookup_get_default_for_uri_scheme(lookup, uri_scheme);
	}

/// <summary>
/// <para>
/// Gets the underlying file descriptor.
/// </para>
/// </summary>

/// <param name="fd_based">
/// a #GFileDescriptorBased.
/// </param>
/// <return>
/// The file descriptor
/// </return>

	public static int FileDescriptorBasedGetFd(MentorLake.Gio.GFileDescriptorBasedHandle fd_based)
	{
		return GioUnixGlobalFunctionsExterns.g_file_descriptor_based_get_fd(fd_based);
	}

/// <summary>
/// <para>
/// Determines if @mount_path is considered an implementation of the
/// OS.
/// </para>
/// <para>
/// This is primarily used for hiding mountable and mounted volumes
/// that only are used in the OS and has little to no relevance to the
/// casual user.
/// </para>
/// </summary>

/// <param name="mount_path">
/// a mount path, e.g. `/media/disk` or `/usr`
/// </param>
/// <return>
/// true if @mount_path is considered an implementation detail
///    of the OS; false otherwise
/// </return>

	public static bool IsMountPathSystemInternal(string mount_path)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_is_mount_path_system_internal(mount_path);
	}

/// <summary>
/// <para>
/// Determines if @device_path is considered a block device path which is only
/// used in implementation of the OS.
/// </para>
/// <para>
/// This is primarily used for hiding mounted volumes that are intended as APIs
/// for programs to read, and system administrators at a shell; rather than
/// something that should, for example, appear in a GUI. For example, the Linux
/// `/proc` filesystem.
/// </para>
/// <para>
/// The list of device paths considered ‘system’ ones may change over time.
/// </para>
/// </summary>

/// <param name="device_path">
/// a device path, e.g. `/dev/loop0` or `nfsd`
/// </param>
/// <return>
/// true if @device_path is considered an implementation detail of
///    the OS; false otherwise
/// </return>

	public static bool IsSystemDevicePath(string device_path)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_is_system_device_path(device_path);
	}

/// <summary>
/// <para>
/// Determines if @fs_type is considered a type of file system which is only
/// used in implementation of the OS.
/// </para>
/// <para>
/// This is primarily used for hiding mounted volumes that are intended as APIs
/// for programs to read, and system administrators at a shell; rather than
/// something that should, for example, appear in a GUI. For example, the Linux
/// `/proc` filesystem.
/// </para>
/// <para>
/// The list of file system types considered ‘system’ ones may change over time.
/// </para>
/// </summary>

/// <param name="fs_type">
/// a file system type, e.g. `procfs` or `tmpfs`
/// </param>
/// <return>
/// true if @fs_type is considered an implementation detail of the OS;
///    false otherwise
/// </return>

	public static bool IsSystemFsType(string fs_type)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_is_system_fs_type(fs_type);
	}

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

	public static MentorLake.Gio.GUnixMountEntryHandle MountAt(string mount_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_at(mount_path, out time_read);
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

	public static int MountCompare(MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_compare(mount1, mount2);
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

	public static MentorLake.Gio.GUnixMountEntryHandle MountCopy(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_copy(mount_entry);
	}

/// <summary>
/// <para>
/// Checks if the Unix mounts have changed since a given Unix time.
/// </para>
/// <para>
/// This can only work reliably if a [class@GioUnix.MountMonitor] is running in
/// the process, otherwise changes in the mount entries file (such as
/// `/proc/self/mountinfo` on Linux) cannot be detected and, as a result, this
/// function has to conservatively always return `TRUE`.
/// </para>
/// <para>
/// It is more efficient to use [signal@GioUnix.MountMonitor::mounts-changed] to
/// be signalled of changes to the mount entries, rather than polling using this
/// function. This function is more appropriate for infrequently determining
/// cache validity.
/// </para>
/// </summary>

/// <param name="time">
/// a timestamp
/// </param>
/// <return>
/// true if the mounts have changed since @time; false otherwise
/// Since 2.84
/// </return>

	public static bool MountEntriesChangedSince(ulong time)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entries_changed_since(time);
	}

/// <summary>
/// <para>
/// Gets a list of [struct@GioUnix.MountEntry] instances representing the Unix
/// mounts.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with the mount timestamp, allowing
/// for checking if the mounts have changed with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// </summary>

/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a list of the
///    Unix mounts
/// </return>

	public static MentorLake.GLib.GListHandle MountEntriesGet(out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entries_get(out time_read);
	}

/// <summary>
/// <para>
/// Gets an array of [struct@Gio.UnixMountEntry]s containing the Unix mounts
/// listed in @table_path.
/// </para>
/// <para>
/// This is a generalized version of [func@GioUnix.mount_entries_get], mainly
/// intended for internal testing use. Note that [func@GioUnix.mount_entries_get]
/// may parse multiple hierarchical table files, so this function is not a direct
/// superset of its functionality.
/// </para>
/// <para>
/// If there is an error reading or parsing the file, `NULL` will be returned
/// and both out parameters will be set to `0`.
/// </para>
/// </summary>

/// <param name="table_path">
/// path to the mounts table file (for example `/proc/self/mountinfo`)
/// </param>
/// <param name="time_read_out">
/// return location for the
///   modification time of @table_path
/// </param>
/// <param name="n_entries_out">
/// return location for the
///   number of mount entries returned
/// </param>
/// <return>
/// mount
///   entries, or `NULL` if there was an error loading them
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle[] MountEntriesGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_entries_out)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entries_get_from_file(table_path, out time_read_out, out n_entries_out);
	}

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

	public static MentorLake.Gio.GUnixMountEntryHandle MountEntryAt(string mount_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_at(mount_path, out time_read);
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

	public static int MountEntryCompare(MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_compare(mount1, mount2);
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

	public static MentorLake.Gio.GUnixMountEntryHandle MountEntryCopy(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_copy(mount_entry);
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

	public static MentorLake.Gio.GUnixMountEntryHandle MountEntryFor(string file_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_for(file_path, out time_read);
	}

/// <summary>
/// <para>
/// Frees a Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>

	public static void MountEntryFree(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		GioUnixGlobalFunctionsExterns.g_unix_mount_entry_free(mount_entry);
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

	public static string MountEntryGetDevicePath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_device_path(mount_entry);
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

	public static string MountEntryGetFsType(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_fs_type(mount_entry);
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

	public static string MountEntryGetMountPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_mount_path(mount_entry);
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

	public static string MountEntryGetOptions(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_options(mount_entry);
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

	public static string MountEntryGetRootPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_get_root_path(mount_entry);
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

	public static bool MountEntryGuessCanEject(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_can_eject(mount_entry);
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

	public static MentorLake.Gio.GIconHandle MountEntryGuessIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_icon(mount_entry);
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

	public static string MountEntryGuessName(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_name(mount_entry);
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

	public static bool MountEntryGuessShouldDisplay(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_should_display(mount_entry);
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

	public static MentorLake.Gio.GIconHandle MountEntryGuessSymbolicIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_guess_symbolic_icon(mount_entry);
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

	public static bool MountEntryIsReadonly(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_is_readonly(mount_entry);
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

	public static bool MountEntryIsSystemInternal(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_entry_is_system_internal(mount_entry);
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

	public static MentorLake.Gio.GUnixMountEntryHandle MountFor(string file_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_for(file_path, out time_read);
	}

/// <summary>
/// <para>
/// Frees a Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>

	public static void MountFree(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		GioUnixGlobalFunctionsExterns.g_unix_mount_free(mount_entry);
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

	public static string MountGetDevicePath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_device_path(mount_entry);
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

	public static string MountGetFsType(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_fs_type(mount_entry);
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

	public static string MountGetMountPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_mount_path(mount_entry);
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

	public static string MountGetOptions(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_options(mount_entry);
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

	public static string MountGetRootPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_get_root_path(mount_entry);
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

	public static bool MountGuessCanEject(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_can_eject(mount_entry);
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

	public static MentorLake.Gio.GIconHandle MountGuessIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_icon(mount_entry);
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

	public static string MountGuessName(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_name(mount_entry);
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

	public static bool MountGuessShouldDisplay(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_should_display(mount_entry);
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

	public static MentorLake.Gio.GIconHandle MountGuessSymbolicIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_guess_symbolic_icon(mount_entry);
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

	public static bool MountIsReadonly(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_is_readonly(mount_entry);
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

	public static bool MountIsSystemInternal(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_is_system_internal(mount_entry);
	}

/// <summary>
/// <para>
/// Gets a [struct@GioUnix.MountPoint] for a given mount path.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with a Unix timestamp for checking if
/// the mount points have changed since with
/// [func@GioUnix.mount_points_changed_since].
/// </para>
/// <para>
/// If more mount points have the same mount path, the last matching mount point
/// is returned.
/// </para>
/// </summary>

/// <param name="mount_path">
/// path for a possible Unix mount point
/// </param>
/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a [struct@GioUnix.MountPoint], or `NULL`
///    if no match is found
/// </return>

	public static MentorLake.Gio.GUnixMountPointHandle MountPointAt(string mount_path, out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_at(mount_path, out time_read);
	}

/// <summary>
/// <para>
/// Compares two Unix mount points.
/// </para>
/// </summary>

/// <param name="mount1">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <param name="mount2">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// `1`, `0` or `-1` if @mount1 is greater than, equal to,
///    or less than @mount2, respectively
/// </return>

	public static int MountPointCompare(MentorLake.Gio.GUnixMountPointHandle mount1, MentorLake.Gio.GUnixMountPointHandle mount2)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_compare(mount1, mount2);
	}

/// <summary>
/// <para>
/// Makes a copy of @mount_point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// a new [struct@GioUnix.MountPoint]
/// </return>

	public static MentorLake.Gio.GUnixMountPointHandle MountPointCopy(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_copy(mount_point);
	}

/// <summary>
/// <para>
/// Frees a Unix mount point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// Unix mount point to free.
/// </param>

	public static void MountPointFree(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		GioUnixGlobalFunctionsExterns.g_unix_mount_point_free(mount_point);
	}

/// <summary>
/// <para>
/// Gets the device path for a Unix mount point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// a string containing the device path
/// </return>

	public static string MountPointGetDevicePath(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_get_device_path(mount_point);
	}

/// <summary>
/// <para>
/// Gets the file system type for the mount point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// a string containing the file system type
/// </return>

	public static string MountPointGetFsType(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_get_fs_type(mount_point);
	}

/// <summary>
/// <para>
/// Gets the mount path for a Unix mount point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// a string containing the mount path
/// </return>

	public static string MountPointGetMountPath(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_get_mount_path(mount_point);
	}

/// <summary>
/// <para>
/// Gets the options for the mount point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// a string containing the options
/// </return>

	public static string MountPointGetOptions(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_get_options(mount_point);
	}

/// <summary>
/// <para>
/// Guesses whether a Unix mount point can be ejected.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// true if @mount_point is deemed to be ejectable; false otherwise
/// </return>

	public static bool MountPointGuessCanEject(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_guess_can_eject(mount_point);
	}

/// <summary>
/// <para>
/// Guesses the icon of a Unix mount point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// a [iface@Gio.Icon]
/// </return>

	public static MentorLake.Gio.GIconHandle MountPointGuessIcon(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_guess_icon(mount_point);
	}

/// <summary>
/// <para>
/// Guesses the name of a Unix mount point.
/// </para>
/// <para>
/// The result is a translated string.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// a newly allocated translated string
/// </return>

	public static string MountPointGuessName(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_guess_name(mount_point);
	}

/// <summary>
/// <para>
/// Guesses the symbolic icon of a Unix mount point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// a [iface@Gio.Icon]
/// </return>

	public static MentorLake.Gio.GIconHandle MountPointGuessSymbolicIcon(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_guess_symbolic_icon(mount_point);
	}

/// <summary>
/// <para>
/// Checks if a Unix mount point is a loopback device.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// true if the mount point is a loopback device; false otherwise
/// </return>

	public static bool MountPointIsLoopback(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_is_loopback(mount_point);
	}

/// <summary>
/// <para>
/// Checks if a Unix mount point is read only.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// true if a mount point is read only; false otherwise
/// </return>

	public static bool MountPointIsReadonly(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_is_readonly(mount_point);
	}

/// <summary>
/// <para>
/// Checks if a Unix mount point is mountable by the user.
/// </para>
/// </summary>

/// <param name="mount_point">
/// a [struct@GioUnix.MountPoint]
/// </param>
/// <return>
/// true if the mount point is user mountable; false otherwise
/// </return>

	public static bool MountPointIsUserMountable(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_point_is_user_mountable(mount_point);
	}

/// <summary>
/// <para>
/// Checks if the Unix mount points have changed since a given Unix time.
/// </para>
/// <para>
/// Unlike [func@GioUnix.mount_entries_changed_since], this function can work
/// reliably without a [class@GioUnix.MountMonitor] running, as it accesses the
/// static mount point information (such as `/etc/fstab` on Linux), which has a
/// valid modification time.
/// </para>
/// <para>
/// It is more efficient to use [signal@GioUnix.MountMonitor::mountpoints-changed]
/// to be signalled of changes to the mount points, rather than polling using
/// this function. This function is more appropriate for infrequently determining
/// cache validity.
/// </para>
/// </summary>

/// <param name="time">
/// a timestamp
/// </param>
/// <return>
/// true if the mount points have changed since @time; false otherwise
/// </return>

	public static bool MountPointsChangedSince(ulong time)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_points_changed_since(time);
	}

/// <summary>
/// <para>
/// Gets a list of [struct@GioUnix.MountPoint] instances representing the Unix
/// mount points.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with the mount timestamp, allowing
/// for checking if the mounts have changed with
/// [func@GioUnix.mount_points_changed_since].
/// </para>
/// </summary>

/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a list of the Unix
///    mount points
/// </return>

	public static MentorLake.GLib.GListHandle MountPointsGet(out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_points_get(out time_read);
	}

/// <summary>
/// <para>
/// Gets an array of [struct@Gio.UnixMountPoint]s containing the Unix mount
/// points listed in @table_path.
/// </para>
/// <para>
/// This is a generalized version of [func@GioUnix.mount_points_get], mainly
/// intended for internal testing use. Note that [func@GioUnix.mount_points_get]
/// may parse multiple hierarchical table files, so this function is not a direct
/// superset of its functionality.
/// </para>
/// <para>
/// If there is an error reading or parsing the file, `NULL` will be returned
/// and both out parameters will be set to `0`.
/// </para>
/// </summary>

/// <param name="table_path">
/// path to the mount points table file (for example `/etc/fstab`)
/// </param>
/// <param name="time_read_out">
/// return location for the
///   modification time of @table_path
/// </param>
/// <param name="n_points_out">
/// return location for the
///   number of mount points returned
/// </param>
/// <return>
/// mount
///   points, or `NULL` if there was an error loading them
/// </return>

	public static MentorLake.Gio.GUnixMountPointHandle[] MountPointsGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_points_out)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mount_points_get_from_file(table_path, out time_read_out, out n_points_out);
	}

/// <summary>
/// <para>
/// Checks if the Unix mounts have changed since a given Unix time.
/// </para>
/// </summary>

/// <param name="time">
/// a timestamp
/// </param>
/// <return>
/// true if the mounts have changed since @time; false otherwise
/// </return>

	public static bool MountsChangedSince(ulong time)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mounts_changed_since(time);
	}

/// <summary>
/// <para>
/// Gets a list of [struct@GioUnix.MountEntry] instances representing the Unix
/// mounts.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with the mount timestamp, allowing
/// for checking if the mounts have changed with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// </summary>

/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a list of the
///    Unix mounts
/// </return>

	public static MentorLake.GLib.GListHandle MountsGet(out ulong time_read)
	{
		return GioUnixGlobalFunctionsExterns.g_unix_mounts_get(out time_read);
	}

/// <summary>
/// <para>
/// Gets an array of [struct@Gio.UnixMountEntry]s containing the Unix mounts
/// listed in @table_path.
/// </para>
/// <para>
/// This is a generalized version of [func@GioUnix.mount_entries_get], mainly
/// intended for internal testing use. Note that [func@GioUnix.mount_entries_get]
/// may parse multiple hierarchical table files, so this function is not a direct
/// superset of its functionality.
/// </para>
/// <para>
/// If there is an error reading or parsing the file, `NULL` will be returned
/// and both out parameters will be set to `0`.
/// </para>
/// </summary>

/// <param name="table_path">
/// path to the mounts table file (for example `/proc/self/mountinfo`)
/// </param>
/// <param name="time_read_out">
/// return location for the
///   modification time of @table_path
/// </param>
/// <param name="n_entries_out">
/// return location for the
///   number of mount entries returned
/// </param>
/// <return>
/// mount
///   entries, or `NULL` if there was an error loading them
/// </return>

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
