namespace MentorLake.Gtk;

public class GtkIconViewHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkScrollableHandle
{
	public static MentorLake.Gtk.GtkIconViewHandle New()
	{
		return GtkIconViewHandleExterns.gtk_icon_view_new();
	}

	public static MentorLake.Gtk.GtkIconViewHandle NewWithArea(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkIconViewHandleExterns.gtk_icon_view_new_with_area(area);
	}

	public static MentorLake.Gtk.GtkIconViewHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkIconViewHandleExterns.gtk_icon_view_new_with_model(model);
	}

}
public static class GtkIconViewHandleSignalExtensions
{

	public static IObservable<GtkIconViewHandleSignalStructs.ActivateCursorItemSignal> Signal_ActivateCursorItem(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.ActivateCursorItemSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.activate_cursor_item handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.ActivateCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-cursor-item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIconViewHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkIconViewHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.ItemActivatedSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "item-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIconViewHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkIconViewHandle self,  MentorLake.Gtk.GtkMovementStep step,  int count,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.MoveCursorSignal()
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

	public static IObservable<GtkIconViewHandleSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.SelectAllSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.select_all handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.SelectAllSignal()
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

	public static IObservable<GtkIconViewHandleSignalStructs.SelectCursorItemSignal> Signal_SelectCursorItem(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.SelectCursorItemSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.select_cursor_item handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.SelectCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select-cursor-item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIconViewHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIconViewHandleSignalStructs.ToggleCursorItemSignal> Signal_ToggleCursorItem(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.ToggleCursorItemSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.toggle_cursor_item handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.ToggleCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-cursor-item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkIconViewHandleSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.unselect_all handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.UnselectAllSignal()
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

public static class GtkIconViewHandleSignalStructs
{

public class ActivateCursorItemSignal
{
	public MentorLake.Gtk.GtkIconViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ItemActivatedSignal
{
	public MentorLake.Gtk.GtkIconViewHandle Self;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public IntPtr UserData;
}

public class MoveCursorSignal
{
	public MentorLake.Gtk.GtkIconViewHandle Self;
	public MentorLake.Gtk.GtkMovementStep Step;
	public int Count;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SelectAllSignal
{
	public MentorLake.Gtk.GtkIconViewHandle Self;
	public IntPtr UserData;
}

public class SelectCursorItemSignal
{
	public MentorLake.Gtk.GtkIconViewHandle Self;
	public IntPtr UserData;
}

public class SelectionChangedSignal
{
	public MentorLake.Gtk.GtkIconViewHandle Self;
	public IntPtr UserData;
}

public class ToggleCursorItemSignal
{
	public MentorLake.Gtk.GtkIconViewHandle Self;
	public IntPtr UserData;
}

public class UnselectAllSignal
{
	public MentorLake.Gtk.GtkIconViewHandle Self;
	public IntPtr UserData;
}
}

public static class GtkIconViewHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, MentorLake.Gtk.GtkMovementStep step, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);

}


public static class GtkIconViewHandleExtensions
{
	public static T ConvertWidgetToBinWindowCoords<T>(this T icon_view, int wx, int wy, out int bx, out int by) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_convert_widget_to_bin_window_coords(icon_view, wx, wy, out bx, out by);
		return icon_view;
	}

	public static MentorLake.cairo.cairo_surface_tHandle CreateDragIcon(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_create_drag_icon(icon_view, path);
	}

	public static T EnableModelDragDest<T>(this T icon_view, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_enable_model_drag_dest(icon_view, targets, n_targets, actions);
		return icon_view;
	}

	public static T EnableModelDragSource<T>(this T icon_view, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_enable_model_drag_source(icon_view, start_button_mask, targets, n_targets, actions);
		return icon_view;
	}

	public static bool GetActivateOnSingleClick(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_activate_on_single_click(icon_view);
	}

	public static bool GetCellRect(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkCellRendererHandle cell, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_cell_rect(icon_view, path, cell, out rect);
	}

	public static int GetColumnSpacing(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_column_spacing(icon_view);
	}

	public static int GetColumns(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_columns(icon_view);
	}

	public static bool GetCursor(this MentorLake.Gtk.GtkIconViewHandle icon_view, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_cursor(icon_view, out path, out cell);
	}

	public static bool GetDestItemAtPos(this MentorLake.Gtk.GtkIconViewHandle icon_view, int drag_x, int drag_y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkIconViewDropPosition pos)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_dest_item_at_pos(icon_view, drag_x, drag_y, out path, out pos);
	}

	public static T GetDragDestItem<T>(this T icon_view, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkIconViewDropPosition pos) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_get_drag_dest_item(icon_view, out path, out pos);
		return icon_view;
	}

	public static bool GetItemAtPos(this MentorLake.Gtk.GtkIconViewHandle icon_view, int x, int y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_at_pos(icon_view, x, y, out path, out cell);
	}

	public static int GetItemColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_column(icon_view, path);
	}

	public static MentorLake.Gtk.GtkOrientation GetItemOrientation(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_orientation(icon_view);
	}

	public static int GetItemPadding(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_padding(icon_view);
	}

	public static int GetItemRow(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_row(icon_view, path);
	}

	public static int GetItemWidth(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_width(icon_view);
	}

	public static int GetMargin(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_margin(icon_view);
	}

	public static int GetMarkupColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_markup_column(icon_view);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_model(icon_view);
	}

	public static MentorLake.Gtk.GtkTreePathHandle GetPathAtPos(this MentorLake.Gtk.GtkIconViewHandle icon_view, int x, int y)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_path_at_pos(icon_view, x, y);
	}

	public static int GetPixbufColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_pixbuf_column(icon_view);
	}

	public static bool GetReorderable(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_reorderable(icon_view);
	}

	public static int GetRowSpacing(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_row_spacing(icon_view);
	}

	public static MentorLake.GLib.GListHandle GetSelectedItems(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_selected_items(icon_view);
	}

	public static MentorLake.Gtk.GtkSelectionMode GetSelectionMode(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_selection_mode(icon_view);
	}

	public static int GetSpacing(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_spacing(icon_view);
	}

	public static int GetTextColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_text_column(icon_view);
	}

	public static int GetTooltipColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_tooltip_column(icon_view);
	}

	public static bool GetTooltipContext(this MentorLake.Gtk.GtkIconViewHandle icon_view, ref int x, ref int y, bool keyboard_tip, out MentorLake.Gtk.GtkTreeModelHandle model, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeIter iter)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_tooltip_context(icon_view, ref x, ref y, keyboard_tip, out model, out path, out iter);
	}

	public static bool GetVisibleRange(this MentorLake.Gtk.GtkIconViewHandle icon_view, out MentorLake.Gtk.GtkTreePathHandle start_path, out MentorLake.Gtk.GtkTreePathHandle end_path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_visible_range(icon_view, out start_path, out end_path);
	}

	public static T ItemActivated<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_item_activated(icon_view, path);
		return icon_view;
	}

	public static bool PathIsSelected(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_path_is_selected(icon_view, path);
	}

	public static T ScrollToPath<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path, bool use_align, float row_align, float col_align) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_scroll_to_path(icon_view, path, use_align, row_align, col_align);
		return icon_view;
	}

	public static T SelectAll<T>(this T icon_view) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_select_all(icon_view);
		return icon_view;
	}

	public static T SelectPath<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_select_path(icon_view, path);
		return icon_view;
	}

	public static T SelectedForeach<T>(this T icon_view, MentorLake.Gtk.GtkIconViewForeachFunc func, IntPtr data) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_selected_foreach(icon_view, func, data);
		return icon_view;
	}

	public static T SetActivateOnSingleClick<T>(this T icon_view, bool single) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_activate_on_single_click(icon_view, single);
		return icon_view;
	}

	public static T SetColumnSpacing<T>(this T icon_view, int column_spacing) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_column_spacing(icon_view, column_spacing);
		return icon_view;
	}

	public static T SetColumns<T>(this T icon_view, int columns) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_columns(icon_view, columns);
		return icon_view;
	}

	public static T SetCursor<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkCellRendererHandle cell, bool start_editing) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_cursor(icon_view, path, cell, start_editing);
		return icon_view;
	}

	public static T SetDragDestItem<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkIconViewDropPosition pos) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_drag_dest_item(icon_view, path, pos);
		return icon_view;
	}

	public static T SetItemOrientation<T>(this T icon_view, MentorLake.Gtk.GtkOrientation orientation) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_item_orientation(icon_view, orientation);
		return icon_view;
	}

	public static T SetItemPadding<T>(this T icon_view, int item_padding) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_item_padding(icon_view, item_padding);
		return icon_view;
	}

	public static T SetItemWidth<T>(this T icon_view, int item_width) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_item_width(icon_view, item_width);
		return icon_view;
	}

	public static T SetMargin<T>(this T icon_view, int margin) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_margin(icon_view, margin);
		return icon_view;
	}

	public static T SetMarkupColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_markup_column(icon_view, column);
		return icon_view;
	}

	public static T SetModel<T>(this T icon_view, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_model(icon_view, model);
		return icon_view;
	}

	public static T SetPixbufColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_pixbuf_column(icon_view, column);
		return icon_view;
	}

	public static T SetReorderable<T>(this T icon_view, bool reorderable) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_reorderable(icon_view, reorderable);
		return icon_view;
	}

	public static T SetRowSpacing<T>(this T icon_view, int row_spacing) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_row_spacing(icon_view, row_spacing);
		return icon_view;
	}

	public static T SetSelectionMode<T>(this T icon_view, MentorLake.Gtk.GtkSelectionMode mode) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_selection_mode(icon_view, mode);
		return icon_view;
	}

	public static T SetSpacing<T>(this T icon_view, int spacing) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_spacing(icon_view, spacing);
		return icon_view;
	}

	public static T SetTextColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_text_column(icon_view, column);
		return icon_view;
	}

	public static T SetTooltipCell<T>(this T icon_view, MentorLake.Gtk.GtkTooltipHandle tooltip, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkCellRendererHandle cell) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_tooltip_cell(icon_view, tooltip, path, cell);
		return icon_view;
	}

	public static T SetTooltipColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_tooltip_column(icon_view, column);
		return icon_view;
	}

	public static T SetTooltipItem<T>(this T icon_view, MentorLake.Gtk.GtkTooltipHandle tooltip, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_tooltip_item(icon_view, tooltip, path);
		return icon_view;
	}

	public static T UnselectAll<T>(this T icon_view) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_unselect_all(icon_view);
		return icon_view;
	}

	public static T UnselectPath<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_unselect_path(icon_view, path);
		return icon_view;
	}

	public static T UnsetModelDragDest<T>(this T icon_view) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_unset_model_drag_dest(icon_view);
		return icon_view;
	}

	public static T UnsetModelDragSource<T>(this T icon_view) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_unset_model_drag_source(icon_view);
		return icon_view;
	}

}

internal class GtkIconViewHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))]
	internal static extern MentorLake.Gtk.GtkIconViewHandle gtk_icon_view_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))]
	internal static extern MentorLake.Gtk.GtkIconViewHandle gtk_icon_view_new_with_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))]
	internal static extern MentorLake.Gtk.GtkIconViewHandle gtk_icon_view_new_with_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_convert_widget_to_bin_window_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int wx, int wy, out int bx, out int by);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_icon_view_create_drag_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_enable_model_drag_dest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_enable_model_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_cell_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] out MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_dest_item_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int drag_x, int drag_y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkIconViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_get_drag_dest_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkIconViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_item_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] out MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_item_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_icon_view_get_item_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_item_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_item_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_item_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_markup_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_icon_view_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_icon_view_get_path_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_pixbuf_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_icon_view_get_selected_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSelectionMode gtk_icon_view_get_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_tooltip_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_tooltip_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, ref int x, ref int y, bool keyboard_tip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] out MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_visible_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle start_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle end_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_path_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_scroll_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, bool use_align, float row_align, float col_align);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_select_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_selected_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkIconViewForeachFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, bool single);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column_spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int columns);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool start_editing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_drag_dest_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkIconViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_item_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_item_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int item_padding);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_item_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int item_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_markup_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_pixbuf_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, bool reorderable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int row_spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkSelectionMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_tooltip_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_tooltip_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_tooltip_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_unselect_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_unset_model_drag_dest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_unset_model_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

}
