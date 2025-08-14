namespace MentorLake.Gtk;


[Flags]
public enum GtkResizeMode
{
/// <summary>
/// <para>
/// Pass resize request to the parent
/// </para>
/// </summary>

	GTK_RESIZE_PARENT = 0,
/// <summary>
/// <para>
/// Queue resizes on this widget
/// </para>
/// </summary>

	GTK_RESIZE_QUEUE = 1,
/// <summary>
/// <para>
/// Resize immediately. Deprecated.
/// </para>
/// </summary>

	GTK_RESIZE_IMMEDIATE = 2
}
