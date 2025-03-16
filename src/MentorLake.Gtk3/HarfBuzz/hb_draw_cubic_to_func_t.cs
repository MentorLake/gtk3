namespace MentorLake.HarfBuzz;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_draw_cubic_to_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_funcs_tHandle>))] MentorLake.HarfBuzz.hb_draw_funcs_tHandle dfuncs, IntPtr draw_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_draw_state_tHandle>))] MentorLake.HarfBuzz.hb_draw_state_tHandle st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y, IntPtr user_data);
