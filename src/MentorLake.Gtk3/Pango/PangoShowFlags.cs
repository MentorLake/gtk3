namespace MentorLake.Pango;

[Flags]
public enum PangoShowFlags : uint
{
	PANGO_SHOW_NONE = 0,
	PANGO_SHOW_SPACES = 1,
	PANGO_SHOW_LINE_BREAKS = 2,
	PANGO_SHOW_IGNORABLES = 4
}
