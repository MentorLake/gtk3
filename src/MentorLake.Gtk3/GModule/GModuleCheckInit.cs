namespace MentorLake.GModule;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GModuleCheckInit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))] MentorLake.GModule.GModuleHandle module);
