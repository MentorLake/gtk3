namespace MentorLake.GioUnix;

/// <summary>
/// <para>
/// Watches for changes to the set of mount entries and mount points in the
/// system.
/// </para>
/// <para>
/// Connect to the [signal@GioUnix.MountMonitor::mounts-changed] signal to be
/// notified of changes to the [struct@GioUnix.MountEntry] list.
/// </para>
/// <para>
/// Connect to the [signal@GioUnix.MountMonitor::mountpoints-changed] signal to
/// be notified of changes to the [struct@GioUnix.MountPoint] list.
/// </para>
/// </summary>

public class GUnixMountMonitorHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Deprecated alias for [func@GioUnix.MountMonitor.get].
/// </para>
/// <para>
/// This function was never a true constructor, which is why it was
/// renamed.
/// </para>
/// </summary>

/// <return>
/// a [class@GioUnix.MountMonitor]
/// </return>

	public static MentorLake.GioUnix.GUnixMountMonitorHandle New()
	{
		return GUnixMountMonitorHandleExterns.g_unix_mount_monitor_new();
	}

/// <summary>
/// <para>
/// Gets the [class@GioUnix.MountMonitor] for the current thread-default main
/// context.
/// </para>
/// <para>
/// The mount monitor can be used to monitor for changes to the list of
/// mounted filesystems as well as the list of mount points (ie: fstab
/// entries).
/// </para>
/// <para>
/// You must only call [method@GObject.Object.unref] on the return value from
/// under the same main context as you called this function.
/// </para>
/// </summary>

/// <return>
/// the [class@GioUnix.MountMonitor]
/// </return>

	public static MentorLake.Gio.GUnixMountMonitorHandle Get()
	{
		return GUnixMountMonitorHandleExterns.g_unix_mount_monitor_get();
	}

/// <summary>
/// <para>
/// This function does nothing.
/// </para>
/// <para>
/// Before 2.44, this was a partially-effective way of controlling the
/// rate at which events would be reported under some uncommon
/// circumstances.  Since @mount_monitor is a singleton, it also meant
/// that calling this function would have side effects for other users of
/// the monitor.
/// </para>
/// </summary>

/// <param name="mount_monitor">
/// a [class@GioUnix.MountMonitor]
/// </param>
/// <param name="limit_msec">
/// a integer with the limit (in milliseconds) to poll for changes
/// </param>

	public static void SetRateLimit(MentorLake.Gio.GUnixMountMonitorHandle mount_monitor, int limit_msec)
	{
		GUnixMountMonitorHandleExterns.g_unix_mount_monitor_set_rate_limit(mount_monitor, limit_msec);
	}

}
public static class GUnixMountMonitorHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the Unix mount points have changed.
/// </para>
/// </summary>

	public static IObservable<GUnixMountMonitorHandleSignalStructs.MountpointsChangedSignal> Signal_MountpointsChanged(this GUnixMountMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GUnixMountMonitorHandleSignalStructs.MountpointsChangedSignal> obs) =>
		{
			GUnixMountMonitorHandleSignalDelegates.mountpoints_changed handler = ( MentorLake.GioUnix.GUnixMountMonitorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GUnixMountMonitorHandleSignalStructs.MountpointsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mountpoints-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the Unix mount entries have changed.
/// </para>
/// </summary>

	public static IObservable<GUnixMountMonitorHandleSignalStructs.MountsChangedSignal> Signal_MountsChanged(this GUnixMountMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GUnixMountMonitorHandleSignalStructs.MountsChangedSignal> obs) =>
		{
			GUnixMountMonitorHandleSignalDelegates.mounts_changed handler = ( MentorLake.GioUnix.GUnixMountMonitorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GUnixMountMonitorHandleSignalStructs.MountsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mounts-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GUnixMountMonitorHandleSignalStructs
{

public class MountpointsChangedSignal
{

	public MentorLake.GioUnix.GUnixMountMonitorHandle Self;

	public IntPtr UserData;
}

public class MountsChangedSignal
{

	public MentorLake.GioUnix.GUnixMountMonitorHandle Self;

	public IntPtr UserData;
}
}

public static class GUnixMountMonitorHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the Unix mount points have changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mountpoints_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GioUnix.GUnixMountMonitorHandle>))] MentorLake.GioUnix.GUnixMountMonitorHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the Unix mount entries have changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mounts_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GioUnix.GUnixMountMonitorHandle>))] MentorLake.GioUnix.GUnixMountMonitorHandle self, IntPtr user_data);

}


public static class GUnixMountMonitorHandleExtensions
{
}

internal class GUnixMountMonitorHandleExterns
{
	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GioUnix.GUnixMountMonitorHandle>))]
	internal static extern MentorLake.GioUnix.GUnixMountMonitorHandle g_unix_mount_monitor_new();

	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GUnixMountMonitorHandle>))]
	internal static extern MentorLake.Gio.GUnixMountMonitorHandle g_unix_mount_monitor_get();

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_unix_mount_monitor_set_rate_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountMonitorHandle>))] MentorLake.Gio.GUnixMountMonitorHandle mount_monitor, int limit_msec);

}
