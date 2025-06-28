namespace MentorLake.Gio;

public class GVolumeMonitorHandle : GObjectHandle
{
	public static MentorLake.Gio.GVolumeHandle AdoptOrphanMount(MentorLake.Gio.GMountHandle mount)
	{
		return GVolumeMonitorHandleExterns.g_volume_monitor_adopt_orphan_mount(mount);
	}

	public static MentorLake.Gio.GVolumeMonitorHandle Get()
	{
		return GVolumeMonitorHandleExterns.g_volume_monitor_get();
	}

}
public static class GVolumeMonitorHandleSignalExtensions
{

	public static IObservable<GVolumeMonitorHandleSignalStructs.DriveChangedSignal> Signal_DriveChanged(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.DriveChangedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.drive_changed handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GDriveHandle drive,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.DriveChangedSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drive-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.DriveConnectedSignal> Signal_DriveConnected(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.DriveConnectedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.drive_connected handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GDriveHandle drive,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.DriveConnectedSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drive-connected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.DriveDisconnectedSignal> Signal_DriveDisconnected(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.DriveDisconnectedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.drive_disconnected handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GDriveHandle drive,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.DriveDisconnectedSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drive-disconnected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.DriveEjectButtonSignal> Signal_DriveEjectButton(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.DriveEjectButtonSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.drive_eject_button handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GDriveHandle drive,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.DriveEjectButtonSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drive-eject-button", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.DriveStopButtonSignal> Signal_DriveStopButton(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.DriveStopButtonSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.drive_stop_button handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GDriveHandle drive,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.DriveStopButtonSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drive-stop-button", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.MountAddedSignal> Signal_MountAdded(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.MountAddedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.mount_added handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GMountHandle mount,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.MountAddedSignal()
				{
					Self = self, Mount = mount, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mount-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.MountChangedSignal> Signal_MountChanged(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.MountChangedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.mount_changed handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GMountHandle mount,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.MountChangedSignal()
				{
					Self = self, Mount = mount, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mount-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.MountPreUnmountSignal> Signal_MountPreUnmount(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.MountPreUnmountSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.mount_pre_unmount handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GMountHandle mount,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.MountPreUnmountSignal()
				{
					Self = self, Mount = mount, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mount-pre-unmount", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.MountRemovedSignal> Signal_MountRemoved(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.MountRemovedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.mount_removed handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GMountHandle mount,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.MountRemovedSignal()
				{
					Self = self, Mount = mount, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mount-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.VolumeAddedSignal> Signal_VolumeAdded(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.VolumeAddedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.volume_added handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GVolumeHandle volume,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.VolumeAddedSignal()
				{
					Self = self, Volume = volume, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "volume-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.VolumeChangedSignal> Signal_VolumeChanged(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.VolumeChangedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.volume_changed handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GVolumeHandle volume,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.VolumeChangedSignal()
				{
					Self = self, Volume = volume, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "volume-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GVolumeMonitorHandleSignalStructs.VolumeRemovedSignal> Signal_VolumeRemoved(this GVolumeMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GVolumeMonitorHandleSignalStructs.VolumeRemovedSignal> obs) =>
		{
			GVolumeMonitorHandleSignalDelegates.volume_removed handler = ( MentorLake.Gio.GVolumeMonitorHandle self,  MentorLake.Gio.GVolumeHandle volume,  IntPtr user_data) =>
			{
				

				var signalStruct = new GVolumeMonitorHandleSignalStructs.VolumeRemovedSignal()
				{
					Self = self, Volume = volume, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "volume-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GVolumeMonitorHandleSignalStructs
{

public class DriveChangedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GDriveHandle Drive;
	public IntPtr UserData;
}

public class DriveConnectedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GDriveHandle Drive;
	public IntPtr UserData;
}

public class DriveDisconnectedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GDriveHandle Drive;
	public IntPtr UserData;
}

public class DriveEjectButtonSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GDriveHandle Drive;
	public IntPtr UserData;
}

public class DriveStopButtonSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GDriveHandle Drive;
	public IntPtr UserData;
}

public class MountAddedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GMountHandle Mount;
	public IntPtr UserData;
}

public class MountChangedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GMountHandle Mount;
	public IntPtr UserData;
}

public class MountPreUnmountSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GMountHandle Mount;
	public IntPtr UserData;
}

public class MountRemovedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GMountHandle Mount;
	public IntPtr UserData;
}

public class VolumeAddedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GVolumeHandle Volume;
	public IntPtr UserData;
}

public class VolumeChangedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GVolumeHandle Volume;
	public IntPtr UserData;
}

public class VolumeRemovedSignal
{
	public MentorLake.Gio.GVolumeMonitorHandle Self;
	public MentorLake.Gio.GVolumeHandle Volume;
	public IntPtr UserData;
}
}

public static class GVolumeMonitorHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_connected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_disconnected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_eject_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_stop_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount_pre_unmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void volume_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void volume_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void volume_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, IntPtr user_data);

}


public static class GVolumeMonitorHandleExtensions
{
	public static MentorLake.GLib.GListHandle GetConnectedDrives(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_connected_drives(volume_monitor);
	}

	public static MentorLake.Gio.GMountHandle GetMountForUuid(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor, string uuid)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_mount_for_uuid(volume_monitor, uuid);
	}

	public static MentorLake.GLib.GListHandle GetMounts(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_mounts(volume_monitor);
	}

	public static MentorLake.Gio.GVolumeHandle GetVolumeForUuid(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor, string uuid)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_volume_for_uuid(volume_monitor, uuid);
	}

	public static MentorLake.GLib.GListHandle GetVolumes(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_volumes(volume_monitor);
	}

}

internal class GVolumeMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_volume_monitor_get_connected_drives([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle volume_monitor);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))]
	internal static extern MentorLake.Gio.GMountHandle g_volume_monitor_get_mount_for_uuid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle volume_monitor, string uuid);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_volume_monitor_get_mounts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle volume_monitor);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))]
	internal static extern MentorLake.Gio.GVolumeHandle g_volume_monitor_get_volume_for_uuid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle volume_monitor, string uuid);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_volume_monitor_get_volumes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle volume_monitor);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))]
	internal static extern MentorLake.Gio.GVolumeHandle g_volume_monitor_adopt_orphan_mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))]
	internal static extern MentorLake.Gio.GVolumeMonitorHandle g_volume_monitor_get();

}
