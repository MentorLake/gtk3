namespace MentorLake.Gdk;

[Flags]
public enum GdkWMFunction : long
{
	GDK_FUNC_ALL = 1,
	GDK_FUNC_RESIZE = 2,
	GDK_FUNC_MOVE = 4,
	GDK_FUNC_MINIMIZE = 8,
	GDK_FUNC_MAXIMIZE = 16,
	GDK_FUNC_CLOSE = 32
}
