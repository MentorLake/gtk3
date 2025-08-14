namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// GdkMonitor objects represent the individual outputs that are
/// associated with a #GdkDisplay. GdkDisplay has APIs to enumerate
/// monitors with gdk_display_get_n_monitors() and gdk_display_get_monitor(), and
/// to find particular monitors with gdk_display_get_primary_monitor() or
/// gdk_display_get_monitor_at_window().
/// </para>
/// <para>
/// GdkMonitor was introduced in GTK+ 3.22 and supersedes earlier
/// APIs in GdkScreen to obtain monitor-related information.
/// </para>
/// </summary>

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

public class InvalidateSignal
{

	public MentorLake.Gdk.GdkMonitorHandle Self;

	public IntPtr UserData;
}
}

public static class GdkMonitorHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle self, IntPtr user_data);

}


public static class GdkMonitorHandleExtensions
{
/// <summary>
/// <para>
/// Gets the display that this monitor belongs to.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// the display
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_display(monitor);
	}

/// <summary>
/// <para>
/// Retrieves the size and position of an individual monitor within the
/// display coordinate space. The returned geometry is in  ”application pixels”,
/// not in ”device pixels” (see gdk_monitor_get_scale_factor()).
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <param name="geometry">
/// a #GdkRectangle to be filled with the monitor geometry
/// </param>

	public static T GetGeometry<T>(this T monitor, out MentorLake.Gdk.GdkRectangle geometry) where T : GdkMonitorHandle
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		GdkMonitorHandleExterns.gdk_monitor_get_geometry(monitor, out geometry);
		return monitor;
	}

/// <summary>
/// <para>
/// Gets the height in millimeters of the monitor.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// the physical height of the monitor
/// </return>

	public static int GetHeightMm(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_height_mm(monitor);
	}

/// <summary>
/// <para>
/// Gets the name or PNP ID of the monitor's manufacturer, if available.
/// </para>
/// <para>
/// Note that this value might also vary depending on actual
/// display backend.
/// </para>
/// <para>
/// PNP ID registry is located at https://uefi.org/pnp_id_list
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// the name of the manufacturer, or %NULL
/// </return>

	public static string GetManufacturer(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_manufacturer(monitor);
	}

/// <summary>
/// <para>
/// Gets the a string identifying the monitor model, if available.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// the monitor model, or %NULL
/// </return>

	public static string GetModel(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_model(monitor);
	}

/// <summary>
/// <para>
/// Gets the refresh rate of the monitor, if available.
/// </para>
/// <para>
/// The value is in milli-Hertz, so a refresh rate of 60Hz
/// is returned as 60000.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// the refresh rate in milli-Hertz, or 0
/// </return>

	public static int GetRefreshRate(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_refresh_rate(monitor);
	}

/// <summary>
/// <para>
/// Gets the internal scale factor that maps from monitor coordinates
/// to the actual device pixels. On traditional systems this is 1, but
/// on very high density outputs this can be a higher value (often 2).
/// </para>
/// <para>
/// This can be used if you want to create pixel based data for a
/// particular monitor, but most of the time you’re drawing to a window
/// where it is better to use gdk_window_get_scale_factor() instead.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// the scale factor
/// </return>

	public static int GetScaleFactor(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_scale_factor(monitor);
	}

/// <summary>
/// <para>
/// Gets information about the layout of red, green and blue
/// primaries for each pixel in this monitor, if available.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// the subpixel layout
/// </return>

	public static MentorLake.Gdk.GdkSubpixelLayout GetSubpixelLayout(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_subpixel_layout(monitor);
	}

/// <summary>
/// <para>
/// Gets the width in millimeters of the monitor.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// the physical width of the monitor
/// </return>

	public static int GetWidthMm(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_get_width_mm(monitor);
	}

/// <summary>
/// <para>
/// Retrieves the size and position of the “work area” on a monitor
/// within the display coordinate space. The returned geometry is in
/// ”application pixels”, not in ”device pixels” (see
/// gdk_monitor_get_scale_factor()).
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
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <param name="workarea">
/// a #GdkRectangle to be filled with
///     the monitor workarea
/// </param>

	public static T GetWorkarea<T>(this T monitor, out MentorLake.Gdk.GdkRectangle workarea) where T : GdkMonitorHandle
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		GdkMonitorHandleExterns.gdk_monitor_get_workarea(monitor, out workarea);
		return monitor;
	}

/// <summary>
/// <para>
/// Gets whether this monitor should be considered primary
/// (see gdk_display_get_primary_monitor()).
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GdkMonitor
/// </param>
/// <return>
/// %TRUE if @monitor is primary
/// </return>

	public static bool IsPrimary(this MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GdkMonitorHandle)");
		return GdkMonitorHandleExterns.gdk_monitor_is_primary(monitor);
	}

}

internal class GdkMonitorHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
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
