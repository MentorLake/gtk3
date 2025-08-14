namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Memory availability warning levels.
/// </para>
/// <para>
/// Note that because new values might be added, it is recommended that applications check
/// #GMemoryMonitorWarningLevel as ranges, for example:
/// |[<!-- language="C" -->
/// if (warning_level > G_MEMORY_MONITOR_WARNING_LEVEL_LOW)
///   drop_caches ();
/// ]|
/// </para>
/// </summary>

[Flags]
public enum GMemoryMonitorWarningLevel
{
/// <summary>
/// <para>
/// Memory on the device is low, processes
///   should free up unneeded resources (for example, in-memory caches) so they can
///   be used elsewhere.
/// </para>
/// </summary>

	G_MEMORY_MONITOR_WARNING_LEVEL_LOW = 50,
/// <summary>
/// <para>
/// Same as @G_MEMORY_MONITOR_WARNING_LEVEL_LOW
///   but the device has even less free memory, so processes should try harder to free
///   up unneeded resources. If your process does not need to stay running, it is a
///   good time for it to quit.
/// </para>
/// </summary>

	G_MEMORY_MONITOR_WARNING_LEVEL_MEDIUM = 100,
/// <summary>
/// <para>
/// The system will soon start terminating
///   processes to reclaim memory, including background processes.
/// </para>
/// </summary>

	G_MEMORY_MONITOR_WARNING_LEVEL_CRITICAL = 255
}
