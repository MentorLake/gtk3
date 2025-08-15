namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Actions are organised into groups. An action group is essentially a
/// map from names to #GtkAction objects.
/// </para>
/// <para>
/// All actions that would make sense to use in a particular context
/// should be in a single group. Multiple action groups may be used for a
/// particular user interface. In fact, it is expected that most nontrivial
/// applications will make use of multiple groups. For example, in an
/// application that can edit multiple documents, one group holding global
/// actions (e.g. quit, about, new), and one group per document holding
/// actions that act on that document (eg. save, cut/copy/paste, etc). Each
/// window’s menus would be constructed from a combination of two action
/// groups.
/// </para>
/// <para>
/// ## Accelerators ## {#Action-Accel}
/// </para>
/// <para>
/// Accelerators are handled by the GTK+ accelerator map. All actions are
/// assigned an accelerator path (which normally has the form
/// `&amp;lt;Actions&amp;gt;/group-name/action-name`) and a shortcut is associated with
/// this accelerator path. All menuitems and toolitems take on this accelerator
/// path. The GTK+ accelerator map code makes sure that the correct shortcut
/// is displayed next to the menu item.
/// </para>
/// <para>
/// # GtkActionGroup as GtkBuildable # {#GtkActionGroup-BUILDER-UI}
/// </para>
/// <para>
/// The #GtkActionGroup implementation of the #GtkBuildable interface accepts
/// #GtkAction objects as `&amp;lt;child&amp;gt;` elements in UI definitions.
/// </para>
/// <para>
/// Note that it is probably more common to define actions and action groups
/// in the code, since they are directly related to what the code can do.
/// </para>
/// <para>
/// The GtkActionGroup implementation of the GtkBuildable interface supports
/// a custom `&amp;lt;accelerator&amp;gt;` element, which has attributes named “key“ and
/// “modifiers“ and allows to specify accelerators. This is similar to the
/// `&amp;lt;accelerator&amp;gt;` element of #GtkWidget, the main difference is that
/// it doesn’t allow you to specify a signal.
/// </para>
/// <para>
/// ## A #GtkDialog UI definition fragment. ##
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkActionGroup&quot; id=&quot;actiongroup&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkActionGroup&quot; id=&quot;actiongroup&quot;&amp;gt;
///   &amp;lt;child&amp;gt;
///       &amp;lt;object class=&quot;GtkAction&quot; id=&quot;About&quot;&amp;gt;
///           &amp;lt;property name=&quot;name&quot;&amp;gt;About&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;stock_id&quot;&amp;gt;gtk-about&amp;lt;/property&amp;gt;
///           &amp;lt;signal handler=&quot;about_activate&quot; name=&quot;activate&quot;/&amp;gt;
///       &amp;lt;/object&amp;gt;
///       &amp;lt;accelerator key=&quot;F1&quot; modifiers=&quot;GDK_CONTROL_MASK | GDK_SHIFT_MASK&quot;/&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// </summary>

public class GtkActionGroupHandle : GObjectHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkActionGroup object. The name of the action group
/// is used when associating [keybindings][Action-Accel]
/// with the actions.
/// </para>
/// </summary>

/// <param name="name">
/// the name of the action group.
/// </param>
/// <return>
/// the new #GtkActionGroup
/// </return>

	public static MentorLake.Gtk.GtkActionGroupHandle New(string name)
	{
		return GtkActionGroupHandleExterns.gtk_action_group_new(name);
	}

}
public static class GtkActionGroupHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::connect-proxy signal is emitted after connecting a proxy to
/// an action in the group. Note that the proxy may have been connected
/// to a different action before.
/// </para>
/// <para>
/// This is intended for simple customizations for which a custom action
/// class would be too clumsy, e.g. showing tooltips for menuitems in the
/// statusbar.
/// </para>
/// <para>
/// #GtkUIManager proxies the signal and provides global notification
/// just before any action is connected to a proxy, which is probably more
/// convenient to use.
/// </para>
/// </summary>

	public static IObservable<GtkActionGroupHandleSignalStructs.ConnectProxySignal> Signal_ConnectProxy(this GtkActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionGroupHandleSignalStructs.ConnectProxySignal> obs) =>
		{
			GtkActionGroupHandleSignalDelegates.connect_proxy handler = ( MentorLake.Gtk.GtkActionGroupHandle self,  MentorLake.Gtk.GtkActionHandle action,  MentorLake.Gtk.GtkWidgetHandle proxy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupHandleSignalStructs.ConnectProxySignal()
				{
					Self = self, Action = action, Proxy = proxy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "connect-proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::disconnect-proxy signal is emitted after disconnecting a proxy
/// from an action in the group.
/// </para>
/// <para>
/// #GtkUIManager proxies the signal and provides global notification
/// just before any action is connected to a proxy, which is probably more
/// convenient to use.
/// </para>
/// </summary>

	public static IObservable<GtkActionGroupHandleSignalStructs.DisconnectProxySignal> Signal_DisconnectProxy(this GtkActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionGroupHandleSignalStructs.DisconnectProxySignal> obs) =>
		{
			GtkActionGroupHandleSignalDelegates.disconnect_proxy handler = ( MentorLake.Gtk.GtkActionGroupHandle self,  MentorLake.Gtk.GtkActionHandle action,  MentorLake.Gtk.GtkWidgetHandle proxy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupHandleSignalStructs.DisconnectProxySignal()
				{
					Self = self, Action = action, Proxy = proxy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "disconnect-proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::post-activate signal is emitted just after the @action in the
/// @action_group is activated
/// </para>
/// <para>
/// This is intended for #GtkUIManager to proxy the signal and provide global
/// notification just after any action is activated.
/// </para>
/// </summary>

	public static IObservable<GtkActionGroupHandleSignalStructs.PostActivateSignal> Signal_PostActivate(this GtkActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionGroupHandleSignalStructs.PostActivateSignal> obs) =>
		{
			GtkActionGroupHandleSignalDelegates.post_activate handler = ( MentorLake.Gtk.GtkActionGroupHandle self,  MentorLake.Gtk.GtkActionHandle action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupHandleSignalStructs.PostActivateSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "post-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::pre-activate signal is emitted just before the @action in the
/// @action_group is activated
/// </para>
/// <para>
/// This is intended for #GtkUIManager to proxy the signal and provide global
/// notification just before any action is activated.
/// </para>
/// </summary>

	public static IObservable<GtkActionGroupHandleSignalStructs.PreActivateSignal> Signal_PreActivate(this GtkActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionGroupHandleSignalStructs.PreActivateSignal> obs) =>
		{
			GtkActionGroupHandleSignalDelegates.pre_activate handler = ( MentorLake.Gtk.GtkActionGroupHandle self,  MentorLake.Gtk.GtkActionHandle action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupHandleSignalStructs.PreActivateSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "pre-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkActionGroupHandleSignalStructs
{

public class ConnectProxySignal
{

	public MentorLake.Gtk.GtkActionGroupHandle Self;
/// <summary>
/// <para>
/// the action
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkActionHandle Action;
/// <summary>
/// <para>
/// the proxy
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Proxy;

	public IntPtr UserData;
}

public class DisconnectProxySignal
{

	public MentorLake.Gtk.GtkActionGroupHandle Self;
/// <summary>
/// <para>
/// the action
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkActionHandle Action;
/// <summary>
/// <para>
/// the proxy
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Proxy;

	public IntPtr UserData;
}

public class PostActivateSignal
{

	public MentorLake.Gtk.GtkActionGroupHandle Self;
/// <summary>
/// <para>
/// the action
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkActionHandle Action;

	public IntPtr UserData;
}

public class PreActivateSignal
{

	public MentorLake.Gtk.GtkActionGroupHandle Self;
/// <summary>
/// <para>
/// the action
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkActionHandle Action;

	public IntPtr UserData;
}
}

public static class GtkActionGroupHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::connect-proxy signal is emitted after connecting a proxy to
/// an action in the group. Note that the proxy may have been connected
/// to a different action before.
/// </para>
/// <para>
/// This is intended for simple customizations for which a custom action
/// class would be too clumsy, e.g. showing tooltips for menuitems in the
/// statusbar.
/// </para>
/// <para>
/// #GtkUIManager proxies the signal and provides global notification
/// just before any action is connected to a proxy, which is probably more
/// convenient to use.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// the action
/// </param>
/// <param name="proxy">
/// the proxy
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void connect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle proxy, IntPtr user_data);


/// <summary>
/// <para>
/// The ::disconnect-proxy signal is emitted after disconnecting a proxy
/// from an action in the group.
/// </para>
/// <para>
/// #GtkUIManager proxies the signal and provides global notification
/// just before any action is connected to a proxy, which is probably more
/// convenient to use.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// the action
/// </param>
/// <param name="proxy">
/// the proxy
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void disconnect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle proxy, IntPtr user_data);


/// <summary>
/// <para>
/// The ::post-activate signal is emitted just after the @action in the
/// @action_group is activated
/// </para>
/// <para>
/// This is intended for #GtkUIManager to proxy the signal and provide global
/// notification just after any action is activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// the action
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void post_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, IntPtr user_data);


/// <summary>
/// <para>
/// The ::pre-activate signal is emitted just before the @action in the
/// @action_group is activated
/// </para>
/// <para>
/// This is intended for #GtkUIManager to proxy the signal and provide global
/// notification just before any action is activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// the action
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pre_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, IntPtr user_data);

}


public static class GtkActionGroupHandleExtensions
{
/// <summary>
/// <para>
/// Adds an action object to the action group. Note that this function
/// does not set up the accel path of the action, which can lead to problems
/// if a user tries to modify the accelerator of a menuitem associated with
/// the action. Therefore you must either set the accel path yourself with
/// gtk_action_set_accel_path(), or use
/// `gtk_action_group_add_action_with_accel (..., NULL)`.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="action">
/// an action
/// </param>

	public static T AddAction<T>(this T action_group, MentorLake.Gtk.GtkActionHandle action) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_action(action_group, action);
		return action_group;
	}

/// <summary>
/// <para>
/// Adds an action object to the action group and sets up the accelerator.
/// </para>
/// <para>
/// If @accelerator is %NULL, attempts to use the accelerator associated
/// with the stock_id of the action.
/// </para>
/// <para>
/// Accel paths are set to `&amp;lt;Actions&amp;gt;/group-name/action-name`.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="action">
/// the action to add
/// </param>
/// <param name="accelerator">
/// the accelerator for the action, in
///   the format understood by gtk_accelerator_parse(), or &quot;&quot; for no accelerator, or
///   %NULL to use the stock accelerator
/// </param>

	public static T AddActionWithAccel<T>(this T action_group, MentorLake.Gtk.GtkActionHandle action, string accelerator) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_action_with_accel(action_group, action, accelerator);
		return action_group;
	}

/// <summary>
/// <para>
/// This is a convenience function to create a number of actions and add them
/// to the action group.
/// </para>
/// <para>
/// The “activate” signals of the actions are connected to the callbacks
/// and their accel paths are set to `&amp;lt;Actions&amp;gt;/group-name/action-name`.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="entries">
/// an array of action descriptions
/// </param>
/// <param name="n_entries">
/// the number of entries
/// </param>
/// <param name="user_data">
/// data to pass to the action callbacks
/// </param>

	public static T AddActions<T>(this T action_group, MentorLake.Gtk.GtkActionEntry[] entries, uint n_entries, IntPtr user_data) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_actions(action_group, entries, n_entries, user_data);
		return action_group;
	}

/// <summary>
/// <para>
/// This variant of gtk_action_group_add_actions() adds a #GDestroyNotify
/// callback for @user_data.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="entries">
/// an array of action descriptions
/// </param>
/// <param name="n_entries">
/// the number of entries
/// </param>
/// <param name="user_data">
/// data to pass to the action callbacks
/// </param>
/// <param name="destroy">
/// destroy notification callback for @user_data
/// </param>

	public static T AddActionsFull<T>(this T action_group, MentorLake.Gtk.GtkActionEntry[] entries, uint n_entries, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_actions_full(action_group, entries, n_entries, user_data, destroy);
		return action_group;
	}

/// <summary>
/// <para>
/// This is a convenience routine to create a group of radio actions and
/// add them to the action group.
/// </para>
/// <para>
/// The “changed” signal of the first radio action is connected to the
/// @on_change callback and the accel paths of the actions are set to
/// `&amp;lt;Actions&amp;gt;/group-name/action-name`.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="entries">
/// an array of radio action descriptions
/// </param>
/// <param name="n_entries">
/// the number of entries
/// </param>
/// <param name="value">
/// the value of the action to activate initially, or -1 if
///   no action should be activated
/// </param>
/// <param name="on_change">
/// the callback to connect to the changed signal
/// </param>
/// <param name="user_data">
/// data to pass to the action callbacks
/// </param>

	public static T AddRadioActions<T>(this T action_group, MentorLake.Gtk.GtkRadioActionEntry[] entries, uint n_entries, int value, MentorLake.GObject.GCallback on_change, IntPtr user_data) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_radio_actions(action_group, entries, n_entries, value, on_change, user_data);
		return action_group;
	}

/// <summary>
/// <para>
/// This variant of gtk_action_group_add_radio_actions() adds a
/// #GDestroyNotify callback for @user_data.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="entries">
/// an array of radio action descriptions
/// </param>
/// <param name="n_entries">
/// the number of entries
/// </param>
/// <param name="value">
/// the value of the action to activate initially, or -1 if
///   no action should be activated
/// </param>
/// <param name="on_change">
/// the callback to connect to the changed signal
/// </param>
/// <param name="user_data">
/// data to pass to the action callbacks
/// </param>
/// <param name="destroy">
/// destroy notification callback for @user_data
/// </param>

	public static T AddRadioActionsFull<T>(this T action_group, MentorLake.Gtk.GtkRadioActionEntry[] entries, uint n_entries, int value, MentorLake.GObject.GCallback on_change, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_radio_actions_full(action_group, entries, n_entries, value, on_change, user_data, destroy);
		return action_group;
	}

/// <summary>
/// <para>
/// This is a convenience function to create a number of toggle actions and add them
/// to the action group.
/// </para>
/// <para>
/// The “activate” signals of the actions are connected to the callbacks
/// and their accel paths are set to `&amp;lt;Actions&amp;gt;/group-name/action-name`.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="entries">
/// an array of toggle action descriptions
/// </param>
/// <param name="n_entries">
/// the number of entries
/// </param>
/// <param name="user_data">
/// data to pass to the action callbacks
/// </param>

	public static T AddToggleActions<T>(this T action_group, MentorLake.Gtk.GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_toggle_actions(action_group, entries, n_entries, user_data);
		return action_group;
	}

/// <summary>
/// <para>
/// This variant of gtk_action_group_add_toggle_actions() adds a
/// #GDestroyNotify callback for @user_data.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="entries">
/// an array of toggle action descriptions
/// </param>
/// <param name="n_entries">
/// the number of entries
/// </param>
/// <param name="user_data">
/// data to pass to the action callbacks
/// </param>
/// <param name="destroy">
/// destroy notification callback for @user_data
/// </param>

	public static T AddToggleActionsFull<T>(this T action_group, MentorLake.Gtk.GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_toggle_actions_full(action_group, entries, n_entries, user_data, destroy);
		return action_group;
	}

/// <summary>
/// <para>
/// Gets the accelerator group.
/// </para>
/// </summary>

/// <param name="action_group">
/// a #GtkActionGroup
/// </param>
/// <return>
/// the accelerator group associated with this action
/// group or %NULL if there is none.
/// </return>

	public static MentorLake.Gtk.GtkAccelGroupHandle GetAccelGroup(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_accel_group(action_group);
	}

/// <summary>
/// <para>
/// Looks up an action in the action group by name.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="action_name">
/// the name of the action
/// </param>
/// <return>
/// the action, or %NULL if no action by that name exists
/// </return>

	public static MentorLake.Gtk.GtkActionHandle GetAction(this MentorLake.Gtk.GtkActionGroupHandle action_group, string action_name)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_action(action_group, action_name);
	}

/// <summary>
/// <para>
/// Gets the name of the action group.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <return>
/// the name of the action group.
/// </return>

	public static string GetName(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_name(action_group);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the group is sensitive.  The constituent actions
/// can only be logically sensitive (see gtk_action_is_sensitive()) if
/// they are sensitive (see gtk_action_get_sensitive()) and their group
/// is sensitive.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <return>
/// %TRUE if the group is sensitive.
/// </return>

	public static bool GetSensitive(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_sensitive(action_group);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the group is visible.  The constituent actions
/// can only be logically visible (see gtk_action_is_visible()) if
/// they are visible (see gtk_action_get_visible()) and their group
/// is visible.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <return>
/// %TRUE if the group is visible.
/// </return>

	public static bool GetVisible(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_visible(action_group);
	}

/// <summary>
/// <para>
/// Lists the actions in the action group.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <return>
/// an allocated list of the action objects in the action group
/// </return>

	public static MentorLake.GLib.GListHandle ListActions(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_list_actions(action_group);
	}

/// <summary>
/// <para>
/// Removes an action object from the action group.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="action">
/// an action
/// </param>

	public static T RemoveAction<T>(this T action_group, MentorLake.Gtk.GtkActionHandle action) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_remove_action(action_group, action);
		return action_group;
	}

/// <summary>
/// <para>
/// Sets the accelerator group to be used by every action in this group.
/// </para>
/// </summary>

/// <param name="action_group">
/// a #GtkActionGroup
/// </param>
/// <param name="accel_group">
/// a #GtkAccelGroup to set or %NULL
/// </param>

	public static T SetAccelGroup<T>(this T action_group, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_accel_group(action_group, accel_group);
		return action_group;
	}

/// <summary>
/// <para>
/// Changes the sensitivity of @action_group
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="sensitive">
/// new sensitivity
/// </param>

	public static T SetSensitive<T>(this T action_group, bool sensitive) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_sensitive(action_group, sensitive);
		return action_group;
	}

/// <summary>
/// <para>
/// Sets a function to be used for translating the @label and @tooltip of
/// #GtkActionEntrys added by gtk_action_group_add_actions().
/// </para>
/// <para>
/// If you’re using gettext(), it is enough to set the translation domain
/// with gtk_action_group_set_translation_domain().
/// </para>
/// </summary>

/// <param name="action_group">
/// a #GtkActionGroup
/// </param>
/// <param name="func">
/// a #GtkTranslateFunc
/// </param>
/// <param name="data">
/// data to be passed to @func and @notify
/// </param>
/// <param name="notify">
/// a #GDestroyNotify function to be called when @action_group is
///   destroyed and when the translation function is changed again
/// </param>

	public static T SetTranslateFunc<T>(this T action_group, MentorLake.Gtk.GtkTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_translate_func(action_group, func, data, notify);
		return action_group;
	}

/// <summary>
/// <para>
/// Sets the translation domain and uses g_dgettext() for translating the
/// @label and @tooltip of #GtkActionEntrys added by
/// gtk_action_group_add_actions().
/// </para>
/// <para>
/// If you’re not using gettext() for localization, see
/// gtk_action_group_set_translate_func().
/// </para>
/// </summary>

/// <param name="action_group">
/// a #GtkActionGroup
/// </param>
/// <param name="domain">
/// the translation domain to use for g_dgettext()
/// calls, or %NULL to use the domain set with textdomain()
/// </param>

	public static T SetTranslationDomain<T>(this T action_group, string domain) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_translation_domain(action_group, domain);
		return action_group;
	}

/// <summary>
/// <para>
/// Changes the visible of @action_group.
/// </para>
/// </summary>

/// <param name="action_group">
/// the action group
/// </param>
/// <param name="visible">
/// new visiblity
/// </param>

	public static T SetVisible<T>(this T action_group, bool visible) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_visible(action_group, visible);
		return action_group;
	}

/// <summary>
/// <para>
/// Translates a string using the function set with
/// gtk_action_group_set_translate_func(). This
/// is mainly intended for language bindings.
/// </para>
/// </summary>

/// <param name="action_group">
/// a #GtkActionGroup
/// </param>
/// <param name="@string">
/// a string
/// </param>
/// <return>
/// the translation of @string
/// </return>

	public static string TranslateString(this MentorLake.Gtk.GtkActionGroupHandle action_group, string @string)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_translate_string(action_group, @string);
	}

}

internal class GtkActionGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkActionGroupHandle gtk_action_group_new(string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_action_with_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string accelerator);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkActionEntry[] entries, uint n_entries, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_actions_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkActionEntry[] entries, uint n_entries, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_radio_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkRadioActionEntry[] entries, uint n_entries, int value, MentorLake.GObject.GCallback on_change, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_radio_actions_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkRadioActionEntry[] entries, uint n_entries, int value, MentorLake.GObject.GCallback on_change, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_toggle_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_toggle_actions_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_action_group_get_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))]
	internal static extern MentorLake.Gtk.GtkActionHandle gtk_action_group_get_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, string action_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_group_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_group_get_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_group_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_action_group_list_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_remove_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, bool sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_translate_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, string domain);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, bool visible);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_group_translate_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, string @string);

}
