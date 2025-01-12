namespace MentorLake.Gtk3.Gdk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GdkFilterReturn GdkFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkXEventHandle>))] GdkXEventHandle xevent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr data);
