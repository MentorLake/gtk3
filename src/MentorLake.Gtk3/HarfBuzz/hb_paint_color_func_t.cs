namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to paint a
/// color everywhere within the current clip.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions object
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions in hb_font_paint_glyph()
/// </param>
/// <param name="is_foreground">
/// whether the color is the foreground
/// </param>
/// <param name="color">
/// The color to use, unpremultiplied
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_color_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_paint_color_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, MentorLake.HarfBuzz.hb_bool_t is_foreground, MentorLake.HarfBuzz.hb_color_t color, IntPtr user_data);
