namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_raster_source_acquire_func_t is the type of function which is
/// called when a pattern is being rendered from. It should create a surface
/// that provides the pixel data for the region of interest as defined by
/// extents, though the surface itself does not have to be limited to that
/// area. For convenience the surface should probably be of image type,
/// created with cairo_surface_create_similar_image() for the target (which
/// enables the number of copies to be reduced during transfer to the
/// device). Another option, might be to return a similar surface to the
/// target for explicit handling by the application of a set of cached sources
/// on the device. The region of sample data provided should be defined using
/// cairo_surface_set_device_offset() to specify the top-left corner of the
/// sample data (along with width and height of the surface).
/// </para>
/// </summary>

/// <param name="pattern">
/// the pattern being rendered from
/// </param>
/// <param name="callback_data">
/// the user data supplied during creation
/// </param>
/// <param name="target">
/// the rendering target surface
/// </param>
/// <param name="extents">
/// rectangular region of interest in pixels in sample space
/// </param>
/// <return>
/// a #cairo_surface_t
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_surface_tHandle cairo_raster_source_acquire_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr callback_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle target, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle extents);
