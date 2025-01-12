namespace MentorLake.Gtk3.Gdk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkEventFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr data);
