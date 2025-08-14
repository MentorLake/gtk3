namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A certificate used for TLS authentication and encryption.
/// This can represent either a certificate only (eg, the certificate
/// received by a client from a server), or the combination of
/// a certificate and a private key (which is needed when acting as a
/// [iface@Gio.TlsServerConnection]).
/// </para>
/// </summary>

public class GTlsCertificateHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a #GTlsCertificate from the data in @file.
/// </para>
/// <para>
/// As of 2.72, if the filename ends in `.p12` or `.pfx` the data is loaded by
/// g_tls_certificate_new_from_pkcs12() otherwise it is loaded by
/// g_tls_certificate_new_from_pem(). See those functions for
/// exact details.
/// </para>
/// <para>
/// If @file cannot be read or parsed, the function will return %NULL and
/// set @error.
/// </para>
/// </summary>

/// <param name="file">
/// file containing a certificate to import
/// </param>
/// <return>
/// the new certificate, or %NULL on error
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle NewFromFile(string file)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_file(file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a #GTlsCertificate from the data in @file.
/// </para>
/// <para>
/// If @file cannot be read or parsed, the function will return %NULL and
/// set @error.
/// </para>
/// <para>
/// Any unknown file types will error with %G_IO_ERROR_NOT_SUPPORTED.
/// Currently only `.p12` and `.pfx` files are supported.
/// See g_tls_certificate_new_from_pkcs12() for more details.
/// </para>
/// </summary>

/// <param name="file">
/// file containing a certificate to import
/// </param>
/// <param name="password">
/// password for PKCS #12 files
/// </param>
/// <return>
/// the new certificate, or %NULL on error
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle NewFromFileWithPassword(string file, string password)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_file_with_password(file, password, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a #GTlsCertificate from the PEM-encoded data in @cert_file
/// and @key_file. The returned certificate will be the first certificate
/// found in @cert_file. As of GLib 2.44, if @cert_file contains more
/// certificates it will try to load a certificate chain. All
/// certificates will be verified in the order found (top-level
/// certificate should be the last one in the file) and the
/// #GTlsCertificate:issuer property of each certificate will be set
/// accordingly if the verification succeeds. If any certificate in the
/// chain cannot be verified, the first certificate in the file will
/// still be returned.
/// </para>
/// <para>
/// If either file cannot be read or parsed, the function will return
/// %NULL and set @error. Otherwise, this behaves like
/// g_tls_certificate_new_from_pem().
/// </para>
/// </summary>

/// <param name="cert_file">
/// file containing one or more PEM-encoded
///     certificates to import
/// </param>
/// <param name="key_file">
/// file containing a PEM-encoded private key
///     to import
/// </param>
/// <return>
/// the new certificate, or %NULL on error
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle NewFromFiles(string cert_file, string key_file)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_files(cert_file, key_file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a #GTlsCertificate from the PEM-encoded data in @data. If
/// @data includes both a certificate and a private key, then the
/// returned certificate will include the private key data as well. (See
/// the #GTlsCertificate:private-key-pem property for information about
/// supported formats.)
/// </para>
/// <para>
/// The returned certificate will be the first certificate found in
/// @data. As of GLib 2.44, if @data contains more certificates it will
/// try to load a certificate chain. All certificates will be verified in
/// the order found (top-level certificate should be the last one in the
/// file) and the #GTlsCertificate:issuer property of each certificate
/// will be set accordingly if the verification succeeds. If any
/// certificate in the chain cannot be verified, the first certificate in
/// the file will still be returned.
/// </para>
/// </summary>

/// <param name="data">
/// PEM-encoded certificate data
/// </param>
/// <param name="length">
/// the length of @data, or -1 if it's 0-terminated.
/// </param>
/// <return>
/// the new certificate, or %NULL if @data is invalid
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle NewFromPem(string data, UIntPtr length)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_pem(data, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a #GTlsCertificate from a
/// [PKCS \#11](https://docs.oasis-open.org/pkcs11/pkcs11-base/v3.0/os/pkcs11-base-v3.0-os.html) URI.
/// </para>
/// <para>
/// An example @pkcs11_uri would be `pkcs11:model=Model;manufacturer=Manufacture;serial=1;token=My%20Client%20Certificate;id=%01`
/// </para>
/// <para>
/// Where the token’s layout is:
/// </para>
/// <para>
/// |[
/// Object 0:
///   URL: pkcs11:model=Model;manufacturer=Manufacture;serial=1;token=My%20Client%20Certificate;id=%01;object=private%20key;type=private
///   Type: Private key (RSA-2048)
///   ID: 01
/// </para>
/// <para>
/// Object 1:
///   URL: pkcs11:model=Model;manufacturer=Manufacture;serial=1;token=My%20Client%20Certificate;id=%01;object=Certificate%20for%20Authentication;type=cert
///   Type: X.509 Certificate (RSA-2048)
///   ID: 01
/// ]|
/// </para>
/// <para>
/// In this case the certificate and private key would both be detected and used as expected.
/// @pkcs_uri may also just reference an X.509 certificate object and then optionally
/// @private_key_pkcs11_uri allows using a private key exposed under a different URI.
/// </para>
/// <para>
/// Note that the private key is not accessed until usage and may fail or require a PIN later.
/// </para>
/// </summary>

/// <param name="pkcs11_uri">
/// A PKCS \#11 URI
/// </param>
/// <param name="private_key_pkcs11_uri">
/// A PKCS \#11 URI
/// </param>
/// <return>
/// the new certificate, or %NULL on error
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle NewFromPkcs11Uris(string pkcs11_uri, string private_key_pkcs11_uri)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_pkcs11_uris(pkcs11_uri, private_key_pkcs11_uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a #GTlsCertificate from the data in @data. It must contain
/// a certificate and matching private key.
/// </para>
/// <para>
/// If extra certificates are included they will be verified as a chain
/// and the #GTlsCertificate:issuer property will be set.
/// All other data will be ignored.
/// </para>
/// <para>
/// You can pass as single password for all of the data which will be
/// used both for the PKCS #12 container as well as encrypted
/// private keys. If decryption fails it will error with
/// %G_TLS_ERROR_BAD_CERTIFICATE_PASSWORD.
/// </para>
/// <para>
/// This constructor requires support in the current #GTlsBackend.
/// If support is missing it will error with
/// %G_IO_ERROR_NOT_SUPPORTED.
/// </para>
/// <para>
/// Other parsing failures will error with %G_TLS_ERROR_BAD_CERTIFICATE.
/// </para>
/// </summary>

/// <param name="data">
/// DER-encoded PKCS #12 format certificate data
/// </param>
/// <param name="length">
/// the length of @data
/// </param>
/// <param name="password">
/// optional password for encrypted certificate data
/// </param>
/// <return>
/// the new certificate, or %NULL if @data is invalid
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle NewFromPkcs12(byte[] data, UIntPtr length, string password)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_pkcs12(data, length, password, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates one or more #GTlsCertificates from the PEM-encoded
/// data in @file. If @file cannot be read or parsed, the function will
/// return %NULL and set @error. If @file does not contain any
/// PEM-encoded certificates, this will return an empty list and not
/// set @error.
/// </para>
/// </summary>

/// <param name="file">
/// file containing PEM-encoded certificates to import
/// </param>
/// <return>
/// a
/// #GList containing #GTlsCertificate objects. You must free the list
/// and its contents when you are done with it.
/// </return>

	public static MentorLake.GLib.GListHandle ListNewFromFile(string file)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_list_new_from_file(file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GTlsCertificateHandleExtensions
{
/// <summary>
/// <para>
/// Gets the value of #GTlsCertificate:dns-names.
/// </para>
/// </summary>

/// <param name="cert">
/// a #GTlsCertificate
/// </param>
/// <return>
/// A #GPtrArray of
/// #GBytes elements, or %NULL if it's not available.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle GetDnsNames(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		if (cert.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_get_dns_names(cert);
	}

/// <summary>
/// <para>
/// Gets the value of #GTlsCertificate:ip-addresses.
/// </para>
/// </summary>

/// <param name="cert">
/// a #GTlsCertificate
/// </param>
/// <return>
/// A #GPtrArray
/// of #GInetAddress elements, or %NULL if it's not available.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle GetIpAddresses(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		if (cert.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_get_ip_addresses(cert);
	}

/// <summary>
/// <para>
/// Gets the #GTlsCertificate representing @cert's issuer, if known
/// </para>
/// </summary>

/// <param name="cert">
/// a #GTlsCertificate
/// </param>
/// <return>
/// The certificate of @cert's issuer,
/// or %NULL if @cert is self-signed or signed with an unknown
/// certificate.
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetIssuer(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		if (cert.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_get_issuer(cert);
	}

/// <summary>
/// <para>
/// Returns the issuer name from the certificate.
/// </para>
/// </summary>

/// <param name="cert">
/// a #GTlsCertificate
/// </param>
/// <return>
/// The issuer name, or %NULL if it's not available.
/// </return>

	public static string GetIssuerName(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		if (cert.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_get_issuer_name(cert);
	}

/// <summary>
/// <para>
/// Returns the time at which the certificate became or will become invalid.
/// </para>
/// </summary>

/// <param name="cert">
/// a #GTlsCertificate
/// </param>
/// <return>
/// The not-valid-after date, or %NULL if it's not available.
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetNotValidAfter(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		if (cert.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_get_not_valid_after(cert);
	}

/// <summary>
/// <para>
/// Returns the time at which the certificate became or will become valid.
/// </para>
/// </summary>

/// <param name="cert">
/// a #GTlsCertificate
/// </param>
/// <return>
/// The not-valid-before date, or %NULL if it's not available.
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetNotValidBefore(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		if (cert.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_get_not_valid_before(cert);
	}

/// <summary>
/// <para>
/// Returns the subject name from the certificate.
/// </para>
/// </summary>

/// <param name="cert">
/// a #GTlsCertificate
/// </param>
/// <return>
/// The subject name, or %NULL if it's not available.
/// </return>

	public static string GetSubjectName(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		if (cert.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_get_subject_name(cert);
	}

/// <summary>
/// <para>
/// Check if two #GTlsCertificate objects represent the same certificate.
/// The raw DER byte data of the two certificates are checked for equality.
/// This has the effect that two certificates may compare equal even if
/// their #GTlsCertificate:issuer, #GTlsCertificate:private-key, or
/// #GTlsCertificate:private-key-pem properties differ.
/// </para>
/// </summary>

/// <param name="cert_one">
/// first certificate to compare
/// </param>
/// <param name="cert_two">
/// second certificate to compare
/// </param>
/// <return>
/// whether the same or not
/// </return>

	public static bool IsSame(this MentorLake.Gio.GTlsCertificateHandle cert_one, MentorLake.Gio.GTlsCertificateHandle cert_two)
	{
		if (cert_one.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_is_same(cert_one, cert_two);
	}

/// <summary>
/// <para>
/// This verifies @cert and returns a set of #GTlsCertificateFlags
/// indicating any problems found with it. This can be used to verify a
/// certificate outside the context of making a connection, or to
/// check a certificate against a CA that is not part of the system
/// CA database.
/// </para>
/// <para>
/// If @cert is valid, %G_TLS_CERTIFICATE_NO_FLAGS is returned.
/// </para>
/// <para>
/// If @identity is not %NULL, @cert's name(s) will be compared against
/// it, and %G_TLS_CERTIFICATE_BAD_IDENTITY will be set in the return
/// value if it does not match. If @identity is %NULL, that bit will
/// never be set in the return value.
/// </para>
/// <para>
/// If @trusted_ca is not %NULL, then @cert (or one of the certificates
/// in its chain) must be signed by it, or else
/// %G_TLS_CERTIFICATE_UNKNOWN_CA will be set in the return value. If
/// @trusted_ca is %NULL, that bit will never be set in the return
/// value.
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
/// Because TLS session context is not used, #GTlsCertificate may not
/// perform as many checks on the certificates as #GTlsConnection would.
/// For example, certificate constraints may not be honored, and
/// revocation checks may not be performed. The best way to verify TLS
/// certificates used by a TLS connection is to let #GTlsConnection
/// handle the verification.
/// </para>
/// </summary>

/// <param name="cert">
/// a #GTlsCertificate
/// </param>
/// <param name="identity">
/// the expected peer identity
/// </param>
/// <param name="trusted_ca">
/// the certificate of a trusted authority
/// </param>
/// <return>
/// the appropriate #GTlsCertificateFlags
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags Verify(this MentorLake.Gio.GTlsCertificateHandle cert, MentorLake.Gio.GSocketConnectableHandle identity, MentorLake.Gio.GTlsCertificateHandle trusted_ca)
	{
		if (cert.IsInvalid) throw new Exception("Invalid handle (GTlsCertificateHandle)");
		return GTlsCertificateHandleExterns.g_tls_certificate_verify(cert, identity, trusted_ca);
	}

}

internal class GTlsCertificateHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_file(string file, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_file_with_password(string file, string password, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_files(string cert_file, string key_file, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_pem(string data, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_pkcs11_uris(string pkcs11_uri, string private_key_pkcs11_uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_pkcs12(byte[] data, UIntPtr length, string password, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_tls_certificate_get_dns_names([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_tls_certificate_get_ip_addresses([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_get_issuer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_certificate_get_issuer_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_tls_certificate_get_not_valid_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_tls_certificate_get_not_valid_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_certificate_get_subject_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_certificate_is_same([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert_one, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert_two);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_tls_certificate_verify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle identity, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle trusted_ca);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_tls_certificate_list_new_from_file(string file, out MentorLake.GLib.GErrorHandle error);

}
