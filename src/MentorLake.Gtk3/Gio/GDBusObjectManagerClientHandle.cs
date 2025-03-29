namespace MentorLake.Gio;

public class GDBusObjectManagerClientHandle : GObjectHandle, GAsyncInitableHandle, GDBusObjectManagerHandle, GInitableHandle
{
	public static MentorLake.Gio.GDBusObjectManagerClientHandle NewFinish(MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_finish(res, error);
	}

	public static MentorLake.Gio.GDBusObjectManagerClientHandle NewForBusFinish(MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_for_bus_finish(res, error);
	}

	public static MentorLake.Gio.GDBusObjectManagerClientHandle NewForBusSync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_for_bus_sync(bus_type, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, error);
	}

	public static MentorLake.Gio.GDBusObjectManagerClientHandle NewSync(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_sync(connection, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, error);
	}

	public static void New(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new(connection, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, callback, user_data);
	}

	public static void NewForBus(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_new_for_bus(bus_type, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, callback, user_data);
	}

}
public static class GDBusObjectManagerClientHandleSignalExtensions
{

	public static IObservable<GDBusObjectManagerClientHandleSignalStructs.InterfaceProxyPropertiesChangedSignal> Signal_InterfaceProxyPropertiesChanged(this GDBusObjectManagerClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerClientHandleSignalStructs.InterfaceProxyPropertiesChangedSignal> obs) =>
		{
			GDBusObjectManagerClientHandleSignalDelegates.interface_proxy_properties_changed handler = ( MentorLake.Gio.GDBusObjectManagerClientHandle self,  MentorLake.Gio.GDBusObjectProxyHandle object_proxy,  MentorLake.Gio.GDBusProxyHandle interface_proxy,  MentorLake.GLib.GVariantHandle changed_properties,  string[] invalidated_properties,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerClientHandleSignalStructs.InterfaceProxyPropertiesChangedSignal()
				{
					Self = self, ObjectProxy = object_proxy, InterfaceProxy = interface_proxy, ChangedProperties = changed_properties, InvalidatedProperties = invalidated_properties, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "interface-proxy-properties-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GDBusObjectManagerClientHandleSignalStructs.InterfaceProxySignalSignal> Signal_InterfaceProxySignal(this GDBusObjectManagerClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusObjectManagerClientHandleSignalStructs.InterfaceProxySignalSignal> obs) =>
		{
			GDBusObjectManagerClientHandleSignalDelegates.interface_proxy_signal handler = ( MentorLake.Gio.GDBusObjectManagerClientHandle self,  MentorLake.Gio.GDBusObjectProxyHandle object_proxy,  MentorLake.Gio.GDBusProxyHandle interface_proxy,  string sender_name,  string signal_name,  MentorLake.GLib.GVariantHandle parameters,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusObjectManagerClientHandleSignalStructs.InterfaceProxySignalSignal()
				{
					Self = self, ObjectProxy = object_proxy, InterfaceProxy = interface_proxy, SenderName = sender_name, SignalName = signal_name, Parameters = parameters, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "interface-proxy-signal", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusObjectManagerClientHandleSignalStructs
{

public struct InterfaceProxyPropertiesChangedSignal
{
	public MentorLake.Gio.GDBusObjectManagerClientHandle Self;
	public MentorLake.Gio.GDBusObjectProxyHandle ObjectProxy;
	public MentorLake.Gio.GDBusProxyHandle InterfaceProxy;
	public MentorLake.GLib.GVariantHandle ChangedProperties;
	public string[] InvalidatedProperties;
	public IntPtr UserData;
}

public struct InterfaceProxySignalSignal
{
	public MentorLake.Gio.GDBusObjectManagerClientHandle Self;
	public MentorLake.Gio.GDBusObjectProxyHandle ObjectProxy;
	public MentorLake.Gio.GDBusProxyHandle InterfaceProxy;
	public string SenderName;
	public string SignalName;
	public MentorLake.GLib.GVariantHandle Parameters;
	public IntPtr UserData;
}
}

public static class GDBusObjectManagerClientHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_proxy_properties_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectProxyHandle>))] MentorLake.Gio.GDBusObjectProxyHandle object_proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle interface_proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle changed_properties, string[] invalidated_properties, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void interface_proxy_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectProxyHandle>))] MentorLake.Gio.GDBusObjectProxyHandle object_proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle interface_proxy, string sender_name, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, IntPtr user_data);

}


public static class GDBusObjectManagerClientHandleExtensions
{
	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusObjectManagerClientHandle manager)
	{
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_get_connection(manager);
	}

	public static MentorLake.Gio.GDBusObjectManagerClientFlags GetFlags(this MentorLake.Gio.GDBusObjectManagerClientHandle manager)
	{
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_get_flags(manager);
	}

	public static string GetName(this MentorLake.Gio.GDBusObjectManagerClientHandle manager)
	{
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_get_name(manager);
	}

	public static string GetNameOwner(this MentorLake.Gio.GDBusObjectManagerClientHandle manager)
	{
		return GDBusObjectManagerClientHandleExterns.g_dbus_object_manager_client_get_name_owner(manager);
	}

}

internal class GDBusObjectManagerClientHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_for_bus_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_for_bus_sync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_object_manager_client_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectManagerClientFlags g_dbus_object_manager_client_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_object_manager_client_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_object_manager_client_get_name_owner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerClientHandle>))] MentorLake.Gio.GDBusObjectManagerClientHandle manager);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_client_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_client_new_for_bus(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusObjectManagerClientFlags flags, string name, string object_path, MentorLake.Gio.GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, MentorLake.GLib.GDestroyNotify get_proxy_type_destroy_notify, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
