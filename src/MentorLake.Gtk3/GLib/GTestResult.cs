namespace MentorLake.GLib;

[Flags]
public enum GTestResult
{
	G_TEST_RUN_SUCCESS = 0,
	G_TEST_RUN_SKIPPED = 1,
	G_TEST_RUN_FAILURE = 2,
	G_TEST_RUN_INCOMPLETE = 3
}
