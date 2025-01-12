namespace MentorLake.Gtk3.Gtk3;

public class GtkTooltipHandle : GObjectHandle
{
	public static void TriggerTooltipQuery(GdkDisplayHandle display)
	{
		GtkTooltipExterns.gtk_tooltip_trigger_tooltip_query(display);
	}

}

public static class GtkTooltipHandleExtensions
{
	public static GtkTooltipHandle SetCustom(this GtkTooltipHandle tooltip, GtkWidgetHandle custom_widget)
	{
		GtkTooltipExterns.gtk_tooltip_set_custom(tooltip, custom_widget);
		return tooltip;
	}

	public static GtkTooltipHandle SetIcon(this GtkTooltipHandle tooltip, GdkPixbufHandle pixbuf)
	{
		GtkTooltipExterns.gtk_tooltip_set_icon(tooltip, pixbuf);
		return tooltip;
	}

	public static GtkTooltipHandle SetIconFromGicon(this GtkTooltipHandle tooltip, GIconHandle gicon, GtkIconSize size)
	{
		GtkTooltipExterns.gtk_tooltip_set_icon_from_gicon(tooltip, gicon, size);
		return tooltip;
	}

	public static GtkTooltipHandle SetIconFromIconName(this GtkTooltipHandle tooltip, string icon_name, GtkIconSize size)
	{
		GtkTooltipExterns.gtk_tooltip_set_icon_from_icon_name(tooltip, icon_name, size);
		return tooltip;
	}

	public static GtkTooltipHandle SetIconFromStock(this GtkTooltipHandle tooltip, string stock_id, GtkIconSize size)
	{
		GtkTooltipExterns.gtk_tooltip_set_icon_from_stock(tooltip, stock_id, size);
		return tooltip;
	}

	public static GtkTooltipHandle SetMarkup(this GtkTooltipHandle tooltip, string markup)
	{
		GtkTooltipExterns.gtk_tooltip_set_markup(tooltip, markup);
		return tooltip;
	}

	public static GtkTooltipHandle SetText(this GtkTooltipHandle tooltip, string text)
	{
		GtkTooltipExterns.gtk_tooltip_set_text(tooltip, text);
		return tooltip;
	}

	public static GtkTooltipHandle SetTipArea(this GtkTooltipHandle tooltip, GdkRectangleHandle rect)
	{
		GtkTooltipExterns.gtk_tooltip_set_tip_area(tooltip, rect);
		return tooltip;
	}

}

internal class GtkTooltipExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_set_custom(GtkTooltipHandle tooltip, GtkWidgetHandle custom_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_set_icon(GtkTooltipHandle tooltip, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_set_icon_from_gicon(GtkTooltipHandle tooltip, GIconHandle gicon, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_set_icon_from_icon_name(GtkTooltipHandle tooltip, string icon_name, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_set_icon_from_stock(GtkTooltipHandle tooltip, string stock_id, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_set_markup(GtkTooltipHandle tooltip, string markup);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_set_text(GtkTooltipHandle tooltip, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_set_tip_area(GtkTooltipHandle tooltip, GdkRectangleHandle rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tooltip_trigger_tooltip_query(GdkDisplayHandle display);

}
