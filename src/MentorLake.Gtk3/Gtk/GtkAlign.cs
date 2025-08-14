namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Controls how a widget deals with extra space in a single (x or y)
/// dimension.
/// </para>
/// <para>
/// Alignment only matters if the widget receives a “too large” allocation,
/// for example if you packed the widget with the #GtkWidget:expand
/// flag inside a #GtkBox, then the widget might get extra space.  If
/// you have for example a 16x16 icon inside a 32x32 space, the icon
/// could be scaled and stretched, it could be centered, or it could be
/// positioned to one side of the space.
/// </para>
/// <para>
/// Note that in horizontal context @GTK_ALIGN_START and @GTK_ALIGN_END
/// are interpreted relative to text direction.
/// </para>
/// <para>
/// GTK_ALIGN_BASELINE support for it is optional for containers and widgets, and
/// it is only supported for vertical alignment.  When its not supported by
/// a child or a container it is treated as @GTK_ALIGN_FILL.
/// </para>
/// </summary>

[Flags]
public enum GtkAlign
{
/// <summary>
/// <para>
/// stretch to fill all space if possible, center if
///     no meaningful way to stretch
/// </para>
/// </summary>

	GTK_ALIGN_FILL = 0,
/// <summary>
/// <para>
/// snap to left or top side, leaving space on right
///     or bottom
/// </para>
/// </summary>

	GTK_ALIGN_START = 1,
/// <summary>
/// <para>
/// snap to right or bottom side, leaving space on left
///     or top
/// </para>
/// </summary>

	GTK_ALIGN_END = 2,
/// <summary>
/// <para>
/// center natural width of widget inside the
///     allocation
/// </para>
/// </summary>

	GTK_ALIGN_CENTER = 3,
/// <summary>
/// <para>
/// align the widget according to the baseline. Since 3.10.
/// </para>
/// </summary>

	GTK_ALIGN_BASELINE = 4
}
