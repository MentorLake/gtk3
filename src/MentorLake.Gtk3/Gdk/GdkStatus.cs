namespace MentorLake.Gdk;

[Flags]
public enum GdkStatus
{
	GDK_OK = 0,
	GDK_ERROR = -1,
	GDK_ERROR_PARAM = -2,
	GDK_ERROR_FILE = -3,
	GDK_ERROR_MEM = -4
}
