namespace MentorLake.Gtk;

public class GtkGestureZoomHandle : GtkGestureHandle
{
	public static MentorLake.Gtk.GtkGestureZoomHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureZoomHandleExterns.gtk_gesture_zoom_new(widget);
	}

}
public static class GtkGestureZoomHandleSignalExtensions
{

	public static IObservable<GtkGestureZoomHandleSignalStructs.ScaleChangedSignal> Signal_ScaleChanged(this GtkGestureZoomHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureZoomHandleSignalStructs.ScaleChangedSignal> obs) =>
		{
			GtkGestureZoomHandleSignalDelegates.scale_changed handler = ( MentorLake.Gtk.GtkGestureZoomHandle self,  double scale,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureZoomHandleSignalStructs.ScaleChangedSignal()
				{
					Self = self, Scale = scale, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scale-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGestureZoomHandleSignalStructs
{

public class ScaleChangedSignal
{
	public MentorLake.Gtk.GtkGestureZoomHandle Self;
	public double Scale;
	public IntPtr UserData;
}
}

public static class GtkGestureZoomHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scale_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureZoomHandle>))] MentorLake.Gtk.GtkGestureZoomHandle self, double scale, IntPtr user_data);

}


public static class GtkGestureZoomHandleExtensions
{
	public static double GetScaleDelta(this MentorLake.Gtk.GtkGestureZoomHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureZoomHandle)");
		return GtkGestureZoomHandleExterns.gtk_gesture_zoom_get_scale_delta(gesture);
	}

}

internal class GtkGestureZoomHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGestureZoomHandle gtk_gesture_zoom_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_gesture_zoom_get_scale_delta([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureZoomHandle>))] MentorLake.Gtk.GtkGestureZoomHandle gesture);

}
