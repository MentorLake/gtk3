namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_raster_source_release_func_t is the type of function which is
/// called when the pixel data is no longer being access by the pattern
/// for the rendering operation. Typically this function will simply
/// destroy the surface created during acquire.
/// </para>
/// </summary>

/// <param name="pattern">
/// the pattern being rendered from
/// </param>
/// <param name="callback_data">
/// the user data supplied during creation
/// </param>
/// <param name="surface">
/// the surface created during acquire
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cairo_raster_source_release_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr callback_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);
