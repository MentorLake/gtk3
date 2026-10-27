namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Control the behaviour of a #WebKitWebView.
/// </para>
/// <para>
/// #WebKitSettings can be applied to a #WebKitWebView to control text charset,
/// color, font sizes, printing mode, script support, loading of images and various
/// other things on a #WebKitWebView. After creation, a #WebKitSettings object
/// contains default settings.
/// </para>
/// <para>
/// ```c
/// // Disable JavaScript
/// WebKitSettings *settings = webkit_web_view_group_get_settings (my_view_group);
/// webkit_settings_set_enable_javascript (settings, FALSE);
/// ```
/// </para>
/// </summary>

public class WebKitSettingsHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #WebKitSettings instance with default values.
/// </para>
/// <para>
/// It must be manually attached to a #WebKitWebView.
/// See also webkit_settings_new_with_settings().
/// </para>
/// </summary>

/// <return>
/// a new #WebKitSettings instance.
/// </return>

	public static MentorLake.WebKit2.WebKitSettingsHandle New()
	{
		return WebKitSettingsHandleExterns.webkit_settings_new();
	}

/// <summary>
/// <para>
/// Creates a new #WebKitSettings instance with the given settings.
/// </para>
/// <para>
/// It must be manually attached to a #WebKitWebView.
/// </para>
/// </summary>

/// <param name="first_setting_name">
/// name of first setting to set
/// </param>
/// <param name="@__arglist">
/// value of first setting, followed by more settings,
///    %NULL-terminated
/// </param>
/// <return>
/// a new #WebKitSettings instance.
/// </return>

	public static MentorLake.WebKit2.WebKitSettingsHandle NewWithSettings(string first_setting_name, IntPtr @__arglist)
	{
		return WebKitSettingsHandleExterns.webkit_settings_new_with_settings(first_setting_name, @__arglist);
	}

/// <summary>
/// <para>
/// Convert @points to the equivalent value in pixels.
/// </para>
/// <para>
/// Applications can use this function to convert font size values
/// in points to font size values in pixels when setting the font size properties
/// of #WebKitSettings.
/// </para>
/// </summary>

/// <param name="points">
/// the font size in points to convert to pixels
/// </param>
/// <return>
/// the equivalent font size in pixels.
/// </return>

	public static uint FontSizeToPixels(uint points)
	{
		return WebKitSettingsHandleExterns.webkit_settings_font_size_to_pixels(points);
	}

/// <summary>
/// <para>
/// Convert @pixels to the equivalent value in points.
/// </para>
/// <para>
/// Applications can use this function to convert font size values
/// in pixels to font size values in points when getting the font size properties
/// of #WebKitSettings.
/// </para>
/// </summary>

/// <param name="pixels">
/// the font size in pixels to convert to points
/// </param>
/// <return>
/// the equivalent font size in points.
/// </return>

	public static uint FontSizeToPoints(uint pixels)
	{
		return WebKitSettingsHandleExterns.webkit_settings_font_size_to_points(pixels);
	}

/// <summary>
/// <para>
/// Gets the list of all available WebKit features.
/// </para>
/// <para>
/// Features can be toggled with [method@Settings.set_feature_enabled],
/// and their current state determined with
/// [method@Settings.get_feature_enabled].
/// </para>
/// <para>
/// Note that most applications should use
/// [func@Settings.get_development_features] and
/// [func@Settings.get_experimental_features] instead.
/// </para>
/// </summary>

/// <return>
/// List of all features.
/// </return>

	public static MentorLake.WebKit2.WebKitFeatureListHandle GetAllFeatures()
	{
		return WebKitSettingsHandleExterns.webkit_settings_get_all_features();
	}

/// <summary>
/// <para>
/// Gets the list of available development WebKit features.
/// </para>
/// <para>
/// The returned features are a subset of those returned by
/// [func@Settings.get_all_features], and includes those which
/// web and WebKit developers might find useful, but in general should
/// *not* be exposed to end users; see [enum@FeatureStatus] for
/// more details.
/// </para>
/// </summary>

/// <return>
/// List of development features.
/// </return>

	public static MentorLake.WebKit2.WebKitFeatureListHandle GetDevelopmentFeatures()
	{
		return WebKitSettingsHandleExterns.webkit_settings_get_development_features();
	}

/// <summary>
/// <para>
/// Gets the list of available experimental WebKit features.
/// </para>
/// <para>
/// The returned features are a subset of those returned by
/// [func@Settings.get_all_features], and includes those which
/// certain applications may want to expose to end users; see
/// [enum@FeatureStatus] for more details.
/// </para>
/// </summary>

/// <return>
/// List of experimental features.
/// </return>

	public static MentorLake.WebKit2.WebKitFeatureListHandle GetExperimentalFeatures()
	{
		return WebKitSettingsHandleExterns.webkit_settings_get_experimental_features();
	}

}

public static class WebKitSettingsHandleExtensions
{
/// <summary>
/// <para>
/// Reads the contents of the given @group_name from the given @key_file and apply the value of
/// each key/value to the corresponding property on the @settings.
/// </para>
/// <para>
/// Value types have to match with the corresponding setting property type and the group keys have to
/// match existing setting property names. If those conditions are not met, the function will return
/// %FALSE.
/// </para>
/// <para>
/// Supported value types are strings (unquoted), booleans (0, 1, true, false) and unsigned integers.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// Name of the group to read from @key_file
/// </param>
/// <return>
/// %TRUE if the settings were correctly applied or %FALSE on error.
/// </return>

	public static bool ApplyFromKeyFile(this MentorLake.WebKit2.WebKitSettingsHandle settings, MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		var externCallResult = WebKitSettingsHandleExterns.webkit_settings_apply_from_key_file(settings, key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:allow-file-access-from-file-urls property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If file access from file URLs is allowed or %FALSE otherwise.
/// </return>

	public static bool GetAllowFileAccessFromFileUrls(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_allow_file_access_from_file_urls(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:allow-modal-dialogs property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if it&apos;s allowed to create and run modal dialogs or %FALSE otherwise.
/// </return>

	public static bool GetAllowModalDialogs(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_allow_modal_dialogs(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:allow-top-navigation-to-data-urls property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If navigation to data URLs from the top frame is allowed or %FALSE\
/// otherwise.
/// </return>

	public static bool GetAllowTopNavigationToDataUrls(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_allow_top_navigation_to_data_urls(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:allow-universal-access-from-file-urls property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If universal access from file URLs is allowed or %FALSE otherwise.
/// </return>

	public static bool GetAllowUniversalAccessFromFileUrls(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_allow_universal_access_from_file_urls(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:auto-load-images property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If auto loading of images is enabled or %FALSE otherwise.
/// </return>

	public static bool GetAutoLoadImages(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_auto_load_images(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:cursive-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The default font family used to display content marked with cursive font.
/// </return>

	public static string GetCursiveFontFamily(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_cursive_font_family(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:default-charset property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// Default charset.
/// </return>

	public static string GetDefaultCharset(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_default_charset(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:default-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The default font family used to display content that does not specify a font.
/// </return>

	public static string GetDefaultFontFamily(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_default_font_family(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:default-font-size property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The default font size, in pixels.
/// </return>

	public static uint GetDefaultFontSize(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_default_font_size(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:default-monospace-font-size property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// Default monospace font size, in pixels.
/// </return>

	public static uint GetDefaultMonospaceFontSize(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_default_monospace_font_size(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:disable-web-security property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If web security support is disabled or %FALSE otherwise.
/// </return>

	public static bool GetDisableWebSecurity(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_disable_web_security(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:draw-compositing-indicators property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If compositing borders are drawn or %FALSE otherwise.
/// </return>

	public static bool GetDrawCompositingIndicators(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_draw_compositing_indicators(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-2d-canvas-acceleration property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if 2D canvas acceleration is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnable2DCanvasAcceleration(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_2d_canvas_acceleration(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-accelerated-2d-canvas property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if accelerated 2D canvas is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableAccelerated2DCanvas(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_accelerated_2d_canvas(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-back-forward-navigation-gestures property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if horizontal swipe gesture will trigger back-forward navigaiton or %FALSE otherwise.
/// </return>

	public static bool GetEnableBackForwardNavigationGestures(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_back_forward_navigation_gestures(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-caret-browsing property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If caret browsing is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableCaretBrowsing(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_caret_browsing(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-developer-extras property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If developer extras is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableDeveloperExtras(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_developer_extras(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-dns-prefetching property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If DNS prefetching is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableDnsPrefetching(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_dns_prefetching(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-encrypted-media property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if EncryptedMedia support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableEncryptedMedia(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_encrypted_media(settings);
	}

/// <summary>
/// <para>
/// Frame flattening is no longer supported. This function returns %FALSE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %FALSE
/// </return>

	public static bool GetEnableFrameFlattening(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_frame_flattening(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-fullscreen property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If fullscreen support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableFullscreen(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_fullscreen(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-html5-database property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if IndexedDB support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableHtml5Database(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_html5_database(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-html5-local-storage property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If HTML5 local storage support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableHtml5LocalStorage(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_html5_local_storage(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-hyperlink-auditing property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If hyper link auditing is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableHyperlinkAuditing(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_hyperlink_auditing(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-java property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %FALSE always.
/// </return>

	public static bool GetEnableJava(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_java(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-javascript property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If JavaScript is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableJavascript(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_javascript(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-javascript-markup property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if JavaScript markup is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableJavascriptMarkup(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_javascript_markup(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-media property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if media support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableMedia(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_media(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-media-capabilities property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if MediaCapabilities support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableMediaCapabilities(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_media_capabilities(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-media-stream property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If mediastream support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableMediaStream(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_media_stream(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-mediasource property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If MediaSource support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableMediasource(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_mediasource(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-mock-capture-devices property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If mock capture devices is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableMockCaptureDevices(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_mock_capture_devices(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-offline-web-application-cache property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %FALSE.
/// </return>

	public static bool GetEnableOfflineWebApplicationCache(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_offline_web_application_cache(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-page-cache property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if page cache enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnablePageCache(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_page_cache(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-plugins property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If plugins are enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnablePlugins(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_plugins(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-private-browsing property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If private browsing is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnablePrivateBrowsing(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_private_browsing(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-resizable-text-areas property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If text areas can be resized or %FALSE otherwise.
/// </return>

	public static bool GetEnableResizableTextAreas(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_resizable_text_areas(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-site-specific-quirks property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if site specific quirks are enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableSiteSpecificQuirks(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_site_specific_quirks(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-smooth-scrolling property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if smooth scrolling is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableSmoothScrolling(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_smooth_scrolling(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-spatial-navigation property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If HTML5 spatial navigation support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableSpatialNavigation(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_spatial_navigation(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-tabs-to-links property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If tabs to link is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableTabsToLinks(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_tabs_to_links(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-webaudio property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If webaudio support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableWebaudio(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_webaudio(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-webgl property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If WebGL support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableWebgl(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_webgl(settings);
	}

/// <summary>
/// <para>
/// Get the [property@Settings:enable-webrtc] property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If WebRTC support is enabled or %FALSE otherwise.
/// </return>

	public static bool GetEnableWebrtc(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_webrtc(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:enable-write-console-messages-to-stdout property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE if writing console messages to stdout is enabled or %FALSE
/// otherwise.
/// </return>

	public static bool GetEnableWriteConsoleMessagesToStdout(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_write_console_messages_to_stdout(settings);
	}

/// <summary>
/// <para>
/// The XSS auditor has been removed. This function returns %FALSE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %FALSE
/// </return>

	public static bool GetEnableXssAuditor(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_enable_xss_auditor(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:fantasy-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The default font family used to display content marked with fantasy font.
/// </return>

	public static string GetFantasyFontFamily(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_fantasy_font_family(settings);
	}

/// <summary>
/// <para>
/// Gets whether a feature is enabled.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="feature">
/// the feature to toggle.
/// </param>
/// <return>
/// Whether the feature is enabled.
/// </return>

	public static bool GetFeatureEnabled(this MentorLake.WebKit2.WebKitSettingsHandle settings, MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_feature_enabled(settings, feature);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:hardware-acceleration-policy property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// a #WebKitHardwareAccelerationPolicy
/// </return>

	public static MentorLake.WebKit2.WebKitHardwareAccelerationPolicy GetHardwareAccelerationPolicy(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_hardware_acceleration_policy(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:javascript-can-access-clipboard property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If javascript-can-access-clipboard is enabled or %FALSE otherwise.
/// </return>

	public static bool GetJavascriptCanAccessClipboard(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_javascript_can_access_clipboard(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:javascript-can-open-windows-automatically property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If JavaScript can open window automatically or %FALSE otherwise.
/// </return>

	public static bool GetJavascriptCanOpenWindowsAutomatically(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_javascript_can_open_windows_automatically(settings);
	}

/// <summary>
/// <para>
/// Setting no longer supported. This function returns %FALSE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %FALSE
/// </return>

	public static bool GetLoadIconsIgnoringImageLoadSetting(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_load_icons_ignoring_image_load_setting(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:math-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The default font family used to display content marked with math font.
/// 
/// Since 2.52
/// </return>

	public static string GetMathFontFamily(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_math_font_family(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:media-content-types-requiring-hardware-support property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// Media content types requiring hardware support, or %NULL.
/// </return>

	public static string GetMediaContentTypesRequiringHardwareSupport(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_media_content_types_requiring_hardware_support(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:media-playback-allows-inline property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If inline playback is allowed for media
///    or %FALSE if only fullscreen playback is allowed.
/// </return>

	public static bool GetMediaPlaybackAllowsInline(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_media_playback_allows_inline(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:media-playback-requires-user-gesture property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If an user gesture is needed to play or load media
///    or %FALSE if no user gesture is needed.
/// </return>

	public static bool GetMediaPlaybackRequiresUserGesture(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_media_playback_requires_user_gesture(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:minimum-font-size property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// Minimum font size, in pixels.
/// </return>

	public static uint GetMinimumFontSize(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_minimum_font_size(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:monospace-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// Default font family used to display content marked with monospace font.
/// </return>

	public static string GetMonospaceFontFamily(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_monospace_font_family(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:pictograph-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The default font family used to display content marked with pictograph font.
/// </return>

	public static string GetPictographFontFamily(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_pictograph_font_family(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:print-backgrounds property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If background images should be printed or %FALSE otherwise.
/// </return>

	public static bool GetPrintBackgrounds(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_print_backgrounds(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:sans-serif-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The default font family used to display content marked with sans-serif font.
/// </return>

	public static string GetSansSerifFontFamily(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_sans_serif_font_family(settings);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings:serif-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The default font family used to display content marked with serif font.
/// </return>

	public static string GetSerifFontFamily(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_serif_font_family(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:user-agent property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The current value of the user-agent property.
/// </return>

	public static string GetUserAgent(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_user_agent(settings);
	}

/// <summary>
/// <para>
/// Get the [property@Settings:webrtc-udp-ports-range] property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The WebRTC UDP ports range, or %NULL if un-set.
/// </return>

	public static string GetWebrtcUdpPortsRange(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_webrtc_udp_ports_range(settings);
	}

/// <summary>
/// <para>
/// Get the #WebKitSettings:zoom-text-only property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// %TRUE If zoom level of the view should only affect the text
///    or %FALSE if all view contents should be scaled.
/// </return>

	public static bool GetZoomTextOnly(this MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		return WebKitSettingsHandleExterns.webkit_settings_get_zoom_text_only(settings);
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:allow-file-access-from-file-urls property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="allowed">
/// Value to be set
/// </param>

	public static T SetAllowFileAccessFromFileUrls<T>(this T settings, bool allowed) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_allow_file_access_from_file_urls(settings, allowed);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:allow-modal-dialogs property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="allowed">
/// Value to be set
/// </param>

	public static T SetAllowModalDialogs<T>(this T settings, bool allowed) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_allow_modal_dialogs(settings, allowed);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:allow-top-navigation-to-data-urls property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="allowed">
/// Value to be set
/// </param>

	public static T SetAllowTopNavigationToDataUrls<T>(this T settings, bool allowed) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_allow_top_navigation_to_data_urls(settings, allowed);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:allow-universal-access-from-file-urls property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="allowed">
/// Value to be set
/// </param>

	public static T SetAllowUniversalAccessFromFileUrls<T>(this T settings, bool allowed) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_allow_universal_access_from_file_urls(settings, allowed);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:auto-load-images property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetAutoLoadImages<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_auto_load_images(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:cursive-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="cursive_font_family">
/// the new default cursive font family
/// </param>

	public static T SetCursiveFontFamily<T>(this T settings, string cursive_font_family) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_cursive_font_family(settings, cursive_font_family);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:default-charset property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="default_charset">
/// default charset to be set
/// </param>

	public static T SetDefaultCharset<T>(this T settings, string default_charset) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_default_charset(settings, default_charset);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:default-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="default_font_family">
/// the new default font family
/// </param>

	public static T SetDefaultFontFamily<T>(this T settings, string default_font_family) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_default_font_family(settings, default_font_family);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:default-font-size property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="font_size">
/// default font size to be set in pixels
/// </param>

	public static T SetDefaultFontSize<T>(this T settings, uint font_size) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_default_font_size(settings, font_size);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:default-monospace-font-size property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="font_size">
/// default monospace font size to be set in pixels
/// </param>

	public static T SetDefaultMonospaceFontSize<T>(this T settings, uint font_size) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_default_monospace_font_size(settings, font_size);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:disable-web-security property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="disabled">
/// Value to be set
/// </param>

	public static T SetDisableWebSecurity<T>(this T settings, bool disabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_disable_web_security(settings, disabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:draw-compositing-indicators property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetDrawCompositingIndicators<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_draw_compositing_indicators(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-2d-canvas-acceleration property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnable2DCanvasAcceleration<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_2d_canvas_acceleration(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-accelerated-2d-canvas property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableAccelerated2DCanvas<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_accelerated_2d_canvas(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-back-forward-navigation-gestures property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// value to be set
/// </param>

	public static T SetEnableBackForwardNavigationGestures<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_back_forward_navigation_gestures(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-caret-browsing property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableCaretBrowsing<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_caret_browsing(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-developer-extras property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableDeveloperExtras<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_developer_extras(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-dns-prefetching property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableDnsPrefetching<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_dns_prefetching(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-encrypted-media property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableEncryptedMedia<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_encrypted_media(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Frame flattening is no longer supported. This function does nothing.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableFrameFlattening<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_frame_flattening(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-fullscreen property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableFullscreen<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_fullscreen(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-html5-database property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableHtml5Database<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_html5_database(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-html5-local-storage property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableHtml5LocalStorage<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_html5_local_storage(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-hyperlink-auditing property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableHyperlinkAuditing<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_hyperlink_auditing(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-java property.
/// </para>
/// <para>
/// Deprecated function that does nothing.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableJava<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_java(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-javascript property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableJavascript<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_javascript(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-javascript-markup property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableJavascriptMarkup<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_javascript_markup(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-media property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableMedia<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_media(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-media-capabilities property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableMediaCapabilities<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_media_capabilities(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-media-stream property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableMediaStream<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_media_stream(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-mediasource property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableMediasource<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_mediasource(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-mock-capture-devices property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableMockCaptureDevices<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_mock_capture_devices(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Setting no longer supported. This function does nothing.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableOfflineWebApplicationCache<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_offline_web_application_cache(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-page-cache property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnablePageCache<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_page_cache(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-plugins property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnablePlugins<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_plugins(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-private-browsing property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnablePrivateBrowsing<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_private_browsing(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-resizable-text-areas property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableResizableTextAreas<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_resizable_text_areas(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-site-specific-quirks property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableSiteSpecificQuirks<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_site_specific_quirks(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-smooth-scrolling property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableSmoothScrolling<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_smooth_scrolling(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-spatial-navigation property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableSpatialNavigation<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_spatial_navigation(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-tabs-to-links property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableTabsToLinks<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_tabs_to_links(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-webaudio property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableWebaudio<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_webaudio(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-webgl property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableWebgl<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_webgl(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the [property@Settings:enable-webrtc] property.
/// </para>
/// <para>
/// Setting this property to %TRUE implies the media-stream web-setting will also be enabled.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableWebrtc<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_webrtc(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:enable-write-console-messages-to-stdout property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableWriteConsoleMessagesToStdout<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_write_console_messages_to_stdout(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// The XSS auditor has been removed. This function does nothing.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetEnableXssAuditor<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_enable_xss_auditor(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:fantasy-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="fantasy_font_family">
/// the new default fantasy font family
/// </param>

	public static T SetFantasyFontFamily<T>(this T settings, string fantasy_font_family) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_fantasy_font_family(settings, fantasy_font_family);
		return settings;
	}

/// <summary>
/// <para>
/// Enables or disables a feature.
/// </para>
/// <para>
/// The current status of the feature can be determined with
/// [id@webkit_settings_get_feature_enabled]. To reset a feature to its
/// initial status, pass the value returned by
/// [id@webkit_feature_get_default_value] as the @enabled parameter.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="feature">
/// the feature to toggle.
/// </param>
/// <param name="enabled">
/// whether the feature will be enabled.
/// </param>

	public static T SetFeatureEnabled<T>(this T settings, MentorLake.WebKit2.WebKitFeatureHandle feature, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_feature_enabled(settings, feature, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:hardware-acceleration-policy property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="policy">
/// a #WebKitHardwareAccelerationPolicy
/// </param>

	public static T SetHardwareAccelerationPolicy<T>(this T settings, MentorLake.WebKit2.WebKitHardwareAccelerationPolicy policy) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_hardware_acceleration_policy(settings, policy);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:javascript-can-access-clipboard property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetJavascriptCanAccessClipboard<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_javascript_can_access_clipboard(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:javascript-can-open-windows-automatically property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetJavascriptCanOpenWindowsAutomatically<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_javascript_can_open_windows_automatically(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Setting no longer supported. This function does nothing.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetLoadIconsIgnoringImageLoadSetting<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_load_icons_ignoring_image_load_setting(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:math-font-family property.
/// </para>
/// <para>
/// Since 2.52
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="math_font_family">
/// the new default math font family
/// </param>

	public static T SetMathFontFamily<T>(this T settings, string math_font_family) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_math_font_family(settings, math_font_family);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:media-content-types-requiring-hardware-support property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="content_types">
/// list of media content types requiring hardware support split by semicolons (:) or %NULL to use the default value.
/// </param>

	public static T SetMediaContentTypesRequiringHardwareSupport<T>(this T settings, string content_types) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_media_content_types_requiring_hardware_support(settings, content_types);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:media-playback-allows-inline property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetMediaPlaybackAllowsInline<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_media_playback_allows_inline(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:media-playback-requires-user-gesture property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="enabled">
/// Value to be set
/// </param>

	public static T SetMediaPlaybackRequiresUserGesture<T>(this T settings, bool enabled) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_media_playback_requires_user_gesture(settings, enabled);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:minimum-font-size property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="font_size">
/// minimum font size to be set in pixels
/// </param>

	public static T SetMinimumFontSize<T>(this T settings, uint font_size) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_minimum_font_size(settings, font_size);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:monospace-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="monospace_font_family">
/// the new default monospace font family
/// </param>

	public static T SetMonospaceFontFamily<T>(this T settings, string monospace_font_family) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_monospace_font_family(settings, monospace_font_family);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:pictograph-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="pictograph_font_family">
/// the new default pictograph font family
/// </param>

	public static T SetPictographFontFamily<T>(this T settings, string pictograph_font_family) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_pictograph_font_family(settings, pictograph_font_family);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:print-backgrounds property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="print_backgrounds">
/// Value to be set
/// </param>

	public static T SetPrintBackgrounds<T>(this T settings, bool print_backgrounds) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_print_backgrounds(settings, print_backgrounds);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:sans-serif-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="sans_serif_font_family">
/// the new default sans-serif font family
/// </param>

	public static T SetSansSerifFontFamily<T>(this T settings, string sans_serif_font_family) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_sans_serif_font_family(settings, sans_serif_font_family);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:serif-font-family property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="serif_font_family">
/// the new default serif font family
/// </param>

	public static T SetSerifFontFamily<T>(this T settings, string serif_font_family) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_serif_font_family(settings, serif_font_family);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:user-agent property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="user_agent">
/// The new custom user agent string or %NULL to use the default user agent
/// </param>

	public static T SetUserAgent<T>(this T settings, string user_agent) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_user_agent(settings, user_agent);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:user-agent property by appending the application details.
/// </para>
/// <para>
/// Set the #WebKitSettings:user-agent property by appending the application details to the default user
/// agent. If no application name or version is given, the default user agent used will be used. If only
/// the version is given, the default engine version is used with the given application name.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="application_name">
/// The application name used for the user agent or %NULL to use the default user agent.
/// </param>
/// <param name="application_version">
/// The application version for the user agent or %NULL to user the default version.
/// </param>

	public static T SetUserAgentWithApplicationDetails<T>(this T settings, string application_name, string application_version) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_user_agent_with_application_details(settings, application_name, application_version);
		return settings;
	}

/// <summary>
/// <para>
/// Set the [property@Settings:webrtc-udp-ports-range] property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="udp_port_range">
/// Value to be set
/// </param>

	public static T SetWebrtcUdpPortsRange<T>(this T settings, string udp_port_range) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_webrtc_udp_ports_range(settings, udp_port_range);
		return settings;
	}

/// <summary>
/// <para>
/// Set the #WebKitSettings:zoom-text-only property.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <param name="zoom_text_only">
/// Value to be set
/// </param>

	public static T SetZoomTextOnly<T>(this T settings, bool zoom_text_only) where T : WebKitSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitSettingsHandle)");
		WebKitSettingsHandleExterns.webkit_settings_set_zoom_text_only(settings, zoom_text_only);
		return settings;
	}

}

internal class WebKitSettingsHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSettingsHandle webkit_settings_new();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSettingsHandle webkit_settings_new_with_settings(string first_setting_name, IntPtr @__arglist);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_apply_from_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_allow_file_access_from_file_urls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_allow_modal_dialogs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_allow_top_navigation_to_data_urls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_allow_universal_access_from_file_urls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_auto_load_images([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_cursive_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_default_charset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_default_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_settings_get_default_font_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_settings_get_default_monospace_font_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_disable_web_security([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_draw_compositing_indicators([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_2d_canvas_acceleration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_accelerated_2d_canvas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_back_forward_navigation_gestures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_caret_browsing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_developer_extras([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_dns_prefetching([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_encrypted_media([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_frame_flattening([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_fullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_html5_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_html5_local_storage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_hyperlink_auditing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_java([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_javascript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_javascript_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_media([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_media_capabilities([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_media_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_mediasource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_mock_capture_devices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_offline_web_application_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_page_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_plugins([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_private_browsing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_resizable_text_areas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_site_specific_quirks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_smooth_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_spatial_navigation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_tabs_to_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_webaudio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_webgl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_webrtc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_write_console_messages_to_stdout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_enable_xss_auditor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_fantasy_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_feature_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitHardwareAccelerationPolicy webkit_settings_get_hardware_acceleration_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_javascript_can_access_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_javascript_can_open_windows_automatically([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_load_icons_ignoring_image_load_setting([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_math_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_media_content_types_requiring_hardware_support([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_media_playback_allows_inline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_media_playback_requires_user_gesture([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_settings_get_minimum_font_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_monospace_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_pictograph_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_print_backgrounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_sans_serif_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_serif_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_user_agent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_settings_get_webrtc_udp_ports_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_settings_get_zoom_text_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_allow_file_access_from_file_urls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool allowed);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_allow_modal_dialogs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool allowed);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_allow_top_navigation_to_data_urls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool allowed);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_allow_universal_access_from_file_urls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool allowed);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_auto_load_images([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_cursive_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string cursive_font_family);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_default_charset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string default_charset);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_default_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string default_font_family);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_default_font_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, uint font_size);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_default_monospace_font_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, uint font_size);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_disable_web_security([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool disabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_draw_compositing_indicators([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_2d_canvas_acceleration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_accelerated_2d_canvas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_back_forward_navigation_gestures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_caret_browsing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_developer_extras([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_dns_prefetching([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_encrypted_media([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_frame_flattening([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_fullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_html5_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_html5_local_storage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_hyperlink_auditing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_java([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_javascript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_javascript_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_media([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_media_capabilities([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_media_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_mediasource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_mock_capture_devices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_offline_web_application_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_page_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_plugins([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_private_browsing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_resizable_text_areas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_site_specific_quirks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_smooth_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_spatial_navigation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_tabs_to_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_webaudio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_webgl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_webrtc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_write_console_messages_to_stdout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_enable_xss_auditor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_fantasy_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string fantasy_font_family);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_feature_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_hardware_acceleration_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, MentorLake.WebKit2.WebKitHardwareAccelerationPolicy policy);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_javascript_can_access_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_javascript_can_open_windows_automatically([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_load_icons_ignoring_image_load_setting([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_math_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string math_font_family);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_media_content_types_requiring_hardware_support([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string content_types);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_media_playback_allows_inline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_media_playback_requires_user_gesture([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_minimum_font_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, uint font_size);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_monospace_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string monospace_font_family);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_pictograph_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string pictograph_font_family);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_print_backgrounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool print_backgrounds);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_sans_serif_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string sans_serif_font_family);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_serif_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string serif_font_family);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_user_agent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string user_agent);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_user_agent_with_application_details([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string application_name, string application_version);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_webrtc_udp_ports_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, string udp_port_range);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_settings_set_zoom_text_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings, bool zoom_text_only);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_settings_font_size_to_pixels(uint points);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_settings_font_size_to_points(uint pixels);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureListHandle>))]
	internal static extern MentorLake.WebKit2.WebKitFeatureListHandle webkit_settings_get_all_features();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureListHandle>))]
	internal static extern MentorLake.WebKit2.WebKitFeatureListHandle webkit_settings_get_development_features();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureListHandle>))]
	internal static extern MentorLake.WebKit2.WebKitFeatureListHandle webkit_settings_get_experimental_features();

}
