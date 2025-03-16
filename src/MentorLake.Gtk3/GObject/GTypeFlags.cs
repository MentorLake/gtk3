namespace MentorLake.GObject;

[Flags]
public enum GTypeFlags : long
{
	G_TYPE_FLAG_NONE = 0,
	G_TYPE_FLAG_ABSTRACT = 16,
	G_TYPE_FLAG_VALUE_ABSTRACT = 32,
	G_TYPE_FLAG_FINAL = 64,
	G_TYPE_FLAG_DEPRECATED = 128
}
