namespace MentorLake.Gtk3.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkFocusHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkObjectHandle>))] AtkObjectHandle @object, bool focus_in);
