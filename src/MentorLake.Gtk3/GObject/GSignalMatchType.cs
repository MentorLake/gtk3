namespace MentorLake.GObject;

[Flags]
public enum GSignalMatchType : long
{
	G_SIGNAL_MATCH_ID = 1,
	G_SIGNAL_MATCH_DETAIL = 2,
	G_SIGNAL_MATCH_CLOSURE = 4,
	G_SIGNAL_MATCH_FUNC = 8,
	G_SIGNAL_MATCH_DATA = 16,
	G_SIGNAL_MATCH_UNBLOCKED = 32
}
