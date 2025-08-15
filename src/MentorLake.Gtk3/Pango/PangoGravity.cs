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
/// Glyphs stand upright (default) &amp;lt;img align=&quot;right&quot; valign=&quot;center&quot; src=&quot;m-south.png&quot;&amp;gt;
/// </para>
/// </summary>

	PANGO_GRAVITY_SOUTH = 0,
/// <summary>
/// <para>
/// Glyphs are rotated 90 degrees counter-clockwise. &amp;lt;img align=&quot;right&quot; valign=&quot;center&quot; src=&quot;m-east.png&quot;&amp;gt;
/// </para>
/// </summary>

	PANGO_GRAVITY_EAST = 1,
/// <summary>
/// <para>
/// Glyphs are upside-down. &amp;lt;img align=&quot;right&quot; valign=&quot;cener&quot; src=&quot;m-north.png&quot;&amp;gt;
/// </para>
/// </summary>

	PANGO_GRAVITY_NORTH = 2,
/// <summary>
/// <para>
/// Glyphs are rotated 90 degrees clockwise. &amp;lt;img align=&quot;right&quot; valign=&quot;center&quot; src=&quot;m-west.png&quot;&amp;gt;
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
