namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GMenuItem is an opaque structure type.  You must access it using the
/// functions below.
/// </para>
/// </summary>

public class GMenuItemHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GMenuItem.
/// </para>
/// <para>
/// If @label is non-%NULL it is used to set the &quot;label&quot; attribute of the
/// new item.
/// </para>
/// <para>
/// If @detailed_action is non-%NULL it is used to set the &quot;action&quot; and
/// possibly the &quot;target&quot; attribute of the new item.  See
/// g_menu_item_set_detailed_action() for more information.
/// </para>
/// </summary>

/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="detailed_action">
/// the detailed action string, or %NULL
/// </param>
/// <return>
/// a new #GMenuItem
/// </return>

	public static MentorLake.Gio.GMenuItemHandle New(string label, string detailed_action)
	{
		return GMenuItemHandleExterns.g_menu_item_new(label, detailed_action);
	}

/// <summary>
/// <para>
/// Creates a #GMenuItem as an exact copy of an existing menu item in a
/// #GMenuModel.
/// </para>
/// <para>
/// @item_index must be valid (ie: be sure to call
/// g_menu_model_get_n_items() first).
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <param name="item_index">
/// the index of an item in @model
/// </param>
/// <return>
/// a new #GMenuItem.
/// </return>

	public static MentorLake.Gio.GMenuItemHandle NewFromModel(MentorLake.Gio.GMenuModelHandle model, int item_index)
	{
		return GMenuItemHandleExterns.g_menu_item_new_from_model(model, item_index);
	}

/// <summary>
/// <para>
/// Creates a new #GMenuItem representing a section.
/// </para>
/// <para>
/// This is a convenience API around g_menu_item_new() and
/// g_menu_item_set_section().
/// </para>
/// <para>
/// The effect of having one menu appear as a section of another is
/// exactly as it sounds: the items from @section become a direct part of
/// the menu that @menu_item is added to.
/// </para>
/// <para>
/// Visual separation is typically displayed between two non-empty
/// sections.  If @label is non-%NULL then it will be incorporated into
/// this visual indication.  This allows for labeled subsections of a
/// menu.
/// </para>
/// <para>
/// As a simple example, consider a typical &quot;Edit&quot; menu from a simple
/// program.  It probably contains an &quot;Undo&quot; and &quot;Redo&quot; item, followed by
/// a separator, followed by &quot;Cut&quot;, &quot;Copy&quot; and &quot;Paste&quot;.
/// </para>
/// <para>
/// This would be accomplished by creating three #GMenu instances.  The
/// first would be populated with the &quot;Undo&quot; and &quot;Redo&quot; items, and the
/// second with the &quot;Cut&quot;, &quot;Copy&quot; and &quot;Paste&quot; items.  The first and
/// second menus would then be added as submenus of the third.  In XML
/// format, this would look something like the following:
/// <code>
/// &amp;lt;menu id=&apos;edit-menu&apos;&amp;gt;
/// &amp;lt;menu id=&apos;edit-menu&apos;&amp;gt;
///   &amp;lt;section&amp;gt;
///     &amp;lt;item label=&apos;Undo&apos;/&amp;gt;
///     &amp;lt;item label=&apos;Redo&apos;/&amp;gt;
///   &amp;lt;/section&amp;gt;
///   &amp;lt;section&amp;gt;
///     &amp;lt;item label=&apos;Cut&apos;/&amp;gt;
///     &amp;lt;item label=&apos;Copy&apos;/&amp;gt;
///     &amp;lt;item label=&apos;Paste&apos;/&amp;gt;
///   &amp;lt;/section&amp;gt;
/// &amp;lt;/menu&amp;gt;
/// </code>
/// The following example is exactly equivalent.  It is more illustrative
/// of the exact relationship between the menus and items (keeping in
/// mind that the &apos;link&apos; element defines a new menu that is linked to the
/// containing one).  The style of the second example is more verbose and
/// difficult to read (and therefore not recommended except for the
/// purpose of understanding what is really going on).
/// <code>
/// &amp;lt;menu id=&apos;edit-menu&apos;&amp;gt;
/// &amp;lt;menu id=&apos;edit-menu&apos;&amp;gt;
///   &amp;lt;item&amp;gt;
///     &amp;lt;link name=&apos;section&apos;&amp;gt;
///       &amp;lt;item label=&apos;Undo&apos;/&amp;gt;
///       &amp;lt;item label=&apos;Redo&apos;/&amp;gt;
///     &amp;lt;/link&amp;gt;
///   &amp;lt;/item&amp;gt;
///   &amp;lt;item&amp;gt;
///     &amp;lt;link name=&apos;section&apos;&amp;gt;
///       &amp;lt;item label=&apos;Cut&apos;/&amp;gt;
///       &amp;lt;item label=&apos;Copy&apos;/&amp;gt;
///       &amp;lt;item label=&apos;Paste&apos;/&amp;gt;
///     &amp;lt;/link&amp;gt;
///   &amp;lt;/item&amp;gt;
/// &amp;lt;/menu&amp;gt;
/// </code>
/// </para>
/// </summary>

/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="section">
/// a #GMenuModel with the items of the section
/// </param>
/// <return>
/// a new #GMenuItem
/// </return>

	public static MentorLake.Gio.GMenuItemHandle NewSection(string label, MentorLake.Gio.GMenuModelHandle section)
	{
		return GMenuItemHandleExterns.g_menu_item_new_section(label, section);
	}

/// <summary>
/// <para>
/// Creates a new #GMenuItem representing a submenu.
/// </para>
/// <para>
/// This is a convenience API around g_menu_item_new() and
/// g_menu_item_set_submenu().
/// </para>
/// </summary>

/// <param name="label">
/// the section label, or %NULL
/// </param>
/// <param name="submenu">
/// a #GMenuModel with the items of the submenu
/// </param>
/// <return>
/// a new #GMenuItem
/// </return>

	public static MentorLake.Gio.GMenuItemHandle NewSubmenu(string label, MentorLake.Gio.GMenuModelHandle submenu)
	{
		return GMenuItemHandleExterns.g_menu_item_new_submenu(label, submenu);
	}

}

public static class GMenuItemHandleExtensions
{
/// <summary>
/// <para>
/// Queries the named @attribute on @menu_item.
/// </para>
/// <para>
/// If the attribute exists and matches the #GVariantType corresponding
/// to @format_string then @format_string is used to deconstruct the
/// value into the positional parameters and %TRUE is returned.
/// </para>
/// <para>
/// If the attribute does not exist, or it does exist but has the wrong
/// type, then the positional parameters are ignored and %FALSE is
/// returned.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="attribute">
/// the attribute name to query
/// </param>
/// <param name="format_string">
/// a #GVariant format string
/// </param>
/// <param name="@__arglist">
/// positional parameters, as per @format_string
/// </param>
/// <return>
/// %TRUE if the named attribute was found with the expected
///     type
/// </return>

	public static bool GetAttribute(this MentorLake.Gio.GMenuItemHandle menu_item, string attribute, string format_string, IntPtr @__arglist)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		return GMenuItemHandleExterns.g_menu_item_get_attribute(menu_item, attribute, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Queries the named @attribute on @menu_item.
/// </para>
/// <para>
/// If @expected_type is specified and the attribute does not have this
/// type, %NULL is returned.  %NULL is also returned if the attribute
/// simply does not exist.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="attribute">
/// the attribute name to query
/// </param>
/// <param name="expected_type">
/// the expected type of the attribute
/// </param>
/// <return>
/// the attribute value, or %NULL
/// </return>

	public static MentorLake.GLib.GVariantHandle GetAttributeValue(this MentorLake.Gio.GMenuItemHandle menu_item, string attribute, MentorLake.GLib.GVariantTypeHandle expected_type)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		return GMenuItemHandleExterns.g_menu_item_get_attribute_value(menu_item, attribute, expected_type);
	}

/// <summary>
/// <para>
/// Queries the named @link on @menu_item.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="link">
/// the link name to query
/// </param>
/// <return>
/// the link, or %NULL
/// </return>

	public static MentorLake.Gio.GMenuModelHandle GetLink(this MentorLake.Gio.GMenuItemHandle menu_item, string link)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		return GMenuItemHandleExterns.g_menu_item_get_link(menu_item, link);
	}

/// <summary>
/// <para>
/// Sets or unsets the &quot;action&quot; and &quot;target&quot; attributes of @menu_item.
/// </para>
/// <para>
/// If @action is %NULL then both the &quot;action&quot; and &quot;target&quot; attributes
/// are unset (and @format_string is ignored along with the positional
/// parameters).
/// </para>
/// <para>
/// If @action is non-%NULL then the &quot;action&quot; attribute is set.
/// @format_string is then inspected.  If it is non-%NULL then the proper
/// position parameters are collected to create a #GVariant instance to
/// use as the target value.  If it is %NULL then the positional
/// parameters are ignored and the &quot;target&quot; attribute is unset.
/// </para>
/// <para>
/// See also g_menu_item_set_action_and_target_value() for an equivalent
/// call that directly accepts a #GVariant.  See
/// g_menu_item_set_detailed_action() for a more convenient version that
/// works with string-typed targets.
/// </para>
/// <para>
/// See also g_menu_item_set_action_and_target_value() for a
/// description of the semantics of the action and target attributes.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="action">
/// the name of the action for this item
/// </param>
/// <param name="format_string">
/// a GVariant format string
/// </param>
/// <param name="@__arglist">
/// positional parameters, as per @format_string
/// </param>

	public static T SetActionAndTarget<T>(this T menu_item, string action, string format_string, IntPtr @__arglist) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_action_and_target(menu_item, action, format_string, @__arglist);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets or unsets the &quot;action&quot; and &quot;target&quot; attributes of @menu_item.
/// </para>
/// <para>
/// If @action is %NULL then both the &quot;action&quot; and &quot;target&quot; attributes
/// are unset (and @target_value is ignored).
/// </para>
/// <para>
/// If @action is non-%NULL then the &quot;action&quot; attribute is set.  The
/// &quot;target&quot; attribute is then set to the value of @target_value if it is
/// non-%NULL or unset otherwise.
/// </para>
/// <para>
/// Normal menu items (ie: not submenu, section or other custom item
/// types) are expected to have the &quot;action&quot; attribute set to identify
/// the action that they are associated with.  The state type of the
/// action help to determine the disposition of the menu item.  See
/// #GAction and #GActionGroup for an overview of actions.
/// </para>
/// <para>
/// In general, clicking on the menu item will result in activation of
/// the named action with the &quot;target&quot; attribute given as the parameter
/// to the action invocation.  If the &quot;target&quot; attribute is not set then
/// the action is invoked with no parameter.
/// </para>
/// <para>
/// If the action has no state then the menu item is usually drawn as a
/// plain menu item (ie: with no additional decoration).
/// </para>
/// <para>
/// If the action has a boolean state then the menu item is usually drawn
/// as a toggle menu item (ie: with a checkmark or equivalent
/// indication).  The item should be marked as &apos;toggled&apos; or &apos;checked&apos;
/// when the boolean state is %TRUE.
/// </para>
/// <para>
/// If the action has a string state then the menu item is usually drawn
/// as a radio menu item (ie: with a radio bullet or equivalent
/// indication).  The item should be marked as &apos;selected&apos; when the string
/// state is equal to the value of the @target property.
/// </para>
/// <para>
/// See g_menu_item_set_action_and_target() or
/// g_menu_item_set_detailed_action() for two equivalent calls that are
/// probably more convenient for most uses.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="action">
/// the name of the action for this item
/// </param>
/// <param name="target_value">
/// a #GVariant to use as the action target
/// </param>

	public static T SetActionAndTargetValue<T>(this T menu_item, string action, MentorLake.GLib.GVariantHandle target_value) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_action_and_target_value(menu_item, action, target_value);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets or unsets an attribute on @menu_item.
/// </para>
/// <para>
/// The attribute to set or unset is specified by @attribute. This
/// can be one of the standard attribute names %G_MENU_ATTRIBUTE_LABEL,
/// %G_MENU_ATTRIBUTE_ACTION, %G_MENU_ATTRIBUTE_TARGET, or a custom
/// attribute name.
/// Attribute names are restricted to lowercase characters, numbers
/// and &apos;-&apos;. Furthermore, the names must begin with a lowercase character,
/// must not end with a &apos;-&apos;, and must not contain consecutive dashes.
/// </para>
/// <para>
/// If @format_string is non-%NULL then the proper position parameters
/// are collected to create a #GVariant instance to use as the attribute
/// value.  If it is %NULL then the positional parameterrs are ignored
/// and the named attribute is unset.
/// </para>
/// <para>
/// See also g_menu_item_set_attribute_value() for an equivalent call
/// that directly accepts a #GVariant.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="attribute">
/// the attribute to set
/// </param>
/// <param name="format_string">
/// a #GVariant format string, or %NULL
/// </param>
/// <param name="@__arglist">
/// positional parameters, as per @format_string
/// </param>

	public static T SetAttribute<T>(this T menu_item, string attribute, string format_string, IntPtr @__arglist) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_attribute(menu_item, attribute, format_string, @__arglist);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets or unsets an attribute on @menu_item.
/// </para>
/// <para>
/// The attribute to set or unset is specified by @attribute. This
/// can be one of the standard attribute names %G_MENU_ATTRIBUTE_LABEL,
/// %G_MENU_ATTRIBUTE_ACTION, %G_MENU_ATTRIBUTE_TARGET, or a custom
/// attribute name.
/// Attribute names are restricted to lowercase characters, numbers
/// and &apos;-&apos;. Furthermore, the names must begin with a lowercase character,
/// must not end with a &apos;-&apos;, and must not contain consecutive dashes.
/// </para>
/// <para>
/// must consist only of lowercase
/// ASCII characters, digits and &apos;-&apos;.
/// </para>
/// <para>
/// If @value is non-%NULL then it is used as the new value for the
/// attribute.  If @value is %NULL then the attribute is unset. If
/// the @value #GVariant is floating, it is consumed.
/// </para>
/// <para>
/// See also g_menu_item_set_attribute() for a more convenient way to do
/// the same.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="attribute">
/// the attribute to set
/// </param>
/// <param name="value">
/// a #GVariant to use as the value, or %NULL
/// </param>

	public static T SetAttributeValue<T>(this T menu_item, string attribute, MentorLake.GLib.GVariantHandle value) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_attribute_value(menu_item, attribute, value);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets the &quot;action&quot; and possibly the &quot;target&quot; attribute of @menu_item.
/// </para>
/// <para>
/// The format of @detailed_action is the same format parsed by
/// g_action_parse_detailed_name().
/// </para>
/// <para>
/// See g_menu_item_set_action_and_target() or
/// g_menu_item_set_action_and_target_value() for more flexible (but
/// slightly less convenient) alternatives.
/// </para>
/// <para>
/// See also g_menu_item_set_action_and_target_value() for a description of
/// the semantics of the action and target attributes.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="detailed_action">
/// the &quot;detailed&quot; action string
/// </param>

	public static T SetDetailedAction<T>(this T menu_item, string detailed_action) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_detailed_action(menu_item, detailed_action);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets (or unsets) the icon on @menu_item.
/// </para>
/// <para>
/// This call is the same as calling g_icon_serialize() and using the
/// result as the value to g_menu_item_set_attribute_value() for
/// %G_MENU_ATTRIBUTE_ICON.
/// </para>
/// <para>
/// This API is only intended for use with &quot;noun&quot; menu items; things like
/// bookmarks or applications in an &quot;Open With&quot; menu.  Don&apos;t use it on
/// menu items corresponding to verbs (eg: stock icons for &apos;Save&apos; or
/// &apos;Quit&apos;).
/// </para>
/// <para>
/// If @icon is %NULL then the icon is unset.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="icon">
/// a #GIcon, or %NULL
/// </param>

	public static T SetIcon<T>(this T menu_item, MentorLake.Gio.GIconHandle icon) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_icon(menu_item, icon);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets or unsets the &quot;label&quot; attribute of @menu_item.
/// </para>
/// <para>
/// If @label is non-%NULL it is used as the label for the menu item.  If
/// it is %NULL then the label attribute is unset.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="label">
/// the label to set, or %NULL to unset
/// </param>

	public static T SetLabel<T>(this T menu_item, string label) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_label(menu_item, label);
		return menu_item;
	}

/// <summary>
/// <para>
/// Creates a link from @menu_item to @model if non-%NULL, or unsets it.
/// </para>
/// <para>
/// Links are used to establish a relationship between a particular menu
/// item and another menu.  For example, %G_MENU_LINK_SUBMENU is used to
/// associate a submenu with a particular menu item, and %G_MENU_LINK_SECTION
/// is used to create a section. Other types of link can be used, but there
/// is no guarantee that clients will be able to make sense of them.
/// Link types are restricted to lowercase characters, numbers
/// and &apos;-&apos;. Furthermore, the names must begin with a lowercase character,
/// must not end with a &apos;-&apos;, and must not contain consecutive dashes.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="link">
/// type of link to establish or unset
/// </param>
/// <param name="model">
/// the #GMenuModel to link to (or %NULL to unset)
/// </param>

	public static T SetLink<T>(this T menu_item, string link, MentorLake.Gio.GMenuModelHandle model) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_link(menu_item, link, model);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets or unsets the &quot;section&quot; link of @menu_item to @section.
/// </para>
/// <para>
/// The effect of having one menu appear as a section of another is
/// exactly as it sounds: the items from @section become a direct part of
/// the menu that @menu_item is added to.  See g_menu_item_new_section()
/// for more information about what it means for a menu item to be a
/// section.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="section">
/// a #GMenuModel, or %NULL
/// </param>

	public static T SetSection<T>(this T menu_item, MentorLake.Gio.GMenuModelHandle section) where T : GMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GMenuItemHandle)");
		GMenuItemHandleExterns.g_menu_item_set_section(menu_item, section);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets or unsets the &quot;submenu&quot; link of @menu_item to @submenu.
/// </para>
/// <para>
/// If @submenu is non-%NULL, it is linked to.  If it is %NULL then the
/// link is unset.
/// </para>
/// <para>
/// The effect of having one menu appear as a submenu of another is
/// exactly as it sounds.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GMenuItem
/// </param>
/// <param name="submenu">
/// a #GMenuModel, or %NULL
/// </param>

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
