namespace MentorLake.HarfBuzz;

public class HarfBuzzGlobalFunctions
{
	public static MentorLake.HarfBuzz.hb_ot_name_id_t AatLayoutFeatureTypeGetNameId(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_aat_layout_feature_type_t feature_type)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_feature_type_get_name_id(face, feature_type);
	}

	public static uint AatLayoutFeatureTypeGetSelectorInfos(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_aat_layout_feature_type_t feature_type, uint start_offset, out uint selector_count, out MentorLake.HarfBuzz.hb_aat_layout_feature_selector_info_t[] selectors, out uint default_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_feature_type_get_selector_infos(face, feature_type, start_offset, out selector_count, out selectors, out default_index);
	}

	public static uint AatLayoutGetFeatureTypes(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_aat_layout_feature_type_t[] features)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_get_feature_types(face, start_offset, out feature_count, out features);
	}

	public static MentorLake.HarfBuzz.hb_bool_t AatLayoutHasPositioning(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_has_positioning(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t AatLayoutHasSubstitution(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_has_substitution(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t AatLayoutHasTracking(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_has_tracking(face);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCopyWritableOrFail(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_copy_writable_or_fail(blob);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreate(string data, uint length, MentorLake.HarfBuzz.hb_memory_mode_t mode, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create(data, length, mode, user_data, destroy);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreateFromFile(string file_name)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create_from_file(file_name);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreateFromFileOrFail(string file_name)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create_from_file_or_fail(file_name);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreateOrFail(string data, uint length, MentorLake.HarfBuzz.hb_memory_mode_t mode, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create_or_fail(data, length, mode, user_data, destroy);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreateSubBlob(MentorLake.HarfBuzz.hb_blob_tHandle parent, uint offset, uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create_sub_blob(parent, offset, length);
	}

	public static void BlobDestroy(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		HarfBuzzGlobalFunctionsExterns.hb_blob_destroy(blob);
	}

	public static string[] BlobGetData(MentorLake.HarfBuzz.hb_blob_tHandle blob, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_data(blob, out length);
	}

	public static string[] BlobGetDataWritable(MentorLake.HarfBuzz.hb_blob_tHandle blob, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_data_writable(blob, out length);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_empty();
	}

	public static uint BlobGetLength(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_length(blob);
	}

	public static IntPtr BlobGetUserData(MentorLake.HarfBuzz.hb_blob_tHandle blob, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_user_data(blob, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BlobIsImmutable(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_is_immutable(blob);
	}

	public static void BlobMakeImmutable(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		HarfBuzzGlobalFunctionsExterns.hb_blob_make_immutable(blob);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobReference(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_reference(blob);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BlobSetUserData(MentorLake.HarfBuzz.hb_blob_tHandle blob, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_set_user_data(blob, key, data, destroy, replace);
	}

	public static void BufferAdd(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t codepoint, uint cluster)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add(buffer, codepoint, cluster);
	}

	public static void BufferAddCodepoints(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_codepoints(buffer, text, text_length, item_offset, item_length);
	}

	public static void BufferAddLatin1(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, byte[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_latin1(buffer, text, text_length, item_offset, item_length);
	}

	public static void BufferAddUtf16(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, ushort[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_utf16(buffer, text, text_length, item_offset, item_length);
	}

	public static void BufferAddUtf32(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_utf32(buffer, text, text_length, item_offset, item_length);
	}

	public static void BufferAddUtf8(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, byte[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_utf8(buffer, text, text_length, item_offset, item_length);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BufferAllocationSuccessful(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_allocation_successful(buffer);
	}

	public static void BufferAppend(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_tHandle source, uint start, uint end)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_append(buffer, source, start, end);
	}

	public static void BufferClearContents(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_clear_contents(buffer);
	}

	public static MentorLake.HarfBuzz.hb_buffer_tHandle BufferCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_create();
	}

	public static MentorLake.HarfBuzz.hb_buffer_tHandle BufferCreateSimilar(MentorLake.HarfBuzz.hb_buffer_tHandle src)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_create_similar(src);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BufferDeserializeGlyphs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, string[] buf, int buf_len, out string end_ptr, MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_deserialize_glyphs(buffer, buf, buf_len, out end_ptr, font, format);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BufferDeserializeUnicode(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, string[] buf, int buf_len, out string end_ptr, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_deserialize_unicode(buffer, buf, buf_len, out end_ptr, format);
	}

	public static void BufferDestroy(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_destroy(buffer);
	}

	public static MentorLake.HarfBuzz.hb_buffer_diff_flags_t BufferDiff(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_tHandle reference, MentorLake.HarfBuzz.hb_codepoint_t dottedcircle_glyph, uint position_fuzz)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_diff(buffer, reference, dottedcircle_glyph, position_fuzz);
	}

	public static MentorLake.HarfBuzz.hb_buffer_cluster_level_t BufferGetClusterLevel(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_cluster_level(buffer);
	}

	public static MentorLake.HarfBuzz.hb_buffer_content_type_t BufferGetContentType(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_content_type(buffer);
	}

	public static MentorLake.HarfBuzz.hb_direction_t BufferGetDirection(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_direction(buffer);
	}

	public static MentorLake.HarfBuzz.hb_buffer_tHandle BufferGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_empty();
	}

	public static MentorLake.HarfBuzz.hb_buffer_flags_t BufferGetFlags(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_flags(buffer);
	}

	public static MentorLake.HarfBuzz.hb_glyph_info_t[] BufferGetGlyphInfos(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_glyph_infos(buffer, out length);
	}

	public static MentorLake.HarfBuzz.hb_glyph_position_t[] BufferGetGlyphPositions(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_glyph_positions(buffer, out length);
	}

	public static MentorLake.HarfBuzz.hb_codepoint_t BufferGetInvisibleGlyph(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_invisible_glyph(buffer);
	}

	public static MentorLake.HarfBuzz.hb_language_t BufferGetLanguage(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_language(buffer);
	}

	public static uint BufferGetLength(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_length(buffer);
	}

	public static MentorLake.HarfBuzz.hb_codepoint_t BufferGetNotFoundGlyph(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_not_found_glyph(buffer);
	}

	public static uint BufferGetRandomState(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_random_state(buffer);
	}

	public static MentorLake.HarfBuzz.hb_codepoint_t BufferGetReplacementCodepoint(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_replacement_codepoint(buffer);
	}

	public static MentorLake.HarfBuzz.hb_script_t BufferGetScript(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_script(buffer);
	}

	public static void BufferGetSegmentProperties(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out MentorLake.HarfBuzz.hb_segment_properties_t props)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_get_segment_properties(buffer, out props);
	}

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle BufferGetUnicodeFuncs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_unicode_funcs(buffer);
	}

	public static IntPtr BufferGetUserData(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_user_data(buffer, key);
	}

	public static void BufferGuessSegmentProperties(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_guess_segment_properties(buffer);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BufferHasPositions(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_has_positions(buffer);
	}

	public static void BufferNormalizeGlyphs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_normalize_glyphs(buffer);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BufferPreAllocate(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint size)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_pre_allocate(buffer, size);
	}

	public static MentorLake.HarfBuzz.hb_buffer_tHandle BufferReference(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_reference(buffer);
	}

	public static void BufferReset(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_reset(buffer);
	}

	public static void BufferReverse(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_reverse(buffer);
	}

	public static void BufferReverseClusters(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_reverse_clusters(buffer);
	}

	public static void BufferReverseRange(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_reverse_range(buffer, start, end);
	}

	public static uint BufferSerialize(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize(buffer, start, end, out buf, out buf_size, out buf_consumed, font, format, flags);
	}

	public static MentorLake.HarfBuzz.hb_buffer_serialize_format_t BufferSerializeFormatFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_format_from_string(str, len);
	}

	public static string BufferSerializeFormatToString(MentorLake.HarfBuzz.hb_buffer_serialize_format_t format)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_format_to_string(format);
	}

	public static uint BufferSerializeGlyphs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_glyphs(buffer, start, end, out buf, out buf_size, out buf_consumed, font, format, flags);
	}

	public static string[] BufferSerializeListFormats()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_list_formats();
	}

	public static uint BufferSerializeUnicode(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_unicode(buffer, start, end, out buf, out buf_size, out buf_consumed, format, flags);
	}

	public static void BufferSetClusterLevel(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_cluster_level_t cluster_level)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_cluster_level(buffer, cluster_level);
	}

	public static void BufferSetContentType(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_content_type_t content_type)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_content_type(buffer, content_type);
	}

	public static void BufferSetDirection(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_direction_t direction)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_direction(buffer, direction);
	}

	public static void BufferSetFlags(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_flags_t flags)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_flags(buffer, flags);
	}

	public static void BufferSetInvisibleGlyph(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t invisible)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_invisible_glyph(buffer, invisible);
	}

	public static void BufferSetLanguage(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_language_t language)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_language(buffer, language);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BufferSetLength(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_set_length(buffer, length);
	}

	public static void BufferSetMessageFunc(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_message_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_message_func(buffer, func, user_data, destroy);
	}

	public static void BufferSetNotFoundGlyph(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t not_found)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_not_found_glyph(buffer, not_found);
	}

	public static void BufferSetRandomState(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint state)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_random_state(buffer, state);
	}

	public static void BufferSetReplacementCodepoint(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t replacement)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_replacement_codepoint(buffer, replacement);
	}

	public static void BufferSetScript(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_script_t script)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_script(buffer, script);
	}

	public static void BufferSetSegmentProperties(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_segment_properties_tHandle props)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_segment_properties(buffer, props);
	}

	public static void BufferSetUnicodeFuncs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_unicode_funcs_tHandle unicode_funcs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_unicode_funcs(buffer, unicode_funcs);
	}

	public static MentorLake.HarfBuzz.hb_bool_t BufferSetUserData(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_set_user_data(buffer, key, data, destroy, replace);
	}

	public static byte ColorGetAlpha(MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_get_alpha(color);
	}

	public static byte ColorGetBlue(MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_get_blue(color);
	}

	public static byte ColorGetGreen(MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_get_green(color);
	}

	public static byte ColorGetRed(MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_get_red(color);
	}

	public static uint ColorLineGetColorStops(MentorLake.HarfBuzz.hb_color_line_tHandle color_line, uint start, out uint count, out MentorLake.HarfBuzz.hb_color_stop_t[] color_stops)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_line_get_color_stops(color_line, start, out count, out color_stops);
	}

	public static MentorLake.HarfBuzz.hb_paint_extend_t ColorLineGetExtend(MentorLake.HarfBuzz.hb_color_line_tHandle color_line)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_line_get_extend(color_line);
	}

	public static MentorLake.HarfBuzz.hb_direction_t DirectionFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_direction_from_string(str, len);
	}

	public static string DirectionToString(MentorLake.HarfBuzz.hb_direction_t direction)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_direction_to_string(direction);
	}

	public static void DrawClosePath(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_close_path(dfuncs, draw_data, st);
	}

	public static void DrawCubicTo(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_cubic_to(dfuncs, draw_data, st, control1_x, control1_y, control2_x, control2_y, to_x, to_y);
	}

	public static MentorLake.HarfBuzz.hb_draw_funcs_tHandle DrawFuncsCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_create();
	}

	public static void DrawFuncsDestroy(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_destroy(dfuncs);
	}

	public static MentorLake.HarfBuzz.hb_draw_funcs_tHandle DrawFuncsGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_get_empty();
	}

	public static IntPtr DrawFuncsGetUserData(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_get_user_data(dfuncs, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t DrawFuncsIsImmutable(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_is_immutable(dfuncs);
	}

	public static void DrawFuncsMakeImmutable(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_make_immutable(dfuncs);
	}

	public static MentorLake.HarfBuzz.hb_draw_funcs_tHandle DrawFuncsReference(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_reference(dfuncs);
	}

	public static void DrawFuncsSetClosePathFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_close_path_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_close_path_func(dfuncs, func, user_data, destroy);
	}

	public static void DrawFuncsSetCubicToFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_cubic_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_cubic_to_func(dfuncs, func, user_data, destroy);
	}

	public static void DrawFuncsSetLineToFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_line_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_line_to_func(dfuncs, func, user_data, destroy);
	}

	public static void DrawFuncsSetMoveToFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_move_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_move_to_func(dfuncs, func, user_data, destroy);
	}

	public static void DrawFuncsSetQuadraticToFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_quadratic_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_quadratic_to_func(dfuncs, func, user_data, destroy);
	}

	public static MentorLake.HarfBuzz.hb_bool_t DrawFuncsSetUserData(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_user_data(dfuncs, key, data, destroy, replace);
	}

	public static void DrawLineTo(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st, float to_x, float to_y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_line_to(dfuncs, draw_data, st, to_x, to_y);
	}

	public static void DrawMoveTo(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st, float to_x, float to_y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_move_to(dfuncs, draw_data, st, to_x, to_y);
	}

	public static void DrawQuadraticTo(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st, float control_x, float control_y, float to_x, float to_y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_quadratic_to(dfuncs, draw_data, st, control_x, control_y, to_x, to_y);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FaceBuilderAddTable(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t tag, MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_builder_add_table(face, tag, blob);
	}

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceBuilderCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_builder_create();
	}

	public static void FaceBuilderSortTables(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t[] tags)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_builder_sort_tables(face, tags);
	}

	public static void FaceCollectNominalGlyphMapping(MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_map_t mapping, out MentorLake.HarfBuzz.hb_set_t unicodes)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_collect_nominal_glyph_mapping(face, out mapping, out unicodes);
	}

	public static void FaceCollectUnicodes(MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_set_t @out)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_collect_unicodes(face, out @out);
	}

	public static void FaceCollectVariationSelectors(MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_set_t @out)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_collect_variation_selectors(face, out @out);
	}

	public static void FaceCollectVariationUnicodes(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_set_t @out)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_collect_variation_unicodes(face, variation_selector, out @out);
	}

	public static uint FaceCount(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_count(blob);
	}

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceCreate(MentorLake.HarfBuzz.hb_blob_tHandle blob, uint index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_create(blob, index);
	}

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceCreateForTables(MentorLake.HarfBuzz.hb_reference_table_func_t reference_table_func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_create_for_tables(reference_table_func, user_data, destroy);
	}

	public static void FaceDestroy(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_destroy(face);
	}

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_empty();
	}

	public static uint FaceGetGlyphCount(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_glyph_count(face);
	}

	public static uint FaceGetIndex(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_index(face);
	}

	public static uint FaceGetTableTags(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint table_count, out MentorLake.HarfBuzz.hb_tag_t[] table_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_table_tags(face, start_offset, out table_count, out table_tags);
	}

	public static uint FaceGetUpem(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_upem(face);
	}

	public static IntPtr FaceGetUserData(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_user_data(face, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FaceIsImmutable(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_is_immutable(face);
	}

	public static void FaceMakeImmutable(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_make_immutable(face);
	}

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceReference(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_reference(face);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle FaceReferenceBlob(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_reference_blob(face);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle FaceReferenceTable(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_reference_table(face, tag);
	}

	public static void FaceSetGlyphCount(MentorLake.HarfBuzz.hb_face_tHandle face, uint glyph_count)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_set_glyph_count(face, glyph_count);
	}

	public static void FaceSetIndex(MentorLake.HarfBuzz.hb_face_tHandle face, uint index)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_set_index(face, index);
	}

	public static void FaceSetUpem(MentorLake.HarfBuzz.hb_face_tHandle face, uint upem)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_set_upem(face, upem);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FaceSetUserData(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_set_user_data(face, key, data, destroy, replace);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FeatureFromString(byte[] str, int len, out MentorLake.HarfBuzz.hb_feature_t feature)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_feature_from_string(str, len, out feature);
	}

	public static void FeatureToString(MentorLake.HarfBuzz.hb_feature_tHandle feature, out string[] buf, out uint size)
	{
		HarfBuzzGlobalFunctionsExterns.hb_feature_to_string(feature, out buf, out size);
	}

	public static void FontAddGlyphOriginForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, ref MentorLake.HarfBuzz.hb_position_t x, ref MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_add_glyph_origin_for_direction(font, glyph, direction, ref x, ref y);
	}

	public static void FontChanged(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_changed(font);
	}

	public static MentorLake.HarfBuzz.hb_font_tHandle FontCreate(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_create(face);
	}

	public static MentorLake.HarfBuzz.hb_font_tHandle FontCreateSubFont(MentorLake.HarfBuzz.hb_font_tHandle parent)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_create_sub_font(parent);
	}

	public static void FontDestroy(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_destroy(font);
	}

	public static void FontDrawGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_draw_glyph(font, glyph, dfuncs, draw_data);
	}

	public static MentorLake.HarfBuzz.hb_font_funcs_tHandle FontFuncsCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_create();
	}

	public static void FontFuncsDestroy(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_destroy(ffuncs);
	}

	public static MentorLake.HarfBuzz.hb_font_funcs_tHandle FontFuncsGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_get_empty();
	}

	public static IntPtr FontFuncsGetUserData(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_get_user_data(ffuncs, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontFuncsIsImmutable(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_is_immutable(ffuncs);
	}

	public static void FontFuncsMakeImmutable(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_make_immutable(ffuncs);
	}

	public static MentorLake.HarfBuzz.hb_font_funcs_tHandle FontFuncsReference(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_reference(ffuncs);
	}

	public static void FontFuncsSetDrawGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_draw_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_draw_glyph_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetFontHExtentsFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_font_h_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_font_h_extents_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetFontVExtentsFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_font_v_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_font_v_extents_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphContourPointFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_contour_point_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_contour_point_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphExtentsFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_extents_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphFromNameFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_from_name_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_from_name_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphHAdvanceFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_advance_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_h_advance_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphHAdvancesFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_advances_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_h_advances_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphHKerningFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_kerning_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_h_kerning_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphHOriginFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_origin_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_h_origin_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphNameFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_name_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_name_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphShapeFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_shape_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_shape_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphVAdvanceFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_advance_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_v_advance_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphVAdvancesFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_advances_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_v_advances_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphVKerningFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_kerning_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_v_kerning_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetGlyphVOriginFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_origin_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_v_origin_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetNominalGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_nominal_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_nominal_glyph_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetNominalGlyphsFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_nominal_glyphs_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_nominal_glyphs_func(ffuncs, func, user_data, destroy);
	}

	public static void FontFuncsSetPaintGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_paint_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_paint_glyph_func(ffuncs, func, user_data, destroy);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontFuncsSetUserData(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_user_data(ffuncs, key, data, destroy, replace);
	}

	public static void FontFuncsSetVariationGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_variation_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_variation_glyph_func(ffuncs, func, user_data, destroy);
	}

	public static MentorLake.HarfBuzz.hb_font_tHandle FontGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_empty();
	}

	public static void FontGetExtentsForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_extents_for_direction(font, direction, out extents);
	}

	public static MentorLake.HarfBuzz.hb_face_tHandle FontGetFace(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_face(font);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph(font, unicode, variation_selector, out glyph);
	}

	public static void FontGetGlyphAdvanceForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_advance_for_direction(font, glyph, direction, out x, out y);
	}

	public static void FontGetGlyphAdvancesForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, uint count, MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, out uint advance_stride)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_advances_for_direction(font, direction, count, first_glyph, glyph_stride, out first_advance, out advance_stride);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphContourPoint(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint point_index, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_contour_point(font, glyph, point_index, out x, out y);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphContourPointForOrigin(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint point_index, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_contour_point_for_origin(font, glyph, point_index, direction, out x, out y);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphExtents(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_glyph_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_extents(font, glyph, out extents);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphExtentsForOrigin(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_glyph_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_extents_for_origin(font, glyph, direction, out extents);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphFromName(MentorLake.HarfBuzz.hb_font_tHandle font, string[] name, int len, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_from_name(font, name, len, out glyph);
	}

	public static MentorLake.HarfBuzz.hb_position_t FontGetGlyphHAdvance(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_h_advance(font, glyph);
	}

	public static void FontGetGlyphHAdvances(MentorLake.HarfBuzz.hb_font_tHandle font, uint count, MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, uint advance_stride)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_h_advances(font, count, first_glyph, glyph_stride, out first_advance, advance_stride);
	}

	public static MentorLake.HarfBuzz.hb_position_t FontGetGlyphHKerning(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t left_glyph, MentorLake.HarfBuzz.hb_codepoint_t right_glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_h_kerning(font, left_glyph, right_glyph);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphHOrigin(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_h_origin(font, glyph, out x, out y);
	}

	public static void FontGetGlyphKerningForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t first_glyph, MentorLake.HarfBuzz.hb_codepoint_t second_glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_kerning_for_direction(font, first_glyph, second_glyph, direction, out x, out y);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphName(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out string[] name, out uint size)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_name(font, glyph, out name, out size);
	}

	public static void FontGetGlyphOriginForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_origin_for_direction(font, glyph, direction, out x, out y);
	}

	public static void FontGetGlyphShape(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_shape(font, glyph, dfuncs, draw_data);
	}

	public static MentorLake.HarfBuzz.hb_position_t FontGetGlyphVAdvance(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_v_advance(font, glyph);
	}

	public static void FontGetGlyphVAdvances(MentorLake.HarfBuzz.hb_font_tHandle font, uint count, MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, out uint advance_stride)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_v_advances(font, count, first_glyph, glyph_stride, out first_advance, out advance_stride);
	}

	public static MentorLake.HarfBuzz.hb_position_t FontGetGlyphVKerning(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t top_glyph, MentorLake.HarfBuzz.hb_codepoint_t bottom_glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_v_kerning(font, top_glyph, bottom_glyph);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphVOrigin(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_v_origin(font, glyph, out x, out y);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetHExtents(MentorLake.HarfBuzz.hb_font_tHandle font, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_h_extents(font, out extents);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetNominalGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_nominal_glyph(font, unicode, out glyph);
	}

	public static uint FontGetNominalGlyphs(MentorLake.HarfBuzz.hb_font_tHandle font, uint count, MentorLake.HarfBuzz.hb_codepoint_tHandle first_unicode, uint unicode_stride, out MentorLake.HarfBuzz.hb_codepoint_t first_glyph, uint glyph_stride)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_nominal_glyphs(font, count, first_unicode, unicode_stride, out first_glyph, glyph_stride);
	}

	public static MentorLake.HarfBuzz.hb_font_tHandle FontGetParent(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_parent(font);
	}

	public static void FontGetPpem(MentorLake.HarfBuzz.hb_font_tHandle font, out uint x_ppem, out uint y_ppem)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_ppem(font, out x_ppem, out y_ppem);
	}

	public static float FontGetPtem(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_ptem(font);
	}

	public static void FontGetScale(MentorLake.HarfBuzz.hb_font_tHandle font, out int x_scale, out int y_scale)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_scale(font, out x_scale, out y_scale);
	}

	public static uint FontGetSerial(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_serial(font);
	}

	public static void FontGetSyntheticBold(MentorLake.HarfBuzz.hb_font_tHandle font, out float x_embolden, out float y_embolden, out MentorLake.HarfBuzz.hb_bool_t in_place)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_synthetic_bold(font, out x_embolden, out y_embolden, out in_place);
	}

	public static float FontGetSyntheticSlant(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_synthetic_slant(font);
	}

	public static IntPtr FontGetUserData(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_user_data(font, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetVExtents(MentorLake.HarfBuzz.hb_font_tHandle font, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_v_extents(font, out extents);
	}

	public static float FontGetVarCoordsDesign(MentorLake.HarfBuzz.hb_font_tHandle font, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_var_coords_design(font, out length);
	}

	public static int FontGetVarCoordsNormalized(MentorLake.HarfBuzz.hb_font_tHandle font, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_var_coords_normalized(font, out length);
	}

	public static uint FontGetVarNamedInstance(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_var_named_instance(font);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGetVariationGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_variation_glyph(font, unicode, variation_selector, out glyph);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontGlyphFromString(MentorLake.HarfBuzz.hb_font_tHandle font, byte[] s, int len, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_glyph_from_string(font, s, len, out glyph);
	}

	public static void FontGlyphToString(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out string[] s, out uint size)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_glyph_to_string(font, glyph, out s, out size);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontIsImmutable(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_is_immutable(font);
	}

	public static void FontMakeImmutable(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_make_immutable(font);
	}

	public static void FontPaintGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_paint_funcs_tHandle pfuncs, IntPtr paint_data, uint palette_index, MentorLake.HarfBuzz.hb_color_t foreground)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_paint_glyph(font, glyph, pfuncs, paint_data, palette_index, foreground);
	}

	public static MentorLake.HarfBuzz.hb_font_tHandle FontReference(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_reference(font);
	}

	public static void FontSetFace(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_face(font, face);
	}

	public static void FontSetFuncs(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_font_funcs_tHandle klass, IntPtr font_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_funcs(font, klass, font_data, destroy);
	}

	public static void FontSetFuncsData(MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_funcs_data(font, font_data, destroy);
	}

	public static void FontSetParent(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_font_tHandle parent)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_parent(font, parent);
	}

	public static void FontSetPpem(MentorLake.HarfBuzz.hb_font_tHandle font, uint x_ppem, uint y_ppem)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_ppem(font, x_ppem, y_ppem);
	}

	public static void FontSetPtem(MentorLake.HarfBuzz.hb_font_tHandle font, float ptem)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_ptem(font, ptem);
	}

	public static void FontSetScale(MentorLake.HarfBuzz.hb_font_tHandle font, int x_scale, int y_scale)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_scale(font, x_scale, y_scale);
	}

	public static void FontSetSyntheticBold(MentorLake.HarfBuzz.hb_font_tHandle font, float x_embolden, float y_embolden, MentorLake.HarfBuzz.hb_bool_t in_place)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_synthetic_bold(font, x_embolden, y_embolden, in_place);
	}

	public static void FontSetSyntheticSlant(MentorLake.HarfBuzz.hb_font_tHandle font, float slant)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_synthetic_slant(font, slant);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FontSetUserData(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_set_user_data(font, key, data, destroy, replace);
	}

	public static void FontSetVarCoordsDesign(MentorLake.HarfBuzz.hb_font_tHandle font, float[] coords, uint coords_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_var_coords_design(font, coords, coords_length);
	}

	public static void FontSetVarCoordsNormalized(MentorLake.HarfBuzz.hb_font_tHandle font, int[] coords, uint coords_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_var_coords_normalized(font, coords, coords_length);
	}

	public static void FontSetVarNamedInstance(MentorLake.HarfBuzz.hb_font_tHandle font, uint instance_index)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_var_named_instance(font, instance_index);
	}

	public static void FontSetVariation(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_tag_t tag, float value)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_variation(font, tag, value);
	}

	public static void FontSetVariations(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_variation_t[] variations, uint variations_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_variations(font, variations, variations_length);
	}

	public static void FontSubtractGlyphOriginForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, ref MentorLake.HarfBuzz.hb_position_t x, ref MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_subtract_glyph_origin_for_direction(font, glyph, direction, ref x, ref y);
	}

	public static void FtFontChanged(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ft_font_changed(font);
	}

	public static int FtFontGetLoadFlags(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ft_font_get_load_flags(font);
	}

	public static void FtFontSetFuncs(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ft_font_set_funcs(font);
	}

	public static void FtFontSetLoadFlags(MentorLake.HarfBuzz.hb_font_tHandle font, int load_flags)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ft_font_set_load_flags(font, load_flags);
	}

	public static void FtFontUnlockFace(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ft_font_unlock_face(font);
	}

	public static MentorLake.HarfBuzz.hb_bool_t FtHbFontChanged(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ft_hb_font_changed(font);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle GlibBlobCreate(MentorLake.GLib.GBytesHandle gbytes)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glib_blob_create(gbytes);
	}

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle GlibGetUnicodeFuncs()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glib_get_unicode_funcs();
	}

	public static MentorLake.GLib.GUnicodeScript GlibScriptFromScript(MentorLake.HarfBuzz.hb_script_t script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glib_script_from_script(script);
	}

	public static MentorLake.HarfBuzz.hb_script_t GlibScriptToScript(MentorLake.GLib.GUnicodeScript script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glib_script_to_script(script);
	}

	public static MentorLake.HarfBuzz.hb_glyph_flags_t GlyphInfoGetGlyphFlags(MentorLake.HarfBuzz.hb_glyph_info_tHandle info)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glyph_info_get_glyph_flags(info);
	}

	public static MentorLake.HarfBuzz.hb_language_t LanguageFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_language_from_string(str, len);
	}

	public static MentorLake.HarfBuzz.hb_language_t LanguageGetDefault()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_language_get_default();
	}

	public static MentorLake.HarfBuzz.hb_bool_t LanguageMatches(MentorLake.HarfBuzz.hb_language_t language, MentorLake.HarfBuzz.hb_language_t specific)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_language_matches(language, specific);
	}

	public static string LanguageToString(MentorLake.HarfBuzz.hb_language_t language)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_language_to_string(language);
	}

	public static MentorLake.HarfBuzz.hb_bool_t MapAllocationSuccessful(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_allocation_successful(map);
	}

	public static void MapClear(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_clear(map);
	}

	public static MentorLake.HarfBuzz.hb_map_tHandle MapCopy(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_copy(map);
	}

	public static MentorLake.HarfBuzz.hb_map_tHandle MapCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_create();
	}

	public static void MapDel(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_del(map, key);
	}

	public static void MapDestroy(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_destroy(map);
	}

	public static MentorLake.HarfBuzz.hb_codepoint_t MapGet(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_get(map, key);
	}

	public static MentorLake.HarfBuzz.hb_map_tHandle MapGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_get_empty();
	}

	public static uint MapGetPopulation(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_get_population(map);
	}

	public static IntPtr MapGetUserData(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_get_user_data(map, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t MapHas(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_has(map, key);
	}

	public static uint MapHash(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_hash(map);
	}

	public static MentorLake.HarfBuzz.hb_bool_t MapIsEmpty(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_is_empty(map);
	}

	public static MentorLake.HarfBuzz.hb_bool_t MapIsEqual(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_map_tHandle other)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_is_equal(map, other);
	}

	public static void MapKeys(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_set_tHandle keys)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_keys(map, keys);
	}

	public static MentorLake.HarfBuzz.hb_bool_t MapNext(MentorLake.HarfBuzz.hb_map_tHandle map, ref int idx, out MentorLake.HarfBuzz.hb_codepoint_t key, out MentorLake.HarfBuzz.hb_codepoint_t value)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_next(map, ref idx, out key, out value);
	}

	public static MentorLake.HarfBuzz.hb_map_tHandle MapReference(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_reference(map);
	}

	public static void MapSet(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key, MentorLake.HarfBuzz.hb_codepoint_t value)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_set(map, key, value);
	}

	public static MentorLake.HarfBuzz.hb_bool_t MapSetUserData(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_set_user_data(map, key, data, destroy, replace);
	}

	public static void MapUpdate(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_map_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_update(map, other);
	}

	public static void MapValues(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_set_tHandle values)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_values(map, values);
	}

	public static uint OtColorGlyphGetLayers(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint layer_count, out MentorLake.HarfBuzz.hb_ot_color_layer_t[] layers)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_glyph_get_layers(face, glyph, start_offset, out layer_count, out layers);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtColorGlyphHasPaint(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_glyph_has_paint(face, glyph);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle OtColorGlyphReferencePng(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_glyph_reference_png(font, glyph);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle OtColorGlyphReferenceSvg(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_glyph_reference_svg(face, glyph);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasLayers(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_layers(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasPaint(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_paint(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasPalettes(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_palettes(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasPng(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_png(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasSvg(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_svg(face);
	}

	public static MentorLake.HarfBuzz.hb_ot_name_id_t OtColorPaletteColorGetNameId(MentorLake.HarfBuzz.hb_face_tHandle face, uint color_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_color_get_name_id(face, color_index);
	}

	public static uint OtColorPaletteGetColors(MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index, uint start_offset, out uint color_count, out MentorLake.HarfBuzz.hb_color_t[] colors)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_get_colors(face, palette_index, start_offset, out color_count, out colors);
	}

	public static uint OtColorPaletteGetCount(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_get_count(face);
	}

	public static MentorLake.HarfBuzz.hb_ot_color_palette_flags_t OtColorPaletteGetFlags(MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_get_flags(face, palette_index);
	}

	public static MentorLake.HarfBuzz.hb_ot_name_id_t OtColorPaletteGetNameId(MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_get_name_id(face, palette_index);
	}

	public static void OtFontSetFuncs(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_font_set_funcs(font);
	}

	public static void OtLayoutCollectFeatures(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t[] scripts, MentorLake.HarfBuzz.hb_tag_t[] languages, MentorLake.HarfBuzz.hb_tag_t[] features, out MentorLake.HarfBuzz.hb_set_t feature_indexes)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_collect_features(face, table_tag, scripts, languages, features, out feature_indexes);
	}

	public static void OtLayoutCollectFeaturesMap(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out MentorLake.HarfBuzz.hb_map_t feature_map)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_collect_features_map(face, table_tag, script_index, language_index, out feature_map);
	}

	public static void OtLayoutCollectLookups(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t[] scripts, MentorLake.HarfBuzz.hb_tag_t[] languages, MentorLake.HarfBuzz.hb_tag_t[] features, out MentorLake.HarfBuzz.hb_set_t lookup_indexes)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_collect_lookups(face, table_tag, scripts, languages, features, out lookup_indexes);
	}

	public static uint OtLayoutFeatureGetCharacters(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint start_offset, out uint char_count, out MentorLake.HarfBuzz.hb_codepoint_t[] characters)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_feature_get_characters(face, table_tag, feature_index, start_offset, out char_count, out characters);
	}

	public static uint OtLayoutFeatureGetLookups(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint start_offset, out uint lookup_count, out uint[] lookup_indexes)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_feature_get_lookups(face, table_tag, feature_index, start_offset, out lookup_count, out lookup_indexes);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutFeatureGetNameIds(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, out MentorLake.HarfBuzz.hb_ot_name_id_t label_id, out MentorLake.HarfBuzz.hb_ot_name_id_t tooltip_id, out MentorLake.HarfBuzz.hb_ot_name_id_t sample_id, out uint num_named_parameters, out MentorLake.HarfBuzz.hb_ot_name_id_t first_param_id)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_feature_get_name_ids(face, table_tag, feature_index, out label_id, out tooltip_id, out sample_id, out num_named_parameters, out first_param_id);
	}

	public static uint OtLayoutFeatureWithVariationsGetLookups(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint variations_index, uint start_offset, out uint lookup_count, out uint[] lookup_indexes)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_feature_with_variations_get_lookups(face, table_tag, feature_index, variations_index, start_offset, out lookup_count, out lookup_indexes);
	}

	public static uint OtLayoutGetAttachPoints(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint point_count, out uint[] point_array)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_attach_points(face, glyph, start_offset, out point_count, out point_array);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetBaseline(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_position_t coord)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_baseline(font, baseline_tag, direction, script_tag, language_tag, out coord);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetBaseline2(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_position_t coord)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_baseline2(font, baseline_tag, direction, script, language, out coord);
	}

	public static void OtLayoutGetBaselineWithFallback(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_position_t coord)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_baseline_with_fallback(font, baseline_tag, direction, script_tag, language_tag, out coord);
	}

	public static void OtLayoutGetBaselineWithFallback2(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_position_t coord)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_baseline_with_fallback2(font, baseline_tag, direction, script, language, out coord);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetFontExtents(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_font_extents(font, direction, script_tag, language_tag, out extents);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetFontExtents2(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_font_extents2(font, direction, script, language, out extents);
	}

	public static MentorLake.HarfBuzz.hb_ot_layout_glyph_class_t OtLayoutGetGlyphClass(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_glyph_class(face, glyph);
	}

	public static void OtLayoutGetGlyphsInClass(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_layout_glyph_class_t klass, out MentorLake.HarfBuzz.hb_set_t glyphs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_glyphs_in_class(face, klass, out glyphs);
	}

	public static MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t OtLayoutGetHorizontalBaselineTagForScript(MentorLake.HarfBuzz.hb_script_t script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_horizontal_baseline_tag_for_script(script);
	}

	public static uint OtLayoutGetLigatureCarets(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint caret_count, out MentorLake.HarfBuzz.hb_position_t[] caret_array)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_ligature_carets(font, direction, glyph, start_offset, out caret_count, out caret_array);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetSizeParams(MentorLake.HarfBuzz.hb_face_tHandle face, out uint design_size, out uint subfamily_id, out MentorLake.HarfBuzz.hb_ot_name_id_t subfamily_name_id, out uint range_start, out uint range_end)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_size_params(face, out design_size, out subfamily_id, out subfamily_name_id, out range_start, out range_end);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutHasGlyphClasses(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_has_glyph_classes(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutHasPositioning(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_has_positioning(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutHasSubstitution(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_has_substitution(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutLanguageFindFeature(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, MentorLake.HarfBuzz.hb_tag_t feature_tag, out uint feature_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_find_feature(face, table_tag, script_index, language_index, feature_tag, out feature_index);
	}

	public static uint OtLayoutLanguageGetFeatureIndexes(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, uint start_offset, out uint feature_count, out uint[] feature_indexes)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_get_feature_indexes(face, table_tag, script_index, language_index, start_offset, out feature_count, out feature_indexes);
	}

	public static uint OtLayoutLanguageGetFeatureTags(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_tag_t[] feature_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_get_feature_tags(face, table_tag, script_index, language_index, start_offset, out feature_count, out feature_tags);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutLanguageGetRequiredFeature(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out uint feature_index, out MentorLake.HarfBuzz.hb_tag_t feature_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_get_required_feature(face, table_tag, script_index, language_index, out feature_index, out feature_tag);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutLanguageGetRequiredFeatureIndex(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out uint feature_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_get_required_feature_index(face, table_tag, script_index, language_index, out feature_index);
	}

	public static void OtLayoutLookupCollectGlyphs(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint lookup_index, out MentorLake.HarfBuzz.hb_set_t glyphs_before, out MentorLake.HarfBuzz.hb_set_t glyphs_input, out MentorLake.HarfBuzz.hb_set_t glyphs_after, out MentorLake.HarfBuzz.hb_set_t glyphs_output)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_collect_glyphs(face, table_tag, lookup_index, out glyphs_before, out glyphs_input, out glyphs_after, out glyphs_output);
	}

	public static uint OtLayoutLookupGetGlyphAlternates(MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint alternate_count, out MentorLake.HarfBuzz.hb_codepoint_t[] alternate_glyphs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_get_glyph_alternates(face, lookup_index, glyph, start_offset, out alternate_count, out alternate_glyphs);
	}

	public static MentorLake.HarfBuzz.hb_position_t OtLayoutLookupGetOpticalBound(MentorLake.HarfBuzz.hb_font_tHandle font, uint lookup_index, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_get_optical_bound(font, lookup_index, direction, glyph);
	}

	public static void OtLayoutLookupSubstituteClosure(MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, out MentorLake.HarfBuzz.hb_set_t glyphs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_substitute_closure(face, lookup_index, out glyphs);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutLookupWouldSubstitute(MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, MentorLake.HarfBuzz.hb_codepoint_tHandle glyphs, uint glyphs_length, MentorLake.HarfBuzz.hb_bool_t zero_context)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_would_substitute(face, lookup_index, glyphs, glyphs_length, zero_context);
	}

	public static void OtLayoutLookupsSubstituteClosure(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_set_tHandle lookups, out MentorLake.HarfBuzz.hb_set_t glyphs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookups_substitute_closure(face, lookups, out glyphs);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutScriptFindLanguage(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, MentorLake.HarfBuzz.hb_tag_t language_tag, uint language_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_script_find_language(face, table_tag, script_index, language_tag, language_index);
	}

	public static uint OtLayoutScriptGetLanguageTags(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint start_offset, out uint language_count, out MentorLake.HarfBuzz.hb_tag_t[] language_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_script_get_language_tags(face, table_tag, script_index, start_offset, out language_count, out language_tags);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutScriptSelectLanguage(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_count, MentorLake.HarfBuzz.hb_tag_tHandle language_tags, out uint language_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_script_select_language(face, table_tag, script_index, language_count, language_tags, out language_index);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutScriptSelectLanguage2(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_count, MentorLake.HarfBuzz.hb_tag_tHandle language_tags, out uint language_index, out MentorLake.HarfBuzz.hb_tag_t chosen_language)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_script_select_language2(face, table_tag, script_index, language_count, language_tags, out language_index, out chosen_language);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutTableChooseScript(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_tHandle script_tags, out uint script_index, out MentorLake.HarfBuzz.hb_tag_t chosen_script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_choose_script(face, table_tag, script_tags, out script_index, out chosen_script);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutTableFindFeatureVariations(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, int coords, uint num_coords, out uint variations_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_find_feature_variations(face, table_tag, coords, num_coords, out variations_index);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutTableFindScript(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t script_tag, out uint script_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_find_script(face, table_tag, script_tag, out script_index);
	}

	public static uint OtLayoutTableGetFeatureTags(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_tag_t[] feature_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_get_feature_tags(face, table_tag, start_offset, out feature_count, out feature_tags);
	}

	public static uint OtLayoutTableGetLookupCount(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_get_lookup_count(face, table_tag);
	}

	public static uint OtLayoutTableGetScriptTags(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint start_offset, out uint script_count, out MentorLake.HarfBuzz.hb_tag_t[] script_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_get_script_tags(face, table_tag, start_offset, out script_count, out script_tags);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutTableSelectScript(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_count, MentorLake.HarfBuzz.hb_tag_tHandle script_tags, out uint script_index, out MentorLake.HarfBuzz.hb_tag_t chosen_script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_select_script(face, table_tag, script_count, script_tags, out script_index, out chosen_script);
	}

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetConstant(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_math_constant_t constant)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_constant(font, constant);
	}

	public static uint OtMathGetGlyphAssembly(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, uint start_offset, out uint parts_count, out MentorLake.HarfBuzz.hb_ot_math_glyph_part_t[] parts, out MentorLake.HarfBuzz.hb_position_t italics_correction)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_assembly(font, glyph, direction, start_offset, out parts_count, out parts, out italics_correction);
	}

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetGlyphItalicsCorrection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_italics_correction(font, glyph);
	}

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetGlyphKerning(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_ot_math_kern_t kern, MentorLake.HarfBuzz.hb_position_t correction_height)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_kerning(font, glyph, kern, correction_height);
	}

	public static uint OtMathGetGlyphKernings(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_ot_math_kern_t kern, uint start_offset, out uint entries_count, out MentorLake.HarfBuzz.hb_ot_math_kern_entry_t[] kern_entries)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_kernings(font, glyph, kern, start_offset, out entries_count, out kern_entries);
	}

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetGlyphTopAccentAttachment(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_top_accent_attachment(font, glyph);
	}

	public static uint OtMathGetGlyphVariants(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, uint start_offset, out uint variants_count, out MentorLake.HarfBuzz.hb_ot_math_glyph_variant_t[] variants)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_variants(font, glyph, direction, start_offset, out variants_count, out variants);
	}

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetMinConnectorOverlap(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_min_connector_overlap(font, direction);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtMathHasData(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_has_data(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtMathIsGlyphExtendedShape(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_is_glyph_extended_shape(face, glyph);
	}

	public static uint OtMetaGetEntryTags(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint entries_count, out MentorLake.HarfBuzz.hb_ot_meta_tag_t[] entries)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_meta_get_entry_tags(face, start_offset, out entries_count, out entries);
	}

	public static MentorLake.HarfBuzz.hb_blob_tHandle OtMetaReferenceEntry(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_meta_tag_t meta_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_meta_reference_entry(face, meta_tag);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtMetricsGetPosition(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag, out MentorLake.HarfBuzz.hb_position_t position)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_position(font, metrics_tag, out position);
	}

	public static void OtMetricsGetPositionWithFallback(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag, out MentorLake.HarfBuzz.hb_position_t position)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_position_with_fallback(font, metrics_tag, out position);
	}

	public static float OtMetricsGetVariation(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_variation(font, metrics_tag);
	}

	public static MentorLake.HarfBuzz.hb_position_t OtMetricsGetXVariation(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_x_variation(font, metrics_tag);
	}

	public static MentorLake.HarfBuzz.hb_position_t OtMetricsGetYVariation(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_y_variation(font, metrics_tag);
	}

	public static uint OtNameGetUtf16(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out ushort[] text)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_name_get_utf16(face, name_id, language, out text_size, out text);
	}

	public static uint OtNameGetUtf32(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out uint[] text)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_name_get_utf32(face, name_id, language, out text_size, out text);
	}

	public static uint OtNameGetUtf8(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out string[] text)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_name_get_utf8(face, name_id, language, out text_size, out text);
	}

	public static MentorLake.HarfBuzz.hb_ot_name_entry_t[] OtNameListNames(MentorLake.HarfBuzz.hb_face_tHandle face, out uint num_entries)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_name_list_names(face, out num_entries);
	}

	public static void OtShapeGlyphsClosure(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, out MentorLake.HarfBuzz.hb_set_t glyphs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_shape_glyphs_closure(font, buffer, features, num_features, out glyphs);
	}

	public static void OtShapePlanCollectLookups(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_tag_t table_tag, out MentorLake.HarfBuzz.hb_set_t lookup_indexes)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_shape_plan_collect_lookups(shape_plan, table_tag, out lookup_indexes);
	}

	public static MentorLake.HarfBuzz.hb_tag_t OtTagFromLanguage(MentorLake.HarfBuzz.hb_language_t language)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_tag_from_language(language);
	}

	public static MentorLake.HarfBuzz.hb_language_t OtTagToLanguage(MentorLake.HarfBuzz.hb_tag_t tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_tag_to_language(tag);
	}

	public static MentorLake.HarfBuzz.hb_script_t OtTagToScript(MentorLake.HarfBuzz.hb_tag_t tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_tag_to_script(tag);
	}

	public static void OtTagsFromScript(MentorLake.HarfBuzz.hb_script_t script, out MentorLake.HarfBuzz.hb_tag_t script_tag_1, out MentorLake.HarfBuzz.hb_tag_t script_tag_2)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_tags_from_script(script, out script_tag_1, out script_tag_2);
	}

	public static void OtTagsFromScriptAndLanguage(MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, ref uint script_count, out MentorLake.HarfBuzz.hb_tag_t script_tags, ref uint language_count, out MentorLake.HarfBuzz.hb_tag_t language_tags)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_tags_from_script_and_language(script, language, ref script_count, out script_tags, ref language_count, out language_tags);
	}

	public static void OtTagsToScriptAndLanguage(MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_script_t script, out MentorLake.HarfBuzz.hb_language_t language)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_tags_to_script_and_language(script_tag, language_tag, out script, out language);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtVarFindAxis(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t axis_tag, uint axis_index, out MentorLake.HarfBuzz.hb_ot_var_axis_t axis_info)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_find_axis(face, axis_tag, axis_index, out axis_info);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtVarFindAxisInfo(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t axis_tag, out MentorLake.HarfBuzz.hb_ot_var_axis_info_t axis_info)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_find_axis_info(face, axis_tag, out axis_info);
	}

	public static uint OtVarGetAxes(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint axes_count, out MentorLake.HarfBuzz.hb_ot_var_axis_t[] axes_array)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_get_axes(face, start_offset, out axes_count, out axes_array);
	}

	public static uint OtVarGetAxisCount(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_get_axis_count(face);
	}

	public static uint OtVarGetAxisInfos(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint axes_count, out MentorLake.HarfBuzz.hb_ot_var_axis_info_t[] axes_array)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_get_axis_infos(face, start_offset, out axes_count, out axes_array);
	}

	public static uint OtVarGetNamedInstanceCount(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_get_named_instance_count(face);
	}

	public static MentorLake.HarfBuzz.hb_bool_t OtVarHasData(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_has_data(face);
	}

	public static uint OtVarNamedInstanceGetDesignCoords(MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index, out uint coords_length, out float[] coords)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_named_instance_get_design_coords(face, instance_index, out coords_length, out coords);
	}

	public static MentorLake.HarfBuzz.hb_ot_name_id_t OtVarNamedInstanceGetPostscriptNameId(MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_named_instance_get_postscript_name_id(face, instance_index);
	}

	public static MentorLake.HarfBuzz.hb_ot_name_id_t OtVarNamedInstanceGetSubfamilyNameId(MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_named_instance_get_subfamily_name_id(face, instance_index);
	}

	public static void OtVarNormalizeCoords(MentorLake.HarfBuzz.hb_face_tHandle face, uint coords_length, float design_coords, out int normalized_coords)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_var_normalize_coords(face, coords_length, design_coords, out normalized_coords);
	}

	public static void OtVarNormalizeVariations(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_variation_tHandle variations, uint variations_length, out int[] coords, out uint coords_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_var_normalize_variations(face, variations, variations_length, out coords, out coords_length);
	}

	public static void PaintColor(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_bool_t is_foreground, MentorLake.HarfBuzz.hb_color_t color)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_color(funcs, paint_data, is_foreground, color);
	}

	public static MentorLake.HarfBuzz.hb_bool_t PaintColorGlyph(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_color_glyph(funcs, paint_data, glyph, font);
	}

	public static MentorLake.HarfBuzz.hb_bool_t PaintCustomPaletteColor(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, uint color_index, out MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_custom_palette_color(funcs, paint_data, color_index, out color);
	}

	public static MentorLake.HarfBuzz.hb_paint_funcs_tHandle PaintFuncsCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_create();
	}

	public static void PaintFuncsDestroy(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_destroy(funcs);
	}

	public static MentorLake.HarfBuzz.hb_paint_funcs_tHandle PaintFuncsGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_get_empty();
	}

	public static IntPtr PaintFuncsGetUserData(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_get_user_data(funcs, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t PaintFuncsIsImmutable(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_is_immutable(funcs);
	}

	public static void PaintFuncsMakeImmutable(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_make_immutable(funcs);
	}

	public static MentorLake.HarfBuzz.hb_paint_funcs_tHandle PaintFuncsReference(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_reference(funcs);
	}

	public static void PaintFuncsSetColorFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_color_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_color_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetColorGlyphFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_color_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_color_glyph_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetCustomPaletteColorFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_custom_palette_color_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_custom_palette_color_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetImageFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_image_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_image_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetLinearGradientFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_linear_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_linear_gradient_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetPopClipFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_clip_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_pop_clip_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetPopGroupFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_group_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_pop_group_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetPopTransformFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_transform_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_pop_transform_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetPushClipGlyphFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_clip_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_push_clip_glyph_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetPushClipRectangleFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_clip_rectangle_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_push_clip_rectangle_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetPushGroupFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_group_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_push_group_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetPushTransformFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_transform_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_push_transform_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetRadialGradientFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_radial_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_radial_gradient_func(funcs, func, user_data, destroy);
	}

	public static void PaintFuncsSetSweepGradientFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_sweep_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_sweep_gradient_func(funcs, func, user_data, destroy);
	}

	public static MentorLake.HarfBuzz.hb_bool_t PaintFuncsSetUserData(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_user_data(funcs, key, data, destroy, replace);
	}

	public static void PaintImage(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_blob_tHandle image, uint width, uint height, MentorLake.HarfBuzz.hb_tag_t format, float slant, MentorLake.HarfBuzz.hb_glyph_extents_tHandle extents)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_image(funcs, paint_data, image, width, height, format, slant, extents);
	}

	public static void PaintLinearGradient(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float x1, float y1, float x2, float y2)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_linear_gradient(funcs, paint_data, color_line, x0, y0, x1, y1, x2, y2);
	}

	public static void PaintPopClip(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_pop_clip(funcs, paint_data);
	}

	public static void PaintPopGroup(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_paint_composite_mode_t mode)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_pop_group(funcs, paint_data, mode);
	}

	public static void PaintPopTransform(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_pop_transform(funcs, paint_data);
	}

	public static void PaintPushClipGlyph(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_push_clip_glyph(funcs, paint_data, glyph, font);
	}

	public static void PaintPushClipRectangle(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, float xmin, float ymin, float xmax, float ymax)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_push_clip_rectangle(funcs, paint_data, xmin, ymin, xmax, ymax);
	}

	public static void PaintPushGroup(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_push_group(funcs, paint_data);
	}

	public static void PaintPushTransform(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, float xx, float yx, float xy, float yy, float dx, float dy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_push_transform(funcs, paint_data, xx, yx, xy, yy, dx, dy);
	}

	public static void PaintRadialGradient(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float r0, float x1, float y1, float r1)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_radial_gradient(funcs, paint_data, color_line, x0, y0, r0, x1, y1, r1);
	}

	public static void PaintSweepGradient(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float start_angle, float end_angle)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_sweep_gradient(funcs, paint_data, color_line, x0, y0, start_angle, end_angle);
	}

	public static MentorLake.HarfBuzz.hb_script_t ScriptFromIso15924Tag(MentorLake.HarfBuzz.hb_tag_t tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_script_from_iso15924_tag(tag);
	}

	public static MentorLake.HarfBuzz.hb_script_t ScriptFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_script_from_string(str, len);
	}

	public static MentorLake.HarfBuzz.hb_direction_t ScriptGetHorizontalDirection(MentorLake.HarfBuzz.hb_script_t script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_script_get_horizontal_direction(script);
	}

	public static MentorLake.HarfBuzz.hb_tag_t ScriptToIso15924Tag(MentorLake.HarfBuzz.hb_script_t script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_script_to_iso15924_tag(script);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SegmentPropertiesEqual(MentorLake.HarfBuzz.hb_segment_properties_tHandle a, MentorLake.HarfBuzz.hb_segment_properties_tHandle b)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_segment_properties_equal(a, b);
	}

	public static uint SegmentPropertiesHash(MentorLake.HarfBuzz.hb_segment_properties_tHandle p)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_segment_properties_hash(p);
	}

	public static void SegmentPropertiesOverlay(MentorLake.HarfBuzz.hb_segment_properties_tHandle p, MentorLake.HarfBuzz.hb_segment_properties_tHandle src)
	{
		HarfBuzzGlobalFunctionsExterns.hb_segment_properties_overlay(p, src);
	}

	public static void SetAdd(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_add(set, codepoint);
	}

	public static void SetAddRange(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t first, MentorLake.HarfBuzz.hb_codepoint_t last)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_add_range(set, first, last);
	}

	public static void SetAddSortedArray(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t[] sorted_codepoints, uint num_codepoints)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_add_sorted_array(set, sorted_codepoints, num_codepoints);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetAllocationSuccessful(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_allocation_successful(set);
	}

	public static void SetClear(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_clear(set);
	}

	public static MentorLake.HarfBuzz.hb_set_tHandle SetCopy(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_copy(set);
	}

	public static MentorLake.HarfBuzz.hb_set_tHandle SetCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_create();
	}

	public static void SetDel(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_del(set, codepoint);
	}

	public static void SetDelRange(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t first, MentorLake.HarfBuzz.hb_codepoint_t last)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_del_range(set, first, last);
	}

	public static void SetDestroy(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_destroy(set);
	}

	public static MentorLake.HarfBuzz.hb_set_tHandle SetGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_empty();
	}

	public static MentorLake.HarfBuzz.hb_codepoint_t SetGetMax(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_max(set);
	}

	public static MentorLake.HarfBuzz.hb_codepoint_t SetGetMin(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_min(set);
	}

	public static uint SetGetPopulation(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_population(set);
	}

	public static IntPtr SetGetUserData(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_user_data(set, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetHas(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_has(set, codepoint);
	}

	public static uint SetHash(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_hash(set);
	}

	public static void SetIntersect(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_intersect(set, other);
	}

	public static void SetInvert(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_invert(set);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetIsEmpty(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_is_empty(set);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetIsEqual(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_is_equal(set, other);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetIsInverted(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_is_inverted(set);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetIsSubset(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle larger_set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_is_subset(set, larger_set);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetNext(MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_next(set, ref codepoint);
	}

	public static uint SetNextMany(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint, MentorLake.HarfBuzz.hb_codepoint_t[] @out, uint size)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_next_many(set, codepoint, @out, size);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetNextRange(MentorLake.HarfBuzz.hb_set_tHandle set, out MentorLake.HarfBuzz.hb_codepoint_t first, ref MentorLake.HarfBuzz.hb_codepoint_t last)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_next_range(set, out first, ref last);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetPrevious(MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_previous(set, ref codepoint);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetPreviousRange(MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t first, out MentorLake.HarfBuzz.hb_codepoint_t last)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_previous_range(set, ref first, out last);
	}

	public static MentorLake.HarfBuzz.hb_set_tHandle SetReference(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_reference(set);
	}

	public static void SetSet(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_set(set, other);
	}

	public static MentorLake.HarfBuzz.hb_bool_t SetSetUserData(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_set_user_data(set, key, data, destroy, replace);
	}

	public static void SetSubtract(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_subtract(set, other);
	}

	public static void SetSymmetricDifference(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_symmetric_difference(set, other);
	}

	public static void SetUnion(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_union(set, other);
	}

	public static void Shape(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features)
	{
		HarfBuzzGlobalFunctionsExterns.hb_shape(font, buffer, features, num_features);
	}

	public static MentorLake.HarfBuzz.hb_bool_t ShapeFull(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_full(font, buffer, features, num_features, shaper_list);
	}

	public static MentorLake.HarfBuzz.hb_bool_t ShapeJustify(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, string[] shaper_list, float min_target_advance, float max_target_advance, ref float advance, out MentorLake.HarfBuzz.hb_tag_t var_tag, out float var_value)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_justify(font, buffer, features, num_features, shaper_list, min_target_advance, max_target_advance, ref advance, out var_tag, out var_value);
	}

	public static string[] ShapeListShapers()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_list_shapers();
	}

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanCreate(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_create(face, props, user_features, num_user_features, shaper_list);
	}

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanCreate2(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, int[] coords, uint num_coords, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_create2(face, props, user_features, num_user_features, coords, num_coords, shaper_list);
	}

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanCreateCached(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_create_cached(face, props, user_features, num_user_features, shaper_list);
	}

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanCreateCached2(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, int[] coords, uint num_coords, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_create_cached2(face, props, user_features, num_user_features, coords, num_coords, shaper_list);
	}

	public static void ShapePlanDestroy(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan)
	{
		HarfBuzzGlobalFunctionsExterns.hb_shape_plan_destroy(shape_plan);
	}

	public static MentorLake.HarfBuzz.hb_bool_t ShapePlanExecute(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_execute(shape_plan, font, buffer, features, num_features);
	}

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_get_empty();
	}

	public static string ShapePlanGetShaper(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_get_shaper(shape_plan);
	}

	public static IntPtr ShapePlanGetUserData(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_get_user_data(shape_plan, key);
	}

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanReference(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_reference(shape_plan);
	}

	public static MentorLake.HarfBuzz.hb_bool_t ShapePlanSetUserData(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_set_user_data(shape_plan, key, data, destroy, replace);
	}

	public static float StyleGetValue(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_style_tag_t style_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_style_get_value(font, style_tag);
	}

	public static MentorLake.HarfBuzz.hb_tag_t TagFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_tag_from_string(str, len);
	}

	public static void TagToString(MentorLake.HarfBuzz.hb_tag_t tag, out byte[] buf)
	{
		HarfBuzzGlobalFunctionsExterns.hb_tag_to_string(tag, out buf);
	}

	public static MentorLake.HarfBuzz.hb_unicode_combining_class_t UnicodeCombiningClass(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_combining_class(ufuncs, unicode);
	}

	public static MentorLake.HarfBuzz.hb_bool_t UnicodeCompose(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t a, MentorLake.HarfBuzz.hb_codepoint_t b, out MentorLake.HarfBuzz.hb_codepoint_t ab)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_compose(ufuncs, a, b, out ab);
	}

	public static MentorLake.HarfBuzz.hb_bool_t UnicodeDecompose(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t ab, out MentorLake.HarfBuzz.hb_codepoint_t a, out MentorLake.HarfBuzz.hb_codepoint_t b)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_decompose(ufuncs, ab, out a, out b);
	}

	public static uint UnicodeDecomposeCompatibility(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t u, out MentorLake.HarfBuzz.hb_codepoint_t decomposed)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_decompose_compatibility(ufuncs, u, out decomposed);
	}

	public static uint UnicodeEastasianWidth(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_eastasian_width(ufuncs, unicode);
	}

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsCreate(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle parent)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_create(parent);
	}

	public static void UnicodeFuncsDestroy(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_destroy(ufuncs);
	}

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsGetDefault()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_get_default();
	}

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_get_empty();
	}

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsGetParent(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_get_parent(ufuncs);
	}

	public static IntPtr UnicodeFuncsGetUserData(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_get_user_data(ufuncs, key);
	}

	public static MentorLake.HarfBuzz.hb_bool_t UnicodeFuncsIsImmutable(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_is_immutable(ufuncs);
	}

	public static void UnicodeFuncsMakeImmutable(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_make_immutable(ufuncs);
	}

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsReference(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_reference(ufuncs);
	}

	public static void UnicodeFuncsSetCombiningClassFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_combining_class_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_combining_class_func(ufuncs, func, user_data, destroy);
	}

	public static void UnicodeFuncsSetComposeFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_compose_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_compose_func(ufuncs, func, user_data, destroy);
	}

	public static void UnicodeFuncsSetDecomposeCompatibilityFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_decompose_compatibility_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_decompose_compatibility_func(ufuncs, func, user_data, destroy);
	}

	public static void UnicodeFuncsSetDecomposeFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_decompose_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_decompose_func(ufuncs, func, user_data, destroy);
	}

	public static void UnicodeFuncsSetEastasianWidthFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_eastasian_width_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_eastasian_width_func(ufuncs, func, user_data, destroy);
	}

	public static void UnicodeFuncsSetGeneralCategoryFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_general_category_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_general_category_func(ufuncs, func, user_data, destroy);
	}

	public static void UnicodeFuncsSetMirroringFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_mirroring_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_mirroring_func(ufuncs, func, user_data, destroy);
	}

	public static void UnicodeFuncsSetScriptFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_script_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_script_func(ufuncs, func, user_data, destroy);
	}

	public static MentorLake.HarfBuzz.hb_bool_t UnicodeFuncsSetUserData(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_user_data(ufuncs, key, data, destroy, replace);
	}

	public static MentorLake.HarfBuzz.hb_unicode_general_category_t UnicodeGeneralCategory(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_general_category(ufuncs, unicode);
	}

	public static MentorLake.HarfBuzz.hb_codepoint_t UnicodeMirroring(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_mirroring(ufuncs, unicode);
	}

	public static MentorLake.HarfBuzz.hb_script_t UnicodeScript(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_script(ufuncs, unicode);
	}

	public static MentorLake.HarfBuzz.hb_bool_t VariationFromString(byte[] str, int len, out MentorLake.HarfBuzz.hb_variation_t variation)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_variation_from_string(str, len, out variation);
	}

	public static void VariationToString(MentorLake.HarfBuzz.hb_variation_tHandle variation, out string[] buf, out uint size)
	{
		HarfBuzzGlobalFunctionsExterns.hb_variation_to_string(variation, out buf, out size);
	}

}

internal class HarfBuzzGlobalFunctionsExterns
{
	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_name_id_t hb_aat_layout_feature_type_get_name_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_aat_layout_feature_type_t feature_type);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_aat_layout_feature_type_get_selector_infos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_aat_layout_feature_type_t feature_type, uint start_offset, out uint selector_count, out MentorLake.HarfBuzz.hb_aat_layout_feature_selector_info_t[] selectors, out uint default_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_aat_layout_get_feature_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_aat_layout_feature_type_t[] features);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_aat_layout_has_positioning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_aat_layout_has_substitution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_aat_layout_has_tracking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_copy_writable_or_fail([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create(string data, uint length, MentorLake.HarfBuzz.hb_memory_mode_t mode, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create_from_file(string file_name);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create_from_file_or_fail(string file_name);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create_or_fail(string data, uint length, MentorLake.HarfBuzz.hb_memory_mode_t mode, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create_sub_blob([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle parent, uint offset, uint length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_blob_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] hb_blob_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob, out uint length);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] hb_blob_get_data_writable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob, out uint length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_blob_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_blob_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_blob_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_blob_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_blob_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t codepoint, uint cluster);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_add_codepoints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t[] text, int text_length, uint item_offset, int item_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_add_latin1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, byte[] text, int text_length, uint item_offset, int item_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_add_utf16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, ushort[] text, int text_length, uint item_offset, int item_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_add_utf32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint[] text, int text_length, uint item_offset, int item_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_add_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, byte[] text, int text_length, uint item_offset, int item_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_buffer_allocation_successful([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle source, uint start, uint end);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_clear_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_tHandle hb_buffer_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_tHandle hb_buffer_create_similar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle src);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_buffer_deserialize_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, string[] buf, int buf_len, out string end_ptr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_buffer_deserialize_unicode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, string[] buf, int buf_len, out string end_ptr, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_diff_flags_t hb_buffer_diff([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle reference, MentorLake.HarfBuzz.hb_codepoint_t dottedcircle_glyph, uint position_fuzz);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_cluster_level_t hb_buffer_get_cluster_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_content_type_t hb_buffer_get_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_direction_t hb_buffer_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_tHandle hb_buffer_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_flags_t hb_buffer_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_glyph_info_t[] hb_buffer_get_glyph_infos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out uint length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_glyph_position_t[] hb_buffer_get_glyph_positions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out uint length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_codepoint_t hb_buffer_get_invisible_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_language_t hb_buffer_get_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_buffer_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_codepoint_t hb_buffer_get_not_found_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_buffer_get_random_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_codepoint_t hb_buffer_get_replacement_codepoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_script_t hb_buffer_get_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_get_segment_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out MentorLake.HarfBuzz.hb_segment_properties_t props);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_buffer_get_unicode_funcs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_buffer_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_guess_segment_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_buffer_has_positions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_normalize_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_buffer_pre_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint size);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_tHandle hb_buffer_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_reverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_reverse_clusters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_reverse_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_buffer_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_serialize_format_t hb_buffer_serialize_format_from_string(byte[] str, int len);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string hb_buffer_serialize_format_to_string(MentorLake.HarfBuzz.hb_buffer_serialize_format_t format);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_buffer_serialize_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] hb_buffer_serialize_list_formats();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_buffer_serialize_unicode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_cluster_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_cluster_level_t cluster_level);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_content_type_t content_type);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_direction_t direction);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_flags_t flags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_invisible_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t invisible);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_language_t language);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_buffer_set_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_message_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_message_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_not_found_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t not_found);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_random_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint state);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_replacement_codepoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t replacement);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_script_t script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_segment_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_buffer_set_unicode_funcs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle unicode_funcs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_buffer_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern byte hb_color_get_alpha(MentorLake.HarfBuzz.hb_color_t color);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern byte hb_color_get_blue(MentorLake.HarfBuzz.hb_color_t color);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern byte hb_color_get_green(MentorLake.HarfBuzz.hb_color_t color);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern byte hb_color_get_red(MentorLake.HarfBuzz.hb_color_t color);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_color_line_get_color_stops([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, uint start, out uint count, out MentorLake.HarfBuzz.hb_color_stop_t[] color_stops);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_paint_extend_t hb_color_line_get_extend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_direction_t hb_direction_from_string(byte[] str, int len);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string hb_direction_to_string(MentorLake.HarfBuzz.hb_direction_t direction);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_close_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_state_tHandle>))] MentorLake.HarfBuzz.hb_draw_state_tHandle st);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_cubic_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_state_tHandle>))] MentorLake.HarfBuzz.hb_draw_state_tHandle st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_draw_funcs_tHandle hb_draw_funcs_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_draw_funcs_tHandle hb_draw_funcs_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_draw_funcs_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_draw_funcs_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_draw_funcs_tHandle hb_draw_funcs_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_set_close_path_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_close_path_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_set_cubic_to_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_cubic_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_set_line_to_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_line_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_set_move_to_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_move_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_set_quadratic_to_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_quadratic_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_draw_funcs_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_line_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_state_tHandle>))] MentorLake.HarfBuzz.hb_draw_state_tHandle st, float to_x, float to_y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_move_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_state_tHandle>))] MentorLake.HarfBuzz.hb_draw_state_tHandle st, float to_x, float to_y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_quadratic_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_state_tHandle>))] MentorLake.HarfBuzz.hb_draw_state_tHandle st, float control_x, float control_y, float to_x, float to_y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_face_builder_add_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_builder_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_builder_sort_tables([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t[] tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_collect_nominal_glyph_mapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_map_t mapping, out MentorLake.HarfBuzz.hb_set_t unicodes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_collect_unicodes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_set_t @out);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_collect_variation_selectors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_set_t @out);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_collect_variation_unicodes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_set_t @out);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob, uint index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_create_for_tables(MentorLake.HarfBuzz.hb_reference_table_func_t reference_table_func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_get_glyph_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_get_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_get_table_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint table_count, out MentorLake.HarfBuzz.hb_tag_t[] table_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_get_upem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_face_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_face_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_face_reference_blob([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_face_reference_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_set_glyph_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint glyph_count);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_set_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_set_upem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint upem);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_face_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_feature_from_string(byte[] str, int len, out MentorLake.HarfBuzz.hb_feature_t feature);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_feature_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_feature_tHandle>))] MentorLake.HarfBuzz.hb_feature_tHandle feature, out string[] buf, out uint size);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_add_glyph_origin_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, ref MentorLake.HarfBuzz.hb_position_t x, ref MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle hb_font_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle hb_font_create_sub_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle parent);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_draw_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_funcs_tHandle hb_font_funcs_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_funcs_tHandle hb_font_funcs_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_font_funcs_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_funcs_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_funcs_tHandle hb_font_funcs_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_draw_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_draw_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_font_h_extents_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_font_h_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_font_v_extents_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_font_v_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_contour_point_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_contour_point_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_extents_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_from_name_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_from_name_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_h_advance_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_advance_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_h_advances_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_advances_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_h_kerning_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_kerning_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_h_origin_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_origin_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_name_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_name_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_shape_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_shape_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_v_advance_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_advance_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_v_advances_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_advances_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_v_kerning_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_kerning_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_glyph_v_origin_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_origin_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_nominal_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_nominal_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_nominal_glyphs_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_nominal_glyphs_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_paint_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_paint_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_funcs_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_set_variation_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_variation_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle hb_font_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_extents_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_font_extents_t extents);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_font_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_glyph_advance_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_glyph_advances_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, out uint advance_stride);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_contour_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint point_index, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_contour_point_for_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint point_index, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_glyph_extents_t extents);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_extents_for_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_glyph_extents_t extents);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_from_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, string[] name, int len, out MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_font_get_glyph_h_advance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_glyph_h_advances([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, uint advance_stride);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_font_get_glyph_h_kerning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t left_glyph, MentorLake.HarfBuzz.hb_codepoint_t right_glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_h_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_glyph_kerning_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t first_glyph, MentorLake.HarfBuzz.hb_codepoint_t second_glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out string[] name, out uint size);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_glyph_origin_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_glyph_shape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_font_get_glyph_v_advance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_glyph_v_advances([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, out uint advance_stride);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_font_get_glyph_v_kerning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t top_glyph, MentorLake.HarfBuzz.hb_codepoint_t bottom_glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_v_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_h_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, out MentorLake.HarfBuzz.hb_font_extents_t extents);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_nominal_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, out MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_font_get_nominal_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle first_unicode, uint unicode_stride, out MentorLake.HarfBuzz.hb_codepoint_t first_glyph, uint glyph_stride);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle hb_font_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_ppem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, out uint x_ppem, out uint y_ppem);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern float hb_font_get_ptem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, out int x_scale, out int y_scale);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_font_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_synthetic_bold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, out float x_embolden, out float y_embolden, out MentorLake.HarfBuzz.hb_bool_t in_place);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern float hb_font_get_synthetic_slant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_font_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_v_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, out MentorLake.HarfBuzz.hb_font_extents_t extents);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern float hb_font_get_var_coords_design([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, out uint length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern int hb_font_get_var_coords_normalized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, out uint length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_font_get_var_named_instance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_variation_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_glyph_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, byte[] s, int len, out MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_glyph_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out string[] s, out uint size);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_paint_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle pfuncs, IntPtr paint_data, uint palette_index, MentorLake.HarfBuzz.hb_color_t foreground);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle hb_font_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_funcs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle klass, IntPtr font_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_funcs_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle parent);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_ppem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, uint x_ppem, uint y_ppem);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_ptem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, float ptem);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, int x_scale, int y_scale);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_synthetic_bold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, float x_embolden, float y_embolden, MentorLake.HarfBuzz.hb_bool_t in_place);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_synthetic_slant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, float slant);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_var_coords_design([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, float[] coords, uint coords_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_var_coords_normalized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, int[] coords, uint coords_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_var_named_instance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, uint instance_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_variation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_tag_t tag, float value);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_set_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_variation_t[] variations, uint variations_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_subtract_glyph_origin_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, ref MentorLake.HarfBuzz.hb_position_t x, ref MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ft_font_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern int hb_ft_font_get_load_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ft_font_set_funcs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ft_font_set_load_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, int load_flags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ft_font_unlock_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ft_hb_font_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_glib_blob_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle gbytes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_glib_get_unicode_funcs();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeScript hb_glib_script_from_script(MentorLake.HarfBuzz.hb_script_t script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_script_t hb_glib_script_to_script(MentorLake.GLib.GUnicodeScript script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_glyph_flags_t hb_glyph_info_get_glyph_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_glyph_info_tHandle>))] MentorLake.HarfBuzz.hb_glyph_info_tHandle info);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_language_t hb_language_from_string(byte[] str, int len);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_language_t hb_language_get_default();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_language_matches(MentorLake.HarfBuzz.hb_language_t language, MentorLake.HarfBuzz.hb_language_t specific);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string hb_language_to_string(MentorLake.HarfBuzz.hb_language_t language);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_map_allocation_successful([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_map_tHandle hb_map_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_map_tHandle hb_map_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_del([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_codepoint_t hb_map_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_map_tHandle hb_map_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_map_get_population([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_map_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_map_has([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_map_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_map_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_map_is_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle other);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle keys);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_map_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, ref int idx, out MentorLake.HarfBuzz.hb_codepoint_t key, out MentorLake.HarfBuzz.hb_codepoint_t value);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_map_tHandle hb_map_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key, MentorLake.HarfBuzz.hb_codepoint_t value);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_map_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle other);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle values);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_color_glyph_get_layers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint layer_count, out MentorLake.HarfBuzz.hb_ot_color_layer_t[] layers);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_color_glyph_has_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_ot_color_glyph_reference_png([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_ot_color_glyph_reference_svg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_color_has_layers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_color_has_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_color_has_palettes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_color_has_png([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_color_has_svg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_name_id_t hb_ot_color_palette_color_get_name_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint color_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_color_palette_get_colors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index, uint start_offset, out uint color_count, out MentorLake.HarfBuzz.hb_color_t[] colors);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_color_palette_get_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_color_palette_flags_t hb_ot_color_palette_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_name_id_t hb_ot_color_palette_get_name_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_font_set_funcs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_collect_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t[] scripts, MentorLake.HarfBuzz.hb_tag_t[] languages, MentorLake.HarfBuzz.hb_tag_t[] features, out MentorLake.HarfBuzz.hb_set_t feature_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_collect_features_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out MentorLake.HarfBuzz.hb_map_t feature_map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_collect_lookups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t[] scripts, MentorLake.HarfBuzz.hb_tag_t[] languages, MentorLake.HarfBuzz.hb_tag_t[] features, out MentorLake.HarfBuzz.hb_set_t lookup_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_feature_get_characters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint start_offset, out uint char_count, out MentorLake.HarfBuzz.hb_codepoint_t[] characters);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_feature_get_lookups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint start_offset, out uint lookup_count, out uint[] lookup_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_feature_get_name_ids([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, out MentorLake.HarfBuzz.hb_ot_name_id_t label_id, out MentorLake.HarfBuzz.hb_ot_name_id_t tooltip_id, out MentorLake.HarfBuzz.hb_ot_name_id_t sample_id, out uint num_named_parameters, out MentorLake.HarfBuzz.hb_ot_name_id_t first_param_id);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_feature_with_variations_get_lookups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint variations_index, uint start_offset, out uint lookup_count, out uint[] lookup_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_get_attach_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint point_count, out uint[] point_array);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_get_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_position_t coord);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_get_baseline2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_position_t coord);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_get_baseline_with_fallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_position_t coord);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_get_baseline_with_fallback2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_position_t coord);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_get_font_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_font_extents_t extents);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_get_font_extents2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_font_extents_t extents);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_layout_glyph_class_t hb_ot_layout_get_glyph_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_get_glyphs_in_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_layout_glyph_class_t klass, out MentorLake.HarfBuzz.hb_set_t glyphs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t hb_ot_layout_get_horizontal_baseline_tag_for_script(MentorLake.HarfBuzz.hb_script_t script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_get_ligature_carets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint caret_count, out MentorLake.HarfBuzz.hb_position_t[] caret_array);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_get_size_params([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, out uint design_size, out uint subfamily_id, out MentorLake.HarfBuzz.hb_ot_name_id_t subfamily_name_id, out uint range_start, out uint range_end);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_has_glyph_classes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_has_positioning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_has_substitution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_language_find_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, MentorLake.HarfBuzz.hb_tag_t feature_tag, out uint feature_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_language_get_feature_indexes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, uint start_offset, out uint feature_count, out uint[] feature_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_language_get_feature_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_tag_t[] feature_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_language_get_required_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out uint feature_index, out MentorLake.HarfBuzz.hb_tag_t feature_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_language_get_required_feature_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out uint feature_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_lookup_collect_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint lookup_index, out MentorLake.HarfBuzz.hb_set_t glyphs_before, out MentorLake.HarfBuzz.hb_set_t glyphs_input, out MentorLake.HarfBuzz.hb_set_t glyphs_after, out MentorLake.HarfBuzz.hb_set_t glyphs_output);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_lookup_get_glyph_alternates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint alternate_count, out MentorLake.HarfBuzz.hb_codepoint_t[] alternate_glyphs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_layout_lookup_get_optical_bound([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, uint lookup_index, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_lookup_substitute_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, out MentorLake.HarfBuzz.hb_set_t glyphs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_lookup_would_substitute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle glyphs, uint glyphs_length, MentorLake.HarfBuzz.hb_bool_t zero_context);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_lookups_substitute_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle lookups, out MentorLake.HarfBuzz.hb_set_t glyphs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_script_find_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, MentorLake.HarfBuzz.hb_tag_t language_tag, uint language_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_script_get_language_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint start_offset, out uint language_count, out MentorLake.HarfBuzz.hb_tag_t[] language_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_script_select_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_tag_tHandle>))] MentorLake.HarfBuzz.hb_tag_tHandle language_tags, out uint language_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_script_select_language2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_tag_tHandle>))] MentorLake.HarfBuzz.hb_tag_tHandle language_tags, out uint language_index, out MentorLake.HarfBuzz.hb_tag_t chosen_language);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_table_choose_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_tag_tHandle>))] MentorLake.HarfBuzz.hb_tag_tHandle script_tags, out uint script_index, out MentorLake.HarfBuzz.hb_tag_t chosen_script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_table_find_feature_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, int coords, uint num_coords, out uint variations_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_table_find_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t script_tag, out uint script_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_table_get_feature_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_tag_t[] feature_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_table_get_lookup_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_table_get_script_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint start_offset, out uint script_count, out MentorLake.HarfBuzz.hb_tag_t[] script_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_table_select_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_tag_tHandle>))] MentorLake.HarfBuzz.hb_tag_tHandle script_tags, out uint script_index, out MentorLake.HarfBuzz.hb_tag_t chosen_script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_constant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_math_constant_t constant);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_math_get_glyph_assembly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, uint start_offset, out uint parts_count, out MentorLake.HarfBuzz.hb_ot_math_glyph_part_t[] parts, out MentorLake.HarfBuzz.hb_position_t italics_correction);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_glyph_italics_correction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_glyph_kerning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_ot_math_kern_t kern, MentorLake.HarfBuzz.hb_position_t correction_height);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_math_get_glyph_kernings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_ot_math_kern_t kern, uint start_offset, out uint entries_count, out MentorLake.HarfBuzz.hb_ot_math_kern_entry_t[] kern_entries);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_glyph_top_accent_attachment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_math_get_glyph_variants([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, uint start_offset, out uint variants_count, out MentorLake.HarfBuzz.hb_ot_math_glyph_variant_t[] variants);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_min_connector_overlap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_math_has_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_math_is_glyph_extended_shape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_meta_get_entry_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint entries_count, out MentorLake.HarfBuzz.hb_ot_meta_tag_t[] entries);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_ot_meta_reference_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_meta_tag_t meta_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_metrics_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag, out MentorLake.HarfBuzz.hb_position_t position);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_metrics_get_position_with_fallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag, out MentorLake.HarfBuzz.hb_position_t position);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern float hb_ot_metrics_get_variation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_metrics_get_x_variation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_metrics_get_y_variation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_name_get_utf16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out ushort[] text);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_name_get_utf32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out uint[] text);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_name_get_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out string[] text);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_name_entry_t[] hb_ot_name_list_names([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, out uint num_entries);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_shape_glyphs_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, out MentorLake.HarfBuzz.hb_set_t glyphs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_shape_plan_collect_lookups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_tag_t table_tag, out MentorLake.HarfBuzz.hb_set_t lookup_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_tag_t hb_ot_tag_from_language(MentorLake.HarfBuzz.hb_language_t language);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_language_t hb_ot_tag_to_language(MentorLake.HarfBuzz.hb_tag_t tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_script_t hb_ot_tag_to_script(MentorLake.HarfBuzz.hb_tag_t tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_tags_from_script(MentorLake.HarfBuzz.hb_script_t script, out MentorLake.HarfBuzz.hb_tag_t script_tag_1, out MentorLake.HarfBuzz.hb_tag_t script_tag_2);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_tags_from_script_and_language(MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, ref uint script_count, out MentorLake.HarfBuzz.hb_tag_t script_tags, ref uint language_count, out MentorLake.HarfBuzz.hb_tag_t language_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_tags_to_script_and_language(MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_script_t script, out MentorLake.HarfBuzz.hb_language_t language);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_var_find_axis([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t axis_tag, uint axis_index, out MentorLake.HarfBuzz.hb_ot_var_axis_t axis_info);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_var_find_axis_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t axis_tag, out MentorLake.HarfBuzz.hb_ot_var_axis_info_t axis_info);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_get_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint axes_count, out MentorLake.HarfBuzz.hb_ot_var_axis_t[] axes_array);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_get_axis_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_get_axis_infos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint axes_count, out MentorLake.HarfBuzz.hb_ot_var_axis_info_t[] axes_array);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_get_named_instance_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_var_has_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_named_instance_get_design_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index, out uint coords_length, out float[] coords);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_name_id_t hb_ot_var_named_instance_get_postscript_name_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_name_id_t hb_ot_var_named_instance_get_subfamily_name_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_var_normalize_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint coords_length, float design_coords, out int normalized_coords);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_var_normalize_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_variation_tHandle>))] MentorLake.HarfBuzz.hb_variation_tHandle variations, uint variations_length, out int[] coords, out uint coords_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_bool_t is_foreground, MentorLake.HarfBuzz.hb_color_t color);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_paint_color_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_paint_custom_palette_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, uint color_index, out MentorLake.HarfBuzz.hb_color_t color);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_paint_funcs_tHandle hb_paint_funcs_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_paint_funcs_tHandle hb_paint_funcs_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_paint_funcs_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_paint_funcs_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_paint_funcs_tHandle hb_paint_funcs_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_color_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_color_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_color_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_color_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_custom_palette_color_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_custom_palette_color_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_image_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_image_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_linear_gradient_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_linear_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_pop_clip_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_clip_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_pop_group_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_group_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_pop_transform_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_transform_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_push_clip_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_clip_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_push_clip_rectangle_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_clip_rectangle_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_push_group_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_group_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_push_transform_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_transform_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_radial_gradient_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_radial_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_set_sweep_gradient_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_sweep_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_paint_funcs_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle image, uint width, uint height, MentorLake.HarfBuzz.hb_tag_t format, float slant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_glyph_extents_tHandle>))] MentorLake.HarfBuzz.hb_glyph_extents_tHandle extents);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_linear_gradient([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float x1, float y1, float x2, float y2);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_pop_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_pop_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_paint_composite_mode_t mode);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_pop_transform([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_push_clip_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_push_clip_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, float xmin, float ymin, float xmax, float ymax);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_push_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_push_transform([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, float xx, float yx, float xy, float yy, float dx, float dy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_radial_gradient([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float r0, float x1, float y1, float r1);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_sweep_gradient([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float start_angle, float end_angle);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_script_t hb_script_from_iso15924_tag(MentorLake.HarfBuzz.hb_tag_t tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_script_t hb_script_from_string(byte[] str, int len);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_direction_t hb_script_get_horizontal_direction(MentorLake.HarfBuzz.hb_script_t script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_tag_t hb_script_to_iso15924_tag(MentorLake.HarfBuzz.hb_script_t script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_segment_properties_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle b);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_segment_properties_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle p);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_segment_properties_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle src);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_add_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t first, MentorLake.HarfBuzz.hb_codepoint_t last);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_add_sorted_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t[] sorted_codepoints, uint num_codepoints);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_allocation_successful([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_set_tHandle hb_set_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_set_tHandle hb_set_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_del([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_del_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t first, MentorLake.HarfBuzz.hb_codepoint_t last);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_set_tHandle hb_set_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_codepoint_t hb_set_get_max([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_codepoint_t hb_set_get_min([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_set_get_population([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_set_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_has([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_set_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_intersect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle other);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_invert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_is_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle other);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_is_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_is_subset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle larger_set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t codepoint);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_set_next_many([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint, MentorLake.HarfBuzz.hb_codepoint_t[] @out, uint size);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_next_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, out MentorLake.HarfBuzz.hb_codepoint_t first, ref MentorLake.HarfBuzz.hb_codepoint_t last);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_previous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t codepoint);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_previous_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t first, out MentorLake.HarfBuzz.hb_codepoint_t last);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_set_tHandle hb_set_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle other);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_set_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_subtract([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle other);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_symmetric_difference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle other);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_union([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle other);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_shape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_shape_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_shape_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, string[] shaper_list, float min_target_advance, float max_target_advance, ref float advance, out MentorLake.HarfBuzz.hb_tag_t var_tag, out float var_value);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] hb_shape_list_shapers();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_create2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, int[] coords, uint num_coords, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_create_cached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_create_cached2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, int[] coords, uint num_coords, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_shape_plan_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_shape_plan_execute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string hb_shape_plan_get_shaper([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_shape_plan_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_shape_plan_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern float hb_style_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_style_tag_t style_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_tag_t hb_tag_from_string(byte[] str, int len);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_tag_to_string(MentorLake.HarfBuzz.hb_tag_t tag, out byte[] buf);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_combining_class_t hb_unicode_combining_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_unicode_compose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t a, MentorLake.HarfBuzz.hb_codepoint_t b, out MentorLake.HarfBuzz.hb_codepoint_t ab);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_unicode_decompose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t ab, out MentorLake.HarfBuzz.hb_codepoint_t a, out MentorLake.HarfBuzz.hb_codepoint_t b);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_unicode_decompose_compatibility([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t u, out MentorLake.HarfBuzz.hb_codepoint_t decomposed);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_unicode_eastasian_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle parent);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_get_default();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_unicode_funcs_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_unicode_funcs_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_set_combining_class_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_combining_class_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_set_compose_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_compose_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_set_decompose_compatibility_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_decompose_compatibility_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_set_decompose_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_decompose_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_set_eastasian_width_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_eastasian_width_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_set_general_category_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_general_category_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_set_mirroring_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_mirroring_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_set_script_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_script_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_unicode_funcs_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_unicode_general_category_t hb_unicode_general_category([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_codepoint_t hb_unicode_mirroring([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_script_t hb_unicode_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_variation_from_string(byte[] str, int len, out MentorLake.HarfBuzz.hb_variation_t variation);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_variation_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_variation_tHandle>))] MentorLake.HarfBuzz.hb_variation_tHandle variation, out string[] buf, out uint size);

}
