namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkEventControllerScroll is an event controller meant to handle
/// scroll events from mice and touchpads. It is capable of handling
/// both discrete and continuous scroll events, abstracting them both
/// on the #GtkEventControllerScroll::scroll signal (deltas in the
/// discrete case are multiples of 1).
/// </para>
/// <para>
/// In the case of continuous scroll events, #GtkEventControllerScroll
/// encloses all #GtkEventControllerScroll::scroll events between two
/// #GtkEventControllerScroll::scroll-begin and #GtkEventControllerScroll::scroll-end
/// signals.
/// </para>
/// <para>
/// The behavior of the event controller can be modified by the
/// flags given at creation time, or modified at a later point through
/// gtk_event_controller_scroll_set_flags() (e.g. because the scrolling
/// conditions of the widget changed).
/// </para>
/// <para>
/// The controller can be set up to emit motion for either/both vertical
/// and horizontal scroll events through #GTK_EVENT_CONTROLLER_SCROLL_VERTICAL,
/// #GTK_EVENT_CONTROLLER_SCROLL_HORIZONTAL and #GTK_EVENT_CONTROLLER_SCROLL_BOTH.
/// If any axis is disabled, the respective #GtkEventControllerScroll::scroll
/// delta will be 0. Vertical scroll events will be translated to horizontal
/// motion for the devices incapable of horizontal scrolling.
/// </para>
/// <para>
/// The event controller can also be forced to emit discrete events on all devices
/// through #GTK_EVENT_CONTROLLER_SCROLL_DISCRETE. This can be used to implement
/// discrete actions triggered through scroll events (e.g. switching across
/// combobox options).
/// </para>
/// <para>
/// The #GTK_EVENT_CONTROLLER_SCROLL_KINETIC flag toggles the emission of the
/// #GtkEventControllerScroll::decelerate signal, emitted at the end of scrolling
/// with two X/Y velocity arguments that are consistent with the motion that
/// was received.
/// </para>
/// <para>
/// This object was added in 3.24.
/// </para>
/// </summary>

public class GtkEventControllerScrollHandle : GtkEventControllerHandle
{
/// <summary>
/// <para>
/// Creates a new event controller that will handle scroll events
/// for the given @widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="flags">
/// behavior flags
/// </param>
/// <return>
/// a new #GtkEventControllerScroll
/// </return>

	public static MentorLake.Gtk.GtkEventControllerScrollHandle New(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkEventControllerScrollFlags flags)
	{
		return GtkEventControllerScrollHandleExterns.gtk_event_controller_scroll_new(widget, flags);
	}

}
public static class GtkEventControllerScrollHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted after scroll is finished if the #GTK_EVENT_CONTROLLER_SCROLL_KINETIC
/// flag is set. @vel_x and @vel_y express the initial velocity that was
/// imprinted by the scroll events. @vel_x and @vel_y are expressed in
/// pixels/ms.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerScrollHandleSignalStructs.DecelerateSignal> Signal_Decelerate(this GtkEventControllerScrollHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollHandleSignalStructs.DecelerateSignal> obs) =>
		{
			GtkEventControllerScrollHandleSignalDelegates.decelerate handler = ( MentorLake.Gtk.GtkEventControllerScrollHandle self,  double vel_x,  double vel_y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollHandleSignalStructs.DecelerateSignal()
				{
					Self = self, VelX = vel_x, VelY = vel_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "decelerate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that the widget should scroll by the
/// amount specified by @dx and @dy.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerScrollHandleSignalStructs.ScrollSignal> Signal_Scroll(this GtkEventControllerScrollHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollHandleSignalStructs.ScrollSignal> obs) =>
		{
			GtkEventControllerScrollHandleSignalDelegates.scroll handler = ( MentorLake.Gtk.GtkEventControllerScrollHandle self,  double dx,  double dy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollHandleSignalStructs.ScrollSignal()
				{
					Self = self, Dx = dx, Dy = dy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that a new scrolling operation has begun. It will
/// only be emitted on devices capable of it.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerScrollHandleSignalStructs.ScrollBeginSignal> Signal_ScrollBegin(this GtkEventControllerScrollHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollHandleSignalStructs.ScrollBeginSignal> obs) =>
		{
			GtkEventControllerScrollHandleSignalDelegates.scroll_begin handler = ( MentorLake.Gtk.GtkEventControllerScrollHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollHandleSignalStructs.ScrollBeginSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll-begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that a new scrolling operation has finished. It will
/// only be emitted on devices capable of it.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerScrollHandleSignalStructs.ScrollEndSignal> Signal_ScrollEnd(this GtkEventControllerScrollHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollHandleSignalStructs.ScrollEndSignal> obs) =>
		{
			GtkEventControllerScrollHandleSignalDelegates.scroll_end handler = ( MentorLake.Gtk.GtkEventControllerScrollHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollHandleSignalStructs.ScrollEndSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkEventControllerScrollHandleSignalStructs
{

public class DecelerateSignal
{

	public MentorLake.Gtk.GtkEventControllerScrollHandle Self;
/// <summary>
/// <para>
/// X velocity
/// </para>
/// </summary>

	public double VelX;
/// <summary>
/// <para>
/// Y velocity
/// </para>
/// </summary>

	public double VelY;

	public IntPtr UserData;
}

public class ScrollSignal
{

	public MentorLake.Gtk.GtkEventControllerScrollHandle Self;
/// <summary>
/// <para>
/// X delta
/// </para>
/// </summary>

	public double Dx;
/// <summary>
/// <para>
/// Y delta
/// </para>
/// </summary>

	public double Dy;

	public IntPtr UserData;
}

public class ScrollBeginSignal
{

	public MentorLake.Gtk.GtkEventControllerScrollHandle Self;

	public IntPtr UserData;
}

public class ScrollEndSignal
{

	public MentorLake.Gtk.GtkEventControllerScrollHandle Self;

	public IntPtr UserData;
}
}

public static class GtkEventControllerScrollHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted after scroll is finished if the #GTK_EVENT_CONTROLLER_SCROLL_KINETIC
/// flag is set. @vel_x and @vel_y express the initial velocity that was
/// imprinted by the scroll events. @vel_x and @vel_y are expressed in
/// pixels/ms.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="vel_x">
/// X velocity
/// </param>
/// <param name="vel_y">
/// Y velocity
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void decelerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle self, double vel_x, double vel_y, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that the widget should scroll by the
/// amount specified by @dx and @dy.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="dx">
/// X delta
/// </param>
/// <param name="dy">
/// Y delta
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle self, double dx, double dy, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that a new scrolling operation has begun. It will
/// only be emitted on devices capable of it.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that a new scrolling operation has finished. It will
/// only be emitted on devices capable of it.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle self, IntPtr user_data);

}


public static class GtkEventControllerScrollHandleExtensions
{
/// <summary>
/// <para>
/// Gets the flags conditioning the scroll controller behavior.
/// </para>
/// </summary>

/// <param name="scroll">
/// a #GtkEventControllerScroll
/// </param>
/// <return>
/// the controller flags.
/// </return>

	public static MentorLake.Gtk.GtkEventControllerScrollFlags GetFlags(this MentorLake.Gtk.GtkEventControllerScrollHandle scroll)
	{
		if (scroll.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerScrollHandle)");
		return GtkEventControllerScrollHandleExterns.gtk_event_controller_scroll_get_flags(scroll);
	}

/// <summary>
/// <para>
/// Sets the flags conditioning scroll controller behavior.
/// </para>
/// </summary>

/// <param name="scroll">
/// a #GtkEventControllerScroll
/// </param>
/// <param name="flags">
/// behavior flags
/// </param>

	public static T SetFlags<T>(this T scroll, MentorLake.Gtk.GtkEventControllerScrollFlags flags) where T : GtkEventControllerScrollHandle
	{
		if (scroll.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerScrollHandle)");
		GtkEventControllerScrollHandleExterns.gtk_event_controller_scroll_set_flags(scroll, flags);
		return scroll;
	}

}

internal class GtkEventControllerScrollHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))]
	internal static extern MentorLake.Gtk.GtkEventControllerScrollHandle gtk_event_controller_scroll_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkEventControllerScrollFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEventControllerScrollFlags gtk_event_controller_scroll_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle scroll);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_controller_scroll_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle scroll, MentorLake.Gtk.GtkEventControllerScrollFlags flags);

}
