namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This is the subclass of [class@Gio.SocketConnection] that is created
/// for TCP/IP sockets.
/// </para>
/// </summary>

public class GTcpConnectionHandle : GSocketConnectionHandle
{
}

public static class GTcpConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Checks if graceful disconnects are used. See
/// g_tcp_connection_set_graceful_disconnect().
/// </para>
/// </summary>

/// <param name="connection">
/// a #GTcpConnection
/// </param>
/// <return>
/// %TRUE if graceful disconnect is used on close, %FALSE otherwise
/// </return>

	public static bool GetGracefulDisconnect(this MentorLake.Gio.GTcpConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GTcpConnectionHandle)");
		return GTcpConnectionHandleExterns.g_tcp_connection_get_graceful_disconnect(connection);
	}

/// <summary>
/// <para>
/// This enables graceful disconnects on close. A graceful disconnect
/// means that we signal the receiving end that the connection is terminated
/// and wait for it to close the connection before closing the connection.
/// </para>
/// <para>
/// A graceful disconnect means that we can be sure that we successfully sent
/// all the outstanding data to the other end, or get an error reported.
/// However, it also means we have to wait for all the data to reach the
/// other side and for it to acknowledge this by closing the socket, which may
/// take a while. For this reason it is disabled by default.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GTcpConnection
/// </param>
/// <param name="graceful_disconnect">
/// Whether to do graceful disconnects or not
/// </param>

	public static T SetGracefulDisconnect<T>(this T connection, bool graceful_disconnect) where T : GTcpConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GTcpConnectionHandle)");
		GTcpConnectionHandleExterns.g_tcp_connection_set_graceful_disconnect(connection, graceful_disconnect);
		return connection;
	}

}

internal class GTcpConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tcp_connection_get_graceful_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTcpConnectionHandle>))] MentorLake.Gio.GTcpConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tcp_connection_set_graceful_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTcpConnectionHandle>))] MentorLake.Gio.GTcpConnectionHandle connection, bool graceful_disconnect);

}
