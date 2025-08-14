namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags describing the access control of a D-Bus property.
/// </para>
/// </summary>

[Flags]
public enum GDBusPropertyInfoFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_PROPERTY_INFO_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Property is readable.
/// </para>
/// </summary>

	G_DBUS_PROPERTY_INFO_FLAGS_READABLE = 1,
/// <summary>
/// <para>
/// Property is writable.
/// </para>
/// </summary>

	G_DBUS_PROPERTY_INFO_FLAGS_WRITABLE = 2
}
