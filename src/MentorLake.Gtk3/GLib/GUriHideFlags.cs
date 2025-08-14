namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags describing what parts of the URI to hide in
/// g_uri_to_string_partial(). Note that %G_URI_HIDE_PASSWORD and
/// %G_URI_HIDE_AUTH_PARAMS will only work if the #GUri was parsed with
/// the corresponding flags.
/// </para>
/// </summary>

[Flags]
public enum GUriHideFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_URI_HIDE_NONE = 0,
/// <summary>
/// <para>
/// Hide the userinfo.
/// </para>
/// </summary>

	G_URI_HIDE_USERINFO = 1,
/// <summary>
/// <para>
/// Hide the password.
/// </para>
/// </summary>

	G_URI_HIDE_PASSWORD = 2,
/// <summary>
/// <para>
/// Hide the auth_params.
/// </para>
/// </summary>

	G_URI_HIDE_AUTH_PARAMS = 4,
/// <summary>
/// <para>
/// Hide the query.
/// </para>
/// </summary>

	G_URI_HIDE_QUERY = 8,
/// <summary>
/// <para>
/// Hide the fragment.
/// </para>
/// </summary>

	G_URI_HIDE_FRAGMENT = 16
}
