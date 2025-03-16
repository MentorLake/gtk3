namespace MentorLake.Gio;

public class GDBusAuthObserverHandle : GObjectHandle
{
	public static MentorLake.Gio.GDBusAuthObserverHandle New()
	{
		return GDBusAuthObserverHandleExterns.g_dbus_auth_observer_new();
	}

}
public static class GDBusAuthObserverHandleSignalExtensions
{

	public static IObservable<GDBusAuthObserverHandleSignalStructs.AllowMechanismSignal> Signal_AllowMechanism(this GDBusAuthObserverHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusAuthObserverHandleSignalStructs.AllowMechanismSignal> obs) =>
		{
			GDBusAuthObserverHandleSignalDelegates.allow_mechanism handler = ( MentorLake.Gio.GDBusAuthObserverHandle self,  string mechanism,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusAuthObserverHandleSignalStructs.AllowMechanismSignal()
				{
					Self = self, Mechanism = mechanism, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "allow-mechanism", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GDBusAuthObserverHandleSignalStructs.AuthorizeAuthenticatedPeerSignal> Signal_AuthorizeAuthenticatedPeer(this GDBusAuthObserverHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusAuthObserverHandleSignalStructs.AuthorizeAuthenticatedPeerSignal> obs) =>
		{
			GDBusAuthObserverHandleSignalDelegates.authorize_authenticated_peer handler = ( MentorLake.Gio.GDBusAuthObserverHandle self,  MentorLake.Gio.GIOStreamHandle stream,  MentorLake.Gio.GCredentialsHandle credentials,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusAuthObserverHandleSignalStructs.AuthorizeAuthenticatedPeerSignal()
				{
					Self = self, Stream = stream, Credentials = credentials, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "authorize-authenticated-peer", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusAuthObserverHandleSignalStructs
{

public struct AllowMechanismSignal
{
	public MentorLake.Gio.GDBusAuthObserverHandle Self;
	public string Mechanism;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct AuthorizeAuthenticatedPeerSignal
{
	public MentorLake.Gio.GDBusAuthObserverHandle Self;
	public MentorLake.Gio.GIOStreamHandle Stream;
	public MentorLake.Gio.GCredentialsHandle Credentials;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDBusAuthObserverHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool allow_mechanism([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle self, string mechanism, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authorize_authenticated_peer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials, IntPtr user_data);

}


public static class GDBusAuthObserverHandleExtensions
{
	public static bool AllowMechanism(this MentorLake.Gio.GDBusAuthObserverHandle observer, string mechanism)
	{
		return GDBusAuthObserverHandleExterns.g_dbus_auth_observer_allow_mechanism(observer, mechanism);
	}

	public static bool AuthorizeAuthenticatedPeer(this MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GCredentialsHandle credentials)
	{
		return GDBusAuthObserverHandleExterns.g_dbus_auth_observer_authorize_authenticated_peer(observer, stream, credentials);
	}

}

internal class GDBusAuthObserverHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusAuthObserverHandle g_dbus_auth_observer_new();

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_auth_observer_allow_mechanism([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, string mechanism);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_auth_observer_authorize_authenticated_peer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))] MentorLake.Gio.GCredentialsHandle credentials);

}
