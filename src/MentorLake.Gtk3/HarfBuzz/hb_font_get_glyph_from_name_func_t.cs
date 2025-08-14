namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// <para>
/// This method should retrieve the glyph ID that corresponds to a glyph-name
/// string.
/// </para>
/// </summary>

/// <param name="font">
/// #hb_font_t to work upon
/// </param>
/// <param name="font_data">
/// @font user data pointer
/// </param>
/// <param name="name">
/// The name string to query
/// </param>
/// <param name="len">
/// The length of the name queried
/// </param>
/// <param name="glyph">
/// The glyph ID retrieved
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_from_name_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, string[] name, int len, out MentorLake.HarfBuzz.hb_codepoint_t glyph, IntPtr user_data);
