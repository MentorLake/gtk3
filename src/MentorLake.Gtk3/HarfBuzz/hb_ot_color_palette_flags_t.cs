namespace MentorLake.HarfBuzz;

[Flags]
public enum hb_ot_color_palette_flags_t : long
{
	HB_OT_COLOR_PALETTE_FLAG_DEFAULT = 0,
	HB_OT_COLOR_PALETTE_FLAG_USABLE_WITH_LIGHT_BACKGROUND = 1,
	HB_OT_COLOR_PALETTE_FLAG_USABLE_WITH_DARK_BACKGROUND = 2
}
