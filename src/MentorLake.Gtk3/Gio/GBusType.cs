namespace MentorLake.Gio;

/// <summary>
/// <para>
/// An enumeration for well-known message buses.
/// </para>
/// </summary>

[Flags]
public enum GBusType
{
/// <summary>
/// <para>
/// An alias for the message bus that activated the process, if any.
/// </para>
/// </summary>

	G_BUS_TYPE_STARTER = -1,
/// <summary>
/// <para>
/// Not a message bus.
/// </para>
/// </summary>

	G_BUS_TYPE_NONE = 0,
/// <summary>
/// <para>
/// The system-wide message bus.
/// </para>
/// </summary>

	G_BUS_TYPE_SYSTEM = 1,
/// <summary>
/// <para>
/// The login session message bus.
/// </para>
/// </summary>

	G_BUS_TYPE_SESSION = 2
}
