namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGesturePan is a #GtkGesture implementation able to recognize
/// pan gestures, those are drags that are locked to happen along one
/// axis. The axis that a #GtkGesturePan handles is defined at
/// construct time, and can be changed through
/// gtk_gesture_pan_set_orientation().
/// </para>
/// <para>
/// When the gesture starts to be recognized, #GtkGesturePan will
/// attempt to determine as early as possible whether the sequence
/// is moving in the expected direction, and denying the sequence if
/// this does not happen.
/// </para>
/// <para>
/// Once a panning gesture along the expected axis is recognized,
/// the #GtkGesturePan::pan signal will be emitted as input events
/// are received, containing the offset in the given axis.
/// </para>
/// </summary>

public class GtkGesturePanHandle : GtkGestureDragHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkGesture that recognizes pan gestures.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="orientation">
/// expected orientation
/// </param>
/// <return>
/// a newly created #GtkGesturePan
/// </return>

	public static MentorLake.Gtk.GtkGesturePanHandle New(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkOrientation orientation)
	{
		return GtkGesturePanHandleExterns.gtk_gesture_pan_new(widget, orientation);
	}

}
public static class GtkGesturePanHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted once a panning gesture along the
/// expected axis is detected.
/// </para>
/// </summary>

	public static IObservable<GtkGesturePanHandleSignalStructs.PanSignal> Signal_Pan(this GtkGesturePanHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGesturePanHandleSignalStructs.PanSignal> obs) =>
		{
			GtkGesturePanHandleSignalDelegates.pan handler = ( MentorLake.Gtk.GtkGesturePanHandle self,  MentorLake.Gtk.GtkPanDirection direction,  double offset,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGesturePanHandleSignalStructs.PanSignal()
				{
					Self = self, Direction = direction, Offset = offset, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "pan", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGesturePanHandleSignalStructs
{

public class PanSignal
{

	public MentorLake.Gtk.GtkGesturePanHandle Self;
/// <summary>
/// <para>
/// current direction of the pan gesture
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPanDirection Direction;
/// <summary>
/// <para>
/// Offset along the gesture orientation
/// </para>
/// </summary>

	public double Offset;

	public IntPtr UserData;
}
}

public static class GtkGesturePanHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted once a panning gesture along the
/// expected axis is detected.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="direction">
/// current direction of the pan gesture
/// </param>
/// <param name="offset">
/// Offset along the gesture orientation
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pan([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGesturePanHandle>))] MentorLake.Gtk.GtkGesturePanHandle self, MentorLake.Gtk.GtkPanDirection direction, double offset, IntPtr user_data);

}


public static class GtkGesturePanHandleExtensions
{
/// <summary>
/// <para>
/// Returns the orientation of the pan gestures that this @gesture expects.
/// </para>
/// </summary>

/// <param name="gesture">
/// A #GtkGesturePan
/// </param>
/// <return>
/// the expected orientation for pan gestures
/// </return>

	public static MentorLake.Gtk.GtkOrientation GetOrientation(this MentorLake.Gtk.GtkGesturePanHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGesturePanHandle)");
		return GtkGesturePanHandleExterns.gtk_gesture_pan_get_orientation(gesture);
	}

/// <summary>
/// <para>
/// Sets the orientation to be expected on pan gestures.
/// </para>
/// </summary>

/// <param name="gesture">
/// A #GtkGesturePan
/// </param>
/// <param name="orientation">
/// expected orientation
/// </param>

	public static T SetOrientation<T>(this T gesture, MentorLake.Gtk.GtkOrientation orientation) where T : GtkGesturePanHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGesturePanHandle)");
		GtkGesturePanHandleExterns.gtk_gesture_pan_set_orientation(gesture, orientation);
		return gesture;
	}

}

internal class GtkGesturePanHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGesturePanHandle>))]
	internal static extern MentorLake.Gtk.GtkGesturePanHandle gtk_gesture_pan_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_gesture_pan_get_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGesturePanHandle>))] MentorLake.Gtk.GtkGesturePanHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_pan_set_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGesturePanHandle>))] MentorLake.Gtk.GtkGesturePanHandle gesture, MentorLake.Gtk.GtkOrientation orientation);

}
