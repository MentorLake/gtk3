namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about an installed application and methods to launch
/// it (with file arguments).
/// </para>
/// <para>
/// `GAppInfo` and `GAppLaunchContext` are used for describing and launching
/// applications installed on the system.
/// </para>
/// <para>
/// As of GLib 2.20, URIs will always be converted to POSIX paths
/// (using [method@Gio.File.get_path]) when using [method@Gio.AppInfo.launch]
/// even if the application requested an URI and not a POSIX path. For example
/// for a desktop-file based application with the following Exec key:
/// </para>
/// <para>
/// ```
/// Exec=totem %U
/// ```
/// </para>
/// <para>
/// and a single URI, `sftp://foo/file.avi`, then
/// `/home/user/.gvfs/sftp on foo/file.avi` will be passed. This will only work
/// if a set of suitable GIO extensions (such as GVfs 2.26 compiled with FUSE
/// support), is available and operational; if this is not the case, the URI
/// will be passed unmodified to the application. Some URIs, such as `mailto:`,
/// of course cannot be mapped to a POSIX path (in GVfs there’s no FUSE mount
/// for it); such URIs will be passed unmodified to the application.
/// </para>
/// <para>
/// Specifically for GVfs 2.26 and later, the POSIX URI will be mapped
/// back to the GIO URI in the [iface@Gio.File] constructors (since GVfs
/// implements the GVfs extension point). As such, if the application
/// needs to examine the URI, it needs to use [method@Gio.File.get_uri]
/// or similar on [iface@Gio.File]. In other words, an application cannot
/// assume that the URI passed to e.g. [func@Gio.File.new_for_commandline_arg]
/// is equal to the result of [method@Gio.File.get_uri]. The following snippet
/// illustrates this:
/// </para>
/// <para>
/// ```c
/// GFile *f;
/// char *uri;
/// </para>
/// <para>
/// file = g_file_new_for_commandline_arg (uri_from_commandline);
/// </para>
/// <para>
/// uri = g_file_get_uri (file);
/// strcmp (uri, uri_from_commandline) == 0;
/// g_free (uri);
/// </para>
/// <para>
/// if (g_file_has_uri_scheme (file, &quot;cdda&quot;))
///   {
///     // do something special with uri
///   }
/// g_object_unref (file);
/// ```
/// </para>
/// <para>
/// This code will work when both `cdda://sr0/Track 1.wav` and
/// `/home/user/.gvfs/cdda on sr0/Track 1.wav` is passed to the
/// application. It should be noted that it’s generally not safe
/// for applications to rely on the format of a particular URIs.
/// Different launcher applications (e.g. file managers) may have
/// different ideas of what a given URI means.
/// </para>
/// </summary>

public interface GAppInfoHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GAppInfoHandleImpl : BaseSafeHandle, GAppInfoHandle
{
}

public static class GAppInfoHandleExtensions
{
/// <summary>
/// <para>
/// Adds a content type to the application information to indicate the
/// application is capable of opening files with the given content type.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="content_type">
/// a string.
/// </param>
/// <return>
/// `TRUE` on success, `FALSE` on error.
/// </return>

	public static bool AddSupportsType(this MentorLake.Gio.GAppInfoHandle appinfo, string content_type)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		var externCallResult = GAppInfoHandleExterns.g_app_info_add_supports_type(appinfo, content_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtains the information whether the [iface@Gio.AppInfo] can be deleted.
/// See [method@Gio.AppInfo.delete].
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// `TRUE` if @appinfo can be deleted
/// </return>

	public static bool CanDelete(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_can_delete(appinfo);
	}

/// <summary>
/// <para>
/// Checks if a supported content type can be removed from an application.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// `TRUE` if it is possible to remove supported content types from a
///   given @appinfo, `FALSE` if not.
/// </return>

	public static bool CanRemoveSupportsType(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_can_remove_supports_type(appinfo);
	}

/// <summary>
/// <para>
/// Tries to delete a [iface@Gio.AppInfo].
/// </para>
/// <para>
/// On some platforms, there may be a difference between user-defined
/// [iface@Gio.AppInfo]s which can be deleted, and system-wide ones which cannot.
/// See [method@Gio.AppInfo.can_delete].
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// `TRUE` if @appinfo has been deleted
/// </return>

	public static bool Delete(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_delete(appinfo);
	}

/// <summary>
/// <para>
/// Creates a duplicate of a [iface@Gio.AppInfo].
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// a duplicate of @appinfo.
/// </return>

	public static MentorLake.Gio.GAppInfoHandle Dup(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_dup(appinfo);
	}

/// <summary>
/// <para>
/// Checks if two [iface@Gio.AppInfo]s are equal.
/// </para>
/// <para>
/// Note that the check *may not* compare each individual field, and only does
/// an identity check. In case detecting changes in the contents is needed,
/// program code must additionally compare relevant fields.
/// </para>
/// </summary>

/// <param name="appinfo1">
/// the first [iface@Gio.AppInfo].
/// </param>
/// <param name="appinfo2">
/// the second [iface@Gio.AppInfo].
/// </param>
/// <return>
/// `TRUE` if @appinfo1 is equal to @appinfo2. `FALSE` otherwise.
/// </return>

	public static bool Equal(this MentorLake.Gio.GAppInfoHandle appinfo1, MentorLake.Gio.GAppInfoHandle appinfo2)
	{
		if (appinfo1.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_equal(appinfo1, appinfo2);
	}

/// <summary>
/// <para>
/// Gets the commandline with which the application will be
/// started.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// a string containing the @appinfo’s
///   commandline, or `NULL` if this information is not available
/// </return>

	public static string GetCommandline(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_get_commandline(appinfo);
	}

/// <summary>
/// <para>
/// Gets a human-readable description of an installed application.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// a string containing a description of the
/// application @appinfo, or `NULL` if none.
/// </return>

	public static string GetDescription(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_get_description(appinfo);
	}

/// <summary>
/// <para>
/// Gets the display name of the application. The display name is often more
/// descriptive to the user than the name itself.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// the display name of the application for @appinfo, or the name if
/// no display name is available.
/// </return>

	public static string GetDisplayName(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_get_display_name(appinfo);
	}

/// <summary>
/// <para>
/// Gets the executable’s name for the installed application.
/// </para>
/// <para>
/// This is intended to be used for debugging or labelling what program is going
/// to be run. To launch the executable, use [method@Gio.AppInfo.launch] and related
/// functions, rather than spawning the return value from this function.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// a string containing the @appinfo’s application
/// binaries name
/// </return>

	public static string GetExecutable(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_get_executable(appinfo);
	}

/// <summary>
/// <para>
/// Gets the icon for the application.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// the default [iface@Gio.Icon] for
///   @appinfo or `NULL` if there is no default icon.
/// </return>

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_get_icon(appinfo);
	}

/// <summary>
/// <para>
/// Gets the ID of an application. An id is a string that identifies the
/// application. The exact format of the id is platform dependent. For instance,
/// on Unix this is the desktop file id from the xdg menu specification.
/// </para>
/// <para>
/// Note that the returned ID may be `NULL`, depending on how the @appinfo has
/// been constructed.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// a string containing the application’s ID.
/// </return>

	public static string GetId(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_get_id(appinfo);
	}

/// <summary>
/// <para>
/// Gets the installed name of the application.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// the name of the application for @appinfo.
/// </return>

	public static string GetName(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_get_name(appinfo);
	}

/// <summary>
/// <para>
/// Retrieves the list of content types that @app_info claims to support.
/// If this information is not provided by the environment, this function
/// will return `NULL`.
/// </para>
/// <para>
/// This function does not take in consideration associations added with
/// [method@Gio.AppInfo.add_supports_type], but only those exported directly by
/// the application.
/// </para>
/// </summary>

/// <param name="appinfo">
/// an app info that can handle files
/// </param>
/// <return>
/// 
///   a list of content types.
/// </return>

	public static string[] GetSupportedTypes(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_get_supported_types(appinfo);
	}

/// <summary>
/// <para>
/// Launches the application. Passes @files to the launched application
/// as arguments, using the optional @context to get information
/// about the details of the launcher (like what screen it is on).
/// On error, @error will be set accordingly.
/// </para>
/// <para>
/// To launch the application without arguments pass a `NULL` @files list.
/// </para>
/// <para>
/// Note that even if the launch is successful the application launched
/// can fail to start if it runs into problems during startup. There is
/// no way to detect this.
/// </para>
/// <para>
/// Some URIs can be changed when passed through a GFile (for instance
/// unsupported URIs with strange formats like mailto:), so if you have
/// a textual URI you want to pass in as argument, consider using
/// [method@Gio.AppInfo.launch_uris] instead.
/// </para>
/// <para>
/// The launched application inherits the environment of the launching
/// process, but it can be modified with [method@Gio.AppLaunchContext.setenv]
/// and [method@Gio.AppLaunchContext.unsetenv].
/// </para>
/// <para>
/// On UNIX, this function sets the `GIO_LAUNCHED_DESKTOP_FILE`
/// environment variable with the path of the launched desktop file and
/// `GIO_LAUNCHED_DESKTOP_FILE_PID` to the process id of the launched
/// process. This can be used to ignore `GIO_LAUNCHED_DESKTOP_FILE`,
/// should it be inherited by further processes. The `DISPLAY`,
/// `XDG_ACTIVATION_TOKEN` and `DESKTOP_STARTUP_ID` environment
/// variables are also set, based on information provided in @context.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="files">
/// a list of [iface@Gio.File] objects
/// </param>
/// <param name="context">
/// the launch context
/// </param>
/// <return>
/// `TRUE` on successful launch, `FALSE` otherwise.
/// </return>

	public static bool Launch(this MentorLake.Gio.GAppInfoHandle appinfo, MentorLake.GLib.GListHandle files, MentorLake.Gio.GAppLaunchContextHandle context)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		var externCallResult = GAppInfoHandleExterns.g_app_info_launch(appinfo, files, context, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Launches the application. This passes the @uris to the launched application
/// as arguments, using the optional @context to get information
/// about the details of the launcher (like what screen it is on).
/// On error, @error will be set accordingly. If the application only supports
/// one URI per invocation as part of their command-line, multiple instances
/// of the application will be spawned.
/// </para>
/// <para>
/// To launch the application without arguments pass a `NULL` @uris list.
/// </para>
/// <para>
/// Note that even if the launch is successful the application launched
/// can fail to start if it runs into problems during startup. There is
/// no way to detect this.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="uris">
/// a list of URIs to launch.
/// </param>
/// <param name="context">
/// the launch context
/// </param>
/// <return>
/// `TRUE` on successful launch, `FALSE` otherwise.
/// </return>

	public static bool LaunchUris(this MentorLake.Gio.GAppInfoHandle appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle context)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		var externCallResult = GAppInfoHandleExterns.g_app_info_launch_uris(appinfo, uris, context, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Async version of [method@Gio.AppInfo.launch_uris].
/// </para>
/// <para>
/// The @callback is invoked immediately after the application launch, but it
/// waits for activation in case of D-Bus–activated applications and also provides
/// extended error information for sandboxed applications, see notes for
/// [func@Gio.AppInfo.launch_default_for_uri_async].
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="uris">
/// a list of URIs to launch.
/// </param>
/// <param name="context">
/// the launch context
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

	public static T LaunchUrisAsync<T>(this T appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GAppInfoHandle
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		GAppInfoHandleExterns.g_app_info_launch_uris_async(appinfo, uris, context, cancellable, callback, user_data);
		return appinfo;
	}

/// <summary>
/// <para>
/// Finishes a [method@Gio.AppInfo.launch_uris_async] operation.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="result">
/// the async result
/// </param>
/// <return>
/// `TRUE` on successful launch, `FALSE` otherwise.
/// </return>

	public static bool LaunchUrisFinish(this MentorLake.Gio.GAppInfoHandle appinfo, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		var externCallResult = GAppInfoHandleExterns.g_app_info_launch_uris_finish(appinfo, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes a supported type from an application, if possible.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="content_type">
/// a string.
/// </param>
/// <return>
/// `TRUE` on success, `FALSE` on error.
/// </return>

	public static bool RemoveSupportsType(this MentorLake.Gio.GAppInfoHandle appinfo, string content_type)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		var externCallResult = GAppInfoHandleExterns.g_app_info_remove_supports_type(appinfo, content_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the application as the default handler for the given file extension.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="extension">
/// a string containing the file extension (without
///   the dot).
/// </param>
/// <return>
/// `TRUE` on success, `FALSE` on error.
/// </return>

	public static bool SetAsDefaultForExtension(this MentorLake.Gio.GAppInfoHandle appinfo, string extension)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		var externCallResult = GAppInfoHandleExterns.g_app_info_set_as_default_for_extension(appinfo, extension, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the application as the default handler for a given type.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="content_type">
/// the content type.
/// </param>
/// <return>
/// `TRUE` on success, `FALSE` on error.
/// </return>

	public static bool SetAsDefaultForType(this MentorLake.Gio.GAppInfoHandle appinfo, string content_type)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		var externCallResult = GAppInfoHandleExterns.g_app_info_set_as_default_for_type(appinfo, content_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the application as the last used application for a given type. This
/// will make the application appear as first in the list returned by
/// [func@Gio.AppInfo.get_recommended_for_type], regardless of the default
/// application for that content type.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <param name="content_type">
/// the content type.
/// </param>
/// <return>
/// `TRUE` on success, `FALSE` on error.
/// </return>

	public static bool SetAsLastUsedForType(this MentorLake.Gio.GAppInfoHandle appinfo, string content_type)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		var externCallResult = GAppInfoHandleExterns.g_app_info_set_as_last_used_for_type(appinfo, content_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if the application info should be shown in menus that
/// list available applications.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// `TRUE` if the @appinfo should be shown, `FALSE` otherwise.
/// </return>

	public static bool ShouldShow(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_should_show(appinfo);
	}

/// <summary>
/// <para>
/// Checks if the application accepts files as arguments.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// `TRUE` if the @appinfo supports files.
/// </return>

	public static bool SupportsFiles(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_supports_files(appinfo);
	}

/// <summary>
/// <para>
/// Checks if the application supports reading files and directories from URIs.
/// </para>
/// </summary>

/// <param name="appinfo">
/// the app info
/// </param>
/// <return>
/// `TRUE` if the @appinfo supports URIs.
/// </return>

	public static bool SupportsUris(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GAppInfoHandle)");
		return GAppInfoHandleExterns.g_app_info_supports_uris(appinfo);
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

	public static MentorLake.Gio.GAppInfoHandle CreateFromCommandline(string commandline, string application_name, MentorLake.Gio.GAppInfoCreateFlags flags)
	{
		var externCallResult = GAppInfoHandleExterns.g_app_info_create_from_commandline(commandline, application_name, flags, out var error);
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

	public static MentorLake.GLib.GListHandle GetAll()
	{
		return GAppInfoHandleExterns.g_app_info_get_all();
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

	public static MentorLake.GLib.GListHandle GetAllForType(string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_get_all_for_type(content_type);
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

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForType(string content_type, bool must_support_uris)
	{
		return GAppInfoHandleExterns.g_app_info_get_default_for_type(content_type, must_support_uris);
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

	public static void GetDefaultForTypeAsync(string content_type, bool must_support_uris, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAppInfoHandleExterns.g_app_info_get_default_for_type_async(content_type, must_support_uris, cancellable, callback, user_data);
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

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForTypeFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GAppInfoHandleExterns.g_app_info_get_default_for_type_finish(result, out var error);
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

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForUriScheme(string uri_scheme)
	{
		return GAppInfoHandleExterns.g_app_info_get_default_for_uri_scheme(uri_scheme);
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

	public static void GetDefaultForUriSchemeAsync(string uri_scheme, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAppInfoHandleExterns.g_app_info_get_default_for_uri_scheme_async(uri_scheme, cancellable, callback, user_data);
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

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForUriSchemeFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GAppInfoHandleExterns.g_app_info_get_default_for_uri_scheme_finish(result, out var error);
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

	public static MentorLake.GLib.GListHandle GetFallbackForType(string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_get_fallback_for_type(content_type);
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

	public static MentorLake.GLib.GListHandle GetRecommendedForType(string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_get_recommended_for_type(content_type);
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

	public static bool LaunchDefaultForUri(string uri, MentorLake.Gio.GAppLaunchContextHandle context)
	{
		var externCallResult = GAppInfoHandleExterns.g_app_info_launch_default_for_uri(uri, context, out var error);
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

	public static void LaunchDefaultForUriAsync(string uri, MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAppInfoHandleExterns.g_app_info_launch_default_for_uri_async(uri, context, cancellable, callback, user_data);
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

	public static bool LaunchDefaultForUriFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GAppInfoHandleExterns.g_app_info_launch_default_for_uri_finish(result, out var error);
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

	public static void ResetTypeAssociations(string content_type)
	{
		GAppInfoHandleExterns.g_app_info_reset_type_associations(content_type);
	}

}

internal class GAppInfoHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_add_supports_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string content_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_can_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_can_remove_supports_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_dup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo2);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_info_get_commandline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_info_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_info_get_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_info_get_executable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_app_info_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_info_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_info_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_app_info_get_supported_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle files, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_launch_uris_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch_uris_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_remove_supports_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string content_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_set_as_default_for_extension([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string extension, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_set_as_default_for_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string content_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_set_as_last_used_for_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string content_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_should_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_supports_files([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_supports_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

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

}
