namespace MentorLake.WebKit2;

public class WebKit2GlobalFunctions
{
/// <summary>
/// <para>
/// Gets the quark for the domain of download errors.
/// </para>
/// </summary>

/// <return>
/// download error domain.
/// </return>

	public static MentorLake.GLib.GQuark DownloadErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_download_error_quark();
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of favicon database errors.
/// </para>
/// </summary>

/// <return>
/// favicon database error domain.
/// </return>

	public static MentorLake.GLib.GQuark FaviconDatabaseErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_favicon_database_error_quark();
	}

/// <summary>
/// <para>
/// Returns the major version number of the WebKit library.
/// </para>
/// <para>
/// (e.g. in WebKit version 1.8.3 this is 1.)
/// </para>
/// <para>
/// This function is in the library, so it represents the WebKit library
/// your code is running against. Contrast with the #WEBKIT_MAJOR_VERSION
/// macro, which represents the major version of the WebKit headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the major version number of the WebKit library
/// </return>

	public static uint GetMajorVersion()
	{
		return WebKit2GlobalFunctionsExterns.webkit_get_major_version();
	}

/// <summary>
/// <para>
/// Returns the micro version number of the WebKit library.
/// </para>
/// <para>
/// (e.g. in WebKit version 1.8.3 this is 3.)
/// </para>
/// <para>
/// This function is in the library, so it represents the WebKit library
/// your code is running against. Contrast with the #WEBKIT_MICRO_VERSION
/// macro, which represents the micro version of the WebKit headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the micro version number of the WebKit library
/// </return>

	public static uint GetMicroVersion()
	{
		return WebKit2GlobalFunctionsExterns.webkit_get_micro_version();
	}

/// <summary>
/// <para>
/// Returns the minor version number of the WebKit library.
/// </para>
/// <para>
/// (e.g. in WebKit version 1.8.3 this is 8.)
/// </para>
/// <para>
/// This function is in the library, so it represents the WebKit library
/// your code is running against. Contrast with the #WEBKIT_MINOR_VERSION
/// macro, which represents the minor version of the WebKit headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the minor version number of the WebKit library
/// </return>

	public static uint GetMinorVersion()
	{
		return WebKit2GlobalFunctionsExterns.webkit_get_minor_version();
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of JavaScript errors.
/// </para>
/// </summary>

/// <return>
/// JavaScript error domain.
/// </return>

	public static MentorLake.GLib.GQuark JavascriptErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_javascript_error_quark();
	}

/// <summary>
/// <para>
/// Get the key system for which access permission is being requested.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitMediaKeySystemPermissionRequest
/// </param>
/// <return>
/// the key system name for @request
/// </return>

	public static string MediaKeySystemPermissionGetName(MentorLake.WebKit2.WebKitMediaKeySystemPermissionRequestHandle request)
	{
		return WebKit2GlobalFunctionsExterns.webkit_media_key_system_permission_get_name(request);
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of networking errors.
/// </para>
/// </summary>

/// <return>
/// network error domain.
/// </return>

	public static MentorLake.GLib.GQuark NetworkErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_network_error_quark();
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of plug-in errors.
/// </para>
/// </summary>

/// <return>
/// plug-in error domain.
/// </return>

	public static MentorLake.GLib.GQuark PluginErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_plugin_error_quark();
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of policy errors.
/// </para>
/// </summary>

/// <return>
/// policy error domain.
/// </return>

	public static MentorLake.GLib.GQuark PolicyErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_policy_error_quark();
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of printing errors.
/// </para>
/// </summary>

/// <return>
/// print error domain.
/// </return>

	public static MentorLake.GLib.GQuark PrintErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_print_error_quark();
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of page snapshot errors.
/// </para>
/// </summary>

/// <return>
/// snapshot error domain.
/// </return>

	public static MentorLake.GLib.GQuark SnapshotErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_snapshot_error_quark();
	}

/// <summary>
/// <para>
/// Use this function to format a URI for display.
/// </para>
/// <para>
/// The URIs used internally by
/// WebKit may contain percent-encoded characters or Punycode, which are not
/// generally suitable to display to users. This function provides protection
/// against IDN homograph attacks, so in some cases the host part of the returned
/// URI may be in Punycode if the safety check fails.
/// </para>
/// </summary>

/// <param name="uri">
/// the URI to be converted
/// </param>
/// <return>
/// @uri suitable for display, or %NULL in
///    case of error.
/// </return>

	public static string UriForDisplay(string uri)
	{
		return WebKit2GlobalFunctionsExterns.webkit_uri_for_display(uri);
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of user content filter errors.
/// </para>
/// </summary>

/// <return>
/// user content filter error domain.
/// </return>

	public static MentorLake.GLib.GQuark UserContentFilterErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_user_content_filter_error_quark();
	}

/// <summary>
/// <para>
/// Check whether the permission request is for an audio device.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitUserMediaPermissionRequest
/// </param>
/// <return>
/// %TRUE if access to an audio device was requested.
/// </return>

	public static bool UserMediaPermissionIsForAudioDevice(MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle request)
	{
		return WebKit2GlobalFunctionsExterns.webkit_user_media_permission_is_for_audio_device(request);
	}

/// <summary>
/// <para>
/// Check whether the permission request is for a display device.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitUserMediaPermissionRequest
/// </param>
/// <return>
/// %TRUE if access to a display device was requested.
/// </return>

	public static bool UserMediaPermissionIsForDisplayDevice(MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle request)
	{
		return WebKit2GlobalFunctionsExterns.webkit_user_media_permission_is_for_display_device(request);
	}

/// <summary>
/// <para>
/// Check whether the permission request is for a video device.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitUserMediaPermissionRequest
/// </param>
/// <return>
/// %TRUE if access to a video device was requested.
/// </return>

	public static bool UserMediaPermissionIsForVideoDevice(MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle request)
	{
		return WebKit2GlobalFunctionsExterns.webkit_user_media_permission_is_for_video_device(request);
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of user message errors.
/// </para>
/// </summary>

/// <return>
/// user message error domain.
/// </return>

	public static MentorLake.GLib.GQuark UserMessageErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_user_message_error_quark();
	}

/// <summary>
/// <para>
/// Gets the quark for the domain of Web Extension Match Pattern errors.
/// </para>
/// </summary>

/// <return>
/// web extension match pattern error domain.
/// </return>

	public static MentorLake.GLib.GQuark WebExtensionMatchPatternErrorQuark()
	{
		return WebKit2GlobalFunctionsExterns.webkit_web_extension_match_pattern_error_quark();
	}

}

internal class WebKit2GlobalFunctionsExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_download_error_quark();

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_favicon_database_error_quark();

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_get_major_version();

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_get_micro_version();

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_get_minor_version();

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_javascript_error_quark();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_media_key_system_permission_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMediaKeySystemPermissionRequestHandle>))] MentorLake.WebKit2.WebKitMediaKeySystemPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_network_error_quark();

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_plugin_error_quark();

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_policy_error_quark();

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_print_error_quark();

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_snapshot_error_quark();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_uri_for_display(string uri);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_user_content_filter_error_quark();

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_user_media_permission_is_for_audio_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle>))] MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_user_media_permission_is_for_display_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle>))] MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_user_media_permission_is_for_video_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle>))] MentorLake.WebKit2.WebKitUserMediaPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_user_message_error_quark();

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.GLib.GQuark webkit_web_extension_match_pattern_error_quark();

}
