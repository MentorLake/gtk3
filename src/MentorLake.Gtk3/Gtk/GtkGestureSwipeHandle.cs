namespace MentorLake.Gtk;

public class GtkGestureSwipeHandle : GtkGestureSingleHandle
{
	public static MentorLake.Gtk.GtkGestureSwipeHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureSwipeHandleExterns.gtk_gesture_swipe_new(widget);
	}

}
public static class GtkGestureSwipeHandleSignalExtensions
{

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

public struct SwipeSignal
{
	public MentorLake.Gtk.GtkGestureSwipeHandle Self;
	public double VelocityX;
	public double VelocityY;
	public IntPtr UserData;
}
}

public static class GtkGestureSwipeHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void swipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSwipeHandle>))] MentorLake.Gtk.GtkGestureSwipeHandle self, double velocity_x, double velocity_y, IntPtr user_data);

}


public static class GtkGestureSwipeHandleExtensions
{
	public static bool GetVelocity(this MentorLake.Gtk.GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y)
	{
		return GtkGestureSwipeHandleExterns.gtk_gesture_swipe_get_velocity(gesture, out velocity_x, out velocity_y);
	}

}

internal class GtkGestureSwipeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGestureSwipeHandle gtk_gesture_swipe_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_swipe_get_velocity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureSwipeHandle>))] MentorLake.Gtk.GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y);

}
