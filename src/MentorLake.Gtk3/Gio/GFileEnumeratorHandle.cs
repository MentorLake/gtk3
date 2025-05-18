namespace MentorLake.Gio;

public class GFileEnumeratorHandle : GObjectHandle
{
}

public static class GFileEnumeratorHandleExtensions
{
	public static bool Close(this MentorLake.Gio.GFileEnumeratorHandle enumerator, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		var externCallResult = GFileEnumeratorHandleExterns.g_file_enumerator_close(enumerator, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T CloseAsync<T>(this T enumerator, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileEnumeratorHandle
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		GFileEnumeratorHandleExterns.g_file_enumerator_close_async(enumerator, io_priority, cancellable, callback, user_data);
		return enumerator;
	}

	public static bool CloseFinish(this MentorLake.Gio.GFileEnumeratorHandle enumerator, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		var externCallResult = GFileEnumeratorHandleExterns.g_file_enumerator_close_finish(enumerator, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GFileHandle GetChild(this MentorLake.Gio.GFileEnumeratorHandle enumerator, MentorLake.Gio.GFileInfoHandle info)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		return GFileEnumeratorHandleExterns.g_file_enumerator_get_child(enumerator, info);
	}

	public static MentorLake.Gio.GFileHandle GetContainer(this MentorLake.Gio.GFileEnumeratorHandle enumerator)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		return GFileEnumeratorHandleExterns.g_file_enumerator_get_container(enumerator);
	}

	public static bool HasPending(this MentorLake.Gio.GFileEnumeratorHandle enumerator)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		return GFileEnumeratorHandleExterns.g_file_enumerator_has_pending(enumerator);
	}

	public static bool IsClosed(this MentorLake.Gio.GFileEnumeratorHandle enumerator)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		return GFileEnumeratorHandleExterns.g_file_enumerator_is_closed(enumerator);
	}

	public static bool Iterate(this MentorLake.Gio.GFileEnumeratorHandle direnum, out MentorLake.Gio.GFileInfoHandle out_info, out MentorLake.Gio.GFileHandle out_child, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (direnum.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		var externCallResult = GFileEnumeratorHandleExterns.g_file_enumerator_iterate(direnum, out out_info, out out_child, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GFileInfoHandle NextFile(this MentorLake.Gio.GFileEnumeratorHandle enumerator, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		var externCallResult = GFileEnumeratorHandleExterns.g_file_enumerator_next_file(enumerator, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T NextFilesAsync<T>(this T enumerator, int num_files, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileEnumeratorHandle
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		GFileEnumeratorHandleExterns.g_file_enumerator_next_files_async(enumerator, num_files, io_priority, cancellable, callback, user_data);
		return enumerator;
	}

	public static MentorLake.GLib.GListHandle NextFilesFinish(this MentorLake.Gio.GFileEnumeratorHandle enumerator, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		var externCallResult = GFileEnumeratorHandleExterns.g_file_enumerator_next_files_finish(enumerator, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetPending<T>(this T enumerator, bool pending) where T : GFileEnumeratorHandle
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GFileEnumeratorHandle)");
		GFileEnumeratorHandleExterns.g_file_enumerator_set_pending(enumerator, pending);
		return enumerator;
	}

}

internal class GFileEnumeratorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_enumerator_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_enumerator_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_enumerator_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_enumerator_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_enumerator_get_container([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_enumerator_has_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_enumerator_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_enumerator_iterate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle direnum, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] out MentorLake.Gio.GFileInfoHandle out_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] out MentorLake.Gio.GFileHandle out_child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_enumerator_next_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_enumerator_next_files_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator, int num_files, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_file_enumerator_next_files_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_enumerator_set_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileEnumeratorHandle>))] MentorLake.Gio.GFileEnumeratorHandle enumerator, bool pending);

}
