namespace MentorLake.Gio;

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

public struct GFileIface
{
	public GTypeInterface g_iface;
	public IntPtr dup;
	public IntPtr hash;
	public IntPtr equal;
	public IntPtr is_native;
	public IntPtr has_uri_scheme;
	public IntPtr get_uri_scheme;
	public IntPtr get_basename;
	public IntPtr get_path;
	public IntPtr get_uri;
	public IntPtr get_parse_name;
	public IntPtr get_parent;
	public IntPtr prefix_matches;
	public IntPtr get_relative_path;
	public IntPtr resolve_relative_path;
	public IntPtr get_child_for_display_name;
	public IntPtr enumerate_children;
	public IntPtr enumerate_children_async;
	public IntPtr enumerate_children_finish;
	public IntPtr query_info;
	public IntPtr query_info_async;
	public IntPtr query_info_finish;
	public IntPtr query_filesystem_info;
	public IntPtr query_filesystem_info_async;
	public IntPtr query_filesystem_info_finish;
	public IntPtr find_enclosing_mount;
	public IntPtr find_enclosing_mount_async;
	public IntPtr find_enclosing_mount_finish;
	public IntPtr set_display_name;
	public IntPtr set_display_name_async;
	public IntPtr set_display_name_finish;
	public IntPtr query_settable_attributes;
	public IntPtr _query_settable_attributes_async;
	public IntPtr _query_settable_attributes_finish;
	public IntPtr query_writable_namespaces;
	public IntPtr _query_writable_namespaces_async;
	public IntPtr _query_writable_namespaces_finish;
	public IntPtr set_attribute;
	public IntPtr set_attributes_from_info;
	public IntPtr set_attributes_async;
	public IntPtr set_attributes_finish;
	public IntPtr read_fn;
	public IntPtr read_async;
	public IntPtr read_finish;
	public IntPtr append_to;
	public IntPtr append_to_async;
	public IntPtr append_to_finish;
	public IntPtr create;
	public IntPtr create_async;
	public IntPtr create_finish;
	public IntPtr replace;
	public IntPtr replace_async;
	public IntPtr replace_finish;
	public IntPtr delete_file;
	public IntPtr delete_file_async;
	public IntPtr delete_file_finish;
	public IntPtr trash;
	public IntPtr trash_async;
	public IntPtr trash_finish;
	public IntPtr make_directory;
	public IntPtr make_directory_async;
	public IntPtr make_directory_finish;
	public IntPtr make_symbolic_link;
	public IntPtr make_symbolic_link_async;
	public IntPtr make_symbolic_link_finish;
	public IntPtr copy;
	public IntPtr copy_async;
	public IntPtr copy_finish;
	public IntPtr move;
	public IntPtr move_async;
	public IntPtr move_finish;
	public IntPtr mount_mountable;
	public IntPtr mount_mountable_finish;
	public IntPtr unmount_mountable;
	public IntPtr unmount_mountable_finish;
	public IntPtr eject_mountable;
	public IntPtr eject_mountable_finish;
	public IntPtr mount_enclosing_volume;
	public IntPtr mount_enclosing_volume_finish;
	public IntPtr monitor_dir;
	public IntPtr monitor_file;
	public IntPtr open_readwrite;
	public IntPtr open_readwrite_async;
	public IntPtr open_readwrite_finish;
	public IntPtr create_readwrite;
	public IntPtr create_readwrite_async;
	public IntPtr create_readwrite_finish;
	public IntPtr replace_readwrite;
	public IntPtr replace_readwrite_async;
	public IntPtr replace_readwrite_finish;
	public IntPtr start_mountable;
	public IntPtr start_mountable_finish;
	public IntPtr stop_mountable;
	public IntPtr stop_mountable_finish;
	public bool supports_thread_contexts;
	public IntPtr unmount_mountable_with_operation;
	public IntPtr unmount_mountable_with_operation_finish;
	public IntPtr eject_mountable_with_operation;
	public IntPtr eject_mountable_with_operation_finish;
	public IntPtr poll_mountable;
	public IntPtr poll_mountable_finish;
	public IntPtr measure_disk_usage;
	public IntPtr measure_disk_usage_async;
	public IntPtr measure_disk_usage_finish;
	public IntPtr query_exists;
}
