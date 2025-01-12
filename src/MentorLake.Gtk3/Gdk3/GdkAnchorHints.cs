namespace MentorLake.Gtk3.Gdk3;

[Flags]
public enum GdkAnchorHints
{
	GDK_ANCHOR_FLIP_X = 0,
	GDK_ANCHOR_FLIP_Y = 1,
	GDK_ANCHOR_SLIDE_X = 2,
	GDK_ANCHOR_SLIDE_Y = 4,
	GDK_ANCHOR_RESIZE_X = 8,
	GDK_ANCHOR_RESIZE_Y = 16,
	GDK_ANCHOR_FLIP = 32,
	GDK_ANCHOR_SLIDE = 64,
	GDK_ANCHOR_RESIZE = 128
}
