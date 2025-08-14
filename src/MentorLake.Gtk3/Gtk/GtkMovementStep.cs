namespace MentorLake.Gtk;


[Flags]
public enum GtkMovementStep
{
/// <summary>
/// <para>
/// Move forward or back by graphemes
/// </para>
/// </summary>

	GTK_MOVEMENT_LOGICAL_POSITIONS = 0,
/// <summary>
/// <para>
/// Move left or right by graphemes
/// </para>
/// </summary>

	GTK_MOVEMENT_VISUAL_POSITIONS = 1,
/// <summary>
/// <para>
/// Move forward or back by words
/// </para>
/// </summary>

	GTK_MOVEMENT_WORDS = 2,
/// <summary>
/// <para>
/// Move up or down lines (wrapped lines)
/// </para>
/// </summary>

	GTK_MOVEMENT_DISPLAY_LINES = 3,
/// <summary>
/// <para>
/// Move to either end of a line
/// </para>
/// </summary>

	GTK_MOVEMENT_DISPLAY_LINE_ENDS = 4,
/// <summary>
/// <para>
/// Move up or down paragraphs (newline-ended lines)
/// </para>
/// </summary>

	GTK_MOVEMENT_PARAGRAPHS = 5,
/// <summary>
/// <para>
/// Move to either end of a paragraph
/// </para>
/// </summary>

	GTK_MOVEMENT_PARAGRAPH_ENDS = 6,
/// <summary>
/// <para>
/// Move by pages
/// </para>
/// </summary>

	GTK_MOVEMENT_PAGES = 7,
/// <summary>
/// <para>
/// Move to ends of the buffer
/// </para>
/// </summary>

	GTK_MOVEMENT_BUFFER_ENDS = 8,
/// <summary>
/// <para>
/// Move horizontally by pages
/// </para>
/// </summary>

	GTK_MOVEMENT_HORIZONTAL_PAGES = 9
}
