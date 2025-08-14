namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// <para>
/// This method should retrieve the glyph ID for a specified Unicode code point
/// font, with an optional variation selector.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="font_data">
/// @font user data pointer
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
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_codepoint_t unicode, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_codepoint_t glyph, IntPtr user_data);
