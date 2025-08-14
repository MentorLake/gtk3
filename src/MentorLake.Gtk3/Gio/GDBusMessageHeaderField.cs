namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Header fields used in #GDBusMessage.
/// </para>
/// </summary>

[Flags]
public enum GDBusMessageHeaderField
{
/// <summary>
/// <para>
/// Not a valid header field.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_INVALID = 0,
/// <summary>
/// <para>
/// The object path.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_PATH = 1,
/// <summary>
/// <para>
/// The interface name.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_INTERFACE = 2,
/// <summary>
/// <para>
/// The method or signal name.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_MEMBER = 3,
/// <summary>
/// <para>
/// The name of the error that occurred.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_ERROR_NAME = 4,
/// <summary>
/// <para>
/// The serial number the message is a reply to.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_REPLY_SERIAL = 5,
/// <summary>
/// <para>
/// The name the message is intended for.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_DESTINATION = 6,
/// <summary>
/// <para>
/// Unique name of the sender of the message (filled in by the bus).
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_SENDER = 7,
/// <summary>
/// <para>
/// The signature of the message body.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_SIGNATURE = 8,
/// <summary>
/// <para>
/// The number of UNIX file descriptors that accompany the message.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_HEADER_FIELD_NUM_UNIX_FDS = 9
}
