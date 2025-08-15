namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A toolbar is created with a call to gtk_toolbar_new().
/// </para>
/// <para>
/// A toolbar can contain instances of a subclass of #GtkToolItem. To add
/// a #GtkToolItem to the a toolbar, use gtk_toolbar_insert(). To remove
/// an item from the toolbar use gtk_container_remove(). To add a button
/// to the toolbar, add an instance of #GtkToolButton.
/// </para>
/// <para>
/// Toolbar items can be visually grouped by adding instances of
/// #GtkSeparatorToolItem to the toolbar. If the GtkToolbar child property
/// “expand” is #TRUE and the property #GtkSeparatorToolItem:draw is set to
/// #FALSE, the effect is to force all following items to the end of the toolbar.
/// </para>
/// <para>
/// By default, a toolbar can be shrunk, upon which it will add an arrow button
/// to show an overflow menu offering access to any #GtkToolItem child that has
/// a proxy menu item. To disable this and request enough size for all children,
/// call gtk_toolbar_set_show_arrow() to set #GtkToolbar:show-arrow to %FALSE.
/// </para>
/// <para>
/// Creating a context menu for the toolbar can be done by connecting to
/// the #GtkToolbar::popup-context-menu signal.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkToolbar has a single CSS node with name toolbar.
/// </para>
/// </summary>

public class GtkToolbarHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkToolShellHandle
{
/// <summary>
/// <para>
/// Creates a new toolbar.
/// </para>
/// </summary>

/// <return>
/// the newly-created toolbar.
/// </return>

	public static MentorLake.Gtk.GtkToolbarHandle New()
	{
		return GtkToolbarHandleExterns.gtk_toolbar_new();
	}

}
public static class GtkToolbarHandleSignalExtensions
{
/// <summary>
/// <para>
/// A keybinding signal used internally by GTK+. This signal can&apos;t
/// be used in application code
/// </para>
/// </summary>

	public static IObservable<GtkToolbarHandleSignalStructs.FocusHomeOrEndSignal> Signal_FocusHomeOrEnd(this GtkToolbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolbarHandleSignalStructs.FocusHomeOrEndSignal> obs) =>
		{
			GtkToolbarHandleSignalDelegates.focus_home_or_end handler = ( MentorLake.Gtk.GtkToolbarHandle self,  bool focus_home,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarHandleSignalStructs.FocusHomeOrEndSignal()
				{
					Self = self, FocusHome = focus_home, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-home-or-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the orientation of the toolbar changes.
/// </para>
/// </summary>

	public static IObservable<GtkToolbarHandleSignalStructs.OrientationChangedSignal> Signal_OrientationChanged(this GtkToolbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolbarHandleSignalStructs.OrientationChangedSignal> obs) =>
		{
			GtkToolbarHandleSignalDelegates.orientation_changed handler = ( MentorLake.Gtk.GtkToolbarHandle self,  MentorLake.Gtk.GtkOrientation orientation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarHandleSignalStructs.OrientationChangedSignal()
				{
					Self = self, Orientation = orientation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "orientation-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the user right-clicks the toolbar or uses the
/// keybinding to display a popup menu.
/// </para>
/// <para>
/// Application developers should handle this signal if they want
/// to display a context menu on the toolbar. The context-menu should
/// appear at the coordinates given by @x and @y. The mouse button
/// number is given by the @button parameter. If the menu was popped
/// up using the keybaord, @button is -1.
/// </para>
/// </summary>

	public static IObservable<GtkToolbarHandleSignalStructs.PopupContextMenuSignal> Signal_PopupContextMenu(this GtkToolbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolbarHandleSignalStructs.PopupContextMenuSignal> obs) =>
		{
			GtkToolbarHandleSignalDelegates.popup_context_menu handler = ( MentorLake.Gtk.GtkToolbarHandle self,  int x,  int y,  int button,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarHandleSignalStructs.PopupContextMenuSignal()
				{
					Self = self, X = x, Y = y, Button = button, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popup-context-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the style of the toolbar changes.
/// </para>
/// </summary>

	public static IObservable<GtkToolbarHandleSignalStructs.StyleChangedSignal> Signal_StyleChanged(this GtkToolbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolbarHandleSignalStructs.StyleChangedSignal> obs) =>
		{
			GtkToolbarHandleSignalDelegates.style_changed handler = ( MentorLake.Gtk.GtkToolbarHandle self,  MentorLake.Gtk.GtkToolbarStyle style,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarHandleSignalStructs.StyleChangedSignal()
				{
					Self = self, Style = style, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "style-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkToolbarHandleSignalStructs
{

public class FocusHomeOrEndSignal
{

	public MentorLake.Gtk.GtkToolbarHandle Self;
/// <summary>
/// <para>
/// %TRUE if the first item should be focused
/// </para>
/// </summary>

	public bool FocusHome;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the signal was handled, %FALSE if not
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class OrientationChangedSignal
{

	public MentorLake.Gtk.GtkToolbarHandle Self;
/// <summary>
/// <para>
/// the new #GtkOrientation of the toolbar
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkOrientation Orientation;

	public IntPtr UserData;
}

public class PopupContextMenuSignal
{

	public MentorLake.Gtk.GtkToolbarHandle Self;
/// <summary>
/// <para>
/// the x coordinate of the point where the menu should appear
/// </para>
/// </summary>

	public int X;
/// <summary>
/// <para>
/// the y coordinate of the point where the menu should appear
/// </para>
/// </summary>

	public int Y;
/// <summary>
/// <para>
/// the mouse button the user pressed, or -1
/// </para>
/// </summary>

	public int Button;

	public IntPtr UserData;
/// <summary>
/// <para>
/// return %TRUE if the signal was handled, %FALSE if not
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class StyleChangedSignal
{

	public MentorLake.Gtk.GtkToolbarHandle Self;
/// <summary>
/// <para>
/// the new #GtkToolbarStyle of the toolbar
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkToolbarStyle Style;

	public IntPtr UserData;
}
}

public static class GtkToolbarHandleSignalDelegates
{

/// <summary>
/// <para>
/// A keybinding signal used internally by GTK+. This signal can&apos;t
/// be used in application code
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="focus_home">
/// %TRUE if the first item should be focused
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the signal was handled, %FALSE if not
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_home_or_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle self, bool focus_home, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the orientation of the toolbar changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="orientation">
/// the new #GtkOrientation of the toolbar
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void orientation_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle self, MentorLake.Gtk.GtkOrientation orientation, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the user right-clicks the toolbar or uses the
/// keybinding to display a popup menu.
/// </para>
/// <para>
/// Application developers should handle this signal if they want
/// to display a context menu on the toolbar. The context-menu should
/// appear at the coordinates given by @x and @y. The mouse button
/// number is given by the @button parameter. If the menu was popped
/// up using the keybaord, @button is -1.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="x">
/// the x coordinate of the point where the menu should appear
/// </param>
/// <param name="y">
/// the y coordinate of the point where the menu should appear
/// </param>
/// <param name="button">
/// the mouse button the user pressed, or -1
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// return %TRUE if the signal was handled, %FALSE if not
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popup_context_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle self, int x, int y, int button, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the style of the toolbar changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="style">
/// the new #GtkToolbarStyle of the toolbar
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle self, MentorLake.Gtk.GtkToolbarStyle style, IntPtr user_data);

}


public static class GtkToolbarHandleExtensions
{
/// <summary>
/// <para>
/// Returns the position corresponding to the indicated point on
/// @toolbar. This is useful when dragging items to the toolbar:
/// this function returns the position a new item should be
/// inserted.
/// </para>
/// <para>
/// @x and @y are in @toolbar coordinates.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <param name="x">
/// x coordinate of a point on the toolbar
/// </param>
/// <param name="y">
/// y coordinate of a point on the toolbar
/// </param>
/// <return>
/// The position corresponding to the point (@x, @y) on the toolbar.
/// </return>

	public static int GetDropIndex(this MentorLake.Gtk.GtkToolbarHandle toolbar, int x, int y)
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		return GtkToolbarHandleExterns.gtk_toolbar_get_drop_index(toolbar, x, y);
	}

/// <summary>
/// <para>
/// Retrieves the icon size for the toolbar. See gtk_toolbar_set_icon_size().
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <return>
/// the current icon size for the icons on the toolbar.
/// </return>

	public static MentorLake.Gtk.GtkIconSize GetIconSize(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		return GtkToolbarHandleExterns.gtk_toolbar_get_icon_size(toolbar);
	}

/// <summary>
/// <para>
/// Returns the position of @item on the toolbar, starting from 0.
/// It is an error if @item is not a child of the toolbar.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <param name="item">
/// a #GtkToolItem that is a child of @toolbar
/// </param>
/// <return>
/// the position of item on the toolbar.
/// </return>

	public static int GetItemIndex(this MentorLake.Gtk.GtkToolbarHandle toolbar, MentorLake.Gtk.GtkToolItemHandle item)
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		return GtkToolbarHandleExterns.gtk_toolbar_get_item_index(toolbar, item);
	}

/// <summary>
/// <para>
/// Returns the number of items on the toolbar.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <return>
/// the number of items on the toolbar
/// </return>

	public static int GetNItems(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		return GtkToolbarHandleExterns.gtk_toolbar_get_n_items(toolbar);
	}

/// <summary>
/// <para>
/// Returns the @n&apos;th item on @toolbar, or %NULL if the
/// toolbar does not contain an @n&apos;th item.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <param name="n">
/// A position on the toolbar
/// </param>
/// <return>
/// The @n&apos;th #GtkToolItem on @toolbar,
///     or %NULL if there isn’t an @n&apos;th item.
/// </return>

	public static MentorLake.Gtk.GtkToolItemHandle GetNthItem(this MentorLake.Gtk.GtkToolbarHandle toolbar, int n)
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		return GtkToolbarHandleExterns.gtk_toolbar_get_nth_item(toolbar, n);
	}

/// <summary>
/// <para>
/// Returns the relief style of buttons on @toolbar. See
/// gtk_button_set_relief().
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <return>
/// The relief style of buttons on @toolbar.
/// </return>

	public static MentorLake.Gtk.GtkReliefStyle GetReliefStyle(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		return GtkToolbarHandleExterns.gtk_toolbar_get_relief_style(toolbar);
	}

/// <summary>
/// <para>
/// Returns whether the toolbar has an overflow menu.
/// See gtk_toolbar_set_show_arrow().
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <return>
/// %TRUE if the toolbar has an overflow menu.
/// </return>

	public static bool GetShowArrow(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		return GtkToolbarHandleExterns.gtk_toolbar_get_show_arrow(toolbar);
	}

/// <summary>
/// <para>
/// Retrieves whether the toolbar has text, icons, or both . See
/// gtk_toolbar_set_style().
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <return>
/// the current style of @toolbar
/// </return>

	public static MentorLake.Gtk.GtkToolbarStyle GetStyle(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		return GtkToolbarHandleExterns.gtk_toolbar_get_style(toolbar);
	}

/// <summary>
/// <para>
/// Insert a #GtkToolItem into the toolbar at position @pos. If @pos is
/// 0 the item is prepended to the start of the toolbar. If @pos is
/// negative, the item is appended to the end of the toolbar.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <param name="item">
/// a #GtkToolItem
/// </param>
/// <param name="pos">
/// the position of the new item
/// </param>

	public static T Insert<T>(this T toolbar, MentorLake.Gtk.GtkToolItemHandle item, int pos) where T : GtkToolbarHandle
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		GtkToolbarHandleExterns.gtk_toolbar_insert(toolbar, item, pos);
		return toolbar;
	}

/// <summary>
/// <para>
/// Highlights @toolbar to give an idea of what it would look like
/// if @item was added to @toolbar at the position indicated by @index_.
/// If @item is %NULL, highlighting is turned off. In that case @index_
/// is ignored.
/// </para>
/// <para>
/// The @tool_item passed to this function must not be part of any widget
/// hierarchy. When an item is set as drop highlight item it can not
/// added to any widget hierarchy or used as highlight item for another
/// toolbar.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <param name="tool_item">
/// a #GtkToolItem, or %NULL to turn of highlighting
/// </param>
/// <param name="index_">
/// a position on @toolbar
/// </param>

	public static T SetDropHighlightItem<T>(this T toolbar, MentorLake.Gtk.GtkToolItemHandle tool_item, int index_) where T : GtkToolbarHandle
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		GtkToolbarHandleExterns.gtk_toolbar_set_drop_highlight_item(toolbar, tool_item, index_);
		return toolbar;
	}

/// <summary>
/// <para>
/// This function sets the size of stock icons in the toolbar. You
/// can call it both before you add the icons and after they’ve been
/// added. The size you set will override user preferences for the default
/// icon size.
/// </para>
/// <para>
/// This should only be used for special-purpose toolbars, normal
/// application toolbars should respect the user preferences for the
/// size of icons.
/// </para>
/// </summary>

/// <param name="toolbar">
/// A #GtkToolbar
/// </param>
/// <param name="icon_size">
/// The #GtkIconSize that stock icons in the toolbar shall have.
/// </param>

	public static T SetIconSize<T>(this T toolbar, MentorLake.Gtk.GtkIconSize icon_size) where T : GtkToolbarHandle
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		GtkToolbarHandleExterns.gtk_toolbar_set_icon_size(toolbar, icon_size);
		return toolbar;
	}

/// <summary>
/// <para>
/// Sets whether to show an overflow menu when @toolbar isn’t allocated enough
/// size to show all of its items. If %TRUE, items which can’t fit in @toolbar,
/// and which have a proxy menu item set by gtk_tool_item_set_proxy_menu_item()
/// or #GtkToolItem::create-menu-proxy, will be available in an overflow menu,
/// which can be opened by an added arrow button. If %FALSE, @toolbar will
/// request enough size to fit all of its child items without any overflow.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>
/// <param name="show_arrow">
/// Whether to show an overflow menu
/// </param>

	public static T SetShowArrow<T>(this T toolbar, bool show_arrow) where T : GtkToolbarHandle
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		GtkToolbarHandleExterns.gtk_toolbar_set_show_arrow(toolbar, show_arrow);
		return toolbar;
	}

/// <summary>
/// <para>
/// Alters the view of @toolbar to display either icons only, text only, or both.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar.
/// </param>
/// <param name="style">
/// the new style for @toolbar.
/// </param>

	public static T SetStyle<T>(this T toolbar, MentorLake.Gtk.GtkToolbarStyle style) where T : GtkToolbarHandle
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		GtkToolbarHandleExterns.gtk_toolbar_set_style(toolbar, style);
		return toolbar;
	}

/// <summary>
/// <para>
/// Unsets toolbar icon size set with gtk_toolbar_set_icon_size(), so that
/// user preferences will be used to determine the icon size.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>

	public static T UnsetIconSize<T>(this T toolbar) where T : GtkToolbarHandle
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		GtkToolbarHandleExterns.gtk_toolbar_unset_icon_size(toolbar);
		return toolbar;
	}

/// <summary>
/// <para>
/// Unsets a toolbar style set with gtk_toolbar_set_style(), so that
/// user preferences will be used to determine the toolbar style.
/// </para>
/// </summary>

/// <param name="toolbar">
/// a #GtkToolbar
/// </param>

	public static T UnsetStyle<T>(this T toolbar) where T : GtkToolbarHandle
	{
		if (toolbar.IsInvalid) throw new Exception("Invalid handle (GtkToolbarHandle)");
		GtkToolbarHandleExterns.gtk_toolbar_unset_style(toolbar);
		return toolbar;
	}

}

internal class GtkToolbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))]
	internal static extern MentorLake.Gtk.GtkToolbarHandle gtk_toolbar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_toolbar_get_drop_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_toolbar_get_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_toolbar_get_item_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle item);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_toolbar_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))]
	internal static extern MentorLake.Gtk.GtkToolItemHandle gtk_toolbar_get_nth_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, int n);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkReliefStyle gtk_toolbar_get_relief_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toolbar_get_show_arrow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolbarStyle gtk_toolbar_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle item, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_set_drop_highlight_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_set_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, MentorLake.Gtk.GtkIconSize icon_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_set_show_arrow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, bool show_arrow);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_set_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, MentorLake.Gtk.GtkToolbarStyle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_unset_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_unset_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

}
