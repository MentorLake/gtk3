namespace MentorLake.Gtk3.Gtk3;

public class GtkApplicationWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GActionGroupHandle, GActionMapHandle, GtkBuildableHandle
{
	public static GtkApplicationWindowHandle New(GtkApplicationHandle application)
	{
		return GtkApplicationWindowExterns.gtk_application_window_new(application);
	}

}

public static class GtkApplicationWindowHandleExtensions
{
	public static GtkShortcutsWindowHandle GetHelpOverlay(this GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowExterns.gtk_application_window_get_help_overlay(window);
	}

	public static uint GetId(this GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowExterns.gtk_application_window_get_id(window);
	}

	public static bool GetShowMenubar(this GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowExterns.gtk_application_window_get_show_menubar(window);
	}

	public static T SetHelpOverlay<T>(this T window, GtkShortcutsWindowHandle help_overlay) where T : GtkApplicationWindowHandle
	{
		GtkApplicationWindowExterns.gtk_application_window_set_help_overlay(window, help_overlay);
		return window;
	}

	public static T SetShowMenubar<T>(this T window, bool show_menubar) where T : GtkApplicationWindowHandle
	{
		GtkApplicationWindowExterns.gtk_application_window_set_show_menubar(window, show_menubar);
		return window;
	}

}

internal class GtkApplicationWindowExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkApplicationWindowHandle gtk_application_window_new(GtkApplicationHandle application);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkShortcutsWindowHandle gtk_application_window_get_help_overlay(GtkApplicationWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_application_window_get_id(GtkApplicationWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_application_window_get_show_menubar(GtkApplicationWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_application_window_set_help_overlay(GtkApplicationWindowHandle window, GtkShortcutsWindowHandle help_overlay);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_application_window_set_show_menubar(GtkApplicationWindowHandle window, bool show_menubar);

}
