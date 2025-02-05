namespace MentorLake.Gtk3.Gdk3;

[Flags]
public enum GdkWindowState
{
	GDK_WINDOW_STATE_WITHDRAWN = 0,
	GDK_WINDOW_STATE_ICONIFIED = 1,
	GDK_WINDOW_STATE_MAXIMIZED = 2,
	GDK_WINDOW_STATE_STICKY = 4,
	GDK_WINDOW_STATE_FULLSCREEN = 8,
	GDK_WINDOW_STATE_ABOVE = 16,
	GDK_WINDOW_STATE_BELOW = 32,
	GDK_WINDOW_STATE_FOCUSED = 64,
	GDK_WINDOW_STATE_TILED = 128,
	GDK_WINDOW_STATE_TOP_TILED = 256,
	GDK_WINDOW_STATE_TOP_RESIZABLE = 512,
	GDK_WINDOW_STATE_RIGHT_TILED = 1024,
	GDK_WINDOW_STATE_RIGHT_RESIZABLE = 2048,
	GDK_WINDOW_STATE_BOTTOM_TILED = 4096,
	GDK_WINDOW_STATE_BOTTOM_RESIZABLE = 8192,
	GDK_WINDOW_STATE_LEFT_TILED = 16384,
	GDK_WINDOW_STATE_LEFT_RESIZABLE = 32768
}
