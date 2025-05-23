namespace MentorLake.Gdk;

[Flags]
public enum GdkWindowState : uint
{
	GDK_WINDOW_STATE_WITHDRAWN = 1,
	GDK_WINDOW_STATE_ICONIFIED = 2,
	GDK_WINDOW_STATE_MAXIMIZED = 4,
	GDK_WINDOW_STATE_STICKY = 8,
	GDK_WINDOW_STATE_FULLSCREEN = 16,
	GDK_WINDOW_STATE_ABOVE = 32,
	GDK_WINDOW_STATE_BELOW = 64,
	GDK_WINDOW_STATE_FOCUSED = 128,
	GDK_WINDOW_STATE_TILED = 256,
	GDK_WINDOW_STATE_TOP_TILED = 512,
	GDK_WINDOW_STATE_TOP_RESIZABLE = 1024,
	GDK_WINDOW_STATE_RIGHT_TILED = 2048,
	GDK_WINDOW_STATE_RIGHT_RESIZABLE = 4096,
	GDK_WINDOW_STATE_BOTTOM_TILED = 8192,
	GDK_WINDOW_STATE_BOTTOM_RESIZABLE = 16384,
	GDK_WINDOW_STATE_LEFT_TILED = 32768,
	GDK_WINDOW_STATE_LEFT_RESIZABLE = 65536
}
