namespace MentorLake.Gtk3.Gio;

public class GPermissionHandle : GObjectHandle
{
}

public static class GPermissionHandleExtensions
{
	public static bool Acquire(this GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPermissionExterns.g_permission_acquire(permission, cancellable, out error);
	}

	public static T AcquireAsync<T>(this T permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GPermissionHandle
	{
		GPermissionExterns.g_permission_acquire_async(permission, cancellable, callback, user_data);
		return permission;
	}

	public static bool AcquireFinish(this GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GPermissionExterns.g_permission_acquire_finish(permission, result, out error);
	}

	public static bool GetAllowed(this GPermissionHandle permission)
	{
		return GPermissionExterns.g_permission_get_allowed(permission);
	}

	public static bool GetCanAcquire(this GPermissionHandle permission)
	{
		return GPermissionExterns.g_permission_get_can_acquire(permission);
	}

	public static bool GetCanRelease(this GPermissionHandle permission)
	{
		return GPermissionExterns.g_permission_get_can_release(permission);
	}

	public static T ImplUpdate<T>(this T permission, bool allowed, bool can_acquire, bool can_release) where T : GPermissionHandle
	{
		GPermissionExterns.g_permission_impl_update(permission, allowed, can_acquire, can_release);
		return permission;
	}

	public static bool Release(this GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPermissionExterns.g_permission_release(permission, cancellable, out error);
	}

	public static T ReleaseAsync<T>(this T permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GPermissionHandle
	{
		GPermissionExterns.g_permission_release_async(permission, cancellable, callback, user_data);
		return permission;
	}

	public static bool ReleaseFinish(this GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GPermissionExterns.g_permission_release_finish(permission, result, out error);
	}

}

internal class GPermissionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_acquire(GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_permission_acquire_async(GPermissionHandle permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_acquire_finish(GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_get_allowed(GPermissionHandle permission);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_get_can_acquire(GPermissionHandle permission);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_get_can_release(GPermissionHandle permission);

	[DllImport(Libraries.Gio)]
	internal static extern void g_permission_impl_update(GPermissionHandle permission, bool allowed, bool can_acquire, bool can_release);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_release(GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_permission_release_async(GPermissionHandle permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_release_finish(GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error);

}
