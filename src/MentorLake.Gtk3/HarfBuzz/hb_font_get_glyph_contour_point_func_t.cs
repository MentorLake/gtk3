namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// <para>
/// This method should retrieve the (X,Y) coordinates (in font units) for a
/// specified contour point in a glyph. Each coordinate must be returned as
/// an #hb_position_t output parameter.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="font_data">
/// @font user data pointer
/// </param>
/// <param name="glyph">
/// The glyph ID to query
/// </param>
/// <param name="point_index">
/// The contour-point index to query
/// </param>
/// <param name="x">
/// The X value retrieved for the contour point
/// </param>
/// <param name="y">
/// The Y value retrieved for the contour point
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_contour_point_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, uint point_index, out MentorLake.HarfBuzz.hb_position_t x, out MentorLake.HarfBuzz.hb_position_t y, IntPtr user_data);
