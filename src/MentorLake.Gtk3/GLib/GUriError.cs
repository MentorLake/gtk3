namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by #GUri methods.
/// </para>
/// </summary>

[Flags]
public enum GUriError
{
/// <summary>
/// <para>
/// Generic error if no more specific error is available.
///     See the error message for details.
/// </para>
/// </summary>

	G_URI_ERROR_FAILED = 0,
/// <summary>
/// <para>
/// The scheme of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_SCHEME = 1,
/// <summary>
/// <para>
/// The user/userinfo of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_USER = 2,
/// <summary>
/// <para>
/// The password of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_PASSWORD = 3,
/// <summary>
/// <para>
/// The authentication parameters of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_AUTH_PARAMS = 4,
/// <summary>
/// <para>
/// The host of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_HOST = 5,
/// <summary>
/// <para>
/// The port of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_PORT = 6,
/// <summary>
/// <para>
/// The path of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_PATH = 7,
/// <summary>
/// <para>
/// The query of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_QUERY = 8,
/// <summary>
/// <para>
/// The fragment of a URI could not be parsed.
/// </para>
/// </summary>

	G_URI_ERROR_BAD_FRAGMENT = 9
}
