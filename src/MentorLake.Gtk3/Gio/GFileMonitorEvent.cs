namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Specifies what type of event a monitor event is.
/// </para>
/// </summary>

[Flags]
public enum GFileMonitorEvent
{
/// <summary>
/// <para>
/// a file changed.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_CHANGED = 0,
/// <summary>
/// <para>
/// a hint that this was probably the last change in a set of changes.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_CHANGES_DONE_HINT = 1,
/// <summary>
/// <para>
/// a file was deleted.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_DELETED = 2,
/// <summary>
/// <para>
/// a file was created.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_CREATED = 3,
/// <summary>
/// <para>
/// a file attribute was changed.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_ATTRIBUTE_CHANGED = 4,
/// <summary>
/// <para>
/// the file location will soon be unmounted.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_PRE_UNMOUNT = 5,
/// <summary>
/// <para>
/// the file location was unmounted.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_UNMOUNTED = 6,
/// <summary>
/// <para>
/// the file was moved -- only sent if the
///   (deprecated) %G_FILE_MONITOR_SEND_MOVED flag is set
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_MOVED = 7,
/// <summary>
/// <para>
/// the file was renamed within the
///   current directory -- only sent if the %G_FILE_MONITOR_WATCH_MOVES
///   flag is set.  Since: 2.46.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_RENAMED = 8,
/// <summary>
/// <para>
/// the file was moved into the
///   monitored directory from another location -- only sent if the
///   %G_FILE_MONITOR_WATCH_MOVES flag is set.  Since: 2.46.
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_MOVED_IN = 9,
/// <summary>
/// <para>
/// the file was moved out of the
///   monitored directory to another location -- only sent if the
///   %G_FILE_MONITOR_WATCH_MOVES flag is set.  Since: 2.46
/// </para>
/// </summary>

	G_FILE_MONITOR_EVENT_MOVED_OUT = 10
}
