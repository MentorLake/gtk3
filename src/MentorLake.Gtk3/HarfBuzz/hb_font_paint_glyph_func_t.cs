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
/// <param name="paint_funcs">
/// The paint functions to use
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions
/// </param>
/// <param name="palette_index">
/// The color palette to use
/// </param>
/// <param name="foreground">
/// The foreground color
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_font_paint_glyph_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle paint_funcs, IntPtr paint_data, uint palette_index, MentorLake.HarfBuzz.hb_color_t foreground, IntPtr user_data);
