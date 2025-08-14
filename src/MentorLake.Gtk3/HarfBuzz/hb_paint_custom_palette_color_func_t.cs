namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to fetch a color from the custom
/// color palette.
/// </para>
/// <para>
/// Custom palette colors override the colors from the fonts selected color
/// palette. It is not necessary to override all palette entries; for entries
/// that should be taken from the font palette, return `false`.
/// </para>
/// <para>
/// This function might get called multiple times, but the custom palette is
/// expected to remain unchanged for duration of a hb_font_paint_glyph() call.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions object
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions in hb_font_paint_glyph()
/// </param>
/// <param name="color_index">
/// the color index
/// </param>
/// <param name="color">
/// fetched color
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_pop_group_func()
/// </param>
/// <return>
/// `true` if found, `false` otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_paint_custom_palette_color_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, uint color_index, out MentorLake.HarfBuzz.hb_color_t color, IntPtr user_data);
