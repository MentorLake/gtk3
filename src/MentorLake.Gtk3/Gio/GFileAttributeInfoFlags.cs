namespace MentorLake.Gio;

[Flags]
public enum GFileAttributeInfoFlags : long
{
	G_FILE_ATTRIBUTE_INFO_NONE = 0,
	G_FILE_ATTRIBUTE_INFO_COPY_WITH_FILE = 1,
	G_FILE_ATTRIBUTE_INFO_COPY_WHEN_MOVED = 2
}
