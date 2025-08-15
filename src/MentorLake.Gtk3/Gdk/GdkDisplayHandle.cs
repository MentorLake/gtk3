namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// #GdkDisplay objects purpose are two fold:
/// </para>
/// <para>
/// - To manage and provide information about input devices (pointers and keyboards)
/// </para>
/// <para>
/// - To manage and provide information about the available #GdkScreens
/// </para>
/// <para>
/// GdkDisplay objects are the GDK representation of an X Display,
/// which can be described as a workstation consisting of
/// a keyboard, a pointing device (such as a mouse) and one or more
/// screens.
/// It is used to open and keep track of various GdkScreen objects
/// currently instantiated by the application. It is also used to
/// access the keyboard(s) and mouse pointer(s) of the display.
/// </para>
/// <para>
/// Most of the input device handling has been factored out into
/// the separate #GdkDeviceManager object. Every display has a
/// device manager, which you can obtain using
/// gdk_display_get_device_manager().
/// </para>
/// </summary>

public class GdkDisplayHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Gets the default #GdkDisplay. This is a convenience
/// function for:
/// `gdk_display_manager_get_default_display (gdk_display_manager_get ())`.
/// </para>
/// </summary>

/// <return>
/// a #GdkDisplay, or %NULL if
///   there is no default display.
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDefault()
	{
		return GdkDisplayHandleExterns.gdk_display_get_default();
	}

/// <summary>
/// <para>
/// Opens a display.
/// </para>
/// </summary>

/// <param name="display_name">
/// the name of the display to open
/// </param>
/// <return>
/// a #GdkDisplay, or %NULL if the
///     display could not be opened
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle Open(string display_name)
	{
		return GdkDisplayHandleExterns.gdk_display_open(display_name);
	}

/// <summary>
/// <para>
/// Opens the default display specified by command line arguments or
/// environment variables, sets it as the default display, and returns
/// it. gdk_parse_args() must have been called first. If the default
/// display has previously been set, simply returns that. An internal
/// function that should not be used by applications.
/// </para>
/// </summary>

/// <return>
/// the default display, if it
///   could be opened, otherwise %NULL.
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle OpenDefaultLibgtkOnly()
	{
		return GdkDisplayHandleExterns.gdk_display_open_default_libgtk_only();
	}

}
public static class GdkDisplayHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::closed signal is emitted when the connection to the windowing
/// system for @display is closed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::monitor-added signal is emitted whenever a monitor is
/// added.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::monitor-removed signal is emitted whenever a monitor is
/// removed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::opened signal is emitted when the connection to the windowing
/// system for @display is opened.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::seat-added signal is emitted whenever a new seat is made
/// known to the windowing system.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::seat-removed signal is emitted whenever a seat is removed
/// by the windowing system.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// %TRUE if the display was closed due to an error
/// </para>
/// </summary>

	public bool IsError;

	public IntPtr UserData;
}

public class MonitorAddedSignal
{

	public MentorLake.Gdk.GdkDisplayHandle Self;
/// <summary>
/// <para>
/// the monitor that was just added
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkMonitorHandle Monitor;

	public IntPtr UserData;
}

public class MonitorRemovedSignal
{

	public MentorLake.Gdk.GdkDisplayHandle Self;
/// <summary>
/// <para>
/// the monitor that was just removed
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the seat that was just added
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkSeatHandle Seat;

	public IntPtr UserData;
}

public class SeatRemovedSignal
{

	public MentorLake.Gdk.GdkDisplayHandle Self;
/// <summary>
/// <para>
/// the seat that was just removed
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkSeatHandle Seat;

	public IntPtr UserData;
}
}

public static class GdkDisplayHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::closed signal is emitted when the connection to the windowing
/// system for @display is closed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="is_error">
/// %TRUE if the display was closed due to an error
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, bool is_error, IntPtr user_data);


/// <summary>
/// <para>
/// The ::monitor-added signal is emitted whenever a monitor is
/// added.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="monitor">
/// the monitor that was just added
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitor_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor, IntPtr user_data);


/// <summary>
/// <para>
/// The ::monitor-removed signal is emitted whenever a monitor is
/// removed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="monitor">
/// the monitor that was just removed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitor_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor, IntPtr user_data);


/// <summary>
/// <para>
/// The ::opened signal is emitted when the connection to the windowing
/// system for @display is opened.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void opened([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::seat-added signal is emitted whenever a new seat is made
/// known to the windowing system.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="seat">
/// the seat that was just added
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void seat_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, IntPtr user_data);


/// <summary>
/// <para>
/// The ::seat-removed signal is emitted whenever a seat is removed
/// by the windowing system.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="seat">
/// the seat that was just removed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void seat_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, IntPtr user_data);

}


public static class GdkDisplayHandleExtensions
{
/// <summary>
/// <para>
/// Emits a short beep on @display
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T Beep<T>(this T display) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_beep(display);
		return display;
	}

/// <summary>
/// <para>
/// Closes the connection to the windowing system for the given display,
/// and cleans up associated resources.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T Close<T>(this T display) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_close(display);
		return display;
	}

/// <summary>
/// <para>
/// Returns %TRUE if there is an ongoing grab on @device for @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// %TRUE if there is a grab in effect for @device.
/// </return>

	public static bool DeviceIsGrabbed(this MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_device_is_grabbed(display, device);
	}

/// <summary>
/// <para>
/// Flushes any requests queued for the windowing system; this happens automatically
/// when the main loop blocks waiting for new events, but if your application
/// is drawing without returning control to the main loop, you may need
/// to call this function explicitly. A common case where this function
/// needs to be called is when an application is executing drawing commands
/// from a thread other than the thread where the main loop is running.
/// </para>
/// <para>
/// This is most useful for X11. On windowing systems where requests are
/// handled synchronously, this function will do nothing.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T Flush<T>(this T display) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_flush(display);
		return display;
	}

/// <summary>
/// <para>
/// Returns a #GdkAppLaunchContext suitable for launching
/// applications on the given display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// a new #GdkAppLaunchContext for @display.
///     Free with g_object_unref() when done
/// </return>

	public static MentorLake.Gdk.GdkAppLaunchContextHandle GetAppLaunchContext(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_app_launch_context(display);
	}

/// <summary>
/// <para>
/// Returns the default size to use for cursors on @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the default cursor size.
/// </return>

	public static uint GetDefaultCursorSize(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_default_cursor_size(display);
	}

/// <summary>
/// <para>
/// Returns the default group leader window for all toplevel windows
/// on @display. This window is implicitly created by GDK.
/// See gdk_window_set_group().
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// The default group leader window
/// for @display
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetDefaultGroup(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_default_group(display);
	}

/// <summary>
/// <para>
/// Get the default #GdkScreen for @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the default #GdkScreen object for @display
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetDefaultScreen(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_default_screen(display);
	}

/// <summary>
/// <para>
/// Returns the default #GdkSeat for this display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the default seat.
/// </return>

	public static MentorLake.Gdk.GdkSeatHandle GetDefaultSeat(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_default_seat(display);
	}

/// <summary>
/// <para>
/// Returns the #GdkDeviceManager associated to @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay.
/// </param>
/// <return>
/// A #GdkDeviceManager, or
///          %NULL. This memory is owned by GDK and must not be freed
///          or unreferenced.
/// </return>

	public static MentorLake.Gdk.GdkDeviceManagerHandle GetDeviceManager(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_device_manager(display);
	}

/// <summary>
/// <para>
/// Gets the next #GdkEvent to be processed for @display, fetching events from the
/// windowing system if necessary.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the next #GdkEvent to be processed, or %NULL
/// if no events are pending. The returned #GdkEvent should be freed
/// with gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle GetEvent(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_event(display);
	}

/// <summary>
/// <para>
/// Gets the maximal size to use for cursors on @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="width">
/// the return location for the maximal cursor width
/// </param>
/// <param name="height">
/// the return location for the maximal cursor height
/// </param>

	public static T GetMaximalCursorSize<T>(this T display, out uint width, out uint height) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_get_maximal_cursor_size(display, out width, out height);
		return display;
	}

/// <summary>
/// <para>
/// Gets a monitor associated with this display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="monitor_num">
/// number of the monitor
/// </param>
/// <return>
/// the #GdkMonitor, or %NULL if
///    @monitor_num is not a valid monitor number
/// </return>

	public static MentorLake.Gdk.GdkMonitorHandle GetMonitor(this MentorLake.Gdk.GdkDisplayHandle display, int monitor_num)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_monitor(display, monitor_num);
	}

/// <summary>
/// <para>
/// Gets the monitor in which the point (@x, @y) is located,
/// or a nearby monitor if the point is not in any monitor.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="x">
/// the x coordinate of the point
/// </param>
/// <param name="y">
/// the y coordinate of the point
/// </param>
/// <return>
/// the monitor containing the point
/// </return>

	public static MentorLake.Gdk.GdkMonitorHandle GetMonitorAtPoint(this MentorLake.Gdk.GdkDisplayHandle display, int x, int y)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_monitor_at_point(display, x, y);
	}

/// <summary>
/// <para>
/// Gets the monitor in which the largest area of @window
/// resides, or a monitor close to @window if it is outside
/// of all monitors.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the monitor with the largest overlap with @window
/// </return>

	public static MentorLake.Gdk.GdkMonitorHandle GetMonitorAtWindow(this MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkWindowHandle window)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_monitor_at_window(display, window);
	}

/// <summary>
/// <para>
/// Gets the number of monitors that belong to @display.
/// </para>
/// <para>
/// The returned number is valid until the next emission of the
/// #GdkDisplay::monitor-added or #GdkDisplay::monitor-removed signal.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the number of monitors
/// </return>

	public static int GetNMonitors(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_n_monitors(display);
	}

/// <summary>
/// <para>
/// Gets the number of screen managed by the @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// number of screens.
/// </return>

	public static int GetNScreens(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_n_screens(display);
	}

/// <summary>
/// <para>
/// Gets the name of the display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// a string representing the display name. This string is owned
/// by GDK and should not be modified or freed.
/// </return>

	public static string GetName(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_name(display);
	}

/// <summary>
/// <para>
/// Gets the current location of the pointer and the current modifier
/// mask for a given display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="screen">
/// location to store the screen that the
///          cursor is on, or %NULL.
/// </param>
/// <param name="x">
/// location to store root window X coordinate of pointer, or %NULL.
/// </param>
/// <param name="y">
/// location to store root window Y coordinate of pointer, or %NULL.
/// </param>
/// <param name="mask">
/// location to store current modifier mask, or %NULL
/// </param>

	public static T GetPointer<T>(this T display, out MentorLake.Gdk.GdkScreenHandle screen, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_get_pointer(display, out screen, out x, out y, out mask);
		return display;
	}

/// <summary>
/// <para>
/// Gets the primary monitor for the display.
/// </para>
/// <para>
/// The primary monitor is considered the monitor where the “main desktop”
/// lives. While normal application windows typically allow the window
/// manager to place the windows, specialized desktop applications
/// such as panels should place themselves on the primary monitor.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the primary monitor, or %NULL if no primary
///     monitor is configured by the user
/// </return>

	public static MentorLake.Gdk.GdkMonitorHandle GetPrimaryMonitor(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_primary_monitor(display);
	}

/// <summary>
/// <para>
/// Returns a screen object for one of the screens of the display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="screen_num">
/// the screen number
/// </param>
/// <return>
/// the #GdkScreen object
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gdk.GdkDisplayHandle display, int screen_num)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_screen(display, screen_num);
	}

/// <summary>
/// <para>
/// Obtains the window underneath the mouse pointer, returning the location
/// of the pointer in that window in @win_x, @win_y for @screen. Returns %NULL
/// if the window under the mouse pointer is not known to GDK (for example,
/// belongs to another application).
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="win_x">
/// return location for x coordinate of the pointer location relative
///    to the window origin, or %NULL
/// </param>
/// <param name="win_y">
/// return location for y coordinate of the pointer location relative
///  &amp;    to the window origin, or %NULL
/// </param>
/// <return>
/// the window under the mouse
///   pointer, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindowAtPointer(this MentorLake.Gdk.GdkDisplayHandle display, out int win_x, out int win_y)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_get_window_at_pointer(display, out win_x, out win_y);
	}

/// <summary>
/// <para>
/// Returns whether the display has events that are waiting
/// to be processed.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// %TRUE if there are events ready to be processed.
/// </return>

	public static bool HasPending(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_has_pending(display);
	}

/// <summary>
/// <para>
/// Finds out if the display has been closed.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// %TRUE if the display is closed.
/// </return>

	public static bool IsClosed(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_is_closed(display);
	}

/// <summary>
/// <para>
/// Release any keyboard grab
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay.
/// </param>
/// <param name="time_">
/// a timestap (e.g #GDK_CURRENT_TIME).
/// </param>

	public static T KeyboardUngrab<T>(this T display, uint time_) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_keyboard_ungrab(display, time_);
		return display;
	}

/// <summary>
/// <para>
/// Returns the list of available input devices attached to @display.
/// The list is statically allocated and should not be freed.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// 
///     a list of #GdkDevice
/// </return>

	public static MentorLake.GLib.GListHandle ListDevices(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_list_devices(display);
	}

/// <summary>
/// <para>
/// Returns the list of seats known to @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the
///          list of seats known to the #GdkDisplay
/// </return>

	public static MentorLake.GLib.GListHandle ListSeats(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_list_seats(display);
	}

/// <summary>
/// <para>
/// Indicates to the GUI environment that the application has
/// finished loading, using a given identifier.
/// </para>
/// <para>
/// GTK+ will call this function automatically for #GtkWindow
/// with custom startup-notification identifier unless
/// gtk_window_set_auto_startup_notification() is called to
/// disable that feature.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="startup_id">
/// a startup-notification identifier, for which
///     notification process should be completed
/// </param>

	public static T NotifyStartupComplete<T>(this T display, string startup_id) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_notify_startup_complete(display, startup_id);
		return display;
	}

/// <summary>
/// <para>
/// Gets a copy of the first #GdkEvent in the @display’s event queue, without
/// removing the event from the queue.  (Note that this function will
/// not get more events from the windowing system.  It only checks the events
/// that have already been moved to the GDK event queue.)
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// a copy of the first #GdkEvent on the event
/// queue, or %NULL if no events are in the queue. The returned
/// #GdkEvent should be freed with gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle PeekEvent(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_peek_event(display);
	}

/// <summary>
/// <para>
/// Test if the pointer is grabbed.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// %TRUE if an active X pointer grab is in effect
/// </return>

	public static bool PointerIsGrabbed(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_pointer_is_grabbed(display);
	}

/// <summary>
/// <para>
/// Release any pointer grab.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay.
/// </param>
/// <param name="time_">
/// a timestap (e.g. %GDK_CURRENT_TIME).
/// </param>

	public static T PointerUngrab<T>(this T display, uint time_) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_pointer_ungrab(display, time_);
		return display;
	}

/// <summary>
/// <para>
/// Appends a copy of the given event onto the front of the event
/// queue for @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="@event">
/// a #GdkEvent.
/// </param>

	public static T PutEvent<T>(this T display, MentorLake.Gdk.GdkEventHandle @event) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_put_event(display, @event);
		return display;
	}

/// <summary>
/// <para>
/// Request #GdkEventOwnerChange events for ownership changes
/// of the selection named by the given atom.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="selection">
/// the #GdkAtom naming the selection for which
///             ownership change notification is requested
/// </param>
/// <return>
/// whether #GdkEventOwnerChange events will
///               be sent.
/// </return>

	public static bool RequestSelectionNotification(this MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_request_selection_notification(display, selection);
	}

/// <summary>
/// <para>
/// Sets the double click distance (two clicks within this distance
/// count as a double click and result in a #GDK_2BUTTON_PRESS event).
/// See also gdk_display_set_double_click_time().
/// Applications should not set this, it is a global
/// user-configured setting.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="distance">
/// distance in pixels
/// </param>

	public static T SetDoubleClickDistance<T>(this T display, uint distance) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_set_double_click_distance(display, distance);
		return display;
	}

/// <summary>
/// <para>
/// Sets the double click time (two clicks within this time interval
/// count as a double click and result in a #GDK_2BUTTON_PRESS event).
/// Applications should not set this, it is a global
/// user-configured setting.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="msec">
/// double click time in milliseconds (thousandths of a second)
/// </param>

	public static T SetDoubleClickTime<T>(this T display, uint msec) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_set_double_click_time(display, msec);
		return display;
	}

/// <summary>
/// <para>
/// Issues a request to the clipboard manager to store the
/// clipboard data. On X11, this is a special program that works
/// according to the
/// [FreeDesktop Clipboard Specification](http://www.freedesktop.org/Standards/clipboard-manager-spec).
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="clipboard_window">
/// a #GdkWindow belonging to the clipboard owner
/// </param>
/// <param name="time_">
/// a timestamp
/// </param>
/// <param name="targets">
/// an array of targets
///                    that should be saved, or %NULL
///                    if all available targets should be saved.
/// </param>
/// <param name="n_targets">
/// length of the @targets array
/// </param>

	public static T StoreClipboard<T>(this T display, MentorLake.Gdk.GdkWindowHandle clipboard_window, uint time_, MentorLake.Gdk.GdkAtom[] targets, int n_targets) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_store_clipboard(display, clipboard_window, time_, targets, n_targets);
		return display;
	}

/// <summary>
/// <para>
/// Returns whether the speicifed display supports clipboard
/// persistance; i.e. if it’s possible to store the clipboard data after an
/// application has quit. On X11 this checks if a clipboard daemon is
/// running.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// %TRUE if the display supports clipboard persistance.
/// </return>

	public static bool SupportsClipboardPersistence(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_clipboard_persistence(display);
	}

/// <summary>
/// <para>
/// Returns %TRUE if gdk_window_set_composited() can be used
/// to redirect drawing on the window using compositing.
/// </para>
/// <para>
/// Currently this only works on X11 with XComposite and
/// XDamage extensions available.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// %TRUE if windows may be composited.
/// </return>

	public static bool SupportsComposite(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_composite(display);
	}

/// <summary>
/// <para>
/// Returns %TRUE if cursors can use an 8bit alpha channel
/// on @display. Otherwise, cursors are restricted to bilevel
/// alpha (i.e. a mask).
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// whether cursors can have alpha channels.
/// </return>

	public static bool SupportsCursorAlpha(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_cursor_alpha(display);
	}

/// <summary>
/// <para>
/// Returns %TRUE if multicolored cursors are supported
/// on @display. Otherwise, cursors have only a forground
/// and a background color.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// whether cursors can have multiple colors.
/// </return>

	public static bool SupportsCursorColor(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_cursor_color(display);
	}

/// <summary>
/// <para>
/// Returns %TRUE if gdk_window_input_shape_combine_mask() can
/// be used to modify the input shape of windows on @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// %TRUE if windows with modified input shape are supported
/// </return>

	public static bool SupportsInputShapes(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_input_shapes(display);
	}

/// <summary>
/// <para>
/// Returns whether #GdkEventOwnerChange events will be
/// sent when the owner of a selection changes.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// whether #GdkEventOwnerChange events will
///               be sent.
/// </return>

	public static bool SupportsSelectionNotification(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_selection_notification(display);
	}

/// <summary>
/// <para>
/// Returns %TRUE if gdk_window_shape_combine_mask() can
/// be used to create shaped windows on @display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// %TRUE if shaped windows are supported
/// </return>

	public static bool SupportsShapes(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		return GdkDisplayHandleExterns.gdk_display_supports_shapes(display);
	}

/// <summary>
/// <para>
/// Flushes any requests queued for the windowing system and waits until all
/// requests have been handled. This is often used for making sure that the
/// display is synchronized with the current state of the program. Calling
/// gdk_display_sync() before gdk_error_trap_pop() makes sure that any errors
/// generated from earlier requests are handled before the error trap is
/// removed.
/// </para>
/// <para>
/// This is most useful for X11. On windowing systems where requests are
/// handled synchronously, this function will do nothing.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T Sync<T>(this T display) where T : GdkDisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkDisplayHandle)");
		GdkDisplayHandleExterns.gdk_display_sync(display);
		return display;
	}

/// <summary>
/// <para>
/// Warps the pointer of @display to the point @x,@y on
/// the screen @screen, unless the pointer is confined
/// to a window by a grab, in which case it will be moved
/// as far as allowed by the grab. Warping the pointer
/// creates events as if the user had moved the mouse
/// instantaneously to the destination.
/// </para>
/// <para>
/// Note that the pointer should normally be under the
/// control of the user. This function was added to cover
/// some rare use cases like keyboard navigation support
/// for the color picker in the #GtkColorSelectionDialog.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="screen">
/// the screen of @display to warp the pointer to
/// </param>
/// <param name="x">
/// the x coordinate of the destination
/// </param>
/// <param name="y">
/// the y coordinate of the destination
/// </param>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))]
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
