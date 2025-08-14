namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to paint a linear
/// gradient everywhere within the current clip.
/// </para>
/// <para>
/// The @color_line object contains information about the colors of the gradients.
/// It is only valid for the duration of the callback, you cannot keep it around.
/// </para>
/// <para>
/// The coordinates of the points are interpreted according
/// to the current transform.
/// </para>
/// <para>
/// See the OpenType spec [COLR](https://learn.microsoft.com/en-us/typography/opentype/spec/colr)
/// section for details on how the points define the direction
/// of the gradient, and how to interpret the @color_line.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions object
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions in hb_font_paint_glyph()
/// </param>
/// <param name="color_line">
/// Color information for the gradient
/// </param>
/// <param name="x0">
/// X coordinate of the first point
/// </param>
/// <param name="y0">
/// Y coordinate of the first point
/// </param>
/// <param name="x1">
/// X coordinate of the second point
/// </param>
/// <param name="y1">
/// Y coordinate of the second point
/// </param>
/// <param name="x2">
/// X coordinate of the third point
/// </param>
/// <param name="y2">
/// Y coordinate of the third point
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_linear_gradient_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_paint_linear_gradient_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, float x0, float y0, float x1, float y1, float x2, float y2, IntPtr user_data);
