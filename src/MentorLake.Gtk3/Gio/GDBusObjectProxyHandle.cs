namespace MentorLake.Gio;

public class GDBusObjectProxyHandle : GObjectHandle, GDBusObjectHandle
{
	public static MentorLake.Gio.GDBusObjectProxyHandle New(MentorLake.Gio.GDBusConnectionHandle connection, string object_path)
	{
		return GDBusObjectProxyHandleExterns.g_dbus_object_proxy_new(connection, object_path);
	}

}
public static class GDBusObjectProxyHandleSignalExtensions
{

	public static IObservable<GDBusObjectProxyHandleSignalStructs.InterfaceAddedSignal> Signal_InterfaceAdded(this GDBusObjectProxyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectProxyHandleSignalStructs.InterfaceAddedSignal> obs) =>
		{
			GDBusObjectProxyHandleSignalDelegates.interface_added handler = ( MentorLake.Gio.GDBusObjectHandle self,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectProxyHandleSignalStructs.InterfaceAddedSignal()
				{
					Self = self, Interface = @interface, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "interface-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GDBusObjectProxyHandleSignalStructs.InterfaceRemovedSignal> Signal_InterfaceRemoved(this GDBusObjectProxyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectProxyHandleSignalStructs.InterfaceRemovedSignal> obs) =>
		{
			GDBusObjectProxyHandleSignalDelegates.interface_removed handler = ( MentorLake.Gio.GDBusObjectHandle self,  MentorLake.Gio.GDBusInterfaceHandle @interface,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectProxyHandleSignalStructs.InterfaceRemovedSignal()
				{
					Self = self, Interface = @interface, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "interface-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusObjectProxyHandleSignalStructs
{

public class InterfaceAddedSignal
{
	public MentorLake.Gio.GDBusObjectHandle Self;
	public MentorLake.Gio.GDBusInterfaceHandle Interface;
	public IntPtr UserData;
}

public class InterfaceRemovedSignal
{
	public MentorLake.Gio.GDBusObjectHandle Self;
	public MentorLake.Gio.GDBusInterfaceHandle Interface;
	public IntPtr UserData;
}
}

public static class GDBusObjectProxyHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle @interface, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle @interface, IntPtr user_data);

}


public static class GDBusObjectProxyHandleExtensions
{
	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusObjectProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectProxyHandle)");
		return GDBusObjectProxyHandleExterns.g_dbus_object_proxy_get_connection(proxy);
	}

}

internal class GDBusObjectProxyHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectProxyHandle g_dbus_object_proxy_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_object_proxy_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectProxyHandle>))] MentorLake.Gio.GDBusObjectProxyHandle proxy);

}
