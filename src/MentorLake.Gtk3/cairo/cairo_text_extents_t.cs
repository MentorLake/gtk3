namespace MentorLake.cairo;

/// <summary>
/// <para>
/// The #cairo_text_extents_t structure stores the extents of a single
/// glyph or a string of glyphs in user-space coordinates. Because text
/// extents are in user-space coordinates, they are mostly, but not
/// entirely, independent of the current transformation matrix. If you call
/// &amp;lt;literal&amp;gt;cairo_scale(cr, 2.0, 2.0)&amp;lt;/literal&amp;gt;, text will
/// be drawn twice as big, but the reported text extents will not be
/// doubled. They will change slightly due to hinting (so you can&apos;t
/// assume that metrics are independent of the transformation matrix),
/// but otherwise will remain unchanged.
/// </para>
/// </summary>

public class cairo_text_extents_tHandle : BaseSafeHandle
{
}


public static class cairo_text_extents_tExtensions
{

	public static cairo_text_extents_t Dereference(this cairo_text_extents_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_text_extents_t>(x.DangerousGetHandle());
}
internal class cairo_text_extents_tExterns
{
}

/// <summary>
/// <para>
/// The #cairo_text_extents_t structure stores the extents of a single
/// glyph or a string of glyphs in user-space coordinates. Because text
/// extents are in user-space coordinates, they are mostly, but not
/// entirely, independent of the current transformation matrix. If you call
/// &amp;lt;literal&amp;gt;cairo_scale(cr, 2.0, 2.0)&amp;lt;/literal&amp;gt;, text will
/// be drawn twice as big, but the reported text extents will not be
/// doubled. They will change slightly due to hinting (so you can&apos;t
/// assume that metrics are independent of the transformation matrix),
/// but otherwise will remain unchanged.
/// </para>
/// </summary>

public struct cairo_text_extents_t
{
	/// <summary>
/// <para>
/// the horizontal distance from the origin to the
///   leftmost part of the glyphs as drawn. Positive if the
///   glyphs lie entirely to the right of the origin.
/// </para>
/// </summary>

public double x_bearing;
	/// <summary>
/// <para>
/// the vertical distance from the origin to the
///   topmost part of the glyphs as drawn. Positive only if the
///   glyphs lie completely below the origin; will usually be
///   negative.
/// </para>
/// </summary>

public double y_bearing;
	/// <summary>
/// <para>
/// width of the glyphs as drawn
/// </para>
/// </summary>

public double width;
	/// <summary>
/// <para>
/// height of the glyphs as drawn
/// </para>
/// </summary>

public double height;
	/// <summary>
/// <para>
/// distance to advance in the X direction
///    after drawing these glyphs
/// </para>
/// </summary>

public double x_advance;
	/// <summary>
/// <para>
/// distance to advance in the Y direction
///   after drawing these glyphs. Will typically be zero except
///   for vertical text layout as found in East-Asian languages.
/// </para>
/// </summary>

public double y_advance;
}
