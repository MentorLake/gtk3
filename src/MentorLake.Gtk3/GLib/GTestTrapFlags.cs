namespace MentorLake.GLib;

[Flags]
public enum GTestTrapFlags : long
{
	G_TEST_TRAP_DEFAULT = 0,
	G_TEST_TRAP_SILENCE_STDOUT = 128,
	G_TEST_TRAP_SILENCE_STDERR = 256,
	G_TEST_TRAP_INHERIT_STDIN = 512
}
