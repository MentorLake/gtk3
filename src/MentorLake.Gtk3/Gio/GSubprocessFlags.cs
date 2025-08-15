namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags to define the behaviour of a #GSubprocess.
/// </para>
/// <para>
/// Note that the default for stdin is to redirect from `/dev/null`.  For
/// stdout and stderr the default are for them to inherit the
/// corresponding descriptor from the calling process.
/// </para>
/// <para>
/// Note that it is a programmer error to mix &apos;incompatible&apos; flags.  For
/// example, you may not request both %G_SUBPROCESS_FLAGS_STDOUT_PIPE and
/// %G_SUBPROCESS_FLAGS_STDOUT_SILENCE.
/// </para>
/// </summary>

[Flags]
public enum GSubprocessFlags : uint
{
/// <summary>
/// <para>
/// No flags.
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// create a pipe for the stdin of the
///   spawned process that can be accessed with
///   g_subprocess_get_stdin_pipe().
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_STDIN_PIPE = 1,
/// <summary>
/// <para>
/// stdin is inherited from the
///   calling process.
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_STDIN_INHERIT = 2,
/// <summary>
/// <para>
/// create a pipe for the stdout of the
///   spawned process that can be accessed with
///   g_subprocess_get_stdout_pipe().
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_STDOUT_PIPE = 4,
/// <summary>
/// <para>
/// silence the stdout of the spawned
///   process (ie: redirect to `/dev/null`).
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_STDOUT_SILENCE = 8,
/// <summary>
/// <para>
/// create a pipe for the stderr of the
///   spawned process that can be accessed with
///   g_subprocess_get_stderr_pipe().
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_STDERR_PIPE = 16,
/// <summary>
/// <para>
/// silence the stderr of the spawned
///   process (ie: redirect to `/dev/null`).
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_STDERR_SILENCE = 32,
/// <summary>
/// <para>
/// merge the stderr of the spawned
///   process with whatever the stdout happens to be.  This is a good way
///   of directing both streams to a common log file, for example.
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_STDERR_MERGE = 64,
/// <summary>
/// <para>
/// spawned processes will inherit the
///   file descriptors of their parent, unless those descriptors have
///   been explicitly marked as close-on-exec.  This flag has no effect
///   over the &quot;standard&quot; file descriptors (stdin, stdout, stderr).
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_INHERIT_FDS = 128,
/// <summary>
/// <para>
/// if path searching is
///   needed when spawning the subprocess, use the `PATH` in the launcher
///   environment. (Since: 2.72)
/// </para>
/// </summary>

	G_SUBPROCESS_FLAGS_SEARCH_PATH_FROM_ENVP = 256
}
