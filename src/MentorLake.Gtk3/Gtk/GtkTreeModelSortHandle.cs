namespace MentorLake.Gtk;

public class GtkTreeModelSortHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
	public static MentorLake.Gtk.GtkTreeModelSortHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle child_model)
	{
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_new_with_model(child_model);
	}

}
public static class GtkTreeModelSortHandleSignalExtensions
{

	public static IObservable<GtkTreeModelSortHandleSignalStructs.RowChangedSignal> Signal_RowChanged(this GtkTreeModelSortHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelSortHandleSignalStructs.RowChangedSignal> obs) =>
		{
			GtkTreeModelSortHandleSignalDelegates.row_changed handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelSortHandleSignalStructs.RowChangedSignal()
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

	public static IObservable<GtkTreeModelSortHandleSignalStructs.RowDeletedSignal> Signal_RowDeleted(this GtkTreeModelSortHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelSortHandleSignalStructs.RowDeletedSignal> obs) =>
		{
			GtkTreeModelSortHandleSignalDelegates.row_deleted handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelSortHandleSignalStructs.RowDeletedSignal()
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

	public static IObservable<GtkTreeModelSortHandleSignalStructs.RowHasChildToggledSignal> Signal_RowHasChildToggled(this GtkTreeModelSortHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelSortHandleSignalStructs.RowHasChildToggledSignal> obs) =>
		{
			GtkTreeModelSortHandleSignalDelegates.row_has_child_toggled handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelSortHandleSignalStructs.RowHasChildToggledSignal()
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

	public static IObservable<GtkTreeModelSortHandleSignalStructs.RowInsertedSignal> Signal_RowInserted(this GtkTreeModelSortHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelSortHandleSignalStructs.RowInsertedSignal> obs) =>
		{
			GtkTreeModelSortHandleSignalDelegates.row_inserted handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelSortHandleSignalStructs.RowInsertedSignal()
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

	public static IObservable<GtkTreeModelSortHandleSignalStructs.RowsReorderedSignal> Signal_RowsReordered(this GtkTreeModelSortHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelSortHandleSignalStructs.RowsReorderedSignal> obs) =>
		{
			GtkTreeModelSortHandleSignalDelegates.rows_reordered handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr new_order,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelSortHandleSignalStructs.RowsReorderedSignal()
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

	public static IObservable<GtkTreeModelSortHandleSignalStructs.SortColumnChangedSignal> Signal_SortColumnChanged(this GtkTreeModelSortHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeModelSortHandleSignalStructs.SortColumnChangedSignal> obs) =>
		{
			GtkTreeModelSortHandleSignalDelegates.sort_column_changed handler = ( MentorLake.Gtk.GtkTreeSortableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeModelSortHandleSignalStructs.SortColumnChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "sort-column-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTreeModelSortHandleSignalStructs
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

public class SortColumnChangedSignal
{
	public MentorLake.Gtk.GtkTreeSortableHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTreeModelSortHandleSignalDelegates
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


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void sort_column_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSortableHandleImpl>))] MentorLake.Gtk.GtkTreeSortableHandle self, IntPtr user_data);

}


public static class GtkTreeModelSortHandleExtensions
{
	public static T ClearCache<T>(this T tree_model_sort) where T : GtkTreeModelSortHandle
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		GtkTreeModelSortHandleExterns.gtk_tree_model_sort_clear_cache(tree_model_sort);
		return tree_model_sort;
	}

	public static bool ConvertChildIterToIter(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, out MentorLake.Gtk.GtkTreeIter sort_iter, MentorLake.Gtk.GtkTreeIterHandle child_iter)
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_child_iter_to_iter(tree_model_sort, out sort_iter, child_iter);
	}

	public static MentorLake.Gtk.GtkTreePathHandle ConvertChildPathToPath(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreePathHandle child_path)
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_child_path_to_path(tree_model_sort, child_path);
	}

	public static T ConvertIterToChildIter<T>(this T tree_model_sort, out MentorLake.Gtk.GtkTreeIter child_iter, MentorLake.Gtk.GtkTreeIterHandle sorted_iter) where T : GtkTreeModelSortHandle
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_iter_to_child_iter(tree_model_sort, out child_iter, sorted_iter);
		return tree_model_sort;
	}

	public static MentorLake.Gtk.GtkTreePathHandle ConvertPathToChildPath(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreePathHandle sorted_path)
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_path_to_child_path(tree_model_sort, sorted_path);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_get_model(tree_model);
	}

	public static bool IterIsValid(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_iter_is_valid(tree_model_sort, iter);
	}

	public static T ResetDefaultSortFunc<T>(this T tree_model_sort) where T : GtkTreeModelSortHandle
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		GtkTreeModelSortHandleExterns.gtk_tree_model_sort_reset_default_sort_func(tree_model_sort);
		return tree_model_sort;
	}

}

internal class GtkTreeModelSortHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeModelSortHandle gtk_tree_model_sort_new_with_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle child_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_sort_clear_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_sort_convert_child_iter_to_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, out MentorLake.Gtk.GtkTreeIter sort_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle child_iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_sort_convert_child_path_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle child_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_sort_convert_iter_to_child_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, out MentorLake.Gtk.GtkTreeIter child_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle sorted_iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_sort_convert_path_to_child_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle sorted_path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_tree_model_sort_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_sort_iter_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_sort_reset_default_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort);

}
