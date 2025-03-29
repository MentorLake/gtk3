namespace MentorLake.Gio;

public class GDBusProxyHandle : GObjectHandle, GAsyncInitableHandle, GDBusInterfaceHandle, GInitableHandle
{
	public static MentorLake.Gio.GDBusProxyHandle NewFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_new_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusProxyHandle NewForBusFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_new_for_bus_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusProxyHandle NewForBusSync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusProxyFlags flags, MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_new_for_bus_sync(bus_type, flags, info, name, object_path, interface_name, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusProxyHandle NewSync(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusProxyFlags flags, MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_new_sync(connection, flags, info, name, object_path, interface_name, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void New(MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusProxyFlags flags, MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusProxyHandleExterns.g_dbus_proxy_new(connection, flags, info, name, object_path, interface_name, cancellable, callback, user_data);
	}

	public static void NewForBus(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusProxyFlags flags, MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusProxyHandleExterns.g_dbus_proxy_new_for_bus(bus_type, flags, info, name, object_path, interface_name, cancellable, callback, user_data);
	}

}
public static class GDBusProxyHandleSignalExtensions
{

	public static IObservable<GDBusProxyHandleSignalStructs.GPropertiesChangedSignal> Signal_GPropertiesChanged(this GDBusProxyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusProxyHandleSignalStructs.GPropertiesChangedSignal> obs) =>
		{
			GDBusProxyHandleSignalDelegates.g_properties_changed handler = ( MentorLake.Gio.GDBusProxyHandle self,  MentorLake.GLib.GVariantHandle changed_properties,  string[] invalidated_properties,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusProxyHandleSignalStructs.GPropertiesChangedSignal()
				{
					Self = self, ChangedProperties = changed_properties, InvalidatedProperties = invalidated_properties, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "g-properties-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GDBusProxyHandleSignalStructs.GSignalSignal> Signal_GSignal(this GDBusProxyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusProxyHandleSignalStructs.GSignalSignal> obs) =>
		{
			GDBusProxyHandleSignalDelegates.g_signal handler = ( MentorLake.Gio.GDBusProxyHandle self,  string sender_name,  string signal_name,  MentorLake.GLib.GVariantHandle parameters,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusProxyHandleSignalStructs.GSignalSignal()
				{
					Self = self, SenderName = sender_name, SignalName = signal_name, Parameters = parameters, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "g-signal", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusProxyHandleSignalStructs
{

public struct GPropertiesChangedSignal
{
	public MentorLake.Gio.GDBusProxyHandle Self;
	public MentorLake.GLib.GVariantHandle ChangedProperties;
	public string[] InvalidatedProperties;
	public IntPtr UserData;
}

public struct GSignalSignal
{
	public MentorLake.Gio.GDBusProxyHandle Self;
	public string SenderName;
	public string SignalName;
	public MentorLake.GLib.GVariantHandle Parameters;
	public IntPtr UserData;
}
}

public static class GDBusProxyHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void g_properties_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle changed_properties, string[] invalidated_properties, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void g_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle self, string sender_name, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, IntPtr user_data);

}


public static class GDBusProxyHandleExtensions
{
	public static T Call<T>(this T proxy, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_call(proxy, method_name, parameters, flags, timeout_msec, cancellable, callback, user_data);
		return proxy;
	}

	public static MentorLake.GLib.GVariantHandle CallFinish(this MentorLake.Gio.GDBusProxyHandle proxy, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_call_finish(proxy, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GVariantHandle CallSync(this MentorLake.Gio.GDBusProxyHandle proxy, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_call_sync(proxy, method_name, parameters, flags, timeout_msec, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T CallWithUnixFdList<T>(this T proxy, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GUnixFDListHandle fd_list, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_call_with_unix_fd_list(proxy, method_name, parameters, flags, timeout_msec, fd_list, cancellable, callback, user_data);
		return proxy;
	}

	public static MentorLake.GLib.GVariantHandle CallWithUnixFdListFinish(this MentorLake.Gio.GDBusProxyHandle proxy, out MentorLake.Gio.GUnixFDListHandle out_fd_list, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_call_with_unix_fd_list_finish(proxy, out out_fd_list, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GVariantHandle CallWithUnixFdListSync(this MentorLake.Gio.GDBusProxyHandle proxy, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GUnixFDListHandle fd_list, out MentorLake.Gio.GUnixFDListHandle out_fd_list, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		var externCallResult = GDBusProxyHandleExterns.g_dbus_proxy_call_with_unix_fd_list_sync(proxy, method_name, parameters, flags, timeout_msec, fd_list, out out_fd_list, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GVariantHandle GetCachedProperty(this MentorLake.Gio.GDBusProxyHandle proxy, string property_name)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_cached_property(proxy, property_name);
	}

	public static string[] GetCachedPropertyNames(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_cached_property_names(proxy);
	}

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_connection(proxy);
	}

	public static int GetDefaultTimeout(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_default_timeout(proxy);
	}

	public static MentorLake.Gio.GDBusProxyFlags GetFlags(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_flags(proxy);
	}

	public static MentorLake.Gio.GDBusInterfaceInfoHandle GetInterfaceInfo(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_interface_info(proxy);
	}

	public static string GetInterfaceName(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_interface_name(proxy);
	}

	public static string GetName(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_name(proxy);
	}

	public static string GetNameOwner(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_name_owner(proxy);
	}

	public static string GetObjectPath(this MentorLake.Gio.GDBusProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		return GDBusProxyHandleExterns.g_dbus_proxy_get_object_path(proxy);
	}

	public static T SetCachedProperty<T>(this T proxy, string property_name, MentorLake.GLib.GVariantHandle value) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_set_cached_property(proxy, property_name, value);
		return proxy;
	}

	public static T SetDefaultTimeout<T>(this T proxy, int timeout_msec) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_set_default_timeout(proxy, timeout_msec);
		return proxy;
	}

	public static T SetInterfaceInfo<T>(this T proxy, MentorLake.Gio.GDBusInterfaceInfoHandle info) where T : GDBusProxyHandle
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusProxyHandle)");
		GDBusProxyHandleExterns.g_dbus_proxy_set_interface_info(proxy, info);
		return proxy;
	}

}

internal class GDBusProxyHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusProxyHandle g_dbus_proxy_new_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusProxyHandle g_dbus_proxy_new_for_bus_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusProxyHandle g_dbus_proxy_new_for_bus_sync(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusProxyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusProxyHandle g_dbus_proxy_new_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusProxyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_call([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_call_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_call_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_call_with_unix_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_call_with_unix_fd_list_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] out MentorLake.Gio.GUnixFDListHandle out_fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_call_with_unix_fd_list_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] out MentorLake.Gio.GUnixFDListHandle out_fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_proxy_get_cached_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string property_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_dbus_proxy_get_cached_property_names([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_proxy_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_dbus_proxy_get_default_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusProxyFlags g_dbus_proxy_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_proxy_get_interface_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_proxy_get_interface_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_proxy_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_proxy_get_name_owner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_proxy_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_set_cached_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_set_default_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, int timeout_msec);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_set_interface_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusProxyHandle>))] MentorLake.Gio.GDBusProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusProxyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_proxy_new_for_bus(MentorLake.Gio.GBusType bus_type, MentorLake.Gio.GDBusProxyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
