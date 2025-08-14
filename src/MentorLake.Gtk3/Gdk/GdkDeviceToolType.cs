namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Indicates the specific type of tool being used being a tablet. Such as an
/// airbrush, pencil, etc.
/// </para>
/// </summary>

[Flags]
public enum GdkDeviceToolType
{
/// <summary>
/// <para>
/// Tool is of an unknown type.
/// </para>
/// </summary>

	GDK_DEVICE_TOOL_TYPE_UNKNOWN = 0,
/// <summary>
/// <para>
/// Tool is a standard tablet stylus.
/// </para>
/// </summary>

	GDK_DEVICE_TOOL_TYPE_PEN = 1,
/// <summary>
/// <para>
/// Tool is standard tablet eraser.
/// </para>
/// </summary>

	GDK_DEVICE_TOOL_TYPE_ERASER = 2,
/// <summary>
/// <para>
/// Tool is a brush stylus.
/// </para>
/// </summary>

	GDK_DEVICE_TOOL_TYPE_BRUSH = 3,
/// <summary>
/// <para>
/// Tool is a pencil stylus.
/// </para>
/// </summary>

	GDK_DEVICE_TOOL_TYPE_PENCIL = 4,
/// <summary>
/// <para>
/// Tool is an airbrush stylus.
/// </para>
/// </summary>

	GDK_DEVICE_TOOL_TYPE_AIRBRUSH = 5,
/// <summary>
/// <para>
/// Tool is a mouse.
/// </para>
/// </summary>

	GDK_DEVICE_TOOL_TYPE_MOUSE = 6,
/// <summary>
/// <para>
/// Tool is a lens cursor.
/// </para>
/// </summary>

	GDK_DEVICE_TOOL_TYPE_LENS = 7
}
