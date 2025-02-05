namespace MentorLake.Gtk3.Gdk3;

public class GdkMonitorHandle : GObjectHandle
{
}

public static class GdkMonitorSignalExtensions
{

	public static IObservable<GdkMonitorSignalStructs.InvalidateSignal> Signal_Invalidate(this GdkMonitorHandle instance)
	{
		return Observable.Create((IObserver<GdkMonitorSignalStructs.InvalidateSignal> obs) =>
		{
			GdkMonitorSignalDelegates.invalidate handler = (GdkMonitorHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkMonitorSignalStructs.InvalidateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "invalidate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkMonitorSignalStructs
{

public struct InvalidateSignal
{
	public GdkMonitorHandle Self;
	public IntPtr UserData;
}
}

public static class GdkMonitorSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkMonitorHandle>))] GdkMonitorHandle self, IntPtr user_data);

}


public static class GdkMonitorHandleExtensions
{
	public static GdkDisplayHandle GetDisplay(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_display(monitor);
	}

	public static T GetGeometry<T>(this T monitor, out GdkRectangle geometry) where T : GdkMonitorHandle
	{
		GdkMonitorExterns.gdk_monitor_get_geometry(monitor, out geometry);
		return monitor;
	}

	public static int GetHeightMm(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_height_mm(monitor);
	}

	public static string GetManufacturer(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_manufacturer(monitor);
	}

	public static string GetModel(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_model(monitor);
	}

	public static int GetRefreshRate(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_refresh_rate(monitor);
	}

	public static int GetScaleFactor(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_scale_factor(monitor);
	}

	public static GdkSubpixelLayout GetSubpixelLayout(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_subpixel_layout(monitor);
	}

	public static int GetWidthMm(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_width_mm(monitor);
	}

	public static T GetWorkarea<T>(this T monitor, out GdkRectangle workarea) where T : GdkMonitorHandle
	{
		GdkMonitorExterns.gdk_monitor_get_workarea(monitor, out workarea);
		return monitor;
	}

	public static bool IsPrimary(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_is_primary(monitor);
	}

}

internal class GdkMonitorExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_monitor_get_display(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_monitor_get_geometry(GdkMonitorHandle monitor, out GdkRectangle geometry);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_monitor_get_height_mm(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_monitor_get_manufacturer(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_monitor_get_model(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_monitor_get_refresh_rate(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_monitor_get_scale_factor(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkSubpixelLayout gdk_monitor_get_subpixel_layout(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_monitor_get_width_mm(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_monitor_get_workarea(GdkMonitorHandle monitor, out GdkRectangle workarea);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_monitor_is_primary(GdkMonitorHandle monitor);

}
