namespace MentorLake.Gio;

public class GMenuHandle : GMenuModelHandle
{
	public static MentorLake.Gio.GMenuHandle New()
	{
		return GMenuHandleExterns.g_menu_new();
	}

}

public static class GMenuHandleExtensions
{
	public static T Append<T>(this T menu, string label, string detailed_action) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_append(menu, label, detailed_action);
		return menu;
	}

	public static T AppendItem<T>(this T menu, MentorLake.Gio.GMenuItemHandle item) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_append_item(menu, item);
		return menu;
	}

	public static T AppendSection<T>(this T menu, string label, MentorLake.Gio.GMenuModelHandle section) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_append_section(menu, label, section);
		return menu;
	}

	public static T AppendSubmenu<T>(this T menu, string label, MentorLake.Gio.GMenuModelHandle submenu) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_append_submenu(menu, label, submenu);
		return menu;
	}

	public static T Freeze<T>(this T menu) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_freeze(menu);
		return menu;
	}

	public static T Insert<T>(this T menu, int position, string label, string detailed_action) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_insert(menu, position, label, detailed_action);
		return menu;
	}

	public static T InsertItem<T>(this T menu, int position, MentorLake.Gio.GMenuItemHandle item) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_insert_item(menu, position, item);
		return menu;
	}

	public static T InsertSection<T>(this T menu, int position, string label, MentorLake.Gio.GMenuModelHandle section) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_insert_section(menu, position, label, section);
		return menu;
	}

	public static T InsertSubmenu<T>(this T menu, int position, string label, MentorLake.Gio.GMenuModelHandle submenu) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_insert_submenu(menu, position, label, submenu);
		return menu;
	}

	public static T Prepend<T>(this T menu, string label, string detailed_action) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_prepend(menu, label, detailed_action);
		return menu;
	}

	public static T PrependItem<T>(this T menu, MentorLake.Gio.GMenuItemHandle item) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_prepend_item(menu, item);
		return menu;
	}

	public static T PrependSection<T>(this T menu, string label, MentorLake.Gio.GMenuModelHandle section) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_prepend_section(menu, label, section);
		return menu;
	}

	public static T PrependSubmenu<T>(this T menu, string label, MentorLake.Gio.GMenuModelHandle submenu) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_prepend_submenu(menu, label, submenu);
		return menu;
	}

	public static T Remove<T>(this T menu, int position) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_remove(menu, position);
		return menu;
	}

	public static T RemoveAll<T>(this T menu) where T : GMenuHandle
	{
		GMenuHandleExterns.g_menu_remove_all(menu);
		return menu;
	}

}

internal class GMenuHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMenuHandle g_menu_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, string label, string detailed_action);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_append_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle item);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_append_section([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle section);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_append_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle submenu);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_freeze([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, int position, string label, string detailed_action);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_insert_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, int position, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle item);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_insert_section([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, int position, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle section);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_insert_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, int position, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle submenu);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, string label, string detailed_action);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_prepend_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuItemHandle>))] MentorLake.Gio.GMenuItemHandle item);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_prepend_section([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle section);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_prepend_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle submenu);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu, int position);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))] MentorLake.Gio.GMenuHandle menu);

}
