namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Error codes for %SOUP_TLD_ERROR.
/// </para>
/// </summary>

[Flags]
public enum SoupTLDError
{
/// <summary>
/// <para>
/// A hostname was syntactically
///   invalid.
/// </para>
/// </summary>

	SOUP_TLD_ERROR_INVALID_HOSTNAME = 0,
/// <summary>
/// <para>
/// The passed-in &quot;hostname&quot; was
///   actually an IP address (and thus has no base domain or
///   public suffix).
/// </para>
/// </summary>

	SOUP_TLD_ERROR_IS_IP_ADDRESS = 1,
/// <summary>
/// <para>
/// The passed-in hostname
///   did not have enough components. Eg, calling
///   [func@tld_get_base_domain] on &amp;lt;literal&amp;gt;&quot;co.uk&quot;&amp;lt;/literal&amp;gt;.
/// </para>
/// </summary>

	SOUP_TLD_ERROR_NOT_ENOUGH_DOMAINS = 2,
/// <summary>
/// <para>
/// The passed-in hostname has
///   no recognized public suffix.
/// </para>
/// </summary>

	SOUP_TLD_ERROR_NO_BASE_DOMAIN = 3,
/// <summary>
/// <para>
/// The Public Suffix List was not
///   available.
/// </para>
/// </summary>

	SOUP_TLD_ERROR_NO_PSL_DATA = 4
}
