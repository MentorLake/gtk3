namespace MentorLake.Gtk3.Gtk3;

public class GtkMenuBarHandle : GtkMenuShellHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkMenuBarHandle New()
	{
		return GtkMenuBarExterns.gtk_menu_bar_new();
	}

	public static GtkMenuBarHandle NewFromModel(GMenuModelHandle model)
	{
		return GtkMenuBarExterns.gtk_menu_bar_new_from_model(model);
	}

}

public static class GtkMenuBarHandleExtensions
{
	public static GtkPackDirection GetChildPackDirection(this GtkMenuBarHandle menubar)
	{
		return GtkMenuBarExterns.gtk_menu_bar_get_child_pack_direction(menubar);
	}

	public static GtkPackDirection GetPackDirection(this GtkMenuBarHandle menubar)
	{
		return GtkMenuBarExterns.gtk_menu_bar_get_pack_direction(menubar);
	}

	public static T SetChildPackDirection<T>(this T menubar, GtkPackDirection child_pack_dir) where T : GtkMenuBarHandle
	{
		GtkMenuBarExterns.gtk_menu_bar_set_child_pack_direction(menubar, child_pack_dir);
		return menubar;
	}

	public static T SetPackDirection<T>(this T menubar, GtkPackDirection pack_dir) where T : GtkMenuBarHandle
	{
		GtkMenuBarExterns.gtk_menu_bar_set_pack_direction(menubar, pack_dir);
		return menubar;
	}

}

internal class GtkMenuBarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuBarHandle gtk_menu_bar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuBarHandle gtk_menu_bar_new_from_model(GMenuModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPackDirection gtk_menu_bar_get_child_pack_direction(GtkMenuBarHandle menubar);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPackDirection gtk_menu_bar_get_pack_direction(GtkMenuBarHandle menubar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_bar_set_child_pack_direction(GtkMenuBarHandle menubar, GtkPackDirection child_pack_dir);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_bar_set_pack_direction(GtkMenuBarHandle menubar, GtkPackDirection pack_dir);

}
