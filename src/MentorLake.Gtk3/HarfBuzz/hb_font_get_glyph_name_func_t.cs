namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// <para>
/// This method should retrieve the glyph name that corresponds to a
/// glyph ID. The name should be returned in a string output parameter.
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
/// <param name="name">
/// Name string retrieved for the glyph ID
/// </param>
/// <param name="size">
/// Length of the glyph-name string retrieved
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>
/// <return>
/// `true` if data found, `false` otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_font_get_glyph_name_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, IntPtr font_data, MentorLake.HarfBuzz.hb_codepoint_t glyph, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out string[] name, out uint size, IntPtr user_data);
