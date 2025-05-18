namespace MentorLake.Gio;

public class GSocketConnectionHandle : GIOStreamHandle
{
	public static MentorLake.GObject.GType FactoryLookupType(MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, int protocol_id)
	{
		return GSocketConnectionHandleExterns.g_socket_connection_factory_lookup_type(family, type, protocol_id);
	}

	public static void FactoryRegisterType(MentorLake.GObject.GType g_type, MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, int protocol)
	{
		GSocketConnectionHandleExterns.g_socket_connection_factory_register_type(g_type, family, type, protocol);
	}

}

public static class GSocketConnectionHandleExtensions
{
	public static bool Connect(this MentorLake.Gio.GSocketConnectionHandle connection, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		var externCallResult = GSocketConnectionHandleExterns.g_socket_connection_connect(connection, address, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ConnectAsync<T>(this T connection, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		GSocketConnectionHandleExterns.g_socket_connection_connect_async(connection, address, cancellable, callback, user_data);
		return connection;
	}

	public static bool ConnectFinish(this MentorLake.Gio.GSocketConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		var externCallResult = GSocketConnectionHandleExterns.g_socket_connection_connect_finish(connection, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketAddressHandle GetLocalAddress(this MentorLake.Gio.GSocketConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		var externCallResult = GSocketConnectionHandleExterns.g_socket_connection_get_local_address(connection, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketAddressHandle GetRemoteAddress(this MentorLake.Gio.GSocketConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		var externCallResult = GSocketConnectionHandleExterns.g_socket_connection_get_remote_address(connection, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketHandle GetSocket(this MentorLake.Gio.GSocketConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		return GSocketConnectionHandleExterns.g_socket_connection_get_socket(connection);
	}

	public static bool IsConnected(this MentorLake.Gio.GSocketConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		return GSocketConnectionHandleExterns.g_socket_connection_is_connected(connection);
	}

}

internal class GSocketConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_connection_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_connection_connect_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_connection_connect_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_connection_get_local_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_connection_get_remote_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_connection_get_socket([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_connection_is_connected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_socket_connection_factory_lookup_type(MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, int protocol_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_connection_factory_register_type(MentorLake.GObject.GType g_type, MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, int protocol);

}
