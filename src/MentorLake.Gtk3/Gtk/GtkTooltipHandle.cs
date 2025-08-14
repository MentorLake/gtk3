namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Basic tooltips can be realized simply by using gtk_widget_set_tooltip_text()
/// or gtk_widget_set_tooltip_markup() without any explicit tooltip object.
/// </para>
/// <para>
/// When you need a tooltip with a little more fancy contents, like adding an
/// image, or you want the tooltip to have different contents per #GtkTreeView
/// row or cell, you will have to do a little more work:
/// </para>
/// <para>
/// - Set the #GtkWidget:has-tooltip property to %TRUE, this will make GTK+
///   monitor the widget for motion and related events which are needed to
///   determine when and where to show a tooltip.
/// </para>
/// <para>
/// - Connect to the #GtkWidget::query-tooltip signal.  This signal will be
///   emitted when a tooltip is supposed to be shown. One of the arguments passed
///   to the signal handler is a GtkTooltip object. This is the object that we
///   are about to display as a tooltip, and can be manipulated in your callback
///   using functions like gtk_tooltip_set_icon(). There are functions for setting
///   the tooltip’s markup, setting an image from a named icon, or even putting in
///   a custom widget.
/// </para>
/// <para>
///   Return %TRUE from your query-tooltip handler. This causes the tooltip to be
///   show. If you return %FALSE, it will not be shown.
/// </para>
/// <para>
/// In the probably rare case where you want to have even more control over the
/// tooltip that is about to be shown, you can set your own #GtkWindow which
/// will be used as tooltip window.  This works as follows:
/// </para>
/// <para>
/// - Set #GtkWidget:has-tooltip and connect to #GtkWidget::query-tooltip as before.
///   Use gtk_widget_set_tooltip_window() to set a #GtkWindow created by you as
///   tooltip window.
/// </para>
/// <para>
/// - In the #GtkWidget::query-tooltip callback you can access your window using
///   gtk_widget_get_tooltip_window() and manipulate as you wish. The semantics of
///   the return value are exactly as before, return %TRUE to show the window,
///   %FALSE to not show it.
/// </para>
/// </summary>

public class GtkTooltipHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Triggers a new tooltip query on @display, in order to update the current
/// visible tooltip, or to show/hide the current tooltip.  This function is
/// useful to call when, for example, the state of the widget changed by a
/// key press.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static void TriggerTooltipQuery(MentorLake.Gdk.GdkDisplayHandle display)
	{
		GtkTooltipHandleExterns.gtk_tooltip_trigger_tooltip_query(display);
	}

}

public static class GtkTooltipHandleExtensions
{
/// <summary>
/// <para>
/// Replaces the widget packed into the tooltip with
/// @custom_widget. @custom_widget does not get destroyed when the tooltip goes
/// away.
/// By default a box with a #GtkImage and #GtkLabel is embedded in
/// the tooltip, which can be configured using gtk_tooltip_set_markup()
/// and gtk_tooltip_set_icon().
/// </para>
/// </summary>

/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="custom_widget">
/// a #GtkWidget, or %NULL to unset the old custom widget.
/// </param>

	public static T SetCustom<T>(this T tooltip, MentorLake.Gtk.GtkWidgetHandle custom_widget) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_custom(tooltip, custom_widget);
		return tooltip;
	}

/// <summary>
/// <para>
/// Sets the icon of the tooltip (which is in front of the text) to be
/// @pixbuf.  If @pixbuf is %NULL, the image will be hidden.
/// </para>
/// </summary>

/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="pixbuf">
/// a #GdkPixbuf, or %NULL
/// </param>

	public static T SetIcon<T>(this T tooltip, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_icon(tooltip, pixbuf);
		return tooltip;
	}

/// <summary>
/// <para>
/// Sets the icon of the tooltip (which is in front of the text)
/// to be the icon indicated by @gicon with the size indicated
/// by @size. If @gicon is %NULL, the image will be hidden.
/// </para>
/// </summary>

/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="gicon">
/// a #GIcon representing the icon, or %NULL
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>

	public static T SetIconFromGicon<T>(this T tooltip, MentorLake.Gio.GIconHandle gicon, MentorLake.Gtk.GtkIconSize size) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_icon_from_gicon(tooltip, gicon, size);
		return tooltip;
	}

/// <summary>
/// <para>
/// Sets the icon of the tooltip (which is in front of the text) to be
/// the icon indicated by @icon_name with the size indicated
/// by @size.  If @icon_name is %NULL, the image will be hidden.
/// </para>
/// </summary>

/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="icon_name">
/// an icon name, or %NULL
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>

	public static T SetIconFromIconName<T>(this T tooltip, string icon_name, MentorLake.Gtk.GtkIconSize size) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_icon_from_icon_name(tooltip, icon_name, size);
		return tooltip;
	}

/// <summary>
/// <para>
/// Sets the icon of the tooltip (which is in front of the text) to be
/// the stock item indicated by @stock_id with the size indicated
/// by @size.  If @stock_id is %NULL, the image will be hidden.
/// </para>
/// </summary>

/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="stock_id">
/// a stock id, or %NULL
/// </param>
/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>

	public static T SetIconFromStock<T>(this T tooltip, string stock_id, MentorLake.Gtk.GtkIconSize size) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_icon_from_stock(tooltip, stock_id, size);
		return tooltip;
	}

/// <summary>
/// <para>
/// Sets the text of the tooltip to be @markup, which is marked up
/// with the [Pango text markup language][PangoMarkupFormat].
/// If @markup is %NULL, the label will be hidden.
/// </para>
/// </summary>

/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="markup">
/// a markup string (see [Pango markup format][PangoMarkupFormat]) or %NULL
/// </param>

	public static T SetMarkup<T>(this T tooltip, string markup) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_markup(tooltip, markup);
		return tooltip;
	}

/// <summary>
/// <para>
/// Sets the text of the tooltip to be @text. If @text is %NULL, the label
/// will be hidden. See also gtk_tooltip_set_markup().
/// </para>
/// </summary>

/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="text">
/// a text string or %NULL
/// </param>

	public static T SetText<T>(this T tooltip, string text) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_text(tooltip, text);
		return tooltip;
	}

/// <summary>
/// <para>
/// Sets the area of the widget, where the contents of this tooltip apply,
/// to be @rect (in widget coordinates).  This is especially useful for
/// properly setting tooltips on #GtkTreeView rows and cells, #GtkIconViews,
/// etc.
/// </para>
/// <para>
/// For setting tooltips on #GtkTreeView, please refer to the convenience
/// functions for this: gtk_tree_view_set_tooltip_row() and
/// gtk_tree_view_set_tooltip_cell().
/// </para>
/// </summary>

/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="rect">
/// a #GdkRectangle
/// </param>

	public static T SetTipArea<T>(this T tooltip, MentorLake.Gdk.GdkRectangleHandle rect) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_tip_area(tooltip, rect);
		return tooltip;
	}

}

internal class GtkTooltipHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_set_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle custom_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_set_icon_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle gicon, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_set_icon_from_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, string icon_name, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_set_icon_from_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, string stock_id, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_set_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_set_tip_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tooltip_trigger_tooltip_query([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

}
