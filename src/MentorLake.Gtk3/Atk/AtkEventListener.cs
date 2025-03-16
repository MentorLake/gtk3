namespace MentorLake.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle obj);
