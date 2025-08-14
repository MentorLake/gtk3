namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGestureMultiPress is a #GtkGesture implementation able to recognize
/// multiple clicks on a nearby zone, which can be listened for through the
/// #GtkGestureMultiPress::pressed signal. Whenever time or distance between
/// clicks exceed the GTK+ defaults, #GtkGestureMultiPress::stopped is emitted,
/// and the click counter is reset.
/// </para>
/// <para>
/// Callers may also restrict the area that is considered valid for a >1
/// touch/button press through gtk_gesture_multi_press_set_area(), so any
/// click happening outside that area is considered to be a first click of
/// its own.
/// </para>
/// </summary>

public class GtkGestureMultiPressHandle : GtkGestureSingleHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkGesture that recognizes single and multiple
/// presses.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a newly created #GtkGestureMultiPress
/// </return>

	public static MentorLake.Gtk.GtkGestureMultiPressHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureMultiPressHandleExterns.gtk_gesture_multi_press_new(widget);
	}

}
public static class GtkGestureMultiPressHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted whenever a button or touch press happens.
/// </para>
/// </summary>

	public static IObservable<GtkGestureMultiPressHandleSignalStructs.PressedSignal> Signal_Pressed(this GtkGestureMultiPressHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureMultiPressHandleSignalStructs.PressedSignal> obs) =>
		{
			GtkGestureMultiPressHandleSignalDelegates.pressed handler = ( MentorLake.Gtk.GtkGestureMultiPressHandle self,  int n_press,  double x,  double y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureMultiPressHandleSignalStructs.PressedSignal()
				{
					Self = self, NPress = n_press, X = x, Y = y, UserData = user_data
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
/// <summary>
/// <para>
/// This signal is emitted when a button or touch is released. @n_press
/// will report the number of press that is paired to this event, note
/// that #GtkGestureMultiPress::stopped may have been emitted between the
/// press and its release, @n_press will only start over at the next press.
/// </para>
/// </summary>

	public static IObservable<GtkGestureMultiPressHandleSignalStructs.ReleasedSignal> Signal_Released(this GtkGestureMultiPressHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureMultiPressHandleSignalStructs.ReleasedSignal> obs) =>
		{
			GtkGestureMultiPressHandleSignalDelegates.released handler = ( MentorLake.Gtk.GtkGestureMultiPressHandle self,  int n_press,  double x,  double y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureMultiPressHandleSignalStructs.ReleasedSignal()
				{
					Self = self, NPress = n_press, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted whenever any time/distance threshold has
/// been exceeded.
/// </para>
/// </summary>

	public static IObservable<GtkGestureMultiPressHandleSignalStructs.StoppedSignal> Signal_Stopped(this GtkGestureMultiPressHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureMultiPressHandleSignalStructs.StoppedSignal> obs) =>
		{
			GtkGestureMultiPressHandleSignalDelegates.stopped handler = ( MentorLake.Gtk.GtkGestureMultiPressHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureMultiPressHandleSignalStructs.StoppedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "stopped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGestureMultiPressHandleSignalStructs
{

public class PressedSignal
{

	public MentorLake.Gtk.GtkGestureMultiPressHandle Self;
/// <summary>
/// <para>
/// how many touch/button presses happened with this one
/// </para>
/// </summary>

	public int NPress;
/// <summary>
/// <para>
/// The X coordinate, in widget allocation coordinates
/// </para>
/// </summary>

	public double X;
/// <summary>
/// <para>
/// The Y coordinate, in widget allocation coordinates
/// </para>
/// </summary>

	public double Y;

	public IntPtr UserData;
}

public class ReleasedSignal
{

	public MentorLake.Gtk.GtkGestureMultiPressHandle Self;
/// <summary>
/// <para>
/// number of press that is paired with this release
/// </para>
/// </summary>

	public int NPress;
/// <summary>
/// <para>
/// The X coordinate, in widget allocation coordinates
/// </para>
/// </summary>

	public double X;
/// <summary>
/// <para>
/// The Y coordinate, in widget allocation coordinates
/// </para>
/// </summary>

	public double Y;

	public IntPtr UserData;
}

public class StoppedSignal
{

	public MentorLake.Gtk.GtkGestureMultiPressHandle Self;

	public IntPtr UserData;
}
}

public static class GtkGestureMultiPressHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted whenever a button or touch press happens.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="n_press">
/// how many touch/button presses happened with this one
/// </param>
/// <param name="x">
/// The X coordinate, in widget allocation coordinates
/// </param>
/// <param name="y">
/// The Y coordinate, in widget allocation coordinates
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle self, int n_press, double x, double y, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a button or touch is released. @n_press
/// will report the number of press that is paired to this event, note
/// that #GtkGestureMultiPress::stopped may have been emitted between the
/// press and its release, @n_press will only start over at the next press.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="n_press">
/// number of press that is paired with this release
/// </param>
/// <param name="x">
/// The X coordinate, in widget allocation coordinates
/// </param>
/// <param name="y">
/// The Y coordinate, in widget allocation coordinates
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle self, int n_press, double x, double y, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever any time/distance threshold has
/// been exceeded.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stopped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle self, IntPtr user_data);

}


public static class GtkGestureMultiPressHandleExtensions
{
/// <summary>
/// <para>
/// If an area was set through gtk_gesture_multi_press_set_area(),
/// this function will return %TRUE and fill in @rect with the
/// press area. See gtk_gesture_multi_press_set_area() for more
/// details on what the press area represents.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureMultiPress
/// </param>
/// <param name="rect">
/// return location for the press area
/// </param>
/// <return>
/// %TRUE if @rect was filled with the press area
/// </return>

	public static bool GetArea(this MentorLake.Gtk.GtkGestureMultiPressHandle gesture, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureMultiPressHandle)");
		return GtkGestureMultiPressHandleExterns.gtk_gesture_multi_press_get_area(gesture, out rect);
	}

/// <summary>
/// <para>
/// If @rect is non-%NULL, the press area will be checked to be
/// confined within the rectangle, otherwise the button count
/// will be reset so the press is seen as being the first one.
/// If @rect is %NULL, the area will be reset to an unrestricted
/// state.
/// </para>
/// <para>
/// Note: The rectangle is only used to determine whether any
/// non-first click falls within the expected area. This is not
/// akin to an input shape.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureMultiPress
/// </param>
/// <param name="rect">
/// rectangle to receive coordinates on
/// </param>

	public static T SetArea<T>(this T gesture, MentorLake.Gdk.GdkRectangleHandle rect) where T : GtkGestureMultiPressHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureMultiPressHandle)");
		GtkGestureMultiPressHandleExterns.gtk_gesture_multi_press_set_area(gesture, rect);
		return gesture;
	}

}

internal class GtkGestureMultiPressHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))]
	internal static extern MentorLake.Gtk.GtkGestureMultiPressHandle gtk_gesture_multi_press_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_multi_press_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle gesture, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_multi_press_set_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect);

}
