namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Specifies the type of antialiasing to do when rendering text or shapes.
/// </para>
/// <para>
/// As it is not necessarily clear from the above what advantages a particular
/// antialias method provides, since 1.12, there is also a set of hints:
/// These make no guarantee on how the backend will perform its rasterisation
/// (if it even rasterises!), nor that they have any differing effect other
/// than to enable some form of antialiasing. In the case of glyph rendering,
/// @CAIRO_ANTIALIAS_FAST and @CAIRO_ANTIALIAS_GOOD will be mapped to
/// @CAIRO_ANTIALIAS_GRAY, with @CAIRO_ANTALIAS_BEST being equivalent to
/// @CAIRO_ANTIALIAS_SUBPIXEL.
/// </para>
/// <para>
/// The interpretation of @CAIRO_ANTIALIAS_DEFAULT is left entirely up to
/// the backend, typically this will be similar to @CAIRO_ANTIALIAS_GOOD.
/// </para>
/// </summary>

[Flags]
public enum cairo_antialias_t
{
/// <summary>
/// <para>
/// Use the default antialiasing for
///   the subsystem and target device, since 1.0
/// </para>
/// </summary>

	CAIRO_ANTIALIAS_DEFAULT = 0,
/// <summary>
/// <para>
/// Use a bilevel alpha mask, since 1.0
/// </para>
/// </summary>

	CAIRO_ANTIALIAS_NONE = 1,
/// <summary>
/// <para>
/// Perform single-color antialiasing (using
///  shades of gray for black text on a white background, for example), since 1.0
/// </para>
/// </summary>

	CAIRO_ANTIALIAS_GRAY = 2,
/// <summary>
/// <para>
/// Perform antialiasing by taking
///  advantage of the order of subpixel elements on devices
///  such as LCD panels, since 1.0
/// </para>
/// </summary>

	CAIRO_ANTIALIAS_SUBPIXEL = 3,
/// <summary>
/// <para>
/// Allow the backend to degrade raster quality for speed
/// </para>
/// </summary>

	CAIRO_ANTIALIAS_FAST = 4,
/// <summary>
/// <para>
/// A balance between speed and quality
/// </para>
/// </summary>

	CAIRO_ANTIALIAS_GOOD = 5,
/// <summary>
/// <para>
/// A high-fidelity, but potentially slow, raster mode
/// </para>
/// </summary>

	CAIRO_ANTIALIAS_BEST = 6
}
