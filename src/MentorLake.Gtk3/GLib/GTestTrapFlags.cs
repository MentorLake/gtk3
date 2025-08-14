namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags to pass to [func@GLib.test_trap_fork] to control input and output.
/// </para>
/// <para>
/// Test traps are guards around forked tests. These flags determine what traps to set.
/// </para>
/// </summary>

[Flags]
public enum GTestTrapFlags : uint
{
/// <summary>
/// <para>
/// Default behaviour. Since: 2.74
/// </para>
/// </summary>

	G_TEST_TRAP_DEFAULT = 0,
/// <summary>
/// <para>
/// Redirect stdout of the test child to
///     `/dev/null` so it cannot be observed on the console during test
///     runs. The actual output is still captured though to allow later
///     tests with g_test_trap_assert_stdout().
/// </para>
/// </summary>

	G_TEST_TRAP_SILENCE_STDOUT = 128,
/// <summary>
/// <para>
/// Redirect stderr of the test child to
///     `/dev/null` so it cannot be observed on the console during test
///     runs. The actual output is still captured though to allow later
///     tests with g_test_trap_assert_stderr().
/// </para>
/// </summary>

	G_TEST_TRAP_SILENCE_STDERR = 256,
/// <summary>
/// <para>
/// If this flag is given, stdin of the
///     child process is shared with stdin of its parent process.
///     It is redirected to `/dev/null` otherwise.
/// </para>
/// </summary>

	G_TEST_TRAP_INHERIT_STDIN = 512
}
