namespace MentorLake.Gtk;

public class GtkTreeViewHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
	public static MentorLake.Gtk.GtkTreeViewHandle New()
	{
		return GtkTreeViewHandleExterns.gtk_tree_view_new();
	}

	public static MentorLake.Gtk.GtkTreeViewHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkTreeViewHandleExterns.gtk_tree_view_new_with_model(model);
	}

}
public static class GtkTreeViewHandleSignalExtensions
{

	public static IObservable<GtkTreeViewHandleSignalStructs.ColumnsChangedSignal> Signal_ColumnsChanged(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.ColumnsChangedSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.columns_changed handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.ColumnsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "columns-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.CursorChangedSignal> Signal_CursorChanged(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.CursorChangedSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.cursor_changed handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.CursorChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cursor-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.ExpandCollapseCursorRowSignal> Signal_ExpandCollapseCursorRow(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.ExpandCollapseCursorRowSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.expand_collapse_cursor_row handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  bool @object,  bool p0,  bool p1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.ExpandCollapseCursorRowSignal()
				{
					Self = self, Object = @object, P0 = p0, P1 = p1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "expand-collapse-cursor-row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  MentorLake.Gtk.GtkMovementStep step,  int direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Direction = direction, UserData = user_data
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

	public static IObservable<GtkTreeViewHandleSignalStructs.RowActivatedSignal> Signal_RowActivated(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.RowActivatedSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.row_activated handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeViewColumnHandle column,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.RowActivatedSignal()
				{
					Self = self, Path = path, Column = column, UserData = user_data
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

	public static IObservable<GtkTreeViewHandleSignalStructs.RowCollapsedSignal> Signal_RowCollapsed(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.RowCollapsedSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.row_collapsed handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  MentorLake.Gtk.GtkTreeIterHandle iter,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.RowCollapsedSignal()
				{
					Self = self, Iter = iter, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-collapsed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.RowExpandedSignal> Signal_RowExpanded(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.RowExpandedSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.row_expanded handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  MentorLake.Gtk.GtkTreeIterHandle iter,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.RowExpandedSignal()
				{
					Self = self, Iter = iter, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-expanded", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.SelectAllSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.select_all handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.SelectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
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

	public static IObservable<GtkTreeViewHandleSignalStructs.SelectCursorParentSignal> Signal_SelectCursorParent(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.SelectCursorParentSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.select_cursor_parent handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.SelectCursorParentSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select-cursor-parent", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.SelectCursorRowSignal> Signal_SelectCursorRow(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.SelectCursorRowSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.select_cursor_row handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  bool @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.SelectCursorRowSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select-cursor-row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.StartInteractiveSearchSignal> Signal_StartInteractiveSearch(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.StartInteractiveSearchSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.start_interactive_search handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.StartInteractiveSearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "start-interactive-search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.TestCollapseRowSignal> Signal_TestCollapseRow(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.TestCollapseRowSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.test_collapse_row handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  MentorLake.Gtk.GtkTreeIterHandle iter,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.TestCollapseRowSignal()
				{
					Self = self, Iter = iter, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "test-collapse-row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.TestExpandRowSignal> Signal_TestExpandRow(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.TestExpandRowSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.test_expand_row handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  MentorLake.Gtk.GtkTreeIterHandle iter,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.TestExpandRowSignal()
				{
					Self = self, Iter = iter, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "test-expand-row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewHandleSignalStructs.ToggleCursorRowSignal> Signal_ToggleCursorRow(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.ToggleCursorRowSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.toggle_cursor_row handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.ToggleCursorRowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
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

	public static IObservable<GtkTreeViewHandleSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkTreeViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewHandleSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkTreeViewHandleSignalDelegates.unselect_all handler = ( MentorLake.Gtk.GtkTreeViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewHandleSignalStructs.UnselectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
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

public static class GtkTreeViewHandleSignalStructs
{

public class ColumnsChangedSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public IntPtr UserData;
}

public class CursorChangedSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public IntPtr UserData;
}

public class ExpandCollapseCursorRowSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public bool Object;
	public bool P0;
	public bool P1;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class MoveCursorSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public MentorLake.Gtk.GtkMovementStep Step;
	public int Direction;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class RowActivatedSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public MentorLake.Gtk.GtkTreeViewColumnHandle Column;
	public IntPtr UserData;
}

public class RowCollapsedSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public IntPtr UserData;
}

public class RowExpandedSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public IntPtr UserData;
}

public class SelectAllSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SelectCursorParentSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SelectCursorRowSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public bool Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class StartInteractiveSearchSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class TestCollapseRowSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class TestExpandRowSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ToggleCursorRowSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class UnselectAllSignal
{
	public MentorLake.Gtk.GtkTreeViewHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkTreeViewHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void columns_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cursor_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool expand_collapse_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, bool @object, bool p0, bool p1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, MentorLake.Gtk.GtkMovementStep step, int direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_collapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_expanded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_cursor_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, bool @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool start_interactive_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool test_collapse_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool test_expand_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool toggle_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);

}


public static class GtkTreeViewHandleExtensions
{
	public static int AppendColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_append_column(tree_view, column);
	}

	public static T CollapseAll<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_collapse_all(tree_view);
		return tree_view;
	}

	public static bool CollapseRow(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_collapse_row(tree_view, path);
	}

	public static T ColumnsAutosize<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_columns_autosize(tree_view);
		return tree_view;
	}

	public static T ConvertBinWindowToTreeCoords<T>(this T tree_view, int bx, int by, out int tx, out int ty) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_bin_window_to_tree_coords(tree_view, bx, by, out tx, out ty);
		return tree_view;
	}

	public static T ConvertBinWindowToWidgetCoords<T>(this T tree_view, int bx, int by, out int wx, out int wy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_bin_window_to_widget_coords(tree_view, bx, by, out wx, out wy);
		return tree_view;
	}

	public static T ConvertTreeToBinWindowCoords<T>(this T tree_view, int tx, int ty, out int bx, out int by) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_tree_to_bin_window_coords(tree_view, tx, ty, out bx, out by);
		return tree_view;
	}

	public static T ConvertTreeToWidgetCoords<T>(this T tree_view, int tx, int ty, out int wx, out int wy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_tree_to_widget_coords(tree_view, tx, ty, out wx, out wy);
		return tree_view;
	}

	public static T ConvertWidgetToBinWindowCoords<T>(this T tree_view, int wx, int wy, out int bx, out int by) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_widget_to_bin_window_coords(tree_view, wx, wy, out bx, out by);
		return tree_view;
	}

	public static T ConvertWidgetToTreeCoords<T>(this T tree_view, int wx, int wy, out int tx, out int ty) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_widget_to_tree_coords(tree_view, wx, wy, out tx, out ty);
		return tree_view;
	}

	public static MentorLake.cairo.cairo_surface_tHandle CreateRowDragIcon(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_create_row_drag_icon(tree_view, path);
	}

	public static T EnableModelDragDest<T>(this T tree_view, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_enable_model_drag_dest(tree_view, targets, n_targets, actions);
		return tree_view;
	}

	public static T EnableModelDragSource<T>(this T tree_view, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_enable_model_drag_source(tree_view, start_button_mask, targets, n_targets, actions);
		return tree_view;
	}

	public static T ExpandAll<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_expand_all(tree_view);
		return tree_view;
	}

	public static bool ExpandRow(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreePathHandle path, bool open_all)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_expand_row(tree_view, path, open_all);
	}

	public static T ExpandToPath<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_expand_to_path(tree_view, path);
		return tree_view;
	}

	public static bool GetActivateOnSingleClick(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_activate_on_single_click(tree_view);
	}

	public static T GetBackgroundArea<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column, out MentorLake.Gdk.GdkRectangle rect) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_background_area(tree_view, path, column, out rect);
		return tree_view;
	}

	public static MentorLake.Gdk.GdkWindowHandle GetBinWindow(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_bin_window(tree_view);
	}

	public static T GetCellArea<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column, out MentorLake.Gdk.GdkRectangle rect) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_cell_area(tree_view, path, column, out rect);
		return tree_view;
	}

	public static MentorLake.Gtk.GtkTreeViewColumnHandle GetColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int n)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_column(tree_view, n);
	}

	public static MentorLake.GLib.GListHandle GetColumns(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_columns(tree_view);
	}

	public static T GetCursor<T>(this T tree_view, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewColumnHandle focus_column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_cursor(tree_view, out path, out focus_column);
		return tree_view;
	}

	public static bool GetDestRowAtPos(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int drag_x, int drag_y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewDropPosition pos)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_dest_row_at_pos(tree_view, drag_x, drag_y, out path, out pos);
	}

	public static T GetDragDestRow<T>(this T tree_view, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewDropPosition pos) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_drag_dest_row(tree_view, out path, out pos);
		return tree_view;
	}

	public static bool GetEnableSearch(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_enable_search(tree_view);
	}

	public static bool GetEnableTreeLines(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_enable_tree_lines(tree_view);
	}

	public static MentorLake.Gtk.GtkTreeViewColumnHandle GetExpanderColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_expander_column(tree_view);
	}

	public static bool GetFixedHeightMode(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_fixed_height_mode(tree_view);
	}

	public static MentorLake.Gtk.GtkTreeViewGridLines GetGridLines(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_grid_lines(tree_view);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_hadjustment(tree_view);
	}

	public static bool GetHeadersClickable(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_headers_clickable(tree_view);
	}

	public static bool GetHeadersVisible(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_headers_visible(tree_view);
	}

	public static bool GetHoverExpand(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_hover_expand(tree_view);
	}

	public static bool GetHoverSelection(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_hover_selection(tree_view);
	}

	public static int GetLevelIndentation(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_level_indentation(tree_view);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_model(tree_view);
	}

	public static uint GetNColumns(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_n_columns(tree_view);
	}

	public static bool GetPathAtPos(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int x, int y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewColumnHandle column, out int cell_x, out int cell_y)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_path_at_pos(tree_view, x, y, out path, out column, out cell_x, out cell_y);
	}

	public static bool GetReorderable(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_reorderable(tree_view);
	}

	public static MentorLake.Gtk.GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_row_separator_func(tree_view);
	}

	public static bool GetRubberBanding(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_rubber_banding(tree_view);
	}

	public static bool GetRulesHint(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_rules_hint(tree_view);
	}

	public static int GetSearchColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_search_column(tree_view);
	}

	public static MentorLake.Gtk.GtkEntryHandle GetSearchEntry(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_search_entry(tree_view);
	}

	public static MentorLake.Gtk.GtkTreeViewSearchEqualFunc GetSearchEqualFunc(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_search_equal_func(tree_view);
	}

	public static MentorLake.Gtk.GtkTreeViewSearchPositionFunc GetSearchPositionFunc(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_search_position_func(tree_view);
	}

	public static MentorLake.Gtk.GtkTreeSelectionHandle GetSelection(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_selection(tree_view);
	}

	public static bool GetShowExpanders(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_show_expanders(tree_view);
	}

	public static int GetTooltipColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_tooltip_column(tree_view);
	}

	public static bool GetTooltipContext(this MentorLake.Gtk.GtkTreeViewHandle tree_view, ref int x, ref int y, bool keyboard_tip, out MentorLake.Gtk.GtkTreeModelHandle model, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeIter iter)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_tooltip_context(tree_view, ref x, ref y, keyboard_tip, out model, out path, out iter);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_vadjustment(tree_view);
	}

	public static bool GetVisibleRange(this MentorLake.Gtk.GtkTreeViewHandle tree_view, out MentorLake.Gtk.GtkTreePathHandle start_path, out MentorLake.Gtk.GtkTreePathHandle end_path)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_visible_range(tree_view, out start_path, out end_path);
	}

	public static T GetVisibleRect<T>(this T tree_view, out MentorLake.Gdk.GdkRectangle visible_rect) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_visible_rect(tree_view, out visible_rect);
		return tree_view;
	}

	public static int InsertColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column, int position)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_insert_column(tree_view, column, position);
	}

	public static int InsertColumnWithAttributes(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int position, string title, MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_insert_column_with_attributes(tree_view, position, title, cell, @__arglist);
	}

	public static int InsertColumnWithDataFunc(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int position, string title, MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkTreeCellDataFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify dnotify)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_insert_column_with_data_func(tree_view, position, title, cell, func, data, dnotify);
	}

	public static bool IsBlankAtPos(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int x, int y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewColumnHandle column, out int cell_x, out int cell_y)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_is_blank_at_pos(tree_view, x, y, out path, out column, out cell_x, out cell_y);
	}

	public static bool IsRubberBandingActive(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_is_rubber_banding_active(tree_view);
	}

	public static T MapExpandedRows<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewMappingFunc func, IntPtr data) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_map_expanded_rows(tree_view, func, data);
		return tree_view;
	}

	public static T MoveColumnAfter<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column, MentorLake.Gtk.GtkTreeViewColumnHandle base_column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_move_column_after(tree_view, column, base_column);
		return tree_view;
	}

	public static int RemoveColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_remove_column(tree_view, column);
	}

	public static T RowActivated<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_row_activated(tree_view, path, column);
		return tree_view;
	}

	public static bool RowExpanded(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_row_expanded(tree_view, path);
	}

	public static T ScrollToCell<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column, bool use_align, float row_align, float col_align) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_scroll_to_cell(tree_view, path, column, use_align, row_align, col_align);
		return tree_view;
	}

	public static T ScrollToPoint<T>(this T tree_view, int tree_x, int tree_y) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_scroll_to_point(tree_view, tree_x, tree_y);
		return tree_view;
	}

	public static T SetActivateOnSingleClick<T>(this T tree_view, bool single) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_activate_on_single_click(tree_view, single);
		return tree_view;
	}

	public static T SetColumnDragFunction<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewColumnDropFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_column_drag_function(tree_view, func, user_data, destroy);
		return tree_view;
	}

	public static T SetCursor<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle focus_column, bool start_editing) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_cursor(tree_view, path, focus_column, start_editing);
		return tree_view;
	}

	public static T SetCursorOnCell<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle focus_column, MentorLake.Gtk.GtkCellRendererHandle focus_cell, bool start_editing) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_cursor_on_cell(tree_view, path, focus_column, focus_cell, start_editing);
		return tree_view;
	}

	public static T SetDestroyCountFunc<T>(this T tree_view, MentorLake.Gtk.GtkTreeDestroyCountFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_destroy_count_func(tree_view, func, data, destroy);
		return tree_view;
	}

	public static T SetDragDestRow<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewDropPosition pos) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_drag_dest_row(tree_view, path, pos);
		return tree_view;
	}

	public static T SetEnableSearch<T>(this T tree_view, bool enable_search) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_enable_search(tree_view, enable_search);
		return tree_view;
	}

	public static T SetEnableTreeLines<T>(this T tree_view, bool enabled) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_enable_tree_lines(tree_view, enabled);
		return tree_view;
	}

	public static T SetExpanderColumn<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_expander_column(tree_view, column);
		return tree_view;
	}

	public static T SetFixedHeightMode<T>(this T tree_view, bool enable) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_fixed_height_mode(tree_view, enable);
		return tree_view;
	}

	public static T SetGridLines<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewGridLines grid_lines) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_grid_lines(tree_view, grid_lines);
		return tree_view;
	}

	public static T SetHadjustment<T>(this T tree_view, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_hadjustment(tree_view, adjustment);
		return tree_view;
	}

	public static T SetHeadersClickable<T>(this T tree_view, bool setting) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_headers_clickable(tree_view, setting);
		return tree_view;
	}

	public static T SetHeadersVisible<T>(this T tree_view, bool headers_visible) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_headers_visible(tree_view, headers_visible);
		return tree_view;
	}

	public static T SetHoverExpand<T>(this T tree_view, bool expand) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_hover_expand(tree_view, expand);
		return tree_view;
	}

	public static T SetHoverSelection<T>(this T tree_view, bool hover) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_hover_selection(tree_view, hover);
		return tree_view;
	}

	public static T SetLevelIndentation<T>(this T tree_view, int indentation) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_level_indentation(tree_view, indentation);
		return tree_view;
	}

	public static T SetModel<T>(this T tree_view, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_model(tree_view, model);
		return tree_view;
	}

	public static T SetReorderable<T>(this T tree_view, bool reorderable) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_reorderable(tree_view, reorderable);
		return tree_view;
	}

	public static T SetRowSeparatorFunc<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewRowSeparatorFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_row_separator_func(tree_view, func, data, destroy);
		return tree_view;
	}

	public static T SetRubberBanding<T>(this T tree_view, bool enable) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_rubber_banding(tree_view, enable);
		return tree_view;
	}

	public static T SetRulesHint<T>(this T tree_view, bool setting) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_rules_hint(tree_view, setting);
		return tree_view;
	}

	public static T SetSearchColumn<T>(this T tree_view, int column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_search_column(tree_view, column);
		return tree_view;
	}

	public static T SetSearchEntry<T>(this T tree_view, MentorLake.Gtk.GtkEntryHandle entry) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_search_entry(tree_view, entry);
		return tree_view;
	}

	public static T SetSearchEqualFunc<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewSearchEqualFunc search_equal_func, IntPtr search_user_data, MentorLake.GLib.GDestroyNotify search_destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_search_equal_func(tree_view, search_equal_func, search_user_data, search_destroy);
		return tree_view;
	}

	public static T SetSearchPositionFunc<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewSearchPositionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_search_position_func(tree_view, func, data, destroy);
		return tree_view;
	}

	public static T SetShowExpanders<T>(this T tree_view, bool enabled) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_show_expanders(tree_view, enabled);
		return tree_view;
	}

	public static T SetTooltipCell<T>(this T tree_view, MentorLake.Gtk.GtkTooltipHandle tooltip, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column, MentorLake.Gtk.GtkCellRendererHandle cell) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_tooltip_cell(tree_view, tooltip, path, column, cell);
		return tree_view;
	}

	public static T SetTooltipColumn<T>(this T tree_view, int column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_tooltip_column(tree_view, column);
		return tree_view;
	}

	public static T SetTooltipRow<T>(this T tree_view, MentorLake.Gtk.GtkTooltipHandle tooltip, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_tooltip_row(tree_view, tooltip, path);
		return tree_view;
	}

	public static T SetVadjustment<T>(this T tree_view, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_vadjustment(tree_view, adjustment);
		return tree_view;
	}

	public static T UnsetRowsDragDest<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_unset_rows_drag_dest(tree_view);
		return tree_view;
	}

	public static T UnsetRowsDragSource<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_unset_rows_drag_source(tree_view);
		return tree_view;
	}

}

internal class GtkTreeViewHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeViewHandle gtk_tree_view_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeViewHandle gtk_tree_view_new_with_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_append_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_collapse_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_collapse_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_columns_autosize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_convert_bin_window_to_tree_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int bx, int by, out int tx, out int ty);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_convert_bin_window_to_widget_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int bx, int by, out int wx, out int wy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_convert_tree_to_bin_window_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int tx, int ty, out int bx, out int by);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_convert_tree_to_widget_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int tx, int ty, out int wx, out int wy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_convert_widget_to_bin_window_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int wx, int wy, out int bx, out int by);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_convert_widget_to_tree_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int wx, int wy, out int tx, out int ty);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_tree_view_create_row_drag_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_enable_model_drag_dest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_enable_model_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_expand_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_expand_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, bool open_all);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_expand_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_get_background_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_tree_view_get_bin_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_get_cell_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnHandle gtk_tree_view_get_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int n);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_tree_view_get_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_get_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] out MentorLake.Gtk.GtkTreeViewColumnHandle focus_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_dest_row_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int drag_x, int drag_y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_get_drag_dest_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_enable_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_enable_tree_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnHandle gtk_tree_view_get_expander_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_fixed_height_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewGridLines gtk_tree_view_get_grid_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_tree_view_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_headers_clickable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_headers_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_hover_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_hover_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_get_level_indentation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_tree_view_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_tree_view_get_n_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_path_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] out MentorLake.Gtk.GtkTreeViewColumnHandle column, out int cell_x, out int cell_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewRowSeparatorFunc gtk_tree_view_get_row_separator_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_rubber_banding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_rules_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_get_search_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))]
	internal static extern MentorLake.Gtk.GtkEntryHandle gtk_tree_view_get_search_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewSearchEqualFunc gtk_tree_view_get_search_equal_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewSearchPositionFunc gtk_tree_view_get_search_position_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeSelectionHandle gtk_tree_view_get_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_show_expanders([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_get_tooltip_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_tooltip_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, ref int x, ref int y, bool keyboard_tip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] out MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_tree_view_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_get_visible_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle start_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle end_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_get_visible_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, out MentorLake.Gdk.GdkRectangle visible_rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_insert_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_insert_column_with_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int position, string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_insert_column_with_data_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int position, string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkTreeCellDataFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify dnotify);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_is_blank_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] out MentorLake.Gtk.GtkTreeViewColumnHandle column, out int cell_x, out int cell_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_is_rubber_banding_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_map_expanded_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewMappingFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_move_column_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle base_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_remove_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_row_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_row_expanded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_scroll_to_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, bool use_align, float row_align, float col_align);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_scroll_to_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int tree_x, int tree_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool single);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_column_drag_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewColumnDropFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle focus_column, bool start_editing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_cursor_on_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle focus_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle focus_cell, bool start_editing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_destroy_count_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeDestroyCountFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_drag_dest_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_enable_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool enable_search);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_enable_tree_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool enabled);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_expander_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_fixed_height_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool enable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_grid_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewGridLines grid_lines);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_headers_clickable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_headers_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool headers_visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_hover_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_hover_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool hover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_level_indentation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int indentation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool reorderable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_row_separator_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewRowSeparatorFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_rubber_banding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool enable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_rules_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_search_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_search_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_search_equal_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewSearchEqualFunc search_equal_func, IntPtr search_user_data, MentorLake.GLib.GDestroyNotify search_destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_search_position_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewSearchPositionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_show_expanders([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, bool enabled);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_tooltip_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_tooltip_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_tooltip_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_unset_rows_drag_dest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_unset_rows_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view);

}
