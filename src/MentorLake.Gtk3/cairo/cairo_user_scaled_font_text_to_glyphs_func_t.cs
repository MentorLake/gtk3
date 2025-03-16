namespace MentorLake.cairo;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_user_scaled_font_text_to_glyphs_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, string utf8, int utf8_len, IntPtr glyphs, int num_glyphs, IntPtr clusters, int num_clusters, out MentorLake.cairo.cairo_text_cluster_flags_t cluster_flags);
