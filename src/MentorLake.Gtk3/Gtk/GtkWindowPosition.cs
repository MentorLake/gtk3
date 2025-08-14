namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Window placement can be influenced using this enumeration. Note that
/// using #GTK_WIN_POS_CENTER_ALWAYS is almost always a bad idea.
/// It won’t necessarily work well with all window managers or on all windowing systems.
/// </para>
/// </summary>

[Flags]
public enum GtkWindowPosition
{
/// <summary>
/// <para>
/// No influence is made on placement.
/// </para>
/// </summary>

	GTK_WIN_POS_NONE = 0,
/// <summary>
/// <para>
/// Windows should be placed in the center of the screen.
/// </para>
/// </summary>

	GTK_WIN_POS_CENTER = 1,
/// <summary>
/// <para>
/// Windows should be placed at the current mouse position.
/// </para>
/// </summary>

	GTK_WIN_POS_MOUSE = 2,
/// <summary>
/// <para>
/// Keep window centered as it changes size, etc.
/// </para>
/// </summary>

	GTK_WIN_POS_CENTER_ALWAYS = 3,
/// <summary>
/// <para>
/// Center the window on its transient
///  parent (see gtk_window_set_transient_for()).
/// </para>
/// </summary>

	GTK_WIN_POS_CENTER_ON_PARENT = 4
}
