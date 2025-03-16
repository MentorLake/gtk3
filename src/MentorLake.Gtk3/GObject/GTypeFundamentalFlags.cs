namespace MentorLake.GObject;

[Flags]
public enum GTypeFundamentalFlags : long
{
	G_TYPE_FLAG_CLASSED = 1,
	G_TYPE_FLAG_INSTANTIATABLE = 2,
	G_TYPE_FLAG_DERIVABLE = 4,
	G_TYPE_FLAG_DEEP_DERIVABLE = 8
}
