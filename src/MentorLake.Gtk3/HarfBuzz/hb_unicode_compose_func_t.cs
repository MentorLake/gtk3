namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_unicode_funcs_t structure.
/// </para>
/// <para>
/// This method should compose a sequence of two input Unicode code
/// points by canonical equivalence, returning the composed code
/// point in a #hb_codepoint_t output parameter (if successful).
/// The method must return an #hb_bool_t indicating the success
/// of the composition.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="a">
/// The first code point to compose
/// </param>
/// <param name="b">
/// The second code point to compose
/// </param>
/// <param name="ab">
/// The composed code point
/// </param>
/// <param name="user_data">
/// user data pointer passed by the caller
/// </param>
/// <return>
/// `true` is @a,@b composed, `false` otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_unicode_compose_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t a, MentorLake.HarfBuzz.hb_codepoint_t b, out MentorLake.HarfBuzz.hb_codepoint_t ab, IntPtr user_data);
