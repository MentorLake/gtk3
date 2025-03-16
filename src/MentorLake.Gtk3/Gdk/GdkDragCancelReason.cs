namespace MentorLake.Gdk;

[Flags]
public enum GdkDragCancelReason
{
	GDK_DRAG_CANCEL_NO_TARGET = 0,
	GDK_DRAG_CANCEL_USER_CANCELLED = 1,
	GDK_DRAG_CANCEL_ERROR = 2
}
