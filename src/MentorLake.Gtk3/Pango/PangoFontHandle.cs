namespace MentorLake.Pango;

public class PangoFontHandle : GObjectHandle
{
	public static void DescriptionsFree(MentorLake.Pango.PangoFontDescriptionHandle[] descs, int n_descs)
	{
		PangoFontHandleExterns.pango_font_descriptions_free(descs, n_descs);
	}

	public static MentorLake.Pango.PangoFontHandle Deserialize(MentorLake.Pango.PangoContextHandle context, MentorLake.GLib.GBytesHandle bytes, IntPtr error)
	{
		return PangoFontHandleExterns.pango_font_deserialize(context, bytes, error);
	}

}

public static class PangoFontHandleExtensions
{
	public static MentorLake.Pango.PangoFontDescriptionHandle Describe(this MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFontHandleExterns.pango_font_describe(font);
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle DescribeWithAbsoluteSize(this MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFontHandleExterns.pango_font_describe_with_absolute_size(font);
	}

	public static MentorLake.Pango.PangoCoverageHandle GetCoverage(this MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoFontHandleExterns.pango_font_get_coverage(font, language);
	}

	public static MentorLake.Pango.PangoFontFaceHandle GetFace(this MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFontHandleExterns.pango_font_get_face(font);
	}

	public static T GetFeatures<T>(this T font, out IntPtr features, uint len, ref uint num_features) where T : PangoFontHandle
	{
		PangoFontHandleExterns.pango_font_get_features(font, out features, len, ref num_features);
		return font;
	}

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(this MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFontHandleExterns.pango_font_get_font_map(font);
	}

	public static T GetGlyphExtents<T>(this T font, MentorLake.Pango.PangoGlyph glyph, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect) where T : PangoFontHandle
	{
		PangoFontHandleExterns.pango_font_get_glyph_extents(font, glyph, out ink_rect, out logical_rect);
		return font;
	}

	public static MentorLake.HarfBuzz.hb_font_tHandle GetHbFont(this MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFontHandleExterns.pango_font_get_hb_font(font);
	}

	public static MentorLake.Pango.PangoLanguageHandle[] GetLanguages(this MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFontHandleExterns.pango_font_get_languages(font);
	}

	public static MentorLake.Pango.PangoFontMetricsHandle GetMetrics(this MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoFontHandleExterns.pango_font_get_metrics(font, language);
	}

	public static bool HasChar(this MentorLake.Pango.PangoFontHandle font, char wc)
	{
		return PangoFontHandleExterns.pango_font_has_char(font, wc);
	}

	public static MentorLake.GLib.GBytesHandle Serialize(this MentorLake.Pango.PangoFontHandle font)
	{
		return PangoFontHandleExterns.pango_font_serialize(font);
	}

}

internal class PangoFontHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_describe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_describe_with_absolute_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_font_get_coverage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontFaceHandle pango_font_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_get_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, out IntPtr features, uint len, ref uint num_features);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_font_get_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_get_glyph_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph glyph, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle pango_font_get_hb_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle[] pango_font_get_languages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMetricsHandle pango_font_get_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_has_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, char wc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle pango_font_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_descriptions_free([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle[] descs, int n_descs);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontHandle pango_font_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, IntPtr error);

}
