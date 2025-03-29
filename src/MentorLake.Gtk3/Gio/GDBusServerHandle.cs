namespace MentorLake.Gio;

public class GDBusServerHandle : GObjectHandle, GInitableHandle
{
	public static MentorLake.Gio.GDBusServerHandle NewSync(string address, MentorLake.Gio.GDBusServerFlags flags, string guid, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GDBusServerHandleExterns.g_dbus_server_new_sync(address, flags, guid, observer, cancellable, error);
	}

}
public static class GDBusServerHandleSignalExtensions
{

	public static IObservable<GDBusServerHandleSignalStructs.NewConnectionSignal> Signal_NewConnection(this GDBusServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusServerHandleSignalStructs.NewConnectionSignal> obs) =>
		{
			GDBusServerHandleSignalDelegates.new_connection handler = ( MentorLake.Gio.GDBusServerHandle self,  MentorLake.Gio.GDBusConnectionHandle connection,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusServerHandleSignalStructs.NewConnectionSignal()
				{
					Self = self, Connection = connection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "new-connection", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusServerHandleSignalStructs
{

public struct NewConnectionSignal
{
	public MentorLake.Gio.GDBusServerHandle Self;
	public MentorLake.Gio.GDBusConnectionHandle Connection;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDBusServerHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool new_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, IntPtr user_data);

}


public static class GDBusServerHandleExtensions
{
	public static string GetClientAddress(this MentorLake.Gio.GDBusServerHandle server)
	{
		return GDBusServerHandleExterns.g_dbus_server_get_client_address(server);
	}

	public static MentorLake.Gio.GDBusServerFlags GetFlags(this MentorLake.Gio.GDBusServerHandle server)
	{
		return GDBusServerHandleExterns.g_dbus_server_get_flags(server);
	}

	public static string GetGuid(this MentorLake.Gio.GDBusServerHandle server)
	{
		return GDBusServerHandleExterns.g_dbus_server_get_guid(server);
	}

	public static bool IsActive(this MentorLake.Gio.GDBusServerHandle server)
	{
		return GDBusServerHandleExterns.g_dbus_server_is_active(server);
	}

	public static T Start<T>(this T server) where T : GDBusServerHandle
	{
		GDBusServerHandleExterns.g_dbus_server_start(server);
		return server;
	}

	public static T Stop<T>(this T server) where T : GDBusServerHandle
	{
		GDBusServerHandleExterns.g_dbus_server_stop(server);
		return server;
	}

}

internal class GDBusServerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusServerHandle g_dbus_server_new_sync(string address, MentorLake.Gio.GDBusServerFlags flags, string guid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_server_get_client_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusServerFlags g_dbus_server_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_server_get_guid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_server_is_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_server_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_server_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

}
