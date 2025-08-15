namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GTlsDatabase` is used to look up certificates and other information
/// from a certificate or key store. It is an abstract base class which
/// TLS library specific subtypes override.
/// </para>
/// <para>
/// A `GTlsDatabase` may be accessed from multiple threads by the TLS backend.
/// All implementations are required to be fully thread-safe.
/// </para>
/// <para>
/// Most common client applications will not directly interact with
/// `GTlsDatabase`. It is used internally by [class@Gio.TlsConnection].
/// </para>
/// </summary>

public class GTlsDatabaseHandle : GObjectHandle
{
}

public static class GTlsDatabaseHandleExtensions
{
/// <summary>
/// <para>
/// Create a handle string for the certificate. The database will only be able
/// to create a handle for certificates that originate from the database. In
/// cases where the database cannot create a handle for a certificate, %NULL
/// will be returned.
/// </para>
/// <para>
/// This handle should be stable across various instances of the application,
/// and between applications. If a certificate is modified in the database,
/// then it is not guaranteed that this handle will continue to point to it.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="certificate">
/// certificate for which to create a handle.
/// </param>
/// <return>
/// a newly allocated string containing the
/// handle.
/// </return>

	public static string CreateCertificateHandle(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GTlsCertificateHandle certificate)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		return GTlsDatabaseHandleExterns.g_tls_database_create_certificate_handle(self, certificate);
	}

/// <summary>
/// <para>
/// Look up a certificate by its handle.
/// </para>
/// <para>
/// The handle should have been created by calling
/// g_tls_database_create_certificate_handle() on a #GTlsDatabase object of
/// the same TLS backend. The handle is designed to remain valid across
/// instantiations of the database.
/// </para>
/// <para>
/// If the handle is no longer valid, or does not point to a certificate in
/// this database, then %NULL will be returned.
/// </para>
/// <para>
/// This function can block, use g_tls_database_lookup_certificate_for_handle_async() to perform
/// the lookup operation asynchronously.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="handle">
/// a certificate handle
/// </param>
/// <param name="interaction">
/// used to interact with the user if necessary
/// </param>
/// <param name="flags">
/// Flags which affect the lookup.
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a newly allocated
/// #GTlsCertificate, or %NULL. Use g_object_unref() to release the certificate.
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle LookupCertificateForHandle(this MentorLake.Gio.GTlsDatabaseHandle self, string handle, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		var externCallResult = GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_for_handle(self, handle, interaction, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously look up a certificate by its handle in the database. See
/// g_tls_database_lookup_certificate_for_handle() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="handle">
/// a certificate handle
/// </param>
/// <param name="interaction">
/// used to interact with the user if necessary
/// </param>
/// <param name="flags">
/// Flags which affect the lookup.
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call when the operation completes
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T LookupCertificateForHandleAsync<T>(this T self, string handle, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsDatabaseHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_for_handle_async(self, handle, interaction, flags, cancellable, callback, user_data);
		return self;
	}

/// <summary>
/// <para>
/// Finish an asynchronous lookup of a certificate by its handle. See
/// g_tls_database_lookup_certificate_for_handle() for more information.
/// </para>
/// <para>
/// If the handle is no longer valid, or does not point to a certificate in
/// this database, then %NULL will be returned.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a newly allocated #GTlsCertificate object.
/// Use g_object_unref() to release the certificate.
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle LookupCertificateForHandleFinish(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		var externCallResult = GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_for_handle_finish(self, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Look up the issuer of @certificate in the database. The
/// #GTlsCertificate:issuer property of @certificate is not modified, and
/// the two certificates are not hooked into a chain.
/// </para>
/// <para>
/// This function can block. Use g_tls_database_lookup_certificate_issuer_async()
/// to perform the lookup operation asynchronously.
/// </para>
/// <para>
/// Beware this function cannot be used to build certification paths. The
/// issuer certificate returned by this function may not be the same as
/// the certificate that would actually be used to construct a valid
/// certification path during certificate verification.
/// [RFC 4158](https://datatracker.ietf.org/doc/html/rfc4158) explains
/// why an issuer certificate cannot be naively assumed to be part of the
/// the certification path (though GLib&apos;s TLS backends may not follow the
/// path building strategies outlined in this RFC). Due to the complexity
/// of certification path building, GLib does not provide any way to know
/// which certification path will actually be used when verifying a TLS
/// certificate. Accordingly, this function cannot be used to make
/// security-related decisions. Only GLib itself should make security
/// decisions about TLS certificates.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="certificate">
/// a #GTlsCertificate
/// </param>
/// <param name="interaction">
/// used to interact with the user if necessary
/// </param>
/// <param name="flags">
/// flags which affect the lookup operation
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a newly allocated issuer #GTlsCertificate,
/// or %NULL. Use g_object_unref() to release the certificate.
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle LookupCertificateIssuer(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GTlsCertificateHandle certificate, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		var externCallResult = GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_issuer(self, certificate, interaction, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously look up the issuer of @certificate in the database. See
/// g_tls_database_lookup_certificate_issuer() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="certificate">
/// a #GTlsCertificate
/// </param>
/// <param name="interaction">
/// used to interact with the user if necessary
/// </param>
/// <param name="flags">
/// flags which affect the lookup operation
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call when the operation completes
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T LookupCertificateIssuerAsync<T>(this T self, MentorLake.Gio.GTlsCertificateHandle certificate, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsDatabaseHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_issuer_async(self, certificate, interaction, flags, cancellable, callback, user_data);
		return self;
	}

/// <summary>
/// <para>
/// Finish an asynchronous lookup issuer operation. See
/// g_tls_database_lookup_certificate_issuer() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a newly allocated issuer #GTlsCertificate,
/// or %NULL. Use g_object_unref() to release the certificate.
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle LookupCertificateIssuerFinish(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		var externCallResult = GTlsDatabaseHandleExterns.g_tls_database_lookup_certificate_issuer_finish(self, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Look up certificates issued by this issuer in the database.
/// </para>
/// <para>
/// This function can block, use g_tls_database_lookup_certificates_issued_by_async() to perform
/// the lookup operation asynchronously.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="issuer_raw_dn">
/// a #GByteArray which holds the DER encoded issuer DN.
/// </param>
/// <param name="interaction">
/// used to interact with the user if necessary
/// </param>
/// <param name="flags">
/// Flags which affect the lookup operation.
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a newly allocated list of #GTlsCertificate
/// objects. Use g_object_unref() on each certificate, and g_list_free() on the release the list.
/// </return>

	public static MentorLake.GLib.GListHandle LookupCertificatesIssuedBy(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.GLib.GByteArrayHandle issuer_raw_dn, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		var externCallResult = GTlsDatabaseHandleExterns.g_tls_database_lookup_certificates_issued_by(self, issuer_raw_dn, interaction, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously look up certificates issued by this issuer in the database. See
/// g_tls_database_lookup_certificates_issued_by() for more information.
/// </para>
/// <para>
/// The database may choose to hold a reference to the issuer byte array for the duration
/// of this asynchronous operation. The byte array should not be modified during
/// this time.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="issuer_raw_dn">
/// a #GByteArray which holds the DER encoded issuer DN.
/// </param>
/// <param name="interaction">
/// used to interact with the user if necessary
/// </param>
/// <param name="flags">
/// Flags which affect the lookup operation.
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call when the operation completes
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T LookupCertificatesIssuedByAsync<T>(this T self, MentorLake.GLib.GByteArrayHandle issuer_raw_dn, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsDatabaseHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		GTlsDatabaseHandleExterns.g_tls_database_lookup_certificates_issued_by_async(self, issuer_raw_dn, interaction, flags, cancellable, callback, user_data);
		return self;
	}

/// <summary>
/// <para>
/// Finish an asynchronous lookup of certificates. See
/// g_tls_database_lookup_certificates_issued_by() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a newly allocated list of #GTlsCertificate
/// objects. Use g_object_unref() on each certificate, and g_list_free() on the release the list.
/// </return>

	public static MentorLake.GLib.GListHandle LookupCertificatesIssuedByFinish(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		var externCallResult = GTlsDatabaseHandleExterns.g_tls_database_lookup_certificates_issued_by_finish(self, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Determines the validity of a certificate chain, outside the context
/// of a TLS session.
/// </para>
/// <para>
/// @chain is a chain of #GTlsCertificate objects each pointing to the next
/// certificate in the chain by its #GTlsCertificate:issuer property.
/// </para>
/// <para>
/// @purpose describes the purpose (or usage) for which the certificate
/// is being used. Typically @purpose will be set to %G_TLS_DATABASE_PURPOSE_AUTHENTICATE_SERVER
/// which means that the certificate is being used to authenticate a server
/// (and we are acting as the client).
/// </para>
/// <para>
/// The @identity is used to ensure the server certificate is valid for
/// the expected peer identity. If the identity does not match the
/// certificate, %G_TLS_CERTIFICATE_BAD_IDENTITY will be set in the
/// return value. If @identity is %NULL, that bit will never be set in
/// the return value. The peer identity may also be used to check for
/// pinned certificates (trust exceptions) in the database. These may
/// override the normal verification process on a host-by-host basis.
/// </para>
/// <para>
/// Currently there are no @flags, and %G_TLS_DATABASE_VERIFY_NONE should be
/// used.
/// </para>
/// <para>
/// If @chain is found to be valid, then the return value will be 0. If
/// @chain is found to be invalid, then the return value will indicate at
/// least one problem found. If the function is unable to determine
/// whether @chain is valid (for example, because @cancellable is
/// triggered before it completes) then the return value will be
/// %G_TLS_CERTIFICATE_GENERIC_ERROR and @error will be set accordingly.
/// @error is not set when @chain is successfully analyzed but found to
/// be invalid.
/// </para>
/// <para>
/// GLib guarantees that if certificate verification fails, at least one
/// error will be set in the return value, but it does not guarantee
/// that all possible errors will be set. Accordingly, you may not safely
/// decide to ignore any particular type of error. For example, it would
/// be incorrect to mask %G_TLS_CERTIFICATE_EXPIRED if you want to allow
/// expired certificates, because this could potentially be the only
/// error flag set even if other problems exist with the certificate.
/// </para>
/// <para>
/// Prior to GLib 2.48, GLib&apos;s default TLS backend modified @chain to
/// represent the certification path built by #GTlsDatabase during
/// certificate verification by adjusting the #GTlsCertificate:issuer
/// property of each certificate in @chain. Since GLib 2.48, this no
/// longer occurs, so you cannot rely on #GTlsCertificate:issuer to
/// represent the actual certification path used during certificate
/// verification.
/// </para>
/// <para>
/// Because TLS session context is not used, #GTlsDatabase may not
/// perform as many checks on the certificates as #GTlsConnection would.
/// For example, certificate constraints may not be honored, and
/// revocation checks may not be performed. The best way to verify TLS
/// certificates used by a TLS connection is to let #GTlsConnection
/// handle the verification.
/// </para>
/// <para>
/// The TLS backend may attempt to look up and add missing certificates
/// to the chain. This may involve HTTP requests to download missing
/// certificates.
/// </para>
/// <para>
/// This function can block. Use g_tls_database_verify_chain_async() to
/// perform the verification operation asynchronously.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="chain">
/// a #GTlsCertificate chain
/// </param>
/// <param name="purpose">
/// the purpose that this certificate chain will be used for.
/// </param>
/// <param name="identity">
/// the expected peer identity
/// </param>
/// <param name="interaction">
/// used to interact with the user if necessary
/// </param>
/// <param name="flags">
/// additional verify flags
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// the appropriate #GTlsCertificateFlags which represents the
/// result of verification.
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags VerifyChain(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GTlsCertificateHandle chain, string purpose, MentorLake.Gio.GSocketConnectableHandle identity, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseVerifyFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		var externCallResult = GTlsDatabaseHandleExterns.g_tls_database_verify_chain(self, chain, purpose, identity, interaction, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously determines the validity of a certificate chain after
/// looking up and adding any missing certificates to the chain. See
/// g_tls_database_verify_chain() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="chain">
/// a #GTlsCertificate chain
/// </param>
/// <param name="purpose">
/// the purpose that this certificate chain will be used for.
/// </param>
/// <param name="identity">
/// the expected peer identity
/// </param>
/// <param name="interaction">
/// used to interact with the user if necessary
/// </param>
/// <param name="flags">
/// additional verify flags
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call when the operation completes
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T VerifyChainAsync<T>(this T self, MentorLake.Gio.GTlsCertificateHandle chain, string purpose, MentorLake.Gio.GSocketConnectableHandle identity, MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseVerifyFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsDatabaseHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		GTlsDatabaseHandleExterns.g_tls_database_verify_chain_async(self, chain, purpose, identity, interaction, flags, cancellable, callback, user_data);
		return self;
	}

/// <summary>
/// <para>
/// Finish an asynchronous verify chain operation. See
/// g_tls_database_verify_chain() for more information.
/// </para>
/// <para>
/// If @chain is found to be valid, then the return value will be 0. If
/// @chain is found to be invalid, then the return value will indicate
/// the problems found. If the function is unable to determine whether
/// @chain is valid or not (eg, because @cancellable is triggered
/// before it completes) then the return value will be
/// %G_TLS_CERTIFICATE_GENERIC_ERROR and @error will be set
/// accordingly. @error is not set when @chain is successfully analyzed
/// but found to be invalid.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTlsDatabase
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// the appropriate #GTlsCertificateFlags which represents the
/// result of verification.
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags VerifyChainFinish(this MentorLake.Gio.GTlsDatabaseHandle self, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTlsDatabaseHandle)");
		var externCallResult = GTlsDatabaseHandleExterns.g_tls_database_verify_chain_finish(self, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GTlsDatabaseHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_database_create_certificate_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_database_lookup_certificate_for_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, string handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_database_lookup_certificate_for_handle_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, string handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_database_lookup_certificate_for_handle_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_database_lookup_certificate_issuer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_database_lookup_certificate_issuer_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_database_lookup_certificate_issuer_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_tls_database_lookup_certificates_issued_by([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle issuer_raw_dn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_database_lookup_certificates_issued_by_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle issuer_raw_dn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_tls_database_lookup_certificates_issued_by_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_tls_database_verify_chain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle chain, string purpose, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle identity, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseVerifyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_database_verify_chain_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle chain, string purpose, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle identity, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsDatabaseVerifyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_tls_database_verify_chain_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
