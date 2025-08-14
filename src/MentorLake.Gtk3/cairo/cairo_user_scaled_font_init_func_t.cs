namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_user_scaled_font_init_func_t is the type of function which is
/// called when a scaled-font needs to be created for a user font-face.
/// </para>
/// <para>
/// The cairo context @cr is not used by the caller, but is prepared in font
/// space, similar to what the cairo contexts passed to the render_glyph
/// method will look like.  The callback can use this context for extents
/// computation for example.  After the callback is called, @cr is checked
/// for any error status.
/// </para>
/// <para>
/// The @extents argument is where the user font sets the font extents for
/// @scaled_font.  It is in font space, which means that for most cases its
/// ascent and descent members should add to 1.0.  @extents is preset to
/// hold a value of 1.0 for ascent, height, and max_x_advance, and 0.0 for
/// descent and max_y_advance members.
/// </para>
/// <para>
/// The callback is optional.  If not set, default font extents as described
/// in the previous paragraph will be used.
/// </para>
/// <para>
/// Note that @scaled_font is not fully initialized at this
/// point and trying to use it for text operations in the callback will result
/// in deadlock.
/// </para>
/// </summary>

/// <param name="scaled_font">
/// the scaled-font being created
/// </param>
/// <param name="cr">
/// a cairo context, in font space
/// </param>
/// <param name="extents">
/// font extents to fill in, in font space
/// </param>
/// <return>
/// %CAIRO_STATUS_SUCCESS upon success, or an error status on error.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_user_scaled_font_init_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_extents_tHandle>))] MentorLake.cairo.cairo_font_extents_tHandle extents);
