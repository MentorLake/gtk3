namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkMenu is a #GtkMenuShell that implements a drop down menu
/// consisting of a list of #GtkMenuItem objects which can be navigated
/// and activated by the user to perform application functions.
/// </para>
/// <para>
/// A #GtkMenu is most commonly dropped down by activating a
/// #GtkMenuItem in a #GtkMenuBar or popped up by activating a
/// #GtkMenuItem in another #GtkMenu.
/// </para>
/// <para>
/// A #GtkMenu can also be popped up by activating a #GtkComboBox.
/// Other composite widgets such as the #GtkNotebook can pop up a
/// #GtkMenu as well.
/// </para>
/// <para>
/// Applications can display a #GtkMenu as a popup menu by calling the
/// gtk_menu_popup() function.  The example below shows how an application
/// can pop up a menu when the 3rd mouse button is pressed.
/// </para>
/// <para>
/// ## Connecting the popup signal handler.
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   // connect our handler which will popup the menu
///   g_signal_connect_swapped (window, "button_press_event",
/// G_CALLBACK (my_popup_handler), menu);
/// ]|
/// </para>
/// <para>
/// ## Signal handler which displays a popup menu.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static gint
/// my_popup_handler (GtkWidget *widget, GdkEvent *event)
/// {
///   GtkMenu *menu;
///   GdkEventButton *event_button;
/// </para>
/// <para>
///   g_return_val_if_fail (widget != NULL, FALSE);
///   g_return_val_if_fail (GTK_IS_MENU (widget), FALSE);
///   g_return_val_if_fail (event != NULL, FALSE);
/// </para>
/// <para>
///   // The "widget" is the menu that was supplied when
///   // g_signal_connect_swapped() was called.
///   menu = GTK_MENU (widget);
/// </para>
/// <para>
///   if (event->type == GDK_BUTTON_PRESS)
///     {
///       event_button = (GdkEventButton *) event;
///       if (event_button->button == GDK_BUTTON_SECONDARY)
///         {
///           gtk_menu_popup (menu, NULL, NULL, NULL, NULL,
///                           event_button->button, event_button->time);
///           return TRUE;
///         }
///     }
/// </para>
/// <para>
///   return FALSE;
/// }
/// ]|
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// menu
/// ├── arrow.top
/// ├── <child>
/// ┊
/// ├── <child>
/// ╰── arrow.bottom
/// ]|
/// </para>
/// <para>
/// The main CSS node of GtkMenu has name menu, and there are two subnodes
/// with name arrow, for scrolling menu arrows. These subnodes get the
/// .top and .bottom style classes.
/// </para>
/// </summary>

public class GtkMenuHandle : GtkMenuShellHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkMenu
/// </para>
/// </summary>

/// <return>
/// a new #GtkMenu
/// </return>

	public static MentorLake.Gtk.GtkMenuHandle New()
	{
		return GtkMenuHandleExterns.gtk_menu_new();
	}

/// <summary>
/// <para>
/// Creates a #GtkMenu and populates it with menu items and
/// submenus according to @model.
/// </para>
/// <para>
/// The created menu items are connected to actions found in the
/// #GtkApplicationWindow to which the menu belongs - typically
/// by means of being attached to a widget (see gtk_menu_attach_to_widget())
/// that is contained within the #GtkApplicationWindows widget hierarchy.
/// </para>
/// <para>
/// Actions can also be added using gtk_widget_insert_action_group() on the menu's
/// attach widget or on any of its parent widgets.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <return>
/// a new #GtkMenu
/// </return>

	public static MentorLake.Gtk.GtkMenuHandle NewFromModel(MentorLake.Gio.GMenuModelHandle model)
	{
		return GtkMenuHandleExterns.gtk_menu_new_from_model(model);
	}

/// <summary>
/// <para>
/// Returns a list of the menus which are attached to this widget.
/// This list is owned by GTK+ and must not be modified.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the list
///     of menus attached to his widget.
/// </return>

	public static MentorLake.GLib.GListHandle GetForAttachWidget(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkMenuHandleExterns.gtk_menu_get_for_attach_widget(widget);
	}

}
public static class GtkMenuHandleSignalExtensions
{

	public static IObservable<GtkMenuHandleSignalStructs.MoveScrollSignal> Signal_MoveScroll(this GtkMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuHandleSignalStructs.MoveScrollSignal> obs) =>
		{
			GtkMenuHandleSignalDelegates.move_scroll handler = ( MentorLake.Gtk.GtkMenuHandle self,  MentorLake.Gtk.GtkScrollType scroll_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuHandleSignalStructs.MoveScrollSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-scroll", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Emitted when the position of @menu is finalized after being popped up
/// using gtk_menu_popup_at_rect (), gtk_menu_popup_at_widget (), or
/// gtk_menu_popup_at_pointer ().
/// </para>
/// <para>
/// @menu might be flipped over the anchor rectangle in order to keep it
/// on-screen, in which case @flipped_x and @flipped_y will be set to %TRUE
/// accordingly.
/// </para>
/// <para>
/// @flipped_rect is the ideal position of @menu after any possible flipping,
/// but before any possible sliding. @final_rect is @flipped_rect, but possibly
/// translated in the case that flipping is still ineffective in keeping @menu
/// on-screen.
/// </para>
/// <para>
/// ![](popup-slide.png)
/// </para>
/// <para>
/// The blue menu is @menu's ideal position, the green menu is @flipped_rect,
/// and the red menu is @final_rect.
/// </para>
/// <para>
/// See gtk_menu_popup_at_rect (), gtk_menu_popup_at_widget (),
/// gtk_menu_popup_at_pointer (), #GtkMenu:anchor-hints,
/// #GtkMenu:rect-anchor-dx, #GtkMenu:rect-anchor-dy, and
/// #GtkMenu:menu-type-hint.
/// </para>
/// </summary>

	public static IObservable<GtkMenuHandleSignalStructs.PoppedUpSignal> Signal_PoppedUp(this GtkMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuHandleSignalStructs.PoppedUpSignal> obs) =>
		{
			GtkMenuHandleSignalDelegates.popped_up handler = ( MentorLake.Gtk.GtkMenuHandle self,  IntPtr flipped_rect,  IntPtr final_rect,  bool flipped_x,  bool flipped_y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuHandleSignalStructs.PoppedUpSignal()
				{
					Self = self, FlippedRect = flipped_rect, FinalRect = final_rect, FlippedX = flipped_x, FlippedY = flipped_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popped-up", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkMenuHandleSignalStructs
{

public class MoveScrollSignal
{

	public MentorLake.Gtk.GtkMenuHandle Self;
/// <summary>
/// <para>
/// a #GtkScrollType
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkScrollType ScrollType;

	public IntPtr UserData;
}

public class PoppedUpSignal
{

	public MentorLake.Gtk.GtkMenuHandle Self;
/// <summary>
/// <para>
/// the position of @menu after any possible
///                flipping or %NULL if the backend can't obtain it
/// </para>
/// </summary>

	public IntPtr FlippedRect;
/// <summary>
/// <para>
/// the final position of @menu or %NULL if the
///              backend can't obtain it
/// </para>
/// </summary>

	public IntPtr FinalRect;
/// <summary>
/// <para>
/// %TRUE if the anchors were flipped horizontally
/// </para>
/// </summary>

	public bool FlippedX;
/// <summary>
/// <para>
/// %TRUE if the anchors were flipped vertically
/// </para>
/// </summary>

	public bool FlippedY;

	public IntPtr UserData;
}
}

public static class GtkMenuHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="scroll_type">
/// a #GtkScrollType
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle self, MentorLake.Gtk.GtkScrollType scroll_type, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the position of @menu is finalized after being popped up
/// using gtk_menu_popup_at_rect (), gtk_menu_popup_at_widget (), or
/// gtk_menu_popup_at_pointer ().
/// </para>
/// <para>
/// @menu might be flipped over the anchor rectangle in order to keep it
/// on-screen, in which case @flipped_x and @flipped_y will be set to %TRUE
/// accordingly.
/// </para>
/// <para>
/// @flipped_rect is the ideal position of @menu after any possible flipping,
/// but before any possible sliding. @final_rect is @flipped_rect, but possibly
/// translated in the case that flipping is still ineffective in keeping @menu
/// on-screen.
/// </para>
/// <para>
/// ![](popup-slide.png)
/// </para>
/// <para>
/// The blue menu is @menu's ideal position, the green menu is @flipped_rect,
/// and the red menu is @final_rect.
/// </para>
/// <para>
/// See gtk_menu_popup_at_rect (), gtk_menu_popup_at_widget (),
/// gtk_menu_popup_at_pointer (), #GtkMenu:anchor-hints,
/// #GtkMenu:rect-anchor-dx, #GtkMenu:rect-anchor-dy, and
/// #GtkMenu:menu-type-hint.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="flipped_rect">
/// the position of @menu after any possible
///                flipping or %NULL if the backend can't obtain it
/// </param>
/// <param name="final_rect">
/// the final position of @menu or %NULL if the
///              backend can't obtain it
/// </param>
/// <param name="flipped_x">
/// %TRUE if the anchors were flipped horizontally
/// </param>
/// <param name="flipped_y">
/// %TRUE if the anchors were flipped vertically
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popped_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle self, IntPtr flipped_rect, IntPtr final_rect, bool flipped_x, bool flipped_y, IntPtr user_data);

}


public static class GtkMenuHandleExtensions
{
/// <summary>
/// <para>
/// Adds a new #GtkMenuItem to a (table) menu. The number of “cells” that
/// an item will occupy is specified by @left_attach, @right_attach,
/// @top_attach and @bottom_attach. These each represent the leftmost,
/// rightmost, uppermost and lower column and row numbers of the table.
/// (Columns and rows are indexed from zero).
/// </para>
/// <para>
/// Note that this function is not related to gtk_menu_detach().
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="child">
/// a #GtkMenuItem
/// </param>
/// <param name="left_attach">
/// The column number to attach the left side of the item to
/// </param>
/// <param name="right_attach">
/// The column number to attach the right side of the item to
/// </param>
/// <param name="top_attach">
/// The row number to attach the top of the item to
/// </param>
/// <param name="bottom_attach">
/// The row number to attach the bottom of the item to
/// </param>

	public static T Attach<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_attach(menu, child, left_attach, right_attach, top_attach, bottom_attach);
		return menu;
	}

/// <summary>
/// <para>
/// Attaches the menu to the widget and provides a callback function
/// that will be invoked when the menu calls gtk_menu_detach() during
/// its destruction.
/// </para>
/// <para>
/// If the menu is attached to the widget then it will be destroyed
/// when the widget is destroyed, as if it was a child widget.
/// An attached menu will also move between screens correctly if the
/// widgets moves between screens.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="attach_widget">
/// the #GtkWidget that the menu will be attached to
/// </param>
/// <param name="detacher">
/// the user supplied callback function
///             that will be called when the menu calls gtk_menu_detach()
/// </param>

	public static T AttachToWidget<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle attach_widget, MentorLake.Gtk.GtkMenuDetachFunc detacher) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_attach_to_widget(menu, attach_widget, detacher);
		return menu;
	}

/// <summary>
/// <para>
/// Detaches the menu from the widget to which it had been attached.
/// This function will call the callback function, @detacher, provided
/// when the gtk_menu_attach_to_widget() function was called.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>

	public static T Detach<T>(this T menu) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_detach(menu);
		return menu;
	}

/// <summary>
/// <para>
/// Gets the #GtkAccelGroup which holds global accelerators for the
/// menu. See gtk_menu_set_accel_group().
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <return>
/// the #GtkAccelGroup associated with the menu
/// </return>

	public static MentorLake.Gtk.GtkAccelGroupHandle GetAccelGroup(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_accel_group(menu);
	}

/// <summary>
/// <para>
/// Retrieves the accelerator path set on the menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a valid #GtkMenu
/// </param>
/// <return>
/// the accelerator path set on the menu.
/// </return>

	public static string GetAccelPath(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_accel_path(menu);
	}

/// <summary>
/// <para>
/// Returns the selected menu item from the menu.  This is used by the
/// #GtkComboBox.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <return>
/// the #GtkMenuItem that was last selected
///          in the menu.  If a selection has not yet been made, the
///          first menu item is selected.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetActive(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_active(menu);
	}

/// <summary>
/// <para>
/// Returns the #GtkWidget that the menu is attached to.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <return>
/// the #GtkWidget that the menu is attached to
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetAttachWidget(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_attach_widget(menu);
	}

/// <summary>
/// <para>
/// Retrieves the number of the monitor on which to show the menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <return>
/// the number of the monitor on which the menu should
///    be popped up or -1, if no monitor has been set
/// </return>

	public static int GetMonitor(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_monitor(menu);
	}

/// <summary>
/// <para>
/// Returns whether the menu reserves space for toggles and
/// icons, regardless of their actual presence.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <return>
/// Whether the menu reserves toggle space
/// </return>

	public static bool GetReserveToggleSize(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_reserve_toggle_size(menu);
	}

/// <summary>
/// <para>
/// Returns whether the menu is torn off.
/// See gtk_menu_set_tearoff_state().
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <return>
/// %TRUE if the menu is currently torn off.
/// </return>

	public static bool GetTearoffState(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_tearoff_state(menu);
	}

/// <summary>
/// <para>
/// Returns the title of the menu. See gtk_menu_set_title().
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <return>
/// the title of the menu, or %NULL if the menu
///     has no title set on it. This string is owned by GTK+
///     and should not be modified or freed.
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_title(menu);
	}

/// <summary>
/// <para>
/// Places @menu on the given monitor.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="monitor">
/// the monitor to place the menu on
/// </param>

	public static T PlaceOnMonitor<T>(this T menu, MentorLake.Gdk.GdkMonitorHandle monitor) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_place_on_monitor(menu, monitor);
		return menu;
	}

/// <summary>
/// <para>
/// Removes the menu from the screen.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>

	public static T Popdown<T>(this T menu) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popdown(menu);
		return menu;
	}

/// <summary>
/// <para>
/// Displays a menu and makes it available for selection.
/// </para>
/// <para>
/// Applications can use this function to display context-sensitive
/// menus, and will typically supply %NULL for the @parent_menu_shell,
/// @parent_menu_item, @func and @data parameters. The default menu
/// positioning function will position the menu at the current mouse
/// cursor position.
/// </para>
/// <para>
/// The @button parameter should be the mouse button pressed to initiate
/// the menu popup. If the menu popup was initiated by something other
/// than a mouse button press, such as a mouse button release or a keypress,
/// @button should be 0.
/// </para>
/// <para>
/// The @activate_time parameter is used to conflict-resolve initiation
/// of concurrent requests for mouse/keyboard grab requests. To function
/// properly, this needs to be the timestamp of the user event (such as
/// a mouse click or key press) that caused the initiation of the popup.
/// Only if no such event is available, gtk_get_current_event_time() can
/// be used instead.
/// </para>
/// <para>
/// Note that this function does not work very well on GDK backends that
/// do not have global coordinates, such as Wayland or Mir. You should
/// probably use one of the gtk_menu_popup_at_ variants, which do not
/// have this problem.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="parent_menu_shell">
/// the menu shell containing the
///     triggering menu item, or %NULL
/// </param>
/// <param name="parent_menu_item">
/// the menu item whose activation
///     triggered the popup, or %NULL
/// </param>
/// <param name="func">
/// a user supplied function used to position
///     the menu, or %NULL
/// </param>
/// <param name="data">
/// user supplied data to be passed to @func.
/// </param>
/// <param name="button">
/// the mouse button which was pressed to initiate the event.
/// </param>
/// <param name="activate_time">
/// the time at which the activation event occurred.
/// </param>

	public static T Popup<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle parent_menu_shell, MentorLake.Gtk.GtkWidgetHandle parent_menu_item, MentorLake.Gtk.GtkMenuPositionFunc func, IntPtr data, uint button, uint activate_time) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup(menu, parent_menu_shell, parent_menu_item, func, data, button, activate_time);
		return menu;
	}

/// <summary>
/// <para>
/// Displays @menu and makes it available for selection.
/// </para>
/// <para>
/// See gtk_menu_popup_at_widget () to pop up a menu at a widget.
/// gtk_menu_popup_at_rect () also allows you to position a menu at an arbitrary
/// rectangle.
/// </para>
/// <para>
/// @menu will be positioned at the pointer associated with @trigger_event.
/// </para>
/// <para>
/// Properties that influence the behaviour of this function are
/// #GtkMenu:anchor-hints, #GtkMenu:rect-anchor-dx, #GtkMenu:rect-anchor-dy, and
/// #GtkMenu:menu-type-hint. Connect to the #GtkMenu::popped-up signal to find
/// out how it was actually positioned.
/// </para>
/// </summary>

/// <param name="menu">
/// the #GtkMenu to pop up
/// </param>
/// <param name="trigger_event">
/// the #GdkEvent that initiated this request or
///                 %NULL if it's the current event
/// </param>

	public static T PopupAtPointer<T>(this T menu, MentorLake.Gdk.GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup_at_pointer(menu, trigger_event);
		return menu;
	}

/// <summary>
/// <para>
/// Displays @menu and makes it available for selection.
/// </para>
/// <para>
/// See gtk_menu_popup_at_widget () and gtk_menu_popup_at_pointer (), which
/// handle more common cases for popping up menus.
/// </para>
/// <para>
/// @menu will be positioned at @rect, aligning their anchor points. @rect is
/// relative to the top-left corner of @rect_window. @rect_anchor and
/// @menu_anchor determine anchor points on @rect and @menu to pin together.
/// @menu can optionally be offset by #GtkMenu:rect-anchor-dx and
/// #GtkMenu:rect-anchor-dy.
/// </para>
/// <para>
/// Anchors should be specified under the assumption that the text direction is
/// left-to-right; they will be flipped horizontally automatically if the text
/// direction is right-to-left.
/// </para>
/// <para>
/// Other properties that influence the behaviour of this function are
/// #GtkMenu:anchor-hints and #GtkMenu:menu-type-hint. Connect to the
/// #GtkMenu::popped-up signal to find out how it was actually positioned.
/// </para>
/// </summary>

/// <param name="menu">
/// the #GtkMenu to pop up
/// </param>
/// <param name="rect_window">
/// the #GdkWindow @rect is relative to
/// </param>
/// <param name="rect">
/// the #GdkRectangle to align @menu with
/// </param>
/// <param name="rect_anchor">
/// the point on @rect to align with @menu's anchor point
/// </param>
/// <param name="menu_anchor">
/// the point on @menu to align with @rect's anchor point
/// </param>
/// <param name="trigger_event">
/// the #GdkEvent that initiated this request or
///                 %NULL if it's the current event
/// </param>

	public static T PopupAtRect<T>(this T menu, MentorLake.Gdk.GdkWindowHandle rect_window, MentorLake.Gdk.GdkRectangleHandle rect, MentorLake.Gdk.GdkGravity rect_anchor, MentorLake.Gdk.GdkGravity menu_anchor, MentorLake.Gdk.GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup_at_rect(menu, rect_window, rect, rect_anchor, menu_anchor, trigger_event);
		return menu;
	}

/// <summary>
/// <para>
/// Displays @menu and makes it available for selection.
/// </para>
/// <para>
/// See gtk_menu_popup_at_pointer () to pop up a menu at the master pointer.
/// gtk_menu_popup_at_rect () also allows you to position a menu at an arbitrary
/// rectangle.
/// </para>
/// <para>
/// ![](popup-anchors.png)
/// </para>
/// <para>
/// @menu will be positioned at @widget, aligning their anchor points.
/// @widget_anchor and @menu_anchor determine anchor points on @widget and @menu
/// to pin together. @menu can optionally be offset by #GtkMenu:rect-anchor-dx
/// and #GtkMenu:rect-anchor-dy.
/// </para>
/// <para>
/// Anchors should be specified under the assumption that the text direction is
/// left-to-right; they will be flipped horizontally automatically if the text
/// direction is right-to-left.
/// </para>
/// <para>
/// Other properties that influence the behaviour of this function are
/// #GtkMenu:anchor-hints and #GtkMenu:menu-type-hint. Connect to the
/// #GtkMenu::popped-up signal to find out how it was actually positioned.
/// </para>
/// </summary>

/// <param name="menu">
/// the #GtkMenu to pop up
/// </param>
/// <param name="widget">
/// the #GtkWidget to align @menu with
/// </param>
/// <param name="widget_anchor">
/// the point on @widget to align with @menu's anchor point
/// </param>
/// <param name="menu_anchor">
/// the point on @menu to align with @widget's anchor point
/// </param>
/// <param name="trigger_event">
/// the #GdkEvent that initiated this request or
///                 %NULL if it's the current event
/// </param>

	public static T PopupAtWidget<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkGravity widget_anchor, MentorLake.Gdk.GdkGravity menu_anchor, MentorLake.Gdk.GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup_at_widget(menu, widget, widget_anchor, menu_anchor, trigger_event);
		return menu;
	}

/// <summary>
/// <para>
/// Displays a menu and makes it available for selection.
/// </para>
/// <para>
/// Applications can use this function to display context-sensitive menus,
/// and will typically supply %NULL for the @parent_menu_shell,
/// @parent_menu_item, @func, @data and @destroy parameters. The default
/// menu positioning function will position the menu at the current position
/// of @device (or its corresponding pointer).
/// </para>
/// <para>
/// The @button parameter should be the mouse button pressed to initiate
/// the menu popup. If the menu popup was initiated by something other than
/// a mouse button press, such as a mouse button release or a keypress,
/// @button should be 0.
/// </para>
/// <para>
/// The @activate_time parameter is used to conflict-resolve initiation of
/// concurrent requests for mouse/keyboard grab requests. To function
/// properly, this needs to be the time stamp of the user event (such as
/// a mouse click or key press) that caused the initiation of the popup.
/// Only if no such event is available, gtk_get_current_event_time() can
/// be used instead.
/// </para>
/// <para>
/// Note that this function does not work very well on GDK backends that
/// do not have global coordinates, such as Wayland or Mir. You should
/// probably use one of the gtk_menu_popup_at_ variants, which do not
/// have this problem.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <param name="parent_menu_shell">
/// the menu shell containing the triggering
///     menu item, or %NULL
/// </param>
/// <param name="parent_menu_item">
/// the menu item whose activation triggered
///     the popup, or %NULL
/// </param>
/// <param name="func">
/// a user supplied function used to position the menu,
///     or %NULL
/// </param>
/// <param name="data">
/// user supplied data to be passed to @func
/// </param>
/// <param name="destroy">
/// destroy notify for @data
/// </param>
/// <param name="button">
/// the mouse button which was pressed to initiate the event
/// </param>
/// <param name="activate_time">
/// the time at which the activation event occurred
/// </param>

	public static T PopupForDevice<T>(this T menu, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gtk.GtkWidgetHandle parent_menu_shell, MentorLake.Gtk.GtkWidgetHandle parent_menu_item, MentorLake.Gtk.GtkMenuPositionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy, uint button, uint activate_time) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup_for_device(menu, device, parent_menu_shell, parent_menu_item, func, data, destroy, button, activate_time);
		return menu;
	}

/// <summary>
/// <para>
/// Moves @child to a new @position in the list of @menu
/// children.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="child">
/// the #GtkMenuItem to move
/// </param>
/// <param name="position">
/// the new position to place @child.
///     Positions are numbered from 0 to n - 1
/// </param>

	public static T ReorderChild<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_reorder_child(menu, child, position);
		return menu;
	}

/// <summary>
/// <para>
/// Repositions the menu according to its position function.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>

	public static T Reposition<T>(this T menu) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_reposition(menu);
		return menu;
	}

/// <summary>
/// <para>
/// Set the #GtkAccelGroup which holds global accelerators for the
/// menu.  This accelerator group needs to also be added to all windows
/// that this menu is being used in with gtk_window_add_accel_group(),
/// in order for those windows to support all the accelerators
/// contained in this group.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="accel_group">
/// the #GtkAccelGroup to be associated
///               with the menu.
/// </param>

	public static T SetAccelGroup<T>(this T menu, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_accel_group(menu, accel_group);
		return menu;
	}

/// <summary>
/// <para>
/// Sets an accelerator path for this menu from which accelerator paths
/// for its immediate children, its menu items, can be constructed.
/// The main purpose of this function is to spare the programmer the
/// inconvenience of having to call gtk_menu_item_set_accel_path() on
/// each menu item that should support runtime user changable accelerators.
/// Instead, by just calling gtk_menu_set_accel_path() on their parent,
/// each menu item of this menu, that contains a label describing its
/// purpose, automatically gets an accel path assigned.
/// </para>
/// <para>
/// For example, a menu containing menu items “New” and “Exit”, will, after
/// `gtk_menu_set_accel_path (menu, "<Gnumeric-Sheet>/File");` has been
/// called, assign its items the accel paths: `"<Gnumeric-Sheet>/File/New"`
/// and `"<Gnumeric-Sheet>/File/Exit"`.
/// </para>
/// <para>
/// Assigning accel paths to menu items then enables the user to change
/// their accelerators at runtime. More details about accelerator paths
/// and their default setups can be found at gtk_accel_map_add_entry().
/// </para>
/// <para>
/// Note that @accel_path string will be stored in a #GQuark. Therefore,
/// if you pass a static string, you can save some memory by interning
/// it first with g_intern_static_string().
/// </para>
/// </summary>

/// <param name="menu">
/// a valid #GtkMenu
/// </param>
/// <param name="accel_path">
/// a valid accelerator path, or %NULL to unset the path
/// </param>

	public static T SetAccelPath<T>(this T menu, string accel_path) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_accel_path(menu, accel_path);
		return menu;
	}

/// <summary>
/// <para>
/// Selects the specified menu item within the menu.  This is used by
/// the #GtkComboBox and should not be used by anyone else.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="index">
/// the index of the menu item to select.  Index values are
///         from 0 to n-1
/// </param>

	public static T SetActive<T>(this T menu, uint index) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_active(menu, index);
		return menu;
	}

/// <summary>
/// <para>
/// Informs GTK+ on which monitor a menu should be popped up.
/// See gdk_monitor_get_geometry().
/// </para>
/// <para>
/// This function should be called from a #GtkMenuPositionFunc
/// if the menu should not appear on the same monitor as the pointer.
/// This information can’t be reliably inferred from the coordinates
/// returned by a #GtkMenuPositionFunc, since, for very long menus,
/// these coordinates may extend beyond the monitor boundaries or even
/// the screen boundaries.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="monitor_num">
/// the number of the monitor on which the menu should
///    be popped up
/// </param>

	public static T SetMonitor<T>(this T menu, int monitor_num) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_monitor(menu, monitor_num);
		return menu;
	}

/// <summary>
/// <para>
/// Sets whether the menu should reserve space for drawing toggles
/// or icons, regardless of their actual presence.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="reserve_toggle_size">
/// whether to reserve size for toggles
/// </param>

	public static T SetReserveToggleSize<T>(this T menu, bool reserve_toggle_size) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_reserve_toggle_size(menu, reserve_toggle_size);
		return menu;
	}

/// <summary>
/// <para>
/// Sets the #GdkScreen on which the menu will be displayed.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="screen">
/// a #GdkScreen, or %NULL if the screen should be
///          determined by the widget the menu is attached to
/// </param>

	public static T SetScreen<T>(this T menu, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_screen(menu, screen);
		return menu;
	}

/// <summary>
/// <para>
/// Changes the tearoff state of the menu.  A menu is normally
/// displayed as drop down menu which persists as long as the menu is
/// active.  It can also be displayed as a tearoff menu which persists
/// until it is closed or reattached.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="torn_off">
/// If %TRUE, menu is displayed as a tearoff menu.
/// </param>

	public static T SetTearoffState<T>(this T menu, bool torn_off) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_tearoff_state(menu, torn_off);
		return menu;
	}

/// <summary>
/// <para>
/// Sets the title string for the menu.
/// </para>
/// <para>
/// The title is displayed when the menu is shown as a tearoff
/// menu. If @title is %NULL, the menu will see if it is attached
/// to a parent menu item, and if so it will try to use the same
/// text as that menu item’s label.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkMenu
/// </param>
/// <param name="title">
/// a string containing the title for the menu, or %NULL to
///   inherit the title of the parent menu item, if any
/// </param>

	public static T SetTitle<T>(this T menu, string title) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_title(menu, title);
		return menu;
	}

}

internal class GtkMenuHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuHandle gtk_menu_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuHandle gtk_menu_new_from_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_attach_to_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle attach_widget, MentorLake.Gtk.GtkMenuDetachFunc detacher);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_detach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_menu_get_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_get_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_get_attach_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_menu_get_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_get_reserve_toggle_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_get_tearoff_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_place_on_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent_menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent_menu_item, MentorLake.Gtk.GtkMenuPositionFunc func, IntPtr data, uint button, uint activate_time);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup_at_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle trigger_event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup_at_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle rect_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect, MentorLake.Gdk.GdkGravity rect_anchor, MentorLake.Gdk.GdkGravity menu_anchor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle trigger_event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup_at_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkGravity widget_anchor, MentorLake.Gdk.GdkGravity menu_anchor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle trigger_event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup_for_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent_menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent_menu_item, MentorLake.Gtk.GtkMenuPositionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy, uint button, uint activate_time);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_reorder_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_reposition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, string accel_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, uint index);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, int monitor_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_reserve_toggle_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, bool reserve_toggle_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_tearoff_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, bool torn_off);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, string title);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_menu_get_for_attach_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}
