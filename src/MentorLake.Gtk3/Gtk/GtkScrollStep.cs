namespace MentorLake.Gtk;


[Flags]
public enum GtkScrollStep
{
/// <summary>
/// <para>
/// Scroll in steps.
/// </para>
/// </summary>

	GTK_SCROLL_STEPS = 0,
/// <summary>
/// <para>
/// Scroll by pages.
/// </para>
/// </summary>

	GTK_SCROLL_PAGES = 1,
/// <summary>
/// <para>
/// Scroll to ends.
/// </para>
/// </summary>

	GTK_SCROLL_ENDS = 2,
/// <summary>
/// <para>
/// Scroll in horizontal steps.
/// </para>
/// </summary>

	GTK_SCROLL_HORIZONTAL_STEPS = 3,
/// <summary>
/// <para>
/// Scroll by horizontal pages.
/// </para>
/// </summary>

	GTK_SCROLL_HORIZONTAL_PAGES = 4,
/// <summary>
/// <para>
/// Scroll to the horizontal ends.
/// </para>
/// </summary>

	GTK_SCROLL_HORIZONTAL_ENDS = 5
}
