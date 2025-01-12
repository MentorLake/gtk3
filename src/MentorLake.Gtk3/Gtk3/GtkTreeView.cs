namespace MentorLake.Gtk3.Gtk3;

public class GtkTreeViewHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
	public static GtkTreeViewHandle New()
	{
		return GtkTreeViewExterns.gtk_tree_view_new();
	}

	public static GtkTreeViewHandle NewWithModel(GtkTreeModelHandle model)
	{
		return GtkTreeViewExterns.gtk_tree_view_new_with_model(model);
	}

}

public static class GtkTreeViewSignalExtensions
{

	public static IObservable<GtkTreeViewSignalStructs.ColumnsChangedSignal> Signal_ColumnsChanged(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.ColumnsChangedSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.columns_changed handler = (GtkTreeViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.ColumnsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "columns_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.CursorChangedSignal> Signal_CursorChanged(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.CursorChangedSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.cursor_changed handler = (GtkTreeViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.CursorChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cursor_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.ExpandCollapseCursorRowSignal> Signal_ExpandCollapseCursorRow(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.ExpandCollapseCursorRowSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.expand_collapse_cursor_row handler = (GtkTreeViewHandle self, bool @object, bool p0, bool p1, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.ExpandCollapseCursorRowSignal()
				{
					Self = self, Object = @object, P0 = p0, P1 = p1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "expand_collapse_cursor_row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.move_cursor handler = (GtkTreeViewHandle self, GtkMovementStep step, int direction, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Direction = direction, UserData = user_data
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

	public static IObservable<GtkTreeViewSignalStructs.RowActivatedSignal> Signal_RowActivated(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.RowActivatedSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.row_activated handler = (GtkTreeViewHandle self, GtkTreePathHandle path, GtkTreeViewColumnHandle column, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.RowActivatedSignal()
				{
					Self = self, Path = path, Column = column, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "row_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.RowCollapsedSignal> Signal_RowCollapsed(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.RowCollapsedSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.row_collapsed handler = (GtkTreeViewHandle self, GtkTreeIterHandle iter, GtkTreePathHandle path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.RowCollapsedSignal()
				{
					Self = self, Iter = iter, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "row_collapsed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.RowExpandedSignal> Signal_RowExpanded(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.RowExpandedSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.row_expanded handler = (GtkTreeViewHandle self, GtkTreeIterHandle iter, GtkTreePathHandle path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.RowExpandedSignal()
				{
					Self = self, Iter = iter, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "row_expanded", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.SelectAllSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.select_all handler = (GtkTreeViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.SelectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "select_all", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.SelectCursorParentSignal> Signal_SelectCursorParent(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.SelectCursorParentSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.select_cursor_parent handler = (GtkTreeViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.SelectCursorParentSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "select_cursor_parent", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.SelectCursorRowSignal> Signal_SelectCursorRow(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.SelectCursorRowSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.select_cursor_row handler = (GtkTreeViewHandle self, bool @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.SelectCursorRowSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "select_cursor_row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.StartInteractiveSearchSignal> Signal_StartInteractiveSearch(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.StartInteractiveSearchSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.start_interactive_search handler = (GtkTreeViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.StartInteractiveSearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "start_interactive_search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.TestCollapseRowSignal> Signal_TestCollapseRow(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.TestCollapseRowSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.test_collapse_row handler = (GtkTreeViewHandle self, GtkTreeIterHandle iter, GtkTreePathHandle path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.TestCollapseRowSignal()
				{
					Self = self, Iter = iter, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "test_collapse_row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.TestExpandRowSignal> Signal_TestExpandRow(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.TestExpandRowSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.test_expand_row handler = (GtkTreeViewHandle self, GtkTreeIterHandle iter, GtkTreePathHandle path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.TestExpandRowSignal()
				{
					Self = self, Iter = iter, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "test_expand_row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.ToggleCursorRowSignal> Signal_ToggleCursorRow(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.ToggleCursorRowSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.toggle_cursor_row handler = (GtkTreeViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.ToggleCursorRowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_cursor_row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTreeViewSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkTreeViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkTreeViewSignalDelegates.unselect_all handler = (GtkTreeViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewSignalStructs.UnselectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
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

public static class GtkTreeViewSignalStructs
{

public struct ColumnsChangedSignal
{
	public GtkTreeViewHandle Self;
	public IntPtr UserData;
}

public struct CursorChangedSignal
{
	public GtkTreeViewHandle Self;
	public IntPtr UserData;
}

public struct ExpandCollapseCursorRowSignal
{
	public GtkTreeViewHandle Self;
	public bool Object;
	public bool P0;
	public bool P1;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MoveCursorSignal
{
	public GtkTreeViewHandle Self;
	public GtkMovementStep Step;
	public int Direction;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct RowActivatedSignal
{
	public GtkTreeViewHandle Self;
	public GtkTreePathHandle Path;
	public GtkTreeViewColumnHandle Column;
	public IntPtr UserData;
}

public struct RowCollapsedSignal
{
	public GtkTreeViewHandle Self;
	public GtkTreeIterHandle Iter;
	public GtkTreePathHandle Path;
	public IntPtr UserData;
}

public struct RowExpandedSignal
{
	public GtkTreeViewHandle Self;
	public GtkTreeIterHandle Iter;
	public GtkTreePathHandle Path;
	public IntPtr UserData;
}

public struct SelectAllSignal
{
	public GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectCursorParentSignal
{
	public GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectCursorRowSignal
{
	public GtkTreeViewHandle Self;
	public bool Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct StartInteractiveSearchSignal
{
	public GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct TestCollapseRowSignal
{
	public GtkTreeViewHandle Self;
	public GtkTreeIterHandle Iter;
	public GtkTreePathHandle Path;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct TestExpandRowSignal
{
	public GtkTreeViewHandle Self;
	public GtkTreeIterHandle Iter;
	public GtkTreePathHandle Path;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ToggleCursorRowSignal
{
	public GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct UnselectAllSignal
{
	public GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkTreeViewSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void columns_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cursor_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool expand_collapse_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, bool @object, bool p0, bool p1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, GtkMovementStep step, int direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreePathHandle>))] GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewColumnHandle>))] GtkTreeViewColumnHandle column, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_collapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreePathHandle>))] GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_expanded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreePathHandle>))] GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_cursor_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, bool @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool start_interactive_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool test_collapse_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreePathHandle>))] GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool test_expand_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreePathHandle>))] GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool toggle_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewHandle>))] GtkTreeViewHandle self, IntPtr user_data);

}


public static class GtkTreeViewHandleExtensions
{
	public static int AppendColumn(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column)
	{
		return GtkTreeViewExterns.gtk_tree_view_append_column(tree_view, column);
	}

	public static T CollapseAll<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_collapse_all(tree_view);
		return tree_view;
	}

	public static bool CollapseRow(this GtkTreeViewHandle tree_view, GtkTreePathHandle path)
	{
		return GtkTreeViewExterns.gtk_tree_view_collapse_row(tree_view, path);
	}

	public static T ColumnsAutosize<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_columns_autosize(tree_view);
		return tree_view;
	}

	public static T ConvertBinWindowToTreeCoords<T>(this T tree_view, int bx, int by, out int tx, out int ty) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_convert_bin_window_to_tree_coords(tree_view, bx, by, out tx, out ty);
		return tree_view;
	}

	public static T ConvertBinWindowToWidgetCoords<T>(this T tree_view, int bx, int by, out int wx, out int wy) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_convert_bin_window_to_widget_coords(tree_view, bx, by, out wx, out wy);
		return tree_view;
	}

	public static T ConvertTreeToBinWindowCoords<T>(this T tree_view, int tx, int ty, out int bx, out int by) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_convert_tree_to_bin_window_coords(tree_view, tx, ty, out bx, out by);
		return tree_view;
	}

	public static T ConvertTreeToWidgetCoords<T>(this T tree_view, int tx, int ty, out int wx, out int wy) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_convert_tree_to_widget_coords(tree_view, tx, ty, out wx, out wy);
		return tree_view;
	}

	public static T ConvertWidgetToBinWindowCoords<T>(this T tree_view, int wx, int wy, out int bx, out int by) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_convert_widget_to_bin_window_coords(tree_view, wx, wy, out bx, out by);
		return tree_view;
	}

	public static T ConvertWidgetToTreeCoords<T>(this T tree_view, int wx, int wy, out int tx, out int ty) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_convert_widget_to_tree_coords(tree_view, wx, wy, out tx, out ty);
		return tree_view;
	}

	public static cairo_surface_tHandle CreateRowDragIcon(this GtkTreeViewHandle tree_view, GtkTreePathHandle path)
	{
		return GtkTreeViewExterns.gtk_tree_view_create_row_drag_icon(tree_view, path);
	}

	public static T EnableModelDragDest<T>(this T tree_view, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_enable_model_drag_dest(tree_view, targets, n_targets, actions);
		return tree_view;
	}

	public static T EnableModelDragSource<T>(this T tree_view, GdkModifierType start_button_mask, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_enable_model_drag_source(tree_view, start_button_mask, targets, n_targets, actions);
		return tree_view;
	}

	public static T ExpandAll<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_expand_all(tree_view);
		return tree_view;
	}

	public static bool ExpandRow(this GtkTreeViewHandle tree_view, GtkTreePathHandle path, bool open_all)
	{
		return GtkTreeViewExterns.gtk_tree_view_expand_row(tree_view, path, open_all);
	}

	public static T ExpandToPath<T>(this T tree_view, GtkTreePathHandle path) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_expand_to_path(tree_view, path);
		return tree_view;
	}

	public static bool GetActivateOnSingleClick(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_activate_on_single_click(tree_view);
	}

	public static T GetBackgroundArea<T>(this T tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, out GdkRectangle rect) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_get_background_area(tree_view, path, column, out rect);
		return tree_view;
	}

	public static GdkWindowHandle GetBinWindow(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_bin_window(tree_view);
	}

	public static T GetCellArea<T>(this T tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, out GdkRectangle rect) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_get_cell_area(tree_view, path, column, out rect);
		return tree_view;
	}

	public static GtkTreeViewColumnHandle GetColumn(this GtkTreeViewHandle tree_view, int n)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_column(tree_view, n);
	}

	public static GListHandle GetColumns(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_columns(tree_view);
	}

	public static T GetCursor<T>(this T tree_view, out GtkTreePathHandle path, out GtkTreeViewColumnHandle focus_column) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_get_cursor(tree_view, out path, out focus_column);
		return tree_view;
	}

	public static bool GetDestRowAtPos(this GtkTreeViewHandle tree_view, int drag_x, int drag_y, out GtkTreePathHandle path, out GtkTreeViewDropPosition pos)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_dest_row_at_pos(tree_view, drag_x, drag_y, out path, out pos);
	}

	public static T GetDragDestRow<T>(this T tree_view, out GtkTreePathHandle path, out GtkTreeViewDropPosition pos) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_get_drag_dest_row(tree_view, out path, out pos);
		return tree_view;
	}

	public static bool GetEnableSearch(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_enable_search(tree_view);
	}

	public static bool GetEnableTreeLines(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_enable_tree_lines(tree_view);
	}

	public static GtkTreeViewColumnHandle GetExpanderColumn(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_expander_column(tree_view);
	}

	public static bool GetFixedHeightMode(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_fixed_height_mode(tree_view);
	}

	public static GtkTreeViewGridLines GetGridLines(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_grid_lines(tree_view);
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_hadjustment(tree_view);
	}

	public static bool GetHeadersClickable(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_headers_clickable(tree_view);
	}

	public static bool GetHeadersVisible(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_headers_visible(tree_view);
	}

	public static bool GetHoverExpand(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_hover_expand(tree_view);
	}

	public static bool GetHoverSelection(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_hover_selection(tree_view);
	}

	public static int GetLevelIndentation(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_level_indentation(tree_view);
	}

	public static GtkTreeModelHandle GetModel(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_model(tree_view);
	}

	public static uint GetNColumns(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_n_columns(tree_view);
	}

	public static bool GetPathAtPos(this GtkTreeViewHandle tree_view, int x, int y, out GtkTreePathHandle path, out GtkTreeViewColumnHandle column, out int cell_x, out int cell_y)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_path_at_pos(tree_view, x, y, out path, out column, out cell_x, out cell_y);
	}

	public static bool GetReorderable(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_reorderable(tree_view);
	}

	public static GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_row_separator_func(tree_view);
	}

	public static bool GetRubberBanding(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_rubber_banding(tree_view);
	}

	public static bool GetRulesHint(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_rules_hint(tree_view);
	}

	public static int GetSearchColumn(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_search_column(tree_view);
	}

	public static GtkEntryHandle GetSearchEntry(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_search_entry(tree_view);
	}

	public static GtkTreeViewSearchEqualFunc GetSearchEqualFunc(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_search_equal_func(tree_view);
	}

	public static GtkTreeViewSearchPositionFunc GetSearchPositionFunc(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_search_position_func(tree_view);
	}

	public static GtkTreeSelectionHandle GetSelection(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_selection(tree_view);
	}

	public static bool GetShowExpanders(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_show_expanders(tree_view);
	}

	public static int GetTooltipColumn(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_tooltip_column(tree_view);
	}

	public static bool GetTooltipContext(this GtkTreeViewHandle tree_view, ref int x, ref int y, bool keyboard_tip, out GtkTreeModelHandle model, out GtkTreePathHandle path, out GtkTreeIter iter)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_tooltip_context(tree_view, ref x, ref y, keyboard_tip, out model, out path, out iter);
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_vadjustment(tree_view);
	}

	public static bool GetVisibleRange(this GtkTreeViewHandle tree_view, out GtkTreePathHandle start_path, out GtkTreePathHandle end_path)
	{
		return GtkTreeViewExterns.gtk_tree_view_get_visible_range(tree_view, out start_path, out end_path);
	}

	public static T GetVisibleRect<T>(this T tree_view, out GdkRectangle visible_rect) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_get_visible_rect(tree_view, out visible_rect);
		return tree_view;
	}

	public static int InsertColumn(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column, int position)
	{
		return GtkTreeViewExterns.gtk_tree_view_insert_column(tree_view, column, position);
	}

	public static int InsertColumnWithAttributes(this GtkTreeViewHandle tree_view, int position, string title, GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		return GtkTreeViewExterns.gtk_tree_view_insert_column_with_attributes(tree_view, position, title, cell, @__arglist);
	}

	public static int InsertColumnWithDataFunc(this GtkTreeViewHandle tree_view, int position, string title, GtkCellRendererHandle cell, GtkTreeCellDataFunc func, IntPtr data, GDestroyNotify dnotify)
	{
		return GtkTreeViewExterns.gtk_tree_view_insert_column_with_data_func(tree_view, position, title, cell, func, data, dnotify);
	}

	public static bool IsBlankAtPos(this GtkTreeViewHandle tree_view, int x, int y, out GtkTreePathHandle path, out GtkTreeViewColumnHandle column, out int cell_x, out int cell_y)
	{
		return GtkTreeViewExterns.gtk_tree_view_is_blank_at_pos(tree_view, x, y, out path, out column, out cell_x, out cell_y);
	}

	public static bool IsRubberBandingActive(this GtkTreeViewHandle tree_view)
	{
		return GtkTreeViewExterns.gtk_tree_view_is_rubber_banding_active(tree_view);
	}

	public static T MapExpandedRows<T>(this T tree_view, GtkTreeViewMappingFunc func, IntPtr data) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_map_expanded_rows(tree_view, func, data);
		return tree_view;
	}

	public static T MoveColumnAfter<T>(this T tree_view, GtkTreeViewColumnHandle column, GtkTreeViewColumnHandle base_column) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_move_column_after(tree_view, column, base_column);
		return tree_view;
	}

	public static int RemoveColumn(this GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column)
	{
		return GtkTreeViewExterns.gtk_tree_view_remove_column(tree_view, column);
	}

	public static T RowActivated<T>(this T tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_row_activated(tree_view, path, column);
		return tree_view;
	}

	public static bool RowExpanded(this GtkTreeViewHandle tree_view, GtkTreePathHandle path)
	{
		return GtkTreeViewExterns.gtk_tree_view_row_expanded(tree_view, path);
	}

	public static T ScrollToCell<T>(this T tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, bool use_align, float row_align, float col_align) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_scroll_to_cell(tree_view, path, column, use_align, row_align, col_align);
		return tree_view;
	}

	public static T ScrollToPoint<T>(this T tree_view, int tree_x, int tree_y) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_scroll_to_point(tree_view, tree_x, tree_y);
		return tree_view;
	}

	public static T SetActivateOnSingleClick<T>(this T tree_view, bool single) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_activate_on_single_click(tree_view, single);
		return tree_view;
	}

	public static T SetColumnDragFunction<T>(this T tree_view, GtkTreeViewColumnDropFunc func, IntPtr user_data, GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_column_drag_function(tree_view, func, user_data, destroy);
		return tree_view;
	}

	public static T SetCursor<T>(this T tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle focus_column, bool start_editing) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_cursor(tree_view, path, focus_column, start_editing);
		return tree_view;
	}

	public static T SetCursorOnCell<T>(this T tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle focus_column, GtkCellRendererHandle focus_cell, bool start_editing) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_cursor_on_cell(tree_view, path, focus_column, focus_cell, start_editing);
		return tree_view;
	}

	public static T SetDestroyCountFunc<T>(this T tree_view, GtkTreeDestroyCountFunc func, IntPtr data, GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_destroy_count_func(tree_view, func, data, destroy);
		return tree_view;
	}

	public static T SetDragDestRow<T>(this T tree_view, GtkTreePathHandle path, GtkTreeViewDropPosition pos) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_drag_dest_row(tree_view, path, pos);
		return tree_view;
	}

	public static T SetEnableSearch<T>(this T tree_view, bool enable_search) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_enable_search(tree_view, enable_search);
		return tree_view;
	}

	public static T SetEnableTreeLines<T>(this T tree_view, bool enabled) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_enable_tree_lines(tree_view, enabled);
		return tree_view;
	}

	public static T SetExpanderColumn<T>(this T tree_view, GtkTreeViewColumnHandle column) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_expander_column(tree_view, column);
		return tree_view;
	}

	public static T SetFixedHeightMode<T>(this T tree_view, bool enable) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_fixed_height_mode(tree_view, enable);
		return tree_view;
	}

	public static T SetGridLines<T>(this T tree_view, GtkTreeViewGridLines grid_lines) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_grid_lines(tree_view, grid_lines);
		return tree_view;
	}

	public static T SetHadjustment<T>(this T tree_view, GtkAdjustmentHandle adjustment) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_hadjustment(tree_view, adjustment);
		return tree_view;
	}

	public static T SetHeadersClickable<T>(this T tree_view, bool setting) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_headers_clickable(tree_view, setting);
		return tree_view;
	}

	public static T SetHeadersVisible<T>(this T tree_view, bool headers_visible) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_headers_visible(tree_view, headers_visible);
		return tree_view;
	}

	public static T SetHoverExpand<T>(this T tree_view, bool expand) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_hover_expand(tree_view, expand);
		return tree_view;
	}

	public static T SetHoverSelection<T>(this T tree_view, bool hover) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_hover_selection(tree_view, hover);
		return tree_view;
	}

	public static T SetLevelIndentation<T>(this T tree_view, int indentation) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_level_indentation(tree_view, indentation);
		return tree_view;
	}

	public static T SetModel<T>(this T tree_view, GtkTreeModelHandle model) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_model(tree_view, model);
		return tree_view;
	}

	public static T SetReorderable<T>(this T tree_view, bool reorderable) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_reorderable(tree_view, reorderable);
		return tree_view;
	}

	public static T SetRowSeparatorFunc<T>(this T tree_view, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_row_separator_func(tree_view, func, data, destroy);
		return tree_view;
	}

	public static T SetRubberBanding<T>(this T tree_view, bool enable) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_rubber_banding(tree_view, enable);
		return tree_view;
	}

	public static T SetRulesHint<T>(this T tree_view, bool setting) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_rules_hint(tree_view, setting);
		return tree_view;
	}

	public static T SetSearchColumn<T>(this T tree_view, int column) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_search_column(tree_view, column);
		return tree_view;
	}

	public static T SetSearchEntry<T>(this T tree_view, GtkEntryHandle entry) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_search_entry(tree_view, entry);
		return tree_view;
	}

	public static T SetSearchEqualFunc<T>(this T tree_view, GtkTreeViewSearchEqualFunc search_equal_func, IntPtr search_user_data, GDestroyNotify search_destroy) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_search_equal_func(tree_view, search_equal_func, search_user_data, search_destroy);
		return tree_view;
	}

	public static T SetSearchPositionFunc<T>(this T tree_view, GtkTreeViewSearchPositionFunc func, IntPtr data, GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_search_position_func(tree_view, func, data, destroy);
		return tree_view;
	}

	public static T SetShowExpanders<T>(this T tree_view, bool enabled) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_show_expanders(tree_view, enabled);
		return tree_view;
	}

	public static T SetTooltipCell<T>(this T tree_view, GtkTooltipHandle tooltip, GtkTreePathHandle path, GtkTreeViewColumnHandle column, GtkCellRendererHandle cell) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_tooltip_cell(tree_view, tooltip, path, column, cell);
		return tree_view;
	}

	public static T SetTooltipColumn<T>(this T tree_view, int column) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_tooltip_column(tree_view, column);
		return tree_view;
	}

	public static T SetTooltipRow<T>(this T tree_view, GtkTooltipHandle tooltip, GtkTreePathHandle path) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_tooltip_row(tree_view, tooltip, path);
		return tree_view;
	}

	public static T SetVadjustment<T>(this T tree_view, GtkAdjustmentHandle adjustment) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_set_vadjustment(tree_view, adjustment);
		return tree_view;
	}

	public static T UnsetRowsDragDest<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_unset_rows_drag_dest(tree_view);
		return tree_view;
	}

	public static T UnsetRowsDragSource<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		GtkTreeViewExterns.gtk_tree_view_unset_rows_drag_source(tree_view);
		return tree_view;
	}

}

internal class GtkTreeViewExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewHandle gtk_tree_view_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewHandle gtk_tree_view_new_with_model(GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_append_column(GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_collapse_all(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_collapse_row(GtkTreeViewHandle tree_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_columns_autosize(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_convert_bin_window_to_tree_coords(GtkTreeViewHandle tree_view, int bx, int by, out int tx, out int ty);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_convert_bin_window_to_widget_coords(GtkTreeViewHandle tree_view, int bx, int by, out int wx, out int wy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_convert_tree_to_bin_window_coords(GtkTreeViewHandle tree_view, int tx, int ty, out int bx, out int by);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_convert_tree_to_widget_coords(GtkTreeViewHandle tree_view, int tx, int ty, out int wx, out int wy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_convert_widget_to_bin_window_coords(GtkTreeViewHandle tree_view, int wx, int wy, out int bx, out int by);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_convert_widget_to_tree_coords(GtkTreeViewHandle tree_view, int wx, int wy, out int tx, out int ty);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_surface_tHandle gtk_tree_view_create_row_drag_icon(GtkTreeViewHandle tree_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_enable_model_drag_dest(GtkTreeViewHandle tree_view, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_enable_model_drag_source(GtkTreeViewHandle tree_view, GdkModifierType start_button_mask, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_expand_all(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_expand_row(GtkTreeViewHandle tree_view, GtkTreePathHandle path, bool open_all);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_expand_to_path(GtkTreeViewHandle tree_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_activate_on_single_click(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_get_background_area(GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, out GdkRectangle rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_tree_view_get_bin_window(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_get_cell_area(GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, out GdkRectangle rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewColumnHandle gtk_tree_view_get_column(GtkTreeViewHandle tree_view, int n);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_tree_view_get_columns(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_get_cursor(GtkTreeViewHandle tree_view, out GtkTreePathHandle path, out GtkTreeViewColumnHandle focus_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_dest_row_at_pos(GtkTreeViewHandle tree_view, int drag_x, int drag_y, out GtkTreePathHandle path, out GtkTreeViewDropPosition pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_get_drag_dest_row(GtkTreeViewHandle tree_view, out GtkTreePathHandle path, out GtkTreeViewDropPosition pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_enable_search(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_enable_tree_lines(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewColumnHandle gtk_tree_view_get_expander_column(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_fixed_height_mode(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewGridLines gtk_tree_view_get_grid_lines(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_tree_view_get_hadjustment(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_headers_clickable(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_headers_visible(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_hover_expand(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_hover_selection(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_get_level_indentation(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelHandle gtk_tree_view_get_model(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_tree_view_get_n_columns(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_path_at_pos(GtkTreeViewHandle tree_view, int x, int y, out GtkTreePathHandle path, out GtkTreeViewColumnHandle column, out int cell_x, out int cell_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_reorderable(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewRowSeparatorFunc gtk_tree_view_get_row_separator_func(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_rubber_banding(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_rules_hint(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_get_search_column(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEntryHandle gtk_tree_view_get_search_entry(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewSearchEqualFunc gtk_tree_view_get_search_equal_func(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewSearchPositionFunc gtk_tree_view_get_search_position_func(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeSelectionHandle gtk_tree_view_get_selection(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_show_expanders(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_get_tooltip_column(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_tooltip_context(GtkTreeViewHandle tree_view, ref int x, ref int y, bool keyboard_tip, out GtkTreeModelHandle model, out GtkTreePathHandle path, out GtkTreeIter iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_tree_view_get_vadjustment(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_get_visible_range(GtkTreeViewHandle tree_view, out GtkTreePathHandle start_path, out GtkTreePathHandle end_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_get_visible_rect(GtkTreeViewHandle tree_view, out GdkRectangle visible_rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_insert_column(GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_insert_column_with_attributes(GtkTreeViewHandle tree_view, int position, string title, GtkCellRendererHandle cell, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_insert_column_with_data_func(GtkTreeViewHandle tree_view, int position, string title, GtkCellRendererHandle cell, GtkTreeCellDataFunc func, IntPtr data, GDestroyNotify dnotify);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_is_blank_at_pos(GtkTreeViewHandle tree_view, int x, int y, out GtkTreePathHandle path, out GtkTreeViewColumnHandle column, out int cell_x, out int cell_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_is_rubber_banding_active(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_map_expanded_rows(GtkTreeViewHandle tree_view, GtkTreeViewMappingFunc func, IntPtr data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_move_column_after(GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column, GtkTreeViewColumnHandle base_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_remove_column(GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_row_activated(GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_row_expanded(GtkTreeViewHandle tree_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_scroll_to_cell(GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle column, bool use_align, float row_align, float col_align);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_scroll_to_point(GtkTreeViewHandle tree_view, int tree_x, int tree_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_activate_on_single_click(GtkTreeViewHandle tree_view, bool single);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_column_drag_function(GtkTreeViewHandle tree_view, GtkTreeViewColumnDropFunc func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_cursor(GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle focus_column, bool start_editing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_cursor_on_cell(GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewColumnHandle focus_column, GtkCellRendererHandle focus_cell, bool start_editing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_destroy_count_func(GtkTreeViewHandle tree_view, GtkTreeDestroyCountFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_drag_dest_row(GtkTreeViewHandle tree_view, GtkTreePathHandle path, GtkTreeViewDropPosition pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_enable_search(GtkTreeViewHandle tree_view, bool enable_search);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_enable_tree_lines(GtkTreeViewHandle tree_view, bool enabled);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_expander_column(GtkTreeViewHandle tree_view, GtkTreeViewColumnHandle column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_fixed_height_mode(GtkTreeViewHandle tree_view, bool enable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_grid_lines(GtkTreeViewHandle tree_view, GtkTreeViewGridLines grid_lines);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_hadjustment(GtkTreeViewHandle tree_view, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_headers_clickable(GtkTreeViewHandle tree_view, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_headers_visible(GtkTreeViewHandle tree_view, bool headers_visible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_hover_expand(GtkTreeViewHandle tree_view, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_hover_selection(GtkTreeViewHandle tree_view, bool hover);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_level_indentation(GtkTreeViewHandle tree_view, int indentation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_model(GtkTreeViewHandle tree_view, GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_reorderable(GtkTreeViewHandle tree_view, bool reorderable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_row_separator_func(GtkTreeViewHandle tree_view, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_rubber_banding(GtkTreeViewHandle tree_view, bool enable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_rules_hint(GtkTreeViewHandle tree_view, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_search_column(GtkTreeViewHandle tree_view, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_search_entry(GtkTreeViewHandle tree_view, GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_search_equal_func(GtkTreeViewHandle tree_view, GtkTreeViewSearchEqualFunc search_equal_func, IntPtr search_user_data, GDestroyNotify search_destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_search_position_func(GtkTreeViewHandle tree_view, GtkTreeViewSearchPositionFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_show_expanders(GtkTreeViewHandle tree_view, bool enabled);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_tooltip_cell(GtkTreeViewHandle tree_view, GtkTooltipHandle tooltip, GtkTreePathHandle path, GtkTreeViewColumnHandle column, GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_tooltip_column(GtkTreeViewHandle tree_view, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_tooltip_row(GtkTreeViewHandle tree_view, GtkTooltipHandle tooltip, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_set_vadjustment(GtkTreeViewHandle tree_view, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_unset_rows_drag_dest(GtkTreeViewHandle tree_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_unset_rows_drag_source(GtkTreeViewHandle tree_view);

}
