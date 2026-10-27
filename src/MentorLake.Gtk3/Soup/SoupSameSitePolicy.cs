namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Represents the same-site policies of a cookie.
/// </para>
/// </summary>

[Flags]
public enum SoupSameSitePolicy
{
/// <summary>
/// <para>
/// The cookie is exposed with both cross-site and same-site requests
/// </para>
/// </summary>

	SOUP_SAME_SITE_POLICY_NONE = 0,
/// <summary>
/// <para>
/// The cookie is withheld on cross-site requests but exposed on cross-site navigations
/// </para>
/// </summary>

	SOUP_SAME_SITE_POLICY_LAX = 1,
/// <summary>
/// <para>
/// The cookie is only exposed for same-site requests
/// </para>
/// </summary>

	SOUP_SAME_SITE_POLICY_STRICT = 2
}
