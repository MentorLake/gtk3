namespace MentorLake.Gtk;

public class GtkListBoxHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkListBoxHandle New()
	{
		return GtkListBoxHandleExterns.gtk_list_box_new();
	}

}
public static class GtkListBoxHandleSignalExtensions
{

	public static IObservable<GtkListBoxHandleSignalStructs.ActivateCursorRowSignal> Signal_ActivateCursorRow(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.ActivateCursorRowSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.activate_cursor_row handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.ActivateCursorRowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-cursor-row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkListBoxHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkListBoxHandle self,  MentorLake.Gtk.GtkMovementStep @object,  int p0,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.MoveCursorSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
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

	public static IObservable<GtkListBoxHandleSignalStructs.RowActivatedSignal> Signal_RowActivated(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.RowActivatedSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.row_activated handler = ( MentorLake.Gtk.GtkListBoxHandle self,  MentorLake.Gtk.GtkListBoxRowHandle row,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.RowActivatedSignal()
				{
					Self = self, Row = row, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkListBoxHandleSignalStructs.RowSelectedSignal> Signal_RowSelected(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.RowSelectedSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.row_selected handler = ( MentorLake.Gtk.GtkListBoxHandle self,  MentorLake.Gtk.GtkListBoxRowHandle row,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.RowSelectedSignal()
				{
					Self = self, Row = row, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkListBoxHandleSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.SelectAllSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.select_all handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.SelectAllSignal()
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

	public static IObservable<GtkListBoxHandleSignalStructs.SelectedRowsChangedSignal> Signal_SelectedRowsChanged(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.SelectedRowsChangedSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.selected_rows_changed handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.SelectedRowsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selected-rows-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkListBoxHandleSignalStructs.ToggleCursorRowSignal> Signal_ToggleCursorRow(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.ToggleCursorRowSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.toggle_cursor_row handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.ToggleCursorRowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-cursor-row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkListBoxHandleSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.unselect_all handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.UnselectAllSignal()
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

public static class GtkListBoxHandleSignalStructs
{

public struct ActivateCursorRowSignal
{
	public MentorLake.Gtk.GtkListBoxHandle Self;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public MentorLake.Gtk.GtkListBoxHandle Self;
	public MentorLake.Gtk.GtkMovementStep Object;
	public int P0;
	public IntPtr UserData;
}

public struct RowActivatedSignal
{
	public MentorLake.Gtk.GtkListBoxHandle Self;
	public MentorLake.Gtk.GtkListBoxRowHandle Row;
	public IntPtr UserData;
}

public struct RowSelectedSignal
{
	public MentorLake.Gtk.GtkListBoxHandle Self;
	public MentorLake.Gtk.GtkListBoxRowHandle Row;
	public IntPtr UserData;
}

public struct SelectAllSignal
{
	public MentorLake.Gtk.GtkListBoxHandle Self;
	public IntPtr UserData;
}

public struct SelectedRowsChangedSignal
{
	public MentorLake.Gtk.GtkListBoxHandle Self;
	public IntPtr UserData;
}

public struct ToggleCursorRowSignal
{
	public MentorLake.Gtk.GtkListBoxHandle Self;
	public IntPtr UserData;
}

public struct UnselectAllSignal
{
	public MentorLake.Gtk.GtkListBoxHandle Self;
	public IntPtr UserData;
}
}

public static class GtkListBoxHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, MentorLake.Gtk.GtkMovementStep @object, int p0, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selected_rows_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);

}


public static class GtkListBoxHandleExtensions
{
	public static T BindModel<T>(this T box, MentorLake.Gio.GListModelHandle model, MentorLake.Gtk.GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

	public static T DragHighlightRow<T>(this T box, MentorLake.Gtk.GtkListBoxRowHandle row) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_drag_highlight_row(box, row);
		return box;
	}

	public static T DragUnhighlightRow<T>(this T box) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_drag_unhighlight_row(box);
		return box;
	}

	public static bool GetActivateOnSingleClick(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		return GtkListBoxHandleExterns.gtk_list_box_get_activate_on_single_click(box);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetAdjustment(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		return GtkListBoxHandleExterns.gtk_list_box_get_adjustment(box);
	}

	public static MentorLake.Gtk.GtkListBoxRowHandle GetRowAtIndex(this MentorLake.Gtk.GtkListBoxHandle box, int index_)
	{
		return GtkListBoxHandleExterns.gtk_list_box_get_row_at_index(box, index_);
	}

	public static MentorLake.Gtk.GtkListBoxRowHandle GetRowAtY(this MentorLake.Gtk.GtkListBoxHandle box, int y)
	{
		return GtkListBoxHandleExterns.gtk_list_box_get_row_at_y(box, y);
	}

	public static MentorLake.Gtk.GtkListBoxRowHandle GetSelectedRow(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		return GtkListBoxHandleExterns.gtk_list_box_get_selected_row(box);
	}

	public static MentorLake.GLib.GListHandle GetSelectedRows(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		return GtkListBoxHandleExterns.gtk_list_box_get_selected_rows(box);
	}

	public static MentorLake.Gtk.GtkSelectionMode GetSelectionMode(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		return GtkListBoxHandleExterns.gtk_list_box_get_selection_mode(box);
	}

	public static T Insert<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_insert(box, child, position);
		return box;
	}

	public static T InvalidateFilter<T>(this T box) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_invalidate_filter(box);
		return box;
	}

	public static T InvalidateHeaders<T>(this T box) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_invalidate_headers(box);
		return box;
	}

	public static T InvalidateSort<T>(this T box) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_invalidate_sort(box);
		return box;
	}

	public static T Prepend<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_prepend(box, child);
		return box;
	}

	public static T SelectAll<T>(this T box) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_select_all(box);
		return box;
	}

	public static T SelectRow<T>(this T box, MentorLake.Gtk.GtkListBoxRowHandle row) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_select_row(box, row);
		return box;
	}

	public static T SelectedForeach<T>(this T box, MentorLake.Gtk.GtkListBoxForeachFunc func, IntPtr data) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_selected_foreach(box, func, data);
		return box;
	}

	public static T SetActivateOnSingleClick<T>(this T box, bool single) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_set_activate_on_single_click(box, single);
		return box;
	}

	public static T SetAdjustment<T>(this T box, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_set_adjustment(box, adjustment);
		return box;
	}

	public static T SetFilterFunc<T>(this T box, MentorLake.Gtk.GtkListBoxFilterFunc filter_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

	public static T SetHeaderFunc<T>(this T box, MentorLake.Gtk.GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_set_header_func(box, update_header, user_data, destroy);
		return box;
	}

	public static T SetPlaceholder<T>(this T box, MentorLake.Gtk.GtkWidgetHandle placeholder) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_set_placeholder(box, placeholder);
		return box;
	}

	public static T SetSelectionMode<T>(this T box, MentorLake.Gtk.GtkSelectionMode mode) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_set_selection_mode(box, mode);
		return box;
	}

	public static T SetSortFunc<T>(this T box, MentorLake.Gtk.GtkListBoxSortFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

	public static T UnselectAll<T>(this T box) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_unselect_all(box);
		return box;
	}

	public static T UnselectRow<T>(this T box, MentorLake.Gtk.GtkListBoxRowHandle row) where T : GtkListBoxHandle
	{
		GtkListBoxHandleExterns.gtk_list_box_unselect_row(box, row);
		return box;
	}

}

internal class GtkListBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkListBoxHandle gtk_list_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_bind_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle model, MentorLake.Gtk.GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_drag_highlight_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_drag_unhighlight_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_box_get_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_list_box_get_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkListBoxRowHandle gtk_list_box_get_row_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkListBoxRowHandle gtk_list_box_get_row_at_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkListBoxRowHandle gtk_list_box_get_selected_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_list_box_get_selected_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSelectionMode gtk_list_box_get_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_invalidate_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_invalidate_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_invalidate_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_select_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_selected_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkListBoxForeachFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, bool single);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_filter_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkListBoxFilterFunc filter_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_header_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_placeholder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle placeholder);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkSelectionMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkListBoxSortFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_unselect_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

}
