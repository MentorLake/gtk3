namespace MentorLake.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkFocusHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle @object, bool focus_in);
