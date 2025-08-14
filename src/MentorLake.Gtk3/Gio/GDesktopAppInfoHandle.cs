namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDesktopAppInfo` is an implementation of [iface@Gio.AppInfo] based on
/// desktop files.
/// </para>
/// <para>
/// Note that `<gio/gdesktopappinfo.h>` belongs to the UNIX-specific
/// GIO interfaces, thus you have to use the `gio-unix-2.0.pc` pkg-config
/// file or the `GioUnix-2.0` GIR namespace when using it.
/// </para>
/// </summary>

public class GDesktopAppInfoHandle : GObjectHandle, GAppInfoHandle
{
/// <summary>
/// <para>
/// Creates a new [class@Gio.DesktopAppInfo] based on a desktop file ID.
/// </para>
/// <para>
/// A desktop file ID is the basename of the desktop file, including the
/// `.desktop` extension. GIO is looking for a desktop file with this name
/// in the `applications` subdirectories of the XDG
/// data directories (i.e. the directories specified in the `XDG_DATA_HOME`
/// and `XDG_DATA_DIRS` environment variables). GIO also supports the
/// prefix-to-subdirectory mapping that is described in the
/// [Menu Spec](http://standards.freedesktop.org/menu-spec/latest/)
/// (i.e. a desktop ID of `kde-foo.desktop` will match
/// `/usr/share/applications/kde/foo.desktop`).
/// </para>
/// </summary>

/// <param name="desktop_id">
/// the desktop file ID
/// </param>
/// <return>
/// a new [class@Gio.DesktopAppInfo], or `NULL` if no
///    desktop file with that ID exists.
/// </return>

	public static MentorLake.Gio.GDesktopAppInfoHandle New(string desktop_id)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new(desktop_id);
	}

/// <summary>
/// <para>
/// Creates a new [class@Gio.DesktopAppInfo].
/// </para>
/// </summary>

/// <param name="filename">
/// the path of a desktop file, in the GLib
///      filename encoding
/// </param>
/// <return>
/// a new [class@Gio.DesktopAppInfo] or `NULL` on error.
/// </return>

	public static MentorLake.Gio.GDesktopAppInfoHandle NewFromFilename(string filename)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new_from_filename(filename);
	}

/// <summary>
/// <para>
/// Creates a new [class@Gio.DesktopAppInfo].
/// </para>
/// </summary>

/// <param name="key_file">
/// an opened [type@GLib.KeyFile]
/// </param>
/// <return>
/// a new [class@Gio.DesktopAppInfo] or `NULL` on error.
/// </return>

	public static MentorLake.Gio.GDesktopAppInfoHandle NewFromKeyfile(MentorLake.GLib.GKeyFileHandle key_file)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new_from_keyfile(key_file);
	}

/// <summary>
/// <para>
/// Gets all applications that implement @interface.
/// </para>
/// <para>
/// An application implements an interface if that interface is listed in
/// the `Implements` line of the desktop file of the application.
/// </para>
/// </summary>

/// <param name="@interface">
/// the name of the interface
/// </param>
/// <return>
/// a list of
///   [class@Gio.DesktopAppInfo] objects.
/// </return>

	public static MentorLake.GLib.GListHandle GetImplementations(string @interface)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_implementations(@interface);
	}

/// <summary>
/// <para>
/// Searches desktop files for ones that match @search_string.
/// </para>
/// <para>
/// The return value is an array of strvs.  Each strv contains a list of
/// applications that matched @search_string with an equal score.  The
/// outer list is sorted by score so that the first strv contains the
/// best-matching applications, and so on.
/// The algorithm for determining matches is undefined and may change at
/// any time.
/// </para>
/// <para>
/// None of the search results are subjected to the normal validation
/// checks performed by [ctor@Gio.DesktopAppInfo.new] (for example, checking that
/// the executable referenced by a result exists), and so it is possible for
/// [ctor@Gio.DesktopAppInfo.new] to return `NULL` when passed an app ID returned
/// by this function. It is expected that calling code will do this when
/// subsequently creating a [class@Gio.DesktopAppInfo] for each result.
/// </para>
/// </summary>

/// <param name="search_string">
/// the search string to use
/// </param>
/// <return>
/// a
///   list of strvs.  Free each item with [func@GLib.strfreev] and free the outer
///   list with [func@GLib.free].
/// </return>

	public static string[][] Search(string search_string)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_search(search_string);
	}

/// <summary>
/// <para>
/// Sets the name of the desktop that the application is running in.
/// </para>
/// <para>
/// This is used by [method@Gio.AppInfo.should_show] and
/// [method@Gio.DesktopAppInfo.get_show_in] to evaluate the
/// <see href="https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-onlyshowin">OnlyShowIn</see>
/// and <see href="https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-notshowin">NotShowIn</see>
/// keys.
/// </para>
/// <para>
/// Should be called only once; subsequent calls are ignored.
/// </para>
/// </summary>

/// <param name="desktop_env">
/// a string specifying what desktop this is
/// </param>

	public static void SetDesktopEnv(string desktop_env)
	{
		GDesktopAppInfoHandleExterns.g_desktop_app_info_set_desktop_env(desktop_env);
	}

}

public static class GDesktopAppInfoHandleExtensions
{
/// <summary>
/// <para>
/// Gets the user-visible display name of the
/// [‘additional application actions’](https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s11.html)
/// specified by @action_name.
/// </para>
/// <para>
/// This corresponds to the `Name` key within the keyfile group for the
/// action.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="action_name">
/// the name of the action as from
///   [method@Gio.DesktopAppInfo.list_actions]
/// </param>
/// <return>
/// the locale-specific action name
/// </return>

	public static string GetActionName(this MentorLake.Gio.GDesktopAppInfoHandle info, string action_name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_action_name(info, action_name);
	}

/// <summary>
/// <para>
/// Looks up a boolean value in the keyfile backing @info.
/// </para>
/// <para>
/// The @key is looked up in the `Desktop Entry` group.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <return>
/// the boolean value, or `FALSE` if the key is not found
/// </return>

	public static bool GetBoolean(this MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_boolean(info, key);
	}

/// <summary>
/// <para>
/// Gets the categories from the desktop file.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <return>
/// The unparsed
///   [`Categories` key](https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-categories)
///   from the desktop file;
///   i.e. no attempt is made to split it by `;` or validate it.
/// </return>

	public static string GetCategories(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_categories(info);
	}

/// <summary>
/// <para>
/// When @info was created from a known filename, return it.  In some
/// situations such as a [class@Gio.DesktopAppInfo] returned from
/// [ctor@Gio.DesktopAppInfo.new_from_keyfile], this function will return `NULL`.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <return>
/// The full path to the file for @info,
///   or `NULL` if not known.
/// </return>

	public static string GetFilename(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_filename(info);
	}

/// <summary>
/// <para>
/// Gets the generic name from the desktop file.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <return>
/// The value of the
///   [`GenericName` key](https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-genericname)
/// </return>

	public static string GetGenericName(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_generic_name(info);
	}

/// <summary>
/// <para>
/// A desktop file is hidden if the
/// <see href="https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-hidden">Hidden</see>
/// in it is set to `True`.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo].
/// </param>
/// <return>
/// `TRUE` if hidden, `FALSE` otherwise.
/// </return>

	public static bool GetIsHidden(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_is_hidden(info);
	}

/// <summary>
/// <para>
/// Gets the keywords from the desktop file.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <return>
/// The value of the
///   [`Keywords` key](https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-keywords)
/// </return>

	public static string[] GetKeywords(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_keywords(info);
	}

/// <summary>
/// <para>
/// Looks up a localized string value in the keyfile backing @info
/// translated to the current locale.
/// </para>
/// <para>
/// The @key is looked up in the `Desktop Entry` group.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <return>
/// a newly allocated string, or `NULL` if the key is not
///   found
/// </return>

	public static string GetLocaleString(this MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_locale_string(info, key);
	}

/// <summary>
/// <para>
/// Gets the value of the
/// <see href="https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-nodisplay">NoDisplay</see>
///  which helps determine if the application info should be shown in menus. See
/// `G_KEY_FILE_DESKTOP_KEY_NO_DISPLAY` and [method@Gio.AppInfo.should_show].
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <return>
/// The value of the `NoDisplay` key
/// </return>

	public static bool GetNodisplay(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_nodisplay(info);
	}

/// <summary>
/// <para>
/// Checks if the application info should be shown in menus that list available
/// applications for a specific name of the desktop, based on the
/// <see href="https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-onlyshowin">OnlyShowIn</see>
/// and <see href="https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s06.html#key-notshowin">NotShowIn</see>
/// keys.
/// </para>
/// <para>
/// @desktop_env should typically be given as `NULL`, in which case the
/// `XDG_CURRENT_DESKTOP` environment variable is consulted.  If you want
/// to override the default mechanism then you may specify @desktop_env,
/// but this is not recommended.
/// </para>
/// <para>
/// Note that [method@Gio.AppInfo.should_show] for @info will include this check
/// (with `NULL` for @desktop_env) as well as additional checks.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="desktop_env">
/// a string specifying a desktop name
/// </param>
/// <return>
/// `TRUE` if the @info should be shown in @desktop_env according to the
/// `OnlyShowIn` and `NotShowIn` keys, `FALSE` otherwise.
/// </return>

	public static bool GetShowIn(this MentorLake.Gio.GDesktopAppInfoHandle info, string desktop_env)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_show_in(info, desktop_env);
	}

/// <summary>
/// <para>
/// Retrieves the `StartupWMClass` field from @info. This represents the
/// `WM_CLASS` property of the main window of the application, if launched
/// through @info.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo] that supports startup notify
/// </param>
/// <return>
/// the startup WM class, or `NULL` if none
///   is set in the desktop file.
/// </return>

	public static string GetStartupWmClass(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_startup_wm_class(info);
	}

/// <summary>
/// <para>
/// Looks up a string value in the keyfile backing @info.
/// </para>
/// <para>
/// The @key is looked up in the `Desktop Entry` group.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <return>
/// a newly allocated string, or `NULL` if the key is not
///   found
/// </return>

	public static string GetString(this MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_string(info, key);
	}

/// <summary>
/// <para>
/// Looks up a string list value in the keyfile backing @info.
/// </para>
/// <para>
/// The @key is looked up in the `Desktop Entry` group.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <param name="length">
/// return location for the number of returned
///   strings, or `NULL`
/// </param>
/// <return>
/// 
///   a `NULL`-terminated string array or `NULL` if the specified
///   key cannot be found. The array should be freed with [func@GLib.strfreev].
/// </return>

	public static string[] GetStringList(this MentorLake.Gio.GDesktopAppInfoHandle info, string key, out UIntPtr length)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_string_list(info, key, out length);
	}

/// <summary>
/// <para>
/// Returns whether @key exists in the `Desktop Entry` group
/// of the keyfile backing @info.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <return>
/// `TRUE` if the @key exists
/// </return>

	public static bool HasKey(this MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_has_key(info, key);
	}

/// <summary>
/// <para>
/// Activates the named application action.
/// </para>
/// <para>
/// You may only call this function on action names that were
/// returned from [method@Gio.DesktopAppInfo.list_actions].
/// </para>
/// <para>
/// Note that if the main entry of the desktop file indicates that the
/// application supports startup notification, and @launch_context is
/// non-`NULL`, then startup notification will be used when activating the
/// action (and as such, invocation of the action on the receiving side
/// must signal the end of startup notification when it is completed).
/// This is the expected behaviour of applications declaring additional
/// actions, as per the
/// [desktop file specification](https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s11.html).
/// </para>
/// <para>
/// As with [method@Gio.AppInfo.launch] there is no way to detect failures that
/// occur while using this function.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="action_name">
/// the name of the action as from
///   [method@Gio.DesktopAppInfo.list_actions]
/// </param>
/// <param name="launch_context">
/// a [class@Gio.AppLaunchContext]
/// </param>

	public static T LaunchAction<T>(this T info, string action_name, MentorLake.Gio.GAppLaunchContextHandle launch_context) where T : GDesktopAppInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_action(info, action_name, launch_context);
		return info;
	}

/// <summary>
/// <para>
/// This function performs the equivalent of [method@Gio.AppInfo.launch_uris],
/// but is intended primarily for operating system components that
/// launch applications.  Ordinary applications should use
/// [method@Gio.AppInfo.launch_uris].
/// </para>
/// <para>
/// If the application is launched via GSpawn, then @spawn_flags, @user_setup
/// and @user_setup_data are used for the call to [func@GLib.spawn_async].
/// Additionally, @pid_callback (with @pid_callback_data) will be called to
/// inform about the PID of the created process. See
/// [func@GLib.spawn_async_with_pipes] for information on certain parameter
/// conditions that can enable an optimized <see href="man:posix_spawn(3">posix_spawn()</see>)
/// code path to be used.
/// </para>
/// <para>
/// If application launching occurs via some other mechanism (for example, D-Bus
/// activation) then @spawn_flags, @user_setup, @user_setup_data,
/// @pid_callback and @pid_callback_data are ignored.
/// </para>
/// </summary>

/// <param name="appinfo">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="uris">
/// List of URIs
/// </param>
/// <param name="launch_context">
/// a [class@Gio.AppLaunchContext]
/// </param>
/// <param name="spawn_flags">
/// [flags@GLib.SpawnFlags], used for each process
/// </param>
/// <param name="user_setup">
/// a [callback@GLib.SpawnChildSetupFunc],
///   used once  for each process.
/// </param>
/// <param name="user_setup_data">
/// User data for @user_setup
/// </param>
/// <param name="pid_callback">
/// Callback for child processes
/// </param>
/// <param name="pid_callback_data">
/// User data for @callback
/// </param>
/// <return>
/// `TRUE` on successful launch, `FALSE` otherwise.
/// </return>

	public static bool LaunchUrisAsManager(this MentorLake.Gio.GDesktopAppInfoHandle appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		var externCallResult = GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_uris_as_manager(appinfo, uris, launch_context, spawn_flags, user_setup, user_setup_data, pid_callback, pid_callback_data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Equivalent to [method@Gio.DesktopAppInfo.launch_uris_as_manager] but allows
/// you to pass in file descriptors for the stdin, stdout and stderr streams
/// of the launched process.
/// </para>
/// <para>
/// If application launching occurs via some non-spawn mechanism (e.g. D-Bus
/// activation) then @stdin_fd, @stdout_fd and @stderr_fd are ignored.
/// </para>
/// </summary>

/// <param name="appinfo">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <param name="uris">
/// List of URIs
/// </param>
/// <param name="launch_context">
/// a [class@Gio.AppLaunchContext]
/// </param>
/// <param name="spawn_flags">
/// [flags@GLib.SpawnFlags], used for each process
/// </param>
/// <param name="user_setup">
/// a
///   [callback@GLib.SpawnChildSetupFunc], used once for each process.
/// </param>
/// <param name="user_setup_data">
/// User data for @user_setup
/// </param>
/// <param name="pid_callback">
/// Callback for child processes
/// </param>
/// <param name="pid_callback_data">
/// User data for @callback
/// </param>
/// <param name="stdin_fd">
/// file descriptor to use for child’s stdin, or `-1`
/// </param>
/// <param name="stdout_fd">
/// file descriptor to use for child’s stdout, or `-1`
/// </param>
/// <param name="stderr_fd">
/// file descriptor to use for child’s stderr, or `-1`
/// </param>
/// <return>
/// `TRUE` on successful launch, `FALSE` otherwise.
/// </return>

	public static bool LaunchUrisAsManagerWithFds(this MentorLake.Gio.GDesktopAppInfoHandle appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, int stdin_fd, int stdout_fd, int stderr_fd)
	{
		if (appinfo.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		var externCallResult = GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_uris_as_manager_with_fds(appinfo, uris, launch_context, spawn_flags, user_setup, user_setup_data, pid_callback, pid_callback_data, stdin_fd, stdout_fd, stderr_fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the list of
/// [‘additional application actions’](https://specifications.freedesktop.org/desktop-entry-spec/latest/ar01s11.html)
/// supported on the desktop file, as per the desktop file specification.
/// </para>
/// <para>
/// As per the specification, this is the list of actions that are
/// explicitly listed in the `Actions` key of the `Desktop Entry` group.
/// </para>
/// </summary>

/// <param name="info">
/// a [class@Gio.DesktopAppInfo]
/// </param>
/// <return>
/// a
///   list of strings, always non-`NULL`
/// </return>

	public static string[] ListActions(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_list_actions(info);
	}

}

internal class GDesktopAppInfoHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))]
	internal static extern MentorLake.Gio.GDesktopAppInfoHandle g_desktop_app_info_new(string desktop_id);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))]
	internal static extern MentorLake.Gio.GDesktopAppInfoHandle g_desktop_app_info_new_from_filename(string filename);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))]
	internal static extern MentorLake.Gio.GDesktopAppInfoHandle g_desktop_app_info_new_from_keyfile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_action_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_desktop_app_info_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_categories([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_generic_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_desktop_app_info_get_is_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_desktop_app_info_get_keywords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_locale_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_desktop_app_info_get_nodisplay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_desktop_app_info_get_show_in([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string desktop_env);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_startup_wm_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_desktop_app_info_get_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key, out UIntPtr length);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_desktop_app_info_has_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_desktop_app_info_launch_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle launch_context);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_desktop_app_info_launch_uris_as_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_desktop_app_info_launch_uris_as_manager_with_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, int stdin_fd, int stdout_fd, int stderr_fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_desktop_app_info_list_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_desktop_app_info_get_implementations(string @interface);

	[DllImport(GioLibrary.Name)]
	internal static extern string[][] g_desktop_app_info_search(string search_string);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_desktop_app_info_set_desktop_env(string desktop_env);

}
