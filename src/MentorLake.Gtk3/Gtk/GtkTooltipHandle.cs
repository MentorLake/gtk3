namespace MentorLake.Gtk;

public class GtkTooltipHandle : GObjectHandle
{
	public static void TriggerTooltipQuery(MentorLake.Gdk.GdkDisplayHandle display)
	{
		GtkTooltipHandleExterns.gtk_tooltip_trigger_tooltip_query(display);
	}

}

public static class GtkTooltipHandleExtensions
{
	public static T SetCustom<T>(this T tooltip, MentorLake.Gtk.GtkWidgetHandle custom_widget) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_custom(tooltip, custom_widget);
		return tooltip;
	}

	public static T SetIcon<T>(this T tooltip, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_icon(tooltip, pixbuf);
		return tooltip;
	}

	public static T SetIconFromGicon<T>(this T tooltip, MentorLake.Gio.GIconHandle gicon, MentorLake.Gtk.GtkIconSize size) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_icon_from_gicon(tooltip, gicon, size);
		return tooltip;
	}

	public static T SetIconFromIconName<T>(this T tooltip, string icon_name, MentorLake.Gtk.GtkIconSize size) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_icon_from_icon_name(tooltip, icon_name, size);
		return tooltip;
	}

	public static T SetIconFromStock<T>(this T tooltip, string stock_id, MentorLake.Gtk.GtkIconSize size) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_icon_from_stock(tooltip, stock_id, size);
		return tooltip;
	}

	public static T SetMarkup<T>(this T tooltip, string markup) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_markup(tooltip, markup);
		return tooltip;
	}

	public static T SetText<T>(this T tooltip, string text) where T : GtkTooltipHandle
	{
		if (tooltip.IsInvalid) throw new Exception("Invalid handle (GtkTooltipHandle)");
		GtkTooltipHandleExterns.gtk_tooltip_set_text(tooltip, text);
		return tooltip;
	}

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
