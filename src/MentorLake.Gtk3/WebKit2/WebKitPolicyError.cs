namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the various policy errors.
/// </para>
/// </summary>

[Flags]
public enum WebKitPolicyError
{
/// <summary>
/// <para>
/// Generic load failure due to policy error
/// </para>
/// </summary>

	WEBKIT_POLICY_ERROR_FAILED = 199,
/// <summary>
/// <para>
/// Load failure due to unsupported mime type
/// </para>
/// </summary>

	WEBKIT_POLICY_ERROR_CANNOT_SHOW_MIME_TYPE = 100,
/// <summary>
/// <para>
/// Load failure due to URI that can not be shown
/// </para>
/// </summary>

	WEBKIT_POLICY_ERROR_CANNOT_SHOW_URI = 101,
/// <summary>
/// <para>
/// Load failure due to frame load interruption by policy change
/// </para>
/// </summary>

	WEBKIT_POLICY_ERROR_FRAME_LOAD_INTERRUPTED_BY_POLICY_CHANGE = 102,
/// <summary>
/// <para>
/// Load failure due to port restriction
/// </para>
/// </summary>

	WEBKIT_POLICY_ERROR_CANNOT_USE_RESTRICTED_PORT = 103
}
