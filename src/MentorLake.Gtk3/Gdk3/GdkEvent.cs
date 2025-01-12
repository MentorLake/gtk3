namespace MentorLake.Gtk3.Gdk3;

public class GdkEventHandle : BaseSafeHandle
{
	public static GdkEventHandle New(GdkEventType type)
	{
		return GdkEventExterns.gdk_event_new(type);
	}

}


public static class GdkEventHandleExtensions
{
	public static bool sGetAngle(this GdkEventHandle event1, GdkEventHandle event2, out double angle)
	{
		return GdkEventExterns.gdk_events_get_angle(event1, event2, out angle);
	}

	public static bool sGetCenter(this GdkEventHandle event1, GdkEventHandle event2, out double x, out double y)
	{
		return GdkEventExterns.gdk_events_get_center(event1, event2, out x, out y);
	}

	public static bool sGetDistance(this GdkEventHandle event1, GdkEventHandle event2, out double distance)
	{
		return GdkEventExterns.gdk_events_get_distance(event1, event2, out distance);
	}

	public static GdkEventHandle Copy(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_copy(@event);
	}

	public static GdkEventHandle Free(this GdkEventHandle @event)
	{
		GdkEventExterns.gdk_event_free(@event);
		return @event;
	}

	public static bool GetAxis(this GdkEventHandle @event, GdkAxisUse axis_use, out double value)
	{
		return GdkEventExterns.gdk_event_get_axis(@event, axis_use, out value);
	}

	public static bool GetButton(this GdkEventHandle @event, out uint button)
	{
		return GdkEventExterns.gdk_event_get_button(@event, out button);
	}

	public static bool GetClickCount(this GdkEventHandle @event, out uint click_count)
	{
		return GdkEventExterns.gdk_event_get_click_count(@event, out click_count);
	}

	public static bool GetCoords(this GdkEventHandle @event, out double x_win, out double y_win)
	{
		return GdkEventExterns.gdk_event_get_coords(@event, out x_win, out y_win);
	}

	public static GdkDeviceHandle GetDevice(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_device(@event);
	}

	public static GdkDeviceToolHandle GetDeviceTool(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_device_tool(@event);
	}

	public static GdkEventSequenceHandle GetEventSequence(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_event_sequence(@event);
	}

	public static GdkEventType GetEventType(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_event_type(@event);
	}

	public static bool GetKeycode(this GdkEventHandle @event, out ushort keycode)
	{
		return GdkEventExterns.gdk_event_get_keycode(@event, out keycode);
	}

	public static bool GetKeyval(this GdkEventHandle @event, out uint keyval)
	{
		return GdkEventExterns.gdk_event_get_keyval(@event, out keyval);
	}

	public static bool GetPointerEmulated(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_pointer_emulated(@event);
	}

	public static bool GetRootCoords(this GdkEventHandle @event, out double x_root, out double y_root)
	{
		return GdkEventExterns.gdk_event_get_root_coords(@event, out x_root, out y_root);
	}

	public static int GetScancode(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_scancode(@event);
	}

	public static GdkScreenHandle GetScreen(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_screen(@event);
	}

	public static bool GetScrollDeltas(this GdkEventHandle @event, out double delta_x, out double delta_y)
	{
		return GdkEventExterns.gdk_event_get_scroll_deltas(@event, out delta_x, out delta_y);
	}

	public static bool GetScrollDirection(this GdkEventHandle @event, out GdkScrollDirection direction)
	{
		return GdkEventExterns.gdk_event_get_scroll_direction(@event, out direction);
	}

	public static GdkSeatHandle GetSeat(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_seat(@event);
	}

	public static GdkDeviceHandle GetSourceDevice(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_source_device(@event);
	}

	public static bool GetState(this GdkEventHandle @event, out GdkModifierType state)
	{
		return GdkEventExterns.gdk_event_get_state(@event, out state);
	}

	public static uint GetTime(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_time(@event);
	}

	public static GdkWindowHandle GetWindow(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_get_window(@event);
	}

	public static bool IsScrollStopEvent(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_is_scroll_stop_event(@event);
	}

	public static GdkEventHandle Put(this GdkEventHandle @event)
	{
		GdkEventExterns.gdk_event_put(@event);
		return @event;
	}

	public static GdkEventHandle SetDevice(this GdkEventHandle @event, GdkDeviceHandle device)
	{
		GdkEventExterns.gdk_event_set_device(@event, device);
		return @event;
	}

	public static GdkEventHandle SetDeviceTool(this GdkEventHandle @event, GdkDeviceToolHandle tool)
	{
		GdkEventExterns.gdk_event_set_device_tool(@event, tool);
		return @event;
	}

	public static GdkEventHandle SetScreen(this GdkEventHandle @event, GdkScreenHandle screen)
	{
		GdkEventExterns.gdk_event_set_screen(@event, screen);
		return @event;
	}

	public static GdkEventHandle SetSourceDevice(this GdkEventHandle @event, GdkDeviceHandle device)
	{
		GdkEventExterns.gdk_event_set_source_device(@event, device);
		return @event;
	}

	public static bool TriggersContextMenu(this GdkEventHandle @event)
	{
		return GdkEventExterns.gdk_event_triggers_context_menu(@event);
	}

}
internal class GdkEventExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventHandle gdk_event_new(GdkEventType type);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_events_get_angle(GdkEventHandle event1, GdkEventHandle event2, out double angle);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_events_get_center(GdkEventHandle event1, GdkEventHandle event2, out double x, out double y);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_events_get_distance(GdkEventHandle event1, GdkEventHandle event2, out double distance);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventHandle gdk_event_copy(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_event_free(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_axis(GdkEventHandle @event, GdkAxisUse axis_use, out double value);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_button(GdkEventHandle @event, out uint button);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_click_count(GdkEventHandle @event, out uint click_count);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_coords(GdkEventHandle @event, out double x_win, out double y_win);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceHandle gdk_event_get_device(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceToolHandle gdk_event_get_device_tool(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventSequenceHandle gdk_event_get_event_sequence(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventType gdk_event_get_event_type(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_keycode(GdkEventHandle @event, out ushort keycode);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_keyval(GdkEventHandle @event, out uint keyval);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_pointer_emulated(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_root_coords(GdkEventHandle @event, out double x_root, out double y_root);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_event_get_scancode(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkScreenHandle gdk_event_get_screen(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_scroll_deltas(GdkEventHandle @event, out double delta_x, out double delta_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_scroll_direction(GdkEventHandle @event, out GdkScrollDirection direction);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkSeatHandle gdk_event_get_seat(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceHandle gdk_event_get_source_device(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_get_state(GdkEventHandle @event, out GdkModifierType state);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_event_get_time(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_event_get_window(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_is_scroll_stop_event(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_event_put(GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_event_set_device(GdkEventHandle @event, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_event_set_device_tool(GdkEventHandle @event, GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_event_set_screen(GdkEventHandle @event, GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_event_set_source_device(GdkEventHandle @event, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_event_triggers_context_menu(GdkEventHandle @event);

}

public struct GdkEvent
{
	public GdkEventType type;
	public GdkEventAny any;
	public GdkEventExpose expose;
	public GdkEventVisibility visibility;
	public GdkEventMotion motion;
	public GdkEventButton button;
	public GdkEventTouch touch;
	public GdkEventScroll scroll;
	public GdkEventKey key;
	public GdkEventCrossing crossing;
	public GdkEventFocus focus_change;
	public GdkEventConfigure configure;
	public GdkEventProperty property;
	public GdkEventSelection selection;
	public GdkEventOwnerChange owner_change;
	public GdkEventProximity proximity;
	public GdkEventDND dnd;
	public GdkEventWindowState window_state;
	public GdkEventSetting setting;
	public GdkEventGrabBroken grab_broken;
	public GdkEventTouchpadSwipe touchpad_swipe;
	public GdkEventTouchpadPinch touchpad_pinch;
	public GdkEventPadButton pad_button;
	public GdkEventPadAxis pad_axis;
	public GdkEventPadGroupMode pad_group_mode;
}
