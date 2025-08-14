namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when creating a new #GDBusConnection.
/// </para>
/// </summary>

[Flags]
public enum GDBusConnectionFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_CONNECTION_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Perform authentication against server.
/// </para>
/// </summary>

	G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_CLIENT = 1,
/// <summary>
/// <para>
/// Perform authentication against client.
/// </para>
/// </summary>

	G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_SERVER = 2,
/// <summary>
/// <para>
/// When
/// authenticating as a server, allow the anonymous authentication
/// method.
/// </para>
/// </summary>

	G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_ALLOW_ANONYMOUS = 4,
/// <summary>
/// <para>
/// Pass this flag if connecting to a peer that is a
/// message bus. This means that the Hello() method will be invoked as part of the connection setup.
/// </para>
/// </summary>

	G_DBUS_CONNECTION_FLAGS_MESSAGE_BUS_CONNECTION = 8,
/// <summary>
/// <para>
/// If set, processing of D-Bus messages is
/// delayed until g_dbus_connection_start_message_processing() is called.
/// </para>
/// </summary>

	G_DBUS_CONNECTION_FLAGS_DELAY_MESSAGE_PROCESSING = 16,
/// <summary>
/// <para>
/// When authenticating
/// as a server, require the UID of the peer to be the same as the UID of the server. (Since: 2.68)
/// </para>
/// </summary>

	G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_REQUIRE_SAME_USER = 32,
/// <summary>
/// <para>
/// When authenticating, try to use
///  protocols that work across a Linux user namespace boundary, even if this
///  reduces interoperability with older D-Bus implementations. This currently
///  affects client-side `EXTERNAL` authentication, for which this flag makes
///  connections to a server in another user namespace succeed, but causes
///  a deadlock when connecting to a GDBus server older than 2.73.3. Since: 2.74
/// </para>
/// </summary>

	G_DBUS_CONNECTION_FLAGS_CROSS_NAMESPACE = 64
}
