namespace MentorLake.Gtk;

public class GtkEventControllerMotionHandle : GtkEventControllerHandle
{
	public static MentorLake.Gtk.GtkEventControllerMotionHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkEventControllerMotionHandleExterns.gtk_event_controller_motion_new(widget);
	}

}
public static class GtkEventControllerMotionHandleSignalExtensions
{

	public static IObservable<GtkEventControllerMotionHandleSignalStructs.EnterSignal> Signal_Enter(this GtkEventControllerMotionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionHandleSignalStructs.EnterSignal> obs) =>
		{
			GtkEventControllerMotionHandleSignalDelegates.enter handler = ( MentorLake.Gtk.GtkEventControllerMotionHandle self,  double x,  double y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionHandleSignalStructs.EnterSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEventControllerMotionHandleSignalStructs.LeaveSignal> Signal_Leave(this GtkEventControllerMotionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionHandleSignalStructs.LeaveSignal> obs) =>
		{
			GtkEventControllerMotionHandleSignalDelegates.leave handler = ( MentorLake.Gtk.GtkEventControllerMotionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionHandleSignalStructs.LeaveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEventControllerMotionHandleSignalStructs.MotionSignal> Signal_Motion(this GtkEventControllerMotionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionHandleSignalStructs.MotionSignal> obs) =>
		{
			GtkEventControllerMotionHandleSignalDelegates.motion handler = ( MentorLake.Gtk.GtkEventControllerMotionHandle self,  double x,  double y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionHandleSignalStructs.MotionSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkEventControllerMotionHandleSignalStructs
{

public class EnterSignal
{
	public MentorLake.Gtk.GtkEventControllerMotionHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public class LeaveSignal
{
	public MentorLake.Gtk.GtkEventControllerMotionHandle Self;
	public IntPtr UserData;
}

public class MotionSignal
{
	public MentorLake.Gtk.GtkEventControllerMotionHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
}
}

public static class GtkEventControllerMotionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerMotionHandle>))] MentorLake.Gtk.GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerMotionHandle>))] MentorLake.Gtk.GtkEventControllerMotionHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerMotionHandle>))] MentorLake.Gtk.GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);

}


public static class GtkEventControllerMotionHandleExtensions
{
}

internal class GtkEventControllerMotionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerMotionHandle>))]
	internal static extern MentorLake.Gtk.GtkEventControllerMotionHandle gtk_event_controller_motion_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}
