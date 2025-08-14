namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The values of this enumeration describe the compositing modes
/// that can be used when combining temporary redirected drawing
/// with the backdrop.
/// </para>
/// <para>
/// See the OpenType spec [COLR](https://learn.microsoft.com/en-us/typography/opentype/spec/colr)
/// section for details.
/// </para>
/// </summary>

[Flags]
public enum hb_paint_composite_mode_t
{
/// <summary>
/// <para>
/// clear destination layer (bounded)
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_CLEAR = 0,
/// <summary>
/// <para>
/// replace destination layer (bounded)
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_SRC = 1,
/// <summary>
/// <para>
/// ignore the source
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_DEST = 2,
/// <summary>
/// <para>
/// draw source layer on top of destination layer
/// (bounded)
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_SRC_OVER = 3,
/// <summary>
/// <para>
/// draw destination on top of source
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_DEST_OVER = 4,
/// <summary>
/// <para>
/// draw source where there was destination content
/// (unbounded)
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_SRC_IN = 5,
/// <summary>
/// <para>
/// leave destination only where there was
/// source content (unbounded)
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_DEST_IN = 6,
/// <summary>
/// <para>
/// draw source where there was no destination
/// content (unbounded)
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_SRC_OUT = 7,
/// <summary>
/// <para>
/// leave destination only where there was no
/// source content
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_DEST_OUT = 8,
/// <summary>
/// <para>
/// draw source on top of destination content and
/// only there
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_SRC_ATOP = 9,
/// <summary>
/// <para>
/// leave destination on top of source content
/// and only there (unbounded)
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_DEST_ATOP = 10,
/// <summary>
/// <para>
/// source and destination are shown where there is only
/// one of them
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_XOR = 11,
/// <summary>
/// <para>
/// source and destination layers are accumulated
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_PLUS = 12,
/// <summary>
/// <para>
/// source and destination are complemented and
/// multiplied. This causes the result to be at least as light as the lighter
/// inputs.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_SCREEN = 13,
/// <summary>
/// <para>
/// multiplies or screens, depending on the
/// lightness of the destination color.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_OVERLAY = 14,
/// <summary>
/// <para>
/// replaces the destination with the source if it
/// is darker, otherwise keeps the source.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_DARKEN = 15,
/// <summary>
/// <para>
/// replaces the destination with the source if it
/// is lighter, otherwise keeps the source.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_LIGHTEN = 16,
/// <summary>
/// <para>
/// brightens the destination color to reflect
/// the source color.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_COLOR_DODGE = 17,
/// <summary>
/// <para>
/// darkens the destination color to reflect
/// the source color.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_COLOR_BURN = 18,
/// <summary>
/// <para>
/// Multiplies or screens, dependent on source
/// color.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_HARD_LIGHT = 19,
/// <summary>
/// <para>
/// Darkens or lightens, dependent on source
/// color.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_SOFT_LIGHT = 20,
/// <summary>
/// <para>
/// Takes the difference of the source and
/// destination color.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_DIFFERENCE = 21,
/// <summary>
/// <para>
/// Produces an effect similar to difference, but
/// with lower contrast.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_EXCLUSION = 22,
/// <summary>
/// <para>
/// source and destination layers are multiplied.
/// This causes the result to be at least as dark as the darker inputs.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_MULTIPLY = 23,
/// <summary>
/// <para>
/// Creates a color with the hue of the source
/// and the saturation and luminosity of the target.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_HSL_HUE = 24,
/// <summary>
/// <para>
/// Creates a color with the saturation
/// of the source and the hue and luminosity of the target. Painting with
/// this mode onto a gray area produces no change.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_HSL_SATURATION = 25,
/// <summary>
/// <para>
/// Creates a color with the hue and saturation
/// of the source and the luminosity of the target. This preserves the gray
/// levels of the target and is useful for coloring monochrome images or
/// tinting color images.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_HSL_COLOR = 26,
/// <summary>
/// <para>
/// Creates a color with the luminosity of
/// the source and the hue and saturation of the target. This produces an
/// inverse effect to @HB_PAINT_COMPOSITE_MODE_HSL_COLOR.
/// </para>
/// </summary>

	HB_PAINT_COMPOSITE_MODE_HSL_LUMINOSITY = 27
}
