namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Enumeration used to describe the byte order of a D-Bus message.
/// </para>
/// </summary>

[Flags]
public enum GDBusMessageByteOrder
{
/// <summary>
/// <para>
/// The byte order is big endian.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_BYTE_ORDER_BIG_ENDIAN = 66,
/// <summary>
/// <para>
/// The byte order is little endian.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_BYTE_ORDER_LITTLE_ENDIAN = 108
}
