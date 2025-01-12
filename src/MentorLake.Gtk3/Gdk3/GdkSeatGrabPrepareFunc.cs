namespace MentorLake.Gtk3.Gdk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkSeatGrabPrepareFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle seat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkWindowHandle>))] GdkWindowHandle window, IntPtr user_data);
