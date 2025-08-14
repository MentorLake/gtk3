namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to indicate the direction in which an arrow should point.
/// </para>
/// </summary>

[Flags]
public enum GtkArrowType
{
/// <summary>
/// <para>
/// Represents an upward pointing arrow.
/// </para>
/// </summary>

	GTK_ARROW_UP = 0,
/// <summary>
/// <para>
/// Represents a downward pointing arrow.
/// </para>
/// </summary>

	GTK_ARROW_DOWN = 1,
/// <summary>
/// <para>
/// Represents a left pointing arrow.
/// </para>
/// </summary>

	GTK_ARROW_LEFT = 2,
/// <summary>
/// <para>
/// Represents a right pointing arrow.
/// </para>
/// </summary>

	GTK_ARROW_RIGHT = 3,
/// <summary>
/// <para>
/// No arrow. Since 2.10.
/// </para>
/// </summary>

	GTK_ARROW_NONE = 4
}
