namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used in g_bus_watch_name().
/// </para>
/// </summary>

[Flags]
public enum GBusNameWatcherFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_BUS_NAME_WATCHER_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// If no-one owns the name when
/// beginning to watch the name, ask the bus to launch an owner for the
/// name.
/// </para>
/// </summary>

	G_BUS_NAME_WATCHER_FLAGS_AUTO_START = 1
}
