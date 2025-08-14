namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkToolItems are widgets that can appear on a toolbar. To
/// create a toolbar item that contain something else than a button, use
/// gtk_tool_item_new(). Use gtk_container_add() to add a child
/// widget to the tool item.
/// </para>
/// <para>
/// For toolbar items that contain buttons, see the #GtkToolButton,
/// #GtkToggleToolButton and #GtkRadioToolButton classes.
/// </para>
/// <para>
/// See the #GtkToolbar class for a description of the toolbar widget, and
/// #GtkToolShell for a description of the tool shell interface.
/// </para>
/// </summary>

public class GtkToolItemHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkToolItem
/// </para>
/// </summary>

/// <return>
/// the new #GtkToolItem
/// </return>

	public static MentorLake.Gtk.GtkToolItemHandle New()
	{
		return GtkToolItemHandleExterns.gtk_tool_item_new();
	}

}
public static class GtkToolItemHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the toolbar needs information from @tool_item
/// about whether the item should appear in the toolbar overflow menu. In
/// response the tool item should either
/// </para>
/// <para>
/// - call gtk_tool_item_set_proxy_menu_item() with a %NULL
///   pointer and return %TRUE to indicate that the item should not appear
///   in the overflow menu
/// </para>
/// <para>
/// - call gtk_tool_item_set_proxy_menu_item() with a new menu
///   item and return %TRUE, or
/// </para>
/// <para>
/// - return %FALSE to indicate that the signal was not handled by the item.
///   This means that the item will not appear in the overflow menu unless
///   a later handler installs a menu item.
/// </para>
/// <para>
/// The toolbar may cache the result of this signal. When the tool item changes
/// how it will respond to this signal it must call gtk_tool_item_rebuild_menu()
/// to invalidate the cache and ensure that the toolbar rebuilds its overflow
/// menu.
/// </para>
/// </summary>

	public static IObservable<GtkToolItemHandleSignalStructs.CreateMenuProxySignal> Signal_CreateMenuProxy(this GtkToolItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolItemHandleSignalStructs.CreateMenuProxySignal> obs) =>
		{
			GtkToolItemHandleSignalDelegates.create_menu_proxy handler = ( MentorLake.Gtk.GtkToolItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolItemHandleSignalStructs.CreateMenuProxySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-menu-proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when some property of the toolbar that the
/// item is a child of changes. For custom subclasses of #GtkToolItem,
/// the default handler of this signal use the functions
/// - gtk_tool_shell_get_orientation()
/// - gtk_tool_shell_get_style()
/// - gtk_tool_shell_get_icon_size()
/// - gtk_tool_shell_get_relief_style()
/// to find out what the toolbar should look like and change
/// themselves accordingly.
/// </para>
/// </summary>

	public static IObservable<GtkToolItemHandleSignalStructs.ToolbarReconfiguredSignal> Signal_ToolbarReconfigured(this GtkToolItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolItemHandleSignalStructs.ToolbarReconfiguredSignal> obs) =>
		{
			GtkToolItemHandleSignalDelegates.toolbar_reconfigured handler = ( MentorLake.Gtk.GtkToolItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolItemHandleSignalStructs.ToolbarReconfiguredSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toolbar-reconfigured", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkToolItemHandleSignalStructs
{

public class CreateMenuProxySignal
{

	public MentorLake.Gtk.GtkToolItemHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the signal was handled, %FALSE if not
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ToolbarReconfiguredSignal
{

	public MentorLake.Gtk.GtkToolItemHandle Self;

	public IntPtr UserData;
}
}

public static class GtkToolItemHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the toolbar needs information from @tool_item
/// about whether the item should appear in the toolbar overflow menu. In
/// response the tool item should either
/// </para>
/// <para>
/// - call gtk_tool_item_set_proxy_menu_item() with a %NULL
///   pointer and return %TRUE to indicate that the item should not appear
///   in the overflow menu
/// </para>
/// <para>
/// - call gtk_tool_item_set_proxy_menu_item() with a new menu
///   item and return %TRUE, or
/// </para>
/// <para>
/// - return %FALSE to indicate that the signal was not handled by the item.
///   This means that the item will not appear in the overflow menu unless
///   a later handler installs a menu item.
/// </para>
/// <para>
/// The toolbar may cache the result of this signal. When the tool item changes
/// how it will respond to this signal it must call gtk_tool_item_rebuild_menu()
/// to invalidate the cache and ensure that the toolbar rebuilds its overflow
/// menu.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the signal was handled, %FALSE if not
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool create_menu_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when some property of the toolbar that the
/// item is a child of changes. For custom subclasses of #GtkToolItem,
/// the default handler of this signal use the functions
/// - gtk_tool_shell_get_orientation()
/// - gtk_tool_shell_get_style()
/// - gtk_tool_shell_get_icon_size()
/// - gtk_tool_shell_get_relief_style()
/// to find out what the toolbar should look like and change
/// themselves accordingly.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toolbar_reconfigured([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle self, IntPtr user_data);

}


public static class GtkToolItemHandleExtensions
{
/// <summary>
/// <para>
/// Returns the ellipsize mode used for @tool_item. Custom subclasses of
/// #GtkToolItem should call this function to find out how text should
/// be ellipsized.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// a #PangoEllipsizeMode indicating how text in @tool_item
/// should be ellipsized.
/// </return>

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsizeMode(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_ellipsize_mode(tool_item);
	}

/// <summary>
/// <para>
/// Returns whether @tool_item is allocated extra space.
/// See gtk_tool_item_set_expand().
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// %TRUE if @tool_item is allocated extra space.
/// </return>

	public static bool GetExpand(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_expand(tool_item);
	}

/// <summary>
/// <para>
/// Returns whether @tool_item is the same size as other homogeneous
/// items. See gtk_tool_item_set_homogeneous().
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// %TRUE if the item is the same size as other homogeneous
/// items.
/// </return>

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_homogeneous(tool_item);
	}

/// <summary>
/// <para>
/// Returns the icon size used for @tool_item. Custom subclasses of
/// #GtkToolItem should call this function to find out what size icons
/// they should use.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// a #GtkIconSize indicating the icon size
/// used for @tool_item
/// </return>

	public static MentorLake.Gtk.GtkIconSize GetIconSize(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_icon_size(tool_item);
	}

/// <summary>
/// <para>
/// Returns whether @tool_item is considered important. See
/// gtk_tool_item_set_is_important()
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// %TRUE if @tool_item is considered important.
/// </return>

	public static bool GetIsImportant(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_is_important(tool_item);
	}

/// <summary>
/// <para>
/// Returns the orientation used for @tool_item. Custom subclasses of
/// #GtkToolItem should call this function to find out what size icons
/// they should use.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// a #GtkOrientation indicating the orientation
/// used for @tool_item
/// </return>

	public static MentorLake.Gtk.GtkOrientation GetOrientation(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_orientation(tool_item);
	}

/// <summary>
/// <para>
/// If @menu_item_id matches the string passed to
/// gtk_tool_item_set_proxy_menu_item() return the corresponding #GtkMenuItem.
/// </para>
/// <para>
/// Custom subclasses of #GtkToolItem should use this function to
/// update their menu item when the #GtkToolItem changes. That the
/// @menu_item_ids must match ensures that a #GtkToolItem
/// will not inadvertently change a menu item that they did not create.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="menu_item_id">
/// a string used to identify the menu item
/// </param>
/// <return>
/// The #GtkMenuItem passed to
///     gtk_tool_item_set_proxy_menu_item(), if the @menu_item_ids
///     match.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetProxyMenuItem(this MentorLake.Gtk.GtkToolItemHandle tool_item, string menu_item_id)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_proxy_menu_item(tool_item, menu_item_id);
	}

/// <summary>
/// <para>
/// Returns the relief style of @tool_item. See gtk_button_set_relief().
/// Custom subclasses of #GtkToolItem should call this function in the handler
/// of the #GtkToolItem::toolbar_reconfigured signal to find out the
/// relief style of buttons.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// a #GtkReliefStyle indicating the relief style used
/// for @tool_item.
/// </return>

	public static MentorLake.Gtk.GtkReliefStyle GetReliefStyle(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_relief_style(tool_item);
	}

/// <summary>
/// <para>
/// Returns the text alignment used for @tool_item. Custom subclasses of
/// #GtkToolItem should call this function to find out how text should
/// be aligned.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem:
/// </param>
/// <return>
/// a #gfloat indicating the horizontal text alignment
/// used for @tool_item
/// </return>

	public static float GetTextAlignment(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_text_alignment(tool_item);
	}

/// <summary>
/// <para>
/// Returns the text orientation used for @tool_item. Custom subclasses of
/// #GtkToolItem should call this function to find out how text should
/// be orientated.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// a #GtkOrientation indicating the text orientation
/// used for @tool_item
/// </return>

	public static MentorLake.Gtk.GtkOrientation GetTextOrientation(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_text_orientation(tool_item);
	}

/// <summary>
/// <para>
/// Returns the size group used for labels in @tool_item.
/// Custom subclasses of #GtkToolItem should call this function
/// and use the size group for labels.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// a #GtkSizeGroup
/// </return>

	public static MentorLake.Gtk.GtkSizeGroupHandle GetTextSizeGroup(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_text_size_group(tool_item);
	}

/// <summary>
/// <para>
/// Returns the toolbar style used for @tool_item. Custom subclasses of
/// #GtkToolItem should call this function in the handler of the
/// GtkToolItem::toolbar_reconfigured signal to find out in what style
/// the toolbar is displayed and change themselves accordingly
/// </para>
/// <para>
/// Possibilities are:
/// - %GTK_TOOLBAR_BOTH, meaning the tool item should show
///   both an icon and a label, stacked vertically
/// - %GTK_TOOLBAR_ICONS, meaning the toolbar shows only icons
/// - %GTK_TOOLBAR_TEXT, meaning the tool item should only show text
/// - %GTK_TOOLBAR_BOTH_HORIZ, meaning the tool item should show
///   both an icon and a label, arranged horizontally
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// A #GtkToolbarStyle indicating the toolbar style used
/// for @tool_item.
/// </return>

	public static MentorLake.Gtk.GtkToolbarStyle GetToolbarStyle(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_toolbar_style(tool_item);
	}

/// <summary>
/// <para>
/// Returns whether @tool_item has a drag window. See
/// gtk_tool_item_set_use_drag_window().
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// %TRUE if @tool_item uses a drag window.
/// </return>

	public static bool GetUseDragWindow(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_use_drag_window(tool_item);
	}

/// <summary>
/// <para>
/// Returns whether the @tool_item is visible on toolbars that are
/// docked horizontally.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// %TRUE if @tool_item is visible on toolbars that are
/// docked horizontally.
/// </return>

	public static bool GetVisibleHorizontal(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_visible_horizontal(tool_item);
	}

/// <summary>
/// <para>
/// Returns whether @tool_item is visible when the toolbar is docked vertically.
/// See gtk_tool_item_set_visible_vertical().
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// Whether @tool_item is visible when the toolbar is docked vertically
/// </return>

	public static bool GetVisibleVertical(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_get_visible_vertical(tool_item);
	}

/// <summary>
/// <para>
/// Calling this function signals to the toolbar that the
/// overflow menu item for @tool_item has changed. If the
/// overflow menu is visible when this function it called,
/// the menu will be rebuilt.
/// </para>
/// <para>
/// The function must be called when the tool item changes what it
/// will do in response to the #GtkToolItem::create-menu-proxy signal.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>

	public static T RebuildMenu<T>(this T tool_item) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_rebuild_menu(tool_item);
		return tool_item;
	}

/// <summary>
/// <para>
/// Returns the #GtkMenuItem that was last set by
/// gtk_tool_item_set_proxy_menu_item(), ie. the #GtkMenuItem
/// that is going to appear in the overflow menu.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <return>
/// The #GtkMenuItem that is going to appear in the
/// overflow menu for @tool_item.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle RetrieveProxyMenuItem(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		return GtkToolItemHandleExterns.gtk_tool_item_retrieve_proxy_menu_item(tool_item);
	}

/// <summary>
/// <para>
/// Sets whether @tool_item is allocated extra space when there
/// is more room on the toolbar then needed for the items. The
/// effect is that the item gets bigger when the toolbar gets bigger
/// and smaller when the toolbar gets smaller.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="expand">
/// Whether @tool_item is allocated extra space
/// </param>

	public static T SetExpand<T>(this T tool_item, bool expand) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_expand(tool_item, expand);
		return tool_item;
	}

/// <summary>
/// <para>
/// Sets whether @tool_item is to be allocated the same size as other
/// homogeneous items. The effect is that all homogeneous items will have
/// the same width as the widest of the items.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="homogeneous">
/// whether @tool_item is the same size as other homogeneous items
/// </param>

	public static T SetHomogeneous<T>(this T tool_item, bool homogeneous) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_homogeneous(tool_item, homogeneous);
		return tool_item;
	}

/// <summary>
/// <para>
/// Sets whether @tool_item should be considered important. The #GtkToolButton
/// class uses this property to determine whether to show or hide its label
/// when the toolbar style is %GTK_TOOLBAR_BOTH_HORIZ. The result is that
/// only tool buttons with the “is_important” property set have labels, an
/// effect known as “priority text”
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="is_important">
/// whether the tool item should be considered important
/// </param>

	public static T SetIsImportant<T>(this T tool_item, bool is_important) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_is_important(tool_item, is_important);
		return tool_item;
	}

/// <summary>
/// <para>
/// Sets the #GtkMenuItem used in the toolbar overflow menu. The
/// @menu_item_id is used to identify the caller of this function and
/// should also be used with gtk_tool_item_get_proxy_menu_item().
/// </para>
/// <para>
/// See also #GtkToolItem::create-menu-proxy.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="menu_item_id">
/// a string used to identify @menu_item
/// </param>
/// <param name="menu_item">
/// a #GtkMenuItem to use in the overflow menu, or %NULL
/// </param>

	public static T SetProxyMenuItem<T>(this T tool_item, string menu_item_id, MentorLake.Gtk.GtkWidgetHandle menu_item) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_proxy_menu_item(tool_item, menu_item_id, menu_item);
		return tool_item;
	}

/// <summary>
/// <para>
/// Sets the markup text to be displayed as tooltip on the item.
/// See gtk_widget_set_tooltip_markup().
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="markup">
/// markup text to be used as tooltip for @tool_item
/// </param>

	public static T SetTooltipMarkup<T>(this T tool_item, string markup) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_tooltip_markup(tool_item, markup);
		return tool_item;
	}

/// <summary>
/// <para>
/// Sets the text to be displayed as tooltip on the item.
/// See gtk_widget_set_tooltip_text().
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="text">
/// text to be used as tooltip for @tool_item
/// </param>

	public static T SetTooltipText<T>(this T tool_item, string text) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_tooltip_text(tool_item, text);
		return tool_item;
	}

/// <summary>
/// <para>
/// Sets whether @tool_item has a drag window. When %TRUE the
/// toolitem can be used as a drag source through gtk_drag_source_set().
/// When @tool_item has a drag window it will intercept all events,
/// even those that would otherwise be sent to a child of @tool_item.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="use_drag_window">
/// Whether @tool_item has a drag window.
/// </param>

	public static T SetUseDragWindow<T>(this T tool_item, bool use_drag_window) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_use_drag_window(tool_item, use_drag_window);
		return tool_item;
	}

/// <summary>
/// <para>
/// Sets whether @tool_item is visible when the toolbar is docked horizontally.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="visible_horizontal">
/// Whether @tool_item is visible when in horizontal mode
/// </param>

	public static T SetVisibleHorizontal<T>(this T tool_item, bool visible_horizontal) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_visible_horizontal(tool_item, visible_horizontal);
		return tool_item;
	}

/// <summary>
/// <para>
/// Sets whether @tool_item is visible when the toolbar is docked
/// vertically. Some tool items, such as text entries, are too wide to be
/// useful on a vertically docked toolbar. If @visible_vertical is %FALSE
/// @tool_item will not appear on toolbars that are docked vertically.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>
/// <param name="visible_vertical">
/// whether @tool_item is visible when the toolbar
/// is in vertical mode
/// </param>

	public static T SetVisibleVertical<T>(this T tool_item, bool visible_vertical) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_set_visible_vertical(tool_item, visible_vertical);
		return tool_item;
	}

/// <summary>
/// <para>
/// Emits the signal #GtkToolItem::toolbar_reconfigured on @tool_item.
/// #GtkToolbar and other #GtkToolShell implementations use this function
/// to notify children, when some aspect of their configuration changes.
/// </para>
/// </summary>

/// <param name="tool_item">
/// a #GtkToolItem
/// </param>

	public static T ToolbarReconfigured<T>(this T tool_item) where T : GtkToolItemHandle
	{
		if (tool_item.IsInvalid) throw new Exception("Invalid handle (GtkToolItemHandle)");
		GtkToolItemHandleExterns.gtk_tool_item_toolbar_reconfigured(tool_item);
		return tool_item;
	}

}

internal class GtkToolItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))]
	internal static extern MentorLake.Gtk.GtkToolItemHandle gtk_tool_item_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode gtk_tool_item_get_ellipsize_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_tool_item_get_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_is_important([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_tool_item_get_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_item_get_proxy_menu_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, string menu_item_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkReliefStyle gtk_tool_item_get_relief_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_tool_item_get_text_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_tool_item_get_text_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkSizeGroupHandle gtk_tool_item_get_text_size_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolbarStyle gtk_tool_item_get_toolbar_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_use_drag_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_visible_horizontal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_visible_vertical([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_rebuild_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_item_retrieve_proxy_menu_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_is_important([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool is_important);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_proxy_menu_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, string menu_item_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_use_drag_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool use_drag_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_visible_horizontal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool visible_horizontal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_visible_vertical([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool visible_vertical);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_toolbar_reconfigured([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

}
