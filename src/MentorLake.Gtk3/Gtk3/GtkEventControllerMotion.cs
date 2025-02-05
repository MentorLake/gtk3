namespace MentorLake.Gtk3.Gtk3;

public class GtkEventControllerMotionHandle : GtkEventControllerHandle
{
	public static GtkEventControllerMotionHandle New(GtkWidgetHandle widget)
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_new(widget);
	}

}

public static class GtkEventControllerMotionSignalExtensions
{

	public static IObservable<GtkEventControllerMotionSignalStructs.EnterSignal> Signal_Enter(this GtkEventControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionSignalStructs.EnterSignal> obs) =>
		{
			GtkEventControllerMotionSignalDelegates.enter handler = (GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionSignalStructs.EnterSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerMotionSignalStructs.LeaveSignal> Signal_Leave(this GtkEventControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionSignalStructs.LeaveSignal> obs) =>
		{
			GtkEventControllerMotionSignalDelegates.leave handler = (GtkEventControllerMotionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionSignalStructs.LeaveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerMotionSignalStructs.MotionSignal> Signal_Motion(this GtkEventControllerMotionHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionSignalStructs.MotionSignal> obs) =>
		{
			GtkEventControllerMotionSignalDelegates.motion handler = (GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionSignalStructs.MotionSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
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
}

public static class GtkEventControllerMotionSignalStructs
{

public struct EnterSignal
{
	public GtkEventControllerMotionHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public struct LeaveSignal
{
	public GtkEventControllerMotionHandle Self;
	public IntPtr UserData;
}

public struct MotionSignal
{
	public GtkEventControllerMotionHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}
}

public static class GtkEventControllerMotionSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);

}


public static class GtkEventControllerMotionHandleExtensions
{
}

internal class GtkEventControllerMotionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEventControllerMotionHandle gtk_event_controller_motion_new(GtkWidgetHandle widget);

}
