namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the visiblity status of a window for a #GdkEventVisibility.
/// </para>
/// </summary>

[Flags]
public enum GdkVisibilityState
{
/// <summary>
/// <para>
/// the window is completely visible.
/// </para>
/// </summary>

	GDK_VISIBILITY_UNOBSCURED = 0,
/// <summary>
/// <para>
/// the window is partially visible.
/// </para>
/// </summary>

	GDK_VISIBILITY_PARTIAL = 1,
/// <summary>
/// <para>
/// the window is not visible at all.
/// </para>
/// </summary>

	GDK_VISIBILITY_FULLY_OBSCURED = 2
}
