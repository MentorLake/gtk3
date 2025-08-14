namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the crossing mode for #GdkEventCrossing.
/// </para>
/// </summary>

[Flags]
public enum GdkCrossingMode
{
/// <summary>
/// <para>
/// crossing because of pointer motion.
/// </para>
/// </summary>

	GDK_CROSSING_NORMAL = 0,
/// <summary>
/// <para>
/// crossing because a grab is activated.
/// </para>
/// </summary>

	GDK_CROSSING_GRAB = 1,
/// <summary>
/// <para>
/// crossing because a grab is deactivated.
/// </para>
/// </summary>

	GDK_CROSSING_UNGRAB = 2,
/// <summary>
/// <para>
/// crossing because a GTK+ grab is activated.
/// </para>
/// </summary>

	GDK_CROSSING_GTK_GRAB = 3,
/// <summary>
/// <para>
/// crossing because a GTK+ grab is deactivated.
/// </para>
/// </summary>

	GDK_CROSSING_GTK_UNGRAB = 4,
/// <summary>
/// <para>
/// crossing because a GTK+ widget changed
///   state (e.g. sensitivity).
/// </para>
/// </summary>

	GDK_CROSSING_STATE_CHANGED = 5,
/// <summary>
/// <para>
/// crossing because a touch sequence has begun,
///   this event is synthetic as the pointer might have not left the window.
/// </para>
/// </summary>

	GDK_CROSSING_TOUCH_BEGIN = 6,
/// <summary>
/// <para>
/// crossing because a touch sequence has ended,
///   this event is synthetic as the pointer might have not left the window.
/// </para>
/// </summary>

	GDK_CROSSING_TOUCH_END = 7,
/// <summary>
/// <para>
/// crossing because of a device switch (i.e.
///   a mouse taking control of the pointer after a touch device), this event
///   is synthetic as the pointer didn’t leave the window.
/// </para>
/// </summary>

	GDK_CROSSING_DEVICE_SWITCH = 8
}
