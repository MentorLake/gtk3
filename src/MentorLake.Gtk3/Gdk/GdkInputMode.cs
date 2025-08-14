namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// An enumeration that describes the mode of an input device.
/// </para>
/// </summary>

[Flags]
public enum GdkInputMode
{
/// <summary>
/// <para>
/// the device is disabled and will not report any events.
/// </para>
/// </summary>

	GDK_MODE_DISABLED = 0,
/// <summary>
/// <para>
/// the device is enabled. The device’s coordinate space
///                   maps to the entire screen.
/// </para>
/// </summary>

	GDK_MODE_SCREEN = 1,
/// <summary>
/// <para>
/// the device is enabled. The device’s coordinate space
///                   is mapped to a single window. The manner in which this window
///                   is chosen is undefined, but it will typically be the same
///                   way in which the focus window for key events is determined.
/// </para>
/// </summary>

	GDK_MODE_WINDOW = 2
}
