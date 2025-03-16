namespace MentorLake.Gtk;

public class GtkSeparatorMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkSeparatorMenuItemHandle New()
	{
		return GtkSeparatorMenuItemHandleExterns.gtk_separator_menu_item_new();
	}

}

public static class GtkSeparatorMenuItemHandleExtensions
{
}

internal class GtkSeparatorMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSeparatorMenuItemHandle gtk_separator_menu_item_new();

}
