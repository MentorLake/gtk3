namespace MentorLake.Gtk3.Gio;

public class GMenuHandle : GMenuModelHandle
{
	public static GMenuHandle New()
	{
		return GMenuExterns.g_menu_new();
	}

}

public static class GMenuHandleExtensions
{
	public static T Append<T>(this T menu, string label, string detailed_action) where T : GMenuHandle
	{
		GMenuExterns.g_menu_append(menu, label, detailed_action);
		return menu;
	}

	public static T AppendItem<T>(this T menu, GMenuItemHandle item) where T : GMenuHandle
	{
		GMenuExterns.g_menu_append_item(menu, item);
		return menu;
	}

	public static T AppendSection<T>(this T menu, string label, GMenuModelHandle section) where T : GMenuHandle
	{
		GMenuExterns.g_menu_append_section(menu, label, section);
		return menu;
	}

	public static T AppendSubmenu<T>(this T menu, string label, GMenuModelHandle submenu) where T : GMenuHandle
	{
		GMenuExterns.g_menu_append_submenu(menu, label, submenu);
		return menu;
	}

	public static T Freeze<T>(this T menu) where T : GMenuHandle
	{
		GMenuExterns.g_menu_freeze(menu);
		return menu;
	}

	public static T Insert<T>(this T menu, int position, string label, string detailed_action) where T : GMenuHandle
	{
		GMenuExterns.g_menu_insert(menu, position, label, detailed_action);
		return menu;
	}

	public static T InsertItem<T>(this T menu, int position, GMenuItemHandle item) where T : GMenuHandle
	{
		GMenuExterns.g_menu_insert_item(menu, position, item);
		return menu;
	}

	public static T InsertSection<T>(this T menu, int position, string label, GMenuModelHandle section) where T : GMenuHandle
	{
		GMenuExterns.g_menu_insert_section(menu, position, label, section);
		return menu;
	}

	public static T InsertSubmenu<T>(this T menu, int position, string label, GMenuModelHandle submenu) where T : GMenuHandle
	{
		GMenuExterns.g_menu_insert_submenu(menu, position, label, submenu);
		return menu;
	}

	public static T Prepend<T>(this T menu, string label, string detailed_action) where T : GMenuHandle
	{
		GMenuExterns.g_menu_prepend(menu, label, detailed_action);
		return menu;
	}

	public static T PrependItem<T>(this T menu, GMenuItemHandle item) where T : GMenuHandle
	{
		GMenuExterns.g_menu_prepend_item(menu, item);
		return menu;
	}

	public static T PrependSection<T>(this T menu, string label, GMenuModelHandle section) where T : GMenuHandle
	{
		GMenuExterns.g_menu_prepend_section(menu, label, section);
		return menu;
	}

	public static T PrependSubmenu<T>(this T menu, string label, GMenuModelHandle submenu) where T : GMenuHandle
	{
		GMenuExterns.g_menu_prepend_submenu(menu, label, submenu);
		return menu;
	}

	public static T Remove<T>(this T menu, int position) where T : GMenuHandle
	{
		GMenuExterns.g_menu_remove(menu, position);
		return menu;
	}

	public static T RemoveAll<T>(this T menu) where T : GMenuHandle
	{
		GMenuExterns.g_menu_remove_all(menu);
		return menu;
	}

}

internal class GMenuExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GMenuHandle g_menu_new();

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_append(GMenuHandle menu, string label, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_append_item(GMenuHandle menu, GMenuItemHandle item);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_append_section(GMenuHandle menu, string label, GMenuModelHandle section);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_append_submenu(GMenuHandle menu, string label, GMenuModelHandle submenu);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_freeze(GMenuHandle menu);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_insert(GMenuHandle menu, int position, string label, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_insert_item(GMenuHandle menu, int position, GMenuItemHandle item);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_insert_section(GMenuHandle menu, int position, string label, GMenuModelHandle section);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_insert_submenu(GMenuHandle menu, int position, string label, GMenuModelHandle submenu);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_prepend(GMenuHandle menu, string label, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_prepend_item(GMenuHandle menu, GMenuItemHandle item);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_prepend_section(GMenuHandle menu, string label, GMenuModelHandle section);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_prepend_submenu(GMenuHandle menu, string label, GMenuModelHandle submenu);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_remove(GMenuHandle menu, int position);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_remove_all(GMenuHandle menu);

}
