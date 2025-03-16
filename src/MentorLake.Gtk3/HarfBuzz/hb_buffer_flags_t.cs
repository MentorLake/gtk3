namespace MentorLake.HarfBuzz;

[Flags]
public enum hb_buffer_flags_t : long
{
	HB_BUFFER_FLAG_DEFAULT = 0,
	HB_BUFFER_FLAG_BOT = 1,
	HB_BUFFER_FLAG_EOT = 2,
	HB_BUFFER_FLAG_PRESERVE_DEFAULT_IGNORABLES = 4,
	HB_BUFFER_FLAG_REMOVE_DEFAULT_IGNORABLES = 8,
	HB_BUFFER_FLAG_DO_NOT_INSERT_DOTTED_CIRCLE = 16,
	HB_BUFFER_FLAG_VERIFY = 32,
	HB_BUFFER_FLAG_PRODUCE_UNSAFE_TO_CONCAT = 64,
	HB_BUFFER_FLAG_PRODUCE_SAFE_TO_INSERT_TATWEEL = 128,
	HB_BUFFER_FLAG_DEFINED = 255
}
