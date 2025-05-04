namespace MentorLake.Gtk;

public class GtkFlowBoxHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkFlowBoxHandle New()
	{
		return GtkFlowBoxHandleExterns.gtk_flow_box_new();
	}

}
public static class GtkFlowBoxHandleSignalExtensions
{

	public static IObservable<GtkFlowBoxHandleSignalStructs.ActivateCursorChildSignal> Signal_ActivateCursorChild(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.ActivateCursorChildSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.activate_cursor_child handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.ActivateCursorChildSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-cursor-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkFlowBoxHandleSignalStructs.ChildActivatedSignal> Signal_ChildActivated(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.ChildActivatedSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.child_activated handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  MentorLake.Gtk.GtkFlowBoxChildHandle child,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.ChildActivatedSignal()
				{
					Self = self, Child = child, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "child-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkFlowBoxHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  MentorLake.Gtk.GtkMovementStep step,  int count,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkFlowBoxHandleSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.SelectAllSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.select_all handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.SelectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select-all", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkFlowBoxHandleSignalStructs.SelectedChildrenChangedSignal> Signal_SelectedChildrenChanged(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.SelectedChildrenChangedSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.selected_children_changed handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.SelectedChildrenChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selected-children-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkFlowBoxHandleSignalStructs.ToggleCursorChildSignal> Signal_ToggleCursorChild(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.ToggleCursorChildSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.toggle_cursor_child handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.ToggleCursorChildSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-cursor-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkFlowBoxHandleSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.unselect_all handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.UnselectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unselect-all", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkFlowBoxHandleSignalStructs
{

public class ActivateCursorChildSignal
{
	public MentorLake.Gtk.GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public class ChildActivatedSignal
{
	public MentorLake.Gtk.GtkFlowBoxHandle Self;
	public MentorLake.Gtk.GtkFlowBoxChildHandle Child;
	public IntPtr UserData;
}

public class MoveCursorSignal
{
	public MentorLake.Gtk.GtkFlowBoxHandle Self;
	public MentorLake.Gtk.GtkMovementStep Step;
	public int Count;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SelectAllSignal
{
	public MentorLake.Gtk.GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public class SelectedChildrenChangedSignal
{
	public MentorLake.Gtk.GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public class ToggleCursorChildSignal
{
	public MentorLake.Gtk.GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public class UnselectAllSignal
{
	public MentorLake.Gtk.GtkFlowBoxHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFlowBoxHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_cursor_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, MentorLake.Gtk.GtkMovementStep step, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selected_children_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);

}


public static class GtkFlowBoxHandleExtensions
{
	public static T BindModel<T>(this T box, MentorLake.Gio.GListModelHandle model, MentorLake.Gtk.GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

	public static bool GetActivateOnSingleClick(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_activate_on_single_click(box);
	}

	public static MentorLake.Gtk.GtkFlowBoxChildHandle GetChildAtIndex(this MentorLake.Gtk.GtkFlowBoxHandle box, int idx)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_child_at_index(box, idx);
	}

	public static MentorLake.Gtk.GtkFlowBoxChildHandle GetChildAtPos(this MentorLake.Gtk.GtkFlowBoxHandle box, int x, int y)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_child_at_pos(box, x, y);
	}

	public static uint GetColumnSpacing(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_column_spacing(box);
	}

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_homogeneous(box);
	}

	public static uint GetMaxChildrenPerLine(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_max_children_per_line(box);
	}

	public static uint GetMinChildrenPerLine(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_min_children_per_line(box);
	}

	public static uint GetRowSpacing(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_row_spacing(box);
	}

	public static MentorLake.GLib.GListHandle GetSelectedChildren(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_selected_children(box);
	}

	public static MentorLake.Gtk.GtkSelectionMode GetSelectionMode(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_selection_mode(box);
	}

	public static T Insert<T>(this T box, MentorLake.Gtk.GtkWidgetHandle widget, int position) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_insert(box, widget, position);
		return box;
	}

	public static T InvalidateFilter<T>(this T box) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_invalidate_filter(box);
		return box;
	}

	public static T InvalidateSort<T>(this T box) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_invalidate_sort(box);
		return box;
	}

	public static T SelectAll<T>(this T box) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_select_all(box);
		return box;
	}

	public static T SelectChild<T>(this T box, MentorLake.Gtk.GtkFlowBoxChildHandle child) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_select_child(box, child);
		return box;
	}

	public static T SelectedForeach<T>(this T box, MentorLake.Gtk.GtkFlowBoxForeachFunc func, IntPtr data) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_selected_foreach(box, func, data);
		return box;
	}

	public static T SetActivateOnSingleClick<T>(this T box, bool single) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_activate_on_single_click(box, single);
		return box;
	}

	public static T SetColumnSpacing<T>(this T box, uint spacing) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_column_spacing(box, spacing);
		return box;
	}

	public static T SetFilterFunc<T>(this T box, MentorLake.Gtk.GtkFlowBoxFilterFunc filter_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

	public static T SetHadjustment<T>(this T box, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_hadjustment(box, adjustment);
		return box;
	}

	public static T SetHomogeneous<T>(this T box, bool homogeneous) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_homogeneous(box, homogeneous);
		return box;
	}

	public static T SetMaxChildrenPerLine<T>(this T box, uint n_children) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_max_children_per_line(box, n_children);
		return box;
	}

	public static T SetMinChildrenPerLine<T>(this T box, uint n_children) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_min_children_per_line(box, n_children);
		return box;
	}

	public static T SetRowSpacing<T>(this T box, uint spacing) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_row_spacing(box, spacing);
		return box;
	}

	public static T SetSelectionMode<T>(this T box, MentorLake.Gtk.GtkSelectionMode mode) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_selection_mode(box, mode);
		return box;
	}

	public static T SetSortFunc<T>(this T box, MentorLake.Gtk.GtkFlowBoxSortFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

	public static T SetVadjustment<T>(this T box, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_vadjustment(box, adjustment);
		return box;
	}

	public static T UnselectAll<T>(this T box) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_unselect_all(box);
		return box;
	}

	public static T UnselectChild<T>(this T box, MentorLake.Gtk.GtkFlowBoxChildHandle child) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_unselect_child(box, child);
		return box;
	}

}

internal class GtkFlowBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFlowBoxHandle gtk_flow_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_bind_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle model, MentorLake.Gtk.GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_flow_box_get_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFlowBoxChildHandle gtk_flow_box_get_child_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, int idx);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFlowBoxChildHandle gtk_flow_box_get_child_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_flow_box_get_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_flow_box_get_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_flow_box_get_max_children_per_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_flow_box_get_min_children_per_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_flow_box_get_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_flow_box_get_selected_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSelectionMode gtk_flow_box_get_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_invalidate_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_invalidate_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_select_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_selected_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, MentorLake.Gtk.GtkFlowBoxForeachFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, bool single);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, uint spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_filter_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, MentorLake.Gtk.GtkFlowBoxFilterFunc filter_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_max_children_per_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, uint n_children);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_min_children_per_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, uint n_children);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, uint spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, MentorLake.Gtk.GtkSelectionMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, MentorLake.Gtk.GtkFlowBoxSortFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_unselect_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

}
