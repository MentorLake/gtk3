namespace MentorLake.Gdk;

public class GdkSeatHandle : GObjectHandle
{
}
public static class GdkSeatHandleSignalExtensions
{

	public static IObservable<GdkSeatHandleSignalStructs.DeviceAddedSignal> Signal_DeviceAdded(this GdkSeatHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkSeatHandleSignalStructs.DeviceAddedSignal> obs) =>
		{
			GdkSeatHandleSignalDelegates.device_added handler = ( MentorLake.Gdk.GdkSeatHandle self,  MentorLake.Gdk.GdkDeviceHandle device,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatHandleSignalStructs.DeviceAddedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "device-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkSeatHandleSignalStructs.DeviceRemovedSignal> Signal_DeviceRemoved(this GdkSeatHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkSeatHandleSignalStructs.DeviceRemovedSignal> obs) =>
		{
			GdkSeatHandleSignalDelegates.device_removed handler = ( MentorLake.Gdk.GdkSeatHandle self,  MentorLake.Gdk.GdkDeviceHandle device,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatHandleSignalStructs.DeviceRemovedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "device-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkSeatHandleSignalStructs.ToolAddedSignal> Signal_ToolAdded(this GdkSeatHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkSeatHandleSignalStructs.ToolAddedSignal> obs) =>
		{
			GdkSeatHandleSignalDelegates.tool_added handler = ( MentorLake.Gdk.GdkSeatHandle self,  MentorLake.Gdk.GdkDeviceToolHandle tool,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatHandleSignalStructs.ToolAddedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tool-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkSeatHandleSignalStructs.ToolRemovedSignal> Signal_ToolRemoved(this GdkSeatHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkSeatHandleSignalStructs.ToolRemovedSignal> obs) =>
		{
			GdkSeatHandleSignalDelegates.tool_removed handler = ( MentorLake.Gdk.GdkSeatHandle self,  MentorLake.Gdk.GdkDeviceToolHandle tool,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatHandleSignalStructs.ToolRemovedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tool-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkSeatHandleSignalStructs
{

public class DeviceAddedSignal
{
	public MentorLake.Gdk.GdkSeatHandle Self;
	public MentorLake.Gdk.GdkDeviceHandle Device;
	public IntPtr UserData;
}

public class DeviceRemovedSignal
{
	public MentorLake.Gdk.GdkSeatHandle Self;
	public MentorLake.Gdk.GdkDeviceHandle Device;
	public IntPtr UserData;
}

public class ToolAddedSignal
{
	public MentorLake.Gdk.GdkSeatHandle Self;
	public MentorLake.Gdk.GdkDeviceToolHandle Tool;
	public IntPtr UserData;
}

public class ToolRemovedSignal
{
	public MentorLake.Gdk.GdkSeatHandle Self;
	public MentorLake.Gdk.GdkDeviceToolHandle Tool;
	public IntPtr UserData;
}
}

public static class GdkSeatHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool, IntPtr user_data);

}


public static class GdkSeatHandleExtensions
{
	public static MentorLake.Gdk.GdkSeatCapabilities GetCapabilities(this MentorLake.Gdk.GdkSeatHandle seat)
	{
		if (seat.IsInvalid || seat.IsClosed) throw new Exception("Invalid or closed handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_capabilities(seat);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkSeatHandle seat)
	{
		if (seat.IsInvalid || seat.IsClosed) throw new Exception("Invalid or closed handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_display(seat);
	}

	public static MentorLake.Gdk.GdkDeviceHandle GetKeyboard(this MentorLake.Gdk.GdkSeatHandle seat)
	{
		if (seat.IsInvalid || seat.IsClosed) throw new Exception("Invalid or closed handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_keyboard(seat);
	}

	public static MentorLake.Gdk.GdkDeviceHandle GetPointer(this MentorLake.Gdk.GdkSeatHandle seat)
	{
		if (seat.IsInvalid || seat.IsClosed) throw new Exception("Invalid or closed handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_pointer(seat);
	}

	public static MentorLake.GLib.GListHandle GetSlaves(this MentorLake.Gdk.GdkSeatHandle seat, MentorLake.Gdk.GdkSeatCapabilities capabilities)
	{
		if (seat.IsInvalid || seat.IsClosed) throw new Exception("Invalid or closed handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_slaves(seat, capabilities);
	}

	public static MentorLake.Gdk.GdkGrabStatus Grab(this MentorLake.Gdk.GdkSeatHandle seat, MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkSeatCapabilities capabilities, bool owner_events, MentorLake.Gdk.GdkCursorHandle cursor, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkSeatGrabPrepareFunc prepare_func, IntPtr prepare_func_data)
	{
		if (seat.IsInvalid || seat.IsClosed) throw new Exception("Invalid or closed handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_grab(seat, window, capabilities, owner_events, cursor, @event, prepare_func, prepare_func_data);
	}

	public static T Ungrab<T>(this T seat) where T : GdkSeatHandle
	{
		if (seat.IsInvalid || seat.IsClosed) throw new Exception("Invalid or closed handle (GdkSeatHandle)");
		GdkSeatHandleExterns.gdk_seat_ungrab(seat);
		return seat;
	}

}

internal class GdkSeatHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkSeatCapabilities gdk_seat_get_capabilities([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_seat_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_seat_get_keyboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_seat_get_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gdk_seat_get_slaves([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, MentorLake.Gdk.GdkSeatCapabilities capabilities);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGrabStatus gdk_seat_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkSeatCapabilities capabilities, bool owner_events, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkSeatGrabPrepareFunc prepare_func, IntPtr prepare_func_data);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_seat_ungrab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

}
