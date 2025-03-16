namespace MentorLake.HarfBuzz;

[Flags]
public enum hb_direction_t
{
	HB_DIRECTION_INVALID = 0,
	HB_DIRECTION_LTR = 4,
	HB_DIRECTION_RTL = 5,
	HB_DIRECTION_TTB = 6,
	HB_DIRECTION_BTT = 7
}
