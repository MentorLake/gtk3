namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// The possible rotations which can be passed to gdk_pixbuf_rotate_simple().
/// </para>
/// <para>
/// To make them easier to use, their numerical values are the actual degrees.
/// </para>
/// </summary>

[Flags]
public enum GdkPixbufRotation
{
/// <summary>
/// <para>
/// No rotation.
/// </para>
/// </summary>

	GDK_PIXBUF_ROTATE_NONE = 0,
/// <summary>
/// <para>
/// Rotate by 90 degrees.
/// </para>
/// </summary>

	GDK_PIXBUF_ROTATE_COUNTERCLOCKWISE = 90,
/// <summary>
/// <para>
/// Rotate by 180 degrees.
/// </para>
/// </summary>

	GDK_PIXBUF_ROTATE_UPSIDEDOWN = 180,
/// <summary>
/// <para>
/// Rotate by 270 degrees.
/// </para>
/// </summary>

	GDK_PIXBUF_ROTATE_CLOCKWISE = 270
}
