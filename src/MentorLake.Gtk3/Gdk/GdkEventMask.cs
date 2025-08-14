namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A set of bit-flags to indicate which events a window is to receive.
/// Most of these masks map onto one or more of the #GdkEventType event types
/// above.
/// </para>
/// <para>
/// See the [input handling overview][chap-input-handling] for details of
/// [event masks][event-masks] and [event propagation][event-propagation].
/// </para>
/// <para>
/// %GDK_POINTER_MOTION_HINT_MASK is deprecated. It is a special mask
/// to reduce the number of %GDK_MOTION_NOTIFY events received. When using
/// %GDK_POINTER_MOTION_HINT_MASK, fewer %GDK_MOTION_NOTIFY events will
/// be sent, some of which are marked as a hint (the is_hint member is
/// %TRUE). To receive more motion events after a motion hint event,
/// the application needs to asks for more, by calling
/// gdk_event_request_motions().
/// </para>
/// <para>
/// Since GTK 3.8, motion events are already compressed by default, independent
/// of this mechanism. This compression can be disabled with
/// gdk_window_set_event_compression(). See the documentation of that function
/// for details.
/// </para>
/// <para>
/// If %GDK_TOUCH_MASK is enabled, the window will receive touch events
/// from touch-enabled devices. Those will come as sequences of #GdkEventTouch
/// with type %GDK_TOUCH_UPDATE, enclosed by two events with
/// type %GDK_TOUCH_BEGIN and %GDK_TOUCH_END (or %GDK_TOUCH_CANCEL).
/// gdk_event_get_event_sequence() returns the event sequence for these
/// events, so different sequences may be distinguished.
/// </para>
/// </summary>

[Flags]
public enum GdkEventMask : uint
{
/// <summary>
/// <para>
/// receive expose events
/// </para>
/// </summary>

	GDK_EXPOSURE_MASK = 2,
/// <summary>
/// <para>
/// receive all pointer motion events
/// </para>
/// </summary>

	GDK_POINTER_MOTION_MASK = 4,
/// <summary>
/// <para>
/// deprecated. see the explanation above
/// </para>
/// </summary>

	GDK_POINTER_MOTION_HINT_MASK = 8,
/// <summary>
/// <para>
/// receive pointer motion events while any button is pressed
/// </para>
/// </summary>

	GDK_BUTTON_MOTION_MASK = 16,
/// <summary>
/// <para>
/// receive pointer motion events while 1 button is pressed
/// </para>
/// </summary>

	GDK_BUTTON1_MOTION_MASK = 32,
/// <summary>
/// <para>
/// receive pointer motion events while 2 button is pressed
/// </para>
/// </summary>

	GDK_BUTTON2_MOTION_MASK = 64,
/// <summary>
/// <para>
/// receive pointer motion events while 3 button is pressed
/// </para>
/// </summary>

	GDK_BUTTON3_MOTION_MASK = 128,
/// <summary>
/// <para>
/// receive button press events
/// </para>
/// </summary>

	GDK_BUTTON_PRESS_MASK = 256,
/// <summary>
/// <para>
/// receive button release events
/// </para>
/// </summary>

	GDK_BUTTON_RELEASE_MASK = 512,
/// <summary>
/// <para>
/// receive key press events
/// </para>
/// </summary>

	GDK_KEY_PRESS_MASK = 1024,
/// <summary>
/// <para>
/// receive key release events
/// </para>
/// </summary>

	GDK_KEY_RELEASE_MASK = 2048,
/// <summary>
/// <para>
/// receive window enter events
/// </para>
/// </summary>

	GDK_ENTER_NOTIFY_MASK = 4096,
/// <summary>
/// <para>
/// receive window leave events
/// </para>
/// </summary>

	GDK_LEAVE_NOTIFY_MASK = 8192,
/// <summary>
/// <para>
/// receive focus change events
/// </para>
/// </summary>

	GDK_FOCUS_CHANGE_MASK = 16384,
/// <summary>
/// <para>
/// receive events about window configuration change
/// </para>
/// </summary>

	GDK_STRUCTURE_MASK = 32768,
/// <summary>
/// <para>
/// receive property change events
/// </para>
/// </summary>

	GDK_PROPERTY_CHANGE_MASK = 65536,
/// <summary>
/// <para>
/// receive visibility change events
/// </para>
/// </summary>

	GDK_VISIBILITY_NOTIFY_MASK = 131072,
/// <summary>
/// <para>
/// receive proximity in events
/// </para>
/// </summary>

	GDK_PROXIMITY_IN_MASK = 262144,
/// <summary>
/// <para>
/// receive proximity out events
/// </para>
/// </summary>

	GDK_PROXIMITY_OUT_MASK = 524288,
/// <summary>
/// <para>
/// receive events about window configuration changes of
///   child windows
/// </para>
/// </summary>

	GDK_SUBSTRUCTURE_MASK = 1048576,
/// <summary>
/// <para>
/// receive scroll events
/// </para>
/// </summary>

	GDK_SCROLL_MASK = 2097152,
/// <summary>
/// <para>
/// receive touch events. Since 3.4
/// </para>
/// </summary>

	GDK_TOUCH_MASK = 4194304,
/// <summary>
/// <para>
/// receive smooth scrolling events. Since 3.4
/// </para>
/// </summary>

	GDK_SMOOTH_SCROLL_MASK = 8388608,
/// <summary>
/// <para>
/// receive touchpad gesture events. Since 3.18
/// </para>
/// </summary>

	GDK_TOUCHPAD_GESTURE_MASK = 16777216,
/// <summary>
/// <para>
/// receive tablet pad events. Since 3.22
/// </para>
/// </summary>

	GDK_TABLET_PAD_MASK = 33554432,
/// <summary>
/// <para>
/// the combination of all the above event masks.
/// </para>
/// </summary>

	GDK_ALL_EVENTS_MASK = 67108862
}
