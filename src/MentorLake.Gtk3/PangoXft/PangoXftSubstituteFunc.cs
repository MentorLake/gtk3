namespace MentorLake.PangoXft;

/// <summary>
/// <para>
/// Function type for doing final config tweaking on prepared FcPatterns.
/// </para>
/// </summary>

/// <param name="pattern">
/// the FcPattern to tweak.
/// </param>
/// <param name="data">
/// user data.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void PangoXftSubstituteFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, IntPtr data);
