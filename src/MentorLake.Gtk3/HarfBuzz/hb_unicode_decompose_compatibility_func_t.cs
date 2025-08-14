namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Fully decompose @u to its Unicode compatibility decomposition. The codepoints of the decomposition will be written to @decomposed.
/// The complete length of the decomposition will be returned.
/// </para>
/// <para>
/// If @u has no compatibility decomposition, zero should be returned.
/// </para>
/// <para>
/// The Unicode standard guarantees that a buffer of length #HB_UNICODE_MAX_DECOMPOSITION_LEN codepoints will always be sufficient for any
/// compatibility decomposition plus an terminating value of 0.  Consequently, @decompose must be allocated by the caller to be at least this length.  Implementations
/// of this function type must ensure that they do not write past the provided array.
/// </para>
/// </summary>

/// <param name="ufuncs">
/// a Unicode function structure
/// </param>
/// <param name="u">
/// codepoint to decompose
/// </param>
/// <param name="decomposed">
/// address of codepoint array (of length #HB_UNICODE_MAX_DECOMPOSITION_LEN) to write decomposition into
/// </param>
/// <param name="user_data">
/// user data pointer as passed to hb_unicode_funcs_set_decompose_compatibility_func()
/// </param>
/// <return>
/// number of codepoints in the full compatibility decomposition of @u, or 0 if no decomposition available.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate uint hb_unicode_decompose_compatibility_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t u, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_codepoint_tHandle>))] MentorLake.HarfBuzz.hb_codepoint_tHandle decomposed, IntPtr user_data);
