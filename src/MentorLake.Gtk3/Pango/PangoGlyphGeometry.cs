namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoGlyphGeometry` structure contains width and positioning
/// information for a single glyph.
/// </para>
/// <para>
/// Note that @width is not guaranteed to be the same as the glyph
/// extents. Kerning and other positioning applied during shaping will
/// affect both the @width and the @x_offset for the glyphs in the
/// glyph string that results from shaping.
/// </para>
/// <para>
/// The information in this struct is intended for rendering the glyphs,
/// as follows:
/// </para>
/// <para>
/// 1. Assume the current point is (x, y)
/// 2. Render the current glyph at (x + x_offset, y + y_offset),
/// 3. Advance the current point to (x + width, y)
/// 4. Render the next glyph
/// </para>
/// </summary>

public class PangoGlyphGeometryHandle : BaseSafeHandle
{
}


public static class PangoGlyphGeometryExtensions
{

	public static PangoGlyphGeometry Dereference(this PangoGlyphGeometryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphGeometry>(x.DangerousGetHandle());
}
internal class PangoGlyphGeometryExterns
{
}

/// <summary>
/// <para>
/// The `PangoGlyphGeometry` structure contains width and positioning
/// information for a single glyph.
/// </para>
/// <para>
/// Note that @width is not guaranteed to be the same as the glyph
/// extents. Kerning and other positioning applied during shaping will
/// affect both the @width and the @x_offset for the glyphs in the
/// glyph string that results from shaping.
/// </para>
/// <para>
/// The information in this struct is intended for rendering the glyphs,
/// as follows:
/// </para>
/// <para>
/// 1. Assume the current point is (x, y)
/// 2. Render the current glyph at (x + x_offset, y + y_offset),
/// 3. Advance the current point to (x + width, y)
/// 4. Render the next glyph
/// </para>
/// </summary>

public struct PangoGlyphGeometry
{
	/// <summary>
/// <para>
/// the logical width to use for the the character.
/// </para>
/// </summary>

public PangoGlyphUnit width;
	/// <summary>
/// <para>
/// horizontal offset from nominal character position.
/// </para>
/// </summary>

public PangoGlyphUnit x_offset;
	/// <summary>
/// <para>
/// vertical offset from nominal character position.
/// </para>
/// </summary>

public PangoGlyphUnit y_offset;
}
