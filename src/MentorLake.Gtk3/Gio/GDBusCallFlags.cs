namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used in g_dbus_connection_call() and similar APIs.
/// </para>
/// </summary>

[Flags]
public enum GDBusCallFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_CALL_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// The bus must not launch
/// an owner for the destination name in response to this method
/// invocation.
/// </para>
/// </summary>

	G_DBUS_CALL_FLAGS_NO_AUTO_START = 1,
/// <summary>
/// <para>
/// the caller is prepared to
/// wait for interactive authorization. Since 2.46.
/// </para>
/// </summary>

	G_DBUS_CALL_FLAGS_ALLOW_INTERACTIVE_AUTHORIZATION = 2
}
