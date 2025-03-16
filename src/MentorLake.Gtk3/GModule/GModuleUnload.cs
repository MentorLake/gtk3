namespace MentorLake.GModule;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GModuleUnload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))] MentorLake.GModule.GModuleHandle module);
