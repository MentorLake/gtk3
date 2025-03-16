namespace MentorLake.GioUnix;

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
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_at(char mount_path, out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern int g_unix_mount_entry_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount2);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_for(char file_path, out ulong time_read);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_unix_mount_entry_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern char g_unix_mount_entry_get_device_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_fs_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern char g_unix_mount_entry_get_mount_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_get_root_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entry_guess_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_entry_guess_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_entry_guess_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entry_guess_should_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_entry_guess_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entry_is_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_unix_mount_entry_is_system_internal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

}

public struct GUnixMountEntry
{
	public static MentorLake.Gio.GUnixMountEntryHandle At(char mount_path, out ulong time_read)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_at(mount_path, out time_read);
	}

	public static int Compare(MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_compare(mount1, mount2);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle Copy(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_copy(mount_entry);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle For(char file_path, out ulong time_read)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_for(file_path, out time_read);
	}

	public static void Free(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		GUnixMountEntryExterns.g_unix_mount_entry_free(mount_entry);
	}

	public static char GetDevicePath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_device_path(mount_entry);
	}

	public static string GetFsType(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_fs_type(mount_entry);
	}

	public static char GetMountPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_mount_path(mount_entry);
	}

	public static string GetOptions(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_options(mount_entry);
	}

	public static string GetRootPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_get_root_path(mount_entry);
	}

	public static bool GuessCanEject(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_can_eject(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle GuessIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_icon(mount_entry);
	}

	public static string GuessName(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_name(mount_entry);
	}

	public static bool GuessShouldDisplay(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_should_display(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle GuessSymbolicIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_guess_symbolic_icon(mount_entry);
	}

	public static bool IsReadonly(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_is_readonly(mount_entry);
	}

	public static bool IsSystemInternal(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GUnixMountEntryExterns.g_unix_mount_entry_is_system_internal(mount_entry);
	}

}
