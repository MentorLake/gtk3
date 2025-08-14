namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGestureRotate is a #GtkGesture implementation able to recognize
/// 2-finger rotations, whenever the angle between both handled sequences
/// changes, the #GtkGestureRotate::angle-changed signal is emitted.
/// </para>
/// </summary>

public class GtkGestureRotateHandle : GtkGestureHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkGesture that recognizes 2-touch
/// rotation gestures.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a newly created #GtkGestureRotate
/// </return>

	public static MentorLake.Gtk.GtkGestureRotateHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureRotateHandleExterns.gtk_gesture_rotate_new(widget);
	}

}
public static class GtkGestureRotateHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the angle between both tracked points
/// changes.
/// </para>
/// </summary>

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

public class AngleChangedSignal
{

	public MentorLake.Gtk.GtkGestureRotateHandle Self;
/// <summary>
/// <para>
/// Current angle in radians
/// </para>
/// </summary>

	public double Angle;
/// <summary>
/// <para>
/// Difference with the starting angle, in radians
/// </para>
/// </summary>

	public double AngleDelta;

	public IntPtr UserData;
}
}

public static class GtkGestureRotateHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the angle between both tracked points
/// changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="angle">
/// Current angle in radians
/// </param>
/// <param name="angle_delta">
/// Difference with the starting angle, in radians
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void angle_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureRotateHandle>))] MentorLake.Gtk.GtkGestureRotateHandle self, double angle, double angle_delta, IntPtr user_data);

}


public static class GtkGestureRotateHandleExtensions
{
/// <summary>
/// <para>
/// If @gesture is active, this function returns the angle difference
/// in radians since the gesture was first recognized. If @gesture is
/// not active, 0 is returned.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureRotate
/// </param>
/// <return>
/// the angle delta in radians
/// </return>

	public static double GetAngleDelta(this MentorLake.Gtk.GtkGestureRotateHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureRotateHandle)");
		return GtkGestureRotateHandleExterns.gtk_gesture_rotate_get_angle_delta(gesture);
	}

}

internal class GtkGestureRotateHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGestureRotateHandle>))]
	internal static extern MentorLake.Gtk.GtkGestureRotateHandle gtk_gesture_rotate_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_gesture_rotate_get_angle_delta([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureRotateHandle>))] MentorLake.Gtk.GtkGestureRotateHandle gesture);

}
