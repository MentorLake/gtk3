namespace MentorLake.Gdk;

public class GdkDeviceHandle : GObjectHandle
{
	public static void FreeHistory(MentorLake.Gdk.GdkTimeCoordHandle[] events, int n_events)
	{
		GdkDeviceHandleExterns.gdk_device_free_history(events, n_events);
	}

	public static bool GrabInfoLibgtkOnly(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkDeviceHandle device, out MentorLake.Gdk.GdkWindowHandle grab_window, out bool owner_events)
	{
		return GdkDeviceHandleExterns.gdk_device_grab_info_libgtk_only(display, device, out grab_window, out owner_events);
	}

}
public static class GdkDeviceHandleSignalExtensions
{

	public static IObservable<GdkDeviceHandleSignalStructs.ChangedSignal> Signal_Changed(this GdkDeviceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDeviceHandleSignalStructs.ChangedSignal> obs) =>
		{
			GdkDeviceHandleSignalDelegates.changed handler = ( MentorLake.Gdk.GdkDeviceHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDeviceHandleSignalStructs.ToolChangedSignal> Signal_ToolChanged(this GdkDeviceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDeviceHandleSignalStructs.ToolChangedSignal> obs) =>
		{
			GdkDeviceHandleSignalDelegates.tool_changed handler = ( MentorLake.Gdk.GdkDeviceHandle self,  MentorLake.Gdk.GdkDeviceToolHandle tool,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceHandleSignalStructs.ToolChangedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tool-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkDeviceHandleSignalStructs
{

public class ChangedSignal
{
	public MentorLake.Gdk.GdkDeviceHandle Self;
	public IntPtr UserData;
}

public class ToolChangedSignal
{
	public MentorLake.Gdk.GdkDeviceHandle Self;
	public MentorLake.Gdk.GdkDeviceToolHandle Tool;
	public IntPtr UserData;
}
}

public static class GdkDeviceHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool, IntPtr user_data);

}


public static class GdkDeviceHandleExtensions
{
	public static MentorLake.Gdk.GdkDeviceHandle GetAssociatedDevice(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_associated_device(device);
	}

	public static MentorLake.Gdk.GdkAxisFlags GetAxes(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_axes(device);
	}

	public static bool GetAxis(this MentorLake.Gdk.GdkDeviceHandle device, double[] axes, MentorLake.Gdk.GdkAxisUse use, out double value)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_axis(device, axes, use, out value);
	}

	public static MentorLake.Gdk.GdkAxisUse GetAxisUse(this MentorLake.Gdk.GdkDeviceHandle device, uint index_)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_axis_use(device, index_);
	}

	public static bool GetAxisValue(this MentorLake.Gdk.GdkDeviceHandle device, double[] axes, MentorLake.Gdk.GdkAtom axis_label, out double value)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_axis_value(device, axes, axis_label, out value);
	}

	public static MentorLake.Gdk.GdkDeviceType GetDeviceType(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_device_type(device);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_display(device);
	}

	public static bool GetHasCursor(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_has_cursor(device);
	}

	public static bool GetHistory(this MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkWindowHandle window, uint start, uint stop, out MentorLake.Gdk.GdkTimeCoordHandle[] events, out int n_events)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_history(device, window, start, stop, out events, out n_events);
	}

	public static bool GetKey(this MentorLake.Gdk.GdkDeviceHandle device, uint index_, out uint keyval, out MentorLake.Gdk.GdkModifierType modifiers)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_key(device, index_, out keyval, out modifiers);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetLastEventWindow(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_last_event_window(device);
	}

	public static MentorLake.Gdk.GdkInputMode GetMode(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_mode(device);
	}

	public static int GetNAxes(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_n_axes(device);
	}

	public static int GetNKeys(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_n_keys(device);
	}

	public static string GetName(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_name(device);
	}

	public static T GetPosition<T>(this T device, out MentorLake.Gdk.GdkScreenHandle screen, out int x, out int y) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_get_position(device, out screen, out x, out y);
		return device;
	}

	public static T GetPositionDouble<T>(this T device, out MentorLake.Gdk.GdkScreenHandle screen, out double x, out double y) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_get_position_double(device, out screen, out x, out y);
		return device;
	}

	public static string GetProductId(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_product_id(device);
	}

	public static MentorLake.Gdk.GdkSeatHandle GetSeat(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_seat(device);
	}

	public static MentorLake.Gdk.GdkInputSource GetSource(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_source(device);
	}

	public static T GetState<T>(this T device, MentorLake.Gdk.GdkWindowHandle window, double[] axes, out MentorLake.Gdk.GdkModifierType mask) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_get_state(device, window, axes, out mask);
		return device;
	}

	public static string GetVendorId(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_vendor_id(device);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindowAtPosition(this MentorLake.Gdk.GdkDeviceHandle device, out int win_x, out int win_y)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_window_at_position(device, out win_x, out win_y);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindowAtPositionDouble(this MentorLake.Gdk.GdkDeviceHandle device, out double win_x, out double win_y)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_window_at_position_double(device, out win_x, out win_y);
	}

	public static MentorLake.Gdk.GdkGrabStatus Grab(this MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkGrabOwnership grab_ownership, bool owner_events, MentorLake.Gdk.GdkEventMask event_mask, MentorLake.Gdk.GdkCursorHandle cursor, uint time_)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_grab(device, window, grab_ownership, owner_events, event_mask, cursor, time_);
	}

	public static MentorLake.GLib.GListHandle ListAxes(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_list_axes(device);
	}

	public static MentorLake.GLib.GListHandle ListSlaveDevices(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_list_slave_devices(device);
	}

	public static T SetAxisUse<T>(this T device, uint index_, MentorLake.Gdk.GdkAxisUse use) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_set_axis_use(device, index_, use);
		return device;
	}

	public static T SetKey<T>(this T device, uint index_, uint keyval, MentorLake.Gdk.GdkModifierType modifiers) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_set_key(device, index_, keyval, modifiers);
		return device;
	}

	public static bool SetMode(this MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkInputMode mode)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_set_mode(device, mode);
	}

	public static T Ungrab<T>(this T device, uint time_) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_ungrab(device, time_);
		return device;
	}

	public static T Warp<T>(this T device, MentorLake.Gdk.GdkScreenHandle screen, int x, int y) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_warp(device, screen, x, y);
		return device;
	}

}

internal class GdkDeviceHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_device_get_associated_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAxisFlags gdk_device_get_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_axis([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, double[] axes, MentorLake.Gdk.GdkAxisUse use, out double value);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAxisUse gdk_device_get_axis_use([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint index_);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_axis_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, double[] axes, MentorLake.Gdk.GdkAtom axis_label, out double value);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceType gdk_device_get_device_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_device_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_has_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_history([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, uint start, uint stop, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 5, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkTimeCoordHandle>))] out MentorLake.Gdk.GdkTimeCoordHandle[] events, out int n_events);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint index_, out uint keyval, out MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_device_get_last_event_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkInputMode gdk_device_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_device_get_n_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_device_get_n_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] out MentorLake.Gdk.GdkScreenHandle screen, out int x, out int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_get_position_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] out MentorLake.Gdk.GdkScreenHandle screen, out double x, out double y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_product_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))]
	internal static extern MentorLake.Gdk.GdkSeatHandle gdk_device_get_seat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkInputSource gdk_device_get_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, double[] axes, out MentorLake.Gdk.GdkModifierType mask);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_vendor_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_device_get_window_at_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, out int win_x, out int win_y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_device_get_window_at_position_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, out double win_x, out double win_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGrabStatus gdk_device_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkGrabOwnership grab_ownership, bool owner_events, MentorLake.Gdk.GdkEventMask event_mask, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor, uint time_);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_device_list_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_device_list_slave_devices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_set_axis_use([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint index_, MentorLake.Gdk.GdkAxisUse use);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_set_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint index_, uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkInputMode mode);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_ungrab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_warp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int x, int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_free_history([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkTimeCoordHandle>))] MentorLake.Gdk.GdkTimeCoordHandle[] events, int n_events);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_grab_info_libgtk_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] out MentorLake.Gdk.GdkWindowHandle grab_window, out bool owner_events);

}
