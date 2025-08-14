namespace MentorLake.PangoFc;

/// <summary>
/// <para>
/// Function type for doing final config tweaking on prepared `FcPattern`s.
/// </para>
/// </summary>

/// <param name="pattern">
/// the FcPattern to tweak.
/// </param>
/// <param name="data">
/// user data.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void PangoFcSubstituteFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, IntPtr data);
