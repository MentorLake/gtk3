namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Capabilities negotiated with the remote peer.
/// </para>
/// </summary>

[Flags]
public enum GDBusCapabilityFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_CAPABILITY_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// The connection
/// supports exchanging UNIX file descriptors with the remote peer.
/// </para>
/// </summary>

	G_DBUS_CAPABILITY_FLAGS_UNIX_FD_PASSING = 1
}
