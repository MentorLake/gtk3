namespace MentorLake.Gdk;

public class GdkMonitorHandle : GObjectHandle
{
}
public static class GdkMonitorHandleSignalExtensions
{

	public static IObservable<GdkMonitorHandleSignalStructs.InvalidateSignal> Signal_Invalidate(this GdkMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkMonitorHandleSignalStructs.InvalidateSignal> obs) =>
		{
			GdkMonitorHandleSignalDelegates.invalidate handler = ( MentorLake.Gdk.GdkMonitorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkMonitorHandleSignalStructs.InvalidateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "invalidate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkMonitorHandleSignalStructs
{

public struct InvalidateSignal
{
	public MentorLake.Gdk.GdkMonitorHandle Self;
	public IntPtr UserData;
}
}

public static class GdkMonitorHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle self, IntPtr user_data);

}


public static class GdkMonitorHandleExtensions
{
	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_display(monitor);
	}

	public static T GetGeometry<T>(this T monitor, out MentorLake.Gdk.GdkRectangle geometry) where T : GdkMonitorHandle
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		GdkMonitorHandleExterns.gdk_monitor_get_geometry(monitor, out geometry);
		return monitor;
	}

	public static int GetHeightMm(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_height_mm(monitor);
	}

	public static string GetManufacturer(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_manufacturer(monitor);
	}

	public static string GetModel(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_model(monitor);
	}

	public static int GetRefreshRate(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_refresh_rate(monitor);
	}

	public static int GetScaleFactor(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_scale_factor(monitor);
	}

	public static MentorLake.Gdk.GdkSubpixelLayout GetSubpixelLayout(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_subpixel_layout(monitor);
	}

	public static int GetWidthMm(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_width_mm(monitor);
	}

	public static T GetWorkarea<T>(this T monitor, out MentorLake.Gdk.GdkRectangle workarea) where T : GdkMonitorHandle
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		GdkMonitorHandleExterns.gdk_monitor_get_workarea(monitor, out workarea);
		return monitor;
	}

	public static bool IsPrimary(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_is_primary(monitor);
	}

}

internal class GdkMonitorHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_monitor_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_monitor_get_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor, out MentorLake.Gdk.GdkRectangle geometry);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_monitor_get_height_mm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_monitor_get_manufacturer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_monitor_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_monitor_get_refresh_rate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_monitor_get_scale_factor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkSubpixelLayout gdk_monitor_get_subpixel_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_monitor_get_width_mm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_monitor_get_workarea([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor, out MentorLake.Gdk.GdkRectangle workarea);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_monitor_is_primary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

}
