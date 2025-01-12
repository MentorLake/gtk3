namespace MentorLake.Gtk3.Gtk3;

public class GtkRecentChooserMenuHandle : GtkMenuHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static GtkRecentChooserMenuHandle New()
	{
		return GtkRecentChooserMenuExterns.gtk_recent_chooser_menu_new();
	}

	public static GtkRecentChooserMenuHandle NewForManager(GtkRecentManagerHandle manager)
	{
		return GtkRecentChooserMenuExterns.gtk_recent_chooser_menu_new_for_manager(manager);
	}

}

public static class GtkRecentChooserMenuHandleExtensions
{
	public static bool GetShowNumbers(this GtkRecentChooserMenuHandle menu)
	{
		return GtkRecentChooserMenuExterns.gtk_recent_chooser_menu_get_show_numbers(menu);
	}

	public static T SetShowNumbers<T>(this T menu, bool show_numbers) where T : GtkRecentChooserMenuHandle
	{
		GtkRecentChooserMenuExterns.gtk_recent_chooser_menu_set_show_numbers(menu, show_numbers);
		return menu;
	}

}

internal class GtkRecentChooserMenuExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentChooserMenuHandle gtk_recent_chooser_menu_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentChooserMenuHandle gtk_recent_chooser_menu_new_for_manager(GtkRecentManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_chooser_menu_get_show_numbers(GtkRecentChooserMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_chooser_menu_set_show_numbers(GtkRecentChooserMenuHandle menu, bool show_numbers);

}
