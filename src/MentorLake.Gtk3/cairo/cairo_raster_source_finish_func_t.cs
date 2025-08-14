namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_raster_source_finish_func_t is the type of function which is
/// called when the pattern (or a copy thereof) is no longer required.
/// </para>
/// </summary>

/// <param name="pattern">
/// the pattern being rendered from
/// </param>
/// <param name="callback_data">
/// the user data supplied during creation
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cairo_raster_source_finish_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr callback_data);
