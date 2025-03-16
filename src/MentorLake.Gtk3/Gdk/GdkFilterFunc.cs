namespace MentorLake.Gdk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gdk.GdkFilterReturn GdkFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkXEventHandle>))] MentorLake.Gdk.GdkXEventHandle xevent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr data);
