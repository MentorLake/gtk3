namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// An enumeration describing the type of an input device in general terms.
/// </para>
/// </summary>

[Flags]
public enum GdkInputSource
{
/// <summary>
/// <para>
/// the device is a mouse. (This will be reported for the core
///                    pointer, even if it is something else, such as a trackball.)
/// </para>
/// </summary>

	GDK_SOURCE_MOUSE = 0,
/// <summary>
/// <para>
/// the device is a stylus of a graphics tablet or similar device.
/// </para>
/// </summary>

	GDK_SOURCE_PEN = 1,
/// <summary>
/// <para>
/// the device is an eraser. Typically, this would be the other end
///                     of a stylus on a graphics tablet.
/// </para>
/// </summary>

	GDK_SOURCE_ERASER = 2,
/// <summary>
/// <para>
/// the device is a graphics tablet “puck” or similar device.
/// </para>
/// </summary>

	GDK_SOURCE_CURSOR = 3,
/// <summary>
/// <para>
/// the device is a keyboard.
/// </para>
/// </summary>

	GDK_SOURCE_KEYBOARD = 4,
/// <summary>
/// <para>
/// the device is a direct-input touch device, such
///     as a touchscreen or tablet. This device type has been added in 3.4.
/// </para>
/// </summary>

	GDK_SOURCE_TOUCHSCREEN = 5,
/// <summary>
/// <para>
/// the device is an indirect touch device, such
///     as a touchpad. This device type has been added in 3.4.
/// </para>
/// </summary>

	GDK_SOURCE_TOUCHPAD = 6,
/// <summary>
/// <para>
/// the device is a trackpoint. This device type has been
///     added in 3.22
/// </para>
/// </summary>

	GDK_SOURCE_TRACKPOINT = 7,
/// <summary>
/// <para>
/// the device is a &quot;pad&quot;, a collection of buttons,
///     rings and strips found in drawing tablets. This device type has been
///     added in 3.22.
/// </para>
/// </summary>

	GDK_SOURCE_TABLET_PAD = 8
}
