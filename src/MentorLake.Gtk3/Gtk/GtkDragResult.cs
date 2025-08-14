namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Gives an indication why a drag operation failed.
/// The value can by obtained by connecting to the
/// #GtkWidget::drag-failed signal.
/// </para>
/// </summary>

[Flags]
public enum GtkDragResult
{
/// <summary>
/// <para>
/// The drag operation was successful.
/// </para>
/// </summary>

	GTK_DRAG_RESULT_SUCCESS = 0,
/// <summary>
/// <para>
/// No suitable drag target.
/// </para>
/// </summary>

	GTK_DRAG_RESULT_NO_TARGET = 1,
/// <summary>
/// <para>
/// The user cancelled the drag operation.
/// </para>
/// </summary>

	GTK_DRAG_RESULT_USER_CANCELLED = 2,
/// <summary>
/// <para>
/// The drag operation timed out.
/// </para>
/// </summary>

	GTK_DRAG_RESULT_TIMEOUT_EXPIRED = 3,
/// <summary>
/// <para>
/// The pointer or keyboard grab used
///  for the drag operation was broken.
/// </para>
/// </summary>

	GTK_DRAG_RESULT_GRAB_BROKEN = 4,
/// <summary>
/// <para>
/// The drag operation failed due to some
///  unspecified error.
/// </para>
/// </summary>

	GTK_DRAG_RESULT_ERROR = 5
}
