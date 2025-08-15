namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// &amp;gt; In GTK+ 3.10, GtkAction has been deprecated. Use #GAction
/// &amp;gt; instead, and associate actions with #GtkActionable widgets. Use
/// &amp;gt; #GMenuModel for creating menus with gtk_menu_new_from_model().
/// </para>
/// <para>
/// Actions represent operations that the user can be perform, along with
/// some information how it should be presented in the interface. Each action
/// provides methods to create icons, menu items and toolbar items
/// representing itself.
/// </para>
/// <para>
/// As well as the callback that is called when the action gets activated,
/// the following also gets associated with the action:
/// </para>
/// <para>
/// - a name (not translated, for path lookup)
/// </para>
/// <para>
/// - a label (translated, for display)
/// </para>
/// <para>
/// - an accelerator
/// </para>
/// <para>
/// - whether label indicates a stock id
/// </para>
/// <para>
/// - a tooltip (optional, translated)
/// </para>
/// <para>
/// - a toolbar label (optional, shorter than label)
/// </para>
/// 
/// <para>
/// The action will also have some state information:
/// </para>
/// <para>
/// - visible (shown/hidden)
/// </para>
/// <para>
/// - sensitive (enabled/disabled)
/// </para>
/// <para>
/// Apart from regular actions, there are [toggle actions][GtkToggleAction],
/// which can be toggled between two states and
/// [radio actions][GtkRadioAction], of which only one in a group
/// can be in the “active” state. Other actions can be implemented as #GtkAction
/// subclasses.
/// </para>
/// <para>
/// Each action can have one or more proxy widgets. To act as an action proxy,
/// widget needs to implement #GtkActivatable interface. Proxies mirror the state
/// of the action and should change when the action’s state changes. Properties
/// that are always mirrored by proxies are #GtkAction:sensitive and
/// #GtkAction:visible. #GtkAction:gicon, #GtkAction:icon-name, #GtkAction:label,
/// #GtkAction:short-label and #GtkAction:stock-id properties are only mirorred
/// if proxy widget has #GtkActivatable:use-action-appearance property set to
/// %TRUE.
/// </para>
/// <para>
/// When the proxy is activated, it should activate its action.
/// </para>
/// </summary>

public class GtkActionHandle : GObjectHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAction object. To add the action to a
/// #GtkActionGroup and set the accelerator for the action,
/// call gtk_action_group_add_action_with_accel().
/// See the [UI Definition section][XML-UI] for information on allowed action
/// names.
/// </para>
/// </summary>

/// <param name="name">
/// A unique name for the action
/// </param>
/// <param name="label">
/// the label displayed in menu items and on buttons,
///         or %NULL
/// </param>
/// <param name="tooltip">
/// a tooltip for the action, or %NULL
/// </param>
/// <param name="stock_id">
/// the stock icon to display in widgets representing
///            the action, or %NULL
/// </param>
/// <return>
/// a new #GtkAction
/// </return>

	public static MentorLake.Gtk.GtkActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkActionHandleExterns.gtk_action_new(name, label, tooltip, stock_id);
	}

}
public static class GtkActionHandleSignalExtensions
{
/// <summary>
/// <para>
/// The &quot;activate&quot; signal is emitted when the action is activated.
/// </para>
/// </summary>

	public static IObservable<GtkActionHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkActionHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkActionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkActionHandleSignalStructs
{

public class ActivateSignal
{

	public MentorLake.Gtk.GtkActionHandle Self;

	public IntPtr UserData;
}
}

public static class GtkActionHandleSignalDelegates
{

/// <summary>
/// <para>
/// The &quot;activate&quot; signal is emitted when the action is activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle self, IntPtr user_data);

}


public static class GtkActionHandleExtensions
{
/// <summary>
/// <para>
/// Emits the “activate” signal on the specified action, if it isn&apos;t
/// insensitive. This gets called by the proxy widgets when they get
/// activated.
/// </para>
/// <para>
/// It can also be used to manually activate an action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>

	public static T Activate<T>(this T action) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_activate(action);
		return action;
	}

/// <summary>
/// <para>
/// Disable activation signals from the action
/// </para>
/// <para>
/// This is needed when updating the state of your proxy
/// #GtkActivatable widget could result in calling gtk_action_activate(),
/// this is a convenience function to avoid recursing in those
/// cases (updating toggle state for instance).
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>

	public static T BlockActivate<T>(this T action) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_block_activate(action);
		return action;
	}

/// <summary>
/// <para>
/// Installs the accelerator for @action if @action has an
/// accel path and group. See gtk_action_set_accel_path() and
/// gtk_action_set_accel_group()
/// </para>
/// <para>
/// Since multiple proxies may independently trigger the installation
/// of the accelerator, the @action counts the number of times this
/// function has been called and doesn’t remove the accelerator until
/// gtk_action_disconnect_accelerator() has been called as many times.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>

	public static T ConnectAccelerator<T>(this T action) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_connect_accelerator(action);
		return action;
	}

/// <summary>
/// <para>
/// This function is intended for use by action implementations to
/// create icons displayed in the proxy widgets.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="icon_size">
/// the size of the icon (#GtkIconSize) that should
///      be created.
/// </param>
/// <return>
/// a widget that displays the icon for this action.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle CreateIcon(this MentorLake.Gtk.GtkActionHandle action, MentorLake.Gtk.GtkIconSize icon_size)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_create_icon(action, icon_size);
	}

/// <summary>
/// <para>
/// If @action provides a #GtkMenu widget as a submenu for the menu
/// item or the toolbar item it creates, this function returns an
/// instance of that menu.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// the menu item provided by the
///               action, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle CreateMenu(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_create_menu(action);
	}

/// <summary>
/// <para>
/// Creates a menu item widget that proxies for the given action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// a menu item connected to the action.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle CreateMenuItem(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_create_menu_item(action);
	}

/// <summary>
/// <para>
/// Creates a toolbar item widget that proxies for the given action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// a toolbar item connected to the action.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle CreateToolItem(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_create_tool_item(action);
	}

/// <summary>
/// <para>
/// Undoes the effect of one call to gtk_action_connect_accelerator().
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>

	public static T DisconnectAccelerator<T>(this T action) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_disconnect_accelerator(action);
		return action;
	}

/// <summary>
/// <para>
/// Returns the accel closure for this action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// the accel closure for this action. The
///          returned closure is owned by GTK+ and must not be unreffed
///          or modified.
/// </return>

	public static MentorLake.GObject.GClosureHandle GetAccelClosure(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_accel_closure(action);
	}

/// <summary>
/// <para>
/// Returns the accel path for this action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// the accel path for this action, or %NULL
///   if none is set. The returned string is owned by GTK+
///   and must not be freed or modified.
/// </return>

	public static string GetAccelPath(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_accel_path(action);
	}

/// <summary>
/// <para>
/// Returns whether @action&apos;s menu item proxies will always
/// show their image, if available.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// %TRUE if the menu item proxies will always show their image
/// </return>

	public static bool GetAlwaysShowImage(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_always_show_image(action);
	}

/// <summary>
/// <para>
/// Gets the gicon of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// The action’s #GIcon if one is set.
/// </return>

	public static MentorLake.Gio.GIconHandle GetGicon(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_gicon(action);
	}

/// <summary>
/// <para>
/// Gets the icon name of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// the icon name
/// </return>

	public static string GetIconName(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_icon_name(action);
	}

/// <summary>
/// <para>
/// Checks whether @action is important or not
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// whether @action is important
/// </return>

	public static bool GetIsImportant(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_is_important(action);
	}

/// <summary>
/// <para>
/// Gets the label text of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// the label text
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_label(action);
	}

/// <summary>
/// <para>
/// Returns the name of the action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// the name of the action. The string belongs to GTK+ and should not
///   be freed.
/// </return>

	public static string GetName(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_name(action);
	}

/// <summary>
/// <para>
/// Returns the proxy widgets for an action.
/// See also gtk_activatable_get_related_action().
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// a #GSList of proxy widgets. The list is owned by GTK+
/// and must not be modified.
/// </return>

	public static MentorLake.GLib.GSListHandle GetProxies(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_proxies(action);
	}

/// <summary>
/// <para>
/// Returns whether the action itself is sensitive. Note that this doesn’t
/// necessarily mean effective sensitivity. See gtk_action_is_sensitive()
/// for that.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// %TRUE if the action itself is sensitive.
/// </return>

	public static bool GetSensitive(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_sensitive(action);
	}

/// <summary>
/// <para>
/// Gets the short label text of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// the short label text.
/// </return>

	public static string GetShortLabel(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_short_label(action);
	}

/// <summary>
/// <para>
/// Gets the stock id of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// the stock id
/// </return>

	public static string GetStockId(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_stock_id(action);
	}

/// <summary>
/// <para>
/// Gets the tooltip text of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// the tooltip text
/// </return>

	public static string GetTooltip(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_tooltip(action);
	}

/// <summary>
/// <para>
/// Returns whether the action itself is visible. Note that this doesn’t
/// necessarily mean effective visibility. See gtk_action_is_sensitive()
/// for that.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// %TRUE if the action itself is visible.
/// </return>

	public static bool GetVisible(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_visible(action);
	}

/// <summary>
/// <para>
/// Checks whether @action is visible when horizontal
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// whether @action is visible when horizontal
/// </return>

	public static bool GetVisibleHorizontal(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_visible_horizontal(action);
	}

/// <summary>
/// <para>
/// Checks whether @action is visible when horizontal
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <return>
/// whether @action is visible when horizontal
/// </return>

	public static bool GetVisibleVertical(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_get_visible_vertical(action);
	}

/// <summary>
/// <para>
/// Returns whether the action is effectively sensitive.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// %TRUE if the action and its associated action group
/// are both sensitive.
/// </return>

	public static bool IsSensitive(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_is_sensitive(action);
	}

/// <summary>
/// <para>
/// Returns whether the action is effectively visible.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// %TRUE if the action and its associated action group
/// are both visible.
/// </return>

	public static bool IsVisible(this MentorLake.Gtk.GtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		return GtkActionHandleExterns.gtk_action_is_visible(action);
	}

/// <summary>
/// <para>
/// Sets the #GtkAccelGroup in which the accelerator for this action
/// will be installed.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="accel_group">
/// a #GtkAccelGroup or %NULL
/// </param>

	public static T SetAccelGroup<T>(this T action, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_accel_group(action, accel_group);
		return action;
	}

/// <summary>
/// <para>
/// Sets the accel path for this action.  All proxy widgets associated
/// with the action will have this accel path, so that their
/// accelerators are consistent.
/// </para>
/// <para>
/// Note that @accel_path string will be stored in a #GQuark. Therefore, if you
/// pass a static string, you can save some memory by interning it first with
/// g_intern_static_string().
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="accel_path">
/// the accelerator path
/// </param>

	public static T SetAccelPath<T>(this T action, string accel_path) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_accel_path(action, accel_path);
		return action;
	}

/// <summary>
/// <para>
/// Sets whether @action&apos;s menu item proxies will ignore the
/// #GtkSettings:gtk-menu-images setting and always show their image, if available.
/// </para>
/// <para>
/// Use this if the menu item would be useless or hard to use
/// without their image.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="always_show">
/// %TRUE if menuitem proxies should always show their image
/// </param>

	public static T SetAlwaysShowImage<T>(this T action, bool always_show) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_always_show_image(action, always_show);
		return action;
	}

/// <summary>
/// <para>
/// Sets the icon of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="icon">
/// the #GIcon to set
/// </param>

	public static T SetGicon<T>(this T action, MentorLake.Gio.GIconHandle icon) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_gicon(action, icon);
		return action;
	}

/// <summary>
/// <para>
/// Sets the icon name on @action
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="icon_name">
/// the icon name to set
/// </param>

	public static T SetIconName<T>(this T action, string icon_name) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_icon_name(action, icon_name);
		return action;
	}

/// <summary>
/// <para>
/// Sets whether the action is important, this attribute is used
/// primarily by toolbar items to decide whether to show a label
/// or not.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="is_important">
/// %TRUE to make the action important
/// </param>

	public static T SetIsImportant<T>(this T action, bool is_important) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_is_important(action, is_important);
		return action;
	}

/// <summary>
/// <para>
/// Sets the label of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="label">
/// the label text to set
/// </param>

	public static T SetLabel<T>(this T action, string label) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_label(action, label);
		return action;
	}

/// <summary>
/// <para>
/// Sets the :sensitive property of the action to @sensitive. Note that
/// this doesn’t necessarily mean effective sensitivity. See
/// gtk_action_is_sensitive()
/// for that.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="sensitive">
/// %TRUE to make the action sensitive
/// </param>

	public static T SetSensitive<T>(this T action, bool sensitive) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_sensitive(action, sensitive);
		return action;
	}

/// <summary>
/// <para>
/// Sets a shorter label text on @action.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="short_label">
/// the label text to set
/// </param>

	public static T SetShortLabel<T>(this T action, string short_label) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_short_label(action, short_label);
		return action;
	}

/// <summary>
/// <para>
/// Sets the stock id on @action
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="stock_id">
/// the stock id
/// </param>

	public static T SetStockId<T>(this T action, string stock_id) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_stock_id(action, stock_id);
		return action;
	}

/// <summary>
/// <para>
/// Sets the tooltip text on @action
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="tooltip">
/// the tooltip text
/// </param>

	public static T SetTooltip<T>(this T action, string tooltip) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_tooltip(action, tooltip);
		return action;
	}

/// <summary>
/// <para>
/// Sets the :visible property of the action to @visible. Note that
/// this doesn’t necessarily mean effective visibility. See
/// gtk_action_is_visible()
/// for that.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="visible">
/// %TRUE to make the action visible
/// </param>

	public static T SetVisible<T>(this T action, bool visible) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_visible(action, visible);
		return action;
	}

/// <summary>
/// <para>
/// Sets whether @action is visible when horizontal
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="visible_horizontal">
/// whether the action is visible horizontally
/// </param>

	public static T SetVisibleHorizontal<T>(this T action, bool visible_horizontal) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_visible_horizontal(action, visible_horizontal);
		return action;
	}

/// <summary>
/// <para>
/// Sets whether @action is visible when vertical
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>
/// <param name="visible_vertical">
/// whether the action is visible vertically
/// </param>

	public static T SetVisibleVertical<T>(this T action, bool visible_vertical) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_set_visible_vertical(action, visible_vertical);
		return action;
	}

/// <summary>
/// <para>
/// Reenable activation signals from the action
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkAction
/// </param>

	public static T UnblockActivate<T>(this T action) where T : GtkActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkActionHandle)");
		GtkActionHandleExterns.gtk_action_unblock_activate(action);
		return action;
	}

}

internal class GtkActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))]
	internal static extern MentorLake.Gtk.GtkActionHandle gtk_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_block_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_connect_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_create_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, MentorLake.Gtk.GtkIconSize icon_size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_create_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_create_menu_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_create_tool_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_disconnect_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle gtk_action_get_accel_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle gtk_action_get_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_is_important([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_action_get_proxies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_short_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_stock_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_visible_horizontal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_visible_vertical([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_is_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_is_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string accel_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool always_show);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_is_important([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool is_important);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_short_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string short_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_stock_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string tooltip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_visible_horizontal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool visible_horizontal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_visible_vertical([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool visible_vertical);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_unblock_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

}
