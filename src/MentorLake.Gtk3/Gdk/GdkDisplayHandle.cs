namespace MentorLake.Gdk;

public class GdkDisplayHandle : GObjectHandle
{
	public static MentorLake.Gdk.GdkDisplayHandle GetDefault()
	{
		return GdkDisplayHandleExterns.gdk_display_get_default();
	}

	public static MentorLake.Gdk.GdkDisplayHandle Open(string display_name)
	{
		return GdkDisplayHandleExterns.gdk_display_open(display_name);
	}

	public static MentorLake.Gdk.GdkDisplayHandle OpenDefaultLibgtkOnly()
	{
		return GdkDisplayHandleExterns.gdk_display_open_default_libgtk_only();
	}

}
public static class GdkDisplayHandleSignalExtensions
{

	public static IObservable<GdkDisplayHandleSignalStructs.ClosedSignal> Signal_Closed(this GdkDisplayHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDisplayHandleSignalStructs.ClosedSignal> obs) =>
		{
			GdkDisplayHandleSignalDelegates.closed handler = ( MentorLake.Gdk.GdkDisplayHandle self,  bool is_error,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayHandleSignalStructs.ClosedSignal()
				{
					Self = self, IsError = is_error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDisplayHandleSignalStructs.MonitorAddedSignal> Signal_MonitorAdded(this GdkDisplayHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDisplayHandleSignalStructs.MonitorAddedSignal> obs) =>
		{
			GdkDisplayHandleSignalDelegates.monitor_added handler = ( MentorLake.Gdk.GdkDisplayHandle self,  MentorLake.Gdk.GdkMonitorHandle monitor,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayHandleSignalStructs.MonitorAddedSignal()
				{
					Self = self, Monitor = monitor, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "monitor-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDisplayHandleSignalStructs.MonitorRemovedSignal> Signal_MonitorRemoved(this GdkDisplayHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDisplayHandleSignalStructs.MonitorRemovedSignal> obs) =>
		{
			GdkDisplayHandleSignalDelegates.monitor_removed handler = ( MentorLake.Gdk.GdkDisplayHandle self,  MentorLake.Gdk.GdkMonitorHandle monitor,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayHandleSignalStructs.MonitorRemovedSignal()
				{
					Self = self, Monitor = monitor, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "monitor-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDisplayHandleSignalStructs.OpenedSignal> Signal_Opened(this GdkDisplayHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDisplayHandleSignalStructs.OpenedSignal> obs) =>
		{
			GdkDisplayHandleSignalDelegates.opened handler = ( MentorLake.Gdk.GdkDisplayHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayHandleSignalStructs.OpenedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "opened", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDisplayHandleSignalStructs.SeatAddedSignal> Signal_SeatAdded(this GdkDisplayHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDisplayHandleSignalStructs.SeatAddedSignal> obs) =>
		{
			GdkDisplayHandleSignalDelegates.seat_added handler = ( MentorLake.Gdk.GdkDisplayHandle self,  MentorLake.Gdk.GdkSeatHandle seat,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayHandleSignalStructs.SeatAddedSignal()
				{
					Self = self, Seat = seat, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "seat-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDisplayHandleSignalStructs.SeatRemovedSignal> Signal_SeatRemoved(this GdkDisplayHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDisplayHandleSignalStructs.SeatRemovedSignal> obs) =>
		{
			GdkDisplayHandleSignalDelegates.seat_removed handler = ( MentorLake.Gdk.GdkDisplayHandle self,  MentorLake.Gdk.GdkSeatHandle seat,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayHandleSignalStructs.SeatRemovedSignal()
				{
					Self = self, Seat = seat, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "seat-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkDisplayHandleSignalStructs
{

public class ClosedSignal
{
	public MentorLake.Gdk.GdkDisplayHandle Self;
	public bool IsError;
	public IntPtr UserData;
}

public class MonitorAddedSignal
{
	public MentorLake.Gdk.GdkDisplayHandle Self;
	public MentorLake.Gdk.GdkMonitorHandle Monitor;
	public IntPtr UserData;
}

public class MonitorRemovedSignal
{
	public MentorLake.Gdk.GdkDisplayHandle Self;
	public MentorLake.Gdk.GdkMonitorHandle Monitor;
	public IntPtr UserData;
}

public class OpenedSignal
{
	public MentorLake.Gdk.GdkDisplayHandle Self;
	public IntPtr UserData;
}

public class SeatAddedSignal
{
	public MentorLake.Gdk.GdkDisplayHandle Self;
	public MentorLake.Gdk.GdkSeatHandle Seat;
	public IntPtr UserData;
}

public class SeatRemovedSignal
{
	public MentorLake.Gdk.GdkDisplayHandle Self;
	public MentorLake.Gdk.GdkSeatHandle Seat;
	public IntPtr UserData;
}
}

public static class GdkDisplayHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, bool is_error, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitor_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitor_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void opened([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void seat_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void seat_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, IntPtr user_data);

}


public static class GdkDisplayHandleExtensions
{
	public static T Beep<T>(this T display) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_beep(display);
		return display;
	}

	public static T Close<T>(this T display) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_close(display);
		return display;
	}

	public static bool DeviceIsGrabbed(this MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_device_is_grabbed(display, device);
	}

	public static T Flush<T>(this T display) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_flush(display);
		return display;
	}

	public static MentorLake.Gdk.GdkAppLaunchContextHandle GetAppLaunchContext(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_app_launch_context(display);
	}

	public static uint GetDefaultCursorSize(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_default_cursor_size(display);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetDefaultGroup(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_default_group(display);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetDefaultScreen(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_default_screen(display);
	}

	public static MentorLake.Gdk.GdkSeatHandle GetDefaultSeat(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_default_seat(display);
	}

	public static MentorLake.Gdk.GdkDeviceManagerHandle GetDeviceManager(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_device_manager(display);
	}

	public static MentorLake.Gdk.GdkEventHandle GetEvent(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_event(display);
	}

	public static T GetMaximalCursorSize<T>(this T display, out uint width, out uint height) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_get_maximal_cursor_size(display, out width, out height);
		return display;
	}

	public static MentorLake.Gdk.GdkMonitorHandle GetMonitor(this MentorLake.Gdk.GdkDisplayHandle display, int monitor_num)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_monitor(display, monitor_num);
	}

	public static MentorLake.Gdk.GdkMonitorHandle GetMonitorAtPoint(this MentorLake.Gdk.GdkDisplayHandle display, int x, int y)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_monitor_at_point(display, x, y);
	}

	public static MentorLake.Gdk.GdkMonitorHandle GetMonitorAtWindow(this MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkWindowHandle window)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_monitor_at_window(display, window);
	}

	public static int GetNMonitors(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_n_monitors(display);
	}

	public static int GetNScreens(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_n_screens(display);
	}

	public static string GetName(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_name(display);
	}

	public static T GetPointer<T>(this T display, out MentorLake.Gdk.GdkScreenHandle screen, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_get_pointer(display, out screen, out x, out y, out mask);
		return display;
	}

	public static MentorLake.Gdk.GdkMonitorHandle GetPrimaryMonitor(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_primary_monitor(display);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gdk.GdkDisplayHandle display, int screen_num)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_screen(display, screen_num);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindowAtPointer(this MentorLake.Gdk.GdkDisplayHandle display, out int win_x, out int win_y)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_window_at_pointer(display, out win_x, out win_y);
	}

	public static bool HasPending(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_has_pending(display);
	}

	public static bool IsClosed(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_is_closed(display);
	}

	public static T KeyboardUngrab<T>(this T display, uint time_) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_keyboard_ungrab(display, time_);
		return display;
	}

	public static MentorLake.GLib.GListHandle ListDevices(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_list_devices(display);
	}

	public static MentorLake.GLib.GListHandle ListSeats(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_list_seats(display);
	}

	public static T NotifyStartupComplete<T>(this T display, string startup_id) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_notify_startup_complete(display, startup_id);
		return display;
	}

	public static MentorLake.Gdk.GdkEventHandle PeekEvent(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_peek_event(display);
	}

	public static bool PointerIsGrabbed(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_pointer_is_grabbed(display);
	}

	public static T PointerUngrab<T>(this T display, uint time_) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_pointer_ungrab(display, time_);
		return display;
	}

	public static T PutEvent<T>(this T display, MentorLake.Gdk.GdkEventHandle @event) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_put_event(display, @event);
		return display;
	}

	public static bool RequestSelectionNotification(this MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_request_selection_notification(display, selection);
	}

	public static T SetDoubleClickDistance<T>(this T display, uint distance) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_set_double_click_distance(display, distance);
		return display;
	}

	public static T SetDoubleClickTime<T>(this T display, uint msec) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_set_double_click_time(display, msec);
		return display;
	}

	public static T StoreClipboard<T>(this T display, MentorLake.Gdk.GdkWindowHandle clipboard_window, uint time_, MentorLake.Gdk.GdkAtom[] targets, int n_targets) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_store_clipboard(display, clipboard_window, time_, targets, n_targets);
		return display;
	}

	public static bool SupportsClipboardPersistence(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_clipboard_persistence(display);
	}

	public static bool SupportsComposite(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_composite(display);
	}

	public static bool SupportsCursorAlpha(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_cursor_alpha(display);
	}

	public static bool SupportsCursorColor(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_cursor_color(display);
	}

	public static bool SupportsInputShapes(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_input_shapes(display);
	}

	public static bool SupportsSelectionNotification(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_selection_notification(display);
	}

	public static bool SupportsShapes(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_shapes(display);
	}

	public static T Sync<T>(this T display) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_sync(display);
		return display;
	}

	public static T WarpPointer<T>(this T display, MentorLake.Gdk.GdkScreenHandle screen, int x, int y) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_warp_pointer(display, screen, x, y);
		return display;
	}

}

internal class GdkDisplayHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_beep([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_device_is_grabbed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))]
	internal static extern MentorLake.Gdk.GdkAppLaunchContextHandle gdk_display_get_app_launch_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_display_get_default_cursor_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_display_get_default_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gdk_display_get_default_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))]
	internal static extern MentorLake.Gdk.GdkSeatHandle gdk_display_get_default_seat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceManagerHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceManagerHandle gdk_display_get_device_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_display_get_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_get_maximal_cursor_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, out uint width, out uint height);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))]
	internal static extern MentorLake.Gdk.GdkMonitorHandle gdk_display_get_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, int monitor_num);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))]
	internal static extern MentorLake.Gdk.GdkMonitorHandle gdk_display_get_monitor_at_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, int x, int y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))]
	internal static extern MentorLake.Gdk.GdkMonitorHandle gdk_display_get_monitor_at_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_display_get_n_monitors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_display_get_n_screens([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_display_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_get_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] out MentorLake.Gdk.GdkScreenHandle screen, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))]
	internal static extern MentorLake.Gdk.GdkMonitorHandle gdk_display_get_primary_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gdk_display_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, int screen_num);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_display_get_window_at_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, out int win_x, out int win_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_has_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_keyboard_ungrab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, uint time_);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_display_list_devices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_display_list_seats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_notify_startup_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, string startup_id);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_display_peek_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_pointer_is_grabbed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_pointer_ungrab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_put_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_request_selection_notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_set_double_click_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, uint distance);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_set_double_click_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, uint msec);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_store_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle clipboard_window, uint time_, MentorLake.Gdk.GdkAtom[] targets, int n_targets);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_supports_clipboard_persistence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_supports_composite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_supports_cursor_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_supports_cursor_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_supports_input_shapes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_supports_selection_notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_display_supports_shapes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_warp_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int x, int y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_display_get_default();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_display_open(string display_name);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_display_open_default_libgtk_only();

}
