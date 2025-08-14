namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_user_scaled_font_text_to_glyphs_func_t is the type of function which
/// is called to convert input text to an array of glyphs.  This is used by the
/// cairo_show_text() operation.
/// </para>
/// <para>
/// Using this callback the user-font has full control on glyphs and their
/// positions.  That means, it allows for features like ligatures and kerning,
/// as well as complex <firstterm>shaping</firstterm> required for scripts like
/// Arabic and Indic.
/// </para>
/// <para>
/// The @num_glyphs argument is preset to the number of glyph entries available
/// in the @glyphs buffer. If the @glyphs buffer is %NULL, the value of
/// @num_glyphs will be zero.  If the provided glyph array is too short for
/// the conversion (or for convenience), a new glyph array may be allocated
/// using cairo_glyph_allocate() and placed in @glyphs.  Upon return,
/// @num_glyphs should contain the number of generated glyphs.  If the value
/// @glyphs points at has changed after the call, the caller will free the
/// allocated glyph array using cairo_glyph_free().  The caller will also free
/// the original value of @glyphs, so the callback shouldn't do so.
/// The callback should populate the glyph indices and positions (in font space)
/// assuming that the text is to be shown at the origin.
/// </para>
/// <para>
/// If @clusters is not %NULL, @num_clusters and @cluster_flags are also
/// non-%NULL, and cluster mapping should be computed. The semantics of how
/// cluster array allocation works is similar to the glyph array.  That is,
/// if @clusters initially points to a non-%NULL value, that array may be used
/// as a cluster buffer, and @num_clusters points to the number of cluster
/// entries available there.  If the provided cluster array is too short for
/// the conversion (or for convenience), a new cluster array may be allocated
/// using cairo_text_cluster_allocate() and placed in @clusters.  In this case,
/// the original value of @clusters will still be freed by the caller.  Upon
/// return, @num_clusters should contain the number of generated clusters.
/// If the value @clusters points at has changed after the call, the caller
/// will free the allocated cluster array using cairo_text_cluster_free().
/// </para>
/// <para>
/// The callback is optional.  If @num_glyphs is negative upon
/// the callback returning or if the return value
/// is %CAIRO_STATUS_USER_FONT_NOT_IMPLEMENTED, the unicode_to_glyph callback
/// is tried.  See #cairo_user_scaled_font_unicode_to_glyph_func_t.
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
/// <param name="utf8">
/// a string of text encoded in UTF-8
/// </param>
/// <param name="utf8_len">
/// length of @utf8 in bytes
/// </param>
/// <param name="glyphs">
/// pointer to array of glyphs to fill, in font space
/// </param>
/// <param name="num_glyphs">
/// pointer to number of glyphs
/// </param>
/// <param name="clusters">
/// pointer to array of cluster mapping information to fill, or %NULL
/// </param>
/// <param name="num_clusters">
/// pointer to number of clusters
/// </param>
/// <param name="cluster_flags">
/// pointer to location to store cluster flags corresponding to the
///                 output @clusters
/// </param>
/// <return>
/// %CAIRO_STATUS_SUCCESS upon success,
/// %CAIRO_STATUS_USER_FONT_NOT_IMPLEMENTED if fallback options should be tried,
/// or %CAIRO_STATUS_USER_FONT_ERROR or any other error status on error.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_user_scaled_font_text_to_glyphs_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, string utf8, int utf8_len, IntPtr glyphs, int num_glyphs, IntPtr clusters, int num_clusters, out MentorLake.cairo.cairo_text_cluster_flags_t cluster_flags);
