namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when sending #GDBusMessages on a #GDBusConnection.
/// </para>
/// </summary>

[Flags]
public enum GDBusSendMessageFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_SEND_MESSAGE_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Do not automatically
/// assign a serial number from the #GDBusConnection object when
/// sending a message.
/// </para>
/// </summary>

	G_DBUS_SEND_MESSAGE_FLAGS_PRESERVE_SERIAL = 1
}
