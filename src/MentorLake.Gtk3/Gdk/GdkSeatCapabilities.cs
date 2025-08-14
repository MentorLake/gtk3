namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Flags describing the seat capabilities.
/// </para>
/// </summary>

[Flags]
public enum GdkSeatCapabilities : uint
{
/// <summary>
/// <para>
/// No input capabilities
/// </para>
/// </summary>

	GDK_SEAT_CAPABILITY_NONE = 0,
/// <summary>
/// <para>
/// The seat has a pointer (e.g. mouse)
/// </para>
/// </summary>

	GDK_SEAT_CAPABILITY_POINTER = 1,
/// <summary>
/// <para>
/// The seat has touchscreen(s) attached
/// </para>
/// </summary>

	GDK_SEAT_CAPABILITY_TOUCH = 2,
/// <summary>
/// <para>
/// The seat has drawing tablet(s) attached
/// </para>
/// </summary>

	GDK_SEAT_CAPABILITY_TABLET_STYLUS = 4,
/// <summary>
/// <para>
/// The seat has keyboard(s) attached
/// </para>
/// </summary>

	GDK_SEAT_CAPABILITY_KEYBOARD = 8,
/// <summary>
/// <para>
/// The union of all pointing capabilities
/// </para>
/// </summary>

	GDK_SEAT_CAPABILITY_ALL_POINTING = 7,
/// <summary>
/// <para>
/// The union of all capabilities
/// </para>
/// </summary>

	GDK_SEAT_CAPABILITY_ALL = 15
}
