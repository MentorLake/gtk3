namespace MentorLake.PangoFc;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.PangoFc.PangoFcDecoderHandle PangoFcDecoderFindFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern, IntPtr user_data);
