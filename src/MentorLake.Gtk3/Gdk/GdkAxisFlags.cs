namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Flags describing the current capabilities of a device/tool.
/// </para>
/// </summary>

[Flags]
public enum GdkAxisFlags : uint
{
/// <summary>
/// <para>
/// X axis is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_X = 2,
/// <summary>
/// <para>
/// Y axis is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_Y = 4,
/// <summary>
/// <para>
/// Pressure axis is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_PRESSURE = 8,
/// <summary>
/// <para>
/// X tilt axis is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_XTILT = 16,
/// <summary>
/// <para>
/// Y tilt axis is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_YTILT = 32,
/// <summary>
/// <para>
/// Wheel axis is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_WHEEL = 64,
/// <summary>
/// <para>
/// Distance axis is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_DISTANCE = 128,
/// <summary>
/// <para>
/// Z-axis rotation is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_ROTATION = 256,
/// <summary>
/// <para>
/// Slider axis is present
/// </para>
/// </summary>

	GDK_AXIS_FLAG_SLIDER = 512
}
