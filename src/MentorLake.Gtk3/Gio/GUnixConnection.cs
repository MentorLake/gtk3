namespace MentorLake.Gtk3.Gio;

public class GUnixConnectionHandle : GSocketConnectionHandle
{
}

public static class GUnixConnectionHandleExtensions
{
	public static GCredentialsHandle ReceiveCredentials(this GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_receive_credentials(connection, cancellable, out error);
	}

	public static T ReceiveCredentialsAsync<T>(this T connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GUnixConnectionHandle
	{
		GUnixConnectionExterns.g_unix_connection_receive_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

	public static GCredentialsHandle ReceiveCredentialsFinish(this GUnixConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_receive_credentials_finish(connection, result, out error);
	}

	public static int ReceiveFd(this GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_receive_fd(connection, cancellable, out error);
	}

	public static bool SendCredentials(this GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_send_credentials(connection, cancellable, out error);
	}

	public static T SendCredentialsAsync<T>(this T connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GUnixConnectionHandle
	{
		GUnixConnectionExterns.g_unix_connection_send_credentials_async(connection, cancellable, callback, user_data);
		return connection;
	}

	public static bool SendCredentialsFinish(this GUnixConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_send_credentials_finish(connection, result, out error);
	}

	public static bool SendFd(this GUnixConnectionHandle connection, int fd, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GUnixConnectionExterns.g_unix_connection_send_fd(connection, fd, cancellable, out error);
	}

}

internal class GUnixConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_unix_connection_receive_credentials(GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_connection_receive_credentials_async(GUnixConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_unix_connection_receive_credentials_finish(GUnixConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_connection_receive_fd(GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_connection_send_credentials(GUnixConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_connection_send_credentials_async(GUnixConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_connection_send_credentials_finish(GUnixConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_unix_connection_send_fd(GUnixConnectionHandle connection, int fd, GCancellableHandle cancellable, out GErrorHandle error);

}
