namespace MentorLake.Gtk3.Gdk3;

[Flags]
public enum GdkDragAction
{
	GDK_ACTION_DEFAULT = 0,
	GDK_ACTION_COPY = 1,
	GDK_ACTION_MOVE = 2,
	GDK_ACTION_LINK = 4,
	GDK_ACTION_PRIVATE = 8,
	GDK_ACTION_ASK = 16
}
