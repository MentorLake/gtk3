namespace MentorLake.Gtk3.Gio;

public class GTcpConnectionHandle : GSocketConnectionHandle
{
}

public static class GTcpConnectionHandleExtensions
{
	public static bool GetGracefulDisconnect(this GTcpConnectionHandle connection)
	{
		return GTcpConnectionExterns.g_tcp_connection_get_graceful_disconnect(connection);
	}

	public static T SetGracefulDisconnect<T>(this T connection, bool graceful_disconnect) where T : GTcpConnectionHandle
	{
		GTcpConnectionExterns.g_tcp_connection_set_graceful_disconnect(connection, graceful_disconnect);
		return connection;
	}

}

internal class GTcpConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_tcp_connection_get_graceful_disconnect(GTcpConnectionHandle connection);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tcp_connection_set_graceful_disconnect(GTcpConnectionHandle connection, bool graceful_disconnect);

}
