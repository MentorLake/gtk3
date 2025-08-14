namespace MentorLake.cairo;


/// <param name="observer">
/// </param>
/// <param name="target">
/// </param>
/// <param name="data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cairo_surface_observer_callback_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle target, IntPtr data);
