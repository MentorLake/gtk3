namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkHeaderBar is similar to a horizontal #GtkBox. It allows children to
/// be placed at the start or the end. In addition, it allows a title and
/// subtitle to be displayed. The title will be centered with respect to
/// the width of the box, even if the children at either side take up
/// different amounts of space. The height of the titlebar will be
/// set to provide sufficient space for the subtitle, even if none is
/// currently set. If a subtitle is not needed, the space reservation
/// can be turned off with gtk_header_bar_set_has_subtitle().
/// </para>
/// <para>
/// GtkHeaderBar can add typical window frame controls, such as minimize,
/// maximize and close buttons, or the window icon.
/// </para>
/// <para>
/// For these reasons, GtkHeaderBar is the natural choice for use as the custom
/// titlebar widget of a #GtkWindow (see gtk_window_set_titlebar()), as it gives
/// features typical of titlebars while allowing the addition of child widgets.
/// </para>
/// </summary>

public class GtkHeaderBarHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkHeaderBar widget.
/// </para>
/// </summary>

/// <return>
/// a new #GtkHeaderBar
/// </return>

	public static MentorLake.Gtk.GtkHeaderBarHandle New()
	{
		return GtkHeaderBarHandleExterns.gtk_header_bar_new();
	}

}

public static class GtkHeaderBarHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the custom title widget of the header. See
/// gtk_header_bar_set_custom_title().
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <return>
/// the custom title widget
///    of the header, or %NULL if none has been set explicitly.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetCustomTitle(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_custom_title(bar);
	}

/// <summary>
/// <para>
/// Gets the decoration layout set with
/// gtk_header_bar_set_decoration_layout().
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <return>
/// the decoration layout
/// </return>

	public static string GetDecorationLayout(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_decoration_layout(bar);
	}

/// <summary>
/// <para>
/// Retrieves whether the header bar reserves space for
/// a subtitle, regardless if one is currently set or not.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <return>
/// %TRUE if the header bar reserves space
///     for a subtitle
/// </return>

	public static bool GetHasSubtitle(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_has_subtitle(bar);
	}

/// <summary>
/// <para>
/// Returns whether this header bar shows the standard window
/// decorations.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <return>
/// %TRUE if the decorations are shown
/// </return>

	public static bool GetShowCloseButton(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_show_close_button(bar);
	}

/// <summary>
/// <para>
/// Retrieves the subtitle of the header. See gtk_header_bar_set_subtitle().
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <return>
/// the subtitle of the header, or %NULL if none has
///    been set explicitly. The returned string is owned by the widget
///    and must not be modified or freed.
/// </return>

	public static string GetSubtitle(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_subtitle(bar);
	}

/// <summary>
/// <para>
/// Retrieves the title of the header. See gtk_header_bar_set_title().
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <return>
/// the title of the header, or %NULL if none has
///    been set explicitly. The returned string is owned by the widget
///    and must not be modified or freed.
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_title(bar);
	}

/// <summary>
/// <para>
/// Adds @child to @bar, packed with reference to the
/// end of the @bar.
/// </para>
/// </summary>

/// <param name="bar">
/// A #GtkHeaderBar
/// </param>
/// <param name="child">
/// the #GtkWidget to be added to @bar
/// </param>

	public static T PackEnd<T>(this T bar, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_pack_end(bar, child);
		return bar;
	}

/// <summary>
/// <para>
/// Adds @child to @bar, packed with reference to the
/// start of the @bar.
/// </para>
/// </summary>

/// <param name="bar">
/// A #GtkHeaderBar
/// </param>
/// <param name="child">
/// the #GtkWidget to be added to @bar
/// </param>

	public static T PackStart<T>(this T bar, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_pack_start(bar, child);
		return bar;
	}

/// <summary>
/// <para>
/// Sets a custom title for the #GtkHeaderBar.
/// </para>
/// <para>
/// The title should help a user identify the current view. This
/// supersedes any title set by gtk_header_bar_set_title() or
/// gtk_header_bar_set_subtitle(). To achieve the same style as
/// the builtin title and subtitle, use the “title” and “subtitle”
/// style classes.
/// </para>
/// <para>
/// You should set the custom title to %NULL, for the header title
/// label to be visible again.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <param name="title_widget">
/// a custom widget to use for a title
/// </param>

	public static T SetCustomTitle<T>(this T bar, MentorLake.Gtk.GtkWidgetHandle title_widget) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_custom_title(bar, title_widget);
		return bar;
	}

/// <summary>
/// <para>
/// Sets the decoration layout for this header bar, overriding
/// the #GtkSettings:gtk-decoration-layout setting.
/// </para>
/// <para>
/// There can be valid reasons for overriding the setting, such
/// as a header bar design that does not allow for buttons to take
/// room on the right, or only offers room for a single close button.
/// Split header bars are another example for overriding the
/// setting.
/// </para>
/// <para>
/// The format of the string is button names, separated by commas.
/// A colon separates the buttons that should appear on the left
/// from those on the right. Recognized button names are minimize,
/// maximize, close, icon (the window icon) and menu (a menu button
/// for the fallback app menu).
/// </para>
/// <para>
/// For example, “menu:minimize,maximize,close” specifies a menu
/// on the left, and minimize, maximize and close buttons on the right.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <param name="layout">
/// a decoration layout, or %NULL to
///     unset the layout
/// </param>

	public static T SetDecorationLayout<T>(this T bar, string layout) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_decoration_layout(bar, layout);
		return bar;
	}

/// <summary>
/// <para>
/// Sets whether the header bar should reserve space
/// for a subtitle, even if none is currently set.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <param name="setting">
/// %TRUE to reserve space for a subtitle
/// </param>

	public static T SetHasSubtitle<T>(this T bar, bool setting) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_has_subtitle(bar, setting);
		return bar;
	}

/// <summary>
/// <para>
/// Sets whether this header bar shows the standard window decorations,
/// including close, maximize, and minimize.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <param name="setting">
/// %TRUE to show standard window decorations
/// </param>

	public static T SetShowCloseButton<T>(this T bar, bool setting) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_show_close_button(bar, setting);
		return bar;
	}

/// <summary>
/// <para>
/// Sets the subtitle of the #GtkHeaderBar. The title should give a user
/// an additional detail to help him identify the current view.
/// </para>
/// <para>
/// Note that GtkHeaderBar by default reserves room for the subtitle,
/// even if none is currently set. If this is not desired, set the
/// #GtkHeaderBar:has-subtitle property to %FALSE.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <param name="subtitle">
/// a subtitle, or %NULL
/// </param>

	public static T SetSubtitle<T>(this T bar, string subtitle) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_subtitle(bar, subtitle);
		return bar;
	}

/// <summary>
/// <para>
/// Sets the title of the #GtkHeaderBar. The title should help a user
/// identify the current view. A good title should not include the
/// application name.
/// </para>
/// </summary>

/// <param name="bar">
/// a #GtkHeaderBar
/// </param>
/// <param name="title">
/// a title, or %NULL
/// </param>

	public static T SetTitle<T>(this T bar, string title) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_title(bar, title);
		return bar;
	}

}

internal class GtkHeaderBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))]
	internal static extern MentorLake.Gtk.GtkHeaderBarHandle gtk_header_bar_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_header_bar_get_custom_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_decoration_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_header_bar_get_has_subtitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_header_bar_get_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_subtitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_custom_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle title_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_decoration_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, string layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_has_subtitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_subtitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, string subtitle);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, string title);

}
