namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Enum values passed to [func@uri_copy] to indicate the components of
/// the URI that should be updated with the given values.
/// </para>
/// </summary>

[Flags]
public enum SoupURIComponent
{
/// <summary>
/// <para>
/// no component
/// </para>
/// </summary>

	SOUP_URI_NONE = 0,
/// <summary>
/// <para>
/// the URI scheme component
/// </para>
/// </summary>

	SOUP_URI_SCHEME = 1,
/// <summary>
/// <para>
/// the URI user component
/// </para>
/// </summary>

	SOUP_URI_USER = 2,
/// <summary>
/// <para>
/// the URI password component
/// </para>
/// </summary>

	SOUP_URI_PASSWORD = 3,
/// <summary>
/// <para>
/// the URI authentication parameters component
/// </para>
/// </summary>

	SOUP_URI_AUTH_PARAMS = 4,
/// <summary>
/// <para>
/// the URI host component
/// </para>
/// </summary>

	SOUP_URI_HOST = 5,
/// <summary>
/// <para>
/// the URI port component
/// </para>
/// </summary>

	SOUP_URI_PORT = 6,
/// <summary>
/// <para>
/// the URI path component
/// </para>
/// </summary>

	SOUP_URI_PATH = 7,
/// <summary>
/// <para>
/// the URI query component
/// </para>
/// </summary>

	SOUP_URI_QUERY = 8,
/// <summary>
/// <para>
/// the URI fragment component
/// </para>
/// </summary>

	SOUP_URI_FRAGMENT = 9
}
