namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGestureStylus is a #GtkGesture implementation specific to stylus
/// input. The provided signals just provide the basic information
/// </para>
/// </summary>

public class GtkGestureStylusHandle : GtkGestureSingleHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkGestureStylus.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a newly created stylus gesture
/// </return>

	public static MentorLake.Gtk.GtkGestureStylusHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGestureStylusHandleExterns.gtk_gesture_stylus_new(widget);
	}

}
public static class GtkGestureStylusHandleSignalExtensions
{

	public static IObservable<GtkGestureStylusHandleSignalStructs.DownSignal> Signal_Down(this GtkGestureStylusHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureStylusHandleSignalStructs.DownSignal> obs) =>
		{
			GtkGestureStylusHandleSignalDelegates.down handler = ( MentorLake.Gtk.GtkGestureStylusHandle self,  double @object,  double p0,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusHandleSignalStructs.DownSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "down", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkGestureStylusHandleSignalStructs.MotionSignal> Signal_Motion(this GtkGestureStylusHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureStylusHandleSignalStructs.MotionSignal> obs) =>
		{
			GtkGestureStylusHandleSignalDelegates.motion handler = ( MentorLake.Gtk.GtkGestureStylusHandle self,  double @object,  double p0,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusHandleSignalStructs.MotionSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkGestureStylusHandleSignalStructs.ProximitySignal> Signal_Proximity(this GtkGestureStylusHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureStylusHandleSignalStructs.ProximitySignal> obs) =>
		{
			GtkGestureStylusHandleSignalDelegates.proximity handler = ( MentorLake.Gtk.GtkGestureStylusHandle self,  double @object,  double p0,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusHandleSignalStructs.ProximitySignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "proximity", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkGestureStylusHandleSignalStructs.UpSignal> Signal_Up(this GtkGestureStylusHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureStylusHandleSignalStructs.UpSignal> obs) =>
		{
			GtkGestureStylusHandleSignalDelegates.up handler = ( MentorLake.Gtk.GtkGestureStylusHandle self,  double @object,  double p0,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureStylusHandleSignalStructs.UpSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "up", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGestureStylusHandleSignalStructs
{

public class DownSignal
{

	public MentorLake.Gtk.GtkGestureStylusHandle Self;

	public double Object;

	public double P0;

	public IntPtr UserData;
}

public class MotionSignal
{

	public MentorLake.Gtk.GtkGestureStylusHandle Self;

	public double Object;

	public double P0;

	public IntPtr UserData;
}

public class ProximitySignal
{

	public MentorLake.Gtk.GtkGestureStylusHandle Self;

	public double Object;

	public double P0;

	public IntPtr UserData;
}

public class UpSignal
{

	public MentorLake.Gtk.GtkGestureStylusHandle Self;

	public double Object;

	public double P0;

	public IntPtr UserData;
}
}

public static class GtkGestureStylusHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="p0">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureStylusHandle>))] MentorLake.Gtk.GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="p0">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureStylusHandle>))] MentorLake.Gtk.GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="p0">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void proximity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureStylusHandle>))] MentorLake.Gtk.GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="p0">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureStylusHandle>))] MentorLake.Gtk.GtkGestureStylusHandle self, double @object, double p0, IntPtr user_data);

}


public static class GtkGestureStylusHandleExtensions
{
/// <summary>
/// <para>
/// Returns the current values for the requested @axes. This function
/// must be called from either the #GtkGestureStylus:down,
/// #GtkGestureStylus:motion, #GtkGestureStylus:up or #GtkGestureStylus:proximity
/// signals.
/// </para>
/// </summary>

/// <param name="gesture">
/// a GtkGestureStylus
/// </param>
/// <param name="axes">
/// array of requested axes, terminated with #GDK_AXIS_IGNORE
/// </param>
/// <param name="values">
/// return location for the axis values
/// </param>
/// <return>
/// #TRUE if there is a current value for the axes
/// </return>

	public static bool GetAxes(this MentorLake.Gtk.GtkGestureStylusHandle gesture, MentorLake.Gdk.GdkAxisUse[] axes, out double[] values)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureStylusHandle)");
		return GtkGestureStylusHandleExterns.gtk_gesture_stylus_get_axes(gesture, axes, out values);
	}

/// <summary>
/// <para>
/// Returns the current value for the requested @axis. This function
/// must be called from either the #GtkGestureStylus:down,
/// #GtkGestureStylus:motion, #GtkGestureStylus:up or #GtkGestureStylus:proximity
/// signals.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureStylus
/// </param>
/// <param name="axis">
/// requested device axis
/// </param>
/// <param name="value">
/// return location for the axis value
/// </param>
/// <return>
/// #TRUE if there is a current value for the axis
/// </return>

	public static bool GetAxis(this MentorLake.Gtk.GtkGestureStylusHandle gesture, MentorLake.Gdk.GdkAxisUse axis, out double value)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureStylusHandle)");
		return GtkGestureStylusHandleExterns.gtk_gesture_stylus_get_axis(gesture, axis, out value);
	}

/// <summary>
/// <para>
/// Returns the #GdkDeviceTool currently driving input through this gesture.
/// This function must be called from either the #GtkGestureStylus::down,
/// #GtkGestureStylus::motion, #GtkGestureStylus::up or #GtkGestureStylus::proximity
/// signal handlers.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGestureStylus
/// </param>
/// <return>
/// The current stylus tool
/// </return>

	public static MentorLake.Gdk.GdkDeviceToolHandle GetDeviceTool(this MentorLake.Gtk.GtkGestureStylusHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureStylusHandle)");
		return GtkGestureStylusHandleExterns.gtk_gesture_stylus_get_device_tool(gesture);
	}

}

internal class GtkGestureStylusHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGestureStylusHandle>))]
	internal static extern MentorLake.Gtk.GtkGestureStylusHandle gtk_gesture_stylus_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_stylus_get_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureStylusHandle>))] MentorLake.Gtk.GtkGestureStylusHandle gesture, MentorLake.Gdk.GdkAxisUse[] axes, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out double[] values);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_stylus_get_axis([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureStylusHandle>))] MentorLake.Gtk.GtkGestureStylusHandle gesture, MentorLake.Gdk.GdkAxisUse axis, out double value);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceToolHandle gtk_gesture_stylus_get_device_tool([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureStylusHandle>))] MentorLake.Gtk.GtkGestureStylusHandle gesture);

}
