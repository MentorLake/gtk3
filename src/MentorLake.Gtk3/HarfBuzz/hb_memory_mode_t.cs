namespace MentorLake.HarfBuzz;

[Flags]
public enum hb_memory_mode_t
{
	HB_MEMORY_MODE_DUPLICATE = 0,
	HB_MEMORY_MODE_READONLY = 1,
	HB_MEMORY_MODE_WRITABLE = 2,
	HB_MEMORY_MODE_READONLY_MAY_MAKE_WRITABLE = 3
}
