namespace MentorLake.Gdk;

[Flags]
public enum GdkWindowAttributesType : uint
{
	GDK_WA_TITLE = 2,
	GDK_WA_X = 4,
	GDK_WA_Y = 8,
	GDK_WA_CURSOR = 16,
	GDK_WA_VISUAL = 32,
	GDK_WA_WMCLASS = 64,
	GDK_WA_NOREDIR = 128,
	GDK_WA_TYPE_HINT = 256
}
