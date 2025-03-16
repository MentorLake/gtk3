namespace MentorLake.Gio;

public class GTlsDatabaseHandle : GObjectHandle
{
}

public static class GTlsDatabaseHandleExtensions
{
	public static string CreateCertificateHandle(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_create_certificate_handle(self, certificate);
	}

	public static MentorLake.Gio.GTlsCertificateHandle LookupCertificateForHandle(this MentorLake.Gio.GTlsDatabaseHandle self, string handle, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_for_handle(self, handle, interaction, flags, cancellable);
	}

	public static T LookupCertificateForHandleAsync<T>(this T self, string handle, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsDatabaseHandle
	{
		GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_for_handle_async(self, handle, interaction, flags, cancellable, callback, user_data);
		return self;
	}

	public static MentorLake.Gio.GTlsCertificateHandle LookupCertificateForHandleFinish(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_for_handle_finish(self, result);
	}

	public static MentorLake.Gio.GTlsCertificateHandle LookupCertificateIssuer(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GTlsCertificateHandle certificate, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_issuer(self, certificate, interaction, flags, cancellable);
	}

	public static T LookupCertificateIssuerAsync<T>(this T self, MentorLake.Gio.GTlsCertificateHandle certificate, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsDatabaseHandle
	{
		GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_issuer_async(self, certificate, interaction, flags, cancellable, callback, user_data);
		return self;
	}

	public static MentorLake.Gio.GTlsCertificateHandle LookupCertificateIssuerFinish(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_issuer_finish(self, result);
	}

	public static MentorLake.GLib.GListHandle LookupCertificatesIssuedBy(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.GLib.GByteArrayHandle issuer_raw_dn, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_lookup_certificates_issued_by(self, issuer_raw_dn, interaction, flags, cancellable);
	}

	public static T LookupCertificatesIssuedByAsync<T>(this T self, MentorLake.GLib.GByteArrayHandle issuer_raw_dn, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsDatabaseHandle
	{
		GTlsDatabaseHandleExterns.g_tls_database_lookup_certificates_issued_by_async(self, issuer_raw_dn, interaction, flags, cancellable, callback, user_data);
		return self;
	}

	public static MentorLake.GLib.GListHandle LookupCertificatesIssuedByFinish(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_lookup_certificates_issued_by_finish(self, result);
	}

	public static MentorLake.Gio.GTlsCertificateFlags VerifyChain(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GTlsCertificateHandle chain, string purpose, MentorLake.Gio.GSocketConnectableHandle identity, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseVerifyFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_verify_chain(self, chain, purpose, identity, interaction, flags, cancellable);
	}

	public static T VerifyChainAsync<T>(this T self, MentorLake.Gio.GTlsCertificateHandle chain, string purpose, MentorLake.Gio.GSocketConnectableHandle identity, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseVerifyFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsDatabaseHandle
	{
		GTlsDatabaseHandleExterns.g_tls_database_verify_chain_async(self, chain, purpose, identity, interaction, flags, cancellable, callback, user_data);
		return self;
	}

	public static MentorLake.Gio.GTlsCertificateFlags VerifyChainFinish(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GTlsDatabaseHandleExterns.g_tls_database_verify_chain_finish(self, result);
	}

}

internal class GTlsDatabaseHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_database_create_certificate_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_database_lookup_certificate_for_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, string handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_database_lookup_certificate_for_handle_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, string handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_database_lookup_certificate_for_handle_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_database_lookup_certificate_issuer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_database_lookup_certificate_issuer_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_database_lookup_certificate_issuer_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_tls_database_lookup_certificates_issued_by([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle issuer_raw_dn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_database_lookup_certificates_issued_by_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle issuer_raw_dn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_tls_database_lookup_certificates_issued_by_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_tls_database_verify_chain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle chain, string purpose, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle identity, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseVerifyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_database_verify_chain_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle chain, string purpose, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle identity, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseVerifyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_tls_database_verify_chain_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

}
