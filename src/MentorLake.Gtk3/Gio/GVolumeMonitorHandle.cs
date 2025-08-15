namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GVolumeMonitor` is for listing the user interesting devices and volumes
/// on the computer. In other words, what a file selector or file manager
/// would show in a sidebar.
/// </para>
/// <para>
/// `GVolumeMonitor` is not
/// thread-default-context aware (see
/// [method@GLib.MainContext.push_thread_default]), and so should not be used
/// other than from the main thread, with no thread-default-context active.
/// </para>
/// <para>
/// In order to receive updates about volumes and mounts monitored through GVFS,
/// a main loop must be running.
/// </para>
/// </summary>

public class GVolumeMonitorHandle : GObjectHandle
{
/// <summary>
/// <para>
/// This function should be called by any #GVolumeMonitor
/// implementation when a new #GMount object is created that is not
/// associated with a #GVolume object. It must be called just before
/// emitting the @mount_added signal.
/// </para>
/// <para>
/// If the return value is not %NULL, the caller must associate the
/// returned #GVolume object with the #GMount. This involves returning
/// it in its g_mount_get_volume() implementation. The caller must
/// also listen for the &quot;removed&quot; signal on the returned object
/// and give up its reference when handling that signal
/// </para>
/// <para>
/// Similarly, if implementing g_volume_monitor_adopt_orphan_mount(),
/// the implementor must take a reference to @mount and return it in
/// its g_volume_get_mount() implemented. Also, the implementor must
/// listen for the &quot;unmounted&quot; signal on @mount and give up its
/// reference upon handling that signal.
/// </para>
/// <para>
/// There are two main use cases for this function.
/// </para>
/// <para>
/// One is when implementing a user space file system driver that reads
/// blocks of a block device that is already represented by the native
/// volume monitor (for example a CD Audio file system driver). Such
/// a driver will generate its own #GMount object that needs to be
/// associated with the #GVolume object that represents the volume.
/// </para>
/// <para>
/// The other is for implementing a #GVolumeMonitor whose sole purpose
/// is to return #GVolume objects representing entries in the users
/// &quot;favorite servers&quot; list or similar.
/// </para>
/// </summary>

/// <param name="mount">
/// a #GMount object to find a parent for
/// </param>
/// <return>
/// the #GVolume object that is the parent for @mount or %NULL
/// if no wants to adopt the #GMount.
/// </return>

	public static MentorLake.Gio.GVolumeHandle AdoptOrphanMount(MentorLake.Gio.GMountHandle mount)
	{
		return GVolumeMonitorHandleExterns.g_volume_monitor_adopt_orphan_mount(mount);
	}

/// <summary>
/// <para>
/// Gets the volume monitor used by gio.
/// </para>
/// </summary>

/// <return>
/// a reference to the #GVolumeMonitor used by gio. Call
///    g_object_unref() when done with it.
/// </return>

	public static MentorLake.Gio.GVolumeMonitorHandle Get()
	{
		return GVolumeMonitorHandleExterns.g_volume_monitor_get();
	}

}
public static class GVolumeMonitorHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a drive changes.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a drive is connected to the system.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a drive is disconnected from the system.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the eject button is pressed on @drive.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the stop button is pressed on @drive.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a mount is added.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a mount changes.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// May be emitted when a mount is about to be removed.
/// </para>
/// <para>
/// This signal depends on the backend and is only emitted if
/// GIO was used to unmount.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a mount is removed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a mountable volume is added to the system.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when mountable volume is changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a mountable volume is removed from the system.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the drive that changed
/// </para>
/// </summary>

	public MentorLake.Gio.GDriveHandle Drive;

	public IntPtr UserData;
}

public class DriveConnectedSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GDrive that was connected.
/// </para>
/// </summary>

	public MentorLake.Gio.GDriveHandle Drive;

	public IntPtr UserData;
}

public class DriveDisconnectedSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GDrive that was disconnected.
/// </para>
/// </summary>

	public MentorLake.Gio.GDriveHandle Drive;

	public IntPtr UserData;
}

public class DriveEjectButtonSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// the drive where the eject button was pressed
/// </para>
/// </summary>

	public MentorLake.Gio.GDriveHandle Drive;

	public IntPtr UserData;
}

public class DriveStopButtonSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// the drive where the stop button was pressed
/// </para>
/// </summary>

	public MentorLake.Gio.GDriveHandle Drive;

	public IntPtr UserData;
}

public class MountAddedSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GMount that was added.
/// </para>
/// </summary>

	public MentorLake.Gio.GMountHandle Mount;

	public IntPtr UserData;
}

public class MountChangedSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GMount that changed.
/// </para>
/// </summary>

	public MentorLake.Gio.GMountHandle Mount;

	public IntPtr UserData;
}

public class MountPreUnmountSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GMount that is being unmounted.
/// </para>
/// </summary>

	public MentorLake.Gio.GMountHandle Mount;

	public IntPtr UserData;
}

public class MountRemovedSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GMount that was removed.
/// </para>
/// </summary>

	public MentorLake.Gio.GMountHandle Mount;

	public IntPtr UserData;
}

public class VolumeAddedSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GVolume that was added.
/// </para>
/// </summary>

	public MentorLake.Gio.GVolumeHandle Volume;

	public IntPtr UserData;
}

public class VolumeChangedSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GVolume that changed.
/// </para>
/// </summary>

	public MentorLake.Gio.GVolumeHandle Volume;

	public IntPtr UserData;
}

public class VolumeRemovedSignal
{

	public MentorLake.Gio.GVolumeMonitorHandle Self;
/// <summary>
/// <para>
/// a #GVolume that was removed.
/// </para>
/// </summary>

	public MentorLake.Gio.GVolumeHandle Volume;

	public IntPtr UserData;
}
}

public static class GVolumeMonitorHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a drive changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="drive">
/// the drive that changed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a drive is connected to the system.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="drive">
/// a #GDrive that was connected.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_connected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a drive is disconnected from the system.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="drive">
/// a #GDrive that was disconnected.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_disconnected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the eject button is pressed on @drive.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="drive">
/// the drive where the eject button was pressed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_eject_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the stop button is pressed on @drive.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="drive">
/// the drive where the stop button was pressed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drive_stop_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDriveHandleImpl>))] MentorLake.Gio.GDriveHandle drive, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a mount is added.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="mount">
/// a #GMount that was added.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a mount changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="mount">
/// a #GMount that changed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, IntPtr user_data);


/// <summary>
/// <para>
/// May be emitted when a mount is about to be removed.
/// </para>
/// <para>
/// This signal depends on the backend and is only emitted if
/// GIO was used to unmount.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="mount">
/// a #GMount that is being unmounted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount_pre_unmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a mount is removed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="mount">
/// a #GMount that was removed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountHandleImpl>))] MentorLake.Gio.GMountHandle mount, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a mountable volume is added to the system.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="volume">
/// a #GVolume that was added.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void volume_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when mountable volume is changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="volume">
/// a #GVolume that changed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void volume_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a mountable volume is removed from the system.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="volume">
/// a #GVolume that was removed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void volume_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeMonitorHandle>))] MentorLake.Gio.GVolumeMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle volume, IntPtr user_data);

}


public static class GVolumeMonitorHandleExtensions
{
/// <summary>
/// <para>
/// Gets a list of drives connected to the system.
/// </para>
/// <para>
/// The returned list should be freed with g_list_free(), after
/// its elements have been unreffed with g_object_unref().
/// </para>
/// </summary>

/// <param name="volume_monitor">
/// a #GVolumeMonitor.
/// </param>
/// <return>
/// a #GList of connected #GDrive objects.
/// </return>

	public static MentorLake.GLib.GListHandle GetConnectedDrives(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_connected_drives(volume_monitor);
	}

/// <summary>
/// <para>
/// Finds a #GMount object by its UUID (see g_mount_get_uuid())
/// </para>
/// </summary>

/// <param name="volume_monitor">
/// a #GVolumeMonitor.
/// </param>
/// <param name="uuid">
/// the UUID to look for
/// </param>
/// <return>
/// a #GMount or %NULL if no such mount is available.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GMountHandle GetMountForUuid(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor, string uuid)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_mount_for_uuid(volume_monitor, uuid);
	}

/// <summary>
/// <para>
/// Gets a list of the mounts on the system.
/// </para>
/// <para>
/// The returned list should be freed with g_list_free(), after
/// its elements have been unreffed with g_object_unref().
/// </para>
/// </summary>

/// <param name="volume_monitor">
/// a #GVolumeMonitor.
/// </param>
/// <return>
/// a #GList of #GMount objects.
/// </return>

	public static MentorLake.GLib.GListHandle GetMounts(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_mounts(volume_monitor);
	}

/// <summary>
/// <para>
/// Finds a #GVolume object by its UUID (see g_volume_get_uuid())
/// </para>
/// </summary>

/// <param name="volume_monitor">
/// a #GVolumeMonitor.
/// </param>
/// <param name="uuid">
/// the UUID to look for
/// </param>
/// <return>
/// a #GVolume or %NULL if no such volume is available.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GVolumeHandle GetVolumeForUuid(this MentorLake.Gio.GVolumeMonitorHandle volume_monitor, string uuid)
	{
		if (volume_monitor.IsInvalid) throw new Exception("Invalid handle (GVolumeMonitorHandle)");
		return GVolumeMonitorHandleExterns.g_volume_monitor_get_volume_for_uuid(volume_monitor, uuid);
	}

/// <summary>
/// <para>
/// Gets a list of the volumes on the system.
/// </para>
/// <para>
/// The returned list should be freed with g_list_free(), after
/// its elements have been unreffed with g_object_unref().
/// </para>
/// </summary>

/// <param name="volume_monitor">
/// a #GVolumeMonitor.
/// </param>
/// <return>
/// a #GList of #GVolume objects.
/// </return>

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
