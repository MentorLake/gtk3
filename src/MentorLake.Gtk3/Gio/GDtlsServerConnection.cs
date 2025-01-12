namespace MentorLake.Gtk3.Gio;

public interface GDtlsServerConnectionHandle
{
}

internal class GDtlsServerConnectionHandleImpl : BaseSafeHandle, GDtlsServerConnectionHandle
{
}

public static class GDtlsServerConnectionHandleExtensions
{
	public static GDatagramBasedHandle New(GDatagramBasedHandle base_socket, GTlsCertificateHandle certificate, out GErrorHandle error)
	{
		return GDtlsServerConnectionExterns.g_dtls_server_connection_new(base_socket, certificate, out error);
	}

}

internal class GDtlsServerConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDatagramBasedHandle g_dtls_server_connection_new(GDatagramBasedHandle base_socket, GTlsCertificateHandle certificate, out GErrorHandle error);

}
