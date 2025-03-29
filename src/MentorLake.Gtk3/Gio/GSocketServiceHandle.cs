namespace MentorLake.Gio;

public class GSocketServiceHandle : GSocketListenerHandle
{
	public static MentorLake.Gio.GSocketServiceHandle New()
	{
		return GSocketServiceHandleExterns.g_socket_service_new();
	}

}
public static class GSocketServiceHandleSignalExtensions
{

	public static IObservable<GSocketServiceHandleSignalStructs.IncomingSignal> Signal_Incoming(this GSocketServiceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSocketServiceHandleSignalStructs.IncomingSignal> obs) =>
		{
			GSocketServiceHandleSignalDelegates.incoming handler = ( MentorLake.Gio.GSocketServiceHandle self,  MentorLake.Gio.GSocketConnectionHandle connection,  MentorLake.GObject.GObjectHandle source_object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSocketServiceHandleSignalStructs.IncomingSignal()
				{
					Self = self, Connection = connection, SourceObject = source_object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "incoming", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GSocketServiceHandleSignalStructs
{

public struct IncomingSignal
{
	public MentorLake.Gio.GSocketServiceHandle Self;
	public MentorLake.Gio.GSocketConnectionHandle Connection;
	public MentorLake.GObject.GObjectHandle SourceObject;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GSocketServiceHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool incoming([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))] MentorLake.Gio.GSocketServiceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, IntPtr user_data);

}


public static class GSocketServiceHandleExtensions
{
	public static bool IsActive(this MentorLake.Gio.GSocketServiceHandle service)
	{
		if (service.IsInvalid || service.IsClosed) throw new Exception("Invalid or closed handle (GSocketServiceHandle)");
		return GSocketServiceHandleExterns.g_socket_service_is_active(service);
	}

	public static T Start<T>(this T service) where T : GSocketServiceHandle
	{
		if (service.IsInvalid || service.IsClosed) throw new Exception("Invalid or closed handle (GSocketServiceHandle)");
		GSocketServiceHandleExterns.g_socket_service_start(service);
		return service;
	}

	public static T Stop<T>(this T service) where T : GSocketServiceHandle
	{
		if (service.IsInvalid || service.IsClosed) throw new Exception("Invalid or closed handle (GSocketServiceHandle)");
		GSocketServiceHandleExterns.g_socket_service_stop(service);
		return service;
	}

}

internal class GSocketServiceHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketServiceHandle g_socket_service_new();

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_service_is_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))] MentorLake.Gio.GSocketServiceHandle service);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_service_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))] MentorLake.Gio.GSocketServiceHandle service);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_service_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))] MentorLake.Gio.GSocketServiceHandle service);

}
