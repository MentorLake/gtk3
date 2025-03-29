namespace MentorLake.Gio;

public interface GTlsServerConnectionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GTlsServerConnectionHandleImpl : BaseSafeHandle, GTlsServerConnectionHandle
{
}

public static class GTlsServerConnectionHandleExtensions
{
	public static MentorLake.Gio.GIOStreamHandle New(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		var externCallResult = GTlsServerConnectionHandleExterns.g_tls_server_connection_new(base_io_stream, certificate, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GTlsServerConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.GLib.GErrorHandle error);

}
