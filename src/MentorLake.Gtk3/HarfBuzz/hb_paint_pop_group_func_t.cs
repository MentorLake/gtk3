namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to undo
/// the effect of a prior call to the #hb_paint_funcs_push_group_func_t
/// vfunc.
/// </para>
/// <para>
/// This call stops the redirection to the intermediate surface,
/// and then composites it on the previous surface, using the
/// compositing mode passed to this call.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions object
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions in hb_font_paint_glyph()
/// </param>
/// <param name="mode">
/// the compositing mode to use
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_pop_group_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_paint_pop_group_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_paint_composite_mode_t mode, IntPtr user_data);
