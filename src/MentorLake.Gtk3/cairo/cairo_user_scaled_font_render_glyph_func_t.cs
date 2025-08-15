namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_user_scaled_font_render_glyph_func_t is the type of function which
/// is called when a user scaled-font needs to render a glyph.
/// </para>
/// <para>
/// The callback is mandatory, and expected to draw the glyph with code @glyph to
/// the cairo context @cr.  @cr is prepared such that the glyph drawing is done in
/// font space.  That is, the matrix set on @cr is the scale matrix of @scaled_font,
/// The @extents argument is where the user font sets the font extents for
/// @scaled_font.  However, if user prefers to draw in user space, they can
/// achieve that by changing the matrix on @cr.  All cairo rendering operations
/// to @cr are permitted, however, the result is undefined if any source other
/// than the default source on @cr is used.  That means, glyph bitmaps should
/// be rendered using cairo_mask() instead of cairo_paint().
/// </para>
/// <para>
/// Other non-default settings on @cr include a font size of 1.0 (given that
/// it is set up to be in font space), and font options corresponding to
/// @scaled_font.
/// </para>
/// <para>
/// The @extents argument is preset to have &amp;lt;literal&amp;gt;x_bearing&amp;lt;/literal&amp;gt;,
/// &amp;lt;literal&amp;gt;width&amp;lt;/literal&amp;gt;, and &amp;lt;literal&amp;gt;y_advance&amp;lt;/literal&amp;gt; of zero,
/// &amp;lt;literal&amp;gt;y_bearing&amp;lt;/literal&amp;gt; set to &amp;lt;literal&amp;gt;-font_extents.ascent&amp;lt;/literal&amp;gt;,
/// &amp;lt;literal&amp;gt;height&amp;lt;/literal&amp;gt; to &amp;lt;literal&amp;gt;font_extents.ascent+font_extents.descent&amp;lt;/literal&amp;gt;,
/// and &amp;lt;literal&amp;gt;x_advance&amp;lt;/literal&amp;gt; to &amp;lt;literal&amp;gt;font_extents.max_x_advance&amp;lt;/literal&amp;gt;.
/// The only field user needs to set in majority of cases is
/// &amp;lt;literal&amp;gt;x_advance&amp;lt;/literal&amp;gt;.
/// If the &amp;lt;literal&amp;gt;width&amp;lt;/literal&amp;gt; field is zero upon the callback returning
/// (which is its preset value), the glyph extents are automatically computed
/// based on the drawings done to @cr.  This is in most cases exactly what the
/// desired behavior is.  However, if for any reason the callback sets the
/// extents, it must be ink extents, and include the extents of all drawing
/// done to @cr in the callback.
/// </para>
/// </summary>

/// <param name="scaled_font">
/// user scaled-font
/// </param>
/// <param name="glyph">
/// glyph code to render
/// </param>
/// <param name="cr">
/// cairo context to draw to, in font space
/// </param>
/// <param name="extents">
/// glyph extents to fill in, in font space
/// </param>
/// <return>
/// %CAIRO_STATUS_SUCCESS upon success, or
/// %CAIRO_STATUS_USER_FONT_ERROR or any other error status on error.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_user_scaled_font_render_glyph_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, ulong glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_text_extents_tHandle>))] MentorLake.cairo.cairo_text_extents_tHandle extents);
