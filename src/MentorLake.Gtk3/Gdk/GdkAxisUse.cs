namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// An enumeration describing the way in which a device
/// axis (valuator) maps onto the predefined valuator
/// types that GTK+ understands.
/// </para>
/// <para>
/// Note that the X and Y axes are not really needed; pointer devices
/// report their location via the x/y members of events regardless. Whether
/// X and Y are present as axes depends on the GDK backend.
/// </para>
/// </summary>

[Flags]
public enum GdkAxisUse
{
/// <summary>
/// <para>
/// the axis is ignored.
/// </para>
/// </summary>

	GDK_AXIS_IGNORE = 0,
/// <summary>
/// <para>
/// the axis is used as the x axis.
/// </para>
/// </summary>

	GDK_AXIS_X = 1,
/// <summary>
/// <para>
/// the axis is used as the y axis.
/// </para>
/// </summary>

	GDK_AXIS_Y = 2,
/// <summary>
/// <para>
/// the axis is used for pressure information.
/// </para>
/// </summary>

	GDK_AXIS_PRESSURE = 3,
/// <summary>
/// <para>
/// the axis is used for x tilt information.
/// </para>
/// </summary>

	GDK_AXIS_XTILT = 4,
/// <summary>
/// <para>
/// the axis is used for y tilt information.
/// </para>
/// </summary>

	GDK_AXIS_YTILT = 5,
/// <summary>
/// <para>
/// the axis is used for wheel information.
/// </para>
/// </summary>

	GDK_AXIS_WHEEL = 6,
/// <summary>
/// <para>
/// the axis is used for pen/tablet distance information. (Since: 3.22)
/// </para>
/// </summary>

	GDK_AXIS_DISTANCE = 7,
/// <summary>
/// <para>
/// the axis is used for pen rotation information. (Since: 3.22)
/// </para>
/// </summary>

	GDK_AXIS_ROTATION = 8,
/// <summary>
/// <para>
/// the axis is used for pen slider information. (Since: 3.22)
/// </para>
/// </summary>

	GDK_AXIS_SLIDER = 9,
/// <summary>
/// <para>
/// a constant equal to the numerically highest axis value.
/// </para>
/// </summary>

	GDK_AXIS_LAST = 10
}
