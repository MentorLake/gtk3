namespace MentorLake.Gtk3.Gtk3;

public class GtkPopoverMenuHandle : GtkPopoverHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkPopoverMenuHandle New()
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_new();
	}

}

public static class GtkPopoverMenuHandleExtensions
{
	public static GtkPopoverMenuHandle OpenSubmenu(this GtkPopoverMenuHandle popover, string name)
	{
		GtkPopoverMenuExterns.gtk_popover_menu_open_submenu(popover, name);
		return popover;
	}

}

internal class GtkPopoverMenuExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPopoverMenuHandle gtk_popover_menu_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_menu_open_submenu(GtkPopoverMenuHandle popover, string name);

}
