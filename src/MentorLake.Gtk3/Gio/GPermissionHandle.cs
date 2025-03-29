namespace MentorLake.Gio;

public class GPermissionHandle : GObjectHandle
{
}

public static class GPermissionHandleExtensions
{
	public static bool Acquire(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GPermissionHandleExterns.g_permission_acquire(permission, cancellable, error);
	}

	public static T AcquireAsync<T>(this T permission, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GPermissionHandle
	{
		GPermissionHandleExterns.g_permission_acquire_async(permission, cancellable, callback, user_data);
		return permission;
	}

	public static bool AcquireFinish(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GPermissionHandleExterns.g_permission_acquire_finish(permission, result, error);
	}

	public static bool GetAllowed(this MentorLake.Gio.GPermissionHandle permission)
	{
		return GPermissionHandleExterns.g_permission_get_allowed(permission);
	}

	public static bool GetCanAcquire(this MentorLake.Gio.GPermissionHandle permission)
	{
		return GPermissionHandleExterns.g_permission_get_can_acquire(permission);
	}

	public static bool GetCanRelease(this MentorLake.Gio.GPermissionHandle permission)
	{
		return GPermissionHandleExterns.g_permission_get_can_release(permission);
	}

	public static T ImplUpdate<T>(this T permission, bool allowed, bool can_acquire, bool can_release) where T : GPermissionHandle
	{
		GPermissionHandleExterns.g_permission_impl_update(permission, allowed, can_acquire, can_release);
		return permission;
	}

	public static bool Release(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GPermissionHandleExterns.g_permission_release(permission, cancellable, error);
	}

	public static T ReleaseAsync<T>(this T permission, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GPermissionHandle
	{
		GPermissionHandleExterns.g_permission_release_async(permission, cancellable, callback, user_data);
		return permission;
	}

	public static bool ReleaseFinish(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GPermissionHandleExterns.g_permission_release_finish(permission, result, error);
	}

}

internal class GPermissionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_permission_acquire_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_acquire_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_get_allowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_get_can_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_get_can_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_permission_impl_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, bool allowed, bool can_acquire, bool can_release);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_permission_release_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_release_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

}
