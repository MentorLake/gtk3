namespace MentorLake.Gio;

public class GDesktopAppInfoHandle : GObjectHandle, GAppInfoHandle
{
	public static MentorLake.Gio.GDesktopAppInfoHandle New(string desktop_id)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new(desktop_id);
	}

	public static MentorLake.Gio.GDesktopAppInfoHandle NewFromFilename(string filename)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new_from_filename(filename);
	}

	public static MentorLake.Gio.GDesktopAppInfoHandle NewFromKeyfile(MentorLake.GLib.GKeyFileHandle key_file)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_new_from_keyfile(key_file);
	}

	public static MentorLake.GLib.GListHandle GetImplementations(string @interface)
	{
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_implementations(@interface);
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
	public static string GetActionName(this MentorLake.Gio.GDesktopAppInfoHandle info, string action_name)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_action_name(info, action_name);
	}

	public static bool GetBoolean(this MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_boolean(info, key);
	}

	public static string GetCategories(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_categories(info);
	}

	public static string GetFilename(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_filename(info);
	}

	public static string GetGenericName(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_generic_name(info);
	}

	public static bool GetIsHidden(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_is_hidden(info);
	}

	public static string[] GetKeywords(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_keywords(info);
	}

	public static string GetLocaleString(this MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_locale_string(info, key);
	}

	public static bool GetNodisplay(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_nodisplay(info);
	}

	public static bool GetShowIn(this MentorLake.Gio.GDesktopAppInfoHandle info, string desktop_env)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_show_in(info, desktop_env);
	}

	public static string GetStartupWmClass(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_startup_wm_class(info);
	}

	public static string GetString(this MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_string(info, key);
	}

	public static string[] GetStringList(this MentorLake.Gio.GDesktopAppInfoHandle info, string key, out UIntPtr length)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_get_string_list(info, key, out length);
	}

	public static bool HasKey(this MentorLake.Gio.GDesktopAppInfoHandle info, string key)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_has_key(info, key);
	}

	public static T LaunchAction<T>(this T info, string action_name, MentorLake.Gio.GAppLaunchContextHandle launch_context) where T : GDesktopAppInfoHandle
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_action(info, action_name, launch_context);
		return info;
	}

	public static bool LaunchUrisAsManager(this MentorLake.Gio.GDesktopAppInfoHandle appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data)
	{
		if (appinfo.IsInvalid || appinfo.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		var externCallResult = GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_uris_as_manager(appinfo, uris, launch_context, spawn_flags, user_setup, user_setup_data, pid_callback, pid_callback_data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool LaunchUrisAsManagerWithFds(this MentorLake.Gio.GDesktopAppInfoHandle appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle launch_context, MentorLake.GLib.GSpawnFlags spawn_flags, MentorLake.GLib.GSpawnChildSetupFunc user_setup, IntPtr user_setup_data, MentorLake.Gio.GDesktopAppLaunchCallback pid_callback, IntPtr pid_callback_data, int stdin_fd, int stdout_fd, int stderr_fd)
	{
		if (appinfo.IsInvalid || appinfo.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		var externCallResult = GDesktopAppInfoHandleExterns.g_desktop_app_info_launch_uris_as_manager_with_fds(appinfo, uris, launch_context, spawn_flags, user_setup, user_setup_data, pid_callback, pid_callback_data, stdin_fd, stdout_fd, stderr_fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string[] ListActions(this MentorLake.Gio.GDesktopAppInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDesktopAppInfoHandle)");
		return GDesktopAppInfoHandleExterns.g_desktop_app_info_list_actions(info);
	}

}

internal class GDesktopAppInfoHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDesktopAppInfoHandle g_desktop_app_info_new(string desktop_id);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDesktopAppInfoHandle g_desktop_app_info_new_from_filename(string filename);

	[DllImport(GioLibrary.Name)]
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
	internal static extern MentorLake.GLib.GListHandle g_desktop_app_info_get_implementations(string @interface);

	[DllImport(GioLibrary.Name)]
	internal static extern string[][] g_desktop_app_info_search(string search_string);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_desktop_app_info_set_desktop_env(string desktop_env);

}
