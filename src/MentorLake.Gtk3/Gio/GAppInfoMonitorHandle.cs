namespace MentorLake.Gio;

public class GAppInfoMonitorHandle : GObjectHandle
{
	public static MentorLake.Gio.GAppInfoMonitorHandle Get()
	{
		return GAppInfoMonitorHandleExterns.g_app_info_monitor_get();
	}

}
public static class GAppInfoMonitorHandleSignalExtensions
{

	public static IObservable<GAppInfoMonitorHandleSignalStructs.ChangedSignal> Signal_Changed(this GAppInfoMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GAppInfoMonitorHandleSignalStructs.ChangedSignal> obs) =>
		{
			GAppInfoMonitorHandleSignalDelegates.changed handler = ( MentorLake.Gio.GAppInfoMonitorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GAppInfoMonitorHandleSignalStructs.ChangedSignal()
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
}

public static class GAppInfoMonitorHandleSignalStructs
{

public class ChangedSignal
{
	public MentorLake.Gio.GAppInfoMonitorHandle Self;
	public IntPtr UserData;
}
}

public static class GAppInfoMonitorHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoMonitorHandle>))] MentorLake.Gio.GAppInfoMonitorHandle self, IntPtr user_data);

}


public static class GAppInfoMonitorHandleExtensions
{
}

internal class GAppInfoMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoMonitorHandle g_app_info_monitor_get();

}
