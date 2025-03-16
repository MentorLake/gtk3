namespace MentorLake.Gio;

[Flags]
public enum GFileQueryInfoFlags : long
{
	G_FILE_QUERY_INFO_NONE = 0,
	G_FILE_QUERY_INFO_NOFOLLOW_SYMLINKS = 1
}
