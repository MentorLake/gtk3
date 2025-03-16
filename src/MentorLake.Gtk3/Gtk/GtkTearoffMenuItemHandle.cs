namespace MentorLake.Gtk;

public class GtkTearoffMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkTearoffMenuItemHandle New()
	{
		return GtkTearoffMenuItemHandleExterns.gtk_tearoff_menu_item_new();
	}

}

public static class GtkTearoffMenuItemHandleExtensions
{
}

internal class GtkTearoffMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTearoffMenuItemHandle gtk_tearoff_menu_item_new();

}
