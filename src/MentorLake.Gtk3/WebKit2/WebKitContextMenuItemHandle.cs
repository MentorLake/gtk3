namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// One item of a #WebKitContextMenu.
/// </para>
/// <para>
/// The #WebKitContextMenu is composed of #WebKitContextMenuItem&amp;lt;!--
/// --&amp;gt;s. These items can be created from a #GtkAction, from a
/// #WebKitContextMenuAction or from a #WebKitContextMenuAction and a
/// label. These #WebKitContextMenuAction&amp;lt;!-- --&amp;gt;s denote stock actions
/// for the items. You can also create separators and submenus.
/// </para>
/// </summary>

public class WebKitContextMenuItemHandle : GInitiallyUnownedHandle
{
/// <summary>
/// <para>
/// Creates a new #WebKitContextMenuItem for the given @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// the newly created #WebKitContextMenuItem object.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle New(MentorLake.Gtk.GtkActionHandle action)
	{
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_new(action);
	}

/// <summary>
/// <para>
/// Creates a new #WebKitContextMenuItem for the given @action and @label.
/// </para>
/// <para>
/// On activation
/// @target will be passed as parameter to the callback.
/// </para>
/// </summary>

/// <param name="action">
/// a #GAction
/// </param>
/// <param name="label">
/// the menu item label text
/// </param>
/// <param name="target">
/// a #GVariant to use as the action target
/// </param>
/// <return>
/// the newly created #WebKitContextMenuItem object.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle NewFromGaction(MentorLake.Gio.GActionHandle action, string label, MentorLake.GLib.GVariantHandle target)
	{
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_new_from_gaction(action, label, target);
	}

/// <summary>
/// <para>
/// Creates a new #WebKitContextMenuItem for the given stock action.
/// </para>
/// <para>
/// Stock actions are handled automatically by WebKit so that, for example,
/// when a menu item created with a %WEBKIT_CONTEXT_MENU_ACTION_STOP is
/// activated the action associated will be handled by WebKit and the current
/// load operation will be stopped. You can get the #GAction of a
/// #WebKitContextMenuItem created with a #WebKitContextMenuAction with
/// webkit_context_menu_item_get_gaction() and connect to the #GSimpleAction::activate signal
/// to be notified when the item is activated, but you can&apos;t prevent the associated
/// action from being performed.
/// </para>
/// </summary>

/// <param name="action">
/// a #WebKitContextMenuAction stock action
/// </param>
/// <return>
/// the newly created #WebKitContextMenuItem object.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle NewFromStockAction(MentorLake.WebKit2.WebKitContextMenuAction action)
	{
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_new_from_stock_action(action);
	}

/// <summary>
/// <para>
/// Creates a new #WebKitContextMenuItem for the given stock action using the given @label.
/// </para>
/// <para>
/// Stock actions have a predefined label, this method can be used to create a
/// #WebKitContextMenuItem for a #WebKitContextMenuAction but using a custom label.
/// </para>
/// </summary>

/// <param name="action">
/// a #WebKitContextMenuAction stock action
/// </param>
/// <param name="label">
/// a custom label text to use instead of the predefined one
/// </param>
/// <return>
/// the newly created #WebKitContextMenuItem object.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle NewFromStockActionWithLabel(MentorLake.WebKit2.WebKitContextMenuAction action, string label)
	{
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_new_from_stock_action_with_label(action, label);
	}

/// <summary>
/// <para>
/// Creates a new #WebKitContextMenuItem representing a separator.
/// </para>
/// </summary>

/// <return>
/// the newly created #WebKitContextMenuItem object.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle NewSeparator()
	{
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_new_separator();
	}

/// <summary>
/// <para>
/// Creates a new #WebKitContextMenuItem using the given @label with a submenu.
/// </para>
/// </summary>

/// <param name="label">
/// the menu item label text
/// </param>
/// <param name="submenu">
/// a #WebKitContextMenu to set
/// </param>
/// <return>
/// the newly created #WebKitContextMenuItem object.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuItemHandle NewWithSubmenu(string label, MentorLake.WebKit2.WebKitContextMenuHandle submenu)
	{
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_new_with_submenu(label, submenu);
	}

}

public static class WebKitContextMenuItemHandleExtensions
{
/// <summary>
/// <para>
/// Gets the action associated to @item as a #GtkAction.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitContextMenuItem
/// </param>
/// <return>
/// the #GtkAction associated to the #WebKitContextMenuItem,
///    or %NULL if @item is a separator.
/// </return>

	public static MentorLake.Gtk.GtkActionHandle GetAction(this MentorLake.WebKit2.WebKitContextMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuItemHandle)");
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_get_action(item);
	}

/// <summary>
/// <para>
/// Gets the action associated to @item as a #GAction.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitContextMenuItem
/// </param>
/// <return>
/// the #GAction associated to the #WebKitContextMenuItem,
///    or %NULL if @item is a separator.
/// </return>

	public static MentorLake.Gio.GActionHandle GetGaction(this MentorLake.WebKit2.WebKitContextMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuItemHandle)");
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_get_gaction(item);
	}

/// <summary>
/// <para>
/// Gets the target #GVariant associated with @item.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitContextMenuItem
/// </param>
/// <return>
/// the target #GVariant of the #WebKitContextMenuItem,
///    or %NULL if @item was not created with webkit_context_menu_item_new_from_gaction()
///    or if no target was specified.
/// </return>

	public static MentorLake.GLib.GVariantHandle GetGactionTarget(this MentorLake.WebKit2.WebKitContextMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuItemHandle)");
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_get_gaction_target(item);
	}

/// <summary>
/// <para>
/// Gets the #WebKitContextMenuAction of @item.
/// </para>
/// <para>
/// If the #WebKitContextMenuItem was not
/// created for a stock action %WEBKIT_CONTEXT_MENU_ACTION_CUSTOM will be
/// returned. If the #WebKitContextMenuItem is a separator %WEBKIT_CONTEXT_MENU_ACTION_NO_ACTION
/// will be returned.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitContextMenuItem
/// </param>
/// <return>
/// the #WebKitContextMenuAction of @item
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuAction GetStockAction(this MentorLake.WebKit2.WebKitContextMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuItemHandle)");
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_get_stock_action(item);
	}

/// <summary>
/// <para>
/// Gets the submenu of @item.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitContextMenuItem
/// </param>
/// <return>
/// the #WebKitContextMenu representing the submenu of
///    @item or %NULL if @item doesn&apos;t have a submenu.
/// </return>

	public static MentorLake.WebKit2.WebKitContextMenuHandle GetSubmenu(this MentorLake.WebKit2.WebKitContextMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuItemHandle)");
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_get_submenu(item);
	}

/// <summary>
/// <para>
/// Gets the title of @item.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitContextMenuItem
/// </param>
/// <return>
/// the title of @item, or %NULL if @item is a separator.
/// </return>

	public static string GetTitle(this MentorLake.WebKit2.WebKitContextMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuItemHandle)");
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_get_title(item);
	}

/// <summary>
/// <para>
/// Checks whether @item is a separator.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitContextMenuItem
/// </param>
/// <return>
/// %TRUE is @item is a separator or %FALSE otherwise
/// </return>

	public static bool IsSeparator(this MentorLake.WebKit2.WebKitContextMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuItemHandle)");
		return WebKitContextMenuItemHandleExterns.webkit_context_menu_item_is_separator(item);
	}

/// <summary>
/// <para>
/// Sets or replaces the @item submenu.
/// </para>
/// <para>
/// If @submenu is %NULL the current
/// submenu of @item is removed.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitContextMenuItem
/// </param>
/// <param name="submenu">
/// a #WebKitContextMenu
/// </param>

	public static T SetSubmenu<T>(this T item, MentorLake.WebKit2.WebKitContextMenuHandle submenu) where T : WebKitContextMenuItemHandle
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitContextMenuItemHandle)");
		WebKitContextMenuItemHandleExterns.webkit_context_menu_item_set_submenu(item, submenu);
		return item;
	}

}

internal class WebKitContextMenuItemHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_item_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_item_new_from_gaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_item_new_from_stock_action(MentorLake.WebKit2.WebKitContextMenuAction action);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_item_new_from_stock_action_with_label(MentorLake.WebKit2.WebKitContextMenuAction action, string label);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_item_new_separator();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuItemHandle webkit_context_menu_item_new_with_submenu(string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle submenu);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))]
	internal static extern MentorLake.Gtk.GtkActionHandle webkit_context_menu_item_get_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))]
	internal static extern MentorLake.Gio.GActionHandle webkit_context_menu_item_get_gaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle webkit_context_menu_item_get_gaction_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitContextMenuAction webkit_context_menu_item_get_stock_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))]
	internal static extern MentorLake.WebKit2.WebKitContextMenuHandle webkit_context_menu_item_get_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_context_menu_item_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_context_menu_item_is_separator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_context_menu_item_set_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuItemHandle>))] MentorLake.WebKit2.WebKitContextMenuItemHandle item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle submenu);

}
