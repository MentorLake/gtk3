namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// <para>
/// This method should retrieve the nominal glyph IDs for a sequence of
/// Unicode code points. Glyph IDs must be returned in a #hb_codepoint_t
/// output parameter.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="font_data">
/// @font user data pointer
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
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>
/// <return>
/// the number of code points processed
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate uint hb_font_get_nominal_glyphs_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle first_unicode, uint unicode_stride, out MentorLake.HarfBuzz.hb_codepoint_t first_glyph, uint glyph_stride, IntPtr user_data);
