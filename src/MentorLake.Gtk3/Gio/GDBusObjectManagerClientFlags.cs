namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when constructing a #GDBusObjectManagerClient.
/// </para>
/// </summary>

[Flags]
public enum GDBusObjectManagerClientFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_OBJECT_MANAGER_CLIENT_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// If not set and the
///   manager is for a well-known name, then request the bus to launch
///   an owner for the name if no-one owns the name. This flag can only
///   be used in managers for well-known names.
/// </para>
/// </summary>

	G_DBUS_OBJECT_MANAGER_CLIENT_FLAGS_DO_NOT_AUTO_START = 1
}
