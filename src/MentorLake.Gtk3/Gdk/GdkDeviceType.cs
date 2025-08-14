namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Indicates the device type. See [above][GdkDeviceManager.description]
/// for more information about the meaning of these device types.
/// </para>
/// </summary>

[Flags]
public enum GdkDeviceType
{
/// <summary>
/// <para>
/// Device is a master (or virtual) device. There will
///                          be an associated focus indicator on the screen.
/// </para>
/// </summary>

	GDK_DEVICE_TYPE_MASTER = 0,
/// <summary>
/// <para>
/// Device is a slave (or physical) device.
/// </para>
/// </summary>

	GDK_DEVICE_TYPE_SLAVE = 1,
/// <summary>
/// <para>
/// Device is a physical device, currently not attached to
///                            any virtual device.
/// </para>
/// </summary>

	GDK_DEVICE_TYPE_FLOATING = 2
}
