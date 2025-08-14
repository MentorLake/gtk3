namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to clip
/// subsequent paint calls to a rectangle.
/// </para>
/// <para>
/// The coordinates of the rectangle are interpreted according
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
/// <param name="xmin">
/// min X for the rectangle
/// </param>
/// <param name="ymin">
/// min Y for the rectangle
/// </param>
/// <param name="xmax">
/// max X for the rectangle
/// </param>
/// <param name="ymax">
/// max Y for the rectangle
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_push_clip_rectangle_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_paint_push_clip_rectangle_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, float xmin, float ymin, float xmax, float ymax, IntPtr user_data);
