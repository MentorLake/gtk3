namespace MentorLake.HarfBuzz;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_font_get_variation_glyph_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_codepoint_t unicode, MentorLake.HarfBuzz.hb_codepoint_t variation_selector, out MentorLake.HarfBuzz.hb_codepoint_t glyph, IntPtr user_data);
