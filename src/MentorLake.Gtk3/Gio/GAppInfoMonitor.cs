namespace MentorLake.Gtk3.Gio;

public class GAppInfoMonitorHandle : GObjectHandle
{
	public static GAppInfoMonitorHandle Get()
	{
		return GAppInfoMonitorExterns.g_app_info_monitor_get();
	}

}

public static class GAppInfoMonitorSignalExtensions
{

	public static IObservable<GAppInfoMonitorSignalStructs.ChangedSignal> Signal_Changed(this GAppInfoMonitorHandle instance)
	{
		return Observable.Create((IObserver<GAppInfoMonitorSignalStructs.ChangedSignal> obs) =>
		{
			GAppInfoMonitorSignalDelegates.changed handler = (GAppInfoMonitorHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GAppInfoMonitorSignalStructs.ChangedSignal()
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
}

public static class GAppInfoMonitorSignalStructs
{

public struct ChangedSignal
{
	public GAppInfoMonitorHandle Self;
	public IntPtr UserData;
}
}

public static class GAppInfoMonitorSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GAppInfoMonitorHandle>))] GAppInfoMonitorHandle self, IntPtr user_data);

}


public static class GAppInfoMonitorHandleExtensions
{
}

internal class GAppInfoMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GAppInfoMonitorHandle g_app_info_monitor_get();

}
