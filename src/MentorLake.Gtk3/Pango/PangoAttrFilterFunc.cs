namespace MentorLake.Pango;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool PangoAttrFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attribute, IntPtr user_data);
