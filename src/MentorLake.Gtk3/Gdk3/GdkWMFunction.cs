namespace MentorLake.Gtk3.Gdk3;

[Flags]
public enum GdkWMFunction
{
	GDK_FUNC_ALL = 0,
	GDK_FUNC_RESIZE = 1,
	GDK_FUNC_MOVE = 2,
	GDK_FUNC_MINIMIZE = 4,
	GDK_FUNC_MAXIMIZE = 8,
	GDK_FUNC_CLOSE = 16
}
