namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These enumeration values describe the possible transitions
/// between pages in a #GtkStack widget.
/// </para>
/// <para>
/// New values may be added to this enumeration over time.
/// </para>
/// </summary>

[Flags]
public enum GtkStackTransitionType
{
/// <summary>
/// <para>
/// No transition
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_NONE = 0,
/// <summary>
/// <para>
/// A cross-fade
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_CROSSFADE = 1,
/// <summary>
/// <para>
/// Slide from left to right
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_SLIDE_RIGHT = 2,
/// <summary>
/// <para>
/// Slide from right to left
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_SLIDE_LEFT = 3,
/// <summary>
/// <para>
/// Slide from bottom up
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_SLIDE_UP = 4,
/// <summary>
/// <para>
/// Slide from top down
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_SLIDE_DOWN = 5,
/// <summary>
/// <para>
/// Slide from left or right according to the children order
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_SLIDE_LEFT_RIGHT = 6,
/// <summary>
/// <para>
/// Slide from top down or bottom up according to the order
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_SLIDE_UP_DOWN = 7,
/// <summary>
/// <para>
/// Cover the old page by sliding up. Since 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_OVER_UP = 8,
/// <summary>
/// <para>
/// Cover the old page by sliding down. Since: 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_OVER_DOWN = 9,
/// <summary>
/// <para>
/// Cover the old page by sliding to the left. Since: 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_OVER_LEFT = 10,
/// <summary>
/// <para>
/// Cover the old page by sliding to the right. Since: 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_OVER_RIGHT = 11,
/// <summary>
/// <para>
/// Uncover the new page by sliding up. Since 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_UNDER_UP = 12,
/// <summary>
/// <para>
/// Uncover the new page by sliding down. Since: 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_UNDER_DOWN = 13,
/// <summary>
/// <para>
/// Uncover the new page by sliding to the left. Since: 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_UNDER_LEFT = 14,
/// <summary>
/// <para>
/// Uncover the new page by sliding to the right. Since: 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_UNDER_RIGHT = 15,
/// <summary>
/// <para>
/// Cover the old page sliding up or uncover the new page sliding down, according to order. Since: 3.12
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_OVER_UP_DOWN = 16,
/// <summary>
/// <para>
/// Cover the old page sliding down or uncover the new page sliding up, according to order. Since: 3.14
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_OVER_DOWN_UP = 17,
/// <summary>
/// <para>
/// Cover the old page sliding left or uncover the new page sliding right, according to order. Since: 3.14
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_OVER_LEFT_RIGHT = 18,
/// <summary>
/// <para>
/// Cover the old page sliding right or uncover the new page sliding left, according to order. Since: 3.14
/// </para>
/// </summary>

	GTK_STACK_TRANSITION_TYPE_OVER_RIGHT_LEFT = 19
}
