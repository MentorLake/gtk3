namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Whenever some area of the window is invalidated (directly in the
/// window or in a child window) this gets called with @region in
/// the coordinate space of @window. You can use @region to just
/// keep track of the dirty region, or you can actually change
/// @region in case you are doing display tricks like showing
/// a child in multiple places.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="region">
/// a #cairo_region_t
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkWindowInvalidateHandlerFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);
