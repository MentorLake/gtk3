namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGestureSwipe is a #GtkGesture implementation able to recognize
/// swipes, after a press/move/.../move/release sequence happens, the
/// #GtkGestureSwipe::swipe signal will be emitted, providing the velocity
/// and directionality of the sequence at the time it was lifted.
/// </para>
/// <para>
/// If the velocity is desired in intermediate points,
/// gtk_gesture_swipe_get_velocity() can be called on eg. a
/// #GtkGesture::update handler.
/// </para>
/// <para>
/// All velocities are reported in pixels/sec units.
/// </para>
/// </summary>

public class GtkGestureSwipeHandle : GtkGestureSingleHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkGesture that recognizes swipes.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a newly created #GtkGestureSwipe
/// </return>

	public static MentorLake.Gtk.GtkGestureSwipeHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureSwipeHandleExterns.gtk_gesture_swipe_new(widget);
	}

}
public static class GtkGestureSwipeHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the recognized gesture is finished, velocity
/// and direction are a product of previously recorded events.
/// </para>
/// </summary>

	public static IObservable<GtkGestureSwipeHandleSignalStructs.SwipeSignal> Signal_Swipe(this GtkGestureSwipeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureSwipeHandleSignalStructs.SwipeSignal> obs) =>
		{
			GtkGestureSwipeHandleSignalDelegates.swipe handler = ( MentorLake.Gtk.GtkGestureSwipeHandle self,  double velocity_x,  double velocity_y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureSwipeHandleSignalStructs.SwipeSignal()
				{
					Self = self, VelocityX = velocity_x, VelocityY = velocity_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "swipe", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGestureSwipeHandleSignalStructs
{

public class SwipeSignal
{

	public MentorLake.Gtk.GtkGestureSwipeHandle Self;
/// <summary>
/// <para>
/// velocity in the X axis, in pixels/sec
/// </para>
/// </summary>

	public double VelocityX;
/// <summary>
/// <para>
/// velocity in the Y axis, in pixels/sec
/// </para>
/// </summary>

	public double VelocityY;

	public IntPtr UserData;
}
}

public static class GtkGestureSwipeHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the recognized gesture is finished, velocity
/// and direction are a product of previously recorded events.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="velocity_x">
/// velocity in the X axis, in pixels/sec
/// </param>
/// <param name="velocity_y">
/// velocity in the Y axis, in pixels/sec
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void swipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSwipeHandle>))] MentorLake.Gtk.GtkGestureSwipeHandle self, double velocity_x, double velocity_y, IntPtr user_data);

}


public static class GtkGestureSwipeHandleExtensions
{
/// <summary>
/// <para>
/// If the gesture is recognized, this function returns %TRUE and fill in
/// @velocity_x and @velocity_y with the recorded velocity, as per the
/// last event(s) processed.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureSwipe
/// </param>
/// <param name="velocity_x">
/// return value for the velocity in the X axis, in pixels/sec
/// </param>
/// <param name="velocity_y">
/// return value for the velocity in the Y axis, in pixels/sec
/// </param>
/// <return>
/// whether velocity could be calculated
/// </return>

	public static bool GetVelocity(this MentorLake.Gtk.GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureSwipeHandle)");
		return GtkGestureSwipeHandleExterns.gtk_gesture_swipe_get_velocity(gesture, out velocity_x, out velocity_y);
	}

}

internal class GtkGestureSwipeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSwipeHandle>))]
	internal static extern MentorLake.Gtk.GtkGestureSwipeHandle gtk_gesture_swipe_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_swipe_get_velocity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSwipeHandle>))] MentorLake.Gtk.GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y);

}
