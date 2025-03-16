namespace MentorLake.cairo;

[Flags]
public enum cairo_filter_t
{
	CAIRO_FILTER_FAST = 0,
	CAIRO_FILTER_GOOD = 1,
	CAIRO_FILTER_BEST = 2,
	CAIRO_FILTER_NEAREST = 3,
	CAIRO_FILTER_BILINEAR = 4,
	CAIRO_FILTER_GAUSSIAN = 5
}
