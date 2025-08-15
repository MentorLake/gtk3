namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoGlyphString` is used to store strings of glyphs with geometry
/// and visual attribute information.
/// </para>
/// <para>
/// The storage for the glyph information is owned by the structure
/// which simplifies memory management.
/// </para>
/// </summary>

public class PangoGlyphStringHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new `PangoGlyphString`.
/// </para>
/// </summary>

/// <return>
/// the newly allocated `PangoGlyphString`, which
///   should be freed with [method@Pango.GlyphString.free].
/// </return>

	public static MentorLake.Pango.PangoGlyphStringHandle New()
	{
		return PangoGlyphStringExterns.pango_glyph_string_new();
	}

}


public static class PangoGlyphStringExtensions
{
/// <summary>
/// <para>
/// Copy a glyph string and associated storage.
/// </para>
/// </summary>

/// <param name="@string">
/// a `PangoGlyphString`
/// </param>
/// <return>
/// the newly allocated `PangoGlyphString`
/// </return>

	public static MentorLake.Pango.PangoGlyphStringHandle Copy(this MentorLake.Pango.PangoGlyphStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		return PangoGlyphStringExterns.pango_glyph_string_copy(@string);
	}

/// <summary>
/// <para>
/// Compute the logical and ink extents of a glyph string.
/// </para>
/// <para>
/// See the documentation for [method@Pango.Font.get_glyph_extents] for details
/// about the interpretation of the rectangles.
/// </para>
/// <para>
/// Examples of logical (red) and ink (green) rects:
/// </para>
/// <para>
/// ![](rects1.png) ![](rects2.png)
/// </para>
/// </summary>

/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>
/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="ink_rect">
/// rectangle used to store the extents of the glyph string as drawn
/// </param>
/// <param name="logical_rect">
/// rectangle used to store the logical extents of the glyph string
/// </param>

	public static void Extents(this MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoFontHandle font, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_extents(glyphs, font, out ink_rect, out logical_rect);
	}

/// <summary>
/// <para>
/// Computes the extents of a sub-portion of a glyph string.
/// </para>
/// <para>
/// The extents are relative to the start of the glyph string range
/// (the origin of their coordinate system is at the start of the range,
/// not at the start of the entire glyph string).
/// </para>
/// </summary>

/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>
/// <param name="start">
/// start index
/// </param>
/// <param name="end">
/// end index (the range is the set of bytes with
///   indices such that start &amp;lt;= index &amp;lt; end)
/// </param>
/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="ink_rect">
/// rectangle used to
///   store the extents of the glyph string range as drawn
/// </param>
/// <param name="logical_rect">
/// rectangle used to
///   store the logical extents of the glyph string range
/// </param>

	public static void ExtentsRange(this MentorLake.Pango.PangoGlyphStringHandle glyphs, int start, int end, MentorLake.Pango.PangoFontHandle font, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_extents_range(glyphs, start, end, font, out ink_rect, out logical_rect);
	}

/// <summary>
/// <para>
/// Free a glyph string and associated storage.
/// </para>
/// </summary>

/// <param name="@string">
/// a `PangoGlyphString`, may be %NULL
/// </param>

	public static void Free(this MentorLake.Pango.PangoGlyphStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_free(@string);
	}

/// <summary>
/// <para>
/// Given a `PangoGlyphString` and corresponding text, determine the width
/// corresponding to each character.
/// </para>
/// <para>
/// When multiple characters compose a single cluster, the width of the
/// entire cluster is divided equally among the characters.
/// </para>
/// <para>
/// See also [method@Pango.GlyphItem.get_logical_widths].
/// </para>
/// </summary>

/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>
/// <param name="text">
/// the text corresponding to the glyphs
/// </param>
/// <param name="length">
/// the length of @text, in bytes
/// </param>
/// <param name="embedding_level">
/// the embedding level of the string
/// </param>
/// <param name="logical_widths">
/// an array whose length is the number of
///   characters in text (equal to `g_utf8_strlen (text, length)` unless
///   text has `NUL` bytes) to be filled in with the resulting character widths.
/// </param>

	public static void GetLogicalWidths(this MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, int embedding_level, int[] logical_widths)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_get_logical_widths(glyphs, text, length, embedding_level, logical_widths);
	}

/// <summary>
/// <para>
/// Computes the logical width of the glyph string.
/// </para>
/// <para>
/// This can also be computed using [method@Pango.GlyphString.extents].
/// However, since this only computes the width, it&apos;s much faster. This
/// is in fact only a convenience function that computes the sum of
/// @geometry.width for each glyph in the @glyphs.
/// </para>
/// </summary>

/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>
/// <return>
/// the logical width of the glyph string.
/// </return>

	public static int GetWidth(this MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		return PangoGlyphStringExterns.pango_glyph_string_get_width(glyphs);
	}

/// <summary>
/// <para>
/// Converts from character position to x position.
/// </para>
/// <para>
/// The X position is measured from the left edge of the run.
/// Character positions are obtained using font metrics for ligatures
/// where available, and computed by dividing up each cluster
/// into equal portions, otherwise.
/// </para>
/// <para>
/// &amp;lt;picture&amp;gt;
///   &amp;lt;source srcset=&quot;glyphstring-positions-dark.png&quot; media=&quot;(prefers-color-scheme: dark)&quot;&amp;gt;
///   &amp;lt;img alt=&quot;Glyph positions&quot; src=&quot;glyphstring-positions-light.png&quot;&amp;gt;
/// &amp;lt;/picture&amp;gt;
/// </para>
/// </summary>

/// <param name="glyphs">
/// the glyphs return from [func@shape]
/// </param>
/// <param name="text">
/// the text for the run
/// </param>
/// <param name="length">
/// the number of bytes (not characters) in @text.
/// </param>
/// <param name="analysis">
/// the analysis information return from [func@itemize]
/// </param>
/// <param name="index_">
/// the byte index within @text
/// </param>
/// <param name="trailing">
/// whether we should compute the result for the beginning (%FALSE)
///   or end (%TRUE) of the character.
/// </param>
/// <param name="x_pos">
/// location to store result
/// </param>

	public static void IndexToX(this MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, int index_, bool trailing, out int x_pos)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_index_to_x(glyphs, text, length, analysis, index_, trailing, out x_pos);
	}

/// <summary>
/// <para>
/// Converts from character position to x position.
/// </para>
/// <para>
/// This variant of [method@Pango.GlyphString.index_to_x] additionally
/// accepts a `PangoLogAttr` array. The grapheme boundary information
/// in it can be used to disambiguate positioning inside some complex
/// clusters.
/// </para>
/// </summary>

/// <param name="glyphs">
/// the glyphs return from [func@shape]
/// </param>
/// <param name="text">
/// the text for the run
/// </param>
/// <param name="length">
/// the number of bytes (not characters) in @text.
/// </param>
/// <param name="analysis">
/// the analysis information return from [func@itemize]
/// </param>
/// <param name="attrs">
/// `PangoLogAttr` array for @text
/// </param>
/// <param name="index_">
/// the byte index within @text
/// </param>
/// <param name="trailing">
/// whether we should compute the result for the beginning (%FALSE)
///   or end (%TRUE) of the character.
/// </param>
/// <param name="x_pos">
/// location to store result
/// </param>

	public static void IndexToXFull(this MentorLake.Pango.PangoGlyphStringHandle glyphs, string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoLogAttrHandle attrs, int index_, bool trailing, out int x_pos)
	{
		if (glyphs.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_index_to_x_full(glyphs, text, length, analysis, attrs, index_, trailing, out x_pos);
	}

/// <summary>
/// <para>
/// Resize a glyph string to the given length.
/// </para>
/// </summary>

/// <param name="@string">
/// a `PangoGlyphString`.
/// </param>
/// <param name="new_len">
/// the new length of the string
/// </param>

	public static void SetSize(this MentorLake.Pango.PangoGlyphStringHandle @string, int new_len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (PangoGlyphString)");
		PangoGlyphStringExterns.pango_glyph_string_set_size(@string, new_len);
	}

/// <summary>
/// <para>
/// Convert from x offset to character position.
/// </para>
/// <para>
/// Character positions are computed by dividing up each cluster into
/// equal portions. In scripts where positioning within a cluster is
/// not allowed (such as Thai), the returned value may not be a valid
/// cursor position; the caller must combine the result with the logical
/// attributes for the text to compute the valid cursor position.
/// </para>
/// </summary>

/// <param name="glyphs">
/// the glyphs returned from [func@shape]
/// </param>
/// <param name="text">
/// the text for the run
/// </param>
/// <param name="length">
/// the number of bytes (not characters) in text.
/// </param>
/// <param name="analysis">
/// the analysis information return from [func@itemize]
/// </param>
/// <param name="x_pos">
/// the x offset (in Pango units)
/// </param>
/// <param name="index_">
/// location to store calculated byte index within @text
/// </param>
/// <param name="trailing">
/// location to store a boolean indicating whether the
///   user clicked on the leading or trailing edge of the character
/// </param>

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

/// <summary>
/// <para>
/// A `PangoGlyphString` is used to store strings of glyphs with geometry
/// and visual attribute information.
/// </para>
/// <para>
/// The storage for the glyph information is owned by the structure
/// which simplifies memory management.
/// </para>
/// </summary>

public struct PangoGlyphString
{
	/// <summary>
/// <para>
/// number of glyphs in this glyph string
/// </para>
/// </summary>

public int num_glyphs;
	/// <summary>
/// <para>
/// array of glyph information
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public PangoGlyphInfo[] glyphs;
	/// <summary>
/// <para>
/// logical cluster info, indexed by the byte index
///   within the text corresponding to the glyph string
/// </para>
/// </summary>

public IntPtr log_clusters;
}
