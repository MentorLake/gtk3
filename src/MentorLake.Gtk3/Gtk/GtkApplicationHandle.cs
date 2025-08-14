namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkApplication is a class that handles many important aspects
/// of a GTK+ application in a convenient fashion, without enforcing
/// a one-size-fits-all application model.
/// </para>
/// <para>
/// Currently, GtkApplication handles GTK+ initialization, application
/// uniqueness, session management, provides some basic scriptability and
/// desktop shell integration by exporting actions and menus and manages a
/// list of toplevel windows whose life-cycle is automatically tied to the
/// life-cycle of your application.
/// </para>
/// <para>
/// While GtkApplication works fine with plain #GtkWindows, it is recommended
/// to use it together with #GtkApplicationWindow.
/// </para>
/// <para>
/// When GDK threads are enabled, GtkApplication will acquire the GDK
/// lock when invoking actions that arrive from other processes.  The GDK
/// lock is not touched for local action invocations.  In order to have
/// actions invoked in a predictable context it is therefore recommended
/// that the GDK lock be held while invoking actions locally with
/// g_action_group_activate_action().  The same applies to actions
/// associated with #GtkApplicationWindow and to the “activate” and
/// “open” #GApplication methods.
/// </para>
/// <para>
/// ## Automatic resources ## {#automatic-resources}
/// </para>
/// <para>
/// #GtkApplication will automatically load menus from the #GtkBuilder
/// resource located at "gtk/menus.ui", relative to the application's
/// resource base path (see g_application_set_resource_base_path()).  The
/// menu with the ID "app-menu" is taken as the application's app menu
/// and the menu with the ID "menubar" is taken as the application's
/// menubar.  Additional menus (most interesting submenus) can be named
/// and accessed via gtk_application_get_menu_by_id() which allows for
/// dynamic population of a part of the menu structure.
/// </para>
/// <para>
/// If the resources "gtk/menus-appmenu.ui" or "gtk/menus-traditional.ui" are
/// present then these files will be used in preference, depending on the value
/// of gtk_application_prefers_app_menu(). If the resource "gtk/menus-common.ui"
/// is present it will be loaded as well. This is useful for storing items that
/// are referenced from both "gtk/menus-appmenu.ui" and
/// "gtk/menus-traditional.ui".
/// </para>
/// <para>
/// It is also possible to provide the menus manually using
/// gtk_application_set_app_menu() and gtk_application_set_menubar().
/// </para>
/// <para>
/// #GtkApplication will also automatically setup an icon search path for
/// the default icon theme by appending "icons" to the resource base
/// path.  This allows your application to easily store its icons as
/// resources.  See gtk_icon_theme_add_resource_path() for more
/// information.
/// </para>
/// <para>
/// If there is a resource located at "gtk/help-overlay.ui" which
/// defines a #GtkShortcutsWindow with ID "help_overlay" then GtkApplication
/// associates an instance of this shortcuts window with each
/// #GtkApplicationWindow and sets up keyboard accelerators (Control-F1
/// and Control-?) to open it. To create a menu item that displays the
/// shortcuts window, associate the item with the action win.show-help-overlay.
/// </para>
/// <para>
/// ## A simple application ## {#gtkapplication}
/// </para>
/// <para>
/// [A simple example](https://gitlab.gnome.org/GNOME/gtk/-/blob/gtk-3-24/examples/bp/bloatpad.c)
/// </para>
/// <para>
/// GtkApplication optionally registers with a session manager
/// of the users session (if you set the #GtkApplication:register-session
/// property) and offers various functionality related to the session
/// life-cycle.
/// </para>
/// <para>
/// An application can block various ways to end the session with
/// the gtk_application_inhibit() function. Typical use cases for
/// this kind of inhibiting are long-running, uninterruptible operations,
/// such as burning a CD or performing a disk backup. The session
/// manager may not honor the inhibitor, but it can be expected to
/// inform the user about the negative consequences of ending the
/// session while inhibitors are present.
/// </para>
/// <para>
/// ## See Also ## {#seealso}
/// [HowDoI: Using GtkApplication](https://wiki.gnome.org/HowDoI/GtkApplication),
/// [Getting Started with GTK+: Basics](https://developer.gnome.org/gtk3/stable/gtk-getting-started.html#id-1.2.3.3)
/// </para>
/// </summary>

public class GtkApplicationHandle : GApplicationHandle, GActionGroupHandle, GActionMapHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkApplication instance.
/// </para>
/// <para>
/// When using #GtkApplication, it is not necessary to call gtk_init()
/// manually. It is called as soon as the application gets registered as
/// the primary instance.
/// </para>
/// <para>
/// Concretely, gtk_init() is called in the default handler for the
/// #GApplication::startup signal. Therefore, #GtkApplication subclasses should
/// chain up in their #GApplication::startup handler before using any GTK+ API.
/// </para>
/// <para>
/// Note that commandline arguments are not passed to gtk_init().
/// All GTK+ functionality that is available via commandline arguments
/// can also be achieved by setting suitable environment variables
/// such as `G_DEBUG`, so this should not be a big
/// problem. If you absolutely must support GTK+ commandline arguments,
/// you can explicitly call gtk_init() before creating the application
/// instance.
/// </para>
/// <para>
/// If non-%NULL, the application ID must be valid.  See
/// g_application_id_is_valid().
/// </para>
/// <para>
/// If no application ID is given then some features (most notably application
/// uniqueness) will be disabled. A null application ID is only allowed with
/// GTK+ 3.6 or later.
/// </para>
/// </summary>

/// <param name="application_id">
/// The application ID.
/// </param>
/// <param name="flags">
/// the application flags
/// </param>
/// <return>
/// a new #GtkApplication instance
/// </return>

	public static MentorLake.Gtk.GtkApplicationHandle New(string application_id, MentorLake.Gio.GApplicationFlags flags)
	{
		return GtkApplicationHandleExterns.gtk_application_new(application_id, flags);
	}

}
public static class GtkApplicationHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the session manager is about to end the session, only
/// if #GtkApplication::register-session is %TRUE. Applications can
/// connect to this signal and call gtk_application_inhibit() with
/// %GTK_APPLICATION_INHIBIT_LOGOUT to delay the end of the session
/// until state has been saved.
/// </para>
/// </summary>

	public static IObservable<GtkApplicationHandleSignalStructs.QueryEndSignal> Signal_QueryEnd(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.QueryEndSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.query_end handler = ( MentorLake.Gtk.GtkApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.QueryEndSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "query-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a #GtkWindow is added to @application through
/// gtk_application_add_window().
/// </para>
/// </summary>

	public static IObservable<GtkApplicationHandleSignalStructs.WindowAddedSignal> Signal_WindowAdded(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.WindowAddedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.window_added handler = ( MentorLake.Gtk.GtkApplicationHandle self,  MentorLake.Gtk.GtkWindowHandle window,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.WindowAddedSignal()
				{
					Self = self, Window = window, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "window-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a #GtkWindow is removed from @application,
/// either as a side-effect of being destroyed or explicitly
/// through gtk_application_remove_window().
/// </para>
/// </summary>

	public static IObservable<GtkApplicationHandleSignalStructs.WindowRemovedSignal> Signal_WindowRemoved(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.WindowRemovedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.window_removed handler = ( MentorLake.Gtk.GtkApplicationHandle self,  MentorLake.Gtk.GtkWindowHandle window,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.WindowRemovedSignal()
				{
					Self = self, Window = window, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "window-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that a new action was just added to the group.
/// </para>
/// <para>
/// This signal is emitted after the action has been added
/// and is now visible.
/// </para>
/// </summary>

	public static IObservable<GtkApplicationHandleSignalStructs.ActionAddedSignal> Signal_ActionAdded(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.ActionAddedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.action_added handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.ActionAddedSignal()
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

	public static IObservable<GtkApplicationHandleSignalStructs.ActionEnabledChangedSignal> Signal_ActionEnabledChanged(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.ActionEnabledChangedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.action_enabled_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  bool enabled,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.ActionEnabledChangedSignal()
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

	public static IObservable<GtkApplicationHandleSignalStructs.ActionRemovedSignal> Signal_ActionRemoved(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.ActionRemovedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.action_removed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.ActionRemovedSignal()
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

	public static IObservable<GtkApplicationHandleSignalStructs.ActionStateChangedSignal> Signal_ActionStateChanged(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.ActionStateChangedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.action_state_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.ActionStateChangedSignal()
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

public static class GtkApplicationHandleSignalStructs
{

public class QueryEndSignal
{

	public MentorLake.Gtk.GtkApplicationHandle Self;

	public IntPtr UserData;
}

public class WindowAddedSignal
{

	public MentorLake.Gtk.GtkApplicationHandle Self;
/// <summary>
/// <para>
/// the newly-added #GtkWindow
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWindowHandle Window;

	public IntPtr UserData;
}

public class WindowRemovedSignal
{

	public MentorLake.Gtk.GtkApplicationHandle Self;
/// <summary>
/// <para>
/// the #GtkWindow that is being removed
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWindowHandle Window;

	public IntPtr UserData;
}

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

public static class GtkApplicationHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the session manager is about to end the session, only
/// if #GtkApplication::register-session is %TRUE. Applications can
/// connect to this signal and call gtk_application_inhibit() with
/// %GTK_APPLICATION_INHIBIT_LOGOUT to delay the end of the session
/// until state has been saved.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void query_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a #GtkWindow is added to @application through
/// gtk_application_add_window().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="window">
/// the newly-added #GtkWindow
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void window_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a #GtkWindow is removed from @application,
/// either as a side-effect of being destroyed or explicitly
/// through gtk_application_remove_window().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="window">
/// the #GtkWindow that is being removed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void window_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, IntPtr user_data);


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


public static class GtkApplicationHandleExtensions
{
/// <summary>
/// <para>
/// Installs an accelerator that will cause the named action
/// to be activated when the key combination specificed by @accelerator
/// is pressed.
/// </para>
/// <para>
/// @accelerator must be a string that can be parsed by gtk_accelerator_parse(),
/// e.g. "<Primary>q" or “<Control><Alt>p”.
/// </para>
/// <para>
/// @action_name must be the name of an action as it would be used
/// in the app menu, i.e. actions that have been added to the application
/// are referred to with an “app.” prefix, and window-specific actions
/// with a “win.” prefix.
/// </para>
/// <para>
/// GtkApplication also extracts accelerators out of “accel” attributes
/// in the #GMenuModels passed to gtk_application_set_app_menu() and
/// gtk_application_set_menubar(), which is usually more convenient
/// than calling this function for each accelerator.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="accelerator">
/// accelerator string
/// </param>
/// <param name="action_name">
/// the name of the action to activate
/// </param>
/// <param name="parameter">
/// parameter to pass when activating the action,
///   or %NULL if the action does not accept an activation parameter
/// </param>

	public static T AddAccelerator<T>(this T application, string accelerator, string action_name, MentorLake.GLib.GVariantHandle parameter) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_add_accelerator(application, accelerator, action_name, parameter);
		return application;
	}

/// <summary>
/// <para>
/// Adds a window to @application.
/// </para>
/// <para>
/// This call can only happen after the @application has started;
/// typically, you should add new application windows in response
/// to the emission of the #GApplication::activate signal.
/// </para>
/// <para>
/// This call is equivalent to setting the #GtkWindow:application
/// property of @window to @application.
/// </para>
/// <para>
/// Normally, the connection between the application and the window
/// will remain until the window is destroyed, but you can explicitly
/// remove it with gtk_application_remove_window().
/// </para>
/// <para>
/// GTK+ will keep the @application running as long as it has
/// any windows.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T AddWindow<T>(this T application, MentorLake.Gtk.GtkWindowHandle window) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_add_window(application, window);
		return application;
	}

/// <summary>
/// <para>
/// Gets the accelerators that are currently associated with
/// the given action.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="detailed_action_name">
/// a detailed action name, specifying an action
///     and target to obtain accelerators for
/// </param>
/// <return>
/// accelerators for @detailed_action_name, as
///     a %NULL-terminated array. Free with g_strfreev() when no longer needed
/// </return>

	public static string[] GetAccelsForAction(this MentorLake.Gtk.GtkApplicationHandle application, string detailed_action_name)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_accels_for_action(application, detailed_action_name);
	}

/// <summary>
/// <para>
/// Returns the list of actions (possibly empty) that @accel maps to.
/// Each item in the list is a detailed action name in the usual form.
/// </para>
/// <para>
/// This might be useful to discover if an accel already exists in
/// order to prevent installation of a conflicting accelerator (from
/// an accelerator editor or a plugin system, for example). Note that
/// having more than one action per accelerator may not be a bad thing
/// and might make sense in cases where the actions never appear in the
/// same context.
/// </para>
/// <para>
/// In case there are no actions for a given accelerator, an empty array
/// is returned.  %NULL is never returned.
/// </para>
/// <para>
/// It is a programmer error to pass an invalid accelerator string.
/// If you are unsure, check it with gtk_accelerator_parse() first.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="accel">
/// an accelerator that can be parsed by gtk_accelerator_parse()
/// </param>
/// <return>
/// a %NULL-terminated array of actions for @accel
/// </return>

	public static string[] GetActionsForAccel(this MentorLake.Gtk.GtkApplicationHandle application, string accel)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_actions_for_accel(application, accel);
	}

/// <summary>
/// <para>
/// Gets the “active” window for the application.
/// </para>
/// <para>
/// The active window is the one that was most recently focused (within
/// the application).  This window may not have the focus at the moment
/// if another application has it — this is just the most
/// recently-focused window within this application.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <return>
/// the active window, or %NULL if
///   there isn't one.
/// </return>

	public static MentorLake.Gtk.GtkWindowHandle GetActiveWindow(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_active_window(application);
	}

/// <summary>
/// <para>
/// Returns the menu model that has been set with
/// gtk_application_set_app_menu().
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <return>
/// the application menu of @application
///   or %NULL if no application menu has been set.
/// </return>

	public static MentorLake.Gio.GMenuModelHandle GetAppMenu(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_app_menu(application);
	}

/// <summary>
/// <para>
/// Gets a menu from automatically loaded resources.
/// See [Automatic resources][automatic-resources]
/// for more information.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="id">
/// the id of the menu to look up
/// </param>
/// <return>
/// Gets the menu with the
///     given id from the automatically loaded resources
/// </return>

	public static MentorLake.Gio.GMenuHandle GetMenuById(this MentorLake.Gtk.GtkApplicationHandle application, string id)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_menu_by_id(application, id);
	}

/// <summary>
/// <para>
/// Returns the menu model that has been set with
/// gtk_application_set_menubar().
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <return>
/// the menubar for windows of @application
/// </return>

	public static MentorLake.Gio.GMenuModelHandle GetMenubar(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_menubar(application);
	}

/// <summary>
/// <para>
/// Returns the #GtkApplicationWindow with the given ID.
/// </para>
/// <para>
/// The ID of a #GtkApplicationWindow can be retrieved with
/// gtk_application_window_get_id().
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="id">
/// an identifier number
/// </param>
/// <return>
/// the window with ID @id, or
///   %NULL if there is no window with this ID
/// </return>

	public static MentorLake.Gtk.GtkWindowHandle GetWindowById(this MentorLake.Gtk.GtkApplicationHandle application, uint id)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_window_by_id(application, id);
	}

/// <summary>
/// <para>
/// Gets a list of the #GtkWindows associated with @application.
/// </para>
/// <para>
/// The list is sorted by most recently focused window, such that the first
/// element is the currently focused window. (Useful for choosing a parent
/// for a transient window.)
/// </para>
/// <para>
/// The list that is returned should not be modified in any way. It will
/// only remain valid until the next focus change or window creation or
/// deletion.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <return>
/// a #GList of #GtkWindow
/// </return>

	public static MentorLake.GLib.GListHandle GetWindows(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_windows(application);
	}

/// <summary>
/// <para>
/// Inform the session manager that certain types of actions should be
/// inhibited. This is not guaranteed to work on all platforms and for
/// all types of actions.
/// </para>
/// <para>
/// Applications should invoke this method when they begin an operation
/// that should not be interrupted, such as creating a CD or DVD. The
/// types of actions that may be blocked are specified by the @flags
/// parameter. When the application completes the operation it should
/// call gtk_application_uninhibit() to remove the inhibitor. Note that
/// an application can have multiple inhibitors, and all of them must
/// be individually removed. Inhibitors are also cleared when the
/// application exits.
/// </para>
/// <para>
/// Applications should not expect that they will always be able to block
/// the action. In most cases, users will be given the option to force
/// the action to take place.
/// </para>
/// <para>
/// Reasons should be short and to the point.
/// </para>
/// <para>
/// If @window is given, the session manager may point the user to
/// this window to find out more about why the action is inhibited.
/// </para>
/// </summary>

/// <param name="application">
/// the #GtkApplication
/// </param>
/// <param name="window">
/// a #GtkWindow, or %NULL
/// </param>
/// <param name="flags">
/// what types of actions should be inhibited
/// </param>
/// <param name="reason">
/// a short, human-readable string that explains
///     why these operations are inhibited
/// </param>
/// <return>
/// A non-zero cookie that is used to uniquely identify this
///     request. It should be used as an argument to gtk_application_uninhibit()
///     in order to remove the request. If the platform does not support
///     inhibiting or the request failed for some reason, 0 is returned.
/// </return>

	public static uint Inhibit(this MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gtk.GtkApplicationInhibitFlags flags, string reason)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_inhibit(application, window, flags, reason);
	}

/// <summary>
/// <para>
/// Determines if any of the actions specified in @flags are
/// currently inhibited (possibly by another application).
/// </para>
/// <para>
/// Note that this information may not be available (for example
/// when the application is running in a sandbox).
/// </para>
/// </summary>

/// <param name="application">
/// the #GtkApplication
/// </param>
/// <param name="flags">
/// what types of actions should be queried
/// </param>
/// <return>
/// %TRUE if any of the actions specified in @flags are inhibited
/// </return>

	public static bool IsInhibited(this MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkApplicationInhibitFlags flags)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_is_inhibited(application, flags);
	}

/// <summary>
/// <para>
/// Lists the detailed action names which have associated accelerators.
/// See gtk_application_set_accels_for_action().
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <return>
/// a %NULL-terminated array of strings,
///     free with g_strfreev() when done
/// </return>

	public static string[] ListActionDescriptions(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_list_action_descriptions(application);
	}

/// <summary>
/// <para>
/// Determines if the desktop environment in which the application is
/// running would prefer an application menu be shown.
/// </para>
/// <para>
/// If this function returns %TRUE then the application should call
/// gtk_application_set_app_menu() with the contents of an application
/// menu, which will be shown by the desktop environment.  If it returns
/// %FALSE then you should consider using an alternate approach, such as
/// a menubar.
/// </para>
/// <para>
/// The value returned by this function is purely advisory and you are
/// free to ignore it.  If you call gtk_application_set_app_menu() even
/// if the desktop environment doesn't support app menus, then a fallback
/// will be provided.
/// </para>
/// <para>
/// Applications are similarly free not to set an app menu even if the
/// desktop environment wants to show one.  In that case, a fallback will
/// also be created by the desktop environment (GNOME, for example, uses
/// a menu with only a "Quit" item in it).
/// </para>
/// <para>
/// The value returned by this function never changes.  Once it returns a
/// particular value, it is guaranteed to always return the same value.
/// </para>
/// <para>
/// You may only call this function after the application has been
/// registered and after the base startup handler has run.  You're most
/// likely to want to use this from your own startup handler.  It may
/// also make sense to consult this function while constructing UI (in
/// activate, open or an action activation handler) in order to determine
/// if you should show a gear menu or not.
/// </para>
/// <para>
/// This function will return %FALSE on Mac OS and a default app menu
/// will be created automatically with the "usual" contents of that menu
/// typical to most Mac OS applications.  If you call
/// gtk_application_set_app_menu() anyway, then this menu will be
/// replaced with your own.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <return>
/// %TRUE if you should set an app menu
/// </return>

	public static bool PrefersAppMenu(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_prefers_app_menu(application);
	}

/// <summary>
/// <para>
/// Removes an accelerator that has been previously added
/// with gtk_application_add_accelerator().
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="action_name">
/// the name of the action to activate
/// </param>
/// <param name="parameter">
/// parameter to pass when activating the action,
///   or %NULL if the action does not accept an activation parameter
/// </param>

	public static T RemoveAccelerator<T>(this T application, string action_name, MentorLake.GLib.GVariantHandle parameter) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_remove_accelerator(application, action_name, parameter);
		return application;
	}

/// <summary>
/// <para>
/// Remove a window from @application.
/// </para>
/// <para>
/// If @window belongs to @application then this call is equivalent to
/// setting the #GtkWindow:application property of @window to
/// %NULL.
/// </para>
/// <para>
/// The application may stop running as a result of a call to this
/// function.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T RemoveWindow<T>(this T application, MentorLake.Gtk.GtkWindowHandle window) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_remove_window(application, window);
		return application;
	}

/// <summary>
/// <para>
/// Sets zero or more keyboard accelerators that will trigger the
/// given action. The first item in @accels will be the primary
/// accelerator, which may be displayed in the UI.
/// </para>
/// <para>
/// To remove all accelerators for an action, use an empty, zero-terminated
/// array for @accels.
/// </para>
/// <para>
/// For the @detailed_action_name, see g_action_parse_detailed_name() and
/// g_action_print_detailed_name().
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="detailed_action_name">
/// a detailed action name, specifying an action
///     and target to associate accelerators with
/// </param>
/// <param name="accels">
/// a list of accelerators in the format
///     understood by gtk_accelerator_parse()
/// </param>

	public static T SetAccelsForAction<T>(this T application, string detailed_action_name, string[] accels) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_set_accels_for_action(application, detailed_action_name, accels);
		return application;
	}

/// <summary>
/// <para>
/// Sets or unsets the application menu for @application.
/// </para>
/// <para>
/// This can only be done in the primary instance of the application,
/// after it has been registered.  #GApplication::startup is a good place
/// to call this.
/// </para>
/// <para>
/// The application menu is a single menu containing items that typically
/// impact the application as a whole, rather than acting on a specific
/// window or document.  For example, you would expect to see
/// “Preferences” or “Quit” in an application menu, but not “Save” or
/// “Print”.
/// </para>
/// <para>
/// If supported, the application menu will be rendered by the desktop
/// environment.
/// </para>
/// <para>
/// Use the base #GActionMap interface to add actions, to respond to the user
/// selecting these menu items.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="app_menu">
/// a #GMenuModel, or %NULL
/// </param>

	public static T SetAppMenu<T>(this T application, MentorLake.Gio.GMenuModelHandle app_menu) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_set_app_menu(application, app_menu);
		return application;
	}

/// <summary>
/// <para>
/// Sets or unsets the menubar for windows of @application.
/// </para>
/// <para>
/// This is a menubar in the traditional sense.
/// </para>
/// <para>
/// This can only be done in the primary instance of the application,
/// after it has been registered.  #GApplication::startup is a good place
/// to call this.
/// </para>
/// <para>
/// Depending on the desktop environment, this may appear at the top of
/// each window, or at the top of the screen.  In some environments, if
/// both the application menu and the menubar are set, the application
/// menu will be presented as if it were the first item of the menubar.
/// Other environments treat the two as completely separate — for example,
/// the application menu may be rendered by the desktop shell while the
/// menubar (if set) remains in each individual window.
/// </para>
/// <para>
/// Use the base #GActionMap interface to add actions, to respond to the
/// user selecting these menu items.
/// </para>
/// </summary>

/// <param name="application">
/// a #GtkApplication
/// </param>
/// <param name="menubar">
/// a #GMenuModel, or %NULL
/// </param>

	public static T SetMenubar<T>(this T application, MentorLake.Gio.GMenuModelHandle menubar) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_set_menubar(application, menubar);
		return application;
	}

/// <summary>
/// <para>
/// Removes an inhibitor that has been established with gtk_application_inhibit().
/// Inhibitors are also cleared when the application exits.
/// </para>
/// </summary>

/// <param name="application">
/// the #GtkApplication
/// </param>
/// <param name="cookie">
/// a cookie that was returned by gtk_application_inhibit()
/// </param>

	public static T Uninhibit<T>(this T application, uint cookie) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_uninhibit(application, cookie);
		return application;
	}

}

internal class GtkApplicationHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))]
	internal static extern MentorLake.Gtk.GtkApplicationHandle gtk_application_new(string application_id, MentorLake.Gio.GApplicationFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_add_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string accelerator, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_add_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_application_get_accels_for_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string detailed_action_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_application_get_actions_for_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string accel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_application_get_active_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle gtk_application_get_app_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))]
	internal static extern MentorLake.Gio.GMenuHandle gtk_application_get_menu_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle gtk_application_get_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_application_get_window_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, uint id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_application_get_windows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_application_inhibit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gtk.GtkApplicationInhibitFlags flags, string reason);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_application_is_inhibited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkApplicationInhibitFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_application_list_action_descriptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_application_prefers_app_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_remove_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_remove_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_set_accels_for_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string detailed_action_name, string[] accels);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_set_app_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle app_menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_set_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle menubar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_uninhibit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, uint cookie);

}
