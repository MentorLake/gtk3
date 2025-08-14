namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_raster_source_copy_func_t is the type of function which is
/// called when the pattern gets copied as a normal part of rendering.
/// </para>
/// </summary>

/// <param name="pattern">
/// the #cairo_pattern_t that was copied to
/// </param>
/// <param name="callback_data">
/// the user data supplied during creation
/// </param>
/// <param name="other">
/// the #cairo_pattern_t being used as the source for the copy
/// </param>
/// <return>
/// CAIRO_STATUS_SUCCESS on success, or one of the
/// #cairo_status_t error codes for failure.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_raster_source_copy_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr callback_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle other);
