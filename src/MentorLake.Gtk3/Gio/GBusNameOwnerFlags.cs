namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used in g_bus_own_name().
/// </para>
/// </summary>

[Flags]
public enum GBusNameOwnerFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_BUS_NAME_OWNER_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Allow another message bus connection to claim the name.
/// </para>
/// </summary>

	G_BUS_NAME_OWNER_FLAGS_ALLOW_REPLACEMENT = 1,
/// <summary>
/// <para>
/// If another message bus connection owns the name and have
/// specified %G_BUS_NAME_OWNER_FLAGS_ALLOW_REPLACEMENT, then take the name from the other connection.
/// </para>
/// </summary>

	G_BUS_NAME_OWNER_FLAGS_REPLACE = 2,
/// <summary>
/// <para>
/// If another message bus connection owns the name, immediately
/// return an error from g_bus_own_name() rather than entering the waiting queue for that name. (Since 2.54)
/// </para>
/// </summary>

	G_BUS_NAME_OWNER_FLAGS_DO_NOT_QUEUE = 4
}
