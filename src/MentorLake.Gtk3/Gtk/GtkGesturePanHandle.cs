namespace MentorLake.Gtk;

public class GtkGesturePanHandle : GtkGestureDragHandle
{
	public static MentorLake.Gtk.GtkGesturePanHandle New(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkOrientation orientation)
	{
		return GtkGesturePanHandleExterns.gtk_gesture_pan_new(widget, orientation);
	}

}
public static class GtkGesturePanHandleSignalExtensions
{

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

public struct PanSignal
{
	public MentorLake.Gtk.GtkGesturePanHandle Self;
	public MentorLake.Gtk.GtkPanDirection Direction;
	public double Offset;
	public IntPtr UserData;
}
}

public static class GtkGesturePanHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pan([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGesturePanHandle>))] MentorLake.Gtk.GtkGesturePanHandle self, MentorLake.Gtk.GtkPanDirection direction, double offset, IntPtr user_data);

}


public static class GtkGesturePanHandleExtensions
{
	public static MentorLake.Gtk.GtkOrientation GetOrientation(this MentorLake.Gtk.GtkGesturePanHandle gesture)
	{
		return GtkGesturePanHandleExterns.gtk_gesture_pan_get_orientation(gesture);
	}

	public static T SetOrientation<T>(this T gesture, MentorLake.Gtk.GtkOrientation orientation) where T : GtkGesturePanHandle
	{
		GtkGesturePanHandleExterns.gtk_gesture_pan_set_orientation(gesture, orientation);
		return gesture;
	}

}

internal class GtkGesturePanHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGesturePanHandle gtk_gesture_pan_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_gesture_pan_get_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGesturePanHandle>))] MentorLake.Gtk.GtkGesturePanHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_pan_set_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGesturePanHandle>))] MentorLake.Gtk.GtkGesturePanHandle gesture, MentorLake.Gtk.GtkOrientation orientation);

}
