namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Window properties of a #WebKitWebView.
/// </para>
/// <para>
/// The content of a #WebKitWebView can request to change certain
/// properties of the window containing the view. This can include the x, y position
/// of the window, the width and height but also if a toolbar,
/// scrollbar, statusbar, locationbar should be visible to the user,
/// and the request to show the #WebKitWebView fullscreen.
/// </para>
/// <para>
/// The #WebKitWebView::ready-to-show signal handler is the proper place
/// to apply the initial window properties. Then you can monitor the
/// #WebKitWindowProperties by connecting to ::notify signal.
/// </para>
/// <para>
/// ```c
/// static void ready_to_show_cb (WebKitWebView *web_view, gpointer user_data)
/// {
///     GtkWidget *window;
///     WebKitWindowProperties *window_properties;
///     gboolean visible;
/// </para>
/// <para>
///     // Create the window to contain the WebKitWebView.
///     window = browser_window_new ();
///     gtk_container_add (GTK_CONTAINER (window), GTK_WIDGET (web_view));
///     gtk_widget_show (GTK_WIDGET (web_view));
/// </para>
/// <para>
///     // Get the WebKitWindowProperties of the web view and monitor it.
///     window_properties = webkit_web_view_get_window_properties (web_view);
///     g_signal_connect (window_properties, &quot;notify::geometry&quot;,
///                       G_CALLBACK (window_geometry_changed), window);
///     g_signal_connect (window_properties, &quot;notify::toolbar-visible&quot;,
///                       G_CALLBACK (window_toolbar_visibility_changed), window);
///     g_signal_connect (window_properties, &quot;notify::menubar-visible&quot;,
///                       G_CALLBACK (window_menubar_visibility_changed), window);
/// </para>
/// <para>
///     // Apply the window properties before showing the window.
///     visible = webkit_window_properties_get_toolbar_visible (window_properties);
///     browser_window_set_toolbar_visible (BROWSER_WINDOW (window), visible);
///     visible = webkit_window_properties_get_menubar_visible (window_properties);
///     browser_window_set_menubar_visible (BROWSER_WINDOW (window), visible);
/// </para>
/// <para>
///     if (webkit_window_properties_get_fullscreen (window_properties)) {
///         gtk_window_fullscreen (GTK_WINDOW (window));
///     } else {
///         GdkRectangle geometry;
/// </para>
/// <para>
///         gtk_window_set_resizable (GTK_WINDOW (window),
///                                   webkit_window_properties_get_resizable (window_properties));
///         webkit_window_properties_get_geometry (window_properties, &amp;geometry);
///         gtk_window_move (GTK_WINDOW (window), geometry.x, geometry.y);
///         gtk_window_resize (GTK_WINDOW (window), geometry.width, geometry.height);
///     }
/// </para>
/// <para>
///     gtk_widget_show (window);
/// }
/// ```
/// </para>
/// </summary>

public class WebKitWindowPropertiesHandle : GObjectHandle
{
}

public static class WebKitWindowPropertiesHandleExtensions
{
/// <summary>
/// <para>
/// Get whether the window should be shown in fullscreen state or not.
/// </para>
/// </summary>

/// <param name="window_properties">
/// a #WebKitWindowProperties
/// </param>
/// <return>
/// %TRUE if the window should be fullscreen or %FALSE otherwise.
/// </return>

	public static bool GetFullscreen(this MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties)
	{
		if (window_properties.IsInvalid) throw new Exception("Invalid handle (WebKitWindowPropertiesHandle)");
		return WebKitWindowPropertiesHandleExterns.webkit_window_properties_get_fullscreen(window_properties);
	}

/// <summary>
/// <para>
/// Get the geometry the window should have on the screen when shown.
/// </para>
/// </summary>

/// <param name="window_properties">
/// a #WebKitWindowProperties
/// </param>
/// <param name="geometry">
/// return location for the window geometry
/// </param>

	public static T GetGeometry<T>(this T window_properties, out MentorLake.Gdk.GdkRectangle geometry) where T : WebKitWindowPropertiesHandle
	{
		if (window_properties.IsInvalid) throw new Exception("Invalid handle (WebKitWindowPropertiesHandle)");
		WebKitWindowPropertiesHandleExterns.webkit_window_properties_get_geometry(window_properties, out geometry);
		return window_properties;
	}

/// <summary>
/// <para>
/// Get whether the window should have the locationbar visible or not.
/// </para>
/// </summary>

/// <param name="window_properties">
/// a #WebKitWindowProperties
/// </param>
/// <return>
/// %TRUE if locationbar should be visible or %FALSE otherwise.
/// </return>

	public static bool GetLocationbarVisible(this MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties)
	{
		if (window_properties.IsInvalid) throw new Exception("Invalid handle (WebKitWindowPropertiesHandle)");
		return WebKitWindowPropertiesHandleExterns.webkit_window_properties_get_locationbar_visible(window_properties);
	}

/// <summary>
/// <para>
/// Get whether the window should have the menubar visible or not.
/// </para>
/// </summary>

/// <param name="window_properties">
/// a #WebKitWindowProperties
/// </param>
/// <return>
/// %TRUE if menubar should be visible or %FALSE otherwise.
/// </return>

	public static bool GetMenubarVisible(this MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties)
	{
		if (window_properties.IsInvalid) throw new Exception("Invalid handle (WebKitWindowPropertiesHandle)");
		return WebKitWindowPropertiesHandleExterns.webkit_window_properties_get_menubar_visible(window_properties);
	}

/// <summary>
/// <para>
/// Get whether the window should be resizable by the user or not.
/// </para>
/// </summary>

/// <param name="window_properties">
/// a #WebKitWindowProperties
/// </param>
/// <return>
/// %TRUE if the window should be resizable or %FALSE otherwise.
/// </return>

	public static bool GetResizable(this MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties)
	{
		if (window_properties.IsInvalid) throw new Exception("Invalid handle (WebKitWindowPropertiesHandle)");
		return WebKitWindowPropertiesHandleExterns.webkit_window_properties_get_resizable(window_properties);
	}

/// <summary>
/// <para>
/// Get whether the window should have the scrollbars visible or not.
/// </para>
/// </summary>

/// <param name="window_properties">
/// a #WebKitWindowProperties
/// </param>
/// <return>
/// %TRUE if scrollbars should be visible or %FALSE otherwise.
/// </return>

	public static bool GetScrollbarsVisible(this MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties)
	{
		if (window_properties.IsInvalid) throw new Exception("Invalid handle (WebKitWindowPropertiesHandle)");
		return WebKitWindowPropertiesHandleExterns.webkit_window_properties_get_scrollbars_visible(window_properties);
	}

/// <summary>
/// <para>
/// Get whether the window should have the statusbar visible or not.
/// </para>
/// </summary>

/// <param name="window_properties">
/// a #WebKitWindowProperties
/// </param>
/// <return>
/// %TRUE if statusbar should be visible or %FALSE otherwise.
/// </return>

	public static bool GetStatusbarVisible(this MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties)
	{
		if (window_properties.IsInvalid) throw new Exception("Invalid handle (WebKitWindowPropertiesHandle)");
		return WebKitWindowPropertiesHandleExterns.webkit_window_properties_get_statusbar_visible(window_properties);
	}

/// <summary>
/// <para>
/// Get whether the window should have the toolbar visible or not.
/// </para>
/// </summary>

/// <param name="window_properties">
/// a #WebKitWindowProperties
/// </param>
/// <return>
/// %TRUE if toolbar should be visible or %FALSE otherwise.
/// </return>

	public static bool GetToolbarVisible(this MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties)
	{
		if (window_properties.IsInvalid) throw new Exception("Invalid handle (WebKitWindowPropertiesHandle)");
		return WebKitWindowPropertiesHandleExterns.webkit_window_properties_get_toolbar_visible(window_properties);
	}

}

internal class WebKitWindowPropertiesHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_window_properties_get_fullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))] MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_window_properties_get_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))] MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties, out MentorLake.Gdk.GdkRectangle geometry);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_window_properties_get_locationbar_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))] MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_window_properties_get_menubar_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))] MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_window_properties_get_resizable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))] MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_window_properties_get_scrollbars_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))] MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_window_properties_get_statusbar_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))] MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_window_properties_get_toolbar_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))] MentorLake.WebKit2.WebKitWindowPropertiesHandle window_properties);

}
