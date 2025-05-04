namespace MentorLake.Gtk;

public class GtkGestureLongPressHandle : GtkGestureSingleHandle
{
	public static MentorLake.Gtk.GtkGestureLongPressHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureLongPressHandleExterns.gtk_gesture_long_press_new(widget);
	}

}
public static class GtkGestureLongPressHandleSignalExtensions
{

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
	public double X;
	public double Y;
	public IntPtr UserData;
}
}

public static class GtkGestureLongPressHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureLongPressHandle>))] MentorLake.Gtk.GtkGestureLongPressHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureLongPressHandle>))] MentorLake.Gtk.GtkGestureLongPressHandle self, double x, double y, IntPtr user_data);

}


public static class GtkGestureLongPressHandleExtensions
{
}

internal class GtkGestureLongPressHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGestureLongPressHandle gtk_gesture_long_press_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}
