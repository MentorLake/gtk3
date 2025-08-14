namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Returned by gdk_device_grab(), gdk_pointer_grab() and gdk_keyboard_grab() to
/// indicate success or the reason for the failure of the grab attempt.
/// </para>
/// </summary>

[Flags]
public enum GdkGrabStatus
{
/// <summary>
/// <para>
/// the resource was successfully grabbed.
/// </para>
/// </summary>

	GDK_GRAB_SUCCESS = 0,
/// <summary>
/// <para>
/// the resource is actively grabbed by another client.
/// </para>
/// </summary>

	GDK_GRAB_ALREADY_GRABBED = 1,
/// <summary>
/// <para>
/// the resource was grabbed more recently than the
///  specified time.
/// </para>
/// </summary>

	GDK_GRAB_INVALID_TIME = 2,
/// <summary>
/// <para>
/// the grab window or the @confine_to window are not
///  viewable.
/// </para>
/// </summary>

	GDK_GRAB_NOT_VIEWABLE = 3,
/// <summary>
/// <para>
/// the resource is frozen by an active grab of another client.
/// </para>
/// </summary>

	GDK_GRAB_FROZEN = 4,
/// <summary>
/// <para>
/// the grab failed for some other reason. Since 3.16
/// </para>
/// </summary>

	GDK_GRAB_FAILED = 5
}
