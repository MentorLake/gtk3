namespace MentorLake.Gtk3.Gtk3;

public class GtkWindowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkWindowHandle New(GtkWindowType type)
	{
		return GtkWindowExterns.gtk_window_new(type);
	}

	public static GListHandle GetDefaultIconList()
	{
		return GtkWindowExterns.gtk_window_get_default_icon_list();
	}

	public static string GetDefaultIconName()
	{
		return GtkWindowExterns.gtk_window_get_default_icon_name();
	}

	public static GListHandle ListToplevels()
	{
		return GtkWindowExterns.gtk_window_list_toplevels();
	}

	public static void SetAutoStartupNotification(bool setting)
	{
		GtkWindowExterns.gtk_window_set_auto_startup_notification(setting);
	}

	public static void SetDefaultIcon(GdkPixbufHandle icon)
	{
		GtkWindowExterns.gtk_window_set_default_icon(icon);
	}

	public static bool SetDefaultIconFromFile(string filename, out GErrorHandle error)
	{
		return GtkWindowExterns.gtk_window_set_default_icon_from_file(filename, out error);
	}

	public static void SetDefaultIconList(GListHandle list)
	{
		GtkWindowExterns.gtk_window_set_default_icon_list(list);
	}

	public static void SetDefaultIconName(string name)
	{
		GtkWindowExterns.gtk_window_set_default_icon_name(name);
	}

	public static void SetInteractiveDebugging(bool enable)
	{
		GtkWindowExterns.gtk_window_set_interactive_debugging(enable);
	}

}

public static class GtkWindowSignalExtensions
{

	public static IObservable<GtkWindowSignalStructs.ActivateDefaultSignal> Signal_ActivateDefault(this GtkWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkWindowSignalStructs.ActivateDefaultSignal> obs) =>
		{
			GtkWindowSignalDelegates.activate_default handler = (GtkWindowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowSignalStructs.ActivateDefaultSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_default", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWindowSignalStructs.ActivateFocusSignal> Signal_ActivateFocus(this GtkWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkWindowSignalStructs.ActivateFocusSignal> obs) =>
		{
			GtkWindowSignalDelegates.activate_focus handler = (GtkWindowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowSignalStructs.ActivateFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWindowSignalStructs.EnableDebuggingSignal> Signal_EnableDebugging(this GtkWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkWindowSignalStructs.EnableDebuggingSignal> obs) =>
		{
			GtkWindowSignalDelegates.enable_debugging handler = (GtkWindowHandle self, bool toggle, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowSignalStructs.EnableDebuggingSignal()
				{
					Self = self, Toggle = toggle, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "enable_debugging", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWindowSignalStructs.KeysChangedSignal> Signal_KeysChanged(this GtkWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkWindowSignalStructs.KeysChangedSignal> obs) =>
		{
			GtkWindowSignalDelegates.keys_changed handler = (GtkWindowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowSignalStructs.KeysChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "keys_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWindowSignalStructs.SetFocusSignal> Signal_SetFocus(this GtkWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkWindowSignalStructs.SetFocusSignal> obs) =>
		{
			GtkWindowSignalDelegates.set_focus handler = (GtkWindowHandle self, GtkWidgetHandle widget, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowSignalStructs.SetFocusSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "set_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkWindowSignalStructs
{

public struct ActivateDefaultSignal
{
	public GtkWindowHandle Self;
	public IntPtr UserData;
}

public struct ActivateFocusSignal
{
	public GtkWindowHandle Self;
	public IntPtr UserData;
}

public struct EnableDebuggingSignal
{
	public GtkWindowHandle Self;
	public bool Toggle;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct KeysChangedSignal
{
	public GtkWindowHandle Self;
	public IntPtr UserData;
}

public struct SetFocusSignal
{
	public GtkWindowHandle Self;
	public GtkWidgetHandle Widget;
	public IntPtr UserData;
}
}

public static class GtkWindowSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWindowHandle>))] GtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWindowHandle>))] GtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool enable_debugging([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWindowHandle>))] GtkWindowHandle self, bool toggle, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void keys_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWindowHandle>))] GtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void set_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWindowHandle>))] GtkWindowHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle widget, IntPtr user_data);

}


public static class GtkWindowHandleExtensions
{
	public static bool ActivateDefault(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_activate_default(window);
	}

	public static bool ActivateFocus(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_activate_focus(window);
	}

	public static bool ActivateKey(this GtkWindowHandle window, GdkEventKeyHandle @event)
	{
		return GtkWindowExterns.gtk_window_activate_key(window, @event);
	}

	public static GtkWindowHandle AddAccelGroup(this GtkWindowHandle window, GtkAccelGroupHandle accel_group)
	{
		GtkWindowExterns.gtk_window_add_accel_group(window, accel_group);
		return window;
	}

	public static GtkWindowHandle AddMnemonic(this GtkWindowHandle window, uint keyval, GtkWidgetHandle target)
	{
		GtkWindowExterns.gtk_window_add_mnemonic(window, keyval, target);
		return window;
	}

	public static GtkWindowHandle BeginMoveDrag(this GtkWindowHandle window, int button, int root_x, int root_y, uint timestamp)
	{
		GtkWindowExterns.gtk_window_begin_move_drag(window, button, root_x, root_y, timestamp);
		return window;
	}

	public static GtkWindowHandle BeginResizeDrag(this GtkWindowHandle window, GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp)
	{
		GtkWindowExterns.gtk_window_begin_resize_drag(window, edge, button, root_x, root_y, timestamp);
		return window;
	}

	public static GtkWindowHandle Close(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_close(window);
		return window;
	}

	public static GtkWindowHandle Deiconify(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_deiconify(window);
		return window;
	}

	public static GtkWindowHandle Fullscreen(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_fullscreen(window);
		return window;
	}

	public static GtkWindowHandle FullscreenOnMonitor(this GtkWindowHandle window, GdkScreenHandle screen, int monitor)
	{
		GtkWindowExterns.gtk_window_fullscreen_on_monitor(window, screen, monitor);
		return window;
	}

	public static bool GetAcceptFocus(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_accept_focus(window);
	}

	public static GtkApplicationHandle GetApplication(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_application(window);
	}

	public static GtkWidgetHandle GetAttachedTo(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_attached_to(window);
	}

	public static bool GetDecorated(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_decorated(window);
	}

	public static GtkWindowHandle GetDefaultSize(this GtkWindowHandle window, out int width, out int height)
	{
		GtkWindowExterns.gtk_window_get_default_size(window, out width, out height);
		return window;
	}

	public static GtkWidgetHandle GetDefaultWidget(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_default_widget(window);
	}

	public static bool GetDeletable(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_deletable(window);
	}

	public static bool GetDestroyWithParent(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_destroy_with_parent(window);
	}

	public static GtkWidgetHandle GetFocus(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_focus(window);
	}

	public static bool GetFocusOnMap(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_focus_on_map(window);
	}

	public static bool GetFocusVisible(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_focus_visible(window);
	}

	public static GdkGravity GetGravity(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_gravity(window);
	}

	public static GtkWindowGroupHandle GetGroup(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_group(window);
	}

	public static bool GetHasResizeGrip(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_has_resize_grip(window);
	}

	public static bool GetHideTitlebarWhenMaximized(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_hide_titlebar_when_maximized(window);
	}

	public static GdkPixbufHandle GetIcon(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_icon(window);
	}

	public static GListHandle GetIconList(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_icon_list(window);
	}

	public static string GetIconName(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_icon_name(window);
	}

	public static GdkModifierType GetMnemonicModifier(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_mnemonic_modifier(window);
	}

	public static bool GetMnemonicsVisible(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_mnemonics_visible(window);
	}

	public static bool GetModal(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_modal(window);
	}

	public static double GetOpacity(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_opacity(window);
	}

	public static GtkWindowHandle GetPosition(this GtkWindowHandle window, out int root_x, out int root_y)
	{
		GtkWindowExterns.gtk_window_get_position(window, out root_x, out root_y);
		return window;
	}

	public static bool GetResizable(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_resizable(window);
	}

	public static bool GetResizeGripArea(this GtkWindowHandle window, out GdkRectangle rect)
	{
		return GtkWindowExterns.gtk_window_get_resize_grip_area(window, out rect);
	}

	public static string GetRole(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_role(window);
	}

	public static GdkScreenHandle GetScreen(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_screen(window);
	}

	public static GtkWindowHandle GetSize(this GtkWindowHandle window, out int width, out int height)
	{
		GtkWindowExterns.gtk_window_get_size(window, out width, out height);
		return window;
	}

	public static bool GetSkipPagerHint(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_skip_pager_hint(window);
	}

	public static bool GetSkipTaskbarHint(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_skip_taskbar_hint(window);
	}

	public static string GetTitle(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_title(window);
	}

	public static GtkWidgetHandle GetTitlebar(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_titlebar(window);
	}

	public static GtkWindowHandle GetTransientFor(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_transient_for(window);
	}

	public static GdkWindowTypeHint GetTypeHint(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_type_hint(window);
	}

	public static bool GetUrgencyHint(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_urgency_hint(window);
	}

	public static GtkWindowType GetWindowType(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_window_type(window);
	}

	public static bool HasGroup(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_has_group(window);
	}

	public static bool HasToplevelFocus(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_has_toplevel_focus(window);
	}

	public static GtkWindowHandle Iconify(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_iconify(window);
		return window;
	}

	public static bool IsActive(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_active(window);
	}

	public static bool IsMaximized(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_maximized(window);
	}

	public static GtkWindowHandle Maximize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_maximize(window);
		return window;
	}

	public static bool MnemonicActivate(this GtkWindowHandle window, uint keyval, GdkModifierType modifier)
	{
		return GtkWindowExterns.gtk_window_mnemonic_activate(window, keyval, modifier);
	}

	public static GtkWindowHandle Move(this GtkWindowHandle window, int x, int y)
	{
		GtkWindowExterns.gtk_window_move(window, x, y);
		return window;
	}

	public static bool ParseGeometry(this GtkWindowHandle window, string geometry)
	{
		return GtkWindowExterns.gtk_window_parse_geometry(window, geometry);
	}

	public static GtkWindowHandle Present(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_present(window);
		return window;
	}

	public static GtkWindowHandle PresentWithTime(this GtkWindowHandle window, uint timestamp)
	{
		GtkWindowExterns.gtk_window_present_with_time(window, timestamp);
		return window;
	}

	public static bool PropagateKeyEvent(this GtkWindowHandle window, GdkEventKeyHandle @event)
	{
		return GtkWindowExterns.gtk_window_propagate_key_event(window, @event);
	}

	public static GtkWindowHandle RemoveAccelGroup(this GtkWindowHandle window, GtkAccelGroupHandle accel_group)
	{
		GtkWindowExterns.gtk_window_remove_accel_group(window, accel_group);
		return window;
	}

	public static GtkWindowHandle RemoveMnemonic(this GtkWindowHandle window, uint keyval, GtkWidgetHandle target)
	{
		GtkWindowExterns.gtk_window_remove_mnemonic(window, keyval, target);
		return window;
	}

	public static GtkWindowHandle ReshowWithInitialSize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_reshow_with_initial_size(window);
		return window;
	}

	public static GtkWindowHandle Resize(this GtkWindowHandle window, int width, int height)
	{
		GtkWindowExterns.gtk_window_resize(window, width, height);
		return window;
	}

	public static bool ResizeGripIsVisible(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_resize_grip_is_visible(window);
	}

	public static GtkWindowHandle ResizeToGeometry(this GtkWindowHandle window, int width, int height)
	{
		GtkWindowExterns.gtk_window_resize_to_geometry(window, width, height);
		return window;
	}

	public static GtkWindowHandle SetAcceptFocus(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_accept_focus(window, setting);
		return window;
	}

	public static GtkWindowHandle SetApplication(this GtkWindowHandle window, GtkApplicationHandle application)
	{
		GtkWindowExterns.gtk_window_set_application(window, application);
		return window;
	}

	public static GtkWindowHandle SetAttachedTo(this GtkWindowHandle window, GtkWidgetHandle attach_widget)
	{
		GtkWindowExterns.gtk_window_set_attached_to(window, attach_widget);
		return window;
	}

	public static GtkWindowHandle SetDecorated(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_decorated(window, setting);
		return window;
	}

	public static GtkWindowHandle SetDefault(this GtkWindowHandle window, GtkWidgetHandle default_widget)
	{
		GtkWindowExterns.gtk_window_set_default(window, default_widget);
		return window;
	}

	public static GtkWindowHandle SetDefaultGeometry(this GtkWindowHandle window, int width, int height)
	{
		GtkWindowExterns.gtk_window_set_default_geometry(window, width, height);
		return window;
	}

	public static GtkWindowHandle SetDefaultSize(this GtkWindowHandle window, int width, int height)
	{
		GtkWindowExterns.gtk_window_set_default_size(window, width, height);
		return window;
	}

	public static GtkWindowHandle SetDeletable(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_deletable(window, setting);
		return window;
	}

	public static GtkWindowHandle SetDestroyWithParent(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_destroy_with_parent(window, setting);
		return window;
	}

	public static GtkWindowHandle SetFocus(this GtkWindowHandle window, GtkWidgetHandle focus)
	{
		GtkWindowExterns.gtk_window_set_focus(window, focus);
		return window;
	}

	public static GtkWindowHandle SetFocusOnMap(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_focus_on_map(window, setting);
		return window;
	}

	public static GtkWindowHandle SetFocusVisible(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_focus_visible(window, setting);
		return window;
	}

	public static GtkWindowHandle SetGeometryHints(this GtkWindowHandle window, GtkWidgetHandle geometry_widget, GdkGeometryHandle geometry, GdkWindowHints geom_mask)
	{
		GtkWindowExterns.gtk_window_set_geometry_hints(window, geometry_widget, geometry, geom_mask);
		return window;
	}

	public static GtkWindowHandle SetGravity(this GtkWindowHandle window, GdkGravity gravity)
	{
		GtkWindowExterns.gtk_window_set_gravity(window, gravity);
		return window;
	}

	public static GtkWindowHandle SetHasResizeGrip(this GtkWindowHandle window, bool value)
	{
		GtkWindowExterns.gtk_window_set_has_resize_grip(window, value);
		return window;
	}

	public static GtkWindowHandle SetHasUserRefCount(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_has_user_ref_count(window, setting);
		return window;
	}

	public static GtkWindowHandle SetHideTitlebarWhenMaximized(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_hide_titlebar_when_maximized(window, setting);
		return window;
	}

	public static GtkWindowHandle SetIcon(this GtkWindowHandle window, GdkPixbufHandle icon)
	{
		GtkWindowExterns.gtk_window_set_icon(window, icon);
		return window;
	}

	public static bool SetIconFromFile(this GtkWindowHandle window, string filename, out GErrorHandle error)
	{
		return GtkWindowExterns.gtk_window_set_icon_from_file(window, filename, out error);
	}

	public static GtkWindowHandle SetIconList(this GtkWindowHandle window, GListHandle list)
	{
		GtkWindowExterns.gtk_window_set_icon_list(window, list);
		return window;
	}

	public static GtkWindowHandle SetIconName(this GtkWindowHandle window, string name)
	{
		GtkWindowExterns.gtk_window_set_icon_name(window, name);
		return window;
	}

	public static GtkWindowHandle SetKeepAbove(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_keep_above(window, setting);
		return window;
	}

	public static GtkWindowHandle SetKeepBelow(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_keep_below(window, setting);
		return window;
	}

	public static GtkWindowHandle SetMnemonicModifier(this GtkWindowHandle window, GdkModifierType modifier)
	{
		GtkWindowExterns.gtk_window_set_mnemonic_modifier(window, modifier);
		return window;
	}

	public static GtkWindowHandle SetMnemonicsVisible(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_mnemonics_visible(window, setting);
		return window;
	}

	public static GtkWindowHandle SetModal(this GtkWindowHandle window, bool modal)
	{
		GtkWindowExterns.gtk_window_set_modal(window, modal);
		return window;
	}

	public static GtkWindowHandle SetOpacity(this GtkWindowHandle window, double opacity)
	{
		GtkWindowExterns.gtk_window_set_opacity(window, opacity);
		return window;
	}

	public static GtkWindowHandle SetPosition(this GtkWindowHandle window, GtkWindowPosition position)
	{
		GtkWindowExterns.gtk_window_set_position(window, position);
		return window;
	}

	public static GtkWindowHandle SetResizable(this GtkWindowHandle window, bool resizable)
	{
		GtkWindowExterns.gtk_window_set_resizable(window, resizable);
		return window;
	}

	public static GtkWindowHandle SetRole(this GtkWindowHandle window, string role)
	{
		GtkWindowExterns.gtk_window_set_role(window, role);
		return window;
	}

	public static GtkWindowHandle SetScreen(this GtkWindowHandle window, GdkScreenHandle screen)
	{
		GtkWindowExterns.gtk_window_set_screen(window, screen);
		return window;
	}

	public static GtkWindowHandle SetSkipPagerHint(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_skip_pager_hint(window, setting);
		return window;
	}

	public static GtkWindowHandle SetSkipTaskbarHint(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_skip_taskbar_hint(window, setting);
		return window;
	}

	public static GtkWindowHandle SetStartupId(this GtkWindowHandle window, string startup_id)
	{
		GtkWindowExterns.gtk_window_set_startup_id(window, startup_id);
		return window;
	}

	public static GtkWindowHandle SetTitle(this GtkWindowHandle window, string title)
	{
		GtkWindowExterns.gtk_window_set_title(window, title);
		return window;
	}

	public static GtkWindowHandle SetTitlebar(this GtkWindowHandle window, GtkWidgetHandle titlebar)
	{
		GtkWindowExterns.gtk_window_set_titlebar(window, titlebar);
		return window;
	}

	public static GtkWindowHandle SetTransientFor(this GtkWindowHandle window, GtkWindowHandle parent)
	{
		GtkWindowExterns.gtk_window_set_transient_for(window, parent);
		return window;
	}

	public static GtkWindowHandle SetTypeHint(this GtkWindowHandle window, GdkWindowTypeHint hint)
	{
		GtkWindowExterns.gtk_window_set_type_hint(window, hint);
		return window;
	}

	public static GtkWindowHandle SetUrgencyHint(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_urgency_hint(window, setting);
		return window;
	}

	public static GtkWindowHandle SetWmclass(this GtkWindowHandle window, string wmclass_name, string wmclass_class)
	{
		GtkWindowExterns.gtk_window_set_wmclass(window, wmclass_name, wmclass_class);
		return window;
	}

	public static GtkWindowHandle Stick(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_stick(window);
		return window;
	}

	public static GtkWindowHandle Unfullscreen(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unfullscreen(window);
		return window;
	}

	public static GtkWindowHandle Unmaximize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unmaximize(window);
		return window;
	}

	public static GtkWindowHandle Unstick(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unstick(window);
		return window;
	}

	public static bool GtkShowUriOnWindow(this GtkWindowHandle parent, string uri, uint timestamp, out GErrorHandle error)
	{
		return GtkWindowExterns.gtk_show_uri_on_window(parent, uri, timestamp, out error);
	}

	public static GtkWindowHandle GtkPrintRunPageSetupDialogAsync(this GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings, GtkPageSetupDoneFunc done_cb, IntPtr data)
	{
		GtkWindowExterns.gtk_print_run_page_setup_dialog_async(parent, page_setup, settings, done_cb, data);
		return parent;
	}

	public static GtkWindowHandle GtkShowAboutDialog(this GtkWindowHandle parent, string first_property_name, IntPtr @__arglist)
	{
		GtkWindowExterns.gtk_show_about_dialog(parent, first_property_name, @__arglist);
		return parent;
	}

	public static GtkPageSetupHandle GtkPrintRunPageSetupDialog(this GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings)
	{
		return GtkWindowExterns.gtk_print_run_page_setup_dialog(parent, page_setup, settings);
	}

}

internal class GtkWindowExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWindowHandle gtk_window_new(GtkWindowType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_activate_default(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_activate_focus(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_activate_key(GtkWindowHandle window, GdkEventKeyHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_add_accel_group(GtkWindowHandle window, GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_add_mnemonic(GtkWindowHandle window, uint keyval, GtkWidgetHandle target);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_begin_move_drag(GtkWindowHandle window, int button, int root_x, int root_y, uint timestamp);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_begin_resize_drag(GtkWindowHandle window, GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_close(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_deiconify(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_fullscreen(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_fullscreen_on_monitor(GtkWindowHandle window, GdkScreenHandle screen, int monitor);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_accept_focus(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkApplicationHandle gtk_window_get_application(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_window_get_attached_to(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_decorated(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_get_default_size(GtkWindowHandle window, out int width, out int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_window_get_default_widget(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_deletable(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_destroy_with_parent(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_window_get_focus(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_focus_on_map(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_focus_visible(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkGravity gtk_window_get_gravity(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWindowGroupHandle gtk_window_get_group(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_has_resize_grip(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_hide_titlebar_when_maximized(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_window_get_icon(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_window_get_icon_list(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_icon_name(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkModifierType gtk_window_get_mnemonic_modifier(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_mnemonics_visible(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_modal(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_window_get_opacity(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_get_position(GtkWindowHandle window, out int root_x, out int root_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_resizable(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_resize_grip_area(GtkWindowHandle window, out GdkRectangle rect);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_role(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkScreenHandle gtk_window_get_screen(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_get_size(GtkWindowHandle window, out int width, out int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_skip_pager_hint(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_skip_taskbar_hint(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_title(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_window_get_titlebar(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWindowHandle gtk_window_get_transient_for(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowTypeHint gtk_window_get_type_hint(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_get_urgency_hint(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWindowType gtk_window_get_window_type(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_has_group(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_has_toplevel_focus(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_iconify(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_is_active(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_is_maximized(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_maximize(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_mnemonic_activate(GtkWindowHandle window, uint keyval, GdkModifierType modifier);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_move(GtkWindowHandle window, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_parse_geometry(GtkWindowHandle window, string geometry);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_present(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_present_with_time(GtkWindowHandle window, uint timestamp);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_propagate_key_event(GtkWindowHandle window, GdkEventKeyHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_remove_accel_group(GtkWindowHandle window, GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_remove_mnemonic(GtkWindowHandle window, uint keyval, GtkWidgetHandle target);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_reshow_with_initial_size(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_resize(GtkWindowHandle window, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_resize_grip_is_visible(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_resize_to_geometry(GtkWindowHandle window, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_accept_focus(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_application(GtkWindowHandle window, GtkApplicationHandle application);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_attached_to(GtkWindowHandle window, GtkWidgetHandle attach_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_decorated(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_default(GtkWindowHandle window, GtkWidgetHandle default_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_default_geometry(GtkWindowHandle window, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_default_size(GtkWindowHandle window, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_deletable(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_destroy_with_parent(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_focus(GtkWindowHandle window, GtkWidgetHandle focus);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_focus_on_map(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_focus_visible(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_geometry_hints(GtkWindowHandle window, GtkWidgetHandle geometry_widget, GdkGeometryHandle geometry, GdkWindowHints geom_mask);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_gravity(GtkWindowHandle window, GdkGravity gravity);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_has_resize_grip(GtkWindowHandle window, bool value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_has_user_ref_count(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_hide_titlebar_when_maximized(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_icon(GtkWindowHandle window, GdkPixbufHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_set_icon_from_file(GtkWindowHandle window, string filename, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_icon_list(GtkWindowHandle window, GListHandle list);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_icon_name(GtkWindowHandle window, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_keep_above(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_keep_below(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_mnemonic_modifier(GtkWindowHandle window, GdkModifierType modifier);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_mnemonics_visible(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_modal(GtkWindowHandle window, bool modal);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_opacity(GtkWindowHandle window, double opacity);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_position(GtkWindowHandle window, GtkWindowPosition position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_resizable(GtkWindowHandle window, bool resizable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_role(GtkWindowHandle window, string role);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_screen(GtkWindowHandle window, GdkScreenHandle screen);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_skip_pager_hint(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_skip_taskbar_hint(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_startup_id(GtkWindowHandle window, string startup_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_title(GtkWindowHandle window, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_titlebar(GtkWindowHandle window, GtkWidgetHandle titlebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_transient_for(GtkWindowHandle window, GtkWindowHandle parent);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_type_hint(GtkWindowHandle window, GdkWindowTypeHint hint);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_urgency_hint(GtkWindowHandle window, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_wmclass(GtkWindowHandle window, string wmclass_name, string wmclass_class);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_stick(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_unfullscreen(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_unmaximize(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_unstick(GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_show_uri_on_window(GtkWindowHandle parent, string uri, uint timestamp, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_run_page_setup_dialog_async(GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings, GtkPageSetupDoneFunc done_cb, IntPtr data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_show_about_dialog(GtkWindowHandle parent, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPageSetupHandle gtk_print_run_page_setup_dialog(GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_window_get_default_icon_list();

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_default_icon_name();

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_window_list_toplevels();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_auto_startup_notification(bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_default_icon(GdkPixbufHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_window_set_default_icon_from_file(string filename, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_default_icon_list(GListHandle list);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_default_icon_name(string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_set_interactive_debugging(bool enable);

}
