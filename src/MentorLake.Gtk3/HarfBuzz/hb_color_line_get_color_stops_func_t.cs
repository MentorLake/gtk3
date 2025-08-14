namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_color_line_t to fetch color stops.
/// </para>
/// </summary>

/// <param name="color_line">
/// a #hb_color_line_t object
/// </param>
/// <param name="color_line_data">
/// the data accompanying @color_line
/// </param>
/// <param name="start">
/// the index of the first color stop to return
/// </param>
/// <param name="count">
/// Input = the maximum number of feature tags to return;
///     Output = the actual number of feature tags returned (may be zero)
/// </param>
/// <param name="color_stops">
/// Array of #hb_color_stop_t to populate
/// </param>
/// <param name="user_data">
/// the data accompanying this method
/// </param>
/// <return>
/// the total number of color stops in @color_line
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate uint hb_color_line_get_color_stops_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_color_line_tHandle>))] MentorLake.HarfBuzz.hb_color_line_tHandle color_line, IntPtr color_line_data, uint start, out uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out MentorLake.HarfBuzz.hb_color_stop_t[] color_stops, IntPtr user_data);
