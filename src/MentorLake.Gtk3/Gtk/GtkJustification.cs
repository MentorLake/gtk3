namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used for justifying the text inside a #GtkLabel widget. (See also
/// #GtkAlignment).
/// </para>
/// </summary>

[Flags]
public enum GtkJustification
{
/// <summary>
/// <para>
/// The text is placed at the left edge of the label.
/// </para>
/// </summary>

	GTK_JUSTIFY_LEFT = 0,
/// <summary>
/// <para>
/// The text is placed at the right edge of the label.
/// </para>
/// </summary>

	GTK_JUSTIFY_RIGHT = 1,
/// <summary>
/// <para>
/// The text is placed in the center of the label.
/// </para>
/// </summary>

	GTK_JUSTIFY_CENTER = 2,
/// <summary>
/// <para>
/// The text is placed is distributed across the label.
/// </para>
/// </summary>

	GTK_JUSTIFY_FILL = 3
}
