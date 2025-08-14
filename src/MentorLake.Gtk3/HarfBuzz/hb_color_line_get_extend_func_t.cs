namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the @hb_color_line_t to fetches the extend mode.
/// </para>
/// </summary>

/// <param name="color_line">
/// a #hb_color_line_t object
/// </param>
/// <param name="color_line_data">
/// the data accompanying @color_line
/// </param>
/// <param name="user_data">
/// the data accompanying this method
/// </param>
/// <return>
/// the extend mode of @color_line
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_paint_extend_t hb_color_line_get_extend_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, IntPtr color_line_data, IntPtr user_data);
