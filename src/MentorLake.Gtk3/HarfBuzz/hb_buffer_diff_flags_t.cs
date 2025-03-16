namespace MentorLake.HarfBuzz;

[Flags]
public enum hb_buffer_diff_flags_t : long
{
	HB_BUFFER_DIFF_FLAG_EQUAL = 0,
	HB_BUFFER_DIFF_FLAG_CONTENT_TYPE_MISMATCH = 1,
	HB_BUFFER_DIFF_FLAG_LENGTH_MISMATCH = 2,
	HB_BUFFER_DIFF_FLAG_NOTDEF_PRESENT = 4,
	HB_BUFFER_DIFF_FLAG_DOTTED_CIRCLE_PRESENT = 8,
	HB_BUFFER_DIFF_FLAG_CODEPOINT_MISMATCH = 16,
	HB_BUFFER_DIFF_FLAG_CLUSTER_MISMATCH = 32,
	HB_BUFFER_DIFF_FLAG_GLYPH_FLAGS_MISMATCH = 64,
	HB_BUFFER_DIFF_FLAG_POSITION_MISMATCH = 128
}
