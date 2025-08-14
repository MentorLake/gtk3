namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Sets up the image loading state.
/// </para>
/// <para>
/// The image loader is responsible for storing the given function pointers
/// and user data, and call them when needed.
/// </para>
/// <para>
/// The image loader should set up an internal state object, and return it
/// from this function; the state object will then be updated from the
/// [callback@GdkPixbuf.PixbufModuleIncrementLoadFunc] callback, and will be freed
/// by [callback@GdkPixbuf.PixbufModuleStopLoadFunc] callback.
/// </para>
/// </summary>

/// <param name="size_func">
/// the function to be called when the size is known
/// </param>
/// <param name="prepared_func">
/// the function to be called when the data has been prepared
/// </param>
/// <param name="updated_func">
/// the function to be called when the data has been updated
/// </param>
/// <param name="user_data">
/// the data to be passed to the functions
/// </param>
/// <return>
/// the data to be passed to
///   [callback@GdkPixbuf.PixbufModuleIncrementLoadFunc]
///   and [callback@GdkPixbuf.PixbufModuleStopLoadFunc], or `NULL` in case of error
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GdkPixbufModuleBeginLoadFunc(MentorLake.GdkPixbuf.GdkPixbufModuleSizeFunc size_func, MentorLake.GdkPixbuf.GdkPixbufModulePreparedFunc prepared_func, MentorLake.GdkPixbuf.GdkPixbufModuleUpdatedFunc updated_func, IntPtr user_data);
