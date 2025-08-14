namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The “system tray” or notification area is normally used for transient icons
/// that indicate some special state. For example, a system tray icon might
/// appear to tell the user that they have new mail, or have an incoming instant
/// message, or something along those lines. The basic idea is that creating an
/// icon in the notification area is less annoying than popping up a dialog.
/// </para>
/// <para>
/// A #GtkStatusIcon object can be used to display an icon in a “system tray”.
/// The icon can have a tooltip, and the user can interact with it by
/// activating it or popping up a context menu.
/// </para>
/// <para>
/// It is very important to notice that status icons depend on the existence
/// of a notification area being available to the user; you should not use status
/// icons as the only way to convey critical information regarding your application,
/// as the notification area may not exist on the user's environment, or may have
/// been removed. You should always check that a status icon has been embedded into
/// a notification area by using gtk_status_icon_is_embedded(), and gracefully
/// recover if the function returns %FALSE.
/// </para>
/// <para>
/// On X11, the implementation follows the
/// [FreeDesktop System Tray Specification](http://www.freedesktop.org/wiki/Specifications/systemtray-spec).
/// Implementations of the “tray” side of this specification can
/// be found e.g. in the GNOME 2 and KDE panel applications.
/// </para>
/// <para>
/// Note that a GtkStatusIcon is not a widget, but just a #GObject. Making it a
/// widget would be impractical, since the system tray on Windows doesn’t allow
/// to embed arbitrary widgets.
/// </para>
/// <para>
/// GtkStatusIcon has been deprecated in 3.14. You should consider using
/// notifications or more modern platform-specific APIs instead. GLib provides
/// the #GNotification API which works well with #GtkApplication on multiple
/// platforms and environments, and should be the preferred mechanism to notify
/// the users of transient status updates. See this [HowDoI](https://wiki.gnome.org/HowDoI/GNotification)
/// for code examples.
/// </para>
/// </summary>

public class GtkStatusIconHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates an empty status icon object.
/// </para>
/// </summary>

/// <return>
/// a new #GtkStatusIcon
/// </return>

	public static MentorLake.Gtk.GtkStatusIconHandle New()
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new();
	}

/// <summary>
/// <para>
/// Creates a status icon displaying the file @filename.
/// </para>
/// <para>
/// The image will be scaled down to fit in the available
/// space in the notification area, if necessary.
/// </para>
/// </summary>

/// <param name="filename">
/// a filename
/// </param>
/// <return>
/// a new #GtkStatusIcon
/// </return>

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromFile(string filename)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_file(filename);
	}

/// <summary>
/// <para>
/// Creates a status icon displaying a #GIcon. If the icon is a
/// themed icon, it will be updated when the theme changes.
/// </para>
/// </summary>

/// <param name="icon">
/// a #GIcon
/// </param>
/// <return>
/// a new #GtkStatusIcon
/// </return>

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromGicon(MentorLake.Gio.GIconHandle icon)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_gicon(icon);
	}

/// <summary>
/// <para>
/// Creates a status icon displaying an icon from the current icon theme.
/// If the current icon theme is changed, the icon will be updated
/// appropriately.
/// </para>
/// </summary>

/// <param name="icon_name">
/// an icon name
/// </param>
/// <return>
/// a new #GtkStatusIcon
/// </return>

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromIconName(string icon_name)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_icon_name(icon_name);
	}

/// <summary>
/// <para>
/// Creates a status icon displaying @pixbuf.
/// </para>
/// <para>
/// The image will be scaled down to fit in the available
/// space in the notification area, if necessary.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a #GdkPixbuf
/// </param>
/// <return>
/// a new #GtkStatusIcon
/// </return>

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_pixbuf(pixbuf);
	}

/// <summary>
/// <para>
/// Creates a status icon displaying a stock icon. Sample stock icon
/// names are #GTK_STOCK_OPEN, #GTK_STOCK_QUIT. You can register your
/// own stock icon names, see gtk_icon_factory_add_default() and
/// gtk_icon_factory_add().
/// </para>
/// </summary>

/// <param name="stock_id">
/// a stock icon id
/// </param>
/// <return>
/// a new #GtkStatusIcon
/// </return>

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromStock(string stock_id)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_stock(stock_id);
	}

/// <summary>
/// <para>
/// Menu positioning function to use with gtk_menu_popup()
/// to position @menu aligned to the status icon @user_data.
/// </para>
/// </summary>

/// <param name="menu">
/// the #GtkMenu
/// </param>
/// <param name="x">
/// return location for the x position
/// </param>
/// <param name="y">
/// return location for the y position
/// </param>
/// <param name="push_in">
/// whether the first menu item should be offset
///           (pushed in) to be aligned with the menu popup position
///           (only useful for GtkOptionMenu).
/// </param>
/// <param name="user_data">
/// the status icon to position the menu on
/// </param>

	public static void PositionMenu(MentorLake.Gtk.GtkMenuHandle menu, ref int x, ref int y, out bool push_in, MentorLake.Gtk.GtkStatusIconHandle user_data)
	{
		GtkStatusIconHandleExterns.gtk_status_icon_position_menu(menu, ref x, ref y, out push_in, user_data);
	}

}
public static class GtkStatusIconHandleSignalExtensions
{
/// <summary>
/// <para>
/// Gets emitted when the user activates the status icon.
/// If and how status icons can activated is platform-dependent.
/// </para>
/// <para>
/// Unlike most G_SIGNAL_ACTION signals, this signal is meant to
/// be used by applications and should be wrapped by language bindings.
/// </para>
/// </summary>

	public static IObservable<GtkStatusIconHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.ActivateSignal()
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
/// <summary>
/// <para>
/// The ::button-press-event signal will be emitted when a button
/// (typically from a mouse) is pressed.
/// </para>
/// <para>
/// Whether this event is emitted is platform-dependent.  Use the ::activate
/// and ::popup-menu signals in preference.
/// </para>
/// </summary>

	public static IObservable<GtkStatusIconHandleSignalStructs.ButtonPressEventSignal> Signal_ButtonPressEvent(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.ButtonPressEventSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.button_press_event handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  MentorLake.Gdk.GdkEventButtonHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.ButtonPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "button-press-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::button-release-event signal will be emitted when a button
/// (typically from a mouse) is released.
/// </para>
/// <para>
/// Whether this event is emitted is platform-dependent.  Use the ::activate
/// and ::popup-menu signals in preference.
/// </para>
/// </summary>

	public static IObservable<GtkStatusIconHandleSignalStructs.ButtonReleaseEventSignal> Signal_ButtonReleaseEvent(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.ButtonReleaseEventSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.button_release_event handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  MentorLake.Gdk.GdkEventButtonHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.ButtonReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "button-release-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Gets emitted when the user brings up the context menu
/// of the status icon. Whether status icons can have context
/// menus and how these are activated is platform-dependent.
/// </para>
/// <para>
/// The @button and @activate_time parameters should be
/// passed as the last to arguments to gtk_menu_popup().
/// </para>
/// <para>
/// Unlike most G_SIGNAL_ACTION signals, this signal is meant to
/// be used by applications and should be wrapped by language bindings.
/// </para>
/// </summary>

	public static IObservable<GtkStatusIconHandleSignalStructs.PopupMenuSignal> Signal_PopupMenu(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.PopupMenuSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.popup_menu handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  uint button,  uint activate_time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.PopupMenuSignal()
				{
					Self = self, Button = button, ActivateTime = activate_time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popup-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the hover timeout has expired with the
/// cursor hovering above @status_icon; or emitted when @status_icon got
/// focus in keyboard mode.
/// </para>
/// <para>
/// Using the given coordinates, the signal handler should determine
/// whether a tooltip should be shown for @status_icon. If this is
/// the case %TRUE should be returned, %FALSE otherwise. Note that if
/// @keyboard_mode is %TRUE, the values of @x and @y are undefined and
/// should not be used.
/// </para>
/// <para>
/// The signal handler is free to manipulate @tooltip with the therefore
/// destined function calls.
/// </para>
/// <para>
/// Whether this signal is emitted is platform-dependent.
/// For plain text tooltips, use #GtkStatusIcon:tooltip-text in preference.
/// </para>
/// </summary>

	public static IObservable<GtkStatusIconHandleSignalStructs.QueryTooltipSignal> Signal_QueryTooltip(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.QueryTooltipSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.query_tooltip handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  int x,  int y,  bool keyboard_mode,  MentorLake.Gtk.GtkTooltipHandle tooltip,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.QueryTooltipSignal()
				{
					Self = self, X = x, Y = y, KeyboardMode = keyboard_mode, Tooltip = tooltip, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "query-tooltip", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::scroll-event signal is emitted when a button in the 4 to 7
/// range is pressed. Wheel mice are usually configured to generate
/// button press events for buttons 4 and 5 when the wheel is turned.
/// </para>
/// <para>
/// Whether this event is emitted is platform-dependent.
/// </para>
/// </summary>

	public static IObservable<GtkStatusIconHandleSignalStructs.ScrollEventSignal> Signal_ScrollEvent(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.ScrollEventSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.scroll_event handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  MentorLake.Gdk.GdkEventScrollHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.ScrollEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Gets emitted when the size available for the image
/// changes, e.g. because the notification area got resized.
/// </para>
/// </summary>

	public static IObservable<GtkStatusIconHandleSignalStructs.SizeChangedSignal> Signal_SizeChanged(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.SizeChangedSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.size_changed handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  int size,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.SizeChangedSignal()
				{
					Self = self, Size = size, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "size-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkStatusIconHandleSignalStructs
{

public class ActivateSignal
{

	public MentorLake.Gtk.GtkStatusIconHandle Self;

	public IntPtr UserData;
}

public class ButtonPressEventSignal
{

	public MentorLake.Gtk.GtkStatusIconHandle Self;
/// <summary>
/// <para>
/// the #GdkEventButton which triggered
///                                 this signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventButtonHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked
/// for the event. %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ButtonReleaseEventSignal
{

	public MentorLake.Gtk.GtkStatusIconHandle Self;
/// <summary>
/// <para>
/// the #GdkEventButton which triggered
///                                 this signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventButtonHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked
/// for the event. %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class PopupMenuSignal
{

	public MentorLake.Gtk.GtkStatusIconHandle Self;
/// <summary>
/// <para>
/// the button that was pressed, or 0 if the
///   signal is not emitted in response to a button press event
/// </para>
/// </summary>

	public uint Button;
/// <summary>
/// <para>
/// the timestamp of the event that
///   triggered the signal emission
/// </para>
/// </summary>

	public uint ActivateTime;

	public IntPtr UserData;
}

public class QueryTooltipSignal
{

	public MentorLake.Gtk.GtkStatusIconHandle Self;
/// <summary>
/// <para>
/// the x coordinate of the cursor position where the request has been
///     emitted, relative to @status_icon
/// </para>
/// </summary>

	public int X;
/// <summary>
/// <para>
/// the y coordinate of the cursor position where the request has been
///     emitted, relative to @status_icon
/// </para>
/// </summary>

	public int Y;
/// <summary>
/// <para>
/// %TRUE if the tooltip was trigged using the keyboard
/// </para>
/// </summary>

	public bool KeyboardMode;
/// <summary>
/// <para>
/// a #GtkTooltip
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTooltipHandle Tooltip;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if @tooltip should be shown right now, %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ScrollEventSignal
{

	public MentorLake.Gtk.GtkStatusIconHandle Self;
/// <summary>
/// <para>
/// the #GdkEventScroll which triggered
///                                 this signal
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventScrollHandle Event;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class SizeChangedSignal
{

	public MentorLake.Gtk.GtkStatusIconHandle Self;
/// <summary>
/// <para>
/// the new size
/// </para>
/// </summary>

	public int Size;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the icon was updated for the new
/// size. Otherwise, GTK+ will scale the icon as necessary.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GtkStatusIconHandleSignalDelegates
{

/// <summary>
/// <para>
/// Gets emitted when the user activates the status icon.
/// If and how status icons can activated is platform-dependent.
/// </para>
/// <para>
/// Unlike most G_SIGNAL_ACTION signals, this signal is meant to
/// be used by applications and should be wrapped by language bindings.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::button-press-event signal will be emitted when a button
/// (typically from a mouse) is pressed.
/// </para>
/// <para>
/// Whether this event is emitted is platform-dependent.  Use the ::activate
/// and ::popup-menu signals in preference.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventButton which triggered
///                                 this signal
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked
/// for the event. %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventButtonHandle>))] MentorLake.Gdk.GdkEventButtonHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::button-release-event signal will be emitted when a button
/// (typically from a mouse) is released.
/// </para>
/// <para>
/// Whether this event is emitted is platform-dependent.  Use the ::activate
/// and ::popup-menu signals in preference.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventButton which triggered
///                                 this signal
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked
/// for the event. %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventButtonHandle>))] MentorLake.Gdk.GdkEventButtonHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted when the user brings up the context menu
/// of the status icon. Whether status icons can have context
/// menus and how these are activated is platform-dependent.
/// </para>
/// <para>
/// The @button and @activate_time parameters should be
/// passed as the last to arguments to gtk_menu_popup().
/// </para>
/// <para>
/// Unlike most G_SIGNAL_ACTION signals, this signal is meant to
/// be used by applications and should be wrapped by language bindings.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="button">
/// the button that was pressed, or 0 if the
///   signal is not emitted in response to a button press event
/// </param>
/// <param name="activate_time">
/// the timestamp of the event that
///   triggered the signal emission
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, uint button, uint activate_time, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the hover timeout has expired with the
/// cursor hovering above @status_icon; or emitted when @status_icon got
/// focus in keyboard mode.
/// </para>
/// <para>
/// Using the given coordinates, the signal handler should determine
/// whether a tooltip should be shown for @status_icon. If this is
/// the case %TRUE should be returned, %FALSE otherwise. Note that if
/// @keyboard_mode is %TRUE, the values of @x and @y are undefined and
/// should not be used.
/// </para>
/// <para>
/// The signal handler is free to manipulate @tooltip with the therefore
/// destined function calls.
/// </para>
/// <para>
/// Whether this signal is emitted is platform-dependent.
/// For plain text tooltips, use #GtkStatusIcon:tooltip-text in preference.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="x">
/// the x coordinate of the cursor position where the request has been
///     emitted, relative to @status_icon
/// </param>
/// <param name="y">
/// the y coordinate of the cursor position where the request has been
///     emitted, relative to @status_icon
/// </param>
/// <param name="keyboard_mode">
/// %TRUE if the tooltip was trigged using the keyboard
/// </param>
/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if @tooltip should be shown right now, %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool query_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, int x, int y, bool keyboard_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, IntPtr user_data);


/// <summary>
/// <para>
/// The ::scroll-event signal is emitted when a button in the 4 to 7
/// range is pressed. Wheel mice are usually configured to generate
/// button press events for buttons 4 and 5 when the wheel is turned.
/// </para>
/// <para>
/// Whether this event is emitted is platform-dependent.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #GdkEventScroll which triggered
///                                 this signal
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventScrollHandle>))] MentorLake.Gdk.GdkEventScrollHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted when the size available for the image
/// changes, e.g. because the notification area got resized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="size">
/// the new size
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the icon was updated for the new
/// size. Otherwise, GTK+ will scale the icon as necessary.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool size_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, int size, IntPtr user_data);

}


public static class GtkStatusIconHandleExtensions
{
/// <summary>
/// <para>
/// Obtains information about the location of the status icon
/// on screen. This information can be used to e.g. position
/// popups like notification bubbles.
/// </para>
/// <para>
/// See gtk_status_icon_position_menu() for a more convenient
/// alternative for positioning menus.
/// </para>
/// <para>
/// Note that some platforms do not allow GTK+ to provide
/// this information, and even on platforms that do allow it,
/// the information is not reliable unless the status icon
/// is embedded in a notification area, see
/// gtk_status_icon_is_embedded().
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="screen">
/// return location for
///          the screen, or %NULL if the information is not needed
/// </param>
/// <param name="area">
/// return location for the area occupied by
///        the status icon, or %NULL
/// </param>
/// <param name="orientation">
/// return location for the
///    orientation of the panel in which the status icon is embedded,
///    or %NULL. A panel at the top or bottom of the screen is
///    horizontal, a panel at the left or right is vertical.
/// </param>
/// <return>
/// %TRUE if the location information has
///               been filled in
/// </return>

	public static bool GetGeometry(this MentorLake.Gtk.GtkStatusIconHandle status_icon, out MentorLake.Gdk.GdkScreenHandle screen, out MentorLake.Gdk.GdkRectangle area, out MentorLake.Gtk.GtkOrientation orientation)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_geometry(status_icon, out screen, out area, out orientation);
	}

/// <summary>
/// <para>
/// Retrieves the #GIcon being displayed by the #GtkStatusIcon.
/// The storage type of the status icon must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_GICON (see gtk_status_icon_get_storage_type()).
/// The caller of this function does not own a reference to the
/// returned #GIcon.
/// </para>
/// <para>
/// If this function fails, @icon is left unchanged;
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// the displayed icon, or %NULL if the image is empty
/// </return>

	public static MentorLake.Gio.GIconHandle GetGicon(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_gicon(status_icon);
	}

/// <summary>
/// <para>
/// Returns the current value of the has-tooltip property.
/// See #GtkStatusIcon:has-tooltip for more information.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// current value of has-tooltip on @status_icon.
/// </return>

	public static bool GetHasTooltip(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_has_tooltip(status_icon);
	}

/// <summary>
/// <para>
/// Gets the name of the icon being displayed by the #GtkStatusIcon.
/// The storage type of the status icon must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_ICON_NAME (see gtk_status_icon_get_storage_type()).
/// The returned string is owned by the #GtkStatusIcon and should not
/// be freed or modified.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// name of the displayed icon, or %NULL if the image is empty.
/// </return>

	public static string GetIconName(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_icon_name(status_icon);
	}

/// <summary>
/// <para>
/// Gets the #GdkPixbuf being displayed by the #GtkStatusIcon.
/// The storage type of the status icon must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_PIXBUF (see gtk_status_icon_get_storage_type()).
/// The caller of this function does not own a reference to the
/// returned pixbuf.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// the displayed pixbuf,
///     or %NULL if the image is empty.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_pixbuf(status_icon);
	}

/// <summary>
/// <para>
/// Returns the #GdkScreen associated with @status_icon.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// a #GdkScreen.
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_screen(status_icon);
	}

/// <summary>
/// <para>
/// Gets the size in pixels that is available for the image.
/// Stock icons and named icons adapt their size automatically
/// if the size of the notification area changes. For other
/// storage types, the size-changed signal can be used to
/// react to size changes.
/// </para>
/// <para>
/// Note that the returned size is only meaningful while the
/// status icon is embedded (see gtk_status_icon_is_embedded()).
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// the size that is available for the image
/// </return>

	public static int GetSize(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_size(status_icon);
	}

/// <summary>
/// <para>
/// Gets the id of the stock icon being displayed by the #GtkStatusIcon.
/// The storage type of the status icon must be %GTK_IMAGE_EMPTY or
/// %GTK_IMAGE_STOCK (see gtk_status_icon_get_storage_type()).
/// The returned string is owned by the #GtkStatusIcon and should not
/// be freed or modified.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// stock id of the displayed stock icon,
///   or %NULL if the image is empty.
/// </return>

	public static string GetStock(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_stock(status_icon);
	}

/// <summary>
/// <para>
/// Gets the type of representation being used by the #GtkStatusIcon
/// to store image data. If the #GtkStatusIcon has no image data,
/// the return value will be %GTK_IMAGE_EMPTY.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// the image representation being used
/// </return>

	public static MentorLake.Gtk.GtkImageType GetStorageType(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_storage_type(status_icon);
	}

/// <summary>
/// <para>
/// Gets the title of this tray icon. See gtk_status_icon_set_title().
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// the title of the status icon
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_title(status_icon);
	}

/// <summary>
/// <para>
/// Gets the contents of the tooltip for @status_icon.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// the tooltip text, or %NULL. You should free the
///   returned string with g_free() when done.
/// </return>

	public static string GetTooltipMarkup(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_tooltip_markup(status_icon);
	}

/// <summary>
/// <para>
/// Gets the contents of the tooltip for @status_icon.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// the tooltip text, or %NULL. You should free the
///   returned string with g_free() when done.
/// </return>

	public static string GetTooltipText(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_tooltip_text(status_icon);
	}

/// <summary>
/// <para>
/// Returns whether the status icon is visible or not.
/// Note that being visible does not guarantee that
/// the user can actually see the icon, see also
/// gtk_status_icon_is_embedded().
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// %TRUE if the status icon is visible
/// </return>

	public static bool GetVisible(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_visible(status_icon);
	}

/// <summary>
/// <para>
/// This function is only useful on the X11/freedesktop.org platform.
/// </para>
/// <para>
/// It returns a window ID for the widget in the underlying
/// status icon implementation.  This is useful for the Galago
/// notification service, which can send a window ID in the protocol
/// in order for the server to position notification windows
/// pointing to a status icon reliably.
/// </para>
/// <para>
/// This function is not intended for other use cases which are
/// more likely to be met by one of the non-X11 specific methods, such
/// as gtk_status_icon_position_menu().
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// An 32 bit unsigned integer identifier for the
/// underlying X11 Window
/// </return>

	public static uint GetX11WindowId(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_x11_window_id(status_icon);
	}

/// <summary>
/// <para>
/// Returns whether the status icon is embedded in a notification
/// area.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <return>
/// %TRUE if the status icon is embedded in
///   a notification area.
/// </return>

	public static bool IsEmbedded(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_is_embedded(status_icon);
	}

/// <summary>
/// <para>
/// Makes @status_icon display the file @filename.
/// See gtk_status_icon_new_from_file() for details.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="filename">
/// a filename
/// </param>

	public static T SetFromFile<T>(this T status_icon, string filename) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_file(status_icon, filename);
		return status_icon;
	}

/// <summary>
/// <para>
/// Makes @status_icon display the #GIcon.
/// See gtk_status_icon_new_from_gicon() for details.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="icon">
/// a GIcon
/// </param>

	public static T SetFromGicon<T>(this T status_icon, MentorLake.Gio.GIconHandle icon) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_gicon(status_icon, icon);
		return status_icon;
	}

/// <summary>
/// <para>
/// Makes @status_icon display the icon named @icon_name from the
/// current icon theme.
/// See gtk_status_icon_new_from_icon_name() for details.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="icon_name">
/// an icon name
/// </param>

	public static T SetFromIconName<T>(this T status_icon, string icon_name) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_icon_name(status_icon, icon_name);
		return status_icon;
	}

/// <summary>
/// <para>
/// Makes @status_icon display @pixbuf.
/// See gtk_status_icon_new_from_pixbuf() for details.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="pixbuf">
/// a #GdkPixbuf or %NULL
/// </param>

	public static T SetFromPixbuf<T>(this T status_icon, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_pixbuf(status_icon, pixbuf);
		return status_icon;
	}

/// <summary>
/// <para>
/// Makes @status_icon display the stock icon with the id @stock_id.
/// See gtk_status_icon_new_from_stock() for details.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="stock_id">
/// a stock icon id
/// </param>

	public static T SetFromStock<T>(this T status_icon, string stock_id) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_stock(status_icon, stock_id);
		return status_icon;
	}

/// <summary>
/// <para>
/// Sets the has-tooltip property on @status_icon to @has_tooltip.
/// See #GtkStatusIcon:has-tooltip for more information.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="has_tooltip">
/// whether or not @status_icon has a tooltip
/// </param>

	public static T SetHasTooltip<T>(this T status_icon, bool has_tooltip) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_has_tooltip(status_icon, has_tooltip);
		return status_icon;
	}

/// <summary>
/// <para>
/// Sets the name of this tray icon.
/// This should be a string identifying this icon. It is may be
/// used for sorting the icons in the tray and will not be shown to
/// the user.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="name">
/// the name
/// </param>

	public static T SetName<T>(this T status_icon, string name) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_name(status_icon, name);
		return status_icon;
	}

/// <summary>
/// <para>
/// Sets the #GdkScreen where @status_icon is displayed; if
/// the icon is already mapped, it will be unmapped, and
/// then remapped on the new screen.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="screen">
/// a #GdkScreen
/// </param>

	public static T SetScreen<T>(this T status_icon, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_screen(status_icon, screen);
		return status_icon;
	}

/// <summary>
/// <para>
/// Sets the title of this tray icon.
/// This should be a short, human-readable, localized string
/// describing the tray icon. It may be used by tools like screen
/// readers to render the tray icon.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="title">
/// the title
/// </param>

	public static T SetTitle<T>(this T status_icon, string title) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_title(status_icon, title);
		return status_icon;
	}

/// <summary>
/// <para>
/// Sets @markup as the contents of the tooltip, which is marked up with
///  the [Pango text markup language][PangoMarkupFormat].
/// </para>
/// <para>
/// This function will take care of setting #GtkStatusIcon:has-tooltip to %TRUE
/// and of the default handler for the #GtkStatusIcon::query-tooltip signal.
/// </para>
/// <para>
/// See also the #GtkStatusIcon:tooltip-markup property and
/// gtk_tooltip_set_markup().
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="markup">
/// the contents of the tooltip for @status_icon, or %NULL
/// </param>

	public static T SetTooltipMarkup<T>(this T status_icon, string markup) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_tooltip_markup(status_icon, markup);
		return status_icon;
	}

/// <summary>
/// <para>
/// Sets @text as the contents of the tooltip.
/// </para>
/// <para>
/// This function will take care of setting #GtkStatusIcon:has-tooltip to
/// %TRUE and of the default handler for the #GtkStatusIcon::query-tooltip
/// signal.
/// </para>
/// <para>
/// See also the #GtkStatusIcon:tooltip-text property and
/// gtk_tooltip_set_text().
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="text">
/// the contents of the tooltip for @status_icon
/// </param>

	public static T SetTooltipText<T>(this T status_icon, string text) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_tooltip_text(status_icon, text);
		return status_icon;
	}

/// <summary>
/// <para>
/// Shows or hides a status icon.
/// </para>
/// </summary>

/// <param name="status_icon">
/// a #GtkStatusIcon
/// </param>
/// <param name="visible">
/// %TRUE to show the status icon, %FALSE to hide it
/// </param>

	public static T SetVisible<T>(this T status_icon, bool visible) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid) throw new Exception("Invalid handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_visible(status_icon, visible);
		return status_icon;
	}

}

internal class GtkStatusIconHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_file(string filename);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_icon_name(string icon_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_status_icon_get_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] out MentorLake.Gdk.GdkScreenHandle screen, out MentorLake.Gdk.GdkRectangle area, out MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle gtk_status_icon_get_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_status_icon_get_has_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_status_icon_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_status_icon_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_status_icon_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageType gtk_status_icon_get_storage_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_status_icon_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_status_icon_get_x11_window_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_status_icon_is_embedded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_has_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, bool has_tooltip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_position_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, ref int x, ref int y, out bool push_in, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle user_data);

}
