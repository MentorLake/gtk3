namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGestureDrag is a #GtkGesture implementation that recognizes drag
/// operations. The drag operation itself can be tracked throught the
/// #GtkGestureDrag::drag-begin, #GtkGestureDrag::drag-update and
/// #GtkGestureDrag::drag-end signals, or the relevant coordinates be
/// extracted through gtk_gesture_drag_get_offset() and
/// gtk_gesture_drag_get_start_point().
/// </para>
/// </summary>

public class GtkGestureDragHandle : GtkGestureSingleHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkGesture that recognizes drags.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a newly created #GtkGestureDrag
/// </return>

	public static MentorLake.Gtk.GtkGestureDragHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureDragHandleExterns.gtk_gesture_drag_new(widget);
	}

}
public static class GtkGestureDragHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted whenever dragging starts.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted whenever the dragging is finished.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted whenever the dragging point moves.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// X coordinate, relative to the widget allocation
/// </para>
/// </summary>

	public double StartX;
/// <summary>
/// <para>
/// Y coordinate, relative to the widget allocation
/// </para>
/// </summary>

	public double StartY;

	public IntPtr UserData;
}

public class DragEndSignal
{

	public MentorLake.Gtk.GtkGestureDragHandle Self;
/// <summary>
/// <para>
/// X offset, relative to the start point
/// </para>
/// </summary>

	public double OffsetX;
/// <summary>
/// <para>
/// Y offset, relative to the start point
/// </para>
/// </summary>

	public double OffsetY;

	public IntPtr UserData;
}

public class DragUpdateSignal
{

	public MentorLake.Gtk.GtkGestureDragHandle Self;
/// <summary>
/// <para>
/// X offset, relative to the start point
/// </para>
/// </summary>

	public double OffsetX;
/// <summary>
/// <para>
/// Y offset, relative to the start point
/// </para>
/// </summary>

	public double OffsetY;

	public IntPtr UserData;
}
}

public static class GtkGestureDragHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted whenever dragging starts.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="start_x">
/// X coordinate, relative to the widget allocation
/// </param>
/// <param name="start_y">
/// Y coordinate, relative to the widget allocation
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle self, double start_x, double start_y, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever the dragging is finished.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="offset_x">
/// X offset, relative to the start point
/// </param>
/// <param name="offset_y">
/// Y offset, relative to the start point
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever the dragging point moves.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="offset_x">
/// X offset, relative to the start point
/// </param>
/// <param name="offset_y">
/// Y offset, relative to the start point
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data);

}


public static class GtkGestureDragHandleExtensions
{
/// <summary>
/// <para>
/// If the @gesture is active, this function returns %TRUE and
/// fills in @x and @y with the coordinates of the current point,
/// as an offset to the starting drag point.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="x">
/// X offset for the current point
/// </param>
/// <param name="y">
/// Y offset for the current point
/// </param>
/// <return>
/// %TRUE if the gesture is active
/// </return>

	public static bool GetOffset(this MentorLake.Gtk.GtkGestureDragHandle gesture, out double x, out double y)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureDragHandle)");
		return GtkGestureDragHandleExterns.gtk_gesture_drag_get_offset(gesture, out x, out y);
	}

/// <summary>
/// <para>
/// If the @gesture is active, this function returns %TRUE
/// and fills in @x and @y with the drag start coordinates,
/// in window-relative coordinates.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="x">
/// X coordinate for the drag start point
/// </param>
/// <param name="y">
/// Y coordinate for the drag start point
/// </param>
/// <return>
/// %TRUE if the gesture is active
/// </return>

	public static bool GetStartPoint(this MentorLake.Gtk.GtkGestureDragHandle gesture, out double x, out double y)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureDragHandle)");
		return GtkGestureDragHandleExterns.gtk_gesture_drag_get_start_point(gesture, out x, out y);
	}

}

internal class GtkGestureDragHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))]
	internal static extern MentorLake.Gtk.GtkGestureDragHandle gtk_gesture_drag_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_drag_get_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle gesture, out double x, out double y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_drag_get_start_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureDragHandle>))] MentorLake.Gtk.GtkGestureDragHandle gesture, out double x, out double y);

}
