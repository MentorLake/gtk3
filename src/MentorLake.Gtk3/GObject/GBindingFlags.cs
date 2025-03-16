namespace MentorLake.GObject;

[Flags]
public enum GBindingFlags : long
{
	G_BINDING_DEFAULT = 0,
	G_BINDING_BIDIRECTIONAL = 1,
	G_BINDING_SYNC_CREATE = 2,
	G_BINDING_INVERT_BOOLEAN = 4
}
