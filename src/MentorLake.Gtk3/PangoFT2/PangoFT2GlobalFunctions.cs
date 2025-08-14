namespace MentorLake.PangoFT2;

public class PangoFT2GlobalFunctions
{
/// <summary>
/// <para>
/// Gets the `PangoCoverage` for a `PangoFT2Font`.
/// </para>
/// <para>
/// Use [method@Pango.Font.get_coverage] instead.
/// </para>
/// </summary>

/// <param name="font">
/// a Pango FT2 font
/// </param>
/// <param name="language">
/// a language tag.
/// </param>
/// <return>
/// a `PangoCoverage`
/// </return>

	public static MentorLake.Pango.PangoCoverageHandle FontGetCoverage(MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_font_get_coverage(font, language);
	}

/// <summary>
/// <para>
/// Returns the native FreeType2 `FT_Face` structure
/// used for this `PangoFont`.
/// </para>
/// <para>
/// This may be useful if you want to use FreeType2
/// functions directly.
/// </para>
/// <para>
/// Use [method@PangoFc.Font.lock_face] instead; when you are
/// done with a face from [method@PangoFc.Font.lock_face], you
/// must call [method@PangoFc.Font.unlock_face].
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// a pointer to a `FT_Face` structure,
///   with the size set correctly
/// </return>

	public static MentorLake.freetype2.FT_Face FontGetFace(MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_font_get_face(font);
	}

/// <summary>
/// <para>
/// Retrieves kerning information for a combination of two glyphs.
/// </para>
/// <para>
/// Use pango_fc_font_kern_glyphs() instead.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="left">
/// the left `PangoGlyph`
/// </param>
/// <param name="right">
/// the right `PangoGlyph`
/// </param>
/// <return>
/// The amount of kerning (in Pango units) to
///   apply for the given combination of glyphs.
/// </return>

	public static int FontGetKerning(MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph left, MentorLake.Pango.PangoGlyph right)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_font_get_kerning(font, left, right);
	}

/// <summary>
/// <para>
/// Retrieves a `PangoContext` for the default PangoFT2 fontmap
/// (see pango_ft2_font_map_for_display()) and sets the resolution
/// for the default fontmap to @dpi_x by @dpi_y.
/// </para>
/// </summary>

/// <param name="dpi_x">
/// the horizontal DPI of the target device
/// </param>
/// <param name="dpi_y">
/// the vertical DPI of the target device
/// </param>
/// <return>
/// the new `PangoContext`
/// </return>

	public static MentorLake.Pango.PangoContextHandle GetContext(double dpi_x, double dpi_y)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_get_context(dpi_x, dpi_y);
	}

/// <summary>
/// <para>
/// Return the index of a glyph suitable for drawing unknown
/// characters with @font, or %PANGO_GLYPH_EMPTY if no suitable
/// glyph found.
/// </para>
/// <para>
/// If you want to draw an unknown-box for a character that
/// is not covered by the font, use PANGO_GET_UNKNOWN_GLYPH()
/// instead.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// a glyph index into @font, or %PANGO_GLYPH_EMPTY
/// </return>

	public static MentorLake.Pango.PangoGlyph GetUnknownGlyph(MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_get_unknown_glyph(font);
	}

/// <summary>
/// <para>
/// Renders a `PangoGlyphString` onto a FreeType2 bitmap.
/// </para>
/// </summary>

/// <param name="bitmap">
/// the FreeType2 bitmap onto which to draw the string
/// </param>
/// <param name="font">
/// the font in which to draw the string
/// </param>
/// <param name="glyphs">
/// the glyph string to draw
/// </param>
/// <param name="x">
/// the x position of the start of the string (in pixels)
/// </param>
/// <param name="y">
/// the y position of the baseline (in pixels)
/// </param>

	public static void Render(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render(bitmap, font, glyphs, x, y);
	}

/// <summary>
/// <para>
/// Render a `PangoLayout` onto a FreeType2 bitmap
/// </para>
/// </summary>

/// <param name="bitmap">
/// a FT_Bitmap to render the layout onto
/// </param>
/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="x">
/// the X position of the left of the layout (in pixels)
/// </param>
/// <param name="y">
/// the Y position of the top of the layout (in pixels)
/// </param>

	public static void RenderLayout(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoLayoutHandle layout, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_layout(bitmap, layout, x, y);
	}

/// <summary>
/// <para>
/// Render a `PangoLayoutLine` onto a FreeType2 bitmap
/// </para>
/// </summary>

/// <param name="bitmap">
/// a FT_Bitmap to render the line onto
/// </param>
/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="x">
/// the x position of start of string (in pixels)
/// </param>
/// <param name="y">
/// the y position of baseline (in pixels)
/// </param>

	public static void RenderLayoutLine(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoLayoutLineHandle line, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_layout_line(bitmap, line, x, y);
	}

/// <summary>
/// <para>
/// Render a `PangoLayoutLine` onto a FreeType2 bitmap, with he
/// location specified in fixed-point Pango units rather than
/// pixels.
/// </para>
/// <para>
/// (Using this will avoid extra inaccuracies from rounding
/// to integer pixels multiple times, even if the final glyph
/// positions are integers.)
/// </para>
/// </summary>

/// <param name="bitmap">
/// a FT_Bitmap to render the line onto
/// </param>
/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="x">
/// the x position of start of string (in Pango units)
/// </param>
/// <param name="y">
/// the y position of baseline (in Pango units)
/// </param>

	public static void RenderLayoutLineSubpixel(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoLayoutLineHandle line, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_layout_line_subpixel(bitmap, line, x, y);
	}

/// <summary>
/// <para>
/// Render a `PangoLayout` onto a FreeType2 bitmap, with he
/// location specified in fixed-point Pango units rather than
/// pixels.
/// </para>
/// <para>
/// (Using this will avoid extra inaccuracies from rounding
/// to integer pixels multiple times, even if the final glyph
/// positions are integers.)
/// </para>
/// </summary>

/// <param name="bitmap">
/// a FT_Bitmap to render the layout onto
/// </param>
/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="x">
/// the X position of the left of the layout (in Pango units)
/// </param>
/// <param name="y">
/// the Y position of the top of the layout (in Pango units)
/// </param>

	public static void RenderLayoutSubpixel(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoLayoutHandle layout, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_layout_subpixel(bitmap, layout, x, y);
	}

/// <summary>
/// <para>
/// Renders a `PangoGlyphString` onto a FreeType2 bitmap, possibly
/// transforming the layed-out coordinates through a transformation
/// matrix.
/// </para>
/// <para>
/// Note that the transformation matrix for @font is not
/// changed, so to produce correct rendering results, the @font
/// must have been loaded using a `PangoContext` with an identical
/// transformation matrix to that passed in to this function.
/// </para>
/// </summary>

/// <param name="bitmap">
/// the FreeType2 bitmap onto which to draw the string
/// </param>
/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="font">
/// the font in which to draw the string
/// </param>
/// <param name="glyphs">
/// the glyph string to draw
/// </param>
/// <param name="x">
/// the x position of the start of the string (in Pango
///   units in user space coordinates)
/// </param>
/// <param name="y">
/// the y position of the baseline (in Pango units
///   in user space coordinates)
/// </param>

	public static void RenderTransformed(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoMatrixHandle matrix, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_transformed(bitmap, matrix, font, glyphs, x, y);
	}

/// <summary>
/// <para>
/// Free the global fontmap. (See pango_ft2_font_map_for_display())
/// Use of the global PangoFT2 fontmap is deprecated.
/// </para>
/// </summary>


	public static void ShutdownDisplay()
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_shutdown_display();
	}

}

internal class PangoFT2GlobalFunctionsExterns
{
	[DllImport(PangoFT2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_ft2_font_get_coverage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoFT2Library.Name)]
	internal static extern MentorLake.freetype2.FT_Face pango_ft2_font_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoFT2Library.Name)]
	internal static extern int pango_ft2_font_get_kerning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph left, MentorLake.Pango.PangoGlyph right);

	[DllImport(PangoFT2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_ft2_get_context(double dpi_x, double dpi_y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern MentorLake.Pango.PangoGlyph pango_ft2_get_unknown_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.freetype2.FT_BitmapHandle>))] MentorLake.freetype2.FT_BitmapHandle bitmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_render_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.freetype2.FT_BitmapHandle>))] MentorLake.freetype2.FT_BitmapHandle bitmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int x, int y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_render_layout_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.freetype2.FT_BitmapHandle>))] MentorLake.freetype2.FT_BitmapHandle bitmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, int x, int y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_render_layout_line_subpixel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.freetype2.FT_BitmapHandle>))] MentorLake.freetype2.FT_BitmapHandle bitmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, int x, int y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_render_layout_subpixel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.freetype2.FT_BitmapHandle>))] MentorLake.freetype2.FT_BitmapHandle bitmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int x, int y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_render_transformed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.freetype2.FT_BitmapHandle>))] MentorLake.freetype2.FT_BitmapHandle bitmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_shutdown_display();

}
