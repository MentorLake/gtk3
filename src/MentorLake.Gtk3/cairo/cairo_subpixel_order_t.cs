namespace MentorLake.cairo;

/// <summary>
/// <para>
/// The subpixel order specifies the order of color elements within
/// each pixel on the display device when rendering with an
/// antialiasing mode of %CAIRO_ANTIALIAS_SUBPIXEL.
/// </para>
/// </summary>

[Flags]
public enum cairo_subpixel_order_t
{
/// <summary>
/// <para>
/// Use the default subpixel order for
///   for the target device, since 1.0
/// </para>
/// </summary>

	CAIRO_SUBPIXEL_ORDER_DEFAULT = 0,
/// <summary>
/// <para>
/// Subpixel elements are arranged horizontally
///   with red at the left, since 1.0
/// </para>
/// </summary>

	CAIRO_SUBPIXEL_ORDER_RGB = 1,
/// <summary>
/// <para>
/// Subpixel elements are arranged horizontally
///   with blue at the left, since 1.0
/// </para>
/// </summary>

	CAIRO_SUBPIXEL_ORDER_BGR = 2,
/// <summary>
/// <para>
/// Subpixel elements are arranged vertically
///   with red at the top, since 1.0
/// </para>
/// </summary>

	CAIRO_SUBPIXEL_ORDER_VRGB = 3,
/// <summary>
/// <para>
/// Subpixel elements are arranged vertically
///   with blue at the top, since 1.0
/// </para>
/// </summary>

	CAIRO_SUBPIXEL_ORDER_VBGR = 4
}
