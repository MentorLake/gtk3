namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes the behavior of a #GtkEventControllerScroll.
/// </para>
/// </summary>

[Flags]
public enum GtkEventControllerScrollFlags : uint
{
/// <summary>
/// <para>
/// Don't emit scroll.
/// </para>
/// </summary>

	GTK_EVENT_CONTROLLER_SCROLL_NONE = 0,
/// <summary>
/// <para>
/// Emit scroll with vertical deltas.
/// </para>
/// </summary>

	GTK_EVENT_CONTROLLER_SCROLL_VERTICAL = 1,
/// <summary>
/// <para>
/// Emit scroll with horizontal deltas.
/// </para>
/// </summary>

	GTK_EVENT_CONTROLLER_SCROLL_HORIZONTAL = 2,
/// <summary>
/// <para>
/// Only emit deltas that are multiples of 1.
/// </para>
/// </summary>

	GTK_EVENT_CONTROLLER_SCROLL_DISCRETE = 4,
/// <summary>
/// <para>
/// Emit #GtkEventControllerScroll::decelerate
///   after continuous scroll finishes.
/// </para>
/// </summary>

	GTK_EVENT_CONTROLLER_SCROLL_KINETIC = 8,
/// <summary>
/// <para>
/// Emit scroll on both axes.
/// </para>
/// </summary>

	GTK_EVENT_CONTROLLER_SCROLL_BOTH_AXES = 3
}
