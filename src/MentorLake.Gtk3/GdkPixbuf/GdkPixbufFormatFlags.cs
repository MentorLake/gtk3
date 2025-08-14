namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Flags which allow a module to specify further details about the supported
/// operations.
/// </para>
/// </summary>

[Flags]
public enum GdkPixbufFormatFlags : uint
{
/// <summary>
/// <para>
/// the module can write out images in the format.
/// </para>
/// </summary>

	GDK_PIXBUF_FORMAT_WRITABLE = 1,
/// <summary>
/// <para>
/// the image format is scalable
/// </para>
/// </summary>

	GDK_PIXBUF_FORMAT_SCALABLE = 2,
/// <summary>
/// <para>
/// the module is threadsafe. gdk-pixbuf
///     ignores modules that are not marked as threadsafe. (Since 2.28).
/// </para>
/// </summary>

	GDK_PIXBUF_FORMAT_THREADSAFE = 4
}
