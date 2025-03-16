namespace MentorLake.GLib;

[Flags]
public enum GFileSetContentsFlags : long
{
	G_FILE_SET_CONTENTS_NONE = 0,
	G_FILE_SET_CONTENTS_CONSISTENT = 1,
	G_FILE_SET_CONTENTS_DURABLE = 2,
	G_FILE_SET_CONTENTS_ONLY_EXISTING = 4
}
