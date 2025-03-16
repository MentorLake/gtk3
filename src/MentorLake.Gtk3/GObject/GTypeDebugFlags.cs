namespace MentorLake.GObject;

[Flags]
public enum GTypeDebugFlags : long
{
	G_TYPE_DEBUG_NONE = 0,
	G_TYPE_DEBUG_OBJECTS = 1,
	G_TYPE_DEBUG_SIGNALS = 2,
	G_TYPE_DEBUG_INSTANCE_COUNT = 4,
	G_TYPE_DEBUG_MASK = 7
}
