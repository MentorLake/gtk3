namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Groups information used for user authentication.
/// </para>
/// </summary>

public class WebKitCredentialHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new credential from the provided username, password and persistence mode.
/// </para>
/// </summary>

/// <param name="username">
/// The username for the new credential
/// </param>
/// <param name="password">
/// The password for the new credential
/// </param>
/// <param name="persistence">
/// The #WebKitCredentialPersistence of the new credential
/// </param>
/// <return>
/// A #WebKitCredential.
/// </return>

	public static MentorLake.WebKit2.WebKitCredentialHandle New(string username, string password, MentorLake.WebKit2.WebKitCredentialPersistence persistence)
	{
		return WebKitCredentialExterns.webkit_credential_new(username, password, persistence);
	}

/// <summary>
/// <para>
/// Create a new credential from the @certificate and persistence mode.
/// </para>
/// <para>
/// Note that %WEBKIT_CREDENTIAL_PERSISTENCE_PERMANENT is not supported for certificate credentials.
/// </para>
/// </summary>

/// <param name="certificate">
/// The #GTlsCertificate, or %NULL
/// </param>
/// <param name="persistence">
/// The #WebKitCredentialPersistence of the new credential
/// </param>
/// <return>
/// A #WebKitCredential.
/// </return>

	public static MentorLake.WebKit2.WebKitCredentialHandle NewForCertificate(MentorLake.Gio.GTlsCertificateHandle certificate, MentorLake.WebKit2.WebKitCredentialPersistence persistence)
	{
		return WebKitCredentialExterns.webkit_credential_new_for_certificate(certificate, persistence);
	}

/// <summary>
/// <para>
/// Create a new credential from the provided PIN and persistence mode.
/// </para>
/// <para>
/// Note that %WEBKIT_CREDENTIAL_PERSISTENCE_PERMANENT is not supported for certificate pin credentials.
/// </para>
/// </summary>

/// <param name="pin">
/// The PIN for the new credential
/// </param>
/// <param name="persistence">
/// The #WebKitCredentialPersistence of the new credential
/// </param>
/// <return>
/// A #WebKitCredential.
/// </return>

	public static MentorLake.WebKit2.WebKitCredentialHandle NewForCertificatePin(string pin, MentorLake.WebKit2.WebKitCredentialPersistence persistence)
	{
		return WebKitCredentialExterns.webkit_credential_new_for_certificate_pin(pin, persistence);
	}

}


public static class WebKitCredentialExtensions
{
/// <summary>
/// <para>
/// Make a copy of the #WebKitCredential.
/// </para>
/// </summary>

/// <param name="credential">
/// a #WebKitCredential
/// </param>
/// <return>
/// A copy of passed in #WebKitCredential
/// </return>

	public static MentorLake.WebKit2.WebKitCredentialHandle Copy(this MentorLake.WebKit2.WebKitCredentialHandle credential)
	{
		if (credential.IsInvalid) throw new Exception("Invalid handle (WebKitCredential)");
		return WebKitCredentialExterns.webkit_credential_copy(credential);
	}

/// <summary>
/// <para>
/// Free the #WebKitCredential.
/// </para>
/// </summary>

/// <param name="credential">
/// A #WebKitCredential
/// </param>

	public static void Free(this MentorLake.WebKit2.WebKitCredentialHandle credential)
	{
		if (credential.IsInvalid) throw new Exception("Invalid handle (WebKitCredential)");
		WebKitCredentialExterns.webkit_credential_free(credential);
	}

/// <summary>
/// <para>
/// Get the certificate currently held by this #WebKitCredential.
/// </para>
/// </summary>

/// <param name="credential">
/// a #WebKitCredential
/// </param>
/// <return>
/// a #GTlsCertificate, or %NULL
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetCertificate(this MentorLake.WebKit2.WebKitCredentialHandle credential)
	{
		if (credential.IsInvalid) throw new Exception("Invalid handle (WebKitCredential)");
		return WebKitCredentialExterns.webkit_credential_get_certificate(credential);
	}

/// <summary>
/// <para>
/// Get the password currently held by this #WebKitCredential.
/// </para>
/// </summary>

/// <param name="credential">
/// a #WebKitCredential
/// </param>
/// <return>
/// The password stored in the #WebKitCredential.
/// </return>

	public static string GetPassword(this MentorLake.WebKit2.WebKitCredentialHandle credential)
	{
		if (credential.IsInvalid) throw new Exception("Invalid handle (WebKitCredential)");
		return WebKitCredentialExterns.webkit_credential_get_password(credential);
	}

/// <summary>
/// <para>
/// Get the persistence mode currently held by this #WebKitCredential.
/// </para>
/// </summary>

/// <param name="credential">
/// a #WebKitCredential
/// </param>
/// <return>
/// The #WebKitCredentialPersistence stored in the #WebKitCredential.
/// </return>

	public static MentorLake.WebKit2.WebKitCredentialPersistence GetPersistence(this MentorLake.WebKit2.WebKitCredentialHandle credential)
	{
		if (credential.IsInvalid) throw new Exception("Invalid handle (WebKitCredential)");
		return WebKitCredentialExterns.webkit_credential_get_persistence(credential);
	}

/// <summary>
/// <para>
/// Get the username currently held by this #WebKitCredential.
/// </para>
/// </summary>

/// <param name="credential">
/// a #WebKitCredential
/// </param>
/// <return>
/// The username stored in the #WebKitCredential.
/// </return>

	public static string GetUsername(this MentorLake.WebKit2.WebKitCredentialHandle credential)
	{
		if (credential.IsInvalid) throw new Exception("Invalid handle (WebKitCredential)");
		return WebKitCredentialExterns.webkit_credential_get_username(credential);
	}

/// <summary>
/// <para>
/// Determine whether this credential has a password stored.
/// </para>
/// </summary>

/// <param name="credential">
/// a #WebKitCredential
/// </param>
/// <return>
/// %TRUE if the credential has a password or %FALSE otherwise.
/// </return>

	public static bool HasPassword(this MentorLake.WebKit2.WebKitCredentialHandle credential)
	{
		if (credential.IsInvalid) throw new Exception("Invalid handle (WebKitCredential)");
		return WebKitCredentialExterns.webkit_credential_has_password(credential);
	}


	public static WebKitCredential Dereference(this WebKitCredentialHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitCredential>(x.DangerousGetHandle());
}
internal class WebKitCredentialExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))]
	internal static extern MentorLake.WebKit2.WebKitCredentialHandle webkit_credential_new(string username, string password, MentorLake.WebKit2.WebKitCredentialPersistence persistence);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))]
	internal static extern MentorLake.WebKit2.WebKitCredentialHandle webkit_credential_new_for_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, MentorLake.WebKit2.WebKitCredentialPersistence persistence);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))]
	internal static extern MentorLake.WebKit2.WebKitCredentialHandle webkit_credential_new_for_certificate_pin(string pin, MentorLake.WebKit2.WebKitCredentialPersistence persistence);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))]
	internal static extern MentorLake.WebKit2.WebKitCredentialHandle webkit_credential_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_credential_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle webkit_credential_get_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_credential_get_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitCredentialPersistence webkit_credential_get_persistence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_credential_get_username([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_credential_has_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitCredentialHandle>))] MentorLake.WebKit2.WebKitCredentialHandle credential);

}

/// <summary>
/// <para>
/// Groups information used for user authentication.
/// </para>
/// </summary>

public struct WebKitCredential
{
}
