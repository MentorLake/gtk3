namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoFont` is used to represent a font in a
/// rendering-system-independent manner.
/// </para>
/// </summary>

public class PangoFontHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Frees an array of font descriptions.
/// </para>
/// </summary>

/// <param name="descs">
/// a pointer
///   to an array of `PangoFontDescription`, may be %NULL
/// </param>
/// <param name="n_descs">
/// number of font descriptions in @descs
/// </param>

	public static void DescriptionsFree(MentorLake.Pango.PangoFontDescriptionHandle[] descs, int n_descs)
	{
		PangoFontHandleExterns.pango_font_descriptions_free(descs, n_descs);
	}

/// <summary>
/// <para>
/// Loads data previously created via [method@Pango.Font.serialize].
/// </para>
/// <para>
/// For a discussion of the supported format, see that function.
/// </para>
/// <para>
/// Note: to verify that the returned font is identical to
/// the one that was serialized, you can compare @bytes to the
/// result of serializing the font again.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="bytes">
/// the bytes containing the data
/// </param>
/// <return>
/// a new `PangoFont`
/// </return>

	public static MentorLake.Pango.PangoFontHandle Deserialize(MentorLake.Pango.PangoContextHandle context, MentorLake.GLib.GBytesHandle bytes)
	{
		var externCallResult = PangoFontHandleExterns.pango_font_deserialize(context, bytes, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class PangoFontHandleExtensions
{
/// <summary>
/// <para>
/// Returns a description of the font, with font size set in points.
/// </para>
/// <para>
/// Use [method@Pango.Font.describe_with_absolute_size] if you want
/// the font size in device units.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// a newly-allocated `PangoFontDescription` object.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle Describe(this MentorLake.Pango.PangoFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_describe(font);
	}

/// <summary>
/// <para>
/// Returns a description of the font, with absolute font size set
/// in device units.
/// </para>
/// <para>
/// Use [method@Pango.Font.describe] if you want the font size in points.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// a newly-allocated `PangoFontDescription` object.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle DescribeWithAbsoluteSize(this MentorLake.Pango.PangoFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_describe_with_absolute_size(font);
	}

/// <summary>
/// <para>
/// Computes the coverage map for a given font and language tag.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="language">
/// the language tag
/// </param>
/// <return>
/// a newly-allocated `PangoCoverage`
///   object.
/// </return>

	public static MentorLake.Pango.PangoCoverageHandle GetCoverage(this MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoLanguageHandle language)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_get_coverage(font, language);
	}

/// <summary>
/// <para>
/// Gets the `PangoFontFace` to which @font belongs.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// the `PangoFontFace`
/// </return>

	public static MentorLake.Pango.PangoFontFaceHandle GetFace(this MentorLake.Pango.PangoFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_get_face(font);
	}

/// <summary>
/// <para>
/// Obtain the OpenType features that are provided by the font.
/// </para>
/// <para>
/// These are passed to the rendering system, together with features
/// that have been explicitly set via attributes.
/// </para>
/// <para>
/// Note that this does not include OpenType features which the
/// rendering system enables by default.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="features">
/// Array to features in
/// </param>
/// <param name="len">
/// the length of @features
/// </param>
/// <param name="num_features">
/// the number of used items in @features
/// </param>

	public static T GetFeatures<T>(this T font, out IntPtr features, uint len, ref uint num_features) where T : PangoFontHandle
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		PangoFontHandleExterns.pango_font_get_features(font, out features, len, ref num_features);
		return font;
	}

/// <summary>
/// <para>
/// Gets the font map for which the font was created.
/// </para>
/// <para>
/// Note that the font maintains a *weak* reference to
/// the font map, so if all references to font map are
/// dropped, the font map will be finalized even if there
/// are fonts created with the font map that are still alive.
/// In that case this function will return %NULL.
/// </para>
/// <para>
/// It is the responsibility of the user to ensure that the
/// font map is kept alive. In most uses this is not an issue
/// as a `PangoContext` holds a reference to the font map.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// the `PangoFontMap`
///   for the font
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(this MentorLake.Pango.PangoFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_get_font_map(font);
	}

/// <summary>
/// <para>
/// Gets the logical and ink extents of a glyph within a font.
/// </para>
/// <para>
/// The coordinate system for each rectangle has its origin at the
/// base line and horizontal origin of the character with increasing
/// coordinates extending to the right and down. The macros PANGO_ASCENT(),
/// PANGO_DESCENT(), PANGO_LBEARING(), and PANGO_RBEARING() can be used to convert
/// from the extents rectangle to more traditional font metrics. The units
/// of the rectangles are in 1/PANGO_SCALE of a device unit.
/// </para>
/// <para>
/// If @font is %NULL, this function gracefully sets some sane values in the
/// output variables and returns.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="glyph">
/// the glyph index
/// </param>
/// <param name="ink_rect">
/// rectangle used to store the extents of the glyph as drawn
/// </param>
/// <param name="logical_rect">
/// rectangle used to store the logical extents of the glyph
/// </param>

	public static T GetGlyphExtents<T>(this T font, MentorLake.Pango.PangoGlyph glyph, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect) where T : PangoFontHandle
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		PangoFontHandleExterns.pango_font_get_glyph_extents(font, glyph, out ink_rect, out logical_rect);
		return font;
	}

/// <summary>
/// <para>
/// Get a `hb_font_t` object backing this font.
/// </para>
/// <para>
/// Note that the objects returned by this function are cached
/// and immutable. If you need to make changes to the `hb_font_t`,
/// use [hb_font_create_sub_font()](https://harfbuzz.github.io/harfbuzz-hb-font.html#hb-font-create-sub-font).
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// the `hb_font_t` object
///   backing the font
/// </return>

	public static MentorLake.HarfBuzz.hb_font_tHandle GetHbFont(this MentorLake.Pango.PangoFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_get_hb_font(font);
	}

/// <summary>
/// <para>
/// Returns the languages that are supported by @font.
/// </para>
/// <para>
/// If the font backend does not provide this information,
/// %NULL is returned. For the fontconfig backend, this
/// corresponds to the FC_LANG member of the FcPattern.
/// </para>
/// <para>
/// The returned array is only valid as long as the font
/// and its fontmap are valid.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// an array of `PangoLanguage`
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle[] GetLanguages(this MentorLake.Pango.PangoFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_get_languages(font);
	}

/// <summary>
/// <para>
/// Gets overall metric information for a font.
/// </para>
/// <para>
/// Since the metrics may be substantially different for different scripts,
/// a language tag can be provided to indicate that the metrics should be
/// retrieved that correspond to the script(s) used by that language.
/// </para>
/// <para>
/// If @font is %NULL, this function gracefully sets some sane values in the
/// output variables and returns.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="language">
/// language tag used to determine which script
///   to get the metrics for, or %NULL to indicate to get the metrics for
///   the entire font.
/// </param>
/// <return>
/// a `PangoFontMetrics` object. The caller must call
///   [method@Pango.FontMetrics.unref] when finished using the object.
/// </return>

	public static MentorLake.Pango.PangoFontMetricsHandle GetMetrics(this MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoLanguageHandle language)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_get_metrics(font, language);
	}

/// <summary>
/// <para>
/// Returns whether the font provides a glyph for this character.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="wc">
/// a Unicode character
/// </param>
/// <return>
/// `TRUE` if @font can render @wc
/// </return>

	public static bool HasChar(this MentorLake.Pango.PangoFontHandle font, char wc)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_has_char(font, wc);
	}

/// <summary>
/// <para>
/// Serializes the @font in a way that can be uniquely identified.
/// </para>
/// <para>
/// There are no guarantees about the format of the output across different
/// versions of Pango.
/// </para>
/// <para>
/// The intended use of this function is testing, benchmarking and debugging.
/// The format is not meant as a permanent storage format.
/// </para>
/// <para>
/// To recreate a font from its serialized form, use [func@Pango.Font.deserialize].
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFont`
/// </param>
/// <return>
/// a `GBytes` containing the serialized form of @font
/// </return>

	public static MentorLake.GLib.GBytesHandle Serialize(this MentorLake.Pango.PangoFontHandle font)
	{
		if (font.IsInvalid) throw new Exception("Invalid handle (PangoFontHandle)");
		return PangoFontHandleExterns.pango_font_serialize(font);
	}

}

internal class PangoFontHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_describe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_describe_with_absolute_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_font_get_coverage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))]
	internal static extern MentorLake.Pango.PangoFontFaceHandle pango_font_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_get_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, out IntPtr features, uint len, ref uint num_features);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_font_get_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_get_glyph_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph glyph, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle pango_font_get_hb_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle[] pango_font_get_languages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))]
	internal static extern MentorLake.Pango.PangoFontMetricsHandle pango_font_get_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_has_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, char wc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle pango_font_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_descriptions_free([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle[] descs, int n_descs);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))]
	internal static extern MentorLake.Pango.PangoFontHandle pango_font_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, out MentorLake.GLib.GErrorHandle error);

}
