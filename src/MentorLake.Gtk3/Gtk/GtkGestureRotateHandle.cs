namespace MentorLake.Gtk;

public class GtkGestureRotateHandle : GtkGestureHandle
{
	public static MentorLake.Gtk.GtkGestureRotateHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureRotateHandleExterns.gtk_gesture_rotate_new(widget);
	}

}
public static class GtkGestureRotateHandleSignalExtensions
{

	public static IObservable<GtkGestureRotateHandleSignalStructs.AngleChangedSignal> Signal_AngleChanged(this GtkGestureRotateHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureRotateHandleSignalStructs.AngleChangedSignal> obs) =>
		{
			GtkGestureRotateHandleSignalDelegates.angle_changed handler = ( MentorLake.Gtk.GtkGestureRotateHandle self,  double angle,  double angle_delta,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureRotateHandleSignalStructs.AngleChangedSignal()
				{
					Self = self, Angle = angle, AngleDelta = angle_delta, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "angle-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGestureRotateHandleSignalStructs
{

public struct AngleChangedSignal
{
	public MentorLake.Gtk.GtkGestureRotateHandle Self;
	public double Angle;
	public double AngleDelta;
	public IntPtr UserData;
}
}

public static class GtkGestureRotateHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void angle_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureRotateHandle>))] MentorLake.Gtk.GtkGestureRotateHandle self, double angle, double angle_delta, IntPtr user_data);

}


public static class GtkGestureRotateHandleExtensions
{
	public static double GetAngleDelta(this MentorLake.Gtk.GtkGestureRotateHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureRotateHandle)");
		return GtkGestureRotateHandleExterns.gtk_gesture_rotate_get_angle_delta(gesture);
	}

}

internal class GtkGestureRotateHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGestureRotateHandle gtk_gesture_rotate_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_gesture_rotate_get_angle_delta([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureRotateHandle>))] MentorLake.Gtk.GtkGestureRotateHandle gesture);

}
