namespace MentorLake.Pango;

public class PangoGlobalFunctions
{
	public static MentorLake.Pango.PangoAttributeHandle AttrAllowBreaksNew(bool allow_breaks)
	{
		return PangoGlobalFunctionsExterns.pango_attr_allow_breaks_new(allow_breaks);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrBackgroundAlphaNew(ushort alpha)
	{
		return PangoGlobalFunctionsExterns.pango_attr_background_alpha_new(alpha);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrBackgroundNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_background_new(red, green, blue);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrBaselineShiftNew(int shift)
	{
		return PangoGlobalFunctionsExterns.pango_attr_baseline_shift_new(shift);
	}

	public static void AttrBreak(string text, int length, MentorLake.Pango.PangoAttrListHandle attr_list, int offset, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_attr_break(text, length, attr_list, offset, attrs, attrs_len);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrFallbackNew(bool enable_fallback)
	{
		return PangoGlobalFunctionsExterns.pango_attr_fallback_new(enable_fallback);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrFamilyNew(string family)
	{
		return PangoGlobalFunctionsExterns.pango_attr_family_new(family);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrFontDescNew(MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoGlobalFunctionsExterns.pango_attr_font_desc_new(desc);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrFontFeaturesNew(string features)
	{
		return PangoGlobalFunctionsExterns.pango_attr_font_features_new(features);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrFontScaleNew(MentorLake.Pango.PangoFontScale scale)
	{
		return PangoGlobalFunctionsExterns.pango_attr_font_scale_new(scale);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrForegroundAlphaNew(ushort alpha)
	{
		return PangoGlobalFunctionsExterns.pango_attr_foreground_alpha_new(alpha);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrForegroundNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_foreground_new(red, green, blue);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrGravityHintNew(MentorLake.Pango.PangoGravityHint hint)
	{
		return PangoGlobalFunctionsExterns.pango_attr_gravity_hint_new(hint);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrGravityNew(MentorLake.Pango.PangoGravity gravity)
	{
		return PangoGlobalFunctionsExterns.pango_attr_gravity_new(gravity);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrInsertHyphensNew(bool insert_hyphens)
	{
		return PangoGlobalFunctionsExterns.pango_attr_insert_hyphens_new(insert_hyphens);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrLanguageNew(MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoGlobalFunctionsExterns.pango_attr_language_new(language);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrLetterSpacingNew(int letter_spacing)
	{
		return PangoGlobalFunctionsExterns.pango_attr_letter_spacing_new(letter_spacing);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrLineHeightNew(double factor)
	{
		return PangoGlobalFunctionsExterns.pango_attr_line_height_new(factor);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrLineHeightNewAbsolute(int height)
	{
		return PangoGlobalFunctionsExterns.pango_attr_line_height_new_absolute(height);
	}

	public static MentorLake.Pango.PangoAttrListHandle AttrListFromString(string text)
	{
		return PangoGlobalFunctionsExterns.pango_attr_list_from_string(text);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrOverlineColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_overline_color_new(red, green, blue);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrOverlineNew(MentorLake.Pango.PangoOverline overline)
	{
		return PangoGlobalFunctionsExterns.pango_attr_overline_new(overline);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrRiseNew(int rise)
	{
		return PangoGlobalFunctionsExterns.pango_attr_rise_new(rise);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrScaleNew(double scale_factor)
	{
		return PangoGlobalFunctionsExterns.pango_attr_scale_new(scale_factor);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrSentenceNew()
	{
		return PangoGlobalFunctionsExterns.pango_attr_sentence_new();
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrShapeNew(MentorLake.Pango.PangoRectangleHandle ink_rect, MentorLake.Pango.PangoRectangleHandle logical_rect)
	{
		return PangoGlobalFunctionsExterns.pango_attr_shape_new(ink_rect, logical_rect);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrShapeNewWithData(MentorLake.Pango.PangoRectangleHandle ink_rect, MentorLake.Pango.PangoRectangleHandle logical_rect, IntPtr data, MentorLake.Pango.PangoAttrDataCopyFunc copy_func, MentorLake.GLib.GDestroyNotify destroy_func)
	{
		return PangoGlobalFunctionsExterns.pango_attr_shape_new_with_data(ink_rect, logical_rect, data, copy_func, destroy_func);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrShowNew(MentorLake.Pango.PangoShowFlags flags)
	{
		return PangoGlobalFunctionsExterns.pango_attr_show_new(flags);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrSizeNew(int size)
	{
		return PangoGlobalFunctionsExterns.pango_attr_size_new(size);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrSizeNewAbsolute(int size)
	{
		return PangoGlobalFunctionsExterns.pango_attr_size_new_absolute(size);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrStretchNew(MentorLake.Pango.PangoStretch stretch)
	{
		return PangoGlobalFunctionsExterns.pango_attr_stretch_new(stretch);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrStrikethroughColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_strikethrough_color_new(red, green, blue);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrStrikethroughNew(bool strikethrough)
	{
		return PangoGlobalFunctionsExterns.pango_attr_strikethrough_new(strikethrough);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrStyleNew(MentorLake.Pango.PangoStyle style)
	{
		return PangoGlobalFunctionsExterns.pango_attr_style_new(style);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrTextTransformNew(MentorLake.Pango.PangoTextTransform transform)
	{
		return PangoGlobalFunctionsExterns.pango_attr_text_transform_new(transform);
	}

	public static string AttrTypeGetName(MentorLake.Pango.PangoAttrType type)
	{
		return PangoGlobalFunctionsExterns.pango_attr_type_get_name(type);
	}

	public static MentorLake.Pango.PangoAttrType AttrTypeRegister(string name)
	{
		return PangoGlobalFunctionsExterns.pango_attr_type_register(name);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrUnderlineColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_underline_color_new(red, green, blue);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrUnderlineNew(MentorLake.Pango.PangoUnderline underline)
	{
		return PangoGlobalFunctionsExterns.pango_attr_underline_new(underline);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrVariantNew(MentorLake.Pango.PangoVariant variant)
	{
		return PangoGlobalFunctionsExterns.pango_attr_variant_new(variant);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrWeightNew(MentorLake.Pango.PangoWeight weight)
	{
		return PangoGlobalFunctionsExterns.pango_attr_weight_new(weight);
	}

	public static MentorLake.Pango.PangoAttributeHandle AttrWordNew()
	{
		return PangoGlobalFunctionsExterns.pango_attr_word_new();
	}

	public static MentorLake.Pango.PangoBidiType BidiTypeForUnichar(char ch)
	{
		return PangoGlobalFunctionsExterns.pango_bidi_type_for_unichar(ch);
	}

	public static void Break(string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_break(text, length, analysis, attrs, attrs_len);
	}

	public static void DefaultBreak(string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoLogAttrHandle attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_default_break(text, length, analysis, attrs, attrs_len);
	}

	public static void ExtentsToPixels(MentorLake.Pango.PangoRectangleHandle inclusive, MentorLake.Pango.PangoRectangleHandle nearest)
	{
		PangoGlobalFunctionsExterns.pango_extents_to_pixels(inclusive, nearest);
	}

	public static MentorLake.Pango.PangoDirection FindBaseDir(string text, int length)
	{
		return PangoGlobalFunctionsExterns.pango_find_base_dir(text, length);
	}

	public static void FindParagraphBoundary(string text, int length, out int paragraph_delimiter_index, out int next_paragraph_start)
	{
		PangoGlobalFunctionsExterns.pango_find_paragraph_boundary(text, length, out paragraph_delimiter_index, out next_paragraph_start);
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle FontDescriptionFromString(string str)
	{
		return PangoGlobalFunctionsExterns.pango_font_description_from_string(str);
	}

	public static void GetLogAttrs(string text, int length, int level, MentorLake.Pango.PangoLanguageHandle language, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_get_log_attrs(text, length, level, language, attrs, attrs_len);
	}

	public static bool GetMirrorChar(char ch, char mirrored_ch)
	{
		return PangoGlobalFunctionsExterns.pango_get_mirror_char(ch, mirrored_ch);
	}

	public static MentorLake.Pango.PangoGravity GravityGetForMatrix(MentorLake.Pango.PangoMatrixHandle matrix)
	{
		return PangoGlobalFunctionsExterns.pango_gravity_get_for_matrix(matrix);
	}

	public static MentorLake.Pango.PangoGravity GravityGetForScript(MentorLake.Pango.PangoScript script, MentorLake.Pango.PangoGravity base_gravity, MentorLake.Pango.PangoGravityHint hint)
	{
		return PangoGlobalFunctionsExterns.pango_gravity_get_for_script(script, base_gravity, hint);
	}

	public static MentorLake.Pango.PangoGravity GravityGetForScriptAndWidth(MentorLake.Pango.PangoScript script, bool wide, MentorLake.Pango.PangoGravity base_gravity, MentorLake.Pango.PangoGravityHint hint)
	{
		return PangoGlobalFunctionsExterns.pango_gravity_get_for_script_and_width(script, wide, base_gravity, hint);
	}

	public static double GravityToRotation(MentorLake.Pango.PangoGravity gravity)
	{
		return PangoGlobalFunctionsExterns.pango_gravity_to_rotation(gravity);
	}

	public static bool IsZeroWidth(char ch)
	{
		return PangoGlobalFunctionsExterns.pango_is_zero_width(ch);
	}

	public static MentorLake.GLib.GListHandle Itemize(MentorLake.Pango.PangoContextHandle context, string text, int start_index, int length, MentorLake.Pango.PangoAttrListHandle attrs, MentorLake.Pango.PangoAttrIteratorHandle cached_iter)
	{
		return PangoGlobalFunctionsExterns.pango_itemize(context, text, start_index, length, attrs, cached_iter);
	}

	public static MentorLake.GLib.GListHandle ItemizeWithBaseDir(MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoDirection base_dir, string text, int start_index, int length, MentorLake.Pango.PangoAttrListHandle attrs, MentorLake.Pango.PangoAttrIteratorHandle cached_iter)
	{
		return PangoGlobalFunctionsExterns.pango_itemize_with_base_dir(context, base_dir, text, start_index, length, attrs, cached_iter);
	}

	public static MentorLake.Pango.PangoLanguageHandle LanguageFromString(string language)
	{
		return PangoGlobalFunctionsExterns.pango_language_from_string(language);
	}

	public static MentorLake.Pango.PangoLanguageHandle LanguageGetDefault()
	{
		return PangoGlobalFunctionsExterns.pango_language_get_default();
	}

	public static MentorLake.Pango.PangoLanguageHandle[] LanguageGetPreferred()
	{
		return PangoGlobalFunctionsExterns.pango_language_get_preferred();
	}

	public static MentorLake.GLib.GQuark LayoutDeserializeErrorQuark()
	{
		return PangoGlobalFunctionsExterns.pango_layout_deserialize_error_quark();
	}

	public static byte Log2VisGetEmbeddingLevels(string text, int length, ref MentorLake.Pango.PangoDirection pbase_dir)
	{
		return PangoGlobalFunctionsExterns.pango_log2vis_get_embedding_levels(text, length, ref pbase_dir);
	}

	public static bool MarkupParserFinish(MentorLake.GLib.GMarkupParseContextHandle context, out MentorLake.Pango.PangoAttrListHandle attr_list, out string text, out char accel_char)
	{
		var externCallResult = PangoGlobalFunctionsExterns.pango_markup_parser_finish(context, out attr_list, out text, out accel_char, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GMarkupParseContextHandle MarkupParserNew(char accel_marker)
	{
		return PangoGlobalFunctionsExterns.pango_markup_parser_new(accel_marker);
	}

	public static bool ParseEnum(MentorLake.GObject.GType type, string str, out int value, bool warn, out string possible_values)
	{
		return PangoGlobalFunctionsExterns.pango_parse_enum(type, str, out value, warn, out possible_values);
	}

	public static bool ParseMarkup(string markup_text, int length, char accel_marker, out MentorLake.Pango.PangoAttrListHandle attr_list, out string text, out char accel_char)
	{
		var externCallResult = PangoGlobalFunctionsExterns.pango_parse_markup(markup_text, length, accel_marker, out attr_list, out text, out accel_char, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool ParseStretch(string str, out MentorLake.Pango.PangoStretch stretch, bool warn)
	{
		return PangoGlobalFunctionsExterns.pango_parse_stretch(str, out stretch, warn);
	}

	public static bool ParseStyle(string str, out MentorLake.Pango.PangoStyle style, bool warn)
	{
		return PangoGlobalFunctionsExterns.pango_parse_style(str, out style, warn);
	}

	public static bool ParseVariant(string str, out MentorLake.Pango.PangoVariant variant, bool warn)
	{
		return PangoGlobalFunctionsExterns.pango_parse_variant(str, out variant, warn);
	}

	public static bool ParseWeight(string str, out MentorLake.Pango.PangoWeight weight, bool warn)
	{
		return PangoGlobalFunctionsExterns.pango_parse_weight(str, out weight, warn);
	}

	public static void QuantizeLineGeometry(ref int thickness, ref int position)
	{
		PangoGlobalFunctionsExterns.pango_quantize_line_geometry(ref thickness, ref position);
	}

	public static int ReadLine(IntPtr stream, MentorLake.GLib.GStringHandle str)
	{
		return PangoGlobalFunctionsExterns.pango_read_line(stream, str);
	}

	public static MentorLake.GLib.GListHandle ReorderItems(MentorLake.GLib.GListHandle items)
	{
		return PangoGlobalFunctionsExterns.pango_reorder_items(items);
	}

	public static bool ScanInt(ref string pos, out int @out)
	{
		return PangoGlobalFunctionsExterns.pango_scan_int(ref pos, out @out);
	}

	public static bool ScanString(ref string pos, MentorLake.GLib.GStringHandle @out)
	{
		return PangoGlobalFunctionsExterns.pango_scan_string(ref pos, @out);
	}

	public static bool ScanWord(ref string pos, MentorLake.GLib.GStringHandle @out)
	{
		return PangoGlobalFunctionsExterns.pango_scan_word(ref pos, @out);
	}

	public static MentorLake.Pango.PangoScript ScriptForUnichar(char ch)
	{
		return PangoGlobalFunctionsExterns.pango_script_for_unichar(ch);
	}

	public static MentorLake.Pango.PangoLanguageHandle ScriptGetSampleLanguage(MentorLake.Pango.PangoScript script)
	{
		return PangoGlobalFunctionsExterns.pango_script_get_sample_language(script);
	}

	public static void Shape(string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		PangoGlobalFunctionsExterns.pango_shape(text, length, analysis, glyphs);
	}

	public static void ShapeFull(string item_text, int item_length, string paragraph_text, int paragraph_length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		PangoGlobalFunctionsExterns.pango_shape_full(item_text, item_length, paragraph_text, paragraph_length, analysis, glyphs);
	}

	public static void ShapeItem(MentorLake.Pango.PangoItemHandle item, string paragraph_text, int paragraph_length, MentorLake.Pango.PangoLogAttrHandle log_attrs, MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoShapeFlags flags)
	{
		PangoGlobalFunctionsExterns.pango_shape_item(item, paragraph_text, paragraph_length, log_attrs, glyphs, flags);
	}

	public static void ShapeWithFlags(string item_text, int item_length, string paragraph_text, int paragraph_length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoShapeFlags flags)
	{
		PangoGlobalFunctionsExterns.pango_shape_with_flags(item_text, item_length, paragraph_text, paragraph_length, analysis, glyphs, flags);
	}

	public static bool SkipSpace(ref string pos)
	{
		return PangoGlobalFunctionsExterns.pango_skip_space(ref pos);
	}

	public static string[] SplitFileList(string str)
	{
		return PangoGlobalFunctionsExterns.pango_split_file_list(str);
	}

	public static MentorLake.Pango.PangoTabArrayHandle TabArrayFromString(string text)
	{
		return PangoGlobalFunctionsExterns.pango_tab_array_from_string(text);
	}

	public static void TailorBreak(string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, int offset, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_tailor_break(text, length, analysis, offset, attrs, attrs_len);
	}

	public static string TrimString(string str)
	{
		return PangoGlobalFunctionsExterns.pango_trim_string(str);
	}

	public static MentorLake.Pango.PangoDirection UnicharDirection(char ch)
	{
		return PangoGlobalFunctionsExterns.pango_unichar_direction(ch);
	}

	public static int UnitsFromDouble(double d)
	{
		return PangoGlobalFunctionsExterns.pango_units_from_double(d);
	}

	public static double UnitsToDouble(int i)
	{
		return PangoGlobalFunctionsExterns.pango_units_to_double(i);
	}

	public static int Version()
	{
		return PangoGlobalFunctionsExterns.pango_version();
	}

	public static string VersionCheck(int required_major, int required_minor, int required_micro)
	{
		return PangoGlobalFunctionsExterns.pango_version_check(required_major, required_minor, required_micro);
	}

	public static string VersionString()
	{
		return PangoGlobalFunctionsExterns.pango_version_string();
	}

}

internal class PangoGlobalFunctionsExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_allow_breaks_new(bool allow_breaks);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_background_alpha_new(ushort alpha);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_background_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_baseline_shift_new(int shift);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_break(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attr_list, int offset, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_fallback_new(bool enable_fallback);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_family_new(string family);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_font_desc_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_font_features_new(string features);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_font_scale_new(MentorLake.Pango.PangoFontScale scale);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_foreground_alpha_new(ushort alpha);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_foreground_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_gravity_hint_new(MentorLake.Pango.PangoGravityHint hint);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_gravity_new(MentorLake.Pango.PangoGravity gravity);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_insert_hyphens_new(bool insert_hyphens);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_language_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_letter_spacing_new(int letter_spacing);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_line_height_new(double factor);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_line_height_new_absolute(int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_from_string(string text);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_overline_color_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_overline_new(MentorLake.Pango.PangoOverline overline);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_rise_new(int rise);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_scale_new(double scale_factor);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_sentence_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_shape_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle ink_rect, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_shape_new_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle ink_rect, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle logical_rect, IntPtr data, MentorLake.Pango.PangoAttrDataCopyFunc copy_func, MentorLake.GLib.GDestroyNotify destroy_func);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_show_new(MentorLake.Pango.PangoShowFlags flags);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_size_new(int size);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_size_new_absolute(int size);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_stretch_new(MentorLake.Pango.PangoStretch stretch);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_strikethrough_color_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_strikethrough_new(bool strikethrough);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_style_new(MentorLake.Pango.PangoStyle style);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_text_transform_new(MentorLake.Pango.PangoTextTransform transform);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_attr_type_get_name(MentorLake.Pango.PangoAttrType type);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttrType pango_attr_type_register(string name);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_underline_color_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_underline_new(MentorLake.Pango.PangoUnderline underline);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_variant_new(MentorLake.Pango.PangoVariant variant);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_weight_new(MentorLake.Pango.PangoWeight weight);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_word_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoBidiType pango_bidi_type_for_unichar(char ch);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_break(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_default_break(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLogAttrHandle>))] MentorLake.Pango.PangoLogAttrHandle attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_extents_to_pixels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle inclusive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle nearest);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection pango_find_base_dir(string text, int length);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_find_paragraph_boundary(string text, int length, out int paragraph_delimiter_index, out int next_paragraph_start);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_from_string(string str);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_get_log_attrs(string text, int length, int level, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_get_mirror_char(char ch, char mirrored_ch);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_gravity_get_for_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_gravity_get_for_script(MentorLake.Pango.PangoScript script, MentorLake.Pango.PangoGravity base_gravity, MentorLake.Pango.PangoGravityHint hint);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_gravity_get_for_script_and_width(MentorLake.Pango.PangoScript script, bool wide, MentorLake.Pango.PangoGravity base_gravity, MentorLake.Pango.PangoGravityHint hint);

	[DllImport(PangoLibrary.Name)]
	internal static extern double pango_gravity_to_rotation(MentorLake.Pango.PangoGravity gravity);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_is_zero_width(char ch);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle pango_itemize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, string text, int start_index, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle cached_iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle pango_itemize_with_base_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoDirection base_dir, string text, int start_index, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle cached_iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_language_from_string(string language);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_language_get_default();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle[] pango_language_get_preferred();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark pango_layout_deserialize_error_quark();

	[DllImport(PangoLibrary.Name)]
	internal static extern byte pango_log2vis_get_embedding_levels(string text, int length, ref MentorLake.Pango.PangoDirection pbase_dir);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_markup_parser_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] out MentorLake.Pango.PangoAttrListHandle attr_list, out string text, out char accel_char, out MentorLake.GLib.GErrorHandle error);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GMarkupParseContextHandle pango_markup_parser_new(char accel_marker);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_enum(MentorLake.GObject.GType type, string str, out int value, bool warn, out string possible_values);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_markup(string markup_text, int length, char accel_marker, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] out MentorLake.Pango.PangoAttrListHandle attr_list, out string text, out char accel_char, out MentorLake.GLib.GErrorHandle error);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_stretch(string str, out MentorLake.Pango.PangoStretch stretch, bool warn);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_style(string str, out MentorLake.Pango.PangoStyle style, bool warn);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_variant(string str, out MentorLake.Pango.PangoVariant variant, bool warn);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_weight(string str, out MentorLake.Pango.PangoWeight weight, bool warn);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_quantize_line_geometry(ref int thickness, ref int position);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_read_line(IntPtr stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle str);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle pango_reorder_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle items);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_scan_int(ref string pos, out int @out);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_scan_string(ref string pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @out);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_scan_word(ref string pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @out);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoScript pango_script_for_unichar(char ch);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_script_get_sample_language(MentorLake.Pango.PangoScript script);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_shape(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_shape_full(string item_text, int item_length, string paragraph_text, int paragraph_length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_shape_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item, string paragraph_text, int paragraph_length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLogAttrHandle>))] MentorLake.Pango.PangoLogAttrHandle log_attrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoShapeFlags flags);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_shape_with_flags(string item_text, int item_length, string paragraph_text, int paragraph_length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoShapeFlags flags);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_skip_space(ref string pos);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] pango_split_file_list(string str);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoTabArrayHandle pango_tab_array_from_string(string text);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tailor_break(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, int offset, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_trim_string(string str);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection pango_unichar_direction(char ch);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_units_from_double(double d);

	[DllImport(PangoLibrary.Name)]
	internal static extern double pango_units_to_double(int i);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_version();

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_version_check(int required_major, int required_minor, int required_micro);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_version_string();

}
