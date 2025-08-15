namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by spawning processes.
/// </para>
/// </summary>

[Flags]
public enum GSpawnError
{
/// <summary>
/// <para>
/// Fork failed due to lack of memory.
/// </para>
/// </summary>

	G_SPAWN_ERROR_FORK = 0,
/// <summary>
/// <para>
/// Read or select on pipes failed.
/// </para>
/// </summary>

	G_SPAWN_ERROR_READ = 1,
/// <summary>
/// <para>
/// Changing to working directory failed.
/// </para>
/// </summary>

	G_SPAWN_ERROR_CHDIR = 2,
/// <summary>
/// <para>
/// execv() returned `EACCES`
/// </para>
/// </summary>

	G_SPAWN_ERROR_ACCES = 3,
/// <summary>
/// <para>
/// execv() returned `EPERM`
/// </para>
/// </summary>

	G_SPAWN_ERROR_PERM = 4,
/// <summary>
/// <para>
/// execv() returned `E2BIG`
/// </para>
/// </summary>

	G_SPAWN_ERROR_TOO_BIG = 5,
/// <summary>
/// <para>
/// deprecated alias for %G_SPAWN_ERROR_TOO_BIG (deprecated since GLib 2.32)
/// </para>
/// </summary>

	G_SPAWN_ERROR_2BIG = 5,
/// <summary>
/// <para>
/// execv() returned `ENOEXEC`
/// </para>
/// </summary>

	G_SPAWN_ERROR_NOEXEC = 6,
/// <summary>
/// <para>
/// execv() returned `ENAMETOOLONG`
/// </para>
/// </summary>

	G_SPAWN_ERROR_NAMETOOLONG = 7,
/// <summary>
/// <para>
/// execv() returned `ENOENT`
/// </para>
/// </summary>

	G_SPAWN_ERROR_NOENT = 8,
/// <summary>
/// <para>
/// execv() returned `ENOMEM`
/// </para>
/// </summary>

	G_SPAWN_ERROR_NOMEM = 9,
/// <summary>
/// <para>
/// execv() returned `ENOTDIR`
/// </para>
/// </summary>

	G_SPAWN_ERROR_NOTDIR = 10,
/// <summary>
/// <para>
/// execv() returned `ELOOP`
/// </para>
/// </summary>

	G_SPAWN_ERROR_LOOP = 11,
/// <summary>
/// <para>
/// execv() returned `ETXTBUSY`
/// </para>
/// </summary>

	G_SPAWN_ERROR_TXTBUSY = 12,
/// <summary>
/// <para>
/// execv() returned `EIO`
/// </para>
/// </summary>

	G_SPAWN_ERROR_IO = 13,
/// <summary>
/// <para>
/// execv() returned `ENFILE`
/// </para>
/// </summary>

	G_SPAWN_ERROR_NFILE = 14,
/// <summary>
/// <para>
/// execv() returned `EMFILE`
/// </para>
/// </summary>

	G_SPAWN_ERROR_MFILE = 15,
/// <summary>
/// <para>
/// execv() returned `EINVAL`
/// </para>
/// </summary>

	G_SPAWN_ERROR_INVAL = 16,
/// <summary>
/// <para>
/// execv() returned `EISDIR`
/// </para>
/// </summary>

	G_SPAWN_ERROR_ISDIR = 17,
/// <summary>
/// <para>
/// execv() returned `ELIBBAD`
/// </para>
/// </summary>

	G_SPAWN_ERROR_LIBBAD = 18,
/// <summary>
/// <para>
/// Some other fatal failure,
///   `error-&amp;gt;message` should explain.
/// </para>
/// </summary>

	G_SPAWN_ERROR_FAILED = 19
}
