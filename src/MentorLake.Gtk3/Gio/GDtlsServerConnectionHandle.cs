namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDtlsServerConnection` is the server-side subclass of
/// [iface@Gio.DtlsConnection], representing a server-side DTLS connection.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Creates a new #GDtlsServerConnection wrapping @base_socket.
/// </para>
/// </summary>

/// <param name="base_socket">
/// the #GDatagramBased to wrap
/// </param>
/// <param name="certificate">
/// the default server certificate, or %NULL
/// </param>
/// <return>
/// the new
///   #GDtlsServerConnection, or %NULL on error
/// </return>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))]
	internal static extern MentorLake.Gio.GDatagramBasedHandle g_dtls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle base_socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.GLib.GErrorHandle error);

}
