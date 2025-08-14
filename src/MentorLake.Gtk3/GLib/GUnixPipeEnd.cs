namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Mnemonic constants for the ends of a Unix pipe.
/// </para>
/// </summary>

[Flags]
public enum GUnixPipeEnd
{
/// <summary>
/// <para>
/// The readable file descriptor 0
/// </para>
/// </summary>

	G_UNIX_PIPE_END_READ = 0,
/// <summary>
/// <para>
/// The writable file descriptor 1
/// </para>
/// </summary>

	G_UNIX_PIPE_END_WRITE = 1
}
