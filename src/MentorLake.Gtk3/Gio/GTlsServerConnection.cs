namespace MentorLake.Gtk3.Gio;

public interface GTlsServerConnectionHandle
{
}

internal class GTlsServerConnectionHandleImpl : BaseSafeHandle, GTlsServerConnectionHandle
{
}

public static class GTlsServerConnectionHandleExtensions
{
	public static GIOStreamHandle New(GIOStreamHandle base_io_stream, GTlsCertificateHandle certificate, out GErrorHandle error)
	{
		return GTlsServerConnectionExterns.g_tls_server_connection_new(base_io_stream, certificate, out error);
	}

}

internal class GTlsServerConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GIOStreamHandle g_tls_server_connection_new(GIOStreamHandle base_io_stream, GTlsCertificateHandle certificate, out GErrorHandle error);

}
