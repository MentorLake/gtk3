namespace MentorLake.GLib;

[Flags]
public enum GMarkupCollectType : long
{
	G_MARKUP_COLLECT_INVALID = 0,
	G_MARKUP_COLLECT_STRING = 1,
	G_MARKUP_COLLECT_STRDUP = 2,
	G_MARKUP_COLLECT_BOOLEAN = 3,
	G_MARKUP_COLLECT_TRISTATE = 4,
	G_MARKUP_COLLECT_OPTIONAL = 65536
}
