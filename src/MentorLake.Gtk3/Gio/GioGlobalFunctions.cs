namespace MentorLake.Gtk3.Gio;

public class GioGlobalFunctions
{
	[DllImport(Libraries.Gio)]
	public static extern void g_simple_async_report_error_in_idle(GObjectHandle @object, GAsyncReadyCallback callback, IntPtr user_data, GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_is_system_fs_type(string fs_type);

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_mount_points_changed_since(ulong time);

	[DllImport(Libraries.Gio)]
	public static extern bool g_dbus_is_guid(string @string);

	[DllImport(Libraries.Gio)]
	public static extern GDBusConnectionHandle g_bus_get_sync(GBusType bus_type, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern bool g_content_type_can_be_executable(string type);

	[DllImport(Libraries.Gio)]
	public static extern void g_io_scheduler_cancel_all_jobs();

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_is_mount_path_system_internal(string mount_path);

	[DllImport(Libraries.Gio)]
	public static extern GSourceHandle g_pollable_source_new_full(GObjectHandle pollable_stream, GSourceHandle child_source, GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	public static extern string g_dbus_escape_object_path(string s);

	[DllImport(Libraries.Gio)]
	public static extern GIconHandle g_unix_mount_guess_icon(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern bool g_content_type_equals(string type1, string type2);

	[DllImport(Libraries.Gio)]
	public static extern bool g_content_type_is_unknown(string type);

	[DllImport(Libraries.Gio)]
	public static extern bool g_dbus_is_address(string @string);

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_mount_is_readonly(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern GIconHandle g_content_type_get_icon(string type);

	[DllImport(Libraries.Gio)]
	public static extern bool g_content_type_is_mime_type(string type, string mime_type);

	[DllImport(Libraries.Gio)]
	public static extern void g_bus_unwatch_name(uint watcher_id);

	[DllImport(Libraries.Gio)]
	public static extern void g_bus_get(GBusType bus_type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	public static extern GUnixMountEntryHandle g_unix_mount_copy(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern string g_dbus_address_escape_value(string @string);

	[DllImport(Libraries.Gio)]
	public static extern string g_content_type_get_mime_type(string type);

	[DllImport(Libraries.Gio)]
	public static extern bool g_resources_get_info(string path, GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern GVariantHandle g_dbus_gvalue_to_gvariant(GValueHandle gvalue, GVariantTypeHandle type);

	[DllImport(Libraries.Gio)]
	public static extern uint g_bus_watch_name(GBusType bus_type, string name, GBusNameWatcherFlags flags, GBusNameAppearedCallback name_appeared_handler, GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, GDestroyNotify user_data_free_func);

	[DllImport(Libraries.Gio)]
	public static extern GIOErrorEnum g_io_error_from_file_error(GFileError file_error);

	[DllImport(Libraries.Gio)]
	public static extern GIOErrorEnum g_io_error_from_errno(int err_no);

	[DllImport(Libraries.Gio)]
	public static extern int g_unix_mount_compare(GUnixMountEntryHandle mount1, GUnixMountEntryHandle mount2);

	[DllImport(Libraries.Gio)]
	public static extern IntPtr g_content_type_guess_for_tree(GFileHandle root);

	[DllImport(Libraries.Gio)]
	public static extern string g_dbus_address_get_for_bus_sync(GBusType bus_type, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	public static extern string g_unix_mount_get_root_path(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	public static extern string g_unix_mount_get_fs_type(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_mount_guess_can_eject(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern uint g_bus_own_name_with_closures(GBusType bus_type, string name, GBusNameOwnerFlags flags, GClosureHandle bus_acquired_closure, GClosureHandle name_acquired_closure, GClosureHandle name_lost_closure);

	[DllImport(Libraries.Gio)]
	public static extern void g_io_modules_scan_all_in_directory(string dirname);

	[DllImport(Libraries.Gio)]
	public static extern GUnixMountEntryHandle g_unix_mount_at(string mount_path, out ulong time_read);

	[DllImport(Libraries.Gio)]
	public static extern void g_unix_mount_free(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern bool g_dbus_is_error_name(string @string);

	[DllImport(Libraries.Gio)]
	public static extern void g_bus_unown_name(uint owner_id);

	[DllImport(Libraries.Gio)]
	public static extern string g_dbus_escape_object_path_bytestring(byte[] bytes);

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_mount_guess_should_display(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern string g_dbus_generate_guid();

	[DllImport(Libraries.Gio)]
	public static extern uint g_bus_watch_name_with_closures(GBusType bus_type, string name, GBusNameWatcherFlags flags, GClosureHandle name_appeared_closure, GClosureHandle name_vanished_closure);

	[DllImport(Libraries.Gio)]
	public static extern string g_unix_mount_guess_name(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern IntPtr g_dbus_unescape_object_path(string s);

	[DllImport(Libraries.Gio)]
	public static extern string g_content_type_get_description(string type);

	[DllImport(Libraries.Gio)]
	public static extern void g_networking_init();

	[DllImport(Libraries.Gio)]
	public static extern string g_content_type_guess(string filename, string data, UIntPtr data_size, out bool result_uncertain);

	[DllImport(Libraries.Gio)]
	public static extern GListHandle g_io_modules_load_all_in_directory(string dirname);

	[DllImport(Libraries.Gio)]
	public static extern GListHandle g_unix_mount_points_get(out ulong time_read);

	[DllImport(Libraries.Gio)]
	public static extern GDBusConnectionHandle g_bus_get_finish(GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern GIconHandle g_unix_mount_guess_symbolic_icon(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_is_system_device_path(string device_path);

	[DllImport(Libraries.Gio)]
	public static extern GQuark g_io_error_quark();

	[DllImport(Libraries.Gio)]
	public static extern bool g_dbus_is_interface_name(string @string);

	[DllImport(Libraries.Gio)]
	public static extern void g_io_scheduler_push_job(GIOSchedulerJobFunc job_func, IntPtr user_data, GDestroyNotify notify, int io_priority, GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	public static extern void g_io_modules_scan_all_in_directory_with_scope(string dirname, GIOModuleScopeHandle scope);

	[DllImport(Libraries.Gio)]
	public static extern GIconHandle g_content_type_get_symbolic_icon(string type);

	[DllImport(Libraries.Gio)]
	public static extern void g_dbus_gvariant_to_gvalue(GVariantHandle value, out GValue out_gvalue);

	[DllImport(Libraries.Gio)]
	public static extern uint g_bus_own_name(GBusType bus_type, string name, GBusNameOwnerFlags flags, GBusAcquiredCallback bus_acquired_handler, GBusNameAcquiredCallback name_acquired_handler, GBusNameLostCallback name_lost_handler, IntPtr user_data, GDestroyNotify user_data_free_func);

	[DllImport(Libraries.Gio)]
	public static extern bool g_content_type_is_a(string type, string supertype);

	[DllImport(Libraries.Gio)]
	public static extern GSettingsBackendHandle g_memory_settings_backend_new();

	[DllImport(Libraries.Gio)]
	public static extern GIOStreamHandle g_dbus_address_get_stream_finish(GAsyncResultHandle res, out string out_guid, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern bool g_dbus_is_unique_name(string @string);

	[DllImport(Libraries.Gio)]
	public static extern GBytesHandle g_resources_lookup_data(string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern void g_simple_async_report_take_gerror_in_idle(GObjectHandle @object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_mounts_changed_since(ulong time);

	[DllImport(Libraries.Gio)]
	public static extern GListHandle g_io_modules_load_all_in_directory_with_scope(string dirname, GIOModuleScopeHandle scope);

	[DllImport(Libraries.Gio)]
	public static extern bool g_dbus_is_name(string @string);

	[DllImport(Libraries.Gio)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	public static extern string g_unix_mount_get_mount_path(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern void g_content_type_set_mime_dirs(string dirs);

	[DllImport(Libraries.Gio)]
	public static extern GListHandle g_unix_mounts_get(out ulong time_read);

	[DllImport(Libraries.Gio)]
	public static extern GIOStreamHandle g_dbus_address_get_stream_sync(string address, out string out_guid, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern string g_content_type_from_mime_type(string mime_type);

	[DllImport(Libraries.Gio)]
	public static extern bool g_dbus_is_member_name(string @string);

	[DllImport(Libraries.Gio)]
	public static extern GSettingsBackendHandle g_keyfile_settings_backend_new(string filename, string root_path, string root_group);

	[DllImport(Libraries.Gio)]
	public static extern GSettingsBackendHandle g_null_settings_backend_new();

	[DllImport(Libraries.Gio)]
	public static extern bool g_dbus_is_supported_address(string @string, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	public static extern string g_unix_mount_get_options(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern void g_dbus_address_get_stream(string address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	public static extern GInputStreamHandle g_resources_open_stream(string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern string g_content_type_get_generic_icon_name(string type);

	[DllImport(Libraries.Gio)]
	public static extern GListHandle g_content_types_get_registered();

	[DllImport(Libraries.Gio)]
	public static extern bool g_unix_mount_is_system_internal(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern IntPtr g_resources_enumerate_children(string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern void g_simple_async_report_gerror_in_idle(GObjectHandle @object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	public static extern GUnixMountEntryHandle g_unix_mount_for(string file_path, out ulong time_read);

	[DllImport(Libraries.Gio)]
	public static extern GSourceHandle g_pollable_source_new(GObjectHandle pollable_stream);

	[DllImport(Libraries.Gio)]
	public static extern void g_resources_register(GResourceHandle resource);

	[DllImport(Libraries.Gio)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	public static extern string g_unix_mount_get_device_path(GUnixMountEntryHandle mount_entry);

	[DllImport(Libraries.Gio)]
	public static extern IntPtr g_content_type_get_mime_dirs();

	[DllImport(Libraries.Gio)]
	public static extern void g_resources_unregister(GResourceHandle resource);

}
