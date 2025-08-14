namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags passed to g_spawn_sync(), g_spawn_async() and g_spawn_async_with_pipes().
/// </para>
/// </summary>

[Flags]
public enum GSpawnFlags : uint
{
/// <summary>
/// <para>
/// no flags, default behaviour
/// </para>
/// </summary>

	G_SPAWN_DEFAULT = 0,
/// <summary>
/// <para>
/// the parent's open file descriptors will
///     be inherited by the child; otherwise all descriptors except stdin,
///     stdout and stderr will be closed before calling exec() in the child.
/// </para>
/// </summary>

	G_SPAWN_LEAVE_DESCRIPTORS_OPEN = 1,
/// <summary>
/// <para>
/// the child will not be automatically reaped;
///     you must use g_child_watch_add() yourself (or call waitpid() or handle
///     `SIGCHLD` yourself), or the child will become a zombie.
/// </para>
/// </summary>

	G_SPAWN_DO_NOT_REAP_CHILD = 2,
/// <summary>
/// <para>
/// `argv[0]` need not be an absolute path, it will be
///     looked for in the user's `PATH`.
/// </para>
/// </summary>

	G_SPAWN_SEARCH_PATH = 4,
/// <summary>
/// <para>
/// the child's standard output will be discarded,
///     instead of going to the same location as the parent's standard output.
/// </para>
/// </summary>

	G_SPAWN_STDOUT_TO_DEV_NULL = 8,
/// <summary>
/// <para>
/// the child's standard error will be discarded.
/// </para>
/// </summary>

	G_SPAWN_STDERR_TO_DEV_NULL = 16,
/// <summary>
/// <para>
/// the child will inherit the parent's standard
///     input (by default, the child's standard input is attached to `/dev/null`).
/// </para>
/// </summary>

	G_SPAWN_CHILD_INHERITS_STDIN = 32,
/// <summary>
/// <para>
/// the first element of `argv` is the file to
///     execute, while the remaining elements are the actual argument vector
///     to pass to the file. Normally g_spawn_async_with_pipes() uses `argv[0]`
///     as the file to execute, and passes all of `argv` to the child.
/// </para>
/// </summary>

	G_SPAWN_FILE_AND_ARGV_ZERO = 64,
/// <summary>
/// <para>
/// if `argv[0]` is not an absolute path,
///     it will be looked for in the `PATH` from the passed child environment.
///     Since: 2.34
/// </para>
/// </summary>

	G_SPAWN_SEARCH_PATH_FROM_ENVP = 128,
/// <summary>
/// <para>
/// create all pipes with the `O_CLOEXEC` flag set.
///     Since: 2.40
/// </para>
/// </summary>

	G_SPAWN_CLOEXEC_PIPES = 256,
/// <summary>
/// <para>
/// The child will inherit the parent's standard output.
/// </para>
/// </summary>

	G_SPAWN_CHILD_INHERITS_STDOUT = 512,
/// <summary>
/// <para>
/// The child will inherit the parent's standard error.
/// </para>
/// </summary>

	G_SPAWN_CHILD_INHERITS_STDERR = 1024,
/// <summary>
/// <para>
/// The child's standard input is attached to `/dev/null`.
/// </para>
/// </summary>

	G_SPAWN_STDIN_FROM_DEV_NULL = 2048
}
