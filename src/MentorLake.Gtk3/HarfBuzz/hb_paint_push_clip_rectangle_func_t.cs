namespace MentorLake.HarfBuzz;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_paint_push_clip_rectangle_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, float xmin, float ymin, float xmax, float ymax, IntPtr user_data);
