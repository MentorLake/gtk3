namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// A function of this type is responsible for freeing the pixel array
/// of a pixbuf.
/// </para>
/// <para>
/// The gdk_pixbuf_new_from_data() function lets you pass in a pre-allocated
/// pixel array so that a pixbuf can be created from it; in this case you
/// will need to pass in a function of type `GdkPixbufDestroyNotify` so that
/// the pixel data can be freed when the pixbuf is finalized.
/// </para>
/// </summary>

/// <param name="pixels">
/// The pixel array of the pixbuf
///   that is being finalized.
/// </param>
/// <param name="data">
/// User closure data.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufDestroyNotify(byte[] pixels, IntPtr data);
