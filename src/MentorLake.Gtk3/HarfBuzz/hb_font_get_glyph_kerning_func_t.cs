namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// This method should retrieve the kerning-adjustment value for a glyph-pair in
/// the specified font, for horizontal text segments.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="font_data">
/// @font user data pointer
/// </param>
/// <param name="first_glyph">
/// The glyph ID of the first glyph in the glyph pair
/// </param>
/// <param name="second_glyph">
/// The glyph ID of the second glyph in the glyph pair
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_position_t hb_font_get_glyph_kerning_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_codepoint_t first_glyph, MentorLake.HarfBuzz.hb_codepoint_t second_glyph, IntPtr user_data);
