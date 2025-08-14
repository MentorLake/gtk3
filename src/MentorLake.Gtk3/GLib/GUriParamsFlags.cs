namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags modifying the way parameters are handled by g_uri_parse_params() and
/// #GUriParamsIter.
/// </para>
/// </summary>

[Flags]
public enum GUriParamsFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_URI_PARAMS_NONE = 0,
/// <summary>
/// <para>
/// Parameter names are case insensitive.
/// </para>
/// </summary>

	G_URI_PARAMS_CASE_INSENSITIVE = 1,
/// <summary>
/// <para>
/// Replace `+` with space character. Only useful for
///     URLs on the web, using the `https` or `http` schemas.
/// </para>
/// </summary>

	G_URI_PARAMS_WWW_FORM = 2,
/// <summary>
/// <para>
/// See %G_URI_FLAGS_PARSE_RELAXED.
/// </para>
/// </summary>

	G_URI_PARAMS_PARSE_RELAXED = 4
}
