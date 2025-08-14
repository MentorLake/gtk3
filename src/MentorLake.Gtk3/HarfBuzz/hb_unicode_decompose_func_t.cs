namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_unicode_funcs_t structure.
/// </para>
/// <para>
/// This method should decompose an input Unicode code point,
/// returning the two decomposed code points in #hb_codepoint_t
/// output parameters (if successful). The method must return an
/// #hb_bool_t indicating the success of the composition.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="ab">
/// The code point to decompose
/// </param>
/// <param name="a">
/// The first decomposed code point
/// </param>
/// <param name="b">
/// The second decomposed code point
/// </param>
/// <param name="user_data">
/// user data pointer passed by the caller
/// </param>
/// <return>
/// `true` if @ab decomposed, `false` otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_unicode_decompose_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t ab, out MentorLake.HarfBuzz.hb_codepoint_t a, out MentorLake.HarfBuzz.hb_codepoint_t b, IntPtr user_data);
