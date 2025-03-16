namespace MentorLake.Pango;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool PangoFontsetForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))] MentorLake.Pango.PangoFontsetHandle fontset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, IntPtr user_data);
