namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGestureLongPress is a #GtkGesture implementation able to recognize
/// long presses, triggering the #GtkGestureLongPress::pressed after the
/// timeout is exceeded.
/// </para>
/// <para>
/// If the touchpoint is lifted before the timeout passes, or if it drifts
/// too far of the initial press point, the #GtkGestureLongPress::cancelled
/// signal will be emitted.
/// </para>
/// </summary>

public class GtkGestureLongPressHandle : GtkGestureSingleHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkGesture that recognizes long presses.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a newly created #GtkGestureLongPress
/// </return>

	public static MentorLake.Gtk.GtkGestureLongPressHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureLongPressHandleExterns.gtk_gesture_long_press_new(widget);
	}

}
public static class GtkGestureLongPressHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted whenever a press moved too far, or was released
/// before #GtkGestureLongPress::pressed happened.
/// </para>
/// </summary>

	public static IObservable<GtkGestureLongPressHandleSignalStructs.CancelledSignal> Signal_Cancelled(this GtkGestureLongPressHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureLongPressHandleSignalStructs.CancelledSignal> obs) =>
		{
			GtkGestureLongPressHandleSignalDelegates.cancelled handler = ( MentorLake.Gtk.GtkGestureLongPressHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureLongPressHandleSignalStructs.CancelledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancelled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted whenever a press goes unmoved/unreleased longer than
/// what the GTK+ defaults tell.
/// </para>
/// </summary>

	public static IObservable<GtkGestureLongPressHandleSignalStructs.PressedSignal> Signal_Pressed(this GtkGestureLongPressHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureLongPressHandleSignalStructs.PressedSignal> obs) =>
		{
			GtkGestureLongPressHandleSignalDelegates.pressed handler = ( MentorLake.Gtk.GtkGestureLongPressHandle self,  double x,  double y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureLongPressHandleSignalStructs.PressedSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGestureLongPressHandleSignalStructs
{

public class CancelledSignal
{

	public MentorLake.Gtk.GtkGestureLongPressHandle Self;

	public IntPtr UserData;
}

public class PressedSignal
{

	public MentorLake.Gtk.GtkGestureLongPressHandle Self;
/// <summary>
/// <para>
/// the X coordinate where the press happened, relative to the widget allocation
/// </para>
/// </summary>

	public double X;
/// <summary>
/// <para>
/// the Y coordinate where the press happened, relative to the widget allocation
/// </para>
/// </summary>

	public double Y;

	public IntPtr UserData;
}
}

public static class GtkGestureLongPressHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted whenever a press moved too far, or was released
/// before #GtkGestureLongPress::pressed happened.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureLongPressHandle>))] MentorLake.Gtk.GtkGestureLongPressHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever a press goes unmoved/unreleased longer than
/// what the GTK+ defaults tell.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="x">
/// the X coordinate where the press happened, relative to the widget allocation
/// </param>
/// <param name="y">
/// the Y coordinate where the press happened, relative to the widget allocation
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureLongPressHandle>))] MentorLake.Gtk.GtkGestureLongPressHandle self, double x, double y, IntPtr user_data);

}


public static class GtkGestureLongPressHandleExtensions
{
}

internal class GtkGestureLongPressHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGestureLongPressHandle>))]
	internal static extern MentorLake.Gtk.GtkGestureLongPressHandle gtk_gesture_long_press_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}
