namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The possible statuses of a one-time initialization function
/// controlled by a #GOnce struct.
/// </para>
/// </summary>

[Flags]
public enum GOnceStatus
{
/// <summary>
/// <para>
/// the function has not been called yet.
/// </para>
/// </summary>

	G_ONCE_STATUS_NOTCALLED = 0,
/// <summary>
/// <para>
/// the function call is currently in progress.
/// </para>
/// </summary>

	G_ONCE_STATUS_PROGRESS = 1,
/// <summary>
/// <para>
/// the function has been called.
/// </para>
/// </summary>

	G_ONCE_STATUS_READY = 2
}
