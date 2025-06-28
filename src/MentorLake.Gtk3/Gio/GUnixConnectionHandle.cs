namespace MentorLake.Gio;

public class GUnixConnectionHandle : GSocketConnectionHandle
{
}

public static class GUnixConnectionHandleExtensions
{
	public static MentorLake.Gio.GCredentialsHandle ReceiveCredentials(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_receive_credentials(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ReceiveCredentialsAsync<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GUnixConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		GUnixConnectionHandleExterns.g_unix_connection_receive_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

	public static MentorLake.Gio.GCredentialsHandle ReceiveCredentialsFinish(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_receive_credentials_finish(connection, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int ReceiveFd(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_receive_fd(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SendCredentials(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_send_credentials(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SendCredentialsAsync<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GUnixConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		GUnixConnectionHandleExterns.g_unix_connection_send_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

	public static bool SendCredentialsFinish(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_send_credentials_finish(connection, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SendFd(this MentorLake.Gio.GUnixConnectionHandle connection, int fd, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GUnixConnectionHandle)");
		var externCallResult = GUnixConnectionHandleExterns.g_unix_connection_send_fd(connection, fd, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GUnixConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_unix_connection_receive_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_connection_receive_credentials_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_unix_connection_receive_credentials_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_connection_receive_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_connection_send_credentials_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_credentials_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, int fd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
