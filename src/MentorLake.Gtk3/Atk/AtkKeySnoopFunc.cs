namespace MentorLake.Atk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int AtkKeySnoopFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkKeyEventStructHandle>))] MentorLake.Atk.AtkKeyEventStructHandle @event, IntPtr user_data);
