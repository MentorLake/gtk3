namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_user_scaled_font_unicode_to_glyph_func_t is the type of function which
/// is called to convert an input Unicode character to a single glyph.
/// This is used by the cairo_show_text() operation.
/// </para>
/// <para>
/// This callback is used to provide the same functionality as the
/// text_to_glyphs callback does (see #cairo_user_scaled_font_text_to_glyphs_func_t)
/// but has much less control on the output,
/// in exchange for increased ease of use.  The inherent assumption to using
/// this callback is that each character maps to one glyph, and that the
/// mapping is context independent.  It also assumes that glyphs are positioned
/// according to their advance width.  These mean no ligatures, kerning, or
/// complex scripts can be implemented using this callback.
/// </para>
/// <para>
/// The callback is optional, and only used if text_to_glyphs callback is not
/// set or fails to return glyphs.  If this callback is not set or if it returns
/// %CAIRO_STATUS_USER_FONT_NOT_IMPLEMENTED, an identity mapping from Unicode
/// code-points to glyph indices is assumed.
/// </para>
/// <para>
/// Note: While cairo does not impose any limitation on glyph indices,
/// some applications may assume that a glyph index fits in a 16-bit
/// unsigned integer.  As such, it is advised that user-fonts keep their
/// glyphs in the 0 to 65535 range.  Furthermore, some applications may
/// assume that glyph 0 is a special glyph-not-found glyph.  User-fonts
/// are advised to use glyph 0 for such purposes and do not use that
/// glyph value for other purposes.
/// </para>
/// </summary>

/// <param name="scaled_font">
/// the scaled-font being created
/// </param>
/// <param name="unicode">
/// input unicode character code-point
/// </param>
/// <param name="glyph_index">
/// output glyph index
/// </param>
/// <return>
/// %CAIRO_STATUS_SUCCESS upon success,
/// %CAIRO_STATUS_USER_FONT_NOT_IMPLEMENTED if fallback options should be tried,
/// or %CAIRO_STATUS_USER_FONT_ERROR or any other error status on error.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_user_scaled_font_unicode_to_glyph_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, ulong unicode, ulong glyph_index);
