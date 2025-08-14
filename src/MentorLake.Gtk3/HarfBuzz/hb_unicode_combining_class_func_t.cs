namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_unicode_funcs_t structure.
/// </para>
/// <para>
/// This method should retrieve the Canonical Combining Class (ccc)
/// property for a specified Unicode code point.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// A Unicode-functions structure
/// </param>
/// <param name="unicode">
/// The code point to query
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>
/// <return>
/// The #hb_unicode_combining_class_t of @unicode
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_unicode_combining_class_t hb_unicode_combining_class_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode, IntPtr user_data);
