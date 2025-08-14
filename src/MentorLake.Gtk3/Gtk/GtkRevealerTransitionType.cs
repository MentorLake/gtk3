namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These enumeration values describe the possible transitions
/// when the child of a #GtkRevealer widget is shown or hidden.
/// </para>
/// </summary>

[Flags]
public enum GtkRevealerTransitionType
{
/// <summary>
/// <para>
/// No transition
/// </para>
/// </summary>

	GTK_REVEALER_TRANSITION_TYPE_NONE = 0,
/// <summary>
/// <para>
/// Fade in
/// </para>
/// </summary>

	GTK_REVEALER_TRANSITION_TYPE_CROSSFADE = 1,
/// <summary>
/// <para>
/// Slide in from the left
/// </para>
/// </summary>

	GTK_REVEALER_TRANSITION_TYPE_SLIDE_RIGHT = 2,
/// <summary>
/// <para>
/// Slide in from the right
/// </para>
/// </summary>

	GTK_REVEALER_TRANSITION_TYPE_SLIDE_LEFT = 3,
/// <summary>
/// <para>
/// Slide in from the bottom
/// </para>
/// </summary>

	GTK_REVEALER_TRANSITION_TYPE_SLIDE_UP = 4,
/// <summary>
/// <para>
/// Slide in from the top
/// </para>
/// </summary>

	GTK_REVEALER_TRANSITION_TYPE_SLIDE_DOWN = 5
}
