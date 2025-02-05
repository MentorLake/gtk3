namespace MentorLake.Gtk3.Gtk3;

public class GtkGestureLongPressHandle : GtkGestureSingleHandle
{
	public static GtkGestureLongPressHandle New(GtkWidgetHandle widget)
	{
		return GtkGestureLongPressExterns.gtk_gesture_long_press_new(widget);
	}

}

public static class GtkGestureLongPressSignalExtensions
{

	public static IObservable<GtkGestureLongPressSignalStructs.CancelledSignal> Signal_Cancelled(this GtkGestureLongPressHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureLongPressSignalStructs.CancelledSignal> obs) =>
		{
			GtkGestureLongPressSignalDelegates.cancelled handler = (GtkGestureLongPressHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureLongPressSignalStructs.CancelledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cancelled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureLongPressSignalStructs.PressedSignal> Signal_Pressed(this GtkGestureLongPressHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureLongPressSignalStructs.PressedSignal> obs) =>
		{
			GtkGestureLongPressSignalDelegates.pressed handler = (GtkGestureLongPressHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureLongPressSignalStructs.PressedSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
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
}

public static class GtkGestureLongPressSignalStructs
{

public struct CancelledSignal
{
	public GtkGestureLongPressHandle Self;
	public IntPtr UserData;
}

public struct PressedSignal
{
	public GtkGestureLongPressHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}
}

public static class GtkGestureLongPressSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureLongPressHandle>))] GtkGestureLongPressHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureLongPressHandle>))] GtkGestureLongPressHandle self, double x, double y, IntPtr user_data);

}


public static class GtkGestureLongPressHandleExtensions
{
}

internal class GtkGestureLongPressExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGestureLongPressHandle gtk_gesture_long_press_new(GtkWidgetHandle widget);

}
