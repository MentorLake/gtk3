namespace MentorLake.Gtk3.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkPropertyChangeHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkPropertyValuesHandle>))] AtkPropertyValuesHandle vals);
