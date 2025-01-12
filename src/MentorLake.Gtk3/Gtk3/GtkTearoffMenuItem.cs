namespace MentorLake.Gtk3.Gtk3;

public class GtkTearoffMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkTearoffMenuItemHandle New()
	{
		return GtkTearoffMenuItemExterns.gtk_tearoff_menu_item_new();
	}

}

public static class GtkTearoffMenuItemHandleExtensions
{
}

internal class GtkTearoffMenuItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTearoffMenuItemHandle gtk_tearoff_menu_item_new();

}
