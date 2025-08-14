namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GTlsServerConnection` is the server-side subclass of
/// [class@Gio.TlsConnection], representing a server-side TLS connection.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Creates a new #GTlsServerConnection wrapping @base_io_stream (which
/// must have pollable input and output streams).
/// </para>
/// <para>
/// See the documentation for #GTlsConnection:base-io-stream for restrictions
/// on when application code can run operations on the @base_io_stream after
/// this function has returned.
/// </para>
/// </summary>

/// <param name="base_io_stream">
/// the #GIOStream to wrap
/// </param>
/// <param name="certificate">
/// the default server certificate, or %NULL
/// </param>
/// <return>
/// the new
/// #GTlsServerConnection, or %NULL on error
/// </return>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tls_server_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.GLib.GErrorHandle error);

}
