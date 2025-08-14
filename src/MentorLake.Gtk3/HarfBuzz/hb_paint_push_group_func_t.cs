namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to use
/// an intermediate surface for subsequent paint calls.
/// </para>
/// <para>
/// The drawing will be redirected to an intermediate surface
/// until a matching call to the #hb_paint_funcs_pop_group_func_t
/// vfunc.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions object
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions in hb_font_paint_glyph()
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_push_group_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_paint_push_group_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, IntPtr user_data);
