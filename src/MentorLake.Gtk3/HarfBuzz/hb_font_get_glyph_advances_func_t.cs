namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// <para>
/// This method should retrieve the advances for a sequence of glyphs.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="font_data">
/// @font user data pointer
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
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_font_get_glyph_advances_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle first_glyph, uint glyph_stride, out MentorLake.HarfBuzz.hb_position_t first_advance, uint advance_stride, IntPtr user_data);
