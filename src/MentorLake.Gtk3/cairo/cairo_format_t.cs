namespace MentorLake.cairo;

[Flags]
public enum cairo_format_t
{
	CAIRO_FORMAT_INVALID = -1,
	CAIRO_FORMAT_ARGB32 = 0,
	CAIRO_FORMAT_RGB24 = 1,
	CAIRO_FORMAT_A8 = 2,
	CAIRO_FORMAT_A1 = 3,
	CAIRO_FORMAT_RGB16_565 = 4,
	CAIRO_FORMAT_RGB30 = 5
}
