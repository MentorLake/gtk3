namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Specifies where an object should be placed on the screen when using scroll_to.
/// </para>
/// </summary>

[Flags]
public enum AtkScrollType
{
/// <summary>
/// <para>
/// Scroll the object vertically and horizontally to bring
///   its top left corner to the top left corner of the window.
/// </para>
/// </summary>

	ATK_SCROLL_TOP_LEFT = 0,
/// <summary>
/// <para>
/// Scroll the object vertically and horizontally to
///   bring its bottom right corner to the bottom right corner of the window.
/// </para>
/// </summary>

	ATK_SCROLL_BOTTOM_RIGHT = 1,
/// <summary>
/// <para>
/// Scroll the object vertically to bring its top edge to
///   the top edge of the window.
/// </para>
/// </summary>

	ATK_SCROLL_TOP_EDGE = 2,
/// <summary>
/// <para>
/// Scroll the object vertically to bring its bottom
///   edge to the bottom edge of the window.
/// </para>
/// </summary>

	ATK_SCROLL_BOTTOM_EDGE = 3,
/// <summary>
/// <para>
/// Scroll the object vertically and horizontally to bring
///   its left edge to the left edge of the window.
/// </para>
/// </summary>

	ATK_SCROLL_LEFT_EDGE = 4,
/// <summary>
/// <para>
/// Scroll the object vertically and horizontally to
///   bring its right edge to the right edge of the window.
/// </para>
/// </summary>

	ATK_SCROLL_RIGHT_EDGE = 5,
/// <summary>
/// <para>
/// Scroll the object vertically and horizontally so that
///   as much as possible of the object becomes visible. The exact placement is
///   determined by the application.
/// </para>
/// </summary>

	ATK_SCROLL_ANYWHERE = 6
}
