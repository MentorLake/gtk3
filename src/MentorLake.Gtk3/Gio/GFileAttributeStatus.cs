namespace MentorLake.Gio;

[Flags]
public enum GFileAttributeStatus
{
	G_FILE_ATTRIBUTE_STATUS_UNSET = 0,
	G_FILE_ATTRIBUTE_STATUS_SET = 1,
	G_FILE_ATTRIBUTE_STATUS_ERROR_SETTING = 2
}
