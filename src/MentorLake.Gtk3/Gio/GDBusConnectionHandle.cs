namespace MentorLake.Gio;

public class GDBusConnectionHandle : GObjectHandle, GAsyncInitableHandle, GInitableHandle
{
	public static MentorLake.Gio.GDBusConnectionHandle NewFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_new_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusConnectionHandle NewForAddressFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_new_for_address_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusConnectionHandle NewForAddressSync(string address, MentorLake.Gio.GDBusConnectionFlags flags, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_new_for_address_sync(address, flags, observer, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusConnectionHandle NewSync(MentorLake.Gio.GIOStreamHandle stream, string guid, MentorLake.Gio.GDBusConnectionFlags flags, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_new_sync(stream, guid, flags, observer, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void New(MentorLake.Gio.GIOStreamHandle stream, string guid, MentorLake.Gio.GDBusConnectionFlags flags, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionHandleExterns.g_dbus_connection_new(stream, guid, flags, observer, cancellable, callback, user_data);
	}

	public static void NewForAddress(string address, MentorLake.Gio.GDBusConnectionFlags flags, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionHandleExterns.g_dbus_connection_new_for_address(address, flags, observer, cancellable, callback, user_data);
	}

}
public static class GDBusConnectionHandleSignalExtensions
{

	public static IObservable<GDBusConnectionHandleSignalStructs.ClosedSignal> Signal_Closed(this GDBusConnectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusConnectionHandleSignalStructs.ClosedSignal> obs) =>
		{
			GDBusConnectionHandleSignalDelegates.closed handler = ( MentorLake.Gio.GDBusConnectionHandle self,  bool remote_peer_vanished,  MentorLake.GLib.GErrorHandle error,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusConnectionHandleSignalStructs.ClosedSignal()
				{
					Self = self, RemotePeerVanished = remote_peer_vanished, Error = error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusConnectionHandleSignalStructs
{

public struct ClosedSignal
{
	public MentorLake.Gio.GDBusConnectionHandle Self;
	public bool RemotePeerVanished;
	public MentorLake.GLib.GErrorHandle Error;
	public IntPtr UserData;
}
}

public static class GDBusConnectionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle self, bool remote_peer_vanished, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);

}


public static class GDBusConnectionHandleExtensions
{
	public static uint AddFilter(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusMessageFilterFunction filter_function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_add_filter(connection, filter_function, user_data, user_data_free_func);
	}

	public static T Call<T>(this T connection, string bus_name, string object_path, string interface_name, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_call(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, cancellable, callback, user_data);
		return connection;
	}

	public static MentorLake.GLib.GVariantHandle CallFinish(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_call_finish(connection, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GVariantHandle CallSync(this MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_call_sync(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T CallWithUnixFdList<T>(this T connection, string bus_name, string object_path, string interface_name, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GUnixFDListHandle fd_list, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_call_with_unix_fd_list(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, fd_list, cancellable, callback, user_data);
		return connection;
	}

	public static MentorLake.GLib.GVariantHandle CallWithUnixFdListFinish(this MentorLake.Gio.GDBusConnectionHandle connection, out MentorLake.Gio.GUnixFDListHandle out_fd_list, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_call_with_unix_fd_list_finish(connection, out out_fd_list, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GVariantHandle CallWithUnixFdListSync(this MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GUnixFDListHandle fd_list, out MentorLake.Gio.GUnixFDListHandle out_fd_list, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_call_with_unix_fd_list_sync(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, fd_list, out out_fd_list, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Close<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_close(connection, cancellable, callback, user_data);
		return connection;
	}

	public static bool CloseFinish(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_close_finish(connection, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool CloseSync(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_close_sync(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool EmitSignal(this MentorLake.Gio.GDBusConnectionHandle connection, string destination_bus_name, string object_path, string interface_name, string signal_name, MentorLake.GLib.GVariantHandle parameters)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_emit_signal(connection, destination_bus_name, object_path, interface_name, signal_name, parameters, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint ExportActionGroup(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GActionGroupHandle action_group)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_export_action_group(connection, object_path, action_group, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint ExportMenuModel(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GMenuModelHandle menu)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_export_menu_model(connection, object_path, menu, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Flush<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_flush(connection, cancellable, callback, user_data);
		return connection;
	}

	public static bool FlushFinish(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_flush_finish(connection, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool FlushSync(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_flush_sync(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusCapabilityFlags GetCapabilities(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_capabilities(connection);
	}

	public static bool GetExitOnClose(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_exit_on_close(connection);
	}

	public static MentorLake.Gio.GDBusConnectionFlags GetFlags(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_flags(connection);
	}

	public static string GetGuid(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_guid(connection);
	}

	public static uint GetLastSerial(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_last_serial(connection);
	}

	public static MentorLake.Gio.GCredentialsHandle GetPeerCredentials(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_peer_credentials(connection);
	}

	public static MentorLake.Gio.GIOStreamHandle GetStream(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_stream(connection);
	}

	public static string GetUniqueName(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_unique_name(connection);
	}

	public static bool IsClosed(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_is_closed(connection);
	}

	public static uint RegisterObject(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GDBusInterfaceInfoHandle interface_info, MentorLake.Gio.GDBusInterfaceVTableHandle vtable, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_register_object(connection, object_path, interface_info, vtable, user_data, user_data_free_func, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint RegisterObjectWithClosures(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GDBusInterfaceInfoHandle interface_info, MentorLake.GObject.GClosureHandle method_call_closure, MentorLake.GObject.GClosureHandle get_property_closure, MentorLake.GObject.GClosureHandle set_property_closure)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_register_object_with_closures(connection, object_path, interface_info, method_call_closure, get_property_closure, set_property_closure, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint RegisterSubtree(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GDBusSubtreeVTableHandle vtable, MentorLake.Gio.GDBusSubtreeFlags flags, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_register_subtree(connection, object_path, vtable, flags, user_data, user_data_free_func, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T RemoveFilter<T>(this T connection, uint filter_id) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_remove_filter(connection, filter_id);
		return connection;
	}

	public static bool SendMessage(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, out uint out_serial)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_send_message(connection, message, flags, out out_serial, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SendMessageWithReply<T>(this T connection, MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_send_message_with_reply(connection, message, flags, timeout_msec, out out_serial, cancellable, callback, user_data);
		return connection;
	}

	public static MentorLake.Gio.GDBusMessageHandle SendMessageWithReplyFinish(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_send_message_with_reply_finish(connection, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GDBusMessageHandle SendMessageWithReplySync(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_send_message_with_reply_sync(connection, message, flags, timeout_msec, out out_serial, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetExitOnClose<T>(this T connection, bool exit_on_close) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_set_exit_on_close(connection, exit_on_close);
		return connection;
	}

	public static uint SignalSubscribe(this MentorLake.Gio.GDBusConnectionHandle connection, string sender, string interface_name, string member, string object_path, string arg0, MentorLake.Gio.GDBusSignalFlags flags, MentorLake.Gio.GDBusSignalCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_signal_subscribe(connection, sender, interface_name, member, object_path, arg0, flags, callback, user_data, user_data_free_func);
	}

	public static T SignalUnsubscribe<T>(this T connection, uint subscription_id) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_signal_unsubscribe(connection, subscription_id);
		return connection;
	}

	public static T StartMessageProcessing<T>(this T connection) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_start_message_processing(connection);
		return connection;
	}

	public static T UnexportActionGroup<T>(this T connection, uint export_id) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_unexport_action_group(connection, export_id);
		return connection;
	}

	public static T UnexportMenuModel<T>(this T connection, uint export_id) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_unexport_menu_model(connection, export_id);
		return connection;
	}

	public static bool UnregisterObject(this MentorLake.Gio.GDBusConnectionHandle connection, uint registration_id)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_unregister_object(connection, registration_id);
	}

	public static bool UnregisterSubtree(this MentorLake.Gio.GDBusConnectionHandle connection, uint registration_id)
	{
		if (connection.IsInvalid || connection.IsClosed) throw new Exception("Invalid or closed handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_unregister_subtree(connection, registration_id);
	}

}

internal class GDBusConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_connection_new_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_connection_new_for_address_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_connection_new_for_address_sync(string address, MentorLake.Gio.GDBusConnectionFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_connection_new_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, string guid, MentorLake.Gio.GDBusConnectionFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_add_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusMessageFilterFunction filter_function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_call([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_connection_call_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_connection_call_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_call_with_unix_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_connection_call_with_unix_fd_list_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] out MentorLake.Gio.GUnixFDListHandle out_fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_connection_call_with_unix_fd_list_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] out MentorLake.Gio.GUnixFDListHandle out_fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_close_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_emit_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string destination_bus_name, string object_path, string interface_name, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_export_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_export_menu_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle menu, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_flush_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_flush_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusCapabilityFlags g_dbus_connection_get_capabilities([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_get_exit_on_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionFlags g_dbus_connection_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_connection_get_guid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_get_last_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GCredentialsHandle g_dbus_connection_get_peer_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOStreamHandle g_dbus_connection_get_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_connection_get_unique_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_register_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle interface_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceVTableHandle>))] MentorLake.Gio.GDBusInterfaceVTableHandle vtable, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_register_object_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle interface_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle method_call_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle get_property_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle set_property_closure, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_register_subtree([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusSubtreeVTableHandle>))] MentorLake.Gio.GDBusSubtreeVTableHandle vtable, MentorLake.Gio.GDBusSubtreeFlags flags, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_remove_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint filter_id);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_send_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, out uint out_serial, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_send_message_with_reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_connection_send_message_with_reply_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_connection_send_message_with_reply_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_set_exit_on_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, bool exit_on_close);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_signal_subscribe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string sender, string interface_name, string member, string object_path, string arg0, MentorLake.Gio.GDBusSignalFlags flags, MentorLake.Gio.GDBusSignalCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_signal_unsubscribe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint subscription_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_start_message_processing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_unexport_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint export_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_unexport_menu_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint export_id);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_unregister_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint registration_id);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_unregister_subtree([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint registration_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, string guid, MentorLake.Gio.GDBusConnectionFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_new_for_address(string address, MentorLake.Gio.GDBusConnectionFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
