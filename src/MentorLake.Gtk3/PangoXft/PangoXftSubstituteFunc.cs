namespace MentorLake.PangoXft;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void PangoXftSubstituteFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, IntPtr data);
