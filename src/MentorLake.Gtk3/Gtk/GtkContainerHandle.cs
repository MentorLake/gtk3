namespace MentorLake.Gtk;

public class GtkContainerHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}
public static class GtkContainerHandleSignalExtensions
{

	public static IObservable<GtkContainerHandleSignalStructs.AddSignal> Signal_Add(this GtkContainerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerHandleSignalStructs.AddSignal> obs) =>
		{
			GtkContainerHandleSignalDelegates.add handler = ( MentorLake.Gtk.GtkContainerHandle self,  MentorLake.Gtk.GtkWidgetHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerHandleSignalStructs.AddSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "add", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkContainerHandleSignalStructs.CheckResizeSignal> Signal_CheckResize(this GtkContainerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerHandleSignalStructs.CheckResizeSignal> obs) =>
		{
			GtkContainerHandleSignalDelegates.check_resize handler = ( MentorLake.Gtk.GtkContainerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerHandleSignalStructs.CheckResizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "check-resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkContainerHandleSignalStructs.RemoveSignal> Signal_Remove(this GtkContainerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerHandleSignalStructs.RemoveSignal> obs) =>
		{
			GtkContainerHandleSignalDelegates.remove handler = ( MentorLake.Gtk.GtkContainerHandle self,  MentorLake.Gtk.GtkWidgetHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerHandleSignalStructs.RemoveSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkContainerHandleSignalStructs.SetFocusChildSignal> Signal_SetFocusChild(this GtkContainerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerHandleSignalStructs.SetFocusChildSignal> obs) =>
		{
			GtkContainerHandleSignalDelegates.set_focus_child handler = ( MentorLake.Gtk.GtkContainerHandle self,  MentorLake.Gtk.GtkWidgetHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerHandleSignalStructs.SetFocusChildSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "set-focus-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkContainerHandleSignalStructs
{

public struct AddSignal
{
	public MentorLake.Gtk.GtkContainerHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Object;
	public IntPtr UserData;
}

public struct CheckResizeSignal
{
	public MentorLake.Gtk.GtkContainerHandle Self;
	public IntPtr UserData;
}

public struct RemoveSignal
{
	public MentorLake.Gtk.GtkContainerHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Object;
	public IntPtr UserData;
}

public struct SetFocusChildSignal
{
	public MentorLake.Gtk.GtkContainerHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Object;
	public IntPtr UserData;
}
}

public static class GtkContainerHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void check_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void set_focus_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle @object, IntPtr user_data);

}


public static class GtkContainerHandleExtensions
{
	public static T Add<T>(this T container, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_add(container, widget);
		return container;
	}

	public static T AddWithProperties<T>(this T container, MentorLake.Gtk.GtkWidgetHandle widget, string first_prop_name, IntPtr @__arglist) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_add_with_properties(container, widget, first_prop_name, @__arglist);
		return container;
	}

	public static T CheckResize<T>(this T container) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_check_resize(container);
		return container;
	}

	public static T ChildGet<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_get(container, child, first_prop_name, @__arglist);
		return container;
	}

	public static T ChildGetProperty<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string property_name, out MentorLake.GObject.GValue value) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_get_property(container, child, property_name, out value);
		return container;
	}

	public static T ChildGetValist<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string first_property_name, IntPtr var_args) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_get_valist(container, child, first_property_name, var_args);
		return container;
	}

	public static T ChildNotify<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string child_property) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_notify(container, child, child_property);
		return container;
	}

	public static T ChildNotifyByPspec<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.GObject.GParamSpecHandle pspec) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_notify_by_pspec(container, child, pspec);
		return container;
	}

	public static T ChildSet<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_set(container, child, first_prop_name, @__arglist);
		return container;
	}

	public static T ChildSetProperty<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string property_name, MentorLake.GObject.GValueHandle value) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_set_property(container, child, property_name, value);
		return container;
	}

	public static T ChildSetValist<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, string first_property_name, IntPtr var_args) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_child_set_valist(container, child, first_property_name, var_args);
		return container;
	}

	public static MentorLake.GObject.GType ChildType(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_child_type(container);
	}

	public static T Forall<T>(this T container, MentorLake.Gtk.GtkCallback callback, IntPtr callback_data) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_forall(container, callback, callback_data);
		return container;
	}

	public static T Foreach<T>(this T container, MentorLake.Gtk.GtkCallback callback, IntPtr callback_data) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_foreach(container, callback, callback_data);
		return container;
	}

	public static uint GetBorderWidth(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_border_width(container);
	}

	public static MentorLake.GLib.GListHandle GetChildren(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_children(container);
	}

	public static bool GetFocusChain(this MentorLake.Gtk.GtkContainerHandle container, out MentorLake.GLib.GListHandle focusable_widgets)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_focus_chain(container, out focusable_widgets);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetFocusChild(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_focus_child(container);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetFocusHadjustment(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_focus_hadjustment(container);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetFocusVadjustment(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_focus_vadjustment(container);
	}

	public static MentorLake.Gtk.GtkWidgetPathHandle GetPathForChild(this MentorLake.Gtk.GtkContainerHandle container, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_path_for_child(container, child);
	}

	public static MentorLake.Gtk.GtkResizeMode GetResizeMode(this MentorLake.Gtk.GtkContainerHandle container)
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		return GtkContainerHandleExterns.gtk_container_get_resize_mode(container);
	}

	public static T PropagateDraw<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.cairo.cairo_tHandle cr) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_propagate_draw(container, child, cr);
		return container;
	}

	public static T Remove<T>(this T container, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_remove(container, widget);
		return container;
	}

	public static T ResizeChildren<T>(this T container) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_resize_children(container);
		return container;
	}

	public static T SetBorderWidth<T>(this T container, uint border_width) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_border_width(container, border_width);
		return container;
	}

	public static T SetFocusChain<T>(this T container, MentorLake.GLib.GListHandle focusable_widgets) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_focus_chain(container, focusable_widgets);
		return container;
	}

	public static T SetFocusChild<T>(this T container, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_focus_child(container, child);
		return container;
	}

	public static T SetFocusHadjustment<T>(this T container, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_focus_hadjustment(container, adjustment);
		return container;
	}

	public static T SetFocusVadjustment<T>(this T container, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_focus_vadjustment(container, adjustment);
		return container;
	}

	public static T SetReallocateRedraws<T>(this T container, bool needs_redraws) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_reallocate_redraws(container, needs_redraws);
		return container;
	}

	public static T SetResizeMode<T>(this T container, MentorLake.Gtk.GtkResizeMode resize_mode) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_set_resize_mode(container, resize_mode);
		return container;
	}

	public static T UnsetFocusChain<T>(this T container) where T : GtkContainerHandle
	{
		if (container.IsInvalid || container.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerHandle)");
		GtkContainerHandleExterns.gtk_container_unset_focus_chain(container);
		return container;
	}

}

internal class GtkContainerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_add_with_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_check_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string child_property);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_notify_by_pspec([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_set_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_child_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_container_child_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_forall([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, MentorLake.Gtk.GtkCallback callback, IntPtr callback_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, MentorLake.Gtk.GtkCallback callback, IntPtr callback_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_container_get_border_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_container_get_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_container_get_focus_chain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] out MentorLake.GLib.GListHandle focusable_widgets);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_container_get_focus_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_container_get_focus_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_container_get_focus_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_container_get_path_for_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkResizeMode gtk_container_get_resize_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_propagate_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_resize_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_border_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, uint border_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_focus_chain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle focusable_widgets);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_focus_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_focus_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_focus_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_reallocate_redraws([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, bool needs_redraws);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_set_resize_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container, MentorLake.Gtk.GtkResizeMode resize_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_unset_focus_chain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerHandle>))] MentorLake.Gtk.GtkContainerHandle container);

}
