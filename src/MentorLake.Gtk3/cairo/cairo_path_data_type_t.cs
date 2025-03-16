namespace MentorLake.cairo;

[Flags]
public enum cairo_path_data_type_t
{
	CAIRO_PATH_MOVE_TO = 0,
	CAIRO_PATH_LINE_TO = 1,
	CAIRO_PATH_CURVE_TO = 2,
	CAIRO_PATH_CLOSE_PATH = 3
}
