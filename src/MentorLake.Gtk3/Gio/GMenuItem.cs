namespace MentorLake.Gtk3.Gio;

public class GMenuItemHandle : GObjectHandle
{
	public static GMenuItemHandle New(string label, string detailed_action)
	{
		return GMenuItemExterns.g_menu_item_new(label, detailed_action);
	}

	public static GMenuItemHandle NewFromModel(GMenuModelHandle model, int item_index)
	{
		return GMenuItemExterns.g_menu_item_new_from_model(model, item_index);
	}

	public static GMenuItemHandle NewSection(string label, GMenuModelHandle section)
	{
		return GMenuItemExterns.g_menu_item_new_section(label, section);
	}

	public static GMenuItemHandle NewSubmenu(string label, GMenuModelHandle submenu)
	{
		return GMenuItemExterns.g_menu_item_new_submenu(label, submenu);
	}

}

public static class GMenuItemHandleExtensions
{
	public static bool GetAttribute(this GMenuItemHandle menu_item, string attribute, string format_string, IntPtr @__arglist)
	{
		return GMenuItemExterns.g_menu_item_get_attribute(menu_item, attribute, format_string, @__arglist);
	}

	public static GVariantHandle GetAttributeValue(this GMenuItemHandle menu_item, string attribute, GVariantTypeHandle expected_type)
	{
		return GMenuItemExterns.g_menu_item_get_attribute_value(menu_item, attribute, expected_type);
	}

	public static GMenuModelHandle GetLink(this GMenuItemHandle menu_item, string link)
	{
		return GMenuItemExterns.g_menu_item_get_link(menu_item, link);
	}

	public static T SetActionAndTarget<T>(this T menu_item, string action, string format_string, IntPtr @__arglist) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_action_and_target(menu_item, action, format_string, @__arglist);
		return menu_item;
	}

	public static T SetActionAndTargetValue<T>(this T menu_item, string action, GVariantHandle target_value) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_action_and_target_value(menu_item, action, target_value);
		return menu_item;
	}

	public static T SetAttribute<T>(this T menu_item, string attribute, string format_string, IntPtr @__arglist) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_attribute(menu_item, attribute, format_string, @__arglist);
		return menu_item;
	}

	public static T SetAttributeValue<T>(this T menu_item, string attribute, GVariantHandle value) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_attribute_value(menu_item, attribute, value);
		return menu_item;
	}

	public static T SetDetailedAction<T>(this T menu_item, string detailed_action) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_detailed_action(menu_item, detailed_action);
		return menu_item;
	}

	public static T SetIcon<T>(this T menu_item, GIconHandle icon) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_icon(menu_item, icon);
		return menu_item;
	}

	public static T SetLabel<T>(this T menu_item, string label) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_label(menu_item, label);
		return menu_item;
	}

	public static T SetLink<T>(this T menu_item, string link, GMenuModelHandle model) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_link(menu_item, link, model);
		return menu_item;
	}

	public static T SetSection<T>(this T menu_item, GMenuModelHandle section) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_section(menu_item, section);
		return menu_item;
	}

	public static T SetSubmenu<T>(this T menu_item, GMenuModelHandle submenu) where T : GMenuItemHandle
	{
		GMenuItemExterns.g_menu_item_set_submenu(menu_item, submenu);
		return menu_item;
	}

}

internal class GMenuItemExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GMenuItemHandle g_menu_item_new(string label, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern GMenuItemHandle g_menu_item_new_from_model(GMenuModelHandle model, int item_index);

	[DllImport(Libraries.Gio)]
	internal static extern GMenuItemHandle g_menu_item_new_section(string label, GMenuModelHandle section);

	[DllImport(Libraries.Gio)]
	internal static extern GMenuItemHandle g_menu_item_new_submenu(string label, GMenuModelHandle submenu);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_menu_item_get_attribute(GMenuItemHandle menu_item, string attribute, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_menu_item_get_attribute_value(GMenuItemHandle menu_item, string attribute, GVariantTypeHandle expected_type);

	[DllImport(Libraries.Gio)]
	internal static extern GMenuModelHandle g_menu_item_get_link(GMenuItemHandle menu_item, string link);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_action_and_target(GMenuItemHandle menu_item, string action, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_action_and_target_value(GMenuItemHandle menu_item, string action, GVariantHandle target_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_attribute(GMenuItemHandle menu_item, string attribute, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_attribute_value(GMenuItemHandle menu_item, string attribute, GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_detailed_action(GMenuItemHandle menu_item, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_icon(GMenuItemHandle menu_item, GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_label(GMenuItemHandle menu_item, string label);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_link(GMenuItemHandle menu_item, string link, GMenuModelHandle model);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_section(GMenuItemHandle menu_item, GMenuModelHandle section);

	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_item_set_submenu(GMenuItemHandle menu_item, GMenuModelHandle submenu);

}
