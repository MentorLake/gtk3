namespace MentorLake.Gtk;

public class GtkEventControllerScrollHandle : GtkEventControllerHandle
{
	public static MentorLake.Gtk.GtkEventControllerScrollHandle New(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkEventControllerScrollFlags flags)
	{
		return GtkEventControllerScrollHandleExterns.gtk_event_controller_scroll_new(widget, flags);
	}

}
public static class GtkEventControllerScrollHandleSignalExtensions
{

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

public struct DecelerateSignal
{
	public MentorLake.Gtk.GtkEventControllerScrollHandle Self;
	public double VelX;
	public double VelY;
	public IntPtr UserData;
}

public struct ScrollSignal
{
	public MentorLake.Gtk.GtkEventControllerScrollHandle Self;
	public double Dx;
	public double Dy;
	public IntPtr UserData;
}

public struct ScrollBeginSignal
{
	public MentorLake.Gtk.GtkEventControllerScrollHandle Self;
	public IntPtr UserData;
}

public struct ScrollEndSignal
{
	public MentorLake.Gtk.GtkEventControllerScrollHandle Self;
	public IntPtr UserData;
}
}

public static class GtkEventControllerScrollHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void decelerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle self, double vel_x, double vel_y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle self, double dx, double dy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void scroll_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle self, IntPtr user_data);

}


public static class GtkEventControllerScrollHandleExtensions
{
	public static MentorLake.Gtk.GtkEventControllerScrollFlags GetFlags(this MentorLake.Gtk.GtkEventControllerScrollHandle scroll)
	{
		if (scroll.IsInvalid || scroll.IsClosed) throw new Exception("Invalid or closed handle (GtkEventControllerScrollHandle)");
		return GtkEventControllerScrollHandleExterns.gtk_event_controller_scroll_get_flags(scroll);
	}

	public static T SetFlags<T>(this T scroll, MentorLake.Gtk.GtkEventControllerScrollFlags flags) where T : GtkEventControllerScrollHandle
	{
		if (scroll.IsInvalid || scroll.IsClosed) throw new Exception("Invalid or closed handle (GtkEventControllerScrollHandle)");
		GtkEventControllerScrollHandleExterns.gtk_event_controller_scroll_set_flags(scroll, flags);
		return scroll;
	}

}

internal class GtkEventControllerScrollHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEventControllerScrollHandle gtk_event_controller_scroll_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkEventControllerScrollFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEventControllerScrollFlags gtk_event_controller_scroll_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle scroll);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_controller_scroll_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerScrollHandle>))] MentorLake.Gtk.GtkEventControllerScrollHandle scroll, MentorLake.Gtk.GtkEventControllerScrollFlags flags);

}
