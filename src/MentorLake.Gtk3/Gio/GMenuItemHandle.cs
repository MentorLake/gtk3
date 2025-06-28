namespace MentorLake.Gio;

public class GMenuItemHandle : GObjectHandle
{
	public static MentorLake.Gio.GMenuItemHandle New(string label, string detailed_action)
	{
		return GMenuItemHandleExterns.g_menu_item_new(label, detailed_action);
	}

	public static MentorLake.Gio.GMenuItemHandle NewFromModel(MentorLake.Gio.GMenuModelHandle model, int item_index)
	{
		return GMenuItemHandleExterns.g_menu_item_new_from_model(model, item_index);
	}

	public static MentorLake.Gio.GMenuItemHandle NewSection(string label, MentorLake.Gio.GMenuModelHandle section)
	{
		return GMenuItemHandleExterns.g_menu_item_new_section(label, section);
	}

	public static MentorLake.Gio.GMenuItemHandle NewSubmenu(string label, MentorLake.Gio.GMenuModelHandle submenu)
	{
		return GMenuItemHandleExterns.g_menu_item_new_submenu(label, submenu);
	}

}

public static class GMenuItemHandleExtensions
{
	public static bool GetAttribute(this MentorLake.Gio.GMenuItemHandle menu_item, string attribute, string format_string, IntPtr @__arglist)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		return GMenuItemHandleExterns.g_menu_item_get_attribute(menu_item, attribute, format_string, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle GetAttributeValue(this MentorLake.Gio.GMenuItemHandle menu_item, string attribute, MentorLake.GLib.GVariantTypeHandle expected_type)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		return GMenuItemHandleExterns.g_menu_item_get_attribute_value(menu_item, attribute, expected_type);
	}

	public static MentorLake.Gio.GMenuModelHandle GetLink(this MentorLake.Gio.GMenuItemHandle menu_item, string link)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		return GMenuItemHandleExterns.g_menu_item_get_link(menu_item, link);
	}

	public static T SetActionAndTarget<T>(this T menu_item, string action, string format_string, IntPtr @__arglist) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_action_and_target(menu_item, action, format_string, @__arglist);
		return menu_item;
	}

	public static T SetActionAndTargetValue<T>(this T menu_item, string action, MentorLake.GLib.GVariantHandle target_value) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_action_and_target_value(menu_item, action, target_value);
		return menu_item;
	}

	public static T SetAttribute<T>(this T menu_item, string attribute, string format_string, IntPtr @__arglist) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_attribute(menu_item, attribute, format_string, @__arglist);
		return menu_item;
	}

	public static T SetAttributeValue<T>(this T menu_item, string attribute, MentorLake.GLib.GVariantHandle value) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_attribute_value(menu_item, attribute, value);
		return menu_item;
	}

	public static T SetDetailedAction<T>(this T menu_item, string detailed_action) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_detailed_action(menu_item, detailed_action);
		return menu_item;
	}

	public static T SetIcon<T>(this T menu_item, MentorLake.Gio.GIconHandle icon) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_icon(menu_item, icon);
		return menu_item;
	}

	public static T SetLabel<T>(this T menu_item, string label) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_label(menu_item, label);
		return menu_item;
	}

	public static T SetLink<T>(this T menu_item, string link, MentorLake.Gio.GMenuModelHandle model) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_link(menu_item, link, model);
		return menu_item;
	}

	public static T SetSection<T>(this T menu_item, MentorLake.Gio.GMenuModelHandle section) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_section(menu_item, section);
		return menu_item;
	}

	public static T SetSubmenu<T>(this T menu_item, MentorLake.Gio.GMenuModelHandle submenu) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_submenu(menu_item, submenu);
		return menu_item;
	}

}

internal class GMenuItemHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))]
	internal static extern MentorLake.Gio.GMenuItemHandle g_menu_item_new(string label, string detailed_action);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))]
	internal static extern MentorLake.Gio.GMenuItemHandle g_menu_item_new_from_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))]
	internal static extern MentorLake.Gio.GMenuItemHandle g_menu_item_new_section(string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle section);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))]
	internal static extern MentorLake.Gio.GMenuItemHandle g_menu_item_new_submenu(string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle submenu);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_item_get_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string attribute, string format_string, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_menu_item_get_attribute_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string attribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle g_menu_item_get_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string link);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_action_and_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string action, string format_string, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_action_and_target_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string attribute, string format_string, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_attribute_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string attribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_detailed_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string detailed_action);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string label);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, string link, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_section([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle section);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_item_set_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle submenu);

}
