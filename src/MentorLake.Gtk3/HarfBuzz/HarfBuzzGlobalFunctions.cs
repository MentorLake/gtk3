namespace MentorLake.HarfBuzz;

public class HarfBuzzGlobalFunctions
{
/// <summary>
/// <para>
/// Fetches the name identifier of the specified feature type in the face&apos;s `name` table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="feature_type">
/// The #hb_aat_layout_feature_type_t of the requested feature type
/// </param>
/// <return>
/// Name identifier of the requested feature type
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_name_id_t AatLayoutFeatureTypeGetNameId(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_aat_layout_feature_type_t feature_type)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_feature_type_get_name_id(face, feature_type);
	}

/// <summary>
/// <para>
/// Fetches a list of the selectors available for the specified feature in the given face.
/// </para>
/// <para>
/// If upon return, @default_index is set to #HB_AAT_LAYOUT_NO_SELECTOR_INDEX, then
/// the feature type is non-exclusive.  Otherwise, @default_index is the index of
/// the selector that is selected by default.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="feature_type">
/// The #hb_aat_layout_feature_type_t of the requested feature type
/// </param>
/// <param name="start_offset">
/// offset of the first feature type to retrieve
/// </param>
/// <param name="selector_count">
/// Input = the maximum number of selectors to return;
///                  Output = the actual number of selectors returned (may be zero)
/// </param>
/// <param name="selectors">
/// 
///             A buffer pointer. The selectors available for the feature type queries.
/// </param>
/// <param name="default_index">
/// The index of the feature&apos;s default selector, if any
/// </param>
/// <return>
/// Number of all available feature selectors
/// </return>

	public static uint AatLayoutFeatureTypeGetSelectorInfos(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_aat_layout_feature_type_t feature_type, uint start_offset, out uint selector_count, out MentorLake.HarfBuzz.hb_aat_layout_feature_selector_info_t[] selectors, out uint default_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_feature_type_get_selector_infos(face, feature_type, start_offset, out selector_count, out selectors, out default_index);
	}

/// <summary>
/// <para>
/// Fetches a list of the AAT feature types included in the specified face.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="start_offset">
/// offset of the first feature type to retrieve
/// </param>
/// <param name="feature_count">
/// Input = the maximum number of feature types to return;
///                 Output = the actual number of feature types returned (may be zero)
/// </param>
/// <param name="features">
/// Array of feature types found
/// </param>
/// <return>
/// Number of all available feature types.
/// </return>

	public static uint AatLayoutGetFeatureTypes(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_aat_layout_feature_type_t[] features)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_get_feature_types(face, start_offset, out feature_count, out features);
	}

/// <summary>
/// <para>
/// Tests whether the specified face includes any positioning information
/// in the `kerx` table.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: does not examine the `GPOS` table.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t AatLayoutHasPositioning(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_has_positioning(face);
	}

/// <summary>
/// <para>
/// Tests whether the specified face includes any substitutions in the
/// `morx` or `mort` tables.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: does not examine the `GSUB` table.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t AatLayoutHasSubstitution(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_has_substitution(face);
	}

/// <summary>
/// <para>
/// Tests whether the specified face includes any tracking information
/// in the `trak` table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t AatLayoutHasTracking(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_aat_layout_has_tracking(face);
	}

/// <summary>
/// <para>
/// Makes a writable copy of @blob.
/// </para>
/// </summary>

/// <param name="blob">
/// A blob.
/// </param>
/// <return>
/// The new blob, or nullptr if allocation failed
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCopyWritableOrFail(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_copy_writable_or_fail(blob);
	}

/// <summary>
/// <para>
/// Creates a new &quot;blob&quot; object wrapping @data.  The @mode parameter is used
/// to negotiate ownership and lifecycle of @data.
/// </para>
/// </summary>

/// <param name="data">
/// Pointer to blob data.
/// </param>
/// <param name="length">
/// Length of @data in bytes.
/// </param>
/// <param name="mode">
/// Memory mode for @data.
/// </param>
/// <param name="user_data">
/// Data parameter to pass to @destroy.
/// </param>
/// <param name="destroy">
/// Callback to call when @data is not needed anymore.
/// </param>
/// <return>
/// New blob, or the empty blob if something failed or if @length is
/// zero.  Destroy with hb_blob_destroy().
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreate(string data, uint length, MentorLake.HarfBuzz.hb_memory_mode_t mode, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create(data, length, mode, user_data, destroy);
	}

/// <summary>
/// <para>
/// Creates a new blob containing the data from the
/// specified binary font file.
/// </para>
/// <para>
/// The filename is passed directly to the system on all platforms,
/// except on Windows, where the filename is interpreted as UTF-8.
/// Only if the filename is not valid UTF-8, it will be interpreted
/// according to the system codepage.
/// </para>
/// </summary>

/// <param name="file_name">
/// A font filename
/// </param>
/// <return>
/// An #hb_blob_t pointer with the content of the file,
/// or hb_blob_get_empty() if failed.
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreateFromFile(string file_name)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create_from_file(file_name);
	}

/// <summary>
/// <para>
/// Creates a new blob containing the data from the
/// specified binary font file.
/// </para>
/// <para>
/// The filename is passed directly to the system on all platforms,
/// except on Windows, where the filename is interpreted as UTF-8.
/// Only if the filename is not valid UTF-8, it will be interpreted
/// according to the system codepage.
/// </para>
/// </summary>

/// <param name="file_name">
/// A font filename
/// </param>
/// <return>
/// An #hb_blob_t pointer with the content of the file,
/// or `NULL` if failed.
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreateFromFileOrFail(string file_name)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create_from_file_or_fail(file_name);
	}

/// <summary>
/// <para>
/// Creates a new &quot;blob&quot; object wrapping @data.  The @mode parameter is used
/// to negotiate ownership and lifecycle of @data.
/// </para>
/// <para>
/// Note that this function returns a freshly-allocated empty blob even if @length
/// is zero. This is in contrast to hb_blob_create(), which returns the singleton
/// empty blob (as returned by hb_blob_get_empty()) if @length is zero.
/// </para>
/// </summary>

/// <param name="data">
/// Pointer to blob data.
/// </param>
/// <param name="length">
/// Length of @data in bytes.
/// </param>
/// <param name="mode">
/// Memory mode for @data.
/// </param>
/// <param name="user_data">
/// Data parameter to pass to @destroy.
/// </param>
/// <param name="destroy">
/// Callback to call when @data is not needed anymore.
/// </param>
/// <return>
/// New blob, or `NULL` if failed.  Destroy with hb_blob_destroy().
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreateOrFail(string data, uint length, MentorLake.HarfBuzz.hb_memory_mode_t mode, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create_or_fail(data, length, mode, user_data, destroy);
	}

/// <summary>
/// <para>
/// Returns a blob that represents a range of bytes in @parent.  The new
/// blob is always created with #HB_MEMORY_MODE_READONLY, meaning that it
/// will never modify data in the parent blob.  The parent data is not
/// expected to be modified, and will result in undefined behavior if it
/// is.
/// </para>
/// <para>
/// Makes @parent immutable.
/// </para>
/// </summary>

/// <param name="parent">
/// Parent blob.
/// </param>
/// <param name="offset">
/// Start offset of sub-blob within @parent, in bytes.
/// </param>
/// <param name="length">
/// Length of sub-blob.
/// </param>
/// <return>
/// New blob, or the empty blob if something failed or if
/// @length is zero or @offset is beyond the end of @parent&apos;s data.  Destroy
/// with hb_blob_destroy().
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobCreateSubBlob(MentorLake.HarfBuzz.hb_blob_tHandle parent, uint offset, uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_create_sub_blob(parent, offset, length);
	}

/// <summary>
/// <para>
/// Decreases the reference count on @blob, and if it reaches zero, destroys
/// @blob, freeing all memory, possibly calling the destroy-callback the blob
/// was created for if it has not been called already.
/// </para>
/// <para>
/// See TODO:link object types for more information.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob.
/// </param>

	public static void BlobDestroy(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		HarfBuzzGlobalFunctionsExterns.hb_blob_destroy(blob);
	}

/// <summary>
/// <para>
/// Fetches the data from a blob.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob.
/// </param>
/// <param name="length">
/// The length in bytes of the data retrieved
/// </param>
/// <return>
/// the byte data of @blob.
/// </return>

	public static string[] BlobGetData(MentorLake.HarfBuzz.hb_blob_tHandle blob, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_data(blob, out length);
	}

/// <summary>
/// <para>
/// Tries to make blob data writable (possibly copying it) and
/// return pointer to data.
/// </para>
/// <para>
/// Fails if blob has been made immutable, or if memory allocation
/// fails.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob.
/// </param>
/// <param name="length">
/// output length of the writable data.
/// </param>
/// <return>
/// Writable blob data,
/// or `NULL` if failed.
/// </return>

	public static string[] BlobGetDataWritable(MentorLake.HarfBuzz.hb_blob_tHandle blob, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_data_writable(blob, out length);
	}

/// <summary>
/// <para>
/// Returns the singleton empty blob.
/// </para>
/// <para>
/// See TODO:link object types for more information.
/// </para>
/// </summary>

/// <return>
/// The empty blob.
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the length of a blob&apos;s data.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob.
/// </param>
/// <return>
/// the length of @blob data in bytes.
/// </return>

	public static uint BlobGetLength(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_length(blob);
	}

/// <summary>
/// <para>
/// Fetches the user data associated with the specified key,
/// attached to the specified font-functions structure.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr BlobGetUserData(MentorLake.HarfBuzz.hb_blob_tHandle blob, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_get_user_data(blob, key);
	}

/// <summary>
/// <para>
/// Tests whether a blob is immutable.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob.
/// </param>
/// <return>
/// `true` if @blob is immutable, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BlobIsImmutable(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_is_immutable(blob);
	}

/// <summary>
/// <para>
/// Makes a blob immutable.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob
/// </param>

	public static void BlobMakeImmutable(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		HarfBuzzGlobalFunctionsExterns.hb_blob_make_immutable(blob);
	}

/// <summary>
/// <para>
/// Increases the reference count on @blob.
/// </para>
/// <para>
/// See TODO:link object types for more information.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob.
/// </param>
/// <return>
/// @blob.
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle BlobReference(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_reference(blob);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified blob.
/// </para>
/// </summary>

/// <param name="blob">
/// An #hb_blob_t
/// </param>
/// <param name="key">
/// The user-data key to set
/// </param>
/// <param name="data">
/// A pointer to the user data to set
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BlobSetUserData(MentorLake.HarfBuzz.hb_blob_tHandle blob, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_blob_set_user_data(blob, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Appends a character with the Unicode value of @codepoint to @buffer, and
/// gives it the initial cluster value of @cluster. Clusters can be any thing
/// the client wants, they are usually used to refer to the index of the
/// character in the input text stream and are output in
/// #hb_glyph_info_t.cluster field.
/// </para>
/// <para>
/// This function does not check the validity of @codepoint, it is up to the
/// caller to ensure it is a valid Unicode code point.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="codepoint">
/// A Unicode code point.
/// </param>
/// <param name="cluster">
/// The cluster value of @codepoint.
/// </param>

	public static void BufferAdd(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t codepoint, uint cluster)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add(buffer, codepoint, cluster);
	}

/// <summary>
/// <para>
/// Appends characters from @text array to @buffer. The @item_offset is the
/// position of the first character from @text that will be appended, and
/// @item_length is the number of character. When shaping part of a larger text
/// (e.g. a run of text from a paragraph), instead of passing just the substring
/// corresponding to the run, it is preferable to pass the whole
/// paragraph and specify the run start and length as @item_offset and
/// @item_length, respectively, to give HarfBuzz the full context to be able,
/// for example, to do cross-run Arabic shaping or properly handle combining
/// marks at stat of run.
/// </para>
/// <para>
/// This function does not check the validity of @text, it is up to the caller
/// to ensure it contains a valid Unicode scalar values.  In contrast,
/// hb_buffer_add_utf32() can be used that takes similar input but performs
/// sanity-check on the input.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #hb_buffer_t to append characters to.
/// </param>
/// <param name="text">
/// an array of Unicode code points to append.
/// </param>
/// <param name="text_length">
/// the length of the @text, or -1 if it is `NULL` terminated.
/// </param>
/// <param name="item_offset">
/// the offset of the first code point to add to the @buffer.
/// </param>
/// <param name="item_length">
/// the number of code points to add to the @buffer, or -1 for the
///               end of @text (assuming it is `NULL` terminated).
/// </param>

	public static void BufferAddCodepoints(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_codepoints(buffer, text, text_length, item_offset, item_length);
	}

/// <summary>
/// <para>
/// Similar to hb_buffer_add_codepoints(), but allows only access to first 256
/// Unicode code points that can fit in 8-bit strings.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Has nothing to do with non-Unicode Latin-1 encoding.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="text">
/// an array of UTF-8
///               characters to append
/// </param>
/// <param name="text_length">
/// the length of the @text, or -1 if it is `NULL` terminated
/// </param>
/// <param name="item_offset">
/// the offset of the first character to add to the @buffer
/// </param>
/// <param name="item_length">
/// the number of characters to add to the @buffer, or -1 for the
///               end of @text (assuming it is `NULL` terminated)
/// </param>

	public static void BufferAddLatin1(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, byte[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_latin1(buffer, text, text_length, item_offset, item_length);
	}

/// <summary>
/// <para>
/// See hb_buffer_add_codepoints().
/// </para>
/// <para>
/// Replaces invalid UTF-16 characters with the @buffer replacement code point,
/// see hb_buffer_set_replacement_codepoint().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="text">
/// An array of UTF-16 characters to append
/// </param>
/// <param name="text_length">
/// The length of the @text, or -1 if it is `NULL` terminated
/// </param>
/// <param name="item_offset">
/// The offset of the first character to add to the @buffer
/// </param>
/// <param name="item_length">
/// The number of characters to add to the @buffer, or -1 for the
///               end of @text (assuming it is `NULL` terminated)
/// </param>

	public static void BufferAddUtf16(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, ushort[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_utf16(buffer, text, text_length, item_offset, item_length);
	}

/// <summary>
/// <para>
/// See hb_buffer_add_codepoints().
/// </para>
/// <para>
/// Replaces invalid UTF-32 characters with the @buffer replacement code point,
/// see hb_buffer_set_replacement_codepoint().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="text">
/// An array of UTF-32 characters to append
/// </param>
/// <param name="text_length">
/// The length of the @text, or -1 if it is `NULL` terminated
/// </param>
/// <param name="item_offset">
/// The offset of the first character to add to the @buffer
/// </param>
/// <param name="item_length">
/// The number of characters to add to the @buffer, or -1 for the
///               end of @text (assuming it is `NULL` terminated)
/// </param>

	public static void BufferAddUtf32(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_utf32(buffer, text, text_length, item_offset, item_length);
	}

/// <summary>
/// <para>
/// See hb_buffer_add_codepoints().
/// </para>
/// <para>
/// Replaces invalid UTF-8 characters with the @buffer replacement code point,
/// see hb_buffer_set_replacement_codepoint().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="text">
/// An array of UTF-8
///               characters to append.
/// </param>
/// <param name="text_length">
/// The length of the @text, or -1 if it is `NULL` terminated.
/// </param>
/// <param name="item_offset">
/// The offset of the first character to add to the @buffer.
/// </param>
/// <param name="item_length">
/// The number of characters to add to the @buffer, or -1 for the
///               end of @text (assuming it is `NULL` terminated).
/// </param>

	public static void BufferAddUtf8(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, byte[] text, int text_length, uint item_offset, int item_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_add_utf8(buffer, text, text_length, item_offset, item_length);
	}

/// <summary>
/// <para>
/// Check if allocating memory for the buffer succeeded.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// `true` if @buffer memory allocation succeeded, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BufferAllocationSuccessful(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_allocation_successful(buffer);
	}

/// <summary>
/// <para>
/// Append (part of) contents of another buffer to this buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="source">
/// source #hb_buffer_t
/// </param>
/// <param name="start">
/// start index into source buffer to copy.  Use 0 to copy from start of buffer.
/// </param>
/// <param name="end">
/// end index into source buffer to copy.  Use @HB_FEATURE_GLOBAL_END to copy to end of buffer.
/// </param>

	public static void BufferAppend(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_tHandle source, uint start, uint end)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_append(buffer, source, start, end);
	}

/// <summary>
/// <para>
/// Similar to hb_buffer_reset(), but does not clear the Unicode functions and
/// the replacement code point.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>

	public static void BufferClearContents(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_clear_contents(buffer);
	}

/// <summary>
/// <para>
/// Creates a new #hb_buffer_t with all properties to defaults.
/// </para>
/// </summary>

/// <return>
/// 
/// A newly allocated #hb_buffer_t with a reference count of 1. The initial
/// reference count should be released with hb_buffer_destroy() when you are done
/// using the #hb_buffer_t. This function never returns `NULL`. If memory cannot
/// be allocated, a special #hb_buffer_t object will be returned on which
/// hb_buffer_allocation_successful() returns `false`.
/// </return>

	public static MentorLake.HarfBuzz.hb_buffer_tHandle BufferCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_create();
	}

/// <summary>
/// <para>
/// Creates a new #hb_buffer_t, similar to hb_buffer_create(). The only
/// difference is that the buffer is configured similarly to @src.
/// </para>
/// </summary>

/// <param name="src">
/// An #hb_buffer_t
/// </param>
/// <return>
/// 
/// A newly allocated #hb_buffer_t, similar to hb_buffer_create().
/// </return>

	public static MentorLake.HarfBuzz.hb_buffer_tHandle BufferCreateSimilar(MentorLake.HarfBuzz.hb_buffer_tHandle src)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_create_similar(src);
	}

/// <summary>
/// <para>
/// Deserializes glyphs @buffer from textual representation in the format
/// produced by hb_buffer_serialize_glyphs().
/// </para>
/// </summary>

/// <param name="buffer">
/// an #hb_buffer_t buffer.
/// </param>
/// <param name="buf">
/// string to deserialize
/// </param>
/// <param name="buf_len">
/// the size of @buf, or -1 if it is `NULL`-terminated
/// </param>
/// <param name="end_ptr">
/// output pointer to the character after last
///                               consumed one.
/// </param>
/// <param name="font">
/// font for getting glyph IDs
/// </param>
/// <param name="format">
/// the #hb_buffer_serialize_format_t of the input @buf
/// </param>
/// <return>
/// `true` if parse was successful, `false` if an error
/// occurred.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BufferDeserializeGlyphs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, string[] buf, int buf_len, out string end_ptr, MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_deserialize_glyphs(buffer, buf, buf_len, out end_ptr, font, format);
	}

/// <summary>
/// <para>
/// Deserializes Unicode @buffer from textual representation in the format
/// produced by hb_buffer_serialize_unicode().
/// </para>
/// </summary>

/// <param name="buffer">
/// an #hb_buffer_t buffer.
/// </param>
/// <param name="buf">
/// string to deserialize
/// </param>
/// <param name="buf_len">
/// the size of @buf, or -1 if it is `NULL`-terminated
/// </param>
/// <param name="end_ptr">
/// output pointer to the character after last
///                               consumed one.
/// </param>
/// <param name="format">
/// the #hb_buffer_serialize_format_t of the input @buf
/// </param>
/// <return>
/// `true` if parse was successful, `false` if an error
/// occurred.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BufferDeserializeUnicode(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, string[] buf, int buf_len, out string end_ptr, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_deserialize_unicode(buffer, buf, buf_len, out end_ptr, format);
	}

/// <summary>
/// <para>
/// Deallocate the @buffer.
/// Decreases the reference count on @buffer by one. If the result is zero, then
/// @buffer and all associated resources are freed. See hb_buffer_reference().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>

	public static void BufferDestroy(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_destroy(buffer);
	}

/// <summary>
/// <para>
/// If dottedcircle_glyph is (hb_codepoint_t) -1 then #HB_BUFFER_DIFF_FLAG_DOTTED_CIRCLE_PRESENT
/// and #HB_BUFFER_DIFF_FLAG_NOTDEF_PRESENT are never returned.  This should be used by most
/// callers if just comparing two buffers is needed.
/// </para>
/// </summary>

/// <param name="buffer">
/// a buffer.
/// </param>
/// <param name="reference">
/// other buffer to compare to.
/// </param>
/// <param name="dottedcircle_glyph">
/// glyph id of U+25CC DOTTED CIRCLE, or (hb_codepoint_t) -1.
/// </param>
/// <param name="position_fuzz">
/// allowed absolute difference in position values.
/// </param>

	public static MentorLake.HarfBuzz.hb_buffer_diff_flags_t BufferDiff(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_tHandle reference, MentorLake.HarfBuzz.hb_codepoint_t dottedcircle_glyph, uint position_fuzz)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_diff(buffer, reference, dottedcircle_glyph, position_fuzz);
	}

/// <summary>
/// <para>
/// Fetches the cluster level of a buffer. The #hb_buffer_cluster_level_t
/// dictates one aspect of how HarfBuzz will treat non-base characters
/// during shaping.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The cluster level of @buffer
/// </return>

	public static MentorLake.HarfBuzz.hb_buffer_cluster_level_t BufferGetClusterLevel(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_cluster_level(buffer);
	}

/// <summary>
/// <para>
/// Fetches the type of @buffer contents. Buffers are either empty, contain
/// characters (before shaping), or contain glyphs (the result of shaping).
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The type of @buffer contents
/// </return>

	public static MentorLake.HarfBuzz.hb_buffer_content_type_t BufferGetContentType(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_content_type(buffer);
	}

/// <summary>
/// <para>
/// See hb_buffer_set_direction()
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The direction of the @buffer.
/// </return>

	public static MentorLake.HarfBuzz.hb_direction_t BufferGetDirection(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_direction(buffer);
	}

/// <summary>
/// <para>
/// Fetches an empty #hb_buffer_t.
/// </para>
/// </summary>

/// <return>
/// The empty buffer
/// </return>

	public static MentorLake.HarfBuzz.hb_buffer_tHandle BufferGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the #hb_buffer_flags_t of @buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The @buffer flags
/// </return>

	public static MentorLake.HarfBuzz.hb_buffer_flags_t BufferGetFlags(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_flags(buffer);
	}

/// <summary>
/// <para>
/// Returns @buffer glyph information array.  Returned pointer
/// is valid as long as @buffer contents are not modified.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="length">
/// The output-array length.
/// </param>
/// <return>
/// 
/// The @buffer glyph information array.
/// The value valid as long as buffer has not been modified.
/// </return>

	public static MentorLake.HarfBuzz.hb_glyph_info_t[] BufferGetGlyphInfos(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_glyph_infos(buffer, out length);
	}

/// <summary>
/// <para>
/// Returns @buffer glyph position array.  Returned pointer
/// is valid as long as @buffer contents are not modified.
/// </para>
/// <para>
/// If buffer did not have positions before, the positions will be
/// initialized to zeros, unless this function is called from
/// within a buffer message callback (see hb_buffer_set_message_func()),
/// in which case `NULL` is returned.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="length">
/// The output length
/// </param>
/// <return>
/// 
/// The @buffer glyph position array.
/// The value valid as long as buffer has not been modified.
/// </return>

	public static MentorLake.HarfBuzz.hb_glyph_position_t[] BufferGetGlyphPositions(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_glyph_positions(buffer, out length);
	}

/// <summary>
/// <para>
/// See hb_buffer_set_invisible_glyph().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The @buffer invisible #hb_codepoint_t
/// </return>

	public static MentorLake.HarfBuzz.hb_codepoint_t BufferGetInvisibleGlyph(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_invisible_glyph(buffer);
	}

/// <summary>
/// <para>
/// See hb_buffer_set_language().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// 
/// The #hb_language_t of the buffer. Must not be freed by the caller.
/// </return>

	public static MentorLake.HarfBuzz.hb_language_t BufferGetLanguage(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_language(buffer);
	}

/// <summary>
/// <para>
/// Returns the number of items in the buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The @buffer length.
/// The value valid as long as buffer has not been modified.
/// </return>

	public static uint BufferGetLength(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_length(buffer);
	}

/// <summary>
/// <para>
/// See hb_buffer_set_not_found_glyph().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The @buffer not-found #hb_codepoint_t
/// </return>

	public static MentorLake.HarfBuzz.hb_codepoint_t BufferGetNotFoundGlyph(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_not_found_glyph(buffer);
	}

/// <summary>
/// <para>
/// See hb_buffer_set_random_state().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The @buffer random state
/// </return>

	public static uint BufferGetRandomState(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_random_state(buffer);
	}

/// <summary>
/// <para>
/// Fetches the #hb_codepoint_t that replaces invalid entries for a given encoding
/// when adding text to @buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The @buffer replacement #hb_codepoint_t
/// </return>

	public static MentorLake.HarfBuzz.hb_codepoint_t BufferGetReplacementCodepoint(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_replacement_codepoint(buffer);
	}

/// <summary>
/// <para>
/// Fetches the script of @buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The #hb_script_t of the @buffer
/// </return>

	public static MentorLake.HarfBuzz.hb_script_t BufferGetScript(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_script(buffer);
	}

/// <summary>
/// <para>
/// Sets @props to the #hb_segment_properties_t of @buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="props">
/// The output #hb_segment_properties_t
/// </param>

	public static void BufferGetSegmentProperties(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, out MentorLake.HarfBuzz.hb_segment_properties_t props)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_get_segment_properties(buffer, out props);
	}

/// <summary>
/// <para>
/// Fetches the Unicode-functions structure of a buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// The Unicode-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle BufferGetUnicodeFuncs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_unicode_funcs(buffer);
	}

/// <summary>
/// <para>
/// Fetches the user data associated with the specified key,
/// attached to the specified buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr BufferGetUserData(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_get_user_data(buffer, key);
	}

/// <summary>
/// <para>
/// Sets unset buffer segment properties based on buffer Unicode
/// contents.  If buffer is not empty, it must have content type
/// #HB_BUFFER_CONTENT_TYPE_UNICODE.
/// </para>
/// <para>
/// If buffer script is not set (ie. is #HB_SCRIPT_INVALID), it
/// will be set to the Unicode script of the first character in
/// the buffer that has a script other than #HB_SCRIPT_COMMON,
/// #HB_SCRIPT_INHERITED, and #HB_SCRIPT_UNKNOWN.
/// </para>
/// <para>
/// Next, if buffer direction is not set (ie. is #HB_DIRECTION_INVALID),
/// it will be set to the natural horizontal direction of the
/// buffer script as returned by hb_script_get_horizontal_direction().
/// If hb_script_get_horizontal_direction() returns #HB_DIRECTION_INVALID,
/// then #HB_DIRECTION_LTR is used.
/// </para>
/// <para>
/// Finally, if buffer language is not set (ie. is #HB_LANGUAGE_INVALID),
/// it will be set to the process&apos;s default language as returned by
/// hb_language_get_default().  This may change in the future by
/// taking buffer script into consideration when choosing a language.
/// Note that hb_language_get_default() is NOT threadsafe the first time
/// it is called.  See documentation for that function for details.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>

	public static void BufferGuessSegmentProperties(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_guess_segment_properties(buffer);
	}

/// <summary>
/// <para>
/// Returns whether @buffer has glyph position data.
/// A buffer gains position data when hb_buffer_get_glyph_positions() is called on it,
/// and cleared of position data when hb_buffer_clear_contents() is called.
/// </para>
/// </summary>

/// <param name="buffer">
/// an #hb_buffer_t.
/// </param>
/// <return>
/// `true` if the @buffer has position array, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BufferHasPositions(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_has_positions(buffer);
	}

/// <summary>
/// <para>
/// Reorders a glyph buffer to have canonical in-cluster glyph order / position.
/// The resulting clusters should behave identical to pre-reordering clusters.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;This has nothing to do with Unicode normalization.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>

	public static void BufferNormalizeGlyphs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_normalize_glyphs(buffer);
	}

/// <summary>
/// <para>
/// Pre allocates memory for @buffer to fit at least @size number of items.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="size">
/// Number of items to pre allocate.
/// </param>
/// <return>
/// `true` if @buffer memory allocation succeeded, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BufferPreAllocate(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint size)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_pre_allocate(buffer, size);
	}

/// <summary>
/// <para>
/// Increases the reference count on @buffer by one. This prevents @buffer from
/// being destroyed until a matching call to hb_buffer_destroy() is made.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <return>
/// 
/// The referenced #hb_buffer_t.
/// </return>

	public static MentorLake.HarfBuzz.hb_buffer_tHandle BufferReference(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_reference(buffer);
	}

/// <summary>
/// <para>
/// Resets the buffer to its initial status, as if it was just newly created
/// with hb_buffer_create().
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>

	public static void BufferReset(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_reset(buffer);
	}

/// <summary>
/// <para>
/// Reverses buffer contents.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>

	public static void BufferReverse(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_reverse(buffer);
	}

/// <summary>
/// <para>
/// Reverses buffer clusters.  That is, the buffer contents are
/// reversed, then each cluster (consecutive items having the
/// same cluster number) are reversed again.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>

	public static void BufferReverseClusters(MentorLake.HarfBuzz.hb_buffer_tHandle buffer)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_reverse_clusters(buffer);
	}

/// <summary>
/// <para>
/// Reverses buffer contents between @start and @end.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="start">
/// start index
/// </param>
/// <param name="end">
/// end index
/// </param>

	public static void BufferReverseRange(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_reverse_range(buffer, start, end);
	}

/// <summary>
/// <para>
/// Serializes @buffer into a textual representation of its content, whether
/// Unicode codepoints or glyph identifiers and positioning information. This is
/// useful for showing the contents of the buffer, for example during debugging.
/// See the documentation of hb_buffer_serialize_unicode() and
/// hb_buffer_serialize_glyphs() for a description of the output format.
/// </para>
/// </summary>

/// <param name="buffer">
/// an #hb_buffer_t buffer.
/// </param>
/// <param name="start">
/// the first item in @buffer to serialize.
/// </param>
/// <param name="end">
/// the last item in @buffer to serialize.
/// </param>
/// <param name="buf">
/// output string to
///       write serialized buffer into.
/// </param>
/// <param name="buf_size">
/// the size of @buf.
/// </param>
/// <param name="buf_consumed">
/// if not `NULL`, will be set to the number of bytes written into @buf.
/// </param>
/// <param name="font">
/// the #hb_font_t used to shape this buffer, needed to
///        read glyph names and extents. If `NULL`, an empty font will be used.
/// </param>
/// <param name="format">
/// the #hb_buffer_serialize_format_t to use for formatting the output.
/// </param>
/// <param name="flags">
/// the #hb_buffer_serialize_flags_t that control what glyph properties
///         to serialize.
/// </param>
/// <return>
/// The number of serialized items.
/// </return>

	public static uint BufferSerialize(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize(buffer, start, end, out buf, out buf_size, out buf_consumed, font, format, flags);
	}

/// <summary>
/// <para>
/// Parses a string into an #hb_buffer_serialize_format_t. Does not check if
/// @str is a valid buffer serialization format, use
/// hb_buffer_serialize_list_formats() to get the list of supported formats.
/// </para>
/// </summary>

/// <param name="str">
/// a string to parse
/// </param>
/// <param name="len">
/// length of @str, or -1 if string is `NULL` terminated
/// </param>
/// <return>
/// The parsed #hb_buffer_serialize_format_t.
/// </return>

	public static MentorLake.HarfBuzz.hb_buffer_serialize_format_t BufferSerializeFormatFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_format_from_string(str, len);
	}

/// <summary>
/// <para>
/// Converts @format to the string corresponding it, or `NULL` if it is not a valid
/// #hb_buffer_serialize_format_t.
/// </para>
/// </summary>

/// <param name="format">
/// an #hb_buffer_serialize_format_t to convert.
/// </param>
/// <return>
/// 
/// A `NULL` terminated string corresponding to @format. Should not be freed.
/// </return>

	public static string BufferSerializeFormatToString(MentorLake.HarfBuzz.hb_buffer_serialize_format_t format)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_format_to_string(format);
	}

/// <summary>
/// <para>
/// Serializes @buffer into a textual representation of its glyph content,
/// useful for showing the contents of the buffer, for example during debugging.
/// There are currently two supported serialization formats:
/// </para>
/// <para>
/// ## text
/// A human-readable, plain text format.
/// The serialized glyphs will look something like:
/// </para>
/// <para>
/// ```
/// [uni0651=0@518,0+0|uni0628=0+1897]
/// ```
/// </para>
/// <para>
/// - The serialized glyphs are delimited with `[` and `]`.
/// - Glyphs are separated with `|`
/// - Each glyph starts with glyph name, or glyph index if
///   #HB_BUFFER_SERIALIZE_FLAG_NO_GLYPH_NAMES flag is set. Then,
///   - If #HB_BUFFER_SERIALIZE_FLAG_NO_CLUSTERS is not set, `=` then #hb_glyph_info_t.cluster.
///   - If #HB_BUFFER_SERIALIZE_FLAG_NO_POSITIONS is not set, the #hb_glyph_position_t in the format:
///     - If both #hb_glyph_position_t.x_offset and #hb_glyph_position_t.y_offset are not 0, `@x_offset,y_offset`. Then,
///     - `+x_advance`, then `,y_advance` if #hb_glyph_position_t.y_advance is not 0. Then,
///   - If #HB_BUFFER_SERIALIZE_FLAG_GLYPH_EXTENTS is set, the #hb_glyph_extents_t in the format `&amp;lt;x_bearing,y_bearing,width,height&amp;gt;`
/// </para>
/// <para>
/// ## json
/// A machine-readable, structured format.
/// The serialized glyphs will look something like:
/// </para>
/// <para>
/// ```
/// [{&quot;g&quot;:&quot;uni0651&quot;,&quot;cl&quot;:0,&quot;dx&quot;:518,&quot;dy&quot;:0,&quot;ax&quot;:0,&quot;ay&quot;:0},
/// {&quot;g&quot;:&quot;uni0628&quot;,&quot;cl&quot;:0,&quot;dx&quot;:0,&quot;dy&quot;:0,&quot;ax&quot;:1897,&quot;ay&quot;:0}]
/// ```
/// </para>
/// <para>
/// Each glyph is a JSON object, with the following properties:
/// - `g`: the glyph name or glyph index if
///   #HB_BUFFER_SERIALIZE_FLAG_NO_GLYPH_NAMES flag is set.
/// - `cl`: #hb_glyph_info_t.cluster if
///   #HB_BUFFER_SERIALIZE_FLAG_NO_CLUSTERS is not set.
/// - `dx`,`dy`,`ax`,`ay`: #hb_glyph_position_t.x_offset, #hb_glyph_position_t.y_offset,
///    #hb_glyph_position_t.x_advance and #hb_glyph_position_t.y_advance
///    respectively, if #HB_BUFFER_SERIALIZE_FLAG_NO_POSITIONS is not set.
/// - `xb`,`yb`,`w`,`h`: #hb_glyph_extents_t.x_bearing, #hb_glyph_extents_t.y_bearing,
///    #hb_glyph_extents_t.width and #hb_glyph_extents_t.height respectively if
///    #HB_BUFFER_SERIALIZE_FLAG_GLYPH_EXTENTS is set.
/// </para>
/// </summary>

/// <param name="buffer">
/// an #hb_buffer_t buffer.
/// </param>
/// <param name="start">
/// the first item in @buffer to serialize.
/// </param>
/// <param name="end">
/// the last item in @buffer to serialize.
/// </param>
/// <param name="buf">
/// output string to
///       write serialized buffer into.
/// </param>
/// <param name="buf_size">
/// the size of @buf.
/// </param>
/// <param name="buf_consumed">
/// if not `NULL`, will be set to the number of bytes written into @buf.
/// </param>
/// <param name="font">
/// the #hb_font_t used to shape this buffer, needed to
///        read glyph names and extents. If `NULL`, an empty font will be used.
/// </param>
/// <param name="format">
/// the #hb_buffer_serialize_format_t to use for formatting the output.
/// </param>
/// <param name="flags">
/// the #hb_buffer_serialize_flags_t that control what glyph properties
///         to serialize.
/// </param>
/// <return>
/// The number of serialized items.
/// </return>

	public static uint BufferSerializeGlyphs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_glyphs(buffer, start, end, out buf, out buf_size, out buf_consumed, font, format, flags);
	}

/// <summary>
/// <para>
/// Returns a list of supported buffer serialization formats.
/// </para>
/// </summary>

/// <return>
/// 
/// A string array of buffer serialization formats. Should not be freed.
/// </return>

	public static string[] BufferSerializeListFormats()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_list_formats();
	}

/// <summary>
/// <para>
/// Serializes @buffer into a textual representation of its content,
/// when the buffer contains Unicode codepoints (i.e., before shaping). This is
/// useful for showing the contents of the buffer, for example during debugging.
/// There are currently two supported serialization formats:
/// </para>
/// <para>
/// ## text
/// A human-readable, plain text format.
/// The serialized codepoints will look something like:
/// </para>
/// <para>
/// ```
///  &amp;lt;U+0651=0|U+0628=1&amp;gt;
/// ```
/// </para>
/// <para>
/// - Glyphs are separated with `|`
/// - Unicode codepoints are expressed as zero-padded four (or more)
///   digit hexadecimal numbers preceded by `U+`
/// - If #HB_BUFFER_SERIALIZE_FLAG_NO_CLUSTERS is not set, the cluster
///   will be indicated with a `=` then #hb_glyph_info_t.cluster.
/// </para>
/// <para>
/// ## json
/// A machine-readable, structured format.
/// The serialized codepoints will be a list of objects with the following
/// properties:
/// - `u`: the Unicode codepoint as a decimal integer
/// - `cl`: #hb_glyph_info_t.cluster if
///   #HB_BUFFER_SERIALIZE_FLAG_NO_CLUSTERS is not set.
/// </para>
/// <para>
/// For example:
/// </para>
/// <para>
/// ```
/// [{u:1617,cl:0},{u:1576,cl:1}]
/// ```
/// </para>
/// </summary>

/// <param name="buffer">
/// an #hb_buffer_t buffer.
/// </param>
/// <param name="start">
/// the first item in @buffer to serialize.
/// </param>
/// <param name="end">
/// the last item in @buffer to serialize.
/// </param>
/// <param name="buf">
/// output string to
///       write serialized buffer into.
/// </param>
/// <param name="buf_size">
/// the size of @buf.
/// </param>
/// <param name="buf_consumed">
/// if not `NULL`, will be set to the number of bytes written into @buf.
/// </param>
/// <param name="format">
/// the #hb_buffer_serialize_format_t to use for formatting the output.
/// </param>
/// <param name="flags">
/// the #hb_buffer_serialize_flags_t that control what glyph properties
///         to serialize.
/// </param>
/// <return>
/// The number of serialized items.
/// </return>

	public static uint BufferSerializeUnicode(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, out byte[] buf, out uint buf_size, out uint buf_consumed, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_serialize_unicode(buffer, start, end, out buf, out buf_size, out buf_consumed, format, flags);
	}

/// <summary>
/// <para>
/// Sets the cluster level of a buffer. The #hb_buffer_cluster_level_t
/// dictates one aspect of how HarfBuzz will treat non-base characters
/// during shaping.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="cluster_level">
/// The cluster level to set on the buffer
/// </param>

	public static void BufferSetClusterLevel(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_cluster_level_t cluster_level)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_cluster_level(buffer, cluster_level);
	}

/// <summary>
/// <para>
/// Sets the type of @buffer contents. Buffers are either empty, contain
/// characters (before shaping), or contain glyphs (the result of shaping).
/// </para>
/// <para>
/// You rarely need to call this function, since a number of other
/// functions transition the content type for you. Namely:
/// </para>
/// <para>
/// - A newly created buffer starts with content type
///   %HB_BUFFER_CONTENT_TYPE_INVALID. Calling hb_buffer_reset(),
///   hb_buffer_clear_contents(), as well as calling hb_buffer_set_length()
///   with an argument of zero all set the buffer content type to invalid
///   as well.
/// </para>
/// <para>
/// - Calling hb_buffer_add_utf8(), hb_buffer_add_utf16(),
///   hb_buffer_add_utf32(), hb_buffer_add_codepoints() and
///   hb_buffer_add_latin1() expect that buffer is either empty and
///   have a content type of invalid, or that buffer content type is
///   %HB_BUFFER_CONTENT_TYPE_UNICODE, and they also set the content
///   type to Unicode if they added anything to an empty buffer.
/// </para>
/// <para>
/// - Finally hb_shape() and hb_shape_full() expect that the buffer
///   is either empty and have content type of invalid, or that buffer
///   content type is %HB_BUFFER_CONTENT_TYPE_UNICODE, and upon
///   success they set the buffer content type to
///   %HB_BUFFER_CONTENT_TYPE_GLYPHS.
/// </para>
/// <para>
/// The above transitions are designed such that one can use a buffer
/// in a loop of &quot;reset : add-text : shape&quot; without needing to ever
/// modify the content type manually.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="content_type">
/// The type of buffer contents to set
/// </param>

	public static void BufferSetContentType(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_content_type_t content_type)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_content_type(buffer, content_type);
	}

/// <summary>
/// <para>
/// Set the text flow direction of the buffer. No shaping can happen without
/// setting @buffer direction, and it controls the visual direction for the
/// output glyphs; for RTL direction the glyphs will be reversed. Many layout
/// features depend on the proper setting of the direction, for example,
/// reversing RTL text before shaping, then shaping with LTR direction is not
/// the same as keeping the text in logical order and shaping with RTL
/// direction.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="direction">
/// the #hb_direction_t of the @buffer
/// </param>

	public static void BufferSetDirection(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_direction_t direction)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_direction(buffer, direction);
	}

/// <summary>
/// <para>
/// Sets @buffer flags to @flags. See #hb_buffer_flags_t.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="flags">
/// The buffer flags to set
/// </param>

	public static void BufferSetFlags(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_flags_t flags)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_flags(buffer, flags);
	}

/// <summary>
/// <para>
/// Sets the #hb_codepoint_t that replaces invisible characters in
/// the shaping result.  If set to zero (default), the glyph for the
/// U+0020 SPACE character is used.  Otherwise, this value is used
/// verbatim.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="invisible">
/// the invisible #hb_codepoint_t
/// </param>

	public static void BufferSetInvisibleGlyph(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t invisible)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_invisible_glyph(buffer, invisible);
	}

/// <summary>
/// <para>
/// Sets the language of @buffer to @language.
/// </para>
/// <para>
/// Languages are crucial for selecting which OpenType feature to apply to the
/// buffer which can result in applying language-specific behaviour. Languages
/// are orthogonal to the scripts, and though they are related, they are
/// different concepts and should not be confused with each other.
/// </para>
/// <para>
/// Use hb_language_from_string() to convert from BCP 47 language tags to
/// #hb_language_t.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="language">
/// An hb_language_t to set
/// </param>

	public static void BufferSetLanguage(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_language_t language)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_language(buffer, language);
	}

/// <summary>
/// <para>
/// Similar to hb_buffer_pre_allocate(), but clears any new items added at the
/// end.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="length">
/// The new length of @buffer
/// </param>
/// <return>
/// `true` if @buffer memory allocation succeeded, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BufferSetLength(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_set_length(buffer, length);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_buffer_message_func_t.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="func">
/// Callback function
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void BufferSetMessageFunc(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_buffer_message_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_message_func(buffer, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the #hb_codepoint_t that replaces characters not found in
/// the font during shaping.
/// </para>
/// <para>
/// The not-found glyph defaults to zero, sometimes known as the
/// &quot;.notdef&quot; glyph.  This API allows for differentiating the two.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="not_found">
/// the not-found #hb_codepoint_t
/// </param>

	public static void BufferSetNotFoundGlyph(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t not_found)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_not_found_glyph(buffer, not_found);
	}

/// <summary>
/// <para>
/// Sets the random state of the buffer. The state changes
/// every time a glyph uses randomness (eg. the `rand`
/// OpenType feature). This function together with
/// hb_buffer_get_random_state() allow for transferring
/// the current random state to a subsequent buffer, to
/// get better randomness distribution.
/// </para>
/// <para>
/// Defaults to 1 and when buffer contents are cleared.
/// A value of 0 disables randomness during shaping.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="state">
/// the new random state
/// </param>

	public static void BufferSetRandomState(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint state)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_random_state(buffer, state);
	}

/// <summary>
/// <para>
/// Sets the #hb_codepoint_t that replaces invalid entries for a given encoding
/// when adding text to @buffer.
/// </para>
/// <para>
/// Default is #HB_BUFFER_REPLACEMENT_CODEPOINT_DEFAULT.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="replacement">
/// the replacement #hb_codepoint_t
/// </param>

	public static void BufferSetReplacementCodepoint(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_codepoint_t replacement)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_replacement_codepoint(buffer, replacement);
	}

/// <summary>
/// <para>
/// Sets the script of @buffer to @script.
/// </para>
/// <para>
/// Script is crucial for choosing the proper shaping behaviour for scripts that
/// require it (e.g. Arabic) and the which OpenType features defined in the font
/// to be applied.
/// </para>
/// <para>
/// You can pass one of the predefined #hb_script_t values, or use
/// hb_script_from_string() or hb_script_from_iso15924_tag() to get the
/// corresponding script from an ISO 15924 script tag.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="script">
/// An #hb_script_t to set.
/// </param>

	public static void BufferSetScript(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_script_t script)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_script(buffer, script);
	}

/// <summary>
/// <para>
/// Sets the segment properties of the buffer, a shortcut for calling
/// hb_buffer_set_direction(), hb_buffer_set_script() and
/// hb_buffer_set_language() individually.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="props">
/// An #hb_segment_properties_t to use
/// </param>

	public static void BufferSetSegmentProperties(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_segment_properties_tHandle props)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_segment_properties(buffer, props);
	}

/// <summary>
/// <para>
/// Sets the Unicode-functions structure of a buffer to
/// @unicode_funcs.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="unicode_funcs">
/// The Unicode-functions structure
/// </param>

	public static void BufferSetUnicodeFuncs(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_unicode_funcs_tHandle unicode_funcs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_buffer_set_unicode_funcs(buffer, unicode_funcs);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t
/// </param>
/// <param name="key">
/// The user-data key
/// </param>
/// <param name="data">
/// A pointer to the user data
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t BufferSetUserData(MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_buffer_set_user_data(buffer, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Fetches the alpha channel of the given @color.
/// </para>
/// </summary>

/// <param name="color">
/// an #hb_color_t we are interested in its channels.
/// </param>
/// <return>
/// Alpha channel value
/// </return>

	public static byte ColorGetAlpha(MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_get_alpha(color);
	}

/// <summary>
/// <para>
/// Fetches the blue channel of the given @color.
/// </para>
/// </summary>

/// <param name="color">
/// an #hb_color_t we are interested in its channels.
/// </param>
/// <return>
/// Blue channel value
/// </return>

	public static byte ColorGetBlue(MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_get_blue(color);
	}

/// <summary>
/// <para>
/// Fetches the green channel of the given @color.
/// </para>
/// </summary>

/// <param name="color">
/// an #hb_color_t we are interested in its channels.
/// </param>
/// <return>
/// Green channel value
/// </return>

	public static byte ColorGetGreen(MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_get_green(color);
	}

/// <summary>
/// <para>
/// Fetches the red channel of the given @color.
/// </para>
/// </summary>

/// <param name="color">
/// an #hb_color_t we are interested in its channels.
/// </param>
/// <return>
/// Red channel value
/// </return>

	public static byte ColorGetRed(MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_get_red(color);
	}

/// <summary>
/// <para>
/// Fetches a list of color stops from the given color line object.
/// </para>
/// <para>
/// Note that due to variations being applied, the returned color stops
/// may be out of order. It is the callers responsibility to ensure that
/// color stops are sorted by their offset before they are used.
/// </para>
/// </summary>

/// <param name="color_line">
/// a #hb_color_line_t object
/// </param>
/// <param name="start">
/// the index of the first color stop to return
/// </param>
/// <param name="count">
/// Input = the maximum number of feature tags to return;
///     Output = the actual number of feature tags returned (may be zero)
/// </param>
/// <param name="color_stops">
/// Array of #hb_color_stop_t to populate
/// </param>
/// <return>
/// the total number of color stops in @color_line
/// </return>

	public static uint ColorLineGetColorStops(MentorLake.HarfBuzz.hb_color_line_tHandle color_line, uint start, out uint count, out MentorLake.HarfBuzz.hb_color_stop_t[] color_stops)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_line_get_color_stops(color_line, start, out count, out color_stops);
	}

/// <summary>
/// <para>
/// Fetches the extend mode of the color line object.
/// </para>
/// </summary>

/// <param name="color_line">
/// a #hb_color_line_t object
/// </param>
/// <return>
/// the extend mode of @color_line
/// </return>

	public static MentorLake.HarfBuzz.hb_paint_extend_t ColorLineGetExtend(MentorLake.HarfBuzz.hb_color_line_tHandle color_line)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_color_line_get_extend(color_line);
	}

/// <summary>
/// <para>
/// Converts a string to an #hb_direction_t.
/// </para>
/// <para>
/// Matching is loose and applies only to the first letter. For
/// examples, &quot;LTR&quot; and &quot;left-to-right&quot; will both return #HB_DIRECTION_LTR.
/// </para>
/// <para>
/// Unmatched strings will return #HB_DIRECTION_INVALID.
/// </para>
/// </summary>

/// <param name="str">
/// String to convert
/// </param>
/// <param name="len">
/// Length of @str, or -1 if it is `NULL`-terminated
/// </param>
/// <return>
/// The #hb_direction_t matching @str
/// </return>

	public static MentorLake.HarfBuzz.hb_direction_t DirectionFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_direction_from_string(str, len);
	}

/// <summary>
/// <para>
/// Converts an #hb_direction_t to a string.
/// </para>
/// </summary>

/// <param name="direction">
/// The #hb_direction_t to convert
/// </param>
/// <return>
/// The string corresponding to @direction
/// </return>

	public static string DirectionToString(MentorLake.HarfBuzz.hb_direction_t direction)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_direction_to_string(direction);
	}

/// <summary>
/// <para>
/// Perform a &quot;close-path&quot; draw operation.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>
/// <param name="draw_data">
/// associated draw data passed by the caller
/// </param>
/// <param name="st">
/// current draw state
/// </param>

	public static void DrawClosePath(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_close_path(dfuncs, draw_data, st);
	}

/// <summary>
/// <para>
/// Perform a &quot;cubic-to&quot; draw operation.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>
/// <param name="draw_data">
/// associated draw data passed by the caller
/// </param>
/// <param name="st">
/// current draw state
/// </param>
/// <param name="control1_x">
/// X component of first control point
/// </param>
/// <param name="control1_y">
/// Y component of first control point
/// </param>
/// <param name="control2_x">
/// X component of second control point
/// </param>
/// <param name="control2_y">
/// Y component of second control point
/// </param>
/// <param name="to_x">
/// X component of target point
/// </param>
/// <param name="to_y">
/// Y component of target point
/// </param>

	public static void DrawCubicTo(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_cubic_to(dfuncs, draw_data, st, control1_x, control1_y, control2_x, control2_y, to_x, to_y);
	}

/// <summary>
/// <para>
/// Creates a new draw callbacks object.
/// </para>
/// </summary>

/// <return>
/// 
/// A newly allocated #hb_draw_funcs_t with a reference count of 1. The initial
/// reference count should be released with hb_draw_funcs_destroy when you are
/// done using the #hb_draw_funcs_t. This function never returns `NULL`. If
/// memory cannot be allocated, a special singleton #hb_draw_funcs_t object will
/// be returned.
/// </return>

	public static MentorLake.HarfBuzz.hb_draw_funcs_tHandle DrawFuncsCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_create();
	}

/// <summary>
/// <para>
/// Deallocate the @dfuncs.
/// Decreases the reference count on @dfuncs by one. If the result is zero, then
/// @dfuncs and all associated resources are freed. See hb_draw_funcs_reference().
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>

	public static void DrawFuncsDestroy(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_destroy(dfuncs);
	}

/// <summary>
/// <para>
/// Fetches the singleton empty draw-functions structure.
/// </para>
/// </summary>

/// <return>
/// The empty draw-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_draw_funcs_tHandle DrawFuncsGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the user-data associated with the specified key,
/// attached to the specified draw-functions structure.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// The draw-functions structure
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr DrawFuncsGetUserData(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_get_user_data(dfuncs, key);
	}

/// <summary>
/// <para>
/// Checks whether @dfuncs is immutable.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>
/// <return>
/// `true` if @dfuncs is immutable, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t DrawFuncsIsImmutable(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_is_immutable(dfuncs);
	}

/// <summary>
/// <para>
/// Makes @dfuncs object immutable.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>

	public static void DrawFuncsMakeImmutable(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_make_immutable(dfuncs);
	}

/// <summary>
/// <para>
/// Increases the reference count on @dfuncs by one.
/// </para>
/// <para>
/// This prevents @dfuncs from being destroyed until a matching
/// call to hb_draw_funcs_destroy() is made.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>
/// <return>
/// 
/// The referenced #hb_draw_funcs_t.
/// </return>

	public static MentorLake.HarfBuzz.hb_draw_funcs_tHandle DrawFuncsReference(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_reference(dfuncs);
	}

/// <summary>
/// <para>
/// Sets close-path callback to the draw functions object.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions object
/// </param>
/// <param name="func">
/// close-path callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void DrawFuncsSetClosePathFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_close_path_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_close_path_func(dfuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets cubic-to callback to the draw functions object.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>
/// <param name="func">
/// cubic-to callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void DrawFuncsSetCubicToFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_cubic_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_cubic_to_func(dfuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets line-to callback to the draw functions object.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions object
/// </param>
/// <param name="func">
/// line-to callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void DrawFuncsSetLineToFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_line_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_line_to_func(dfuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets move-to callback to the draw functions object.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions object
/// </param>
/// <param name="func">
/// move-to callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void DrawFuncsSetMoveToFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_move_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_move_to_func(dfuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets quadratic-to callback to the draw functions object.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions object
/// </param>
/// <param name="func">
/// quadratic-to callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void DrawFuncsSetQuadraticToFunc(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_draw_quadratic_to_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_quadratic_to_func(dfuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified draw-functions structure.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// The draw-functions structure
/// </param>
/// <param name="key">
/// The user-data key
/// </param>
/// <param name="data">
/// A pointer to the user data
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t DrawFuncsSetUserData(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_draw_funcs_set_user_data(dfuncs, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Perform a &quot;line-to&quot; draw operation.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>
/// <param name="draw_data">
/// associated draw data passed by the caller
/// </param>
/// <param name="st">
/// current draw state
/// </param>
/// <param name="to_x">
/// X component of target point
/// </param>
/// <param name="to_y">
/// Y component of target point
/// </param>

	public static void DrawLineTo(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st, float to_x, float to_y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_line_to(dfuncs, draw_data, st, to_x, to_y);
	}

/// <summary>
/// <para>
/// Perform a &quot;move-to&quot; draw operation.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>
/// <param name="draw_data">
/// associated draw data passed by the caller
/// </param>
/// <param name="st">
/// current draw state
/// </param>
/// <param name="to_x">
/// X component of target point
/// </param>
/// <param name="to_y">
/// Y component of target point
/// </param>

	public static void DrawMoveTo(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st, float to_x, float to_y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_move_to(dfuncs, draw_data, st, to_x, to_y);
	}

/// <summary>
/// <para>
/// Perform a &quot;quadratic-to&quot; draw operation.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions
/// </param>
/// <param name="draw_data">
/// associated draw data passed by the caller
/// </param>
/// <param name="st">
/// current draw state
/// </param>
/// <param name="control_x">
/// X component of control point
/// </param>
/// <param name="control_y">
/// Y component of control point
/// </param>
/// <param name="to_x">
/// X component of target point
/// </param>
/// <param name="to_y">
/// Y component of target point
/// </param>

	public static void DrawQuadraticTo(MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, MentorLake.HarfBuzz.hb_draw_state_tHandle st, float control_x, float control_y, float to_x, float to_y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_draw_quadratic_to(dfuncs, draw_data, st, control_x, control_y, to_x, to_y);
	}

/// <summary>
/// <para>
/// Add table for @tag with data provided by @blob to the face.  @face must
/// be created using hb_face_builder_create().
/// </para>
/// </summary>

/// <param name="face">
/// A face object created with hb_face_builder_create()
/// </param>
/// <param name="tag">
/// The #hb_tag_t of the table to add
/// </param>
/// <param name="blob">
/// The blob containing the table data to add
/// </param>

	public static MentorLake.HarfBuzz.hb_bool_t FaceBuilderAddTable(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t tag, MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_builder_add_table(face, tag, blob);
	}

/// <summary>
/// <para>
/// Creates a #hb_face_t that can be used with hb_face_builder_add_table().
/// After tables are added to the face, it can be compiled to a binary
/// font file by calling hb_face_reference_blob().
/// </para>
/// </summary>

/// <return>
/// New face.
/// </return>

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceBuilderCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_builder_create();
	}

/// <summary>
/// <para>
/// Set the ordering of tables for serialization. Any tables not
/// specified in the tags list will be ordered after the tables in
/// tags, ordered by the default sort ordering.
/// </para>
/// </summary>

/// <param name="face">
/// A face object created with hb_face_builder_create()
/// </param>
/// <param name="tags">
/// ordered list of table tags terminated by
///   %HB_TAG_NONE
/// </param>

	public static void FaceBuilderSortTables(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t[] tags)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_builder_sort_tables(face, tags);
	}

/// <summary>
/// <para>
/// Collects the mapping from Unicode characters to nominal glyphs of the @face,
/// and optionally all of the Unicode characters covered by @face.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="mapping">
/// The map to add Unicode-to-glyph mapping to
/// </param>
/// <param name="unicodes">
/// The set to add Unicode characters to, or `NULL`
/// </param>

	public static void FaceCollectNominalGlyphMapping(MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_map_t mapping, out MentorLake.HarfBuzz.hb_set_t unicodes)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_collect_nominal_glyph_mapping(face, out mapping, out unicodes);
	}

/// <summary>
/// <para>
/// Collects all of the Unicode characters covered by @face and adds
/// them to the #hb_set_t set @out.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="@out">
/// The set to add Unicode characters to
/// </param>

	public static void FaceCollectUnicodes(MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_set_t @out)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_collect_unicodes(face, out @out);
	}

/// <summary>
/// <para>
/// Collects all Unicode &quot;Variation Selector&quot; characters covered by @face and adds
/// them to the #hb_set_t set @out.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="@out">
/// The set to add Variation Selector characters to
/// </param>

	public static void FaceCollectVariationSelectors(MentorLake.HarfBuzz.hb_face_tHandle face, out MentorLake.HarfBuzz.hb_set_t @out)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_collect_variation_selectors(face, out @out);
	}

/// <summary>
/// <para>
/// Collects all Unicode characters for @variation_selector covered by @face and adds
/// them to the #hb_set_t set @out.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="variation_selector">
/// The Variation Selector to query
/// </param>
/// <param name="@out">
/// The set to add Unicode characters to
/// </param>

	public static void FaceCollectVariationUnicodes(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_set_t @out)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_collect_variation_unicodes(face, variation_selector, out @out);
	}

/// <summary>
/// <para>
/// Fetches the number of faces in a blob.
/// </para>
/// </summary>

/// <param name="blob">
/// a blob.
/// </param>
/// <return>
/// Number of faces in @blob
/// </return>

	public static uint FaceCount(MentorLake.HarfBuzz.hb_blob_tHandle blob)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_count(blob);
	}

/// <summary>
/// <para>
/// Constructs a new face object from the specified blob and
/// a face index into that blob.
/// </para>
/// <para>
/// The face index is used for blobs of file formats such as TTC and
/// DFont that can contain more than one face.  Face indices within
/// such collections are zero-based.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: If the blob font format is not a collection, @index
/// is ignored.  Otherwise, only the lower 16-bits of @index are used.
/// The unmodified @index can be accessed via hb_face_get_index().&amp;lt;/note&amp;gt;
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: The high 16-bits of @index, if non-zero, are used by
/// hb_font_create() to load named-instances in variable fonts.  See
/// hb_font_create() for details.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="blob">
/// #hb_blob_t to work upon
/// </param>
/// <param name="index">
/// The index of the face within @blob
/// </param>
/// <return>
/// The new face object
/// </return>

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceCreate(MentorLake.HarfBuzz.hb_blob_tHandle blob, uint index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_create(blob, index);
	}

/// <summary>
/// <para>
/// Variant of hb_face_create(), built for those cases where it is more
/// convenient to provide data for individual tables instead of the whole font
/// data. With the caveat that hb_face_get_table_tags() does not currently work
/// with faces created this way.
/// </para>
/// <para>
/// Creates a new face object from the specified @user_data and @reference_table_func,
/// with the @destroy callback.
/// </para>
/// </summary>

/// <param name="reference_table_func">
/// Table-referencing function
/// </param>
/// <param name="user_data">
/// A pointer to the user data
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <return>
/// The new face object
/// </return>

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceCreateForTables(MentorLake.HarfBuzz.hb_reference_table_func_t reference_table_func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_create_for_tables(reference_table_func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Decreases the reference count on a face object. When the
/// reference count reaches zero, the face is destroyed,
/// freeing all memory.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>

	public static void FaceDestroy(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_destroy(face);
	}

/// <summary>
/// <para>
/// Fetches the singleton empty face object.
/// </para>
/// </summary>

/// <return>
/// The empty face object
/// </return>

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the glyph-count value of the specified face object.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <return>
/// The glyph-count value of @face
/// </return>

	public static uint FaceGetGlyphCount(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_glyph_count(face);
	}

/// <summary>
/// <para>
/// Fetches the face-index corresponding to the given face.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: face indices within a collection are zero-based.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <return>
/// The index of @face.
/// </return>

	public static uint FaceGetIndex(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_index(face);
	}

/// <summary>
/// <para>
/// Fetches a list of all table tags for a face, if possible. The list returned will
/// begin at the offset provided
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="start_offset">
/// The index of first table tag to retrieve
/// </param>
/// <param name="table_count">
/// Input = the maximum number of table tags to return;
///                Output = the actual number of table tags returned (may be zero)
/// </param>
/// <param name="table_tags">
/// The array of table tags found
/// </param>
/// <return>
/// Total number of tables, or zero if it is not possible to list
/// </return>

	public static uint FaceGetTableTags(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint table_count, out MentorLake.HarfBuzz.hb_tag_t[] table_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_table_tags(face, start_offset, out table_count, out table_tags);
	}

/// <summary>
/// <para>
/// Fetches the units-per-em (UPEM) value of the specified face object.
/// </para>
/// <para>
/// Typical UPEM values for fonts are 1000, or 2048, but any value
/// in between 16 and 16,384 is allowed for OpenType fonts.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <return>
/// The upem value of @face
/// </return>

	public static uint FaceGetUpem(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_upem(face);
	}

/// <summary>
/// <para>
/// Fetches the user data associated with the specified key,
/// attached to the specified face object.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr FaceGetUserData(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_get_user_data(face, key);
	}

/// <summary>
/// <para>
/// Tests whether the given face object is immutable.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <return>
/// `true` is @face is immutable, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FaceIsImmutable(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_is_immutable(face);
	}

/// <summary>
/// <para>
/// Makes the given face object immutable.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>

	public static void FaceMakeImmutable(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_make_immutable(face);
	}

/// <summary>
/// <para>
/// Increases the reference count on a face object.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <return>
/// The @face object
/// </return>

	public static MentorLake.HarfBuzz.hb_face_tHandle FaceReference(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_reference(face);
	}

/// <summary>
/// <para>
/// Fetches a pointer to the binary blob that contains the
/// specified face. Returns an empty blob if referencing face data is not
/// possible.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <return>
/// A pointer to the blob for @face
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle FaceReferenceBlob(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_reference_blob(face);
	}

/// <summary>
/// <para>
/// Fetches a reference to the specified table within
/// the specified face.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="tag">
/// The #hb_tag_t of the table to query
/// </param>
/// <return>
/// A pointer to the @tag table within @face
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle FaceReferenceTable(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_reference_table(face, tag);
	}

/// <summary>
/// <para>
/// Sets the glyph count for a face object to the specified value.
/// </para>
/// <para>
/// This API is used in rare circumstances.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="glyph_count">
/// The glyph-count value to assign
/// </param>

	public static void FaceSetGlyphCount(MentorLake.HarfBuzz.hb_face_tHandle face, uint glyph_count)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_set_glyph_count(face, glyph_count);
	}

/// <summary>
/// <para>
/// Assigns the specified face-index to @face. Fails if the
/// face is immutable.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: changing the index has no effect on the face itself
/// This only changes the value returned by hb_face_get_index().&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="index">
/// The index to assign
/// </param>

	public static void FaceSetIndex(MentorLake.HarfBuzz.hb_face_tHandle face, uint index)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_set_index(face, index);
	}

/// <summary>
/// <para>
/// Sets the units-per-em (upem) for a face object to the specified value.
/// </para>
/// <para>
/// This API is used in rare circumstances.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="upem">
/// The units-per-em value to assign
/// </param>

	public static void FaceSetUpem(MentorLake.HarfBuzz.hb_face_tHandle face, uint upem)
	{
		HarfBuzzGlobalFunctionsExterns.hb_face_set_upem(face, upem);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the given face object.
/// </para>
/// </summary>

/// <param name="face">
/// A face object
/// </param>
/// <param name="key">
/// The user-data key to set
/// </param>
/// <param name="data">
/// A pointer to the user data
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FaceSetUserData(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_face_set_user_data(face, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Parses a string into a #hb_feature_t.
/// </para>
/// <para>
/// The format for specifying feature strings follows. All valid CSS
/// font-feature-settings values other than &apos;normal&apos; and the global values are
/// also accepted, though not documented below. CSS string escapes are not
/// supported.
/// </para>
/// <para>
/// The range indices refer to the positions between Unicode characters. The
/// position before the first character is always 0.
/// </para>
/// <para>
/// The format is Python-esque.  Here is how it all works:
/// </para>
/// <para>
/// &amp;lt;informaltable pgwide=&apos;1&apos; align=&apos;left&apos; frame=&apos;none&apos;&amp;gt;
/// &amp;lt;tgroup cols=&apos;5&apos;&amp;gt;
/// &amp;lt;thead&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;Syntax&amp;lt;/entry&amp;gt;    &amp;lt;entry&amp;gt;Value&amp;lt;/entry&amp;gt; &amp;lt;entry&amp;gt;Start&amp;lt;/entry&amp;gt; &amp;lt;entry&amp;gt;End&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;/thead&amp;gt;
/// &amp;lt;tbody&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;Setting value:&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature on&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;+kern&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature on&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;-kern&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature off&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern=0&amp;lt;/entry&amp;gt;    &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature off&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern=1&amp;lt;/entry&amp;gt;    &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature on&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;aalt=2&amp;lt;/entry&amp;gt;    &amp;lt;entry&amp;gt;2&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Choose 2nd alternate&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;Setting index:&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern[]&amp;lt;/entry&amp;gt;    &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature on&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern[:]&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature on&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern[5:]&amp;lt;/entry&amp;gt;  &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;5&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;∞&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature on, partial&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern[:5]&amp;lt;/entry&amp;gt;  &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;0&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;5&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature on, partial&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern[3:5]&amp;lt;/entry&amp;gt; &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;3&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;5&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn feature on, range&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;kern[3]&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;1&amp;lt;/entry&amp;gt;     &amp;lt;entry&amp;gt;3&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;3+1&amp;lt;/entry&amp;gt; &amp;lt;entry&amp;gt;Turn feature on, single char&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;Mixing it all:&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;row&amp;gt;&amp;lt;entry&amp;gt;aalt[3:5]=2&amp;lt;/entry&amp;gt; &amp;lt;entry&amp;gt;2&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;3&amp;lt;/entry&amp;gt;      &amp;lt;entry&amp;gt;5&amp;lt;/entry&amp;gt;   &amp;lt;entry&amp;gt;Turn 2nd alternate on for range&amp;lt;/entry&amp;gt;&amp;lt;/row&amp;gt;
/// &amp;lt;/tbody&amp;gt;
/// &amp;lt;/tgroup&amp;gt;
/// &amp;lt;/informaltable&amp;gt;
/// </para>
/// </summary>

/// <param name="str">
/// a string to parse
/// </param>
/// <param name="len">
/// length of @str, or -1 if string is `NULL` terminated
/// </param>
/// <param name="feature">
/// the #hb_feature_t to initialize with the parsed values
/// </param>
/// <return>
/// `true` if @str is successfully parsed, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FeatureFromString(byte[] str, int len, out MentorLake.HarfBuzz.hb_feature_t feature)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_feature_from_string(str, len, out feature);
	}

/// <summary>
/// <para>
/// Converts a #hb_feature_t into a `NULL`-terminated string in the format
/// understood by hb_feature_from_string(). The client in responsible for
/// allocating big enough size for @buf, 128 bytes is more than enough.
/// </para>
/// </summary>

/// <param name="feature">
/// an #hb_feature_t to convert
/// </param>
/// <param name="buf">
/// output string
/// </param>
/// <param name="size">
/// the allocated size of @buf
/// </param>

	public static void FeatureToString(MentorLake.HarfBuzz.hb_feature_tHandle feature, out string[] buf, out uint size)
	{
		HarfBuzzGlobalFunctionsExterns.hb_feature_to_string(feature, out buf, out size);
	}

/// <summary>
/// <para>
/// Adds the origin coordinates to an (X,Y) point coordinate, in
/// the specified glyph ID in the specified font.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="x">
/// Input = The original X coordinate
///     Output = The X coordinate plus the X-coordinate of the origin
/// </param>
/// <param name="y">
/// Input = The original Y coordinate
///     Output = The Y coordinate plus the Y-coordinate of the origin
/// </param>

	public static void FontAddGlyphOriginForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, ref MentorLake.HarfBuzz.hb_position_t x, ref MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_add_glyph_origin_for_direction(font, glyph, direction, ref x, ref y);
	}

/// <summary>
/// <para>
/// Notifies the @font that underlying font data has changed.
/// This has the effect of increasing the serial as returned
/// by hb_font_get_serial(), which invalidates internal caches.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>

	public static void FontChanged(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_changed(font);
	}

/// <summary>
/// <para>
/// Constructs a new font object from the specified face.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: If @face&apos;s index value (as passed to hb_face_create()
/// has non-zero top 16-bits, those bits minus one are passed to
/// hb_font_set_var_named_instance(), effectively loading a named-instance
/// of a variable font, instead of the default-instance.  This allows
/// specifying which named-instance to load by default when creating the
/// face.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="face">
/// a face.
/// </param>
/// <return>
/// The new font object
/// </return>

	public static MentorLake.HarfBuzz.hb_font_tHandle FontCreate(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_create(face);
	}

/// <summary>
/// <para>
/// Constructs a sub-font font object from the specified @parent font,
/// replicating the parent&apos;s properties.
/// </para>
/// </summary>

/// <param name="parent">
/// The parent font object
/// </param>
/// <return>
/// The new sub-font font object
/// </return>

	public static MentorLake.HarfBuzz.hb_font_tHandle FontCreateSubFont(MentorLake.HarfBuzz.hb_font_tHandle parent)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_create_sub_font(parent);
	}

/// <summary>
/// <para>
/// Decreases the reference count on the given font object. When the
/// reference count reaches zero, the font is destroyed,
/// freeing all memory.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>

	public static void FontDestroy(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_destroy(font);
	}

/// <summary>
/// <para>
/// Draws the outline that corresponds to a glyph in the specified @font.
/// </para>
/// <para>
/// The outline is returned by way of calls to the callbacks of the @dfuncs
/// objects, with @draw_data passed to them.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID
/// </param>
/// <param name="dfuncs">
/// #hb_draw_funcs_t to draw to
/// </param>
/// <param name="draw_data">
/// User data to pass to draw callbacks
/// </param>

	public static void FontDrawGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_draw_glyph(font, glyph, dfuncs, draw_data);
	}

/// <summary>
/// <para>
/// Creates a new #hb_font_funcs_t structure of font functions.
/// </para>
/// </summary>

/// <return>
/// The font-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_font_funcs_tHandle FontFuncsCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_create();
	}

/// <summary>
/// <para>
/// Decreases the reference count on a font-functions structure. When
/// the reference count reaches zero, the font-functions structure is
/// destroyed, freeing all memory.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// The font-functions structure
/// </param>

	public static void FontFuncsDestroy(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_destroy(ffuncs);
	}

/// <summary>
/// <para>
/// Fetches an empty font-functions structure.
/// </para>
/// </summary>

/// <return>
/// The font-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_font_funcs_tHandle FontFuncsGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the user data associated with the specified key,
/// attached to the specified font-functions structure.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// The font-functions structure
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr FontFuncsGetUserData(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_get_user_data(ffuncs, key);
	}

/// <summary>
/// <para>
/// Tests whether a font-functions structure is immutable.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// The font-functions structure
/// </param>
/// <return>
/// `true` if @ffuncs is immutable, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontFuncsIsImmutable(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_is_immutable(ffuncs);
	}

/// <summary>
/// <para>
/// Makes a font-functions structure immutable.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// The font-functions structure
/// </param>

	public static void FontFuncsMakeImmutable(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_make_immutable(ffuncs);
	}

/// <summary>
/// <para>
/// Increases the reference count on a font-functions structure.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// The font-functions structure
/// </param>
/// <return>
/// The font-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_font_funcs_tHandle FontFuncsReference(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_reference(ffuncs);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_draw_glyph_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetDrawGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_draw_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_draw_glyph_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_font_h_extents_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetFontHExtentsFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_font_h_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_font_h_extents_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_font_v_extents_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetFontVExtentsFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_font_v_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_font_v_extents_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_contour_point_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphContourPointFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_contour_point_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_contour_point_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_extents_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphExtentsFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_extents_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_extents_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_from_name_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphFromNameFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_from_name_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_from_name_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Deprecated.  Use hb_font_funcs_set_nominal_glyph_func() and
/// hb_font_funcs_set_variation_glyph_func() instead.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// The font-functions structure
/// </param>
/// <param name="func">
/// callback function
/// </param>
/// <param name="user_data">
/// data to pass to @func
/// </param>
/// <param name="destroy">
/// function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_h_advance_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphHAdvanceFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_advance_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_h_advance_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_h_advances_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphHAdvancesFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_advances_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_h_advances_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_h_kerning_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphHKerningFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_kerning_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_h_kerning_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_h_origin_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphHOriginFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_h_origin_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_h_origin_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_name_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphNameFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_name_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_name_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_shape_func_t,
/// which is the same as #hb_font_draw_glyph_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphShapeFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_shape_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_shape_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_v_advance_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphVAdvanceFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_advance_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_v_advance_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_v_advances_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphVAdvancesFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_advances_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_v_advances_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_v_kerning_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphVKerningFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_kerning_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_v_kerning_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_glyph_v_origin_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetGlyphVOriginFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_glyph_v_origin_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_glyph_v_origin_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_nominal_glyph_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetNominalGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_nominal_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_nominal_glyph_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_nominal_glyphs_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetNominalGlyphsFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_nominal_glyphs_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_nominal_glyphs_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_paint_glyph_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is no longer needed
/// </param>

	public static void FontFuncsSetPaintGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_paint_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_paint_glyph_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified font-functions structure.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// The font-functions structure
/// </param>
/// <param name="key">
/// The user-data key to set
/// </param>
/// <param name="data">
/// A pointer to the user data set
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontFuncsSetUserData(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_user_data(ffuncs, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_font_get_variation_glyph_func_t.
/// </para>
/// </summary>

/// <param name="ffuncs">
/// A font-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void FontFuncsSetVariationGlyphFunc(MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, MentorLake.HarfBuzz.hb_font_get_variation_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_funcs_set_variation_glyph_func(ffuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Fetches the empty font object.
/// </para>
/// </summary>

/// <return>
/// The empty font object
/// </return>

	public static MentorLake.HarfBuzz.hb_font_tHandle FontGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the extents for a font in a text segment of the
/// specified direction.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="extents">
/// The #hb_font_extents_t retrieved
/// </param>

	public static void FontGetExtentsForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_extents_for_direction(font, direction, out extents);
	}

/// <summary>
/// <para>
/// Fetches the face associated with the specified font object.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// The #hb_face_t value
/// </return>

	public static MentorLake.HarfBuzz.hb_face_tHandle FontGetFace(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_face(font);
	}

/// <summary>
/// <para>
/// Fetches the glyph ID for a Unicode code point in the specified
/// font, with an optional variation selector.
/// </para>
/// <para>
/// If @variation_selector is 0, calls hb_font_get_nominal_glyph();
/// otherwise calls hb_font_get_variation_glyph().
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="unicode">
/// The Unicode code point to query
/// </param>
/// <param name="variation_selector">
/// A variation-selector code point
/// </param>
/// <param name="glyph">
/// The glyph ID retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph(font, unicode, variation_selector, out glyph);
	}

/// <summary>
/// <para>
/// Fetches the advance for a glyph ID from the specified font,
/// in a text segment of the specified direction.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="x">
/// The horizontal advance retrieved
/// </param>
/// <param name="y">
/// The vertical advance retrieved
/// </param>

	public static void FontGetGlyphAdvanceForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_advance_for_direction(font, glyph, direction, out x, out y);
	}

/// <summary>
/// <para>
/// Fetches the advances for a sequence of glyph IDs in the specified
/// font, in a text segment of the specified direction.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="count">
/// The number of glyph IDs in the sequence queried
/// </param>
/// <param name="first_glyph">
/// The first glyph ID to query
/// </param>
/// <param name="glyph_stride">
/// The stride between successive glyph IDs
/// </param>
/// <param name="first_advance">
/// The first advance retrieved
/// </param>
/// <param name="advance_stride">
/// The stride between successive advances
/// </param>

	public static void FontGetGlyphAdvancesForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, uint count, MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, out uint advance_stride)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_advances_for_direction(font, direction, count, first_glyph, glyph_stride, out first_advance, out advance_stride);
	}

/// <summary>
/// <para>
/// Fetches the (x,y) coordinates of a specified contour-point index
/// in the specified glyph, within the specified font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="point_index">
/// The contour-point index to query
/// </param>
/// <param name="x">
/// The X value retrieved for the contour point
/// </param>
/// <param name="y">
/// The Y value retrieved for the contour point
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphContourPoint(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint point_index, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_contour_point(font, glyph, point_index, out x, out y);
	}

/// <summary>
/// <para>
/// Fetches the (X,Y) coordinates of a specified contour-point index
/// in the specified glyph ID in the specified font, with respect
/// to the origin in a text segment in the specified direction.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="point_index">
/// The contour-point index to query
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="x">
/// The X value retrieved for the contour point
/// </param>
/// <param name="y">
/// The Y value retrieved for the contour point
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphContourPointForOrigin(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint point_index, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_contour_point_for_origin(font, glyph, point_index, direction, out x, out y);
	}

/// <summary>
/// <para>
/// Fetches the #hb_glyph_extents_t data for a glyph ID
/// in the specified font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="extents">
/// The #hb_glyph_extents_t retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphExtents(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_glyph_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_extents(font, glyph, out extents);
	}

/// <summary>
/// <para>
/// Fetches the #hb_glyph_extents_t data for a glyph ID
/// in the specified font, with respect to the origin in
/// a text segment in the specified direction.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="extents">
/// The #hb_glyph_extents_t retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphExtentsForOrigin(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_glyph_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_extents_for_origin(font, glyph, direction, out extents);
	}

/// <summary>
/// <para>
/// Fetches the glyph ID that corresponds to a name string in the specified @font.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: @len == -1 means the name string is null-terminated.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="name">
/// The name string to query
/// </param>
/// <param name="len">
/// The length of the name queried
/// </param>
/// <param name="glyph">
/// The glyph ID retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphFromName(MentorLake.HarfBuzz.hb_font_tHandle font, string[] name, int len, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_from_name(font, name, len, out glyph);
	}

/// <summary>
/// <para>
/// Fetches the advance for a glyph ID in the specified font,
/// for horizontal text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <return>
/// The advance of @glyph within @font
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t FontGetGlyphHAdvance(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_h_advance(font, glyph);
	}

/// <summary>
/// <para>
/// Fetches the advances for a sequence of glyph IDs in the specified
/// font, for horizontal text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="count">
/// The number of glyph IDs in the sequence queried
/// </param>
/// <param name="first_glyph">
/// The first glyph ID to query
/// </param>
/// <param name="glyph_stride">
/// The stride between successive glyph IDs
/// </param>
/// <param name="first_advance">
/// The first advance retrieved
/// </param>
/// <param name="advance_stride">
/// The stride between successive advances
/// </param>

	public static void FontGetGlyphHAdvances(MentorLake.HarfBuzz.hb_font_tHandle font, uint count, MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, uint advance_stride)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_h_advances(font, count, first_glyph, glyph_stride, out first_advance, advance_stride);
	}

/// <summary>
/// <para>
/// Fetches the kerning-adjustment value for a glyph-pair in
/// the specified font, for horizontal text segments.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;It handles legacy kerning only (as returned by the corresponding
/// #hb_font_funcs_t function).&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="left_glyph">
/// The glyph ID of the left glyph in the glyph pair
/// </param>
/// <param name="right_glyph">
/// The glyph ID of the right glyph in the glyph pair
/// </param>
/// <return>
/// The kerning adjustment value
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t FontGetGlyphHKerning(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t left_glyph, MentorLake.HarfBuzz.hb_codepoint_t right_glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_h_kerning(font, left_glyph, right_glyph);
	}

/// <summary>
/// <para>
/// Fetches the (X,Y) coordinates of the origin for a glyph ID
/// in the specified font, for horizontal text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="x">
/// The X coordinate of the origin
/// </param>
/// <param name="y">
/// The Y coordinate of the origin
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphHOrigin(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_h_origin(font, glyph, out x, out y);
	}

/// <summary>
/// <para>
/// Fetches the kerning-adjustment value for a glyph-pair in the specified font.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="first_glyph">
/// The glyph ID of the first glyph in the glyph pair to query
/// </param>
/// <param name="second_glyph">
/// The glyph ID of the second glyph in the glyph pair to query
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="x">
/// The horizontal kerning-adjustment value retrieved
/// </param>
/// <param name="y">
/// The vertical kerning-adjustment value retrieved
/// </param>

	public static void FontGetGlyphKerningForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t first_glyph, MentorLake.HarfBuzz.hb_codepoint_t second_glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_kerning_for_direction(font, first_glyph, second_glyph, direction, out x, out y);
	}

/// <summary>
/// <para>
/// Fetches the glyph-name string for a glyph ID in the specified @font.
/// </para>
/// <para>
/// According to the OpenType specification, glyph names are limited to 63
/// characters and can only contain (a subset of) ASCII.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="name">
/// Name string retrieved for the glyph ID
/// </param>
/// <param name="size">
/// Length of the glyph-name string retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphName(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out string[] name, out uint size)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_name(font, glyph, out name, out size);
	}

/// <summary>
/// <para>
/// Fetches the (X,Y) coordinates of the origin for a glyph in
/// the specified font.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="x">
/// The X coordinate retrieved for the origin
/// </param>
/// <param name="y">
/// The Y coordinate retrieved for the origin
/// </param>

	public static void FontGetGlyphOriginForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_origin_for_direction(font, glyph, direction, out x, out y);
	}

/// <summary>
/// <para>
/// Fetches the glyph shape that corresponds to a glyph in the specified @font.
/// The shape is returned by way of calls to the callbacks of the @dfuncs
/// objects, with @draw_data passed to them.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID
/// </param>
/// <param name="dfuncs">
/// #hb_draw_funcs_t to draw to
/// </param>
/// <param name="draw_data">
/// User data to pass to draw callbacks
/// </param>

	public static void FontGetGlyphShape(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_shape(font, glyph, dfuncs, draw_data);
	}

/// <summary>
/// <para>
/// Fetches the advance for a glyph ID in the specified font,
/// for vertical text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <return>
/// The advance of @glyph within @font
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t FontGetGlyphVAdvance(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_v_advance(font, glyph);
	}

/// <summary>
/// <para>
/// Fetches the advances for a sequence of glyph IDs in the specified
/// font, for vertical text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="count">
/// The number of glyph IDs in the sequence queried
/// </param>
/// <param name="first_glyph">
/// The first glyph ID to query
/// </param>
/// <param name="glyph_stride">
/// The stride between successive glyph IDs
/// </param>
/// <param name="first_advance">
/// The first advance retrieved
/// </param>
/// <param name="advance_stride">
/// The stride between successive advances
/// </param>

	public static void FontGetGlyphVAdvances(MentorLake.HarfBuzz.hb_font_tHandle font, uint count, MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, out uint advance_stride)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_v_advances(font, count, first_glyph, glyph_stride, out first_advance, out advance_stride);
	}

/// <summary>
/// <para>
/// Fetches the kerning-adjustment value for a glyph-pair in
/// the specified font, for vertical text segments.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;It handles legacy kerning only (as returned by the corresponding
/// #hb_font_funcs_t function).&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="top_glyph">
/// The glyph ID of the top glyph in the glyph pair
/// </param>
/// <param name="bottom_glyph">
/// The glyph ID of the bottom glyph in the glyph pair
/// </param>
/// <return>
/// The kerning adjustment value
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t FontGetGlyphVKerning(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t top_glyph, MentorLake.HarfBuzz.hb_codepoint_t bottom_glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_v_kerning(font, top_glyph, bottom_glyph);
	}

/// <summary>
/// <para>
/// Fetches the (X,Y) coordinates of the origin for a glyph ID
/// in the specified font, for vertical text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="x">
/// The X coordinate of the origin
/// </param>
/// <param name="y">
/// The Y coordinate of the origin
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetGlyphVOrigin(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_glyph_v_origin(font, glyph, out x, out y);
	}

/// <summary>
/// <para>
/// Fetches the extents for a specified font, for horizontal
/// text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="extents">
/// The font extents retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetHExtents(MentorLake.HarfBuzz.hb_font_tHandle font, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_h_extents(font, out extents);
	}

/// <summary>
/// <para>
/// Fetches the nominal glyph ID for a Unicode code point in the
/// specified font.
/// </para>
/// <para>
/// This version of the function should not be used to fetch glyph IDs
/// for code points modified by variation selectors. For variation-selector
/// support, user hb_font_get_variation_glyph() or use hb_font_get_glyph().
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="unicode">
/// The Unicode code point to query
/// </param>
/// <param name="glyph">
/// The glyph ID retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetNominalGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_nominal_glyph(font, unicode, out glyph);
	}

/// <summary>
/// <para>
/// Fetches the nominal glyph IDs for a sequence of Unicode code points. Glyph
/// IDs must be returned in a #hb_codepoint_t output parameter. Stops at the
/// first unsupported glyph ID.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="count">
/// number of code points to query
/// </param>
/// <param name="first_unicode">
/// The first Unicode code point to query
/// </param>
/// <param name="unicode_stride">
/// The stride between successive code points
/// </param>
/// <param name="first_glyph">
/// The first glyph ID retrieved
/// </param>
/// <param name="glyph_stride">
/// The stride between successive glyph IDs
/// </param>
/// <return>
/// the number of code points processed
/// </return>

	public static uint FontGetNominalGlyphs(MentorLake.HarfBuzz.hb_font_tHandle font, uint count, MentorLake.HarfBuzz.hb_codepoint_tHandle first_unicode, uint unicode_stride, out MentorLake.HarfBuzz.hb_codepoint_t first_glyph, uint glyph_stride)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_nominal_glyphs(font, count, first_unicode, unicode_stride, out first_glyph, glyph_stride);
	}

/// <summary>
/// <para>
/// Fetches the parent font of @font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// The parent font object
/// </return>

	public static MentorLake.HarfBuzz.hb_font_tHandle FontGetParent(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_parent(font);
	}

/// <summary>
/// <para>
/// Fetches the horizontal and vertical points-per-em (ppem) of a font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="x_ppem">
/// Horizontal ppem value
/// </param>
/// <param name="y_ppem">
/// Vertical ppem value
/// </param>

	public static void FontGetPpem(MentorLake.HarfBuzz.hb_font_tHandle font, out uint x_ppem, out uint y_ppem)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_ppem(font, out x_ppem, out y_ppem);
	}

/// <summary>
/// <para>
/// Fetches the &quot;point size&quot; of a font. Used in CoreText to
/// implement optical sizing.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// Point size.  A value of zero means &quot;not set.&quot;
/// </return>

	public static float FontGetPtem(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_ptem(font);
	}

/// <summary>
/// <para>
/// Fetches the horizontal and vertical scale of a font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="x_scale">
/// Horizontal scale value
/// </param>
/// <param name="y_scale">
/// Vertical scale value
/// </param>

	public static void FontGetScale(MentorLake.HarfBuzz.hb_font_tHandle font, out int x_scale, out int y_scale)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_scale(font, out x_scale, out y_scale);
	}

/// <summary>
/// <para>
/// Returns the internal serial number of the font. The serial
/// number is increased every time a setting on the font is
/// changed, using a setter function.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// serial number
/// </return>

	public static uint FontGetSerial(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_serial(font);
	}

/// <summary>
/// <para>
/// Fetches the &quot;synthetic boldness&quot; parameters of a font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="x_embolden">
/// return location for horizontal value
/// </param>
/// <param name="y_embolden">
/// return location for vertical value
/// </param>
/// <param name="in_place">
/// return location for in-place value
/// </param>

	public static void FontGetSyntheticBold(MentorLake.HarfBuzz.hb_font_tHandle font, out float x_embolden, out float y_embolden, out MentorLake.HarfBuzz.hb_bool_t in_place)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_get_synthetic_bold(font, out x_embolden, out y_embolden, out in_place);
	}

/// <summary>
/// <para>
/// Fetches the &quot;synthetic slant&quot; of a font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// Synthetic slant.  By default is zero.
/// </return>

	public static float FontGetSyntheticSlant(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_synthetic_slant(font);
	}

/// <summary>
/// <para>
/// Fetches the user-data object associated with the specified key,
/// attached to the specified font object.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// Pointer to the user data
/// </return>

	public static IntPtr FontGetUserData(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_user_data(font, key);
	}

/// <summary>
/// <para>
/// Fetches the extents for a specified font, for vertical
/// text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="extents">
/// The font extents retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetVExtents(MentorLake.HarfBuzz.hb_font_tHandle font, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_v_extents(font, out extents);
	}

/// <summary>
/// <para>
/// Fetches the list of variation coordinates (in design-space units) currently
/// set on a font.
/// </para>
/// <para>
/// Note that this returned array may only contain values for some
/// (or none) of the axes; omitted axes effectively have their default
/// values.
/// </para>
/// <para>
/// Return value is valid as long as variation coordinates of the font
/// are not modified.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="length">
/// Number of coordinates retrieved
/// </param>
/// <return>
/// coordinates array
/// </return>

	public static float FontGetVarCoordsDesign(MentorLake.HarfBuzz.hb_font_tHandle font, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_var_coords_design(font, out length);
	}

/// <summary>
/// <para>
/// Fetches the list of normalized variation coordinates currently
/// set on a font.
/// </para>
/// <para>
/// Note that this returned array may only contain values for some
/// (or none) of the axes; omitted axes effectively have zero values.
/// </para>
/// <para>
/// Return value is valid as long as variation coordinates of the font
/// are not modified.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="length">
/// Number of coordinates retrieved
/// </param>
/// <return>
/// coordinates array
/// </return>

	public static int FontGetVarCoordsNormalized(MentorLake.HarfBuzz.hb_font_tHandle font, out uint length)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_var_coords_normalized(font, out length);
	}

/// <summary>
/// <para>
/// Returns the currently-set named-instance index of the font.
/// </para>
/// </summary>

/// <param name="font">
/// a font.
/// </param>
/// <return>
/// Named-instance index or %HB_FONT_NO_VAR_NAMED_INSTANCE.
/// </return>

	public static uint FontGetVarNamedInstance(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_var_named_instance(font);
	}

/// <summary>
/// <para>
/// Fetches the glyph ID for a Unicode code point when followed by
/// by the specified variation-selector code point, in the specified
/// font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="unicode">
/// The Unicode code point to query
/// </param>
/// <param name="variation_selector">
/// The  variation-selector code point to query
/// </param>
/// <param name="glyph">
/// The glyph ID retrieved
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGetVariationGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t unicode, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_get_variation_glyph(font, unicode, variation_selector, out glyph);
	}

/// <summary>
/// <para>
/// Fetches the glyph ID from @font that matches the specified string.
/// Strings of the format `gidDDD` or `uniUUUU` are parsed automatically.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: @len == -1 means the string is null-terminated.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="s">
/// string to query
/// </param>
/// <param name="len">
/// The length of the string @s
/// </param>
/// <param name="glyph">
/// The glyph ID corresponding to the string requested
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontGlyphFromString(MentorLake.HarfBuzz.hb_font_tHandle font, byte[] s, int len, out MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_glyph_from_string(font, s, len, out glyph);
	}

/// <summary>
/// <para>
/// Fetches the name of the specified glyph ID in @font and returns
/// it in string @s.
/// </para>
/// <para>
/// If the glyph ID has no name in @font, a string of the form `gidDDD` is
/// generated, with `DDD` being the glyph ID.
/// </para>
/// <para>
/// According to the OpenType specification, glyph names are limited to 63
/// characters and can only contain (a subset of) ASCII.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="s">
/// The string containing the glyph name
/// </param>
/// <param name="size">
/// Length of string @s
/// </param>

	public static void FontGlyphToString(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, out string[] s, out uint size)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_glyph_to_string(font, glyph, out s, out size);
	}

/// <summary>
/// <para>
/// Tests whether a font object is immutable.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// `true` if @font is immutable, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontIsImmutable(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_is_immutable(font);
	}

/// <summary>
/// <para>
/// Makes @font immutable.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>

	public static void FontMakeImmutable(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_make_immutable(font);
	}

/// <summary>
/// <para>
/// Paints the glyph.
/// </para>
/// <para>
/// The painting instructions are returned by way of calls to
/// the callbacks of the @funcs object, with @paint_data passed
/// to them.
/// </para>
/// <para>
/// If the font has color palettes (see hb_ot_color_has_palettes()),
/// then @palette_index selects the palette to use. If the font only
/// has one palette, this will be 0.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID
/// </param>
/// <param name="pfuncs">
/// #hb_paint_funcs_t to paint with
/// </param>
/// <param name="paint_data">
/// User data to pass to paint callbacks
/// </param>
/// <param name="palette_index">
/// The index of the font&apos;s color palette to use
/// </param>
/// <param name="foreground">
/// The foreground color, unpremultipled
/// </param>

	public static void FontPaintGlyph(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_paint_funcs_tHandle pfuncs, IntPtr paint_data, uint palette_index, MentorLake.HarfBuzz.hb_color_t foreground)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_paint_glyph(font, glyph, pfuncs, paint_data, palette_index, foreground);
	}

/// <summary>
/// <para>
/// Increases the reference count on the given font object.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// The @font object
/// </return>

	public static MentorLake.HarfBuzz.hb_font_tHandle FontReference(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_reference(font);
	}

/// <summary>
/// <para>
/// Sets @face as the font-face value of @font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="face">
/// The #hb_face_t to assign
/// </param>

	public static void FontSetFace(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_face(font, face);
	}

/// <summary>
/// <para>
/// Replaces the font-functions structure attached to a font, updating
/// the font&apos;s user-data with @font-data and the @destroy callback.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="klass">
/// The font-functions structure.
/// </param>
/// <param name="font_data">
/// Data to attach to @font
/// </param>
/// <param name="destroy">
/// The function to call when @font_data is not needed anymore
/// </param>

	public static void FontSetFuncs(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_font_funcs_tHandle klass, IntPtr font_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_funcs(font, klass, font_data, destroy);
	}

/// <summary>
/// <para>
/// Replaces the user data attached to a font, updating the font&apos;s
/// @destroy callback.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="font_data">
/// Data to attach to @font
/// </param>
/// <param name="destroy">
/// The function to call when @font_data is not needed anymore
/// </param>

	public static void FontSetFuncsData(MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_funcs_data(font, font_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the parent font of @font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="parent">
/// The parent font object to assign
/// </param>

	public static void FontSetParent(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_font_tHandle parent)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_parent(font, parent);
	}

/// <summary>
/// <para>
/// Sets the horizontal and vertical pixels-per-em (PPEM) of a font.
/// </para>
/// <para>
/// These values are used for pixel-size-specific adjustment to
/// shaping and draw results, though for the most part they are
/// unused and can be left unset.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="x_ppem">
/// Horizontal ppem value to assign
/// </param>
/// <param name="y_ppem">
/// Vertical ppem value to assign
/// </param>

	public static void FontSetPpem(MentorLake.HarfBuzz.hb_font_tHandle font, uint x_ppem, uint y_ppem)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_ppem(font, x_ppem, y_ppem);
	}

/// <summary>
/// <para>
/// Sets the &quot;point size&quot; of a font. Set to zero to unset.
/// Used in CoreText to implement optical sizing.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: There are 72 points in an inch.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="ptem">
/// font size in points.
/// </param>

	public static void FontSetPtem(MentorLake.HarfBuzz.hb_font_tHandle font, float ptem)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_ptem(font, ptem);
	}

/// <summary>
/// <para>
/// Sets the horizontal and vertical scale of a font.
/// </para>
/// <para>
/// The font scale is a number related to, but not the same as,
/// font size. Typically the client establishes a scale factor
/// to be used between the two. For example, 64, or 256, which
/// would be the fractional-precision part of the font scale.
/// This is necessary because #hb_position_t values are integer
/// types and you need to leave room for fractional values
/// in there.
/// </para>
/// <para>
/// For example, to set the font size to 20, with 64
/// levels of fractional precision you would call
/// `hb_font_set_scale(font, 20 * 64, 20 * 64)`.
/// </para>
/// <para>
/// In the example above, even what font size 20 means is up to
/// you. It might be 20 pixels, or 20 points, or 20 millimeters.
/// HarfBuzz does not care about that.  You can set the point
/// size of the font using hb_font_set_ptem(), and the pixel
/// size using hb_font_set_ppem().
/// </para>
/// <para>
/// The choice of scale is yours but needs to be consistent between
/// what you set here, and what you expect out of #hb_position_t
/// as well has draw / paint API output values.
/// </para>
/// <para>
/// Fonts default to a scale equal to the UPEM value of their face.
/// A font with this setting is sometimes called an &quot;unscaled&quot; font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="x_scale">
/// Horizontal scale value to assign
/// </param>
/// <param name="y_scale">
/// Vertical scale value to assign
/// </param>

	public static void FontSetScale(MentorLake.HarfBuzz.hb_font_tHandle font, int x_scale, int y_scale)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_scale(font, x_scale, y_scale);
	}

/// <summary>
/// <para>
/// Sets the &quot;synthetic boldness&quot; of a font.
/// </para>
/// <para>
/// Positive values for @x_embolden / @y_embolden make a font
/// bolder, negative values thinner. Typical values are in the
/// 0.01 to 0.05 range. The default value is zero.
/// </para>
/// <para>
/// Synthetic boldness is applied by offsetting the contour
/// points of the glyph shape.
/// </para>
/// <para>
/// Synthetic boldness is applied when rendering a glyph via
/// hb_font_draw_glyph().
/// </para>
/// <para>
/// If @in_place is `false`, then glyph advance-widths are also
/// adjusted, otherwise they are not.  The in-place mode is
/// useful for simulating [font grading](https://fonts.google.com/knowledge/glossary/grade).
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="x_embolden">
/// the amount to embolden horizontally
/// </param>
/// <param name="y_embolden">
/// the amount to embolden vertically
/// </param>
/// <param name="in_place">
/// whether to embolden glyphs in-place
/// </param>

	public static void FontSetSyntheticBold(MentorLake.HarfBuzz.hb_font_tHandle font, float x_embolden, float y_embolden, MentorLake.HarfBuzz.hb_bool_t in_place)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_synthetic_bold(font, x_embolden, y_embolden, in_place);
	}

/// <summary>
/// <para>
/// Sets the &quot;synthetic slant&quot; of a font.  By default is zero.
/// Synthetic slant is the graphical skew applied to the font
/// at rendering time.
/// </para>
/// <para>
/// HarfBuzz needs to know this value to adjust shaping results,
/// metrics, and style values to match the slanted rendering.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: The glyph shape fetched via the hb_font_draw_glyph()
/// function is slanted to reflect this value as well.&amp;lt;/note&amp;gt;
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: The slant value is a ratio.  For example, a
/// 20% slant would be represented as a 0.2 value.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="slant">
/// synthetic slant value.
/// </param>

	public static void FontSetSyntheticSlant(MentorLake.HarfBuzz.hb_font_tHandle font, float slant)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_synthetic_slant(font, slant);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified font object.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="key">
/// The user-data key
/// </param>
/// <param name="data">
/// A pointer to the user data
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FontSetUserData(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_font_set_user_data(font, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Applies a list of variation coordinates (in design-space units)
/// to a font.
/// </para>
/// <para>
/// Note that this overrides all existing variations set on @font.
/// Axes not included in @coords will be effectively set to their
/// default values.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="coords">
/// Array of variation coordinates to apply
/// </param>
/// <param name="coords_length">
/// Number of coordinates to apply
/// </param>

	public static void FontSetVarCoordsDesign(MentorLake.HarfBuzz.hb_font_tHandle font, float[] coords, uint coords_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_var_coords_design(font, coords, coords_length);
	}

/// <summary>
/// <para>
/// Applies a list of variation coordinates (in normalized units)
/// to a font.
/// </para>
/// <para>
/// Note that this overrides all existing variations set on @font.
/// Axes not included in @coords will be effectively set to their
/// default values.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: Coordinates should be normalized to 2.14.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="coords">
/// Array of variation coordinates to apply
/// </param>
/// <param name="coords_length">
/// Number of coordinates to apply
/// </param>

	public static void FontSetVarCoordsNormalized(MentorLake.HarfBuzz.hb_font_tHandle font, int[] coords, uint coords_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_var_coords_normalized(font, coords, coords_length);
	}

/// <summary>
/// <para>
/// Sets design coords of a font from a named-instance index.
/// </para>
/// </summary>

/// <param name="font">
/// a font.
/// </param>
/// <param name="instance_index">
/// named instance index.
/// </param>

	public static void FontSetVarNamedInstance(MentorLake.HarfBuzz.hb_font_tHandle font, uint instance_index)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_var_named_instance(font, instance_index);
	}

/// <summary>
/// <para>
/// Change the value of one variation axis on the font.
/// </para>
/// <para>
/// Note: This function is expensive to be called repeatedly.
///   If you want to set multiple variation axes at the same time,
///   use hb_font_set_variations() instead.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="tag">
/// The #hb_tag_t tag of the variation-axis name
/// </param>
/// <param name="value">
/// The value of the variation axis
/// </param>

	public static void FontSetVariation(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_tag_t tag, float value)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_variation(font, tag, value);
	}

/// <summary>
/// <para>
/// Applies a list of font-variation settings to a font.
/// </para>
/// <para>
/// Note that this overrides all existing variations set on @font.
/// Axes not included in @variations will be effectively set to their
/// default values.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="variations">
/// Array of variation settings to apply
/// </param>
/// <param name="variations_length">
/// Number of variations to apply
/// </param>

	public static void FontSetVariations(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_variation_t[] variations, uint variations_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_set_variations(font, variations, variations_length);
	}

/// <summary>
/// <para>
/// Subtracts the origin coordinates from an (X,Y) point coordinate,
/// in the specified glyph ID in the specified font.
/// </para>
/// <para>
/// Calls the appropriate direction-specific variant (horizontal
/// or vertical) depending on the value of @direction.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="direction">
/// The direction of the text segment
/// </param>
/// <param name="x">
/// Input = The original X coordinate
///     Output = The X coordinate minus the X-coordinate of the origin
/// </param>
/// <param name="y">
/// Input = The original Y coordinate
///     Output = The Y coordinate minus the Y-coordinate of the origin
/// </param>

	public static void FontSubtractGlyphOriginForDirection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, ref MentorLake.HarfBuzz.hb_position_t x, ref MentorLake.HarfBuzz.hb_position_t y)
	{
		HarfBuzzGlobalFunctionsExterns.hb_font_subtract_glyph_origin_for_direction(font, glyph, direction, ref x, ref y);
	}

/// <summary>
/// <para>
/// Refreshes the state of @font when the underlying FT_Face has changed.
/// This function should be called after changing the size or
/// variation-axis settings on the FT_Face.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>

	public static void FtFontChanged(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ft_font_changed(font);
	}

/// <summary>
/// <para>
/// Fetches the FT_Load_Glyph load flags of the specified #hb_font_t.
/// </para>
/// <para>
/// For more information, see
/// &amp;lt;https://freetype.org/freetype2/docs/reference/ft2-glyph_retrieval.html#ft_load_xxx&amp;gt;
/// </para>
/// <para>
/// This function works with #hb_font_t objects created by
/// hb_ft_font_create() or hb_ft_font_create_referenced().
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// FT_Load_Glyph flags found, or 0
/// </return>

	public static int FtFontGetLoadFlags(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ft_font_get_load_flags(font);
	}

/// <summary>
/// <para>
/// Configures the font-functions structure of the specified
/// #hb_font_t font object to use FreeType font functions.
/// </para>
/// <para>
/// In particular, you can use this function to configure an
/// existing #hb_face_t face object for use with FreeType font
/// functions even if that #hb_face_t face object was initially
/// created with hb_face_create(), and therefore was not
/// initially configured to use FreeType font functions.
/// </para>
/// <para>
/// An #hb_font_t object created with hb_ft_font_create()
/// is preconfigured for FreeType font functions and does not
/// require this function to be used.
/// </para>
/// <para>
/// Note that if you modify the underlying #hb_font_t after
/// calling this function, you need to call hb_ft_hb_font_changed()
/// to update the underlying FT_Face.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: Internally, this function creates an FT_Face.
/// &amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>

	public static void FtFontSetFuncs(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ft_font_set_funcs(font);
	}

/// <summary>
/// <para>
/// Sets the FT_Load_Glyph load flags for the specified #hb_font_t.
/// </para>
/// <para>
/// For more information, see
/// &amp;lt;https://freetype.org/freetype2/docs/reference/ft2-glyph_retrieval.html#ft_load_xxx&amp;gt;
/// </para>
/// <para>
/// This function works with #hb_font_t objects created by
/// hb_ft_font_create() or hb_ft_font_create_referenced().
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="load_flags">
/// The FreeType load flags to set
/// </param>

	public static void FtFontSetLoadFlags(MentorLake.HarfBuzz.hb_font_tHandle font, int load_flags)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ft_font_set_load_flags(font, load_flags);
	}

/// <summary>
/// <para>
/// Releases an FT_Face previously obtained with hb_ft_font_lock_face().
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>

	public static void FtFontUnlockFace(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ft_font_unlock_face(font);
	}

/// <summary>
/// <para>
/// Refreshes the state of the underlying FT_Face of @font when the hb_font_t
/// @font has changed.
/// This function should be called after changing the size or
/// variation-axis settings on the @font.
/// This call is fast if nothing has changed on @font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <return>
/// true if changed, false otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t FtHbFontChanged(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ft_hb_font_changed(font);
	}

/// <summary>
/// <para>
/// Creates an #hb_blob_t blob from the specified
/// GBytes data structure.
/// </para>
/// </summary>

/// <param name="gbytes">
/// the GBytes structure to work upon
/// </param>
/// <return>
/// the new #hb_blob_t blob object
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle GlibBlobCreate(MentorLake.GLib.GBytesHandle gbytes)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glib_blob_create(gbytes);
	}

/// <summary>
/// <para>
/// Fetches a Unicode-functions structure that is populated
/// with the appropriate GLib function for each method.
/// </para>
/// </summary>

/// <return>
/// a pointer to the #hb_unicode_funcs_t Unicode-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle GlibGetUnicodeFuncs()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glib_get_unicode_funcs();
	}

/// <summary>
/// <para>
/// Fetches the GUnicodeScript identifier that corresponds to the
/// specified #hb_script_t script.
/// </para>
/// </summary>

/// <param name="script">
/// The #hb_script_t to query
/// </param>
/// <return>
/// the GUnicodeScript identifier found
/// </return>

	public static MentorLake.GLib.GUnicodeScript GlibScriptFromScript(MentorLake.HarfBuzz.hb_script_t script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glib_script_from_script(script);
	}

/// <summary>
/// <para>
/// Fetches the #hb_script_t script that corresponds to the
/// specified GUnicodeScript identifier.
/// </para>
/// </summary>

/// <param name="script">
/// The GUnicodeScript identifier to query
/// </param>
/// <return>
/// the #hb_script_t script found
/// </return>

	public static MentorLake.HarfBuzz.hb_script_t GlibScriptToScript(MentorLake.GLib.GUnicodeScript script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glib_script_to_script(script);
	}

/// <summary>
/// <para>
/// Returns glyph flags encoded within a #hb_glyph_info_t.
/// </para>
/// </summary>

/// <param name="info">
/// a #hb_glyph_info_t
/// </param>
/// <return>
/// The #hb_glyph_flags_t encoded within @info
/// </return>

	public static MentorLake.HarfBuzz.hb_glyph_flags_t GlyphInfoGetGlyphFlags(MentorLake.HarfBuzz.hb_glyph_info_tHandle info)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_glyph_info_get_glyph_flags(info);
	}

/// <summary>
/// <para>
/// Converts @str representing a BCP 47 language tag to the corresponding
/// #hb_language_t.
/// </para>
/// </summary>

/// <param name="str">
/// a string representing
///       a BCP 47 language tag
/// </param>
/// <param name="len">
/// length of the @str, or -1 if it is `NULL`-terminated.
/// </param>
/// <return>
/// 
/// The #hb_language_t corresponding to the BCP 47 language tag.
/// </return>

	public static MentorLake.HarfBuzz.hb_language_t LanguageFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_language_from_string(str, len);
	}

/// <summary>
/// <para>
/// Fetch the default language from current locale.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note that the first time this function is called, it calls
/// &quot;setlocale (LC_CTYPE, nullptr)&quot; to fetch current locale.  The underlying
/// setlocale function is, in many implementations, NOT threadsafe.  To avoid
/// problems, call this function once before multiple threads can call it.
/// This function is only used from hb_buffer_guess_segment_properties() by
/// HarfBuzz itself.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <return>
/// The default language of the locale as
/// an #hb_language_t
/// </return>

	public static MentorLake.HarfBuzz.hb_language_t LanguageGetDefault()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_language_get_default();
	}

/// <summary>
/// <para>
/// Check whether a second language tag is the same or a more
/// specific version of the provided language tag.  For example,
/// &quot;fa_IR.utf8&quot; is a more specific tag for &quot;fa&quot; or for &quot;fa_IR&quot;.
/// </para>
/// </summary>

/// <param name="language">
/// The #hb_language_t to work on
/// </param>
/// <param name="specific">
/// Another #hb_language_t
/// </param>
/// <return>
/// `true` if languages match, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t LanguageMatches(MentorLake.HarfBuzz.hb_language_t language, MentorLake.HarfBuzz.hb_language_t specific)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_language_matches(language, specific);
	}

/// <summary>
/// <para>
/// Converts an #hb_language_t to a string.
/// </para>
/// </summary>

/// <param name="language">
/// The #hb_language_t to convert
/// </param>
/// <return>
/// 
/// A `NULL`-terminated string representing the @language. Must not be freed by
/// the caller.
/// </return>

	public static string LanguageToString(MentorLake.HarfBuzz.hb_language_t language)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_language_to_string(language);
	}

/// <summary>
/// <para>
/// Tests whether memory allocation for a set was successful.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <return>
/// `true` if allocation succeeded, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t MapAllocationSuccessful(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_allocation_successful(map);
	}

/// <summary>
/// <para>
/// Clears out the contents of @map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>

	public static void MapClear(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_clear(map);
	}

/// <summary>
/// <para>
/// Allocate a copy of @map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <return>
/// Newly-allocated map.
/// </return>

	public static MentorLake.HarfBuzz.hb_map_tHandle MapCopy(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_copy(map);
	}

/// <summary>
/// <para>
/// Creates a new, initially empty map.
/// </para>
/// </summary>

/// <return>
/// The new #hb_map_t
/// </return>

	public static MentorLake.HarfBuzz.hb_map_tHandle MapCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_create();
	}

/// <summary>
/// <para>
/// Removes @key and its stored value from @map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="key">
/// The key to delete
/// </param>

	public static void MapDel(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_del(map, key);
	}

/// <summary>
/// <para>
/// Decreases the reference count on a map. When
/// the reference count reaches zero, the map is
/// destroyed, freeing all memory.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>

	public static void MapDestroy(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_destroy(map);
	}

/// <summary>
/// <para>
/// Fetches the value stored for @key in @map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="key">
/// The key to query
/// </param>

	public static MentorLake.HarfBuzz.hb_codepoint_t MapGet(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_get(map, key);
	}

/// <summary>
/// <para>
/// Fetches the singleton empty #hb_map_t.
/// </para>
/// </summary>

/// <return>
/// The empty #hb_map_t
/// </return>

	public static MentorLake.HarfBuzz.hb_map_tHandle MapGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_get_empty();
	}

/// <summary>
/// <para>
/// Returns the number of key-value pairs in the map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <return>
/// The population of @map
/// </return>

	public static uint MapGetPopulation(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_get_population(map);
	}

/// <summary>
/// <para>
/// Fetches the user data associated with the specified key,
/// attached to the specified map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr MapGetUserData(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_get_user_data(map, key);
	}

/// <summary>
/// <para>
/// Tests whether @key is an element of @map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="key">
/// The key to query
/// </param>
/// <return>
/// `true` if @key is found in @map, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t MapHas(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_has(map, key);
	}

/// <summary>
/// <para>
/// Creates a hash representing @map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <return>
/// A hash of @map.
/// </return>

	public static uint MapHash(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_hash(map);
	}

/// <summary>
/// <para>
/// Tests whether @map is empty (contains no elements).
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <return>
/// `true` if @map is empty
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t MapIsEmpty(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_is_empty(map);
	}

/// <summary>
/// <para>
/// Tests whether @map and @other are equal (contain the same
/// elements).
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="other">
/// Another map
/// </param>
/// <return>
/// `true` if the two maps are equal, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t MapIsEqual(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_map_tHandle other)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_is_equal(map, other);
	}

/// <summary>
/// <para>
/// Add the keys of @map to @keys.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="keys">
/// A set
/// </param>

	public static void MapKeys(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_set_tHandle keys)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_keys(map, keys);
	}

/// <summary>
/// <para>
/// Fetches the next key/value pair in @map.
/// </para>
/// <para>
/// Set @idx to -1 to get started.
/// </para>
/// <para>
/// If the map is modified during iteration, the behavior is undefined.
/// </para>
/// <para>
/// The order in which the key/values are returned is undefined.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="idx">
/// Iterator internal state
/// </param>
/// <param name="key">
/// Key retrieved
/// </param>
/// <param name="value">
/// Value retrieved
/// </param>
/// <return>
/// `true` if there was a next value, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t MapNext(MentorLake.HarfBuzz.hb_map_tHandle map, ref int idx, out MentorLake.HarfBuzz.hb_codepoint_t key, out MentorLake.HarfBuzz.hb_codepoint_t value)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_next(map, ref idx, out key, out value);
	}

/// <summary>
/// <para>
/// Increases the reference count on a map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <return>
/// The map
/// </return>

	public static MentorLake.HarfBuzz.hb_map_tHandle MapReference(MentorLake.HarfBuzz.hb_map_tHandle map)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_reference(map);
	}

/// <summary>
/// <para>
/// Stores @key:@value in the map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="key">
/// The key to store in the map
/// </param>
/// <param name="value">
/// The value to store for @key
/// </param>

	public static void MapSet(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key, MentorLake.HarfBuzz.hb_codepoint_t value)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_set(map, key, value);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="key">
/// The user-data key to set
/// </param>
/// <param name="data">
/// A pointer to the user data to set
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t MapSetUserData(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_map_set_user_data(map, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Add the contents of @other to @map.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="other">
/// Another map
/// </param>

	public static void MapUpdate(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_map_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_update(map, other);
	}

/// <summary>
/// <para>
/// Add the values of @map to @values.
/// </para>
/// </summary>

/// <param name="map">
/// A map
/// </param>
/// <param name="values">
/// A set
/// </param>

	public static void MapValues(MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_set_tHandle values)
	{
		HarfBuzzGlobalFunctionsExterns.hb_map_values(map, values);
	}

/// <summary>
/// <para>
/// Fetches a list of all color layers for the specified glyph index in the specified
/// face. The list returned will begin at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph index to query
/// </param>
/// <param name="start_offset">
/// offset of the first layer to retrieve
/// </param>
/// <param name="layer_count">
/// Input = the maximum number of layers to return;
///         Output = the actual number of layers returned (may be zero)
/// </param>
/// <param name="layers">
/// The array of layers found
/// </param>
/// <return>
/// Total number of layers available for the glyph index queried
/// </return>

	public static uint OtColorGlyphGetLayers(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint layer_count, out MentorLake.HarfBuzz.hb_ot_color_layer_t[] layers)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_glyph_get_layers(face, glyph, start_offset, out layer_count, out layers);
	}

/// <summary>
/// <para>
/// Tests where a face includes COLRv1 paint
/// data for @glyph.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph index to query
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtColorGlyphHasPaint(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_glyph_has_paint(face, glyph);
	}

/// <summary>
/// <para>
/// Fetches the PNG image for a glyph. This function takes a font object, not a face object,
/// as input. To get an optimally sized PNG blob, the PPEM values must be set on the @font
/// object. If PPEM is unset, the blob returned will be the largest PNG available.
/// </para>
/// <para>
/// If the glyph has no PNG image, the singleton empty blob is returned.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// a glyph index
/// </param>
/// <return>
/// An #hb_blob_t containing the PNG image for the glyph, if available
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle OtColorGlyphReferencePng(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_glyph_reference_png(font, glyph);
	}

/// <summary>
/// <para>
/// Fetches the SVG document for a glyph. The blob may be either plain text or gzip-encoded.
/// </para>
/// <para>
/// If the glyph has no SVG document, the singleton empty blob is returned.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="glyph">
/// a svg glyph index
/// </param>
/// <return>
/// An #hb_blob_t containing the SVG document of the glyph, if available
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle OtColorGlyphReferenceSvg(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_glyph_reference_svg(face, glyph);
	}

/// <summary>
/// <para>
/// Tests whether a face includes a `COLR` table
/// with data according to COLRv0.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasLayers(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_layers(face);
	}

/// <summary>
/// <para>
/// Tests where a face includes a `COLR` table
/// with data according to COLRv1.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasPaint(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_paint(face);
	}

/// <summary>
/// <para>
/// Tests whether a face includes a `CPAL` color-palette table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasPalettes(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_palettes(face);
	}

/// <summary>
/// <para>
/// Tests whether a face has PNG glyph images (either in `CBDT` or `sbix` tables).
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasPng(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_png(face);
	}

/// <summary>
/// <para>
/// Tests whether a face includes any `SVG` glyph images.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon.
/// </param>
/// <return>
/// `true` if data found, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtColorHasSvg(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_has_svg(face);
	}

/// <summary>
/// <para>
/// Fetches the `name` table Name ID that provides display names for
/// the specified color in a face&apos;s `CPAL` color palette.
/// </para>
/// <para>
/// Display names can be generic (e.g., &quot;Background&quot;) or specific
/// (e.g., &quot;Eye color&quot;).
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="color_index">
/// The index of the color
/// </param>
/// <return>
/// the Name ID found for the color.
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_name_id_t OtColorPaletteColorGetNameId(MentorLake.HarfBuzz.hb_face_tHandle face, uint color_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_color_get_name_id(face, color_index);
	}

/// <summary>
/// <para>
/// Fetches a list of the colors in a color palette.
/// </para>
/// <para>
/// After calling this function, @colors will be filled with the palette
/// colors. If @colors is NULL, the function will just return the number
/// of total colors without storing any actual colors; this can be used
/// for allocating a buffer of suitable size before calling
/// hb_ot_color_palette_get_colors() a second time.
/// </para>
/// <para>
/// The RGBA values in the palette are unpremultiplied. See the
/// OpenType spec [CPAL](https://learn.microsoft.com/en-us/typography/opentype/spec/cpal)
/// section for details.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="palette_index">
/// the index of the color palette to query
/// </param>
/// <param name="start_offset">
/// offset of the first color to retrieve
/// </param>
/// <param name="color_count">
/// Input = the maximum number of colors to return;
///               Output = the actual number of colors returned (may be zero)
/// </param>
/// <param name="colors">
/// The array of #hb_color_t records found
/// </param>
/// <return>
/// the total number of colors in the palette
/// </return>

	public static uint OtColorPaletteGetColors(MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index, uint start_offset, out uint color_count, out MentorLake.HarfBuzz.hb_color_t[] colors)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_get_colors(face, palette_index, start_offset, out color_count, out colors);
	}

/// <summary>
/// <para>
/// Fetches the number of color palettes in a face.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// the number of palettes found
/// </return>

	public static uint OtColorPaletteGetCount(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_get_count(face);
	}

/// <summary>
/// <para>
/// Fetches the flags defined for a color palette.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="palette_index">
/// The index of the color palette
/// </param>
/// <return>
/// the #hb_ot_color_palette_flags_t of the requested color palette
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_color_palette_flags_t OtColorPaletteGetFlags(MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_get_flags(face, palette_index);
	}

/// <summary>
/// <para>
/// Fetches the `name` table Name ID that provides display names for
/// a `CPAL` color palette.
/// </para>
/// <para>
/// Palette display names can be generic (e.g., &quot;Default&quot;) or provide
/// specific, themed names (e.g., &quot;Spring&quot;, &quot;Summer&quot;, &quot;Fall&quot;, and &quot;Winter&quot;).
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="palette_index">
/// The index of the color palette
/// </param>
/// <return>
/// the Named ID found for the palette.
/// If the requested palette has no name the result is #HB_OT_NAME_ID_INVALID.
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_name_id_t OtColorPaletteGetNameId(MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_color_palette_get_name_id(face, palette_index);
	}

/// <summary>
/// <para>
/// Sets the font functions to use when working with @font.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>

	public static void OtFontSetFuncs(MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_font_set_funcs(font);
	}

/// <summary>
/// <para>
/// Fetches a list of all feature indexes in the specified face&apos;s GSUB table
/// or GPOS table, underneath the specified scripts, languages, and features.
/// If no list of scripts is provided, all scripts will be queried. If no list
/// of languages is provided, all languages will be queried. If no list of
/// features is provided, all features will be queried.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="scripts">
/// The array of scripts to collect features for,
///   terminated by %HB_TAG_NONE
/// </param>
/// <param name="languages">
/// The array of languages to collect features for,
///   terminated by %HB_TAG_NONE
/// </param>
/// <param name="features">
/// The array of features to collect,
///   terminated by %HB_TAG_NONE
/// </param>
/// <param name="feature_indexes">
/// The set of feature indexes found for the query
/// </param>

	public static void OtLayoutCollectFeatures(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t[] scripts, MentorLake.HarfBuzz.hb_tag_t[] languages, MentorLake.HarfBuzz.hb_tag_t[] features, out MentorLake.HarfBuzz.hb_set_t feature_indexes)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_collect_features(face, table_tag, scripts, languages, features, out feature_indexes);
	}

/// <summary>
/// <para>
/// Fetches the mapping from feature tags to feature indexes for
/// the specified script and language.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_index">
/// The index of the requested language tag
/// </param>
/// <param name="feature_map">
/// The map of feature tag to feature index.
/// </param>

	public static void OtLayoutCollectFeaturesMap(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out MentorLake.HarfBuzz.hb_map_t feature_map)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_collect_features_map(face, table_tag, script_index, language_index, out feature_map);
	}

/// <summary>
/// <para>
/// Fetches a list of all feature-lookup indexes in the specified face&apos;s GSUB
/// table or GPOS table, underneath the specified scripts, languages, and
/// features. If no list of scripts is provided, all scripts will be queried.
/// If no list of languages is provided, all languages will be queried. If no
/// list of features is provided, all features will be queried.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="scripts">
/// The array of scripts to collect lookups for,
///   terminated by %HB_TAG_NONE
/// </param>
/// <param name="languages">
/// The array of languages to collect lookups for,
///   terminated by %HB_TAG_NONE
/// </param>
/// <param name="features">
/// The array of features to collect lookups for,
///   terminated by %HB_TAG_NONE
/// </param>
/// <param name="lookup_indexes">
/// The array of lookup indexes found for the query
/// </param>

	public static void OtLayoutCollectLookups(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t[] scripts, MentorLake.HarfBuzz.hb_tag_t[] languages, MentorLake.HarfBuzz.hb_tag_t[] features, out MentorLake.HarfBuzz.hb_set_t lookup_indexes)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_collect_lookups(face, table_tag, scripts, languages, features, out lookup_indexes);
	}

/// <summary>
/// <para>
/// Fetches a list of the characters defined as having a variant under the specified
/// &quot;Character Variant&quot; (&quot;cvXX&quot;) feature tag.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// table tag to query, &quot;GSUB&quot; or &quot;GPOS&quot;.
/// </param>
/// <param name="feature_index">
/// index of feature to query.
/// </param>
/// <param name="start_offset">
/// offset of the first character to retrieve
/// </param>
/// <param name="char_count">
/// Input = the maximum number of characters to return;
///              Output = the actual number of characters returned (may be zero)
/// </param>
/// <param name="characters">
/// A buffer pointer.
///              The Unicode codepoints of the characters for which this feature provides
///               glyph variants.
/// </param>
/// <return>
/// Number of total sample characters in the cvXX feature.
/// </return>

	public static uint OtLayoutFeatureGetCharacters(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint start_offset, out uint char_count, out MentorLake.HarfBuzz.hb_codepoint_t[] characters)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_feature_get_characters(face, table_tag, feature_index, start_offset, out char_count, out characters);
	}

/// <summary>
/// <para>
/// Fetches a list of all lookups enumerated for the specified feature, in
/// the specified face&apos;s GSUB table or GPOS table. The list returned will
/// begin at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="feature_index">
/// The index of the requested feature
/// </param>
/// <param name="start_offset">
/// offset of the first lookup to retrieve
/// </param>
/// <param name="lookup_count">
/// Input = the maximum number of lookups to return;
///                Output = the actual number of lookups returned (may be zero)
/// </param>
/// <param name="lookup_indexes">
/// The array of lookup indexes found for the query
/// </param>
/// <return>
/// Total number of lookups.
/// </return>

	public static uint OtLayoutFeatureGetLookups(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint start_offset, out uint lookup_count, out uint[] lookup_indexes)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_feature_get_lookups(face, table_tag, feature_index, start_offset, out lookup_count, out lookup_indexes);
	}

/// <summary>
/// <para>
/// Fetches name indices from feature parameters for &quot;Stylistic Set&quot; (&apos;ssXX&apos;) or
/// &quot;Character Variant&quot; (&apos;cvXX&apos;) features.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// table tag to query, &quot;GSUB&quot; or &quot;GPOS&quot;.
/// </param>
/// <param name="feature_index">
/// index of feature to query.
/// </param>
/// <param name="label_id">
/// The ‘name’ table name ID that specifies a string
///            for a user-interface label for this feature. (May be NULL.)
/// </param>
/// <param name="tooltip_id">
/// The ‘name’ table name ID that specifies a string
///              that an application can use for tooltip text for this
///              feature. (May be NULL.)
/// </param>
/// <param name="sample_id">
/// The ‘name’ table name ID that specifies sample text
///             that illustrates the effect of this feature. (May be NULL.)
/// </param>
/// <param name="num_named_parameters">
/// Number of named parameters. (May be zero.)
/// </param>
/// <param name="first_param_id">
/// The first ‘name’ table name ID used to specify
///                  strings for user-interface labels for the feature
///                  parameters. (Must be zero if numParameters is zero.)
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutFeatureGetNameIds(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, out MentorLake.HarfBuzz.hb_ot_name_id_t label_id, out MentorLake.HarfBuzz.hb_ot_name_id_t tooltip_id, out MentorLake.HarfBuzz.hb_ot_name_id_t sample_id, out uint num_named_parameters, out MentorLake.HarfBuzz.hb_ot_name_id_t first_param_id)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_feature_get_name_ids(face, table_tag, feature_index, out label_id, out tooltip_id, out sample_id, out num_named_parameters, out first_param_id);
	}

/// <summary>
/// <para>
/// Fetches a list of all lookups enumerated for the specified feature, in
/// the specified face&apos;s GSUB table or GPOS table, enabled at the specified
/// variations index. The list returned will begin at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="feature_index">
/// The index of the feature to query
/// </param>
/// <param name="variations_index">
/// The index of the feature variation to query
/// </param>
/// <param name="start_offset">
/// offset of the first lookup to retrieve
/// </param>
/// <param name="lookup_count">
/// Input = the maximum number of lookups to return;
///                Output = the actual number of lookups returned (may be zero)
/// </param>
/// <param name="lookup_indexes">
/// The array of lookups found for the query
/// </param>
/// <return>
/// Total number of lookups.
/// </return>

	public static uint OtLayoutFeatureWithVariationsGetLookups(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint variations_index, uint start_offset, out uint lookup_count, out uint[] lookup_indexes)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_feature_with_variations_get_lookups(face, table_tag, feature_index, variations_index, start_offset, out lookup_count, out lookup_indexes);
	}

/// <summary>
/// <para>
/// Fetches a list of all attachment points for the specified glyph in the GDEF
/// table of the face. The list returned will begin at the offset provided.
/// </para>
/// <para>
/// Useful if the client program wishes to cache the list.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <param name="glyph">
/// The #hb_codepoint_t code point to query
/// </param>
/// <param name="start_offset">
/// offset of the first attachment point to retrieve
/// </param>
/// <param name="point_count">
/// Input = the maximum number of attachment points to return;
///               Output = the actual number of attachment points returned (may be zero)
/// </param>
/// <param name="point_array">
/// The array of attachment points found for the query
/// </param>
/// <return>
/// Total number of attachment points for @glyph.
/// </return>

	public static uint OtLayoutGetAttachPoints(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint point_count, out uint[] point_array)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_attach_points(face, glyph, start_offset, out point_count, out point_array);
	}

/// <summary>
/// <para>
/// Fetches a baseline value from the face.
/// </para>
/// </summary>

/// <param name="font">
/// a font
/// </param>
/// <param name="baseline_tag">
/// a baseline tag
/// </param>
/// <param name="direction">
/// text direction.
/// </param>
/// <param name="script_tag">
/// script tag.
/// </param>
/// <param name="language_tag">
/// language tag, currently unused.
/// </param>
/// <param name="coord">
/// baseline value if found.
/// </param>
/// <return>
/// `true` if found baseline value in the font.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetBaseline(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_position_t coord)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_baseline(font, baseline_tag, direction, script_tag, language_tag, out coord);
	}

/// <summary>
/// <para>
/// Fetches a baseline value from the face.
/// </para>
/// <para>
/// This function is like hb_ot_layout_get_baseline() but takes
/// #hb_script_t and #hb_language_t instead of OpenType #hb_tag_t.
/// </para>
/// </summary>

/// <param name="font">
/// a font
/// </param>
/// <param name="baseline_tag">
/// a baseline tag
/// </param>
/// <param name="direction">
/// text direction.
/// </param>
/// <param name="script">
/// script.
/// </param>
/// <param name="language">
/// language, currently unused.
/// </param>
/// <param name="coord">
/// baseline value if found.
/// </param>
/// <return>
/// `true` if found baseline value in the font.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetBaseline2(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_position_t coord)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_baseline2(font, baseline_tag, direction, script, language, out coord);
	}

/// <summary>
/// <para>
/// Fetches a baseline value from the face, and synthesizes
/// it if the font does not have it.
/// </para>
/// </summary>

/// <param name="font">
/// a font
/// </param>
/// <param name="baseline_tag">
/// a baseline tag
/// </param>
/// <param name="direction">
/// text direction.
/// </param>
/// <param name="script_tag">
/// script tag.
/// </param>
/// <param name="language_tag">
/// language tag, currently unused.
/// </param>
/// <param name="coord">
/// baseline value if found.
/// </param>

	public static void OtLayoutGetBaselineWithFallback(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_position_t coord)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_baseline_with_fallback(font, baseline_tag, direction, script_tag, language_tag, out coord);
	}

/// <summary>
/// <para>
/// Fetches a baseline value from the face, and synthesizes
/// it if the font does not have it.
/// </para>
/// <para>
/// This function is like hb_ot_layout_get_baseline_with_fallback() but takes
/// #hb_script_t and #hb_language_t instead of OpenType #hb_tag_t.
/// </para>
/// </summary>

/// <param name="font">
/// a font
/// </param>
/// <param name="baseline_tag">
/// a baseline tag
/// </param>
/// <param name="direction">
/// text direction.
/// </param>
/// <param name="script">
/// script.
/// </param>
/// <param name="language">
/// language, currently unused.
/// </param>
/// <param name="coord">
/// baseline value if found.
/// </param>

	public static void OtLayoutGetBaselineWithFallback2(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t baseline_tag, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_position_t coord)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_baseline_with_fallback2(font, baseline_tag, direction, script, language, out coord);
	}

/// <summary>
/// <para>
/// Fetches script/language-specific font extents.  These values are
/// looked up in the `BASE` table&apos;s `MinMax` records.
/// </para>
/// <para>
/// If no such extents are found, the default extents for the font are
/// fetched. As such, the return value of this function can for the
/// most part be ignored.  Note that the per-script/language extents
/// do not have a line-gap value, and the line-gap is set to zero in
/// that case.
/// </para>
/// </summary>

/// <param name="font">
/// a font
/// </param>
/// <param name="direction">
/// text direction.
/// </param>
/// <param name="script_tag">
/// script tag.
/// </param>
/// <param name="language_tag">
/// language tag.
/// </param>
/// <param name="extents">
/// font extents if found.
/// </param>
/// <return>
/// `true` if found script/language-specific font extents.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetFontExtents(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_font_extents(font, direction, script_tag, language_tag, out extents);
	}

/// <summary>
/// <para>
/// Fetches script/language-specific font extents.  These values are
/// looked up in the `BASE` table&apos;s `MinMax` records.
/// </para>
/// <para>
/// If no such extents are found, the default extents for the font are
/// fetched. As such, the return value of this function can for the
/// most part be ignored.  Note that the per-script/language extents
/// do not have a line-gap value, and the line-gap is set to zero in
/// that case.
/// </para>
/// <para>
/// This function is like hb_ot_layout_get_font_extents() but takes
/// #hb_script_t and #hb_language_t instead of OpenType #hb_tag_t.
/// </para>
/// </summary>

/// <param name="font">
/// a font
/// </param>
/// <param name="direction">
/// text direction.
/// </param>
/// <param name="script">
/// script.
/// </param>
/// <param name="language">
/// language.
/// </param>
/// <param name="extents">
/// font extents if found.
/// </param>
/// <return>
/// `true` if found script/language-specific font extents.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetFontExtents2(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, out MentorLake.HarfBuzz.hb_font_extents_t extents)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_font_extents2(font, direction, script, language, out extents);
	}

/// <summary>
/// <para>
/// Fetches the GDEF class of the requested glyph in the specified face.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <param name="glyph">
/// The #hb_codepoint_t code point to query
/// </param>
/// <return>
/// The #hb_ot_layout_glyph_class_t glyph class of the given code
/// point in the GDEF table of the face.
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_layout_glyph_class_t OtLayoutGetGlyphClass(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_glyph_class(face, glyph);
	}

/// <summary>
/// <para>
/// Retrieves the set of all glyphs from the face that belong to the requested
/// glyph class in the face&apos;s GDEF table.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <param name="klass">
/// The #hb_ot_layout_glyph_class_t GDEF class to retrieve
/// </param>
/// <param name="glyphs">
/// The #hb_set_t set of all glyphs belonging to the requested
///          class.
/// </param>

	public static void OtLayoutGetGlyphsInClass(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_layout_glyph_class_t klass, out MentorLake.HarfBuzz.hb_set_t glyphs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_glyphs_in_class(face, klass, out glyphs);
	}

/// <summary>
/// <para>
/// Fetches the dominant horizontal baseline tag used by @script.
/// </para>
/// </summary>

/// <param name="script">
/// a script tag.
/// </param>
/// <return>
/// dominant baseline tag for the @script.
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_layout_baseline_tag_t OtLayoutGetHorizontalBaselineTagForScript(MentorLake.HarfBuzz.hb_script_t script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_horizontal_baseline_tag_for_script(script);
	}

/// <summary>
/// <para>
/// Fetches a list of the caret positions defined for a ligature glyph in the GDEF
/// table of the font. The list returned will begin at the offset provided.
/// </para>
/// <para>
/// Note that a ligature that is formed from n characters will have n-1
/// caret positions. The first character is not represented in the array,
/// since its caret position is the glyph position.
/// </para>
/// <para>
/// The positions returned by this function are &apos;unshaped&apos;, and will have to
/// be fixed up for kerning that may be applied to the ligature glyph.
/// </para>
/// </summary>

/// <param name="font">
/// The #hb_font_t to work on
/// </param>
/// <param name="direction">
/// The #hb_direction_t text direction to use
/// </param>
/// <param name="glyph">
/// The #hb_codepoint_t code point to query
/// </param>
/// <param name="start_offset">
/// offset of the first caret position to retrieve
/// </param>
/// <param name="caret_count">
/// Input = the maximum number of caret positions to return;
///               Output = the actual number of caret positions returned (may be zero)
/// </param>
/// <param name="caret_array">
/// The array of caret positions found for the query
/// </param>
/// <return>
/// Total number of ligature caret positions for @glyph.
/// </return>

	public static uint OtLayoutGetLigatureCarets(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint caret_count, out MentorLake.HarfBuzz.hb_position_t[] caret_array)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_ligature_carets(font, direction, glyph, start_offset, out caret_count, out caret_array);
	}

/// <summary>
/// <para>
/// Fetches optical-size feature data (i.e., the `size` feature from GPOS). Note that
/// the subfamily_id and the subfamily name string (accessible via the subfamily_name_id)
/// as used here are defined as pertaining only to fonts within a font family that differ
/// specifically in their respective size ranges; other ways to differentiate fonts within
/// a subfamily are not covered by the `size` feature.
/// </para>
/// <para>
/// For more information on this distinction, see the [`size` feature documentation](
/// https://docs.microsoft.com/en-us/typography/opentype/spec/features_pt#tag-size).
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="design_size">
/// The design size of the face
/// </param>
/// <param name="subfamily_id">
/// The identifier of the face within the font subfamily
/// </param>
/// <param name="subfamily_name_id">
/// The ‘name’ table name ID of the face within the font subfamily
/// </param>
/// <param name="range_start">
/// The minimum size of the recommended size range for the face
/// </param>
/// <param name="range_end">
/// The maximum size of the recommended size range for the face
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutGetSizeParams(MentorLake.HarfBuzz.hb_face_tHandle face, out uint design_size, out uint subfamily_id, out MentorLake.HarfBuzz.hb_ot_name_id_t subfamily_name_id, out uint range_start, out uint range_end)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_get_size_params(face, out design_size, out subfamily_id, out subfamily_name_id, out range_start, out range_end);
	}

/// <summary>
/// <para>
/// Tests whether a face has any glyph classes defined in its GDEF table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutHasGlyphClasses(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_has_glyph_classes(face);
	}

/// <summary>
/// <para>
/// Tests whether the specified face includes any GPOS positioning.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if the face has GPOS data, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutHasPositioning(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_has_positioning(face);
	}

/// <summary>
/// <para>
/// Tests whether the specified face includes any GSUB substitutions.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutHasSubstitution(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_has_substitution(face);
	}

/// <summary>
/// <para>
/// Fetches the index of a given feature tag in the specified face&apos;s GSUB table
/// or GPOS table, underneath the specified script and language.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_index">
/// The index of the requested language tag
/// </param>
/// <param name="feature_tag">
/// #hb_tag_t of the feature tag requested
/// </param>
/// <param name="feature_index">
/// The index of the requested feature
/// </param>
/// <return>
/// `true` if the feature is found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutLanguageFindFeature(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, MentorLake.HarfBuzz.hb_tag_t feature_tag, out uint feature_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_find_feature(face, table_tag, script_index, language_index, feature_tag, out feature_index);
	}

/// <summary>
/// <para>
/// Fetches a list of all features in the specified face&apos;s GSUB table
/// or GPOS table, underneath the specified script and language. The list
/// returned will begin at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_index">
/// The index of the requested language tag
/// </param>
/// <param name="start_offset">
/// offset of the first feature tag to retrieve
/// </param>
/// <param name="feature_count">
/// Input = the maximum number of feature tags to return;
///                 Output: the actual number of feature tags returned (may be zero)
/// </param>
/// <param name="feature_indexes">
/// The array of feature indexes found for the query
/// </param>
/// <return>
/// Total number of features.
/// </return>

	public static uint OtLayoutLanguageGetFeatureIndexes(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, uint start_offset, out uint feature_count, out uint[] feature_indexes)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_get_feature_indexes(face, table_tag, script_index, language_index, start_offset, out feature_count, out feature_indexes);
	}

/// <summary>
/// <para>
/// Fetches a list of all features in the specified face&apos;s GSUB table
/// or GPOS table, underneath the specified script and language. The list
/// returned will begin at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_index">
/// The index of the requested language tag
/// </param>
/// <param name="start_offset">
/// offset of the first feature tag to retrieve
/// </param>
/// <param name="feature_count">
/// Input = the maximum number of feature tags to return;
///                 Output = the actual number of feature tags returned (may be zero)
/// </param>
/// <param name="feature_tags">
/// The array of #hb_tag_t feature tags found for the query
/// </param>
/// <return>
/// Total number of feature tags.
/// </return>

	public static uint OtLayoutLanguageGetFeatureTags(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_tag_t[] feature_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_get_feature_tags(face, table_tag, script_index, language_index, start_offset, out feature_count, out feature_tags);
	}

/// <summary>
/// <para>
/// Fetches the tag of a requested feature index in the given face&apos;s GSUB or GPOS table,
/// underneath the specified script and language.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_index">
/// The index of the requested language tag
/// </param>
/// <param name="feature_index">
/// The index of the requested feature
/// </param>
/// <param name="feature_tag">
/// The #hb_tag_t of the requested feature
/// </param>
/// <return>
/// `true` if the feature is found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutLanguageGetRequiredFeature(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out uint feature_index, out MentorLake.HarfBuzz.hb_tag_t feature_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_get_required_feature(face, table_tag, script_index, language_index, out feature_index, out feature_tag);
	}

/// <summary>
/// <para>
/// Fetches the index of a requested feature in the given face&apos;s GSUB or GPOS table,
/// underneath the specified script and language.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_index">
/// The index of the requested language tag
/// </param>
/// <param name="feature_index">
/// The index of the requested feature
/// </param>
/// <return>
/// `true` if the feature is found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutLanguageGetRequiredFeatureIndex(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out uint feature_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_language_get_required_feature_index(face, table_tag, script_index, language_index, out feature_index);
	}

/// <summary>
/// <para>
/// Fetches a list of all glyphs affected by the specified lookup in the
/// specified face&apos;s GSUB table or GPOS table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="lookup_index">
/// The index of the feature lookup to query
/// </param>
/// <param name="glyphs_before">
/// Array of glyphs preceding the substitution range
/// </param>
/// <param name="glyphs_input">
/// Array of input glyphs that would be substituted by the lookup
/// </param>
/// <param name="glyphs_after">
/// Array of glyphs following the substitution range
/// </param>
/// <param name="glyphs_output">
/// Array of glyphs that would be the substituted output of the lookup
/// </param>

	public static void OtLayoutLookupCollectGlyphs(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint lookup_index, out MentorLake.HarfBuzz.hb_set_t glyphs_before, out MentorLake.HarfBuzz.hb_set_t glyphs_input, out MentorLake.HarfBuzz.hb_set_t glyphs_after, out MentorLake.HarfBuzz.hb_set_t glyphs_output)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_collect_glyphs(face, table_tag, lookup_index, out glyphs_before, out glyphs_input, out glyphs_after, out glyphs_output);
	}

/// <summary>
/// <para>
/// Fetches alternates of a glyph from a given GSUB lookup index.
/// </para>
/// </summary>

/// <param name="face">
/// a face.
/// </param>
/// <param name="lookup_index">
/// index of the feature lookup to query.
/// </param>
/// <param name="glyph">
/// a glyph id.
/// </param>
/// <param name="start_offset">
/// starting offset.
/// </param>
/// <param name="alternate_count">
/// Input = the maximum number of alternate glyphs to return;
///                   Output = the actual number of alternate glyphs returned (may be zero).
/// </param>
/// <param name="alternate_glyphs">
/// A glyphs buffer.
///                    Alternate glyphs associated with the glyph id.
/// </param>
/// <return>
/// Total number of alternates found in the specific lookup index for the given glyph id.
/// </return>

	public static uint OtLayoutLookupGetGlyphAlternates(MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint alternate_count, out MentorLake.HarfBuzz.hb_codepoint_t[] alternate_glyphs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_get_glyph_alternates(face, lookup_index, glyph, start_offset, out alternate_count, out alternate_glyphs);
	}

/// <summary>
/// <para>
/// Fetches the optical bound of a glyph positioned at the margin of text.
/// The direction identifies which edge of the glyph to query.
/// </para>
/// </summary>

/// <param name="font">
/// a font.
/// </param>
/// <param name="lookup_index">
/// index of the feature lookup to query.
/// </param>
/// <param name="direction">
/// edge of the glyph to query.
/// </param>
/// <param name="glyph">
/// a glyph id.
/// </param>
/// <return>
/// Adjustment value. Negative values mean the glyph will stick out of the margin.
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t OtLayoutLookupGetOpticalBound(MentorLake.HarfBuzz.hb_font_tHandle font, uint lookup_index, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_get_optical_bound(font, lookup_index, direction, glyph);
	}

/// <summary>
/// <para>
/// Compute the transitive closure of glyphs needed for a
/// specified lookup.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="lookup_index">
/// index of the feature lookup to query
/// </param>
/// <param name="glyphs">
/// Array of glyphs comprising the transitive closure of the lookup
/// </param>

	public static void OtLayoutLookupSubstituteClosure(MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, out MentorLake.HarfBuzz.hb_set_t glyphs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_substitute_closure(face, lookup_index, out glyphs);
	}

/// <summary>
/// <para>
/// Tests whether a specified lookup in the specified face would
/// trigger a substitution on the given glyph sequence.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="lookup_index">
/// The index of the lookup to query
/// </param>
/// <param name="glyphs">
/// The sequence of glyphs to query for substitution
/// </param>
/// <param name="glyphs_length">
/// The length of the glyph sequence
/// </param>
/// <param name="zero_context">
/// #hb_bool_t indicating whether pre-/post-context are disallowed
/// in substitutions
/// </param>
/// <return>
/// `true` if a substitution would be triggered, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutLookupWouldSubstitute(MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, MentorLake.HarfBuzz.hb_codepoint_tHandle glyphs, uint glyphs_length, MentorLake.HarfBuzz.hb_bool_t zero_context)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookup_would_substitute(face, lookup_index, glyphs, glyphs_length, zero_context);
	}

/// <summary>
/// <para>
/// Compute the transitive closure of glyphs needed for all of the
/// provided lookups.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="lookups">
/// The set of lookups to query
/// </param>
/// <param name="glyphs">
/// Array of glyphs comprising the transitive closure of the lookups
/// </param>

	public static void OtLayoutLookupsSubstituteClosure(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_set_tHandle lookups, out MentorLake.HarfBuzz.hb_set_t glyphs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_layout_lookups_substitute_closure(face, lookups, out glyphs);
	}

/// <summary>
/// <para>
/// Fetches the index of a given language tag in the specified face&apos;s GSUB table
/// or GPOS table, underneath the specified script tag.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_tag">
/// The #hb_tag_t of the requested language
/// </param>
/// <param name="language_index">
/// The index of the requested language
/// </param>
/// <return>
/// `true` if the language tag is found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutScriptFindLanguage(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, MentorLake.HarfBuzz.hb_tag_t language_tag, uint language_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_script_find_language(face, table_tag, script_index, language_tag, language_index);
	}

/// <summary>
/// <para>
/// Fetches a list of language tags in the given face&apos;s GSUB or GPOS table, underneath
/// the specified script index. The list returned will begin at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="start_offset">
/// offset of the first language tag to retrieve
/// </param>
/// <param name="language_count">
/// Input = the maximum number of language tags to return;
///                  Output = the actual number of language tags returned (may be zero)
/// </param>
/// <param name="language_tags">
/// Array of language tags found in the table
/// </param>
/// <return>
/// Total number of language tags.
/// </return>

	public static uint OtLayoutScriptGetLanguageTags(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint start_offset, out uint language_count, out MentorLake.HarfBuzz.hb_tag_t[] language_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_script_get_language_tags(face, table_tag, script_index, start_offset, out language_count, out language_tags);
	}

/// <summary>
/// <para>
/// Fetches the index of the first language tag fom @language_tags that is present
/// in the specified face&apos;s GSUB or GPOS table, underneath the specified script
/// index.
/// </para>
/// <para>
/// If none of the given language tags is found, `false` is returned and
/// @language_index is set to the default language index.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_count">
/// The number of languages in the specified script
/// </param>
/// <param name="language_tags">
/// The array of language tags
/// </param>
/// <param name="language_index">
/// The index of the requested language
/// </param>
/// <return>
/// `true` if one of the given language tags is found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutScriptSelectLanguage(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_count, MentorLake.HarfBuzz.hb_tag_tHandle language_tags, out uint language_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_script_select_language(face, table_tag, script_index, language_count, language_tags, out language_index);
	}

/// <summary>
/// <para>
/// Fetches the index of the first language tag fom @language_tags that is present
/// in the specified face&apos;s GSUB or GPOS table, underneath the specified script
/// index.
/// </para>
/// <para>
/// If none of the given language tags is found, `false` is returned and
/// @language_index is set to #HB_OT_LAYOUT_DEFAULT_LANGUAGE_INDEX and
/// @chosen_language is set to #HB_TAG_NONE.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <param name="language_count">
/// The number of languages in the specified script
/// </param>
/// <param name="language_tags">
/// The array of language tags
/// </param>
/// <param name="language_index">
/// The index of the chosen language
/// </param>
/// <param name="chosen_language">
/// #hb_tag_t of the chosen language
/// </param>
/// <return>
/// `true` if one of the given language tags is found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutScriptSelectLanguage2(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_count, MentorLake.HarfBuzz.hb_tag_tHandle language_tags, out uint language_index, out MentorLake.HarfBuzz.hb_tag_t chosen_language)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_script_select_language2(face, table_tag, script_index, language_count, language_tags, out language_index, out chosen_language);
	}

/// <summary>
/// <para>
/// Deprecated since 2.0.0
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_tags">
/// Array of #hb_tag_t script tags
/// </param>
/// <param name="script_index">
/// The index of the chosen script
/// </param>
/// <param name="chosen_script">
/// #hb_tag_t of the chosen script
/// </param>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutTableChooseScript(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_tHandle script_tags, out uint script_index, out MentorLake.HarfBuzz.hb_tag_t chosen_script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_choose_script(face, table_tag, script_tags, out script_index, out chosen_script);
	}

/// <summary>
/// <para>
/// Fetches a list of feature variations in the specified face&apos;s GSUB table
/// or GPOS table, at the specified variation coordinates.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="coords">
/// The variation coordinates to query
/// </param>
/// <param name="num_coords">
/// The number of variation coordinates
/// </param>
/// <param name="variations_index">
/// The array of feature variations found for the query
/// </param>
/// <return>
/// `true` if feature variations were found, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutTableFindFeatureVariations(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, int coords, uint num_coords, out uint variations_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_find_feature_variations(face, table_tag, coords, num_coords, out variations_index);
	}

/// <summary>
/// <para>
/// Fetches the index if a given script tag in the specified face&apos;s GSUB table
/// or GPOS table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_tag">
/// #hb_tag_t of the script tag requested
/// </param>
/// <param name="script_index">
/// The index of the requested script tag
/// </param>
/// <return>
/// `true` if the script is found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutTableFindScript(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, MentorLake.HarfBuzz.hb_tag_t script_tag, out uint script_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_find_script(face, table_tag, script_tag, out script_index);
	}

/// <summary>
/// <para>
/// Fetches a list of all feature tags in the given face&apos;s GSUB or GPOS table.
/// Note that there might be duplicate feature tags, belonging to different
/// script/language-system pairs of the table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="start_offset">
/// offset of the first feature tag to retrieve
/// </param>
/// <param name="feature_count">
/// Input = the maximum number of feature tags to return;
///                 Output = the actual number of feature tags returned (may be zero)
/// </param>
/// <param name="feature_tags">
/// Array of feature tags found in the table
/// </param>
/// <return>
/// Total number of feature tags.
/// </return>

	public static uint OtLayoutTableGetFeatureTags(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint start_offset, out uint feature_count, out MentorLake.HarfBuzz.hb_tag_t[] feature_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_get_feature_tags(face, table_tag, start_offset, out feature_count, out feature_tags);
	}

/// <summary>
/// <para>
/// Fetches the total number of lookups enumerated in the specified
/// face&apos;s GSUB table or GPOS table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <return>
/// Total number of lookups.
/// </return>

	public static uint OtLayoutTableGetLookupCount(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_get_lookup_count(face, table_tag);
	}

/// <summary>
/// <para>
/// Fetches a list of all scripts enumerated in the specified face&apos;s GSUB table
/// or GPOS table. The list returned will begin at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="start_offset">
/// offset of the first script tag to retrieve
/// </param>
/// <param name="script_count">
/// Input = the maximum number of script tags to return;
///                Output = the actual number of script tags returned (may be zero)
/// </param>
/// <param name="script_tags">
/// The array of #hb_tag_t script tags found for the query
/// </param>
/// <return>
/// Total number of script tags.
/// </return>

	public static uint OtLayoutTableGetScriptTags(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint start_offset, out uint script_count, out MentorLake.HarfBuzz.hb_tag_t[] script_tags)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_get_script_tags(face, table_tag, start_offset, out script_count, out script_tags);
	}

/// <summary>
/// <para>
/// Selects an OpenType script for @table_tag from the @script_tags array.
/// </para>
/// <para>
/// If the table does not have any of the requested scripts, then `DFLT`,
/// `dflt`, and `latn` tags are tried in that order. If the table still does not
/// have any of these scripts, @script_index is set to
/// #HB_OT_LAYOUT_NO_SCRIPT_INDEX and @chosen_script is set to #HB_TAG_NONE.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="table_tag">
/// #HB_OT_TAG_GSUB or #HB_OT_TAG_GPOS
/// </param>
/// <param name="script_count">
/// Number of script tags in the array
/// </param>
/// <param name="script_tags">
/// Array of #hb_tag_t script tags
/// </param>
/// <param name="script_index">
/// The index of the requested script
/// </param>
/// <param name="chosen_script">
/// #hb_tag_t of the requested script
/// </param>
/// <return>
/// `true` if one of the requested scripts is selected, `false` if a fallback
/// script is selected or if no scripts are selected.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtLayoutTableSelectScript(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_count, MentorLake.HarfBuzz.hb_tag_tHandle script_tags, out uint script_index, out MentorLake.HarfBuzz.hb_tag_t chosen_script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_layout_table_select_script(face, table_tag, script_count, script_tags, out script_index, out chosen_script);
	}

/// <summary>
/// <para>
/// Fetches the specified math constant. For most constants, the value returned
/// is an #hb_position_t.
/// </para>
/// <para>
/// However, if the requested constant is #HB_OT_MATH_CONSTANT_SCRIPT_PERCENT_SCALE_DOWN,
/// #HB_OT_MATH_CONSTANT_SCRIPT_SCRIPT_PERCENT_SCALE_DOWN or
/// #HB_OT_MATH_CONSTANT_RADICAL_DEGREE_BOTTOM_RAISE_PERCENT, then the return value is
/// an integer between 0 and 100 representing that percentage.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="constant">
/// #hb_ot_math_constant_t the constant to retrieve
/// </param>
/// <return>
/// the requested constant or zero
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetConstant(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_math_constant_t constant)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_constant(font, constant);
	}

/// <summary>
/// <para>
/// Fetches the GlyphAssembly for the specified font, glyph index, and direction.
/// Returned are a list of #hb_ot_math_glyph_part_t glyph parts that can be
/// used to draw the glyph and an italics-correction value (if one is defined
/// in the font).
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;The @direction parameter is only used to select between horizontal
/// or vertical directions for the construction. Even though all #hb_direction_t
/// values are accepted, only the result of #HB_DIRECTION_IS_HORIZONTAL is
/// considered.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The index of the glyph to stretch
/// </param>
/// <param name="direction">
/// direction of the stretching (horizontal or vertical)
/// </param>
/// <param name="start_offset">
/// offset of the first glyph part to retrieve
/// </param>
/// <param name="parts_count">
/// Input = maximum number of glyph parts to return;
///               Output = actual number of parts returned
/// </param>
/// <param name="parts">
/// the glyph parts returned
/// </param>
/// <param name="italics_correction">
/// italics correction of the glyph assembly
/// </param>
/// <return>
/// the total number of parts in the glyph assembly
/// </return>

	public static uint OtMathGetGlyphAssembly(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, uint start_offset, out uint parts_count, out MentorLake.HarfBuzz.hb_ot_math_glyph_part_t[] parts, out MentorLake.HarfBuzz.hb_position_t italics_correction)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_assembly(font, glyph, direction, start_offset, out parts_count, out parts, out italics_correction);
	}

/// <summary>
/// <para>
/// Fetches an italics-correction value (if one exists) for the specified
/// glyph index.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph index from which to retrieve the value
/// </param>
/// <return>
/// the italics correction of the glyph or zero
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetGlyphItalicsCorrection(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_italics_correction(font, glyph);
	}

/// <summary>
/// <para>
/// Fetches the math kerning (cut-ins) value for the specified font, glyph index, and
/// @kern.
/// </para>
/// <para>
/// If the MathKern table is found, the function examines it to find a height
/// value that is greater or equal to @correction_height. If such a height
/// value is found, corresponding kerning value from the table is returned. If
/// no such height value is found, the last kerning value is returned.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph index from which to retrieve the value
/// </param>
/// <param name="kern">
/// The #hb_ot_math_kern_t from which to retrieve the value
/// </param>
/// <param name="correction_height">
/// the correction height to use to determine the kerning.
/// </param>
/// <return>
/// requested kerning value or zero
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetGlyphKerning(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_ot_math_kern_t kern, MentorLake.HarfBuzz.hb_position_t correction_height)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_kerning(font, glyph, kern, correction_height);
	}

/// <summary>
/// <para>
/// Fetches the raw MathKern (cut-in) data for the specified font, glyph index,
/// and @kern. The corresponding list of kern values and correction heights is
/// returned as a list of #hb_ot_math_kern_entry_t structs.
/// </para>
/// <para>
/// See also #hb_ot_math_get_glyph_kerning, which handles selecting the
/// appropriate kern value for a given correction height.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;For a glyph with @n defined kern values (where @n &amp;gt; 0), there are only
/// @n−1 defined correction heights, as each correction height defines a boundary
/// past which the next kern value should be selected. Therefore, only the
/// #hb_ot_math_kern_entry_t.kern_value of the uppermost #hb_ot_math_kern_entry_t
/// actually comes from the font; its corresponding
/// #hb_ot_math_kern_entry_t.max_correction_height is always set to
/// &amp;lt;code&amp;gt;INT32_MAX&amp;lt;/code&amp;gt;.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph index from which to retrieve the kernings
/// </param>
/// <param name="kern">
/// The #hb_ot_math_kern_t from which to retrieve the kernings
/// </param>
/// <param name="start_offset">
/// offset of the first kern entry to retrieve
/// </param>
/// <param name="entries_count">
/// Input = the maximum number of kern entries to return;
///                                     Output = the actual number of kern entries returned
/// </param>
/// <param name="kern_entries">
/// array of kern entries returned
/// </param>
/// <return>
/// the total number of kern values available or zero
/// </return>

	public static uint OtMathGetGlyphKernings(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_ot_math_kern_t kern, uint start_offset, out uint entries_count, out MentorLake.HarfBuzz.hb_ot_math_kern_entry_t[] kern_entries)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_kernings(font, glyph, kern, start_offset, out entries_count, out kern_entries);
	}

/// <summary>
/// <para>
/// Fetches a top-accent-attachment value (if one exists) for the specified
/// glyph index.
/// </para>
/// <para>
/// For any glyph that does not have a top-accent-attachment value - that is,
/// a glyph not covered by the `MathTopAccentAttachment` table (or, when
/// @font has no `MathTopAccentAttachment` table or no `MATH` table, any
/// glyph) - the function synthesizes a value, returning the position at
/// one-half the glyph&apos;s advance width.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph index from which to retrieve the value
/// </param>
/// <return>
/// the top accent attachment of the glyph or 0.5 * the advance
///               width of @glyph
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetGlyphTopAccentAttachment(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_top_accent_attachment(font, glyph);
	}

/// <summary>
/// <para>
/// Fetches the MathGlyphConstruction for the specified font, glyph index, and
/// direction. The corresponding list of size variants is returned as a list of
/// #hb_ot_math_glyph_variant_t structs.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;The @direction parameter is only used to select between horizontal
/// or vertical directions for the construction. Even though all #hb_direction_t
/// values are accepted, only the result of #HB_DIRECTION_IS_HORIZONTAL is
/// considered.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="glyph">
/// The index of the glyph to stretch
/// </param>
/// <param name="direction">
/// The direction of the stretching (horizontal or vertical)
/// </param>
/// <param name="start_offset">
/// offset of the first variant to retrieve
/// </param>
/// <param name="variants_count">
/// Input = the maximum number of variants to return;
///                           Output = the actual number of variants returned
/// </param>
/// <param name="variants">
/// array of variants returned
/// </param>
/// <return>
/// the total number of size variants available or zero
/// </return>

	public static uint OtMathGetGlyphVariants(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, uint start_offset, out uint variants_count, out MentorLake.HarfBuzz.hb_ot_math_glyph_variant_t[] variants)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_glyph_variants(font, glyph, direction, start_offset, out variants_count, out variants);
	}

/// <summary>
/// <para>
/// Fetches the MathVariants table for the specified font and returns the
/// minimum overlap of connecting glyphs that are required to draw a glyph
/// assembly in the specified direction.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;The @direction parameter is only used to select between horizontal
/// or vertical directions for the construction. Even though all #hb_direction_t
/// values are accepted, only the result of #HB_DIRECTION_IS_HORIZONTAL is
/// considered.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="direction">
/// direction of the stretching (horizontal or vertical)
/// </param>
/// <return>
/// requested minimum connector overlap or zero
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t OtMathGetMinConnectorOverlap(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_get_min_connector_overlap(font, direction);
	}

/// <summary>
/// <para>
/// Tests whether a face has a `MATH` table.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to test
/// </param>
/// <return>
/// `true` if the table is found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtMathHasData(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_has_data(face);
	}

/// <summary>
/// <para>
/// Tests whether the given glyph index is an extended shape in the face.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="glyph">
/// The glyph index to test
/// </param>
/// <return>
/// `true` if the glyph is an extended shape, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtMathIsGlyphExtendedShape(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_math_is_glyph_extended_shape(face, glyph);
	}

/// <summary>
/// <para>
/// Fetches all available feature types.
/// </para>
/// </summary>

/// <param name="face">
/// a face object
/// </param>
/// <param name="start_offset">
/// iteration&apos;s start offset
/// </param>
/// <param name="entries_count">
/// buffer size as input, filled size as output
/// </param>
/// <param name="entries">
/// entries tags buffer
/// </param>
/// <return>
/// Number of all available feature types.
/// </return>

	public static uint OtMetaGetEntryTags(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint entries_count, out MentorLake.HarfBuzz.hb_ot_meta_tag_t[] entries)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_meta_get_entry_tags(face, start_offset, out entries_count, out entries);
	}

/// <summary>
/// <para>
/// It fetches metadata entry of a given tag from a font.
/// </para>
/// </summary>

/// <param name="face">
/// a #hb_face_t object.
/// </param>
/// <param name="meta_tag">
/// tag of metadata you like to have.
/// </param>
/// <return>
/// A blob containing the blob.
/// </return>

	public static MentorLake.HarfBuzz.hb_blob_tHandle OtMetaReferenceEntry(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_meta_tag_t meta_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_meta_reference_entry(face, meta_tag);
	}

/// <summary>
/// <para>
/// Fetches metrics value corresponding to @metrics_tag from @font.
/// </para>
/// </summary>

/// <param name="font">
/// an #hb_font_t object.
/// </param>
/// <param name="metrics_tag">
/// tag of metrics value you like to fetch.
/// </param>
/// <param name="position">
/// result of metrics value from the font.
/// </param>
/// <return>
/// Whether found the requested metrics in the font.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtMetricsGetPosition(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag, out MentorLake.HarfBuzz.hb_position_t position)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_position(font, metrics_tag, out position);
	}

/// <summary>
/// <para>
/// Fetches metrics value corresponding to @metrics_tag from @font,
/// and synthesizes a value if it the value is missing in the font.
/// </para>
/// </summary>

/// <param name="font">
/// an #hb_font_t object.
/// </param>
/// <param name="metrics_tag">
/// tag of metrics value you like to fetch.
/// </param>
/// <param name="position">
/// result of metrics value from the font.
/// </param>

	public static void OtMetricsGetPositionWithFallback(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag, out MentorLake.HarfBuzz.hb_position_t position)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_position_with_fallback(font, metrics_tag, out position);
	}

/// <summary>
/// <para>
/// Fetches metrics value corresponding to @metrics_tag from @font with the
/// current font variation settings applied.
/// </para>
/// </summary>

/// <param name="font">
/// an #hb_font_t object.
/// </param>
/// <param name="metrics_tag">
/// tag of metrics value you like to fetch.
/// </param>
/// <return>
/// The requested metric value.
/// </return>

	public static float OtMetricsGetVariation(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_variation(font, metrics_tag);
	}

/// <summary>
/// <para>
/// Fetches horizontal metrics value corresponding to @metrics_tag from @font
/// with the current font variation settings applied.
/// </para>
/// </summary>

/// <param name="font">
/// an #hb_font_t object.
/// </param>
/// <param name="metrics_tag">
/// tag of metrics value you like to fetch.
/// </param>
/// <return>
/// The requested metric value.
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t OtMetricsGetXVariation(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_x_variation(font, metrics_tag);
	}

/// <summary>
/// <para>
/// Fetches vertical metrics value corresponding to @metrics_tag from @font with
/// the current font variation settings applied.
/// </para>
/// </summary>

/// <param name="font">
/// an #hb_font_t object.
/// </param>
/// <param name="metrics_tag">
/// tag of metrics value you like to fetch.
/// </param>
/// <return>
/// The requested metric value.
/// </return>

	public static MentorLake.HarfBuzz.hb_position_t OtMetricsGetYVariation(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_metrics_tag_t metrics_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_metrics_get_y_variation(font, metrics_tag);
	}

/// <summary>
/// <para>
/// Fetches a font name from the OpenType &apos;name&apos; table.
/// If @language is #HB_LANGUAGE_INVALID, English (&quot;en&quot;) is assumed.
/// Returns string in UTF-16 encoding. A NUL terminator is always written
/// for convenience, and isn&apos;t included in the output @text_size.
/// </para>
/// </summary>

/// <param name="face">
/// font face.
/// </param>
/// <param name="name_id">
/// OpenType name identifier to fetch.
/// </param>
/// <param name="language">
/// language to fetch the name for.
/// </param>
/// <param name="text_size">
/// input size of @text buffer, and output size of
///                                   text written to buffer.
/// </param>
/// <param name="text">
/// buffer to write fetched name into.
/// </param>
/// <return>
/// full length of the requested string, or 0 if not found.
/// </return>

	public static uint OtNameGetUtf16(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out ushort[] text)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_name_get_utf16(face, name_id, language, out text_size, out text);
	}

/// <summary>
/// <para>
/// Fetches a font name from the OpenType &apos;name&apos; table.
/// If @language is #HB_LANGUAGE_INVALID, English (&quot;en&quot;) is assumed.
/// Returns string in UTF-32 encoding. A NUL terminator is always written
/// for convenience, and isn&apos;t included in the output @text_size.
/// </para>
/// </summary>

/// <param name="face">
/// font face.
/// </param>
/// <param name="name_id">
/// OpenType name identifier to fetch.
/// </param>
/// <param name="language">
/// language to fetch the name for.
/// </param>
/// <param name="text_size">
/// input size of @text buffer, and output size of
///                                   text written to buffer.
/// </param>
/// <param name="text">
/// buffer to write fetched name into.
/// </param>
/// <return>
/// full length of the requested string, or 0 if not found.
/// </return>

	public static uint OtNameGetUtf32(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out uint[] text)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_name_get_utf32(face, name_id, language, out text_size, out text);
	}

/// <summary>
/// <para>
/// Fetches a font name from the OpenType &apos;name&apos; table.
/// If @language is #HB_LANGUAGE_INVALID, English (&quot;en&quot;) is assumed.
/// Returns string in UTF-8 encoding. A NUL terminator is always written
/// for convenience, and isn&apos;t included in the output @text_size.
/// </para>
/// </summary>

/// <param name="face">
/// font face.
/// </param>
/// <param name="name_id">
/// OpenType name identifier to fetch.
/// </param>
/// <param name="language">
/// language to fetch the name for.
/// </param>
/// <param name="text_size">
/// input size of @text buffer, and output size of
///                                   text written to buffer.
/// </param>
/// <param name="text">
/// buffer to write fetched name into.
/// </param>
/// <return>
/// full length of the requested string, or 0 if not found.
/// </return>

	public static uint OtNameGetUtf8(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, out string[] text)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_name_get_utf8(face, name_id, language, out text_size, out text);
	}

/// <summary>
/// <para>
/// Enumerates all available name IDs and language combinations. Returned
/// array is owned by the @face and should not be modified.  It can be
/// used as long as @face is alive.
/// </para>
/// </summary>

/// <param name="face">
/// font face.
/// </param>
/// <param name="num_entries">
/// number of returned entries.
/// </param>
/// <return>
/// Array of available name entries.
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_name_entry_t[] OtNameListNames(MentorLake.HarfBuzz.hb_face_tHandle face, out uint num_entries)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_name_list_names(face, out num_entries);
	}

/// <summary>
/// <para>
/// Computes the transitive closure of glyphs needed for a specified
/// input buffer under the given font and feature list. The closure is
/// computed as a set, not as a list.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="buffer">
/// The input buffer to compute from
/// </param>
/// <param name="features">
/// The features enabled on the buffer
/// </param>
/// <param name="num_features">
/// The number of features enabled on the buffer
/// </param>
/// <param name="glyphs">
/// The #hb_set_t set of glyphs comprising the transitive closure of the query
/// </param>

	public static void OtShapeGlyphsClosure(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, out MentorLake.HarfBuzz.hb_set_t glyphs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_shape_glyphs_closure(font, buffer, features, num_features, out glyphs);
	}

/// <summary>
/// <para>
/// Computes the complete set of GSUB or GPOS lookups that are applicable
/// under a given @shape_plan.
/// </para>
/// </summary>

/// <param name="shape_plan">
/// #hb_shape_plan_t to query
/// </param>
/// <param name="table_tag">
/// GSUB or GPOS
/// </param>
/// <param name="lookup_indexes">
/// The #hb_set_t set of lookups returned
/// </param>

	public static void OtShapePlanCollectLookups(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_tag_t table_tag, out MentorLake.HarfBuzz.hb_set_t lookup_indexes)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_shape_plan_collect_lookups(shape_plan, table_tag, out lookup_indexes);
	}

/// <summary>
/// <para>
/// Converts an #hb_language_t to an #hb_tag_t.
/// </para>
/// </summary>

/// <param name="language">
/// an #hb_language_t to convert.
/// </param>

	public static MentorLake.HarfBuzz.hb_tag_t OtTagFromLanguage(MentorLake.HarfBuzz.hb_language_t language)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_tag_from_language(language);
	}

/// <summary>
/// <para>
/// Converts a language tag to an #hb_language_t.
/// </para>
/// </summary>

/// <param name="tag">
/// an language tag
/// </param>
/// <return>
/// 
/// The #hb_language_t corresponding to @tag.
/// </return>

	public static MentorLake.HarfBuzz.hb_language_t OtTagToLanguage(MentorLake.HarfBuzz.hb_tag_t tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_tag_to_language(tag);
	}

/// <summary>
/// <para>
/// Converts a script tag to an #hb_script_t.
/// </para>
/// </summary>

/// <param name="tag">
/// a script tag
/// </param>
/// <return>
/// The #hb_script_t corresponding to @tag.
/// </return>

	public static MentorLake.HarfBuzz.hb_script_t OtTagToScript(MentorLake.HarfBuzz.hb_tag_t tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_tag_to_script(tag);
	}

/// <summary>
/// <para>
/// Converts an #hb_script_t to script tags.
/// </para>
/// </summary>

/// <param name="script">
/// an #hb_script_t to convert.
/// </param>
/// <param name="script_tag_1">
/// output #hb_tag_t.
/// </param>
/// <param name="script_tag_2">
/// output #hb_tag_t.
/// </param>

	public static void OtTagsFromScript(MentorLake.HarfBuzz.hb_script_t script, out MentorLake.HarfBuzz.hb_tag_t script_tag_1, out MentorLake.HarfBuzz.hb_tag_t script_tag_2)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_tags_from_script(script, out script_tag_1, out script_tag_2);
	}

/// <summary>
/// <para>
/// Converts an #hb_script_t and an #hb_language_t to script and language tags.
/// </para>
/// </summary>

/// <param name="script">
/// an #hb_script_t to convert.
/// </param>
/// <param name="language">
/// an #hb_language_t to convert.
/// </param>
/// <param name="script_count">
/// maximum number of script tags to retrieve (IN)
/// and actual number of script tags retrieved (OUT)
/// </param>
/// <param name="script_tags">
/// array of size at least @script_count to store the
/// script tag results
/// </param>
/// <param name="language_count">
/// maximum number of language tags to retrieve
/// (IN) and actual number of language tags retrieved (OUT)
/// </param>
/// <param name="language_tags">
/// array of size at least @language_count to store
/// the language tag results
/// </param>

	public static void OtTagsFromScriptAndLanguage(MentorLake.HarfBuzz.hb_script_t script, MentorLake.HarfBuzz.hb_language_t language, ref uint script_count, out MentorLake.HarfBuzz.hb_tag_t script_tags, ref uint language_count, out MentorLake.HarfBuzz.hb_tag_t language_tags)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_tags_from_script_and_language(script, language, ref script_count, out script_tags, ref language_count, out language_tags);
	}

/// <summary>
/// <para>
/// Converts a script tag and a language tag to an #hb_script_t and an
/// #hb_language_t.
/// </para>
/// </summary>

/// <param name="script_tag">
/// a script tag
/// </param>
/// <param name="language_tag">
/// a language tag
/// </param>
/// <param name="script">
/// the #hb_script_t corresponding to @script_tag.
/// </param>
/// <param name="language">
/// the #hb_language_t corresponding to @script_tag and
/// @language_tag.
/// </param>

	public static void OtTagsToScriptAndLanguage(MentorLake.HarfBuzz.hb_tag_t script_tag, MentorLake.HarfBuzz.hb_tag_t language_tag, out MentorLake.HarfBuzz.hb_script_t script, out MentorLake.HarfBuzz.hb_language_t language)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_tags_to_script_and_language(script_tag, language_tag, out script, out language);
	}

/// <summary>
/// <para>
/// Fetches the variation-axis information corresponding to the specified axis tag
/// in the specified face.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="axis_tag">
/// The #hb_tag_t of the variation axis to query
/// </param>
/// <param name="axis_index">
/// The index of the variation axis
/// </param>
/// <param name="axis_info">
/// The #hb_ot_var_axis_info_t of the axis tag queried
/// </param>

	public static MentorLake.HarfBuzz.hb_bool_t OtVarFindAxis(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t axis_tag, uint axis_index, out MentorLake.HarfBuzz.hb_ot_var_axis_t axis_info)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_find_axis(face, axis_tag, axis_index, out axis_info);
	}

/// <summary>
/// <para>
/// Fetches the variation-axis information corresponding to the specified axis tag
/// in the specified face.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="axis_tag">
/// The #hb_tag_t of the variation axis to query
/// </param>
/// <param name="axis_info">
/// The #hb_ot_var_axis_info_t of the axis tag queried
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtVarFindAxisInfo(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t axis_tag, out MentorLake.HarfBuzz.hb_ot_var_axis_info_t axis_info)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_find_axis_info(face, axis_tag, out axis_info);
	}

/// <summary>
/// <para>
/// Fetches a list of all variation axes in the specified face. The list returned will begin
/// at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="start_offset">
/// offset of the first lookup to retrieve
/// </param>
/// <param name="axes_count">
/// Input = the maximum number of variation axes to return;
///                Output = the actual number of variation axes returned (may be zero)
/// </param>
/// <param name="axes_array">
/// The array of variation axes found
/// </param>

	public static uint OtVarGetAxes(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint axes_count, out MentorLake.HarfBuzz.hb_ot_var_axis_t[] axes_array)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_get_axes(face, start_offset, out axes_count, out axes_array);
	}

/// <summary>
/// <para>
/// Fetches the number of OpenType variation axes included in the face.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <return>
/// the number of variation axes defined
/// </return>

	public static uint OtVarGetAxisCount(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_get_axis_count(face);
	}

/// <summary>
/// <para>
/// Fetches a list of all variation axes in the specified face. The list returned will begin
/// at the offset provided.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to work upon
/// </param>
/// <param name="start_offset">
/// offset of the first lookup to retrieve
/// </param>
/// <param name="axes_count">
/// Input = the maximum number of variation axes to return;
///                Output = the actual number of variation axes returned (may be zero)
/// </param>
/// <param name="axes_array">
/// The array of variation axes found
/// </param>
/// <return>
/// the number of variation axes in the face
/// </return>

	public static uint OtVarGetAxisInfos(MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint axes_count, out MentorLake.HarfBuzz.hb_ot_var_axis_info_t[] axes_array)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_get_axis_infos(face, start_offset, out axes_count, out axes_array);
	}

/// <summary>
/// <para>
/// Fetches the number of named instances included in the face.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <return>
/// the number of named instances defined
/// </return>

	public static uint OtVarGetNamedInstanceCount(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_get_named_instance_count(face);
	}

/// <summary>
/// <para>
/// Tests whether a face includes any OpenType variation data in the `fvar` table.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t OtVarHasData(MentorLake.HarfBuzz.hb_face_tHandle face)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_has_data(face);
	}

/// <summary>
/// <para>
/// Fetches the design-space coordinates corresponding to the given
/// named instance in the face.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <param name="instance_index">
/// The index of the named instance to query
/// </param>
/// <param name="coords_length">
/// Input = the maximum number of coordinates to return;
///                 Output = the actual number of coordinates returned (may be zero)
/// </param>
/// <param name="coords">
/// The array of coordinates found for the query
/// </param>
/// <return>
/// the number of variation axes in the face
/// </return>

	public static uint OtVarNamedInstanceGetDesignCoords(MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index, out uint coords_length, out float[] coords)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_named_instance_get_design_coords(face, instance_index, out coords_length, out coords);
	}

/// <summary>
/// <para>
/// Fetches the `name` table Name ID that provides display names for
/// the &quot;PostScript name&quot; defined for the given named instance in the face.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <param name="instance_index">
/// The index of the named instance to query
/// </param>
/// <return>
/// the Name ID found for the PostScript name
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_name_id_t OtVarNamedInstanceGetPostscriptNameId(MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_named_instance_get_postscript_name_id(face, instance_index);
	}

/// <summary>
/// <para>
/// Fetches the `name` table Name ID that provides display names for
/// the &quot;Subfamily name&quot; defined for the given named instance in the face.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <param name="instance_index">
/// The index of the named instance to query
/// </param>
/// <return>
/// the Name ID found for the Subfamily name
/// </return>

	public static MentorLake.HarfBuzz.hb_ot_name_id_t OtVarNamedInstanceGetSubfamilyNameId(MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_ot_var_named_instance_get_subfamily_name_id(face, instance_index);
	}

/// <summary>
/// <para>
/// Normalizes the given design-space coordinates. The minimum and maximum
/// values for the axis are mapped to the interval [-1,1], with the default
/// axis value mapped to 0.
/// </para>
/// <para>
/// The normalized values have 14 bits of fixed-point sub-integer precision as per
/// OpenType specification.
/// </para>
/// <para>
/// Any additional scaling defined in the face&apos;s `avar` table is also
/// applied, as described at https://docs.microsoft.com/en-us/typography/opentype/spec/avar
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <param name="coords_length">
/// The length of the coordinate array
/// </param>
/// <param name="design_coords">
/// The design-space coordinates to normalize
/// </param>
/// <param name="normalized_coords">
/// The normalized coordinates
/// </param>

	public static void OtVarNormalizeCoords(MentorLake.HarfBuzz.hb_face_tHandle face, uint coords_length, float design_coords, out int normalized_coords)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_var_normalize_coords(face, coords_length, design_coords, out normalized_coords);
	}

/// <summary>
/// <para>
/// Normalizes all of the coordinates in the given list of variation axes.
/// </para>
/// </summary>

/// <param name="face">
/// The #hb_face_t to work on
/// </param>
/// <param name="variations">
/// The array of variations to normalize
/// </param>
/// <param name="variations_length">
/// The number of variations to normalize
/// </param>
/// <param name="coords">
/// The array of normalized coordinates
/// </param>
/// <param name="coords_length">
/// The length of the coordinate array
/// </param>

	public static void OtVarNormalizeVariations(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_variation_tHandle variations, uint variations_length, out int[] coords, out uint coords_length)
	{
		HarfBuzzGlobalFunctionsExterns.hb_ot_var_normalize_variations(face, variations, variations_length, out coords, out coords_length);
	}

/// <summary>
/// <para>
/// Perform a &quot;color&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="is_foreground">
/// whether the color is the foreground
/// </param>
/// <param name="color">
/// The color to use
/// </param>

	public static void PaintColor(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_bool_t is_foreground, MentorLake.HarfBuzz.hb_color_t color)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_color(funcs, paint_data, is_foreground, color);
	}

/// <summary>
/// <para>
/// Perform a &quot;color-glyph&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="glyph">
/// the glyph ID
/// </param>
/// <param name="font">
/// the font
/// </param>

	public static MentorLake.HarfBuzz.hb_bool_t PaintColorGlyph(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_color_glyph(funcs, paint_data, glyph, font);
	}

/// <summary>
/// <para>
/// Gets the custom palette color for @color_index.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="color_index">
/// color index
/// </param>
/// <param name="color">
/// fetched color
/// </param>
/// <return>
/// `true` if found, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t PaintCustomPaletteColor(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, uint color_index, out MentorLake.HarfBuzz.hb_color_t color)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_custom_palette_color(funcs, paint_data, color_index, out color);
	}

/// <summary>
/// <para>
/// Creates a new #hb_paint_funcs_t structure of paint functions.
/// </para>
/// <para>
/// The initial reference count of 1 should be released with hb_paint_funcs_destroy()
/// when you are done using the #hb_paint_funcs_t. This function never returns
/// `NULL`. If memory cannot be allocated, a special singleton #hb_paint_funcs_t
/// object will be returned.
/// </para>
/// </summary>

/// <return>
/// the paint-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_paint_funcs_tHandle PaintFuncsCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_create();
	}

/// <summary>
/// <para>
/// Decreases the reference count on a paint-functions structure.
/// </para>
/// <para>
/// When the reference count reaches zero, the structure
/// is destroyed, freeing all memory.
/// </para>
/// </summary>

/// <param name="funcs">
/// The paint-functions structure
/// </param>

	public static void PaintFuncsDestroy(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_destroy(funcs);
	}

/// <summary>
/// <para>
/// Fetches the singleton empty paint-functions structure.
/// </para>
/// </summary>

/// <return>
/// The empty paint-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_paint_funcs_tHandle PaintFuncsGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the user-data associated with the specified key,
/// attached to the specified paint-functions structure.
/// </para>
/// </summary>

/// <param name="funcs">
/// The paint-functions structure
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr PaintFuncsGetUserData(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_get_user_data(funcs, key);
	}

/// <summary>
/// <para>
/// Tests whether a paint-functions structure is immutable.
/// </para>
/// </summary>

/// <param name="funcs">
/// The paint-functions structure
/// </param>
/// <return>
/// `true` if @funcs is immutable, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t PaintFuncsIsImmutable(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_is_immutable(funcs);
	}

/// <summary>
/// <para>
/// Makes a paint-functions structure immutable.
/// </para>
/// <para>
/// After this call, all attempts to set one of the callbacks
/// on @funcs will fail.
/// </para>
/// </summary>

/// <param name="funcs">
/// The paint-functions structure
/// </param>

	public static void PaintFuncsMakeImmutable(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_make_immutable(funcs);
	}

/// <summary>
/// <para>
/// Increases the reference count on a paint-functions structure.
/// </para>
/// <para>
/// This prevents @funcs from being destroyed until a matching
/// call to hb_paint_funcs_destroy() is made.
/// </para>
/// </summary>

/// <param name="funcs">
/// The paint-functions structure
/// </param>
/// <return>
/// The paint-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_paint_funcs_tHandle PaintFuncsReference(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_reference(funcs);
	}

/// <summary>
/// <para>
/// Sets the paint-color callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The paint-color callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetColorFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_color_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_color_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the color-glyph callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The color-glyph callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetColorGlyphFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_color_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_color_glyph_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the custom-palette-color callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The custom-palette-color callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetCustomPaletteColorFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_custom_palette_color_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_custom_palette_color_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the paint-image callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The paint-image callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetImageFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_image_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_image_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the linear-gradient callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The linear-gradient callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetLinearGradientFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_linear_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_linear_gradient_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the pop-clip callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The pop-clip callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetPopClipFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_clip_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_pop_clip_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the pop-group callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The pop-group callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetPopGroupFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_group_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_pop_group_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the pop-transform callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The pop-transform callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetPopTransformFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_pop_transform_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_pop_transform_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the push-clip-glyph callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The push-clip-glyph callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetPushClipGlyphFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_clip_glyph_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_push_clip_glyph_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the push-clip-rect callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The push-clip-rectangle callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetPushClipRectangleFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_clip_rectangle_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_push_clip_rectangle_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the push-group callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The push-group callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetPushGroupFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_group_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_push_group_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the push-transform callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The push-transform callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetPushTransformFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_push_transform_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_push_transform_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the radial-gradient callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The radial-gradient callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetRadialGradientFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_radial_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_radial_gradient_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the sweep-gradient callback on the paint functions struct.
/// </para>
/// </summary>

/// <param name="funcs">
/// A paint functions struct
/// </param>
/// <param name="func">
/// The sweep-gradient callback
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// Function to call when @user_data is no longer needed
/// </param>

	public static void PaintFuncsSetSweepGradientFunc(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_paint_sweep_gradient_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_sweep_gradient_func(funcs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified paint-functions structure.
/// </para>
/// </summary>

/// <param name="funcs">
/// The paint-functions structure
/// </param>
/// <param name="key">
/// The user-data key
/// </param>
/// <param name="data">
/// A pointer to the user data
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t PaintFuncsSetUserData(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_paint_funcs_set_user_data(funcs, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Perform a &quot;image&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="image">
/// image data
/// </param>
/// <param name="width">
/// width of the raster image in pixels, or 0
/// </param>
/// <param name="height">
/// height of the raster image in pixels, or 0
/// </param>
/// <param name="format">
/// the image format as a tag
/// </param>
/// <param name="slant">
/// the synthetic slant ratio to be applied to the image during rendering
/// </param>
/// <param name="extents">
/// the extents of the glyph
/// </param>

	public static void PaintImage(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_blob_tHandle image, uint width, uint height, MentorLake.HarfBuzz.hb_tag_t format, float slant, MentorLake.HarfBuzz.hb_glyph_extents_tHandle extents)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_image(funcs, paint_data, image, width, height, format, slant, extents);
	}

/// <summary>
/// <para>
/// Perform a &quot;linear-gradient&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="color_line">
/// Color information for the gradient
/// </param>
/// <param name="x0">
/// X coordinate of the first point
/// </param>
/// <param name="y0">
/// Y coordinate of the first point
/// </param>
/// <param name="x1">
/// X coordinate of the second point
/// </param>
/// <param name="y1">
/// Y coordinate of the second point
/// </param>
/// <param name="x2">
/// X coordinate of the third point
/// </param>
/// <param name="y2">
/// Y coordinate of the third point
/// </param>

	public static void PaintLinearGradient(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float x1, float y1, float x2, float y2)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_linear_gradient(funcs, paint_data, color_line, x0, y0, x1, y1, x2, y2);
	}

/// <summary>
/// <para>
/// Perform a &quot;pop-clip&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>

	public static void PaintPopClip(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_pop_clip(funcs, paint_data);
	}

/// <summary>
/// <para>
/// Perform a &quot;pop-group&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="mode">
/// the compositing mode to use
/// </param>

	public static void PaintPopGroup(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_paint_composite_mode_t mode)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_pop_group(funcs, paint_data, mode);
	}

/// <summary>
/// <para>
/// Perform a &quot;pop-transform&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>

	public static void PaintPopTransform(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_pop_transform(funcs, paint_data);
	}

/// <summary>
/// <para>
/// Perform a &quot;push-clip-glyph&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="glyph">
/// the glyph ID
/// </param>
/// <param name="font">
/// the font
/// </param>

	public static void PaintPushClipGlyph(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_font_tHandle font)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_push_clip_glyph(funcs, paint_data, glyph, font);
	}

/// <summary>
/// <para>
/// Perform a &quot;push-clip-rect&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="xmin">
/// min X for the rectangle
/// </param>
/// <param name="ymin">
/// min Y for the rectangle
/// </param>
/// <param name="xmax">
/// max X for the rectangle
/// </param>
/// <param name="ymax">
/// max Y for the rectangle
/// </param>

	public static void PaintPushClipRectangle(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, float xmin, float ymin, float xmax, float ymax)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_push_clip_rectangle(funcs, paint_data, xmin, ymin, xmax, ymax);
	}

/// <summary>
/// <para>
/// Perform a &quot;push-group&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>

	public static void PaintPushGroup(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_push_group(funcs, paint_data);
	}

/// <summary>
/// <para>
/// Perform a &quot;push-transform&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="xx">
/// xx component of the transform matrix
/// </param>
/// <param name="yx">
/// yx component of the transform matrix
/// </param>
/// <param name="xy">
/// xy component of the transform matrix
/// </param>
/// <param name="yy">
/// yy component of the transform matrix
/// </param>
/// <param name="dx">
/// dx component of the transform matrix
/// </param>
/// <param name="dy">
/// dy component of the transform matrix
/// </param>

	public static void PaintPushTransform(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, float xx, float yx, float xy, float yy, float dx, float dy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_push_transform(funcs, paint_data, xx, yx, xy, yy, dx, dy);
	}

/// <summary>
/// <para>
/// Perform a &quot;radial-gradient&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="color_line">
/// Color information for the gradient
/// </param>
/// <param name="x0">
/// X coordinate of the first circle&apos;s center
/// </param>
/// <param name="y0">
/// Y coordinate of the first circle&apos;s center
/// </param>
/// <param name="r0">
/// radius of the first circle
/// </param>
/// <param name="x1">
/// X coordinate of the second circle&apos;s center
/// </param>
/// <param name="y1">
/// Y coordinate of the second circle&apos;s center
/// </param>
/// <param name="r1">
/// radius of the second circle
/// </param>

	public static void PaintRadialGradient(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float r0, float x1, float y1, float r1)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_radial_gradient(funcs, paint_data, color_line, x0, y0, r0, x1, y1, r1);
	}

/// <summary>
/// <para>
/// Perform a &quot;sweep-gradient&quot; paint operation.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions
/// </param>
/// <param name="paint_data">
/// associated data passed by the caller
/// </param>
/// <param name="color_line">
/// Color information for the gradient
/// </param>
/// <param name="x0">
/// X coordinate of the circle&apos;s center
/// </param>
/// <param name="y0">
/// Y coordinate of the circle&apos;s center
/// </param>
/// <param name="start_angle">
/// the start angle
/// </param>
/// <param name="end_angle">
/// the end angle
/// </param>

	public static void PaintSweepGradient(MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float start_angle, float end_angle)
	{
		HarfBuzzGlobalFunctionsExterns.hb_paint_sweep_gradient(funcs, paint_data, color_line, x0, y0, start_angle, end_angle);
	}

/// <summary>
/// <para>
/// Converts an ISO 15924 script tag to a corresponding #hb_script_t.
/// </para>
/// </summary>

/// <param name="tag">
/// an #hb_tag_t representing an ISO 15924 tag.
/// </param>
/// <return>
/// An #hb_script_t corresponding to the ISO 15924 tag.
/// </return>

	public static MentorLake.HarfBuzz.hb_script_t ScriptFromIso15924Tag(MentorLake.HarfBuzz.hb_tag_t tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_script_from_iso15924_tag(tag);
	}

/// <summary>
/// <para>
/// Converts a string @str representing an ISO 15924 script tag to a
/// corresponding #hb_script_t. Shorthand for hb_tag_from_string() then
/// hb_script_from_iso15924_tag().
/// </para>
/// </summary>

/// <param name="str">
/// a string representing an
///       ISO 15924 tag.
/// </param>
/// <param name="len">
/// length of the @str, or -1 if it is `NULL`-terminated.
/// </param>
/// <return>
/// An #hb_script_t corresponding to the ISO 15924 tag.
/// </return>

	public static MentorLake.HarfBuzz.hb_script_t ScriptFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_script_from_string(str, len);
	}

/// <summary>
/// <para>
/// Fetches the #hb_direction_t of a script when it is
/// set horizontally. All right-to-left scripts will return
/// #HB_DIRECTION_RTL. All left-to-right scripts will return
/// #HB_DIRECTION_LTR.  Scripts that can be written either
/// horizontally or vertically will return #HB_DIRECTION_INVALID.
/// Unknown scripts will return #HB_DIRECTION_LTR.
/// </para>
/// </summary>

/// <param name="script">
/// The #hb_script_t to query
/// </param>
/// <return>
/// The horizontal #hb_direction_t of @script
/// </return>

	public static MentorLake.HarfBuzz.hb_direction_t ScriptGetHorizontalDirection(MentorLake.HarfBuzz.hb_script_t script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_script_get_horizontal_direction(script);
	}

/// <summary>
/// <para>
/// Converts an #hb_script_t to a corresponding ISO 15924 script tag.
/// </para>
/// </summary>

/// <param name="script">
/// an #hb_script_t to convert.
/// </param>
/// <return>
/// An #hb_tag_t representing an ISO 15924 script tag.
/// </return>

	public static MentorLake.HarfBuzz.hb_tag_t ScriptToIso15924Tag(MentorLake.HarfBuzz.hb_script_t script)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_script_to_iso15924_tag(script);
	}

/// <summary>
/// <para>
/// Checks the equality of two #hb_segment_properties_t&apos;s.
/// </para>
/// </summary>

/// <param name="a">
/// first #hb_segment_properties_t to compare.
/// </param>
/// <param name="b">
/// second #hb_segment_properties_t to compare.
/// </param>
/// <return>
/// `true` if all properties of @a equal those of @b, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SegmentPropertiesEqual(MentorLake.HarfBuzz.hb_segment_properties_tHandle a, MentorLake.HarfBuzz.hb_segment_properties_tHandle b)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_segment_properties_equal(a, b);
	}

/// <summary>
/// <para>
/// Creates a hash representing @p.
/// </para>
/// </summary>

/// <param name="p">
/// #hb_segment_properties_t to hash.
/// </param>
/// <return>
/// A hash of @p.
/// </return>

	public static uint SegmentPropertiesHash(MentorLake.HarfBuzz.hb_segment_properties_tHandle p)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_segment_properties_hash(p);
	}

/// <summary>
/// <para>
/// Fills in missing fields of @p from @src in a considered manner.
/// </para>
/// <para>
/// First, if @p does not have direction set, direction is copied from @src.
/// </para>
/// <para>
/// Next, if @p and @src have the same direction (which can be unset), if @p
/// does not have script set, script is copied from @src.
/// </para>
/// <para>
/// Finally, if @p and @src have the same direction and script (which either
/// can be unset), if @p does not have language set, language is copied from
/// @src.
/// </para>
/// </summary>

/// <param name="p">
/// #hb_segment_properties_t to fill in.
/// </param>
/// <param name="src">
/// #hb_segment_properties_t to fill in from.
/// </param>

	public static void SegmentPropertiesOverlay(MentorLake.HarfBuzz.hb_segment_properties_tHandle p, MentorLake.HarfBuzz.hb_segment_properties_tHandle src)
	{
		HarfBuzzGlobalFunctionsExterns.hb_segment_properties_overlay(p, src);
	}

/// <summary>
/// <para>
/// Adds @codepoint to @set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="codepoint">
/// The element to add to @set
/// </param>

	public static void SetAdd(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_add(set, codepoint);
	}

/// <summary>
/// <para>
/// Adds all of the elements from @first to @last
/// (inclusive) to @set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="first">
/// The first element to add to @set
/// </param>
/// <param name="last">
/// The final element to add to @set
/// </param>

	public static void SetAddRange(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t first, MentorLake.HarfBuzz.hb_codepoint_t last)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_add_range(set, first, last);
	}

/// <summary>
/// <para>
/// Adds @num_codepoints codepoints to a set at once.
/// The codepoints array must be in increasing order,
/// with size at least @num_codepoints.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="sorted_codepoints">
/// Array of codepoints to add
/// </param>
/// <param name="num_codepoints">
/// Length of @sorted_codepoints
/// </param>

	public static void SetAddSortedArray(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t[] sorted_codepoints, uint num_codepoints)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_add_sorted_array(set, sorted_codepoints, num_codepoints);
	}

/// <summary>
/// <para>
/// Tests whether memory allocation for a set was successful.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <return>
/// `true` if allocation succeeded, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetAllocationSuccessful(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_allocation_successful(set);
	}

/// <summary>
/// <para>
/// Clears out the contents of a set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>

	public static void SetClear(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_clear(set);
	}

/// <summary>
/// <para>
/// Allocate a copy of @set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <return>
/// Newly-allocated set.
/// </return>

	public static MentorLake.HarfBuzz.hb_set_tHandle SetCopy(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_copy(set);
	}

/// <summary>
/// <para>
/// Creates a new, initially empty set.
/// </para>
/// </summary>

/// <return>
/// The new #hb_set_t
/// </return>

	public static MentorLake.HarfBuzz.hb_set_tHandle SetCreate()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_create();
	}

/// <summary>
/// <para>
/// Removes @codepoint from @set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="codepoint">
/// Removes @codepoint from @set
/// </param>

	public static void SetDel(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_del(set, codepoint);
	}

/// <summary>
/// <para>
/// Removes all of the elements from @first to @last
/// (inclusive) from @set.
/// </para>
/// <para>
/// If @last is #HB_SET_VALUE_INVALID, then all values
/// greater than or equal to @first are removed.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="first">
/// The first element to remove from @set
/// </param>
/// <param name="last">
/// The final element to remove from @set
/// </param>

	public static void SetDelRange(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t first, MentorLake.HarfBuzz.hb_codepoint_t last)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_del_range(set, first, last);
	}

/// <summary>
/// <para>
/// Decreases the reference count on a set. When
/// the reference count reaches zero, the set is
/// destroyed, freeing all memory.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>

	public static void SetDestroy(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_destroy(set);
	}

/// <summary>
/// <para>
/// Fetches the singleton empty #hb_set_t.
/// </para>
/// </summary>

/// <return>
/// The empty #hb_set_t
/// </return>

	public static MentorLake.HarfBuzz.hb_set_tHandle SetGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_empty();
	}

/// <summary>
/// <para>
/// Finds the largest element in the set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <return>
/// maximum of @set, or #HB_SET_VALUE_INVALID if @set is empty.
/// </return>

	public static MentorLake.HarfBuzz.hb_codepoint_t SetGetMax(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_max(set);
	}

/// <summary>
/// <para>
/// Finds the smallest element in the set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <return>
/// minimum of @set, or #HB_SET_VALUE_INVALID if @set is empty.
/// </return>

	public static MentorLake.HarfBuzz.hb_codepoint_t SetGetMin(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_min(set);
	}

/// <summary>
/// <para>
/// Returns the number of elements in the set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <return>
/// The population of @set
/// </return>

	public static uint SetGetPopulation(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_population(set);
	}

/// <summary>
/// <para>
/// Fetches the user data associated with the specified key,
/// attached to the specified set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr SetGetUserData(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_get_user_data(set, key);
	}

/// <summary>
/// <para>
/// Tests whether @codepoint belongs to @set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="codepoint">
/// The element to query
/// </param>
/// <return>
/// `true` if @codepoint is in @set, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetHas(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_has(set, codepoint);
	}

/// <summary>
/// <para>
/// Creates a hash representing @set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <return>
/// A hash of @set.
/// </return>

	public static uint SetHash(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_hash(set);
	}

/// <summary>
/// <para>
/// Makes @set the intersection of @set and @other.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="other">
/// Another set
/// </param>

	public static void SetIntersect(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_intersect(set, other);
	}

/// <summary>
/// <para>
/// Inverts the contents of @set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>

	public static void SetInvert(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_invert(set);
	}

/// <summary>
/// <para>
/// Tests whether a set is empty (contains no elements).
/// </para>
/// </summary>

/// <param name="set">
/// a set.
/// </param>
/// <return>
/// `true` if @set is empty
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetIsEmpty(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_is_empty(set);
	}

/// <summary>
/// <para>
/// Tests whether @set and @other are equal (contain the same
/// elements).
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="other">
/// Another set
/// </param>
/// <return>
/// `true` if the two sets are equal, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetIsEqual(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_is_equal(set, other);
	}

/// <summary>
/// <para>
/// Returns whether the set is inverted.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <return>
/// `true` if the set is inverted, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetIsInverted(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_is_inverted(set);
	}

/// <summary>
/// <para>
/// Tests whether @set is a subset of @larger_set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="larger_set">
/// Another set
/// </param>
/// <return>
/// `true` if the @set is a subset of (or equal to) @larger_set, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetIsSubset(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle larger_set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_is_subset(set, larger_set);
	}

/// <summary>
/// <para>
/// Fetches the next element in @set that is greater than current value of @codepoint.
/// </para>
/// <para>
/// Set @codepoint to #HB_SET_VALUE_INVALID to get started.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="codepoint">
/// Input = Code point to query
///             Output = Code point retrieved
/// </param>
/// <return>
/// `true` if there was a next value, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetNext(MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_next(set, ref codepoint);
	}

/// <summary>
/// <para>
/// Finds the next element in @set that is greater than @codepoint. Writes out
/// codepoints to @out, until either the set runs out of elements, or @size
/// codepoints are written, whichever comes first.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="codepoint">
/// Outputting codepoints starting after this one.
///             Use #HB_SET_VALUE_INVALID to get started.
/// </param>
/// <param name="@out">
/// An array of codepoints to write to.
/// </param>
/// <param name="size">
/// The maximum number of codepoints to write out.
/// </param>
/// <return>
/// the number of values written.
/// </return>

	public static uint SetNextMany(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint, MentorLake.HarfBuzz.hb_codepoint_t[] @out, uint size)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_next_many(set, codepoint, @out, size);
	}

/// <summary>
/// <para>
/// Fetches the next consecutive range of elements in @set that
/// are greater than current value of @last.
/// </para>
/// <para>
/// Set @last to #HB_SET_VALUE_INVALID to get started.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="first">
/// The first code point in the range
/// </param>
/// <param name="last">
/// Input = The current last code point in the range
///         Output = The last code point in the range
/// </param>
/// <return>
/// `true` if there was a next range, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetNextRange(MentorLake.HarfBuzz.hb_set_tHandle set, out MentorLake.HarfBuzz.hb_codepoint_t first, ref MentorLake.HarfBuzz.hb_codepoint_t last)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_next_range(set, out first, ref last);
	}

/// <summary>
/// <para>
/// Fetches the previous element in @set that is lower than current value of @codepoint.
/// </para>
/// <para>
/// Set @codepoint to #HB_SET_VALUE_INVALID to get started.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="codepoint">
/// Input = Code point to query
///             Output = Code point retrieved
/// </param>
/// <return>
/// `true` if there was a previous value, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetPrevious(MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t codepoint)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_previous(set, ref codepoint);
	}

/// <summary>
/// <para>
/// Fetches the previous consecutive range of elements in @set that
/// are greater than current value of @last.
/// </para>
/// <para>
/// Set @first to #HB_SET_VALUE_INVALID to get started.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="first">
/// Input = The current first code point in the range
///         Output = The first code point in the range
/// </param>
/// <param name="last">
/// The last code point in the range
/// </param>
/// <return>
/// `true` if there was a previous range, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetPreviousRange(MentorLake.HarfBuzz.hb_set_tHandle set, ref MentorLake.HarfBuzz.hb_codepoint_t first, out MentorLake.HarfBuzz.hb_codepoint_t last)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_previous_range(set, ref first, out last);
	}

/// <summary>
/// <para>
/// Increases the reference count on a set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <return>
/// The set
/// </return>

	public static MentorLake.HarfBuzz.hb_set_tHandle SetReference(MentorLake.HarfBuzz.hb_set_tHandle set)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_reference(set);
	}

/// <summary>
/// <para>
/// Makes the contents of @set equal to the contents of @other.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="other">
/// Another set
/// </param>

	public static void SetSet(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_set(set, other);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="key">
/// The user-data key to set
/// </param>
/// <param name="data">
/// A pointer to the user data to set
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t SetSetUserData(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_set_set_user_data(set, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Subtracts the contents of @other from @set.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="other">
/// Another set
/// </param>

	public static void SetSubtract(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_subtract(set, other);
	}

/// <summary>
/// <para>
/// Makes @set the symmetric difference of @set
/// and @other.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="other">
/// Another set
/// </param>

	public static void SetSymmetricDifference(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_symmetric_difference(set, other);
	}

/// <summary>
/// <para>
/// Makes @set the union of @set and @other.
/// </para>
/// </summary>

/// <param name="set">
/// A set
/// </param>
/// <param name="other">
/// Another set
/// </param>

	public static void SetUnion(MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_set_tHandle other)
	{
		HarfBuzzGlobalFunctionsExterns.hb_set_union(set, other);
	}

/// <summary>
/// <para>
/// Shapes @buffer using @font turning its Unicode characters content to
/// positioned glyphs. If @features is not `NULL`, it will be used to control the
/// features applied during shaping. If two @features have the same tag but
/// overlapping ranges the value of the feature with the higher index takes
/// precedence.
/// </para>
/// </summary>

/// <param name="font">
/// an #hb_font_t to use for shaping
/// </param>
/// <param name="buffer">
/// an #hb_buffer_t to shape
/// </param>
/// <param name="features">
/// an array of user
///    specified #hb_feature_t or `NULL`
/// </param>
/// <param name="num_features">
/// the length of @features array
/// </param>

	public static void Shape(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features)
	{
		HarfBuzzGlobalFunctionsExterns.hb_shape(font, buffer, features, num_features);
	}

/// <summary>
/// <para>
/// See hb_shape() for details. If @shaper_list is not `NULL`, the specified
/// shapers will be used in the given order, otherwise the default shapers list
/// will be used.
/// </para>
/// </summary>

/// <param name="font">
/// an #hb_font_t to use for shaping
/// </param>
/// <param name="buffer">
/// an #hb_buffer_t to shape
/// </param>
/// <param name="features">
/// an array of user
///    specified #hb_feature_t or `NULL`
/// </param>
/// <param name="num_features">
/// the length of @features array
/// </param>
/// <param name="shaper_list">
/// a `NULL`-terminated
///    array of shapers to use or `NULL`
/// </param>
/// <return>
/// false if all shapers failed, true otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t ShapeFull(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_full(font, buffer, features, num_features, shaper_list);
	}

/// <summary>
/// <para>
/// See hb_shape_full() for basic details. If @shaper_list is not `NULL`, the specified
/// shapers will be used in the given order, otherwise the default shapers list
/// will be used.
/// </para>
/// <para>
/// In addition, justify the shaping results such that the shaping results reach
/// the target advance width/height, depending on the buffer direction.
/// </para>
/// <para>
/// If the advance of the buffer shaped with hb_shape_full() is already known,
/// put that in *advance. Otherwise set *advance to zero.
/// </para>
/// <para>
/// This API is currently experimental and will probably change in the future.
/// </para>
/// </summary>

/// <param name="font">
/// a mutable #hb_font_t to use for shaping
/// </param>
/// <param name="buffer">
/// an #hb_buffer_t to shape
/// </param>
/// <param name="features">
/// an array of user
///    specified #hb_feature_t or `NULL`
/// </param>
/// <param name="num_features">
/// the length of @features array
/// </param>
/// <param name="shaper_list">
/// a `NULL`-terminated
///    array of shapers to use or `NULL`
/// </param>
/// <param name="min_target_advance">
/// Minimum advance width/height to aim for.
/// </param>
/// <param name="max_target_advance">
/// Maximum advance width/height to aim for.
/// </param>
/// <param name="advance">
/// Input/output advance width/height of the buffer.
/// </param>
/// <param name="var_tag">
/// Variation-axis tag used for justification.
/// </param>
/// <param name="var_value">
/// Variation-axis value used to reach target justification.
/// </param>
/// <return>
/// false if all shapers failed, true otherwise
/// 
/// XSince: EXPERIMENTAL
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t ShapeJustify(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features, string[] shaper_list, float min_target_advance, float max_target_advance, ref float advance, out MentorLake.HarfBuzz.hb_tag_t var_tag, out float var_value)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_justify(font, buffer, features, num_features, shaper_list, min_target_advance, max_target_advance, ref advance, out var_tag, out var_value);
	}

/// <summary>
/// <para>
/// Retrieves the list of shapers supported by HarfBuzz.
/// </para>
/// </summary>

/// <return>
/// an array of
///    constant strings
/// </return>

	public static string[] ShapeListShapers()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_list_shapers();
	}

/// <summary>
/// <para>
/// Constructs a shaping plan for a combination of @face, @user_features, @props,
/// and @shaper_list.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to use
/// </param>
/// <param name="props">
/// The #hb_segment_properties_t of the segment
/// </param>
/// <param name="user_features">
/// The list of user-selected features
/// </param>
/// <param name="num_user_features">
/// The number of user-selected features
/// </param>
/// <param name="shaper_list">
/// List of shapers to try
/// </param>
/// <return>
/// The shaping plan
/// </return>

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanCreate(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_create(face, props, user_features, num_user_features, shaper_list);
	}

/// <summary>
/// <para>
/// The variable-font version of #hb_shape_plan_create.
/// Constructs a shaping plan for a combination of @face, @user_features, @props,
/// and @shaper_list, plus the variation-space coordinates @coords.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to use
/// </param>
/// <param name="props">
/// The #hb_segment_properties_t of the segment
/// </param>
/// <param name="user_features">
/// The list of user-selected features
/// </param>
/// <param name="num_user_features">
/// The number of user-selected features
/// </param>
/// <param name="coords">
/// The list of variation-space coordinates
/// </param>
/// <param name="num_coords">
/// The number of variation-space coordinates
/// </param>
/// <param name="shaper_list">
/// List of shapers to try
/// </param>
/// <return>
/// The shaping plan
/// </return>

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanCreate2(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, int[] coords, uint num_coords, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_create2(face, props, user_features, num_user_features, coords, num_coords, shaper_list);
	}

/// <summary>
/// <para>
/// Creates a cached shaping plan suitable for reuse, for a combination
/// of @face, @user_features, @props, and @shaper_list.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to use
/// </param>
/// <param name="props">
/// The #hb_segment_properties_t of the segment
/// </param>
/// <param name="user_features">
/// The list of user-selected features
/// </param>
/// <param name="num_user_features">
/// The number of user-selected features
/// </param>
/// <param name="shaper_list">
/// List of shapers to try
/// </param>
/// <return>
/// The shaping plan
/// </return>

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanCreateCached(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_create_cached(face, props, user_features, num_user_features, shaper_list);
	}

/// <summary>
/// <para>
/// The variable-font version of #hb_shape_plan_create_cached.
/// Creates a cached shaping plan suitable for reuse, for a combination
/// of @face, @user_features, @props, and @shaper_list, plus the
/// variation-space coordinates @coords.
/// </para>
/// </summary>

/// <param name="face">
/// #hb_face_t to use
/// </param>
/// <param name="props">
/// The #hb_segment_properties_t of the segment
/// </param>
/// <param name="user_features">
/// The list of user-selected features
/// </param>
/// <param name="num_user_features">
/// The number of user-selected features
/// </param>
/// <param name="coords">
/// The list of variation-space coordinates
/// </param>
/// <param name="num_coords">
/// The number of variation-space coordinates
/// </param>
/// <param name="shaper_list">
/// List of shapers to try
/// </param>
/// <return>
/// The shaping plan
/// </return>

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanCreateCached2(MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, int[] coords, uint num_coords, string[] shaper_list)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_create_cached2(face, props, user_features, num_user_features, coords, num_coords, shaper_list);
	}

/// <summary>
/// <para>
/// Decreases the reference count on the given shaping plan. When the
/// reference count reaches zero, the shaping plan is destroyed,
/// freeing all memory.
/// </para>
/// </summary>

/// <param name="shape_plan">
/// A shaping plan
/// </param>

	public static void ShapePlanDestroy(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan)
	{
		HarfBuzzGlobalFunctionsExterns.hb_shape_plan_destroy(shape_plan);
	}

/// <summary>
/// <para>
/// Executes the given shaping plan on the specified buffer, using
/// the given @font and @features.
/// </para>
/// </summary>

/// <param name="shape_plan">
/// A shaping plan
/// </param>
/// <param name="font">
/// The #hb_font_t to use
/// </param>
/// <param name="buffer">
/// The #hb_buffer_t to work upon
/// </param>
/// <param name="features">
/// Features to enable
/// </param>
/// <param name="num_features">
/// The number of features to enable
/// </param>
/// <return>
/// `true` if success, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t ShapePlanExecute(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_execute(shape_plan, font, buffer, features, num_features);
	}

/// <summary>
/// <para>
/// Fetches the singleton empty shaping plan.
/// </para>
/// </summary>

/// <return>
/// The empty shaping plan
/// </return>

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the shaper from a given shaping plan.
/// </para>
/// </summary>

/// <param name="shape_plan">
/// A shaping plan
/// </param>
/// <return>
/// The shaper
/// </return>

	public static string ShapePlanGetShaper(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_get_shaper(shape_plan);
	}

/// <summary>
/// <para>
/// Fetches the user data associated with the specified key,
/// attached to the specified shaping plan.
/// </para>
/// </summary>

/// <param name="shape_plan">
/// A shaping plan
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr ShapePlanGetUserData(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_get_user_data(shape_plan, key);
	}

/// <summary>
/// <para>
/// Increases the reference count on the given shaping plan.
/// </para>
/// </summary>

/// <param name="shape_plan">
/// A shaping plan
/// </param>
/// <return>
/// @shape_plan
/// </return>

	public static MentorLake.HarfBuzz.hb_shape_plan_tHandle ShapePlanReference(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_reference(shape_plan);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the given shaping plan.
/// </para>
/// </summary>

/// <param name="shape_plan">
/// A shaping plan
/// </param>
/// <param name="key">
/// The user-data key to set
/// </param>
/// <param name="data">
/// A pointer to the user data
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise.
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t ShapePlanSetUserData(MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_shape_plan_set_user_data(shape_plan, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Searches variation axes of a #hb_font_t object for a specific axis first,
/// if not set, then tries to get default style values from different
/// tables of the font.
/// </para>
/// </summary>

/// <param name="font">
/// a #hb_font_t object.
/// </param>
/// <param name="style_tag">
/// a style tag.
/// </param>
/// <return>
/// Corresponding axis or default value to a style tag.
/// </return>

	public static float StyleGetValue(MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_style_tag_t style_tag)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_style_get_value(font, style_tag);
	}

/// <summary>
/// <para>
/// Converts a string into an #hb_tag_t. Valid tags
/// are four characters. Shorter input strings will be
/// padded with spaces. Longer input strings will be
/// truncated.
/// </para>
/// </summary>

/// <param name="str">
/// String to convert
/// </param>
/// <param name="len">
/// Length of @str, or -1 if it is `NULL`-terminated
/// </param>
/// <return>
/// The #hb_tag_t corresponding to @str
/// </return>

	public static MentorLake.HarfBuzz.hb_tag_t TagFromString(byte[] str, int len)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_tag_from_string(str, len);
	}

/// <summary>
/// <para>
/// Converts an #hb_tag_t to a string and returns it in @buf.
/// Strings will be four characters long.
/// </para>
/// </summary>

/// <param name="tag">
/// #hb_tag_t to convert
/// </param>
/// <param name="buf">
/// Converted string
/// </param>

	public static void TagToString(MentorLake.HarfBuzz.hb_tag_t tag, out byte[] buf)
	{
		HarfBuzzGlobalFunctionsExterns.hb_tag_to_string(tag, out buf);
	}

/// <summary>
/// <para>
/// Retrieves the Canonical Combining Class (ccc) property
/// of code point @unicode.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="unicode">
/// The code point to query
/// </param>
/// <return>
/// The #hb_unicode_combining_class_t of @unicode
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_combining_class_t UnicodeCombiningClass(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_combining_class(ufuncs, unicode);
	}

/// <summary>
/// <para>
/// Fetches the composition of a sequence of two Unicode
/// code points.
/// </para>
/// <para>
/// Calls the composition function of the specified
/// Unicode-functions structure @ufuncs.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="a">
/// The first Unicode code point to compose
/// </param>
/// <param name="b">
/// The second Unicode code point to compose
/// </param>
/// <param name="ab">
/// The composition of @a, @b
/// </param>
/// <return>
/// `true` if @a and @b composed, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t UnicodeCompose(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t a, MentorLake.HarfBuzz.hb_codepoint_t b, out MentorLake.HarfBuzz.hb_codepoint_t ab)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_compose(ufuncs, a, b, out ab);
	}

/// <summary>
/// <para>
/// Fetches the decomposition of a Unicode code point.
/// </para>
/// <para>
/// Calls the decomposition function of the specified
/// Unicode-functions structure @ufuncs.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="ab">
/// Unicode code point to decompose
/// </param>
/// <param name="a">
/// The first code point of the decomposition of @ab
/// </param>
/// <param name="b">
/// The second code point of the decomposition of @ab
/// </param>
/// <return>
/// `true` if @ab was decomposed, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t UnicodeDecompose(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t ab, out MentorLake.HarfBuzz.hb_codepoint_t a, out MentorLake.HarfBuzz.hb_codepoint_t b)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_decompose(ufuncs, ab, out a, out b);
	}

/// <summary>
/// <para>
/// Fetches the compatibility decomposition of a Unicode
/// code point. Deprecated.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="u">
/// Code point to decompose
/// </param>
/// <param name="decomposed">
/// Compatibility decomposition of @u
/// </param>
/// <return>
/// length of @decomposed.
/// </return>

	public static uint UnicodeDecomposeCompatibility(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t u, out MentorLake.HarfBuzz.hb_codepoint_t decomposed)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_decompose_compatibility(ufuncs, u, out decomposed);
	}

/// <summary>
/// <para>
/// Don&apos;t use. Not used by HarfBuzz.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// a Unicode-function structure
/// </param>
/// <param name="unicode">
/// The code point to query
/// </param>

	public static uint UnicodeEastasianWidth(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_eastasian_width(ufuncs, unicode);
	}

/// <summary>
/// <para>
/// Creates a new #hb_unicode_funcs_t structure of Unicode functions.
/// </para>
/// </summary>

/// <param name="parent">
/// Parent Unicode-functions structure
/// </param>
/// <return>
/// The Unicode-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsCreate(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle parent)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_create(parent);
	}

/// <summary>
/// <para>
/// Decreases the reference count on a Unicode-functions structure. When
/// the reference count reaches zero, the Unicode-functions structure is
/// destroyed, freeing all memory.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>

	public static void UnicodeFuncsDestroy(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_destroy(ufuncs);
	}

/// <summary>
/// <para>
/// Fetches a pointer to the default Unicode-functions structure that is used
/// when no functions are explicitly set on #hb_buffer_t.
/// </para>
/// </summary>

/// <return>
/// a pointer to the #hb_unicode_funcs_t Unicode-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsGetDefault()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_get_default();
	}

/// <summary>
/// <para>
/// Fetches the singleton empty Unicode-functions structure.
/// </para>
/// </summary>

/// <return>
/// The empty Unicode-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsGetEmpty()
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_get_empty();
	}

/// <summary>
/// <para>
/// Fetches the parent of the Unicode-functions structure
/// @ufuncs.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <return>
/// The parent Unicode-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsGetParent(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_get_parent(ufuncs);
	}

/// <summary>
/// <para>
/// Fetches the user-data associated with the specified key,
/// attached to the specified Unicode-functions structure.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="key">
/// The user-data key to query
/// </param>
/// <return>
/// A pointer to the user data
/// </return>

	public static IntPtr UnicodeFuncsGetUserData(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_get_user_data(ufuncs, key);
	}

/// <summary>
/// <para>
/// Tests whether the specified Unicode-functions structure
/// is immutable.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <return>
/// `true` if @ufuncs is immutable, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t UnicodeFuncsIsImmutable(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_is_immutable(ufuncs);
	}

/// <summary>
/// <para>
/// Makes the specified Unicode-functions structure
/// immutable.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>

	public static void UnicodeFuncsMakeImmutable(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_make_immutable(ufuncs);
	}

/// <summary>
/// <para>
/// Increases the reference count on a Unicode-functions structure.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <return>
/// The Unicode-functions structure
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_funcs_tHandle UnicodeFuncsReference(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_reference(ufuncs);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_unicode_combining_class_func_t.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void UnicodeFuncsSetCombiningClassFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_combining_class_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_combining_class_func(ufuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_unicode_compose_func_t.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void UnicodeFuncsSetComposeFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_compose_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_compose_func(ufuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_unicode_decompose_compatibility_func_t.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void UnicodeFuncsSetDecomposeCompatibilityFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_decompose_compatibility_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_decompose_compatibility_func(ufuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_unicode_decompose_func_t.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void UnicodeFuncsSetDecomposeFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_decompose_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_decompose_func(ufuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_unicode_eastasian_width_func_t.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// a Unicode-function structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void UnicodeFuncsSetEastasianWidthFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_eastasian_width_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_eastasian_width_func(ufuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_unicode_general_category_func_t.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void UnicodeFuncsSetGeneralCategoryFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_general_category_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_general_category_func(ufuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_unicode_mirroring_func_t.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void UnicodeFuncsSetMirroringFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_mirroring_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_mirroring_func(ufuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Sets the implementation function for #hb_unicode_script_func_t.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="func">
/// The callback function to assign
/// </param>
/// <param name="user_data">
/// Data to pass to @func
/// </param>
/// <param name="destroy">
/// The function to call when @user_data is not needed anymore
/// </param>

	public static void UnicodeFuncsSetScriptFunc(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_unicode_script_func_t func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy)
	{
		HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_script_func(ufuncs, func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Attaches a user-data key/data pair to the specified Unicode-functions structure.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="key">
/// The user-data key
/// </param>
/// <param name="data">
/// A pointer to the user data
/// </param>
/// <param name="destroy">
/// A callback to call when @data is not needed anymore
/// </param>
/// <param name="replace">
/// Whether to replace an existing data with the same key
/// </param>
/// <return>
/// `true` if success, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t UnicodeFuncsSetUserData(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_funcs_set_user_data(ufuncs, key, data, destroy, replace);
	}

/// <summary>
/// <para>
/// Retrieves the General Category (gc) property
/// of code point @unicode.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="unicode">
/// The code point to query
/// </param>
/// <return>
/// The #hb_unicode_general_category_t of @unicode
/// </return>

	public static MentorLake.HarfBuzz.hb_unicode_general_category_t UnicodeGeneralCategory(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_general_category(ufuncs, unicode);
	}

/// <summary>
/// <para>
/// Retrieves the Bi-directional Mirroring Glyph code
/// point defined for code point @unicode.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="unicode">
/// The code point to query
/// </param>
/// <return>
/// The #hb_codepoint_t of the Mirroring Glyph for @unicode
/// </return>

	public static MentorLake.HarfBuzz.hb_codepoint_t UnicodeMirroring(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_mirroring(ufuncs, unicode);
	}

/// <summary>
/// <para>
/// Retrieves the #hb_script_t script to which code
/// point @unicode belongs.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// The Unicode-functions structure
/// </param>
/// <param name="unicode">
/// The code point to query
/// </param>
/// <return>
/// The #hb_script_t of @unicode
/// </return>

	public static MentorLake.HarfBuzz.hb_script_t UnicodeScript(MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_unicode_script(ufuncs, unicode);
	}

/// <summary>
/// <para>
/// Parses a string into a #hb_variation_t.
/// </para>
/// <para>
/// The format for specifying variation settings follows. All valid CSS
/// font-variation-settings values other than &apos;normal&apos; and &apos;inherited&apos; are also
/// accepted, though, not documented below.
/// </para>
/// <para>
/// The format is a tag, optionally followed by an equals sign, followed by a
/// number. For example `wght=500`, or `slnt=-7.5`.
/// </para>
/// </summary>

/// <param name="str">
/// a string to parse
/// </param>
/// <param name="len">
/// length of @str, or -1 if string is `NULL` terminated
/// </param>
/// <param name="variation">
/// the #hb_variation_t to initialize with the parsed values
/// </param>
/// <return>
/// `true` if @str is successfully parsed, `false` otherwise
/// </return>

	public static MentorLake.HarfBuzz.hb_bool_t VariationFromString(byte[] str, int len, out MentorLake.HarfBuzz.hb_variation_t variation)
	{
		return HarfBuzzGlobalFunctionsExterns.hb_variation_from_string(str, len, out variation);
	}

/// <summary>
/// <para>
/// Converts an #hb_variation_t into a `NULL`-terminated string in the format
/// understood by hb_variation_from_string(). The client in responsible for
/// allocating big enough size for @buf, 128 bytes is more than enough.
/// </para>
/// </summary>

/// <param name="variation">
/// an #hb_variation_t to convert
/// </param>
/// <param name="buf">
/// output string
/// </param>
/// <param name="size">
/// the allocated size of @buf
/// </param>

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
	internal static extern uint hb_aat_layout_feature_type_get_selector_infos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_aat_layout_feature_type_t feature_type, uint start_offset, out uint selector_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out MentorLake.HarfBuzz.hb_aat_layout_feature_selector_info_t[] selectors, out uint default_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_aat_layout_get_feature_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint feature_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.HarfBuzz.hb_aat_layout_feature_type_t[] features);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_aat_layout_has_positioning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_aat_layout_has_substitution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_aat_layout_has_tracking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_copy_writable_or_fail([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create(string data, uint length, MentorLake.HarfBuzz.hb_memory_mode_t mode, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create_from_file(string file_name);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create_from_file_or_fail(string file_name);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_blob_create_or_fail(string data, uint length, MentorLake.HarfBuzz.hb_memory_mode_t mode, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_buffer_tHandle hb_buffer_create();

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))]
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
	internal static extern uint hb_buffer_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out byte[] buf, out uint buf_size, out uint buf_consumed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_buffer_serialize_format_t hb_buffer_serialize_format_from_string(byte[] str, int len);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string hb_buffer_serialize_format_to_string(MentorLake.HarfBuzz.hb_buffer_serialize_format_t format);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_buffer_serialize_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out byte[] buf, out uint buf_size, out uint buf_consumed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] hb_buffer_serialize_list_formats();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_buffer_serialize_unicode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, uint start, uint end, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out byte[] buf, out uint buf_size, out uint buf_consumed, MentorLake.HarfBuzz.hb_buffer_serialize_format_t format, MentorLake.HarfBuzz.hb_buffer_serialize_flags_t flags);

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
	internal static extern uint hb_color_line_get_color_stops([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, uint start, out uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.HarfBuzz.hb_color_stop_t[] color_stops);

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_draw_funcs_tHandle hb_draw_funcs_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_draw_funcs_tHandle hb_draw_funcs_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_draw_funcs_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_draw_funcs_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_draw_funcs_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle blob, uint index);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_create_for_tables(MentorLake.HarfBuzz.hb_reference_table_func_t reference_table_func, IntPtr user_data, MentorLake.HarfBuzz.hb_destroy_func_t destroy);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_get_glyph_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_get_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_get_table_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint table_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.HarfBuzz.hb_tag_t[] table_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_face_get_upem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_face_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_face_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_face_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle hb_face_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_face_reference_blob([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
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
	internal static extern void hb_feature_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_feature_tHandle>))] MentorLake.HarfBuzz.hb_feature_tHandle feature, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out string[] buf, out uint size);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_add_glyph_origin_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, ref MentorLake.HarfBuzz.hb_position_t x, ref MentorLake.HarfBuzz.hb_position_t y);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle hb_font_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle hb_font_create_sub_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle parent);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_draw_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_font_funcs_tHandle hb_font_funcs_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_font_funcs_tHandle hb_font_funcs_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_font_funcs_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_funcs_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_funcs_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))] MentorLake.HarfBuzz.hb_font_funcs_tHandle ffuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_funcs_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_font_tHandle hb_font_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_get_extents_for_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, out MentorLake.HarfBuzz.hb_font_extents_t extents);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))]
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
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out string[] name, out uint size);

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))]
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
	internal static extern void hb_font_glyph_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out string[] s, out uint size);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_font_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_font_paint_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle pfuncs, IntPtr paint_data, uint palette_index, MentorLake.HarfBuzz.hb_color_t foreground);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_glib_blob_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle gbytes);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_map_tHandle hb_map_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_map_tHandle hb_map_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_del([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_map_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_codepoint_t hb_map_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))] MentorLake.HarfBuzz.hb_map_tHandle map, MentorLake.HarfBuzz.hb_codepoint_t key);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_map_tHandle>))]
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
	internal static extern uint hb_ot_color_glyph_get_layers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint layer_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out MentorLake.HarfBuzz.hb_ot_color_layer_t[] layers);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_color_glyph_has_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_blob_tHandle hb_ot_color_glyph_reference_png([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
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
	internal static extern uint hb_ot_color_palette_get_colors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint palette_index, uint start_offset, out uint color_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out MentorLake.HarfBuzz.hb_color_t[] colors);

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
	internal static extern uint hb_ot_layout_feature_get_characters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint start_offset, out uint char_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.HarfBuzz.hb_codepoint_t[] characters);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_feature_get_lookups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint start_offset, out uint lookup_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out uint[] lookup_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_feature_get_name_ids([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, out MentorLake.HarfBuzz.hb_ot_name_id_t label_id, out MentorLake.HarfBuzz.hb_ot_name_id_t tooltip_id, out MentorLake.HarfBuzz.hb_ot_name_id_t sample_id, out uint num_named_parameters, out MentorLake.HarfBuzz.hb_ot_name_id_t first_param_id);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_feature_with_variations_get_lookups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint feature_index, uint variations_index, uint start_offset, out uint lookup_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out uint[] lookup_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_get_attach_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint point_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out uint[] point_array);

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
	internal static extern uint hb_ot_layout_get_ligature_carets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint caret_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.HarfBuzz.hb_position_t[] caret_array);

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
	internal static extern uint hb_ot_layout_language_get_feature_indexes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, uint start_offset, out uint feature_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out uint[] feature_indexes);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_language_get_feature_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, uint start_offset, out uint feature_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out MentorLake.HarfBuzz.hb_tag_t[] feature_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_language_get_required_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out uint feature_index, out MentorLake.HarfBuzz.hb_tag_t feature_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_language_get_required_feature_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint language_index, out uint feature_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_layout_lookup_collect_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint lookup_index, out MentorLake.HarfBuzz.hb_set_t glyphs_before, out MentorLake.HarfBuzz.hb_set_t glyphs_input, out MentorLake.HarfBuzz.hb_set_t glyphs_after, out MentorLake.HarfBuzz.hb_set_t glyphs_output);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_lookup_get_glyph_alternates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint lookup_index, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint start_offset, out uint alternate_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.HarfBuzz.hb_codepoint_t[] alternate_glyphs);

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
	internal static extern uint hb_ot_layout_script_get_language_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_index, uint start_offset, out uint language_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.HarfBuzz.hb_tag_t[] language_tags);

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
	internal static extern uint hb_ot_layout_table_get_feature_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint start_offset, out uint feature_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out MentorLake.HarfBuzz.hb_tag_t[] feature_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_table_get_lookup_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_layout_table_get_script_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint start_offset, out uint script_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out MentorLake.HarfBuzz.hb_tag_t[] script_tags);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_layout_table_select_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t table_tag, uint script_count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_tag_tHandle>))] MentorLake.HarfBuzz.hb_tag_tHandle script_tags, out uint script_index, out MentorLake.HarfBuzz.hb_tag_t chosen_script);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_constant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_ot_math_constant_t constant);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_math_get_glyph_assembly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, uint start_offset, out uint parts_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.HarfBuzz.hb_ot_math_glyph_part_t[] parts, out MentorLake.HarfBuzz.hb_position_t italics_correction);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_glyph_italics_correction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_glyph_kerning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_ot_math_kern_t kern, MentorLake.HarfBuzz.hb_position_t correction_height);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_math_get_glyph_kernings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_ot_math_kern_t kern, uint start_offset, out uint entries_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.HarfBuzz.hb_ot_math_kern_entry_t[] kern_entries);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_glyph_top_accent_attachment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_math_get_glyph_variants([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_codepoint_t glyph, MentorLake.HarfBuzz.hb_direction_t direction, uint start_offset, out uint variants_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.HarfBuzz.hb_ot_math_glyph_variant_t[] variants);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_position_t hb_ot_math_get_min_connector_overlap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_direction_t direction);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_math_has_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_math_is_glyph_extended_shape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_codepoint_t glyph);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_meta_get_entry_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint entries_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.HarfBuzz.hb_ot_meta_tag_t[] entries);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))]
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
	internal static extern uint hb_ot_name_get_utf16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out ushort[] text);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_name_get_utf32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out uint[] text);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_name_get_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_ot_name_id_t name_id, MentorLake.HarfBuzz.hb_language_t language, out uint text_size, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out string[] text);

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
	internal static extern uint hb_ot_var_get_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint axes_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.HarfBuzz.hb_ot_var_axis_t[] axes_array);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_get_axis_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_get_axis_infos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint start_offset, out uint axes_count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.HarfBuzz.hb_ot_var_axis_info_t[] axes_array);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_get_named_instance_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_ot_var_has_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern uint hb_ot_var_named_instance_get_design_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index, out uint coords_length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out float[] coords);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_name_id_t hb_ot_var_named_instance_get_postscript_name_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_ot_name_id_t hb_ot_var_named_instance_get_subfamily_name_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint instance_index);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_var_normalize_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, uint coords_length, float design_coords, out int normalized_coords);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_ot_var_normalize_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_variation_tHandle>))] MentorLake.HarfBuzz.hb_variation_tHandle variations, uint variations_length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out int[] coords, out uint coords_length);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_bool_t is_foreground, MentorLake.HarfBuzz.hb_color_t color);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_paint_color_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_paint_custom_palette_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, uint color_index, out MentorLake.HarfBuzz.hb_color_t color);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_paint_funcs_tHandle hb_paint_funcs_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_paint_funcs_tHandle hb_paint_funcs_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_paint_funcs_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_paint_funcs_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_paint_funcs_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_set_tHandle hb_set_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_set_tHandle hb_set_create();

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_del([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t codepoint);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_del_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set, MentorLake.HarfBuzz.hb_codepoint_t first, MentorLake.HarfBuzz.hb_codepoint_t last);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_set_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))] MentorLake.HarfBuzz.hb_set_tHandle set);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_set_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_create2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, int[] coords, uint num_coords, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_create_cached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_create_cached2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_segment_properties_tHandle>))] MentorLake.HarfBuzz.hb_segment_properties_tHandle props, MentorLake.HarfBuzz.hb_feature_t[] user_features, uint num_user_features, int[] coords, uint num_coords, string[] shaper_list);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_shape_plan_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_shape_plan_execute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, MentorLake.HarfBuzz.hb_feature_t[] features, uint num_features);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string hb_shape_plan_get_shaper([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_shape_plan_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_shape_plan_tHandle hb_shape_plan_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_shape_plan_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_shape_plan_tHandle>))] MentorLake.HarfBuzz.hb_shape_plan_tHandle shape_plan, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key, IntPtr data, MentorLake.HarfBuzz.hb_destroy_func_t destroy, MentorLake.HarfBuzz.hb_bool_t replace);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern float hb_style_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, MentorLake.HarfBuzz.hb_style_tag_t style_tag);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_tag_t hb_tag_from_string(byte[] str, int len);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_tag_to_string(MentorLake.HarfBuzz.hb_tag_t tag, [MarshalAs(UnmanagedType.LPArray)] out byte[] buf);

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle parent);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_get_default();

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_get_empty();

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_unicode_funcs_tHandle hb_unicode_funcs_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern IntPtr hb_unicode_funcs_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_user_data_key_tHandle>))] MentorLake.HarfBuzz.hb_user_data_key_tHandle key);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern MentorLake.HarfBuzz.hb_bool_t hb_unicode_funcs_is_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_unicode_funcs_make_immutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs);

	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))]
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
	internal static extern void hb_variation_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_variation_tHandle>))] MentorLake.HarfBuzz.hb_variation_tHandle variation, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out string[] buf, out uint size);

}
