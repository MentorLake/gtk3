namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Defines the type of the function that gets called once the size
/// of the loaded image is known.
/// </para>
/// <para>
/// The function is expected to set @width and @height to the desired
/// size to which the image should be scaled. If a module has no efficient
/// way to achieve the desired scaling during the loading of the image, it may
/// either ignore the size request, or only approximate it - gdk-pixbuf will
/// then perform the required scaling on the completely loaded image.
/// </para>
/// <para>
/// If the function sets @width or @height to zero, the module should interpret
/// this as a hint that it will be closed soon and shouldn&apos;t allocate further
/// resources. This convention is used to implement gdk_pixbuf_get_file_info()
/// efficiently.
/// </para>
/// </summary>

/// <param name="width">
/// pointer to a location containing the current image width
/// </param>
/// <param name="height">
/// pointer to a location containing the current image height
/// </param>
/// <param name="user_data">
/// the loader.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufModuleSizeFunc(int width, int height, IntPtr user_data);
