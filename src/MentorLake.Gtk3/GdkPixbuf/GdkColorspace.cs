namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// This enumeration defines the color spaces that are supported by
/// the gdk-pixbuf library.
/// </para>
/// <para>
/// Currently only RGB is supported.
/// </para>
/// </summary>

[Flags]
public enum GdkColorspace
{
/// <summary>
/// <para>
/// Indicates a red/green/blue additive color space.
/// </para>
/// </summary>

	GDK_COLORSPACE_RGB = 0
}
