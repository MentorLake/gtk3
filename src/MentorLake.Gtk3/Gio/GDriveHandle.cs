namespace MentorLake.Gio;

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
	public static bool CanEject(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_eject(drive);
	}

	public static bool CanPollForMedia(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_poll_for_media(drive);
	}

	public static bool CanStart(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_start(drive);
	}

	public static bool CanStartDegraded(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_start_degraded(drive);
	}

	public static bool CanStop(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_can_stop(drive);
	}

	public static T Eject<T>(this T drive, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_eject(drive, flags, cancellable, callback, user_data);
		return drive;
	}

	public static bool EjectFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_eject_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T EjectWithOperation<T>(this T drive, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_eject_with_operation(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

	public static bool EjectWithOperationFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_eject_with_operation_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string[] EnumerateIdentifiers(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_enumerate_identifiers(drive);
	}

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_icon(drive);
	}

	public static string GetIdentifier(this MentorLake.Gio.GDriveHandle drive, string kind)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_identifier(drive, kind);
	}

	public static string GetName(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_name(drive);
	}

	public static string GetSortKey(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_sort_key(drive);
	}

	public static MentorLake.Gio.GDriveStartStopType GetStartStopType(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_start_stop_type(drive);
	}

	public static MentorLake.Gio.GIconHandle GetSymbolicIcon(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_symbolic_icon(drive);
	}

	public static MentorLake.GLib.GListHandle GetVolumes(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_get_volumes(drive);
	}

	public static bool HasMedia(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_has_media(drive);
	}

	public static bool HasVolumes(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_has_volumes(drive);
	}

	public static bool IsMediaCheckAutomatic(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_is_media_check_automatic(drive);
	}

	public static bool IsMediaRemovable(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_is_media_removable(drive);
	}

	public static bool IsRemovable(this MentorLake.Gio.GDriveHandle drive)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		return GDriveHandleExterns.g_drive_is_removable(drive);
	}

	public static T PollForMedia<T>(this T drive, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_poll_for_media(drive, cancellable, callback, user_data);
		return drive;
	}

	public static bool PollForMediaFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_poll_for_media_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Start<T>(this T drive, MentorLake.Gio.GDriveStartFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_start(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

	public static bool StartFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		var externCallResult = GDriveHandleExterns.g_drive_start_finish(drive, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Stop<T>(this T drive, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDriveHandle
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
		GDriveHandleExterns.g_drive_stop(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

	public static bool StopFinish(this MentorLake.Gio.GDriveHandle drive, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (drive.IsInvalid || drive.IsClosed) throw new Exception("Invalid or closed handle (GDriveHandle)");
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
	internal static extern MentorLake.Gio.GIconHandle g_drive_get_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive);

	[DllImport(GioLibrary.Name)]
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
