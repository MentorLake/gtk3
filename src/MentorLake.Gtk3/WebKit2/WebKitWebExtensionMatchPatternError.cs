namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote errors happening when creating a #WebKitWebExtensionMatchPattern
/// </para>
/// </summary>

[Flags]
public enum WebKitWebExtensionMatchPatternError
{
/// <summary>
/// <para>
/// An unknown error occured.
/// </para>
/// </summary>

	WEBKIT_WEB_EXTENSION_MATCH_PATTERN_ERROR_UNKNOWN = 899,
/// <summary>
/// <para>
/// The scheme component was invalid.
/// </para>
/// </summary>

	WEBKIT_WEB_EXTENSION_MATCH_PATTERN_ERROR_INVALID_SCHEME = 808,
/// <summary>
/// <para>
/// The host component was invalid.
/// </para>
/// </summary>

	WEBKIT_WEB_EXTENSION_MATCH_PATTERN_ERROR_INVALID_HOST = 809,
/// <summary>
/// <para>
/// The path component was invalid.
/// </para>
/// </summary>

	WEBKIT_WEB_EXTENSION_MATCH_PATTERN_ERROR_INVALID_PATH = 810
}
