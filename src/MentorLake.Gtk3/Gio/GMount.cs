namespace MentorLake.Gtk3.Gio;

public interface GMountHandle
{
}

internal class GMountHandleImpl : BaseSafeHandle, GMountHandle
{
}

public static class GMountHandleExtensions
{
	public static bool CanEject(this GMountHandle mount)
	{
		return GMountExterns.g_mount_can_eject(mount);
	}

	public static bool CanUnmount(this GMountHandle mount)
	{
		return GMountExterns.g_mount_can_unmount(mount);
	}

	public static T Eject<T>(this T mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountExterns.g_mount_eject(mount, flags, cancellable, callback, user_data);
		return mount;
	}

	public static bool EjectFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_eject_finish(mount, result, out error);
	}

	public static T EjectWithOperation<T>(this T mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountExterns.g_mount_eject_with_operation(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool EjectWithOperationFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_eject_with_operation_finish(mount, result, out error);
	}

	public static GFileHandle GetDefaultLocation(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_default_location(mount);
	}

	public static GDriveHandle GetDrive(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_drive(mount);
	}

	public static GIconHandle GetIcon(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_icon(mount);
	}

	public static string GetName(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_name(mount);
	}

	public static GFileHandle GetRoot(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_root(mount);
	}

	public static string GetSortKey(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_sort_key(mount);
	}

	public static GIconHandle GetSymbolicIcon(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_symbolic_icon(mount);
	}

	public static string GetUuid(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_uuid(mount);
	}

	public static GVolumeHandle GetVolume(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_volume(mount);
	}

	public static T GuessContentType<T>(this T mount, bool force_rescan, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountExterns.g_mount_guess_content_type(mount, force_rescan, cancellable, callback, user_data);
		return mount;
	}

	public static IntPtr GuessContentTypeFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_guess_content_type_finish(mount, result, out error);
	}

	public static IntPtr GuessContentTypeSync(this GMountHandle mount, bool force_rescan, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GMountExterns.g_mount_guess_content_type_sync(mount, force_rescan, cancellable, out error);
	}

	public static bool IsShadowed(this GMountHandle mount)
	{
		return GMountExterns.g_mount_is_shadowed(mount);
	}

	public static T Remount<T>(this T mount, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountExterns.g_mount_remount(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool RemountFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_remount_finish(mount, result, out error);
	}

	public static T Shadow<T>(this T mount) where T : GMountHandle
	{
		GMountExterns.g_mount_shadow(mount);
		return mount;
	}

	public static T Unmount<T>(this T mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountExterns.g_mount_unmount(mount, flags, cancellable, callback, user_data);
		return mount;
	}

	public static bool UnmountFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_unmount_finish(mount, result, out error);
	}

	public static T UnmountWithOperation<T>(this T mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountExterns.g_mount_unmount_with_operation(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool UnmountWithOperationFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_unmount_with_operation_finish(mount, result, out error);
	}

	public static T Unshadow<T>(this T mount) where T : GMountHandle
	{
		GMountExterns.g_mount_unshadow(mount);
		return mount;
	}

}

internal class GMountExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_can_eject(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_can_unmount(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_eject(GMountHandle mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_eject_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_eject_with_operation(GMountHandle mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_eject_with_operation_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_mount_get_default_location(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GDriveHandle g_mount_get_drive(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_mount_get_icon(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_get_name(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_mount_get_root(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_get_sort_key(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_mount_get_symbolic_icon(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_get_uuid(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GVolumeHandle g_mount_get_volume(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_guess_content_type(GMountHandle mount, bool force_rescan, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_mount_guess_content_type_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_mount_guess_content_type_sync(GMountHandle mount, bool force_rescan, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_is_shadowed(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_remount(GMountHandle mount, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_remount_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_shadow(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_unmount(GMountHandle mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_unmount_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_unmount_with_operation(GMountHandle mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_unmount_with_operation_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_unshadow(GMountHandle mount);

}
