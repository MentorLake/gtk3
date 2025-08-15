namespace MentorLake.cairo;

/// <summary>
/// <para>
/// The #cairo_font_extents_t structure stores metric information for
/// a font. Values are given in the current user-space coordinate
/// system.
/// </para>
/// <para>
/// Because font metrics are in user-space coordinates, they are
/// mostly, but not entirely, independent of the current transformation
/// matrix. If you call &amp;lt;literal&amp;gt;cairo_scale(cr, 2.0, 2.0)&amp;lt;/literal&amp;gt;,
/// text will be drawn twice as big, but the reported text extents will
/// not be doubled. They will change slightly due to hinting (so you
/// can&apos;t assume that metrics are independent of the transformation
/// matrix), but otherwise will remain unchanged.
/// </para>
/// </summary>

public class cairo_font_extents_tHandle : BaseSafeHandle
{
}


public static class cairo_font_extents_tExtensions
{

	public static cairo_font_extents_t Dereference(this cairo_font_extents_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_font_extents_t>(x.DangerousGetHandle());
}
internal class cairo_font_extents_tExterns
{
}

/// <summary>
/// <para>
/// The #cairo_font_extents_t structure stores metric information for
/// a font. Values are given in the current user-space coordinate
/// system.
/// </para>
/// <para>
/// Because font metrics are in user-space coordinates, they are
/// mostly, but not entirely, independent of the current transformation
/// matrix. If you call &amp;lt;literal&amp;gt;cairo_scale(cr, 2.0, 2.0)&amp;lt;/literal&amp;gt;,
/// text will be drawn twice as big, but the reported text extents will
/// not be doubled. They will change slightly due to hinting (so you
/// can&apos;t assume that metrics are independent of the transformation
/// matrix), but otherwise will remain unchanged.
/// </para>
/// </summary>

public struct cairo_font_extents_t
{
	/// <summary>
/// <para>
/// the distance that the font extends above the baseline.
///          Note that this is not always exactly equal to the maximum
///          of the extents of all the glyphs in the font, but rather
///          is picked to express the font designer&apos;s intent as to
///          how the font should align with elements above it.
/// </para>
/// </summary>

public double ascent;
	/// <summary>
/// <para>
/// the distance that the font extends below the baseline.
///           This value is positive for typical fonts that include
///           portions below the baseline. Note that this is not always
///           exactly equal to the maximum of the extents of all the
///           glyphs in the font, but rather is picked to express the
///           font designer&apos;s intent as to how the font should
///           align with elements below it.
/// </para>
/// </summary>

public double descent;
	/// <summary>
/// <para>
/// the recommended vertical distance between baselines when
///          setting consecutive lines of text with the font. This
///          is greater than @ascent+@descent by a
///          quantity known as the &amp;lt;firstterm&amp;gt;line spacing&amp;lt;/firstterm&amp;gt;
///          or &amp;lt;firstterm&amp;gt;external leading&amp;lt;/firstterm&amp;gt;. When space
///          is at a premium, most fonts can be set with only
///          a distance of @ascent+@descent between lines.
/// </para>
/// </summary>

public double height;
	/// <summary>
/// <para>
/// the maximum distance in the X direction that
///         the origin is advanced for any glyph in the font.
/// </para>
/// </summary>

public double max_x_advance;
	/// <summary>
/// <para>
/// the maximum distance in the Y direction that
///         the origin is advanced for any glyph in the font.
///         This will be zero for normal fonts used for horizontal
///         writing. (The scripts of East Asia are sometimes written
///         vertically.)
/// </para>
/// </summary>

public double max_y_advance;
}
