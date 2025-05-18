namespace MentorLake.Gdk;

public class GdkScreenHandle : GObjectHandle
{
	public static MentorLake.Gdk.GdkScreenHandle GetDefault()
	{
		return GdkScreenHandleExterns.gdk_screen_get_default();
	}

	public static int Height()
	{
		return GdkScreenHandleExterns.gdk_screen_height();
	}

	public static int HeightMm()
	{
		return GdkScreenHandleExterns.gdk_screen_height_mm();
	}

	public static int Width()
	{
		return GdkScreenHandleExterns.gdk_screen_width();
	}

	public static int WidthMm()
	{
		return GdkScreenHandleExterns.gdk_screen_width_mm();
	}

}
public static class GdkScreenHandleSignalExtensions
{

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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void composited_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void monitors_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle self, IntPtr user_data);

}


public static class GdkScreenHandleExtensions
{
	public static MentorLake.Gdk.GdkWindowHandle GetActiveWindow(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_active_window(screen);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_display(screen);
	}

	public static MentorLake.cairo.cairo_font_options_tHandle GetFontOptions(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_font_options(screen);
	}

	public static int GetHeight(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_height(screen);
	}

	public static int GetHeightMm(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_height_mm(screen);
	}

	public static int GetMonitorAtPoint(this MentorLake.Gdk.GdkScreenHandle screen, int x, int y)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_at_point(screen, x, y);
	}

	public static int GetMonitorAtWindow(this MentorLake.Gdk.GdkScreenHandle screen, MentorLake.Gdk.GdkWindowHandle window)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_at_window(screen, window);
	}

	public static T GetMonitorGeometry<T>(this T screen, int monitor_num, out MentorLake.Gdk.GdkRectangle dest) where T : GdkScreenHandle
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		GdkScreenHandleExterns.gdk_screen_get_monitor_geometry(screen, monitor_num, out dest);
		return screen;
	}

	public static int GetMonitorHeightMm(this MentorLake.Gdk.GdkScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_height_mm(screen, monitor_num);
	}

	public static string GetMonitorPlugName(this MentorLake.Gdk.GdkScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_plug_name(screen, monitor_num);
	}

	public static int GetMonitorScaleFactor(this MentorLake.Gdk.GdkScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_scale_factor(screen, monitor_num);
	}

	public static int GetMonitorWidthMm(this MentorLake.Gdk.GdkScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_monitor_width_mm(screen, monitor_num);
	}

	public static T GetMonitorWorkarea<T>(this T screen, int monitor_num, out MentorLake.Gdk.GdkRectangle dest) where T : GdkScreenHandle
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		GdkScreenHandleExterns.gdk_screen_get_monitor_workarea(screen, monitor_num, out dest);
		return screen;
	}

	public static int GetNMonitors(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_n_monitors(screen);
	}

	public static int GetNumber(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_number(screen);
	}

	public static int GetPrimaryMonitor(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_primary_monitor(screen);
	}

	public static double GetResolution(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_resolution(screen);
	}

	public static MentorLake.Gdk.GdkVisualHandle GetRgbaVisual(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_rgba_visual(screen);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetRootWindow(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_root_window(screen);
	}

	public static bool GetSetting(this MentorLake.Gdk.GdkScreenHandle screen, string name, MentorLake.GObject.GValueHandle value)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_setting(screen, name, value);
	}

	public static MentorLake.Gdk.GdkVisualHandle GetSystemVisual(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_system_visual(screen);
	}

	public static MentorLake.GLib.GListHandle GetToplevelWindows(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_toplevel_windows(screen);
	}

	public static int GetWidth(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_width(screen);
	}

	public static int GetWidthMm(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_width_mm(screen);
	}

	public static MentorLake.GLib.GListHandle GetWindowStack(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_get_window_stack(screen);
	}

	public static bool IsComposited(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_is_composited(screen);
	}

	public static MentorLake.GLib.GListHandle ListVisuals(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_list_visuals(screen);
	}

	public static string MakeDisplayName(this MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		return GdkScreenHandleExterns.gdk_screen_make_display_name(screen);
	}

	public static T SetFontOptions<T>(this T screen, MentorLake.cairo.cairo_font_options_tHandle options) where T : GdkScreenHandle
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkScreenHandle)");
		GdkScreenHandleExterns.gdk_screen_set_font_options(screen, options);
		return screen;
	}

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
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
