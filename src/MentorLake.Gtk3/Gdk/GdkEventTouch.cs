namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Used for touch events.
/// @type field will be one of %GDK_TOUCH_BEGIN, %GDK_TOUCH_UPDATE,
/// %GDK_TOUCH_END or %GDK_TOUCH_CANCEL.
/// </para>
/// <para>
/// Touch events are grouped into sequences by means of the @sequence
/// field, which can also be obtained with gdk_event_get_event_sequence().
/// Each sequence begins with a %GDK_TOUCH_BEGIN event, followed by
/// any number of %GDK_TOUCH_UPDATE events, and ends with a %GDK_TOUCH_END
/// (or %GDK_TOUCH_CANCEL) event. With multitouch devices, there may be
/// several active sequences at the same time.
/// </para>
/// </summary>

public class GdkEventTouchHandle : BaseSafeHandle
{
}


public static class GdkEventTouchExtensions
{

	public static GdkEventTouch Dereference(this GdkEventTouchHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventTouch>(x.DangerousGetHandle());
}
internal class GdkEventTouchExterns
{
}

/// <summary>
/// <para>
/// Used for touch events.
/// @type field will be one of %GDK_TOUCH_BEGIN, %GDK_TOUCH_UPDATE,
/// %GDK_TOUCH_END or %GDK_TOUCH_CANCEL.
/// </para>
/// <para>
/// Touch events are grouped into sequences by means of the @sequence
/// field, which can also be obtained with gdk_event_get_event_sequence().
/// Each sequence begins with a %GDK_TOUCH_BEGIN event, followed by
/// any number of %GDK_TOUCH_UPDATE events, and ends with a %GDK_TOUCH_END
/// (or %GDK_TOUCH_CANCEL) event. With multitouch devices, there may be
/// several active sequences at the same time.
/// </para>
/// </summary>

public struct GdkEventTouch
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_TOUCH_BEGIN, %GDK_TOUCH_UPDATE,
///   %GDK_TOUCH_END, %GDK_TOUCH_CANCEL)
/// </para>
/// </summary>

public GdkEventType type;
	/// <summary>
/// <para>
/// the window which received the event
/// </para>
/// </summary>

public IntPtr window;
	/// <summary>
/// <para>
/// %TRUE if the event was sent explicitly.
/// </para>
/// </summary>

public byte send_event;
	/// <summary>
/// <para>
/// the time of the event in milliseconds.
/// </para>
/// </summary>

public uint time;
	/// <summary>
/// <para>
/// the x coordinate of the pointer relative to the window
/// </para>
/// </summary>

public double x;
	/// <summary>
/// <para>
/// the y coordinate of the pointer relative to the window
/// </para>
/// </summary>

public double y;
	/// <summary>
/// <para>
/// @x, @y translated to the axes of @device, or %NULL if @device is
///   the mouse
/// </para>
/// </summary>

public IntPtr axes;
	/// <summary>
/// <para>
/// a bit-mask representing the state of
///   the modifier keys (e.g. Control, Shift and Alt) and the pointer
///   buttons. See #GdkModifierType
/// </para>
/// </summary>

public GdkModifierType state;
	/// <summary>
/// <para>
/// the event sequence that the event belongs to
/// </para>
/// </summary>

public IntPtr sequence;
	/// <summary>
/// <para>
/// whether the event should be used for emulating
///   pointer event
/// </para>
/// </summary>

public bool emulating_pointer;
	/// <summary>
/// <para>
/// the master device that the event originated from. Use
/// gdk_event_get_source_device() to get the slave device.
/// </para>
/// </summary>

public IntPtr device;
	/// <summary>
/// <para>
/// the x coordinate of the pointer relative to the root of the
///   screen
/// </para>
/// </summary>

public double x_root;
	/// <summary>
/// <para>
/// the y coordinate of the pointer relative to the root of the
///   screen
/// </para>
/// </summary>

public double y_root;
}
