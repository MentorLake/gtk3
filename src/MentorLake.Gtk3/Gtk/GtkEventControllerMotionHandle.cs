namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkEventControllerMotion is an event controller meant for situations
/// where you need to track the position of the pointer.
/// </para>
/// <para>
/// This object was added in 3.24.
/// </para>
/// </summary>

public class GtkEventControllerMotionHandle : GtkEventControllerHandle
{
/// <summary>
/// <para>
/// Creates a new event controller that will handle motion events
/// for the given @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// a new #GtkEventControllerMotion
/// </return>

	public static MentorLake.Gtk.GtkEventControllerMotionHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkEventControllerMotionHandleExterns.gtk_event_controller_motion_new(widget);
	}

}
public static class GtkEventControllerMotionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Signals that the pointer has entered the widget.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerMotionHandleSignalStructs.EnterSignal> Signal_Enter(this GtkEventControllerMotionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionHandleSignalStructs.EnterSignal> obs) =>
		{
			GtkEventControllerMotionHandleSignalDelegates.enter handler = ( MentorLake.Gtk.GtkEventControllerMotionHandle self,  double x,  double y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionHandleSignalStructs.EnterSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that pointer has left the widget.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerMotionHandleSignalStructs.LeaveSignal> Signal_Leave(this GtkEventControllerMotionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionHandleSignalStructs.LeaveSignal> obs) =>
		{
			GtkEventControllerMotionHandleSignalDelegates.leave handler = ( MentorLake.Gtk.GtkEventControllerMotionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionHandleSignalStructs.LeaveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the pointer moves inside the widget.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerMotionHandleSignalStructs.MotionSignal> Signal_Motion(this GtkEventControllerMotionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerMotionHandleSignalStructs.MotionSignal> obs) =>
		{
			GtkEventControllerMotionHandleSignalDelegates.motion handler = ( MentorLake.Gtk.GtkEventControllerMotionHandle self,  double x,  double y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerMotionHandleSignalStructs.MotionSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
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
}

public static class GtkEventControllerMotionHandleSignalStructs
{

public class EnterSignal
{

	public MentorLake.Gtk.GtkEventControllerMotionHandle Self;
/// <summary>
/// <para>
/// the x coordinate
/// </para>
/// </summary>

	public double X;
/// <summary>
/// <para>
/// the y coordinate
/// </para>
/// </summary>

	public double Y;

	public IntPtr UserData;
}

public class LeaveSignal
{

	public MentorLake.Gtk.GtkEventControllerMotionHandle Self;

	public IntPtr UserData;
}

public class MotionSignal
{

	public MentorLake.Gtk.GtkEventControllerMotionHandle Self;
/// <summary>
/// <para>
/// the x coordinate
/// </para>
/// </summary>

	public double X;
/// <summary>
/// <para>
/// the y coordinate
/// </para>
/// </summary>

	public double Y;

	public IntPtr UserData;
}
}

public static class GtkEventControllerMotionHandleSignalDelegates
{

/// <summary>
/// <para>
/// Signals that the pointer has entered the widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="x">
/// the x coordinate
/// </param>
/// <param name="y">
/// the y coordinate
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerMotionHandle>))] MentorLake.Gtk.GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that pointer has left the widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerMotionHandle>))] MentorLake.Gtk.GtkEventControllerMotionHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the pointer moves inside the widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="x">
/// the x coordinate
/// </param>
/// <param name="y">
/// the y coordinate
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerMotionHandle>))] MentorLake.Gtk.GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);

}


public static class GtkEventControllerMotionHandleExtensions
{
}

internal class GtkEventControllerMotionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerMotionHandle>))]
	internal static extern MentorLake.Gtk.GtkEventControllerMotionHandle gtk_event_controller_motion_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}
