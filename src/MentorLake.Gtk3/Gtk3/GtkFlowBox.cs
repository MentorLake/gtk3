namespace MentorLake.Gtk3.Gtk3;

public class GtkFlowBoxHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkFlowBoxHandle New()
	{
		return GtkFlowBoxExterns.gtk_flow_box_new();
	}

}

public static class GtkFlowBoxSignalExtensions
{

	public static IObservable<GtkFlowBoxSignalStructs.ActivateCursorChildSignal> Signal_ActivateCursorChild(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.ActivateCursorChildSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.activate_cursor_child handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.ActivateCursorChildSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_cursor_child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.ChildActivatedSignal> Signal_ChildActivated(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.ChildActivatedSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.child_activated handler = (GtkFlowBoxHandle self, GtkFlowBoxChildHandle child, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.ChildActivatedSignal()
				{
					Self = self, Child = child, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "child_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.move_cursor handler = (GtkFlowBoxHandle self, GtkMovementStep step, int count, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.SelectAllSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.select_all handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.SelectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "select_all", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.SelectedChildrenChangedSignal> Signal_SelectedChildrenChanged(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.SelectedChildrenChangedSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.selected_children_changed handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.SelectedChildrenChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selected_children_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.ToggleCursorChildSignal> Signal_ToggleCursorChild(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.ToggleCursorChildSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.toggle_cursor_child handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.ToggleCursorChildSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_cursor_child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.unselect_all handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.UnselectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unselect_all", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkFlowBoxSignalStructs
{

public struct ActivateCursorChildSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public struct ChildActivatedSignal
{
	public GtkFlowBoxHandle Self;
	public GtkFlowBoxChildHandle Child;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkFlowBoxHandle Self;
	public GtkMovementStep Step;
	public int Count;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectAllSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public struct SelectedChildrenChangedSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public struct ToggleCursorChildSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public struct UnselectAllSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFlowBoxSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_cursor_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxChildHandle>))] GtkFlowBoxChildHandle child, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, GtkMovementStep step, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selected_children_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);

}


public static class GtkFlowBoxHandleExtensions
{
	public static T BindModel<T>(this T box, GListModelHandle model, GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

	public static bool GetActivateOnSingleClick(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_activate_on_single_click(box);
	}

	public static GtkFlowBoxChildHandle GetChildAtIndex(this GtkFlowBoxHandle box, int idx)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_child_at_index(box, idx);
	}

	public static GtkFlowBoxChildHandle GetChildAtPos(this GtkFlowBoxHandle box, int x, int y)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_child_at_pos(box, x, y);
	}

	public static uint GetColumnSpacing(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_column_spacing(box);
	}

	public static bool GetHomogeneous(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_homogeneous(box);
	}

	public static uint GetMaxChildrenPerLine(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_max_children_per_line(box);
	}

	public static uint GetMinChildrenPerLine(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_min_children_per_line(box);
	}

	public static uint GetRowSpacing(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_row_spacing(box);
	}

	public static GListHandle GetSelectedChildren(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_selected_children(box);
	}

	public static GtkSelectionMode GetSelectionMode(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_selection_mode(box);
	}

	public static T Insert<T>(this T box, GtkWidgetHandle widget, int position) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_insert(box, widget, position);
		return box;
	}

	public static T InvalidateFilter<T>(this T box) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_invalidate_filter(box);
		return box;
	}

	public static T InvalidateSort<T>(this T box) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_invalidate_sort(box);
		return box;
	}

	public static T SelectAll<T>(this T box) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_select_all(box);
		return box;
	}

	public static T SelectChild<T>(this T box, GtkFlowBoxChildHandle child) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_select_child(box, child);
		return box;
	}

	public static T SelectedForeach<T>(this T box, GtkFlowBoxForeachFunc func, IntPtr data) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_selected_foreach(box, func, data);
		return box;
	}

	public static T SetActivateOnSingleClick<T>(this T box, bool single) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_activate_on_single_click(box, single);
		return box;
	}

	public static T SetColumnSpacing<T>(this T box, uint spacing) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_column_spacing(box, spacing);
		return box;
	}

	public static T SetFilterFunc<T>(this T box, GtkFlowBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

	public static T SetHadjustment<T>(this T box, GtkAdjustmentHandle adjustment) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_hadjustment(box, adjustment);
		return box;
	}

	public static T SetHomogeneous<T>(this T box, bool homogeneous) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_homogeneous(box, homogeneous);
		return box;
	}

	public static T SetMaxChildrenPerLine<T>(this T box, uint n_children) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_max_children_per_line(box, n_children);
		return box;
	}

	public static T SetMinChildrenPerLine<T>(this T box, uint n_children) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_min_children_per_line(box, n_children);
		return box;
	}

	public static T SetRowSpacing<T>(this T box, uint spacing) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_row_spacing(box, spacing);
		return box;
	}

	public static T SetSelectionMode<T>(this T box, GtkSelectionMode mode) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_selection_mode(box, mode);
		return box;
	}

	public static T SetSortFunc<T>(this T box, GtkFlowBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

	public static T SetVadjustment<T>(this T box, GtkAdjustmentHandle adjustment) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_set_vadjustment(box, adjustment);
		return box;
	}

	public static T UnselectAll<T>(this T box) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_unselect_all(box);
		return box;
	}

	public static T UnselectChild<T>(this T box, GtkFlowBoxChildHandle child) where T : GtkFlowBoxHandle
	{
		GtkFlowBoxExterns.gtk_flow_box_unselect_child(box, child);
		return box;
	}

}

internal class GtkFlowBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFlowBoxHandle gtk_flow_box_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_bind_model(GtkFlowBoxHandle box, GListModelHandle model, GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_flow_box_get_activate_on_single_click(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFlowBoxChildHandle gtk_flow_box_get_child_at_index(GtkFlowBoxHandle box, int idx);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFlowBoxChildHandle gtk_flow_box_get_child_at_pos(GtkFlowBoxHandle box, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_flow_box_get_column_spacing(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_flow_box_get_homogeneous(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_flow_box_get_max_children_per_line(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_flow_box_get_min_children_per_line(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_flow_box_get_row_spacing(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_flow_box_get_selected_children(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSelectionMode gtk_flow_box_get_selection_mode(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_insert(GtkFlowBoxHandle box, GtkWidgetHandle widget, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_invalidate_filter(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_invalidate_sort(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_select_all(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_select_child(GtkFlowBoxHandle box, GtkFlowBoxChildHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_selected_foreach(GtkFlowBoxHandle box, GtkFlowBoxForeachFunc func, IntPtr data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_activate_on_single_click(GtkFlowBoxHandle box, bool single);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_column_spacing(GtkFlowBoxHandle box, uint spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_filter_func(GtkFlowBoxHandle box, GtkFlowBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_hadjustment(GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_homogeneous(GtkFlowBoxHandle box, bool homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_max_children_per_line(GtkFlowBoxHandle box, uint n_children);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_min_children_per_line(GtkFlowBoxHandle box, uint n_children);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_row_spacing(GtkFlowBoxHandle box, uint spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_selection_mode(GtkFlowBoxHandle box, GtkSelectionMode mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_sort_func(GtkFlowBoxHandle box, GtkFlowBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_set_vadjustment(GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_unselect_all(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_unselect_child(GtkFlowBoxHandle box, GtkFlowBoxChildHandle child);

}
