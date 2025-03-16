namespace MentorLake.HarfBuzz;

[Flags]
public enum hb_glyph_flags_t : long
{
	HB_GLYPH_FLAG_UNSAFE_TO_BREAK = 1,
	HB_GLYPH_FLAG_UNSAFE_TO_CONCAT = 2,
	HB_GLYPH_FLAG_SAFE_TO_INSERT_TATWEEL = 4,
	HB_GLYPH_FLAG_DEFINED = 7
}
