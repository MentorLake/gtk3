namespace MentorLake.Gio;

public class GTlsCertificateHandle : GObjectHandle
{
	public static MentorLake.Gio.GTlsCertificateHandle NewFromFile(string file)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_file(file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GTlsCertificateHandle NewFromFileWithPassword(string file, string password)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_file_with_password(file, password, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GTlsCertificateHandle NewFromFiles(string cert_file, string key_file)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_files(cert_file, key_file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GTlsCertificateHandle NewFromPem(string data, UIntPtr length)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_pem(data, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GTlsCertificateHandle NewFromPkcs11Uris(string pkcs11_uri, string private_key_pkcs11_uri)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_pkcs11_uris(pkcs11_uri, private_key_pkcs11_uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GTlsCertificateHandle NewFromPkcs12(byte[] data, UIntPtr length, string password)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_new_from_pkcs12(data, length, password, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GListHandle ListNewFromFile(string file)
	{
		var externCallResult = GTlsCertificateHandleExterns.g_tls_certificate_list_new_from_file(file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GTlsCertificateHandleExtensions
{
	public static MentorLake.GLib.GPtrArrayHandle GetDnsNames(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_get_dns_names(cert);
	}

	public static MentorLake.GLib.GPtrArrayHandle GetIpAddresses(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_get_ip_addresses(cert);
	}

	public static MentorLake.Gio.GTlsCertificateHandle GetIssuer(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_get_issuer(cert);
	}

	public static string GetIssuerName(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_get_issuer_name(cert);
	}

	public static MentorLake.GLib.GDateTimeHandle GetNotValidAfter(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_get_not_valid_after(cert);
	}

	public static MentorLake.GLib.GDateTimeHandle GetNotValidBefore(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_get_not_valid_before(cert);
	}

	public static string GetSubjectName(this MentorLake.Gio.GTlsCertificateHandle cert)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_get_subject_name(cert);
	}

	public static bool IsSame(this MentorLake.Gio.GTlsCertificateHandle cert_one, MentorLake.Gio.GTlsCertificateHandle cert_two)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_is_same(cert_one, cert_two);
	}

	public static MentorLake.Gio.GTlsCertificateFlags Verify(this MentorLake.Gio.GTlsCertificateHandle cert, MentorLake.Gio.GSocketConnectableHandle identity, MentorLake.Gio.GTlsCertificateHandle trusted_ca)
	{
		return GTlsCertificateHandleExterns.g_tls_certificate_verify(cert, identity, trusted_ca);
	}

}

internal class GTlsCertificateHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_file(string file, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_file_with_password(string file, string password, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_files(string cert_file, string key_file, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_pem(string data, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_pkcs11_uris(string pkcs11_uri, string private_key_pkcs11_uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_new_from_pkcs12(byte[] data, UIntPtr length, string password, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_tls_certificate_get_dns_names([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_tls_certificate_get_ip_addresses([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_certificate_get_issuer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_certificate_get_issuer_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_tls_certificate_get_not_valid_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GDateTimeHandle g_tls_certificate_get_not_valid_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_certificate_get_subject_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_certificate_is_same([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert_one, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert_two);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_tls_certificate_verify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle cert, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle identity, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle trusted_ca);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_tls_certificate_list_new_from_file(string file, out MentorLake.GLib.GErrorHandle error);

}
