namespace MentorLake.PangoFc;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void PangoFcSubstituteFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, IntPtr data);
