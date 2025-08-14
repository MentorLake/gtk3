namespace MentorLake.GObject;

/// <summary>
/// <para>
/// These flags used to be passed to g_type_init_with_debug_flags() which
/// is now deprecated.
/// </para>
/// <para>
/// If you need to enable debugging features, use the `GOBJECT_DEBUG`
/// environment variable.
/// </para>
/// </summary>

[Flags]
public enum GTypeDebugFlags : uint
{
/// <summary>
/// <para>
/// Print no messages
/// </para>
/// </summary>

	G_TYPE_DEBUG_NONE = 0,
/// <summary>
/// <para>
/// Print messages about object bookkeeping
/// </para>
/// </summary>

	G_TYPE_DEBUG_OBJECTS = 1,
/// <summary>
/// <para>
/// Print messages about signal emissions
/// </para>
/// </summary>

	G_TYPE_DEBUG_SIGNALS = 2,
/// <summary>
/// <para>
/// Keep a count of instances of each type
/// </para>
/// </summary>

	G_TYPE_DEBUG_INSTANCE_COUNT = 4,
/// <summary>
/// <para>
/// Mask covering all debug flags
/// </para>
/// </summary>

	G_TYPE_DEBUG_MASK = 7
}
