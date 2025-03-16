namespace MentorLake.PangoFT2;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void PangoFT2SubstituteFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, IntPtr data);
