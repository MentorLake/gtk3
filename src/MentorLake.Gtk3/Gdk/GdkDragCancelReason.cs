namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Used in #GdkDragContext to the reason of a cancelled DND operation.
/// </para>
/// </summary>

[Flags]
public enum GdkDragCancelReason
{
/// <summary>
/// <para>
/// There is no suitable drop target.
/// </para>
/// </summary>

	GDK_DRAG_CANCEL_NO_TARGET = 0,
/// <summary>
/// <para>
/// Drag cancelled by the user
/// </para>
/// </summary>

	GDK_DRAG_CANCEL_USER_CANCELLED = 1,
/// <summary>
/// <para>
/// Unspecified error.
/// </para>
/// </summary>

	GDK_DRAG_CANCEL_ERROR = 2
}
