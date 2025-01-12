namespace MentorLake.Gtk3.GLib;

[Flags]
public enum GMarkupCollectType
{
	G_MARKUP_COLLECT_INVALID = 0,
	G_MARKUP_COLLECT_STRING = 1,
	G_MARKUP_COLLECT_STRDUP = 2,
	G_MARKUP_COLLECT_BOOLEAN = 4,
	G_MARKUP_COLLECT_TRISTATE = 8,
	G_MARKUP_COLLECT_OPTIONAL = 16
}
