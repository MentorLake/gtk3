namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes how the border of a UI element should be rendered.
/// </para>
/// </summary>

[Flags]
public enum GtkBorderStyle
{
/// <summary>
/// <para>
/// No visible border
/// </para>
/// </summary>

	GTK_BORDER_STYLE_NONE = 0,
/// <summary>
/// <para>
/// A single line segment
/// </para>
/// </summary>

	GTK_BORDER_STYLE_SOLID = 1,
/// <summary>
/// <para>
/// Looks as if the content is sunken into the canvas
/// </para>
/// </summary>

	GTK_BORDER_STYLE_INSET = 2,
/// <summary>
/// <para>
/// Looks as if the content is coming out of the canvas
/// </para>
/// </summary>

	GTK_BORDER_STYLE_OUTSET = 3,
/// <summary>
/// <para>
/// Same as @GTK_BORDER_STYLE_NONE
/// </para>
/// </summary>

	GTK_BORDER_STYLE_HIDDEN = 4,
/// <summary>
/// <para>
/// A series of round dots
/// </para>
/// </summary>

	GTK_BORDER_STYLE_DOTTED = 5,
/// <summary>
/// <para>
/// A series of square-ended dashes
/// </para>
/// </summary>

	GTK_BORDER_STYLE_DASHED = 6,
/// <summary>
/// <para>
/// Two parallel lines with some space between them
/// </para>
/// </summary>

	GTK_BORDER_STYLE_DOUBLE = 7,
/// <summary>
/// <para>
/// Looks as if it were carved in the canvas
/// </para>
/// </summary>

	GTK_BORDER_STYLE_GROOVE = 8,
/// <summary>
/// <para>
/// Looks as if it were coming out of the canvas
/// </para>
/// </summary>

	GTK_BORDER_STYLE_RIDGE = 9
}
