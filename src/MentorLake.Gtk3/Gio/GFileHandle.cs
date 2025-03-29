namespace MentorLake.Gio;

public interface GFileHandle
{
}

internal class GFileHandleImpl : BaseSafeHandle, GFileHandle
{
}

public static class GFileHandleExtensions
{
	public static MentorLake.Gio.GFileOutputStreamHandle AppendTo(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_append_to(file, flags, cancellable, error);
	}

	public static T AppendToAsync<T>(this T file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_append_to_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileOutputStreamHandle AppendToFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_append_to_finish(file, res, error);
	}

	public static string BuildAttributeListForCopy(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCopyFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_build_attribute_list_for_copy(file, flags, cancellable, error);
	}

	public static bool Copy(this MentorLake.Gio.GFileHandle source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, IntPtr error)
	{
		return GFileHandleExterns.g_file_copy(source, destination, flags, cancellable, progress_callback, progress_callback_data, error);
	}

	public static T CopyAsync<T>(this T source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_copy_async(source, destination, flags, io_priority, cancellable, progress_callback, progress_callback_data, callback, user_data);
		return source;
	}

	public static T CopyAsyncWithClosures<T>(this T source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GObject.GClosureHandle progress_callback_closure, MentorLake.GObject.GClosureHandle ready_callback_closure) where T : GFileHandle
	{
		GFileHandleExterns.g_file_copy_async_with_closures(source, destination, flags, io_priority, cancellable, progress_callback_closure, ready_callback_closure);
		return source;
	}

	public static bool CopyAttributes(this MentorLake.Gio.GFileHandle source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_copy_attributes(source, destination, flags, cancellable, error);
	}

	public static bool CopyFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_copy_finish(file, res, error);
	}

	public static MentorLake.Gio.GFileOutputStreamHandle Create(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_create(file, flags, cancellable, error);
	}

	public static T CreateAsync<T>(this T file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_create_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileOutputStreamHandle CreateFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_create_finish(file, res, error);
	}

	public static MentorLake.Gio.GFileIOStreamHandle CreateReadwrite(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_create_readwrite(file, flags, cancellable, error);
	}

	public static T CreateReadwriteAsync<T>(this T file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_create_readwrite_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileIOStreamHandle CreateReadwriteFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_create_readwrite_finish(file, res, error);
	}

	public static bool Delete(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_delete(file, cancellable, error);
	}

	public static T DeleteAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_delete_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool DeleteFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_delete_finish(file, result, error);
	}

	public static MentorLake.Gio.GFileHandle Dup(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_dup(file);
	}

	public static T EjectMountable<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_eject_mountable(file, flags, cancellable, callback, user_data);
		return file;
	}

	public static bool EjectMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_eject_mountable_finish(file, result, error);
	}

	public static T EjectMountableWithOperation<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_eject_mountable_with_operation(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

	public static bool EjectMountableWithOperationFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_eject_mountable_with_operation_finish(file, result, error);
	}

	public static MentorLake.Gio.GFileEnumeratorHandle EnumerateChildren(this MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_enumerate_children(file, attributes, flags, cancellable, error);
	}

	public static T EnumerateChildrenAsync<T>(this T file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_enumerate_children_async(file, attributes, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileEnumeratorHandle EnumerateChildrenFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_enumerate_children_finish(file, res, error);
	}

	public static bool Equal(this MentorLake.Gio.GFileHandle file1, MentorLake.Gio.GFileHandle file2)
	{
		return GFileHandleExterns.g_file_equal(file1, file2);
	}

	public static MentorLake.Gio.GMountHandle FindEnclosingMount(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_find_enclosing_mount(file, cancellable, error);
	}

	public static T FindEnclosingMountAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_find_enclosing_mount_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GMountHandle FindEnclosingMountFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_find_enclosing_mount_finish(file, res, error);
	}

	public static string GetBasename(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_get_basename(file);
	}

	public static MentorLake.Gio.GFileHandle GetChild(this MentorLake.Gio.GFileHandle file, string name)
	{
		return GFileHandleExterns.g_file_get_child(file, name);
	}

	public static MentorLake.Gio.GFileHandle GetChildForDisplayName(this MentorLake.Gio.GFileHandle file, string display_name, IntPtr error)
	{
		return GFileHandleExterns.g_file_get_child_for_display_name(file, display_name, error);
	}

	public static MentorLake.Gio.GFileHandle GetParent(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_get_parent(file);
	}

	public static string GetParseName(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_get_parse_name(file);
	}

	public static string GetPath(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_get_path(file);
	}

	public static string GetRelativePath(this MentorLake.Gio.GFileHandle parent, MentorLake.Gio.GFileHandle descendant)
	{
		return GFileHandleExterns.g_file_get_relative_path(parent, descendant);
	}

	public static string GetUri(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_get_uri(file);
	}

	public static string GetUriScheme(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_get_uri_scheme(file);
	}

	public static bool HasParent(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileHandle parent)
	{
		return GFileHandleExterns.g_file_has_parent(file, parent);
	}

	public static bool HasPrefix(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileHandle prefix)
	{
		return GFileHandleExterns.g_file_has_prefix(file, prefix);
	}

	public static bool HasUriScheme(this MentorLake.Gio.GFileHandle file, string uri_scheme)
	{
		return GFileHandleExterns.g_file_has_uri_scheme(file, uri_scheme);
	}

	public static uint Hash(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_hash(file);
	}

	public static bool IsNative(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_is_native(file);
	}

	public static MentorLake.GLib.GBytesHandle LoadBytes(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, out string etag_out, IntPtr error)
	{
		return GFileHandleExterns.g_file_load_bytes(file, cancellable, out etag_out, error);
	}

	public static T LoadBytesAsync<T>(this T file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_load_bytes_async(file, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.GLib.GBytesHandle LoadBytesFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, out string etag_out, IntPtr error)
	{
		return GFileHandleExterns.g_file_load_bytes_finish(file, result, out etag_out, error);
	}

	public static bool LoadContents(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, out byte[] contents, out UIntPtr length, out string etag_out, IntPtr error)
	{
		return GFileHandleExterns.g_file_load_contents(file, cancellable, out contents, out length, out etag_out, error);
	}

	public static T LoadContentsAsync<T>(this T file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_load_contents_async(file, cancellable, callback, user_data);
		return file;
	}

	public static bool LoadContentsFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, out byte[] contents, out UIntPtr length, out string etag_out, IntPtr error)
	{
		return GFileHandleExterns.g_file_load_contents_finish(file, res, out contents, out length, out etag_out, error);
	}

	public static T LoadPartialContentsAsync<T>(this T file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileReadMoreCallback read_more_callback, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_load_partial_contents_async(file, cancellable, read_more_callback, callback, user_data);
		return file;
	}

	public static bool LoadPartialContentsFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, out byte[] contents, out UIntPtr length, out string etag_out, IntPtr error)
	{
		return GFileHandleExterns.g_file_load_partial_contents_finish(file, res, out contents, out length, out etag_out, error);
	}

	public static bool MakeDirectory(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_make_directory(file, cancellable, error);
	}

	public static T MakeDirectoryAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_make_directory_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool MakeDirectoryFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_make_directory_finish(file, result, error);
	}

	public static bool MakeDirectoryWithParents(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_make_directory_with_parents(file, cancellable, error);
	}

	public static bool MakeSymbolicLink(this MentorLake.Gio.GFileHandle file, string symlink_value, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_make_symbolic_link(file, symlink_value, cancellable, error);
	}

	public static T MakeSymbolicLinkAsync<T>(this T file, string symlink_value, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_make_symbolic_link_async(file, symlink_value, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool MakeSymbolicLinkFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_make_symbolic_link_finish(file, result, error);
	}

	public static bool MeasureDiskUsage(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMeasureFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileMeasureProgressCallback progress_callback, IntPtr progress_data, out ulong disk_usage, out ulong num_dirs, out ulong num_files, IntPtr error)
	{
		return GFileHandleExterns.g_file_measure_disk_usage(file, flags, cancellable, progress_callback, progress_data, out disk_usage, out num_dirs, out num_files, error);
	}

	public static T MeasureDiskUsageAsync<T>(this T file, MentorLake.Gio.GFileMeasureFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileMeasureProgressCallback progress_callback, IntPtr progress_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_measure_disk_usage_async(file, flags, io_priority, cancellable, progress_callback, progress_data, callback, user_data);
		return file;
	}

	public static bool MeasureDiskUsageFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, out ulong disk_usage, out ulong num_dirs, out ulong num_files, IntPtr error)
	{
		return GFileHandleExterns.g_file_measure_disk_usage_finish(file, result, out disk_usage, out num_dirs, out num_files, error);
	}

	public static MentorLake.Gio.GFileMonitorHandle Monitor(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_monitor(file, flags, cancellable, error);
	}

	public static MentorLake.Gio.GFileMonitorHandle MonitorDirectory(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_monitor_directory(file, flags, cancellable, error);
	}

	public static MentorLake.Gio.GFileMonitorHandle MonitorFile(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_monitor_file(file, flags, cancellable, error);
	}

	public static T MountEnclosingVolume<T>(this T location, MentorLake.Gio.GMountMountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_mount_enclosing_volume(location, flags, mount_operation, cancellable, callback, user_data);
		return location;
	}

	public static bool MountEnclosingVolumeFinish(this MentorLake.Gio.GFileHandle location, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_mount_enclosing_volume_finish(location, result, error);
	}

	public static T MountMountable<T>(this T file, MentorLake.Gio.GMountMountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_mount_mountable(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileHandle MountMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_mount_mountable_finish(file, result, error);
	}

	public static bool Move(this MentorLake.Gio.GFileHandle source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, IntPtr error)
	{
		return GFileHandleExterns.g_file_move(source, destination, flags, cancellable, progress_callback, progress_callback_data, error);
	}

	public static T MoveAsync<T>(this T source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_move_async(source, destination, flags, io_priority, cancellable, progress_callback, progress_callback_data, callback, user_data);
		return source;
	}

	public static T MoveAsyncWithClosures<T>(this T source, MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GObject.GClosureHandle progress_callback_closure, MentorLake.GObject.GClosureHandle ready_callback_closure) where T : GFileHandle
	{
		GFileHandleExterns.g_file_move_async_with_closures(source, destination, flags, io_priority, cancellable, progress_callback_closure, ready_callback_closure);
		return source;
	}

	public static bool MoveFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_move_finish(file, result, error);
	}

	public static MentorLake.Gio.GFileIOStreamHandle OpenReadwrite(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_open_readwrite(file, cancellable, error);
	}

	public static T OpenReadwriteAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_open_readwrite_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileIOStreamHandle OpenReadwriteFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_open_readwrite_finish(file, res, error);
	}

	public static string PeekPath(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_peek_path(file);
	}

	public static T PollMountable<T>(this T file, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_poll_mountable(file, cancellable, callback, user_data);
		return file;
	}

	public static bool PollMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_poll_mountable_finish(file, result, error);
	}

	public static MentorLake.Gio.GAppInfoHandle QueryDefaultHandler(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_query_default_handler(file, cancellable, error);
	}

	public static T QueryDefaultHandlerAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_query_default_handler_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GAppInfoHandle QueryDefaultHandlerFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_query_default_handler_finish(file, result, error);
	}

	public static bool QueryExists(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GFileHandleExterns.g_file_query_exists(file, cancellable);
	}

	public static MentorLake.Gio.GFileType QueryFileType(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GFileHandleExterns.g_file_query_file_type(file, flags, cancellable);
	}

	public static MentorLake.Gio.GFileInfoHandle QueryFilesystemInfo(this MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_query_filesystem_info(file, attributes, cancellable, error);
	}

	public static T QueryFilesystemInfoAsync<T>(this T file, string attributes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_query_filesystem_info_async(file, attributes, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileInfoHandle QueryFilesystemInfoFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_query_filesystem_info_finish(file, res, error);
	}

	public static MentorLake.Gio.GFileInfoHandle QueryInfo(this MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_query_info(file, attributes, flags, cancellable, error);
	}

	public static T QueryInfoAsync<T>(this T file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_query_info_async(file, attributes, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileInfoHandle QueryInfoFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_query_info_finish(file, res, error);
	}

	public static MentorLake.Gio.GFileAttributeInfoListHandle QuerySettableAttributes(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_query_settable_attributes(file, cancellable, error);
	}

	public static MentorLake.Gio.GFileAttributeInfoListHandle QueryWritableNamespaces(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_query_writable_namespaces(file, cancellable, error);
	}

	public static MentorLake.Gio.GFileInputStreamHandle Read(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_read(file, cancellable, error);
	}

	public static T ReadAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_read_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileInputStreamHandle ReadFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_read_finish(file, res, error);
	}

	public static MentorLake.Gio.GFileOutputStreamHandle Replace(this MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_replace(file, etag, make_backup, flags, cancellable, error);
	}

	public static T ReplaceAsync<T>(this T file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_replace_async(file, etag, make_backup, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool ReplaceContents(this MentorLake.Gio.GFileHandle file, byte[] contents, UIntPtr length, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, out string new_etag, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_replace_contents(file, contents, length, etag, make_backup, flags, out new_etag, cancellable, error);
	}

	public static T ReplaceContentsAsync<T>(this T file, byte[] contents, UIntPtr length, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_replace_contents_async(file, contents, length, etag, make_backup, flags, cancellable, callback, user_data);
		return file;
	}

	public static T ReplaceContentsBytesAsync<T>(this T file, MentorLake.GLib.GBytesHandle contents, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_replace_contents_bytes_async(file, contents, etag, make_backup, flags, cancellable, callback, user_data);
		return file;
	}

	public static bool ReplaceContentsFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, out string new_etag, IntPtr error)
	{
		return GFileHandleExterns.g_file_replace_contents_finish(file, res, out new_etag, error);
	}

	public static MentorLake.Gio.GFileOutputStreamHandle ReplaceFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_replace_finish(file, res, error);
	}

	public static MentorLake.Gio.GFileIOStreamHandle ReplaceReadwrite(this MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_replace_readwrite(file, etag, make_backup, flags, cancellable, error);
	}

	public static T ReplaceReadwriteAsync<T>(this T file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_replace_readwrite_async(file, etag, make_backup, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileIOStreamHandle ReplaceReadwriteFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_replace_readwrite_finish(file, res, error);
	}

	public static MentorLake.Gio.GFileHandle ResolveRelativePath(this MentorLake.Gio.GFileHandle file, string relative_path)
	{
		return GFileHandleExterns.g_file_resolve_relative_path(file, relative_path);
	}

	public static bool SetAttribute(this MentorLake.Gio.GFileHandle file, string attribute, MentorLake.Gio.GFileAttributeType type, IntPtr value_p, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attribute(file, attribute, type, value_p, flags, cancellable, error);
	}

	public static bool SetAttributeByteString(this MentorLake.Gio.GFileHandle file, string attribute, string value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attribute_byte_string(file, attribute, value, flags, cancellable, error);
	}

	public static bool SetAttributeInt32(this MentorLake.Gio.GFileHandle file, string attribute, int value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attribute_int32(file, attribute, value, flags, cancellable, error);
	}

	public static bool SetAttributeInt64(this MentorLake.Gio.GFileHandle file, string attribute, long value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attribute_int64(file, attribute, value, flags, cancellable, error);
	}

	public static bool SetAttributeString(this MentorLake.Gio.GFileHandle file, string attribute, string value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attribute_string(file, attribute, value, flags, cancellable, error);
	}

	public static bool SetAttributeUint32(this MentorLake.Gio.GFileHandle file, string attribute, uint value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attribute_uint32(file, attribute, value, flags, cancellable, error);
	}

	public static bool SetAttributeUint64(this MentorLake.Gio.GFileHandle file, string attribute, ulong value, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attribute_uint64(file, attribute, value, flags, cancellable, error);
	}

	public static T SetAttributesAsync<T>(this T file, MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_set_attributes_async(file, info, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool SetAttributesFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, out MentorLake.Gio.GFileInfoHandle info, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attributes_finish(file, result, out info, error);
	}

	public static bool SetAttributesFromInfo(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileQueryInfoFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_attributes_from_info(file, info, flags, cancellable, error);
	}

	public static MentorLake.Gio.GFileHandle SetDisplayName(this MentorLake.Gio.GFileHandle file, string display_name, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_display_name(file, display_name, cancellable, error);
	}

	public static T SetDisplayNameAsync<T>(this T file, string display_name, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_set_display_name_async(file, display_name, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static MentorLake.Gio.GFileHandle SetDisplayNameFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GFileHandleExterns.g_file_set_display_name_finish(file, res, error);
	}

	public static T StartMountable<T>(this T file, MentorLake.Gio.GDriveStartFlags flags, MentorLake.Gio.GMountOperationHandle start_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_start_mountable(file, flags, start_operation, cancellable, callback, user_data);
		return file;
	}

	public static bool StartMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_start_mountable_finish(file, result, error);
	}

	public static T StopMountable<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_stop_mountable(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

	public static bool StopMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_stop_mountable_finish(file, result, error);
	}

	public static bool SupportsThreadContexts(this MentorLake.Gio.GFileHandle file)
	{
		return GFileHandleExterns.g_file_supports_thread_contexts(file);
	}

	public static bool Trash(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileHandleExterns.g_file_trash(file, cancellable, error);
	}

	public static T TrashAsync<T>(this T file, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_trash_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool TrashFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_trash_finish(file, result, error);
	}

	public static T UnmountMountable<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_unmount_mountable(file, flags, cancellable, callback, user_data);
		return file;
	}

	public static bool UnmountMountableFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_unmount_mountable_finish(file, result, error);
	}

	public static T UnmountMountableWithOperation<T>(this T file, MentorLake.Gio.GMountUnmountFlags flags, MentorLake.Gio.GMountOperationHandle mount_operation, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileHandle
	{
		GFileHandleExterns.g_file_unmount_mountable_with_operation(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

	public static bool UnmountMountableWithOperationFinish(this MentorLake.Gio.GFileHandle file, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_unmount_mountable_with_operation_finish(file, result, error);
	}

	public static MentorLake.Gio.GFileHandle NewBuildFilename(string first_element, IntPtr @__arglist)
	{
		return GFileHandleExterns.g_file_new_build_filename(first_element, @__arglist);
	}

	public static MentorLake.Gio.GFileHandle NewBuildFilenamev(string[] args)
	{
		return GFileHandleExterns.g_file_new_build_filenamev(args);
	}

	public static MentorLake.Gio.GFileHandle NewForCommandlineArg(string arg)
	{
		return GFileHandleExterns.g_file_new_for_commandline_arg(arg);
	}

	public static MentorLake.Gio.GFileHandle NewForCommandlineArgAndCwd(string arg, string cwd)
	{
		return GFileHandleExterns.g_file_new_for_commandline_arg_and_cwd(arg, cwd);
	}

	public static MentorLake.Gio.GFileHandle NewForPath(string path)
	{
		return GFileHandleExterns.g_file_new_for_path(path);
	}

	public static MentorLake.Gio.GFileHandle NewForUri(string uri)
	{
		return GFileHandleExterns.g_file_new_for_uri(uri);
	}

	public static MentorLake.Gio.GFileHandle NewTmp(string tmpl, out MentorLake.Gio.GFileIOStreamHandle iostream, IntPtr error)
	{
		return GFileHandleExterns.g_file_new_tmp(tmpl, out iostream, error);
	}

	public static void NewTmpAsync(string tmpl, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileHandleExterns.g_file_new_tmp_async(tmpl, io_priority, cancellable, callback, user_data);
	}

	public static void NewTmpDirAsync(string tmpl, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileHandleExterns.g_file_new_tmp_dir_async(tmpl, io_priority, cancellable, callback, user_data);
	}

	public static MentorLake.Gio.GFileHandle NewTmpDirFinish(MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileHandleExterns.g_file_new_tmp_dir_finish(result, error);
	}

	public static MentorLake.Gio.GFileHandle NewTmpFinish(MentorLake.Gio.GAsyncResultHandle result, out MentorLake.Gio.GFileIOStreamHandle iostream, IntPtr error)
	{
		return GFileHandleExterns.g_file_new_tmp_finish(result, out iostream, error);
	}

	public static MentorLake.Gio.GFileHandle ParseName(string parse_name)
	{
		return GFileHandleExterns.g_file_parse_name(parse_name);
	}

}

internal class GFileHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_append_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_append_to_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_append_to_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_build_attribute_list_for_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCopyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_copy_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_copy_async_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle progress_callback_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle ready_callback_closure);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_copy_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_copy_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_create_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_create_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_create_readwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_create_readwrite_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_create_readwrite_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_delete_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_delete_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_dup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_eject_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_eject_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_eject_mountable_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_eject_mountable_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileEnumeratorHandle g_file_enumerate_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_enumerate_children_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileEnumeratorHandle g_file_enumerate_children_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file2);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMountHandle g_file_find_enclosing_mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_find_enclosing_mount_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMountHandle g_file_find_enclosing_mount_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_basename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_get_child_for_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string display_name, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_parse_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_relative_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle descendant);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_get_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_has_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle parent);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_has_prefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle prefix);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_has_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string uri_scheme);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_file_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_is_native([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_file_load_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out string etag_out, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_load_bytes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_file_load_bytes_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out string etag_out, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_load_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out byte[] contents, out UIntPtr length, out string etag_out, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_load_contents_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_load_contents_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out byte[] contents, out UIntPtr length, out string etag_out, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_load_partial_contents_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileReadMoreCallback read_more_callback, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_load_partial_contents_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out byte[] contents, out UIntPtr length, out string etag_out, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_make_directory_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_directory_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_directory_with_parents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_symbolic_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string symlink_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_make_symbolic_link_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string symlink_value, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_make_symbolic_link_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_measure_disk_usage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMeasureFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileMeasureProgressCallback progress_callback, IntPtr progress_data, out ulong disk_usage, out ulong num_dirs, out ulong num_files, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_measure_disk_usage_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMeasureFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileMeasureProgressCallback progress_callback, IntPtr progress_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_measure_disk_usage_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out ulong disk_usage, out ulong num_dirs, out ulong num_files, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileMonitorHandle g_file_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileMonitorHandle g_file_monitor_directory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileMonitorHandle g_file_monitor_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileMonitorFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_mount_enclosing_volume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location, MentorLake.Gio.GMountMountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_mount_enclosing_volume_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_mount_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountMountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_mount_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_move_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GFileProgressCallback progress_callback, IntPtr progress_callback_data, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_move_async_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle destination, MentorLake.Gio.GFileCopyFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle progress_callback_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle ready_callback_closure);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_move_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_open_readwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_open_readwrite_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_open_readwrite_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_peek_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_poll_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_poll_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_file_query_default_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_query_default_handler_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_file_query_default_handler_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_query_exists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileType g_file_query_file_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_query_filesystem_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_query_filesystem_info_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_query_filesystem_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_query_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_query_info_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attributes, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_query_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_query_settable_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_query_writable_namespaces([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInputStreamHandle g_file_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_read_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInputStreamHandle g_file_read_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_replace_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_replace_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, byte[] contents, UIntPtr length, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, out string new_etag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_replace_contents_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, byte[] contents, UIntPtr length, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_replace_contents_bytes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle contents, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_replace_contents_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out string new_etag, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileOutputStreamHandle g_file_replace_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_replace_readwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_replace_readwrite_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string etag, bool make_backup, MentorLake.Gio.GFileCreateFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileIOStreamHandle g_file_replace_readwrite_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_resolve_relative_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string relative_path);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, MentorLake.Gio.GFileAttributeType type, IntPtr value_p, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_byte_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, string value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, int value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, long value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, string value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, uint value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attribute_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string attribute, ulong value, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_set_attributes_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileQueryInfoFlags flags, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attributes_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] out MentorLake.Gio.GFileInfoHandle info, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_set_attributes_from_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileQueryInfoFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_set_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string display_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_set_display_name_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, string display_name, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_set_display_name_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_start_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GDriveStartFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle start_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_start_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_stop_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_stop_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_supports_thread_contexts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_trash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_trash_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_trash_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_unmount_mountable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_unmount_mountable_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_unmount_mountable_with_operation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.Gio.GMountUnmountFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_unmount_mountable_with_operation_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_build_filename(string first_element, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_build_filenamev(string[] args);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_commandline_arg(string arg);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_commandline_arg_and_cwd(string arg, string cwd);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_path(string path);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_uri(string uri);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp(string tmpl, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] out MentorLake.Gio.GFileIOStreamHandle iostream, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_new_tmp_async(string tmpl, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_new_tmp_dir_async(string tmpl, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp_dir_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] out MentorLake.Gio.GFileIOStreamHandle iostream, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_parse_name(string parse_name);

}
