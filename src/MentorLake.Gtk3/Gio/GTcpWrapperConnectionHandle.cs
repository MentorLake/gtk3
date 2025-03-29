namespace MentorLake.Gio;

public class GTcpWrapperConnectionHandle : GTcpConnectionHandle
{
	public static MentorLake.Gio.GTcpWrapperConnectionHandle New(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GSocketHandle socket)
	{
		return GTcpWrapperConnectionHandleExterns.g_tcp_wrapper_connection_new(base_io_stream, socket);
	}

}

public static class GTcpWrapperConnectionHandleExtensions
{
	public static MentorLake.Gio.GIOStreamHandle GetBaseIoStream(this MentorLake.Gio.GTcpWrapperConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GTcpWrapperConnectionHandle)");
		return GTcpWrapperConnectionHandleExterns.g_tcp_wrapper_connection_get_base_io_stream(conn);
	}

}

internal class GTcpWrapperConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTcpWrapperConnectionHandle g_tcp_wrapper_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tcp_wrapper_connection_get_base_io_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTcpWrapperConnectionHandle>))] MentorLake.Gio.GTcpWrapperConnectionHandle conn);

}
