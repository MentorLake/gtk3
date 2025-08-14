namespace MentorLake.Pango;

/// <summary>
/// <para>
/// Class structure for `PangoRenderer`.
/// </para>
/// <para>
/// The following vfuncs take user space coordinates in Pango units
/// and have default implementations:
/// - draw_glyphs
/// - draw_rectangle
/// - draw_error_underline
/// - draw_shape
/// - draw_glyph_item
/// </para>
/// <para>
/// The default draw_shape implementation draws nothing.
/// </para>
/// <para>
/// The following vfuncs take device space coordinates as doubles
/// and must be implemented:
/// - draw_trapezoid
/// - draw_glyph
/// </para>
/// </summary>

public class PangoRendererClassHandle : BaseSafeHandle
{
}


public static class PangoRendererClassExtensions
{

	public static PangoRendererClass Dereference(this PangoRendererClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoRendererClass>(x.DangerousGetHandle());
}
internal class PangoRendererClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for `PangoRenderer`.
/// </para>
/// <para>
/// The following vfuncs take user space coordinates in Pango units
/// and have default implementations:
/// - draw_glyphs
/// - draw_rectangle
/// - draw_error_underline
/// - draw_shape
/// - draw_glyph_item
/// </para>
/// <para>
/// The default draw_shape implementation draws nothing.
/// </para>
/// <para>
/// The following vfuncs take device space coordinates as doubles
/// and must be implemented:
/// - draw_trapezoid
/// - draw_glyph
/// </para>
/// </summary>

public struct PangoRendererClass
{
	/// <summary>
/// <para>
/// draws a `PangoGlyphString`
/// </para>
/// </summary>

public IntPtr draw_glyphs;
	/// <summary>
/// <para>
/// draws a rectangle
/// </para>
/// </summary>

public IntPtr draw_rectangle;
	/// <summary>
/// <para>
/// draws a squiggly line that approximately
/// covers the given rectangle in the style of an underline used to
/// indicate a spelling error.
/// </para>
/// </summary>

public IntPtr draw_error_underline;
	/// <summary>
/// <para>
/// draw content for a glyph shaped with `PangoAttrShape`
///   @x, @y are the coordinates of the left edge of the baseline,
///   in user coordinates.
/// </para>
/// </summary>

public IntPtr draw_shape;
	/// <summary>
/// <para>
/// draws a trapezoidal filled area
/// </para>
/// </summary>

public IntPtr draw_trapezoid;
	/// <summary>
/// <para>
/// draws a single glyph
/// </para>
/// </summary>

public IntPtr draw_glyph;
	/// <summary>
/// <para>
/// do renderer specific processing when rendering
///  attributes change
/// </para>
/// </summary>

public IntPtr part_changed;
	/// <summary>
/// <para>
/// Do renderer-specific initialization before drawing
/// </para>
/// </summary>

public IntPtr begin;
	/// <summary>
/// <para>
/// Do renderer-specific cleanup after drawing
/// </para>
/// </summary>

public IntPtr end;
	/// <summary>
/// <para>
/// updates the renderer for a new run
/// </para>
/// </summary>

public IntPtr prepare_run;
	/// <summary>
/// <para>
/// draws a `PangoGlyphItem`
/// </para>
/// </summary>

public IntPtr draw_glyph_item;
	
public IntPtr _pango_reserved2;
	
public IntPtr _pango_reserved3;
	
public IntPtr _pango_reserved4;
}
