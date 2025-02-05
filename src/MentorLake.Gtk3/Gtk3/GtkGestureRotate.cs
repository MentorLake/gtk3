namespace MentorLake.Gtk3.Gtk3;

public class GtkGestureRotateHandle : GtkGestureHandle
{
	public static GtkGestureRotateHandle New(GtkWidgetHandle widget)
	{
		return GtkGestureRotateExterns.gtk_gesture_rotate_new(widget);
	}

}

public static class GtkGestureRotateSignalExtensions
{

	public static IObservable<GtkGestureRotateSignalStructs.AngleChangedSignal> Signal_AngleChanged(this GtkGestureRotateHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureRotateSignalStructs.AngleChangedSignal> obs) =>
		{
			GtkGestureRotateSignalDelegates.angle_changed handler = (GtkGestureRotateHandle self, double angle, double angle_delta, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureRotateSignalStructs.AngleChangedSignal()
				{
					Self = self, Angle = angle, AngleDelta = angle_delta, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "angle_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureRotateSignalStructs
{

public struct AngleChangedSignal
{
	public GtkGestureRotateHandle Self;
	public double Angle;
	public double AngleDelta;
	public IntPtr UserData;
}
}

public static class GtkGestureRotateSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void angle_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureRotateHandle>))] GtkGestureRotateHandle self, double angle, double angle_delta, IntPtr user_data);

}


public static class GtkGestureRotateHandleExtensions
{
	public static double GetAngleDelta(this GtkGestureRotateHandle gesture)
	{
		return GtkGestureRotateExterns.gtk_gesture_rotate_get_angle_delta(gesture);
	}

}

internal class GtkGestureRotateExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGestureRotateHandle gtk_gesture_rotate_new(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_gesture_rotate_get_angle_delta(GtkGestureRotateHandle gesture);

}
