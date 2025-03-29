namespace MentorLake.Gio;

public class GUnixConnectionHandle : GSocketConnectionHandle
{
}

public static class GUnixConnectionHandleExtensions
{
	public static MentorLake.Gio.GCredentialsHandle ReceiveCredentials(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GUnixConnectionHandleExterns.g_unix_connection_receive_credentials(connection, cancellable, error);
	}

	public static T ReceiveCredentialsAsync<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GUnixConnectionHandle
	{
		GUnixConnectionHandleExterns.g_unix_connection_receive_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

	public static MentorLake.Gio.GCredentialsHandle ReceiveCredentialsFinish(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GUnixConnectionHandleExterns.g_unix_connection_receive_credentials_finish(connection, result, error);
	}

	public static int ReceiveFd(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GUnixConnectionHandleExterns.g_unix_connection_receive_fd(connection, cancellable, error);
	}

	public static bool SendCredentials(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GUnixConnectionHandleExterns.g_unix_connection_send_credentials(connection, cancellable, error);
	}

	public static T SendCredentialsAsync<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GUnixConnectionHandle
	{
		GUnixConnectionHandleExterns.g_unix_connection_send_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

	public static bool SendCredentialsFinish(this MentorLake.Gio.GUnixConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GUnixConnectionHandleExterns.g_unix_connection_send_credentials_finish(connection, result, error);
	}

	public static bool SendFd(this MentorLake.Gio.GUnixConnectionHandle connection, int fd, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GUnixConnectionHandleExterns.g_unix_connection_send_fd(connection, fd, cancellable, error);
	}

}

internal class GUnixConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GCredentialsHandle g_unix_connection_receive_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_connection_receive_credentials_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GCredentialsHandle g_unix_connection_receive_credentials_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_unix_connection_receive_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_unix_connection_send_credentials_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_credentials_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_unix_connection_send_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixConnectionHandle>))] MentorLake.Gio.GUnixConnectionHandle connection, int fd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

}
