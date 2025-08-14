namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="font_data">
/// @font user data pointer
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="draw_funcs">
/// The draw functions to send the shape data to
/// </param>
/// <param name="draw_data">
/// The data accompanying the draw functions
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_font_get_glyph_shape_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle draw_funcs, IntPtr draw_data, IntPtr user_data);
