namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values representing the authentication scheme.
/// </para>
/// </summary>

[Flags]
public enum WebKitAuthenticationScheme
{
/// <summary>
/// <para>
/// The default authentication scheme of WebKit.
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_DEFAULT = 1,
/// <summary>
/// <para>
/// Basic authentication scheme as defined in RFC 2617.
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_HTTP_BASIC = 2,
/// <summary>
/// <para>
/// Digest authentication scheme as defined in RFC 2617.
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_HTTP_DIGEST = 3,
/// <summary>
/// <para>
/// HTML Form authentication.
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_HTML_FORM = 4,
/// <summary>
/// <para>
/// NTLM Microsoft proprietary authentication scheme.
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_NTLM = 5,
/// <summary>
/// <para>
/// Negotiate (or SPNEGO) authentication scheme as defined in RFC 4559.
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_NEGOTIATE = 6,
/// <summary>
/// <para>
/// Client Certificate Authentication (see RFC 2246).
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_CLIENT_CERTIFICATE_REQUESTED = 7,
/// <summary>
/// <para>
/// Server Trust Authentication.
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_SERVER_TRUST_EVALUATION_REQUESTED = 8,
/// <summary>
/// <para>
/// Client certificate PIN required for use. Since: 2.34
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_CLIENT_CERTIFICATE_PIN_REQUESTED = 9,
/// <summary>
/// <para>
/// Authentication scheme unknown.
/// </para>
/// </summary>

	WEBKIT_AUTHENTICATION_SCHEME_UNKNOWN = 100
}
