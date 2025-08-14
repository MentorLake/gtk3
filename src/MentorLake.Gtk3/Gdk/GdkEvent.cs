namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkEvent contains a union of all of the event types,
/// and allows access to the data fields in a number of ways.
/// </para>
/// <para>
/// The event type is always the first field in all of the event types, and
/// can always be accessed with the following code, no matter what type of
/// event it is:
/// |[<!-- language="C" -->
///   GdkEvent *event;
///   GdkEventType type;
/// </para>
/// <para>
///   type = event->type;
/// ]|
/// </para>
/// <para>
/// To access other fields of the event, the pointer to the event
/// can be cast to the appropriate event type, or the union member
/// name can be used. For example if the event type is %GDK_BUTTON_PRESS
/// then the x coordinate of the button press can be accessed with:
/// |[<!-- language="C" -->
///   GdkEvent *event;
///   gdouble x;
/// </para>
/// <para>
///   x = ((GdkEventButton*)event)->x;
/// ]|
/// or:
/// |[<!-- language="C" -->
///   GdkEvent *event;
///   gdouble x;
/// </para>
/// <para>
///   x = event->button.x;
/// ]|
/// </para>
/// </summary>

public class GdkEventHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new event of the given type. All fields are set to 0.
/// </para>
/// </summary>

/// <param name="type">
/// a #GdkEventType
/// </param>
/// <return>
/// a newly-allocated #GdkEvent. The returned #GdkEvent
/// should be freed with gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle New(MentorLake.Gdk.GdkEventType type)
	{
		return GdkEventExterns.gdk_event_new(type);
	}

}


public static class GdkEventExtensions
{
/// <summary>
/// <para>
/// If both events contain X/Y information, this function will return %TRUE
/// and return in @angle the relative angle from @event1 to @event2. The rotation
/// direction for positive angles is from the positive X axis towards the positive
/// Y axis.
/// </para>
/// </summary>

/// <param name="event1">
/// first #GdkEvent
/// </param>
/// <param name="event2">
/// second #GdkEvent
/// </param>
/// <param name="angle">
/// return location for the relative angle between both events
/// </param>
/// <return>
/// %TRUE if the angle could be calculated.
/// </return>

	public static bool GetAngle(this MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double angle)
	{
		if (event1.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_events_get_angle(event1, event2, out angle);
	}

/// <summary>
/// <para>
/// If both events contain X/Y information, the center of both coordinates
/// will be returned in @x and @y.
/// </para>
/// </summary>

/// <param name="event1">
/// first #GdkEvent
/// </param>
/// <param name="event2">
/// second #GdkEvent
/// </param>
/// <param name="x">
/// return location for the X coordinate of the center
/// </param>
/// <param name="y">
/// return location for the Y coordinate of the center
/// </param>
/// <return>
/// %TRUE if the center could be calculated.
/// </return>

	public static bool GetCenter(this MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double x, out double y)
	{
		if (event1.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_events_get_center(event1, event2, out x, out y);
	}

/// <summary>
/// <para>
/// If both events have X/Y information, the distance between both coordinates
/// (as in a straight line going from @event1 to @event2) will be returned.
/// </para>
/// </summary>

/// <param name="event1">
/// first #GdkEvent
/// </param>
/// <param name="event2">
/// second #GdkEvent
/// </param>
/// <param name="distance">
/// return location for the distance
/// </param>
/// <return>
/// %TRUE if the distance could be calculated.
/// </return>

	public static bool GetDistance(this MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double distance)
	{
		if (event1.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_events_get_distance(event1, event2, out distance);
	}

/// <summary>
/// <para>
/// Copies a #GdkEvent, copying or incrementing the reference count of the
/// resources associated with it (e.g. #GdkWindow’s and strings).
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// a copy of @event. The returned #GdkEvent should be freed with
/// gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle Copy(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_copy(@event);
	}

/// <summary>
/// <para>
/// Frees a #GdkEvent, freeing or decrementing any resources associated with it.
/// Note that this function should only be called with events returned from
/// functions such as gdk_event_peek(), gdk_event_get(), gdk_event_copy()
/// and gdk_event_new().
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent.
/// </param>

	public static void Free(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		GdkEventExterns.gdk_event_free(@event);
	}

/// <summary>
/// <para>
/// Extract the axis value for a particular axis use from
/// an event structure.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="axis_use">
/// the axis use to look for
/// </param>
/// <param name="value">
/// location to store the value found
/// </param>
/// <return>
/// %TRUE if the specified axis was found, otherwise %FALSE
/// </return>

	public static bool GetAxis(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkAxisUse axis_use, out double value)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_axis(@event, axis_use, out value);
	}

/// <summary>
/// <para>
/// Extract the button number from an event.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="button">
/// location to store mouse button number
/// </param>
/// <return>
/// %TRUE if the event delivered a button number
/// </return>

	public static bool GetButton(this MentorLake.Gdk.GdkEventHandle @event, out uint button)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_button(@event, out button);
	}

/// <summary>
/// <para>
/// Extracts the click count from an event.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="click_count">
/// location to store click count
/// </param>
/// <return>
/// %TRUE if the event delivered a click count
/// </return>

	public static bool GetClickCount(this MentorLake.Gdk.GdkEventHandle @event, out uint click_count)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_click_count(@event, out click_count);
	}

/// <summary>
/// <para>
/// Extract the event window relative x/y coordinates from an event.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="x_win">
/// location to put event window x coordinate
/// </param>
/// <param name="y_win">
/// location to put event window y coordinate
/// </param>
/// <return>
/// %TRUE if the event delivered event window coordinates
/// </return>

	public static bool GetCoords(this MentorLake.Gdk.GdkEventHandle @event, out double x_win, out double y_win)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_coords(@event, out x_win, out y_win);
	}

/// <summary>
/// <para>
/// If the event contains a “device” field, this function will return
/// it, else it will return %NULL.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent.
/// </param>
/// <return>
/// a #GdkDevice, or %NULL.
/// </return>

	public static MentorLake.Gdk.GdkDeviceHandle GetDevice(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_device(@event);
	}

/// <summary>
/// <para>
/// If the event was generated by a device that supports
/// different tools (eg. a tablet), this function will
/// return a #GdkDeviceTool representing the tool that
/// caused the event. Otherwise, %NULL will be returned.
/// </para>
/// <para>
/// Note: the #GdkDeviceTool<!-- -->s will be constant during
/// the application lifetime, if settings must be stored
/// persistently across runs, see gdk_device_tool_get_serial()
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// The current device tool, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkDeviceToolHandle GetDeviceTool(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_device_tool(@event);
	}

/// <summary>
/// <para>
/// If @event if of type %GDK_TOUCH_BEGIN, %GDK_TOUCH_UPDATE,
/// %GDK_TOUCH_END or %GDK_TOUCH_CANCEL, returns the #GdkEventSequence
/// to which the event belongs. Otherwise, return %NULL.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// the event sequence that the event belongs to
/// </return>

	public static MentorLake.Gdk.GdkEventSequenceHandle GetEventSequence(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_event_sequence(@event);
	}

/// <summary>
/// <para>
/// Retrieves the type of the event.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// a #GdkEventType
/// </return>

	public static MentorLake.Gdk.GdkEventType GetEventType(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_event_type(@event);
	}

/// <summary>
/// <para>
/// Extracts the hardware keycode from an event.
/// </para>
/// <para>
/// Also see gdk_event_get_scancode().
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="keycode">
/// location to store the keycode
/// </param>
/// <return>
/// %TRUE if the event delivered a hardware keycode
/// </return>

	public static bool GetKeycode(this MentorLake.Gdk.GdkEventHandle @event, out ushort keycode)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_keycode(@event, out keycode);
	}

/// <summary>
/// <para>
/// Extracts the keyval from an event.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="keyval">
/// location to store the keyval
/// </param>
/// <return>
/// %TRUE if the event delivered a key symbol
/// </return>

	public static bool GetKeyval(this MentorLake.Gdk.GdkEventHandle @event, out uint keyval)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_keyval(@event, out keyval);
	}

/// <summary>
/// <para>
/// #event: a #GdkEvent
/// Returns whether this event is an 'emulated' pointer event (typically
/// from a touch event), as opposed to a real one.
/// </para>
/// </summary>

/// <param name="@event">
/// </param>
/// <return>
/// %TRUE if this event is emulated
/// </return>

	public static bool GetPointerEmulated(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_pointer_emulated(@event);
	}

/// <summary>
/// <para>
/// Extract the root window relative x/y coordinates from an event.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="x_root">
/// location to put root window x coordinate
/// </param>
/// <param name="y_root">
/// location to put root window y coordinate
/// </param>
/// <return>
/// %TRUE if the event delivered root window coordinates
/// </return>

	public static bool GetRootCoords(this MentorLake.Gdk.GdkEventHandle @event, out double x_root, out double y_root)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_root_coords(@event, out x_root, out y_root);
	}

/// <summary>
/// <para>
/// Gets the keyboard low-level scancode of a key event.
/// </para>
/// <para>
/// This is usually hardware_keycode. On Windows this is the high
/// word of WM_KEY{DOWN,UP} lParam which contains the scancode and
/// some extended flags.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// The associated keyboard scancode or 0
/// </return>

	public static int GetScancode(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_scancode(@event);
	}

/// <summary>
/// <para>
/// Returns the screen for the event. The screen is
/// typically the screen for `event->any.window`, but
/// for events such as mouse events, it is the screen
/// where the pointer was when the event occurs -
/// that is, the screen which has the root window
/// to which `event->motion.x_root` and
/// `event->motion.y_root` are relative.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// the screen for the event
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_screen(@event);
	}

/// <summary>
/// <para>
/// Retrieves the scroll deltas from a #GdkEvent
/// </para>
/// <para>
/// See also: gdk_event_get_scroll_direction()
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="delta_x">
/// return location for X delta
/// </param>
/// <param name="delta_y">
/// return location for Y delta
/// </param>
/// <return>
/// %TRUE if the event contains smooth scroll information
///   and %FALSE otherwise
/// </return>

	public static bool GetScrollDeltas(this MentorLake.Gdk.GdkEventHandle @event, out double delta_x, out double delta_y)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_scroll_deltas(@event, out delta_x, out delta_y);
	}

/// <summary>
/// <para>
/// Extracts the scroll direction from an event.
/// </para>
/// <para>
/// If @event is not of type %GDK_SCROLL, the contents of @direction
/// are undefined.
/// </para>
/// <para>
/// If you wish to handle both discrete and smooth scrolling, you
/// should check the return value of this function, or of
/// gdk_event_get_scroll_deltas(); for instance:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   GdkScrollDirection direction;
///   double vscroll_factor = 0.0;
///   double x_scroll, y_scroll;
/// </para>
/// <para>
///   if (gdk_event_get_scroll_direction (event, &direction))
///     {
///       // Handle discrete scrolling with a known constant delta;
///       const double delta = 12.0;
/// </para>
/// <para>
///       switch (direction)
///         {
///         case GDK_SCROLL_UP:
///           vscroll_factor = -delta;
///           break;
///         case GDK_SCROLL_DOWN:
///           vscroll_factor = delta;
///           break;
///         default:
///           // no scrolling
///           break;
///         }
///     }
///   else if (gdk_event_get_scroll_deltas (event, &x_scroll, &y_scroll))
///     {
///       // Handle smooth scrolling directly
///       vscroll_factor = y_scroll;
///     }
/// ]|
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="direction">
/// location to store the scroll direction
/// </param>
/// <return>
/// %TRUE if the event delivered a scroll direction
///   and %FALSE otherwise
/// </return>

	public static bool GetScrollDirection(this MentorLake.Gdk.GdkEventHandle @event, out MentorLake.Gdk.GdkScrollDirection direction)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_scroll_direction(@event, out direction);
	}

/// <summary>
/// <para>
/// Returns the #GdkSeat this event was generated for.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// The #GdkSeat of this event
/// </return>

	public static MentorLake.Gdk.GdkSeatHandle GetSeat(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_seat(@event);
	}

/// <summary>
/// <para>
/// This function returns the hardware (slave) #GdkDevice that has
/// triggered the event, falling back to the virtual (master) device
/// (as in gdk_event_get_device()) if the event wasn’t caused by
/// interaction with a hardware device. This may happen for example
/// in synthesized crossing events after a #GdkWindow updates its
/// geometry or a grab is acquired/released.
/// </para>
/// <para>
/// If the event does not contain a device field, this function will
/// return %NULL.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// a #GdkDevice, or %NULL.
/// </return>

	public static MentorLake.Gdk.GdkDeviceHandle GetSourceDevice(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_source_device(@event);
	}

/// <summary>
/// <para>
/// If the event contains a “state” field, puts that field in @state. Otherwise
/// stores an empty state (0). Returns %TRUE if there was a state field
/// in the event. @event may be %NULL, in which case it’s treated
/// as if the event had no state field.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent or %NULL
/// </param>
/// <param name="state">
/// return location for state
/// </param>
/// <return>
/// %TRUE if there was a state field in the event
/// </return>

	public static bool GetState(this MentorLake.Gdk.GdkEventHandle @event, out MentorLake.Gdk.GdkModifierType state)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_state(@event, out state);
	}

/// <summary>
/// <para>
/// Returns the time stamp from @event, if there is one; otherwise
/// returns #GDK_CURRENT_TIME. If @event is %NULL, returns #GDK_CURRENT_TIME.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// time stamp field from @event
/// </return>

	public static uint GetTime(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_time(@event);
	}

/// <summary>
/// <para>
/// Extracts the #GdkWindow associated with an event.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// The #GdkWindow associated with the event
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_window(@event);
	}

/// <summary>
/// <para>
/// Check whether a scroll event is a stop scroll event. Scroll sequences
/// with smooth scroll information may provide a stop scroll event once the
/// interaction with the device finishes, e.g. by lifting a finger. This
/// stop scroll event is the signal that a widget may trigger kinetic
/// scrolling based on the current velocity.
/// </para>
/// <para>
/// Stop scroll events always have a a delta of 0/0.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// %TRUE if the event is a scroll stop event
/// </return>

	public static bool IsScrollStopEvent(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_is_scroll_stop_event(@event);
	}

/// <summary>
/// <para>
/// Appends a copy of the given event onto the front of the event
/// queue for event->any.window’s display, or the default event
/// queue if event->any.window is %NULL. See gdk_display_put_event().
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent.
/// </param>

	public static void Put(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		GdkEventExterns.gdk_event_put(@event);
	}

/// <summary>
/// <para>
/// Sets the device for @event to @device. The event must
/// have been allocated by GTK+, for instance, by
/// gdk_event_copy().
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>

	public static void SetDevice(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		GdkEventExterns.gdk_event_set_device(@event, device);
	}

/// <summary>
/// <para>
/// Sets the device tool for this event, should be rarely used.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="tool">
/// tool to set on the event, or %NULL
/// </param>

	public static void SetDeviceTool(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkDeviceToolHandle tool)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		GdkEventExterns.gdk_event_set_device_tool(@event, tool);
	}

/// <summary>
/// <para>
/// Sets the screen for @event to @screen. The event must
/// have been allocated by GTK+, for instance, by
/// gdk_event_copy().
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="screen">
/// a #GdkScreen
/// </param>

	public static void SetScreen(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		GdkEventExterns.gdk_event_set_screen(@event, screen);
	}

/// <summary>
/// <para>
/// Sets the slave device for @event to @device.
/// </para>
/// <para>
/// The event must have been allocated by GTK+,
/// for instance by gdk_event_copy().
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>

	public static void SetSourceDevice(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		GdkEventExterns.gdk_event_set_source_device(@event, device);
	}

/// <summary>
/// <para>
/// This function returns whether a #GdkEventButton should trigger a
/// context menu, according to platform conventions. The right mouse
/// button always triggers context menus. Additionally, if
/// gdk_keymap_get_modifier_mask() returns a non-0 mask for
/// %GDK_MODIFIER_INTENT_CONTEXT_MENU, then the left mouse button will
/// also trigger a context menu if this modifier is pressed.
/// </para>
/// <para>
/// This function should always be used instead of simply checking for
/// event->button == %GDK_BUTTON_SECONDARY.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent, currently only button events are meaningful values
/// </param>
/// <return>
/// %TRUE if the event should trigger a context menu.
/// </return>

	public static bool TriggersContextMenu(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid) throw new Exception("Invalid handle (GdkEvent)");
		return GdkEventExterns.gdk_event_triggers_context_menu(@event);
	}


	public static GdkEvent Dereference(this GdkEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEvent>(x.DangerousGetHandle());
}
internal class GdkEventExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_new(MentorLake.Gdk.GdkEventType type);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_angle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double angle);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_center([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double x, out double y);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double distance);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_axis([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkAxisUse axis_use, out double value);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out uint button);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_click_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out uint click_count);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out double x_win, out double y_win);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_event_get_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceToolHandle gdk_event_get_device_tool([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))]
	internal static extern MentorLake.Gdk.GdkEventSequenceHandle gdk_event_get_event_sequence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventType gdk_event_get_event_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_keycode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out ushort keycode);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_keyval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out uint keyval);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_pointer_emulated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_root_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out double x_root, out double y_root);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_event_get_scancode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gdk_event_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_scroll_deltas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out double delta_x, out double delta_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_scroll_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out MentorLake.Gdk.GdkScrollDirection direction);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))]
	internal static extern MentorLake.Gdk.GdkSeatHandle gdk_event_get_seat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_event_get_source_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out MentorLake.Gdk.GdkModifierType state);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_event_get_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_event_get_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_is_scroll_stop_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_put([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_set_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_set_device_tool([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_set_source_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_triggers_context_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_get();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_handler_set(MentorLake.Gdk.GdkEventFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_peek();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_request_motions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventMotionHandle>))] MentorLake.Gdk.GdkEventMotionHandle @event);

}

/// <summary>
/// <para>
/// A #GdkEvent contains a union of all of the event types,
/// and allows access to the data fields in a number of ways.
/// </para>
/// <para>
/// The event type is always the first field in all of the event types, and
/// can always be accessed with the following code, no matter what type of
/// event it is:
/// |[<!-- language="C" -->
///   GdkEvent *event;
///   GdkEventType type;
/// </para>
/// <para>
///   type = event->type;
/// ]|
/// </para>
/// <para>
/// To access other fields of the event, the pointer to the event
/// can be cast to the appropriate event type, or the union member
/// name can be used. For example if the event type is %GDK_BUTTON_PRESS
/// then the x coordinate of the button press can be accessed with:
/// |[<!-- language="C" -->
///   GdkEvent *event;
///   gdouble x;
/// </para>
/// <para>
///   x = ((GdkEventButton*)event)->x;
/// ]|
/// or:
/// |[<!-- language="C" -->
///   GdkEvent *event;
///   gdouble x;
/// </para>
/// <para>
///   x = event->button.x;
/// ]|
/// </para>
/// </summary>

public struct GdkEvent
{
	/// <summary>
/// <para>
/// the #GdkEventType
/// </para>
/// </summary>

public GdkEventType type;
	/// <summary>
/// <para>
/// a #GdkEventAny
/// </para>
/// </summary>

public GdkEventAny any;
	/// <summary>
/// <para>
/// a #GdkEventExpose
/// </para>
/// </summary>

public GdkEventExpose expose;
	/// <summary>
/// <para>
/// a #GdkEventVisibility
/// </para>
/// </summary>

public GdkEventVisibility visibility;
	/// <summary>
/// <para>
/// a #GdkEventMotion
/// </para>
/// </summary>

public GdkEventMotion motion;
	/// <summary>
/// <para>
/// a #GdkEventButton
/// </para>
/// </summary>

public GdkEventButton button;
	/// <summary>
/// <para>
/// a #GdkEventTouch
/// </para>
/// </summary>

public GdkEventTouch touch;
	/// <summary>
/// <para>
/// a #GdkEventScroll
/// </para>
/// </summary>

public GdkEventScroll scroll;
	/// <summary>
/// <para>
/// a #GdkEventKey
/// </para>
/// </summary>

public GdkEventKey key;
	/// <summary>
/// <para>
/// a #GdkEventCrossing
/// </para>
/// </summary>

public GdkEventCrossing crossing;
	/// <summary>
/// <para>
/// a #GdkEventFocus
/// </para>
/// </summary>

public GdkEventFocus focus_change;
	/// <summary>
/// <para>
/// a #GdkEventConfigure
/// </para>
/// </summary>

public GdkEventConfigure configure;
	/// <summary>
/// <para>
/// a #GdkEventProperty
/// </para>
/// </summary>

public GdkEventProperty property;
	/// <summary>
/// <para>
/// a #GdkEventSelection
/// </para>
/// </summary>

public GdkEventSelection selection;
	/// <summary>
/// <para>
/// a #GdkEventOwnerChange
/// </para>
/// </summary>

public GdkEventOwnerChange owner_change;
	/// <summary>
/// <para>
/// a #GdkEventProximity
/// </para>
/// </summary>

public GdkEventProximity proximity;
	/// <summary>
/// <para>
/// a #GdkEventDND
/// </para>
/// </summary>

public GdkEventDND dnd;
	/// <summary>
/// <para>
/// a #GdkEventWindowState
/// </para>
/// </summary>

public GdkEventWindowState window_state;
	/// <summary>
/// <para>
/// a #GdkEventSetting
/// </para>
/// </summary>

public GdkEventSetting setting;
	/// <summary>
/// <para>
/// a #GdkEventGrabBroken
/// </para>
/// </summary>

public GdkEventGrabBroken grab_broken;
	/// <summary>
/// <para>
/// a #GdkEventTouchpadSwipe
/// </para>
/// </summary>

public GdkEventTouchpadSwipe touchpad_swipe;
	/// <summary>
/// <para>
/// a #GdkEventTouchpadPinch
/// </para>
/// </summary>

public GdkEventTouchpadPinch touchpad_pinch;
	/// <summary>
/// <para>
/// a #GdkEventPadButton
/// </para>
/// </summary>

public GdkEventPadButton pad_button;
	/// <summary>
/// <para>
/// a #GdkEventPadAxis
/// </para>
/// </summary>

public GdkEventPadAxis pad_axis;
	/// <summary>
/// <para>
/// a #GdkEventPadGroupMode
/// </para>
/// </summary>

public GdkEventPadGroupMode pad_group_mode;
/// <summary>
/// <para>
/// Checks all open displays for a #GdkEvent to process,to be processed
/// on, fetching events from the windowing system if necessary.
/// See gdk_display_get_event().
/// </para>
/// </summary>

/// <return>
/// the next #GdkEvent to be processed, or %NULL
/// if no events are pending. The returned #GdkEvent should be freed
/// with gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle Get()
	{
		return GdkEventExterns.gdk_event_get();
	}

/// <summary>
/// <para>
/// Sets the function to call to handle all events from GDK.
/// </para>
/// <para>
/// Note that GTK+ uses this to install its own event handler, so it is
/// usually not useful for GTK+ applications. (Although an application
/// can call this function then call gtk_main_do_event() to pass
/// events to GTK+.)
/// </para>
/// </summary>

/// <param name="func">
/// the function to call to handle events from GDK.
/// </param>
/// <param name="data">
/// user data to pass to the function.
/// </param>
/// <param name="notify">
/// the function to call when the handler function is removed, i.e. when
///          gdk_event_handler_set() is called with another event handler.
/// </param>

	public static void HandlerSet(MentorLake.Gdk.GdkEventFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		GdkEventExterns.gdk_event_handler_set(func, data, notify);
	}

/// <summary>
/// <para>
/// If there is an event waiting in the event queue of some open
/// display, returns a copy of it. See gdk_display_peek_event().
/// </para>
/// </summary>

/// <return>
/// a copy of the first #GdkEvent on some event
/// queue, or %NULL if no events are in any queues. The returned
/// #GdkEvent should be freed with gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle Peek()
	{
		return GdkEventExterns.gdk_event_peek();
	}

/// <summary>
/// <para>
/// Request more motion notifies if @event is a motion notify hint event.
/// </para>
/// <para>
/// This function should be used instead of gdk_window_get_pointer() to
/// request further motion notifies, because it also works for extension
/// events where motion notifies are provided for devices other than the
/// core pointer. Coordinate extraction, processing and requesting more
/// motion events from a %GDK_MOTION_NOTIFY event usually works like this:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// {
///   // motion_event handler
///   x = motion_event->x;
///   y = motion_event->y;
///   // handle (x,y) motion
///   gdk_event_request_motions (motion_event); // handles is_hint events
/// }
/// ]|
/// </para>
/// </summary>

/// <param name="@event">
/// a valid #GdkEvent
/// </param>

	public static void RequestMotions(MentorLake.Gdk.GdkEventMotionHandle @event)
	{
		GdkEventExterns.gdk_event_request_motions(@event);
	}

}
