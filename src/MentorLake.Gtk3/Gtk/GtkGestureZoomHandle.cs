namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGestureZoom is a #GtkGesture implementation able to recognize
/// pinch/zoom gestures, whenever the distance between both tracked
/// sequences changes, the #GtkGestureZoom::scale-changed signal is
/// emitted to report the scale factor.
/// </para>
/// </summary>

public class GtkGestureZoomHandle : GtkGestureHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkGesture that recognizes zoom
/// in/out gestures (usually known as pinch/zoom).
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a newly created #GtkGestureZoom
/// </return>

	public static MentorLake.Gtk.GtkGestureZoomHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureZoomHandleExterns.gtk_gesture_zoom_new(widget);
	}

}
public static class GtkGestureZoomHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted whenever the distance between both tracked
/// sequences changes.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Scale delta, taking the initial state as 1:1
/// </para>
/// </summary>

	public double Scale;

	public IntPtr UserData;
}
}

public static class GtkGestureZoomHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted whenever the distance between both tracked
/// sequences changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="scale">
/// Scale delta, taking the initial state as 1:1
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scale_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureZoomHandle>))] MentorLake.Gtk.GtkGestureZoomHandle self, double scale, IntPtr user_data);

}


public static class GtkGestureZoomHandleExtensions
{
/// <summary>
/// <para>
/// If @gesture is active, this function returns the zooming difference
/// since the gesture was recognized (hence the starting point is
/// considered 1:1). If @gesture is not active, 1 is returned.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureZoom
/// </param>
/// <return>
/// the scale delta
/// </return>

	public static double GetScaleDelta(this MentorLake.Gtk.GtkGestureZoomHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureZoomHandle)");
		return GtkGestureZoomHandleExterns.gtk_gesture_zoom_get_scale_delta(gesture);
	}

}

internal class GtkGestureZoomHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGestureZoomHandle>))]
	internal static extern MentorLake.Gtk.GtkGestureZoomHandle gtk_gesture_zoom_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_gesture_zoom_get_scale_delta([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureZoomHandle>))] MentorLake.Gtk.GtkGestureZoomHandle gesture);

}
