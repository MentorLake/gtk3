namespace MentorLake.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypeValueCopyFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle src_value, out MentorLake.GObject.GValue dest_value);
