namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoGlyphInfo` structure represents a single glyph with
/// positioning information and visual attributes.
/// </para>
/// </summary>

public class PangoGlyphInfoHandle : BaseSafeHandle
{
}


public static class PangoGlyphInfoExtensions
{

	public static PangoGlyphInfo Dereference(this PangoGlyphInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphInfo>(x.DangerousGetHandle());
}
internal class PangoGlyphInfoExterns
{
}

/// <summary>
/// <para>
/// A `PangoGlyphInfo` structure represents a single glyph with
/// positioning information and visual attributes.
/// </para>
/// </summary>

public struct PangoGlyphInfo
{
	/// <summary>
/// <para>
/// the glyph itself.
/// </para>
/// </summary>

public PangoGlyph glyph;
	/// <summary>
/// <para>
/// the positional information about the glyph.
/// </para>
/// </summary>

public PangoGlyphGeometry geometry;
	/// <summary>
/// <para>
/// the visual attributes of the glyph.
/// </para>
/// </summary>

public PangoGlyphVisAttr attr;
}
