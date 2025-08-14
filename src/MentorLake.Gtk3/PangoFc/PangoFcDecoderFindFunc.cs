namespace MentorLake.PangoFc;

/// <summary>
/// <para>
/// Callback function passed to [method@PangoFc.FontMap.add_decoder_find_func].
/// </para>
/// </summary>

/// <param name="pattern">
/// a fully resolved `FcPattern` specifying the font on the system
/// </param>
/// <param name="user_data">
/// user data passed to
///   [method@PangoFc.FontMap.add_decoder_find_func]
/// </param>
/// <return>
/// a new reference to a custom decoder for this pattern,
///  or %NULL if the default decoder handling should be used.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.PangoFc.PangoFcDecoderHandle PangoFcDecoderFindFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, IntPtr user_data);
