namespace MentorLake.Gio;

public interface GVolumeHandle
{
}

internal class GVolumeHandleImpl : BaseSafeHandle, GVolumeHandle
{
}

public static class GVolumeHandleExtensions
{
	public static bool CanEject(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_can_eject(volume);
	}

	public static bool CanMount(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_can_mount(volume);
	}

	public static T Eject<T>(this T volume, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GVolumeHandle
	{
		GVolumeHandleExterns.g_volume_eject(volume, flags, cancellable, callback, user_data);
		return volume;
	}

	public static bool EjectFinish(this MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GVolumeHandleExterns.g_volume_eject_finish(volume, result);
	}

	public static T EjectWithOperation<T>(this T volume, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GVolumeHandle
	{
		GVolumeHandleExterns.g_volume_eject_with_operation(volume, flags, mount_operation, cancellable, callback, user_data);
		return volume;
	}

	public static bool EjectWithOperationFinish(this MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GVolumeHandleExterns.g_volume_eject_with_operation_finish(volume, result);
	}

	public static string[] EnumerateIdentifiers(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_enumerate_identifiers(volume);
	}

	public static MentorLake.Gio.GFileHandle GetActivationRoot(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_get_activation_root(volume);
	}

	public static MentorLake.Gio.GDriveHandle GetDrive(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_get_drive(volume);
	}

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_get_icon(volume);
	}

	public static string GetIdentifier(this MentorLake.Gio.GVolumeHandle volume, string kind)
	{
		return GVolumeHandleExterns.g_volume_get_identifier(volume, kind);
	}

	public static MentorLake.Gio.GMountHandle GetMount(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_get_mount(volume);
	}

	public static string GetName(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_get_name(volume);
	}

	public static string GetSortKey(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_get_sort_key(volume);
	}

	public static MentorLake.Gio.GIconHandle GetSymbolicIcon(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_get_symbolic_icon(volume);
	}

	public static string GetUuid(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_get_uuid(volume);
	}

	public static T Mount<T>(this T volume, MentorLake.Gio.GMountMountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GVolumeHandle
	{
		GVolumeHandleExterns.g_volume_mount(volume, flags, mount_operation, cancellable, callback, user_data);
		return volume;
	}

	public static bool MountFinish(this MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GVolumeHandleExterns.g_volume_mount_finish(volume, result);
	}

	public static bool ShouldAutomount(this MentorLake.Gio.GVolumeHandle volume)
	{
		return GVolumeHandleExterns.g_volume_should_automount(volume);
	}

}

internal class GVolumeHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_can_mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_volume_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_eject_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_volume_eject_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_eject_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_volume_enumerate_identifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_volume_get_activation_root([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDriveHandle g_volume_get_drive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_volume_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_volume_get_identifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, string kind);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMountHandle g_volume_get_mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_volume_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_volume_get_sort_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_volume_get_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_volume_get_uuid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_volume_mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GMountMountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_mount_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_should_automount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

}
