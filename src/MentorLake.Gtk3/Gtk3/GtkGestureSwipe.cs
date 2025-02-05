namespace MentorLake.Gtk3.Gtk3;

public class GtkGestureSwipeHandle : GtkGestureSingleHandle
{
	public static GtkGestureSwipeHandle New(GtkWidgetHandle widget)
	{
		return GtkGestureSwipeExterns.gtk_gesture_swipe_new(widget);
	}

}

public static class GtkGestureSwipeSignalExtensions
{

	public static IObservable<GtkGestureSwipeSignalStructs.SwipeSignal> Signal_Swipe(this GtkGestureSwipeHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureSwipeSignalStructs.SwipeSignal> obs) =>
		{
			GtkGestureSwipeSignalDelegates.swipe handler = (GtkGestureSwipeHandle self, double velocity_x, double velocity_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureSwipeSignalStructs.SwipeSignal()
				{
					Self = self, VelocityX = velocity_x, VelocityY = velocity_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "swipe", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureSwipeSignalStructs
{

public struct SwipeSignal
{
	public GtkGestureSwipeHandle Self;
	public double VelocityX;
	public double VelocityY;
	public IntPtr UserData;
}
}

public static class GtkGestureSwipeSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void swipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureSwipeHandle>))] GtkGestureSwipeHandle self, double velocity_x, double velocity_y, IntPtr user_data);

}


public static class GtkGestureSwipeHandleExtensions
{
	public static bool GetVelocity(this GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y)
	{
		return GtkGestureSwipeExterns.gtk_gesture_swipe_get_velocity(gesture, out velocity_x, out velocity_y);
	}

}

internal class GtkGestureSwipeExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGestureSwipeHandle gtk_gesture_swipe_new(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gesture_swipe_get_velocity(GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y);

}
