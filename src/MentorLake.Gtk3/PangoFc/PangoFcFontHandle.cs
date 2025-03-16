namespace MentorLake.PangoFc;

public class PangoFcFontHandle : PangoFontHandle
{
	public static MentorLake.Pango.PangoFontDescriptionHandle DescriptionFromPattern(MentorLake.fontconfig.FcPatternHandle pattern, bool include_size)
	{
		return PangoFcFontHandleExterns.pango_fc_font_description_from_pattern(pattern, include_size);
	}

}

public static class PangoFcFontHandleExtensions
{
	public static uint GetGlyph(this MentorLake.PangoFc.PangoFcFontHandle font, char wc)
	{
		return PangoFcFontHandleExterns.pango_fc_font_get_glyph(font, wc);
	}

	public static MentorLake.Pango.PangoLanguageHandle[] GetLanguages(this MentorLake.PangoFc.PangoFcFontHandle font)
	{
		return PangoFcFontHandleExterns.pango_fc_font_get_languages(font);
	}

	public static MentorLake.fontconfig.FcPatternHandle GetPattern(this MentorLake.PangoFc.PangoFcFontHandle font)
	{
		return PangoFcFontHandleExterns.pango_fc_font_get_pattern(font);
	}

	public static MentorLake.Pango.PangoGlyph GetUnknownGlyph(this MentorLake.PangoFc.PangoFcFontHandle font, char wc)
	{
		return PangoFcFontHandleExterns.pango_fc_font_get_unknown_glyph(font, wc);
	}

	public static bool HasChar(this MentorLake.PangoFc.PangoFcFontHandle font, char wc)
	{
		return PangoFcFontHandleExterns.pango_fc_font_has_char(font, wc);
	}

	public static T KernGlyphs<T>(this T font, MentorLake.Pango.PangoGlyphStringHandle glyphs) where T : PangoFcFontHandle
	{
		PangoFcFontHandleExterns.pango_fc_font_kern_glyphs(font, glyphs);
		return font;
	}

	public static MentorLake.freetype2.FT_Face LockFace(this MentorLake.PangoFc.PangoFcFontHandle font)
	{
		return PangoFcFontHandleExterns.pango_fc_font_lock_face(font);
	}

	public static T UnlockFace<T>(this T font) where T : PangoFcFontHandle
	{
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
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_fc_font_description_from_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, bool include_size);

}
