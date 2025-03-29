namespace MentorLake.Gio;

public interface GDtlsConnectionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDtlsConnectionHandleImpl : BaseSafeHandle, GDtlsConnectionHandle
{
}

public static class GDtlsConnectionHandleExtensions
{
	public static bool Close(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_close(conn, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T CloseAsync<T>(this T conn, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_close_async(conn, io_priority, cancellable, callback, user_data);
		return conn;
	}

	public static bool CloseFinish(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_close_finish(conn, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool EmitAcceptCertificate(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GTlsCertificateHandle peer_cert, MentorLake.Gio.GTlsCertificateFlags errors)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_emit_accept_certificate(conn, peer_cert, errors);
	}

	public static MentorLake.Gio.GTlsCertificateHandle GetCertificate(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_certificate(conn);
	}

	public static bool GetChannelBindingData(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GTlsChannelBindingType type, out MentorLake.GLib.GByteArray data)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_get_channel_binding_data(conn, type, out data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string GetCiphersuiteName(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_ciphersuite_name(conn);
	}

	public static MentorLake.Gio.GTlsDatabaseHandle GetDatabase(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_database(conn);
	}

	public static MentorLake.Gio.GTlsInteractionHandle GetInteraction(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_interaction(conn);
	}

	public static string GetNegotiatedProtocol(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_negotiated_protocol(conn);
	}

	public static MentorLake.Gio.GTlsCertificateHandle GetPeerCertificate(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_peer_certificate(conn);
	}

	public static MentorLake.Gio.GTlsCertificateFlags GetPeerCertificateErrors(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_peer_certificate_errors(conn);
	}

	public static MentorLake.Gio.GTlsProtocolVersion GetProtocolVersion(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_protocol_version(conn);
	}

	public static MentorLake.Gio.GTlsRehandshakeMode GetRehandshakeMode(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_rehandshake_mode(conn);
	}

	public static bool GetRequireCloseNotify(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_require_close_notify(conn);
	}

	public static bool Handshake(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_handshake(conn, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T HandshakeAsync<T>(this T conn, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_handshake_async(conn, io_priority, cancellable, callback, user_data);
		return conn;
	}

	public static bool HandshakeFinish(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_handshake_finish(conn, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetAdvertisedProtocols<T>(this T conn, string[] protocols) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_advertised_protocols(conn, protocols);
		return conn;
	}

	public static T SetCertificate<T>(this T conn, MentorLake.Gio.GTlsCertificateHandle certificate) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_certificate(conn, certificate);
		return conn;
	}

	public static T SetDatabase<T>(this T conn, MentorLake.Gio.GTlsDatabaseHandle database) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_database(conn, database);
		return conn;
	}

	public static T SetInteraction<T>(this T conn, MentorLake.Gio.GTlsInteractionHandle interaction) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_interaction(conn, interaction);
		return conn;
	}

	public static T SetRehandshakeMode<T>(this T conn, MentorLake.Gio.GTlsRehandshakeMode mode) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_rehandshake_mode(conn, mode);
		return conn;
	}

	public static T SetRequireCloseNotify<T>(this T conn, bool require_close_notify) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_require_close_notify(conn, require_close_notify);
		return conn;
	}

	public static bool Shutdown(this MentorLake.Gio.GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_shutdown(conn, shutdown_read, shutdown_write, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ShutdownAsync<T>(this T conn, bool shutdown_read, bool shutdown_write, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_shutdown_async(conn, shutdown_read, shutdown_write, io_priority, cancellable, callback, user_data);
		return conn;
	}

	public static bool ShutdownFinish(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (conn.IsInvalid || conn.IsClosed) throw new Exception("Invalid or closed handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_shutdown_finish(conn, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GDtlsConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_emit_accept_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle peer_cert, MentorLake.Gio.GTlsCertificateFlags errors);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_dtls_connection_get_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_get_channel_binding_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GTlsChannelBindingType type, out MentorLake.GLib.GByteArray data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dtls_connection_get_ciphersuite_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_dtls_connection_get_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionHandle g_dtls_connection_get_interaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dtls_connection_get_negotiated_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_dtls_connection_get_peer_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_dtls_connection_get_peer_certificate_errors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsProtocolVersion g_dtls_connection_get_protocol_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsRehandshakeMode g_dtls_connection_get_rehandshake_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_get_require_close_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_handshake([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_handshake_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_handshake_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_advertised_protocols([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, string[] protocols);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle database);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_interaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_rehandshake_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GTlsRehandshakeMode mode);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_require_close_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, bool require_close_notify);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_shutdown_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_shutdown_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
