namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to clip
/// subsequent paint calls to the outline of a glyph.
/// </para>
/// <para>
/// The coordinates of the glyph outline are interpreted according
/// to the current transform.
/// </para>
/// <para>
/// This clip is applied in addition to the current clip,
/// and remains in effect until a matching call to
/// the #hb_paint_funcs_pop_clip_func_t vfunc.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions object
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions in hb_font_paint_glyph()
/// </param>
/// <param name="glyph">
/// the glyph ID
/// </param>
/// <param name="font">
/// the font
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_push_clip_glyph_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_paint_push_clip_glyph_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr user_data);
