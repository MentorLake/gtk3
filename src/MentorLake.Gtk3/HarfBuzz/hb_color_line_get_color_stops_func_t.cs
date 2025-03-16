namespace MentorLake.HarfBuzz;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate uint hb_color_line_get_color_stops_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, IntPtr color_line_data, uint start, out uint count, out MentorLake.HarfBuzz.hb_color_stop_t[] color_stops, IntPtr user_data);
