namespace MentorLake.Gtk3.Gtk3;

public class GtkEventControllerScrollHandle : GtkEventControllerHandle
{
	public static GtkEventControllerScrollHandle New(GtkWidgetHandle widget, GtkEventControllerScrollFlags flags)
	{
		return GtkEventControllerScrollExterns.gtk_event_controller_scroll_new(widget, flags);
	}

}

public static class GtkEventControllerScrollSignalExtensions
{

	public static IObservable<GtkEventControllerScrollSignalStructs.DecelerateSignal> Signal_Decelerate(this GtkEventControllerScrollHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollSignalStructs.DecelerateSignal> obs) =>
		{
			GtkEventControllerScrollSignalDelegates.decelerate handler = (GtkEventControllerScrollHandle self, double vel_x, double vel_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollSignalStructs.DecelerateSignal()
				{
					Self = self, VelX = vel_x, VelY = vel_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "decelerate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerScrollSignalStructs.ScrollSignal> Signal_Scroll(this GtkEventControllerScrollHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollSignalStructs.ScrollSignal> obs) =>
		{
			GtkEventControllerScrollSignalDelegates.scroll handler = (GtkEventControllerScrollHandle self, double dx, double dy, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollSignalStructs.ScrollSignal()
				{
					Self = self, Dx = dx, Dy = dy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerScrollSignalStructs.ScrollBeginSignal> Signal_ScrollBegin(this GtkEventControllerScrollHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollSignalStructs.ScrollBeginSignal> obs) =>
		{
			GtkEventControllerScrollSignalDelegates.scroll_begin handler = (GtkEventControllerScrollHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollSignalStructs.ScrollBeginSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll_begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerScrollSignalStructs.ScrollEndSignal> Signal_ScrollEnd(this GtkEventControllerScrollHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerScrollSignalStructs.ScrollEndSignal> obs) =>
		{
			GtkEventControllerScrollSignalDelegates.scroll_end handler = (GtkEventControllerScrollHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerScrollSignalStructs.ScrollEndSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEventControllerScrollSignalStructs
{

public struct DecelerateSignal
{
	public GtkEventControllerScrollHandle Self;
	public double VelX;
	public double VelY;
	public IntPtr UserData;
}

public struct ScrollSignal
{
	public GtkEventControllerScrollHandle Self;
	public double Dx;
	public double Dy;
	public IntPtr UserData;
}

public struct ScrollBeginSignal
{
	public GtkEventControllerScrollHandle Self;
	public IntPtr UserData;
}

public struct ScrollEndSignal
{
	public GtkEventControllerScrollHandle Self;
	public IntPtr UserData;
}
}

public static class GtkEventControllerScrollSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void decelerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, double vel_x, double vel_y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, double dx, double dy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, IntPtr user_data);

}


public static class GtkEventControllerScrollHandleExtensions
{
	public static GtkEventControllerScrollFlags GetFlags(this GtkEventControllerScrollHandle controller)
	{
		return GtkEventControllerScrollExterns.gtk_event_controller_scroll_get_flags(controller);
	}

	public static GtkEventControllerScrollHandle SetFlags(this GtkEventControllerScrollHandle controller, GtkEventControllerScrollFlags flags)
	{
		GtkEventControllerScrollExterns.gtk_event_controller_scroll_set_flags(controller, flags);
		return controller;
	}

}

internal class GtkEventControllerScrollExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEventControllerScrollHandle gtk_event_controller_scroll_new(GtkWidgetHandle widget, GtkEventControllerScrollFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEventControllerScrollFlags gtk_event_controller_scroll_get_flags(GtkEventControllerScrollHandle controller);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_event_controller_scroll_set_flags(GtkEventControllerScrollHandle controller, GtkEventControllerScrollFlags flags);

}
