namespace MentorLake.cairo;

/// <summary>
/// <para>
/// The #cairo_glyph_t structure holds information about a single glyph
/// when drawing or measuring text. A font is (in simple terms) a
/// collection of shapes used to draw text. A glyph is one of these
/// shapes. There can be multiple glyphs for a single character
/// (alternates to be used in different contexts, for example), or a
/// glyph can be a &amp;lt;firstterm&amp;gt;ligature&amp;lt;/firstterm&amp;gt; of multiple
/// characters. Cairo doesn&apos;t expose any way of converting input text
/// into glyphs, so in order to use the Cairo interfaces that take
/// arrays of glyphs, you must directly access the appropriate
/// underlying font system.
/// </para>
/// <para>
/// Note that the offsets given by @x and @y are not cumulative. When
/// drawing or measuring text, each glyph is individually positioned
/// with respect to the overall origin
/// </para>
/// </summary>

public class cairo_glyph_tHandle : BaseSafeHandle
{
}


public static class cairo_glyph_tExtensions
{

	public static cairo_glyph_t Dereference(this cairo_glyph_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_glyph_t>(x.DangerousGetHandle());
}
internal class cairo_glyph_tExterns
{
}

/// <summary>
/// <para>
/// The #cairo_glyph_t structure holds information about a single glyph
/// when drawing or measuring text. A font is (in simple terms) a
/// collection of shapes used to draw text. A glyph is one of these
/// shapes. There can be multiple glyphs for a single character
/// (alternates to be used in different contexts, for example), or a
/// glyph can be a &amp;lt;firstterm&amp;gt;ligature&amp;lt;/firstterm&amp;gt; of multiple
/// characters. Cairo doesn&apos;t expose any way of converting input text
/// into glyphs, so in order to use the Cairo interfaces that take
/// arrays of glyphs, you must directly access the appropriate
/// underlying font system.
/// </para>
/// <para>
/// Note that the offsets given by @x and @y are not cumulative. When
/// drawing or measuring text, each glyph is individually positioned
/// with respect to the overall origin
/// </para>
/// </summary>

public struct cairo_glyph_t
{
	/// <summary>
/// <para>
/// glyph index in the font. The exact interpretation of the
///      glyph index depends on the font technology being used.
/// </para>
/// </summary>

public ulong index;
	/// <summary>
/// <para>
/// the offset in the X direction between the origin used for
///     drawing or measuring the string and the origin of this glyph.
/// </para>
/// </summary>

public double x;
	/// <summary>
/// <para>
/// the offset in the Y direction between the origin used for
///     drawing or measuring the string and the origin of this glyph.
/// </para>
/// </summary>

public double y;
}
