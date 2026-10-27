namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents the context menu in a #WebKitWebView.
/// </para>
/// <para>
/// #WebKitContextMenu represents a context menu containing
/// #WebKitContextMenuItem&amp;lt;!-- --&amp;gt;s in a #WebKitWebView.
/// </para>
/// <para>
/// When a #WebKitWebView is about to display the context menu, it
/// emits the #WebKitWebView::context-menu signal, which has the
/// #WebKitContextMenu as an argument. You can modify it, adding new
/// submenus that you can create with webkit_context_menu_new(), adding
/// new #WebKitContextMenuItem&amp;lt;!-- --&amp;gt;s with
/// webkit_context_menu_prepend(), webkit_context_menu_append() or
/// webkit_context_menu_insert(), maybe after having removed the
/// existing ones with webkit_context_menu_remove_all().
/// </para>
/// </summary>

public class WebKitContextMenuHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #WebKitContextMenu object.
/// </para>
/// <para>
/// Creates a new #WebKitContextMenu object to be used as a submenu of an existing
/// #WebKitContextMenu. The context menu of a #WebKitWebView is created by the view
/// and passed as an argument of #WebKitWebView::context-menu signal.
/// To add items to the menu use webkit_context_menu_prepend(),
/// webkit_context_menu_append() or webkit_context_menu_insert().
/// See also webkit_context_menu_new_with_items() to create a #WebKitContextMenu with
/// a list of initial items.
/// </para>
/// </summary>

/// <return>
/// The newly created #WebKitContextMenu object
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuHandle New()
	{
		return WebKitContextMenuHandleExterns.webkit_context_menu_new();
	}

/// <summary>
/// <para>
/// Creates a new #WebKitContextMenu object with the given items.
/// </para>
/// <para>
/// Creates a new #WebKitContextMenu object to be used as a submenu of an existing
/// #WebKitContextMenu with the given initial items.
/// See also webkit_context_menu_new()
/// </para>
/// </summary>

/// <param name="items">
/// a #GList of #WebKitContextMenuItem
/// </param>
/// <return>
/// The newly created #WebKitContextMenu object
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuHandle NewWithItems(MentorLake.GLib.GListHandle items)
	{
		return WebKitContextMenuHandleExterns.webkit_context_menu_new_with_items(items);
	}

}

public static class WebKitContextMenuHandleExtensions
{
/// <summary>
/// <para>
/// Adds @item at the end of the @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <param name="item">
/// the #WebKitContextMenuItem to add
/// </param>

	public static T Append<T>(this T menu, MentorLake.WebKit2.WebKitContextMenuItemHandle item) where T : WebKitContextMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		WebKitContextMenuHandleExterns.webkit_context_menu_append(menu, item);
		return menu;
	}

/// <summary>
/// <para>
/// Gets the first item in the @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <return>
/// the first #WebKitContextMenuItem of @menu,
///    or %NULL if the #WebKitContextMenu is empty.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle First(this MentorLake.WebKit2.WebKitContextMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		return WebKitContextMenuHandleExterns.webkit_context_menu_first(menu);
	}

/// <summary>
/// <para>
/// Gets the #GdkEvent that triggered the context menu. This function only returns a valid
/// #GdkEvent when called for a #WebKitContextMenu passed to #WebKitWebView::context-menu
/// signal; in all other cases, %NULL is returned.
/// </para>
/// <para>
/// The returned #GdkEvent is expected to be one of the following types:
/// &amp;lt;itemizedlist&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
/// a #GdkEventButton of type %GDK_BUTTON_PRESS when the context menu was triggered with mouse.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
/// a #GdkEventKey of type %GDK_KEY_PRESS if the keyboard was used to show the menu.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
/// a generic #GdkEvent of type %GDK_NOTHING when the #GtkWidget::popup-menu signal was used to show the context menu.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;/itemizedlist&amp;gt;
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <return>
/// the menu event or %NULL.
/// </return>

	public static MentorLake.Gdk.GdkEventHandle GetEvent(this MentorLake.WebKit2.WebKitContextMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		return WebKitContextMenuHandleExterns.webkit_context_menu_get_event(menu);
	}

/// <summary>
/// <para>
/// Gets the item at the given position in the @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <param name="position">
/// the position of the item, counting from 0
/// </param>
/// <return>
/// the #WebKitContextMenuItem at position @position in @menu,
///    or %NULL if the position is off the end of the @menu.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle GetItemAtPosition(this MentorLake.WebKit2.WebKitContextMenuHandle menu, uint position)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		return WebKitContextMenuHandleExterns.webkit_context_menu_get_item_at_position(menu, position);
	}

/// <summary>
/// <para>
/// Returns the item list of @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <return>
/// a #GList of
///    #WebKitContextMenuItem&amp;lt;!-- --&amp;gt;s
/// </return>

	public static MentorLake.GLib.GListHandle GetItems(this MentorLake.WebKit2.WebKitContextMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		return WebKitContextMenuHandleExterns.webkit_context_menu_get_items(menu);
	}

/// <summary>
/// <para>
/// Gets the length of the @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <return>
/// the number of #WebKitContextMenuItem&amp;lt;!-- --&amp;gt;s in @menu
/// </return>

	public static uint GetNItems(this MentorLake.WebKit2.WebKitContextMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		return WebKitContextMenuHandleExterns.webkit_context_menu_get_n_items(menu);
	}

/// <summary>
/// <para>
/// Gets the position in view coordinates where the context menu was triggered.
/// </para>
/// <para>
/// This function only returns valid coordinates when called for a #WebKitContextMenu
/// passed to #WebKitWebView::context-menu signal.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <param name="x">
/// return location for the x coordinate
/// </param>
/// <param name="y">
/// return location for the y coordinate
/// </param>
/// <return>
/// %TRUE if valid position coordinates are available, %FALSE otherwise
/// </return>

	public static bool GetPosition(this MentorLake.WebKit2.WebKitContextMenuHandle menu, out int x, out int y)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		return WebKitContextMenuHandleExterns.webkit_context_menu_get_position(menu, out x, out y);
	}

/// <summary>
/// <para>
/// Gets the user data of @menu.
/// </para>
/// <para>
/// This function can be used from the UI Process to get user data previously set
/// from the Web Process with webkit_context_menu_set_user_data().
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <return>
/// the user data of @menu, or %NULL if @menu doesn&apos;t have user data
/// </return>

	public static MentorLake.GLib.GVariantHandle GetUserData(this MentorLake.WebKit2.WebKitContextMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		return WebKitContextMenuHandleExterns.webkit_context_menu_get_user_data(menu);
	}

/// <summary>
/// <para>
/// Inserts @item into the @menu at the given position.
/// </para>
/// <para>
/// If @position is negative, or is larger than the number of items
/// in the #WebKitContextMenu, the item is added on to the end of
/// the @menu. The first position is 0.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <param name="item">
/// the #WebKitContextMenuItem to add
/// </param>
/// <param name="position">
/// the position to insert the item
/// </param>

	public static T Insert<T>(this T menu, MentorLake.WebKit2.WebKitContextMenuItemHandle item, int position) where T : WebKitContextMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		WebKitContextMenuHandleExterns.webkit_context_menu_insert(menu, item, position);
		return menu;
	}

/// <summary>
/// <para>
/// Gets the last item in the @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <return>
/// the last #WebKitContextMenuItem of @menu,
///    or %NULL if the #WebKitContextMenu is empty.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle Last(this MentorLake.WebKit2.WebKitContextMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		return WebKitContextMenuHandleExterns.webkit_context_menu_last(menu);
	}

/// <summary>
/// <para>
/// Moves @item to the given position in the @menu.
/// </para>
/// <para>
/// If @position is negative, or is larger than the number of items
/// in the #WebKitContextMenu, the item is added on to the end of
/// the @menu.
/// The first position is 0.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <param name="item">
/// the #WebKitContextMenuItem to add
/// </param>
/// <param name="position">
/// the new position to move the item
/// </param>

	public static T MoveItem<T>(this T menu, MentorLake.WebKit2.WebKitContextMenuItemHandle item, int position) where T : WebKitContextMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		WebKitContextMenuHandleExterns.webkit_context_menu_move_item(menu, item, position);
		return menu;
	}

/// <summary>
/// <para>
/// Adds @item at the beginning of the @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <param name="item">
/// the #WebKitContextMenuItem to add
/// </param>

	public static T Prepend<T>(this T menu, MentorLake.WebKit2.WebKitContextMenuItemHandle item) where T : WebKitContextMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		WebKitContextMenuHandleExterns.webkit_context_menu_prepend(menu, item);
		return menu;
	}

/// <summary>
/// <para>
/// Removes @item from the @menu.
/// </para>
/// <para>
/// See also webkit_context_menu_remove_all() to remove all items.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <param name="item">
/// the #WebKitContextMenuItem to remove
/// </param>

	public static T Remove<T>(this T menu, MentorLake.WebKit2.WebKitContextMenuItemHandle item) where T : WebKitContextMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		WebKitContextMenuHandleExterns.webkit_context_menu_remove(menu, item);
		return menu;
	}

/// <summary>
/// <para>
/// Removes all items of the @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>

	public static T RemoveAll<T>(this T menu) where T : WebKitContextMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		WebKitContextMenuHandleExterns.webkit_context_menu_remove_all(menu);
		return menu;
	}

/// <summary>
/// <para>
/// Sets user data to @menu.
/// </para>
/// <para>
/// This function can be used from a Web Process extension to set user data
/// that can be retrieved from the UI Process using webkit_context_menu_get_user_data().
/// If the @user_data #GVariant is floating, it is consumed.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitContextMenu
/// </param>
/// <param name="user_data">
/// a #GVariant
/// </param>

	public static T SetUserData<T>(this T menu, MentorLake.GLib.GVariantHandle user_data) where T : WebKitContextMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuHandle)");
		WebKitContextMenuHandleExterns.webkit_context_menu_set_user_data(menu, user_data);
		return menu;
	}

}

internal class WebKitContextMenuHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuHandle webkit_context_menu_new();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuHandle webkit_context_menu_new_with_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle items);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_context_menu_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle webkit_context_menu_get_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_get_item_at_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu, uint position);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_context_menu_get_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_context_menu_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_context_menu_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu, out int x, out int y);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle webkit_context_menu_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_context_menu_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item, int position);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_last([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_context_menu_move_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item, int position);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_context_menu_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_context_menu_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_context_menu_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_context_menu_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle user_data);

}
