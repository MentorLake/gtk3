namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// #GdkScreen objects are the GDK representation of the screen on
/// which windows can be displayed and on which the pointer moves.
/// X originally identified screens with physical screens, but
/// nowadays it is more common to have a single #GdkScreen which
/// combines several physical monitors (see gdk_screen_get_n_monitors()).
/// </para>
/// <para>
/// GdkScreen is used throughout GDK and GTK+ to specify which screen
/// the top level windows are to be displayed on. it is also used to
/// query the screen specification and default settings such as
/// the default visual (gdk_screen_get_system_visual()), the dimensions
/// of the physical monitors (gdk_screen_get_monitor_geometry()), etc.
/// </para>
/// </summary>

public class GdkScreenHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Gets the default screen for the default display. (See
/// gdk_display_get_default ()).
/// </para>
/// </summary>

/// <return>
/// a #GdkScreen, or %NULL if
///     there is no default display.
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetDefault()
	{
		return GdkScreenHandleExterns.gdk_screen_get_default();
	}

/// <summary>
/// <para>
/// Gets the height of the default screen in pixels. The returned
/// size is in ”application pixels”, not in ”device pixels” (see
/// gdk_screen_get_monitor_scale_factor()).
/// </para>
/// </summary>

/// <return>
/// the height of the default screen in pixels.
/// </return>

	public static int Height()
	{
		return GdkScreenHandleExterns.gdk_screen_height();
	}

/// <summary>
/// <para>
/// Returns the height of the default screen in millimeters.
/// Note that on many X servers this value will not be correct.
/// </para>
/// </summary>

/// <return>
/// the height of the default screen in millimeters,
/// though it is not always correct.
/// </return>

	public static int HeightMm()
	{
		return GdkScreenHandleExterns.gdk_screen_height_mm();
	}

/// <summary>
/// <para>
/// Gets the width of the default screen in pixels. The returned
/// size is in ”application pixels”, not in ”device pixels” (see
/// gdk_screen_get_monitor_scale_factor()).
/// </para>
/// </summary>

/// <return>
/// the width of the default screen in pixels.
/// </return>

	public static int Width()
	{
		return GdkScreenHandleExterns.gdk_screen_width();
	}

/// <summary>
/// <para>
/// Returns the width of the default screen in millimeters.
/// Note that on many X servers this value will not be correct.
/// </para>
/// </summary>

/// <return>
/// the width of the default screen in millimeters,
/// though it is not always correct.
/// </return>

	public static int WidthMm()
	{
		return GdkScreenHandleExterns.gdk_screen_width_mm();
	}

}
public static class GdkScreenHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::composited-changed signal is emitted when the composited
/// status of the screen changes
/// </para>
/// </summary>

	public static IObservable<GdkScreenHandleSignalStructs.CompositedChangedSignal> Signal_CompositedChanged(this GdkScreenHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkScreenHandleSignalStructs.CompositedChangedSignal> obs) =>
		{
			GdkScreenHandleSignalDelegates.composited_changed handler = ( MentorLake.Gdk.GdkScreenHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkScreenHandleSignalStructs.CompositedChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "composited-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::monitors-changed signal is emitted when the number, size
/// or position of the monitors attached to the screen change.
/// </para>
/// <para>
/// Only for X11 and OS X for now. A future implementation for Win32
/// may be a possibility.
/// </para>
/// </summary>

	public static IObservable<GdkScreenHandleSignalStructs.MonitorsChangedSignal> Signal_MonitorsChanged(this GdkScreenHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkScreenHandleSignalStructs.MonitorsChangedSignal> obs) =>
		{
			GdkScreenHandleSignalDelegates.monitors_changed handler = ( MentorLake.Gdk.GdkScreenHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkScreenHandleSignalStructs.MonitorsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "monitors-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::size-changed signal is emitted when the pixel width or
/// height of a screen changes.
/// </para>
/// </summary>

	public static IObservable<GdkScreenHandleSignalStructs.SizeChangedSignal> Signal_SizeChanged(this GdkScreenHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkScreenHandleSignalStructs.SizeChangedSignal> obs) =>
		{
			GdkScreenHandleSignalDelegates.size_changed handler = ( MentorLake.Gdk.GdkScreenHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkScreenHandleSignalStructs.SizeChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
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

public static class GdkScreenHandleSignalStructs
{

public class CompositedChangedSignal
{

	public MentorLake.Gdk.GdkScreenHandle Self;

	public IntPtr UserData;
}

public class MonitorsChangedSignal
{

	public MentorLake.Gdk.GdkScreenHandle Self;

	public IntPtr UserData;
}

public class SizeChangedSignal
{

	public MentorLake.Gdk.GdkScreenHandle Self;

	public IntPtr UserData;
}
}

public static class GdkScreenHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::composited-changed signal is emitted when the composited
/// status of the screen changes
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void composited_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::monitors-changed signal is emitted when the number, size
/// or position of the monitors attached to the screen change.
/// </para>
/// <para>
/// Only for X11 and OS X for now. A future implementation for Win32
/// may be a possibility.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitors_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::size-changed signal is emitted when the pixel width or
/// height of a screen changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle self, IntPtr user_data);

}


public static class GdkScreenHandleExtensions
{
/// <summary>
/// <para>
/// Returns the screen’s currently active window.
/// </para>
/// <para>
/// On X11, this is done by inspecting the _NET_ACTIVE_WINDOW property
/// on the root window, as described in the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec).
/// If there is no currently currently active
/// window, or the window manager does not support the
/// _NET_ACTIVE_WINDOW hint, this function returns %NULL.
/// </para>
/// <para>
/// On other platforms, this function may return %NULL, depending on whether
/// it is implementable on that platform.
/// </para>
/// <para>
/// The returned window should be unrefed using g_object_unref() when
/// no longer needed.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the currently active window,
///   or %NULL.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetActiveWindow(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_active_window(screen);
	}

/// <summary>
/// <para>
/// Gets the display to which the @screen belongs.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the display to which @screen belongs
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_display(screen);
	}

/// <summary>
/// <para>
/// Gets any options previously set with gdk_screen_set_font_options().
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the current font options, or %NULL if no
///  default font options have been set.
/// </return>

	public static MentorLake.cairo.cairo_font_options_tHandle GetFontOptions(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_font_options(screen);
	}

/// <summary>
/// <para>
/// Gets the height of @screen in pixels. The returned size is in
/// ”application pixels”, not in ”device pixels” (see
/// gdk_screen_get_monitor_scale_factor()).
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the height of @screen in pixels.
/// </return>

	public static int GetHeight(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_height(screen);
	}

/// <summary>
/// <para>
/// Returns the height of @screen in millimeters.
/// </para>
/// <para>
/// Note that this value is somewhat ill-defined when the screen
/// has multiple monitors of different resolution. It is recommended
/// to use the monitor dimensions instead.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the heigth of @screen in millimeters.
/// </return>

	public static int GetHeightMm(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_height_mm(screen);
	}

/// <summary>
/// <para>
/// Returns the monitor number in which the point (@x,@y) is located.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen.
/// </param>
/// <param name="x">
/// the x coordinate in the virtual screen.
/// </param>
/// <param name="y">
/// the y coordinate in the virtual screen.
/// </param>
/// <return>
/// the monitor number in which the point (@x,@y) lies, or
///   a monitor close to (@x,@y) if the point is not in any monitor.
/// </return>

	public static int GetMonitorAtPoint(this MentorLake.Gdk.GdkScreenHandle screen, int x, int y)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_at_point(screen, x, y);
	}

/// <summary>
/// <para>
/// Returns the number of the monitor in which the largest area of the
/// bounding rectangle of @window resides.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen.
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the monitor number in which most of @window is located,
///     or if @window does not intersect any monitors, a monitor,
///     close to @window.
/// </return>

	public static int GetMonitorAtWindow(this MentorLake.Gdk.GdkScreenHandle screen, MentorLake.Gdk.GdkWindowHandle window)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_at_window(screen, window);
	}

/// <summary>
/// <para>
/// Retrieves the #GdkRectangle representing the size and position of
/// the individual monitor within the entire screen area. The returned
/// geometry is in ”application pixels”, not in ”device pixels” (see
/// gdk_screen_get_monitor_scale_factor()).
/// </para>
/// <para>
/// Monitor numbers start at 0. To obtain the number of monitors of
/// @screen, use gdk_screen_get_n_monitors().
/// </para>
/// <para>
/// Note that the size of the entire screen area can be retrieved via
/// gdk_screen_get_width() and gdk_screen_get_height().
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="monitor_num">
/// the monitor number
/// </param>
/// <param name="dest">
/// a #GdkRectangle to be filled with
///     the monitor geometry
/// </param>

	public static T GetMonitorGeometry<T>(this T screen, int monitor_num, out MentorLake.Gdk.GdkRectangle dest) where T : GdkScreenHandle
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		GdkScreenHandleExterns.gdk_screen_get_monitor_geometry(screen, monitor_num, out dest);
		return screen;
	}

/// <summary>
/// <para>
/// Gets the height in millimeters of the specified monitor.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="monitor_num">
/// number of the monitor, between 0 and gdk_screen_get_n_monitors (screen)
/// </param>
/// <return>
/// the height of the monitor, or -1 if not available
/// </return>

	public static int GetMonitorHeightMm(this MentorLake.Gdk.GdkScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_height_mm(screen, monitor_num);
	}

/// <summary>
/// <para>
/// Returns the output name of the specified monitor.
/// Usually something like VGA, DVI, or TV, not the actual
/// product name of the display device.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="monitor_num">
/// number of the monitor, between 0 and gdk_screen_get_n_monitors (screen)
/// </param>
/// <return>
/// a newly-allocated string containing the name
///   of the monitor, or %NULL if the name cannot be determined
/// </return>

	public static string GetMonitorPlugName(this MentorLake.Gdk.GdkScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_plug_name(screen, monitor_num);
	}

/// <summary>
/// <para>
/// Returns the internal scale factor that maps from monitor coordinates
/// to the actual device pixels. On traditional systems this is 1, but
/// on very high density outputs this can be a higher value (often 2).
/// </para>
/// <para>
/// This can be used if you want to create pixel based data for a
/// particular monitor, but most of the time you’re drawing to a window
/// where it is better to use gdk_window_get_scale_factor() instead.
/// </para>
/// </summary>

/// <param name="screen">
/// screen to get scale factor for
/// </param>
/// <param name="monitor_num">
/// number of the monitor, between 0 and gdk_screen_get_n_monitors (screen)
/// </param>
/// <return>
/// the scale factor
/// </return>

	public static int GetMonitorScaleFactor(this MentorLake.Gdk.GdkScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_scale_factor(screen, monitor_num);
	}

/// <summary>
/// <para>
/// Gets the width in millimeters of the specified monitor, if available.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="monitor_num">
/// number of the monitor, between 0 and gdk_screen_get_n_monitors (screen)
/// </param>
/// <return>
/// the width of the monitor, or -1 if not available
/// </return>

	public static int GetMonitorWidthMm(this MentorLake.Gdk.GdkScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_width_mm(screen, monitor_num);
	}

/// <summary>
/// <para>
/// Retrieves the #GdkRectangle representing the size and position of
/// the “work area” on a monitor within the entire screen area. The returned
/// geometry is in ”application pixels”, not in ”device pixels” (see
/// gdk_screen_get_monitor_scale_factor()).
/// </para>
/// <para>
/// The work area should be considered when positioning menus and
/// similar popups, to avoid placing them below panels, docks or other
/// desktop components.
/// </para>
/// <para>
/// Note that not all backends may have a concept of workarea. This
/// function will return the monitor geometry if a workarea is not
/// available, or does not apply.
/// </para>
/// <para>
/// Monitor numbers start at 0. To obtain the number of monitors of
/// @screen, use gdk_screen_get_n_monitors().
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="monitor_num">
/// the monitor number
/// </param>
/// <param name="dest">
/// a #GdkRectangle to be filled with
///     the monitor workarea
/// </param>

	public static T GetMonitorWorkarea<T>(this T screen, int monitor_num, out MentorLake.Gdk.GdkRectangle dest) where T : GdkScreenHandle
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		GdkScreenHandleExterns.gdk_screen_get_monitor_workarea(screen, monitor_num, out dest);
		return screen;
	}

/// <summary>
/// <para>
/// Returns the number of monitors which @screen consists of.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// number of monitors which @screen consists of
/// </return>

	public static int GetNMonitors(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_n_monitors(screen);
	}

/// <summary>
/// <para>
/// Gets the index of @screen among the screens in the display
/// to which it belongs. (See gdk_screen_get_display())
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the index
/// </return>

	public static int GetNumber(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_number(screen);
	}

/// <summary>
/// <para>
/// Gets the primary monitor for @screen.  The primary monitor
/// is considered the monitor where the “main desktop” lives.
/// While normal application windows typically allow the window
/// manager to place the windows, specialized desktop applications
/// such as panels should place themselves on the primary monitor.
/// </para>
/// <para>
/// If no primary monitor is configured by the user, the return value
/// will be 0, defaulting to the first monitor.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen.
/// </param>
/// <return>
/// An integer index for the primary monitor, or 0 if none is configured.
/// </return>

	public static int GetPrimaryMonitor(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_primary_monitor(screen);
	}

/// <summary>
/// <para>
/// Gets the resolution for font handling on the screen; see
/// gdk_screen_set_resolution() for full details.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the current resolution, or -1 if no resolution
/// has been set.
/// </return>

	public static double GetResolution(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_resolution(screen);
	}

/// <summary>
/// <para>
/// Gets a visual to use for creating windows with an alpha channel.
/// The windowing system on which GTK+ is running
/// may not support this capability, in which case %NULL will
/// be returned. Even if a non-%NULL value is returned, its
/// possible that the window’s alpha channel won’t be honored
/// when displaying the window on the screen: in particular, for
/// X an appropriate windowing manager and compositing manager
/// must be running to provide appropriate display.
/// </para>
/// <para>
/// This functionality is not implemented in the Windows backend.
/// </para>
/// <para>
/// For setting an overall opacity for a top-level window, see
/// gdk_window_set_opacity().
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// a visual to use for windows
///     with an alpha channel or %NULL if the capability is not
///     available.
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetRgbaVisual(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_rgba_visual(screen);
	}

/// <summary>
/// <para>
/// Gets the root window of @screen.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the root window
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetRootWindow(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_root_window(screen);
	}

/// <summary>
/// <para>
/// Retrieves a desktop-wide setting such as double-click time
/// for the #GdkScreen @screen.
/// </para>
/// <para>
/// FIXME needs a list of valid settings here, or a link to
/// more information.
/// </para>
/// </summary>

/// <param name="screen">
/// the #GdkScreen where the setting is located
/// </param>
/// <param name="name">
/// the name of the setting
/// </param>
/// <param name="value">
/// location to store the value of the setting
/// </param>
/// <return>
/// %TRUE if the setting existed and a value was stored
///   in @value, %FALSE otherwise.
/// </return>

	public static bool GetSetting(this MentorLake.Gdk.GdkScreenHandle screen, string name, MentorLake.GObject.GValueHandle value)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_setting(screen, name, value);
	}

/// <summary>
/// <para>
/// Get the system’s default visual for @screen.
/// This is the visual for the root window of the display.
/// The return value should not be freed.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen.
/// </param>
/// <return>
/// the system visual
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetSystemVisual(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_system_visual(screen);
	}

/// <summary>
/// <para>
/// Obtains a list of all toplevel windows known to GDK on the screen @screen.
/// A toplevel window is a child of the root window (see
/// gdk_get_default_root_window()).
/// </para>
/// <para>
/// The returned list should be freed with g_list_free(), but
/// its elements need not be freed.
/// </para>
/// </summary>

/// <param name="screen">
/// The #GdkScreen where the toplevels are located.
/// </param>
/// <return>
/// 
///     list of toplevel windows, free with g_list_free()
/// </return>

	public static MentorLake.GLib.GListHandle GetToplevelWindows(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_toplevel_windows(screen);
	}

/// <summary>
/// <para>
/// Gets the width of @screen in pixels. The returned size is in
/// ”application pixels”, not in ”device pixels” (see
/// gdk_screen_get_monitor_scale_factor()).
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the width of @screen in pixels.
/// </return>

	public static int GetWidth(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_width(screen);
	}

/// <summary>
/// <para>
/// Gets the width of @screen in millimeters.
/// </para>
/// <para>
/// Note that this value is somewhat ill-defined when the screen
/// has multiple monitors of different resolution. It is recommended
/// to use the monitor dimensions instead.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the width of @screen in millimeters.
/// </return>

	public static int GetWidthMm(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_width_mm(screen);
	}

/// <summary>
/// <para>
/// Returns a #GList of #GdkWindows representing the current
/// window stack.
/// </para>
/// <para>
/// On X11, this is done by inspecting the _NET_CLIENT_LIST_STACKING
/// property on the root window, as described in the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec).
/// If the window manager does not support the
/// _NET_CLIENT_LIST_STACKING hint, this function returns %NULL.
/// </para>
/// <para>
/// On other platforms, this function may return %NULL, depending on whether
/// it is implementable on that platform.
/// </para>
/// <para>
/// The returned list is newly allocated and owns references to the
/// windows it contains, so it should be freed using g_list_free() and
/// its windows unrefed using g_object_unref() when no longer needed.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// a
///     list of #GdkWindows for the current window stack, or %NULL.
/// </return>

	public static MentorLake.GLib.GListHandle GetWindowStack(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_window_stack(screen);
	}

/// <summary>
/// <para>
/// Returns whether windows with an RGBA visual can reasonably
/// be expected to have their alpha channel drawn correctly on
/// the screen.
/// </para>
/// <para>
/// On X11 this function returns whether a compositing manager is
/// compositing @screen.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// Whether windows with RGBA visuals can reasonably be
/// expected to have their alpha channels drawn correctly on the screen.
/// </return>

	public static bool IsComposited(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_is_composited(screen);
	}

/// <summary>
/// <para>
/// Lists the available visuals for the specified @screen.
/// A visual describes a hardware image data format.
/// For example, a visual might support 24-bit color, or 8-bit color,
/// and might expect pixels to be in a certain format.
/// </para>
/// <para>
/// Call g_list_free() on the return value when you’re finished with it.
/// </para>
/// </summary>

/// <param name="screen">
/// the relevant #GdkScreen.
/// </param>
/// <return>
/// 
///     a list of visuals; the list must be freed, but not its contents
/// </return>

	public static MentorLake.GLib.GListHandle ListVisuals(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_list_visuals(screen);
	}

/// <summary>
/// <para>
/// Determines the name to pass to gdk_display_open() to get
/// a #GdkDisplay with this screen as the default screen.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// a newly allocated string, free with g_free()
/// </return>

	public static string MakeDisplayName(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_make_display_name(screen);
	}

/// <summary>
/// <para>
/// Sets the default font options for the screen. These
/// options will be set on any #PangoContext’s newly created
/// with gdk_pango_context_get_for_screen(). Changing the
/// default set of font options does not affect contexts that
/// have already been created.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="options">
/// a #cairo_font_options_t, or %NULL to unset any
///   previously set default font options.
/// </param>

	public static T SetFontOptions<T>(this T screen, MentorLake.cairo.cairo_font_options_tHandle options) where T : GdkScreenHandle
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		GdkScreenHandleExterns.gdk_screen_set_font_options(screen, options);
		return screen;
	}

/// <summary>
/// <para>
/// Sets the resolution for font handling on the screen. This is a
/// scale factor between points specified in a #PangoFontDescription
/// and cairo units. The default value is 96, meaning that a 10 point
/// font will be 13 units high. (10 * 96. / 72. = 13.3).
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="dpi">
/// the resolution in “dots per inch”. (Physical inches aren’t actually
///   involved; the terminology is conventional.)
/// </param>

	public static T SetResolution<T>(this T screen, double dpi) where T : GdkScreenHandle
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		GdkScreenHandleExterns.gdk_screen_set_resolution(screen, dpi);
		return screen;
	}

}

internal class GdkScreenHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_screen_get_active_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_screen_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_options_tHandle gdk_screen_get_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_height_mm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_monitor_at_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int x, int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_monitor_at_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_screen_get_monitor_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int monitor_num, out MentorLake.Gdk.GdkRectangle dest);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_monitor_height_mm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int monitor_num);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_screen_get_monitor_plug_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int monitor_num);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_monitor_scale_factor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int monitor_num);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_monitor_width_mm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int monitor_num);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_screen_get_monitor_workarea([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int monitor_num, out MentorLake.Gdk.GdkRectangle dest);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_n_monitors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_primary_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern double gdk_screen_get_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gdk_screen_get_rgba_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_screen_get_root_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_screen_get_setting([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gdk_screen_get_system_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_screen_get_toplevel_windows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_get_width_mm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_screen_get_window_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_screen_is_composited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_screen_list_visuals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_screen_make_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_screen_set_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_screen_set_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, double dpi);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gdk_screen_get_default();

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_height();

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_height_mm();

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_width();

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_screen_width_mm();

}
