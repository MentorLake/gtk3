namespace MentorLake.Gtk3.Cairo;

public enum cairo_status_t : uint
{
	CAIRO_STATUS_SUCCESS = 0,
	CAIRO_STATUS_NO_MEMORY,
	CAIRO_STATUS_INVALID_RESTORE,
	CAIRO_STATUS_INVALID_POP_GROUP,
	CAIRO_STATUS_NO_CURRENT_POINT,
	CAIRO_STATUS_INVALID_MATRIX,
	CAIRO_STATUS_INVALID_STATUS,
	CAIRO_STATUS_NULL_POINTER,
	CAIRO_STATUS_INVALID_STRING,
	CAIRO_STATUS_INVALID_PATH_DATA,
	CAIRO_STATUS_READ_ERROR,
	CAIRO_STATUS_WRITE_ERROR,
	CAIRO_STATUS_SURFACE_FINISHED,
	CAIRO_STATUS_SURFACE_TYPE_MISMATCH,
	CAIRO_STATUS_PATTERN_TYPE_MISMATCH,
	CAIRO_STATUS_INVALID_CONTENT,
	CAIRO_STATUS_INVALID_FORMAT,
	CAIRO_STATUS_INVALID_VISUAL,
	CAIRO_STATUS_FILE_NOT_FOUND,
	CAIRO_STATUS_INVALID_DASH,
	CAIRO_STATUS_INVALID_DSC_COMMENT,
	CAIRO_STATUS_INVALID_INDEX,
	CAIRO_STATUS_CLIP_NOT_REPRESENTABLE,
	CAIRO_STATUS_TEMP_FILE_ERROR,
	CAIRO_STATUS_INVALID_STRIDE,
	CAIRO_STATUS_FONT_TYPE_MISMATCH,
	CAIRO_STATUS_USER_FONT_IMMUTABLE,
	CAIRO_STATUS_USER_FONT_ERROR,
	CAIRO_STATUS_NEGATIVE_COUNT,
	CAIRO_STATUS_INVALID_CLUSTERS,
	CAIRO_STATUS_INVALID_SLANT,
	CAIRO_STATUS_INVALID_WEIGHT,
	CAIRO_STATUS_INVALID_SIZE,
	CAIRO_STATUS_USER_FONT_NOT_IMPLEMENTED,
	CAIRO_STATUS_DEVICE_TYPE_MISMATCH,
	CAIRO_STATUS_DEVICE_ERROR,
	CAIRO_STATUS_INVALID_MESH_CONSTRUCTION,
	CAIRO_STATUS_DEVICE_FINISHED,
	CAIRO_STATUS_JBIG2_GLOBAL_MISSING,
	CAIRO_STATUS_PNG_ERROR,
	CAIRO_STATUS_FREETYPE_ERROR,
	CAIRO_STATUS_WIN32_GDI_ERROR,
	CAIRO_STATUS_TAG_ERROR,
	CAIRO_STATUS_LAST_STATUS
}
