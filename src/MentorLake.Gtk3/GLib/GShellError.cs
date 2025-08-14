namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by shell functions.
/// </para>
/// </summary>

[Flags]
public enum GShellError
{
/// <summary>
/// <para>
/// Mismatched or otherwise mangled quoting.
/// </para>
/// </summary>

	G_SHELL_ERROR_BAD_QUOTING = 0,
/// <summary>
/// <para>
/// String to be parsed was empty.
/// </para>
/// </summary>

	G_SHELL_ERROR_EMPTY_STRING = 1,
/// <summary>
/// <para>
/// Some other error.
/// </para>
/// </summary>

	G_SHELL_ERROR_FAILED = 2
}
