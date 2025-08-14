namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GTcpWrapperConnection` can be used to wrap a [class@Gio.IOStream] that is
/// based on a [class@Gio.Socket], but which is not actually a
/// [class@Gio.SocketConnection]. This is used by [class@Gio.SocketClient] so
/// that it can always return a [class@Gio.SocketConnection], even when the
/// connection it has actually created is not directly a
/// [class@Gio.SocketConnection].
/// </para>
/// </summary>

public class GTcpWrapperConnectionHandle : GTcpConnectionHandle
{
/// <summary>
/// <para>
/// Wraps @base_io_stream and @socket together as a #GSocketConnection.
/// </para>
/// </summary>

/// <param name="base_io_stream">
/// the #GIOStream to wrap
/// </param>
/// <param name="socket">
/// the #GSocket associated with @base_io_stream
/// </param>
/// <return>
/// the new #GSocketConnection.
/// </return>

	public static MentorLake.Gio.GTcpWrapperConnectionHandle New(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GSocketHandle socket)
	{
		return GTcpWrapperConnectionHandleExterns.g_tcp_wrapper_connection_new(base_io_stream, socket);
	}

}

public static class GTcpWrapperConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Gets @conn's base #GIOStream
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTcpWrapperConnection
/// </param>
/// <return>
/// @conn's base #GIOStream
/// </return>

	public static MentorLake.Gio.GIOStreamHandle GetBaseIoStream(this MentorLake.Gio.GTcpWrapperConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTcpWrapperConnectionHandle)");
		return GTcpWrapperConnectionHandleExterns.g_tcp_wrapper_connection_get_base_io_stream(conn);
	}

}

internal class GTcpWrapperConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTcpWrapperConnectionHandle>))]
	internal static extern MentorLake.Gio.GTcpWrapperConnectionHandle g_tcp_wrapper_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tcp_wrapper_connection_get_base_io_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTcpWrapperConnectionHandle>))] MentorLake.Gio.GTcpWrapperConnectionHandle conn);

}
