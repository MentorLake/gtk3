namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values representing query permission results.
/// </para>
/// </summary>

[Flags]
public enum WebKitPermissionState
{
/// <summary>
/// <para>
/// Access to the feature is granted.
/// </para>
/// </summary>

	WEBKIT_PERMISSION_STATE_GRANTED = 0,
/// <summary>
/// <para>
/// Access to the feature is denied.
/// </para>
/// </summary>

	WEBKIT_PERMISSION_STATE_DENIED = 1,
/// <summary>
/// <para>
/// Access to the feature has to be requested via user prompt.
/// </para>
/// </summary>

	WEBKIT_PERMISSION_STATE_PROMPT = 2
}
