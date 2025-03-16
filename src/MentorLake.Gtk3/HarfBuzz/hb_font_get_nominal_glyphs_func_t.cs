namespace MentorLake.HarfBuzz;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate uint hb_font_get_nominal_glyphs_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle first_unicode, uint unicode_stride, out MentorLake.HarfBuzz.hb_codepoint_t first_glyph, uint glyph_stride, IntPtr user_data);
