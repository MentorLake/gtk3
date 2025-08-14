namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkMenuButton widget is used to display a popup when clicked on.
/// This popup can be provided either as a #GtkMenu, a #GtkPopover or an
/// abstract #GMenuModel.
/// </para>
/// <para>
/// The #GtkMenuButton widget can hold any valid child widget. That is, it
/// can hold almost any other standard #GtkWidget. The most commonly used
/// child is #GtkImage. If no widget is explicitely added to the #GtkMenuButton,
/// a #GtkImage is automatically created, using an arrow image oriented
/// according to #GtkMenuButton:direction or the generic “open-menu-symbolic”
/// icon if the direction is not set.
/// </para>
/// <para>
/// The positioning of the popup is determined by the #GtkMenuButton:direction
/// property of the menu button.
/// </para>
/// <para>
/// For menus, the #GtkWidget:halign and #GtkWidget:valign properties of the
/// menu are also taken into account. For example, when the direction is
/// %GTK_ARROW_DOWN and the horizontal alignment is %GTK_ALIGN_START, the
/// menu will be positioned below the button, with the starting edge
/// (depending on the text direction) of the menu aligned with the starting
/// edge of the button. If there is not enough space below the button, the
/// menu is popped up above the button instead. If the alignment would move
/// part of the menu offscreen, it is “pushed in”.
/// </para>
/// <para>
/// ## Direction = Down
/// </para>
/// <para>
/// - halign = start
/// </para>
/// <para>
///     ![](down-start.png)
/// </para>
/// <para>
/// - halign = center
/// </para>
/// <para>
///     ![](down-center.png)
/// </para>
/// <para>
/// - halign = end
/// </para>
/// <para>
///     ![](down-end.png)
/// </para>
/// <para>
/// ## Direction = Up
/// </para>
/// <para>
/// - halign = start
/// </para>
/// <para>
///     ![](up-start.png)
/// </para>
/// <para>
/// - halign = center
/// </para>
/// <para>
///     ![](up-center.png)
/// </para>
/// <para>
/// - halign = end
/// </para>
/// <para>
///     ![](up-end.png)
/// </para>
/// <para>
/// ## Direction = Left
/// </para>
/// <para>
/// - valign = start
/// </para>
/// <para>
///     ![](left-start.png)
/// </para>
/// <para>
/// - valign = center
/// </para>
/// <para>
///     ![](left-center.png)
/// </para>
/// <para>
/// - valign = end
/// </para>
/// <para>
///     ![](left-end.png)
/// </para>
/// <para>
/// ## Direction = Right
/// </para>
/// <para>
/// - valign = start
/// </para>
/// <para>
///     ![](right-start.png)
/// </para>
/// <para>
/// - valign = center
/// </para>
/// <para>
///     ![](right-center.png)
/// </para>
/// <para>
/// - valign = end
/// </para>
/// <para>
///     ![](right-end.png)
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkMenuButton has a single CSS node with name button. To differentiate
/// it from a plain #GtkButton, it gets the .popup style class.
/// </para>
/// </summary>

public class GtkMenuButtonHandle : GtkToggleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkMenuButton widget with downwards-pointing
/// arrow as the only child. You can replace the child widget
/// with another #GtkWidget should you wish to.
/// </para>
/// </summary>

/// <return>
/// The newly created #GtkMenuButton widget
/// </return>

	public static MentorLake.Gtk.GtkMenuButtonHandle New()
	{
		return GtkMenuButtonHandleExterns.gtk_menu_button_new();
	}

}

public static class GtkMenuButtonHandleExtensions
{
/// <summary>
/// <para>
/// Returns the parent #GtkWidget to use to line up with menu.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <return>
/// a #GtkWidget value or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetAlignWidget(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_align_widget(menu_button);
	}

/// <summary>
/// <para>
/// Returns the direction the popup will be pointing at when popped up.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <return>
/// a #GtkArrowType value
/// </return>

	public static MentorLake.Gtk.GtkArrowType GetDirection(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_direction(menu_button);
	}

/// <summary>
/// <para>
/// Returns the #GMenuModel used to generate the popup.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <return>
/// a #GMenuModel or %NULL
/// </return>

	public static MentorLake.Gio.GMenuModelHandle GetMenuModel(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_menu_model(menu_button);
	}

/// <summary>
/// <para>
/// Returns the #GtkPopover that pops out of the button.
/// If the button is not using a #GtkPopover, this function
/// returns %NULL.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <return>
/// a #GtkPopover or %NULL
/// </return>

	public static MentorLake.Gtk.GtkPopoverHandle GetPopover(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_popover(menu_button);
	}

/// <summary>
/// <para>
/// Returns the #GtkMenu that pops out of the button.
/// If the button does not use a #GtkMenu, this function
/// returns %NULL.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <return>
/// a #GtkMenu or %NULL
/// </return>

	public static MentorLake.Gtk.GtkMenuHandle GetPopup(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_popup(menu_button);
	}

/// <summary>
/// <para>
/// Returns whether a #GtkPopover or a #GtkMenu will be constructed
/// from the menu model.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <return>
/// %TRUE if using a #GtkPopover
/// </return>

	public static bool GetUsePopover(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_use_popover(menu_button);
	}

/// <summary>
/// <para>
/// Sets the #GtkWidget to use to line the menu with when popped up.
/// Note that the @align_widget must contain the #GtkMenuButton itself.
/// </para>
/// <para>
/// Setting it to %NULL means that the menu will be aligned with the
/// button itself.
/// </para>
/// <para>
/// Note that this property is only used with menus currently,
/// and not for popovers.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <param name="align_widget">
/// a #GtkWidget
/// </param>

	public static T SetAlignWidget<T>(this T menu_button, MentorLake.Gtk.GtkWidgetHandle align_widget) where T : GtkMenuButtonHandle
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		GtkMenuButtonHandleExterns.gtk_menu_button_set_align_widget(menu_button, align_widget);
		return menu_button;
	}

/// <summary>
/// <para>
/// Sets the direction in which the popup will be popped up, as
/// well as changing the arrow’s direction. The child will not
/// be changed to an arrow if it was customized.
/// </para>
/// <para>
/// If the does not fit in the available space in the given direction,
/// GTK+ will its best to keep it inside the screen and fully visible.
/// </para>
/// <para>
/// If you pass %GTK_ARROW_NONE for a @direction, the popup will behave
/// as if you passed %GTK_ARROW_DOWN (although you won’t see any arrows).
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <param name="direction">
/// a #GtkArrowType
/// </param>

	public static T SetDirection<T>(this T menu_button, MentorLake.Gtk.GtkArrowType direction) where T : GtkMenuButtonHandle
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		GtkMenuButtonHandleExterns.gtk_menu_button_set_direction(menu_button, direction);
		return menu_button;
	}

/// <summary>
/// <para>
/// Sets the #GMenuModel from which the popup will be constructed,
/// or %NULL to dissociate any existing menu model and disable the button.
/// </para>
/// <para>
/// Depending on the value of #GtkMenuButton:use-popover, either a
/// #GtkMenu will be created with gtk_menu_new_from_model(), or a
/// #GtkPopover with gtk_popover_new_from_model(). In either case,
/// actions will be connected as documented for these functions.
/// </para>
/// <para>
/// If #GtkMenuButton:popup or #GtkMenuButton:popover are already set, those
/// widgets are dissociated from the @menu_button, and those properties are set
/// to %NULL.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <param name="menu_model">
/// a #GMenuModel, or %NULL to unset and disable the
///   button
/// </param>

	public static T SetMenuModel<T>(this T menu_button, MentorLake.Gio.GMenuModelHandle menu_model) where T : GtkMenuButtonHandle
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		GtkMenuButtonHandleExterns.gtk_menu_button_set_menu_model(menu_button, menu_model);
		return menu_button;
	}

/// <summary>
/// <para>
/// Sets the #GtkPopover that will be popped up when the @menu_button is clicked,
/// or %NULL to dissociate any existing popover and disable the button.
/// </para>
/// <para>
/// If #GtkMenuButton:menu-model or #GtkMenuButton:popup are set, those objects
/// are dissociated from the @menu_button, and those properties are set to %NULL.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <param name="popover">
/// a #GtkPopover, or %NULL to unset and disable the button
/// </param>

	public static T SetPopover<T>(this T menu_button, MentorLake.Gtk.GtkWidgetHandle popover) where T : GtkMenuButtonHandle
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		GtkMenuButtonHandleExterns.gtk_menu_button_set_popover(menu_button, popover);
		return menu_button;
	}

/// <summary>
/// <para>
/// Sets the #GtkMenu that will be popped up when the @menu_button is clicked, or
/// %NULL to dissociate any existing menu and disable the button.
/// </para>
/// <para>
/// If #GtkMenuButton:menu-model or #GtkMenuButton:popover are set, those objects
/// are dissociated from the @menu_button, and those properties are set to %NULL.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <param name="menu">
/// a #GtkMenu, or %NULL to unset and disable the button
/// </param>

	public static T SetPopup<T>(this T menu_button, MentorLake.Gtk.GtkWidgetHandle menu) where T : GtkMenuButtonHandle
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		GtkMenuButtonHandleExterns.gtk_menu_button_set_popup(menu_button, menu);
		return menu_button;
	}

/// <summary>
/// <para>
/// Sets whether to construct a #GtkPopover instead of #GtkMenu
/// when gtk_menu_button_set_menu_model() is called. Note that
/// this property is only consulted when a new menu model is set.
/// </para>
/// </summary>

/// <param name="menu_button">
/// a #GtkMenuButton
/// </param>
/// <param name="use_popover">
/// %TRUE to construct a popover from the menu model
/// </param>

	public static T SetUsePopover<T>(this T menu_button, bool use_popover) where T : GtkMenuButtonHandle
	{
		if (menu_button.IsInvalid) throw new Exception("Invalid handle (GtkMenuButtonHandle)");
		GtkMenuButtonHandleExterns.gtk_menu_button_set_use_popover(menu_button, use_popover);
		return menu_button;
	}

}

internal class GtkMenuButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuButtonHandle gtk_menu_button_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_button_get_align_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkArrowType gtk_menu_button_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle gtk_menu_button_get_menu_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))]
	internal static extern MentorLake.Gtk.GtkPopoverHandle gtk_menu_button_get_popover([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuHandle gtk_menu_button_get_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_button_get_use_popover([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_align_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle align_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, MentorLake.Gtk.GtkArrowType direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_menu_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle menu_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_popover([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_use_popover([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, bool use_popover);

}
