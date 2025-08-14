namespace MentorLake.GioUnix;

/// <summary>
/// <para>
/// Defines a Unix mount point (e.g. `/dev`).
/// This corresponds roughly to a fstab entry.
/// </para>
/// </summary>

public class GUnixMountPointHandle : BaseSafeHandle
{
}


public static class GUnixMountPointExtensions
{

	public static GUnixMountPoint Dereference(this GUnixMountPointHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixMountPoint>(x.DangerousGetHandle());
}
internal class GUnixMountPointExterns
{
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

}

/// <summary>
/// <para>
/// Defines a Unix mount point (e.g. `/dev`).
/// This corresponds roughly to a fstab entry.
/// </para>
/// </summary>

public struct GUnixMountPoint
{
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

	public static MentorLake.Gio.GUnixMountPointHandle At(string mount_path, out ulong time_read)
	{
		return GUnixMountPointExterns.g_unix_mount_point_at(mount_path, out time_read);
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

	public static int Compare(MentorLake.Gio.GUnixMountPointHandle mount1, MentorLake.Gio.GUnixMountPointHandle mount2)
	{
		return GUnixMountPointExterns.g_unix_mount_point_compare(mount1, mount2);
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

	public static MentorLake.Gio.GUnixMountPointHandle Copy(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_copy(mount_point);
	}

/// <summary>
/// <para>
/// Frees a Unix mount point.
/// </para>
/// </summary>

/// <param name="mount_point">
/// Unix mount point to free.
/// </param>

	public static void Free(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		GUnixMountPointExterns.g_unix_mount_point_free(mount_point);
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

	public static string GetDevicePath(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_device_path(mount_point);
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

	public static string GetFsType(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_fs_type(mount_point);
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

	public static string GetMountPath(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_mount_path(mount_point);
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

	public static string GetOptions(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_options(mount_point);
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

	public static bool GuessCanEject(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_can_eject(mount_point);
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

	public static MentorLake.Gio.GIconHandle GuessIcon(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_icon(mount_point);
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

	public static string GuessName(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_name(mount_point);
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

	public static MentorLake.Gio.GIconHandle GuessSymbolicIcon(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_symbolic_icon(mount_point);
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

	public static bool IsLoopback(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_loopback(mount_point);
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

	public static bool IsReadonly(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_readonly(mount_point);
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

	public static bool IsUserMountable(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_user_mountable(mount_point);
	}

}
