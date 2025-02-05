namespace MentorLake.Gtk3.Pango;

public class PangoGlyphStringHandle : BaseSafeHandle
{
	public static PangoGlyphStringHandle New()
	{
		return PangoGlyphStringExterns.pango_glyph_string_new();
	}

}


public static class PangoGlyphStringHandleExtensions
{
	public static PangoGlyphStringHandle Copy(this PangoGlyphStringHandle @string)
	{
		return PangoGlyphStringExterns.pango_glyph_string_copy(@string);
	}

	public static T Extents<T>(this T glyphs, PangoFontHandle font, out PangoRectangle ink_rect, out PangoRectangle logical_rect) where T : PangoGlyphStringHandle
	{
		PangoGlyphStringExterns.pango_glyph_string_extents(glyphs, font, out ink_rect, out logical_rect);
		return glyphs;
	}

	public static T ExtentsRange<T>(this T glyphs, int start, int end, PangoFontHandle font, out PangoRectangle ink_rect, out PangoRectangle logical_rect) where T : PangoGlyphStringHandle
	{
		PangoGlyphStringExterns.pango_glyph_string_extents_range(glyphs, start, end, font, out ink_rect, out logical_rect);
		return glyphs;
	}

	public static T Free<T>(this T @string) where T : PangoGlyphStringHandle
	{
		PangoGlyphStringExterns.pango_glyph_string_free(@string);
		return @string;
	}

	public static T GetLogicalWidths<T>(this T glyphs, string text, int length, int embedding_level, int[] logical_widths) where T : PangoGlyphStringHandle
	{
		PangoGlyphStringExterns.pango_glyph_string_get_logical_widths(glyphs, text, length, embedding_level, logical_widths);
		return glyphs;
	}

	public static int GetWidth(this PangoGlyphStringHandle glyphs)
	{
		return PangoGlyphStringExterns.pango_glyph_string_get_width(glyphs);
	}

	public static T IndexToX<T>(this T glyphs, string text, int length, PangoAnalysisHandle analysis, int index_, bool trailing, out int x_pos) where T : PangoGlyphStringHandle
	{
		PangoGlyphStringExterns.pango_glyph_string_index_to_x(glyphs, text, length, analysis, index_, trailing, out x_pos);
		return glyphs;
	}

	public static T IndexToXFull<T>(this T glyphs, string text, int length, PangoAnalysisHandle analysis, PangoLogAttrHandle attrs, int index_, bool trailing, out int x_pos) where T : PangoGlyphStringHandle
	{
		PangoGlyphStringExterns.pango_glyph_string_index_to_x_full(glyphs, text, length, analysis, attrs, index_, trailing, out x_pos);
		return glyphs;
	}

	public static T SetSize<T>(this T @string, int new_len) where T : PangoGlyphStringHandle
	{
		PangoGlyphStringExterns.pango_glyph_string_set_size(@string, new_len);
		return @string;
	}

	public static T XToIndex<T>(this T glyphs, string text, int length, PangoAnalysisHandle analysis, int x_pos, out int index_, out int trailing) where T : PangoGlyphStringHandle
	{
		PangoGlyphStringExterns.pango_glyph_string_x_to_index(glyphs, text, length, analysis, x_pos, out index_, out trailing);
		return glyphs;
	}

}
internal class PangoGlyphStringExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoGlyphStringHandle pango_glyph_string_new();

	[DllImport(Libraries.Pango)]
	internal static extern PangoGlyphStringHandle pango_glyph_string_copy(PangoGlyphStringHandle @string);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_string_extents(PangoGlyphStringHandle glyphs, PangoFontHandle font, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_string_extents_range(PangoGlyphStringHandle glyphs, int start, int end, PangoFontHandle font, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_string_free(PangoGlyphStringHandle @string);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_string_get_logical_widths(PangoGlyphStringHandle glyphs, string text, int length, int embedding_level, int[] logical_widths);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_glyph_string_get_width(PangoGlyphStringHandle glyphs);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_string_index_to_x(PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, int index_, bool trailing, out int x_pos);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_string_index_to_x_full(PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, PangoLogAttrHandle attrs, int index_, bool trailing, out int x_pos);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_string_set_size(PangoGlyphStringHandle @string, int new_len);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_string_x_to_index(PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, int x_pos, out int index_, out int trailing);

}

public struct PangoGlyphString
{
	public int num_glyphs;
	public PangoGlyphInfoHandle glyphs;
	public int[] log_clusters;
}
