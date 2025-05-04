namespace MentorLake.Gtk;

public class GtkTreeModelFilterHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle
{
}
public static class GtkTreeModelFilterHandleSignalExtensions
{

	public static IObservable<GtkTreeModelFilterHandleSignalStructs.RowChangedSignal> Signal_RowChanged(this GtkTreeModelFilterHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelFilterHandleSignalStructs.RowChangedSignal> obs) =>
		{
			GtkTreeModelFilterHandleSignalDelegates.row_changed handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelFilterHandleSignalStructs.RowChangedSignal()
				{
					Self = self, Path = path, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeModelFilterHandleSignalStructs.RowDeletedSignal> Signal_RowDeleted(this GtkTreeModelFilterHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelFilterHandleSignalStructs.RowDeletedSignal> obs) =>
		{
			GtkTreeModelFilterHandleSignalDelegates.row_deleted handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelFilterHandleSignalStructs.RowDeletedSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-deleted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeModelFilterHandleSignalStructs.RowHasChildToggledSignal> Signal_RowHasChildToggled(this GtkTreeModelFilterHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelFilterHandleSignalStructs.RowHasChildToggledSignal> obs) =>
		{
			GtkTreeModelFilterHandleSignalDelegates.row_has_child_toggled handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelFilterHandleSignalStructs.RowHasChildToggledSignal()
				{
					Self = self, Path = path, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-has-child-toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeModelFilterHandleSignalStructs.RowInsertedSignal> Signal_RowInserted(this GtkTreeModelFilterHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelFilterHandleSignalStructs.RowInsertedSignal> obs) =>
		{
			GtkTreeModelFilterHandleSignalDelegates.row_inserted handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelFilterHandleSignalStructs.RowInsertedSignal()
				{
					Self = self, Path = path, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-inserted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeModelFilterHandleSignalStructs.RowsReorderedSignal> Signal_RowsReordered(this GtkTreeModelFilterHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelFilterHandleSignalStructs.RowsReorderedSignal> obs) =>
		{
			GtkTreeModelFilterHandleSignalDelegates.rows_reordered handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr new_order,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelFilterHandleSignalStructs.RowsReorderedSignal()
				{
					Self = self, Path = path, Iter = iter, NewOrder = new_order, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "rows-reordered", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTreeModelFilterHandleSignalStructs
{

public class RowChangedSignal
{
	public MentorLake.Gtk.GtkTreeModelHandle Self;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public IntPtr UserData;
}

public class RowDeletedSignal
{
	public MentorLake.Gtk.GtkTreeModelHandle Self;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public IntPtr UserData;
}

public class RowHasChildToggledSignal
{
	public MentorLake.Gtk.GtkTreeModelHandle Self;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public IntPtr UserData;
}

public class RowInsertedSignal
{
	public MentorLake.Gtk.GtkTreeModelHandle Self;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public IntPtr UserData;
}

public class RowsReorderedSignal
{
	public MentorLake.Gtk.GtkTreeModelHandle Self;
	public MentorLake.Gtk.GtkTreePathHandle Path;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public IntPtr NewOrder;
	public IntPtr UserData;
}
}

public static class GtkTreeModelFilterHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_has_child_toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void rows_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr new_order, IntPtr user_data);

}


public static class GtkTreeModelFilterHandleExtensions
{
	public static T ClearCache<T>(this T filter) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_clear_cache(filter);
		return filter;
	}

	public static bool ConvertChildIterToIter(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, out MentorLake.Gtk.GtkTreeIter filter_iter, MentorLake.Gtk.GtkTreeIterHandle child_iter)
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_child_iter_to_iter(filter, out filter_iter, child_iter);
	}

	public static MentorLake.Gtk.GtkTreePathHandle ConvertChildPathToPath(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, MentorLake.Gtk.GtkTreePathHandle child_path)
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_child_path_to_path(filter, child_path);
	}

	public static T ConvertIterToChildIter<T>(this T filter, out MentorLake.Gtk.GtkTreeIter child_iter, MentorLake.Gtk.GtkTreeIterHandle filter_iter) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_iter_to_child_iter(filter, out child_iter, filter_iter);
		return filter;
	}

	public static MentorLake.Gtk.GtkTreePathHandle ConvertPathToChildPath(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, MentorLake.Gtk.GtkTreePathHandle filter_path)
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_path_to_child_path(filter, filter_path);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeModelFilterHandle filter)
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_get_model(filter);
	}

	public static T Refilter<T>(this T filter) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_refilter(filter);
		return filter;
	}

	public static T SetModifyFunc<T>(this T filter, int n_columns, MentorLake.GObject.GType[] types, MentorLake.Gtk.GtkTreeModelFilterModifyFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_set_modify_func(filter, n_columns, types, func, data, destroy);
		return filter;
	}

	public static T SetVisibleColumn<T>(this T filter, int column) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_set_visible_column(filter, column);
		return filter;
	}

	public static T SetVisibleFunc<T>(this T filter, MentorLake.Gtk.GtkTreeModelFilterVisibleFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid || filter.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_set_visible_func(filter, func, data, destroy);
		return filter;
	}

}

internal class GtkTreeModelFilterHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_clear_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_filter_convert_child_iter_to_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, out MentorLake.Gtk.GtkTreeIter filter_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle child_iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_filter_convert_child_path_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle child_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_convert_iter_to_child_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, out MentorLake.Gtk.GtkTreeIter child_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle filter_iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_filter_convert_path_to_child_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle filter_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_tree_model_filter_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_refilter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_set_modify_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, int n_columns, MentorLake.GObject.GType[] types, MentorLake.Gtk.GtkTreeModelFilterModifyFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_set_visible_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_set_visible_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, MentorLake.Gtk.GtkTreeModelFilterVisibleFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

}
