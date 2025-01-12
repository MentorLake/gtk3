namespace MentorLake.Gtk3.Gdk3;

public class GdkScreenHandle : GObjectHandle
{
	public static GdkScreenHandle GetDefault()
	{
		return GdkScreenExterns.gdk_screen_get_default();
	}

	public static int Height()
	{
		return GdkScreenExterns.gdk_screen_height();
	}

	public static int HeightMm()
	{
		return GdkScreenExterns.gdk_screen_height_mm();
	}

	public static int Width()
	{
		return GdkScreenExterns.gdk_screen_width();
	}

	public static int WidthMm()
	{
		return GdkScreenExterns.gdk_screen_width_mm();
	}

}

public static class GdkScreenSignalExtensions
{

	public static IObservable<GdkScreenSignalStructs.CompositedChangedSignal> Signal_CompositedChanged(this GdkScreenHandle instance)
	{
		return Observable.Create((IObserver<GdkScreenSignalStructs.CompositedChangedSignal> obs) =>
		{
			GdkScreenSignalDelegates.composited_changed handler = (GdkScreenHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkScreenSignalStructs.CompositedChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "composited_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkScreenSignalStructs.MonitorsChangedSignal> Signal_MonitorsChanged(this GdkScreenHandle instance)
	{
		return Observable.Create((IObserver<GdkScreenSignalStructs.MonitorsChangedSignal> obs) =>
		{
			GdkScreenSignalDelegates.monitors_changed handler = (GdkScreenHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkScreenSignalStructs.MonitorsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "monitors_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkScreenSignalStructs.SizeChangedSignal> Signal_SizeChanged(this GdkScreenHandle instance)
	{
		return Observable.Create((IObserver<GdkScreenSignalStructs.SizeChangedSignal> obs) =>
		{
			GdkScreenSignalDelegates.size_changed handler = (GdkScreenHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkScreenSignalStructs.SizeChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "size_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkScreenSignalStructs
{

public struct CompositedChangedSignal
{
	public GdkScreenHandle Self;
	public IntPtr UserData;
}

public struct MonitorsChangedSignal
{
	public GdkScreenHandle Self;
	public IntPtr UserData;
}

public struct SizeChangedSignal
{
	public GdkScreenHandle Self;
	public IntPtr UserData;
}
}

public static class GdkScreenSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void composited_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkScreenHandle>))] GdkScreenHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitors_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkScreenHandle>))] GdkScreenHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkScreenHandle>))] GdkScreenHandle self, IntPtr user_data);

}


public static class GdkScreenHandleExtensions
{
	public static GdkWindowHandle GetActiveWindow(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_active_window(screen);
	}

	public static GdkDisplayHandle GetDisplay(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_display(screen);
	}

	public static cairo_font_options_tHandle GetFontOptions(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_font_options(screen);
	}

	public static int GetHeight(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_height(screen);
	}

	public static int GetHeightMm(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_height_mm(screen);
	}

	public static int GetMonitorAtPoint(this GdkScreenHandle screen, int x, int y)
	{
		return GdkScreenExterns.gdk_screen_get_monitor_at_point(screen, x, y);
	}

	public static int GetMonitorAtWindow(this GdkScreenHandle screen, GdkWindowHandle window)
	{
		return GdkScreenExterns.gdk_screen_get_monitor_at_window(screen, window);
	}

	public static GdkScreenHandle GetMonitorGeometry(this GdkScreenHandle screen, int monitor_num, out GdkRectangle dest)
	{
		GdkScreenExterns.gdk_screen_get_monitor_geometry(screen, monitor_num, out dest);
		return screen;
	}

	public static int GetMonitorHeightMm(this GdkScreenHandle screen, int monitor_num)
	{
		return GdkScreenExterns.gdk_screen_get_monitor_height_mm(screen, monitor_num);
	}

	public static string GetMonitorPlugName(this GdkScreenHandle screen, int monitor_num)
	{
		return GdkScreenExterns.gdk_screen_get_monitor_plug_name(screen, monitor_num);
	}

	public static int GetMonitorScaleFactor(this GdkScreenHandle screen, int monitor_num)
	{
		return GdkScreenExterns.gdk_screen_get_monitor_scale_factor(screen, monitor_num);
	}

	public static int GetMonitorWidthMm(this GdkScreenHandle screen, int monitor_num)
	{
		return GdkScreenExterns.gdk_screen_get_monitor_width_mm(screen, monitor_num);
	}

	public static GdkScreenHandle GetMonitorWorkarea(this GdkScreenHandle screen, int monitor_num, out GdkRectangle dest)
	{
		GdkScreenExterns.gdk_screen_get_monitor_workarea(screen, monitor_num, out dest);
		return screen;
	}

	public static int GetNMonitors(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_n_monitors(screen);
	}

	public static int GetNumber(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_number(screen);
	}

	public static int GetPrimaryMonitor(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_primary_monitor(screen);
	}

	public static double GetResolution(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_resolution(screen);
	}

	public static GdkVisualHandle GetRgbaVisual(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_rgba_visual(screen);
	}

	public static GdkWindowHandle GetRootWindow(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_root_window(screen);
	}

	public static bool GetSetting(this GdkScreenHandle screen, string name, GValueHandle value)
	{
		return GdkScreenExterns.gdk_screen_get_setting(screen, name, value);
	}

	public static GdkVisualHandle GetSystemVisual(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_system_visual(screen);
	}

	public static GListHandle GetToplevelWindows(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_toplevel_windows(screen);
	}

	public static int GetWidth(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_width(screen);
	}

	public static int GetWidthMm(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_width_mm(screen);
	}

	public static GListHandle GetWindowStack(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_get_window_stack(screen);
	}

	public static bool IsComposited(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_is_composited(screen);
	}

	public static GListHandle ListVisuals(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_list_visuals(screen);
	}

	public static string MakeDisplayName(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_screen_make_display_name(screen);
	}

	public static GdkScreenHandle SetFontOptions(this GdkScreenHandle screen, cairo_font_options_tHandle options)
	{
		GdkScreenExterns.gdk_screen_set_font_options(screen, options);
		return screen;
	}

	public static GdkScreenHandle SetResolution(this GdkScreenHandle screen, double dpi)
	{
		GdkScreenExterns.gdk_screen_set_resolution(screen, dpi);
		return screen;
	}

	public static PangoContextHandle GdkPangoContextGetForScreen(this GdkScreenHandle screen)
	{
		return GdkScreenExterns.gdk_pango_context_get_for_screen(screen);
	}

}

internal class GdkScreenExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_screen_get_active_window(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_screen_get_display(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_font_options_tHandle gdk_screen_get_font_options(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_height(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_height_mm(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_monitor_at_point(GdkScreenHandle screen, int x, int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_monitor_at_window(GdkScreenHandle screen, GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_screen_get_monitor_geometry(GdkScreenHandle screen, int monitor_num, out GdkRectangle dest);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_monitor_height_mm(GdkScreenHandle screen, int monitor_num);

	[DllImport(Libraries.Gdk3)]
	internal static extern string gdk_screen_get_monitor_plug_name(GdkScreenHandle screen, int monitor_num);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_monitor_scale_factor(GdkScreenHandle screen, int monitor_num);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_monitor_width_mm(GdkScreenHandle screen, int monitor_num);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_screen_get_monitor_workarea(GdkScreenHandle screen, int monitor_num, out GdkRectangle dest);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_n_monitors(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_number(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_primary_monitor(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern double gdk_screen_get_resolution(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualHandle gdk_screen_get_rgba_visual(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_screen_get_root_window(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_screen_get_setting(GdkScreenHandle screen, string name, GValueHandle value);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualHandle gdk_screen_get_system_visual(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_screen_get_toplevel_windows(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_width(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_get_width_mm(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_screen_get_window_stack(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_screen_is_composited(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_screen_list_visuals(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern string gdk_screen_make_display_name(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_screen_set_font_options(GdkScreenHandle screen, cairo_font_options_tHandle options);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_screen_set_resolution(GdkScreenHandle screen, double dpi);

	[DllImport(Libraries.Gdk3)]
	internal static extern PangoContextHandle gdk_pango_context_get_for_screen(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkScreenHandle gdk_screen_get_default();

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_height();

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_height_mm();

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_width();

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_screen_width_mm();

}
