namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used to set what a #GFileMonitor will watch for.
/// </para>
/// </summary>

[Flags]
public enum GFileMonitorFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_FILE_MONITOR_NONE = 0,
/// <summary>
/// <para>
/// Watch for mount events.
/// </para>
/// </summary>

	G_FILE_MONITOR_WATCH_MOUNTS = 1,
/// <summary>
/// <para>
/// Pair DELETED and CREATED events caused
///   by file renames (moves) and send a single G_FILE_MONITOR_EVENT_MOVED
///   event instead (NB: not supported on all backends; the default
///   behaviour -without specifying this flag- is to send single DELETED
///   and CREATED events).  Deprecated since 2.46: use
///   %G_FILE_MONITOR_WATCH_MOVES instead.
/// </para>
/// </summary>

	G_FILE_MONITOR_SEND_MOVED = 2,
/// <summary>
/// <para>
/// Watch for changes to the file made
///   via another hard link. Since 2.36.
/// </para>
/// </summary>

	G_FILE_MONITOR_WATCH_HARD_LINKS = 4,
/// <summary>
/// <para>
/// Watch for rename operations on a
///   monitored directory.  This causes %G_FILE_MONITOR_EVENT_RENAMED,
///   %G_FILE_MONITOR_EVENT_MOVED_IN and %G_FILE_MONITOR_EVENT_MOVED_OUT
///   events to be emitted when possible.  Since: 2.46.
/// </para>
/// </summary>

	G_FILE_MONITOR_WATCH_MOVES = 8
}
