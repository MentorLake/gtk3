namespace MentorLake.Gdk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkEventFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr data);
