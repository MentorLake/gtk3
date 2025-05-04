namespace MentorLake.Gtk;

public class GtkGestureDragHandle : GtkGestureSingleHandle
{
	public static MentorLake.Gtk.GtkGestureDragHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureDragHandleExterns.gtk_gesture_drag_new(widget);
	}

}
public static class GtkGestureDragHandleSignalExtensions
{

	public static IObservable<GtkGestureDragHandleSignalStructs.DragBeginSignal> Signal_DragBegin(this GtkGestureDragHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureDragHandleSignalStructs.DragBeginSignal> obs) =>
		{
			GtkGestureDragHandleSignalDelegates.drag_begin handler = ( MentorLake.Gtk.GtkGestureDragHandle self,  double start_x,  double start_y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureDragHandleSignalStructs.DragBeginSignal()
				{
					Self = self, StartX = start_x, StartY = start_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkGestureDragHandleSignalStructs.DragEndSignal> Signal_DragEnd(this GtkGestureDragHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureDragHandleSignalStructs.DragEndSignal> obs) =>
		{
			GtkGestureDragHandleSignalDelegates.drag_end handler = ( MentorLake.Gtk.GtkGestureDragHandle self,  double offset_x,  double offset_y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureDragHandleSignalStructs.DragEndSignal()
				{
					Self = self, OffsetX = offset_x, OffsetY = offset_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkGestureDragHandleSignalStructs.DragUpdateSignal> Signal_DragUpdate(this GtkGestureDragHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureDragHandleSignalStructs.DragUpdateSignal> obs) =>
		{
			GtkGestureDragHandleSignalDelegates.drag_update handler = ( MentorLake.Gtk.GtkGestureDragHandle self,  double offset_x,  double offset_y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureDragHandleSignalStructs.DragUpdateSignal()
				{
					Self = self, OffsetX = offset_x, OffsetY = offset_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGestureDragHandleSignalStructs
{

public class DragBeginSignal
{
	public MentorLake.Gtk.GtkGestureDragHandle Self;
	public double StartX;
	public double StartY;
	public IntPtr UserData;
}

public class DragEndSignal
{
	public MentorLake.Gtk.GtkGestureDragHandle Self;
	public double OffsetX;
	public double OffsetY;
	public IntPtr UserData;
}

public class DragUpdateSignal
{
	public MentorLake.Gtk.GtkGestureDragHandle Self;
	public double OffsetX;
	public double OffsetY;
	public IntPtr UserData;
}
}

public static class GtkGestureDragHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle self, double start_x, double start_y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data);

}


public static class GtkGestureDragHandleExtensions
{
	public static bool GetOffset(this MentorLake.Gtk.GtkGestureDragHandle gesture, out double x, out double y)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureDragHandle)");
		return GtkGestureDragHandleExterns.gtk_gesture_drag_get_offset(gesture, out x, out y);
	}

	public static bool GetStartPoint(this MentorLake.Gtk.GtkGestureDragHandle gesture, out double x, out double y)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureDragHandle)");
		return GtkGestureDragHandleExterns.gtk_gesture_drag_get_start_point(gesture, out x, out y);
	}

}

internal class GtkGestureDragHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGestureDragHandle gtk_gesture_drag_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_drag_get_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle gesture, out double x, out double y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_drag_get_start_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle gesture, out double x, out double y);

}
