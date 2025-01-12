namespace MentorLake.Gtk3.Gdk3;

public class GdkDisplayHandle : GObjectHandle
{
	public static GdkDisplayHandle GetDefault()
	{
		return GdkDisplayExterns.gdk_display_get_default();
	}

	public static GdkDisplayHandle Open(string display_name)
	{
		return GdkDisplayExterns.gdk_display_open(display_name);
	}

	public static GdkDisplayHandle OpenDefaultLibgtkOnly()
	{
		return GdkDisplayExterns.gdk_display_open_default_libgtk_only();
	}

}

public static class GdkDisplaySignalExtensions
{

	public static IObservable<GdkDisplaySignalStructs.ClosedSignal> Signal_Closed(this GdkDisplayHandle instance)
	{
		return Observable.Create((IObserver<GdkDisplaySignalStructs.ClosedSignal> obs) =>
		{
			GdkDisplaySignalDelegates.closed handler = (GdkDisplayHandle self, bool is_error, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplaySignalStructs.ClosedSignal()
				{
					Self = self, IsError = is_error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDisplaySignalStructs.MonitorAddedSignal> Signal_MonitorAdded(this GdkDisplayHandle instance)
	{
		return Observable.Create((IObserver<GdkDisplaySignalStructs.MonitorAddedSignal> obs) =>
		{
			GdkDisplaySignalDelegates.monitor_added handler = (GdkDisplayHandle self, GdkMonitorHandle monitor, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplaySignalStructs.MonitorAddedSignal()
				{
					Self = self, Monitor = monitor, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "monitor_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDisplaySignalStructs.MonitorRemovedSignal> Signal_MonitorRemoved(this GdkDisplayHandle instance)
	{
		return Observable.Create((IObserver<GdkDisplaySignalStructs.MonitorRemovedSignal> obs) =>
		{
			GdkDisplaySignalDelegates.monitor_removed handler = (GdkDisplayHandle self, GdkMonitorHandle monitor, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplaySignalStructs.MonitorRemovedSignal()
				{
					Self = self, Monitor = monitor, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "monitor_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDisplaySignalStructs.OpenedSignal> Signal_Opened(this GdkDisplayHandle instance)
	{
		return Observable.Create((IObserver<GdkDisplaySignalStructs.OpenedSignal> obs) =>
		{
			GdkDisplaySignalDelegates.opened handler = (GdkDisplayHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplaySignalStructs.OpenedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "opened", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDisplaySignalStructs.SeatAddedSignal> Signal_SeatAdded(this GdkDisplayHandle instance)
	{
		return Observable.Create((IObserver<GdkDisplaySignalStructs.SeatAddedSignal> obs) =>
		{
			GdkDisplaySignalDelegates.seat_added handler = (GdkDisplayHandle self, GdkSeatHandle seat, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplaySignalStructs.SeatAddedSignal()
				{
					Self = self, Seat = seat, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "seat_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDisplaySignalStructs.SeatRemovedSignal> Signal_SeatRemoved(this GdkDisplayHandle instance)
	{
		return Observable.Create((IObserver<GdkDisplaySignalStructs.SeatRemovedSignal> obs) =>
		{
			GdkDisplaySignalDelegates.seat_removed handler = (GdkDisplayHandle self, GdkSeatHandle seat, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplaySignalStructs.SeatRemovedSignal()
				{
					Self = self, Seat = seat, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "seat_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkDisplaySignalStructs
{

public struct ClosedSignal
{
	public GdkDisplayHandle Self;
	public bool IsError;
	public IntPtr UserData;
}

public struct MonitorAddedSignal
{
	public GdkDisplayHandle Self;
	public GdkMonitorHandle Monitor;
	public IntPtr UserData;
}

public struct MonitorRemovedSignal
{
	public GdkDisplayHandle Self;
	public GdkMonitorHandle Monitor;
	public IntPtr UserData;
}

public struct OpenedSignal
{
	public GdkDisplayHandle Self;
	public IntPtr UserData;
}

public struct SeatAddedSignal
{
	public GdkDisplayHandle Self;
	public GdkSeatHandle Seat;
	public IntPtr UserData;
}

public struct SeatRemovedSignal
{
	public GdkDisplayHandle Self;
	public GdkSeatHandle Seat;
	public IntPtr UserData;
}
}

public static class GdkDisplaySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDisplayHandle>))] GdkDisplayHandle self, bool is_error, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitor_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDisplayHandle>))] GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkMonitorHandle>))] GdkMonitorHandle monitor, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitor_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDisplayHandle>))] GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkMonitorHandle>))] GdkMonitorHandle monitor, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void opened([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDisplayHandle>))] GdkDisplayHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void seat_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDisplayHandle>))] GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle seat, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void seat_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDisplayHandle>))] GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle seat, IntPtr user_data);

}


public static class GdkDisplayHandleExtensions
{
	public static GdkDisplayHandle Beep(this GdkDisplayHandle display)
	{
		GdkDisplayExterns.gdk_display_beep(display);
		return display;
	}

	public static GdkDisplayHandle Close(this GdkDisplayHandle display)
	{
		GdkDisplayExterns.gdk_display_close(display);
		return display;
	}

	public static bool DeviceIsGrabbed(this GdkDisplayHandle display, GdkDeviceHandle device)
	{
		return GdkDisplayExterns.gdk_display_device_is_grabbed(display, device);
	}

	public static GdkDisplayHandle Flush(this GdkDisplayHandle display)
	{
		GdkDisplayExterns.gdk_display_flush(display);
		return display;
	}

	public static GdkAppLaunchContextHandle GetAppLaunchContext(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_app_launch_context(display);
	}

	public static uint GetDefaultCursorSize(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_default_cursor_size(display);
	}

	public static GdkWindowHandle GetDefaultGroup(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_default_group(display);
	}

	public static GdkScreenHandle GetDefaultScreen(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_default_screen(display);
	}

	public static GdkSeatHandle GetDefaultSeat(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_default_seat(display);
	}

	public static GdkDeviceManagerHandle GetDeviceManager(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_device_manager(display);
	}

	public static GdkEventHandle GetEvent(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_event(display);
	}

	public static GdkDisplayHandle GetMaximalCursorSize(this GdkDisplayHandle display, out uint width, out uint height)
	{
		GdkDisplayExterns.gdk_display_get_maximal_cursor_size(display, out width, out height);
		return display;
	}

	public static GdkMonitorHandle GetMonitor(this GdkDisplayHandle display, int monitor_num)
	{
		return GdkDisplayExterns.gdk_display_get_monitor(display, monitor_num);
	}

	public static GdkMonitorHandle GetMonitorAtPoint(this GdkDisplayHandle display, int x, int y)
	{
		return GdkDisplayExterns.gdk_display_get_monitor_at_point(display, x, y);
	}

	public static GdkMonitorHandle GetMonitorAtWindow(this GdkDisplayHandle display, GdkWindowHandle window)
	{
		return GdkDisplayExterns.gdk_display_get_monitor_at_window(display, window);
	}

	public static int GetNMonitors(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_n_monitors(display);
	}

	public static int GetNScreens(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_n_screens(display);
	}

	public static string GetName(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_name(display);
	}

	public static GdkDisplayHandle GetPointer(this GdkDisplayHandle display, out GdkScreenHandle screen, out int x, out int y, out GdkModifierType mask)
	{
		GdkDisplayExterns.gdk_display_get_pointer(display, out screen, out x, out y, out mask);
		return display;
	}

	public static GdkMonitorHandle GetPrimaryMonitor(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_primary_monitor(display);
	}

	public static GdkScreenHandle GetScreen(this GdkDisplayHandle display, int screen_num)
	{
		return GdkDisplayExterns.gdk_display_get_screen(display, screen_num);
	}

	public static GdkWindowHandle GetWindowAtPointer(this GdkDisplayHandle display, out int win_x, out int win_y)
	{
		return GdkDisplayExterns.gdk_display_get_window_at_pointer(display, out win_x, out win_y);
	}

	public static bool HasPending(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_has_pending(display);
	}

	public static bool IsClosed(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_is_closed(display);
	}

	public static GdkDisplayHandle KeyboardUngrab(this GdkDisplayHandle display, uint time_)
	{
		GdkDisplayExterns.gdk_display_keyboard_ungrab(display, time_);
		return display;
	}

	public static GListHandle ListDevices(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_list_devices(display);
	}

	public static GListHandle ListSeats(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_list_seats(display);
	}

	public static GdkDisplayHandle NotifyStartupComplete(this GdkDisplayHandle display, string startup_id)
	{
		GdkDisplayExterns.gdk_display_notify_startup_complete(display, startup_id);
		return display;
	}

	public static GdkEventHandle PeekEvent(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_peek_event(display);
	}

	public static bool PointerIsGrabbed(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_pointer_is_grabbed(display);
	}

	public static GdkDisplayHandle PointerUngrab(this GdkDisplayHandle display, uint time_)
	{
		GdkDisplayExterns.gdk_display_pointer_ungrab(display, time_);
		return display;
	}

	public static GdkDisplayHandle PutEvent(this GdkDisplayHandle display, GdkEventHandle @event)
	{
		GdkDisplayExterns.gdk_display_put_event(display, @event);
		return display;
	}

	public static bool RequestSelectionNotification(this GdkDisplayHandle display, GdkAtom selection)
	{
		return GdkDisplayExterns.gdk_display_request_selection_notification(display, selection);
	}

	public static GdkDisplayHandle SetDoubleClickDistance(this GdkDisplayHandle display, uint distance)
	{
		GdkDisplayExterns.gdk_display_set_double_click_distance(display, distance);
		return display;
	}

	public static GdkDisplayHandle SetDoubleClickTime(this GdkDisplayHandle display, uint msec)
	{
		GdkDisplayExterns.gdk_display_set_double_click_time(display, msec);
		return display;
	}

	public static GdkDisplayHandle StoreClipboard(this GdkDisplayHandle display, GdkWindowHandle clipboard_window, uint time_, GdkAtom[] targets, int n_targets)
	{
		GdkDisplayExterns.gdk_display_store_clipboard(display, clipboard_window, time_, targets, n_targets);
		return display;
	}

	public static bool SupportsClipboardPersistence(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_clipboard_persistence(display);
	}

	public static bool SupportsComposite(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_composite(display);
	}

	public static bool SupportsCursorAlpha(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_cursor_alpha(display);
	}

	public static bool SupportsCursorColor(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_cursor_color(display);
	}

	public static bool SupportsInputShapes(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_input_shapes(display);
	}

	public static bool SupportsSelectionNotification(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_selection_notification(display);
	}

	public static bool SupportsShapes(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_shapes(display);
	}

	public static GdkDisplayHandle Sync(this GdkDisplayHandle display)
	{
		GdkDisplayExterns.gdk_display_sync(display);
		return display;
	}

	public static GdkDisplayHandle WarpPointer(this GdkDisplayHandle display, GdkScreenHandle screen, int x, int y)
	{
		GdkDisplayExterns.gdk_display_warp_pointer(display, screen, x, y);
		return display;
	}

	public static PangoContextHandle GdkPangoContextGetForDisplay(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_pango_context_get_for_display(display);
	}

	public static int GdkTextPropertyToUtf8ListForDisplay(this GdkDisplayHandle display, GdkAtom encoding, int format, string text, int length, out string[] list)
	{
		return GdkDisplayExterns.gdk_text_property_to_utf8_list_for_display(display, encoding, format, text, length, out list);
	}

	public static GdkWindowHandle GdkSelectionOwnerGetForDisplay(this GdkDisplayHandle display, GdkAtom selection)
	{
		return GdkDisplayExterns.gdk_selection_owner_get_for_display(display, selection);
	}

	public static bool GdkSelectionOwnerSetForDisplay(this GdkDisplayHandle display, GdkWindowHandle owner, GdkAtom selection, uint time_, bool send_event)
	{
		return GdkDisplayExterns.gdk_selection_owner_set_for_display(display, owner, selection, time_, send_event);
	}

	public static GdkDisplayHandle GdkSelectionSendNotifyForDisplay(this GdkDisplayHandle display, GdkWindowHandle requestor, GdkAtom selection, GdkAtom target, GdkAtom property, uint time_)
	{
		GdkDisplayExterns.gdk_selection_send_notify_for_display(display, requestor, selection, target, property, time_);
		return display;
	}

}

internal class GdkDisplayExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_beep(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_close(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_device_is_grabbed(GdkDisplayHandle display, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_flush(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkAppLaunchContextHandle gdk_display_get_app_launch_context(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_display_get_default_cursor_size(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_display_get_default_group(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkScreenHandle gdk_display_get_default_screen(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkSeatHandle gdk_display_get_default_seat(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceManagerHandle gdk_display_get_device_manager(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventHandle gdk_display_get_event(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_get_maximal_cursor_size(GdkDisplayHandle display, out uint width, out uint height);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkMonitorHandle gdk_display_get_monitor(GdkDisplayHandle display, int monitor_num);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkMonitorHandle gdk_display_get_monitor_at_point(GdkDisplayHandle display, int x, int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkMonitorHandle gdk_display_get_monitor_at_window(GdkDisplayHandle display, GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_display_get_n_monitors(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_display_get_n_screens(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_display_get_name(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_get_pointer(GdkDisplayHandle display, out GdkScreenHandle screen, out int x, out int y, out GdkModifierType mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkMonitorHandle gdk_display_get_primary_monitor(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkScreenHandle gdk_display_get_screen(GdkDisplayHandle display, int screen_num);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_display_get_window_at_pointer(GdkDisplayHandle display, out int win_x, out int win_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_has_pending(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_is_closed(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_keyboard_ungrab(GdkDisplayHandle display, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_display_list_devices(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_display_list_seats(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_notify_startup_complete(GdkDisplayHandle display, string startup_id);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventHandle gdk_display_peek_event(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_pointer_is_grabbed(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_pointer_ungrab(GdkDisplayHandle display, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_put_event(GdkDisplayHandle display, GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_request_selection_notification(GdkDisplayHandle display, GdkAtom selection);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_set_double_click_distance(GdkDisplayHandle display, uint distance);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_set_double_click_time(GdkDisplayHandle display, uint msec);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_store_clipboard(GdkDisplayHandle display, GdkWindowHandle clipboard_window, uint time_, GdkAtom[] targets, int n_targets);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_supports_clipboard_persistence(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_supports_composite(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_supports_cursor_alpha(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_supports_cursor_color(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_supports_input_shapes(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_supports_selection_notification(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_display_supports_shapes(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_sync(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_display_warp_pointer(GdkDisplayHandle display, GdkScreenHandle screen, int x, int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern PangoContextHandle gdk_pango_context_get_for_display(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_text_property_to_utf8_list_for_display(GdkDisplayHandle display, GdkAtom encoding, int format, string text, int length, out string[] list);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_selection_owner_get_for_display(GdkDisplayHandle display, GdkAtom selection);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_selection_owner_set_for_display(GdkDisplayHandle display, GdkWindowHandle owner, GdkAtom selection, uint time_, bool send_event);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_selection_send_notify_for_display(GdkDisplayHandle display, GdkWindowHandle requestor, GdkAtom selection, GdkAtom target, GdkAtom property, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_display_get_default();

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_display_open(string display_name);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_display_open_default_libgtk_only();

}
