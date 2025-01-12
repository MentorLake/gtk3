namespace MentorLake.Gtk3.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int AtkKeySnoopFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkKeyEventStructHandle>))] AtkKeyEventStructHandle @event, IntPtr user_data);
