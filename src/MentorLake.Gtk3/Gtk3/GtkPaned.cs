namespace MentorLake.Gtk3.Gtk3;

public class GtkPanedHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkPanedHandle New(GtkOrientation orientation)
	{
		return GtkPanedExterns.gtk_paned_new(orientation);
	}

}

public static class GtkPanedSignalExtensions
{

	public static IObservable<GtkPanedSignalStructs.AcceptPositionSignal> Signal_AcceptPosition(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.AcceptPositionSignal> obs) =>
		{
			GtkPanedSignalDelegates.accept_position handler = (GtkPanedHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.AcceptPositionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accept_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.CancelPositionSignal> Signal_CancelPosition(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.CancelPositionSignal> obs) =>
		{
			GtkPanedSignalDelegates.cancel_position handler = (GtkPanedHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.CancelPositionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cancel_position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.CycleChildFocusSignal> Signal_CycleChildFocus(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.CycleChildFocusSignal> obs) =>
		{
			GtkPanedSignalDelegates.cycle_child_focus handler = (GtkPanedHandle self, bool reversed, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.CycleChildFocusSignal()
				{
					Self = self, Reversed = reversed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cycle_child_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.CycleHandleFocusSignal> Signal_CycleHandleFocus(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.CycleHandleFocusSignal> obs) =>
		{
			GtkPanedSignalDelegates.cycle_handle_focus handler = (GtkPanedHandle self, bool reversed, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.CycleHandleFocusSignal()
				{
					Self = self, Reversed = reversed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cycle_handle_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.MoveHandleSignal> Signal_MoveHandle(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.MoveHandleSignal> obs) =>
		{
			GtkPanedSignalDelegates.move_handle handler = (GtkPanedHandle self, ref GtkScrollType scroll_type, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.MoveHandleSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_handle", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPanedSignalStructs.ToggleHandleFocusSignal> Signal_ToggleHandleFocus(this GtkPanedHandle instance)
	{
		return Observable.Create((IObserver<GtkPanedSignalStructs.ToggleHandleFocusSignal> obs) =>
		{
			GtkPanedSignalDelegates.toggle_handle_focus handler = (GtkPanedHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedSignalStructs.ToggleHandleFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_handle_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPanedSignalStructs
{

public struct AcceptPositionSignal
{
	public GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CancelPositionSignal
{
	public GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CycleChildFocusSignal
{
	public GtkPanedHandle Self;
	public bool Reversed;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CycleHandleFocusSignal
{
	public GtkPanedHandle Self;
	public bool Reversed;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MoveHandleSignal
{
	public GtkPanedHandle Self;
	public GtkScrollType ScrollType;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ToggleHandleFocusSignal
{
	public GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkPanedSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accept_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cancel_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cycle_child_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, bool reversed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cycle_handle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, bool reversed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, ref GtkScrollType scroll_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool toggle_handle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPanedHandle>))] GtkPanedHandle self, IntPtr user_data);

}


public static class GtkPanedHandleExtensions
{
	public static T Add1<T>(this T paned, GtkWidgetHandle child) where T : GtkPanedHandle
	{
		GtkPanedExterns.gtk_paned_add1(paned, child);
		return paned;
	}

	public static T Add2<T>(this T paned, GtkWidgetHandle child) where T : GtkPanedHandle
	{
		GtkPanedExterns.gtk_paned_add2(paned, child);
		return paned;
	}

	public static GtkWidgetHandle GetChild1(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_child1(paned);
	}

	public static GtkWidgetHandle GetChild2(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_child2(paned);
	}

	public static GdkWindowHandle GetHandleWindow(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_handle_window(paned);
	}

	public static int GetPosition(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_position(paned);
	}

	public static bool GetWideHandle(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_wide_handle(paned);
	}

	public static T Pack1<T>(this T paned, GtkWidgetHandle child, bool resize, bool shrink) where T : GtkPanedHandle
	{
		GtkPanedExterns.gtk_paned_pack1(paned, child, resize, shrink);
		return paned;
	}

	public static T Pack2<T>(this T paned, GtkWidgetHandle child, bool resize, bool shrink) where T : GtkPanedHandle
	{
		GtkPanedExterns.gtk_paned_pack2(paned, child, resize, shrink);
		return paned;
	}

	public static T SetPosition<T>(this T paned, int position) where T : GtkPanedHandle
	{
		GtkPanedExterns.gtk_paned_set_position(paned, position);
		return paned;
	}

	public static T SetWideHandle<T>(this T paned, bool wide) where T : GtkPanedHandle
	{
		GtkPanedExterns.gtk_paned_set_wide_handle(paned, wide);
		return paned;
	}

}

internal class GtkPanedExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPanedHandle gtk_paned_new(GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paned_add1(GtkPanedHandle paned, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paned_add2(GtkPanedHandle paned, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_paned_get_child1(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_paned_get_child2(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_paned_get_handle_window(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_paned_get_position(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_paned_get_wide_handle(GtkPanedHandle paned);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paned_pack1(GtkPanedHandle paned, GtkWidgetHandle child, bool resize, bool shrink);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paned_pack2(GtkPanedHandle paned, GtkWidgetHandle child, bool resize, bool shrink);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paned_set_position(GtkPanedHandle paned, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paned_set_wide_handle(GtkPanedHandle paned, bool wide);

}
