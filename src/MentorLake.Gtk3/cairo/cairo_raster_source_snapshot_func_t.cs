namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_raster_source_snapshot_func_t is the type of function which is
/// called when the pixel data needs to be preserved for later use
/// during printing. This pattern will be accessed again later, and it
/// is expected to provide the pixel data that was current at the time
/// of snapshotting.
/// </para>
/// </summary>

/// <param name="pattern">
/// the pattern being rendered from
/// </param>
/// <param name="callback_data">
/// the user data supplied during creation
/// </param>
/// <return>
/// CAIRO_STATUS_SUCCESS on success, or one of the
/// #cairo_status_t error codes for failure.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_raster_source_snapshot_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr callback_data);
