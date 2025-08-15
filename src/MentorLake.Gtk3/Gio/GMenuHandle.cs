namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GMenu` is a simple implementation of [class@Gio.MenuModel].
/// You populate a `GMenu` by adding [class@Gio.MenuItem] instances to it.
/// </para>
/// <para>
/// There are some convenience functions to allow you to directly
/// add items (avoiding [class@Gio.MenuItem]) for the common cases. To add
/// a regular item, use [method@Gio.Menu.insert]. To add a section, use
/// [method@Gio.Menu.insert_section]. To add a submenu, use
/// [method@Gio.Menu.insert_submenu].
/// </para>
/// </summary>

public class GMenuHandle : GMenuModelHandle
{
/// <summary>
/// <para>
/// Creates a new #GMenu.
/// </para>
/// <para>
/// The new menu has no items.
/// </para>
/// </summary>

/// <return>
/// a new #GMenu
/// </return>

	public static MentorLake.Gio.GMenuHandle New()
	{
		return GMenuHandleExterns.g_menu_new();
	}

}

public static class GMenuHandleExtensions
{
/// <summary>
/// <para>
/// Convenience function for appending a normal menu item to the end of
/// @menu.  Combine g_menu_item_new() and g_menu_insert_item() for a more
/// flexible alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="detailed_action">
/// the detailed action string, or %NULL
/// </param>

	public static T Append<T>(this T menu, string label, string detailed_action) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_append(menu, label, detailed_action);
		return menu;
	}

/// <summary>
/// <para>
/// Appends @item to the end of @menu.
/// </para>
/// <para>
/// See g_menu_insert_item() for more information.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="item">
/// a #GMenuItem to append
/// </param>

	public static T AppendItem<T>(this T menu, MentorLake.Gio.GMenuItemHandle item) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_append_item(menu, item);
		return menu;
	}

/// <summary>
/// <para>
/// Convenience function for appending a section menu item to the end of
/// @menu.  Combine g_menu_item_new_section() and g_menu_insert_item() for a
/// more flexible alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="section">
/// a #GMenuModel with the items of the section
/// </param>

	public static T AppendSection<T>(this T menu, string label, MentorLake.Gio.GMenuModelHandle section) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_append_section(menu, label, section);
		return menu;
	}

/// <summary>
/// <para>
/// Convenience function for appending a submenu menu item to the end of
/// @menu.  Combine g_menu_item_new_submenu() and g_menu_insert_item() for a
/// more flexible alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="submenu">
/// a #GMenuModel with the items of the submenu
/// </param>

	public static T AppendSubmenu<T>(this T menu, string label, MentorLake.Gio.GMenuModelHandle submenu) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_append_submenu(menu, label, submenu);
		return menu;
	}

/// <summary>
/// <para>
/// Marks @menu as frozen.
/// </para>
/// <para>
/// After the menu is frozen, it is an error to attempt to make any
/// changes to it.  In effect this means that the #GMenu API must no
/// longer be used.
/// </para>
/// <para>
/// This function causes g_menu_model_is_mutable() to begin returning
/// %FALSE, which has some positive performance implications.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>

	public static T Freeze<T>(this T menu) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_freeze(menu);
		return menu;
	}

/// <summary>
/// <para>
/// Convenience function for inserting a normal menu item into @menu.
/// Combine g_menu_item_new() and g_menu_insert_item() for a more flexible
/// alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="position">
/// the position at which to insert the item
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="detailed_action">
/// the detailed action string, or %NULL
/// </param>

	public static T Insert<T>(this T menu, int position, string label, string detailed_action) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_insert(menu, position, label, detailed_action);
		return menu;
	}

/// <summary>
/// <para>
/// Inserts @item into @menu.
/// </para>
/// <para>
/// The &quot;insertion&quot; is actually done by copying all of the attribute and
/// link values of @item and using them to form a new item within @menu.
/// As such, @item itself is not really inserted, but rather, a menu item
/// that is exactly the same as the one presently described by @item.
/// </para>
/// <para>
/// This means that @item is essentially useless after the insertion
/// occurs.  Any changes you make to it are ignored unless it is inserted
/// again (at which point its updated values will be copied).
/// </para>
/// <para>
/// You should probably just free @item once you&apos;re done.
/// </para>
/// <para>
/// There are many convenience functions to take care of common cases.
/// See g_menu_insert(), g_menu_insert_section() and
/// g_menu_insert_submenu() as well as &quot;prepend&quot; and &quot;append&quot; variants of
/// each of these functions.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="position">
/// the position at which to insert the item
/// </param>
/// <param name="item">
/// the #GMenuItem to insert
/// </param>

	public static T InsertItem<T>(this T menu, int position, MentorLake.Gio.GMenuItemHandle item) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_insert_item(menu, position, item);
		return menu;
	}

/// <summary>
/// <para>
/// Convenience function for inserting a section menu item into @menu.
/// Combine g_menu_item_new_section() and g_menu_insert_item() for a more
/// flexible alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="position">
/// the position at which to insert the item
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="section">
/// a #GMenuModel with the items of the section
/// </param>

	public static T InsertSection<T>(this T menu, int position, string label, MentorLake.Gio.GMenuModelHandle section) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_insert_section(menu, position, label, section);
		return menu;
	}

/// <summary>
/// <para>
/// Convenience function for inserting a submenu menu item into @menu.
/// Combine g_menu_item_new_submenu() and g_menu_insert_item() for a more
/// flexible alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="position">
/// the position at which to insert the item
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="submenu">
/// a #GMenuModel with the items of the submenu
/// </param>

	public static T InsertSubmenu<T>(this T menu, int position, string label, MentorLake.Gio.GMenuModelHandle submenu) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_insert_submenu(menu, position, label, submenu);
		return menu;
	}

/// <summary>
/// <para>
/// Convenience function for prepending a normal menu item to the start
/// of @menu.  Combine g_menu_item_new() and g_menu_insert_item() for a more
/// flexible alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="detailed_action">
/// the detailed action string, or %NULL
/// </param>

	public static T Prepend<T>(this T menu, string label, string detailed_action) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_prepend(menu, label, detailed_action);
		return menu;
	}

/// <summary>
/// <para>
/// Prepends @item to the start of @menu.
/// </para>
/// <para>
/// See g_menu_insert_item() for more information.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="item">
/// a #GMenuItem to prepend
/// </param>

	public static T PrependItem<T>(this T menu, MentorLake.Gio.GMenuItemHandle item) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_prepend_item(menu, item);
		return menu;
	}

/// <summary>
/// <para>
/// Convenience function for prepending a section menu item to the start
/// of @menu.  Combine g_menu_item_new_section() and g_menu_insert_item() for
/// a more flexible alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="section">
/// a #GMenuModel with the items of the section
/// </param>

	public static T PrependSection<T>(this T menu, string label, MentorLake.Gio.GMenuModelHandle section) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_prepend_section(menu, label, section);
		return menu;
	}

/// <summary>
/// <para>
/// Convenience function for prepending a submenu menu item to the start
/// of @menu.  Combine g_menu_item_new_submenu() and g_menu_insert_item() for
/// a more flexible alternative.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="submenu">
/// a #GMenuModel with the items of the submenu
/// </param>

	public static T PrependSubmenu<T>(this T menu, string label, MentorLake.Gio.GMenuModelHandle submenu) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_prepend_submenu(menu, label, submenu);
		return menu;
	}

/// <summary>
/// <para>
/// Removes an item from the menu.
/// </para>
/// <para>
/// @position gives the index of the item to remove.
/// </para>
/// <para>
/// It is an error if position is not in range the range from 0 to one
/// less than the number of items in the menu.
/// </para>
/// <para>
/// It is not possible to remove items by identity since items are added
/// to the menu simply by copying their links and attributes (ie:
/// identity of the item itself is not preserved).
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>
/// <param name="position">
/// the position of the item to remove
/// </param>

	public static T Remove<T>(this T menu, int position) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_remove(menu, position);
		return menu;
	}

/// <summary>
/// <para>
/// Removes all items in the menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GMenu
/// </param>

	public static T RemoveAll<T>(this T menu) where T : GMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GMenuHandle)");
		GMenuHandleExterns.g_menu_remove_all(menu);
		return menu;
	}

}

internal class GMenuHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))]
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
