namespace MentorLake.Gio;

public interface GMountHandle
{
}

internal class GMountHandleImpl : BaseSafeHandle, GMountHandle
{
}

public static class GMountHandleExtensions
{
	public static bool CanEject(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_can_eject(mount);
	}

	public static bool CanUnmount(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_can_unmount(mount);
	}

	public static T Eject<T>(this T mount, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountHandleExterns.g_mount_eject(mount, flags, cancellable, callback, user_data);
		return mount;
	}

	public static bool EjectFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GMountHandleExterns.g_mount_eject_finish(mount, result);
	}

	public static T EjectWithOperation<T>(this T mount, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountHandleExterns.g_mount_eject_with_operation(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool EjectWithOperationFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GMountHandleExterns.g_mount_eject_with_operation_finish(mount, result);
	}

	public static MentorLake.Gio.GFileHandle GetDefaultLocation(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_default_location(mount);
	}

	public static MentorLake.Gio.GDriveHandle GetDrive(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_drive(mount);
	}

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_icon(mount);
	}

	public static string GetName(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_name(mount);
	}

	public static MentorLake.Gio.GFileHandle GetRoot(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_root(mount);
	}

	public static string GetSortKey(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_sort_key(mount);
	}

	public static MentorLake.Gio.GIconHandle GetSymbolicIcon(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_symbolic_icon(mount);
	}

	public static string GetUuid(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_uuid(mount);
	}

	public static MentorLake.Gio.GVolumeHandle GetVolume(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_get_volume(mount);
	}

	public static T GuessContentType<T>(this T mount, bool force_rescan, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountHandleExterns.g_mount_guess_content_type(mount, force_rescan, cancellable, callback, user_data);
		return mount;
	}

	public static string[] GuessContentTypeFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GMountHandleExterns.g_mount_guess_content_type_finish(mount, result);
	}

	public static string[] GuessContentTypeSync(this MentorLake.Gio.GMountHandle mount, bool force_rescan, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GMountHandleExterns.g_mount_guess_content_type_sync(mount, force_rescan, cancellable);
	}

	public static bool IsShadowed(this MentorLake.Gio.GMountHandle mount)
	{
		return GMountHandleExterns.g_mount_is_shadowed(mount);
	}

	public static T Remount<T>(this T mount, MentorLake.Gio.GMountMountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountHandleExterns.g_mount_remount(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool RemountFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GMountHandleExterns.g_mount_remount_finish(mount, result);
	}

	public static T Shadow<T>(this T mount) where T : GMountHandle
	{
		GMountHandleExterns.g_mount_shadow(mount);
		return mount;
	}

	public static T Unmount<T>(this T mount, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountHandleExterns.g_mount_unmount(mount, flags, cancellable, callback, user_data);
		return mount;
	}

	public static bool UnmountFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GMountHandleExterns.g_mount_unmount_finish(mount, result);
	}

	public static T UnmountWithOperation<T>(this T mount, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		GMountHandleExterns.g_mount_unmount_with_operation(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool UnmountWithOperationFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GMountHandleExterns.g_mount_unmount_with_operation_finish(mount, result);
	}

	public static T Unshadow<T>(this T mount) where T : GMountHandle
	{
		GMountHandleExterns.g_mount_unshadow(mount);
		return mount;
	}

}

internal class GMountHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_can_unmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_eject_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_eject_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_eject_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_mount_get_default_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDriveHandle g_mount_get_drive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_mount_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_mount_get_root([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_get_sort_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_mount_get_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_get_uuid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GVolumeHandle g_mount_get_volume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_guess_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, bool force_rescan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_mount_guess_content_type_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_mount_guess_content_type_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, bool force_rescan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_is_shadowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_remount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountMountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_remount_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_shadow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_unmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_unmount_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_unmount_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_unmount_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_unshadow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

}
