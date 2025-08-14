namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Finalizes the image loading state.
/// </para>
/// <para>
/// This function is called on success and error states.
/// </para>
/// </summary>

/// <param name="context">
/// the state object created by [callback@GdkPixbuf.PixbufModuleBeginLoadFunc]
/// </param>
/// <return>
/// `TRUE` if the loading operation was successful
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufModuleStopLoadFunc(IntPtr context);
