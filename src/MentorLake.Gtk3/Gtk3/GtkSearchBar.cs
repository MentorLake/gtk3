namespace MentorLake.Gtk3.Gtk3;

public class GtkSearchBarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkSearchBarHandle New()
	{
		return GtkSearchBarExterns.gtk_search_bar_new();
	}

}

public static class GtkSearchBarHandleExtensions
{
	public static T ConnectEntry<T>(this T bar, GtkEntryHandle entry) where T : GtkSearchBarHandle
	{
		GtkSearchBarExterns.gtk_search_bar_connect_entry(bar, entry);
		return bar;
	}

	public static bool GetSearchMode(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_search_mode(bar);
	}

	public static bool GetShowCloseButton(this GtkSearchBarHandle bar)
	{
		return GtkSearchBarExterns.gtk_search_bar_get_show_close_button(bar);
	}

	public static bool HandleEvent(this GtkSearchBarHandle bar, GdkEventHandle @event)
	{
		return GtkSearchBarExterns.gtk_search_bar_handle_event(bar, @event);
	}

	public static T SetSearchMode<T>(this T bar, bool search_mode) where T : GtkSearchBarHandle
	{
		GtkSearchBarExterns.gtk_search_bar_set_search_mode(bar, search_mode);
		return bar;
	}

	public static T SetShowCloseButton<T>(this T bar, bool visible) where T : GtkSearchBarHandle
	{
		GtkSearchBarExterns.gtk_search_bar_set_show_close_button(bar, visible);
		return bar;
	}

}

internal class GtkSearchBarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSearchBarHandle gtk_search_bar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_search_bar_connect_entry(GtkSearchBarHandle bar, GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_search_bar_get_search_mode(GtkSearchBarHandle bar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_search_bar_get_show_close_button(GtkSearchBarHandle bar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_search_bar_handle_event(GtkSearchBarHandle bar, GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_search_bar_set_search_mode(GtkSearchBarHandle bar, bool search_mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_search_bar_set_show_close_button(GtkSearchBarHandle bar, bool visible);

}
