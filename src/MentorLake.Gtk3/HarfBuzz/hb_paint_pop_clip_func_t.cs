namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to undo
/// the effect of a prior call to the #hb_paint_funcs_push_clip_glyph_func_t
/// or #hb_paint_funcs_push_clip_rectangle_func_t vfuncs.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions object
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions in hb_font_paint_glyph()
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_pop_clip_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_paint_pop_clip_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, IntPtr user_data);
