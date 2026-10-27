namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to specify the capture state of a media device.
/// </para>
/// </summary>

[Flags]
public enum WebKitMediaCaptureState
{
/// <summary>
/// <para>
/// Media capture is disabled.
/// </para>
/// </summary>

	WEBKIT_MEDIA_CAPTURE_STATE_NONE = 0,
/// <summary>
/// <para>
/// Media capture is active.
/// </para>
/// </summary>

	WEBKIT_MEDIA_CAPTURE_STATE_ACTIVE = 1,
/// <summary>
/// <para>
/// Media capture is muted.
/// </para>
/// </summary>

	WEBKIT_MEDIA_CAPTURE_STATE_MUTED = 2
}
