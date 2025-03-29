namespace MentorLake.Gio;

public interface GDtlsServerConnectionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDtlsServerConnectionHandleImpl : BaseSafeHandle, GDtlsServerConnectionHandle
{
}

public static class GDtlsServerConnectionHandleExtensions
{
	public static MentorLake.Gio.GDatagramBasedHandle New(MentorLake.Gio.GDatagramBasedHandle base_socket, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		var externCallResult = GDtlsServerConnectionHandleExterns.g_dtls_server_connection_new(base_socket, certificate, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GDtlsServerConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDatagramBasedHandle g_dtls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle base_socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.GLib.GErrorHandle error);

}
