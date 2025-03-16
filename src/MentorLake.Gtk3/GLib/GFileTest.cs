namespace MentorLake.GLib;

[Flags]
public enum GFileTest : long
{
	G_FILE_TEST_IS_REGULAR = 1,
	G_FILE_TEST_IS_SYMLINK = 2,
	G_FILE_TEST_IS_DIR = 4,
	G_FILE_TEST_IS_EXECUTABLE = 8,
	G_FILE_TEST_EXISTS = 16
}
