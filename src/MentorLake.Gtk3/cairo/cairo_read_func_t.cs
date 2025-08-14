namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_read_func_t is the type of function which is called when a
/// backend needs to read data from an input stream.  It is passed the
/// closure which was specified by the user at the time the read
/// function was registered, the buffer to read the data into and the
/// length of the data in bytes.  The read function should return
/// %CAIRO_STATUS_SUCCESS if all the data was successfully read,
/// %CAIRO_STATUS_READ_ERROR otherwise.
/// </para>
/// </summary>

/// <param name="closure">
/// the input closure
/// </param>
/// <param name="data">
/// the buffer into which to read the data
/// </param>
/// <param name="length">
/// the amount of data to read
/// </param>
/// <return>
/// the status code of the read operation
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_status_t cairo_read_func_t(IntPtr closure, byte data, uint length);
