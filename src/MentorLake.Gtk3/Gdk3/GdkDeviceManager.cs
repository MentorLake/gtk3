namespace MentorLake.Gtk3.Gdk3;

public class GdkDeviceManagerHandle : GObjectHandle
{
}

public static class GdkDeviceManagerSignalExtensions
{

	public static IObservable<GdkDeviceManagerSignalStructs.DeviceAddedSignal> Signal_DeviceAdded(this GdkDeviceManagerHandle instance)
	{
		return Observable.Create((IObserver<GdkDeviceManagerSignalStructs.DeviceAddedSignal> obs) =>
		{
			GdkDeviceManagerSignalDelegates.device_added handler = (GdkDeviceManagerHandle self, GdkDeviceHandle device, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceManagerSignalStructs.DeviceAddedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "device_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDeviceManagerSignalStructs.DeviceChangedSignal> Signal_DeviceChanged(this GdkDeviceManagerHandle instance)
	{
		return Observable.Create((IObserver<GdkDeviceManagerSignalStructs.DeviceChangedSignal> obs) =>
		{
			GdkDeviceManagerSignalDelegates.device_changed handler = (GdkDeviceManagerHandle self, GdkDeviceHandle device, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceManagerSignalStructs.DeviceChangedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "device_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDeviceManagerSignalStructs.DeviceRemovedSignal> Signal_DeviceRemoved(this GdkDeviceManagerHandle instance)
	{
		return Observable.Create((IObserver<GdkDeviceManagerSignalStructs.DeviceRemovedSignal> obs) =>
		{
			GdkDeviceManagerSignalDelegates.device_removed handler = (GdkDeviceManagerHandle self, GdkDeviceHandle device, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceManagerSignalStructs.DeviceRemovedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "device_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkDeviceManagerSignalStructs
{

public struct DeviceAddedSignal
{
	public GdkDeviceManagerHandle Self;
	public GdkDeviceHandle Device;
	public IntPtr UserData;
}

public struct DeviceChangedSignal
{
	public GdkDeviceManagerHandle Self;
	public GdkDeviceHandle Device;
	public IntPtr UserData;
}

public struct DeviceRemovedSignal
{
	public GdkDeviceManagerHandle Self;
	public GdkDeviceHandle Device;
	public IntPtr UserData;
}
}

public static class GdkDeviceManagerSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceManagerHandle>))] GdkDeviceManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle device, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceManagerHandle>))] GdkDeviceManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle device, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceManagerHandle>))] GdkDeviceManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDeviceHandle>))] GdkDeviceHandle device, IntPtr user_data);

}


public static class GdkDeviceManagerHandleExtensions
{
	public static GdkDeviceHandle GetClientPointer(this GdkDeviceManagerHandle device_manager)
	{
		return GdkDeviceManagerExterns.gdk_device_manager_get_client_pointer(device_manager);
	}

	public static GdkDisplayHandle GetDisplay(this GdkDeviceManagerHandle device_manager)
	{
		return GdkDeviceManagerExterns.gdk_device_manager_get_display(device_manager);
	}

	public static GListHandle ListDevices(this GdkDeviceManagerHandle device_manager, GdkDeviceType type)
	{
		return GdkDeviceManagerExterns.gdk_device_manager_list_devices(device_manager, type);
	}

}

internal class GdkDeviceManagerExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceHandle gdk_device_manager_get_client_pointer(GdkDeviceManagerHandle device_manager);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_device_manager_get_display(GdkDeviceManagerHandle device_manager);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_device_manager_list_devices(GdkDeviceManagerHandle device_manager, GdkDeviceType type);

}
