namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GPermission` represents the status of the caller’s permission to
/// perform a certain action.
/// </para>
/// <para>
/// You can query if the action is currently allowed and if it is
/// possible to acquire the permission so that the action will be allowed
/// in the future.
/// </para>
/// <para>
/// There is also an API to actually acquire the permission and one to
/// release it.
/// </para>
/// <para>
/// As an example, a `GPermission` might represent the ability for the
/// user to write to a [class@Gio.Settings] object.  This `GPermission` object
/// could then be used to decide if it is appropriate to show a “Click here to
/// unlock” button in a dialog and to provide the mechanism to invoke
/// when that button is clicked.
/// </para>
/// </summary>

public class GPermissionHandle : GObjectHandle
{
}

public static class GPermissionHandleExtensions
{
/// <summary>
/// <para>
/// Attempts to acquire the permission represented by @permission.
/// </para>
/// <para>
/// The precise method by which this happens depends on the permission
/// and the underlying authentication mechanism.  A simple example is
/// that a dialog may appear asking the user to enter their password.
/// </para>
/// <para>
/// You should check with g_permission_get_can_acquire() before calling
/// this function.
/// </para>
/// <para>
/// If the permission is acquired then %TRUE is returned.  Otherwise,
/// %FALSE is returned and @error is set appropriately.
/// </para>
/// <para>
/// This call is blocking, likely for a very long time (in the case that
/// user interaction is required).  See g_permission_acquire_async() for
/// the non-blocking version.
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %TRUE if the permission was successfully acquired
/// </return>

	public static bool Acquire(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		var externCallResult = GPermissionHandleExterns.g_permission_acquire(permission, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Attempts to acquire the permission represented by @permission.
/// </para>
/// <para>
/// This is the first half of the asynchronous version of
/// g_permission_acquire().
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// the #GAsyncReadyCallback to call when done
/// </param>
/// <param name="user_data">
/// the user data to pass to @callback
/// </param>

	public static T AcquireAsync<T>(this T permission, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GPermissionHandle
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		GPermissionHandleExterns.g_permission_acquire_async(permission, cancellable, callback, user_data);
		return permission;
	}

/// <summary>
/// <para>
/// Collects the result of attempting to acquire the permission
/// represented by @permission.
/// </para>
/// <para>
/// This is the second half of the asynchronous version of
/// g_permission_acquire().
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <param name="result">
/// the #GAsyncResult given to the #GAsyncReadyCallback
/// </param>
/// <return>
/// %TRUE if the permission was successfully acquired
/// </return>

	public static bool AcquireFinish(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		var externCallResult = GPermissionHandleExterns.g_permission_acquire_finish(permission, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the value of the &apos;allowed&apos; property.  This property is %TRUE if
/// the caller currently has permission to perform the action that
/// @permission represents the permission to perform.
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <return>
/// the value of the &apos;allowed&apos; property
/// </return>

	public static bool GetAllowed(this MentorLake.Gio.GPermissionHandle permission)
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		return GPermissionHandleExterns.g_permission_get_allowed(permission);
	}

/// <summary>
/// <para>
/// Gets the value of the &apos;can-acquire&apos; property.  This property is %TRUE
/// if it is generally possible to acquire the permission by calling
/// g_permission_acquire().
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <return>
/// the value of the &apos;can-acquire&apos; property
/// </return>

	public static bool GetCanAcquire(this MentorLake.Gio.GPermissionHandle permission)
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		return GPermissionHandleExterns.g_permission_get_can_acquire(permission);
	}

/// <summary>
/// <para>
/// Gets the value of the &apos;can-release&apos; property.  This property is %TRUE
/// if it is generally possible to release the permission by calling
/// g_permission_release().
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <return>
/// the value of the &apos;can-release&apos; property
/// </return>

	public static bool GetCanRelease(this MentorLake.Gio.GPermissionHandle permission)
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		return GPermissionHandleExterns.g_permission_get_can_release(permission);
	}

/// <summary>
/// <para>
/// This function is called by the #GPermission implementation to update
/// the properties of the permission.  You should never call this
/// function except from a #GPermission implementation.
/// </para>
/// <para>
/// GObject notify signals are generated, as appropriate.
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <param name="allowed">
/// the new value for the &apos;allowed&apos; property
/// </param>
/// <param name="can_acquire">
/// the new value for the &apos;can-acquire&apos; property
/// </param>
/// <param name="can_release">
/// the new value for the &apos;can-release&apos; property
/// </param>

	public static T ImplUpdate<T>(this T permission, bool allowed, bool can_acquire, bool can_release) where T : GPermissionHandle
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		GPermissionHandleExterns.g_permission_impl_update(permission, allowed, can_acquire, can_release);
		return permission;
	}

/// <summary>
/// <para>
/// Attempts to release the permission represented by @permission.
/// </para>
/// <para>
/// The precise method by which this happens depends on the permission
/// and the underlying authentication mechanism.  In most cases the
/// permission will be dropped immediately without further action.
/// </para>
/// <para>
/// You should check with g_permission_get_can_release() before calling
/// this function.
/// </para>
/// <para>
/// If the permission is released then %TRUE is returned.  Otherwise,
/// %FALSE is returned and @error is set appropriately.
/// </para>
/// <para>
/// This call is blocking, likely for a very long time (in the case that
/// user interaction is required).  See g_permission_release_async() for
/// the non-blocking version.
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %TRUE if the permission was successfully released
/// </return>

	public static bool Release(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		var externCallResult = GPermissionHandleExterns.g_permission_release(permission, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Attempts to release the permission represented by @permission.
/// </para>
/// <para>
/// This is the first half of the asynchronous version of
/// g_permission_release().
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// the #GAsyncReadyCallback to call when done
/// </param>
/// <param name="user_data">
/// the user data to pass to @callback
/// </param>

	public static T ReleaseAsync<T>(this T permission, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GPermissionHandle
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
		GPermissionHandleExterns.g_permission_release_async(permission, cancellable, callback, user_data);
		return permission;
	}

/// <summary>
/// <para>
/// Collects the result of attempting to release the permission
/// represented by @permission.
/// </para>
/// <para>
/// This is the second half of the asynchronous version of
/// g_permission_release().
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission instance
/// </param>
/// <param name="result">
/// the #GAsyncResult given to the #GAsyncReadyCallback
/// </param>
/// <return>
/// %TRUE if the permission was successfully released
/// </return>

	public static bool ReleaseFinish(this MentorLake.Gio.GPermissionHandle permission, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (permission.IsInvalid) throw new Exception("Invalid handle (GPermissionHandle)");
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
