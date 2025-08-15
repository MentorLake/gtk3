namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_unicode_funcs_t structure.
/// </para>
/// <para>
/// This method should retrieve the Bi-Directional Mirroring Glyph
/// code point for a specified Unicode code point.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: If a code point does not have a specified
/// Bi-Directional Mirroring Glyph defined, the method should
/// return the original code point.&amp;lt;/note&amp;gt;
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
/// The #hb_codepoint_t of the Mirroring Glyph for @unicode
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_codepoint_t hb_unicode_mirroring_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_unicode_funcs_tHandle>))] MentorLake.HarfBuzz.hb_unicode_funcs_tHandle ufuncs, MentorLake.HarfBuzz.hb_codepoint_t unicode, IntPtr user_data);
