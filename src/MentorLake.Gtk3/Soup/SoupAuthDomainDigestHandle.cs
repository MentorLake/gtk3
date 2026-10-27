namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Server-side &quot;Digest&quot; authentication.
/// </para>
/// <para>
/// [class@AuthDomainDigest] handles the server side of HTTP &quot;Digest&quot;
/// authentication.
/// </para>
/// </summary>

public class SoupAuthDomainDigestHandle : SoupAuthDomainHandle
{
/// <summary>
/// <para>
/// Creates a [class@AuthDomainDigest].
/// </para>
/// <para>
/// You must set the [property@AuthDomain:realm] property, to indicate the realm name to
/// be returned with the authentication challenge to the client. Other parameters
/// are optional.
/// </para>
/// </summary>

/// <param name="optname1">
/// name of first option, or %NULL
/// </param>
/// <param name="@__arglist">
/// option name/value pairs
/// </param>
/// <return>
/// the new #SoupAuthDomain
/// </return>

	public static MentorLake.Soup.SoupAuthDomainDigestHandle New(string optname1, IntPtr @__arglist)
	{
		return SoupAuthDomainDigestHandleExterns.soup_auth_domain_digest_new(optname1, @__arglist);
	}

/// <summary>
/// <para>
/// Encodes the username/realm/password triplet for Digest
/// authentication.
/// </para>
/// <para>
/// That is, it returns a stringified MD5 hash of
/// @username, @realm, and @password concatenated together. This is
/// the form that is needed as the return value of
/// [class@AuthDomainDigest]&apos;s auth handler.
/// </para>
/// <para>
/// For security reasons, you should store the encoded hash, rather
/// than storing the cleartext password itself and calling this method
/// only when you need to verify it. This way, if your server is
/// compromised, the attackers will not gain access to cleartext
/// passwords which might also be usable at other sites. (Note also
/// that the encoded password returned by this method is identical to
/// the encoded password stored in an Apache .htdigest file.)
/// </para>
/// </summary>

/// <param name="username">
/// a username
/// </param>
/// <param name="realm">
/// an auth realm name
/// </param>
/// <param name="password">
/// the password for @username in @realm
/// </param>
/// <return>
/// the encoded password
/// </return>

	public static string EncodePassword(string username, string realm, string password)
	{
		return SoupAuthDomainDigestHandleExterns.soup_auth_domain_digest_encode_password(username, realm, password);
	}

}

public static class SoupAuthDomainDigestHandleExtensions
{
/// <summary>
/// <para>
/// Sets the callback that @domain will use to authenticate incoming
/// requests.
/// </para>
/// <para>
/// For each request containing authorization, @domain will
/// invoke the callback, and then either accept or reject the request
/// based on @callback&apos;s return value.
/// </para>
/// <para>
/// You can also set the auth callback by setting the
/// [property@AuthDomainDigest:auth-callback] and
/// [property@AuthDomainDigest:auth-data] properties, which can also be used to
/// set the callback at construct time.
/// </para>
/// </summary>

/// <param name="domain">
/// the domain
/// </param>
/// <param name="callback">
/// the callback
/// </param>
/// <param name="user_data">
/// data to pass to @auth_callback
/// </param>
/// <param name="dnotify">
/// destroy notifier to free @user_data when @domain
///   is destroyed
/// </param>

	public static T SetAuthCallback<T>(this T domain, MentorLake.Soup.SoupAuthDomainDigestAuthCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify dnotify) where T : SoupAuthDomainDigestHandle
	{
		if (domain.IsInvalid) throw new Exception("Invalid handle (SoupAuthDomainDigestHandle)");
		SoupAuthDomainDigestHandleExterns.soup_auth_domain_digest_set_auth_callback(domain, callback, user_data, dnotify);
		return domain;
	}

}

internal class SoupAuthDomainDigestHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainDigestHandle>))]
	internal static extern MentorLake.Soup.SoupAuthDomainDigestHandle soup_auth_domain_digest_new(string optname1, IntPtr @__arglist);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_domain_digest_set_auth_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle domain, MentorLake.Soup.SoupAuthDomainDigestAuthCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify dnotify);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_auth_domain_digest_encode_password(string username, string realm, string password);

}
