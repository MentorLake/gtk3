namespace MentorLake.cairo;

[Flags]
public enum cairo_font_type_t
{
	CAIRO_FONT_TYPE_TOY = 0,
	CAIRO_FONT_TYPE_FT = 1,
	CAIRO_FONT_TYPE_WIN32 = 2,
	CAIRO_FONT_TYPE_QUARTZ = 3,
	CAIRO_FONT_TYPE_USER = 4
}
