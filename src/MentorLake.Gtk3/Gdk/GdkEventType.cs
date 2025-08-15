namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the type of the event.
/// </para>
/// <para>
/// Do not confuse these events with the signals that GTK+ widgets emit.
/// Although many of these events result in corresponding signals being emitted,
/// the events are often transformed or filtered along the way.
/// </para>
/// <para>
/// In some language bindings, the values %GDK_2BUTTON_PRESS and
/// %GDK_3BUTTON_PRESS would translate into something syntactically
/// invalid (eg `Gdk.EventType.2ButtonPress`, where a
/// symbol is not allowed to start with a number). In that case, the
/// aliases %GDK_DOUBLE_BUTTON_PRESS and %GDK_TRIPLE_BUTTON_PRESS can
/// be used instead.
/// </para>
/// </summary>

[Flags]
public enum GdkEventType
{
/// <summary>
/// <para>
/// a special code to indicate a null event.
/// </para>
/// </summary>

	GDK_NOTHING = -1,
/// <summary>
/// <para>
/// the window manager has requested that the toplevel window be
///   hidden or destroyed, usually when the user clicks on a special icon in the
///   title bar.
/// </para>
/// </summary>

	GDK_DELETE = 0,
/// <summary>
/// <para>
/// the window has been destroyed.
/// </para>
/// </summary>

	GDK_DESTROY = 1,
/// <summary>
/// <para>
/// all or part of the window has become visible and needs to be
///   redrawn.
/// </para>
/// </summary>

	GDK_EXPOSE = 2,
/// <summary>
/// <para>
/// the pointer (usually a mouse) has moved.
/// </para>
/// </summary>

	GDK_MOTION_NOTIFY = 3,
/// <summary>
/// <para>
/// a mouse button has been pressed.
/// </para>
/// </summary>

	GDK_BUTTON_PRESS = 4,
/// <summary>
/// <para>
/// a mouse button has been double-clicked (clicked twice
///   within a short period of time). Note that each click also generates a
///   %GDK_BUTTON_PRESS event.
/// </para>
/// </summary>

	GDK_2BUTTON_PRESS = 5,
/// <summary>
/// <para>
/// alias for %GDK_2BUTTON_PRESS, added in 3.6.
/// </para>
/// </summary>

	GDK_DOUBLE_BUTTON_PRESS = 5,
/// <summary>
/// <para>
/// a mouse button has been clicked 3 times in a short period
///   of time. Note that each click also generates a %GDK_BUTTON_PRESS event.
/// </para>
/// </summary>

	GDK_3BUTTON_PRESS = 6,
/// <summary>
/// <para>
/// alias for %GDK_3BUTTON_PRESS, added in 3.6.
/// </para>
/// </summary>

	GDK_TRIPLE_BUTTON_PRESS = 6,
/// <summary>
/// <para>
/// a mouse button has been released.
/// </para>
/// </summary>

	GDK_BUTTON_RELEASE = 7,
/// <summary>
/// <para>
/// a key has been pressed.
/// </para>
/// </summary>

	GDK_KEY_PRESS = 8,
/// <summary>
/// <para>
/// a key has been released.
/// </para>
/// </summary>

	GDK_KEY_RELEASE = 9,
/// <summary>
/// <para>
/// the pointer has entered the window.
/// </para>
/// </summary>

	GDK_ENTER_NOTIFY = 10,
/// <summary>
/// <para>
/// the pointer has left the window.
/// </para>
/// </summary>

	GDK_LEAVE_NOTIFY = 11,
/// <summary>
/// <para>
/// the keyboard focus has entered or left the window.
/// </para>
/// </summary>

	GDK_FOCUS_CHANGE = 12,
/// <summary>
/// <para>
/// the size, position or stacking order of the window has changed.
///   Note that GTK+ discards these events for %GDK_WINDOW_CHILD windows.
/// </para>
/// </summary>

	GDK_CONFIGURE = 13,
/// <summary>
/// <para>
/// the window has been mapped.
/// </para>
/// </summary>

	GDK_MAP = 14,
/// <summary>
/// <para>
/// the window has been unmapped.
/// </para>
/// </summary>

	GDK_UNMAP = 15,
/// <summary>
/// <para>
/// a property on the window has been changed or deleted.
/// </para>
/// </summary>

	GDK_PROPERTY_NOTIFY = 16,
/// <summary>
/// <para>
/// the application has lost ownership of a selection.
/// </para>
/// </summary>

	GDK_SELECTION_CLEAR = 17,
/// <summary>
/// <para>
/// another application has requested a selection.
/// </para>
/// </summary>

	GDK_SELECTION_REQUEST = 18,
/// <summary>
/// <para>
/// a selection has been received.
/// </para>
/// </summary>

	GDK_SELECTION_NOTIFY = 19,
/// <summary>
/// <para>
/// an input device has moved into contact with a sensing
///   surface (e.g. a touchscreen or graphics tablet).
/// </para>
/// </summary>

	GDK_PROXIMITY_IN = 20,
/// <summary>
/// <para>
/// an input device has moved out of contact with a sensing
///   surface.
/// </para>
/// </summary>

	GDK_PROXIMITY_OUT = 21,
/// <summary>
/// <para>
/// the mouse has entered the window while a drag is in progress.
/// </para>
/// </summary>

	GDK_DRAG_ENTER = 22,
/// <summary>
/// <para>
/// the mouse has left the window while a drag is in progress.
/// </para>
/// </summary>

	GDK_DRAG_LEAVE = 23,
/// <summary>
/// <para>
/// the mouse has moved in the window while a drag is in
///   progress.
/// </para>
/// </summary>

	GDK_DRAG_MOTION = 24,
/// <summary>
/// <para>
/// the status of the drag operation initiated by the window
///   has changed.
/// </para>
/// </summary>

	GDK_DRAG_STATUS = 25,
/// <summary>
/// <para>
/// a drop operation onto the window has started.
/// </para>
/// </summary>

	GDK_DROP_START = 26,
/// <summary>
/// <para>
/// the drop operation initiated by the window has completed.
/// </para>
/// </summary>

	GDK_DROP_FINISHED = 27,
/// <summary>
/// <para>
/// a message has been received from another application.
/// </para>
/// </summary>

	GDK_CLIENT_EVENT = 28,
/// <summary>
/// <para>
/// the window visibility status has changed.
/// </para>
/// </summary>

	GDK_VISIBILITY_NOTIFY = 29,
/// <summary>
/// <para>
/// the scroll wheel was turned
/// </para>
/// </summary>

	GDK_SCROLL = 31,
/// <summary>
/// <para>
/// the state of a window has changed. See #GdkWindowState
///   for the possible window states
/// </para>
/// </summary>

	GDK_WINDOW_STATE = 32,
/// <summary>
/// <para>
/// a setting has been modified.
/// </para>
/// </summary>

	GDK_SETTING = 33,
/// <summary>
/// <para>
/// the owner of a selection has changed. This event type
///   was added in 2.6
/// </para>
/// </summary>

	GDK_OWNER_CHANGE = 34,
/// <summary>
/// <para>
/// a pointer or keyboard grab was broken. This event type
///   was added in 2.8.
/// </para>
/// </summary>

	GDK_GRAB_BROKEN = 35,
/// <summary>
/// <para>
/// the content of the window has been changed. This event type
///   was added in 2.14.
/// </para>
/// </summary>

	GDK_DAMAGE = 36,
/// <summary>
/// <para>
/// A new touch event sequence has just started. This event
///   type was added in 3.4.
/// </para>
/// </summary>

	GDK_TOUCH_BEGIN = 37,
/// <summary>
/// <para>
/// A touch event sequence has been updated. This event type
///   was added in 3.4.
/// </para>
/// </summary>

	GDK_TOUCH_UPDATE = 38,
/// <summary>
/// <para>
/// A touch event sequence has finished. This event type
///   was added in 3.4.
/// </para>
/// </summary>

	GDK_TOUCH_END = 39,
/// <summary>
/// <para>
/// A touch event sequence has been canceled. This event type
///   was added in 3.4.
/// </para>
/// </summary>

	GDK_TOUCH_CANCEL = 40,
/// <summary>
/// <para>
/// A touchpad swipe gesture event, the current state
///   is determined by its phase field. This event type was added in 3.18.
/// </para>
/// </summary>

	GDK_TOUCHPAD_SWIPE = 41,
/// <summary>
/// <para>
/// A touchpad pinch gesture event, the current state
///   is determined by its phase field. This event type was added in 3.18.
/// </para>
/// </summary>

	GDK_TOUCHPAD_PINCH = 42,
/// <summary>
/// <para>
/// A tablet pad button press event. This event type
///   was added in 3.22.
/// </para>
/// </summary>

	GDK_PAD_BUTTON_PRESS = 43,
/// <summary>
/// <para>
/// A tablet pad button release event. This event type
///   was added in 3.22.
/// </para>
/// </summary>

	GDK_PAD_BUTTON_RELEASE = 44,
/// <summary>
/// <para>
/// A tablet pad axis event from a &quot;ring&quot;. This event type was
///   added in 3.22.
/// </para>
/// </summary>

	GDK_PAD_RING = 45,
/// <summary>
/// <para>
/// A tablet pad axis event from a &quot;strip&quot;. This event type was
///   added in 3.22.
/// </para>
/// </summary>

	GDK_PAD_STRIP = 46,
/// <summary>
/// <para>
/// A tablet pad group mode change. This event type was
///   added in 3.22.
/// </para>
/// </summary>

	GDK_PAD_GROUP_MODE = 47,
/// <summary>
/// <para>
/// marks the end of the GdkEventType enumeration. Added in 2.18
/// </para>
/// </summary>

	GDK_EVENT_LAST = 48
}
