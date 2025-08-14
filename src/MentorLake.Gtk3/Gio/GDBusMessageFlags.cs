namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Message flags used in #GDBusMessage.
/// </para>
/// </summary>

[Flags]
public enum GDBusMessageFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// A reply is not expected.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_FLAGS_NO_REPLY_EXPECTED = 1,
/// <summary>
/// <para>
/// The bus must not launch an
/// owner for the destination name in response to this message.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_FLAGS_NO_AUTO_START = 2,
/// <summary>
/// <para>
/// If set on a method
/// call, this flag means that the caller is prepared to wait for interactive
/// authorization. Since 2.46.
/// </para>
/// </summary>

	G_DBUS_MESSAGE_FLAGS_ALLOW_INTERACTIVE_AUTHORIZATION = 4
}
