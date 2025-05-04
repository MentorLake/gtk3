namespace MentorLake.Gtk;

public class GtkWindowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkWindowHandle New(MentorLake.Gtk.GtkWindowType type)
	{
		return GtkWindowHandleExterns.gtk_window_new(type);
	}

	public static MentorLake.GLib.GListHandle GetDefaultIconList()
	{
		return GtkWindowHandleExterns.gtk_window_get_default_icon_list();
	}

	public static string GetDefaultIconName()
	{
		return GtkWindowHandleExterns.gtk_window_get_default_icon_name();
	}

	public static MentorLake.GLib.GListHandle ListToplevels()
	{
		return GtkWindowHandleExterns.gtk_window_list_toplevels();
	}

	public static void SetAutoStartupNotification(bool setting)
	{
		GtkWindowHandleExterns.gtk_window_set_auto_startup_notification(setting);
	}

	public static void SetDefaultIcon(MentorLake.GdkPixbuf.GdkPixbufHandle icon)
	{
		GtkWindowHandleExterns.gtk_window_set_default_icon(icon);
	}

	public static bool SetDefaultIconFromFile(string filename)
	{
		var externCallResult = GtkWindowHandleExterns.gtk_window_set_default_icon_from_file(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void SetDefaultIconList(MentorLake.GLib.GListHandle list)
	{
		GtkWindowHandleExterns.gtk_window_set_default_icon_list(list);
	}

	public static void SetDefaultIconName(string name)
	{
		GtkWindowHandleExterns.gtk_window_set_default_icon_name(name);
	}

	public static void SetInteractiveDebugging(bool enable)
	{
		GtkWindowHandleExterns.gtk_window_set_interactive_debugging(enable);
	}

}
public static class GtkWindowHandleSignalExtensions
{

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
	public bool Toggle;
	public IntPtr UserData;
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
	public MentorLake.Gtk.GtkWidgetHandle Widget;
	public IntPtr UserData;
}
}

public static class GtkWindowHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool enable_debugging([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, bool toggle, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void keys_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void set_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);

}


public static class GtkWindowHandleExtensions
{
	public static bool ActivateDefault(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_activate_default(window);
	}

	public static bool ActivateFocus(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_activate_focus(window);
	}

	public static bool ActivateKey(this MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_activate_key(window, @event);
	}

	public static T AddAccelGroup<T>(this T window, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_add_accel_group(window, accel_group);
		return window;
	}

	public static T AddMnemonic<T>(this T window, uint keyval, MentorLake.Gtk.GtkWidgetHandle target) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_add_mnemonic(window, keyval, target);
		return window;
	}

	public static T BeginMoveDrag<T>(this T window, int button, int root_x, int root_y, uint timestamp) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_begin_move_drag(window, button, root_x, root_y, timestamp);
		return window;
	}

	public static T BeginResizeDrag<T>(this T window, MentorLake.Gdk.GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_begin_resize_drag(window, edge, button, root_x, root_y, timestamp);
		return window;
	}

	public static T Close<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_close(window);
		return window;
	}

	public static T Deiconify<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_deiconify(window);
		return window;
	}

	public static T Fullscreen<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_fullscreen(window);
		return window;
	}

	public static T FullscreenOnMonitor<T>(this T window, MentorLake.Gdk.GdkScreenHandle screen, int monitor) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_fullscreen_on_monitor(window, screen, monitor);
		return window;
	}

	public static bool GetAcceptFocus(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_accept_focus(window);
	}

	public static MentorLake.Gtk.GtkApplicationHandle GetApplication(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_application(window);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetAttachedTo(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_attached_to(window);
	}

	public static bool GetDecorated(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_decorated(window);
	}

	public static T GetDefaultSize<T>(this T window, out int width, out int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_get_default_size(window, out width, out height);
		return window;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetDefaultWidget(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_default_widget(window);
	}

	public static bool GetDeletable(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_deletable(window);
	}

	public static bool GetDestroyWithParent(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_destroy_with_parent(window);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetFocus(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_focus(window);
	}

	public static bool GetFocusOnMap(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_focus_on_map(window);
	}

	public static bool GetFocusVisible(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_focus_visible(window);
	}

	public static MentorLake.Gdk.GdkGravity GetGravity(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_gravity(window);
	}

	public static MentorLake.Gtk.GtkWindowGroupHandle GetGroup(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_group(window);
	}

	public static bool GetHasResizeGrip(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_has_resize_grip(window);
	}

	public static bool GetHideTitlebarWhenMaximized(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_hide_titlebar_when_maximized(window);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetIcon(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_icon(window);
	}

	public static MentorLake.GLib.GListHandle GetIconList(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_icon_list(window);
	}

	public static string GetIconName(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_icon_name(window);
	}

	public static MentorLake.Gdk.GdkModifierType GetMnemonicModifier(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_mnemonic_modifier(window);
	}

	public static bool GetMnemonicsVisible(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_mnemonics_visible(window);
	}

	public static bool GetModal(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_modal(window);
	}

	public static double GetOpacity(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_opacity(window);
	}

	public static T GetPosition<T>(this T window, out int root_x, out int root_y) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_get_position(window, out root_x, out root_y);
		return window;
	}

	public static bool GetResizable(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_resizable(window);
	}

	public static bool GetResizeGripArea(this MentorLake.Gtk.GtkWindowHandle window, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_resize_grip_area(window, out rect);
	}

	public static string GetRole(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_role(window);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_screen(window);
	}

	public static T GetSize<T>(this T window, out int width, out int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_get_size(window, out width, out height);
		return window;
	}

	public static bool GetSkipPagerHint(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_skip_pager_hint(window);
	}

	public static bool GetSkipTaskbarHint(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_skip_taskbar_hint(window);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_title(window);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetTitlebar(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_titlebar(window);
	}

	public static MentorLake.Gtk.GtkWindowHandle GetTransientFor(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_transient_for(window);
	}

	public static MentorLake.Gdk.GdkWindowTypeHint GetTypeHint(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_type_hint(window);
	}

	public static bool GetUrgencyHint(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_urgency_hint(window);
	}

	public static MentorLake.Gtk.GtkWindowType GetWindowType(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_get_window_type(window);
	}

	public static bool HasGroup(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_has_group(window);
	}

	public static bool HasToplevelFocus(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_has_toplevel_focus(window);
	}

	public static T Iconify<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_iconify(window);
		return window;
	}

	public static bool IsActive(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_is_active(window);
	}

	public static bool IsMaximized(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_is_maximized(window);
	}

	public static T Maximize<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_maximize(window);
		return window;
	}

	public static bool MnemonicActivate(this MentorLake.Gtk.GtkWindowHandle window, uint keyval, MentorLake.Gdk.GdkModifierType modifier)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_mnemonic_activate(window, keyval, modifier);
	}

	public static T Move<T>(this T window, int x, int y) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_move(window, x, y);
		return window;
	}

	public static bool ParseGeometry(this MentorLake.Gtk.GtkWindowHandle window, string geometry)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_parse_geometry(window, geometry);
	}

	public static T Present<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_present(window);
		return window;
	}

	public static T PresentWithTime<T>(this T window, uint timestamp) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_present_with_time(window, timestamp);
		return window;
	}

	public static bool PropagateKeyEvent(this MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_propagate_key_event(window, @event);
	}

	public static T RemoveAccelGroup<T>(this T window, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_remove_accel_group(window, accel_group);
		return window;
	}

	public static T RemoveMnemonic<T>(this T window, uint keyval, MentorLake.Gtk.GtkWidgetHandle target) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_remove_mnemonic(window, keyval, target);
		return window;
	}

	public static T ReshowWithInitialSize<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_reshow_with_initial_size(window);
		return window;
	}

	public static T Resize<T>(this T window, int width, int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_resize(window, width, height);
		return window;
	}

	public static bool ResizeGripIsVisible(this MentorLake.Gtk.GtkWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		return GtkWindowHandleExterns.gtk_window_resize_grip_is_visible(window);
	}

	public static T ResizeToGeometry<T>(this T window, int width, int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_resize_to_geometry(window, width, height);
		return window;
	}

	public static T SetAcceptFocus<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_accept_focus(window, setting);
		return window;
	}

	public static T SetApplication<T>(this T window, MentorLake.Gtk.GtkApplicationHandle application) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_application(window, application);
		return window;
	}

	public static T SetAttachedTo<T>(this T window, MentorLake.Gtk.GtkWidgetHandle attach_widget) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_attached_to(window, attach_widget);
		return window;
	}

	public static T SetDecorated<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_decorated(window, setting);
		return window;
	}

	public static T SetDefault<T>(this T window, MentorLake.Gtk.GtkWidgetHandle default_widget) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_default(window, default_widget);
		return window;
	}

	public static T SetDefaultGeometry<T>(this T window, int width, int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_default_geometry(window, width, height);
		return window;
	}

	public static T SetDefaultSize<T>(this T window, int width, int height) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_default_size(window, width, height);
		return window;
	}

	public static T SetDeletable<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_deletable(window, setting);
		return window;
	}

	public static T SetDestroyWithParent<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_destroy_with_parent(window, setting);
		return window;
	}

	public static T SetFocus<T>(this T window, MentorLake.Gtk.GtkWidgetHandle focus) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_focus(window, focus);
		return window;
	}

	public static T SetFocusOnMap<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_focus_on_map(window, setting);
		return window;
	}

	public static T SetFocusVisible<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_focus_visible(window, setting);
		return window;
	}

	public static T SetGeometryHints<T>(this T window, MentorLake.Gtk.GtkWidgetHandle geometry_widget, MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints geom_mask) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_geometry_hints(window, geometry_widget, geometry, geom_mask);
		return window;
	}

	public static T SetGravity<T>(this T window, MentorLake.Gdk.GdkGravity gravity) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_gravity(window, gravity);
		return window;
	}

	public static T SetHasResizeGrip<T>(this T window, bool value) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_has_resize_grip(window, value);
		return window;
	}

	public static T SetHasUserRefCount<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_has_user_ref_count(window, setting);
		return window;
	}

	public static T SetHideTitlebarWhenMaximized<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_hide_titlebar_when_maximized(window, setting);
		return window;
	}

	public static T SetIcon<T>(this T window, MentorLake.GdkPixbuf.GdkPixbufHandle icon) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_icon(window, icon);
		return window;
	}

	public static bool SetIconFromFile(this MentorLake.Gtk.GtkWindowHandle window, string filename)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		var externCallResult = GtkWindowHandleExterns.gtk_window_set_icon_from_file(window, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetIconList<T>(this T window, MentorLake.GLib.GListHandle list) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_icon_list(window, list);
		return window;
	}

	public static T SetIconName<T>(this T window, string name) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_icon_name(window, name);
		return window;
	}

	public static T SetKeepAbove<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_keep_above(window, setting);
		return window;
	}

	public static T SetKeepBelow<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_keep_below(window, setting);
		return window;
	}

	public static T SetMnemonicModifier<T>(this T window, MentorLake.Gdk.GdkModifierType modifier) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_mnemonic_modifier(window, modifier);
		return window;
	}

	public static T SetMnemonicsVisible<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_mnemonics_visible(window, setting);
		return window;
	}

	public static T SetModal<T>(this T window, bool modal) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_modal(window, modal);
		return window;
	}

	public static T SetOpacity<T>(this T window, double opacity) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_opacity(window, opacity);
		return window;
	}

	public static T SetPosition<T>(this T window, MentorLake.Gtk.GtkWindowPosition position) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_position(window, position);
		return window;
	}

	public static T SetResizable<T>(this T window, bool resizable) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_resizable(window, resizable);
		return window;
	}

	public static T SetRole<T>(this T window, string role) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_role(window, role);
		return window;
	}

	public static T SetScreen<T>(this T window, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_screen(window, screen);
		return window;
	}

	public static T SetSkipPagerHint<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_skip_pager_hint(window, setting);
		return window;
	}

	public static T SetSkipTaskbarHint<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_skip_taskbar_hint(window, setting);
		return window;
	}

	public static T SetStartupId<T>(this T window, string startup_id) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_startup_id(window, startup_id);
		return window;
	}

	public static T SetTitle<T>(this T window, string title) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_title(window, title);
		return window;
	}

	public static T SetTitlebar<T>(this T window, MentorLake.Gtk.GtkWidgetHandle titlebar) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_titlebar(window, titlebar);
		return window;
	}

	public static T SetTransientFor<T>(this T window, MentorLake.Gtk.GtkWindowHandle parent) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_transient_for(window, parent);
		return window;
	}

	public static T SetTypeHint<T>(this T window, MentorLake.Gdk.GdkWindowTypeHint hint) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_type_hint(window, hint);
		return window;
	}

	public static T SetUrgencyHint<T>(this T window, bool setting) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_urgency_hint(window, setting);
		return window;
	}

	public static T SetWmclass<T>(this T window, string wmclass_name, string wmclass_class) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_set_wmclass(window, wmclass_name, wmclass_class);
		return window;
	}

	public static T Stick<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_stick(window);
		return window;
	}

	public static T Unfullscreen<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_unfullscreen(window);
		return window;
	}

	public static T Unmaximize<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_unmaximize(window);
		return window;
	}

	public static T Unstick<T>(this T window) where T : GtkWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkWindowHandle)");
		GtkWindowHandleExterns.gtk_window_unstick(window);
		return window;
	}

}

internal class GtkWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.Gtk.GtkApplicationHandle gtk_window_get_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_get_attached_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_decorated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_get_default_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_get_default_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_deletable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_destroy_with_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_get_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_focus_on_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_focus_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGravity gtk_window_get_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWindowGroupHandle gtk_window_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_has_resize_grip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_window_get_hide_titlebar_when_maximized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_window_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_get_titlebar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.GLib.GListHandle gtk_window_get_default_icon_list();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_window_get_default_icon_name();

	[DllImport(GtkLibrary.Name)]
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
