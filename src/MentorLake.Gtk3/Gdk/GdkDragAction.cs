namespace MentorLake.Gdk;

[Flags]
public enum GdkDragAction : long
{
	GDK_ACTION_DEFAULT = 1,
	GDK_ACTION_COPY = 2,
	GDK_ACTION_MOVE = 4,
	GDK_ACTION_LINK = 8,
	GDK_ACTION_PRIVATE = 16,
	GDK_ACTION_ASK = 32
}
