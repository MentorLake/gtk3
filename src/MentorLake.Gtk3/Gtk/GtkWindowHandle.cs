namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkWindow is a toplevel window which can contain other widgets.
/// Windows normally have decorations that are under the control
/// of the windowing system and allow the user to manipulate the window
/// (resize it, move it, close it,...).
/// </para>
/// <para>
/// # GtkWindow as GtkBuildable
/// </para>
/// <para>
/// The GtkWindow implementation of the #GtkBuildable interface supports a
/// custom `&amp;lt;accel-groups&amp;gt;` element, which supports any number of `&amp;lt;group&amp;gt;`
/// elements representing the #GtkAccelGroup objects you want to add to
/// your window (synonymous with gtk_window_add_accel_group().
/// </para>
/// <para>
/// It also supports the `&amp;lt;initial-focus&amp;gt;` element, whose name property names
/// the widget to receive the focus when the window is mapped.
/// </para>
/// <para>
/// An example of a UI definition fragment with accel groups:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkWindow&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkWindow&quot;&amp;gt;
///   &amp;lt;accel-groups&amp;gt;
///     &amp;lt;group name=&quot;accelgroup1&quot;/&amp;gt;
///   &amp;lt;/accel-groups&amp;gt;
///   &amp;lt;initial-focus name=&quot;thunderclap&quot;/&amp;gt;
/// &amp;lt;/object&amp;gt;
/// 
/// ...
/// 
/// &amp;lt;object class=&quot;GtkAccelGroup&quot; id=&quot;accelgroup1&quot;/&amp;gt;
/// </code>
/// <para>
/// The GtkWindow implementation of the #GtkBuildable interface supports
/// setting a child as the titlebar by specifying “titlebar” as the “type”
/// attribute of a `&amp;lt;child&amp;gt;` element.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// window.background
/// window.background
/// ├── decoration
/// ├── &amp;lt;titlebar child&amp;gt;.titlebar [.default-decoration]
/// ╰── &amp;lt;child&amp;gt;
/// </code>
/// <para>
/// GtkWindow has a main CSS node with name window and style class .background,
/// and a subnode with name decoration.
/// </para>
/// <para>
/// Style classes that are typically used with the main CSS node are .csd (when
/// client-side decorations are in use), .solid-csd (for client-side decorations
/// without invisible borders), .ssd (used by mutter when rendering server-side
/// decorations). GtkWindow also represents window states with the following
/// style classes on the main node: .tiled, .maximized, .fullscreen. Specialized
/// types of window often add their own discriminating style classes, such as
/// .popup or .tooltip.
/// </para>
/// <para>
/// GtkWindow adds the .titlebar and .default-decoration style classes to the
/// widget that is added as a titlebar child.
/// </para>
/// </summary>

public class GtkWindowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkWindow, which is a toplevel window that can
/// contain other widgets. Nearly always, the type of the window should
/// be #GTK_WINDOW_TOPLEVEL. If you’re implementing something like a
/// popup menu from scratch (which is a bad idea, just use #GtkMenu),
/// you might use #GTK_WINDOW_POPUP. #GTK_WINDOW_POPUP is not for
/// dialogs, though in some other toolkits dialogs are called “popups”.
/// In GTK+, #GTK_WINDOW_POPUP means a pop-up menu or pop-up tooltip.
/// On X11, popup windows are not controlled by the
/// [window manager][gtk-X11-arch].
/// </para>
/// <para>
/// If you simply want an undecorated window (no window borders), use
/// gtk_window_set_decorated(), don’t use #GTK_WINDOW_POPUP.
/// </para>
/// <para>
/// All top-level windows created by gtk_window_new() are stored in
/// an internal top-level window list.  This list can be obtained from
/// gtk_window_list_toplevels().  Due to Gtk+ keeping a reference to
/// the window internally, gtk_window_new() does not return a reference
/// to the caller.
/// </para>
/// <para>
/// To delete a #GtkWindow, call gtk_widget_destroy().
/// </para>
/// </summary>

/// <param name="type">
/// type of window
/// </param>
/// <return>
/// a new #GtkWindow.
/// </return>

	public static MentorLake.Gtk.GtkWindowHandle New(MentorLake.Gtk.GtkWindowType type)
	{
		return GtkWindowHandleExterns.gtk_window_new(type);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_default_icon_list().
/// The list is a copy and should be freed with g_list_free(),
/// but the pixbufs in the list have not had their reference count
/// incremented.
/// </para>
/// </summary>

/// <return>
/// copy of default icon list
/// </return>

	public static MentorLake.GLib.GListHandle GetDefaultIconList()
	{
		return GtkWindowHandleExterns.gtk_window_get_default_icon_list();
	}

/// <summary>
/// <para>
/// Returns the fallback icon name for windows that has been set
/// with gtk_window_set_default_icon_name(). The returned
/// string is owned by GTK+ and should not be modified. It
/// is only valid until the next call to
/// gtk_window_set_default_icon_name().
/// </para>
/// </summary>

/// <return>
/// the fallback icon name for windows
/// </return>

	public static string GetDefaultIconName()
	{
		return GtkWindowHandleExterns.gtk_window_get_default_icon_name();
	}

/// <summary>
/// <para>
/// Returns a list of all existing toplevel windows. The widgets
/// in the list are not individually referenced. If you want
/// to iterate through the list and perform actions involving
/// callbacks that might destroy the widgets, you must call
/// `g_list_foreach (result, (GFunc)g_object_ref, NULL)` first, and
/// then unref all the widgets afterwards.
/// </para>
/// </summary>

/// <return>
/// list of toplevel widgets
/// </return>

	public static MentorLake.GLib.GListHandle ListToplevels()
	{
		return GtkWindowHandleExterns.gtk_window_list_toplevels();
	}

/// <summary>
/// <para>
/// By default, after showing the first #GtkWindow, GTK+ calls
/// gdk_notify_startup_complete().  Call this function to disable
/// the automatic startup notification. You might do this if your
/// first window is a splash screen, and you want to delay notification
/// until after your real main window has been shown, for example.
/// </para>
/// <para>
/// In that example, you would disable startup notification
/// temporarily, show your splash screen, then re-enable it so that
/// showing the main window would automatically result in notification.
/// </para>
/// </summary>

/// <param name="setting">
/// %TRUE to automatically do startup notification
/// </param>

	public static void SetAutoStartupNotification(bool setting)
	{
		GtkWindowHandleExterns.gtk_window_set_auto_startup_notification(setting);
	}

/// <summary>
/// <para>
/// Sets an icon to be used as fallback for windows that haven&apos;t
/// had gtk_window_set_icon() called on them from a pixbuf.
/// </para>
/// </summary>

/// <param name="icon">
/// the icon
/// </param>

	public static void SetDefaultIcon(MentorLake.GdkPixbuf.GdkPixbufHandle icon)
	{
		GtkWindowHandleExterns.gtk_window_set_default_icon(icon);
	}

/// <summary>
/// <para>
/// Sets an icon to be used as fallback for windows that haven&apos;t
/// had gtk_window_set_icon_list() called on them from a file
/// on disk. Warns on failure if @err is %NULL.
/// </para>
/// </summary>

/// <param name="filename">
/// location of icon file
/// </param>
/// <return>
/// %TRUE if setting the icon succeeded.
/// </return>

	public static bool SetDefaultIconFromFile(string filename)
	{
		var externCallResult = GtkWindowHandleExterns.gtk_window_set_default_icon_from_file(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets an icon list to be used as fallback for windows that haven&apos;t
/// had gtk_window_set_icon_list() called on them to set up a
/// window-specific icon list. This function allows you to set up the
/// icon for all windows in your app at once.
/// </para>
/// <para>
/// See gtk_window_set_icon_list() for more details.
/// </para>
/// </summary>

/// <param name="list">
/// a list of #GdkPixbuf
/// </param>

	public static void SetDefaultIconList(MentorLake.GLib.GListHandle list)
	{
		GtkWindowHandleExterns.gtk_window_set_default_icon_list(list);
	}

/// <summary>
/// <para>
/// Sets an icon to be used as fallback for windows that haven&apos;t
/// had gtk_window_set_icon_list() called on them from a named
/// themed icon, see gtk_window_set_icon_name().
/// </para>
/// </summary>

/// <param name="name">
/// the name of the themed icon
/// </param>

	public static void SetDefaultIconName(string name)
	{
		GtkWindowHandleExterns.gtk_window_set_default_icon_name(name);
	}

/// <summary>
/// <para>
/// Opens or closes the [interactive debugger][interactive-debugging],
/// which offers access to the widget hierarchy of the application
/// and to useful debugging tools.
/// </para>
/// </summary>

/// <param name="enable">
/// %TRUE to enable interactive debugging
/// </param>

	public static void SetInteractiveDebugging(bool enable)
	{
		GtkWindowHandleExterns.gtk_window_set_interactive_debugging(enable);
	}

}
public static class GtkWindowHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::activate-default signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates the default widget
/// of @window.
/// </para>
/// </summary>

	public static IObservable<GtkWindowHandleSignalStructs.ActivateDefaultSignal> Signal_ActivateDefault(this GtkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowHandleSignalStructs.ActivateDefaultSignal> obs) =>
		{
			GtkWindowHandleSignalDelegates.activate_default handler = ( MentorLake.Gtk.GtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowHandleSignalStructs.ActivateDefaultSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-default", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::activate-focus signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates the currently
/// focused widget of @window.
/// </para>
/// </summary>

	public static IObservable<GtkWindowHandleSignalStructs.ActivateFocusSignal> Signal_ActivateFocus(this GtkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowHandleSignalStructs.ActivateFocusSignal> obs) =>
		{
			GtkWindowHandleSignalDelegates.activate_focus handler = ( MentorLake.Gtk.GtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowHandleSignalStructs.ActivateFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::enable-debugging signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user enables or disables interactive
/// debugging. When @toggle is %TRUE, interactive debugging is toggled
/// on or off, when it is %FALSE, the debugger will be pointed at the
/// widget under the pointer.
/// </para>
/// <para>
/// The default bindings for this signal are Ctrl-Shift-I
/// and Ctrl-Shift-D.
/// </para>
/// </summary>

	public static IObservable<GtkWindowHandleSignalStructs.EnableDebuggingSignal> Signal_EnableDebugging(this GtkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowHandleSignalStructs.EnableDebuggingSignal> obs) =>
		{
			GtkWindowHandleSignalDelegates.enable_debugging handler = ( MentorLake.Gtk.GtkWindowHandle self,  bool toggle,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowHandleSignalStructs.EnableDebuggingSignal()
				{
					Self = self, Toggle = toggle, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "enable-debugging", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::keys-changed signal gets emitted when the set of accelerators
/// or mnemonics that are associated with @window changes.
/// </para>
/// </summary>

	public static IObservable<GtkWindowHandleSignalStructs.KeysChangedSignal> Signal_KeysChanged(this GtkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowHandleSignalStructs.KeysChangedSignal> obs) =>
		{
			GtkWindowHandleSignalDelegates.keys_changed handler = ( MentorLake.Gtk.GtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowHandleSignalStructs.KeysChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "keys-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted whenever the currently focused widget in
/// this window changes.
/// </para>
/// </summary>

	public static IObservable<GtkWindowHandleSignalStructs.SetFocusSignal> Signal_SetFocus(this GtkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowHandleSignalStructs.SetFocusSignal> obs) =>
		{
			GtkWindowHandleSignalDelegates.set_focus handler = ( MentorLake.Gtk.GtkWindowHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowHandleSignalStructs.SetFocusSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "set-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkWindowHandleSignalStructs
{

public class ActivateDefaultSignal
{

	public MentorLake.Gtk.GtkWindowHandle Self;

	public IntPtr UserData;
}

public class ActivateFocusSignal
{

	public MentorLake.Gtk.GtkWindowHandle Self;

	public IntPtr UserData;
}

public class EnableDebuggingSignal
{

	public MentorLake.Gtk.GtkWindowHandle Self;
/// <summary>
/// <para>
/// toggle the debugger
/// </para>
/// </summary>

	public bool Toggle;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the key binding was handled
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class KeysChangedSignal
{

	public MentorLake.Gtk.GtkWindowHandle Self;

	public IntPtr UserData;
}

public class SetFocusSignal
{

	public MentorLake.Gtk.GtkWindowHandle Self;
/// <summary>
/// <para>
/// the newly focused widget (or %NULL for no focus)
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Widget;

	public IntPtr UserData;
}
}

public static class GtkWindowHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::activate-default signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates the default widget
/// of @window.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::activate-focus signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates the currently
/// focused widget of @window.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::enable-debugging signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user enables or disables interactive
/// debugging. When @toggle is %TRUE, interactive debugging is toggled
/// on or off, when it is %FALSE, the debugger will be pointed at the
/// widget under the pointer.
/// </para>
/// <para>
/// The default bindings for this signal are Ctrl-Shift-I
/// and Ctrl-Shift-D.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="toggle">
/// toggle the debugger
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the key binding was handled
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool enable_debugging([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, bool toggle, IntPtr user_data);


/// <summary>
/// <para>
/// The ::keys-changed signal gets emitted when the set of accelerators
/// or mnemonics that are associated with @window changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void keys_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever the currently focused widget in
/// this window changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="widget">
/// the newly focused widget (or %NULL for no focus)
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void set_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);

}


public static class GtkWindowHandleExtensions
{
/// <summary>
/// <para>
/// Activates the default widget for the window, unless the current
/// focused widget has been configured to receive the default action
/// (see gtk_widget_set_receives_default()), in which case the
/// focused widget is activated.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if a widget got activated.
/// </return>

	public static bool ActivateDefault(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_activate_default(window);
	}

/// <summary>
/// <para>
/// Activates the current focused widget within the window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if a widget got activated.
/// </return>

	public static bool ActivateFocus(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_activate_focus(window);
	}

/// <summary>
/// <para>
/// Activates mnemonics and accelerators for this #GtkWindow. This is normally
/// called by the default ::key_press_event handler for toplevel windows,
/// however in some cases it may be useful to call this directly when
/// overriding the standard key handling for a toplevel window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="@event">
/// a #GdkEventKey
/// </param>
/// <return>
/// %TRUE if a mnemonic or accelerator was found and activated.
/// </return>

	public static bool ActivateKey(this MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_activate_key(window, @event);
	}

/// <summary>
/// <para>
/// Associate @accel_group with @window, such that calling
/// gtk_accel_groups_activate() on @window will activate accelerators
/// in @accel_group.
/// </para>
/// </summary>

/// <param name="window">
/// window to attach accelerator group to
/// </param>
/// <param name="accel_group">
/// a #GtkAccelGroup
/// </param>

	public static T AddAccelGroup<T>(this T window, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_add_accel_group(window, accel_group);
		return window;
	}

/// <summary>
/// <para>
/// Adds a mnemonic to this window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="keyval">
/// the mnemonic
/// </param>
/// <param name="target">
/// the widget that gets activated by the mnemonic
/// </param>

	public static T AddMnemonic<T>(this T window, uint keyval, MentorLake.Gtk.GtkWidgetHandle target) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_add_mnemonic(window, keyval, target);
		return window;
	}

/// <summary>
/// <para>
/// Starts moving a window. This function is used if an application has
/// window movement grips. When GDK can support it, the window movement
/// will be done using the standard mechanism for the
/// [window manager][gtk-X11-arch] or windowing
/// system. Otherwise, GDK will try to emulate window movement,
/// potentially not all that well, depending on the windowing system.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="button">
/// mouse button that initiated the drag
/// </param>
/// <param name="root_x">
/// X position where the user clicked to initiate the drag, in root window coordinates
/// </param>
/// <param name="root_y">
/// Y position where the user clicked to initiate the drag
/// </param>
/// <param name="timestamp">
/// timestamp from the click event that initiated the drag
/// </param>

	public static T BeginMoveDrag<T>(this T window, int button, int root_x, int root_y, uint timestamp) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_begin_move_drag(window, button, root_x, root_y, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// Starts resizing a window. This function is used if an application
/// has window resizing controls. When GDK can support it, the resize
/// will be done using the standard mechanism for the
/// [window manager][gtk-X11-arch] or windowing
/// system. Otherwise, GDK will try to emulate window resizing,
/// potentially not all that well, depending on the windowing system.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="edge">
/// position of the resize control
/// </param>
/// <param name="button">
/// mouse button that initiated the drag
/// </param>
/// <param name="root_x">
/// X position where the user clicked to initiate the drag, in root window coordinates
/// </param>
/// <param name="root_y">
/// Y position where the user clicked to initiate the drag
/// </param>
/// <param name="timestamp">
/// timestamp from the click event that initiated the drag
/// </param>

	public static T BeginResizeDrag<T>(this T window, MentorLake.Gdk.GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_begin_resize_drag(window, edge, button, root_x, root_y, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// Requests that the window is closed, similar to what happens
/// when a window manager close button is clicked.
/// </para>
/// <para>
/// This function can be used with close buttons in custom
/// titlebars.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Close<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_close(window);
		return window;
	}

/// <summary>
/// <para>
/// Asks to deiconify (i.e. unminimize) the specified @window. Note
/// that you shouldn’t assume the window is definitely deiconified
/// afterward, because other entities (e.g. the user or
/// [window manager][gtk-X11-arch])) could iconify it
/// again before your code which assumes deiconification gets to run.
/// </para>
/// <para>
/// You can track iconification via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Deiconify<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_deiconify(window);
		return window;
	}

/// <summary>
/// <para>
/// Asks to place @window in the fullscreen state. Note that you
/// shouldn’t assume the window is definitely full screen afterward,
/// because other entities (e.g. the user or
/// [window manager][gtk-X11-arch]) could unfullscreen it
/// again, and not all window managers honor requests to fullscreen
/// windows. But normally the window will end up fullscreen. Just
/// don’t write code that crashes if not.
/// </para>
/// <para>
/// You can track the fullscreen state via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Fullscreen<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_fullscreen(window);
		return window;
	}

/// <summary>
/// <para>
/// Asks to place @window in the fullscreen state. Note that you shouldn&apos;t assume
/// the window is definitely full screen afterward.
/// </para>
/// <para>
/// You can track the fullscreen state via the &quot;window-state-event&quot; signal
/// on #GtkWidget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="screen">
/// a #GdkScreen to draw to
/// </param>
/// <param name="monitor">
/// which monitor to go fullscreen on
/// </param>

	public static T FullscreenOnMonitor<T>(this T window, MentorLake.Gdk.GdkScreenHandle screen, int monitor) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_fullscreen_on_monitor(window, screen, monitor);
		return window;
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_accept_focus().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if window should receive the input focus
/// </return>

	public static bool GetAcceptFocus(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_accept_focus(window);
	}

/// <summary>
/// <para>
/// Gets the #GtkApplication associated with the window (if any).
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// a #GtkApplication, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkApplicationHandle GetApplication(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_application(window);
	}

/// <summary>
/// <para>
/// Fetches the attach widget for this window. See
/// gtk_window_set_attached_to().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the widget where the window
/// is attached, or %NULL if the window is not attached to any widget.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetAttachedTo(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_attached_to(window);
	}

/// <summary>
/// <para>
/// Returns whether the window has been set to have decorations
/// such as a title bar via gtk_window_set_decorated().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the window has been set to have decorations
/// </return>

	public static bool GetDecorated(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_decorated(window);
	}

/// <summary>
/// <para>
/// Gets the default size of the window. A value of -1 for the width or
/// height indicates that a default size has not been explicitly set
/// for that dimension, so the “natural” size of the window will be
/// used.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="width">
/// location to store the default width, or %NULL
/// </param>
/// <param name="height">
/// location to store the default height, or %NULL
/// </param>

	public static T GetDefaultSize<T>(this T window, out int width, out int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_get_default_size(window, out width, out height);
		return window;
	}

/// <summary>
/// <para>
/// Returns the default widget for @window. See
/// gtk_window_set_default() for more details.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the default widget, or %NULL
/// if there is none.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetDefaultWidget(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_default_widget(window);
	}

/// <summary>
/// <para>
/// Returns whether the window has been set to have a close button
/// via gtk_window_set_deletable().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the window has been set to have a close button
/// </return>

	public static bool GetDeletable(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_deletable(window);
	}

/// <summary>
/// <para>
/// Returns whether the window will be destroyed with its transient parent. See
/// gtk_window_set_destroy_with_parent ().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the window will be destroyed with its transient parent.
/// </return>

	public static bool GetDestroyWithParent(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_destroy_with_parent(window);
	}

/// <summary>
/// <para>
/// Retrieves the current focused widget within the window.
/// Note that this is the widget that would have the focus
/// if the toplevel window focused; if the toplevel window
/// is not focused then  `gtk_widget_has_focus (widget)` will
/// not be %TRUE for the widget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the currently focused widget,
/// or %NULL if there is none.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetFocus(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_focus(window);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_focus_on_map().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if window should receive the input focus when
/// mapped.
/// </return>

	public static bool GetFocusOnMap(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_focus_on_map(window);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWindow:focus-visible property.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if “focus rectangles” are supposed to be visible
///     in this window.
/// </return>

	public static bool GetFocusVisible(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_focus_visible(window);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_gravity().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// window gravity
/// </return>

	public static MentorLake.Gdk.GdkGravity GetGravity(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_gravity(window);
	}

/// <summary>
/// <para>
/// Returns the group for @window or the default group, if
/// @window is %NULL or if @window does not have an explicit
/// window group.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow, or %NULL
/// </param>
/// <return>
/// the #GtkWindowGroup for a window or the default group
/// </return>

	public static MentorLake.Gtk.GtkWindowGroupHandle GetGroup(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_group(window);
	}

/// <summary>
/// <para>
/// Determines whether the window may have a resize grip.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the window has a resize grip
/// </return>

	public static bool GetHasResizeGrip(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_has_resize_grip(window);
	}

/// <summary>
/// <para>
/// Returns whether the window has requested to have its titlebar hidden
/// when maximized. See gtk_window_set_hide_titlebar_when_maximized ().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the window has requested to have its titlebar
///               hidden when maximized
/// </return>

	public static bool GetHideTitlebarWhenMaximized(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_hide_titlebar_when_maximized(window);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_icon() (or if you&apos;ve
/// called gtk_window_set_icon_list(), gets the first icon in
/// the icon list).
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// icon for window or %NULL if none
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetIcon(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_icon(window);
	}

/// <summary>
/// <para>
/// Retrieves the list of icons set by gtk_window_set_icon_list().
/// The list is copied, but the reference count on each
/// member won’t be incremented.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// copy of window’s icon list
/// </return>

	public static MentorLake.GLib.GListHandle GetIconList(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_icon_list(window);
	}

/// <summary>
/// <para>
/// Returns the name of the themed icon for the window,
/// see gtk_window_set_icon_name().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the icon name or %NULL if the window has
/// no themed icon
/// </return>

	public static string GetIconName(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_icon_name(window);
	}

/// <summary>
/// <para>
/// Returns the mnemonic modifier for this window. See
/// gtk_window_set_mnemonic_modifier().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the modifier mask used to activate
///               mnemonics on this window.
/// </return>

	public static MentorLake.Gdk.GdkModifierType GetMnemonicModifier(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_mnemonic_modifier(window);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkWindow:mnemonics-visible property.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if mnemonics are supposed to be visible
/// in this window.
/// </return>

	public static bool GetMnemonicsVisible(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_mnemonics_visible(window);
	}

/// <summary>
/// <para>
/// Returns whether the window is modal. See gtk_window_set_modal().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the window is set to be modal and
///               establishes a grab when shown
/// </return>

	public static bool GetModal(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_modal(window);
	}

/// <summary>
/// <para>
/// Fetches the requested opacity for this window. See
/// gtk_window_set_opacity().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the requested opacity for this window.
/// </return>

	public static double GetOpacity(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_opacity(window);
	}

/// <summary>
/// <para>
/// This function returns the position you need to pass to
/// gtk_window_move() to keep @window in its current position.
/// This means that the meaning of the returned value varies with
/// window gravity. See gtk_window_move() for more details.
/// </para>
/// <para>
/// The reliability of this function depends on the windowing system
/// currently in use. Some windowing systems, such as Wayland, do not
/// support a global coordinate system, and thus the position of the
/// window will always be (0, 0). Others, like X11, do not have a reliable
/// way to obtain the geometry of the decorations of a window if they are
/// provided by the window manager. Additionally, on X11, window manager
/// have been known to mismanage window gravity, which result in windows
/// moving even if you use the coordinates of the current position as
/// returned by this function.
/// </para>
/// <para>
/// If you haven’t changed the window gravity, its gravity will be
/// #GDK_GRAVITY_NORTH_WEST. This means that gtk_window_get_position()
/// gets the position of the top-left corner of the window manager
/// frame for the window. gtk_window_move() sets the position of this
/// same top-left corner.
/// </para>
/// <para>
/// If a window has gravity #GDK_GRAVITY_STATIC the window manager
/// frame is not relevant, and thus gtk_window_get_position() will
/// always produce accurate results. However you can’t use static
/// gravity to do things like place a window in a corner of the screen,
/// because static gravity ignores the window manager decorations.
/// </para>
/// <para>
/// Ideally, this function should return appropriate values if the
/// window has client side decorations, assuming that the windowing
/// system supports global coordinates.
/// </para>
/// <para>
/// In practice, saving the window position should not be left to
/// applications, as they lack enough knowledge of the windowing
/// system and the window manager state to effectively do so. The
/// appropriate way to implement saving the window position is to
/// use a platform-specific protocol, wherever that is available.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="root_x">
/// return location for X coordinate of
///     gravity-determined reference point, or %NULL
/// </param>
/// <param name="root_y">
/// return location for Y coordinate of
///     gravity-determined reference point, or %NULL
/// </param>

	public static T GetPosition<T>(this T window, out int root_x, out int root_y) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_get_position(window, out root_x, out root_y);
		return window;
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_resizable().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the user can resize the window
/// </return>

	public static bool GetResizable(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_resizable(window);
	}

/// <summary>
/// <para>
/// If a window has a resize grip, this will retrieve the grip
/// position, width and height into the specified #GdkRectangle.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="rect">
/// a pointer to a #GdkRectangle which we should store
///     the resize grip area
/// </param>
/// <return>
/// %TRUE if the resize grip’s area was retrieved
/// </return>

	public static bool GetResizeGripArea(this MentorLake.Gtk.GtkWindowHandle window, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_resize_grip_area(window, out rect);
	}

/// <summary>
/// <para>
/// Returns the role of the window. See gtk_window_set_role() for
/// further explanation.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the role of the window if set, or %NULL. The
/// returned is owned by the widget and must not be modified or freed.
/// </return>

	public static string GetRole(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_role(window);
	}

/// <summary>
/// <para>
/// Returns the #GdkScreen associated with @window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow.
/// </param>
/// <return>
/// a #GdkScreen.
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_screen(window);
	}

/// <summary>
/// <para>
/// Obtains the current size of @window.
/// </para>
/// <para>
/// If @window is not visible on screen, this function return the size GTK+
/// will suggest to the [window manager][gtk-X11-arch] for the initial window
/// size (but this is not reliably the same as the size the window manager
/// will actually select). See: gtk_window_set_default_size().
/// </para>
/// <para>
/// Depending on the windowing system and the window manager constraints,
/// the size returned by this function may not match the size set using
/// gtk_window_resize(); additionally, since gtk_window_resize() may be
/// implemented as an asynchronous operation, GTK+ cannot guarantee in any
/// way that this code:
/// </para>
/// <code>
///   // width and height are set elsewhere
///   // width and height are set elsewhere
///   gtk_window_resize (window, width, height);
/// 
///   int new_width, new_height;
///   gtk_window_get_size (window, &amp;new_width, &amp;new_height);
/// </code>
/// <para>
/// will result in `new_width` and `new_height` matching `width` and
/// `height`, respectively.
/// </para>
/// <para>
/// This function will return the logical size of the #GtkWindow,
/// excluding the widgets used in client side decorations; there is,
/// however, no guarantee that the result will be completely accurate
/// because client side decoration may include widgets that depend on
/// the user preferences and that may not be visibile at the time you
/// call this function.
/// </para>
/// <para>
/// The dimensions returned by this function are suitable for being
/// stored across sessions; use gtk_window_set_default_size() to
/// restore them when before showing the window.
/// </para>
/// <para>
/// To avoid potential race conditions, you should only call this
/// function in response to a size change notification, for instance
/// inside a handler for the #GtkWidget::size-allocate signal, or
/// inside a handler for the #GtkWidget::configure-event signal:
/// </para>
/// <code>
/// static void
/// static void
/// on_size_allocate (GtkWidget *widget, GtkAllocation *allocation)
/// {
///   int new_width, new_height;
/// 
///   gtk_window_get_size (GTK_WINDOW (widget), &amp;new_width, &amp;new_height);
/// 
///   ...
/// }
/// </code>
/// <para>
/// Note that, if you connect to the #GtkWidget::size-allocate signal,
/// you should not use the dimensions of the #GtkAllocation passed to
/// the signal handler, as the allocation may contain client side
/// decorations added by GTK+, depending on the windowing system in
/// use.
/// </para>
/// <para>
/// If you are getting a window size in order to position the window
/// on the screen, you should, instead, simply set the window’s semantic
/// type with gtk_window_set_type_hint(), which allows the window manager
/// to e.g. center dialogs. Also, if you set the transient parent of
/// dialogs with gtk_window_set_transient_for() window managers will
/// often center the dialog over its parent window. It&apos;s much preferred
/// to let the window manager handle these cases rather than doing it
/// yourself, because all apps will behave consistently and according to
/// user or system preferences, if the window manager handles it. Also,
/// the window manager can take into account the size of the window
/// decorations and border that it may add, and of which GTK+ has no
/// knowledge. Additionally, positioning windows in global screen coordinates
/// may not be allowed by the windowing system. For more information,
/// see: gtk_window_set_position().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="width">
/// return location for width, or %NULL
/// </param>
/// <param name="height">
/// return location for height, or %NULL
/// </param>

	public static T GetSize<T>(this T window, out int width, out int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_get_size(window, out width, out height);
		return window;
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_skip_pager_hint().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if window shouldn’t be in pager
/// </return>

	public static bool GetSkipPagerHint(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_skip_pager_hint(window);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_skip_taskbar_hint()
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if window shouldn’t be in taskbar
/// </return>

	public static bool GetSkipTaskbarHint(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_skip_taskbar_hint(window);
	}

/// <summary>
/// <para>
/// Retrieves the title of the window. See gtk_window_set_title().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the title of the window, or %NULL if none has
/// been set explicitly. The returned string is owned by the widget
/// and must not be modified or freed.
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_title(window);
	}

/// <summary>
/// <para>
/// Returns the custom titlebar that has been set with
/// gtk_window_set_titlebar().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the custom titlebar, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetTitlebar(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_titlebar(window);
	}

/// <summary>
/// <para>
/// Fetches the transient parent for this window. See
/// gtk_window_set_transient_for().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the transient parent for this
/// window, or %NULL if no transient parent has been set.
/// </return>

	public static MentorLake.Gtk.GtkWindowHandle GetTransientFor(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_transient_for(window);
	}

/// <summary>
/// <para>
/// Gets the type hint for this window. See gtk_window_set_type_hint().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the type hint for @window.
/// </return>

	public static MentorLake.Gdk.GdkWindowTypeHint GetTypeHint(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_type_hint(window);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_window_set_urgency_hint()
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if window is urgent
/// </return>

	public static bool GetUrgencyHint(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_urgency_hint(window);
	}

/// <summary>
/// <para>
/// Gets the type of the window. See #GtkWindowType.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// the type of the window
/// </return>

	public static MentorLake.Gtk.GtkWindowType GetWindowType(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_window_type(window);
	}

/// <summary>
/// <para>
/// Returns whether @window has an explicit window group.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if @window has an explicit window group.
/// 
/// Since 2.22
/// </return>

	public static bool HasGroup(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_has_group(window);
	}

/// <summary>
/// <para>
/// Returns whether the input focus is within this GtkWindow.
/// For real toplevel windows, this is identical to gtk_window_is_active(),
/// but for embedded windows, like #GtkPlug, the results will differ.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the input focus is within this GtkWindow
/// </return>

	public static bool HasToplevelFocus(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_has_toplevel_focus(window);
	}

/// <summary>
/// <para>
/// Asks to iconify (i.e. minimize) the specified @window. Note that
/// you shouldn’t assume the window is definitely iconified afterward,
/// because other entities (e.g. the user or
/// [window manager][gtk-X11-arch]) could deiconify it
/// again, or there may not be a window manager in which case
/// iconification isn’t possible, etc. But normally the window will end
/// up iconified. Just don’t write code that crashes if not.
/// </para>
/// <para>
/// It’s permitted to call this function before showing a window,
/// in which case the window will be iconified before it ever appears
/// onscreen.
/// </para>
/// <para>
/// You can track iconification via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Iconify<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_iconify(window);
		return window;
	}

/// <summary>
/// <para>
/// Returns whether the window is part of the current active toplevel.
/// (That is, the toplevel window receiving keystrokes.)
/// The return value is %TRUE if the window is active toplevel
/// itself, but also if it is, say, a #GtkPlug embedded in the active toplevel.
/// You might use this function if you wanted to draw a widget
/// differently in an active window from a widget in an inactive window.
/// See gtk_window_has_toplevel_focus()
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if the window part of the current active window.
/// </return>

	public static bool IsActive(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_is_active(window);
	}

/// <summary>
/// <para>
/// Retrieves the current maximized state of @window.
/// </para>
/// <para>
/// Note that since maximization is ultimately handled by the window
/// manager and happens asynchronously to an application request, you
/// shouldn’t assume the return value of this function changing
/// immediately (or at all), as an effect of calling
/// gtk_window_maximize() or gtk_window_unmaximize().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// whether the window has a maximized state.
/// </return>

	public static bool IsMaximized(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_is_maximized(window);
	}

/// <summary>
/// <para>
/// Asks to maximize @window, so that it becomes full-screen. Note that
/// you shouldn’t assume the window is definitely maximized afterward,
/// because other entities (e.g. the user or
/// [window manager][gtk-X11-arch]) could unmaximize it
/// again, and not all window managers support maximization. But
/// normally the window will end up maximized. Just don’t write code
/// that crashes if not.
/// </para>
/// <para>
/// It’s permitted to call this function before showing a window,
/// in which case the window will be maximized when it appears onscreen
/// initially.
/// </para>
/// <para>
/// You can track maximization via the “window-state-event” signal
/// on #GtkWidget, or by listening to notifications on the
/// #GtkWindow:is-maximized property.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Maximize<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_maximize(window);
		return window;
	}

/// <summary>
/// <para>
/// Activates the targets associated with the mnemonic.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="keyval">
/// the mnemonic
/// </param>
/// <param name="modifier">
/// the modifiers
/// </param>
/// <return>
/// %TRUE if the activation is done.
/// </return>

	public static bool MnemonicActivate(this MentorLake.Gtk.GtkWindowHandle window, uint keyval, MentorLake.Gdk.GdkModifierType modifier)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_mnemonic_activate(window, keyval, modifier);
	}

/// <summary>
/// <para>
/// Asks the [window manager][gtk-X11-arch] to move
/// @window to the given position.  Window managers are free to ignore
/// this; most window managers ignore requests for initial window
/// positions (instead using a user-defined placement algorithm) and
/// honor requests after the window has already been shown.
/// </para>
/// <para>
/// Note: the position is the position of the gravity-determined
/// reference point for the window. The gravity determines two things:
/// first, the location of the reference point in root window
/// coordinates; and second, which point on the window is positioned at
/// the reference point.
/// </para>
/// <para>
/// By default the gravity is #GDK_GRAVITY_NORTH_WEST, so the reference
/// point is simply the @x, @y supplied to gtk_window_move(). The
/// top-left corner of the window decorations (aka window frame or
/// border) will be placed at @x, @y.  Therefore, to position a window
/// at the top left of the screen, you want to use the default gravity
/// (which is #GDK_GRAVITY_NORTH_WEST) and move the window to 0,0.
/// </para>
/// <para>
/// To position a window at the bottom right corner of the screen, you
/// would set #GDK_GRAVITY_SOUTH_EAST, which means that the reference
/// point is at @x + the window width and @y + the window height, and
/// the bottom-right corner of the window border will be placed at that
/// reference point. So, to place a window in the bottom right corner
/// you would first set gravity to south east, then write:
/// `gtk_window_move (window, gdk_screen_width () - window_width,
/// gdk_screen_height () - window_height)` (note that this
/// example does not take multi-head scenarios into account).
/// </para>
/// <para>
/// The [Extended Window Manager Hints Specification](http://www.freedesktop.org/Standards/wm-spec)
/// has a nice table of gravities in the “implementation notes” section.
/// </para>
/// <para>
/// The gtk_window_get_position() documentation may also be relevant.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="x">
/// X coordinate to move window to
/// </param>
/// <param name="y">
/// Y coordinate to move window to
/// </param>

	public static T Move<T>(this T window, int x, int y) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_move(window, x, y);
		return window;
	}

/// <summary>
/// <para>
/// Parses a standard X Window System geometry string - see the
/// manual page for X (type “man X”) for details on this.
/// gtk_window_parse_geometry() does work on all GTK+ ports
/// including Win32 but is primarily intended for an X environment.
/// </para>
/// <para>
/// If either a size or a position can be extracted from the
/// geometry string, gtk_window_parse_geometry() returns %TRUE
/// and calls gtk_window_set_default_size() and/or gtk_window_move()
/// to resize/move the window.
/// </para>
/// <para>
/// If gtk_window_parse_geometry() returns %TRUE, it will also
/// set the #GDK_HINT_USER_POS and/or #GDK_HINT_USER_SIZE hints
/// indicating to the window manager that the size/position of
/// the window was user-specified. This causes most window
/// managers to honor the geometry.
/// </para>
/// <para>
/// Note that for gtk_window_parse_geometry() to work as expected, it has
/// to be called when the window has its “final” size, i.e. after calling
/// gtk_widget_show_all() on the contents and gtk_window_set_geometry_hints()
/// on the window.
/// <code>
/// #include &amp;lt;gtk/gtk.h&amp;gt;
/// #include &amp;lt;gtk/gtk.h&amp;gt;
/// 
/// static void
/// fill_with_content (GtkWidget *vbox)
/// {
///   // fill with content...
/// }
/// 
/// int
/// main (int argc, char *argv[])
/// {
///   GtkWidget *window, *vbox;
///   GdkGeometry size_hints = {
///     100, 50, 0, 0, 100, 50, 10,
///     10, 0.0, 0.0, GDK_GRAVITY_NORTH_WEST
///   };
/// 
///   gtk_init (&amp;argc, &amp;argv);
/// 
///   window = gtk_window_new (GTK_WINDOW_TOPLEVEL);
///   vbox = gtk_box_new (GTK_ORIENTATION_VERTICAL, 0);
/// 
///   gtk_container_add (GTK_CONTAINER (window), vbox);
///   fill_with_content (vbox);
///   gtk_widget_show_all (vbox);
/// 
///   gtk_window_set_geometry_hints (GTK_WINDOW (window),
/// 	  			    NULL,
/// 				    &amp;size_hints,
/// 				    GDK_HINT_MIN_SIZE |
/// 				    GDK_HINT_BASE_SIZE |
/// 				    GDK_HINT_RESIZE_INC);
/// 
///   if (argc &amp;gt; 1)
///     {
///       gboolean res;
///       res = gtk_window_parse_geometry (GTK_WINDOW (window),
///                                        argv[1]);
///       if (! res)
///         fprintf (stderr,
///                  &quot;Failed to parse “%s”\n&quot;,
///                  argv[1]);
///     }
/// 
///   gtk_widget_show_all (window);
///   gtk_main ();
/// 
///   return 0;
/// }
/// </code>
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="geometry">
/// geometry string
/// </param>
/// <return>
/// %TRUE if string was parsed successfully
/// </return>

	public static bool ParseGeometry(this MentorLake.Gtk.GtkWindowHandle window, string geometry)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_parse_geometry(window, geometry);
	}

/// <summary>
/// <para>
/// Presents a window to the user. This function should not be used
/// as when it is called, it is too late to gather a valid timestamp
/// to allow focus stealing prevention to work correctly.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Present<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_present(window);
		return window;
	}

/// <summary>
/// <para>
/// Presents a window to the user. This may mean raising the window
/// in the stacking order, deiconifying it, moving it to the current
/// desktop, and/or giving it the keyboard focus, possibly dependent
/// on the user’s platform, window manager, and preferences.
/// </para>
/// <para>
/// If @window is hidden, this function calls gtk_widget_show()
/// as well.
/// </para>
/// <para>
/// This function should be used when the user tries to open a window
/// that’s already open. Say for example the preferences dialog is
/// currently open, and the user chooses Preferences from the menu
/// a second time; use gtk_window_present() to move the already-open dialog
/// where the user can see it.
/// </para>
/// <para>
/// Presents a window to the user in response to a user interaction. The
/// timestamp should be gathered when the window was requested to be shown
/// (when clicking a link for example), rather than once the window is
/// ready to be shown.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="timestamp">
/// the timestamp of the user interaction (typically a
///   button or key press event) which triggered this call
/// </param>

	public static T PresentWithTime<T>(this T window, uint timestamp) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_present_with_time(window, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// Propagate a key press or release event to the focus widget and
/// up the focus container chain until a widget handles @event.
/// This is normally called by the default ::key_press_event and
/// ::key_release_event handlers for toplevel windows,
/// however in some cases it may be useful to call this directly when
/// overriding the standard key handling for a toplevel window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="@event">
/// a #GdkEventKey
/// </param>
/// <return>
/// %TRUE if a widget in the focus chain handled the event.
/// </return>

	public static bool PropagateKeyEvent(this MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_propagate_key_event(window, @event);
	}

/// <summary>
/// <para>
/// Reverses the effects of gtk_window_add_accel_group().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="accel_group">
/// a #GtkAccelGroup
/// </param>

	public static T RemoveAccelGroup<T>(this T window, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_remove_accel_group(window, accel_group);
		return window;
	}

/// <summary>
/// <para>
/// Removes a mnemonic from this window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="keyval">
/// the mnemonic
/// </param>
/// <param name="target">
/// the widget that gets activated by the mnemonic
/// </param>

	public static T RemoveMnemonic<T>(this T window, uint keyval, MentorLake.Gtk.GtkWidgetHandle target) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_remove_mnemonic(window, keyval, target);
		return window;
	}

/// <summary>
/// <para>
/// Hides @window, then reshows it, resetting the
/// default size and position of the window. Used
/// by GUI builders only.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T ReshowWithInitialSize<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_reshow_with_initial_size(window);
		return window;
	}

/// <summary>
/// <para>
/// Resizes the window as if the user had done so, obeying geometry
/// constraints. The default geometry constraint is that windows may
/// not be smaller than their size request; to override this
/// constraint, call gtk_widget_set_size_request() to set the window&apos;s
/// request to a smaller value.
/// </para>
/// <para>
/// If gtk_window_resize() is called before showing a window for the
/// first time, it overrides any default size set with
/// gtk_window_set_default_size().
/// </para>
/// <para>
/// Windows may not be resized smaller than 1 by 1 pixels.
/// </para>
/// <para>
/// When using client side decorations, GTK+ will do its best to adjust
/// the given size so that the resulting window size matches the
/// requested size without the title bar, borders and shadows added for
/// the client side decorations, but there is no guarantee that the
/// result will be totally accurate because these widgets added for
/// client side decorations depend on the theme and may not be realized
/// or visible at the time gtk_window_resize() is issued.
/// </para>
/// <para>
/// If the GtkWindow has a titlebar widget (see gtk_window_set_titlebar()), then
/// typically, gtk_window_resize() will compensate for the height of the titlebar
/// widget only if the height is known when the resulting GtkWindow configuration
/// is issued.
/// For example, if new widgets are added after the GtkWindow configuration
/// and cause the titlebar widget to grow in height, this will result in a
/// window content smaller that specified by gtk_window_resize() and not
/// a larger window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="width">
/// width in pixels to resize the window to
/// </param>
/// <param name="height">
/// height in pixels to resize the window to
/// </param>

	public static T Resize<T>(this T window, int width, int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_resize(window, width, height);
		return window;
	}

/// <summary>
/// <para>
/// Determines whether a resize grip is visible for the specified window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <return>
/// %TRUE if a resize grip exists and is visible
/// </return>

	public static bool ResizeGripIsVisible(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_resize_grip_is_visible(window);
	}

/// <summary>
/// <para>
/// Like gtk_window_resize(), but @width and @height are interpreted
/// in terms of the base size and increment set with
/// gtk_window_set_geometry_hints.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="width">
/// width in resize increments to resize the window to
/// </param>
/// <param name="height">
/// height in resize increments to resize the window to
/// </param>

	public static T ResizeToGeometry<T>(this T window, int width, int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_resize_to_geometry(window, width, height);
		return window;
	}

/// <summary>
/// <para>
/// Windows may set a hint asking the desktop environment not to receive
/// the input focus. This function sets this hint.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// %TRUE to let this window receive input focus
/// </param>

	public static T SetAcceptFocus<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_accept_focus(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Sets or unsets the #GtkApplication associated with the window.
/// </para>
/// <para>
/// The application will be kept alive for at least as long as it has any windows
/// associated with it (see g_application_hold() for a way to keep it alive
/// without windows).
/// </para>
/// <para>
/// Normally, the connection between the application and the window will remain
/// until the window is destroyed, but you can explicitly remove it by setting
/// the @application to %NULL.
/// </para>
/// <para>
/// This is equivalent to calling gtk_application_remove_window() and/or
/// gtk_application_add_window() on the old/new applications as relevant.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="application">
/// a #GtkApplication, or %NULL to unset
/// </param>

	public static T SetApplication<T>(this T window, MentorLake.Gtk.GtkApplicationHandle application) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_application(window, application);
		return window;
	}

/// <summary>
/// <para>
/// Marks @window as attached to @attach_widget. This creates a logical binding
/// between the window and the widget it belongs to, which is used by GTK+ to
/// propagate information such as styling or accessibility to @window as if it
/// was a children of @attach_widget.
/// </para>
/// <para>
/// Examples of places where specifying this relation is useful are for instance
/// a #GtkMenu created by a #GtkComboBox, a completion popup window
/// created by #GtkEntry or a typeahead search entry created by #GtkTreeView.
/// </para>
/// <para>
/// Note that this function should not be confused with
/// gtk_window_set_transient_for(), which specifies a window manager relation
/// between two toplevels instead.
/// </para>
/// <para>
/// Passing %NULL for @attach_widget detaches the window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="attach_widget">
/// a #GtkWidget, or %NULL
/// </param>

	public static T SetAttachedTo<T>(this T window, MentorLake.Gtk.GtkWidgetHandle attach_widget) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_attached_to(window, attach_widget);
		return window;
	}

/// <summary>
/// <para>
/// By default, windows are decorated with a title bar, resize
/// controls, etc.  Some [window managers][gtk-X11-arch]
/// allow GTK+ to disable these decorations, creating a
/// borderless window. If you set the decorated property to %FALSE
/// using this function, GTK+ will do its best to convince the window
/// manager not to decorate the window. Depending on the system, this
/// function may not have any effect when called on a window that is
/// already visible, so you should call it before calling gtk_widget_show().
/// </para>
/// <para>
/// On Windows, this function always works, since there’s no window manager
/// policy involved.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// %TRUE to decorate the window
/// </param>

	public static T SetDecorated<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_decorated(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// The default widget is the widget that’s activated when the user
/// presses Enter in a dialog (for example). This function sets or
/// unsets the default widget for a #GtkWindow. When setting (rather
/// than unsetting) the default widget it’s generally easier to call
/// gtk_widget_grab_default() on the widget. Before making a widget
/// the default widget, you must call gtk_widget_set_can_default() on
/// the widget you’d like to make the default.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="default_widget">
/// widget to be the default, or %NULL
///     to unset the default widget for the toplevel
/// </param>

	public static T SetDefault<T>(this T window, MentorLake.Gtk.GtkWidgetHandle default_widget) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_default(window, default_widget);
		return window;
	}

/// <summary>
/// <para>
/// Like gtk_window_set_default_size(), but @width and @height are interpreted
/// in terms of the base size and increment set with
/// gtk_window_set_geometry_hints.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="width">
/// width in resize increments, or -1 to unset the default width
/// </param>
/// <param name="height">
/// height in resize increments, or -1 to unset the default height
/// </param>

	public static T SetDefaultGeometry<T>(this T window, int width, int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_default_geometry(window, width, height);
		return window;
	}

/// <summary>
/// <para>
/// Sets the default size of a window. If the window’s “natural” size
/// (its size request) is larger than the default, the default will be
/// ignored. More generally, if the default size does not obey the
/// geometry hints for the window (gtk_window_set_geometry_hints() can
/// be used to set these explicitly), the default size will be clamped
/// to the nearest permitted size.
/// </para>
/// <para>
/// Unlike gtk_widget_set_size_request(), which sets a size request for
/// a widget and thus would keep users from shrinking the window, this
/// function only sets the initial size, just as if the user had
/// resized the window themselves. Users can still shrink the window
/// again as they normally would. Setting a default size of -1 means to
/// use the “natural” default size (the size request of the window).
/// </para>
/// <para>
/// For more control over a window’s initial size and how resizing works,
/// investigate gtk_window_set_geometry_hints().
/// </para>
/// <para>
/// For some uses, gtk_window_resize() is a more appropriate function.
/// gtk_window_resize() changes the current size of the window, rather
/// than the size to be used on initial display. gtk_window_resize() always
/// affects the window itself, not the geometry widget.
/// </para>
/// <para>
/// The default size of a window only affects the first time a window is
/// shown; if a window is hidden and re-shown, it will remember the size
/// it had prior to hiding, rather than using the default size.
/// </para>
/// <para>
/// Windows can’t actually be 0x0 in size, they must be at least 1x1, but
/// passing 0 for @width and @height is OK, resulting in a 1x1 default size.
/// </para>
/// <para>
/// If you use this function to reestablish a previously saved window size,
/// note that the appropriate size to save is the one returned by
/// gtk_window_get_size(). Using the window allocation directly will not
/// work in all circumstances and can lead to growing or shrinking windows.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="width">
/// width in pixels, or -1 to unset the default width
/// </param>
/// <param name="height">
/// height in pixels, or -1 to unset the default height
/// </param>

	public static T SetDefaultSize<T>(this T window, int width, int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_default_size(window, width, height);
		return window;
	}

/// <summary>
/// <para>
/// By default, windows have a close button in the window frame. Some
/// [window managers][gtk-X11-arch] allow GTK+ to
/// disable this button. If you set the deletable property to %FALSE
/// using this function, GTK+ will do its best to convince the window
/// manager not to show a close button. Depending on the system, this
/// function may not have any effect when called on a window that is
/// already visible, so you should call it before calling gtk_widget_show().
/// </para>
/// <para>
/// On Windows, this function always works, since there’s no window manager
/// policy involved.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// %TRUE to decorate the window as deletable
/// </param>

	public static T SetDeletable<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_deletable(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// If @setting is %TRUE, then destroying the transient parent of @window
/// will also destroy @window itself. This is useful for dialogs that
/// shouldn’t persist beyond the lifetime of the main window they&apos;re
/// associated with, for example.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// whether to destroy @window with its transient parent
/// </param>

	public static T SetDestroyWithParent<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_destroy_with_parent(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// If @focus is not the current focus widget, and is focusable, sets
/// it as the focus widget for the window. If @focus is %NULL, unsets
/// the focus widget for this window. To set the focus to a particular
/// widget in the toplevel, it is usually more convenient to use
/// gtk_widget_grab_focus() instead of this function.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="focus">
/// widget to be the new focus widget, or %NULL to unset
///   any focus widget for the toplevel window.
/// </param>

	public static T SetFocus<T>(this T window, MentorLake.Gtk.GtkWidgetHandle focus) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_focus(window, focus);
		return window;
	}

/// <summary>
/// <para>
/// Windows may set a hint asking the desktop environment not to receive
/// the input focus when the window is mapped.  This function sets this
/// hint.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// %TRUE to let this window receive input focus on map
/// </param>

	public static T SetFocusOnMap<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_focus_on_map(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Sets the #GtkWindow:focus-visible property.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// the new value
/// </param>

	public static T SetFocusVisible<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_focus_visible(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// This function sets up hints about how a window can be resized by
/// the user.  You can set a minimum and maximum size; allowed resize
/// increments (e.g. for xterm, you can only resize by the size of a
/// character); aspect ratios; and more. See the #GdkGeometry struct.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="geometry_widget">
/// widget the geometry hints used to be applied to
///   or %NULL. Since 3.20 this argument is ignored and GTK behaves as if %NULL was
///   set.
/// </param>
/// <param name="geometry">
/// struct containing geometry information or %NULL
/// </param>
/// <param name="geom_mask">
/// mask indicating which struct fields should be paid attention to
/// </param>

	public static T SetGeometryHints<T>(this T window, MentorLake.Gtk.GtkWidgetHandle geometry_widget, MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints geom_mask) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_geometry_hints(window, geometry_widget, geometry, geom_mask);
		return window;
	}

/// <summary>
/// <para>
/// Window gravity defines the meaning of coordinates passed to
/// gtk_window_move(). See gtk_window_move() and #GdkGravity for
/// more details.
/// </para>
/// <para>
/// The default window gravity is #GDK_GRAVITY_NORTH_WEST which will
/// typically “do what you mean.”
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="gravity">
/// window gravity
/// </param>

	public static T SetGravity<T>(this T window, MentorLake.Gdk.GdkGravity gravity) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_gravity(window, gravity);
		return window;
	}

/// <summary>
/// <para>
/// Sets whether @window has a corner resize grip.
/// </para>
/// <para>
/// Note that the resize grip is only shown if the window
/// is actually resizable and not maximized. Use
/// gtk_window_resize_grip_is_visible() to find out if the
/// resize grip is currently shown.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="value">
/// %TRUE to allow a resize grip
/// </param>

	public static T SetHasResizeGrip<T>(this T window, bool value) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_has_resize_grip(window, value);
		return window;
	}

/// <summary>
/// <para>
/// Tells GTK+ whether to drop its extra reference to the window
/// when gtk_widget_destroy() is called.
/// </para>
/// <para>
/// This function is only exported for the benefit of language
/// bindings which may need to keep the window alive until their
/// wrapper object is garbage collected. There is no justification
/// for ever calling this function in an application.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// the new value
/// </param>

	public static T SetHasUserRefCount<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_has_user_ref_count(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// If @setting is %TRUE, then @window will request that it’s titlebar
/// should be hidden when maximized.
/// This is useful for windows that don’t convey any information other
/// than the application name in the titlebar, to put the available
/// screen space to better use. If the underlying window system does not
/// support the request, the setting will not have any effect.
/// </para>
/// <para>
/// Note that custom titlebars set with gtk_window_set_titlebar() are
/// not affected by this. The application is in full control of their
/// content and visibility anyway.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// whether to hide the titlebar when @window is maximized
/// </param>

	public static T SetHideTitlebarWhenMaximized<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_hide_titlebar_when_maximized(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Sets up the icon representing a #GtkWindow. This icon is used when
/// the window is minimized (also known as iconified).  Some window
/// managers or desktop environments may also place it in the window
/// frame, or display it in other contexts. On others, the icon is not
/// used at all, so your mileage may vary.
/// </para>
/// <para>
/// The icon should be provided in whatever size it was naturally
/// drawn; that is, don’t scale the image before passing it to
/// GTK+. Scaling is postponed until the last minute, when the desired
/// final size is known, to allow best quality.
/// </para>
/// <para>
/// If you have your icon hand-drawn in multiple sizes, use
/// gtk_window_set_icon_list(). Then the best size will be used.
/// </para>
/// <para>
/// This function is equivalent to calling gtk_window_set_icon_list()
/// with a 1-element list.
/// </para>
/// <para>
/// See also gtk_window_set_default_icon_list() to set the icon
/// for all windows in your application in one go.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="icon">
/// icon image, or %NULL
/// </param>

	public static T SetIcon<T>(this T window, MentorLake.GdkPixbuf.GdkPixbufHandle icon) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_icon(window, icon);
		return window;
	}

/// <summary>
/// <para>
/// Sets the icon for @window.
/// Warns on failure if @err is %NULL.
/// </para>
/// <para>
/// This function is equivalent to calling gtk_window_set_icon()
/// with a pixbuf created by loading the image from @filename.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="filename">
/// location of icon file
/// </param>
/// <return>
/// %TRUE if setting the icon succeeded.
/// </return>

	public static bool SetIconFromFile(this MentorLake.Gtk.GtkWindowHandle window, string filename)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		var externCallResult = GtkWindowHandleExterns.gtk_window_set_icon_from_file(window, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets up the icon representing a #GtkWindow. The icon is used when
/// the window is minimized (also known as iconified).  Some window
/// managers or desktop environments may also place it in the window
/// frame, or display it in other contexts. On others, the icon is not
/// used at all, so your mileage may vary.
/// </para>
/// <para>
/// gtk_window_set_icon_list() allows you to pass in the same icon in
/// several hand-drawn sizes. The list should contain the natural sizes
/// your icon is available in; that is, don’t scale the image before
/// passing it to GTK+. Scaling is postponed until the last minute,
/// when the desired final size is known, to allow best quality.
/// </para>
/// <para>
/// By passing several sizes, you may improve the final image quality
/// of the icon, by reducing or eliminating automatic image scaling.
/// </para>
/// <para>
/// Recommended sizes to provide: 16x16, 32x32, 48x48 at minimum, and
/// larger images (64x64, 128x128) if you have them.
/// </para>
/// <para>
/// See also gtk_window_set_default_icon_list() to set the icon
/// for all windows in your application in one go.
/// </para>
/// <para>
/// Note that transient windows (those who have been set transient for another
/// window using gtk_window_set_transient_for()) will inherit their
/// icon from their transient parent. So there’s no need to explicitly
/// set the icon on transient windows.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="list">
/// list of #GdkPixbuf
/// </param>

	public static T SetIconList<T>(this T window, MentorLake.GLib.GListHandle list) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_icon_list(window, list);
		return window;
	}

/// <summary>
/// <para>
/// Sets the icon for the window from a named themed icon.
/// See the docs for #GtkIconTheme for more details.
/// On some platforms, the window icon is not used at all.
/// </para>
/// <para>
/// Note that this has nothing to do with the WM_ICON_NAME
/// property which is mentioned in the ICCCM.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="name">
/// the name of the themed icon
/// </param>

	public static T SetIconName<T>(this T window, string name) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_icon_name(window, name);
		return window;
	}

/// <summary>
/// <para>
/// Asks to keep @window above, so that it stays on top. Note that
/// you shouldn’t assume the window is definitely above afterward,
/// because other entities (e.g. the user or
/// [window manager][gtk-X11-arch]) could not keep it above,
/// and not all window managers support keeping windows above. But
/// normally the window will end kept above. Just don’t write code
/// that crashes if not.
/// </para>
/// <para>
/// It’s permitted to call this function before showing a window,
/// in which case the window will be kept above when it appears onscreen
/// initially.
/// </para>
/// <para>
/// You can track the above state via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// <para>
/// Note that, according to the
/// [Extended Window Manager Hints Specification](http://www.freedesktop.org/Standards/wm-spec),
/// the above state is mainly meant for user preferences and should not
/// be used by applications e.g. for drawing attention to their
/// dialogs.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// whether to keep @window above other windows
/// </param>

	public static T SetKeepAbove<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_keep_above(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Asks to keep @window below, so that it stays in bottom. Note that
/// you shouldn’t assume the window is definitely below afterward,
/// because other entities (e.g. the user or
/// [window manager][gtk-X11-arch]) could not keep it below,
/// and not all window managers support putting windows below. But
/// normally the window will be kept below. Just don’t write code
/// that crashes if not.
/// </para>
/// <para>
/// It’s permitted to call this function before showing a window,
/// in which case the window will be kept below when it appears onscreen
/// initially.
/// </para>
/// <para>
/// You can track the below state via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// <para>
/// Note that, according to the
/// [Extended Window Manager Hints Specification](http://www.freedesktop.org/Standards/wm-spec),
/// the above state is mainly meant for user preferences and should not
/// be used by applications e.g. for drawing attention to their
/// dialogs.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// whether to keep @window below other windows
/// </param>

	public static T SetKeepBelow<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_keep_below(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Sets the mnemonic modifier for this window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="modifier">
/// the modifier mask used to activate
///               mnemonics on this window.
/// </param>

	public static T SetMnemonicModifier<T>(this T window, MentorLake.Gdk.GdkModifierType modifier) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_mnemonic_modifier(window, modifier);
		return window;
	}

/// <summary>
/// <para>
/// Sets the #GtkWindow:mnemonics-visible property.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// the new value
/// </param>

	public static T SetMnemonicsVisible<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_mnemonics_visible(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Sets a window modal or non-modal. Modal windows prevent interaction
/// with other windows in the same application. To keep modal dialogs
/// on top of main application windows, use
/// gtk_window_set_transient_for() to make the dialog transient for the
/// parent; most [window managers][gtk-X11-arch]
/// will then disallow lowering the dialog below the parent.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="modal">
/// whether the window is modal
/// </param>

	public static T SetModal<T>(this T window, bool modal) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_modal(window, modal);
		return window;
	}

/// <summary>
/// <para>
/// Request the windowing system to make @window partially transparent,
/// with opacity 0 being fully transparent and 1 fully opaque. (Values
/// of the opacity parameter are clamped to the [0,1] range.) On X11
/// this has any effect only on X screens with a compositing manager
/// running. See gtk_widget_is_composited(). On Windows it should work
/// always.
/// </para>
/// <para>
/// Note that setting a window’s opacity after the window has been
/// shown causes it to flicker once on Windows.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="opacity">
/// desired opacity, between 0 and 1
/// </param>

	public static T SetOpacity<T>(this T window, double opacity) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_opacity(window, opacity);
		return window;
	}

/// <summary>
/// <para>
/// Sets a position constraint for this window. If the old or new
/// constraint is %GTK_WIN_POS_CENTER_ALWAYS, this will also cause
/// the window to be repositioned to satisfy the new constraint.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow.
/// </param>
/// <param name="position">
/// a position constraint.
/// </param>

	public static T SetPosition<T>(this T window, MentorLake.Gtk.GtkWindowPosition position) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_position(window, position);
		return window;
	}

/// <summary>
/// <para>
/// Sets whether the user can resize a window. Windows are user resizable
/// by default.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="resizable">
/// %TRUE if the user can resize this window
/// </param>

	public static T SetResizable<T>(this T window, bool resizable) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_resizable(window, resizable);
		return window;
	}

/// <summary>
/// <para>
/// This function is only useful on X11, not with other GTK+ targets.
/// </para>
/// <para>
/// In combination with the window title, the window role allows a
/// [window manager][gtk-X11-arch] to identify &quot;the
/// same&quot; window when an application is restarted. So for example you
/// might set the “toolbox” role on your app’s toolbox window, so that
/// when the user restarts their session, the window manager can put
/// the toolbox back in the same place.
/// </para>
/// <para>
/// If a window already has a unique title, you don’t need to set the
/// role, since the WM can use the title to identify the window when
/// restoring the session.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="role">
/// unique identifier for the window to be used when restoring a session
/// </param>

	public static T SetRole<T>(this T window, string role) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_role(window, role);
		return window;
	}

/// <summary>
/// <para>
/// Sets the #GdkScreen where the @window is displayed; if
/// the window is already mapped, it will be unmapped, and
/// then remapped on the new screen.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow.
/// </param>
/// <param name="screen">
/// a #GdkScreen.
/// </param>

	public static T SetScreen<T>(this T window, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_screen(window, screen);
		return window;
	}

/// <summary>
/// <para>
/// Windows may set a hint asking the desktop environment not to display
/// the window in the pager. This function sets this hint.
/// (A &quot;pager&quot; is any desktop navigation tool such as a workspace
/// switcher that displays a thumbnail representation of the windows
/// on the screen.)
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// %TRUE to keep this window from appearing in the pager
/// </param>

	public static T SetSkipPagerHint<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_skip_pager_hint(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Windows may set a hint asking the desktop environment not to display
/// the window in the task bar. This function sets this hint.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// %TRUE to keep this window from appearing in the task bar
/// </param>

	public static T SetSkipTaskbarHint<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_skip_taskbar_hint(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Startup notification identifiers are used by desktop environment to
/// track application startup, to provide user feedback and other
/// features. This function changes the corresponding property on the
/// underlying GdkWindow. Normally, startup identifier is managed
/// automatically and you should only use this function in special cases
/// like transferring focus from other processes. You should use this
/// function before calling gtk_window_present() or any equivalent
/// function generating a window map event.
/// </para>
/// <para>
/// This function is only useful on X11, not with other GTK+ targets.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="startup_id">
/// a string with startup-notification identifier
/// </param>

	public static T SetStartupId<T>(this T window, string startup_id) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_startup_id(window, startup_id);
		return window;
	}

/// <summary>
/// <para>
/// Sets the title of the #GtkWindow. The title of a window will be
/// displayed in its title bar; on the X Window System, the title bar
/// is rendered by the [window manager][gtk-X11-arch],
/// so exactly how the title appears to users may vary
/// according to a user’s exact configuration. The title should help a
/// user distinguish this window from other windows they may have
/// open. A good title might include the application name and current
/// document filename, for example.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="title">
/// title of the window
/// </param>

	public static T SetTitle<T>(this T window, string title) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_title(window, title);
		return window;
	}

/// <summary>
/// <para>
/// Sets a custom titlebar for @window.
/// </para>
/// <para>
/// A typical widget used here is #GtkHeaderBar, as it provides various features
/// expected of a titlebar while allowing the addition of child widgets to it.
/// </para>
/// <para>
/// If you set a custom titlebar, GTK+ will do its best to convince
/// the window manager not to put its own titlebar on the window.
/// Depending on the system, this function may not work for a window
/// that is already visible, so you set the titlebar before calling
/// gtk_widget_show().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="titlebar">
/// the widget to use as titlebar
/// </param>

	public static T SetTitlebar<T>(this T window, MentorLake.Gtk.GtkWidgetHandle titlebar) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_titlebar(window, titlebar);
		return window;
	}

/// <summary>
/// <para>
/// Dialog windows should be set transient for the main application
/// window they were spawned from. This allows
/// [window managers][gtk-X11-arch] to e.g. keep the
/// dialog on top of the main window, or center the dialog over the
/// main window. gtk_dialog_new_with_buttons() and other convenience
/// functions in GTK+ will sometimes call
/// gtk_window_set_transient_for() on your behalf.
/// </para>
/// <para>
/// Passing %NULL for @parent unsets the current transient window.
/// </para>
/// <para>
/// On Wayland, this function can also be used to attach a new
/// #GTK_WINDOW_POPUP to a #GTK_WINDOW_TOPLEVEL parent already mapped
/// on screen so that the #GTK_WINDOW_POPUP will be created as a
/// subsurface-based window #GDK_WINDOW_SUBSURFACE which can be
/// positioned at will relatively to the #GTK_WINDOW_TOPLEVEL surface.
/// </para>
/// <para>
/// On Windows, this function puts the child window on top of the parent,
/// much as the window manager would have done on X.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="parent">
/// parent window, or %NULL
/// </param>

	public static T SetTransientFor<T>(this T window, MentorLake.Gtk.GtkWindowHandle parent) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_transient_for(window, parent);
		return window;
	}

/// <summary>
/// <para>
/// By setting the type hint for the window, you allow the window
/// manager to decorate and handle the window in a way which is
/// suitable to the function of the window in your application.
/// </para>
/// <para>
/// This function should be called before the window becomes visible.
/// </para>
/// <para>
/// gtk_dialog_new_with_buttons() and other convenience functions in GTK+
/// will sometimes call gtk_window_set_type_hint() on your behalf.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="hint">
/// the window type
/// </param>

	public static T SetTypeHint<T>(this T window, MentorLake.Gdk.GdkWindowTypeHint hint) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_type_hint(window, hint);
		return window;
	}

/// <summary>
/// <para>
/// Windows may set a hint asking the desktop environment to draw
/// the users attention to the window. This function sets this hint.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="setting">
/// %TRUE to mark this window as urgent
/// </param>

	public static T SetUrgencyHint<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_urgency_hint(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Don’t use this function. It sets the X Window System “class” and
/// “name” hints for a window.  According to the ICCCM, you should
/// always set these to the same value for all windows in an
/// application, and GTK+ sets them to that value by default, so calling
/// this function is sort of pointless. However, you may want to call
/// gtk_window_set_role() on each window in your application, for the
/// benefit of the session manager. Setting the role allows the window
/// manager to restore window positions when loading a saved session.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="wmclass_name">
/// window name hint
/// </param>
/// <param name="wmclass_class">
/// window class hint
/// </param>

	public static T SetWmclass<T>(this T window, string wmclass_name, string wmclass_class) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_wmclass(window, wmclass_name, wmclass_class);
		return window;
	}

/// <summary>
/// <para>
/// Asks to stick @window, which means that it will appear on all user
/// desktops. Note that you shouldn’t assume the window is definitely
/// stuck afterward, because other entities (e.g. the user or
/// [window manager][gtk-X11-arch] could unstick it
/// again, and some window managers do not support sticking
/// windows. But normally the window will end up stuck. Just don&apos;t
/// write code that crashes if not.
/// </para>
/// <para>
/// It’s permitted to call this function before showing a window.
/// </para>
/// <para>
/// You can track stickiness via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Stick<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_stick(window);
		return window;
	}

/// <summary>
/// <para>
/// Asks to toggle off the fullscreen state for @window. Note that you
/// shouldn’t assume the window is definitely not full screen
/// afterward, because other entities (e.g. the user or
/// [window manager][gtk-X11-arch]) could fullscreen it
/// again, and not all window managers honor requests to unfullscreen
/// windows. But normally the window will end up restored to its normal
/// state. Just don’t write code that crashes if not.
/// </para>
/// <para>
/// You can track the fullscreen state via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Unfullscreen<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_unfullscreen(window);
		return window;
	}

/// <summary>
/// <para>
/// Asks to unmaximize @window. Note that you shouldn’t assume the
/// window is definitely unmaximized afterward, because other entities
/// (e.g. the user or [window manager][gtk-X11-arch])
/// could maximize it again, and not all window
/// managers honor requests to unmaximize. But normally the window will
/// end up unmaximized. Just don’t write code that crashes if not.
/// </para>
/// <para>
/// You can track maximization via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Unmaximize<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_unmaximize(window);
		return window;
	}

/// <summary>
/// <para>
/// Asks to unstick @window, which means that it will appear on only
/// one of the user’s desktops. Note that you shouldn’t assume the
/// window is definitely unstuck afterward, because other entities
/// (e.g. the user or [window manager][gtk-X11-arch]) could
/// stick it again. But normally the window will
/// end up unstuck. Just don’t write code that crashes if not.
/// </para>
/// <para>
/// You can track stickiness via the “window-state-event” signal
/// on #GtkWidget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>

	public static T Unstick<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_unstick(window);
		return window;
	}

}

internal class GtkWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_window_new(MentorLake.Gtk.GtkWindowType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_activate_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_activate_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_activate_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_add_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_add_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, uint keyval, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle target);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_begin_move_drag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, int button, int root_x, int root_y, uint timestamp);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_begin_resize_drag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gdk.GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_deiconify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_fullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_fullscreen_on_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int monitor);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_accept_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))]
	internal static extern MentorLake.Gtk.GtkApplicationHandle gtk_window_get_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_get_attached_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_decorated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_get_default_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_get_default_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_deletable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_destroy_with_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_get_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_focus_on_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_focus_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGravity gtk_window_get_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowGroupHandle gtk_window_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_has_resize_grip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_hide_titlebar_when_maximized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_window_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_window_get_icon_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkModifierType gtk_window_get_mnemonic_modifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_mnemonics_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_window_get_opacity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, out int root_x, out int root_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_resizable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_resize_grip_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_role([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_window_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_skip_pager_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_skip_taskbar_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_get_titlebar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_window_get_transient_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowTypeHint gtk_window_get_type_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_urgency_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWindowType gtk_window_get_window_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_has_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_has_toplevel_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_iconify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_is_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_is_maximized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_maximize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_mnemonic_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, uint keyval, MentorLake.Gdk.GdkModifierType modifier);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_parse_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, string geometry);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_present([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_present_with_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, uint timestamp);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_propagate_key_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_remove_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_remove_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, uint keyval, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle target);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_reshow_with_initial_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_resize_grip_is_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_resize_to_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_accept_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_attached_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle attach_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_decorated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle default_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_default_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_default_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_deletable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_destroy_with_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle focus);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_focus_on_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_focus_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_geometry_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle geometry_widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGeometryHandle>))] MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints geom_mask);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gdk.GdkGravity gravity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_has_resize_grip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_has_user_ref_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_hide_titlebar_when_maximized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_set_icon_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_icon_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_keep_above([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_keep_below([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_mnemonic_modifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gdk.GdkModifierType modifier);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_mnemonics_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool modal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_opacity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, double opacity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gtk.GtkWindowPosition position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_resizable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool resizable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_role([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, string role);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_skip_pager_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_skip_taskbar_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_startup_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, string startup_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_titlebar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle titlebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_transient_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_type_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gdk.GdkWindowTypeHint hint);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_urgency_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_wmclass([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, string wmclass_name, string wmclass_class);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_stick([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_unfullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_unmaximize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_unstick([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_window_get_default_icon_list();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_default_icon_name();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_window_list_toplevels();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_auto_startup_notification(bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_default_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_set_default_icon_from_file(string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_default_icon_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_default_icon_name(string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_set_interactive_debugging(bool enable);

}
