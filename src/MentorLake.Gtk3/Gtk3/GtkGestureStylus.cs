namespace MentorLake.Gtk3.Gtk3;

public class GtkGestureStylusHandle : GtkGestureSingleHandle
{
	public static GtkGestureStylusHandle New(GtkWidgetHandle widget)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_new(widget);
	}

}

public static class GtkGestureStylusSignalExtensions
{

	public static IObservable<GtkGestureStylusSignalStructs.DownSignal> Signal_Down(this GtkGestureStylusHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureStylusSignalStructs.DownSignal> obs) =>
		{
			GtkGestureStylusSignalDelegates.down handler = (GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusSignalStructs.DownSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "down", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureStylusSignalStructs.MotionSignal> Signal_Motion(this GtkGestureStylusHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureStylusSignalStructs.MotionSignal> obs) =>
		{
			GtkGestureStylusSignalDelegates.motion handler = (GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusSignalStructs.MotionSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureStylusSignalStructs.ProximitySignal> Signal_Proximity(this GtkGestureStylusHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureStylusSignalStructs.ProximitySignal> obs) =>
		{
			GtkGestureStylusSignalDelegates.proximity handler = (GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusSignalStructs.ProximitySignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "proximity", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGestureStylusSignalStructs.UpSignal> Signal_Up(this GtkGestureStylusHandle instance)
	{
		return Observable.Create((IObserver<GtkGestureStylusSignalStructs.UpSignal> obs) =>
		{
			GtkGestureStylusSignalDelegates.up handler = (GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusSignalStructs.UpSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "up", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGestureStylusSignalStructs
{

public struct DownSignal
{
	public GtkGestureStylusHandle Self;
	public double Object;
	public double P0;
	public IntPtr UserData;
}

public struct MotionSignal
{
	public GtkGestureStylusHandle Self;
	public double Object;
	public double P0;
	public IntPtr UserData;
}

public struct ProximitySignal
{
	public GtkGestureStylusHandle Self;
	public double Object;
	public double P0;
	public IntPtr UserData;
}

public struct UpSignal
{
	public GtkGestureStylusHandle Self;
	public double Object;
	public double P0;
	public IntPtr UserData;
}
}

public static class GtkGestureStylusSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void proximity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data);

}


public static class GtkGestureStylusHandleExtensions
{
	public static bool GetAxes(this GtkGestureStylusHandle gesture, GdkAxisUse[] axes, out double[] values)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_axes(gesture, axes, out values);
	}

	public static bool GetAxis(this GtkGestureStylusHandle gesture, GdkAxisUse axis, out double value)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_axis(gesture, axis, out value);
	}

	public static GdkDeviceToolHandle GetDeviceTool(this GtkGestureStylusHandle gesture)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_device_tool(gesture);
	}

}

internal class GtkGestureStylusExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGestureStylusHandle gtk_gesture_stylus_new(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gesture_stylus_get_axes(GtkGestureStylusHandle gesture, GdkAxisUse[] axes, out double[] values);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gesture_stylus_get_axis(GtkGestureStylusHandle gesture, GdkAxisUse axis, out double value);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkDeviceToolHandle gtk_gesture_stylus_get_device_tool(GtkGestureStylusHandle gesture);

}
