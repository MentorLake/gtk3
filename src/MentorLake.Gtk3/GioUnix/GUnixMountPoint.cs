namespace MentorLake.GioUnix;

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

public struct GUnixMountPoint
{
	public static MentorLake.Gio.GUnixMountPointHandle At(string mount_path, out ulong time_read)
	{
		return GUnixMountPointExterns.g_unix_mount_point_at(mount_path, out time_read);
	}

	public static int Compare(MentorLake.Gio.GUnixMountPointHandle mount1, MentorLake.Gio.GUnixMountPointHandle mount2)
	{
		return GUnixMountPointExterns.g_unix_mount_point_compare(mount1, mount2);
	}

	public static MentorLake.Gio.GUnixMountPointHandle Copy(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_copy(mount_point);
	}

	public static void Free(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		GUnixMountPointExterns.g_unix_mount_point_free(mount_point);
	}

	public static string GetDevicePath(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_device_path(mount_point);
	}

	public static string GetFsType(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_fs_type(mount_point);
	}

	public static string GetMountPath(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_mount_path(mount_point);
	}

	public static string GetOptions(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_get_options(mount_point);
	}

	public static bool GuessCanEject(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_can_eject(mount_point);
	}

	public static MentorLake.Gio.GIconHandle GuessIcon(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_icon(mount_point);
	}

	public static string GuessName(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_name(mount_point);
	}

	public static MentorLake.Gio.GIconHandle GuessSymbolicIcon(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_guess_symbolic_icon(mount_point);
	}

	public static bool IsLoopback(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_loopback(mount_point);
	}

	public static bool IsReadonly(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_readonly(mount_point);
	}

	public static bool IsUserMountable(MentorLake.Gio.GUnixMountPointHandle mount_point)
	{
		return GUnixMountPointExterns.g_unix_mount_point_is_user_mountable(mount_point);
	}

}
