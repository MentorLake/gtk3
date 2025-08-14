namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Specifies how to render the junction of two lines when stroking.
/// </para>
/// <para>
/// The default line join style is %CAIRO_LINE_JOIN_MITER.
/// </para>
/// </summary>

[Flags]
public enum cairo_line_join_t
{
/// <summary>
/// <para>
/// use a sharp (angled) corner, see
/// cairo_set_miter_limit() (Since 1.0)
/// </para>
/// </summary>

	CAIRO_LINE_JOIN_MITER = 0,
/// <summary>
/// <para>
/// use a rounded join, the center of the circle is the
/// joint point (Since 1.0)
/// </para>
/// </summary>

	CAIRO_LINE_JOIN_ROUND = 1,
/// <summary>
/// <para>
/// use a cut-off join, the join is cut off at half
/// the line width from the joint point (Since 1.0)
/// </para>
/// </summary>

	CAIRO_LINE_JOIN_BEVEL = 2
}
