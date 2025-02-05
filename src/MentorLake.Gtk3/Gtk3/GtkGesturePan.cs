namespace MentorLake.Gtk3.Gtk3;

public class GtkGesturePanHandle : GtkGestureDragHandle
{
	public static GtkGesturePanHandle New(GtkWidgetHandle widget, GtkOrientation orientation)
	{
		return GtkGesturePanExterns.gtk_gesture_pan_new(widget, orientation);
	}

}

public static class GtkGesturePanSignalExtensions
{

	public static IObservable<GtkGesturePanSignalStructs.PanSignal> Signal_Pan(this GtkGesturePanHandle instance)
	{
		return Observable.Create((IObserver<GtkGesturePanSignalStructs.PanSignal> obs) =>
		{
			GtkGesturePanSignalDelegates.pan handler = (GtkGesturePanHandle self, ref GtkPanDirection direction, double offset, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGesturePanSignalStructs.PanSignal()
				{
					Self = self, Direction = direction, Offset = offset, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "pan", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGesturePanSignalStructs
{

public struct PanSignal
{
	public GtkGesturePanHandle Self;
	public GtkPanDirection Direction;
	public double Offset;
	public IntPtr UserData;
}
}

public static class GtkGesturePanSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pan([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGesturePanHandle>))] GtkGesturePanHandle self, ref GtkPanDirection direction, double offset, IntPtr user_data);

}


public static class GtkGesturePanHandleExtensions
{
	public static GtkOrientation GetOrientation(this GtkGesturePanHandle gesture)
	{
		return GtkGesturePanExterns.gtk_gesture_pan_get_orientation(gesture);
	}

	public static T SetOrientation<T>(this T gesture, GtkOrientation orientation) where T : GtkGesturePanHandle
	{
		GtkGesturePanExterns.gtk_gesture_pan_set_orientation(gesture, orientation);
		return gesture;
	}

}

internal class GtkGesturePanExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGesturePanHandle gtk_gesture_pan_new(GtkWidgetHandle widget, GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOrientation gtk_gesture_pan_get_orientation(GtkGesturePanHandle gesture);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gesture_pan_set_orientation(GtkGesturePanHandle gesture, GtkOrientation orientation);

}
