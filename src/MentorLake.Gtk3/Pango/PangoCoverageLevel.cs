namespace MentorLake.Pango;

[Flags]
public enum PangoCoverageLevel
{
	PANGO_COVERAGE_NONE = 0,
	PANGO_COVERAGE_FALLBACK = 1,
	PANGO_COVERAGE_APPROXIMATE = 2,
	PANGO_COVERAGE_EXACT = 3
}
