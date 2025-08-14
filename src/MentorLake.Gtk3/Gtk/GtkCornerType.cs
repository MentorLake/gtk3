namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Specifies which corner a child widget should be placed in when packed into
/// a #GtkScrolledWindow. This is effectively the opposite of where the scroll
/// bars are placed.
/// </para>
/// </summary>

[Flags]
public enum GtkCornerType
{
/// <summary>
/// <para>
/// Place the scrollbars on the right and bottom of the
///  widget (default behaviour).
/// </para>
/// </summary>

	GTK_CORNER_TOP_LEFT = 0,
/// <summary>
/// <para>
/// Place the scrollbars on the top and right of the
///  widget.
/// </para>
/// </summary>

	GTK_CORNER_BOTTOM_LEFT = 1,
/// <summary>
/// <para>
/// Place the scrollbars on the left and bottom of the
///  widget.
/// </para>
/// </summary>

	GTK_CORNER_TOP_RIGHT = 2,
/// <summary>
/// <para>
/// Place the scrollbars on the top and left of the
///  widget.
/// </para>
/// </summary>

	GTK_CORNER_BOTTOM_RIGHT = 3
}
