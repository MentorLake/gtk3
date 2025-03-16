namespace MentorLake.GioUnix;

public class GUnixMountMonitorHandle : GObjectHandle
{
	public static MentorLake.GioUnix.GUnixMountMonitorHandle New()
	{
		return GUnixMountMonitorHandleExterns.g_unix_mount_monitor_new();
	}

	public static MentorLake.Gio.GUnixMountMonitorHandle Get()
	{
		return GUnixMountMonitorHandleExterns.g_unix_mount_monitor_get();
	}

	public static void SetRateLimit(MentorLake.Gio.GUnixMountMonitorHandle mount_monitor, int limit_msec)
	{
		GUnixMountMonitorHandleExterns.g_unix_mount_monitor_set_rate_limit(mount_monitor, limit_msec);
	}

}
public static class GUnixMountMonitorHandleSignalExtensions
{

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

public struct MountpointsChangedSignal
{
	public MentorLake.GioUnix.GUnixMountMonitorHandle Self;
	public IntPtr UserData;
}

public struct MountsChangedSignal
{
	public MentorLake.GioUnix.GUnixMountMonitorHandle Self;
	public IntPtr UserData;
}
}

public static class GUnixMountMonitorHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mountpoints_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GioUnix.GUnixMountMonitorHandle>))] MentorLake.GioUnix.GUnixMountMonitorHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mounts_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GioUnix.GUnixMountMonitorHandle>))] MentorLake.GioUnix.GUnixMountMonitorHandle self, IntPtr user_data);

}


public static class GUnixMountMonitorHandleExtensions
{
}

internal class GUnixMountMonitorHandleExterns
{
	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.GioUnix.GUnixMountMonitorHandle g_unix_mount_monitor_new();

	[DllImport(GioUnixLibrary.Name)]
	internal static extern MentorLake.Gio.GUnixMountMonitorHandle g_unix_mount_monitor_get();

	[DllImport(GioUnixLibrary.Name)]
	internal static extern void g_unix_mount_monitor_set_rate_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixMountMonitorHandle>))] MentorLake.Gio.GUnixMountMonitorHandle mount_monitor, int limit_msec);

}
