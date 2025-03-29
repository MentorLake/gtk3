namespace MentorLake.Gio;

public class GioGlobalFunctions
{
	public static bool ActionNameIsValid(string action_name)
	{
		return GioGlobalFunctionsExterns.g_action_name_is_valid(action_name);
	}

	public static bool ActionParseDetailedName(string detailed_name, out string action_name, out MentorLake.GLib.GVariantHandle target_value)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_action_parse_detailed_name(detailed_name, out action_name, out target_value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ActionPrintDetailedName(string action_name, MentorLake.GLib.GVariantHandle target_value)
	{
		return GioGlobalFunctionsExterns.g_action_print_detailed_name(action_name, target_value);
	}

	public static MentorLake.Gio.GAppInfoHandle AppInfoCreateFromCommandline(string commandline, string application_name, MentorLake.Gio.GAppInfoCreateFlags flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_create_from_commandline(commandline, application_name, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GListHandle AppInfoGetAll()
	{
		return GioGlobalFunctionsExterns.g_app_info_get_all();
	}

	public static MentorLake.GLib.GListHandle AppInfoGetAllForType(string content_type)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_all_for_type(content_type);
	}

	public static MentorLake.Gio.GAppInfoHandle AppInfoGetDefaultForType(string content_type, bool must_support_uris)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_default_for_type(content_type, must_support_uris);
	}

	public static void AppInfoGetDefaultForTypeAsync(string content_type, bool must_support_uris, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_app_info_get_default_for_type_async(content_type, must_support_uris, cancellable, callback, user_data);
	}

	public static MentorLake.Gio.GAppInfoHandle AppInfoGetDefaultForTypeFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_get_default_for_type_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GAppInfoHandle AppInfoGetDefaultForUriScheme(string uri_scheme)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_default_for_uri_scheme(uri_scheme);
	}

	public static void AppInfoGetDefaultForUriSchemeAsync(string uri_scheme, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_app_info_get_default_for_uri_scheme_async(uri_scheme, cancellable, callback, user_data);
	}

	public static MentorLake.Gio.GAppInfoHandle AppInfoGetDefaultForUriSchemeFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_get_default_for_uri_scheme_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GListHandle AppInfoGetFallbackForType(string content_type)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_fallback_for_type(content_type);
	}

	public static MentorLake.GLib.GListHandle AppInfoGetRecommendedForType(string content_type)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_recommended_for_type(content_type);
	}

	public static bool AppInfoLaunchDefaultForUri(string uri, MentorLake.Gio.GAppLaunchContextHandle context)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_launch_default_for_uri(uri, context, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void AppInfoLaunchDefaultForUriAsync(string uri, MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_app_info_launch_default_for_uri_async(uri, context, cancellable, callback, user_data);
	}

	public static bool AppInfoLaunchDefaultForUriFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_launch_default_for_uri_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void AppInfoResetTypeAssociations(string content_type)
	{
		GioGlobalFunctionsExterns.g_app_info_reset_type_associations(content_type);
	}

	public static void AsyncInitableNewvAsync(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameterHandle parameters, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_async_initable_newv_async(object_type, n_parameters, parameters, io_priority, cancellable, callback, user_data);
	}

	public static void BusGet(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_bus_get(bus_type, cancellable, callback, user_data);
	}

	public static MentorLake.Gio.GDBusConnectionHandle BusGetFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_bus_get_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusConnectionHandle BusGetSync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_bus_get_sync(bus_type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint BusOwnName(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.Gio.GBusAcquiredCallback bus_acquired_handler, MentorLake.Gio.GBusNameAcquiredCallback name_acquired_handler, MentorLake.Gio.GBusNameLostCallback name_lost_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		return GioGlobalFunctionsExterns.g_bus_own_name(bus_type, name, flags, bus_acquired_handler, name_acquired_handler, name_lost_handler, user_data, user_data_free_func);
	}

	public static uint BusOwnNameOnConnection(MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.Gio.GBusNameAcquiredCallback name_acquired_handler, MentorLake.Gio.GBusNameLostCallback name_lost_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		return GioGlobalFunctionsExterns.g_bus_own_name_on_connection(connection, name, flags, name_acquired_handler, name_lost_handler, user_data, user_data_free_func);
	}

	public static uint BusOwnNameOnConnectionWithClosures(MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.GObject.GClosureHandle name_acquired_closure, MentorLake.GObject.GClosureHandle name_lost_closure)
	{
		return GioGlobalFunctionsExterns.g_bus_own_name_on_connection_with_closures(connection, name, flags, name_acquired_closure, name_lost_closure);
	}

	public static uint BusOwnNameWithClosures(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.GObject.GClosureHandle bus_acquired_closure, MentorLake.GObject.GClosureHandle name_acquired_closure, MentorLake.GObject.GClosureHandle name_lost_closure)
	{
		return GioGlobalFunctionsExterns.g_bus_own_name_with_closures(bus_type, name, flags, bus_acquired_closure, name_acquired_closure, name_lost_closure);
	}

	public static void BusUnownName(uint owner_id)
	{
		GioGlobalFunctionsExterns.g_bus_unown_name(owner_id);
	}

	public static void BusUnwatchName(uint watcher_id)
	{
		GioGlobalFunctionsExterns.g_bus_unwatch_name(watcher_id);
	}

	public static uint BusWatchName(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.Gio.GBusNameAppearedCallback name_appeared_handler, MentorLake.Gio.GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		return GioGlobalFunctionsExterns.g_bus_watch_name(bus_type, name, flags, name_appeared_handler, name_vanished_handler, user_data, user_data_free_func);
	}

	public static uint BusWatchNameOnConnection(MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.Gio.GBusNameAppearedCallback name_appeared_handler, MentorLake.Gio.GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		return GioGlobalFunctionsExterns.g_bus_watch_name_on_connection(connection, name, flags, name_appeared_handler, name_vanished_handler, user_data, user_data_free_func);
	}

	public static uint BusWatchNameOnConnectionWithClosures(MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.GObject.GClosureHandle name_appeared_closure, MentorLake.GObject.GClosureHandle name_vanished_closure)
	{
		return GioGlobalFunctionsExterns.g_bus_watch_name_on_connection_with_closures(connection, name, flags, name_appeared_closure, name_vanished_closure);
	}

	public static uint BusWatchNameWithClosures(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.GObject.GClosureHandle name_appeared_closure, MentorLake.GObject.GClosureHandle name_vanished_closure)
	{
		return GioGlobalFunctionsExterns.g_bus_watch_name_with_closures(bus_type, name, flags, name_appeared_closure, name_vanished_closure);
	}

	public static bool ContentTypeCanBeExecutable(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_can_be_executable(type);
	}

	public static bool ContentTypeEquals(string type1, string type2)
	{
		return GioGlobalFunctionsExterns.g_content_type_equals(type1, type2);
	}

	public static string ContentTypeFromMimeType(string mime_type)
	{
		return GioGlobalFunctionsExterns.g_content_type_from_mime_type(mime_type);
	}

	public static string ContentTypeGetDescription(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_description(type);
	}

	public static string ContentTypeGetGenericIconName(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_generic_icon_name(type);
	}

	public static MentorLake.Gio.GIconHandle ContentTypeGetIcon(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_icon(type);
	}

	public static string[] ContentTypeGetMimeDirs()
	{
		return GioGlobalFunctionsExterns.g_content_type_get_mime_dirs();
	}

	public static string ContentTypeGetMimeType(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_mime_type(type);
	}

	public static MentorLake.Gio.GIconHandle ContentTypeGetSymbolicIcon(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_symbolic_icon(type);
	}

	public static string ContentTypeGuess(string filename, char[] data, UIntPtr data_size, out bool result_uncertain)
	{
		return GioGlobalFunctionsExterns.g_content_type_guess(filename, data, data_size, out result_uncertain);
	}

	public static string[] ContentTypeGuessForTree(MentorLake.Gio.GFileHandle root)
	{
		return GioGlobalFunctionsExterns.g_content_type_guess_for_tree(root);
	}

	public static bool ContentTypeIsA(string type, string supertype)
	{
		return GioGlobalFunctionsExterns.g_content_type_is_a(type, supertype);
	}

	public static bool ContentTypeIsMimeType(string type, string mime_type)
	{
		return GioGlobalFunctionsExterns.g_content_type_is_mime_type(type, mime_type);
	}

	public static bool ContentTypeIsUnknown(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_is_unknown(type);
	}

	public static void ContentTypeSetMimeDirs(string[] dirs)
	{
		GioGlobalFunctionsExterns.g_content_type_set_mime_dirs(dirs);
	}

	public static MentorLake.GLib.GListHandle ContentTypesGetRegistered()
	{
		return GioGlobalFunctionsExterns.g_content_types_get_registered();
	}

	public static string DbusAddressEscapeValue(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_address_escape_value(@string);
	}

	public static string DbusAddressGetForBusSync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dbus_address_get_for_bus_sync(bus_type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void DbusAddressGetStream(string address, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_dbus_address_get_stream(address, cancellable, callback, user_data);
	}

	public static MentorLake.Gio.GIOStreamHandle DbusAddressGetStreamFinish(MentorLake.Gio.GAsyncResultHandle res, out string out_guid)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dbus_address_get_stream_finish(res, out out_guid, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GIOStreamHandle DbusAddressGetStreamSync(string address, out string out_guid, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dbus_address_get_stream_sync(address, out out_guid, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string DbusAnnotationInfoLookup(MentorLake.Gio.GDBusAnnotationInfoHandle[] annotations, string name)
	{
		return GioGlobalFunctionsExterns.g_dbus_annotation_info_lookup(annotations, name);
	}

	public static string DbusErrorEncodeGerror(MentorLake.GLib.GErrorHandle error)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_encode_gerror(error);
	}

	public static string DbusErrorGetRemoteError(MentorLake.GLib.GErrorHandle error)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_get_remote_error(error);
	}

	public static bool DbusErrorIsRemoteError(MentorLake.GLib.GErrorHandle error)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_is_remote_error(error);
	}

	public static MentorLake.GLib.GErrorHandle DbusErrorNewForDbusError(string dbus_error_name, string dbus_error_message)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_new_for_dbus_error(dbus_error_name, dbus_error_message);
	}

	public static MentorLake.GLib.GQuark DbusErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_dbus_error_quark();
	}

	public static bool DbusErrorRegisterError(MentorLake.GLib.GQuark error_domain, int error_code, string dbus_error_name)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_register_error(error_domain, error_code, dbus_error_name);
	}

	public static void DbusErrorRegisterErrorDomain(string error_domain_quark_name, UIntPtr quark_volatile, MentorLake.Gio.GDBusErrorEntry[] entries, uint num_entries)
	{
		GioGlobalFunctionsExterns.g_dbus_error_register_error_domain(error_domain_quark_name, quark_volatile, entries, num_entries);
	}

	public static bool DbusErrorStripRemoteError(MentorLake.GLib.GErrorHandle error)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_strip_remote_error(error);
	}

	public static bool DbusErrorUnregisterError(MentorLake.GLib.GQuark error_domain, int error_code, string dbus_error_name)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_unregister_error(error_domain, error_code, dbus_error_name);
	}

	public static string DbusEscapeObjectPath(string s)
	{
		return GioGlobalFunctionsExterns.g_dbus_escape_object_path(s);
	}

	public static string DbusEscapeObjectPathBytestring(byte[] bytes)
	{
		return GioGlobalFunctionsExterns.g_dbus_escape_object_path_bytestring(bytes);
	}

	public static string DbusGenerateGuid()
	{
		return GioGlobalFunctionsExterns.g_dbus_generate_guid();
	}

	public static MentorLake.GLib.GVariantHandle DbusGvalueToGvariant(MentorLake.GObject.GValueHandle gvalue, MentorLake.GLib.GVariantTypeHandle type)
	{
		return GioGlobalFunctionsExterns.g_dbus_gvalue_to_gvariant(gvalue, type);
	}

	public static void DbusGvariantToGvalue(MentorLake.GLib.GVariantHandle value, out MentorLake.GObject.GValue out_gvalue)
	{
		GioGlobalFunctionsExterns.g_dbus_gvariant_to_gvalue(value, out out_gvalue);
	}

	public static bool DbusIsAddress(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_address(@string);
	}

	public static bool DbusIsErrorName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_error_name(@string);
	}

	public static bool DbusIsGuid(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_guid(@string);
	}

	public static bool DbusIsInterfaceName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_interface_name(@string);
	}

	public static bool DbusIsMemberName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_member_name(@string);
	}

	public static bool DbusIsName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_name(@string);
	}

	public static bool DbusIsSupportedAddress(string @string)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dbus_is_supported_address(@string, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool DbusIsUniqueName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_unique_name(@string);
	}

	public static byte[] DbusUnescapeObjectPath(string s)
	{
		return GioGlobalFunctionsExterns.g_dbus_unescape_object_path(s);
	}

	public static MentorLake.Gio.GDatagramBasedHandle DtlsClientConnectionNew(MentorLake.Gio.GDatagramBasedHandle base_socket, MentorLake.Gio.GSocketConnectableHandle server_identity)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dtls_client_connection_new(base_socket, server_identity, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDatagramBasedHandle DtlsServerConnectionNew(MentorLake.Gio.GDatagramBasedHandle base_socket, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dtls_server_connection_new(base_socket, certificate, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GFileHandle FileNewBuildFilenamev(string[] args)
	{
		return GioGlobalFunctionsExterns.g_file_new_build_filenamev(args);
	}

	public static MentorLake.Gio.GFileHandle FileNewForCommandlineArg(string arg)
	{
		return GioGlobalFunctionsExterns.g_file_new_for_commandline_arg(arg);
	}

	public static MentorLake.Gio.GFileHandle FileNewForCommandlineArgAndCwd(string arg, string cwd)
	{
		return GioGlobalFunctionsExterns.g_file_new_for_commandline_arg_and_cwd(arg, cwd);
	}

	public static MentorLake.Gio.GFileHandle FileNewForPath(string path)
	{
		return GioGlobalFunctionsExterns.g_file_new_for_path(path);
	}

	public static MentorLake.Gio.GFileHandle FileNewForUri(string uri)
	{
		return GioGlobalFunctionsExterns.g_file_new_for_uri(uri);
	}

	public static MentorLake.Gio.GFileHandle FileNewTmp(string tmpl, out MentorLake.Gio.GFileIOStreamHandle iostream)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_file_new_tmp(tmpl, out iostream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void FileNewTmpAsync(string tmpl, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_file_new_tmp_async(tmpl, io_priority, cancellable, callback, user_data);
	}

	public static void FileNewTmpDirAsync(string tmpl, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_file_new_tmp_dir_async(tmpl, io_priority, cancellable, callback, user_data);
	}

	public static MentorLake.Gio.GFileHandle FileNewTmpDirFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_file_new_tmp_dir_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GFileHandle FileNewTmpFinish(MentorLake.Gio.GAsyncResultHandle result, out MentorLake.Gio.GFileIOStreamHandle iostream)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_file_new_tmp_finish(result, out iostream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GFileHandle FileParseName(string parse_name)
	{
		return GioGlobalFunctionsExterns.g_file_parse_name(parse_name);
	}

	public static MentorLake.Gio.GIconHandle IconDeserialize(MentorLake.GLib.GVariantHandle value)
	{
		return GioGlobalFunctionsExterns.g_icon_deserialize(value);
	}

	public static MentorLake.Gio.GIconHandle IconNewForString(string str)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_icon_new_for_string(str, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GObject.GObjectHandle InitableNewv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_initable_newv(object_type, n_parameters, parameters, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GIOErrorEnum IoErrorFromErrno(int err_no)
	{
		return GioGlobalFunctionsExterns.g_io_error_from_errno(err_no);
	}

	public static MentorLake.Gio.GIOErrorEnum IoErrorFromFileError(MentorLake.GLib.GFileError file_error)
	{
		return GioGlobalFunctionsExterns.g_io_error_from_file_error(file_error);
	}

	public static MentorLake.GLib.GQuark IoErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_io_error_quark();
	}

	public static MentorLake.Gio.GIOExtensionHandle IoExtensionPointImplement(string extension_point_name, MentorLake.GObject.GType type, string extension_name, int priority)
	{
		return GioGlobalFunctionsExterns.g_io_extension_point_implement(extension_point_name, type, extension_name, priority);
	}

	public static MentorLake.Gio.GIOExtensionPointHandle IoExtensionPointLookup(string name)
	{
		return GioGlobalFunctionsExterns.g_io_extension_point_lookup(name);
	}

	public static MentorLake.Gio.GIOExtensionPointHandle IoExtensionPointRegister(string name)
	{
		return GioGlobalFunctionsExterns.g_io_extension_point_register(name);
	}

	public static MentorLake.GLib.GListHandle IoModulesLoadAllInDirectory(string dirname)
	{
		return GioGlobalFunctionsExterns.g_io_modules_load_all_in_directory(dirname);
	}

	public static MentorLake.GLib.GListHandle IoModulesLoadAllInDirectoryWithScope(string dirname, MentorLake.Gio.GIOModuleScopeHandle scope)
	{
		return GioGlobalFunctionsExterns.g_io_modules_load_all_in_directory_with_scope(dirname, scope);
	}

	public static void IoModulesScanAllInDirectory(string dirname)
	{
		GioGlobalFunctionsExterns.g_io_modules_scan_all_in_directory(dirname);
	}

	public static void IoModulesScanAllInDirectoryWithScope(string dirname, MentorLake.Gio.GIOModuleScopeHandle scope)
	{
		GioGlobalFunctionsExterns.g_io_modules_scan_all_in_directory_with_scope(dirname, scope);
	}

	public static void IoSchedulerCancelAllJobs()
	{
		GioGlobalFunctionsExterns.g_io_scheduler_cancel_all_jobs();
	}

	public static void IoSchedulerPushJob(MentorLake.Gio.GIOSchedulerJobFunc job_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify, int io_priority, MentorLake.Gio.GCancellableHandle cancellable)
	{
		GioGlobalFunctionsExterns.g_io_scheduler_push_job(job_func, user_data, notify, io_priority, cancellable);
	}

	public static MentorLake.Gio.GSettingsBackendHandle KeyfileSettingsBackendNew(string filename, string root_path, string root_group)
	{
		return GioGlobalFunctionsExterns.g_keyfile_settings_backend_new(filename, root_path, root_group);
	}

	public static MentorLake.Gio.GMemoryMonitorHandle MemoryMonitorDupDefault()
	{
		return GioGlobalFunctionsExterns.g_memory_monitor_dup_default();
	}

	public static MentorLake.Gio.GSettingsBackendHandle MemorySettingsBackendNew()
	{
		return GioGlobalFunctionsExterns.g_memory_settings_backend_new();
	}

	public static MentorLake.Gio.GNetworkMonitorHandle NetworkMonitorGetDefault()
	{
		return GioGlobalFunctionsExterns.g_network_monitor_get_default();
	}

	public static void NetworkingInit()
	{
		GioGlobalFunctionsExterns.g_networking_init();
	}

	public static MentorLake.Gio.GSettingsBackendHandle NullSettingsBackendNew()
	{
		return GioGlobalFunctionsExterns.g_null_settings_backend_new();
	}

	public static MentorLake.GLib.GSourceHandle PollableSourceNew(MentorLake.GObject.GObjectHandle pollable_stream)
	{
		return GioGlobalFunctionsExterns.g_pollable_source_new(pollable_stream);
	}

	public static MentorLake.GLib.GSourceHandle PollableSourceNewFull(MentorLake.GObject.GObjectHandle pollable_stream, MentorLake.GLib.GSourceHandle child_source, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GioGlobalFunctionsExterns.g_pollable_source_new_full(pollable_stream, child_source, cancellable);
	}

	public static UIntPtr PollableStreamRead(MentorLake.Gio.GInputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_pollable_stream_read(stream, buffer, count, blocking, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr PollableStreamWrite(MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_pollable_stream_write(stream, buffer, count, blocking, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PollableStreamWriteAll(MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_pollable_stream_write_all(stream, buffer, count, blocking, out bytes_written, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GPowerProfileMonitorHandle PowerProfileMonitorDupDefault()
	{
		return GioGlobalFunctionsExterns.g_power_profile_monitor_dup_default();
	}

	public static MentorLake.Gio.GProxyHandle ProxyGetDefaultForProtocol(string protocol)
	{
		return GioGlobalFunctionsExterns.g_proxy_get_default_for_protocol(protocol);
	}

	public static MentorLake.Gio.GProxyResolverHandle ProxyResolverGetDefault()
	{
		return GioGlobalFunctionsExterns.g_proxy_resolver_get_default();
	}

	public static MentorLake.GLib.GQuark ResolverErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_resolver_error_quark();
	}

	public static MentorLake.GLib.GQuark ResourceErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_resource_error_quark();
	}

	public static MentorLake.Gio.GResourceHandle ResourceLoad(string filename)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resource_load(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string[] ResourcesEnumerateChildren(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resources_enumerate_children(path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool ResourcesGetInfo(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resources_get_info(path, lookup_flags, out size, out flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool ResourcesHasChildren(string path)
	{
		return GioGlobalFunctionsExterns.g_resources_has_children(path);
	}

	public static MentorLake.GLib.GBytesHandle ResourcesLookupData(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resources_lookup_data(path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GInputStreamHandle ResourcesOpenStream(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resources_open_stream(path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void ResourcesRegister(MentorLake.Gio.GResourceHandle resource)
	{
		GioGlobalFunctionsExterns.g_resources_register(resource);
	}

	public static void ResourcesUnregister(MentorLake.Gio.GResourceHandle resource)
	{
		GioGlobalFunctionsExterns.g_resources_unregister(resource);
	}

	public static MentorLake.Gio.GSettingsSchemaSourceHandle SettingsSchemaSourceGetDefault()
	{
		return GioGlobalFunctionsExterns.g_settings_schema_source_get_default();
	}

	public static void SimpleAsyncReportErrorInIdle(MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GioGlobalFunctionsExterns.g_simple_async_report_error_in_idle(@object, callback, user_data, domain, code, format, @__arglist);
	}

	public static void SimpleAsyncReportGerrorInIdle(MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GErrorHandle error)
	{
		GioGlobalFunctionsExterns.g_simple_async_report_gerror_in_idle(@object, callback, user_data, error);
	}

	public static void SimpleAsyncReportTakeGerrorInIdle(MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GErrorHandle error)
	{
		GioGlobalFunctionsExterns.g_simple_async_report_take_gerror_in_idle(@object, callback, user_data, error);
	}

	public static MentorLake.GLib.GListHandle SrvTargetListSort(MentorLake.GLib.GListHandle targets)
	{
		return GioGlobalFunctionsExterns.g_srv_target_list_sort(targets);
	}

	public static MentorLake.Gio.GTlsBackendHandle TlsBackendGetDefault()
	{
		return GioGlobalFunctionsExterns.g_tls_backend_get_default();
	}

	public static MentorLake.GLib.GQuark TlsChannelBindingErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_tls_channel_binding_error_quark();
	}

	public static MentorLake.Gio.GIOStreamHandle TlsClientConnectionNew(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GSocketConnectableHandle server_identity)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_tls_client_connection_new(base_io_stream, server_identity, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GQuark TlsErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_tls_error_quark();
	}

	public static MentorLake.Gio.GTlsDatabaseHandle TlsFileDatabaseNew(string anchors)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_tls_file_database_new(anchors, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GIOStreamHandle TlsServerConnectionNew(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_tls_server_connection_new(base_io_stream, certificate, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool UnixIsMountPathSystemInternal(string mount_path)
	{
		return GioGlobalFunctionsExterns.g_unix_is_mount_path_system_internal(mount_path);
	}

	public static bool UnixIsSystemDevicePath(string device_path)
	{
		return GioGlobalFunctionsExterns.g_unix_is_system_device_path(device_path);
	}

	public static bool UnixIsSystemFsType(string fs_type)
	{
		return GioGlobalFunctionsExterns.g_unix_is_system_fs_type(fs_type);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountAt(string mount_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_at(mount_path, out time_read);
	}

	public static int UnixMountCompare(MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_compare(mount1, mount2);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountCopy(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_copy(mount_entry);
	}

	public static bool UnixMountEntriesChangedSince(ulong time)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entries_changed_since(time);
	}

	public static MentorLake.GLib.GListHandle UnixMountEntriesGet(out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entries_get(out time_read);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle[] UnixMountEntriesGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_entries_out)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entries_get_from_file(table_path, out time_read_out, out n_entries_out);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountEntryAt(string mount_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entry_at(mount_path, out time_read);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountEntryFor(string file_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entry_for(file_path, out time_read);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountFor(string file_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_for(file_path, out time_read);
	}

	public static void UnixMountFree(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		GioGlobalFunctionsExterns.g_unix_mount_free(mount_entry);
	}

	public static string UnixMountGetDevicePath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_device_path(mount_entry);
	}

	public static string UnixMountGetFsType(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_fs_type(mount_entry);
	}

	public static string UnixMountGetMountPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_mount_path(mount_entry);
	}

	public static string UnixMountGetOptions(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_options(mount_entry);
	}

	public static string UnixMountGetRootPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_root_path(mount_entry);
	}

	public static bool UnixMountGuessCanEject(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_can_eject(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle UnixMountGuessIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_icon(mount_entry);
	}

	public static string UnixMountGuessName(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_name(mount_entry);
	}

	public static bool UnixMountGuessShouldDisplay(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_should_display(mount_entry);
	}

	public static MentorLake.Gio.GIconHandle UnixMountGuessSymbolicIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_symbolic_icon(mount_entry);
	}

	public static bool UnixMountIsReadonly(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_is_readonly(mount_entry);
	}

	public static bool UnixMountIsSystemInternal(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_is_system_internal(mount_entry);
	}

	public static MentorLake.Gio.GUnixMountPointHandle UnixMountPointAt(string mount_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_point_at(mount_path, out time_read);
	}

	public static bool UnixMountPointsChangedSince(ulong time)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_points_changed_since(time);
	}

	public static MentorLake.GLib.GListHandle UnixMountPointsGet(out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_points_get(out time_read);
	}

	public static MentorLake.Gio.GUnixMountPointHandle[] UnixMountPointsGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_points_out)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_points_get_from_file(table_path, out time_read_out, out n_points_out);
	}

	public static bool UnixMountsChangedSince(ulong time)
	{
		return GioGlobalFunctionsExterns.g_unix_mounts_changed_since(time);
	}

	public static MentorLake.GLib.GListHandle UnixMountsGet(out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mounts_get(out time_read);
	}

	public static MentorLake.Gio.GUnixMountEntryHandle[] UnixMountsGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_entries_out)
	{
		return GioGlobalFunctionsExterns.g_unix_mounts_get_from_file(table_path, out time_read_out, out n_entries_out);
	}

}

internal class GioGlobalFunctionsExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_name_is_valid(string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_parse_detailed_name(string detailed_name, out string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle target_value, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_action_print_detailed_name(string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target_value);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_create_from_commandline(string commandline, string application_name, MentorLake.Gio.GAppInfoCreateFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_all();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_all_for_type(string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_type(string content_type, bool must_support_uris);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_get_default_for_type_async(string content_type, bool must_support_uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_type_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_uri_scheme(string uri_scheme);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_get_default_for_uri_scheme_async(string uri_scheme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_uri_scheme_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_fallback_for_type(string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_recommended_for_type(string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch_default_for_uri(string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_launch_default_for_uri_async(string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch_default_for_uri_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_reset_type_associations(string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_newv_async(MentorLake.GObject.GType object_type, uint n_parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParameterHandle>))] MentorLake.GObject.GParameterHandle parameters, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_bus_get(MentorLake.Gio.GBusType bus_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_bus_get_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_bus_get_sync(MentorLake.Gio.GBusType bus_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_bus_own_name(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.Gio.GBusAcquiredCallback bus_acquired_handler, MentorLake.Gio.GBusNameAcquiredCallback name_acquired_handler, MentorLake.Gio.GBusNameLostCallback name_lost_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_bus_own_name_on_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.Gio.GBusNameAcquiredCallback name_acquired_handler, MentorLake.Gio.GBusNameLostCallback name_lost_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_bus_own_name_on_connection_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameOwnerFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle name_acquired_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle name_lost_closure);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_bus_own_name_with_closures(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameOwnerFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle bus_acquired_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle name_acquired_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle name_lost_closure);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_bus_unown_name(uint owner_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_bus_unwatch_name(uint watcher_id);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_bus_watch_name(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.Gio.GBusNameAppearedCallback name_appeared_handler, MentorLake.Gio.GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_bus_watch_name_on_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.Gio.GBusNameAppearedCallback name_appeared_handler, MentorLake.Gio.GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_bus_watch_name_on_connection_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameWatcherFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle name_appeared_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle name_vanished_closure);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_bus_watch_name_with_closures(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameWatcherFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle name_appeared_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle name_vanished_closure);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_content_type_can_be_executable(string type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_content_type_equals(string type1, string type2);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_content_type_from_mime_type(string mime_type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_content_type_get_description(string type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_content_type_get_generic_icon_name(string type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_content_type_get_icon(string type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_content_type_get_mime_dirs();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_content_type_get_mime_type(string type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_content_type_get_symbolic_icon(string type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_content_type_guess(string filename, char[] data, UIntPtr data_size, out bool result_uncertain);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_content_type_guess_for_tree([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle root);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_content_type_is_a(string type, string supertype);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_content_type_is_mime_type(string type, string mime_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_content_type_is_unknown(string type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_content_type_set_mime_dirs(string[] dirs);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_content_types_get_registered();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_address_escape_value(string @string);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_address_get_for_bus_sync(MentorLake.Gio.GBusType bus_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_address_get_stream(string address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOStreamHandle g_dbus_address_get_stream_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out string out_guid, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOStreamHandle g_dbus_address_get_stream_sync(string address, out string out_guid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_annotation_info_lookup([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAnnotationInfoHandle>))] MentorLake.Gio.GDBusAnnotationInfoHandle[] annotations, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_error_encode_gerror([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_error_get_remote_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_error_is_remote_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GErrorHandle g_dbus_error_new_for_dbus_error(string dbus_error_name, string dbus_error_message);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_dbus_error_quark();

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_error_register_error(MentorLake.GLib.GQuark error_domain, int error_code, string dbus_error_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_error_register_error_domain(string error_domain_quark_name, UIntPtr quark_volatile, MentorLake.Gio.GDBusErrorEntry[] entries, uint num_entries);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_error_strip_remote_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_error_unregister_error(MentorLake.GLib.GQuark error_domain, int error_code, string dbus_error_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_escape_object_path(string s);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_escape_object_path_bytestring(byte[] bytes);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_generate_guid();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_gvalue_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle gvalue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_gvariant_to_gvalue([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out MentorLake.GObject.GValue out_gvalue);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_is_address(string @string);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_is_error_name(string @string);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_is_guid(string @string);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_is_interface_name(string @string);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_is_member_name(string @string);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_is_name(string @string);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_is_supported_address(string @string, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_is_unique_name(string @string);

	[DllImport(GioLibrary.Name)]
	internal static extern byte[] g_dbus_unescape_object_path(string s);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDatagramBasedHandle g_dtls_client_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle base_socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle server_identity, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDatagramBasedHandle g_dtls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle base_socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.GLib.GErrorHandle error);

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
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp(string tmpl, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] out MentorLake.Gio.GFileIOStreamHandle iostream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_new_tmp_async(string tmpl, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_new_tmp_dir_async(string tmpl, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp_dir_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] out MentorLake.Gio.GFileIOStreamHandle iostream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_parse_name(string parse_name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_icon_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_icon_new_for_string(string str, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_initable_newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOErrorEnum g_io_error_from_errno(int err_no);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOErrorEnum g_io_error_from_file_error(MentorLake.GLib.GFileError file_error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_io_error_quark();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOExtensionHandle g_io_extension_point_implement(string extension_point_name, MentorLake.GObject.GType type, string extension_name, int priority);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOExtensionPointHandle g_io_extension_point_lookup(string name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOExtensionPointHandle g_io_extension_point_register(string name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_io_modules_load_all_in_directory(string dirname);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_io_modules_load_all_in_directory_with_scope(string dirname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleScopeHandle>))] MentorLake.Gio.GIOModuleScopeHandle scope);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_modules_scan_all_in_directory(string dirname);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_modules_scan_all_in_directory_with_scope(string dirname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleScopeHandle>))] MentorLake.Gio.GIOModuleScopeHandle scope);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_scheduler_cancel_all_jobs();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_scheduler_push_job(MentorLake.Gio.GIOSchedulerJobFunc job_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsBackendHandle g_keyfile_settings_backend_new(string filename, string root_path, string root_group);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMemoryMonitorHandle g_memory_monitor_dup_default();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsBackendHandle g_memory_settings_backend_new();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GNetworkMonitorHandle g_network_monitor_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_networking_init();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsBackendHandle g_null_settings_backend_new();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_pollable_source_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle pollable_stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_pollable_source_new_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle pollable_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle child_source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_pollable_stream_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_pollable_stream_write([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_stream_write_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GPowerProfileMonitorHandle g_power_profile_monitor_dup_default();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GProxyHandle g_proxy_get_default_for_protocol(string protocol);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GProxyResolverHandle g_proxy_resolver_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_resolver_error_quark();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_resource_error_quark();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GResourceHandle g_resource_load(string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_resources_enumerate_children(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_resources_get_info(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_resources_has_children(string path);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_resources_lookup_data(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInputStreamHandle g_resources_open_stream(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resources_register([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resources_unregister([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsSchemaSourceHandle g_settings_schema_source_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_report_error_in_idle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_report_gerror_in_idle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_report_take_gerror_in_idle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_srv_target_list_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle targets);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsBackendHandle g_tls_backend_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_tls_channel_binding_error_quark();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tls_client_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle server_identity, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_tls_error_quark();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_tls_file_database_new(string anchors, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_is_mount_path_system_internal(string mount_path);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_is_system_device_path(string device_path);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_is_system_fs_type(string fs_type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_at(string mount_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_mount_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount2);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_entries_changed_since(ulong time);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_unix_mount_entries_get(out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle[] g_unix_mount_entries_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_entries_out);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_at(string mount_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_for(string file_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_for(string file_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_mount_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_device_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_fs_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_mount_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_get_root_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_guess_can_eject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_guess_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_guess_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_guess_should_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_guess_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_is_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_is_system_internal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountPointHandle g_unix_mount_point_at(string mount_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_points_changed_since(ulong time);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_unix_mount_points_get(out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountPointHandle[] g_unix_mount_points_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_points_out);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mounts_changed_since(ulong time);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_unix_mounts_get(out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle[] g_unix_mounts_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_entries_out);

}
