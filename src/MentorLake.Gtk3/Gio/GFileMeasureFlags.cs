namespace MentorLake.Gio;

[Flags]
public enum GFileMeasureFlags : uint
{
	G_FILE_MEASURE_NONE = 0,
	G_FILE_MEASURE_REPORT_ANY_ERROR = 2,
	G_FILE_MEASURE_APPARENT_SIZE = 4,
	G_FILE_MEASURE_NO_XDEV = 8
}
