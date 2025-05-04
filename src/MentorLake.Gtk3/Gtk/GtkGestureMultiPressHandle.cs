namespace MentorLake.Gtk;

public class GtkGestureMultiPressHandle : GtkGestureSingleHandle
{
	public static MentorLake.Gtk.GtkGestureMultiPressHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureMultiPressHandleExterns.gtk_gesture_multi_press_new(widget);
	}

}
public static class GtkGestureMultiPressHandleSignalExtensions
{

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
	public int NPress;
	public double X;
	public double Y;
	public IntPtr UserData;
}

public class ReleasedSignal
{
	public MentorLake.Gtk.GtkGestureMultiPressHandle Self;
	public int NPress;
	public double X;
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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle self, int n_press, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle self, int n_press, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stopped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle self, IntPtr user_data);

}


public static class GtkGestureMultiPressHandleExtensions
{
	public static bool GetArea(this MentorLake.Gtk.GtkGestureMultiPressHandle gesture, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureMultiPressHandle)");
		return GtkGestureMultiPressHandleExterns.gtk_gesture_multi_press_get_area(gesture, out rect);
	}

	public static T SetArea<T>(this T gesture, MentorLake.Gdk.GdkRectangleHandle rect) where T : GtkGestureMultiPressHandle
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureMultiPressHandle)");
		GtkGestureMultiPressHandleExterns.gtk_gesture_multi_press_set_area(gesture, rect);
		return gesture;
	}

}

internal class GtkGestureMultiPressHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGestureMultiPressHandle gtk_gesture_multi_press_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_multi_press_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle gesture, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_multi_press_set_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureMultiPressHandle>))] MentorLake.Gtk.GtkGestureMultiPressHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect);

}
