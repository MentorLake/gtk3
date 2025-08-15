namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags to pass to [func@GLib.test_trap_subprocess] to control input and output.
/// </para>
/// <para>
/// Note that in contrast with [func@GLib.test_trap_fork], the default
/// behavior of [func@GLib.test_trap_subprocess] is to not show stdout
/// and stderr.
/// </para>
/// </summary>

[Flags]
public enum GTestSubprocessFlags : uint
{
/// <summary>
/// <para>
/// Default behaviour. Since: 2.74
/// </para>
/// </summary>

	G_TEST_SUBPROCESS_DEFAULT = 0,
/// <summary>
/// <para>
/// If this flag is given, the child
///   process will inherit the parent&apos;s stdin. Otherwise, the child&apos;s
///   stdin is redirected to `/dev/null`.
/// </para>
/// </summary>

	G_TEST_SUBPROCESS_INHERIT_STDIN = 1,
/// <summary>
/// <para>
/// If this flag is given, the child
///   process will inherit the parent&apos;s stdout. Otherwise, the child&apos;s
///   stdout will not be visible, but it will be captured to allow
///   later tests with [func@GLib.test_trap_assert_stdout].
/// </para>
/// </summary>

	G_TEST_SUBPROCESS_INHERIT_STDOUT = 2,
/// <summary>
/// <para>
/// If this flag is given, the child
///   process will inherit the parent&apos;s stderr. Otherwise, the child&apos;s
///   stderr will not be visible, but it will be captured to allow
///   later tests with [func@GLib.test_trap_assert_stderr].
/// </para>
/// </summary>

	G_TEST_SUBPROCESS_INHERIT_STDERR = 4
}
