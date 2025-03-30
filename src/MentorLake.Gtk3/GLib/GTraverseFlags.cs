namespace MentorLake.GLib;

[Flags]
public enum GTraverseFlags : uint
{
	G_TRAVERSE_LEAVES = 1,
	G_TRAVERSE_NON_LEAVES = 2,
	G_TRAVERSE_ALL = 3,
	G_TRAVERSE_MASK = 3,
	G_TRAVERSE_LEAFS = 1,
	G_TRAVERSE_NON_LEAFS = 2
}
