namespace MentorLake.PangoFc;

/// <summary>
/// <para>
/// `PangoFcFont` is a base class for font implementations
/// using the Fontconfig and FreeType libraries.
/// </para>
/// <para>
/// It is used in onjunction with [class@PangoFc.FontMap].
/// When deriving from this class, you need to implement all
/// of its virtual functions other than shutdown() along with
/// the get_glyph_extents() virtual function from `PangoFont`.
/// </para>
/// </summary>

public class PangoFcFontHandle : PangoFontHandle
{
/// <summary>
/// <para>
/// Creates a `PangoFontDescription` that matches the specified
/// Fontconfig pattern as closely as possible.
/// </para>
/// <para>
/// Many possible Fontconfig pattern values, such as %FC_RASTERIZER
/// or %FC_DPI, don't make sense in the context of `PangoFontDescription`,
/// so will be ignored.
/// </para>
/// </summary>

/// <param name="pattern">
/// a `FcPattern`
/// </param>
/// <param name="include_size">
/// if %TRUE, the pattern will include the size from
///   the @pattern; otherwise the resulting pattern will be unsized.
///   (only %FC_SIZE is examined, not %FC_PIXEL_SIZE)
/// </param>
/// <return>
/// a new `PangoFontDescription`. Free with
///   pango_font_description_free().
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle DescriptionFromPattern(MentorLake.fontconfig.FcPatternHandle pattern, bool include_size)
	{
		return PangoFcFontHandleExterns.pango_fc_font_description_from_pattern(pattern, include_size);
	}

}

public static class PangoFcFontHandleExtensions
{
/// <summary>
/// <para>
/// Gets the glyph index for a given Unicode character
/// for @font.
/// </para>
/// <para>
/// If you only want to determine whether the font has
/// the glyph, use [method@PangoFc.Font.has_char].
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`
/// </param>
/// <param name="wc">
/// Unicode character to look up
/// </param>
/// <return>
/// the glyph index, or 0, if the Unicode
///   character doesn't exist in the font.
/// </return>

	public static uint GetGlyph(this MentorLake.PangoFc.PangoFcFontHandle font, char wc)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFcFontHandle)");
		return PangoFcFontHandleExterns.pango_fc_font_get_glyph(font, wc);
	}

/// <summary>
/// <para>
/// Returns the languages that are supported by @font.
/// </para>
/// <para>
/// This corresponds to the FC_LANG member of the FcPattern.
/// </para>
/// <para>
/// The returned array is only valid as long as the font
/// and its fontmap are valid.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`
/// </param>
/// <return>
/// a
///   %NULL-terminated array of `PangoLanguage`*
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle[] GetLanguages(this MentorLake.PangoFc.PangoFcFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFcFontHandle)");
		return PangoFcFontHandleExterns.pango_fc_font_get_languages(font);
	}

/// <summary>
/// <para>
/// Returns the FcPattern that @font is based on.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`
/// </param>
/// <return>
/// the fontconfig pattern for this font
/// </return>

	public static MentorLake.fontconfig.FcPatternHandle GetPattern(this MentorLake.PangoFc.PangoFcFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFcFontHandle)");
		return PangoFcFontHandleExterns.pango_fc_font_get_pattern(font);
	}

/// <summary>
/// <para>
/// Returns the index of a glyph suitable for drawing @wc
/// as an unknown character.
/// </para>
/// <para>
/// Use PANGO_GET_UNKNOWN_GLYPH() instead.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`
/// </param>
/// <param name="wc">
/// the Unicode character for which a glyph is needed.
/// </param>
/// <return>
/// a glyph index into @font.
/// </return>

	public static MentorLake.Pango.PangoGlyph GetUnknownGlyph(this MentorLake.PangoFc.PangoFcFontHandle font, char wc)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFcFontHandle)");
		return PangoFcFontHandleExterns.pango_fc_font_get_unknown_glyph(font, wc);
	}

/// <summary>
/// <para>
/// Determines whether @font has a glyph for the codepoint @wc.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`
/// </param>
/// <param name="wc">
/// Unicode codepoint to look up
/// </param>
/// <return>
/// %TRUE if @font has the requested codepoint.
/// </return>

	public static bool HasChar(this MentorLake.PangoFc.PangoFcFontHandle font, char wc)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFcFontHandle)");
		return PangoFcFontHandleExterns.pango_fc_font_has_char(font, wc);
	}

/// <summary>
/// <para>
/// This function used to adjust each adjacent pair of glyphs
/// in @glyphs according to kerning information in @font.
/// </para>
/// <para>
/// Since 1.44, it does nothing.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`
/// </param>
/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>

	public static T KernGlyphs<T>(this T font, MentorLake.Pango.PangoGlyphStringHandle glyphs) where T : PangoFcFontHandle
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFcFontHandle)");
		PangoFcFontHandleExterns.pango_fc_font_kern_glyphs(font, glyphs);
		return font;
	}

/// <summary>
/// <para>
/// Gets the FreeType `FT_Face` associated with a font.
/// </para>
/// <para>
/// This face will be kept around until you call
/// [method@PangoFc.Font.unlock_face].
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`.
/// </param>
/// <return>
/// the FreeType `FT_Face` associated with @font.
/// </return>

	public static MentorLake.freetype2.FT_Face LockFace(this MentorLake.PangoFc.PangoFcFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFcFontHandle)");
		return PangoFcFontHandleExterns.pango_fc_font_lock_face(font);
	}

/// <summary>
/// <para>
/// Releases a font previously obtained with
/// [method@PangoFc.Font.lock_face].
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`.
/// </param>

	public static T UnlockFace<T>(this T font) where T : PangoFcFontHandle
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFcFontHandle)");
		PangoFcFontHandleExterns.pango_fc_font_unlock_face(font);
		return font;
	}

}

internal class PangoFcFontHandleExterns
{
	[DllImport(PangoFcLibrary.Name)]
	internal static extern uint pango_fc_font_get_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font, char wc);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle[] pango_fc_font_get_languages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font);

	[DllImport(PangoFcLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))]
	internal static extern MentorLake.fontconfig.FcPatternHandle pango_fc_font_get_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGlyph pango_fc_font_get_unknown_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font, char wc);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern bool pango_fc_font_has_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font, char wc);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_kern_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern MentorLake.freetype2.FT_Face pango_fc_font_lock_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_unlock_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font);

	[DllImport(PangoFcLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_fc_font_description_from_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, bool include_size);

}
