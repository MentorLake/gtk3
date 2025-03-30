namespace MentorLake.Gio;

[Flags]
public enum GFileCreateFlags : uint
{
	G_FILE_CREATE_NONE = 0,
	G_FILE_CREATE_PRIVATE = 1,
	G_FILE_CREATE_REPLACE_DESTINATION = 2
}
