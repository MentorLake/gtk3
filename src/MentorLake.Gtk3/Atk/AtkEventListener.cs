namespace MentorLake.Gtk3.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle obj);
