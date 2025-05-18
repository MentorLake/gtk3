namespace MentorLake.Gio;

public class GThreadedSocketServiceHandle : GSocketServiceHandle
{
	public static MentorLake.Gio.GThreadedSocketServiceHandle New(int max_threads)
	{
		return GThreadedSocketServiceHandleExterns.g_threaded_socket_service_new(max_threads);
	}

}
public static class GThreadedSocketServiceHandleSignalExtensions
{

	public static IObservable<GThreadedSocketServiceHandleSignalStructs.RunSignal> Signal_Run(this GThreadedSocketServiceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GThreadedSocketServiceHandleSignalStructs.RunSignal> obs) =>
		{
			GThreadedSocketServiceHandleSignalDelegates.run handler = ( MentorLake.Gio.GThreadedSocketServiceHandle self,  MentorLake.Gio.GSocketConnectionHandle connection,  MentorLake.GObject.GObjectHandle source_object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GThreadedSocketServiceHandleSignalStructs.RunSignal()
				{
					Self = self, Connection = connection, SourceObject = source_object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "run", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GThreadedSocketServiceHandleSignalStructs
{

public class RunSignal
{
	public MentorLake.Gio.GThreadedSocketServiceHandle Self;
	public MentorLake.Gio.GSocketConnectionHandle Connection;
	public MentorLake.GObject.GObjectHandle SourceObject;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GThreadedSocketServiceHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GThreadedSocketServiceHandle>))] MentorLake.Gio.GThreadedSocketServiceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, IntPtr user_data);

}


public static class GThreadedSocketServiceHandleExtensions
{
}

internal class GThreadedSocketServiceHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GThreadedSocketServiceHandle>))]
	internal static extern MentorLake.Gio.GThreadedSocketServiceHandle g_threaded_socket_service_new(int max_threads);

}
