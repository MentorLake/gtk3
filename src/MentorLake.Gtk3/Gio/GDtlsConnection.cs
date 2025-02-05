namespace MentorLake.Gtk3.Gio;

public interface GDtlsConnectionHandle
{
}

internal class GDtlsConnectionHandleImpl : BaseSafeHandle, GDtlsConnectionHandle
{
}

public static class GDtlsConnectionHandleExtensions
{
	public static bool Close(this GDtlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDtlsConnectionExterns.g_dtls_connection_close(conn, cancellable, out error);
	}

	public static T CloseAsync<T>(this T conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_close_async(conn, io_priority, cancellable, callback, user_data);
		return conn;
	}

	public static bool CloseFinish(this GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GDtlsConnectionExterns.g_dtls_connection_close_finish(conn, result, out error);
	}

	public static bool EmitAcceptCertificate(this GDtlsConnectionHandle conn, GTlsCertificateHandle peer_cert, GTlsCertificateFlags errors)
	{
		return GDtlsConnectionExterns.g_dtls_connection_emit_accept_certificate(conn, peer_cert, errors);
	}

	public static GTlsCertificateHandle GetCertificate(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_certificate(conn);
	}

	public static bool GetChannelBindingData(this GDtlsConnectionHandle conn, GTlsChannelBindingType type, out GByteArray data, out GErrorHandle error)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_channel_binding_data(conn, type, out data, out error);
	}

	public static string GetCiphersuiteName(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_ciphersuite_name(conn);
	}

	public static GTlsDatabaseHandle GetDatabase(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_database(conn);
	}

	public static GTlsInteractionHandle GetInteraction(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_interaction(conn);
	}

	public static string GetNegotiatedProtocol(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_negotiated_protocol(conn);
	}

	public static GTlsCertificateHandle GetPeerCertificate(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_peer_certificate(conn);
	}

	public static GTlsCertificateFlags GetPeerCertificateErrors(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_peer_certificate_errors(conn);
	}

	public static GTlsProtocolVersion GetProtocolVersion(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_protocol_version(conn);
	}

	public static GTlsRehandshakeMode GetRehandshakeMode(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_rehandshake_mode(conn);
	}

	public static bool GetRequireCloseNotify(this GDtlsConnectionHandle conn)
	{
		return GDtlsConnectionExterns.g_dtls_connection_get_require_close_notify(conn);
	}

	public static bool Handshake(this GDtlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDtlsConnectionExterns.g_dtls_connection_handshake(conn, cancellable, out error);
	}

	public static T HandshakeAsync<T>(this T conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_handshake_async(conn, io_priority, cancellable, callback, user_data);
		return conn;
	}

	public static bool HandshakeFinish(this GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GDtlsConnectionExterns.g_dtls_connection_handshake_finish(conn, result, out error);
	}

	public static T SetAdvertisedProtocols<T>(this T conn, string protocols) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_set_advertised_protocols(conn, protocols);
		return conn;
	}

	public static T SetCertificate<T>(this T conn, GTlsCertificateHandle certificate) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_set_certificate(conn, certificate);
		return conn;
	}

	public static T SetDatabase<T>(this T conn, GTlsDatabaseHandle database) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_set_database(conn, database);
		return conn;
	}

	public static T SetInteraction<T>(this T conn, GTlsInteractionHandle interaction) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_set_interaction(conn, interaction);
		return conn;
	}

	public static T SetRehandshakeMode<T>(this T conn, GTlsRehandshakeMode mode) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_set_rehandshake_mode(conn, mode);
		return conn;
	}

	public static T SetRequireCloseNotify<T>(this T conn, bool require_close_notify) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_set_require_close_notify(conn, require_close_notify);
		return conn;
	}

	public static bool Shutdown(this GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDtlsConnectionExterns.g_dtls_connection_shutdown(conn, shutdown_read, shutdown_write, cancellable, out error);
	}

	public static T ShutdownAsync<T>(this T conn, bool shutdown_read, bool shutdown_write, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		GDtlsConnectionExterns.g_dtls_connection_shutdown_async(conn, shutdown_read, shutdown_write, io_priority, cancellable, callback, user_data);
		return conn;
	}

	public static bool ShutdownFinish(this GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GDtlsConnectionExterns.g_dtls_connection_shutdown_finish(conn, result, out error);
	}

}

internal class GDtlsConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_close(GDtlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_close_async(GDtlsConnectionHandle conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_close_finish(GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_emit_accept_certificate(GDtlsConnectionHandle conn, GTlsCertificateHandle peer_cert, GTlsCertificateFlags errors);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_dtls_connection_get_certificate(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_get_channel_binding_data(GDtlsConnectionHandle conn, GTlsChannelBindingType type, out GByteArray data, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dtls_connection_get_ciphersuite_name(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsDatabaseHandle g_dtls_connection_get_database(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsInteractionHandle g_dtls_connection_get_interaction(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dtls_connection_get_negotiated_protocol(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateHandle g_dtls_connection_get_peer_certificate(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_dtls_connection_get_peer_certificate_errors(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsProtocolVersion g_dtls_connection_get_protocol_version(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsRehandshakeMode g_dtls_connection_get_rehandshake_mode(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_get_require_close_notify(GDtlsConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_handshake(GDtlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_handshake_async(GDtlsConnectionHandle conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_handshake_finish(GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_set_advertised_protocols(GDtlsConnectionHandle conn, string protocols);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_set_certificate(GDtlsConnectionHandle conn, GTlsCertificateHandle certificate);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_set_database(GDtlsConnectionHandle conn, GTlsDatabaseHandle database);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_set_interaction(GDtlsConnectionHandle conn, GTlsInteractionHandle interaction);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_set_rehandshake_mode(GDtlsConnectionHandle conn, GTlsRehandshakeMode mode);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_set_require_close_notify(GDtlsConnectionHandle conn, bool require_close_notify);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_shutdown(GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_connection_shutdown_async(GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dtls_connection_shutdown_finish(GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error);

}
