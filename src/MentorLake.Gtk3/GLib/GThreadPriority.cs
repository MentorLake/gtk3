namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Thread priorities.
/// </para>
/// </summary>

[Flags]
public enum GThreadPriority
{
/// <summary>
/// <para>
/// a priority lower than normal
/// </para>
/// </summary>

	G_THREAD_PRIORITY_LOW = 0,
/// <summary>
/// <para>
/// the default priority
/// </para>
/// </summary>

	G_THREAD_PRIORITY_NORMAL = 1,
/// <summary>
/// <para>
/// a priority higher than normal
/// </para>
/// </summary>

	G_THREAD_PRIORITY_HIGH = 2,
/// <summary>
/// <para>
/// the highest priority
/// </para>
/// </summary>

	G_THREAD_PRIORITY_URGENT = 3
}
