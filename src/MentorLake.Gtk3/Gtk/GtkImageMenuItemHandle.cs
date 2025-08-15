namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkImageMenuItem is a menu item which has an icon next to the text label.
/// </para>
/// <para>
/// This is functionally equivalent to:
/// </para>
/// <code>
///   GtkWidget *box = gtk_box_new (GTK_ORIENTATION_HORIZONTAL, 6);
///   GtkWidget *box = gtk_box_new (GTK_ORIENTATION_HORIZONTAL, 6);
///   GtkWidget *icon = gtk_image_new_from_icon_name (&quot;folder-music-symbolic&quot;, GTK_ICON_SIZE_MENU);
///   GtkWidget *label = gtk_label_new (&quot;Music&quot;);
///   GtkWidget *menu_item = gtk_menu_item_new ();
/// 
///   gtk_container_add (GTK_CONTAINER (box), icon);
///   gtk_container_add (GTK_CONTAINER (box), label);
/// 
///   gtk_container_add (GTK_CONTAINER (menu_item), box);
/// 
///   gtk_widget_show_all (menu_item);
/// </code>
/// <para>
/// Note that the user may disable display of menu icons using
/// the #GtkSettings:gtk-menu-images setting, so make sure to still
/// fill in the text label. If you want to ensure that your menu items
/// show an icon you are strongly encouraged to use a #GtkMenuItem
/// with a #GtkImage instead.
/// </para>
/// <para>
/// #GtkImageMenuItem has been deprecated since GTK+ 3.10. If you want to
/// display an icon in a menu item, you should use #GtkMenuItem and pack a
/// #GtkBox with a #GtkImage and a #GtkLabel instead. You should also consider
/// using #GtkBuilder and the XML #GMenu description for creating menus, by
/// following the [GMenu guide][https://developer.gnome.org/GMenu/]. You should
/// consider using icons in menu items only sparingly, and for &quot;objects&quot; (or
/// &quot;nouns&quot;) elements only, like bookmarks, files, and links; &quot;actions&quot; (or
/// &quot;verbs&quot;) should not have icons.
/// </para>
/// <para>
/// Furthermore, if you would like to display keyboard accelerator, you must
/// pack the accel label into the box using gtk_box_pack_end() and align the
/// label, otherwise the accelerator will not display correctly. The following
/// code snippet adds a keyboard accelerator to the menu item, with a key
/// binding of Ctrl+M:
/// </para>
/// <code>
///   GtkWidget *box = gtk_box_new (GTK_ORIENTATION_HORIZONTAL, 6);
///   GtkWidget *box = gtk_box_new (GTK_ORIENTATION_HORIZONTAL, 6);
///   GtkWidget *icon = gtk_image_new_from_icon_name (&quot;folder-music-symbolic&quot;, GTK_ICON_SIZE_MENU);
///   GtkWidget *label = gtk_accel_label_new (&quot;Music&quot;);
///   GtkWidget *menu_item = gtk_menu_item_new ();
///   GtkAccelGroup *accel_group = gtk_accel_group_new ();
/// 
///   gtk_container_add (GTK_CONTAINER (box), icon);
/// 
///   gtk_label_set_use_underline (GTK_LABEL (label), TRUE);
///   gtk_label_set_xalign (GTK_LABEL (label), 0.0);
/// 
///   gtk_widget_add_accelerator (menu_item, &quot;activate&quot;, accel_group,
///                               GDK_KEY_m, GDK_CONTROL_MASK, GTK_ACCEL_VISIBLE);
///   gtk_accel_label_set_accel_widget (GTK_ACCEL_LABEL (label), menu_item);
/// 
///   gtk_box_pack_end (GTK_BOX (box), label, TRUE, TRUE, 0);
/// 
///   gtk_container_add (GTK_CONTAINER (menu_item), box);
/// 
///   gtk_widget_show_all (menu_item);
/// </code>
/// </summary>

public class GtkImageMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkImageMenuItem with an empty label.
/// </para>
/// </summary>

/// <return>
/// a new #GtkImageMenuItem
/// </return>

	public static MentorLake.Gtk.GtkImageMenuItemHandle New()
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkImageMenuItem containing the image and text from a
/// stock item. Some stock ids have preprocessor macros like #GTK_STOCK_OK
/// and #GTK_STOCK_APPLY.
/// </para>
/// <para>
/// If you want this menu item to have changeable accelerators, then pass in
/// %NULL for accel_group. Next call gtk_menu_item_set_accel_path() with an
/// appropriate path for the menu item, use gtk_stock_lookup() to look up the
/// standard accelerator for the stock item, and if one is found, call
/// gtk_accel_map_add_entry() to register it.
/// </para>
/// </summary>

/// <param name="stock_id">
/// the name of the stock item.
/// </param>
/// <param name="accel_group">
/// the #GtkAccelGroup to add the menu items
///   accelerator to, or %NULL.
/// </param>
/// <return>
/// a new #GtkImageMenuItem.
/// </return>

	public static MentorLake.Gtk.GtkImageMenuItemHandle NewFromStock(string stock_id, MentorLake.Gtk.GtkAccelGroupHandle accel_group)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_new_from_stock(stock_id, accel_group);
	}

/// <summary>
/// <para>
/// Creates a new #GtkImageMenuItem containing a label.
/// </para>
/// </summary>

/// <param name="label">
/// the text of the menu item.
/// </param>
/// <return>
/// a new #GtkImageMenuItem.
/// </return>

	public static MentorLake.Gtk.GtkImageMenuItemHandle NewWithLabel(string label)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_new_with_label(label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkImageMenuItem containing a label. The label
/// will be created using gtk_label_new_with_mnemonic(), so underscores
/// in @label indicate the mnemonic for the menu item.
/// </para>
/// </summary>

/// <param name="label">
/// the text of the menu item, with an underscore in front of the
///         mnemonic character
/// </param>
/// <return>
/// a new #GtkImageMenuItem
/// </return>

	public static MentorLake.Gtk.GtkImageMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_new_with_mnemonic(label);
	}

}

public static class GtkImageMenuItemHandleExtensions
{
/// <summary>
/// <para>
/// Returns whether the menu item will ignore the #GtkSettings:gtk-menu-images
/// setting and always show the image, if available.
/// </para>
/// </summary>

/// <param name="image_menu_item">
/// a #GtkImageMenuItem
/// </param>
/// <return>
/// %TRUE if the menu item will always show the image
/// </return>

	public static bool GetAlwaysShowImage(this MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item)
	{
		if (image_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkImageMenuItemHandle)");
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_get_always_show_image(image_menu_item);
	}

/// <summary>
/// <para>
/// Gets the widget that is currently set as the image of @image_menu_item.
/// See gtk_image_menu_item_set_image().
/// </para>
/// </summary>

/// <param name="image_menu_item">
/// a #GtkImageMenuItem
/// </param>
/// <return>
/// the widget set as image of @image_menu_item
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetImage(this MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item)
	{
		if (image_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkImageMenuItemHandle)");
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_get_image(image_menu_item);
	}

/// <summary>
/// <para>
/// Checks whether the label set in the menuitem is used as a
/// stock id to select the stock item for the item.
/// </para>
/// </summary>

/// <param name="image_menu_item">
/// a #GtkImageMenuItem
/// </param>
/// <return>
/// %TRUE if the label set in the menuitem is used as a
///     stock id to select the stock item for the item
/// </return>

	public static bool GetUseStock(this MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item)
	{
		if (image_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkImageMenuItemHandle)");
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_get_use_stock(image_menu_item);
	}

/// <summary>
/// <para>
/// Specifies an @accel_group to add the menu items accelerator to
/// (this only applies to stock items so a stock item must already
/// be set, make sure to call gtk_image_menu_item_set_use_stock()
/// and gtk_menu_item_set_label() with a valid stock item first).
/// </para>
/// <para>
/// If you want this menu item to have changeable accelerators then
/// you shouldnt need this (see gtk_image_menu_item_new_from_stock()).
/// </para>
/// </summary>

/// <param name="image_menu_item">
/// a #GtkImageMenuItem
/// </param>
/// <param name="accel_group">
/// the #GtkAccelGroup
/// </param>

	public static T SetAccelGroup<T>(this T image_menu_item, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkImageMenuItemHandle
	{
		if (image_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkImageMenuItemHandle)");
		GtkImageMenuItemHandleExterns.gtk_image_menu_item_set_accel_group(image_menu_item, accel_group);
		return image_menu_item;
	}

/// <summary>
/// <para>
/// If %TRUE, the menu item will ignore the #GtkSettings:gtk-menu-images
/// setting and always show the image, if available.
/// </para>
/// <para>
/// Use this property if the menuitem would be useless or hard to use
/// without the image.
/// </para>
/// </summary>

/// <param name="image_menu_item">
/// a #GtkImageMenuItem
/// </param>
/// <param name="always_show">
/// %TRUE if the menuitem should always show the image
/// </param>

	public static T SetAlwaysShowImage<T>(this T image_menu_item, bool always_show) where T : GtkImageMenuItemHandle
	{
		if (image_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkImageMenuItemHandle)");
		GtkImageMenuItemHandleExterns.gtk_image_menu_item_set_always_show_image(image_menu_item, always_show);
		return image_menu_item;
	}

/// <summary>
/// <para>
/// Sets the image of @image_menu_item to the given widget.
/// Note that it depends on the show-menu-images setting whether
/// the image will be displayed or not.
/// </para>
/// </summary>

/// <param name="image_menu_item">
/// a #GtkImageMenuItem.
/// </param>
/// <param name="image">
/// a widget to set as the image for the menu item.
/// </param>

	public static T SetImage<T>(this T image_menu_item, MentorLake.Gtk.GtkWidgetHandle image) where T : GtkImageMenuItemHandle
	{
		if (image_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkImageMenuItemHandle)");
		GtkImageMenuItemHandleExterns.gtk_image_menu_item_set_image(image_menu_item, image);
		return image_menu_item;
	}

/// <summary>
/// <para>
/// If %TRUE, the label set in the menuitem is used as a
/// stock id to select the stock item for the item.
/// </para>
/// </summary>

/// <param name="image_menu_item">
/// a #GtkImageMenuItem
/// </param>
/// <param name="use_stock">
/// %TRUE if the menuitem should use a stock item
/// </param>

	public static T SetUseStock<T>(this T image_menu_item, bool use_stock) where T : GtkImageMenuItemHandle
	{
		if (image_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkImageMenuItemHandle)");
		GtkImageMenuItemHandleExterns.gtk_image_menu_item_set_use_stock(image_menu_item, use_stock);
		return image_menu_item;
	}

}

internal class GtkImageMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkImageMenuItemHandle gtk_image_menu_item_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkImageMenuItemHandle gtk_image_menu_item_new_from_stock(string stock_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkImageMenuItemHandle gtk_image_menu_item_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkImageMenuItemHandle gtk_image_menu_item_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_image_menu_item_get_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_image_menu_item_get_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_image_menu_item_get_use_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_menu_item_set_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_menu_item_set_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item, bool always_show);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_menu_item_set_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_menu_item_set_use_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item, bool use_stock);

}
