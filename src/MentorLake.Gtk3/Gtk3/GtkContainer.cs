namespace MentorLake.Gtk3.Gtk3;

public class GtkContainerHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkContainerSignalExtensions
{

	public static IObservable<GtkContainerSignalStructs.AddSignal> Signal_Add(this GtkContainerHandle instance)
	{
		return Observable.Create((IObserver<GtkContainerSignalStructs.AddSignal> obs) =>
		{
			GtkContainerSignalDelegates.add handler = (GtkContainerHandle self, GtkWidgetHandle @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerSignalStructs.AddSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "add", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkContainerSignalStructs.CheckResizeSignal> Signal_CheckResize(this GtkContainerHandle instance)
	{
		return Observable.Create((IObserver<GtkContainerSignalStructs.CheckResizeSignal> obs) =>
		{
			GtkContainerSignalDelegates.check_resize handler = (GtkContainerHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerSignalStructs.CheckResizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "check_resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkContainerSignalStructs.RemoveSignal> Signal_Remove(this GtkContainerHandle instance)
	{
		return Observable.Create((IObserver<GtkContainerSignalStructs.RemoveSignal> obs) =>
		{
			GtkContainerSignalDelegates.remove handler = (GtkContainerHandle self, GtkWidgetHandle @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerSignalStructs.RemoveSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "remove", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkContainerSignalStructs.SetFocusChildSignal> Signal_SetFocusChild(this GtkContainerHandle instance)
	{
		return Observable.Create((IObserver<GtkContainerSignalStructs.SetFocusChildSignal> obs) =>
		{
			GtkContainerSignalDelegates.set_focus_child handler = (GtkContainerHandle self, GtkWidgetHandle @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerSignalStructs.SetFocusChildSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "set_focus_child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkContainerSignalStructs
{

public struct AddSignal
{
	public GtkContainerHandle Self;
	public GtkWidgetHandle Object;
	public IntPtr UserData;
}

public struct CheckResizeSignal
{
	public GtkContainerHandle Self;
	public IntPtr UserData;
}

public struct RemoveSignal
{
	public GtkContainerHandle Self;
	public GtkWidgetHandle Object;
	public IntPtr UserData;
}

public struct SetFocusChildSignal
{
	public GtkContainerHandle Self;
	public GtkWidgetHandle Object;
	public IntPtr UserData;
}
}

public static class GtkContainerSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkContainerHandle>))] GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void check_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkContainerHandle>))] GtkContainerHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkContainerHandle>))] GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void set_focus_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkContainerHandle>))] GtkContainerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle @object, IntPtr user_data);

}


public static class GtkContainerHandleExtensions
{
	public static GtkContainerHandle Add(this GtkContainerHandle container, GtkWidgetHandle widget)
	{
		GtkContainerExterns.gtk_container_add(container, widget);
		return container;
	}

	public static GtkContainerHandle AddWithProperties(this GtkContainerHandle container, GtkWidgetHandle widget, string first_prop_name, IntPtr @__arglist)
	{
		GtkContainerExterns.gtk_container_add_with_properties(container, widget, first_prop_name, @__arglist);
		return container;
	}

	public static GtkContainerHandle CheckResize(this GtkContainerHandle container)
	{
		GtkContainerExterns.gtk_container_check_resize(container);
		return container;
	}

	public static GtkContainerHandle ChildGet(this GtkContainerHandle container, GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist)
	{
		GtkContainerExterns.gtk_container_child_get(container, child, first_prop_name, @__arglist);
		return container;
	}

	public static GtkContainerHandle ChildGetProperty(this GtkContainerHandle container, GtkWidgetHandle child, string property_name, GValueHandle value)
	{
		GtkContainerExterns.gtk_container_child_get_property(container, child, property_name, value);
		return container;
	}

	public static GtkContainerHandle ChildGetValist(this GtkContainerHandle container, GtkWidgetHandle child, string first_property_name, out IntPtr var_args)
	{
		GtkContainerExterns.gtk_container_child_get_valist(container, child, first_property_name, out var_args);
		return container;
	}

	public static GtkContainerHandle ChildNotify(this GtkContainerHandle container, GtkWidgetHandle child, string child_property)
	{
		GtkContainerExterns.gtk_container_child_notify(container, child, child_property);
		return container;
	}

	public static GtkContainerHandle ChildNotifyByPspec(this GtkContainerHandle container, GtkWidgetHandle child, GParamSpecHandle pspec)
	{
		GtkContainerExterns.gtk_container_child_notify_by_pspec(container, child, pspec);
		return container;
	}

	public static GtkContainerHandle ChildSet(this GtkContainerHandle container, GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist)
	{
		GtkContainerExterns.gtk_container_child_set(container, child, first_prop_name, @__arglist);
		return container;
	}

	public static GtkContainerHandle ChildSetProperty(this GtkContainerHandle container, GtkWidgetHandle child, string property_name, GValueHandle value)
	{
		GtkContainerExterns.gtk_container_child_set_property(container, child, property_name, value);
		return container;
	}

	public static GtkContainerHandle ChildSetValist(this GtkContainerHandle container, GtkWidgetHandle child, string first_property_name, IntPtr var_args)
	{
		GtkContainerExterns.gtk_container_child_set_valist(container, child, first_property_name, var_args);
		return container;
	}

	public static GType ChildType(this GtkContainerHandle container)
	{
		return GtkContainerExterns.gtk_container_child_type(container);
	}

	public static GtkContainerHandle Forall(this GtkContainerHandle container, GtkCallback callback, IntPtr callback_data)
	{
		GtkContainerExterns.gtk_container_forall(container, callback, callback_data);
		return container;
	}

	public static GtkContainerHandle Foreach(this GtkContainerHandle container, GtkCallback callback, IntPtr callback_data)
	{
		GtkContainerExterns.gtk_container_foreach(container, callback, callback_data);
		return container;
	}

	public static uint GetBorderWidth(this GtkContainerHandle container)
	{
		return GtkContainerExterns.gtk_container_get_border_width(container);
	}

	public static GListHandle GetChildren(this GtkContainerHandle container)
	{
		return GtkContainerExterns.gtk_container_get_children(container);
	}

	public static bool GetFocusChain(this GtkContainerHandle container, out GListHandle focusable_widgets)
	{
		return GtkContainerExterns.gtk_container_get_focus_chain(container, out focusable_widgets);
	}

	public static GtkWidgetHandle GetFocusChild(this GtkContainerHandle container)
	{
		return GtkContainerExterns.gtk_container_get_focus_child(container);
	}

	public static GtkAdjustmentHandle GetFocusHadjustment(this GtkContainerHandle container)
	{
		return GtkContainerExterns.gtk_container_get_focus_hadjustment(container);
	}

	public static GtkAdjustmentHandle GetFocusVadjustment(this GtkContainerHandle container)
	{
		return GtkContainerExterns.gtk_container_get_focus_vadjustment(container);
	}

	public static GtkWidgetPathHandle GetPathForChild(this GtkContainerHandle container, GtkWidgetHandle child)
	{
		return GtkContainerExterns.gtk_container_get_path_for_child(container, child);
	}

	public static GtkResizeMode GetResizeMode(this GtkContainerHandle container)
	{
		return GtkContainerExterns.gtk_container_get_resize_mode(container);
	}

	public static GtkContainerHandle PropagateDraw(this GtkContainerHandle container, GtkWidgetHandle child, cairo_tHandle cr)
	{
		GtkContainerExterns.gtk_container_propagate_draw(container, child, cr);
		return container;
	}

	public static GtkContainerHandle Remove(this GtkContainerHandle container, GtkWidgetHandle widget)
	{
		GtkContainerExterns.gtk_container_remove(container, widget);
		return container;
	}

	public static GtkContainerHandle ResizeChildren(this GtkContainerHandle container)
	{
		GtkContainerExterns.gtk_container_resize_children(container);
		return container;
	}

	public static GtkContainerHandle SetBorderWidth(this GtkContainerHandle container, uint border_width)
	{
		GtkContainerExterns.gtk_container_set_border_width(container, border_width);
		return container;
	}

	public static GtkContainerHandle SetFocusChain(this GtkContainerHandle container, GListHandle focusable_widgets)
	{
		GtkContainerExterns.gtk_container_set_focus_chain(container, focusable_widgets);
		return container;
	}

	public static GtkContainerHandle SetFocusChild(this GtkContainerHandle container, GtkWidgetHandle child)
	{
		GtkContainerExterns.gtk_container_set_focus_child(container, child);
		return container;
	}

	public static GtkContainerHandle SetFocusHadjustment(this GtkContainerHandle container, GtkAdjustmentHandle adjustment)
	{
		GtkContainerExterns.gtk_container_set_focus_hadjustment(container, adjustment);
		return container;
	}

	public static GtkContainerHandle SetFocusVadjustment(this GtkContainerHandle container, GtkAdjustmentHandle adjustment)
	{
		GtkContainerExterns.gtk_container_set_focus_vadjustment(container, adjustment);
		return container;
	}

	public static GtkContainerHandle SetReallocateRedraws(this GtkContainerHandle container, bool needs_redraws)
	{
		GtkContainerExterns.gtk_container_set_reallocate_redraws(container, needs_redraws);
		return container;
	}

	public static GtkContainerHandle SetResizeMode(this GtkContainerHandle container, GtkResizeMode resize_mode)
	{
		GtkContainerExterns.gtk_container_set_resize_mode(container, resize_mode);
		return container;
	}

	public static GtkContainerHandle UnsetFocusChain(this GtkContainerHandle container)
	{
		GtkContainerExterns.gtk_container_unset_focus_chain(container);
		return container;
	}

}

internal class GtkContainerExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_add(GtkContainerHandle container, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_add_with_properties(GtkContainerHandle container, GtkWidgetHandle widget, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_check_resize(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_child_get(GtkContainerHandle container, GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_child_get_property(GtkContainerHandle container, GtkWidgetHandle child, string property_name, GValueHandle value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_child_get_valist(GtkContainerHandle container, GtkWidgetHandle child, string first_property_name, out IntPtr var_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_child_notify(GtkContainerHandle container, GtkWidgetHandle child, string child_property);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_child_notify_by_pspec(GtkContainerHandle container, GtkWidgetHandle child, GParamSpecHandle pspec);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_child_set(GtkContainerHandle container, GtkWidgetHandle child, string first_prop_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_child_set_property(GtkContainerHandle container, GtkWidgetHandle child, string property_name, GValueHandle value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_child_set_valist(GtkContainerHandle container, GtkWidgetHandle child, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern GType gtk_container_child_type(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_forall(GtkContainerHandle container, GtkCallback callback, IntPtr callback_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_foreach(GtkContainerHandle container, GtkCallback callback, IntPtr callback_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_container_get_border_width(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_container_get_children(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_container_get_focus_chain(GtkContainerHandle container, out GListHandle focusable_widgets);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_container_get_focus_child(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_container_get_focus_hadjustment(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_container_get_focus_vadjustment(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetPathHandle gtk_container_get_path_for_child(GtkContainerHandle container, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkResizeMode gtk_container_get_resize_mode(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_propagate_draw(GtkContainerHandle container, GtkWidgetHandle child, cairo_tHandle cr);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_remove(GtkContainerHandle container, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_resize_children(GtkContainerHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_set_border_width(GtkContainerHandle container, uint border_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_set_focus_chain(GtkContainerHandle container, GListHandle focusable_widgets);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_set_focus_child(GtkContainerHandle container, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_set_focus_hadjustment(GtkContainerHandle container, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_set_focus_vadjustment(GtkContainerHandle container, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_set_reallocate_redraws(GtkContainerHandle container, bool needs_redraws);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_set_resize_mode(GtkContainerHandle container, GtkResizeMode resize_mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_unset_focus_chain(GtkContainerHandle container);

}
