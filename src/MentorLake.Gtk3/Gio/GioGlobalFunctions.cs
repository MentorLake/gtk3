namespace MentorLake.Gio;

public class GioGlobalFunctions
{
/// <summary>
/// <para>
/// Checks if @action_name is valid.
/// </para>
/// <para>
/// @action_name is valid if it consists only of alphanumeric characters,
/// plus `-` and `.`.  The empty string is not a valid action name.
/// </para>
/// <para>
/// It is an error to call this function with a non-UTF-8 @action_name.
/// @action_name must not be `NULL`.
/// </para>
/// </summary>

/// <param name="action_name">
/// a potential action name
/// </param>
/// <return>
/// `TRUE` if @action_name is valid
/// </return>

	public static bool ActionNameIsValid(string action_name)
	{
		return GioGlobalFunctionsExterns.g_action_name_is_valid(action_name);
	}

/// <summary>
/// <para>
/// Parses a detailed action name into its separate name and target
/// components.
/// </para>
/// <para>
/// Detailed action names can have three formats.
/// </para>
/// <para>
/// The first format is used to represent an action name with no target
/// value and consists of just an action name containing no whitespace
/// nor the characters `:`, `(` or `)`.  For example: `app.action`.
/// </para>
/// <para>
/// The second format is used to represent an action with a target value
/// that is a non-empty string consisting only of alphanumerics, plus `-`
/// and `.`.  In that case, the action name and target value are
/// separated by a double colon (`::`).  For example:
/// `app.action::target`.
/// </para>
/// <para>
/// The third format is used to represent an action with any type of
/// target value, including strings.  The target value follows the action
/// name, surrounded in parens.  For example: `app.action(42)`.  The
/// target value is parsed using [func@GLib.Variant.parse].  If a tuple-typed
/// value is desired, it must be specified in the same way, resulting in
/// two sets of parens, for example: `app.action((1,2,3))`.  A string
/// target can be specified this way as well: `app.action(&apos;target&apos;)`.
/// For strings, this third format must be used if target value is
/// empty or contains characters other than alphanumerics, `-` and `.`.
/// </para>
/// <para>
/// If this function returns `TRUE`, a non-`NULL` value is guaranteed to be returned
/// in @action_name (if a pointer is passed in). A `NULL` value may still be
/// returned in @target_value, as the @detailed_name may not contain a target.
/// </para>
/// <para>
/// If returned, the [type@GLib.Variant] in @target_value is guaranteed to not be floating.
/// </para>
/// </summary>

/// <param name="detailed_name">
/// a detailed action name
/// </param>
/// <param name="action_name">
/// the action name
/// </param>
/// <param name="target_value">
/// the target value,
///   or `NULL` for no target
/// </param>
/// <return>
/// `TRUE` if successful, else `FALSE` with @error set
/// </return>

	public static bool ActionParseDetailedName(string detailed_name, out string action_name, out MentorLake.GLib.GVariantHandle target_value)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_action_parse_detailed_name(detailed_name, out action_name, out target_value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Formats a detailed action name from @action_name and @target_value.
/// </para>
/// <para>
/// It is an error to call this function with an invalid action name.
/// </para>
/// <para>
/// This function is the opposite of [func@Gio.Action.parse_detailed_name].
/// It will produce a string that can be parsed back to the @action_name
/// and @target_value by that function.
/// </para>
/// <para>
/// See that function for the types of strings that will be printed by
/// this function.
/// </para>
/// </summary>

/// <param name="action_name">
/// a valid action name
/// </param>
/// <param name="target_value">
/// a [type@GLib.Variant] target value, or `NULL`
/// </param>
/// <return>
/// a detailed format string
/// </return>

	public static string ActionPrintDetailedName(string action_name, MentorLake.GLib.GVariantHandle target_value)
	{
		return GioGlobalFunctionsExterns.g_action_print_detailed_name(action_name, target_value);
	}

/// <summary>
/// <para>
/// Creates a new [iface@Gio.AppInfo] from the given information.
/// </para>
/// <para>
/// Note that for @commandline, the quoting rules of the `Exec` key of the
/// [freedesktop.org Desktop Entry Specification](http://freedesktop.org/Standards/desktop-entry-spec)
/// are applied. For example, if the @commandline contains
/// percent-encoded URIs, the percent-character must be doubled in order to prevent it from
/// being swallowed by `Exec` key unquoting. See
/// [the specification](https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s07.html)
/// for exact quoting rules.
/// </para>
/// </summary>

/// <param name="commandline">
/// the command line to use
/// </param>
/// <param name="application_name">
/// the application name, or `NULL` to use @commandline
/// </param>
/// <param name="flags">
/// flags that can specify details of the created [iface@Gio.AppInfo]
/// </param>
/// <return>
/// new [iface@Gio.AppInfo] for given command.
/// </return>

	public static MentorLake.Gio.GAppInfoHandle AppInfoCreateFromCommandline(string commandline, string application_name, MentorLake.Gio.GAppInfoCreateFlags flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_create_from_commandline(commandline, application_name, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets a list of all of the applications currently registered
/// on this system.
/// </para>
/// <para>
/// For desktop files, this includes applications that have
/// &amp;lt;see href=&quot;https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-nodisplay&quot;&amp;gt;NoDisplay=true&amp;lt;/see&amp;gt;
/// set or are excluded from display by means of
/// &amp;lt;see href=&quot;https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-onlyshowin&quot;&amp;gt;OnlyShowIn&amp;lt;/see&amp;gt;
/// or &amp;lt;see href=&quot;https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-notshowin&quot;&amp;gt;NotShowIn&amp;lt;/see&amp;gt;.
/// See [method@Gio.AppInfo.should_show].
/// </para>
/// <para>
/// The returned list does not include applications which have the
/// &amp;lt;see href=&quot;https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-hidden&quot;&amp;gt;Hidden&amp;lt;/see&amp;gt;
/// set.
/// </para>
/// </summary>

/// <return>
/// a newly allocated
///   list of references to [iface@Gio.AppInfo]s.
/// </return>

	public static MentorLake.GLib.GListHandle AppInfoGetAll()
	{
		return GioGlobalFunctionsExterns.g_app_info_get_all();
	}

/// <summary>
/// <para>
/// Gets a list of all [iface@Gio.AppInfo]s for a given content type,
/// including the recommended and fallback [iface@Gio.AppInfo]s. See
/// [func@Gio.AppInfo.get_recommended_for_type] and
/// [func@Gio.AppInfo.get_fallback_for_type].
/// </para>
/// </summary>

/// <param name="content_type">
/// the content type to find a [iface@Gio.AppInfo] for
/// </param>
/// <return>
/// list of
///   [iface@Gio.AppInfo]s for given @content_type.
/// </return>

	public static MentorLake.GLib.GListHandle AppInfoGetAllForType(string content_type)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_all_for_type(content_type);
	}

/// <summary>
/// <para>
/// Gets the default [iface@Gio.AppInfo] for a given content type.
/// </para>
/// </summary>

/// <param name="content_type">
/// the content type to find a [iface@Gio.AppInfo] for
/// </param>
/// <param name="must_support_uris">
/// if `TRUE`, the [iface@Gio.AppInfo] is expected to
///   support URIs
/// </param>
/// <return>
/// [iface@Gio.AppInfo] for given
///   @content_type or `NULL` on error.
/// </return>

	public static MentorLake.Gio.GAppInfoHandle AppInfoGetDefaultForType(string content_type, bool must_support_uris)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_default_for_type(content_type, must_support_uris);
	}

/// <summary>
/// <para>
/// Asynchronously gets the default [iface@Gio.AppInfo] for a given content
/// type.
/// </para>
/// </summary>

/// <param name="content_type">
/// the content type to find a [iface@Gio.AppInfo] for
/// </param>
/// <param name="must_support_uris">
/// if `TRUE`, the [iface@Gio.AppInfo] is expected to
///   support URIs
/// </param>
/// <param name="cancellable">
/// a [class@Gio.Cancellable]
/// </param>
/// <param name="callback">
/// a [type@Gio.AsyncReadyCallback] to call
///   when the request is done
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>

	public static void AppInfoGetDefaultForTypeAsync(string content_type, bool must_support_uris, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_app_info_get_default_for_type_async(content_type, must_support_uris, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes a default [iface@Gio.AppInfo] lookup started by
/// [func@Gio.AppInfo.get_default_for_type_async].
/// </para>
/// <para>
/// If no #[iface@Gio.AppInfo] is found, then @error will be set to
/// [error@Gio.IOErrorEnum.NOT_FOUND].
/// </para>
/// </summary>

/// <param name="result">
/// the async result
/// </param>
/// <return>
/// [iface@Gio.AppInfo] for given @content_type or
///   `NULL` on error.
/// </return>

	public static MentorLake.Gio.GAppInfoHandle AppInfoGetDefaultForTypeFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_get_default_for_type_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the default application for handling URIs with the given URI scheme.
/// </para>
/// <para>
/// A URI scheme is the initial part of the URI, up to but not including the `:`.
/// For example, `http`, `ftp` or `sip`.
/// </para>
/// </summary>

/// <param name="uri_scheme">
/// a string containing a URI scheme.
/// </param>
/// <return>
/// [iface@Gio.AppInfo] for given
///   @uri_scheme or `NULL` on error.
/// </return>

	public static MentorLake.Gio.GAppInfoHandle AppInfoGetDefaultForUriScheme(string uri_scheme)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_default_for_uri_scheme(uri_scheme);
	}

/// <summary>
/// <para>
/// Asynchronously gets the default application for handling URIs with
/// the given URI scheme. A URI scheme is the initial part
/// of the URI, up to but not including the `:`, e.g. `http`,
/// `ftp` or `sip`.
/// </para>
/// </summary>

/// <param name="uri_scheme">
/// a string containing a URI scheme.
/// </param>
/// <param name="cancellable">
/// a [class@Gio.Cancellable]
/// </param>
/// <param name="callback">
/// a [type@Gio.AsyncReadyCallback] to call
///   when the request is done
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>

	public static void AppInfoGetDefaultForUriSchemeAsync(string uri_scheme, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_app_info_get_default_for_uri_scheme_async(uri_scheme, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes a default [iface@Gio.AppInfo] lookup started by
/// [func@Gio.AppInfo.get_default_for_uri_scheme_async].
/// </para>
/// <para>
/// If no [iface@Gio.AppInfo] is found, then @error will be set to
/// [error@Gio.IOErrorEnum.NOT_FOUND].
/// </para>
/// </summary>

/// <param name="result">
/// the async result
/// </param>
/// <return>
/// [iface@Gio.AppInfo] for given @uri_scheme or
///   `NULL` on error.
/// </return>

	public static MentorLake.Gio.GAppInfoHandle AppInfoGetDefaultForUriSchemeFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_get_default_for_uri_scheme_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets a list of fallback [iface@Gio.AppInfo]s for a given content type, i.e.
/// those applications which claim to support the given content type by MIME
/// type subclassing and not directly.
/// </para>
/// </summary>

/// <param name="content_type">
/// the content type to find a [iface@Gio.AppInfo] for
/// </param>
/// <return>
/// list of [iface@Gio.AppInfo]s
///     for given @content_type or `NULL` on error.
/// </return>

	public static MentorLake.GLib.GListHandle AppInfoGetFallbackForType(string content_type)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_fallback_for_type(content_type);
	}

/// <summary>
/// <para>
/// Gets a list of recommended [iface@Gio.AppInfo]s for a given content type,
/// i.e. those applications which claim to support the given content type
/// exactly, and not by MIME type subclassing.
/// </para>
/// <para>
/// Note that the first application of the list is the last used one, i.e.
/// the last one for which [method@Gio.AppInfo.set_as_last_used_for_type] has
/// been called.
/// </para>
/// </summary>

/// <param name="content_type">
/// the content type to find a [iface@Gio.AppInfo] for
/// </param>
/// <return>
/// list of
///   [iface@Gio.AppInfo]s for given @content_type or `NULL` on error.
/// </return>

	public static MentorLake.GLib.GListHandle AppInfoGetRecommendedForType(string content_type)
	{
		return GioGlobalFunctionsExterns.g_app_info_get_recommended_for_type(content_type);
	}

/// <summary>
/// <para>
/// Utility function that launches the default application registered to handle
/// the specified uri. Synchronous I/O is done on the uri to detect the type of
/// the file if required.
/// </para>
/// <para>
/// The D-Bus–activated applications don’t have to be started if your application
/// terminates too soon after this function. To prevent this, use
/// [func@Gio.AppInfo.launch_default_for_uri_async] instead.
/// </para>
/// </summary>

/// <param name="uri">
/// the uri to show
/// </param>
/// <param name="context">
/// optional launch context
/// </param>
/// <return>
/// `TRUE` on success, `FALSE` on error.
/// </return>

	public static bool AppInfoLaunchDefaultForUri(string uri, MentorLake.Gio.GAppLaunchContextHandle context)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_launch_default_for_uri(uri, context, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Async version of [func@Gio.AppInfo.launch_default_for_uri].
/// </para>
/// <para>
/// This version is useful if you are interested in receiving error information
/// in the case where the application is sandboxed and the portal may present an
/// application chooser dialog to the user.
/// </para>
/// <para>
/// This is also useful if you want to be sure that the D-Bus–activated
/// applications are really started before termination and if you are interested
/// in receiving error information from their activation.
/// </para>
/// </summary>

/// <param name="uri">
/// the uri to show
/// </param>
/// <param name="context">
/// optional launch context
/// </param>
/// <param name="cancellable">
/// a [class@Gio.Cancellable]
/// </param>
/// <param name="callback">
/// a [type@Gio.AsyncReadyCallback] to call
///   when the request is done
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>

	public static void AppInfoLaunchDefaultForUriAsync(string uri, MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_app_info_launch_default_for_uri_async(uri, context, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes an asynchronous launch-default-for-uri operation.
/// </para>
/// </summary>

/// <param name="result">
/// the async result
/// </param>
/// <return>
/// `TRUE` if the launch was successful, `FALSE` if @error is set
/// </return>

	public static bool AppInfoLaunchDefaultForUriFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_app_info_launch_default_for_uri_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes all changes to the type associations done by
/// [method@Gio.AppInfo.set_as_default_for_type],
/// [method@Gio.AppInfo.set_as_default_for_extension],
/// [method@Gio.AppInfo.add_supports_type] or
/// [method@Gio.AppInfo.remove_supports_type].
/// </para>
/// </summary>

/// <param name="content_type">
/// a content type
/// </param>

	public static void AppInfoResetTypeAssociations(string content_type)
	{
		GioGlobalFunctionsExterns.g_app_info_reset_type_associations(content_type);
	}

/// <summary>
/// <para>
/// Helper function for constructing #GAsyncInitable object. This is
/// similar to g_object_newv() but also initializes the object asynchronously.
/// </para>
/// <para>
/// When the initialization is finished, @callback will be called. You can
/// then call g_async_initable_new_finish() to get the new object and check
/// for any errors.
/// </para>
/// </summary>

/// <param name="object_type">
/// a #GType supporting #GAsyncInitable.
/// </param>
/// <param name="n_parameters">
/// the number of parameters in @parameters
/// </param>
/// <param name="parameters">
/// the parameters to use to construct the object
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the operation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the initialization is
///     finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static void AsyncInitableNewvAsync(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameterHandle parameters, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_async_initable_newv_async(object_type, n_parameters, parameters, io_priority, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Asynchronously connects to the message bus specified by @bus_type.
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked. You can
/// then call g_bus_get_finish() to get the result of the operation.
/// </para>
/// <para>
/// This is an asynchronous failable function. See g_bus_get_sync() for
/// the synchronous version.
/// </para>
/// </summary>

/// <param name="bus_type">
/// a #GBusType
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to @callback
/// </param>

	public static void BusGet(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_bus_get(bus_type, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_bus_get().
/// </para>
/// <para>
/// The returned object is a singleton, that is, shared with other
/// callers of g_bus_get() and g_bus_get_sync() for @bus_type. In the
/// event that you need a private message bus connection, use
/// g_dbus_address_get_for_bus_sync() and
/// g_dbus_connection_new_for_address() with
/// G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_CLIENT and
/// G_DBUS_CONNECTION_FLAGS_MESSAGE_BUS_CONNECTION flags.
/// </para>
/// <para>
/// Note that the returned #GDBusConnection object will (usually) have
/// the #GDBusConnection:exit-on-close property set to %TRUE.
/// </para>
/// </summary>

/// <param name="res">
/// a #GAsyncResult obtained from the #GAsyncReadyCallback passed
///     to g_bus_get()
/// </param>
/// <return>
/// a #GDBusConnection or %NULL if @error is set.
///     Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle BusGetFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_bus_get_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously connects to the message bus specified by @bus_type.
/// Note that the returned object may shared with other callers,
/// e.g. if two separate parts of a process calls this function with
/// the same @bus_type, they will share the same object.
/// </para>
/// <para>
/// This is a synchronous failable function. See g_bus_get() and
/// g_bus_get_finish() for the asynchronous version.
/// </para>
/// <para>
/// The returned object is a singleton, that is, shared with other
/// callers of g_bus_get() and g_bus_get_sync() for @bus_type. In the
/// event that you need a private message bus connection, use
/// g_dbus_address_get_for_bus_sync() and
/// g_dbus_connection_new_for_address() with
/// G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_CLIENT and
/// G_DBUS_CONNECTION_FLAGS_MESSAGE_BUS_CONNECTION flags.
/// </para>
/// <para>
/// Note that the returned #GDBusConnection object will (usually) have
/// the #GDBusConnection:exit-on-close property set to %TRUE.
/// </para>
/// </summary>

/// <param name="bus_type">
/// a #GBusType
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// a #GDBusConnection or %NULL if @error is set.
///     Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle BusGetSync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_bus_get_sync(bus_type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Starts acquiring @name on the bus specified by @bus_type and calls
/// @name_acquired_handler and @name_lost_handler when the name is
/// acquired respectively lost. Callbacks will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this function from.
/// </para>
/// <para>
/// You are guaranteed that one of the @name_acquired_handler and @name_lost_handler
/// callbacks will be invoked after calling this function - there are three
/// possible cases:
/// </para>
/// <para>
/// - @name_lost_handler with a %NULL connection (if a connection to the bus
///   can&apos;t be made).
/// </para>
/// <para>
/// - @bus_acquired_handler then @name_lost_handler (if the name can&apos;t be
///   obtained)
/// </para>
/// <para>
/// - @bus_acquired_handler then @name_acquired_handler (if the name was
///   obtained).
/// </para>
/// <para>
/// When you are done owning the name, just call g_bus_unown_name()
/// with the owner id this function returns.
/// </para>
/// <para>
/// If the name is acquired or lost (for example another application
/// could acquire the name if you allow replacement or the application
/// currently owning the name exits), the handlers are also invoked.
/// If the #GDBusConnection that is used for attempting to own the name
/// closes, then @name_lost_handler is invoked since it is no longer
/// possible for other processes to access the process.
/// </para>
/// <para>
/// You cannot use g_bus_own_name() several times for the same name (unless
/// interleaved with calls to g_bus_unown_name()) - only the first call
/// will work.
/// </para>
/// <para>
/// Another guarantee is that invocations of @name_acquired_handler
/// and @name_lost_handler are guaranteed to alternate; that
/// is, if @name_acquired_handler is invoked then you are
/// guaranteed that the next time one of the handlers is invoked, it
/// will be @name_lost_handler. The reverse is also true.
/// </para>
/// <para>
/// If you plan on exporting objects (using e.g.
/// g_dbus_connection_register_object()), note that it is generally too late
/// to export the objects in @name_acquired_handler. Instead, you can do this
/// in @bus_acquired_handler since you are guaranteed that this will run
/// before @name is requested from the bus.
/// </para>
/// <para>
/// This behavior makes it very simple to write applications that wants
/// to [own names][gdbus-owning-names] and export objects.
/// Simply register objects to be exported in @bus_acquired_handler and
/// unregister the objects (if any) in @name_lost_handler.
/// </para>
/// </summary>

/// <param name="bus_type">
/// the type of bus to own a name on
/// </param>
/// <param name="name">
/// the well-known name to own
/// </param>
/// <param name="flags">
/// a set of flags from the #GBusNameOwnerFlags enumeration
/// </param>
/// <param name="bus_acquired_handler">
/// handler to invoke when
///   connected to the bus of type @bus_type or %NULL
/// </param>
/// <param name="name_acquired_handler">
/// handler to invoke when
///   @name is acquired or %NULL
/// </param>
/// <param name="name_lost_handler">
/// handler to invoke when @name
///   is lost or %NULL
/// </param>
/// <param name="user_data">
/// user data to pass to handlers
/// </param>
/// <param name="user_data_free_func">
/// function for freeing @user_data or %NULL
/// </param>
/// <return>
/// an identifier (never 0) that can be used with
///     g_bus_unown_name() to stop owning the name.
/// </return>

	public static uint BusOwnName(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.Gio.GBusAcquiredCallback bus_acquired_handler, MentorLake.Gio.GBusNameAcquiredCallback name_acquired_handler, MentorLake.Gio.GBusNameLostCallback name_lost_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		return GioGlobalFunctionsExterns.g_bus_own_name(bus_type, name, flags, bus_acquired_handler, name_acquired_handler, name_lost_handler, user_data, user_data_free_func);
	}

/// <summary>
/// <para>
/// Like g_bus_own_name() but takes a #GDBusConnection instead of a
/// #GBusType.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="name">
/// the well-known name to own
/// </param>
/// <param name="flags">
/// a set of flags from the #GBusNameOwnerFlags enumeration
/// </param>
/// <param name="name_acquired_handler">
/// handler to invoke when
///   @name is acquired or %NULL
/// </param>
/// <param name="name_lost_handler">
/// handler to invoke when @name
///   is lost or %NULL
/// </param>
/// <param name="user_data">
/// user data to pass to handlers
/// </param>
/// <param name="user_data_free_func">
/// function for freeing @user_data or %NULL
/// </param>
/// <return>
/// an identifier (never 0) that can be used with
///     g_bus_unown_name() to stop owning the name
/// </return>

	public static uint BusOwnNameOnConnection(MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.Gio.GBusNameAcquiredCallback name_acquired_handler, MentorLake.Gio.GBusNameLostCallback name_lost_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		return GioGlobalFunctionsExterns.g_bus_own_name_on_connection(connection, name, flags, name_acquired_handler, name_lost_handler, user_data, user_data_free_func);
	}

/// <summary>
/// <para>
/// Version of g_bus_own_name_on_connection() using closures instead of
/// callbacks for easier binding in other languages.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="name">
/// the well-known name to own
/// </param>
/// <param name="flags">
/// a set of flags from the #GBusNameOwnerFlags enumeration
/// </param>
/// <param name="name_acquired_closure">
/// #GClosure to invoke when @name is
///     acquired or %NULL
/// </param>
/// <param name="name_lost_closure">
/// #GClosure to invoke when @name is lost
///     or %NULL
/// </param>
/// <return>
/// an identifier (never 0) that can be used with
///     g_bus_unown_name() to stop owning the name.
/// </return>

	public static uint BusOwnNameOnConnectionWithClosures(MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.GObject.GClosureHandle name_acquired_closure, MentorLake.GObject.GClosureHandle name_lost_closure)
	{
		return GioGlobalFunctionsExterns.g_bus_own_name_on_connection_with_closures(connection, name, flags, name_acquired_closure, name_lost_closure);
	}

/// <summary>
/// <para>
/// Version of g_bus_own_name() using closures instead of callbacks for
/// easier binding in other languages.
/// </para>
/// </summary>

/// <param name="bus_type">
/// the type of bus to own a name on
/// </param>
/// <param name="name">
/// the well-known name to own
/// </param>
/// <param name="flags">
/// a set of flags from the #GBusNameOwnerFlags enumeration
/// </param>
/// <param name="bus_acquired_closure">
/// #GClosure to invoke when connected to
///     the bus of type @bus_type or %NULL
/// </param>
/// <param name="name_acquired_closure">
/// #GClosure to invoke when @name is
///     acquired or %NULL
/// </param>
/// <param name="name_lost_closure">
/// #GClosure to invoke when @name is lost or
///     %NULL
/// </param>
/// <return>
/// an identifier (never 0) that can be used with
///     g_bus_unown_name() to stop owning the name.
/// </return>

	public static uint BusOwnNameWithClosures(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameOwnerFlags flags, MentorLake.GObject.GClosureHandle bus_acquired_closure, MentorLake.GObject.GClosureHandle name_acquired_closure, MentorLake.GObject.GClosureHandle name_lost_closure)
	{
		return GioGlobalFunctionsExterns.g_bus_own_name_with_closures(bus_type, name, flags, bus_acquired_closure, name_acquired_closure, name_lost_closure);
	}

/// <summary>
/// <para>
/// Stops owning a name.
/// </para>
/// <para>
/// Note that there may still be D-Bus traffic to process (relating to owning
/// and unowning the name) in the current thread-default #GMainContext after
/// this function has returned. You should continue to iterate the #GMainContext
/// until the #GDestroyNotify function passed to g_bus_own_name() is called, in
/// order to avoid memory leaks through callbacks queued on the #GMainContext
/// after it’s stopped being iterated.
/// </para>
/// </summary>

/// <param name="owner_id">
/// an identifier obtained from g_bus_own_name()
/// </param>

	public static void BusUnownName(uint owner_id)
	{
		GioGlobalFunctionsExterns.g_bus_unown_name(owner_id);
	}

/// <summary>
/// <para>
/// Stops watching a name.
/// </para>
/// <para>
/// Note that there may still be D-Bus traffic to process (relating to watching
/// and unwatching the name) in the current thread-default #GMainContext after
/// this function has returned. You should continue to iterate the #GMainContext
/// until the #GDestroyNotify function passed to g_bus_watch_name() is called, in
/// order to avoid memory leaks through callbacks queued on the #GMainContext
/// after it’s stopped being iterated.
/// </para>
/// </summary>

/// <param name="watcher_id">
/// An identifier obtained from g_bus_watch_name()
/// </param>

	public static void BusUnwatchName(uint watcher_id)
	{
		GioGlobalFunctionsExterns.g_bus_unwatch_name(watcher_id);
	}

/// <summary>
/// <para>
/// Starts watching @name on the bus specified by @bus_type and calls
/// @name_appeared_handler and @name_vanished_handler when the name is
/// known to have an owner respectively known to lose its
/// owner. Callbacks will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this function from.
/// </para>
/// <para>
/// You are guaranteed that one of the handlers will be invoked after
/// calling this function. When you are done watching the name, just
/// call g_bus_unwatch_name() with the watcher id this function
/// returns.
/// </para>
/// <para>
/// If the name vanishes or appears (for example the application owning
/// the name could restart), the handlers are also invoked. If the
/// #GDBusConnection that is used for watching the name disconnects, then
/// @name_vanished_handler is invoked since it is no longer
/// possible to access the name.
/// </para>
/// <para>
/// Another guarantee is that invocations of @name_appeared_handler
/// and @name_vanished_handler are guaranteed to alternate; that
/// is, if @name_appeared_handler is invoked then you are
/// guaranteed that the next time one of the handlers is invoked, it
/// will be @name_vanished_handler. The reverse is also true.
/// </para>
/// <para>
/// This behavior makes it very simple to write applications that want
/// to take action when a certain [name exists][gdbus-watching-names].
/// Basically, the application should create object proxies in
/// @name_appeared_handler and destroy them again (if any) in
/// @name_vanished_handler.
/// </para>
/// </summary>

/// <param name="bus_type">
/// The type of bus to watch a name on.
/// </param>
/// <param name="name">
/// The name (well-known or unique) to watch.
/// </param>
/// <param name="flags">
/// Flags from the #GBusNameWatcherFlags enumeration.
/// </param>
/// <param name="name_appeared_handler">
/// Handler to invoke when
///   @name is known to exist or %NULL.
/// </param>
/// <param name="name_vanished_handler">
/// Handler to invoke when
///   @name is known to not exist or %NULL.
/// </param>
/// <param name="user_data">
/// User data to pass to handlers.
/// </param>
/// <param name="user_data_free_func">
/// Function for freeing @user_data or %NULL.
/// </param>
/// <return>
/// An identifier (never 0) that can be used with
/// g_bus_unwatch_name() to stop watching the name.
/// </return>

	public static uint BusWatchName(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.Gio.GBusNameAppearedCallback name_appeared_handler, MentorLake.Gio.GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		return GioGlobalFunctionsExterns.g_bus_watch_name(bus_type, name, flags, name_appeared_handler, name_vanished_handler, user_data, user_data_free_func);
	}

/// <summary>
/// <para>
/// Like g_bus_watch_name() but takes a #GDBusConnection instead of a
/// #GBusType.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="name">
/// The name (well-known or unique) to watch.
/// </param>
/// <param name="flags">
/// Flags from the #GBusNameWatcherFlags enumeration.
/// </param>
/// <param name="name_appeared_handler">
/// Handler to invoke when
///   @name is known to exist or %NULL.
/// </param>
/// <param name="name_vanished_handler">
/// Handler to invoke when
///   @name is known to not exist or %NULL.
/// </param>
/// <param name="user_data">
/// User data to pass to handlers.
/// </param>
/// <param name="user_data_free_func">
/// Function for freeing @user_data or %NULL.
/// </param>
/// <return>
/// An identifier (never 0) that can be used with
/// g_bus_unwatch_name() to stop watching the name.
/// </return>

	public static uint BusWatchNameOnConnection(MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.Gio.GBusNameAppearedCallback name_appeared_handler, MentorLake.Gio.GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		return GioGlobalFunctionsExterns.g_bus_watch_name_on_connection(connection, name, flags, name_appeared_handler, name_vanished_handler, user_data, user_data_free_func);
	}

/// <summary>
/// <para>
/// Version of g_bus_watch_name_on_connection() using closures instead of callbacks for
/// easier binding in other languages.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="name">
/// The name (well-known or unique) to watch.
/// </param>
/// <param name="flags">
/// Flags from the #GBusNameWatcherFlags enumeration.
/// </param>
/// <param name="name_appeared_closure">
/// #GClosure to invoke when @name is known
/// to exist or %NULL.
/// </param>
/// <param name="name_vanished_closure">
/// #GClosure to invoke when @name is known
/// to not exist or %NULL.
/// </param>
/// <return>
/// An identifier (never 0) that can be used with
/// g_bus_unwatch_name() to stop watching the name.
/// </return>

	public static uint BusWatchNameOnConnectionWithClosures(MentorLake.Gio.GDBusConnectionHandle connection, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.GObject.GClosureHandle name_appeared_closure, MentorLake.GObject.GClosureHandle name_vanished_closure)
	{
		return GioGlobalFunctionsExterns.g_bus_watch_name_on_connection_with_closures(connection, name, flags, name_appeared_closure, name_vanished_closure);
	}

/// <summary>
/// <para>
/// Version of g_bus_watch_name() using closures instead of callbacks for
/// easier binding in other languages.
/// </para>
/// </summary>

/// <param name="bus_type">
/// The type of bus to watch a name on.
/// </param>
/// <param name="name">
/// The name (well-known or unique) to watch.
/// </param>
/// <param name="flags">
/// Flags from the #GBusNameWatcherFlags enumeration.
/// </param>
/// <param name="name_appeared_closure">
/// #GClosure to invoke when @name is known
/// to exist or %NULL.
/// </param>
/// <param name="name_vanished_closure">
/// #GClosure to invoke when @name is known
/// to not exist or %NULL.
/// </param>
/// <return>
/// An identifier (never 0) that can be used with
/// g_bus_unwatch_name() to stop watching the name.
/// </return>

	public static uint BusWatchNameWithClosures(MentorLake.Gio.GBusType bus_type, string name, MentorLake.Gio.GBusNameWatcherFlags flags, MentorLake.GObject.GClosureHandle name_appeared_closure, MentorLake.GObject.GClosureHandle name_vanished_closure)
	{
		return GioGlobalFunctionsExterns.g_bus_watch_name_with_closures(bus_type, name, flags, name_appeared_closure, name_vanished_closure);
	}

/// <summary>
/// <para>
/// Checks if a content type can be executable. Note that for instance
/// things like text files can be executables (i.e. scripts and batch files).
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <return>
/// %TRUE if the file type corresponds to a type that
///     can be executable, %FALSE otherwise.
/// </return>

	public static bool ContentTypeCanBeExecutable(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_can_be_executable(type);
	}

/// <summary>
/// <para>
/// Compares two content types for equality.
/// </para>
/// </summary>

/// <param name="type1">
/// a content type string
/// </param>
/// <param name="type2">
/// a content type string
/// </param>
/// <return>
/// %TRUE if the two strings are identical or equivalent,
///     %FALSE otherwise.
/// </return>

	public static bool ContentTypeEquals(string type1, string type2)
	{
		return GioGlobalFunctionsExterns.g_content_type_equals(type1, type2);
	}

/// <summary>
/// <para>
/// Tries to find a content type based on the mime type name.
/// </para>
/// </summary>

/// <param name="mime_type">
/// a mime type string
/// </param>
/// <return>
/// Newly allocated string with content type or
///     %NULL. Free with g_free()
/// </return>

	public static string ContentTypeFromMimeType(string mime_type)
	{
		return GioGlobalFunctionsExterns.g_content_type_from_mime_type(mime_type);
	}

/// <summary>
/// <para>
/// Gets the human readable description of the content type.
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <return>
/// a short description of the content type @type. Free the
///     returned string with g_free()
/// </return>

	public static string ContentTypeGetDescription(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_description(type);
	}

/// <summary>
/// <para>
/// Gets the generic icon name for a content type.
/// </para>
/// <para>
/// See the
/// [shared-mime-info](http://www.freedesktop.org/wiki/Specifications/shared-mime-info-spec)
/// specification for more on the generic icon name.
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <return>
/// the registered generic icon name for the given @type,
///     or %NULL if unknown. Free with g_free()
/// </return>

	public static string ContentTypeGetGenericIconName(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_generic_icon_name(type);
	}

/// <summary>
/// <para>
/// Gets the icon for a content type.
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <return>
/// #GIcon corresponding to the content type. Free the returned
///     object with g_object_unref()
/// </return>

	public static MentorLake.Gio.GIconHandle ContentTypeGetIcon(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_icon(type);
	}

/// <summary>
/// <para>
/// Get the list of directories which MIME data is loaded from. See
/// g_content_type_set_mime_dirs() for details.
/// </para>
/// </summary>

/// <return>
/// %NULL-terminated list of
///    directories to load MIME data from, including any `mime/` subdirectory,
///    and with the first directory to try listed first
/// </return>

	public static string[] ContentTypeGetMimeDirs()
	{
		return GioGlobalFunctionsExterns.g_content_type_get_mime_dirs();
	}

/// <summary>
/// <para>
/// Gets the mime type for the content type, if one is registered.
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <return>
/// the registered mime type for the
///     given @type, or %NULL if unknown; free with g_free().
/// </return>

	public static string ContentTypeGetMimeType(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_mime_type(type);
	}

/// <summary>
/// <para>
/// Gets the symbolic icon for a content type.
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <return>
/// symbolic #GIcon corresponding to the content type.
///     Free the returned object with g_object_unref()
/// </return>

	public static MentorLake.Gio.GIconHandle ContentTypeGetSymbolicIcon(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_get_symbolic_icon(type);
	}

/// <summary>
/// <para>
/// Guesses the content type based on example data. If the function is
/// uncertain, @result_uncertain will be set to %TRUE. Either @filename
/// or @data may be %NULL, in which case the guess will be based solely
/// on the other argument.
/// </para>
/// </summary>

/// <param name="filename">
/// a path, or %NULL
/// </param>
/// <param name="data">
/// a stream of data, or %NULL
/// </param>
/// <param name="data_size">
/// the size of @data
/// </param>
/// <param name="result_uncertain">
/// return location for the certainty
///     of the result, or %NULL
/// </param>
/// <return>
/// a string indicating a guessed content type for the
///     given data. Free with g_free()
/// </return>

	public static string ContentTypeGuess(string filename, byte[] data, UIntPtr data_size, out bool result_uncertain)
	{
		return GioGlobalFunctionsExterns.g_content_type_guess(filename, data, data_size, out result_uncertain);
	}

/// <summary>
/// <para>
/// Tries to guess the type of the tree with root @root, by
/// looking at the files it contains. The result is an array
/// of content types, with the best guess coming first.
/// </para>
/// <para>
/// The types returned all have the form x-content/foo, e.g.
/// x-content/audio-cdda (for audio CDs) or x-content/image-dcf
/// (for a camera memory card). See the
/// [shared-mime-info](http://www.freedesktop.org/wiki/Specifications/shared-mime-info-spec)
/// specification for more on x-content types.
/// </para>
/// <para>
/// This function is useful in the implementation of
/// g_mount_guess_content_type().
/// </para>
/// </summary>

/// <param name="root">
/// the root of the tree to guess a type for
/// </param>
/// <return>
/// an %NULL-terminated
///     array of zero or more content types. Free with g_strfreev()
/// </return>

	public static string[] ContentTypeGuessForTree(MentorLake.Gio.GFileHandle root)
	{
		return GioGlobalFunctionsExterns.g_content_type_guess_for_tree(root);
	}

/// <summary>
/// <para>
/// Determines if @type is a subset of @supertype.
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <param name="supertype">
/// a content type string
/// </param>
/// <return>
/// %TRUE if @type is a kind of @supertype,
///     %FALSE otherwise.
/// </return>

	public static bool ContentTypeIsA(string type, string supertype)
	{
		return GioGlobalFunctionsExterns.g_content_type_is_a(type, supertype);
	}

/// <summary>
/// <para>
/// Determines if @type is a subset of @mime_type.
/// Convenience wrapper around g_content_type_is_a().
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <param name="mime_type">
/// a mime type string
/// </param>
/// <return>
/// %TRUE if @type is a kind of @mime_type,
///     %FALSE otherwise.
/// </return>

	public static bool ContentTypeIsMimeType(string type, string mime_type)
	{
		return GioGlobalFunctionsExterns.g_content_type_is_mime_type(type, mime_type);
	}

/// <summary>
/// <para>
/// Checks if the content type is the generic &quot;unknown&quot; type.
/// On UNIX this is the &quot;application/octet-stream&quot; mimetype,
/// while on win32 it is &quot;*&quot; and on OSX it is a dynamic type
/// or octet-stream.
/// </para>
/// </summary>

/// <param name="type">
/// a content type string
/// </param>
/// <return>
/// %TRUE if the type is the unknown type.
/// </return>

	public static bool ContentTypeIsUnknown(string type)
	{
		return GioGlobalFunctionsExterns.g_content_type_is_unknown(type);
	}

/// <summary>
/// <para>
/// Set the list of directories used by GIO to load the MIME database.
/// If @dirs is %NULL, the directories used are the default:
/// </para>
/// <para>
///  - the `mime` subdirectory of the directory in `$XDG_DATA_HOME`
///  - the `mime` subdirectory of every directory in `$XDG_DATA_DIRS`
/// </para>
/// <para>
/// This function is intended to be used when writing tests that depend on
/// information stored in the MIME database, in order to control the data.
/// </para>
/// <para>
/// Typically, in case your tests use %G_TEST_OPTION_ISOLATE_DIRS, but they
/// depend on the system’s MIME database, you should call this function
/// with @dirs set to %NULL before calling g_test_init(), for instance:
/// </para>
/// <code>
///   // Load MIME data from the system
///   // Load MIME data from the system
///   g_content_type_set_mime_dirs (NULL);
///   // Isolate the environment
///   g_test_init (&amp;argc, &amp;argv, G_TEST_OPTION_ISOLATE_DIRS, NULL);
/// 
///   …
/// 
///   return g_test_run ();
/// </code>
/// </summary>

/// <param name="dirs">
/// %NULL-terminated list of
///    directories to load MIME data from, including any `mime/` subdirectory,
///    and with the first directory to try listed first
/// </param>

	public static void ContentTypeSetMimeDirs(string[] dirs)
	{
		GioGlobalFunctionsExterns.g_content_type_set_mime_dirs(dirs);
	}

/// <summary>
/// <para>
/// Gets a list of strings containing all the registered content types
/// known to the system. The list and its data should be freed using
/// `g_list_free_full (list, g_free)`.
/// </para>
/// </summary>

/// <return>
/// list of the registered
///     content types
/// </return>

	public static MentorLake.GLib.GListHandle ContentTypesGetRegistered()
	{
		return GioGlobalFunctionsExterns.g_content_types_get_registered();
	}

/// <summary>
/// <para>
/// Escape @string so it can appear in a D-Bus address as the value
/// part of a key-value pair.
/// </para>
/// <para>
/// For instance, if @string is `/run/bus-for-:0`,
/// this function would return `/run/bus-for-%3A0`,
/// which could be used in a D-Bus address like
/// `unix:nonce-tcp:host=127.0.0.1,port=42,noncefile=/run/bus-for-%3A0`.
/// </para>
/// </summary>

/// <param name="@string">
/// an unescaped string to be included in a D-Bus address
///     as the value in a key-value pair
/// </param>
/// <return>
/// a copy of @string with all
///     non-optionally-escaped bytes escaped
/// </return>

	public static string DbusAddressEscapeValue(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_address_escape_value(@string);
	}

/// <summary>
/// <para>
/// Synchronously looks up the D-Bus address for the well-known message
/// bus instance specified by @bus_type. This may involve using various
/// platform specific mechanisms.
/// </para>
/// <para>
/// The returned address will be in the
/// [D-Bus address format](https://dbus.freedesktop.org/doc/dbus-specification.html#addresses).
/// </para>
/// </summary>

/// <param name="bus_type">
/// a #GBusType
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// a valid D-Bus address string for @bus_type or
///     %NULL if @error is set
/// </return>

	public static string DbusAddressGetForBusSync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dbus_address_get_for_bus_sync(bus_type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously connects to an endpoint specified by @address and
/// sets up the connection so it is in a state to run the client-side
/// of the D-Bus authentication conversation. @address must be in the
/// [D-Bus address format](https://dbus.freedesktop.org/doc/dbus-specification.html#addresses).
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked. You can
/// then call g_dbus_address_get_stream_finish() to get the result of
/// the operation.
/// </para>
/// <para>
/// This is an asynchronous failable function. See
/// g_dbus_address_get_stream_sync() for the synchronous version.
/// </para>
/// </summary>

/// <param name="address">
/// A valid D-Bus address.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <param name="callback">
/// A #GAsyncReadyCallback to call when the request is satisfied.
/// </param>
/// <param name="user_data">
/// Data to pass to @callback.
/// </param>

	public static void DbusAddressGetStream(string address, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_dbus_address_get_stream(address, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_address_get_stream().
/// </para>
/// <para>
/// A server is not required to set a GUID, so @out_guid may be set to %NULL
/// even on success.
/// </para>
/// </summary>

/// <param name="res">
/// A #GAsyncResult obtained from the GAsyncReadyCallback passed to g_dbus_address_get_stream().
/// </param>
/// <param name="out_guid">
/// %NULL or return location to store the GUID extracted from @address, if any.
/// </param>
/// <return>
/// A #GIOStream or %NULL if @error is set.
/// </return>

	public static MentorLake.Gio.GIOStreamHandle DbusAddressGetStreamFinish(MentorLake.Gio.GAsyncResultHandle res, out string out_guid)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dbus_address_get_stream_finish(res, out out_guid, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously connects to an endpoint specified by @address and
/// sets up the connection so it is in a state to run the client-side
/// of the D-Bus authentication conversation. @address must be in the
/// [D-Bus address format](https://dbus.freedesktop.org/doc/dbus-specification.html#addresses).
/// </para>
/// <para>
/// A server is not required to set a GUID, so @out_guid may be set to %NULL
/// even on success.
/// </para>
/// <para>
/// This is a synchronous failable function. See
/// g_dbus_address_get_stream() for the asynchronous version.
/// </para>
/// </summary>

/// <param name="address">
/// A valid D-Bus address.
/// </param>
/// <param name="out_guid">
/// %NULL or return location to store the GUID extracted from @address, if any.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <return>
/// A #GIOStream or %NULL if @error is set.
/// </return>

	public static MentorLake.Gio.GIOStreamHandle DbusAddressGetStreamSync(string address, out string out_guid, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dbus_address_get_stream_sync(address, out out_guid, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks up the value of an annotation.
/// </para>
/// <para>
/// The cost of this function is O(n) in number of annotations.
/// </para>
/// </summary>

/// <param name="annotations">
/// A %NULL-terminated array of annotations or %NULL.
/// </param>
/// <param name="name">
/// The name of the annotation to look up.
/// </param>
/// <return>
/// The value or %NULL if not found. Do not free, it is owned by @annotations.
/// </return>

	public static string DbusAnnotationInfoLookup(MentorLake.Gio.GDBusAnnotationInfoHandle[] annotations, string name)
	{
		return GioGlobalFunctionsExterns.g_dbus_annotation_info_lookup(annotations, name);
	}

/// <summary>
/// <para>
/// Creates a D-Bus error name to use for @error. If @error matches
/// a registered error (cf. g_dbus_error_register_error()), the corresponding
/// D-Bus error name will be returned.
/// </para>
/// <para>
/// Otherwise the a name of the form
/// `org.gtk.GDBus.UnmappedGError.Quark._ESCAPED_QUARK_NAME.Code_ERROR_CODE`
/// will be used. This allows other GDBus applications to map the error
/// on the wire back to a #GError using g_dbus_error_new_for_dbus_error().
/// </para>
/// <para>
/// This function is typically only used in object mappings to put a
/// #GError on the wire. Regular applications should not use it.
/// </para>
/// </summary>

/// <param name="error">
/// A #GError.
/// </param>
/// <return>
/// A D-Bus error name (never %NULL).
///     Free with g_free().
/// </return>

	public static string DbusErrorEncodeGerror(MentorLake.GLib.GErrorHandle error)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_encode_gerror(error);
	}

/// <summary>
/// <para>
/// Gets the D-Bus error name used for @error, if any.
/// </para>
/// <para>
/// This function is guaranteed to return a D-Bus error name for all
/// #GErrors returned from functions handling remote method calls
/// (e.g. g_dbus_connection_call_finish()) unless
/// g_dbus_error_strip_remote_error() has been used on @error.
/// </para>
/// </summary>

/// <param name="error">
/// a #GError
/// </param>
/// <return>
/// an allocated string or %NULL if the
///     D-Bus error name could not be found. Free with g_free().
/// </return>

	public static string DbusErrorGetRemoteError(MentorLake.GLib.GErrorHandle error)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_get_remote_error(error);
	}

/// <summary>
/// <para>
/// Checks if @error represents an error received via D-Bus from a remote peer. If so,
/// use g_dbus_error_get_remote_error() to get the name of the error.
/// </para>
/// </summary>

/// <param name="error">
/// A #GError.
/// </param>
/// <return>
/// %TRUE if @error represents an error from a remote peer,
/// %FALSE otherwise.
/// </return>

	public static bool DbusErrorIsRemoteError(MentorLake.GLib.GErrorHandle error)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_is_remote_error(error);
	}

/// <summary>
/// <para>
/// Creates a #GError based on the contents of @dbus_error_name and
/// @dbus_error_message.
/// </para>
/// <para>
/// Errors registered with g_dbus_error_register_error() will be looked
/// up using @dbus_error_name and if a match is found, the error domain
/// and code is used. Applications can use g_dbus_error_get_remote_error()
/// to recover @dbus_error_name.
/// </para>
/// <para>
/// If a match against a registered error is not found and the D-Bus
/// error name is in a form as returned by g_dbus_error_encode_gerror()
/// the error domain and code encoded in the name is used to
/// create the #GError. Also, @dbus_error_name is added to the error message
/// such that it can be recovered with g_dbus_error_get_remote_error().
/// </para>
/// <para>
/// Otherwise, a #GError with the error code %G_IO_ERROR_DBUS_ERROR
/// in the %G_IO_ERROR error domain is returned. Also, @dbus_error_name is
/// added to the error message such that it can be recovered with
/// g_dbus_error_get_remote_error().
/// </para>
/// <para>
/// In all three cases, @dbus_error_name can always be recovered from the
/// returned #GError using the g_dbus_error_get_remote_error() function
/// (unless g_dbus_error_strip_remote_error() hasn&apos;t been used on the returned error).
/// </para>
/// <para>
/// This function is typically only used in object mappings to prepare
/// #GError instances for applications. Regular applications should not use
/// it.
/// </para>
/// </summary>

/// <param name="dbus_error_name">
/// D-Bus error name.
/// </param>
/// <param name="dbus_error_message">
/// D-Bus error message.
/// </param>
/// <return>
/// An allocated #GError. Free with g_error_free().
/// </return>

	public static MentorLake.GLib.GErrorHandle DbusErrorNewForDbusError(string dbus_error_name, string dbus_error_message)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_new_for_dbus_error(dbus_error_name, dbus_error_message);
	}



	public static MentorLake.GLib.GQuark DbusErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_dbus_error_quark();
	}

/// <summary>
/// <para>
/// Creates an association to map between @dbus_error_name and
/// #GErrors specified by @error_domain and @error_code.
/// </para>
/// <para>
/// This is typically done in the routine that returns the #GQuark for
/// an error domain.
/// </para>
/// </summary>

/// <param name="error_domain">
/// A #GQuark for an error domain.
/// </param>
/// <param name="error_code">
/// An error code.
/// </param>
/// <param name="dbus_error_name">
/// A D-Bus error name.
/// </param>
/// <return>
/// %TRUE if the association was created, %FALSE if it already
/// exists.
/// </return>

	public static bool DbusErrorRegisterError(MentorLake.GLib.GQuark error_domain, int error_code, string dbus_error_name)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_register_error(error_domain, error_code, dbus_error_name);
	}

/// <summary>
/// <para>
/// Helper function for associating a #GError error domain with D-Bus error names.
/// </para>
/// <para>
/// While @quark_volatile has a `volatile` qualifier, this is a historical
/// artifact and the argument passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="error_domain_quark_name">
/// The error domain name.
/// </param>
/// <param name="quark_volatile">
/// A pointer where to store the #GQuark.
/// </param>
/// <param name="entries">
/// A pointer to @num_entries #GDBusErrorEntry struct items.
/// </param>
/// <param name="num_entries">
/// Number of items to register.
/// </param>

	public static void DbusErrorRegisterErrorDomain(string error_domain_quark_name, UIntPtr quark_volatile, MentorLake.Gio.GDBusErrorEntry[] entries, uint num_entries)
	{
		GioGlobalFunctionsExterns.g_dbus_error_register_error_domain(error_domain_quark_name, quark_volatile, entries, num_entries);
	}

/// <summary>
/// <para>
/// Looks for extra information in the error message used to recover
/// the D-Bus error name and strips it if found. If stripped, the
/// message field in @error will correspond exactly to what was
/// received on the wire.
/// </para>
/// <para>
/// This is typically used when presenting errors to the end user.
/// </para>
/// </summary>

/// <param name="error">
/// A #GError.
/// </param>
/// <return>
/// %TRUE if information was stripped, %FALSE otherwise.
/// </return>

	public static bool DbusErrorStripRemoteError(MentorLake.GLib.GErrorHandle error)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_strip_remote_error(error);
	}

/// <summary>
/// <para>
/// Destroys an association previously set up with g_dbus_error_register_error().
/// </para>
/// </summary>

/// <param name="error_domain">
/// A #GQuark for an error domain.
/// </param>
/// <param name="error_code">
/// An error code.
/// </param>
/// <param name="dbus_error_name">
/// A D-Bus error name.
/// </param>
/// <return>
/// %TRUE if the association was destroyed, %FALSE if it wasn&apos;t found.
/// </return>

	public static bool DbusErrorUnregisterError(MentorLake.GLib.GQuark error_domain, int error_code, string dbus_error_name)
	{
		return GioGlobalFunctionsExterns.g_dbus_error_unregister_error(error_domain, error_code, dbus_error_name);
	}

/// <summary>
/// <para>
/// This is a language binding friendly version of g_dbus_escape_object_path_bytestring().
/// </para>
/// </summary>

/// <param name="s">
/// the string to escape
/// </param>
/// <return>
/// an escaped version of @s. Free with g_free().
/// </return>

	public static string DbusEscapeObjectPath(string s)
	{
		return GioGlobalFunctionsExterns.g_dbus_escape_object_path(s);
	}

/// <summary>
/// <para>
/// Escapes @bytes for use in a D-Bus object path component.
/// @bytes is an array of zero or more nonzero bytes in an
/// unspecified encoding, followed by a single zero byte.
/// </para>
/// <para>
/// The escaping method consists of replacing all non-alphanumeric
/// characters (see g_ascii_isalnum()) with their hexadecimal value
/// preceded by an underscore (`_`). For example:
/// `foo.bar.baz` will become `foo_2ebar_2ebaz`.
/// </para>
/// <para>
/// This method is appropriate to use when the input is nearly
/// a valid object path component but is not when your input
/// is far from being a valid object path component.
/// Other escaping algorithms are also valid to use with
/// D-Bus object paths.
/// </para>
/// <para>
/// This can be reversed with g_dbus_unescape_object_path().
/// </para>
/// </summary>

/// <param name="bytes">
/// the string of bytes to escape
/// </param>
/// <return>
/// an escaped version of @bytes. Free with g_free().
/// </return>

	public static string DbusEscapeObjectPathBytestring(byte[] bytes)
	{
		return GioGlobalFunctionsExterns.g_dbus_escape_object_path_bytestring(bytes);
	}

/// <summary>
/// <para>
/// Generate a D-Bus GUID that can be used with
/// e.g. g_dbus_connection_new().
/// </para>
/// <para>
/// See the
/// [D-Bus specification](https://dbus.freedesktop.org/doc/dbus-specification.html#uuids)
/// regarding what strings are valid D-Bus GUIDs. The specification refers to
/// these as ‘UUIDs’ whereas GLib (for historical reasons) refers to them as
/// ‘GUIDs’. The terms are interchangeable.
/// </para>
/// <para>
/// Note that D-Bus GUIDs do not follow
/// [RFC 4122](https://datatracker.ietf.org/doc/html/rfc4122).
/// </para>
/// </summary>

/// <return>
/// A valid D-Bus GUID. Free with g_free().
/// </return>

	public static string DbusGenerateGuid()
	{
		return GioGlobalFunctionsExterns.g_dbus_generate_guid();
	}

/// <summary>
/// <para>
/// Converts a #GValue to a #GVariant of the type indicated by the @type
/// parameter.
/// </para>
/// <para>
/// The conversion is using the following rules:
/// </para>
/// <para>
/// - `G_TYPE_STRING`: &apos;s&apos;, &apos;o&apos;, &apos;g&apos; or &apos;ay&apos;
/// - `G_TYPE_STRV`: &apos;as&apos;, &apos;ao&apos; or &apos;aay&apos;
/// - `G_TYPE_BOOLEAN`: &apos;b&apos;
/// - `G_TYPE_UCHAR`: &apos;y&apos;
/// - `G_TYPE_INT`: &apos;i&apos;, &apos;n&apos;
/// - `G_TYPE_UINT`: &apos;u&apos;, &apos;q&apos;
/// - `G_TYPE_INT64`: &apos;x&apos;
/// - `G_TYPE_UINT64`: &apos;t&apos;
/// - `G_TYPE_DOUBLE`: &apos;d&apos;
/// - `G_TYPE_VARIANT`: Any #GVariantType
/// </para>
/// <para>
/// This can fail if e.g. @gvalue is of type %G_TYPE_STRING and @type
/// is &apos;i&apos;, i.e. %G_VARIANT_TYPE_INT32. It will also fail for any #GType
/// (including e.g. %G_TYPE_OBJECT and %G_TYPE_BOXED derived-types) not
/// in the table above.
/// </para>
/// <para>
/// Note that if @gvalue is of type %G_TYPE_VARIANT and its value is
/// %NULL, the empty #GVariant instance (never %NULL) for @type is
/// returned (e.g. 0 for scalar types, the empty string for string types,
/// &apos;/&apos; for object path types, the empty array for any array type and so on).
/// </para>
/// <para>
/// See the g_dbus_gvariant_to_gvalue() function for how to convert a
/// #GVariant to a #GValue.
/// </para>
/// </summary>

/// <param name="gvalue">
/// A #GValue to convert to a #GVariant
/// </param>
/// <param name="type">
/// A #GVariantType
/// </param>
/// <return>
/// A #GVariant (never floating) of
///     #GVariantType @type holding the data from @gvalue or an empty #GVariant
///     in case of failure. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle DbusGvalueToGvariant(MentorLake.GObject.GValueHandle gvalue, MentorLake.GLib.GVariantTypeHandle type)
	{
		return GioGlobalFunctionsExterns.g_dbus_gvalue_to_gvariant(gvalue, type);
	}

/// <summary>
/// <para>
/// Converts a #GVariant to a #GValue. If @value is floating, it is consumed.
/// </para>
/// <para>
/// The rules specified in the g_dbus_gvalue_to_gvariant() function are
/// used - this function is essentially its reverse form. So, a #GVariant
/// containing any basic or string array type will be converted to a #GValue
/// containing a basic value or string array. Any other #GVariant (handle,
/// variant, tuple, dict entry) will be converted to a #GValue containing that
/// #GVariant.
/// </para>
/// <para>
/// The conversion never fails - a valid #GValue is always returned in
/// @out_gvalue.
/// </para>
/// </summary>

/// <param name="value">
/// A #GVariant.
/// </param>
/// <param name="out_gvalue">
/// Return location pointing to a zero-filled (uninitialized) #GValue.
/// </param>

	public static void DbusGvariantToGvalue(MentorLake.GLib.GVariantHandle value, out MentorLake.GObject.GValue out_gvalue)
	{
		GioGlobalFunctionsExterns.g_dbus_gvariant_to_gvalue(value, out out_gvalue);
	}

/// <summary>
/// <para>
/// Checks if @string is a
/// [D-Bus address](https://dbus.freedesktop.org/doc/dbus-specification.html#addresses).
/// </para>
/// <para>
/// This doesn&apos;t check if @string is actually supported by #GDBusServer
/// or #GDBusConnection - use g_dbus_is_supported_address() to do more
/// checks.
/// </para>
/// </summary>

/// <param name="@string">
/// A string.
/// </param>
/// <return>
/// %TRUE if @string is a valid D-Bus address, %FALSE otherwise.
/// </return>

	public static bool DbusIsAddress(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_address(@string);
	}

/// <summary>
/// <para>
/// Check whether @string is a valid D-Bus error name.
/// </para>
/// <para>
/// This function returns the same result as g_dbus_is_interface_name(),
/// because D-Bus error names are defined to have exactly the
/// same syntax as interface names.
/// </para>
/// </summary>

/// <param name="@string">
/// The string to check.
/// </param>
/// <return>
/// %TRUE if valid, %FALSE otherwise.
/// </return>

	public static bool DbusIsErrorName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_error_name(@string);
	}

/// <summary>
/// <para>
/// Checks if @string is a D-Bus GUID.
/// </para>
/// <para>
/// See the documentation for g_dbus_generate_guid() for more information about
/// the format of a GUID.
/// </para>
/// </summary>

/// <param name="@string">
/// The string to check.
/// </param>
/// <return>
/// %TRUE if @string is a GUID, %FALSE otherwise.
/// </return>

	public static bool DbusIsGuid(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_guid(@string);
	}

/// <summary>
/// <para>
/// Checks if @string is a valid D-Bus interface name.
/// </para>
/// </summary>

/// <param name="@string">
/// The string to check.
/// </param>
/// <return>
/// %TRUE if valid, %FALSE otherwise.
/// </return>

	public static bool DbusIsInterfaceName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_interface_name(@string);
	}

/// <summary>
/// <para>
/// Checks if @string is a valid D-Bus member (e.g. signal or method) name.
/// </para>
/// </summary>

/// <param name="@string">
/// The string to check.
/// </param>
/// <return>
/// %TRUE if valid, %FALSE otherwise.
/// </return>

	public static bool DbusIsMemberName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_member_name(@string);
	}

/// <summary>
/// <para>
/// Checks if @string is a valid D-Bus bus name (either unique or well-known).
/// </para>
/// </summary>

/// <param name="@string">
/// The string to check.
/// </param>
/// <return>
/// %TRUE if valid, %FALSE otherwise.
/// </return>

	public static bool DbusIsName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_name(@string);
	}

/// <summary>
/// <para>
/// Like g_dbus_is_address() but also checks if the library supports the
/// transports in @string and that key/value pairs for each transport
/// are valid. See the specification of the
/// [D-Bus address format](https://dbus.freedesktop.org/doc/dbus-specification.html#addresses).
/// </para>
/// </summary>

/// <param name="@string">
/// A string.
/// </param>
/// <return>
/// %TRUE if @string is a valid D-Bus address that is
/// supported by this library, %FALSE if @error is set.
/// </return>

	public static bool DbusIsSupportedAddress(string @string)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dbus_is_supported_address(@string, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if @string is a valid D-Bus unique bus name.
/// </para>
/// </summary>

/// <param name="@string">
/// The string to check.
/// </param>
/// <return>
/// %TRUE if valid, %FALSE otherwise.
/// </return>

	public static bool DbusIsUniqueName(string @string)
	{
		return GioGlobalFunctionsExterns.g_dbus_is_unique_name(@string);
	}

/// <summary>
/// <para>
/// Unescapes an string that was previously escaped with
/// g_dbus_escape_object_path(). If the string is in a format that could
/// not have been returned by g_dbus_escape_object_path(), this function
/// returns %NULL.
/// </para>
/// <para>
/// Encoding alphanumeric characters which do not need to be
/// encoded is not allowed (e.g `_63` is not valid, the string
/// should contain `c` instead).
/// </para>
/// </summary>

/// <param name="s">
/// the string to unescape
/// </param>
/// <return>
/// an
///   unescaped version of @s, or %NULL if @s is not a string returned
///   from g_dbus_escape_object_path(). Free with g_free().
/// </return>

	public static byte[] DbusUnescapeObjectPath(string s)
	{
		return GioGlobalFunctionsExterns.g_dbus_unescape_object_path(s);
	}

/// <summary>
/// <para>
/// Creates a new #GDtlsClientConnection wrapping @base_socket which is
/// assumed to communicate with the server identified by @server_identity.
/// </para>
/// </summary>

/// <param name="base_socket">
/// the #GDatagramBased to wrap
/// </param>
/// <param name="server_identity">
/// the expected identity of the server
/// </param>
/// <return>
/// the new
///   #GDtlsClientConnection, or %NULL on error
/// </return>

	public static MentorLake.Gio.GDatagramBasedHandle DtlsClientConnectionNew(MentorLake.Gio.GDatagramBasedHandle base_socket, MentorLake.Gio.GSocketConnectableHandle server_identity)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dtls_client_connection_new(base_socket, server_identity, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new #GDtlsServerConnection wrapping @base_socket.
/// </para>
/// </summary>

/// <param name="base_socket">
/// the #GDatagramBased to wrap
/// </param>
/// <param name="certificate">
/// the default server certificate, or %NULL
/// </param>
/// <return>
/// the new
///   #GDtlsServerConnection, or %NULL on error
/// </return>

	public static MentorLake.Gio.GDatagramBasedHandle DtlsServerConnectionNew(MentorLake.Gio.GDatagramBasedHandle base_socket, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_dtls_server_connection_new(base_socket, certificate, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Constructs a #GFile from a vector of elements using the correct
/// separator for filenames.
/// </para>
/// <para>
/// Using this function is equivalent to calling g_build_filenamev(),
/// followed by g_file_new_for_path() on the result.
/// </para>
/// </summary>

/// <param name="args">
/// %NULL-terminated
///   array of strings containing the path elements.
/// </param>
/// <return>
/// a new #GFile
/// </return>

	public static MentorLake.Gio.GFileHandle FileNewBuildFilenamev(string[] args)
	{
		return GioGlobalFunctionsExterns.g_file_new_build_filenamev(args);
	}

/// <summary>
/// <para>
/// Creates a #GFile with the given argument from the command line.
/// The value of @arg can be either a URI, an absolute path or a
/// relative path resolved relative to the current working directory.
/// This operation never fails, but the returned object might not
/// support any I/O operation if @arg points to a malformed path.
/// </para>
/// <para>
/// Note that on Windows, this function expects its argument to be in
/// UTF-8 -- not the system code page.  This means that you
/// should not use this function with string from argv as it is passed
/// to main().  g_win32_get_command_line() will return a UTF-8 version of
/// the commandline.  #GApplication also uses UTF-8 but
/// g_application_command_line_create_file_for_arg() may be more useful
/// for you there.  It is also always possible to use this function with
/// #GOptionContext arguments of type %G_OPTION_ARG_FILENAME.
/// </para>
/// </summary>

/// <param name="arg">
/// a command line string
/// </param>
/// <return>
/// a new #GFile.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle FileNewForCommandlineArg(string arg)
	{
		return GioGlobalFunctionsExterns.g_file_new_for_commandline_arg(arg);
	}

/// <summary>
/// <para>
/// Creates a #GFile with the given argument from the command line.
/// </para>
/// <para>
/// This function is similar to g_file_new_for_commandline_arg() except
/// that it allows for passing the current working directory as an
/// argument instead of using the current working directory of the
/// process.
/// </para>
/// <para>
/// This is useful if the commandline argument was given in a context
/// other than the invocation of the current process.
/// </para>
/// <para>
/// See also g_application_command_line_create_file_for_arg().
/// </para>
/// </summary>

/// <param name="arg">
/// a command line string
/// </param>
/// <param name="cwd">
/// the current working directory of the commandline
/// </param>
/// <return>
/// a new #GFile
/// </return>

	public static MentorLake.Gio.GFileHandle FileNewForCommandlineArgAndCwd(string arg, string cwd)
	{
		return GioGlobalFunctionsExterns.g_file_new_for_commandline_arg_and_cwd(arg, cwd);
	}

/// <summary>
/// <para>
/// Constructs a #GFile for a given path. This operation never
/// fails, but the returned object might not support any I/O
/// operation if @path is malformed.
/// </para>
/// </summary>

/// <param name="path">
/// a string containing a relative or absolute path.
///   The string must be encoded in the glib filename encoding.
/// </param>
/// <return>
/// a new #GFile for the given @path.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle FileNewForPath(string path)
	{
		return GioGlobalFunctionsExterns.g_file_new_for_path(path);
	}

/// <summary>
/// <para>
/// Constructs a #GFile for a given URI. This operation never
/// fails, but the returned object might not support any I/O
/// operation if @uri is malformed or if the uri type is
/// not supported.
/// </para>
/// </summary>

/// <param name="uri">
/// a UTF-8 string containing a URI
/// </param>
/// <return>
/// a new #GFile for the given @uri.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle FileNewForUri(string uri)
	{
		return GioGlobalFunctionsExterns.g_file_new_for_uri(uri);
	}

/// <summary>
/// <para>
/// Opens a file in the preferred directory for temporary files (as
/// returned by g_get_tmp_dir()) and returns a #GFile and
/// #GFileIOStream pointing to it.
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding
/// containing a sequence of six &apos;X&apos; characters, and containing no
/// directory components. If it is %NULL, a default template is used.
/// </para>
/// <para>
/// Unlike the other #GFile constructors, this will return %NULL if
/// a temporary file could not be created.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for the file
///   name, as in g_file_open_tmp(), or %NULL for a default template
/// </param>
/// <param name="iostream">
/// on return, a #GFileIOStream for the created file
/// </param>
/// <return>
/// a new #GFile.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle FileNewTmp(string tmpl, out MentorLake.Gio.GFileIOStreamHandle iostream)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_file_new_tmp(tmpl, out iostream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously opens a file in the preferred directory for temporary files
///  (as returned by g_get_tmp_dir()) as g_file_new_tmp().
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding
/// containing a sequence of six &apos;X&apos; characters, and containing no
/// directory components. If it is %NULL, a default template is used.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for the file
///   name, as in g_file_open_tmp(), or %NULL for a default template
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is done
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>

	public static void FileNewTmpAsync(string tmpl, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_file_new_tmp_async(tmpl, io_priority, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Asynchronously creates a directory in the preferred directory for
/// temporary files (as returned by g_get_tmp_dir()) as g_dir_make_tmp().
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding
/// containing a sequence of six &apos;X&apos; characters, and containing no
/// directory components. If it is %NULL, a default template is used.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for the file
///   name, as in g_dir_make_tmp(), or %NULL for a default template
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is done
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>

	public static void FileNewTmpDirAsync(string tmpl, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GioGlobalFunctionsExterns.g_file_new_tmp_dir_async(tmpl, io_priority, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes a temporary directory creation started by
/// g_file_new_tmp_dir_async().
/// </para>
/// </summary>

/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a new #GFile.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle FileNewTmpDirFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_file_new_tmp_dir_finish(result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes a temporary file creation started by g_file_new_tmp_async().
/// </para>
/// </summary>

/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <param name="iostream">
/// on return, a #GFileIOStream for the created file
/// </param>
/// <return>
/// a new #GFile.
///   Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle FileNewTmpFinish(MentorLake.Gio.GAsyncResultHandle result, out MentorLake.Gio.GFileIOStreamHandle iostream)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_file_new_tmp_finish(result, out iostream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Constructs a #GFile with the given @parse_name (i.e. something
/// given by g_file_get_parse_name()). This operation never fails,
/// but the returned object might not support any I/O operation if
/// the @parse_name cannot be parsed.
/// </para>
/// </summary>

/// <param name="parse_name">
/// a file name or path to be parsed
/// </param>
/// <return>
/// a new #GFile.
/// </return>

	public static MentorLake.Gio.GFileHandle FileParseName(string parse_name)
	{
		return GioGlobalFunctionsExterns.g_file_parse_name(parse_name);
	}

/// <summary>
/// <para>
/// Deserializes a #GIcon previously serialized using g_icon_serialize().
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant created with g_icon_serialize()
/// </param>
/// <return>
/// a #GIcon, or %NULL when deserialization fails.
/// </return>

	public static MentorLake.Gio.GIconHandle IconDeserialize(MentorLake.GLib.GVariantHandle value)
	{
		return GioGlobalFunctionsExterns.g_icon_deserialize(value);
	}

/// <summary>
/// <para>
/// Generate a #GIcon instance from @str. This function can fail if
/// @str is not valid - see g_icon_to_string() for discussion.
/// </para>
/// <para>
/// If your application or library provides one or more #GIcon
/// implementations you need to ensure that each #GType is registered
/// with the type system prior to calling g_icon_new_for_string().
/// </para>
/// </summary>

/// <param name="str">
/// A string obtained via g_icon_to_string().
/// </param>
/// <return>
/// An object implementing the #GIcon
///          interface or %NULL if @error is set.
/// </return>

	public static MentorLake.Gio.GIconHandle IconNewForString(string str)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_icon_new_for_string(str, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Helper function for constructing #GInitable object. This is
/// similar to g_object_newv() but also initializes the object
/// and returns %NULL, setting an error on failure.
/// </para>
/// </summary>

/// <param name="object_type">
/// a #GType supporting #GInitable.
/// </param>
/// <param name="n_parameters">
/// the number of parameters in @parameters
/// </param>
/// <param name="parameters">
/// the parameters to use to construct the object
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a newly allocated
///      #GObject, or %NULL on error
/// </return>

	public static MentorLake.GObject.GObjectHandle InitableNewv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_initable_newv(object_type, n_parameters, parameters, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts `errno.h` error codes into GIO error codes.
/// </para>
/// <para>
/// The fallback value %G_IO_ERROR_FAILED is returned for error codes not
/// currently handled (but note that future GLib releases may return a more
/// specific value instead).
/// </para>
/// <para>
/// As `errno` is global and may be modified by intermediate function
/// calls, you should save its value immediately after the call returns,
/// and use the saved value instead of `errno`:
/// </para>
/// 
/// <code>
///   int saved_errno;
///   int saved_errno;
/// 
///   ret = read (blah);
///   saved_errno = errno;
/// 
///   g_io_error_from_errno (saved_errno);
/// </code>
/// </summary>

/// <param name="err_no">
/// Error number as defined in errno.h.
/// </param>
/// <return>
/// #GIOErrorEnum value for the given `errno.h` error number
/// </return>

	public static MentorLake.Gio.GIOErrorEnum IoErrorFromErrno(int err_no)
	{
		return GioGlobalFunctionsExterns.g_io_error_from_errno(err_no);
	}

/// <summary>
/// <para>
/// Converts #GFileError error codes into GIO error codes.
/// </para>
/// </summary>

/// <param name="file_error">
/// a #GFileError.
/// </param>
/// <return>
/// #GIOErrorEnum value for the given #GFileError error value.
/// </return>

	public static MentorLake.Gio.GIOErrorEnum IoErrorFromFileError(MentorLake.GLib.GFileError file_error)
	{
		return GioGlobalFunctionsExterns.g_io_error_from_file_error(file_error);
	}

/// <summary>
/// <para>
/// Gets the GIO Error Quark.
/// </para>
/// </summary>

/// <return>
/// a #GQuark.
/// </return>

	public static MentorLake.GLib.GQuark IoErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_io_error_quark();
	}

/// <summary>
/// <para>
/// Registers @type as extension for the extension point with name
/// @extension_point_name.
/// </para>
/// <para>
/// If @type has already been registered as an extension for this
/// extension point, the existing #GIOExtension object is returned.
/// </para>
/// </summary>

/// <param name="extension_point_name">
/// the name of the extension point
/// </param>
/// <param name="type">
/// the #GType to register as extension
/// </param>
/// <param name="extension_name">
/// the name for the extension
/// </param>
/// <param name="priority">
/// the priority for the extension
/// </param>
/// <return>
/// a #GIOExtension object for #GType
/// </return>

	public static MentorLake.Gio.GIOExtensionHandle IoExtensionPointImplement(string extension_point_name, MentorLake.GObject.GType type, string extension_name, int priority)
	{
		return GioGlobalFunctionsExterns.g_io_extension_point_implement(extension_point_name, type, extension_name, priority);
	}

/// <summary>
/// <para>
/// Looks up an existing extension point.
/// </para>
/// </summary>

/// <param name="name">
/// the name of the extension point
/// </param>
/// <return>
/// the #GIOExtensionPoint, or %NULL if there
///    is no registered extension point with the given name.
/// </return>

	public static MentorLake.Gio.GIOExtensionPointHandle IoExtensionPointLookup(string name)
	{
		return GioGlobalFunctionsExterns.g_io_extension_point_lookup(name);
	}

/// <summary>
/// <para>
/// Registers an extension point.
/// </para>
/// </summary>

/// <param name="name">
/// The name of the extension point
/// </param>
/// <return>
/// the new #GIOExtensionPoint. This object is
///    owned by GIO and should not be freed.
/// </return>

	public static MentorLake.Gio.GIOExtensionPointHandle IoExtensionPointRegister(string name)
	{
		return GioGlobalFunctionsExterns.g_io_extension_point_register(name);
	}

/// <summary>
/// <para>
/// Loads all the modules in the specified directory.
/// </para>
/// <para>
/// If don&apos;t require all modules to be initialized (and thus registering
/// all gtypes) then you can use g_io_modules_scan_all_in_directory()
/// which allows delayed/lazy loading of modules.
/// </para>
/// </summary>

/// <param name="dirname">
/// pathname for a directory containing modules
///     to load.
/// </param>
/// <return>
/// a list of #GIOModules loaded
///      from the directory,
///      All the modules are loaded into memory, if you want to
///      unload them (enabling on-demand loading) you must call
///      g_type_module_unuse() on all the modules. Free the list
///      with g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle IoModulesLoadAllInDirectory(string dirname)
	{
		return GioGlobalFunctionsExterns.g_io_modules_load_all_in_directory(dirname);
	}

/// <summary>
/// <para>
/// Loads all the modules in the specified directory.
/// </para>
/// <para>
/// If don&apos;t require all modules to be initialized (and thus registering
/// all gtypes) then you can use g_io_modules_scan_all_in_directory()
/// which allows delayed/lazy loading of modules.
/// </para>
/// </summary>

/// <param name="dirname">
/// pathname for a directory containing modules
///     to load.
/// </param>
/// <param name="scope">
/// a scope to use when scanning the modules.
/// </param>
/// <return>
/// a list of #GIOModules loaded
///      from the directory,
///      All the modules are loaded into memory, if you want to
///      unload them (enabling on-demand loading) you must call
///      g_type_module_unuse() on all the modules. Free the list
///      with g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle IoModulesLoadAllInDirectoryWithScope(string dirname, MentorLake.Gio.GIOModuleScopeHandle scope)
	{
		return GioGlobalFunctionsExterns.g_io_modules_load_all_in_directory_with_scope(dirname, scope);
	}

/// <summary>
/// <para>
/// Scans all the modules in the specified directory, ensuring that
/// any extension point implemented by a module is registered.
/// </para>
/// <para>
/// This may not actually load and initialize all the types in each
/// module, some modules may be lazily loaded and initialized when
/// an extension point it implements is used with e.g.
/// g_io_extension_point_get_extensions() or
/// g_io_extension_point_get_extension_by_name().
/// </para>
/// <para>
/// If you need to guarantee that all types are loaded in all the modules,
/// use g_io_modules_load_all_in_directory().
/// </para>
/// </summary>

/// <param name="dirname">
/// pathname for a directory containing modules
///     to scan.
/// </param>

	public static void IoModulesScanAllInDirectory(string dirname)
	{
		GioGlobalFunctionsExterns.g_io_modules_scan_all_in_directory(dirname);
	}

/// <summary>
/// <para>
/// Scans all the modules in the specified directory, ensuring that
/// any extension point implemented by a module is registered.
/// </para>
/// <para>
/// This may not actually load and initialize all the types in each
/// module, some modules may be lazily loaded and initialized when
/// an extension point it implements is used with e.g.
/// g_io_extension_point_get_extensions() or
/// g_io_extension_point_get_extension_by_name().
/// </para>
/// <para>
/// If you need to guarantee that all types are loaded in all the modules,
/// use g_io_modules_load_all_in_directory().
/// </para>
/// </summary>

/// <param name="dirname">
/// pathname for a directory containing modules
///     to scan.
/// </param>
/// <param name="scope">
/// a scope to use when scanning the modules
/// </param>

	public static void IoModulesScanAllInDirectoryWithScope(string dirname, MentorLake.Gio.GIOModuleScopeHandle scope)
	{
		GioGlobalFunctionsExterns.g_io_modules_scan_all_in_directory_with_scope(dirname, scope);
	}

/// <summary>
/// <para>
/// Cancels all cancellable I/O jobs.
/// </para>
/// <para>
/// A job is cancellable if a #GCancellable was passed into
/// g_io_scheduler_push_job().
/// </para>
/// </summary>


	public static void IoSchedulerCancelAllJobs()
	{
		GioGlobalFunctionsExterns.g_io_scheduler_cancel_all_jobs();
	}

/// <summary>
/// <para>
/// Schedules the I/O job to run in another thread.
/// </para>
/// <para>
/// @notify will be called on @user_data after @job_func has returned,
/// regardless whether the job was cancelled or has run to completion.
/// </para>
/// <para>
/// If @cancellable is not %NULL, it can be used to cancel the I/O job
/// by calling g_cancellable_cancel() or by calling
/// g_io_scheduler_cancel_all_jobs().
/// </para>
/// </summary>

/// <param name="job_func">
/// a #GIOSchedulerJobFunc.
/// </param>
/// <param name="user_data">
/// data to pass to @job_func
/// </param>
/// <param name="notify">
/// a #GDestroyNotify for @user_data, or %NULL
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority)
/// of the request.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>

	public static void IoSchedulerPushJob(MentorLake.Gio.GIOSchedulerJobFunc job_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify, int io_priority, MentorLake.Gio.GCancellableHandle cancellable)
	{
		GioGlobalFunctionsExterns.g_io_scheduler_push_job(job_func, user_data, notify, io_priority, cancellable);
	}

/// <summary>
/// <para>
/// Creates a keyfile-backed #GSettingsBackend.
/// </para>
/// <para>
/// The filename of the keyfile to use is given by @filename.
/// </para>
/// <para>
/// All settings read to or written from the backend must fall under the
/// path given in @root_path (which must start and end with a slash and
/// not contain two consecutive slashes).  @root_path may be &quot;/&quot;.
/// </para>
/// <para>
/// If @root_group is non-%NULL then it specifies the name of the keyfile
/// group used for keys that are written directly below @root_path.  For
/// example, if @root_path is &quot;/apps/example/&quot; and @root_group is
/// &quot;toplevel&quot;, then settings the key &quot;/apps/example/enabled&quot; to a value
/// of %TRUE will cause the following to appear in the keyfile:
/// </para>
/// <code>
///   [toplevel]
///   [toplevel]
///   enabled=true
/// </code>
/// <para>
/// If @root_group is %NULL then it is not permitted to store keys
/// directly below the @root_path.
/// </para>
/// <para>
/// For keys not stored directly below @root_path (ie: in a sub-path),
/// the name of the subpath (with the final slash stripped) is used as
/// the name of the keyfile group.  To continue the example, if
/// &quot;/apps/example/profiles/default/font-size&quot; were set to
/// 12 then the following would appear in the keyfile:
/// </para>
/// <code>
///   [profiles/default]
///   [profiles/default]
///   font-size=12
/// </code>
/// <para>
/// The backend will refuse writes (and return writability as being
/// %FALSE) for keys outside of @root_path and, in the event that
/// @root_group is %NULL, also for keys directly under @root_path.
/// Writes will also be refused if the backend detects that it has the
/// inability to rewrite the keyfile (ie: the containing directory is not
/// writable).
/// </para>
/// <para>
/// There is no checking done for your key namespace clashing with the
/// syntax of the key file format.  For example, if you have &apos;[&apos; or &apos;]&apos;
/// characters in your path names or &apos;=&apos; in your key names you may be in
/// trouble.
/// </para>
/// <para>
/// The backend reads default values from a keyfile called `defaults` in
/// the directory specified by the #GKeyfileSettingsBackend:defaults-dir property,
/// and a list of locked keys from a text file with the name `locks` in
/// the same location.
/// </para>
/// </summary>

/// <param name="filename">
/// the filename of the keyfile
/// </param>
/// <param name="root_path">
/// the path under which all settings keys appear
/// </param>
/// <param name="root_group">
/// the group name corresponding to
///              @root_path, or %NULL
/// </param>
/// <return>
/// a keyfile-backed #GSettingsBackend
/// </return>

	public static MentorLake.Gio.GSettingsBackendHandle KeyfileSettingsBackendNew(string filename, string root_path, string root_group)
	{
		return GioGlobalFunctionsExterns.g_keyfile_settings_backend_new(filename, root_path, root_group);
	}

/// <summary>
/// <para>
/// Gets a reference to the default #GMemoryMonitor for the system.
/// </para>
/// </summary>

/// <return>
/// a new reference to the default #GMemoryMonitor
/// </return>

	public static MentorLake.Gio.GMemoryMonitorHandle MemoryMonitorDupDefault()
	{
		return GioGlobalFunctionsExterns.g_memory_monitor_dup_default();
	}

/// <summary>
/// <para>
/// Creates a memory-backed #GSettingsBackend.
/// </para>
/// <para>
/// This backend allows changes to settings, but does not write them
/// to any backing storage, so the next time you run your application,
/// the memory backend will start out with the default values again.
/// </para>
/// </summary>

/// <return>
/// a newly created #GSettingsBackend
/// </return>

	public static MentorLake.Gio.GSettingsBackendHandle MemorySettingsBackendNew()
	{
		return GioGlobalFunctionsExterns.g_memory_settings_backend_new();
	}

/// <summary>
/// <para>
/// Gets the default #GNetworkMonitor for the system.
/// </para>
/// </summary>

/// <return>
/// a #GNetworkMonitor, which will be
///     a dummy object if no network monitor is available
/// </return>

	public static MentorLake.Gio.GNetworkMonitorHandle NetworkMonitorGetDefault()
	{
		return GioGlobalFunctionsExterns.g_network_monitor_get_default();
	}

/// <summary>
/// <para>
/// Initializes the platform networking libraries (eg, on Windows, this
/// calls WSAStartup()). GLib will call this itself if it is needed, so
/// you only need to call it if you directly call system networking
/// functions (without calling any GLib networking functions first).
/// </para>
/// </summary>


	public static void NetworkingInit()
	{
		GioGlobalFunctionsExterns.g_networking_init();
	}

/// <summary>
/// <para>
/// Creates a readonly #GSettingsBackend.
/// </para>
/// <para>
/// This backend does not allow changes to settings, so all settings
/// will always have their default values.
/// </para>
/// </summary>

/// <return>
/// a newly created #GSettingsBackend
/// </return>

	public static MentorLake.Gio.GSettingsBackendHandle NullSettingsBackendNew()
	{
		return GioGlobalFunctionsExterns.g_null_settings_backend_new();
	}

/// <summary>
/// <para>
/// Utility method for #GPollableInputStream and #GPollableOutputStream
/// implementations. Creates a new #GSource that expects a callback of
/// type #GPollableSourceFunc. The new source does not actually do
/// anything on its own; use g_source_add_child_source() to add other
/// sources to it to cause it to trigger.
/// </para>
/// </summary>

/// <param name="pollable_stream">
/// the stream associated with the new source
/// </param>
/// <return>
/// the new #GSource.
/// </return>

	public static MentorLake.GLib.GSourceHandle PollableSourceNew(MentorLake.GObject.GObjectHandle pollable_stream)
	{
		return GioGlobalFunctionsExterns.g_pollable_source_new(pollable_stream);
	}

/// <summary>
/// <para>
/// Utility method for #GPollableInputStream and #GPollableOutputStream
/// implementations. Creates a new #GSource, as with
/// g_pollable_source_new(), but also attaching @child_source (with a
/// dummy callback), and @cancellable, if they are non-%NULL.
/// </para>
/// </summary>

/// <param name="pollable_stream">
/// the stream associated with the
///   new source
/// </param>
/// <param name="child_source">
/// optional child source to attach
/// </param>
/// <param name="cancellable">
/// optional #GCancellable to attach
/// </param>
/// <return>
/// the new #GSource.
/// </return>

	public static MentorLake.GLib.GSourceHandle PollableSourceNewFull(MentorLake.GObject.GObjectHandle pollable_stream, MentorLake.GLib.GSourceHandle child_source, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GioGlobalFunctionsExterns.g_pollable_source_new_full(pollable_stream, child_source, cancellable);
	}

/// <summary>
/// <para>
/// Tries to read from @stream, as with g_input_stream_read() (if
/// @blocking is %TRUE) or g_pollable_input_stream_read_nonblocking()
/// (if @blocking is %FALSE). This can be used to more easily share
/// code between blocking and non-blocking implementations of a method.
/// </para>
/// <para>
/// If @blocking is %FALSE, then @stream must be a
/// #GPollableInputStream for which g_pollable_input_stream_can_poll()
/// returns %TRUE, or else the behavior is undefined. If @blocking is
/// %TRUE, then @stream does not need to be a #GPollableInputStream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream
/// </param>
/// <param name="buffer">
/// a buffer to
///   read data into
/// </param>
/// <param name="count">
/// the number of bytes to read
/// </param>
/// <param name="blocking">
/// whether to do blocking I/O
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// the number of bytes read, or -1 on error.
/// </return>

	public static UIntPtr PollableStreamRead(MentorLake.Gio.GInputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_pollable_stream_read(stream, buffer, count, blocking, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to write to @stream, as with g_output_stream_write() (if
/// @blocking is %TRUE) or g_pollable_output_stream_write_nonblocking()
/// (if @blocking is %FALSE). This can be used to more easily share
/// code between blocking and non-blocking implementations of a method.
/// </para>
/// <para>
/// If @blocking is %FALSE, then @stream must be a
/// #GPollableOutputStream for which
/// g_pollable_output_stream_can_poll() returns %TRUE or else the
/// behavior is undefined. If @blocking is %TRUE, then @stream does not
/// need to be a #GPollableOutputStream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="buffer">
/// the buffer
///   containing the data to write.
/// </param>
/// <param name="count">
/// the number of bytes to write
/// </param>
/// <param name="blocking">
/// whether to do blocking I/O
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// the number of bytes written, or -1 on error.
/// </return>

	public static UIntPtr PollableStreamWrite(MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_pollable_stream_write(stream, buffer, count, blocking, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tries to write @count bytes to @stream, as with
/// g_output_stream_write_all(), but using g_pollable_stream_write()
/// rather than g_output_stream_write().
/// </para>
/// <para>
/// On a successful write of @count bytes, %TRUE is returned, and
/// @bytes_written is set to @count.
/// </para>
/// <para>
/// If there is an error during the operation (including
/// %G_IO_ERROR_WOULD_BLOCK in the non-blocking case), %FALSE is
/// returned and @error is set to indicate the error status,
/// @bytes_written is updated to contain the number of bytes written
/// into the stream before the error occurred.
/// </para>
/// <para>
/// As with g_pollable_stream_write(), if @blocking is %FALSE, then
/// @stream must be a #GPollableOutputStream for which
/// g_pollable_output_stream_can_poll() returns %TRUE or else the
/// behavior is undefined. If @blocking is %TRUE, then @stream does not
/// need to be a #GPollableOutputStream.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GOutputStream.
/// </param>
/// <param name="buffer">
/// the buffer
///   containing the data to write.
/// </param>
/// <param name="count">
/// the number of bytes to write
/// </param>
/// <param name="blocking">
/// whether to do blocking I/O
/// </param>
/// <param name="bytes_written">
/// location to store the number of bytes that was
///   written to the stream
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error
/// </return>

	public static bool PollableStreamWriteAll(MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_pollable_stream_write_all(stream, buffer, count, blocking, out bytes_written, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets a reference to the default #GPowerProfileMonitor for the system.
/// </para>
/// </summary>

/// <return>
/// a new reference to the default #GPowerProfileMonitor
/// </return>

	public static MentorLake.Gio.GPowerProfileMonitorHandle PowerProfileMonitorDupDefault()
	{
		return GioGlobalFunctionsExterns.g_power_profile_monitor_dup_default();
	}

/// <summary>
/// <para>
/// Find the `gio-proxy` extension point for a proxy implementation that supports
/// the specified protocol.
/// </para>
/// </summary>

/// <param name="protocol">
/// the proxy protocol name (e.g. http, socks, etc)
/// </param>
/// <return>
/// return a #GProxy or NULL if protocol
///               is not supported.
/// </return>

	public static MentorLake.Gio.GProxyHandle ProxyGetDefaultForProtocol(string protocol)
	{
		return GioGlobalFunctionsExterns.g_proxy_get_default_for_protocol(protocol);
	}

/// <summary>
/// <para>
/// Gets the default #GProxyResolver for the system.
/// </para>
/// </summary>

/// <return>
/// the default #GProxyResolver, which
///     will be a dummy object if no proxy resolver is available
/// </return>

	public static MentorLake.Gio.GProxyResolverHandle ProxyResolverGetDefault()
	{
		return GioGlobalFunctionsExterns.g_proxy_resolver_get_default();
	}

/// <summary>
/// <para>
/// Gets the #GResolver Error Quark.
/// </para>
/// </summary>

/// <return>
/// a #GQuark.
/// </return>

	public static MentorLake.GLib.GQuark ResolverErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_resolver_error_quark();
	}

/// <summary>
/// <para>
/// Gets the [struct@Gio.Resource] Error Quark.
/// </para>
/// </summary>

/// <return>
/// a [type@GLib.Quark]
/// </return>

	public static MentorLake.GLib.GQuark ResourceErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_resource_error_quark();
	}

/// <summary>
/// <para>
/// Loads a binary resource bundle and creates a [struct@Gio.Resource]
/// representation of it, allowing you to query it for data.
/// </para>
/// <para>
/// If you want to use this resource in the global resource namespace you need
/// to register it with [func@Gio.resources_register].
/// </para>
/// <para>
/// If @filename is empty or the data in it is corrupt,
/// %G_RESOURCE_ERROR_INTERNAL will be returned. If @filename doesn’t exist, or
/// there is an error in reading it, an error from [ctor@GLib.MappedFile.new]
/// will be returned.
/// </para>
/// </summary>

/// <param name="filename">
/// the path of a filename to load, in the GLib filename encoding
/// </param>
/// <return>
/// a new [struct@Gio.Resource], or `NULL` on error
/// </return>

	public static MentorLake.Gio.GResourceHandle ResourceLoad(string filename)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resource_load(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns all the names of children at the specified @path in the set of
/// globally registered resources.
/// </para>
/// <para>
/// The return result is a `NULL` terminated list of strings which should
/// be released with [func@GLib.strfreev].
/// </para>
/// <para>
/// @lookup_flags controls the behaviour of the lookup.
/// </para>
/// </summary>

/// <param name="path">
/// A path name inside the resource
/// </param>
/// <param name="lookup_flags">
/// A [flags@Gio.ResourceLookupFlags]
/// </param>
/// <return>
/// an array of constant strings
/// </return>

	public static string[] ResourcesEnumerateChildren(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resources_enumerate_children(path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks for a file at the specified @path in the set of
/// globally registered resources and if found returns information about it.
/// </para>
/// <para>
/// @lookup_flags controls the behaviour of the lookup.
/// </para>
/// </summary>

/// <param name="path">
/// A path name inside the resource
/// </param>
/// <param name="lookup_flags">
/// A [flags@Gio.ResourceLookupFlags]
/// </param>
/// <param name="size">
/// a location to place the length of the contents of the file,
///    or `NULL` if the length is not needed
/// </param>
/// <param name="flags">
/// a location to place the [flags@Gio.ResourceFlags] about the file,
///    or `NULL` if the flags are not needed
/// </param>
/// <return>
/// `TRUE` if the file was found, `FALSE` if there were errors
/// </return>

	public static bool ResourcesGetInfo(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resources_get_info(path, lookup_flags, out size, out flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns whether the specified @path in the set of
/// globally registered resources has children.
/// </para>
/// </summary>

/// <param name="path">
/// A pathname
/// </param>
/// <return>
/// %TRUE if @patch has children
/// </return>

	public static bool ResourcesHasChildren(string path)
	{
		return GioGlobalFunctionsExterns.g_resources_has_children(path);
	}

/// <summary>
/// <para>
/// Looks for a file at the specified @path in the set of
/// globally registered resources and returns a [struct@GLib.Bytes] that
/// lets you directly access the data in memory.
/// </para>
/// <para>
/// The data is always followed by a zero byte, so you
/// can safely use the data as a C string. However, that byte
/// is not included in the size of the [struct@GLib.Bytes].
/// </para>
/// <para>
/// For uncompressed resource files this is a pointer directly into
/// the resource bundle, which is typically in some read-only data section
/// in the program binary. For compressed files we allocate memory on
/// the heap and automatically uncompress the data.
/// </para>
/// <para>
/// @lookup_flags controls the behaviour of the lookup.
/// </para>
/// </summary>

/// <param name="path">
/// A path name inside the resource
/// </param>
/// <param name="lookup_flags">
/// A [flags@Gio.ResourceLookupFlags]
/// </param>
/// <return>
/// [struct@GLib.Bytes] or `NULL` on error
/// </return>

	public static MentorLake.GLib.GBytesHandle ResourcesLookupData(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resources_lookup_data(path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks for a file at the specified @path in the set of
/// globally registered resources and returns a [class@Gio.InputStream]
/// that lets you read the data.
/// </para>
/// <para>
/// @lookup_flags controls the behaviour of the lookup.
/// </para>
/// </summary>

/// <param name="path">
/// A path name inside the resource
/// </param>
/// <param name="lookup_flags">
/// A [flags@Gio.ResourceLookupFlags]
/// </param>
/// <return>
/// [class@Gio.InputStream] or `NULL` on error
/// </return>

	public static MentorLake.Gio.GInputStreamHandle ResourcesOpenStream(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_resources_open_stream(path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Registers the resource with the process-global set of resources.
/// </para>
/// <para>
/// Once a resource is registered the files in it can be accessed
/// with the global resource lookup functions like
/// [func@Gio.resources_lookup_data].
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>

	public static void ResourcesRegister(MentorLake.Gio.GResourceHandle resource)
	{
		GioGlobalFunctionsExterns.g_resources_register(resource);
	}

/// <summary>
/// <para>
/// Unregisters the resource from the process-global set of resources.
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>

	public static void ResourcesUnregister(MentorLake.Gio.GResourceHandle resource)
	{
		GioGlobalFunctionsExterns.g_resources_unregister(resource);
	}

/// <summary>
/// <para>
/// Gets the default system schema source.
/// </para>
/// <para>
/// This function is not required for normal uses of #GSettings but it
/// may be useful to authors of plugin management systems or to those who
/// want to introspect the content of schemas.
/// </para>
/// <para>
/// If no schemas are installed, %NULL will be returned.
/// </para>
/// <para>
/// The returned source may actually consist of multiple schema sources
/// from different directories, depending on which directories were given
/// in `XDG_DATA_DIRS` and `GSETTINGS_SCHEMA_DIR`. For this reason, all
/// lookups performed against the default source should probably be done
/// recursively.
/// </para>
/// </summary>

/// <return>
/// the default schema source
/// </return>

	public static MentorLake.Gio.GSettingsSchemaSourceHandle SettingsSchemaSourceGetDefault()
	{
		return GioGlobalFunctionsExterns.g_settings_schema_source_get_default();
	}

/// <summary>
/// <para>
/// Reports an error in an asynchronous function in an idle function by
/// directly setting the contents of the #GAsyncResult with the given error
/// information.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject, or %NULL.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>
/// <param name="domain">
/// a #GQuark containing the error domain (usually %G_IO_ERROR).
/// </param>
/// <param name="code">
/// a specific error code.
/// </param>
/// <param name="format">
/// a formatted error reporting string.
/// </param>
/// <param name="@__arglist">
/// a list of variables to fill in @format.
/// </param>

	public static void SimpleAsyncReportErrorInIdle(MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GioGlobalFunctionsExterns.g_simple_async_report_error_in_idle(@object, callback, user_data, domain, code, format, @__arglist);
	}

/// <summary>
/// <para>
/// Reports an error in an idle function. Similar to
/// g_simple_async_report_error_in_idle(), but takes a #GError rather
/// than building a new one.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject, or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>
/// <param name="error">
/// the #GError to report
/// </param>

	public static void SimpleAsyncReportGerrorInIdle(MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GErrorHandle error)
	{
		GioGlobalFunctionsExterns.g_simple_async_report_gerror_in_idle(@object, callback, user_data, error);
	}

/// <summary>
/// <para>
/// Reports an error in an idle function. Similar to
/// g_simple_async_report_gerror_in_idle(), but takes over the caller&apos;s
/// ownership of @error, so the caller does not have to free it any more.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject, or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback.
/// </param>
/// <param name="user_data">
/// user data passed to @callback.
/// </param>
/// <param name="error">
/// the #GError to report
/// </param>

	public static void SimpleAsyncReportTakeGerrorInIdle(MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GErrorHandle error)
	{
		GioGlobalFunctionsExterns.g_simple_async_report_take_gerror_in_idle(@object, callback, user_data, error);
	}

/// <summary>
/// <para>
/// Sorts @targets in place according to the algorithm in RFC 2782.
/// </para>
/// </summary>

/// <param name="targets">
/// a #GList of #GSrvTarget
/// </param>
/// <return>
/// the head of the sorted list.
/// </return>

	public static MentorLake.GLib.GListHandle SrvTargetListSort(MentorLake.GLib.GListHandle targets)
	{
		return GioGlobalFunctionsExterns.g_srv_target_list_sort(targets);
	}

/// <summary>
/// <para>
/// Gets the default #GTlsBackend for the system.
/// </para>
/// </summary>

/// <return>
/// a #GTlsBackend, which will be a
///     dummy object if no TLS backend is available
/// </return>

	public static MentorLake.Gio.GTlsBackendHandle TlsBackendGetDefault()
	{
		return GioGlobalFunctionsExterns.g_tls_backend_get_default();
	}

/// <summary>
/// <para>
/// Gets the TLS channel binding error quark.
/// </para>
/// </summary>

/// <return>
/// a #GQuark.
/// </return>

	public static MentorLake.GLib.GQuark TlsChannelBindingErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_tls_channel_binding_error_quark();
	}

/// <summary>
/// <para>
/// Creates a new #GTlsClientConnection wrapping @base_io_stream (which
/// must have pollable input and output streams) which is assumed to
/// communicate with the server identified by @server_identity.
/// </para>
/// <para>
/// See the documentation for #GTlsConnection:base-io-stream for restrictions
/// on when application code can run operations on the @base_io_stream after
/// this function has returned.
/// </para>
/// </summary>

/// <param name="base_io_stream">
/// the #GIOStream to wrap
/// </param>
/// <param name="server_identity">
/// the expected identity of the server
/// </param>
/// <return>
/// the new
/// #GTlsClientConnection, or %NULL on error
/// </return>

	public static MentorLake.Gio.GIOStreamHandle TlsClientConnectionNew(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GSocketConnectableHandle server_identity)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_tls_client_connection_new(base_io_stream, server_identity, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the TLS error quark.
/// </para>
/// </summary>

/// <return>
/// a #GQuark.
/// </return>

	public static MentorLake.GLib.GQuark TlsErrorQuark()
	{
		return GioGlobalFunctionsExterns.g_tls_error_quark();
	}

/// <summary>
/// <para>
/// Creates a new #GTlsFileDatabase which uses anchor certificate authorities
/// in @anchors to verify certificate chains.
/// </para>
/// <para>
/// The certificates in @anchors must be PEM encoded.
/// </para>
/// </summary>

/// <param name="anchors">
/// filename of anchor certificate authorities.
/// </param>
/// <return>
/// the new
/// #GTlsFileDatabase, or %NULL on error
/// </return>

	public static MentorLake.Gio.GTlsDatabaseHandle TlsFileDatabaseNew(string anchors)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_tls_file_database_new(anchors, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new #GTlsServerConnection wrapping @base_io_stream (which
/// must have pollable input and output streams).
/// </para>
/// <para>
/// See the documentation for #GTlsConnection:base-io-stream for restrictions
/// on when application code can run operations on the @base_io_stream after
/// this function has returned.
/// </para>
/// </summary>

/// <param name="base_io_stream">
/// the #GIOStream to wrap
/// </param>
/// <param name="certificate">
/// the default server certificate, or %NULL
/// </param>
/// <return>
/// the new
/// #GTlsServerConnection, or %NULL on error
/// </return>

	public static MentorLake.Gio.GIOStreamHandle TlsServerConnectionNew(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		var externCallResult = GioGlobalFunctionsExterns.g_tls_server_connection_new(base_io_stream, certificate, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Determines if @mount_path is considered an implementation of the
/// OS.
/// </para>
/// <para>
/// This is primarily used for hiding mountable and mounted volumes
/// that only are used in the OS and has little to no relevance to the
/// casual user.
/// </para>
/// </summary>

/// <param name="mount_path">
/// a mount path, e.g. `/media/disk` or `/usr`
/// </param>
/// <return>
/// true if @mount_path is considered an implementation detail
///    of the OS; false otherwise
/// </return>

	public static bool UnixIsMountPathSystemInternal(string mount_path)
	{
		return GioGlobalFunctionsExterns.g_unix_is_mount_path_system_internal(mount_path);
	}

/// <summary>
/// <para>
/// Determines if @device_path is considered a block device path which is only
/// used in implementation of the OS.
/// </para>
/// <para>
/// This is primarily used for hiding mounted volumes that are intended as APIs
/// for programs to read, and system administrators at a shell; rather than
/// something that should, for example, appear in a GUI. For example, the Linux
/// `/proc` filesystem.
/// </para>
/// <para>
/// The list of device paths considered ‘system’ ones may change over time.
/// </para>
/// </summary>

/// <param name="device_path">
/// a device path, e.g. `/dev/loop0` or `nfsd`
/// </param>
/// <return>
/// true if @device_path is considered an implementation detail of
///    the OS; false otherwise
/// </return>

	public static bool UnixIsSystemDevicePath(string device_path)
	{
		return GioGlobalFunctionsExterns.g_unix_is_system_device_path(device_path);
	}

/// <summary>
/// <para>
/// Determines if @fs_type is considered a type of file system which is only
/// used in implementation of the OS.
/// </para>
/// <para>
/// This is primarily used for hiding mounted volumes that are intended as APIs
/// for programs to read, and system administrators at a shell; rather than
/// something that should, for example, appear in a GUI. For example, the Linux
/// `/proc` filesystem.
/// </para>
/// <para>
/// The list of file system types considered ‘system’ ones may change over time.
/// </para>
/// </summary>

/// <param name="fs_type">
/// a file system type, e.g. `procfs` or `tmpfs`
/// </param>
/// <return>
/// true if @fs_type is considered an implementation detail of the OS;
///    false otherwise
/// </return>

	public static bool UnixIsSystemFsType(string fs_type)
	{
		return GioGlobalFunctionsExterns.g_unix_is_system_fs_type(fs_type);
	}

/// <summary>
/// <para>
/// Gets a [struct@GioUnix.MountEntry] for a given mount path.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with a Unix timestamp for checking
/// if the mounts have changed since with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// <para>
/// If more mounts have the same mount path, the last matching mount
/// is returned.
/// </para>
/// <para>
/// This will return `NULL` if there is no mount point at @mount_path.
/// </para>
/// </summary>

/// <param name="mount_path">
/// path for a possible Unix mount
/// </param>
/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a [struct@GioUnix.MountEntry]
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountAt(string mount_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_at(mount_path, out time_read);
	}

/// <summary>
/// <para>
/// Compares two Unix mounts.
/// </para>
/// </summary>

/// <param name="mount1">
/// first [struct@GioUnix.MountEntry] to compare
/// </param>
/// <param name="mount2">
/// second [struct@GioUnix.MountEntry] to compare
/// </param>
/// <return>
/// `1`, `0` or `-1` if @mount1 is greater than, equal to,
///    or less than @mount2, respectively
/// </return>

	public static int UnixMountCompare(MentorLake.Gio.GUnixMountEntryHandle mount1, MentorLake.Gio.GUnixMountEntryHandle mount2)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_compare(mount1, mount2);
	}

/// <summary>
/// <para>
/// Makes a copy of @mount_entry.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a new [struct@GioUnix.MountEntry]
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountCopy(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_copy(mount_entry);
	}

/// <summary>
/// <para>
/// Checks if the Unix mounts have changed since a given Unix time.
/// </para>
/// <para>
/// This can only work reliably if a [class@GioUnix.MountMonitor] is running in
/// the process, otherwise changes in the mount entries file (such as
/// `/proc/self/mountinfo` on Linux) cannot be detected and, as a result, this
/// function has to conservatively always return `TRUE`.
/// </para>
/// <para>
/// It is more efficient to use [signal@GioUnix.MountMonitor::mounts-changed] to
/// be signalled of changes to the mount entries, rather than polling using this
/// function. This function is more appropriate for infrequently determining
/// cache validity.
/// </para>
/// </summary>

/// <param name="time">
/// a timestamp
/// </param>
/// <return>
/// true if the mounts have changed since @time; false otherwise
/// Since 2.84
/// </return>

	public static bool UnixMountEntriesChangedSince(ulong time)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entries_changed_since(time);
	}

/// <summary>
/// <para>
/// Gets a list of [struct@GioUnix.MountEntry] instances representing the Unix
/// mounts.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with the mount timestamp, allowing
/// for checking if the mounts have changed with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// </summary>

/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a list of the
///    Unix mounts
/// </return>

	public static MentorLake.GLib.GListHandle UnixMountEntriesGet(out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entries_get(out time_read);
	}

/// <summary>
/// <para>
/// Gets an array of [struct@Gio.UnixMountEntry]s containing the Unix mounts
/// listed in @table_path.
/// </para>
/// <para>
/// This is a generalized version of [func@GioUnix.mount_entries_get], mainly
/// intended for internal testing use. Note that [func@GioUnix.mount_entries_get]
/// may parse multiple hierarchical table files, so this function is not a direct
/// superset of its functionality.
/// </para>
/// <para>
/// If there is an error reading or parsing the file, `NULL` will be returned
/// and both out parameters will be set to `0`.
/// </para>
/// </summary>

/// <param name="table_path">
/// path to the mounts table file (for example `/proc/self/mountinfo`)
/// </param>
/// <param name="time_read_out">
/// return location for the
///   modification time of @table_path
/// </param>
/// <param name="n_entries_out">
/// return location for the
///   number of mount entries returned
/// </param>
/// <return>
/// mount
///   entries, or `NULL` if there was an error loading them
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle[] UnixMountEntriesGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_entries_out)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entries_get_from_file(table_path, out time_read_out, out n_entries_out);
	}

/// <summary>
/// <para>
/// Gets a [struct@GioUnix.MountEntry] for a given mount path.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with a Unix timestamp for checking
/// if the mounts have changed since with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// <para>
/// If more mounts have the same mount path, the last matching mount
/// is returned.
/// </para>
/// <para>
/// This will return `NULL` if there is no mount point at @mount_path.
/// </para>
/// </summary>

/// <param name="mount_path">
/// path for a possible Unix mount
/// </param>
/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a [struct@GioUnix.MountEntry]
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountEntryAt(string mount_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entry_at(mount_path, out time_read);
	}

/// <summary>
/// <para>
/// Gets a [struct@GioUnix.MountEntry] for a given file path.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with a Unix timestamp for checking
/// if the mounts have changed since with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// <para>
/// If more mounts have the same mount path, the last matching mount
/// is returned.
/// </para>
/// <para>
/// This will return `NULL` if looking up the mount entry fails, if
/// @file_path doesn’t exist or there is an I/O error.
/// </para>
/// </summary>

/// <param name="file_path">
/// file path on some Unix mount
/// </param>
/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a [struct@GioUnix.MountEntry]
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountEntryFor(string file_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_entry_for(file_path, out time_read);
	}

/// <summary>
/// <para>
/// Gets a [struct@GioUnix.MountEntry] for a given file path.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with a Unix timestamp for checking
/// if the mounts have changed since with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// <para>
/// If more mounts have the same mount path, the last matching mount
/// is returned.
/// </para>
/// <para>
/// This will return `NULL` if looking up the mount entry fails, if
/// @file_path doesn’t exist or there is an I/O error.
/// </para>
/// </summary>

/// <param name="file_path">
/// file path on some Unix mount
/// </param>
/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a [struct@GioUnix.MountEntry]
/// </return>

	public static MentorLake.Gio.GUnixMountEntryHandle UnixMountFor(string file_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_for(file_path, out time_read);
	}

/// <summary>
/// <para>
/// Frees a Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>

	public static void UnixMountFree(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		GioGlobalFunctionsExterns.g_unix_mount_free(mount_entry);
	}

/// <summary>
/// <para>
/// Gets the device path for a Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a string containing the device path
/// </return>

	public static string UnixMountGetDevicePath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_device_path(mount_entry);
	}

/// <summary>
/// <para>
/// Gets the filesystem type for the Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a string containing the file system type
/// </return>

	public static string UnixMountGetFsType(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_fs_type(mount_entry);
	}

/// <summary>
/// <para>
/// Gets the mount path for a Unix mount.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry] to get the mount path for
/// </param>
/// <return>
/// the mount path for @mount_entry
/// </return>

	public static string UnixMountGetMountPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_mount_path(mount_entry);
	}

/// <summary>
/// <para>
/// Gets a comma separated list of mount options for the Unix mount.
/// </para>
/// <para>
/// For example: `rw,relatime,seclabel,data=ordered`.
/// </para>
/// <para>
/// This is similar to [func@GioUnix.MountPoint.get_options], but it takes
/// a [struct@GioUnix.MountEntry] as an argument.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a string containing the options, or `NULL` if not
///    available.
/// </return>

	public static string UnixMountGetOptions(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_options(mount_entry);
	}

/// <summary>
/// <para>
/// Gets the root of the mount within the filesystem. This is useful e.g. for
/// mounts created by bind operation, or btrfs subvolumes.
/// </para>
/// <para>
/// For example, the root path is equal to `/` for a mount created by
/// `mount /dev/sda1 /mnt/foo` and `/bar` for
/// `mount --bind /mnt/foo/bar /mnt/bar`.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a string containing the root, or `NULL` if not supported
/// </return>

	public static string UnixMountGetRootPath(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_get_root_path(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses whether a Unix mount entry can be ejected.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// true if @mount_entry is deemed to be ejectable; false otherwise
/// </return>

	public static bool UnixMountGuessCanEject(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_can_eject(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses the icon of a Unix mount entry.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a [iface@Gio.Icon]
/// </return>

	public static MentorLake.Gio.GIconHandle UnixMountGuessIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_icon(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses the name of a Unix mount entry.
/// </para>
/// <para>
/// The result is a translated string.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a newly allocated translated string
/// </return>

	public static string UnixMountGuessName(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_name(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses whether a Unix mount entry should be displayed in the UI.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// true if @mount_entry is deemed to be displayable; false otherwise
/// </return>

	public static bool UnixMountGuessShouldDisplay(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_should_display(mount_entry);
	}

/// <summary>
/// <para>
/// Guesses the symbolic icon of a Unix mount entry.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// a [iface@Gio.Icon]
/// </return>

	public static MentorLake.Gio.GIconHandle UnixMountGuessSymbolicIcon(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_guess_symbolic_icon(mount_entry);
	}

/// <summary>
/// <para>
/// Checks if a Unix mount is mounted read only.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// true if @mount_entry is read only; false otherwise
/// </return>

	public static bool UnixMountIsReadonly(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_is_readonly(mount_entry);
	}

/// <summary>
/// <para>
/// Checks if a Unix mount is a system mount.
/// </para>
/// <para>
/// This is the Boolean OR of
/// [func@GioUnix.is_system_fs_type], [func@GioUnix.is_system_device_path] and
/// [func@GioUnix.is_mount_path_system_internal] on @mount_entry’s properties.
/// </para>
/// <para>
/// The definition of what a ‘system’ mount entry is may change over time as new
/// file system types and device paths are ignored.
/// </para>
/// </summary>

/// <param name="mount_entry">
/// a [struct@GioUnix.MountEntry]
/// </param>
/// <return>
/// true if the Unix mount is for a system path; false otherwise
/// </return>

	public static bool UnixMountIsSystemInternal(MentorLake.Gio.GUnixMountEntryHandle mount_entry)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_is_system_internal(mount_entry);
	}

/// <summary>
/// <para>
/// Gets a [struct@GioUnix.MountPoint] for a given mount path.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with a Unix timestamp for checking if
/// the mount points have changed since with
/// [func@GioUnix.mount_points_changed_since].
/// </para>
/// <para>
/// If more mount points have the same mount path, the last matching mount point
/// is returned.
/// </para>
/// </summary>

/// <param name="mount_path">
/// path for a possible Unix mount point
/// </param>
/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a [struct@GioUnix.MountPoint], or `NULL`
///    if no match is found
/// </return>

	public static MentorLake.Gio.GUnixMountPointHandle UnixMountPointAt(string mount_path, out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_point_at(mount_path, out time_read);
	}

/// <summary>
/// <para>
/// Checks if the Unix mount points have changed since a given Unix time.
/// </para>
/// <para>
/// Unlike [func@GioUnix.mount_entries_changed_since], this function can work
/// reliably without a [class@GioUnix.MountMonitor] running, as it accesses the
/// static mount point information (such as `/etc/fstab` on Linux), which has a
/// valid modification time.
/// </para>
/// <para>
/// It is more efficient to use [signal@GioUnix.MountMonitor::mountpoints-changed]
/// to be signalled of changes to the mount points, rather than polling using
/// this function. This function is more appropriate for infrequently determining
/// cache validity.
/// </para>
/// </summary>

/// <param name="time">
/// a timestamp
/// </param>
/// <return>
/// true if the mount points have changed since @time; false otherwise
/// </return>

	public static bool UnixMountPointsChangedSince(ulong time)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_points_changed_since(time);
	}

/// <summary>
/// <para>
/// Gets a list of [struct@GioUnix.MountPoint] instances representing the Unix
/// mount points.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with the mount timestamp, allowing
/// for checking if the mounts have changed with
/// [func@GioUnix.mount_points_changed_since].
/// </para>
/// </summary>

/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a list of the Unix
///    mount points
/// </return>

	public static MentorLake.GLib.GListHandle UnixMountPointsGet(out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_points_get(out time_read);
	}

/// <summary>
/// <para>
/// Gets an array of [struct@Gio.UnixMountPoint]s containing the Unix mount
/// points listed in @table_path.
/// </para>
/// <para>
/// This is a generalized version of [func@GioUnix.mount_points_get], mainly
/// intended for internal testing use. Note that [func@GioUnix.mount_points_get]
/// may parse multiple hierarchical table files, so this function is not a direct
/// superset of its functionality.
/// </para>
/// <para>
/// If there is an error reading or parsing the file, `NULL` will be returned
/// and both out parameters will be set to `0`.
/// </para>
/// </summary>

/// <param name="table_path">
/// path to the mount points table file (for example `/etc/fstab`)
/// </param>
/// <param name="time_read_out">
/// return location for the
///   modification time of @table_path
/// </param>
/// <param name="n_points_out">
/// return location for the
///   number of mount points returned
/// </param>
/// <return>
/// mount
///   points, or `NULL` if there was an error loading them
/// </return>

	public static MentorLake.Gio.GUnixMountPointHandle[] UnixMountPointsGetFromFile(string table_path, out ulong time_read_out, out UIntPtr n_points_out)
	{
		return GioGlobalFunctionsExterns.g_unix_mount_points_get_from_file(table_path, out time_read_out, out n_points_out);
	}

/// <summary>
/// <para>
/// Checks if the Unix mounts have changed since a given Unix time.
/// </para>
/// </summary>

/// <param name="time">
/// a timestamp
/// </param>
/// <return>
/// true if the mounts have changed since @time; false otherwise
/// </return>

	public static bool UnixMountsChangedSince(ulong time)
	{
		return GioGlobalFunctionsExterns.g_unix_mounts_changed_since(time);
	}

/// <summary>
/// <para>
/// Gets a list of [struct@GioUnix.MountEntry] instances representing the Unix
/// mounts.
/// </para>
/// <para>
/// If @time_read is set, it will be filled with the mount timestamp, allowing
/// for checking if the mounts have changed with
/// [func@GioUnix.mount_entries_changed_since].
/// </para>
/// </summary>

/// <param name="time_read">
/// return location for a timestamp
/// </param>
/// <return>
/// a list of the
///    Unix mounts
/// </return>

	public static MentorLake.GLib.GListHandle UnixMountsGet(out ulong time_read)
	{
		return GioGlobalFunctionsExterns.g_unix_mounts_get(out time_read);
	}

/// <summary>
/// <para>
/// Gets an array of [struct@Gio.UnixMountEntry]s containing the Unix mounts
/// listed in @table_path.
/// </para>
/// <para>
/// This is a generalized version of [func@GioUnix.mount_entries_get], mainly
/// intended for internal testing use. Note that [func@GioUnix.mount_entries_get]
/// may parse multiple hierarchical table files, so this function is not a direct
/// superset of its functionality.
/// </para>
/// <para>
/// If there is an error reading or parsing the file, `NULL` will be returned
/// and both out parameters will be set to `0`.
/// </para>
/// </summary>

/// <param name="table_path">
/// path to the mounts table file (for example `/proc/self/mountinfo`)
/// </param>
/// <param name="time_read_out">
/// return location for the
///   modification time of @table_path
/// </param>
/// <param name="n_entries_out">
/// return location for the
///   number of mount entries returned
/// </param>
/// <return>
/// mount
///   entries, or `NULL` if there was an error loading them
/// </return>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_create_from_commandline(string commandline, string application_name, MentorLake.Gio.GAppInfoCreateFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_all();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_all_for_type(string content_type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_type(string content_type, bool must_support_uris);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_get_default_for_type_async(string content_type, bool must_support_uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_type_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_uri_scheme(string uri_scheme);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_get_default_for_uri_scheme_async(string uri_scheme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_uri_scheme_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_fallback_for_type(string content_type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_bus_get_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_content_type_get_icon(string type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_content_type_get_mime_dirs();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_content_type_get_mime_type(string type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_content_type_get_symbolic_icon(string type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_content_type_guess(string filename, byte[] data, UIntPtr data_size, out bool result_uncertain);

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_dbus_address_get_stream_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out string out_guid, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))]
	internal static extern MentorLake.Gio.GDatagramBasedHandle g_dtls_client_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle base_socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle server_identity, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))]
	internal static extern MentorLake.Gio.GDatagramBasedHandle g_dtls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle base_socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_build_filenamev(string[] args);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_commandline_arg(string arg);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_commandline_arg_and_cwd(string arg, string cwd);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_path(string path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_for_uri(string uri);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp(string tmpl, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] out MentorLake.Gio.GFileIOStreamHandle iostream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_new_tmp_async(string tmpl, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_new_tmp_dir_async(string tmpl, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp_dir_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_new_tmp_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] out MentorLake.Gio.GFileIOStreamHandle iostream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_parse_name(string parse_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_icon_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_icon_new_for_string(string str, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_initable_newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOErrorEnum g_io_error_from_errno(int err_no);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOErrorEnum g_io_error_from_file_error(MentorLake.GLib.GFileError file_error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_io_error_quark();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionHandle>))]
	internal static extern MentorLake.Gio.GIOExtensionHandle g_io_extension_point_implement(string extension_point_name, MentorLake.GObject.GType type, string extension_name, int priority);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))]
	internal static extern MentorLake.Gio.GIOExtensionPointHandle g_io_extension_point_lookup(string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))]
	internal static extern MentorLake.Gio.GIOExtensionPointHandle g_io_extension_point_register(string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_io_modules_load_all_in_directory(string dirname);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))]
	internal static extern MentorLake.Gio.GSettingsBackendHandle g_keyfile_settings_backend_new(string filename, string root_path, string root_group);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryMonitorHandleImpl>))]
	internal static extern MentorLake.Gio.GMemoryMonitorHandle g_memory_monitor_dup_default();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))]
	internal static extern MentorLake.Gio.GSettingsBackendHandle g_memory_settings_backend_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkMonitorHandleImpl>))]
	internal static extern MentorLake.Gio.GNetworkMonitorHandle g_network_monitor_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_networking_init();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))]
	internal static extern MentorLake.Gio.GSettingsBackendHandle g_null_settings_backend_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_pollable_source_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle pollable_stream);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_pollable_source_new_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle pollable_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle child_source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_pollable_stream_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_pollable_stream_write([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_stream_write_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, byte[] buffer, UIntPtr count, bool blocking, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPowerProfileMonitorHandleImpl>))]
	internal static extern MentorLake.Gio.GPowerProfileMonitorHandle g_power_profile_monitor_dup_default();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyHandleImpl>))]
	internal static extern MentorLake.Gio.GProxyHandle g_proxy_get_default_for_protocol(string protocol);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))]
	internal static extern MentorLake.Gio.GProxyResolverHandle g_proxy_resolver_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_resolver_error_quark();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_resource_error_quark();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))]
	internal static extern MentorLake.Gio.GResourceHandle g_resource_load(string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_resources_enumerate_children(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_resources_get_info(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_resources_has_children(string path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_resources_lookup_data(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_resources_open_stream(string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resources_register([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resources_unregister([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))]
	internal static extern MentorLake.Gio.GSettingsSchemaSourceHandle g_settings_schema_source_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_report_error_in_idle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_report_gerror_in_idle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_report_take_gerror_in_idle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_srv_target_list_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle targets);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))]
	internal static extern MentorLake.Gio.GTlsBackendHandle g_tls_backend_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_tls_channel_binding_error_quark();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tls_client_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle server_identity, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_tls_error_quark();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_tls_file_database_new(string anchors, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_is_mount_path_system_internal(string mount_path);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_is_system_device_path(string device_path);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_is_system_fs_type(string fs_type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_at(string mount_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_mount_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount2);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_entries_changed_since(ulong time);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_unix_mount_entries_get(out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle[] g_unix_mount_entries_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_entries_out);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_at(string mount_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle g_unix_mount_entry_for(string file_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_guess_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_unix_mount_guess_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_guess_should_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_unix_mount_guess_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_is_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_is_system_internal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountEntryHandle>))] MentorLake.Gio.GUnixMountEntryHandle mount_entry);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountPointHandle>))]
	internal static extern MentorLake.Gio.GUnixMountPointHandle g_unix_mount_point_at(string mount_path, out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mount_points_changed_since(ulong time);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_unix_mount_points_get(out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountPointHandle[] g_unix_mount_points_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_points_out);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_mounts_changed_since(ulong time);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_unix_mounts_get(out ulong time_read);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountEntryHandle[] g_unix_mounts_get_from_file(string table_path, out ulong time_read_out, out UIntPtr n_entries_out);

}
