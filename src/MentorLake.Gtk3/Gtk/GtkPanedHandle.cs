namespace MentorLake.Gtk;

public class GtkPanedHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkPanedHandle New(MentorLake.Gtk.GtkOrientation orientation)
	{
		return GtkPanedHandleExterns.gtk_paned_new(orientation);
	}

}
public static class GtkPanedHandleSignalExtensions
{

	public static IObservable<GtkPanedHandleSignalStructs.AcceptPositionSignal> Signal_AcceptPosition(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.AcceptPositionSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.accept_position handler = ( MentorLake.Gtk.GtkPanedHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.AcceptPositionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accept-position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPanedHandleSignalStructs.CancelPositionSignal> Signal_CancelPosition(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.CancelPositionSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.cancel_position handler = ( MentorLake.Gtk.GtkPanedHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.CancelPositionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancel-position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPanedHandleSignalStructs.CycleChildFocusSignal> Signal_CycleChildFocus(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.CycleChildFocusSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.cycle_child_focus handler = ( MentorLake.Gtk.GtkPanedHandle self,  bool reversed,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.CycleChildFocusSignal()
				{
					Self = self, Reversed = reversed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cycle-child-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPanedHandleSignalStructs.CycleHandleFocusSignal> Signal_CycleHandleFocus(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.CycleHandleFocusSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.cycle_handle_focus handler = ( MentorLake.Gtk.GtkPanedHandle self,  bool reversed,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.CycleHandleFocusSignal()
				{
					Self = self, Reversed = reversed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cycle-handle-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPanedHandleSignalStructs.MoveHandleSignal> Signal_MoveHandle(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.MoveHandleSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.move_handle handler = ( MentorLake.Gtk.GtkPanedHandle self,  MentorLake.Gtk.GtkScrollType scroll_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.MoveHandleSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-handle", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPanedHandleSignalStructs.ToggleHandleFocusSignal> Signal_ToggleHandleFocus(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.ToggleHandleFocusSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.toggle_handle_focus handler = ( MentorLake.Gtk.GtkPanedHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.ToggleHandleFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-handle-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkPanedHandleSignalStructs
{

public class AcceptPositionSignal
{
	public MentorLake.Gtk.GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class CancelPositionSignal
{
	public MentorLake.Gtk.GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class CycleChildFocusSignal
{
	public MentorLake.Gtk.GtkPanedHandle Self;
	public bool Reversed;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class CycleHandleFocusSignal
{
	public MentorLake.Gtk.GtkPanedHandle Self;
	public bool Reversed;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class MoveHandleSignal
{
	public MentorLake.Gtk.GtkPanedHandle Self;
	public MentorLake.Gtk.GtkScrollType ScrollType;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ToggleHandleFocusSignal
{
	public MentorLake.Gtk.GtkPanedHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkPanedHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accept_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cancel_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cycle_child_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, bool reversed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cycle_handle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, bool reversed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, MentorLake.Gtk.GtkScrollType scroll_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool toggle_handle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, IntPtr user_data);

}


public static class GtkPanedHandleExtensions
{
	public static T Add1<T>(this T paned, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_add1(paned, child);
		return paned;
	}

	public static T Add2<T>(this T paned, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_add2(paned, child);
		return paned;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetChild1(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_child1(paned);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetChild2(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_child2(paned);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetHandleWindow(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_handle_window(paned);
	}

	public static int GetPosition(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_position(paned);
	}

	public static bool GetWideHandle(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_wide_handle(paned);
	}

	public static T Pack1<T>(this T paned, MentorLake.Gtk.GtkWidgetHandle child, bool resize, bool shrink) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_pack1(paned, child, resize, shrink);
		return paned;
	}

	public static T Pack2<T>(this T paned, MentorLake.Gtk.GtkWidgetHandle child, bool resize, bool shrink) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_pack2(paned, child, resize, shrink);
		return paned;
	}

	public static T SetPosition<T>(this T paned, int position) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_set_position(paned, position);
		return paned;
	}

	public static T SetWideHandle<T>(this T paned, bool wide) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_set_wide_handle(paned, wide);
		return paned;
	}

}

internal class GtkPanedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))]
	internal static extern MentorLake.Gtk.GtkPanedHandle gtk_paned_new(MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_add1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_add2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_paned_get_child1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_paned_get_child2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_paned_get_handle_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_paned_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_paned_get_wide_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_pack1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool resize, bool shrink);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_pack2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool resize, bool shrink);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_set_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_set_wide_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, bool wide);

}
