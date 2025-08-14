namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Specifies how to render the endpoints of the path when stroking.
/// </para>
/// <para>
/// The default line cap style is %CAIRO_LINE_CAP_BUTT.
/// </para>
/// </summary>

[Flags]
public enum cairo_line_cap_t
{
/// <summary>
/// <para>
/// start(stop) the line exactly at the start(end) point (Since 1.0)
/// </para>
/// </summary>

	CAIRO_LINE_CAP_BUTT = 0,
/// <summary>
/// <para>
/// use a round ending, the center of the circle is the end point (Since 1.0)
/// </para>
/// </summary>

	CAIRO_LINE_CAP_ROUND = 1,
/// <summary>
/// <para>
/// use squared ending, the center of the square is the end point (Since 1.0)
/// </para>
/// </summary>

	CAIRO_LINE_CAP_SQUARE = 2
}
