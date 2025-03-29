namespace MentorLake.Gio;

public class GPermissionHandle : GObjectHandle
{
}

public static class GPermissionHandleExtensions
{
	public static bool Acquire(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		var externCallResult = GPermissionHandleExterns.g_permission_acquire(permission, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T AcquireAsync<T>(this T permission, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GPermissionHandle
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		GPermissionHandleExterns.g_permission_acquire_async(permission, cancellable, callback, user_data);
		return permission;
	}

	public static bool AcquireFinish(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		var externCallResult = GPermissionHandleExterns.g_permission_acquire_finish(permission, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool GetAllowed(this MentorLake.Gio.GPermissionHandle permission)
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		return GPermissionHandleExterns.g_permission_get_allowed(permission);
	}

	public static bool GetCanAcquire(this MentorLake.Gio.GPermissionHandle permission)
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		return GPermissionHandleExterns.g_permission_get_can_acquire(permission);
	}

	public static bool GetCanRelease(this MentorLake.Gio.GPermissionHandle permission)
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		return GPermissionHandleExterns.g_permission_get_can_release(permission);
	}

	public static T ImplUpdate<T>(this T permission, bool allowed, bool can_acquire, bool can_release) where T : GPermissionHandle
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		GPermissionHandleExterns.g_permission_impl_update(permission, allowed, can_acquire, can_release);
		return permission;
	}

	public static bool Release(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		var externCallResult = GPermissionHandleExterns.g_permission_release(permission, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ReleaseAsync<T>(this T permission, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GPermissionHandle
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		GPermissionHandleExterns.g_permission_release_async(permission, cancellable, callback, user_data);
		return permission;
	}

	public static bool ReleaseFinish(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (permission.IsInvalid || permission.IsClosed) throw new Exception("Invalid or closed handle (GPermissionHandle)");
		var externCallResult = GPermissionHandleExterns.g_permission_release_finish(permission, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GPermissionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_permission_acquire_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_acquire_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_get_allowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_get_can_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_get_can_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_permission_impl_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, bool allowed, bool can_acquire, bool can_release);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_permission_release_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_permission_release_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
