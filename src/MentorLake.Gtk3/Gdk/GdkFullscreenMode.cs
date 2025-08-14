namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Indicates which monitor (in a multi-head setup) a window should span over
/// when in fullscreen mode.
/// </para>
/// </summary>

[Flags]
public enum GdkFullscreenMode
{
/// <summary>
/// <para>
/// Fullscreen on current monitor only.
/// </para>
/// </summary>

	GDK_FULLSCREEN_ON_CURRENT_MONITOR = 0,
/// <summary>
/// <para>
/// Span across all monitors when fullscreen.
/// </para>
/// </summary>

	GDK_FULLSCREEN_ON_ALL_MONITORS = 1
}
