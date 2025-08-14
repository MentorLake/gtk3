namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Statuses returned by most of the #GIOFuncs functions.
/// </para>
/// </summary>

[Flags]
public enum GIOStatus
{
/// <summary>
/// <para>
/// An error occurred.
/// </para>
/// </summary>

	G_IO_STATUS_ERROR = 0,
/// <summary>
/// <para>
/// Success.
/// </para>
/// </summary>

	G_IO_STATUS_NORMAL = 1,
/// <summary>
/// <para>
/// End of file.
/// </para>
/// </summary>

	G_IO_STATUS_EOF = 2,
/// <summary>
/// <para>
/// Resource temporarily unavailable.
/// </para>
/// </summary>

	G_IO_STATUS_AGAIN = 3
}
