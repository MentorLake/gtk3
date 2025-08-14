namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_unicode_funcs_t structure.
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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate uint hb_unicode_eastasian_width_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode, IntPtr user_data);
