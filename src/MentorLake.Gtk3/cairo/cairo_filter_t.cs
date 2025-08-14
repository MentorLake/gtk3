namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_filter_t is used to indicate what filtering should be
/// applied when reading pixel values from patterns. See
/// cairo_pattern_set_filter() for indicating the desired filter to be
/// used with a particular pattern.
/// </para>
/// </summary>

[Flags]
public enum cairo_filter_t
{
/// <summary>
/// <para>
/// A high-performance filter, with quality similar
///     to %CAIRO_FILTER_NEAREST (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FILTER_FAST = 0,
/// <summary>
/// <para>
/// A reasonable-performance filter, with quality
///     similar to %CAIRO_FILTER_BILINEAR (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FILTER_GOOD = 1,
/// <summary>
/// <para>
/// The highest-quality available, performance may
///     not be suitable for interactive use. (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FILTER_BEST = 2,
/// <summary>
/// <para>
/// Nearest-neighbor filtering (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FILTER_NEAREST = 3,
/// <summary>
/// <para>
/// Linear interpolation in two dimensions (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FILTER_BILINEAR = 4,
/// <summary>
/// <para>
/// This filter value is currently
///     unimplemented, and should not be used in current code. (Since 1.0)
/// </para>
/// </summary>

	CAIRO_FILTER_GAUSSIAN = 5
}
