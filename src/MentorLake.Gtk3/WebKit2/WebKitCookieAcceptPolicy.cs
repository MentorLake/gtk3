namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the cookie acceptance policies.
/// </para>
/// </summary>

[Flags]
public enum WebKitCookieAcceptPolicy
{
/// <summary>
/// <para>
/// Accept all cookies unconditionally.
/// </para>
/// </summary>

	WEBKIT_COOKIE_POLICY_ACCEPT_ALWAYS = 0,
/// <summary>
/// <para>
/// Reject all cookies unconditionally.
/// </para>
/// </summary>

	WEBKIT_COOKIE_POLICY_ACCEPT_NEVER = 1,
/// <summary>
/// <para>
/// Accept only cookies set by the main document loaded.
/// </para>
/// </summary>

	WEBKIT_COOKIE_POLICY_ACCEPT_NO_THIRD_PARTY = 2
}
