namespace MentorLake.Gdk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkSeatGrabPrepareFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, IntPtr user_data);
