namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags passed to g_dbus_connection_register_subtree().
/// </para>
/// </summary>

[Flags]
public enum GDBusSubtreeFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_SUBTREE_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Method calls to objects not in the enumerated range
///                                                       will still be dispatched. This is useful if you want
///                                                       to dynamically spawn objects in the subtree.
/// </para>
/// </summary>

	G_DBUS_SUBTREE_FLAGS_DISPATCH_TO_UNENUMERATED_NODES = 1
}
