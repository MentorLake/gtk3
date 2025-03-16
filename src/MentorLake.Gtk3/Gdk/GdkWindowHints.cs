namespace MentorLake.Gdk;

[Flags]
public enum GdkWindowHints : long
{
	GDK_HINT_POS = 1,
	GDK_HINT_MIN_SIZE = 2,
	GDK_HINT_MAX_SIZE = 4,
	GDK_HINT_BASE_SIZE = 8,
	GDK_HINT_ASPECT = 16,
	GDK_HINT_RESIZE_INC = 32,
	GDK_HINT_WIN_GRAVITY = 64,
	GDK_HINT_USER_POS = 128,
	GDK_HINT_USER_SIZE = 256
}
