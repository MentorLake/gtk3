namespace MentorLake.PangoFT2;

public class PangoFT2GlobalFunctions
{
	public static MentorLake.Pango.PangoCoverageHandle FontGetCoverage(MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_font_get_coverage(font, language);
	}

	public static MentorLake.freetype2.FT_Face FontGetFace(MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_font_get_face(font);
	}

	public static int FontGetKerning(MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph left, MentorLake.Pango.PangoGlyph right)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_font_get_kerning(font, left, right);
	}

	public static MentorLake.Pango.PangoContextHandle GetContext(double dpi_x, double dpi_y)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_get_context(dpi_x, dpi_y);
	}

	public static MentorLake.Pango.PangoGlyph GetUnknownGlyph(MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFT2GlobalFunctionsExterns.pango_ft2_get_unknown_glyph(font);
	}

	public static void Render(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render(bitmap, font, glyphs, x, y);
	}

	public static void RenderLayout(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoLayoutHandle layout, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_layout(bitmap, layout, x, y);
	}

	public static void RenderLayoutLine(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoLayoutLineHandle line, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_layout_line(bitmap, line, x, y);
	}

	public static void RenderLayoutLineSubpixel(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoLayoutLineHandle line, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_layout_line_subpixel(bitmap, line, x, y);
	}

	public static void RenderLayoutSubpixel(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoLayoutHandle layout, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_layout_subpixel(bitmap, layout, x, y);
	}

	public static void RenderTransformed(MentorLake.freetype2.FT_BitmapHandle bitmap, MentorLake.Pango.PangoMatrixHandle matrix, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_render_transformed(bitmap, matrix, font, glyphs, x, y);
	}

	public static void ShutdownDisplay()
	{
		PangoFT2GlobalFunctionsExterns.pango_ft2_shutdown_display();
	}

}

internal class PangoFT2GlobalFunctionsExterns
{
	[DllImport(PangoFT2Library.Name)]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_ft2_font_get_coverage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoFT2Library.Name)]
	internal static extern MentorLake.freetype2.FT_Face pango_ft2_font_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoFT2Library.Name)]
	internal static extern int pango_ft2_font_get_kerning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph left, MentorLake.Pango.PangoGlyph right);

	[DllImport(PangoFT2Library.Name)]
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
