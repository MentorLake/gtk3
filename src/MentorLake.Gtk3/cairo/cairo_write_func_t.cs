namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_write_func_t is the type of function which is called when a
/// backend needs to write data to an output stream.  It is passed the
/// closure which was specified by the user at the time the write
/// function was registered, the data to write and the length of the
/// data in bytes.  The write function should return
/// %CAIRO_STATUS_SUCCESS if all the data was successfully written,
/// %CAIRO_STATUS_WRITE_ERROR otherwise.
/// </para>
/// </summary>

/// <param name="closure">
/// the output closure
/// </param>
/// <param name="data">
/// the buffer containing the data to write
/// </param>
/// <param name="length">
/// the amount of data to write
/// </param>
/// <return>
/// the status code of the write operation
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_write_func_t(IntPtr closure, byte data, uint length);
