namespace MentorLake.Gtk3.GModule;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GModuleCheckInit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GModuleHandle>))] GModuleHandle module);
