namespace MentorLake.Gio;

/// <summary>
/// <para>
/// An interface for writing VFS file handles.
/// </para>
/// </summary>

public class GFileIfaceHandle : BaseSafeHandle
{
}


public static class GFileIfaceExtensions
{

	public static GFileIface Dereference(this GFileIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileIface>(x.DangerousGetHandle());
}
internal class GFileIfaceExterns
{
}

/// <summary>
/// <para>
/// An interface for writing VFS file handles.
/// </para>
/// </summary>

public struct GFileIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Duplicates a #GFile.
/// </para>
/// </summary>

public IntPtr dup;
	/// <summary>
/// <para>
/// Creates a hash of a #GFile.
/// </para>
/// </summary>

public IntPtr hash;
	/// <summary>
/// <para>
/// Checks equality of two given #GFiles.
/// </para>
/// </summary>

public IntPtr equal;
	/// <summary>
/// <para>
/// Checks to see if a file is native to the system.
/// </para>
/// </summary>

public IntPtr is_native;
	/// <summary>
/// <para>
/// Checks to see if a #GFile has a given URI scheme.
/// </para>
/// </summary>

public IntPtr has_uri_scheme;
	/// <summary>
/// <para>
/// Gets the URI scheme for a #GFile.
/// </para>
/// </summary>

public IntPtr get_uri_scheme;
	/// <summary>
/// <para>
/// Gets the basename for a given #GFile.
/// </para>
/// </summary>

public IntPtr get_basename;
	/// <summary>
/// <para>
/// Gets the current path within a #GFile.
/// </para>
/// </summary>

public IntPtr get_path;
	/// <summary>
/// <para>
/// Gets a URI for the path within a #GFile.
/// </para>
/// </summary>

public IntPtr get_uri;
	/// <summary>
/// <para>
/// Gets the parsed name for the #GFile.
/// </para>
/// </summary>

public IntPtr get_parse_name;
	/// <summary>
/// <para>
/// Gets the parent directory for the #GFile.
/// </para>
/// </summary>

public IntPtr get_parent;
	/// <summary>
/// <para>
/// Checks whether a #GFile contains a specified file.
/// </para>
/// </summary>

public IntPtr prefix_matches;
	/// <summary>
/// <para>
/// Gets the path for a #GFile relative to a given path.
/// </para>
/// </summary>

public IntPtr get_relative_path;
	/// <summary>
/// <para>
/// Resolves a relative path for a #GFile to an absolute path.
/// </para>
/// </summary>

public IntPtr resolve_relative_path;
	/// <summary>
/// <para>
/// Gets the child #GFile for a given display name.
/// </para>
/// </summary>

public IntPtr get_child_for_display_name;
	/// <summary>
/// <para>
/// Gets a #GFileEnumerator with the children of a #GFile.
/// </para>
/// </summary>

public IntPtr enumerate_children;
	/// <summary>
/// <para>
/// Asynchronously gets a #GFileEnumerator with the children of a #GFile.
/// </para>
/// </summary>

public IntPtr enumerate_children_async;
	/// <summary>
/// <para>
/// Finishes asynchronously enumerating the children.
/// </para>
/// </summary>

public IntPtr enumerate_children_finish;
	/// <summary>
/// <para>
/// Gets the #GFileInfo for a #GFile.
/// </para>
/// </summary>

public IntPtr query_info;
	/// <summary>
/// <para>
/// Asynchronously gets the #GFileInfo for a #GFile.
/// </para>
/// </summary>

public IntPtr query_info_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous query info operation.
/// </para>
/// </summary>

public IntPtr query_info_finish;
	/// <summary>
/// <para>
/// Gets a #GFileInfo for the file system #GFile is on.
/// </para>
/// </summary>

public IntPtr query_filesystem_info;
	/// <summary>
/// <para>
/// Asynchronously gets a #GFileInfo for the file system #GFile is on.
/// </para>
/// </summary>

public IntPtr query_filesystem_info_async;
	/// <summary>
/// <para>
/// Finishes asynchronously getting the file system info.
/// </para>
/// </summary>

public IntPtr query_filesystem_info_finish;
	/// <summary>
/// <para>
/// Gets a #GMount for the #GFile.
/// </para>
/// </summary>

public IntPtr find_enclosing_mount;
	/// <summary>
/// <para>
/// Asynchronously gets the #GMount for a #GFile.
/// </para>
/// </summary>

public IntPtr find_enclosing_mount_async;
	/// <summary>
/// <para>
/// Finishes asynchronously getting the volume.
/// </para>
/// </summary>

public IntPtr find_enclosing_mount_finish;
	/// <summary>
/// <para>
/// Sets the display name for a #GFile.
/// </para>
/// </summary>

public IntPtr set_display_name;
	/// <summary>
/// <para>
/// Asynchronously sets a #GFile&apos;s display name.
/// </para>
/// </summary>

public IntPtr set_display_name_async;
	/// <summary>
/// <para>
/// Finishes asynchronously setting a #GFile&apos;s display name.
/// </para>
/// </summary>

public IntPtr set_display_name_finish;
	/// <summary>
/// <para>
/// Returns a list of #GFileAttributeInfos that can be set.
/// </para>
/// </summary>

public IntPtr query_settable_attributes;
	/// <summary>
/// <para>
/// Asynchronously gets a list of #GFileAttributeInfos that can be set.
/// </para>
/// </summary>

public IntPtr _query_settable_attributes_async;
	/// <summary>
/// <para>
/// Finishes asynchronously querying settable attributes.
/// </para>
/// </summary>

public IntPtr _query_settable_attributes_finish;
	/// <summary>
/// <para>
/// Returns a list of #GFileAttributeInfo namespaces that are writable.
/// </para>
/// </summary>

public IntPtr query_writable_namespaces;
	/// <summary>
/// <para>
/// Asynchronously gets a list of #GFileAttributeInfo namespaces that are writable.
/// </para>
/// </summary>

public IntPtr _query_writable_namespaces_async;
	/// <summary>
/// <para>
/// Finishes asynchronously querying the writable namespaces.
/// </para>
/// </summary>

public IntPtr _query_writable_namespaces_finish;
	/// <summary>
/// <para>
/// Sets a #GFileAttributeInfo.
/// </para>
/// </summary>

public IntPtr set_attribute;
	/// <summary>
/// <para>
/// Sets a #GFileAttributeInfo with information from a #GFileInfo.
/// </para>
/// </summary>

public IntPtr set_attributes_from_info;
	/// <summary>
/// <para>
/// Asynchronously sets a file&apos;s attributes.
/// </para>
/// </summary>

public IntPtr set_attributes_async;
	/// <summary>
/// <para>
/// Finishes setting a file&apos;s attributes asynchronously.
/// </para>
/// </summary>

public IntPtr set_attributes_finish;
	/// <summary>
/// <para>
/// Reads a file asynchronously.
/// </para>
/// </summary>

public IntPtr read_fn;
	/// <summary>
/// <para>
/// Asynchronously reads a file.
/// </para>
/// </summary>

public IntPtr read_async;
	/// <summary>
/// <para>
/// Finishes asynchronously reading a file.
/// </para>
/// </summary>

public IntPtr read_finish;
	/// <summary>
/// <para>
/// Writes to the end of a file.
/// </para>
/// </summary>

public IntPtr append_to;
	/// <summary>
/// <para>
/// Asynchronously writes to the end of a file.
/// </para>
/// </summary>

public IntPtr append_to_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous file append operation.
/// </para>
/// </summary>

public IntPtr append_to_finish;
	/// <summary>
/// <para>
/// Creates a new file.
/// </para>
/// </summary>

public IntPtr create;
	/// <summary>
/// <para>
/// Asynchronously creates a file.
/// </para>
/// </summary>

public IntPtr create_async;
	/// <summary>
/// <para>
/// Finishes asynchronously creating a file.
/// </para>
/// </summary>

public IntPtr create_finish;
	/// <summary>
/// <para>
/// Replaces the contents of a file.
/// </para>
/// </summary>

public IntPtr replace;
	/// <summary>
/// <para>
/// Asynchronously replaces the contents of a file.
/// </para>
/// </summary>

public IntPtr replace_async;
	/// <summary>
/// <para>
/// Finishes asynchronously replacing a file.
/// </para>
/// </summary>

public IntPtr replace_finish;
	/// <summary>
/// <para>
/// Deletes a file.
/// </para>
/// </summary>

public IntPtr delete_file;
	/// <summary>
/// <para>
/// Asynchronously deletes a file.
/// </para>
/// </summary>

public IntPtr delete_file_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous delete.
/// </para>
/// </summary>

public IntPtr delete_file_finish;
	/// <summary>
/// <para>
/// Sends a #GFile to the Trash location.
/// </para>
/// </summary>

public IntPtr trash;
	/// <summary>
/// <para>
/// Asynchronously sends a #GFile to the Trash location.
/// </para>
/// </summary>

public IntPtr trash_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous file trashing operation.
/// </para>
/// </summary>

public IntPtr trash_finish;
	/// <summary>
/// <para>
/// Makes a directory.
/// </para>
/// </summary>

public IntPtr make_directory;
	/// <summary>
/// <para>
/// Asynchronously makes a directory.
/// </para>
/// </summary>

public IntPtr make_directory_async;
	/// <summary>
/// <para>
/// Finishes making a directory asynchronously.
/// </para>
/// </summary>

public IntPtr make_directory_finish;
	/// <summary>
/// <para>
/// Makes a symbolic link. %NULL if symbolic
///    links are unsupported.
/// </para>
/// </summary>

public IntPtr make_symbolic_link;
	/// <summary>
/// <para>
/// Asynchronously makes a symbolic link
/// </para>
/// </summary>

public IntPtr make_symbolic_link_async;
	/// <summary>
/// <para>
/// Finishes making a symbolic link asynchronously.
/// </para>
/// </summary>

public IntPtr make_symbolic_link_finish;
	/// <summary>
/// <para>
/// Copies a file. %NULL if copying is unsupported, which will
///     cause `GFile` to use a fallback copy method where it reads from the
///     source and writes to the destination.
/// </para>
/// </summary>

public IntPtr copy;
	/// <summary>
/// <para>
/// Asynchronously copies a file.
/// </para>
/// </summary>

public IntPtr copy_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous copy operation.
/// </para>
/// </summary>

public IntPtr copy_finish;
	/// <summary>
/// <para>
/// Moves a file.
/// </para>
/// </summary>

public IntPtr move;
	/// <summary>
/// <para>
/// Asynchronously moves a file. Since: 2.72
/// </para>
/// </summary>

public IntPtr move_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous move operation. Since: 2.72
/// </para>
/// </summary>

public IntPtr move_finish;
	/// <summary>
/// <para>
/// Mounts a mountable object.
/// </para>
/// </summary>

public IntPtr mount_mountable;
	/// <summary>
/// <para>
/// Finishes a mounting operation.
/// </para>
/// </summary>

public IntPtr mount_mountable_finish;
	/// <summary>
/// <para>
/// Unmounts a mountable object.
/// </para>
/// </summary>

public IntPtr unmount_mountable;
	/// <summary>
/// <para>
/// Finishes an unmount operation.
/// </para>
/// </summary>

public IntPtr unmount_mountable_finish;
	/// <summary>
/// <para>
/// Ejects a mountable.
/// </para>
/// </summary>

public IntPtr eject_mountable;
	/// <summary>
/// <para>
/// Finishes an eject operation.
/// </para>
/// </summary>

public IntPtr eject_mountable_finish;
	/// <summary>
/// <para>
/// Mounts a specified location.
/// </para>
/// </summary>

public IntPtr mount_enclosing_volume;
	/// <summary>
/// <para>
/// Finishes mounting a specified location.
/// </para>
/// </summary>

public IntPtr mount_enclosing_volume_finish;
	/// <summary>
/// <para>
/// Creates a #GFileMonitor for the location.
/// </para>
/// </summary>

public IntPtr monitor_dir;
	/// <summary>
/// <para>
/// Creates a #GFileMonitor for the location.
/// </para>
/// </summary>

public IntPtr monitor_file;
	/// <summary>
/// <para>
/// Open file read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr open_readwrite;
	/// <summary>
/// <para>
/// Asynchronously opens file read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr open_readwrite_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous open read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr open_readwrite_finish;
	/// <summary>
/// <para>
/// Creates file read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr create_readwrite;
	/// <summary>
/// <para>
/// Asynchronously creates file read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr create_readwrite_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous creates read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr create_readwrite_finish;
	/// <summary>
/// <para>
/// Replaces file read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr replace_readwrite;
	/// <summary>
/// <para>
/// Asynchronously replaces file read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr replace_readwrite_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous replace read/write. Since 2.22.
/// </para>
/// </summary>

public IntPtr replace_readwrite_finish;
	/// <summary>
/// <para>
/// Starts a mountable object. Since 2.22.
/// </para>
/// </summary>

public IntPtr start_mountable;
	/// <summary>
/// <para>
/// Finishes a start operation. Since 2.22.
/// </para>
/// </summary>

public IntPtr start_mountable_finish;
	/// <summary>
/// <para>
/// Stops a mountable. Since 2.22.
/// </para>
/// </summary>

public IntPtr stop_mountable;
	/// <summary>
/// <para>
/// Finishes a stop operation. Since 2.22.
/// </para>
/// </summary>

public IntPtr stop_mountable_finish;
	/// <summary>
/// <para>
/// a boolean that indicates whether the #GFile implementation supports thread-default contexts. Since 2.22.
/// </para>
/// </summary>

public bool supports_thread_contexts;
	/// <summary>
/// <para>
/// Unmounts a mountable object using a #GMountOperation. Since 2.22.
/// </para>
/// </summary>

public IntPtr unmount_mountable_with_operation;
	/// <summary>
/// <para>
/// Finishes an unmount operation using a #GMountOperation. Since 2.22.
/// </para>
/// </summary>

public IntPtr unmount_mountable_with_operation_finish;
	/// <summary>
/// <para>
/// Ejects a mountable object using a #GMountOperation. Since 2.22.
/// </para>
/// </summary>

public IntPtr eject_mountable_with_operation;
	/// <summary>
/// <para>
/// Finishes an eject operation using a #GMountOperation. Since 2.22.
/// </para>
/// </summary>

public IntPtr eject_mountable_with_operation_finish;
	/// <summary>
/// <para>
/// Polls a mountable object for media changes. Since 2.22.
/// </para>
/// </summary>

public IntPtr poll_mountable;
	/// <summary>
/// <para>
/// Finishes a poll operation for media changes. Since 2.22.
/// </para>
/// </summary>

public IntPtr poll_mountable_finish;
	/// <summary>
/// <para>
/// Recursively measures the disk usage of @file. Since 2.38
/// </para>
/// </summary>

public IntPtr measure_disk_usage;
	/// <summary>
/// <para>
/// Asynchronously recursively measures the disk usage of @file. Since 2.38
/// </para>
/// </summary>

public IntPtr measure_disk_usage_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous recursive measurement of the disk usage of @file. Since 2.38
/// </para>
/// </summary>

public IntPtr measure_disk_usage_finish;
	/// <summary>
/// <para>
/// Queries whether a file exists. Since 2.84
/// </para>
/// </summary>

public IntPtr query_exists;
}
