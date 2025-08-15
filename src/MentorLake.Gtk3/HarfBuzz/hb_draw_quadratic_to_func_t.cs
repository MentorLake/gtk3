namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_draw_funcs_t to perform a &quot;quadratic-to&quot; draw
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
/// <param name="control_x">
/// X component of control point
/// </param>
/// <param name="control_y">
/// Y component of control point
/// </param>
/// <param name="to_x">
/// X component of target point
/// </param>
/// <param name="to_y">
/// Y component of target point
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_draw_funcs_set_quadratic_to_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_draw_quadratic_to_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_state_tHandle>))] MentorLake.HarfBuzz.hb_draw_state_tHandle st, float control_x, float control_y, float to_x, float to_y, IntPtr user_data);
