namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The `GVolume` interface represents user-visible objects that can be
/// mounted. For example, a file system partition on a USB flash drive, or an
/// optical disc inserted into a disc drive.
/// </para>
/// <para>
/// If a `GVolume` is currently mounted, the corresponding [iface@Gio.Mount] can
/// be retrieved using [method@Gio.Volume.get_mount].
/// </para>
/// <para>
/// Mounting a `GVolume` instance is an asynchronous operation. For more
/// information about asynchronous operations, see [iface@Gio.AsyncResult] and
/// [class@Gio.Task]. To mount a `GVolume`, first call [method@Gio.Volume.mount]
/// with (at least) the `GVolume` instance, optionally a
/// [class@Gio.MountOperation] object and a [type@Gio.AsyncReadyCallback].
/// </para>
/// <para>
/// Typically, one will only want to pass `NULL` for the
/// [class@Gio.MountOperation] if automounting all volumes when a desktop session
/// starts since it’s not desirable to put up a lot of dialogs asking
/// for credentials.
/// </para>
/// <para>
/// The callback will be fired when the operation has resolved (either
/// with success or failure), and a [iface@Gio.AsyncResult] instance will be
/// passed to the callback.  That callback should then call
/// [method@Gio.Volume.mount_finish] with the `GVolume` instance and the
/// [iface@Gio.AsyncResult] data to see if the operation was completed
/// successfully.  If a [type@GLib.Error] is present when
/// [method@Gio.Volume.mount_finish] is called, then it will be filled with any
/// error information.
/// </para>
/// <para>
/// Note, when [porting from GnomeVFS](migrating-gnome-vfs.html),
/// `GVolume` is the moral equivalent of `GnomeVFSDrive`.
/// </para>
/// <para>
/// ## Volume Identifiers
/// </para>
/// <para>
/// It is sometimes necessary to directly access the underlying
/// operating system object behind a volume (e.g. for passing a volume
/// to an application via the command line). For this purpose, GIO
/// allows to obtain an ‘identifier’ for the volume. There can be
/// different kinds of identifiers, such as Hal UDIs, filesystem labels,
/// traditional Unix devices (e.g. `/dev/sda2`), UUIDs. GIO uses predefined
/// strings as names for the different kinds of identifiers:
/// `G_VOLUME_IDENTIFIER_KIND_UUID`, `G_VOLUME_IDENTIFIER_KIND_LABEL`, etc.
/// Use [method@Gio.Volume.get_identifier] to obtain an identifier for a volume.
/// </para>
/// <para>
/// Note that `G_VOLUME_IDENTIFIER_KIND_HAL_UDI` will only be available
/// when the GVFS hal volume monitor is in use. Other volume monitors
/// will generally be able to provide the `G_VOLUME_IDENTIFIER_KIND_UNIX_DEVICE`
/// identifier, which can be used to obtain a hal device by means of
/// `libhal_manager_find_device_string_match()`.
/// </para>
/// </summary>

public interface GVolumeHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GVolumeHandleImpl : BaseSafeHandle, GVolumeHandle
{
}

public static class GVolumeHandleExtensions
{
/// <summary>
/// <para>
/// Checks if a volume can be ejected.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// %TRUE if the @volume can be ejected. %FALSE otherwise
/// </return>

	public static bool CanEject(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_can_eject(volume);
	}

/// <summary>
/// <para>
/// Checks if a volume can be mounted.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// %TRUE if the @volume can be mounted. %FALSE otherwise
/// </return>

	public static bool CanMount(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_can_mount(volume);
	}

/// <summary>
/// <para>
/// Ejects a volume. This is an asynchronous operation, and is
/// finished by calling g_volume_eject_finish() with the @volume
/// and #GAsyncResult returned in the @callback.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <param name="flags">
/// flags affecting the unmount if required for eject
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL
/// </param>
/// <param name="user_data">
/// user data that gets passed to @callback
/// </param>

	public static T Eject<T>(this T volume, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GVolumeHandle
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		GVolumeHandleExterns.g_volume_eject(volume, flags, cancellable, callback, user_data);
		return volume;
	}

/// <summary>
/// <para>
/// Finishes ejecting a volume. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="volume">
/// pointer to a #GVolume
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE, %FALSE if operation failed
/// </return>

	public static bool EjectFinish(this MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		var externCallResult = GVolumeHandleExterns.g_volume_eject_finish(volume, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Ejects a volume. This is an asynchronous operation, and is
/// finished by calling g_volume_eject_with_operation_finish() with the @volume
/// and #GAsyncResult data returned in the @callback.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <param name="flags">
/// flags affecting the unmount if required for eject
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation or %NULL to
///     avoid user interaction
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL
/// </param>
/// <param name="user_data">
/// user data passed to @callback
/// </param>

	public static T EjectWithOperation<T>(this T volume, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GVolumeHandle
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		GVolumeHandleExterns.g_volume_eject_with_operation(volume, flags, mount_operation, cancellable, callback, user_data);
		return volume;
	}

/// <summary>
/// <para>
/// Finishes ejecting a volume. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the volume was successfully ejected. %FALSE otherwise
/// </return>

	public static bool EjectWithOperationFinish(this MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		var externCallResult = GVolumeHandleExterns.g_volume_eject_with_operation_finish(volume, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the kinds of [identifiers](#volume-identifiers) that @volume has.
/// Use g_volume_get_identifier() to obtain the identifiers themselves.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// a %NULL-terminated array
///   of strings containing kinds of identifiers. Use g_strfreev() to free.
/// </return>

	public static string[] EnumerateIdentifiers(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_enumerate_identifiers(volume);
	}

/// <summary>
/// <para>
/// Gets the activation root for a #GVolume if it is known ahead of
/// mount time. Returns %NULL otherwise. If not %NULL and if @volume
/// is mounted, then the result of g_mount_get_root() on the
/// #GMount object obtained from g_volume_get_mount() will always
/// either be equal or a prefix of what this function returns. In
/// other words, in code
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   GMount *mount;
///   GFile *mount_root
///   GFile *volume_activation_root;
/// </para>
/// <para>
///   mount = g_volume_get_mount (volume); // mounted, so never NULL
///   mount_root = g_mount_get_root (mount);
///   volume_activation_root = g_volume_get_activation_root (volume); // assume not NULL
/// ]|
/// then the expression
/// |[<!-- language="C" -->
///   (g_file_has_prefix (volume_activation_root, mount_root) ||
///    g_file_equal (volume_activation_root, mount_root))
/// ]|
/// will always be %TRUE.
/// </para>
/// <para>
/// Activation roots are typically used in #GVolumeMonitor
/// implementations to find the underlying mount to shadow, see
/// g_mount_is_shadowed() for more details.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// the activation root of @volume
///     or %NULL. Use g_object_unref() to free.
/// </return>

	public static MentorLake.Gio.GFileHandle GetActivationRoot(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_activation_root(volume);
	}

/// <summary>
/// <para>
/// Gets the drive for the @volume.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// a #GDrive or %NULL if @volume is not
///     associated with a drive. The returned object should be unreffed
///     with g_object_unref() when no longer needed.
/// </return>

	public static MentorLake.Gio.GDriveHandle GetDrive(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_drive(volume);
	}

/// <summary>
/// <para>
/// Gets the icon for @volume.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// a #GIcon.
///     The returned object should be unreffed with g_object_unref()
///     when no longer needed.
/// </return>

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_icon(volume);
	}

/// <summary>
/// <para>
/// Gets the identifier of the given kind for @volume.
/// See the [introduction](#volume-identifiers) for more
/// information about volume identifiers.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <param name="kind">
/// the kind of identifier to return
/// </param>
/// <return>
/// a newly allocated string containing the
///     requested identifier, or %NULL if the #GVolume
///     doesn't have this kind of identifier
/// </return>

	public static string GetIdentifier(this MentorLake.Gio.GVolumeHandle volume, string kind)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_identifier(volume, kind);
	}

/// <summary>
/// <para>
/// Gets the mount for the @volume.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// a #GMount or %NULL if @volume isn't mounted.
///     The returned object should be unreffed with g_object_unref()
///     when no longer needed.
/// </return>

	public static MentorLake.Gio.GMountHandle GetMount(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_mount(volume);
	}

/// <summary>
/// <para>
/// Gets the name of @volume.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// the name for the given @volume. The returned string should
///     be freed with g_free() when no longer needed.
/// </return>

	public static string GetName(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_name(volume);
	}

/// <summary>
/// <para>
/// Gets the sort key for @volume, if any.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// Sorting key for @volume or %NULL if no such key is available
/// </return>

	public static string GetSortKey(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_sort_key(volume);
	}

/// <summary>
/// <para>
/// Gets the symbolic icon for @volume.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// a #GIcon.
///     The returned object should be unreffed with g_object_unref()
///     when no longer needed.
/// </return>

	public static MentorLake.Gio.GIconHandle GetSymbolicIcon(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_symbolic_icon(volume);
	}

/// <summary>
/// <para>
/// Gets the UUID for the @volume. The reference is typically based on
/// the file system UUID for the volume in question and should be
/// considered an opaque string. Returns %NULL if there is no UUID
/// available.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// the UUID for @volume or %NULL if no UUID
///     can be computed.
///     The returned string should be freed with g_free()
///     when no longer needed.
/// </return>

	public static string GetUuid(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		return GVolumeHandleExterns.g_volume_get_uuid(volume);
	}

/// <summary>
/// <para>
/// Mounts a volume. This is an asynchronous operation, and is
/// finished by calling g_volume_mount_finish() with the @volume
/// and #GAsyncResult returned in the @callback.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <param name="flags">
/// flags affecting the operation
/// </param>
/// <param name="mount_operation">
/// a #GMountOperation or %NULL to avoid user interaction
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback, or %NULL
/// </param>
/// <param name="user_data">
/// user data that gets passed to @callback
/// </param>

	public static T Mount<T>(this T volume, MentorLake.Gio.GMountMountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GVolumeHandle
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		GVolumeHandleExterns.g_volume_mount(volume, flags, mount_operation, cancellable, callback, user_data);
		return volume;
	}

/// <summary>
/// <para>
/// Finishes mounting a volume. If any errors occurred during the operation,
/// @error will be set to contain the errors and %FALSE will be returned.
/// </para>
/// <para>
/// If the mount operation succeeded, g_volume_get_mount() on @volume
/// is guaranteed to return the mount right after calling this
/// function; there's no need to listen for the 'mount-added' signal on
/// #GVolumeMonitor.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE, %FALSE if operation failed
/// </return>

	public static bool MountFinish(this MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
		var externCallResult = GVolumeHandleExterns.g_volume_mount_finish(volume, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns whether the volume should be automatically mounted.
/// </para>
/// </summary>

/// <param name="volume">
/// a #GVolume
/// </param>
/// <return>
/// %TRUE if the volume should be automatically mounted
/// </return>

	public static bool ShouldAutomount(this MentorLake.Gio.GVolumeHandle volume)
	{
		if (volume.IsInvalid) throw new Exception("Invalid handle (GVolumeHandle)");
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
	internal static extern bool g_volume_eject_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_volume_eject_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_eject_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_volume_enumerate_identifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_volume_get_activation_root([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))]
	internal static extern MentorLake.Gio.GDriveHandle g_volume_get_drive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_volume_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_volume_get_identifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, string kind);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))]
	internal static extern MentorLake.Gio.GMountHandle g_volume_get_mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_volume_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_volume_get_sort_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_volume_get_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_volume_get_uuid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_volume_mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, MentorLake.Gio.GMountMountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_mount_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_volume_should_automount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume);

}
