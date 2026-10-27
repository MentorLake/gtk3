namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to specify autoplay policies.
/// </para>
/// </summary>

[Flags]
public enum WebKitAutoplayPolicy
{
/// <summary>
/// <para>
/// Do not restrict autoplay.
/// </para>
/// </summary>

	WEBKIT_AUTOPLAY_ALLOW = 0,
/// <summary>
/// <para>
/// Allow videos to autoplay if
///     they have no audio track, or if their audio track is muted.
/// </para>
/// </summary>

	WEBKIT_AUTOPLAY_ALLOW_WITHOUT_SOUND = 1,
/// <summary>
/// <para>
/// Never allow autoplay.
/// </para>
/// </summary>

	WEBKIT_AUTOPLAY_DENY = 2
}
