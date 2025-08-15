namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGestureSingle is a subclass of #GtkGesture, optimized (although
/// not restricted) for dealing with mouse and single-touch gestures. Under
/// interaction, these gestures stick to the first interacting sequence, which
/// is accessible through gtk_gesture_single_get_current_sequence() while the
/// gesture is being interacted with.
/// </para>
/// <para>
/// By default gestures react to both %GDK_BUTTON_PRIMARY and touch
/// events, gtk_gesture_single_set_touch_only() can be used to change the
/// touch behavior. Callers may also specify a different mouse button number
/// to interact with through gtk_gesture_single_set_button(), or react to any
/// mouse button by setting 0. While the gesture is active, the button being
/// currently pressed can be known through gtk_gesture_single_get_current_button().
/// </para>
/// </summary>

public class GtkGestureSingleHandle : GtkGestureHandle
{
}

public static class GtkGestureSingleHandleExtensions
{
/// <summary>
/// <para>
/// Returns the button number @gesture listens for, or 0 if @gesture
/// reacts to any button press.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSingle
/// </param>
/// <return>
/// The button number, or 0 for any button
/// </return>

	public static uint GetButton(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_button(gesture);
	}

/// <summary>
/// <para>
/// Returns the button number currently interacting with @gesture, or 0 if there
/// is none.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSingle
/// </param>
/// <return>
/// The current button number
/// </return>

	public static uint GetCurrentButton(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_current_button(gesture);
	}

/// <summary>
/// <para>
/// Returns the event sequence currently interacting with @gesture.
/// This is only meaningful if gtk_gesture_is_active() returns %TRUE.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSingle
/// </param>
/// <return>
/// the current sequence
/// </return>

	public static MentorLake.Gdk.GdkEventSequenceHandle GetCurrentSequence(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_current_sequence(gesture);
	}

/// <summary>
/// <para>
/// Gets whether a gesture is exclusive. For more information, see
/// gtk_gesture_single_set_exclusive().
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSingle
/// </param>
/// <return>
/// Whether the gesture is exclusive
/// </return>

	public static bool GetExclusive(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_exclusive(gesture);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the gesture is only triggered by touch events.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSingle
/// </param>
/// <return>
/// %TRUE if the gesture only handles touch events
/// </return>

	public static bool GetTouchOnly(this MentorLake.Gtk.GtkGestureSingleHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		return GtkGestureSingleHandleExterns.gtk_gesture_single_get_touch_only(gesture);
	}

/// <summary>
/// <para>
/// Sets the button number @gesture listens to. If non-0, every
/// button press from a different button number will be ignored.
/// Touch events implicitly match with button 1.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSingle
/// </param>
/// <param name="button">
/// button number to listen to, or 0 for any button
/// </param>

	public static T SetButton<T>(this T gesture, uint button) where T : GtkGestureSingleHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		GtkGestureSingleHandleExterns.gtk_gesture_single_set_button(gesture, button);
		return gesture;
	}

/// <summary>
/// <para>
/// Sets whether @gesture is exclusive. An exclusive gesture will
/// only handle pointer and &quot;pointer emulated&quot; touch events, so at
/// any given time, there is only one sequence able to interact with
/// those.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSingle
/// </param>
/// <param name="exclusive">
/// %TRUE to make @gesture exclusive
/// </param>

	public static T SetExclusive<T>(this T gesture, bool exclusive) where T : GtkGestureSingleHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSingleHandle)");
		GtkGestureSingleHandleExterns.gtk_gesture_single_set_exclusive(gesture, exclusive);
		return gesture;
	}

/// <summary>
/// <para>
/// If @touch_only is %TRUE, @gesture will only handle events of type
/// #GDK_TOUCH_BEGIN, #GDK_TOUCH_UPDATE or #GDK_TOUCH_END. If %FALSE,
/// mouse events will be handled too.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSingle
/// </param>
/// <param name="touch_only">
/// whether @gesture handles only touch events
/// </param>

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
