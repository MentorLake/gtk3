namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// An error code in the `GDK_PIXBUF_ERROR` domain.
/// </para>
/// <para>
/// Many gdk-pixbuf operations can cause errors in this domain, or in
/// the `G_FILE_ERROR` domain.
/// </para>
/// </summary>

[Flags]
public enum GdkPixbufError
{
/// <summary>
/// <para>
/// An image file was broken somehow.
/// </para>
/// </summary>

	GDK_PIXBUF_ERROR_CORRUPT_IMAGE = 0,
/// <summary>
/// <para>
/// Not enough memory.
/// </para>
/// </summary>

	GDK_PIXBUF_ERROR_INSUFFICIENT_MEMORY = 1,
/// <summary>
/// <para>
/// A bad option was passed to a pixbuf save module.
/// </para>
/// </summary>

	GDK_PIXBUF_ERROR_BAD_OPTION = 2,
/// <summary>
/// <para>
/// Unknown image type.
/// </para>
/// </summary>

	GDK_PIXBUF_ERROR_UNKNOWN_TYPE = 3,
/// <summary>
/// <para>
/// Don't know how to perform the
///  given operation on the type of image at hand.
/// </para>
/// </summary>

	GDK_PIXBUF_ERROR_UNSUPPORTED_OPERATION = 4,
/// <summary>
/// <para>
/// Generic failure code, something went wrong.
/// </para>
/// </summary>

	GDK_PIXBUF_ERROR_FAILED = 5,
/// <summary>
/// <para>
/// Only part of the animation was loaded.
/// </para>
/// </summary>

	GDK_PIXBUF_ERROR_INCOMPLETE_ANIMATION = 6
}
