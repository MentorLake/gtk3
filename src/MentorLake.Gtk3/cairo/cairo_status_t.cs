namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_status_t is used to indicate errors that can occur when
/// using Cairo. In some cases it is returned directly by functions.
/// but when using #cairo_t, the last error, if any, is stored in
/// the context and can be retrieved with cairo_status().
/// </para>
/// <para>
/// New entries may be added in future versions.  Use cairo_status_to_string()
/// to get a human-readable representation of an error message.
/// </para>
/// </summary>

[Flags]
public enum cairo_status_t
{
/// <summary>
/// <para>
/// no error has occurred (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_SUCCESS = 0,
/// <summary>
/// <para>
/// out of memory (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_NO_MEMORY = 1,
/// <summary>
/// <para>
/// cairo_restore() called without matching cairo_save() (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_RESTORE = 2,
/// <summary>
/// <para>
/// no saved group to pop, i.e. cairo_pop_group() without matching cairo_push_group() (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_POP_GROUP = 3,
/// <summary>
/// <para>
/// no current point defined (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_NO_CURRENT_POINT = 4,
/// <summary>
/// <para>
/// invalid matrix (not invertible) (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_MATRIX = 5,
/// <summary>
/// <para>
/// invalid value for an input #cairo_status_t (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_STATUS = 6,
/// <summary>
/// <para>
/// %NULL pointer (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_NULL_POINTER = 7,
/// <summary>
/// <para>
/// input string not valid UTF-8 (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_STRING = 8,
/// <summary>
/// <para>
/// input path data not valid (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_PATH_DATA = 9,
/// <summary>
/// <para>
/// error while reading from input stream (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_READ_ERROR = 10,
/// <summary>
/// <para>
/// error while writing to output stream (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_WRITE_ERROR = 11,
/// <summary>
/// <para>
/// target surface has been finished (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_SURFACE_FINISHED = 12,
/// <summary>
/// <para>
/// the surface type is not appropriate for the operation (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_SURFACE_TYPE_MISMATCH = 13,
/// <summary>
/// <para>
/// the pattern type is not appropriate for the operation (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_PATTERN_TYPE_MISMATCH = 14,
/// <summary>
/// <para>
/// invalid value for an input #cairo_content_t (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_CONTENT = 15,
/// <summary>
/// <para>
/// invalid value for an input #cairo_format_t (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_FORMAT = 16,
/// <summary>
/// <para>
/// invalid value for an input Visual* (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_VISUAL = 17,
/// <summary>
/// <para>
/// file not found (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_FILE_NOT_FOUND = 18,
/// <summary>
/// <para>
/// invalid value for a dash setting (Since 1.0)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_DASH = 19,
/// <summary>
/// <para>
/// invalid value for a DSC comment (Since 1.2)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_DSC_COMMENT = 20,
/// <summary>
/// <para>
/// invalid index passed to getter (Since 1.4)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_INDEX = 21,
/// <summary>
/// <para>
/// clip region not representable in desired format (Since 1.4)
/// </para>
/// </summary>

	CAIRO_STATUS_CLIP_NOT_REPRESENTABLE = 22,
/// <summary>
/// <para>
/// error creating or writing to a temporary file (Since 1.6)
/// </para>
/// </summary>

	CAIRO_STATUS_TEMP_FILE_ERROR = 23,
/// <summary>
/// <para>
/// invalid value for stride (Since 1.6)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_STRIDE = 24,
/// <summary>
/// <para>
/// the font type is not appropriate for the operation (Since 1.8)
/// </para>
/// </summary>

	CAIRO_STATUS_FONT_TYPE_MISMATCH = 25,
/// <summary>
/// <para>
/// the user-font is immutable (Since 1.8)
/// </para>
/// </summary>

	CAIRO_STATUS_USER_FONT_IMMUTABLE = 26,
/// <summary>
/// <para>
/// error occurred in a user-font callback function (Since 1.8)
/// </para>
/// </summary>

	CAIRO_STATUS_USER_FONT_ERROR = 27,
/// <summary>
/// <para>
/// negative number used where it is not allowed (Since 1.8)
/// </para>
/// </summary>

	CAIRO_STATUS_NEGATIVE_COUNT = 28,
/// <summary>
/// <para>
/// input clusters do not represent the accompanying text and glyph array (Since 1.8)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_CLUSTERS = 29,
/// <summary>
/// <para>
/// invalid value for an input #cairo_font_slant_t (Since 1.8)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_SLANT = 30,
/// <summary>
/// <para>
/// invalid value for an input #cairo_font_weight_t (Since 1.8)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_WEIGHT = 31,
/// <summary>
/// <para>
/// invalid value (typically too big) for the size of the input (surface, pattern, etc.) (Since 1.10)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_SIZE = 32,
/// <summary>
/// <para>
/// user-font method not implemented (Since 1.10)
/// </para>
/// </summary>

	CAIRO_STATUS_USER_FONT_NOT_IMPLEMENTED = 33,
/// <summary>
/// <para>
/// the device type is not appropriate for the operation (Since 1.10)
/// </para>
/// </summary>

	CAIRO_STATUS_DEVICE_TYPE_MISMATCH = 34,
/// <summary>
/// <para>
/// an operation to the device caused an unspecified error (Since 1.10)
/// </para>
/// </summary>

	CAIRO_STATUS_DEVICE_ERROR = 35,
/// <summary>
/// <para>
/// a mesh pattern
///   construction operation was used outside of a
///   cairo_mesh_pattern_begin_patch()/cairo_mesh_pattern_end_patch()
///   pair (Since 1.12)
/// </para>
/// </summary>

	CAIRO_STATUS_INVALID_MESH_CONSTRUCTION = 36,
/// <summary>
/// <para>
/// target device has been finished (Since 1.12)
/// </para>
/// </summary>

	CAIRO_STATUS_DEVICE_FINISHED = 37,
/// <summary>
/// <para>
/// %CAIRO_MIME_TYPE_JBIG2_GLOBAL_ID has been used on at least one image
///   but no image provided %CAIRO_MIME_TYPE_JBIG2_GLOBAL (Since 1.14)
/// </para>
/// </summary>

	CAIRO_STATUS_JBIG2_GLOBAL_MISSING = 38,
/// <summary>
/// <para>
/// error occurred in libpng while reading from or writing to a PNG file (Since 1.16)
/// </para>
/// </summary>

	CAIRO_STATUS_PNG_ERROR = 39,
/// <summary>
/// <para>
/// error occurred in libfreetype (Since 1.16)
/// </para>
/// </summary>

	CAIRO_STATUS_FREETYPE_ERROR = 40,
/// <summary>
/// <para>
/// error occurred in the Windows Graphics Device Interface (Since 1.16)
/// </para>
/// </summary>

	CAIRO_STATUS_WIN32_GDI_ERROR = 41,
/// <summary>
/// <para>
/// invalid tag name, attributes, or nesting (Since 1.16)
/// </para>
/// </summary>

	CAIRO_STATUS_TAG_ERROR = 42,
/// <summary>
/// <para>
/// this is a special value indicating the number of
///   status values defined in this enumeration.  When using this value, note
///   that the version of cairo at run-time may have additional status values
///   defined than the value of this symbol at compile-time. (Since 1.10)
/// </para>
/// </summary>

	CAIRO_STATUS_LAST_STATUS = 43
}
