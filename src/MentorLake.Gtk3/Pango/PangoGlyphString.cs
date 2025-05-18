namespace MentorLake.Pango;

public class PangoGlyphStringHandle : BaseSafeHandle
{
	public static MentorLake.Pango.PangoGlyphStringHandle New()
	{
		return PangoGlyphStringExterns.pango_glyph_string_new();
	}

}


public static class PangoGlyphStringExtensions
{
	public static MentorLake.Pango.PangoGlyphStringHandle Copy(this MentorLake.Pango.PangoGlyphStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		return PangoGlyphStringExterns.pango_glyph_string_copy(@string);
	}

	public static void Extents(this MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoFontHandle font, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_extents(glyphs, font, out ink_rect, out logical_rect);
	}

	public static void ExtentsRange(this MentorLake.Pango.PangoGlyphStringHandle glyphs, int start, int end, MentorLake.Pango.PangoFontHandle font, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_extents_range(glyphs, start, end, font, out ink_rect, out logical_rect);
	}

	public static void Free(this MentorLake.Pango.PangoGlyphStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_free(@string);
	}

	public static void GetLogicalWidths(this MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, int embedding_level, int[] logical_widths)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_get_logical_widths(glyphs, text, length, embedding_level, logical_widths);
	}

	public static int GetWidth(this MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		return PangoGlyphStringExterns.pango_glyph_string_get_width(glyphs);
	}

	public static void IndexToX(this MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, int index_, bool trailing, out int x_pos)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_index_to_x(glyphs, text, length, analysis, index_, trailing, out x_pos);
	}

	public static void IndexToXFull(this MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoLogAttrHandle attrs, int index_, bool trailing, out int x_pos)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_index_to_x_full(glyphs, text, length, analysis, attrs, index_, trailing, out x_pos);
	}

	public static void SetSize(this MentorLake.Pango.PangoGlyphStringHandle @string, int new_len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_set_size(@string, new_len);
	}

	public static void XToIndex(this MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, int x_pos, out int index_, out int trailing)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_x_to_index(glyphs, text, length, analysis, x_pos, out index_, out trailing);
	}


	public static PangoGlyphString Dereference(this PangoGlyphStringHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphString>(x.DangerousGetHandle());
}
internal class PangoGlyphStringExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))]
	internal static extern MentorLake.Pango.PangoGlyphStringHandle pango_glyph_string_new();

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))]
	internal static extern MentorLake.Pango.PangoGlyphStringHandle pango_glyph_string_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle @string);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_string_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_string_extents_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, int start, int end, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_string_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle @string);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_string_get_logical_widths([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, int embedding_level, int[] logical_widths);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_glyph_string_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_string_index_to_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, int index_, bool trailing, out int x_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_string_index_to_x_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLogAttrHandle>))] MentorLake.Pango.PangoLogAttrHandle attrs, int index_, bool trailing, out int x_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_string_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle @string, int new_len);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_string_x_to_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, int x_pos, out int index_, out int trailing);

}

public struct PangoGlyphString
{
	public int num_glyphs;
	[MarshalAs(UnmanagedType.ByValArray)] public PangoGlyphInfo[] glyphs;
	public IntPtr log_clusters;
}
