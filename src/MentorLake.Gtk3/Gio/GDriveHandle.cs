namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDrive` represents a piece of hardware connected to the machine.
/// It’s generally only created for removable hardware or hardware with
/// removable media. For example, an optical disc drive, or a USB flash drive.
/// </para>
/// <para>
/// `GDrive` is a container class for [iface@Gio.Volume] objects that stem from
/// the same piece of media. As such, `GDrive` abstracts a drive with
/// (or without) removable media and provides operations for querying
/// whether media is available, determining whether media change is
/// automatically detected and ejecting the media.
/// </para>
/// <para>
/// If the `GDrive` reports that media isn’t automatically detected, one
/// can poll for media; typically one should not do this periodically
/// as a poll for media operation is potentially expensive and may
/// spin up the drive creating noise.
/// </para>
/// <para>
/// `GDrive` supports starting and stopping drives with authentication
/// support for the former. This can be used to support a diverse set
/// of use cases including connecting/disconnecting iSCSI devices,
/// powering down external disk enclosures and starting/stopping
/// multi-disk devices such as RAID devices. Note that the actual
/// semantics and side-effects of starting/stopping a `GDrive` may vary
/// according to implementation. To choose the correct verbs in e.g. a
/// file manager, use [method@Gio.Drive.get_start_stop_type].
/// </para>
/// <para>
/// For [porting from GnomeVFS](migrating-gnome-vfs.html) note that there is no
/// equivalent of `GDrive` in that API.
/// </para>
/// </summary>

public interface GDriveHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDriveHandleImpl : BaseSafeHandle, GDriveHandle
{
}

public static class GDriveHandleExtensions
{
/// <summary>
/// <para>
/// Checks if a drive can be ejected.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if the @drive can be ejected, %FALSE otherwise.
/// </return>

	public static bool CanEject(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_eject(drive);
	}

/// <summary>
/// <para>
/// Checks if a drive can be polled for media changes.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if the @drive can be polled for media changes,
///     %FALSE otherwise.
/// </return>

	public static bool CanPollForMedia(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_poll_for_media(drive);
	}

/// <summary>
/// <para>
/// Checks if a drive can be started.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if the @drive can be started, %FALSE otherwise.
/// </return>

	public static bool CanStart(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_start(drive);
	}

/// <summary>
/// <para>
/// Checks if a drive can be started degraded.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if the @drive can be started degraded, %FALSE otherwise.
/// </return>

	public static bool CanStartDegraded(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_start_degraded(drive);
	}

/// <summary>
/// <para>
/// Checks if a drive can be stopped.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if the @drive can be stopped, %FALSE otherwise.
/// </return>

	public static bool CanStop(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_stop(drive);
	}

/// <summary>
/// <para>
/// Asynchronously ejects a drive.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_drive_eject_finish() to obtain the
/// result of the operation.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
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
/// user data to pass to @callback
/// </param>

	public static T Eject<T>(this T drive, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_eject(drive, flags, cancellable, callback, user_data);
		return drive;
	}

/// <summary>
/// <para>
/// Finishes ejecting a drive.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the drive has been ejected successfully,
///     %FALSE otherwise.
/// </return>

	public static bool EjectFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_eject_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Ejects a drive. This is an asynchronous operation, and is
/// finished by calling g_drive_eject_with_operation_finish() with the @drive
/// and #GAsyncResult data returned in the @callback.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
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

	public static T EjectWithOperation<T>(this T drive, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_eject_with_operation(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

/// <summary>
/// <para>
/// Finishes ejecting a drive. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the drive was successfully ejected. %FALSE otherwise.
/// </return>

	public static bool EjectWithOperationFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_eject_with_operation_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the kinds of identifiers that @drive has.
/// Use g_drive_get_identifier() to obtain the identifiers
/// themselves.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive
/// </param>
/// <return>
/// a %NULL-terminated
///     array of strings containing kinds of identifiers. Use g_strfreev()
///     to free.
/// </return>

	public static string[] EnumerateIdentifiers(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_enumerate_identifiers(drive);
	}

/// <summary>
/// <para>
/// Gets the icon for @drive.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// #GIcon for the @drive.
///    Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_icon(drive);
	}

/// <summary>
/// <para>
/// Gets the identifier of the given kind for @drive. The only
/// identifier currently available is
/// %G_DRIVE_IDENTIFIER_KIND_UNIX_DEVICE.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive
/// </param>
/// <param name="kind">
/// the kind of identifier to return
/// </param>
/// <return>
/// a newly allocated string containing the
///     requested identifier, or %NULL if the #GDrive
///     doesn't have this kind of identifier.
/// </return>

	public static string GetIdentifier(this MentorLake.Gio.GDriveHandle drive, string kind)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_identifier(drive, kind);
	}

/// <summary>
/// <para>
/// Gets the name of @drive.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// a string containing @drive's name. The returned
///     string should be freed when no longer needed.
/// </return>

	public static string GetName(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_name(drive);
	}

/// <summary>
/// <para>
/// Gets the sort key for @drive, if any.
/// </para>
/// </summary>

/// <param name="drive">
/// A #GDrive.
/// </param>
/// <return>
/// Sorting key for @drive or %NULL if no such key is available.
/// </return>

	public static string GetSortKey(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_sort_key(drive);
	}

/// <summary>
/// <para>
/// Gets a hint about how a drive can be started/stopped.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// A value from the #GDriveStartStopType enumeration.
/// </return>

	public static MentorLake.Gio.GDriveStartStopType GetStartStopType(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_start_stop_type(drive);
	}

/// <summary>
/// <para>
/// Gets the icon for @drive.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// symbolic #GIcon for the @drive.
///    Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GIconHandle GetSymbolicIcon(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_symbolic_icon(drive);
	}

/// <summary>
/// <para>
/// Get a list of mountable volumes for @drive.
/// </para>
/// <para>
/// The returned list should be freed with g_list_free(), after
/// its elements have been unreffed with g_object_unref().
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// #GList containing any #GVolume objects on the given @drive.
/// </return>

	public static MentorLake.GLib.GListHandle GetVolumes(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_volumes(drive);
	}

/// <summary>
/// <para>
/// Checks if the @drive has media. Note that the OS may not be polling
/// the drive for media changes; see g_drive_is_media_check_automatic()
/// for more details.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if @drive has media, %FALSE otherwise.
/// </return>

	public static bool HasMedia(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_has_media(drive);
	}

/// <summary>
/// <para>
/// Check if @drive has any mountable volumes.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if the @drive contains volumes, %FALSE otherwise.
/// </return>

	public static bool HasVolumes(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_has_volumes(drive);
	}

/// <summary>
/// <para>
/// Checks if @drive is capable of automatically detecting media changes.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if the @drive is capable of automatically detecting
///     media changes, %FALSE otherwise.
/// </return>

	public static bool IsMediaCheckAutomatic(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_is_media_check_automatic(drive);
	}

/// <summary>
/// <para>
/// Checks if the @drive supports removable media.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if @drive supports removable media, %FALSE otherwise.
/// </return>

	public static bool IsMediaRemovable(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_is_media_removable(drive);
	}

/// <summary>
/// <para>
/// Checks if the #GDrive and/or its media is considered removable by the user.
/// See g_drive_is_media_removable().
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <return>
/// %TRUE if @drive and/or its media is considered removable, %FALSE otherwise.
/// </return>

	public static bool IsRemovable(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_is_removable(drive);
	}

/// <summary>
/// <para>
/// Asynchronously polls @drive to see if media has been inserted or removed.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_drive_poll_for_media_finish() to obtain the
/// result of the operation.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL.
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>

	public static T PollForMedia<T>(this T drive, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_poll_for_media(drive, cancellable, callback, user_data);
		return drive;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_drive_poll_for_media() on a drive.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the drive has been poll_for_mediaed successfully,
///     %FALSE otherwise.
/// </return>

	public static bool PollForMediaFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_poll_for_media_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously starts a drive.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_drive_start_finish() to obtain the
/// result of the operation.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <param name="flags">
/// flags affecting the start operation.
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
/// user data to pass to @callback
/// </param>

	public static T Start<T>(this T drive, MentorLake.Gio.GDriveStartFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_start(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

/// <summary>
/// <para>
/// Finishes starting a drive.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the drive has been started successfully,
///     %FALSE otherwise.
/// </return>

	public static bool StartFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_start_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously stops a drive.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_drive_stop_finish() to obtain the
/// result of the operation.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <param name="flags">
/// flags affecting the unmount if required for stopping.
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
/// user data to pass to @callback
/// </param>

	public static T Stop<T>(this T drive, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_stop(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

/// <summary>
/// <para>
/// Finishes stopping a drive.
/// </para>
/// </summary>

/// <param name="drive">
/// a #GDrive.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE if the drive has been stopped successfully,
///     %FALSE otherwise.
/// </return>

	public static bool StopFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid) throw new Exception("Invalid handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_stop_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GDriveHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_can_poll_for_media([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_can_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_can_start_degraded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_can_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_drive_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_eject_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_drive_eject_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_eject_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_drive_enumerate_identifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_drive_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_drive_get_identifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, string kind);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_drive_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_drive_get_sort_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDriveStartStopType g_drive_get_start_stop_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_drive_get_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_drive_get_volumes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_has_media([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_has_volumes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_is_media_check_automatic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_is_media_removable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_is_removable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_drive_poll_for_media([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_poll_for_media_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_drive_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GDriveStartFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_start_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_drive_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_drive_stop_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
