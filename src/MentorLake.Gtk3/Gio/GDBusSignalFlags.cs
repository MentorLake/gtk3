namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when subscribing to signals via g_dbus_connection_signal_subscribe().
/// </para>
/// </summary>

[Flags]
public enum GDBusSignalFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_SIGNAL_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Don't actually send the AddMatch
/// D-Bus call for this signal subscription.  This gives you more control
/// over which match rules you add (but you must add them manually).
/// </para>
/// </summary>

	G_DBUS_SIGNAL_FLAGS_NO_MATCH_RULE = 1,
/// <summary>
/// <para>
/// Match first arguments that
/// contain a bus or interface name with the given namespace.
/// </para>
/// </summary>

	G_DBUS_SIGNAL_FLAGS_MATCH_ARG0_NAMESPACE = 2,
/// <summary>
/// <para>
/// Match first arguments that
/// contain an object path that is either equivalent to the given path,
/// or one of the paths is a subpath of the other.
/// </para>
/// </summary>

	G_DBUS_SIGNAL_FLAGS_MATCH_ARG0_PATH = 4
}
