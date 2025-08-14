namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkApplicationWindow is a #GtkWindow subclass that offers some
/// extra functionality for better integration with #GtkApplication
/// features.  Notably, it can handle both the application menu as well
/// as the menubar. See gtk_application_set_app_menu() and
/// gtk_application_set_menubar().
/// </para>
/// <para>
/// This class implements the #GActionGroup and #GActionMap interfaces,
/// to let you add window-specific actions that will be exported by the
/// associated #GtkApplication, together with its application-wide
/// actions.  Window-specific actions are prefixed with the “win.”
/// prefix and application-wide actions are prefixed with the “app.”
/// prefix.  Actions must be addressed with the prefixed name when
/// referring to them from a #GMenuModel.
/// </para>
/// <para>
/// Note that widgets that are placed inside a #GtkApplicationWindow
/// can also activate these actions, if they implement the
/// #GtkActionable interface.
/// </para>
/// <para>
/// As with #GtkApplication, the GDK lock will be acquired when
/// processing actions arriving from other processes and should therefore
/// be held when activating actions locally (if GDK threads are enabled).
/// </para>
/// <para>
/// The settings #GtkSettings:gtk-shell-shows-app-menu and
/// #GtkSettings:gtk-shell-shows-menubar tell GTK+ whether the
/// desktop environment is showing the application menu and menubar
/// models outside the application as part of the desktop shell.
/// For instance, on OS X, both menus will be displayed remotely;
/// on Windows neither will be. gnome-shell (starting with version 3.4)
/// will display the application menu, but not the menubar.
/// </para>
/// <para>
/// If the desktop environment does not display the menubar, then
/// #GtkApplicationWindow will automatically show a #GtkMenuBar for it.
/// This behaviour can be overridden with the #GtkApplicationWindow:show-menubar
/// property. If the desktop environment does not display the application
/// menu, then it will automatically be included in the menubar or in the
/// windows client-side decorations.
/// </para>
/// <para>
/// ## A GtkApplicationWindow with a menubar
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GtkApplication *app = gtk_application_new ("org.gtk.test", 0);
/// </para>
/// <para>
/// GtkBuilder *builder = gtk_builder_new_from_string (
///     "<interface>"
///     "  <menu id='menubar'>"
///     "    <submenu label='_Edit'>"
///     "      <item label='_Copy' action='win.copy'/>"
///     "      <item label='_Paste' action='win.paste'/>"
///     "    </submenu>"
///     "  </menu>"
///     "</interface>",
///     -1);
/// </para>
/// <para>
/// GMenuModel *menubar = G_MENU_MODEL (gtk_builder_get_object (builder,
///                                                             "menubar"));
/// gtk_application_set_menubar (GTK_APPLICATION (app), menubar);
/// g_object_unref (builder);
/// </para>
/// <para>
/// // ...
/// </para>
/// <para>
/// GtkWidget *window = gtk_application_window_new (app);
/// ]|
/// </para>
/// <para>
/// ## Handling fallback yourself
/// </para>
/// <para>
/// [A simple example](https://git.gnome.org/browse/gtk+/tree/examples/sunny.c)
/// </para>
/// <para>
/// The XML format understood by #GtkBuilder for #GMenuModel consists
/// of a toplevel `<menu>` element, which contains one or more `<item>`
/// elements. Each `<item>` element contains `<attribute>` and `<link>`
/// elements with a mandatory name attribute. `<link>` elements have the
/// same content model as `<menu>`. Instead of `<link name="submenu>` or
/// `<link name="section">`, you can use `<submenu>` or `<section>`
/// elements.
/// </para>
/// <para>
/// Attribute values can be translated using gettext, like other #GtkBuilder
/// content. `<attribute>` elements can be marked for translation with a
/// `translatable="yes"` attribute. It is also possible to specify message
/// context and translator comments, using the context and comments attributes.
/// To make use of this, the #GtkBuilder must have been given the gettext
/// domain to use.
/// </para>
/// <para>
/// The following attributes are used when constructing menu items:
/// - "label": a user-visible string to display
/// - "action": the prefixed name of the action to trigger
/// - "target": the parameter to use when activating the action
/// - "icon" and "verb-icon": names of icons that may be displayed
/// - "submenu-action": name of an action that may be used to determine
///      if a submenu can be opened
/// - "hidden-when": a string used to determine when the item will be hidden.
///      Possible values include "action-disabled", "action-missing", "macos-menubar".
/// </para>
/// <para>
/// The following attributes are used when constructing sections:
/// - "label": a user-visible string to use as section heading
/// - "display-hint": a string used to determine special formatting for the section.
///     Possible values include "horizontal-buttons".
/// - "text-direction": a string used to determine the #GtkTextDirection to use
///     when "display-hint" is set to "horizontal-buttons". Possible values
///     include "rtl", "ltr", and "none".
/// </para>
/// <para>
/// The following attributes are used when constructing submenus:
/// - "label": a user-visible string to display
/// - "icon": icon name to display
/// </para>
/// </summary>

public class GtkApplicationWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GActionGroupHandle, GActionMapHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkApplicationWindow.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <return>
/// a newly created #GtkApplicationWindow
/// </return>

	public static MentorLake.Gtk.GtkApplicationWindowHandle New(MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationWindowHandleExterns.gtk_application_window_new(application);
	}

}
public static class GtkApplicationWindowHandleSignalExtensions
{
/// <summary>
/// <para>
/// Signals that a new action was just added to the group.
/// </para>
/// <para>
/// This signal is emitted after the action has been added
/// and is now visible.
/// </para>
/// </summary>

	public static IObservable<GtkApplicationWindowHandleSignalStructs.ActionAddedSignal> Signal_ActionAdded(this GtkApplicationWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationWindowHandleSignalStructs.ActionAddedSignal> obs) =>
		{
			GtkApplicationWindowHandleSignalDelegates.action_added handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationWindowHandleSignalStructs.ActionAddedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that the enabled status of the named action has changed.
/// </para>
/// </summary>

	public static IObservable<GtkApplicationWindowHandleSignalStructs.ActionEnabledChangedSignal> Signal_ActionEnabledChanged(this GtkApplicationWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationWindowHandleSignalStructs.ActionEnabledChangedSignal> obs) =>
		{
			GtkApplicationWindowHandleSignalDelegates.action_enabled_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  bool enabled,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationWindowHandleSignalStructs.ActionEnabledChangedSignal()
				{
					Self = self, ActionName = action_name, Enabled = enabled, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-enabled-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that an action is just about to be removed from the group.
/// </para>
/// <para>
/// This signal is emitted before the action is removed, so the action
/// is still visible and can be queried from the signal handler.
/// </para>
/// </summary>

	public static IObservable<GtkApplicationWindowHandleSignalStructs.ActionRemovedSignal> Signal_ActionRemoved(this GtkApplicationWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationWindowHandleSignalStructs.ActionRemovedSignal> obs) =>
		{
			GtkApplicationWindowHandleSignalDelegates.action_removed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationWindowHandleSignalStructs.ActionRemovedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that the state of the named action has changed.
/// </para>
/// </summary>

	public static IObservable<GtkApplicationWindowHandleSignalStructs.ActionStateChangedSignal> Signal_ActionStateChanged(this GtkApplicationWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationWindowHandleSignalStructs.ActionStateChangedSignal> obs) =>
		{
			GtkApplicationWindowHandleSignalDelegates.action_state_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationWindowHandleSignalStructs.ActionStateChangedSignal()
				{
					Self = self, ActionName = action_name, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkApplicationWindowHandleSignalStructs
{

public class ActionAddedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;

	public IntPtr UserData;
}

public class ActionEnabledChangedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;
/// <summary>
/// <para>
/// whether the action is enabled
/// </para>
/// </summary>

	public bool Enabled;

	public IntPtr UserData;
}

public class ActionRemovedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;

	public IntPtr UserData;
}

public class ActionStateChangedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;
/// <summary>
/// <para>
/// the new value of the state
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle Value;

	public IntPtr UserData;
}
}

public static class GtkApplicationWindowHandleSignalDelegates
{

/// <summary>
/// <para>
/// Signals that a new action was just added to the group.
/// </para>
/// <para>
/// This signal is emitted after the action has been added
/// and is now visible.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that the enabled status of the named action has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="enabled">
/// whether the action is enabled
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, bool enabled, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that an action is just about to be removed from the group.
/// </para>
/// <para>
/// This signal is emitted before the action is removed, so the action
/// is still visible and can be queried from the signal handler.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that the state of the named action has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="value">
/// the new value of the state
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr user_data);

}


public static class GtkApplicationWindowHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GtkShortcutsWindow that has been set up with
/// a prior call to gtk_application_window_set_help_overlay().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkApplicationWindow
/// </param>
/// <return>
/// the help overlay associated with @window, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkShortcutsWindowHandle GetHelpOverlay(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkApplicationWindowHandle)");
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_help_overlay(window);
	}

/// <summary>
/// <para>
/// Returns the unique ID of the window. If the window has not yet been added to
/// a #GtkApplication, returns `0`.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkApplicationWindow
/// </param>
/// <return>
/// the unique ID for @window, or `0` if the window
///   has not yet been added to a #GtkApplication
/// </return>

	public static uint GetId(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkApplicationWindowHandle)");
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_id(window);
	}

/// <summary>
/// <para>
/// Returns whether the window will display a menubar for the app menu
/// and menubar as needed.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkApplicationWindow
/// </param>
/// <return>
/// %TRUE if @window will display a menubar when needed
/// </return>

	public static bool GetShowMenubar(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkApplicationWindowHandle)");
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_show_menubar(window);
	}

/// <summary>
/// <para>
/// Associates a shortcuts window with the application window, and
/// sets up an action with the name win.show-help-overlay to present
/// it.
/// </para>
/// <para>
/// @window takes resposibility for destroying @help_overlay.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkApplicationWindow
/// </param>
/// <param name="help_overlay">
/// a #GtkShortcutsWindow
/// </param>

	public static T SetHelpOverlay<T>(this T window, MentorLake.Gtk.GtkShortcutsWindowHandle help_overlay) where T : GtkApplicationWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkApplicationWindowHandle)");
		GtkApplicationWindowHandleExterns.gtk_application_window_set_help_overlay(window, help_overlay);
		return window;
	}

/// <summary>
/// <para>
/// Sets whether the window will display a menubar for the app menu
/// and menubar as needed.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkApplicationWindow
/// </param>
/// <param name="show_menubar">
/// whether to show a menubar when needed
/// </param>

	public static T SetShowMenubar<T>(this T window, bool show_menubar) where T : GtkApplicationWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkApplicationWindowHandle)");
		GtkApplicationWindowHandleExterns.gtk_application_window_set_show_menubar(window, show_menubar);
		return window;
	}

}

internal class GtkApplicationWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkApplicationWindowHandle gtk_application_window_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkShortcutsWindowHandle gtk_application_window_get_help_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_application_window_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_application_window_get_show_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_window_set_help_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsWindowHandle>))] MentorLake.Gtk.GtkShortcutsWindowHandle help_overlay);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_window_set_show_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window, bool show_menubar);

}
