namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_draw_funcs_t to perform a "close-path" draw
/// operation.
/// </para>
/// </summary>

/// <param name="dfuncs">
/// draw functions object
/// </param>
/// <param name="draw_data">
/// The data accompanying the draw functions in hb_font_draw_glyph()
/// </param>
/// <param name="st">
/// current draw state
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_draw_funcs_set_close_path_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_draw_close_path_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_state_tHandle>))] MentorLake.HarfBuzz.hb_draw_state_tHandle st, IntPtr user_data);
