namespace MentorLake.Pango;

/// <summary>
/// <para>
/// Flags influencing the shaping process.
/// </para>
/// <para>
/// `PangoShapeFlags` can be passed to [func@Pango.shape_with_flags].
/// </para>
/// </summary>

[Flags]
public enum PangoShapeFlags : uint
{
/// <summary>
/// <para>
/// Default value
/// </para>
/// </summary>

	PANGO_SHAPE_NONE = 0,
/// <summary>
/// <para>
/// Round glyph positions and widths to whole device units
///   This option should be set if the target renderer can&apos;t do subpixel positioning of glyphs
/// </para>
/// </summary>

	PANGO_SHAPE_ROUND_POSITIONS = 1
}
