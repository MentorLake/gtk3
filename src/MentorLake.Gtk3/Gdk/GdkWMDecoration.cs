namespace MentorLake.Gdk;

[Flags]
public enum GdkWMDecoration : long
{
	GDK_DECOR_ALL = 1,
	GDK_DECOR_BORDER = 2,
	GDK_DECOR_RESIZEH = 4,
	GDK_DECOR_TITLE = 8,
	GDK_DECOR_MENU = 16,
	GDK_DECOR_MINIMIZE = 32,
	GDK_DECOR_MAXIMIZE = 64
}
