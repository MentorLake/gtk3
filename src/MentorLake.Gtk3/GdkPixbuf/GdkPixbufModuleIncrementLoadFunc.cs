namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Incrementally loads a buffer into the image data.
/// </para>
/// </summary>

/// <param name="context">
/// the state object created by [callback@GdkPixbuf.PixbufModuleBeginLoadFunc]
/// </param>
/// <param name="buf">
/// the data to load
/// </param>
/// <param name="size">
/// the length of the data to load
/// </param>
/// <return>
/// `TRUE` if the incremental load was successful
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufModuleIncrementLoadFunc(IntPtr context, byte[] buf, uint size);
