namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The policy for accepting or rejecting cookies returned in
/// responses.
/// </para>
/// </summary>

[Flags]
public enum SoupCookieJarAcceptPolicy
{
/// <summary>
/// <para>
/// accept all cookies unconditionally.
/// </para>
/// </summary>

	SOUP_COOKIE_JAR_ACCEPT_ALWAYS = 0,
/// <summary>
/// <para>
/// reject all cookies unconditionally.
/// </para>
/// </summary>

	SOUP_COOKIE_JAR_ACCEPT_NEVER = 1,
/// <summary>
/// <para>
/// accept all cookies set by the main
///   document loaded in the application using libsoup. An example of the most
///   common case, web browsers, would be: If http://www.example.com is the page
///   loaded, accept all cookies set by example.com, but if a resource from
///   http://www.third-party.com is loaded from that page reject any cookie that
///   it could try to set. For libsoup to be able to tell apart first party
///   cookies from the rest, the application must call
///   [method@Message.set_first_party] on each outgoing [class@Message], setting
///   the [struct@GLib.Uri] of the main document. If no first party is set in a
///   message when this policy is in effect, cookies will be assumed to be third
///   party by default.
/// </para>
/// </summary>

	SOUP_COOKIE_JAR_ACCEPT_NO_THIRD_PARTY = 2,
/// <summary>
/// <para>
/// accept all cookies set by
///   the main document loaded in the application using libsoup, and from domains
///   that have previously set at least one cookie when loaded as the main
///   document. An example of the most common case, web browsers, would be: if
///   http://www.example.com is the page loaded, accept all cookies set by
///   example.com, but if a resource from http://www.third-party.com is loaded
///   from that page, reject any cookie that it could try to set unless it
///   already has a cookie in the cookie jar. For libsoup to be able to tell
///   apart first party cookies from the rest, the application must call
///   [method@Message.set_first_party] on each outgoing [class@Message], setting the
///   [struct@GLib.Uri] of the main document. If no first party is set in a
///   message when this policy is in effect, cookies will be assumed to be third
///   party by default.
/// </para>
/// </summary>

	SOUP_COOKIE_JAR_ACCEPT_GRANDFATHERED_THIRD_PARTY = 3
}
