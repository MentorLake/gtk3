namespace MentorLake.Gtk3.Gdk3;

public class GdkDeviceHandle : GObjectHandle
{
	public static void FreeHistory(GdkTimeCoordHandle[] events, int n_events)
	{
		GdkDeviceExterns.gdk_device_free_history(events, n_events);
	}

	public static bool GrabInfoLibgtkOnly(GdkDisplayHandle display, GdkDeviceHandle device, out GdkWindowHandle grab_window, out bool owner_events)
	{
		return GdkDeviceExterns.gdk_device_grab_info_libgtk_only(display, device, out grab_window, out owner_events);
	}

}

public static class GdkDeviceSignalExtensions
{

	public static IObservable<GdkDeviceSignalStructs.ChangedSignal> Signal_Changed(this GdkDeviceHandle instance)
	{
		return Observable.Create((IObserver<GdkDeviceSignalStructs.ChangedSignal> obs) =>
		{
			GdkDeviceSignalDelegates.changed handler = (GdkDeviceHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDeviceSignalStructs.ToolChangedSignal> Signal_ToolChanged(this GdkDeviceHandle instance)
	{
		return Observable.Create((IObserver<GdkDeviceSignalStructs.ToolChangedSignal> obs) =>
		{
			GdkDeviceSignalDelegates.tool_changed handler = (GdkDeviceHandle self, GdkDeviceToolHandle tool, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceSignalStructs.ToolChangedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "tool_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkDeviceSignalStructs
{

public struct ChangedSignal
{
	public GdkDeviceHandle Self;
	public IntPtr UserData;
}

public struct ToolChangedSignal
{
	public GdkDeviceHandle Self;
	public GdkDeviceToolHandle Tool;
	public IntPtr UserData;
}
}

public static class GdkDeviceSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceToolHandle>))] GdkDeviceToolHandle tool, IntPtr user_data);

}


public static class GdkDeviceHandleExtensions
{
	public static GdkDeviceHandle GetAssociatedDevice(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_associated_device(device);
	}

	public static GdkAxisFlags GetAxes(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_axes(device);
	}

	public static bool GetAxis(this GdkDeviceHandle device, double[] axes, GdkAxisUse use, out double value)
	{
		return GdkDeviceExterns.gdk_device_get_axis(device, axes, use, out value);
	}

	public static GdkAxisUse GetAxisUse(this GdkDeviceHandle device, uint index_)
	{
		return GdkDeviceExterns.gdk_device_get_axis_use(device, index_);
	}

	public static bool GetAxisValue(this GdkDeviceHandle device, double[] axes, GdkAtom axis_label, out double value)
	{
		return GdkDeviceExterns.gdk_device_get_axis_value(device, axes, axis_label, out value);
	}

	public static GdkDeviceType GetDeviceType(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_device_type(device);
	}

	public static GdkDisplayHandle GetDisplay(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_display(device);
	}

	public static bool GetHasCursor(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_has_cursor(device);
	}

	public static bool GetHistory(this GdkDeviceHandle device, GdkWindowHandle window, uint start, uint stop, out GdkTimeCoordHandle[] events, out int n_events)
	{
		return GdkDeviceExterns.gdk_device_get_history(device, window, start, stop, out events, out n_events);
	}

	public static bool GetKey(this GdkDeviceHandle device, uint index_, out uint keyval, out GdkModifierType modifiers)
	{
		return GdkDeviceExterns.gdk_device_get_key(device, index_, out keyval, out modifiers);
	}

	public static GdkWindowHandle GetLastEventWindow(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_last_event_window(device);
	}

	public static GdkInputMode GetMode(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_mode(device);
	}

	public static int GetNAxes(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_n_axes(device);
	}

	public static int GetNKeys(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_n_keys(device);
	}

	public static string GetName(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_name(device);
	}

	public static GdkDeviceHandle GetPosition(this GdkDeviceHandle device, out GdkScreenHandle screen, out int x, out int y)
	{
		GdkDeviceExterns.gdk_device_get_position(device, out screen, out x, out y);
		return device;
	}

	public static GdkDeviceHandle GetPositionDouble(this GdkDeviceHandle device, out GdkScreenHandle screen, out double x, out double y)
	{
		GdkDeviceExterns.gdk_device_get_position_double(device, out screen, out x, out y);
		return device;
	}

	public static string GetProductId(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_product_id(device);
	}

	public static GdkSeatHandle GetSeat(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_seat(device);
	}

	public static GdkInputSource GetSource(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_source(device);
	}

	public static GdkDeviceHandle GetState(this GdkDeviceHandle device, GdkWindowHandle window, double[] axes, out GdkModifierType mask)
	{
		GdkDeviceExterns.gdk_device_get_state(device, window, axes, out mask);
		return device;
	}

	public static string GetVendorId(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_vendor_id(device);
	}

	public static GdkWindowHandle GetWindowAtPosition(this GdkDeviceHandle device, out int win_x, out int win_y)
	{
		return GdkDeviceExterns.gdk_device_get_window_at_position(device, out win_x, out win_y);
	}

	public static GdkWindowHandle GetWindowAtPositionDouble(this GdkDeviceHandle device, out double win_x, out double win_y)
	{
		return GdkDeviceExterns.gdk_device_get_window_at_position_double(device, out win_x, out win_y);
	}

	public static GdkGrabStatus Grab(this GdkDeviceHandle device, GdkWindowHandle window, GdkGrabOwnership grab_ownership, bool owner_events, GdkEventMask event_mask, GdkCursorHandle cursor, uint time_)
	{
		return GdkDeviceExterns.gdk_device_grab(device, window, grab_ownership, owner_events, event_mask, cursor, time_);
	}

	public static GListHandle ListAxes(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_list_axes(device);
	}

	public static GListHandle ListSlaveDevices(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_list_slave_devices(device);
	}

	public static GdkDeviceHandle SetAxisUse(this GdkDeviceHandle device, uint index_, GdkAxisUse use)
	{
		GdkDeviceExterns.gdk_device_set_axis_use(device, index_, use);
		return device;
	}

	public static GdkDeviceHandle SetKey(this GdkDeviceHandle device, uint index_, uint keyval, GdkModifierType modifiers)
	{
		GdkDeviceExterns.gdk_device_set_key(device, index_, keyval, modifiers);
		return device;
	}

	public static bool SetMode(this GdkDeviceHandle device, GdkInputMode mode)
	{
		return GdkDeviceExterns.gdk_device_set_mode(device, mode);
	}

	public static GdkDeviceHandle Ungrab(this GdkDeviceHandle device, uint time_)
	{
		GdkDeviceExterns.gdk_device_ungrab(device, time_);
		return device;
	}

	public static GdkDeviceHandle Warp(this GdkDeviceHandle device, GdkScreenHandle screen, int x, int y)
	{
		GdkDeviceExterns.gdk_device_warp(device, screen, x, y);
		return device;
	}

}

internal class GdkDeviceExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceHandle gdk_device_get_associated_device(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkAxisFlags gdk_device_get_axes(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_device_get_axis(GdkDeviceHandle device, double[] axes, GdkAxisUse use, out double value);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkAxisUse gdk_device_get_axis_use(GdkDeviceHandle device, uint index_);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_device_get_axis_value(GdkDeviceHandle device, double[] axes, GdkAtom axis_label, out double value);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceType gdk_device_get_device_type(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_device_get_display(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_device_get_has_cursor(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_device_get_history(GdkDeviceHandle device, GdkWindowHandle window, uint start, uint stop, out GdkTimeCoordHandle[] events, out int n_events);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_device_get_key(GdkDeviceHandle device, uint index_, out uint keyval, out GdkModifierType modifiers);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_device_get_last_event_window(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkInputMode gdk_device_get_mode(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_device_get_n_axes(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_device_get_n_keys(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_name(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_device_get_position(GdkDeviceHandle device, out GdkScreenHandle screen, out int x, out int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_device_get_position_double(GdkDeviceHandle device, out GdkScreenHandle screen, out double x, out double y);

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_product_id(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkSeatHandle gdk_device_get_seat(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkInputSource gdk_device_get_source(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_device_get_state(GdkDeviceHandle device, GdkWindowHandle window, double[] axes, out GdkModifierType mask);

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_vendor_id(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_device_get_window_at_position(GdkDeviceHandle device, out int win_x, out int win_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_device_get_window_at_position_double(GdkDeviceHandle device, out double win_x, out double win_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkGrabStatus gdk_device_grab(GdkDeviceHandle device, GdkWindowHandle window, GdkGrabOwnership grab_ownership, bool owner_events, GdkEventMask event_mask, GdkCursorHandle cursor, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_device_list_axes(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_device_list_slave_devices(GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_device_set_axis_use(GdkDeviceHandle device, uint index_, GdkAxisUse use);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_device_set_key(GdkDeviceHandle device, uint index_, uint keyval, GdkModifierType modifiers);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_device_set_mode(GdkDeviceHandle device, GdkInputMode mode);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_device_ungrab(GdkDeviceHandle device, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_device_warp(GdkDeviceHandle device, GdkScreenHandle screen, int x, int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_device_free_history(GdkTimeCoordHandle[] events, int n_events);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_device_grab_info_libgtk_only(GdkDisplayHandle display, GdkDeviceHandle device, out GdkWindowHandle grab_window, out bool owner_events);

}
