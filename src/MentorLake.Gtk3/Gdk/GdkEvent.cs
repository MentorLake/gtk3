namespace MentorLake.Gdk;

public class GdkEventHandle : BaseSafeHandle
{
	public static MentorLake.Gdk.GdkEventHandle New(MentorLake.Gdk.GdkEventType type)
	{
		return GdkEventExterns.gdk_event_new(type);
	}

}


public static class GdkEventExtensions
{
	public static bool GetAngle(this MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double angle)
	{
		if (event1.IsInvalid || event1.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_events_get_angle(event1, event2, out angle);
	}

	public static bool GetCenter(this MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double x, out double y)
	{
		if (event1.IsInvalid || event1.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_events_get_center(event1, event2, out x, out y);
	}

	public static bool GetDistance(this MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double distance)
	{
		if (event1.IsInvalid || event1.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_events_get_distance(event1, event2, out distance);
	}

	public static MentorLake.Gdk.GdkEventHandle Copy(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_copy(@event);
	}

	public static void Free(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		GdkEventExterns.gdk_event_free(@event);
	}

	public static bool GetAxis(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkAxisUse axis_use, out double value)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_axis(@event, axis_use, out value);
	}

	public static bool GetButton(this MentorLake.Gdk.GdkEventHandle @event, out uint button)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_button(@event, out button);
	}

	public static bool GetClickCount(this MentorLake.Gdk.GdkEventHandle @event, out uint click_count)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_click_count(@event, out click_count);
	}

	public static bool GetCoords(this MentorLake.Gdk.GdkEventHandle @event, out double x_win, out double y_win)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_coords(@event, out x_win, out y_win);
	}

	public static MentorLake.Gdk.GdkDeviceHandle GetDevice(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_device(@event);
	}

	public static MentorLake.Gdk.GdkDeviceToolHandle GetDeviceTool(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_device_tool(@event);
	}

	public static MentorLake.Gdk.GdkEventSequenceHandle GetEventSequence(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_event_sequence(@event);
	}

	public static MentorLake.Gdk.GdkEventType GetEventType(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_event_type(@event);
	}

	public static bool GetKeycode(this MentorLake.Gdk.GdkEventHandle @event, out ushort keycode)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_keycode(@event, out keycode);
	}

	public static bool GetKeyval(this MentorLake.Gdk.GdkEventHandle @event, out uint keyval)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_keyval(@event, out keyval);
	}

	public static bool GetPointerEmulated(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_pointer_emulated(@event);
	}

	public static bool GetRootCoords(this MentorLake.Gdk.GdkEventHandle @event, out double x_root, out double y_root)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_root_coords(@event, out x_root, out y_root);
	}

	public static int GetScancode(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_scancode(@event);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_screen(@event);
	}

	public static bool GetScrollDeltas(this MentorLake.Gdk.GdkEventHandle @event, out double delta_x, out double delta_y)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_scroll_deltas(@event, out delta_x, out delta_y);
	}

	public static bool GetScrollDirection(this MentorLake.Gdk.GdkEventHandle @event, out MentorLake.Gdk.GdkScrollDirection direction)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_scroll_direction(@event, out direction);
	}

	public static MentorLake.Gdk.GdkSeatHandle GetSeat(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_seat(@event);
	}

	public static MentorLake.Gdk.GdkDeviceHandle GetSourceDevice(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_source_device(@event);
	}

	public static bool GetState(this MentorLake.Gdk.GdkEventHandle @event, out MentorLake.Gdk.GdkModifierType state)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_state(@event, out state);
	}

	public static uint GetTime(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_time(@event);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_get_window(@event);
	}

	public static bool IsScrollStopEvent(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_is_scroll_stop_event(@event);
	}

	public static void Put(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		GdkEventExterns.gdk_event_put(@event);
	}

	public static void SetDevice(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		GdkEventExterns.gdk_event_set_device(@event, device);
	}

	public static void SetDeviceTool(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkDeviceToolHandle tool)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		GdkEventExterns.gdk_event_set_device_tool(@event, tool);
	}

	public static void SetScreen(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkScreenHandle screen)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		GdkEventExterns.gdk_event_set_screen(@event, screen);
	}

	public static void SetSourceDevice(this MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		GdkEventExterns.gdk_event_set_source_device(@event, device);
	}

	public static bool TriggersContextMenu(this MentorLake.Gdk.GdkEventHandle @event)
	{
		if (@event.IsInvalid || @event.IsClosed) throw new Exception("Invalid or closed handle (GdkEvent)");
		return GdkEventExterns.gdk_event_triggers_context_menu(@event);
	}


	public static GdkEvent Dereference(this GdkEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEvent>(x.DangerousGetHandle());
}
internal class GdkEventExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_new(MentorLake.Gdk.GdkEventType type);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_angle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double angle);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_center([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double x, out double y);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double distance);

	[DllImport(GdkLibrary.Name)]
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
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_event_get_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceToolHandle gdk_event_get_device_tool([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
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
	internal static extern MentorLake.Gdk.GdkScreenHandle gdk_event_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_scroll_deltas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out double delta_x, out double delta_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_scroll_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out MentorLake.Gdk.GdkScrollDirection direction);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkSeatHandle gdk_event_get_seat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_event_get_source_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_event_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, out MentorLake.Gdk.GdkModifierType state);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_event_get_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
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
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_get();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_handler_set(MentorLake.Gdk.GdkEventFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_peek();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_request_motions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventMotionHandle>))] MentorLake.Gdk.GdkEventMotionHandle @event);

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
	public static MentorLake.Gdk.GdkEventHandle Get()
	{
		return GdkEventExterns.gdk_event_get();
	}

	public static void HandlerSet(MentorLake.Gdk.GdkEventFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		GdkEventExterns.gdk_event_handler_set(func, data, notify);
	}

	public static MentorLake.Gdk.GdkEventHandle Peek()
	{
		return GdkEventExterns.gdk_event_peek();
	}

	public static void RequestMotions(MentorLake.Gdk.GdkEventMotionHandle @event)
	{
		GdkEventExterns.gdk_event_request_motions(@event);
	}

}
