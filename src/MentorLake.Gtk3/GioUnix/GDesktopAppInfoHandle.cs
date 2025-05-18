namespace MentorLake.GioUnix;

public class GDesktopAppInfoHandle : GObjectHandle, GAppInfoHandle
{
	public static MentorLake.GioUnix.GDesktopAppInfoHandle New(string desktop_id)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new(desktop_id);
	}

	public static MentorLake.GioUnix.GDesktopAppInfoHandle NewFromFilename(string filename)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new_from_filename(filename);
	}

	public static MentorLake.GioUnix.GDesktopAppInfoHandle NewFromKeyfile(MentorLake.GLib.GKeyFileHandle key_file)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new_from_keyfile(key_file);
	}

	public static string GetActionName(MentorLake.Gio.GDesktopAppInfoHandle info, string action_name)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_action_name(info, action_name);
	}

	public static bool GetBoolean(MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_boolean(info, key);
	}

	public static string GetCategories(MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_categories(info);
	}

	public static string GetFilename(MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_filename(info);
	}

	public static string GetGenericName(MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_generic_name(info);
	}

	public static MentorLake.GLib.GListHandle GetImplementations(string @interface)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_implementations(@interface);
	}

	public static bool GetIsHidden(MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_is_hidden(info);
	}

	public static string[] GetKeywords(MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_keywords(info);
	}

	public static string GetLocaleString(MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_locale_string(info, key);
	}

	public static bool GetNodisplay(MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_nodisplay(info);
	}

	public static bool GetShowIn(MentorLake.Gio.GDesktopAppInfoHandle info, string desktop_env)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_show_in(info, desktop_env);
	}

	public static string GetStartupWmClass(MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_startup_wm_class(info);
	}

	public static string GetString(MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_string(info, key);
	}

	public static string[] GetStringList(MentorLake.Gio.GDesktopAppInfoHandle info, string key, out UIntPtr length)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_string_list(info, key, out length);
	}

	public static bool HasKey(MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_has_key(info, key);
	}

	public static void LaunchAction(MentorLake.Gio.GDesktopAppInfoHandle info, string action_name, MentorLake.Gio.GAppLaunchContextHandle launch_context)
	{
		GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_action(info, action_name, launch_context);
	}

	public static bool LaunchUrisAsManager(MentorLake.Gio.GDesktopAppInfoHandle appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data)
	{
		var externCallResult = GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_uris_as_manager(appinfo, uris, launch_context, spawn_flags, user_setup, user_setup_data, pid_callback, pid_callback_data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool LaunchUrisAsManagerWithFds(MentorLake.Gio.GDesktopAppInfoHandle appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, int stdin_fd, int stdout_fd, int stderr_fd)
	{
		var externCallResult = GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_uris_as_manager_with_fds(appinfo, uris, launch_context, spawn_flags, user_setup, user_setup_data, pid_callback, pid_callback_data, stdin_fd, stdout_fd, stderr_fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string[] ListActions(MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_list_actions(info);
	}

	public static string[][] Search(string search_string)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_search(search_string);
	}

	public static void SetDesktopEnv(string desktop_env)
	{
		GDesktopAppInfoHandleExterns.g_desktop_app_info_set_desktop_env(desktop_env);
	}

}

public static class GDesktopAppInfoHandleExtensions
{
}

internal class GDesktopAppInfoHandleExterns
{
	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GioUnix.GDesktopAppInfoHandle>))]
	internal static extern MentorLake.GioUnix.GDesktopAppInfoHandle g_desktop_app_info_new(string desktop_id);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GioUnix.GDesktopAppInfoHandle>))]
	internal static extern MentorLake.GioUnix.GDesktopAppInfoHandle g_desktop_app_info_new_from_filename(string filename);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GioUnix.GDesktopAppInfoHandle>))]
	internal static extern MentorLake.GioUnix.GDesktopAppInfoHandle g_desktop_app_info_new_from_keyfile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_action_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string action_name);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_desktop_app_info_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_categories([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_generic_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_desktop_app_info_get_implementations(string @interface);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_desktop_app_info_get_is_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_desktop_app_info_get_keywords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_locale_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_desktop_app_info_get_nodisplay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_desktop_app_info_get_show_in([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string desktop_env);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_startup_wm_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_desktop_app_info_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_desktop_app_info_get_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key, out UIntPtr length);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_desktop_app_info_has_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string key);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_desktop_app_info_launch_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle launch_context);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_desktop_app_info_launch_uris_as_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern bool g_desktop_app_info_launch_uris_as_manager_with_fds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, int stdin_fd, int stdout_fd, int stderr_fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_desktop_app_info_list_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoHandle>))] MentorLake.Gio.GDesktopAppInfoHandle info);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern string[][] g_desktop_app_info_search(string search_string);

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_desktop_app_info_set_desktop_env(string desktop_env);

}
