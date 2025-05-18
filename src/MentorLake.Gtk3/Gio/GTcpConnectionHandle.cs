namespace MentorLake.Gio;

public class GTcpConnectionHandle : GSocketConnectionHandle
{
}

public static class GTcpConnectionHandleExtensions
{
	public static bool GetGracefulDisconnect(this MentorLake.Gio.GTcpConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GTcpConnectionHandle)");
		return GTcpConnectionHandleExterns.g_tcp_connection_get_graceful_disconnect(connection);
	}

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
