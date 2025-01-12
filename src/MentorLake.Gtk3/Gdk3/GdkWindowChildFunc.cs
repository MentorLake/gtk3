namespace MentorLake.Gtk3.Gdk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkWindowChildFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkWindowHandle>))] GdkWindowHandle window, IntPtr user_data);
