namespace MentorLake.Gtk3.Gtk3;

public class GtkHeaderBarHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkHeaderBarHandle New()
	{
		return GtkHeaderBarExterns.gtk_header_bar_new();
	}

}

public static class GtkHeaderBarHandleExtensions
{
	public static GtkWidgetHandle GetCustomTitle(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_custom_title(bar);
	}

	public static string GetDecorationLayout(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_decoration_layout(bar);
	}

	public static bool GetHasSubtitle(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_has_subtitle(bar);
	}

	public static bool GetShowCloseButton(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_show_close_button(bar);
	}

	public static string GetSubtitle(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_subtitle(bar);
	}

	public static string GetTitle(this GtkHeaderBarHandle bar)
	{
		return GtkHeaderBarExterns.gtk_header_bar_get_title(bar);
	}

	public static T PackEnd<T>(this T bar, GtkWidgetHandle child) where T : GtkHeaderBarHandle
	{
		GtkHeaderBarExterns.gtk_header_bar_pack_end(bar, child);
		return bar;
	}

	public static T PackStart<T>(this T bar, GtkWidgetHandle child) where T : GtkHeaderBarHandle
	{
		GtkHeaderBarExterns.gtk_header_bar_pack_start(bar, child);
		return bar;
	}

	public static T SetCustomTitle<T>(this T bar, GtkWidgetHandle title_widget) where T : GtkHeaderBarHandle
	{
		GtkHeaderBarExterns.gtk_header_bar_set_custom_title(bar, title_widget);
		return bar;
	}

	public static T SetDecorationLayout<T>(this T bar, string layout) where T : GtkHeaderBarHandle
	{
		GtkHeaderBarExterns.gtk_header_bar_set_decoration_layout(bar, layout);
		return bar;
	}

	public static T SetHasSubtitle<T>(this T bar, bool setting) where T : GtkHeaderBarHandle
	{
		GtkHeaderBarExterns.gtk_header_bar_set_has_subtitle(bar, setting);
		return bar;
	}

	public static T SetShowCloseButton<T>(this T bar, bool setting) where T : GtkHeaderBarHandle
	{
		GtkHeaderBarExterns.gtk_header_bar_set_show_close_button(bar, setting);
		return bar;
	}

	public static T SetSubtitle<T>(this T bar, string subtitle) where T : GtkHeaderBarHandle
	{
		GtkHeaderBarExterns.gtk_header_bar_set_subtitle(bar, subtitle);
		return bar;
	}

	public static T SetTitle<T>(this T bar, string title) where T : GtkHeaderBarHandle
	{
		GtkHeaderBarExterns.gtk_header_bar_set_title(bar, title);
		return bar;
	}

}

internal class GtkHeaderBarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHeaderBarHandle gtk_header_bar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_header_bar_get_custom_title(GtkHeaderBarHandle bar);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_decoration_layout(GtkHeaderBarHandle bar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_header_bar_get_has_subtitle(GtkHeaderBarHandle bar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_header_bar_get_show_close_button(GtkHeaderBarHandle bar);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_subtitle(GtkHeaderBarHandle bar);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_title(GtkHeaderBarHandle bar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_header_bar_pack_end(GtkHeaderBarHandle bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_header_bar_pack_start(GtkHeaderBarHandle bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_header_bar_set_custom_title(GtkHeaderBarHandle bar, GtkWidgetHandle title_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_header_bar_set_decoration_layout(GtkHeaderBarHandle bar, string layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_header_bar_set_has_subtitle(GtkHeaderBarHandle bar, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_header_bar_set_show_close_button(GtkHeaderBarHandle bar, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_header_bar_set_subtitle(GtkHeaderBarHandle bar, string subtitle);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_header_bar_set_title(GtkHeaderBarHandle bar, string title);

}
