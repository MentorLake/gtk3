namespace MentorLake.Gtk3.Gdk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkWindowInvalidateHandlerFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkWindowHandle>))] GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<cairo_region_tHandle>))] cairo_region_tHandle region);
