namespace MentorLake.Gtk3.Gio;

public class GThreadedSocketServiceHandle : GSocketServiceHandle
{
	public static GThreadedSocketServiceHandle New(int max_threads)
	{
		return GThreadedSocketServiceExterns.g_threaded_socket_service_new(max_threads);
	}

}

public static class GThreadedSocketServiceSignalExtensions
{

	public static IObservable<GThreadedSocketServiceSignalStructs.RunSignal> Signal_Run(this GThreadedSocketServiceHandle instance)
	{
		return Observable.Create((IObserver<GThreadedSocketServiceSignalStructs.RunSignal> obs) =>
		{
			GThreadedSocketServiceSignalDelegates.run handler = (GThreadedSocketServiceHandle self, GSocketConnectionHandle connection, GObjectHandle source_object, IntPtr user_data) =>
			{
				

				var signalStruct = new GThreadedSocketServiceSignalStructs.RunSignal()
				{
					Self = self, Connection = connection, SourceObject = source_object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "run", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GThreadedSocketServiceSignalStructs
{

public struct RunSignal
{
	public GThreadedSocketServiceHandle Self;
	public GSocketConnectionHandle Connection;
	public GObjectHandle SourceObject;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GThreadedSocketServiceSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GThreadedSocketServiceHandle>))] GThreadedSocketServiceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketConnectionHandle>))] GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle source_object, IntPtr user_data);

}


public static class GThreadedSocketServiceHandleExtensions
{
}

internal class GThreadedSocketServiceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GThreadedSocketServiceHandle g_threaded_socket_service_new(int max_threads);

}
