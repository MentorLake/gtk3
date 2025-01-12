namespace MentorLake.Gtk3.Gtk3;

public class GtkSeparatorMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkSeparatorMenuItemHandle New()
	{
		return GtkSeparatorMenuItemExterns.gtk_separator_menu_item_new();
	}

}

public static class GtkSeparatorMenuItemHandleExtensions
{
}

internal class GtkSeparatorMenuItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSeparatorMenuItemHandle gtk_separator_menu_item_new();

}
