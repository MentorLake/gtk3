namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Implements HTTP cookies, as described by
/// [RFC 6265](http://tools.ietf.org/html/rfc6265.txt).
/// </para>
/// <para>
/// To have a [class@Session] handle cookies for your appliction
/// automatically, use a [class@CookieJar].
/// </para>
/// <para>
/// @name and @value will be set for all cookies. If the cookie is
/// generated from a string that appears to have no name, then @name
/// will be the empty string.
/// </para>
/// <para>
/// @domain and @path give the host or domain, and path within that
/// host/domain, to restrict this cookie to. If @domain starts with
/// &quot;.&quot;, that indicates a domain (which matches the string after the
/// &quot;.&quot;, or any hostname that has @domain as a suffix). Otherwise, it
/// is a hostname and must match exactly.
/// </para>
/// <para>
/// @expires will be non-%NULL if the cookie uses either the original
/// &quot;expires&quot; attribute, or the newer &quot;max-age&quot; attribute. If @expires
/// is %NULL, it indicates that neither &quot;expires&quot; nor &quot;max-age&quot; was
/// specified, and the cookie expires at the end of the session.
/// </para>
/// <para>
/// If @http_only is set, the cookie should not be exposed to untrusted
/// code (eg, javascript), so as to minimize the danger posed by
/// cross-site scripting attacks.
/// </para>
/// </summary>

public class SoupCookieHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new [struct@Cookie] with the given attributes.
/// </para>
/// <para>
/// Use [method@Cookie.set_secure] and [method@Cookie.set_http_only] if you
/// need to set those attributes on the returned cookie.
/// </para>
/// <para>
/// If @domain starts with &quot;.&quot;, that indicates a domain (which matches
/// the string after the &quot;.&quot;, or any hostname that has @domain as a
/// suffix). Otherwise, it is a hostname and must match exactly.
/// </para>
/// <para>
/// @max_age is used to set the &quot;expires&quot; attribute on the cookie; pass
/// -1 to not include the attribute (indicating that the cookie expires
/// with the current session), 0 for an already-expired cookie, or a
/// lifetime in seconds. You can use the constants
/// %SOUP_COOKIE_MAX_AGE_ONE_HOUR, %SOUP_COOKIE_MAX_AGE_ONE_DAY,
/// %SOUP_COOKIE_MAX_AGE_ONE_WEEK and %SOUP_COOKIE_MAX_AGE_ONE_YEAR (or
/// multiples thereof) to calculate this value. (If you really care
/// about setting the exact time that the cookie will expire, use
/// [method@Cookie.set_expires].)
/// </para>
/// <para>
/// As of version 3.4.0 the default value of a cookie&apos;s same-site-policy
/// is %SOUP_SAME_SITE_POLICY_LAX.
/// </para>
/// </summary>

/// <param name="name">
/// cookie name
/// </param>
/// <param name="value">
/// cookie value
/// </param>
/// <param name="domain">
/// cookie domain or hostname
/// </param>
/// <param name="path">
/// cookie path, or %NULL
/// </param>
/// <param name="max_age">
/// max age of the cookie, or -1 for a session cookie
/// </param>
/// <return>
/// a new #SoupCookie.
/// </return>

	public static MentorLake.Soup.SoupCookieHandle New(string name, string value, string domain, string path, int max_age)
	{
		return SoupCookieExterns.soup_cookie_new(name, value, domain, path, max_age);
	}

}


public static class SoupCookieExtensions
{
/// <summary>
/// <para>
/// Tests if @cookie should be sent to @uri.
/// </para>
/// <para>
/// (At the moment, this does not check that @cookie&apos;s domain matches
/// @uri, because it assumes that the caller has already done that.
/// But don&apos;t rely on that; it may change in the future.)
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="uri">
/// a #GUri
/// </param>
/// <return>
/// %TRUE if @cookie should be sent to @uri, %FALSE if not
/// </return>

	public static bool AppliesToUri(this MentorLake.Soup.SoupCookieHandle cookie, MentorLake.GLib.GUriHandle uri)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_applies_to_uri(cookie, uri);
	}

/// <summary>
/// <para>
/// Copies @cookie.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// a copy of @cookie
/// </return>

	public static MentorLake.Soup.SoupCookieHandle Copy(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_copy(cookie);
	}

/// <summary>
/// <para>
/// Checks if the @cookie&apos;s domain and @host match.
/// </para>
/// <para>
/// The domains match if @cookie should be sent when making a request to @host,
/// or that @cookie should be accepted when receiving a response from @host.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="host">
/// a URI
/// </param>
/// <return>
/// %TRUE if the domains match, %FALSE otherwise
/// </return>

	public static bool DomainMatches(this MentorLake.Soup.SoupCookieHandle cookie, string host)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_domain_matches(cookie, host);
	}

/// <summary>
/// <para>
/// Tests if @cookie1 and @cookie2 are equal.
/// </para>
/// <para>
/// Note that currently, this does not check that the cookie domains
/// match. This may change in the future.
/// </para>
/// </summary>

/// <param name="cookie1">
/// a #SoupCookie
/// </param>
/// <param name="cookie2">
/// a #SoupCookie
/// </param>
/// <return>
/// whether the cookies are equal.
/// </return>

	public static bool Equal(this MentorLake.Soup.SoupCookieHandle cookie1, MentorLake.Soup.SoupCookieHandle cookie2)
	{
		if (cookie1.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_equal(cookie1, cookie2);
	}

/// <summary>
/// <para>
/// Frees @cookie.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>

	public static void Free(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_free(cookie);
	}

/// <summary>
/// <para>
/// Gets @cookie&apos;s domain.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// @cookie&apos;s domain
/// </return>

	public static string GetDomain(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_get_domain(cookie);
	}

/// <summary>
/// <para>
/// Gets @cookie&apos;s expiration time.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #GDateTime
/// </param>
/// <return>
/// @cookie&apos;s expiration time, which is
///   owned by @cookie and should not be modified or freed.
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetExpires(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_get_expires(cookie);
	}

/// <summary>
/// <para>
/// Gets @cookie&apos;s HttpOnly attribute.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// @cookie&apos;s HttpOnly attribute
/// </return>

	public static bool GetHttpOnly(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_get_http_only(cookie);
	}

/// <summary>
/// <para>
/// Gets @cookie&apos;s name.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// @cookie&apos;s name
/// </return>

	public static string GetName(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_get_name(cookie);
	}

/// <summary>
/// <para>
/// Gets @cookie&apos;s path.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// @cookie&apos;s path
/// </return>

	public static string GetPath(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_get_path(cookie);
	}

/// <summary>
/// <para>
/// Returns the same-site policy for this cookie.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// a #SoupSameSitePolicy
/// </return>

	public static MentorLake.Soup.SoupSameSitePolicy GetSameSitePolicy(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_get_same_site_policy(cookie);
	}

/// <summary>
/// <para>
/// Gets @cookie&apos;s secure attribute.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// @cookie&apos;s secure attribute
/// </return>

	public static bool GetSecure(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_get_secure(cookie);
	}

/// <summary>
/// <para>
/// Gets @cookie&apos;s value.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// @cookie&apos;s value
/// </return>

	public static string GetValue(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_get_value(cookie);
	}

/// <summary>
/// <para>
/// Sets @cookie&apos;s domain to @domain.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="domain">
/// the new domain
/// </param>

	public static void SetDomain(this MentorLake.Soup.SoupCookieHandle cookie, string domain)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_domain(cookie, domain);
	}

/// <summary>
/// <para>
/// Sets @cookie&apos;s expiration time to @expires.
/// </para>
/// <para>
/// If @expires is %NULL, @cookie will be a session cookie and will expire at the
/// end of the client&apos;s session.
/// </para>
/// <para>
/// (This sets the same property as [method@Cookie.set_max_age].)
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="expires">
/// the new expiration time, or %NULL
/// </param>

	public static void SetExpires(this MentorLake.Soup.SoupCookieHandle cookie, MentorLake.GLib.GDateTimeHandle expires)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_expires(cookie, expires);
	}

/// <summary>
/// <para>
/// Sets @cookie&apos;s HttpOnly attribute to @http_only.
/// </para>
/// <para>
/// If %TRUE, @cookie will be marked as &quot;http only&quot;, meaning it should not be
/// exposed to web page scripts or other untrusted code.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="http_only">
/// the new value for the HttpOnly attribute
/// </param>

	public static void SetHttpOnly(this MentorLake.Soup.SoupCookieHandle cookie, bool http_only)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_http_only(cookie, http_only);
	}

/// <summary>
/// <para>
/// Sets @cookie&apos;s max age to @max_age.
/// </para>
/// <para>
/// If @max_age is -1, the cookie is a session cookie, and will expire at the end
/// of the client&apos;s session. Otherwise, it is the number of seconds until the
/// cookie expires. You can use the constants %SOUP_COOKIE_MAX_AGE_ONE_HOUR,
/// %SOUP_COOKIE_MAX_AGE_ONE_DAY, %SOUP_COOKIE_MAX_AGE_ONE_WEEK and
/// %SOUP_COOKIE_MAX_AGE_ONE_YEAR (or multiples thereof) to calculate this value.
/// (A value of 0 indicates that the cookie should be considered
/// already-expired.)
/// </para>
/// <para>
/// This sets the same property as [method@Cookie.set_expires].
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="max_age">
/// the new max age
/// </param>

	public static void SetMaxAge(this MentorLake.Soup.SoupCookieHandle cookie, int max_age)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_max_age(cookie, max_age);
	}

/// <summary>
/// <para>
/// Sets @cookie&apos;s name to @name.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="name">
/// the new name
/// </param>

	public static void SetName(this MentorLake.Soup.SoupCookieHandle cookie, string name)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_name(cookie, name);
	}

/// <summary>
/// <para>
/// Sets @cookie&apos;s path to @path.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="path">
/// the new path
/// </param>

	public static void SetPath(this MentorLake.Soup.SoupCookieHandle cookie, string path)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_path(cookie, path);
	}

/// <summary>
/// <para>
/// When used in conjunction with
/// [method@CookieJar.get_cookie_list_with_same_site_info] this sets the policy
/// of when this cookie should be exposed.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="policy">
/// a #SoupSameSitePolicy
/// </param>

	public static void SetSameSitePolicy(this MentorLake.Soup.SoupCookieHandle cookie, MentorLake.Soup.SoupSameSitePolicy policy)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_same_site_policy(cookie, policy);
	}

/// <summary>
/// <para>
/// Sets @cookie&apos;s secure attribute to @secure.
/// </para>
/// <para>
/// If %TRUE, @cookie will only be transmitted from the client to the server over
/// secure (https) connections.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="secure">
/// the new value for the secure attribute
/// </param>

	public static void SetSecure(this MentorLake.Soup.SoupCookieHandle cookie, bool secure)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_secure(cookie, secure);
	}

/// <summary>
/// <para>
/// Sets @cookie&apos;s value to @value.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <param name="value">
/// the new value
/// </param>

	public static void SetValue(this MentorLake.Soup.SoupCookieHandle cookie, string value)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		SoupCookieExterns.soup_cookie_set_value(cookie, value);
	}

/// <summary>
/// <para>
/// Serializes @cookie in the format used by the Cookie header (ie, for
/// returning a cookie from a [class@Session] to a server).
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// the header
/// </return>

	public static string ToCookieHeader(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_to_cookie_header(cookie);
	}

/// <summary>
/// <para>
/// Serializes @cookie in the format used by the Set-Cookie header.
/// </para>
/// <para>
/// i.e. for sending a cookie from a [class@Server] to a client.
/// </para>
/// </summary>

/// <param name="cookie">
/// a #SoupCookie
/// </param>
/// <return>
/// the header
/// </return>

	public static string ToSetCookieHeader(this MentorLake.Soup.SoupCookieHandle cookie)
	{
		if (cookie.IsInvalid) throw new Exception("Invalid handle (SoupCookie)");
		return SoupCookieExterns.soup_cookie_to_set_cookie_header(cookie);
	}


	public static SoupCookie Dereference(this SoupCookieHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupCookie>(x.DangerousGetHandle());
}
internal class SoupCookieExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))]
	internal static extern MentorLake.Soup.SoupCookieHandle soup_cookie_new(string name, string value, string domain, string path, int max_age);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_cookie_applies_to_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))]
	internal static extern MentorLake.Soup.SoupCookieHandle soup_cookie_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_cookie_domain_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, string host);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_cookie_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie2);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_cookie_get_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle soup_cookie_get_expires([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_cookie_get_http_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_cookie_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_cookie_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupSameSitePolicy soup_cookie_get_same_site_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_cookie_get_secure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_cookie_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, string domain);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_expires([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle expires);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_http_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, bool http_only);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_max_age([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, int max_age);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, string name);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, string path);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_same_site_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, MentorLake.Soup.SoupSameSitePolicy policy);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_secure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, bool secure);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookie_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie, string value);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_cookie_to_cookie_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_cookie_to_set_cookie_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))] MentorLake.Soup.SoupCookieHandle cookie);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))]
	internal static extern MentorLake.Soup.SoupCookieHandle soup_cookie_parse(string header, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle origin);

}

/// <summary>
/// <para>
/// Implements HTTP cookies, as described by
/// [RFC 6265](http://tools.ietf.org/html/rfc6265.txt).
/// </para>
/// <para>
/// To have a [class@Session] handle cookies for your appliction
/// automatically, use a [class@CookieJar].
/// </para>
/// <para>
/// @name and @value will be set for all cookies. If the cookie is
/// generated from a string that appears to have no name, then @name
/// will be the empty string.
/// </para>
/// <para>
/// @domain and @path give the host or domain, and path within that
/// host/domain, to restrict this cookie to. If @domain starts with
/// &quot;.&quot;, that indicates a domain (which matches the string after the
/// &quot;.&quot;, or any hostname that has @domain as a suffix). Otherwise, it
/// is a hostname and must match exactly.
/// </para>
/// <para>
/// @expires will be non-%NULL if the cookie uses either the original
/// &quot;expires&quot; attribute, or the newer &quot;max-age&quot; attribute. If @expires
/// is %NULL, it indicates that neither &quot;expires&quot; nor &quot;max-age&quot; was
/// specified, and the cookie expires at the end of the session.
/// </para>
/// <para>
/// If @http_only is set, the cookie should not be exposed to untrusted
/// code (eg, javascript), so as to minimize the danger posed by
/// cross-site scripting attacks.
/// </para>
/// </summary>

public struct SoupCookie
{
/// <summary>
/// <para>
/// Parses @header and returns a [struct@Cookie].
/// </para>
/// <para>
/// If @header contains multiple cookies, only the first one will be parsed.
/// </para>
/// <para>
/// If @header does not have &quot;path&quot; or &quot;domain&quot; attributes, they will
/// be defaulted from @origin. If @origin is %NULL, path will default
/// to &quot;/&quot;, but domain will be left as %NULL. Note that this is not a
/// valid state for a [struct@Cookie], and you will need to fill in some
/// appropriate string for the domain if you want to actually make use
/// of the cookie.
/// </para>
/// <para>
/// As of version 3.4.0 the default value of a cookie&apos;s same-site-policy
/// is %SOUP_SAME_SITE_POLICY_LAX.
/// </para>
/// </summary>

/// <param name="header">
/// a cookie string (eg, the value of a Set-Cookie header)
/// </param>
/// <param name="origin">
/// origin of the cookie
/// </param>
/// <return>
/// a new #SoupCookie, or %NULL if it could
///   not be parsed, or contained an illegal &quot;domain&quot; attribute for a
///   cookie originating from @origin.
/// </return>

	public static MentorLake.Soup.SoupCookieHandle Parse(string header, MentorLake.GLib.GUriHandle origin)
	{
		return SoupCookieExterns.soup_cookie_parse(header, origin);
	}

}
