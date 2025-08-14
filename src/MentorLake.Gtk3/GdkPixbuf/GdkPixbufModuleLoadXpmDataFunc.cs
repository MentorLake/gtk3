namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Loads XPM data into a new `GdkPixbuf`.
/// </para>
/// </summary>

/// <param name="data">
/// the XPM data
/// </param>
/// <return>
/// a newly created `GdkPixbuf` for the XPM data
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GdkPixbuf.GdkPixbufHandle GdkPixbufModuleLoadXpmDataFunc(string[] data);
