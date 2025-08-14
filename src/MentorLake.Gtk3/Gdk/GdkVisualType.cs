namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A set of values that describe the manner in which the pixel values
/// for a visual are converted into RGB values for display.
/// </para>
/// </summary>

[Flags]
public enum GdkVisualType
{
/// <summary>
/// <para>
/// Each pixel value indexes a grayscale value
///     directly.
/// </para>
/// </summary>

	GDK_VISUAL_STATIC_GRAY = 0,
/// <summary>
/// <para>
/// Each pixel is an index into a color map that
///     maps pixel values into grayscale values. The color map can be
///     changed by an application.
/// </para>
/// </summary>

	GDK_VISUAL_GRAYSCALE = 1,
/// <summary>
/// <para>
/// Each pixel value is an index into a predefined,
///     unmodifiable color map that maps pixel values into RGB values.
/// </para>
/// </summary>

	GDK_VISUAL_STATIC_COLOR = 2,
/// <summary>
/// <para>
/// Each pixel is an index into a color map that
///     maps pixel values into rgb values. The color map can be changed by
///     an application.
/// </para>
/// </summary>

	GDK_VISUAL_PSEUDO_COLOR = 3,
/// <summary>
/// <para>
/// Each pixel value directly contains red, green,
///     and blue components. Use gdk_visual_get_red_pixel_details(), etc,
///     to obtain information about how the components are assembled into
///     a pixel value.
/// </para>
/// </summary>

	GDK_VISUAL_TRUE_COLOR = 4,
/// <summary>
/// <para>
/// Each pixel value contains red, green, and blue
///     components as for %GDK_VISUAL_TRUE_COLOR, but the components are
///     mapped via a color table into the final output table instead of
///     being converted directly.
/// </para>
/// </summary>

	GDK_VISUAL_DIRECT_COLOR = 5
}
