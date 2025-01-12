namespace MentorLake.Gtk3.Gtk3;

public class GtkGestureMultiPressHandle : GtkGestureSingleHandle
{
	public static GtkGestureMultiPressHandle New(GtkWidgetHandle widget)
	{
		return GtkGestureMultiPressExterns.gtk_gesture_multi_press_new(widget);
	}

}

public static class GtkGestureMultiPressSignalExtensions
{

	public static IObservable<GtkGestureMultiPressSignalStructs.PressedSignal> Signal_Pressed(this GtkGestureMultiPressHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureMultiPressSignalStructs.PressedSignal> obs) =>
		{
			GtkGestureMultiPressSignalDelegates.pressed handler = (GtkGestureMultiPressHandle self, int n_press, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureMultiPressSignalStructs.PressedSignal()
				{
					Self = self, NPress = n_press, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureMultiPressSignalStructs.ReleasedSignal> Signal_Released(this GtkGestureMultiPressHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureMultiPressSignalStructs.ReleasedSignal> obs) =>
		{
			GtkGestureMultiPressSignalDelegates.released handler = (GtkGestureMultiPressHandle self, int n_press, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureMultiPressSignalStructs.ReleasedSignal()
				{
					Self = self, NPress = n_press, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureMultiPressSignalStructs.StoppedSignal> Signal_Stopped(this GtkGestureMultiPressHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureMultiPressSignalStructs.StoppedSignal> obs) =>
		{
			GtkGestureMultiPressSignalDelegates.stopped handler = (GtkGestureMultiPressHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureMultiPressSignalStructs.StoppedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "stopped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureMultiPressSignalStructs
{

public struct PressedSignal
{
	public GtkGestureMultiPressHandle Self;
	public int NPress;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct ReleasedSignal
{
	public GtkGestureMultiPressHandle Self;
	public int NPress;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct StoppedSignal
{
	public GtkGestureMultiPressHandle Self;
	public IntPtr UserData;
}
}

public static class GtkGestureMultiPressSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureMultiPressHandle>))] GtkGestureMultiPressHandle self, int n_press, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureMultiPressHandle>))] GtkGestureMultiPressHandle self, int n_press, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stopped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureMultiPressHandle>))] GtkGestureMultiPressHandle self, IntPtr user_data);

}


public static class GtkGestureMultiPressHandleExtensions
{
	public static bool GetArea(this GtkGestureMultiPressHandle gesture, out GdkRectangle rect)
	{
		return GtkGestureMultiPressExterns.gtk_gesture_multi_press_get_area(gesture, out rect);
	}

	public static GtkGestureMultiPressHandle SetArea(this GtkGestureMultiPressHandle gesture, GdkRectangleHandle rect)
	{
		GtkGestureMultiPressExterns.gtk_gesture_multi_press_set_area(gesture, rect);
		return gesture;
	}

}

internal class GtkGestureMultiPressExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGestureMultiPressHandle gtk_gesture_multi_press_new(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gesture_multi_press_get_area(GtkGestureMultiPressHandle gesture, out GdkRectangle rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gesture_multi_press_set_area(GtkGestureMultiPressHandle gesture, GdkRectangleHandle rect);

}
