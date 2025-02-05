namespace MentorLake.Gtk3.Gtk3;

public class GtkIconViewHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkScrollableHandle
{
	public static GtkIconViewHandle New()
	{
		return GtkIconViewExterns.gtk_icon_view_new();
	}

	public static GtkIconViewHandle NewWithArea(GtkCellAreaHandle area)
	{
		return GtkIconViewExterns.gtk_icon_view_new_with_area(area);
	}

	public static GtkIconViewHandle NewWithModel(GtkTreeModelHandle model)
	{
		return GtkIconViewExterns.gtk_icon_view_new_with_model(model);
	}

}

public static class GtkIconViewSignalExtensions
{

	public static IObservable<GtkIconViewSignalStructs.ActivateCursorItemSignal> Signal_ActivateCursorItem(this GtkIconViewHandle instance)
	{
		return Observable.Create((IObserver<GtkIconViewSignalStructs.ActivateCursorItemSignal> obs) =>
		{
			GtkIconViewSignalDelegates.activate_cursor_item handler = (GtkIconViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewSignalStructs.ActivateCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_cursor_item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIconViewSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkIconViewHandle instance)
	{
		return Observable.Create((IObserver<GtkIconViewSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkIconViewSignalDelegates.item_activated handler = (GtkIconViewHandle self, GtkTreePathHandle path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewSignalStructs.ItemActivatedSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "item_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIconViewSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkIconViewHandle instance)
	{
		return Observable.Create((IObserver<GtkIconViewSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkIconViewSignalDelegates.move_cursor handler = (GtkIconViewHandle self, GtkMovementStep step, int count, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewSignalStructs.MoveCursorSignal()
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

	public static IObservable<GtkIconViewSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkIconViewHandle instance)
	{
		return Observable.Create((IObserver<GtkIconViewSignalStructs.SelectAllSignal> obs) =>
		{
			GtkIconViewSignalDelegates.select_all handler = (GtkIconViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewSignalStructs.SelectAllSignal()
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

	public static IObservable<GtkIconViewSignalStructs.SelectCursorItemSignal> Signal_SelectCursorItem(this GtkIconViewHandle instance)
	{
		return Observable.Create((IObserver<GtkIconViewSignalStructs.SelectCursorItemSignal> obs) =>
		{
			GtkIconViewSignalDelegates.select_cursor_item handler = (GtkIconViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewSignalStructs.SelectCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "select_cursor_item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIconViewSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkIconViewHandle instance)
	{
		return Observable.Create((IObserver<GtkIconViewSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkIconViewSignalDelegates.selection_changed handler = (GtkIconViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selection_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIconViewSignalStructs.ToggleCursorItemSignal> Signal_ToggleCursorItem(this GtkIconViewHandle instance)
	{
		return Observable.Create((IObserver<GtkIconViewSignalStructs.ToggleCursorItemSignal> obs) =>
		{
			GtkIconViewSignalDelegates.toggle_cursor_item handler = (GtkIconViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewSignalStructs.ToggleCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_cursor_item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkIconViewSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkIconViewHandle instance)
	{
		return Observable.Create((IObserver<GtkIconViewSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkIconViewSignalDelegates.unselect_all handler = (GtkIconViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewSignalStructs.UnselectAllSignal()
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

public static class GtkIconViewSignalStructs
{

public struct ActivateCursorItemSignal
{
	public GtkIconViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ItemActivatedSignal
{
	public GtkIconViewHandle Self;
	public GtkTreePathHandle Path;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkIconViewHandle Self;
	public GtkMovementStep Step;
	public int Count;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectAllSignal
{
	public GtkIconViewHandle Self;
	public IntPtr UserData;
}

public struct SelectCursorItemSignal
{
	public GtkIconViewHandle Self;
	public IntPtr UserData;
}

public struct SelectionChangedSignal
{
	public GtkIconViewHandle Self;
	public IntPtr UserData;
}

public struct ToggleCursorItemSignal
{
	public GtkIconViewHandle Self;
	public IntPtr UserData;
}

public struct UnselectAllSignal
{
	public GtkIconViewHandle Self;
	public IntPtr UserData;
}
}

public static class GtkIconViewSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconViewHandle>))] GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconViewHandle>))] GtkIconViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreePathHandle>))] GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconViewHandle>))] GtkIconViewHandle self, GtkMovementStep step, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconViewHandle>))] GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconViewHandle>))] GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconViewHandle>))] GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconViewHandle>))] GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconViewHandle>))] GtkIconViewHandle self, IntPtr user_data);

}


public static class GtkIconViewHandleExtensions
{
	public static T ConvertWidgetToBinWindowCoords<T>(this T icon_view, int wx, int wy, out int bx, out int by) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_convert_widget_to_bin_window_coords(icon_view, wx, wy, out bx, out by);
		return icon_view;
	}

	public static cairo_surface_tHandle CreateDragIcon(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		return GtkIconViewExterns.gtk_icon_view_create_drag_icon(icon_view, path);
	}

	public static T EnableModelDragDest<T>(this T icon_view, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_enable_model_drag_dest(icon_view, targets, n_targets, actions);
		return icon_view;
	}

	public static T EnableModelDragSource<T>(this T icon_view, GdkModifierType start_button_mask, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_enable_model_drag_source(icon_view, start_button_mask, targets, n_targets, actions);
		return icon_view;
	}

	public static bool GetActivateOnSingleClick(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_activate_on_single_click(icon_view);
	}

	public static bool GetCellRect(this GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkCellRendererHandle cell, out GdkRectangle rect)
	{
		return GtkIconViewExterns.gtk_icon_view_get_cell_rect(icon_view, path, cell, out rect);
	}

	public static int GetColumnSpacing(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_column_spacing(icon_view);
	}

	public static int GetColumns(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_columns(icon_view);
	}

	public static bool GetCursor(this GtkIconViewHandle icon_view, out GtkTreePathHandle path, out GtkCellRendererHandle cell)
	{
		return GtkIconViewExterns.gtk_icon_view_get_cursor(icon_view, out path, out cell);
	}

	public static bool GetDestItemAtPos(this GtkIconViewHandle icon_view, int drag_x, int drag_y, out GtkTreePathHandle path, out GtkIconViewDropPosition pos)
	{
		return GtkIconViewExterns.gtk_icon_view_get_dest_item_at_pos(icon_view, drag_x, drag_y, out path, out pos);
	}

	public static T GetDragDestItem<T>(this T icon_view, out GtkTreePathHandle path, out GtkIconViewDropPosition pos) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_get_drag_dest_item(icon_view, out path, out pos);
		return icon_view;
	}

	public static bool GetItemAtPos(this GtkIconViewHandle icon_view, int x, int y, out GtkTreePathHandle path, out GtkCellRendererHandle cell)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_at_pos(icon_view, x, y, out path, out cell);
	}

	public static int GetItemColumn(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_column(icon_view, path);
	}

	public static GtkOrientation GetItemOrientation(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_orientation(icon_view);
	}

	public static int GetItemPadding(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_padding(icon_view);
	}

	public static int GetItemRow(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_row(icon_view, path);
	}

	public static int GetItemWidth(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_item_width(icon_view);
	}

	public static int GetMargin(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_margin(icon_view);
	}

	public static int GetMarkupColumn(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_markup_column(icon_view);
	}

	public static GtkTreeModelHandle GetModel(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_model(icon_view);
	}

	public static GtkTreePathHandle GetPathAtPos(this GtkIconViewHandle icon_view, int x, int y)
	{
		return GtkIconViewExterns.gtk_icon_view_get_path_at_pos(icon_view, x, y);
	}

	public static int GetPixbufColumn(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_pixbuf_column(icon_view);
	}

	public static bool GetReorderable(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_reorderable(icon_view);
	}

	public static int GetRowSpacing(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_row_spacing(icon_view);
	}

	public static GListHandle GetSelectedItems(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_selected_items(icon_view);
	}

	public static GtkSelectionMode GetSelectionMode(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_selection_mode(icon_view);
	}

	public static int GetSpacing(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_spacing(icon_view);
	}

	public static int GetTextColumn(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_text_column(icon_view);
	}

	public static int GetTooltipColumn(this GtkIconViewHandle icon_view)
	{
		return GtkIconViewExterns.gtk_icon_view_get_tooltip_column(icon_view);
	}

	public static bool GetTooltipContext(this GtkIconViewHandle icon_view, ref int x, ref int y, bool keyboard_tip, out GtkTreeModelHandle model, out GtkTreePathHandle path, out GtkTreeIter iter)
	{
		return GtkIconViewExterns.gtk_icon_view_get_tooltip_context(icon_view, ref x, ref y, keyboard_tip, out model, out path, out iter);
	}

	public static bool GetVisibleRange(this GtkIconViewHandle icon_view, out GtkTreePathHandle start_path, out GtkTreePathHandle end_path)
	{
		return GtkIconViewExterns.gtk_icon_view_get_visible_range(icon_view, out start_path, out end_path);
	}

	public static T ItemActivated<T>(this T icon_view, GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_item_activated(icon_view, path);
		return icon_view;
	}

	public static bool PathIsSelected(this GtkIconViewHandle icon_view, GtkTreePathHandle path)
	{
		return GtkIconViewExterns.gtk_icon_view_path_is_selected(icon_view, path);
	}

	public static T ScrollToPath<T>(this T icon_view, GtkTreePathHandle path, bool use_align, float row_align, float col_align) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_scroll_to_path(icon_view, path, use_align, row_align, col_align);
		return icon_view;
	}

	public static T SelectAll<T>(this T icon_view) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_select_all(icon_view);
		return icon_view;
	}

	public static T SelectPath<T>(this T icon_view, GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_select_path(icon_view, path);
		return icon_view;
	}

	public static T SelectedForeach<T>(this T icon_view, GtkIconViewForeachFunc func, IntPtr data) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_selected_foreach(icon_view, func, data);
		return icon_view;
	}

	public static T SetActivateOnSingleClick<T>(this T icon_view, bool single) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_activate_on_single_click(icon_view, single);
		return icon_view;
	}

	public static T SetColumnSpacing<T>(this T icon_view, int column_spacing) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_column_spacing(icon_view, column_spacing);
		return icon_view;
	}

	public static T SetColumns<T>(this T icon_view, int columns) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_columns(icon_view, columns);
		return icon_view;
	}

	public static T SetCursor<T>(this T icon_view, GtkTreePathHandle path, GtkCellRendererHandle cell, bool start_editing) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_cursor(icon_view, path, cell, start_editing);
		return icon_view;
	}

	public static T SetDragDestItem<T>(this T icon_view, GtkTreePathHandle path, GtkIconViewDropPosition pos) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_drag_dest_item(icon_view, path, pos);
		return icon_view;
	}

	public static T SetItemOrientation<T>(this T icon_view, GtkOrientation orientation) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_item_orientation(icon_view, orientation);
		return icon_view;
	}

	public static T SetItemPadding<T>(this T icon_view, int item_padding) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_item_padding(icon_view, item_padding);
		return icon_view;
	}

	public static T SetItemWidth<T>(this T icon_view, int item_width) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_item_width(icon_view, item_width);
		return icon_view;
	}

	public static T SetMargin<T>(this T icon_view, int margin) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_margin(icon_view, margin);
		return icon_view;
	}

	public static T SetMarkupColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_markup_column(icon_view, column);
		return icon_view;
	}

	public static T SetModel<T>(this T icon_view, GtkTreeModelHandle model) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_model(icon_view, model);
		return icon_view;
	}

	public static T SetPixbufColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_pixbuf_column(icon_view, column);
		return icon_view;
	}

	public static T SetReorderable<T>(this T icon_view, bool reorderable) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_reorderable(icon_view, reorderable);
		return icon_view;
	}

	public static T SetRowSpacing<T>(this T icon_view, int row_spacing) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_row_spacing(icon_view, row_spacing);
		return icon_view;
	}

	public static T SetSelectionMode<T>(this T icon_view, GtkSelectionMode mode) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_selection_mode(icon_view, mode);
		return icon_view;
	}

	public static T SetSpacing<T>(this T icon_view, int spacing) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_spacing(icon_view, spacing);
		return icon_view;
	}

	public static T SetTextColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_text_column(icon_view, column);
		return icon_view;
	}

	public static T SetTooltipCell<T>(this T icon_view, GtkTooltipHandle tooltip, GtkTreePathHandle path, GtkCellRendererHandle cell) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_tooltip_cell(icon_view, tooltip, path, cell);
		return icon_view;
	}

	public static T SetTooltipColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_tooltip_column(icon_view, column);
		return icon_view;
	}

	public static T SetTooltipItem<T>(this T icon_view, GtkTooltipHandle tooltip, GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_set_tooltip_item(icon_view, tooltip, path);
		return icon_view;
	}

	public static T UnselectAll<T>(this T icon_view) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_unselect_all(icon_view);
		return icon_view;
	}

	public static T UnselectPath<T>(this T icon_view, GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_unselect_path(icon_view, path);
		return icon_view;
	}

	public static T UnsetModelDragDest<T>(this T icon_view) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_unset_model_drag_dest(icon_view);
		return icon_view;
	}

	public static T UnsetModelDragSource<T>(this T icon_view) where T : GtkIconViewHandle
	{
		GtkIconViewExterns.gtk_icon_view_unset_model_drag_source(icon_view);
		return icon_view;
	}

}

internal class GtkIconViewExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconViewHandle gtk_icon_view_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconViewHandle gtk_icon_view_new_with_area(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconViewHandle gtk_icon_view_new_with_model(GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_convert_widget_to_bin_window_coords(GtkIconViewHandle icon_view, int wx, int wy, out int bx, out int by);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_surface_tHandle gtk_icon_view_create_drag_icon(GtkIconViewHandle icon_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_enable_model_drag_dest(GtkIconViewHandle icon_view, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_enable_model_drag_source(GtkIconViewHandle icon_view, GdkModifierType start_button_mask, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_get_activate_on_single_click(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_get_cell_rect(GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkCellRendererHandle cell, out GdkRectangle rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_column_spacing(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_columns(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_get_cursor(GtkIconViewHandle icon_view, out GtkTreePathHandle path, out GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_get_dest_item_at_pos(GtkIconViewHandle icon_view, int drag_x, int drag_y, out GtkTreePathHandle path, out GtkIconViewDropPosition pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_get_drag_dest_item(GtkIconViewHandle icon_view, out GtkTreePathHandle path, out GtkIconViewDropPosition pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_get_item_at_pos(GtkIconViewHandle icon_view, int x, int y, out GtkTreePathHandle path, out GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_item_column(GtkIconViewHandle icon_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOrientation gtk_icon_view_get_item_orientation(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_item_padding(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_item_row(GtkIconViewHandle icon_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_item_width(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_margin(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_markup_column(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelHandle gtk_icon_view_get_model(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreePathHandle gtk_icon_view_get_path_at_pos(GtkIconViewHandle icon_view, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_pixbuf_column(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_get_reorderable(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_row_spacing(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_icon_view_get_selected_items(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSelectionMode gtk_icon_view_get_selection_mode(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_spacing(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_text_column(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_icon_view_get_tooltip_column(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_get_tooltip_context(GtkIconViewHandle icon_view, ref int x, ref int y, bool keyboard_tip, out GtkTreeModelHandle model, out GtkTreePathHandle path, out GtkTreeIter iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_get_visible_range(GtkIconViewHandle icon_view, out GtkTreePathHandle start_path, out GtkTreePathHandle end_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_item_activated(GtkIconViewHandle icon_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_view_path_is_selected(GtkIconViewHandle icon_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_scroll_to_path(GtkIconViewHandle icon_view, GtkTreePathHandle path, bool use_align, float row_align, float col_align);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_select_all(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_select_path(GtkIconViewHandle icon_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_selected_foreach(GtkIconViewHandle icon_view, GtkIconViewForeachFunc func, IntPtr data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_activate_on_single_click(GtkIconViewHandle icon_view, bool single);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_column_spacing(GtkIconViewHandle icon_view, int column_spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_columns(GtkIconViewHandle icon_view, int columns);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_cursor(GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkCellRendererHandle cell, bool start_editing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_drag_dest_item(GtkIconViewHandle icon_view, GtkTreePathHandle path, GtkIconViewDropPosition pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_item_orientation(GtkIconViewHandle icon_view, GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_item_padding(GtkIconViewHandle icon_view, int item_padding);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_item_width(GtkIconViewHandle icon_view, int item_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_margin(GtkIconViewHandle icon_view, int margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_markup_column(GtkIconViewHandle icon_view, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_model(GtkIconViewHandle icon_view, GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_pixbuf_column(GtkIconViewHandle icon_view, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_reorderable(GtkIconViewHandle icon_view, bool reorderable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_row_spacing(GtkIconViewHandle icon_view, int row_spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_selection_mode(GtkIconViewHandle icon_view, GtkSelectionMode mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_spacing(GtkIconViewHandle icon_view, int spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_text_column(GtkIconViewHandle icon_view, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_tooltip_cell(GtkIconViewHandle icon_view, GtkTooltipHandle tooltip, GtkTreePathHandle path, GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_tooltip_column(GtkIconViewHandle icon_view, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_set_tooltip_item(GtkIconViewHandle icon_view, GtkTooltipHandle tooltip, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_unselect_all(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_unselect_path(GtkIconViewHandle icon_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_unset_model_drag_dest(GtkIconViewHandle icon_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_view_unset_model_drag_source(GtkIconViewHandle icon_view);

}
