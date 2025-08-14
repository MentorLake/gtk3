namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when creating a #GDBusServer.
/// </para>
/// </summary>

[Flags]
public enum GDBusServerFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_SERVER_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// All #GDBusServer::new-connection
/// signals will run in separated dedicated threads (see signal for
/// details).
/// </para>
/// </summary>

	G_DBUS_SERVER_FLAGS_RUN_IN_THREAD = 1,
/// <summary>
/// <para>
/// Allow the anonymous
/// authentication method.
/// </para>
/// </summary>

	G_DBUS_SERVER_FLAGS_AUTHENTICATION_ALLOW_ANONYMOUS = 2,
/// <summary>
/// <para>
/// Require the UID of the
/// peer to be the same as the UID of the server when authenticating. (Since: 2.68)
/// </para>
/// </summary>

	G_DBUS_SERVER_FLAGS_AUTHENTICATION_REQUIRE_SAME_USER = 4
}
