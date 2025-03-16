namespace MentorLake.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkPropertyChangeHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkPropertyValuesHandle>))] MentorLake.Atk.AtkPropertyValuesHandle vals);
