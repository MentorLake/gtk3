namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoGravity` represents the orientation of glyphs in a segment
/// of text.
/// </para>
/// <para>
/// This is useful when rendering vertical text layouts. In those situations,
/// the layout is rotated using a non-identity [struct@Pango.Matrix], and then
/// glyph orientation is controlled using `PangoGravity`.
/// </para>
/// <para>
/// Not every value in this enumeration makes sense for every usage of
/// `PangoGravity`; for example, %PANGO_GRAVITY_AUTO only can be passed to
/// [method@Pango.Context.set_base_gravity] and can only be returned by
/// [method@Pango.Context.get_base_gravity].
/// </para>
/// <para>
/// See also: [enum@Pango.GravityHint]
/// </para>
/// </summary>

[Flags]
public enum PangoGravity
{
/// <summary>
/// <para>
/// Glyphs stand upright (default) <img align="right" valign="center" src="m-south.png">
/// </para>
/// </summary>

	PANGO_GRAVITY_SOUTH = 0,
/// <summary>
/// <para>
/// Glyphs are rotated 90 degrees counter-clockwise. <img align="right" valign="center" src="m-east.png">
/// </para>
/// </summary>

	PANGO_GRAVITY_EAST = 1,
/// <summary>
/// <para>
/// Glyphs are upside-down. <img align="right" valign="cener" src="m-north.png">
/// </para>
/// </summary>

	PANGO_GRAVITY_NORTH = 2,
/// <summary>
/// <para>
/// Glyphs are rotated 90 degrees clockwise. <img align="right" valign="center" src="m-west.png">
/// </para>
/// </summary>

	PANGO_GRAVITY_WEST = 3,
/// <summary>
/// <para>
/// Gravity is resolved from the context matrix
/// </para>
/// </summary>

	PANGO_GRAVITY_AUTO = 4
}
