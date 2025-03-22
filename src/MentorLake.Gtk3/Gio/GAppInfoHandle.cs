namespace MentorLake.Gio;

public interface GAppInfoHandle
{
}

internal class GAppInfoHandleImpl : BaseSafeHandle, GAppInfoHandle
{
}

public static class GAppInfoHandleExtensions
{
	public static bool AddSupportsType(this MentorLake.Gio.GAppInfoHandle appinfo, string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_add_supports_type(appinfo, content_type);
	}

	public static bool CanDelete(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_can_delete(appinfo);
	}

	public static bool CanRemoveSupportsType(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_can_remove_supports_type(appinfo);
	}

	public static bool Delete(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_delete(appinfo);
	}

	public static MentorLake.Gio.GAppInfoHandle Dup(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_dup(appinfo);
	}

	public static bool Equal(this MentorLake.Gio.GAppInfoHandle appinfo1, MentorLake.Gio.GAppInfoHandle appinfo2)
	{
		return GAppInfoHandleExterns.g_app_info_equal(appinfo1, appinfo2);
	}

	public static string GetCommandline(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_get_commandline(appinfo);
	}

	public static string GetDescription(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_get_description(appinfo);
	}

	public static string GetDisplayName(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_get_display_name(appinfo);
	}

	public static string GetExecutable(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_get_executable(appinfo);
	}

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_get_icon(appinfo);
	}

	public static string GetId(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_get_id(appinfo);
	}

	public static string GetName(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_get_name(appinfo);
	}

	public static string[] GetSupportedTypes(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_get_supported_types(appinfo);
	}

	public static bool Launch(this MentorLake.Gio.GAppInfoHandle appinfo, MentorLake.GLib.GListHandle files, MentorLake.Gio.GAppLaunchContextHandle context)
	{
		return GAppInfoHandleExterns.g_app_info_launch(appinfo, files, context);
	}

	public static bool LaunchUris(this MentorLake.Gio.GAppInfoHandle appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle context)
	{
		return GAppInfoHandleExterns.g_app_info_launch_uris(appinfo, uris, context);
	}

	public static T LaunchUrisAsync<T>(this T appinfo, MentorLake.GLib.GListHandle uris, MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GAppInfoHandle
	{
		GAppInfoHandleExterns.g_app_info_launch_uris_async(appinfo, uris, context, cancellable, callback, user_data);
		return appinfo;
	}

	public static bool LaunchUrisFinish(this MentorLake.Gio.GAppInfoHandle appinfo, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GAppInfoHandleExterns.g_app_info_launch_uris_finish(appinfo, result);
	}

	public static bool RemoveSupportsType(this MentorLake.Gio.GAppInfoHandle appinfo, string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_remove_supports_type(appinfo, content_type);
	}

	public static bool SetAsDefaultForExtension(this MentorLake.Gio.GAppInfoHandle appinfo, string extension)
	{
		return GAppInfoHandleExterns.g_app_info_set_as_default_for_extension(appinfo, extension);
	}

	public static bool SetAsDefaultForType(this MentorLake.Gio.GAppInfoHandle appinfo, string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_set_as_default_for_type(appinfo, content_type);
	}

	public static bool SetAsLastUsedForType(this MentorLake.Gio.GAppInfoHandle appinfo, string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_set_as_last_used_for_type(appinfo, content_type);
	}

	public static bool ShouldShow(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_should_show(appinfo);
	}

	public static bool SupportsFiles(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_supports_files(appinfo);
	}

	public static bool SupportsUris(this MentorLake.Gio.GAppInfoHandle appinfo)
	{
		return GAppInfoHandleExterns.g_app_info_supports_uris(appinfo);
	}

	public static MentorLake.Gio.GAppInfoHandle CreateFromCommandline(string commandline, string application_name, MentorLake.Gio.GAppInfoCreateFlags flags)
	{
		return GAppInfoHandleExterns.g_app_info_create_from_commandline(commandline, application_name, flags);
	}

	public static MentorLake.GLib.GListHandle GetAll()
	{
		return GAppInfoHandleExterns.g_app_info_get_all();
	}

	public static MentorLake.GLib.GListHandle GetAllForType(string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_get_all_for_type(content_type);
	}

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForType(string content_type, bool must_support_uris)
	{
		return GAppInfoHandleExterns.g_app_info_get_default_for_type(content_type, must_support_uris);
	}

	public static void GetDefaultForTypeAsync(string content_type, bool must_support_uris, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAppInfoHandleExterns.g_app_info_get_default_for_type_async(content_type, must_support_uris, cancellable, callback, user_data);
	}

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForTypeFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		return GAppInfoHandleExterns.g_app_info_get_default_for_type_finish(result);
	}

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForUriScheme(string uri_scheme)
	{
		return GAppInfoHandleExterns.g_app_info_get_default_for_uri_scheme(uri_scheme);
	}

	public static void GetDefaultForUriSchemeAsync(string uri_scheme, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAppInfoHandleExterns.g_app_info_get_default_for_uri_scheme_async(uri_scheme, cancellable, callback, user_data);
	}

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForUriSchemeFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		return GAppInfoHandleExterns.g_app_info_get_default_for_uri_scheme_finish(result);
	}

	public static MentorLake.GLib.GListHandle GetFallbackForType(string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_get_fallback_for_type(content_type);
	}

	public static MentorLake.GLib.GListHandle GetRecommendedForType(string content_type)
	{
		return GAppInfoHandleExterns.g_app_info_get_recommended_for_type(content_type);
	}

	public static bool LaunchDefaultForUri(string uri, MentorLake.Gio.GAppLaunchContextHandle context)
	{
		return GAppInfoHandleExterns.g_app_info_launch_default_for_uri(uri, context);
	}

	public static void LaunchDefaultForUriAsync(string uri, MentorLake.Gio.GAppLaunchContextHandle context, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAppInfoHandleExterns.g_app_info_launch_default_for_uri_async(uri, context, cancellable, callback, user_data);
	}

	public static bool LaunchDefaultForUriFinish(MentorLake.Gio.GAsyncResultHandle result)
	{
		return GAppInfoHandleExterns.g_app_info_launch_default_for_uri_finish(result);
	}

	public static void ResetTypeAssociations(string content_type)
	{
		GAppInfoHandleExterns.g_app_info_reset_type_associations(content_type);
	}

}

internal class GAppInfoHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_add_supports_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_can_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_can_remove_supports_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
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
	internal static extern MentorLake.Gio.GIconHandle g_app_info_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_info_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_app_info_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_app_info_get_supported_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle files, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_launch_uris_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch_uris_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_remove_supports_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_set_as_default_for_extension([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string extension);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_set_as_default_for_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_set_as_last_used_for_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo, string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_should_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_supports_files([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_supports_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle appinfo);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_create_from_commandline(string commandline, string application_name, MentorLake.Gio.GAppInfoCreateFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_all();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_all_for_type(string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_type(string content_type, bool must_support_uris);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_get_default_for_type_async(string content_type, bool must_support_uris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_type_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_uri_scheme(string uri_scheme);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_get_default_for_uri_scheme_async(string uri_scheme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_app_info_get_default_for_uri_scheme_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_fallback_for_type(string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_app_info_get_recommended_for_type(string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch_default_for_uri(string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_launch_default_for_uri_async(string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppLaunchContextHandle>))] MentorLake.Gio.GAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_app_info_launch_default_for_uri_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_app_info_reset_type_associations(string content_type);

}
