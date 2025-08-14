namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Message types used in #GDBusMessage.
/// </para>
/// </summary>

[Flags]
public enum GDBusMessageType
{
/// <summary>
/// <para>
/// Message is of invalid type.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_TYPE_INVALID = 0,
/// <summary>
/// <para>
/// Method call.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_TYPE_METHOD_CALL = 1,
/// <summary>
/// <para>
/// Method reply.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_TYPE_METHOD_RETURN = 2,
/// <summary>
/// <para>
/// Error reply.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_TYPE_ERROR = 3,
/// <summary>
/// <para>
/// Signal emission.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_TYPE_SIGNAL = 4
}
