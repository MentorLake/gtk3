namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_path_data_t is used to describe the type of one portion
/// of a path when represented as a #cairo_path_t.
/// See #cairo_path_data_t for details.
/// </para>
/// </summary>

[Flags]
public enum cairo_path_data_type_t
{
/// <summary>
/// <para>
/// A move-to operation, since 1.0
/// </para>
/// </summary>

	CAIRO_PATH_MOVE_TO = 0,
/// <summary>
/// <para>
/// A line-to operation, since 1.0
/// </para>
/// </summary>

	CAIRO_PATH_LINE_TO = 1,
/// <summary>
/// <para>
/// A curve-to operation, since 1.0
/// </para>
/// </summary>

	CAIRO_PATH_CURVE_TO = 2,
/// <summary>
/// <para>
/// A close-path operation, since 1.0
/// </para>
/// </summary>

	CAIRO_PATH_CLOSE_PATH = 3
}
