namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The `GMount` interface represents a user-visible mount, such as a mounted
/// file system.
/// </para>
/// <para>
/// `GMount` is a ‘mounted’ filesystem that you can access. Mounted is in
/// quotes because it’s not the same as a UNIX mount, it might be a GVFS
/// mount, but you can still access the files on it if you use GIO.
/// </para>
/// <para>
/// A `GMount` might be associated with a [iface@Gio.Volume] (such as a USB flash
/// drive) which hosts it.
/// </para>
/// <para>
/// Unmounting a `GMount` instance is an asynchronous operation. For
/// more information about asynchronous operations, see [iface@Gio.AsyncResult]
/// and [class@Gio.Task]. To unmount a `GMount` instance, first call
/// [method@Gio.Mount.unmount_with_operation] with (at least) the `GMount`
/// instance and a [type@Gio.AsyncReadyCallback].  The callback will be fired
/// when the operation has resolved (either with success or failure), and a
/// [iface@Gio.AsyncResult] structure will be passed to the callback.  That
/// callback should then call [method@Gio.Mount.unmount_with_operation_finish]
/// with the `GMount` and the [iface@Gio.AsyncResult] data to see if the
/// operation was completed successfully.  If an `error` is present when
/// [method@Gio.Mount.unmount_with_operation_finish] is called, then it will be
/// filled with any error information.
/// </para>
/// <para>
/// Note, when [porting from GnomeVFS](migrating-gnome-vfs.html), `GMount` is the
/// moral equivalent of `GnomeVFSVolume`.
/// </para>
/// </summary>

public interface GMountHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GMountHandleImpl : BaseSafeHandle, GMountHandle
{
}

public static class GMountHandleExtensions
{
/// <summary>
/// <para>
/// Checks if @mount can be ejected.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// %TRUE if the @mount can be ejected.
/// </return>

	public static bool CanEject(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_can_eject(mount);
	}

/// <summary>
/// <para>
/// Checks if @mount can be unmounted.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// %TRUE if the @mount can be unmounted.
/// </return>

	public static bool CanUnmount(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_can_unmount(mount);
	}

/// <summary>
/// <para>
/// Ejects a mount. This is an asynchronous operation, and is
/// finished by calling g_mount_eject_finish() with the @mount
/// and #GAsyncResult data returned in the @callback.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="flags">
/// flags affecting the unmount if required for eject
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>

	public static T Eject<T>(this T mount, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		GMountHandleExterns.g_mount_eject(mount, flags, cancellable, callback, user_data);
		return mount;
	}

/// <summary>
/// <para>
/// Finishes ejecting a mount. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the mount was successfully ejected. %FALSE otherwise.
/// </return>

	public static bool EjectFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		var externCallResult = GMountHandleExterns.g_mount_eject_finish(mount, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Ejects a mount. This is an asynchronous operation, and is
/// finished by calling g_mount_eject_with_operation_finish() with the @mount
/// and #GAsyncResult data returned in the @callback.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="flags">
/// flags affecting the unmount if required for eject
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation or %NULL to avoid
///     user interaction.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>

	public static T EjectWithOperation<T>(this T mount, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		GMountHandleExterns.g_mount_eject_with_operation(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

/// <summary>
/// <para>
/// Finishes ejecting a mount. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the mount was successfully ejected. %FALSE otherwise.
/// </return>

	public static bool EjectWithOperationFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		var externCallResult = GMountHandleExterns.g_mount_eject_with_operation_finish(mount, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the default location of @mount. The default location of the given
/// @mount is a path that reflects the main entry point for the user (e.g.
/// the home directory, or the root of the volume).
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// a #GFile.
///      The returned object should be unreffed with
///      g_object_unref() when no longer needed.
/// </return>

	public static MentorLake.Gio.GFileHandle GetDefaultLocation(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_default_location(mount);
	}

/// <summary>
/// <para>
/// Gets the drive for the @mount.
/// </para>
/// <para>
/// This is a convenience method for getting the #GVolume and then
/// using that object to get the #GDrive.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// a #GDrive or %NULL if @mount is not
///      associated with a volume or a drive.
///      The returned object should be unreffed with
///      g_object_unref() when no longer needed.
/// </return>

	public static MentorLake.Gio.GDriveHandle GetDrive(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_drive(mount);
	}

/// <summary>
/// <para>
/// Gets the icon for @mount.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// a #GIcon.
///      The returned object should be unreffed with
///      g_object_unref() when no longer needed.
/// </return>

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_icon(mount);
	}

/// <summary>
/// <para>
/// Gets the name of @mount.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// the name for the given @mount.
///     The returned string should be freed with g_free()
///     when no longer needed.
/// </return>

	public static string GetName(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_name(mount);
	}

/// <summary>
/// <para>
/// Gets the root directory on @mount.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// a #GFile.
///      The returned object should be unreffed with
///      g_object_unref() when no longer needed.
/// </return>

	public static MentorLake.Gio.GFileHandle GetRoot(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_root(mount);
	}

/// <summary>
/// <para>
/// Gets the sort key for @mount, if any.
/// </para>
/// </summary>

/// <param name="mount">
/// A #GMount.
/// </param>
/// <return>
/// Sorting key for @mount or %NULL if no such key is available.
/// </return>

	public static string GetSortKey(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_sort_key(mount);
	}

/// <summary>
/// <para>
/// Gets the symbolic icon for @mount.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// a #GIcon.
///      The returned object should be unreffed with
///      g_object_unref() when no longer needed.
/// </return>

	public static MentorLake.Gio.GIconHandle GetSymbolicIcon(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_symbolic_icon(mount);
	}

/// <summary>
/// <para>
/// Gets the UUID for the @mount. The reference is typically based on
/// the file system UUID for the mount in question and should be
/// considered an opaque string. Returns %NULL if there is no UUID
/// available.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// the UUID for @mount or %NULL if no UUID
///     can be computed.
///     The returned string should be freed with g_free()
///     when no longer needed.
/// </return>

	public static string GetUuid(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_uuid(mount);
	}

/// <summary>
/// <para>
/// Gets the volume for the @mount.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <return>
/// a #GVolume or %NULL if @mount is not
///      associated with a volume.
///      The returned object should be unreffed with
///      g_object_unref() when no longer needed.
/// </return>

	public static MentorLake.Gio.GVolumeHandle GetVolume(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_get_volume(mount);
	}

/// <summary>
/// <para>
/// Tries to guess the type of content stored on @mount. Returns one or
/// more textual identifiers of well-known content types (typically
/// prefixed with "x-content/"), e.g. x-content/image-dcf for camera
/// memory cards. See the
/// [shared-mime-info](http://www.freedesktop.org/wiki/Specifications/shared-mime-info-spec)
/// specification for more on x-content types.
/// </para>
/// <para>
/// This is an asynchronous operation (see
/// g_mount_guess_content_type_sync() for the synchronous version), and
/// is finished by calling g_mount_guess_content_type_finish() with the
/// @mount and #GAsyncResult data returned in the @callback.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount
/// </param>
/// <param name="force_rescan">
/// Whether to force a rescan of the content.
///     Otherwise a cached result will be used if available
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
/// </param>
/// <param name="user_data">
/// user data passed to @callback
/// </param>

	public static T GuessContentType<T>(this T mount, bool force_rescan, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		GMountHandleExterns.g_mount_guess_content_type(mount, force_rescan, cancellable, callback, user_data);
		return mount;
	}

/// <summary>
/// <para>
/// Finishes guessing content types of @mount. If any errors occurred
/// during the operation, @error will be set to contain the errors and
/// %FALSE will be returned. In particular, you may get an
/// %G_IO_ERROR_NOT_SUPPORTED if the mount does not support content
/// guessing.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a %NULL-terminated array of content types or %NULL on error.
///     Caller should free this array with g_strfreev() when done with it.
/// </return>

	public static string[] GuessContentTypeFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		var externCallResult = GMountHandleExterns.g_mount_guess_content_type_finish(mount, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to guess the type of content stored on @mount. Returns one or
/// more textual identifiers of well-known content types (typically
/// prefixed with "x-content/"), e.g. x-content/image-dcf for camera
/// memory cards. See the
/// [shared-mime-info](http://www.freedesktop.org/wiki/Specifications/shared-mime-info-spec)
/// specification for more on x-content types.
/// </para>
/// <para>
/// This is a synchronous operation and as such may block doing IO;
/// see g_mount_guess_content_type() for the asynchronous version.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount
/// </param>
/// <param name="force_rescan">
/// Whether to force a rescan of the content.
///     Otherwise a cached result will be used if available
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <return>
/// a %NULL-terminated array of content types or %NULL on error.
///     Caller should free this array with g_strfreev() when done with it.
/// </return>

	public static string[] GuessContentTypeSync(this MentorLake.Gio.GMountHandle mount, bool force_rescan, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		var externCallResult = GMountHandleExterns.g_mount_guess_content_type_sync(mount, force_rescan, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Determines if @mount is shadowed. Applications or libraries should
/// avoid displaying @mount in the user interface if it is shadowed.
/// </para>
/// <para>
/// A mount is said to be shadowed if there exists one or more user
/// visible objects (currently #GMount objects) with a root that is
/// inside the root of @mount.
/// </para>
/// <para>
/// One application of shadow mounts is when exposing a single file
/// system that is used to address several logical volumes. In this
/// situation, a #GVolumeMonitor implementation would create two
/// #GVolume objects (for example, one for the camera functionality of
/// the device and one for a SD card reader on the device) with
/// activation URIs `gphoto2://[usb:001,002]/store1/`
/// and `gphoto2://[usb:001,002]/store2/`. When the
/// underlying mount (with root
/// `gphoto2://[usb:001,002]/`) is mounted, said
/// #GVolumeMonitor implementation would create two #GMount objects
/// (each with their root matching the corresponding volume activation
/// root) that would shadow the original mount.
/// </para>
/// <para>
/// The proxy monitor in GVfs 2.26 and later, automatically creates and
/// manage shadow mounts (and shadows the underlying mount) if the
/// activation root on a #GVolume is set.
/// </para>
/// </summary>

/// <param name="mount">
/// A #GMount.
/// </param>
/// <return>
/// %TRUE if @mount is shadowed.
/// </return>

	public static bool IsShadowed(this MentorLake.Gio.GMountHandle mount)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		return GMountHandleExterns.g_mount_is_shadowed(mount);
	}

/// <summary>
/// <para>
/// Remounts a mount. This is an asynchronous operation, and is
/// finished by calling g_mount_remount_finish() with the @mount
/// and #GAsyncResults data returned in the @callback.
/// </para>
/// <para>
/// Remounting is useful when some setting affecting the operation
/// of the volume has been changed, as these may need a remount to
/// take affect. While this is semantically equivalent with unmounting
/// and then remounting not all backends might need to actually be
/// unmounted.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation or %NULL to avoid
///     user interaction.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>

	public static T Remount<T>(this T mount, MentorLake.Gio.GMountMountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		GMountHandleExterns.g_mount_remount(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

/// <summary>
/// <para>
/// Finishes remounting a mount. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the mount was successfully remounted. %FALSE otherwise.
/// </return>

	public static bool RemountFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		var externCallResult = GMountHandleExterns.g_mount_remount_finish(mount, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Increments the shadow count on @mount. Usually used by
/// #GVolumeMonitor implementations when creating a shadow mount for
/// @mount, see g_mount_is_shadowed() for more information. The caller
/// will need to emit the #GMount::changed signal on @mount manually.
/// </para>
/// </summary>

/// <param name="mount">
/// A #GMount.
/// </param>

	public static T Shadow<T>(this T mount) where T : GMountHandle
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		GMountHandleExterns.g_mount_shadow(mount);
		return mount;
	}

/// <summary>
/// <para>
/// Unmounts a mount. This is an asynchronous operation, and is
/// finished by calling g_mount_unmount_finish() with the @mount
/// and #GAsyncResult data returned in the @callback.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>

	public static T Unmount<T>(this T mount, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		GMountHandleExterns.g_mount_unmount(mount, flags, cancellable, callback, user_data);
		return mount;
	}

/// <summary>
/// <para>
/// Finishes unmounting a mount. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the mount was successfully unmounted. %FALSE otherwise.
/// </return>

	public static bool UnmountFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		var externCallResult = GMountHandleExterns.g_mount_unmount_finish(mount, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Unmounts a mount. This is an asynchronous operation, and is
/// finished by calling g_mount_unmount_with_operation_finish() with the @mount
/// and #GAsyncResult data returned in the @callback.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation or %NULL to avoid
///     user interaction.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>

	public static T UnmountWithOperation<T>(this T mount, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GMountHandle
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		GMountHandleExterns.g_mount_unmount_with_operation(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

/// <summary>
/// <para>
/// Finishes unmounting a mount. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the mount was successfully unmounted. %FALSE otherwise.
/// </return>

	public static bool UnmountWithOperationFinish(this MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
		var externCallResult = GMountHandleExterns.g_mount_unmount_with_operation_finish(mount, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Decrements the shadow count on @mount. Usually used by
/// #GVolumeMonitor implementations when destroying a shadow mount for
/// @mount, see g_mount_is_shadowed() for more information. The caller
/// will need to emit the #GMount::changed signal on @mount manually.
/// </para>
/// </summary>

/// <param name="mount">
/// A #GMount.
/// </param>

	public static T Unshadow<T>(this T mount) where T : GMountHandle
	{
		if (mount.IsInvalid) throw new Exception("Invalid handle (GMountHandle)");
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
	internal static extern bool g_mount_eject_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_eject_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_eject_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_mount_get_default_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))]
	internal static extern MentorLake.Gio.GDriveHandle g_mount_get_drive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_mount_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_mount_get_root([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_get_sort_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_mount_get_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mount_get_uuid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))]
	internal static extern MentorLake.Gio.GVolumeHandle g_mount_get_volume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_guess_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, bool force_rescan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_mount_guess_content_type_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_mount_guess_content_type_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, bool force_rescan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_is_shadowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_remount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountMountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_remount_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_shadow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_unmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_unmount_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_unmount_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_mount_unmount_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_mount_unshadow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

}
