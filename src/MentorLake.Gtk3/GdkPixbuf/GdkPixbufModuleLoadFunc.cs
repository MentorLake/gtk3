namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Loads a file from a standard C file stream into a new `GdkPixbuf`.
/// </para>
/// <para>
/// In case of error, this function should return `NULL` and set the `error` argument.
/// </para>
/// </summary>

/// <param name="f">
/// the file stream from which the image should be loaded
/// </param>
/// <return>
/// a newly created `GdkPixbuf` for the contents of the file
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GdkPixbuf.GdkPixbufHandle GdkPixbufModuleLoadFunc(IntPtr f);
