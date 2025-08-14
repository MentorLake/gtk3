namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Flags that describe the properties of color palette.
/// </para>
/// </summary>

[Flags]
public enum hb_ot_color_palette_flags_t : uint
{
/// <summary>
/// <para>
/// Default indicating that there is nothing special
///   to note about a color palette.
/// </para>
/// </summary>

	HB_OT_COLOR_PALETTE_FLAG_DEFAULT = 0,
/// <summary>
/// <para>
/// Flag indicating that the color
///   palette is appropriate to use when displaying the font on a light background such as white.
/// </para>
/// </summary>

	HB_OT_COLOR_PALETTE_FLAG_USABLE_WITH_LIGHT_BACKGROUND = 1,
/// <summary>
/// <para>
/// Flag indicating that the color
///   palette is appropriate to use when displaying the font on a dark background such as black.
/// </para>
/// </summary>

	HB_OT_COLOR_PALETTE_FLAG_USABLE_WITH_DARK_BACKGROUND = 2
}
