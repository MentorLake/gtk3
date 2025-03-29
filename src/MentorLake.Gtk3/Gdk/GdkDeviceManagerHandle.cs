namespace MentorLake.Gdk;

public class GdkDeviceManagerHandle : GObjectHandle
{
}
public static class GdkDeviceManagerHandleSignalExtensions
{

	public static IObservable<GdkDeviceManagerHandleSignalStructs.DeviceAddedSignal> Signal_DeviceAdded(this GdkDeviceManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDeviceManagerHandleSignalStructs.DeviceAddedSignal> obs) =>
		{
			GdkDeviceManagerHandleSignalDelegates.device_added handler = ( MentorLake.Gdk.GdkDeviceManagerHandle self,  MentorLake.Gdk.GdkDeviceHandle device,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceManagerHandleSignalStructs.DeviceAddedSignal()
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

	public static IObservable<GdkDeviceManagerHandleSignalStructs.DeviceChangedSignal> Signal_DeviceChanged(this GdkDeviceManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDeviceManagerHandleSignalStructs.DeviceChangedSignal> obs) =>
		{
			GdkDeviceManagerHandleSignalDelegates.device_changed handler = ( MentorLake.Gdk.GdkDeviceManagerHandle self,  MentorLake.Gdk.GdkDeviceHandle device,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceManagerHandleSignalStructs.DeviceChangedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "device-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDeviceManagerHandleSignalStructs.DeviceRemovedSignal> Signal_DeviceRemoved(this GdkDeviceManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDeviceManagerHandleSignalStructs.DeviceRemovedSignal> obs) =>
		{
			GdkDeviceManagerHandleSignalDelegates.device_removed handler = ( MentorLake.Gdk.GdkDeviceManagerHandle self,  MentorLake.Gdk.GdkDeviceHandle device,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceManagerHandleSignalStructs.DeviceRemovedSignal()
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
}

public static class GdkDeviceManagerHandleSignalStructs
{

public struct DeviceAddedSignal
{
	public MentorLake.Gdk.GdkDeviceManagerHandle Self;
	public MentorLake.Gdk.GdkDeviceHandle Device;
	public IntPtr UserData;
}

public struct DeviceChangedSignal
{
	public MentorLake.Gdk.GdkDeviceManagerHandle Self;
	public MentorLake.Gdk.GdkDeviceHandle Device;
	public IntPtr UserData;
}

public struct DeviceRemovedSignal
{
	public MentorLake.Gdk.GdkDeviceManagerHandle Self;
	public MentorLake.Gdk.GdkDeviceHandle Device;
	public IntPtr UserData;
}
}

public static class GdkDeviceManagerHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceManagerHandle>))] MentorLake.Gdk.GdkDeviceManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceManagerHandle>))] MentorLake.Gdk.GdkDeviceManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceManagerHandle>))] MentorLake.Gdk.GdkDeviceManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, IntPtr user_data);

}


public static class GdkDeviceManagerHandleExtensions
{
	public static MentorLake.Gdk.GdkDeviceHandle GetClientPointer(this MentorLake.Gdk.GdkDeviceManagerHandle device_manager)
	{
		if (device_manager.IsInvalid || device_manager.IsClosed) throw new Exception("Invalid or closed handle (GdkDeviceManagerHandle)");
		return GdkDeviceManagerHandleExterns.gdk_device_manager_get_client_pointer(device_manager);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkDeviceManagerHandle device_manager)
	{
		if (device_manager.IsInvalid || device_manager.IsClosed) throw new Exception("Invalid or closed handle (GdkDeviceManagerHandle)");
		return GdkDeviceManagerHandleExterns.gdk_device_manager_get_display(device_manager);
	}

	public static MentorLake.GLib.GListHandle ListDevices(this MentorLake.Gdk.GdkDeviceManagerHandle device_manager, MentorLake.Gdk.GdkDeviceType type)
	{
		if (device_manager.IsInvalid || device_manager.IsClosed) throw new Exception("Invalid or closed handle (GdkDeviceManagerHandle)");
		return GdkDeviceManagerHandleExterns.gdk_device_manager_list_devices(device_manager, type);
	}

}

internal class GdkDeviceManagerHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_device_manager_get_client_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceManagerHandle>))] MentorLake.Gdk.GdkDeviceManagerHandle device_manager);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_device_manager_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceManagerHandle>))] MentorLake.Gdk.GdkDeviceManagerHandle device_manager);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gdk_device_manager_list_devices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceManagerHandle>))] MentorLake.Gdk.GdkDeviceManagerHandle device_manager, MentorLake.Gdk.GdkDeviceType type);

}
