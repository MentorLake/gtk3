namespace MentorLake.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClassInitFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class, IntPtr class_data);
