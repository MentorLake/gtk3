namespace MentorLake.Gio;

public interface GTlsServerConnectionHandle
{
}

internal class GTlsServerConnectionHandleImpl : BaseSafeHandle, GTlsServerConnectionHandle
{
}

public static class GTlsServerConnectionHandleExtensions
{
	public static MentorLake.Gio.GIOStreamHandle New(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		return GTlsServerConnectionHandleExterns.g_tls_server_connection_new(base_io_stream, certificate);
	}

}

internal class GTlsServerConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate);

}
