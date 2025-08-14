namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_pattern_type_t is used to describe the type of a given pattern.
/// </para>
/// <para>
/// The type of a pattern is determined by the function used to create
/// it. The cairo_pattern_create_rgb() and cairo_pattern_create_rgba()
/// functions create SOLID patterns. The remaining
/// cairo_pattern_create<!-- --> functions map to pattern types in obvious
/// ways.
/// </para>
/// <para>
/// The pattern type can be queried with cairo_pattern_get_type()
/// </para>
/// <para>
/// Most #cairo_pattern_t functions can be called with a pattern of any
/// type, (though trying to change the extend or filter for a solid
/// pattern will have no effect). A notable exception is
/// cairo_pattern_add_color_stop_rgb() and
/// cairo_pattern_add_color_stop_rgba() which must only be called with
/// gradient patterns (either LINEAR or RADIAL). Otherwise the pattern
/// will be shutdown and put into an error state.
/// </para>
/// <para>
/// New entries may be added in future versions.
/// </para>
/// </summary>

[Flags]
public enum cairo_pattern_type_t
{
/// <summary>
/// <para>
/// The pattern is a solid (uniform)
/// color. It may be opaque or translucent, since 1.2.
/// </para>
/// </summary>

	CAIRO_PATTERN_TYPE_SOLID = 0,
/// <summary>
/// <para>
/// The pattern is a based on a surface (an image), since 1.2.
/// </para>
/// </summary>

	CAIRO_PATTERN_TYPE_SURFACE = 1,
/// <summary>
/// <para>
/// The pattern is a linear gradient, since 1.2.
/// </para>
/// </summary>

	CAIRO_PATTERN_TYPE_LINEAR = 2,
/// <summary>
/// <para>
/// The pattern is a radial gradient, since 1.2.
/// </para>
/// </summary>

	CAIRO_PATTERN_TYPE_RADIAL = 3,
/// <summary>
/// <para>
/// The pattern is a mesh, since 1.12.
/// </para>
/// </summary>

	CAIRO_PATTERN_TYPE_MESH = 4,
/// <summary>
/// <para>
/// The pattern is a user pattern providing raster data, since 1.12.
/// </para>
/// </summary>

	CAIRO_PATTERN_TYPE_RASTER_SOURCE = 5
}
