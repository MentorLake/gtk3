namespace MentorLake.GObject;

[Flags]
public enum GSignalFlags : long
{
	G_SIGNAL_RUN_FIRST = 1,
	G_SIGNAL_RUN_LAST = 2,
	G_SIGNAL_RUN_CLEANUP = 4,
	G_SIGNAL_NO_RECURSE = 8,
	G_SIGNAL_DETAILED = 16,
	G_SIGNAL_ACTION = 32,
	G_SIGNAL_NO_HOOKS = 64,
	G_SIGNAL_MUST_COLLECT = 128,
	G_SIGNAL_DEPRECATED = 256,
	G_SIGNAL_ACCUMULATOR_FIRST_RUN = 131072
}
