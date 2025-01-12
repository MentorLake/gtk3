namespace MentorLake.Gtk3.Gtk3;

public class GtkGestureSingleHandle : GtkGestureHandle
{
}

public static class GtkGestureSingleHandleExtensions
{
	public static uint GetButton(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_button(gesture);
	}

	public static uint GetCurrentButton(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_current_button(gesture);
	}

	public static GdkEventSequenceHandle GetCurrentSequence(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_current_sequence(gesture);
	}

	public static bool GetExclusive(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_exclusive(gesture);
	}

	public static bool GetTouchOnly(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_touch_only(gesture);
	}

	public static T SetButton<T>(this T gesture, uint button) where T : GtkGestureSingleHandle
	{
		GtkGestureSingleExterns.gtk_gesture_single_set_button(gesture, button);
		return gesture;
	}

	public static T SetExclusive<T>(this T gesture, bool exclusive) where T : GtkGestureSingleHandle
	{
		GtkGestureSingleExterns.gtk_gesture_single_set_exclusive(gesture, exclusive);
		return gesture;
	}

	public static T SetTouchOnly<T>(this T gesture, bool touch_only) where T : GtkGestureSingleHandle
	{
		GtkGestureSingleExterns.gtk_gesture_single_set_touch_only(gesture, touch_only);
		return gesture;
	}

}

internal class GtkGestureSingleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_gesture_single_get_button(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_gesture_single_get_current_button(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkEventSequenceHandle gtk_gesture_single_get_current_sequence(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gesture_single_get_exclusive(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gesture_single_get_touch_only(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gesture_single_set_button(GtkGestureSingleHandle gesture, uint button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gesture_single_set_exclusive(GtkGestureSingleHandle gesture, bool exclusive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gesture_single_set_touch_only(GtkGestureSingleHandle gesture, bool touch_only);

}
