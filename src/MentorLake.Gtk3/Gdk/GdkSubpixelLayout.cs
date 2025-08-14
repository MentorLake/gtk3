namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// This enumeration describes how the red, green and blue components
/// of physical pixels on an output device are laid out.
/// </para>
/// </summary>

[Flags]
public enum GdkSubpixelLayout
{
/// <summary>
/// <para>
/// The layout is not known
/// </para>
/// </summary>

	GDK_SUBPIXEL_LAYOUT_UNKNOWN = 0,
/// <summary>
/// <para>
/// Not organized in this way
/// </para>
/// </summary>

	GDK_SUBPIXEL_LAYOUT_NONE = 1,
/// <summary>
/// <para>
/// The layout is horizontal, the order is RGB
/// </para>
/// </summary>

	GDK_SUBPIXEL_LAYOUT_HORIZONTAL_RGB = 2,
/// <summary>
/// <para>
/// The layout is horizontal, the order is BGR
/// </para>
/// </summary>

	GDK_SUBPIXEL_LAYOUT_HORIZONTAL_BGR = 3,
/// <summary>
/// <para>
/// The layout is vertical, the order is RGB
/// </para>
/// </summary>

	GDK_SUBPIXEL_LAYOUT_VERTICAL_RGB = 4,
/// <summary>
/// <para>
/// The layout is vertical, the order is BGR
/// </para>
/// </summary>

	GDK_SUBPIXEL_LAYOUT_VERTICAL_BGR = 5
}
