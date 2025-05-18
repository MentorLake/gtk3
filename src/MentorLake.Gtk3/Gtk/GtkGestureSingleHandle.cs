namespace MentorLake.Gtk;

public class GtkGestureSingleHandle : GtkGestureHandle
{
}

public static class GtkGestureSingleHandleExtensions
{
	public static uint GetButton(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_button(gesture);
	}

	public static uint GetCurrentButton(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_current_button(gesture);
	}

	public static MentorLake.Gdk.GdkEventSequenceHandle GetCurrentSequence(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_current_sequence(gesture);
	}

	public static bool GetExclusive(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_exclusive(gesture);
	}

	public static bool GetTouchOnly(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_touch_only(gesture);
	}

	public static T SetButton<T>(this T gesture, uint button) where T : GtkGestureSingleHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		GtkGestureSingleHandleExterns.gtk_gesture_single_set_button(gesture, button);
		return gesture;
	}

	public static T SetExclusive<T>(this T gesture, bool exclusive) where T : GtkGestureSingleHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		GtkGestureSingleHandleExterns.gtk_gesture_single_set_exclusive(gesture, exclusive);
		return gesture;
	}

	public static T SetTouchOnly<T>(this T gesture, bool touch_only) where T : GtkGestureSingleHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		GtkGestureSingleHandleExterns.gtk_gesture_single_set_touch_only(gesture, touch_only);
		return gesture;
	}

}

internal class GtkGestureSingleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_gesture_single_get_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSingleHandle>))] MentorLake.Gtk.GtkGestureSingleHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_gesture_single_get_current_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSingleHandle>))] MentorLake.Gtk.GtkGestureSingleHandle gesture);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))]
	internal static extern MentorLake.Gdk.GdkEventSequenceHandle gtk_gesture_single_get_current_sequence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSingleHandle>))] MentorLake.Gtk.GtkGestureSingleHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_single_get_exclusive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSingleHandle>))] MentorLake.Gtk.GtkGestureSingleHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_single_get_touch_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSingleHandle>))] MentorLake.Gtk.GtkGestureSingleHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_single_set_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSingleHandle>))] MentorLake.Gtk.GtkGestureSingleHandle gesture, uint button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_single_set_exclusive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSingleHandle>))] MentorLake.Gtk.GtkGestureSingleHandle gesture, bool exclusive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_single_set_touch_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSingleHandle>))] MentorLake.Gtk.GtkGestureSingleHandle gesture, bool touch_only);

}
