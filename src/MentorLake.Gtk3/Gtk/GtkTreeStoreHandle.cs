namespace MentorLake.Gtk;

public class GtkTreeStoreHandle : GObjectHandle, GtkBuildableHandle, GtkTreeDragDestHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
	public static MentorLake.Gtk.GtkTreeStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkTreeStoreHandleExterns.gtk_tree_store_new(n_columns, @__arglist);
	}

	public static MentorLake.Gtk.GtkTreeStoreHandle Newv(int n_columns, MentorLake.GObject.GType[] types)
	{
		return GtkTreeStoreHandleExterns.gtk_tree_store_newv(n_columns, types);
	}

}
public static class GtkTreeStoreHandleSignalExtensions
{

	public static IObservable<GtkTreeStoreHandleSignalStructs.RowChangedSignal> Signal_RowChanged(this GtkTreeStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeStoreHandleSignalStructs.RowChangedSignal> obs) =>
		{
			GtkTreeStoreHandleSignalDelegates.row_changed handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeStoreHandleSignalStructs.RowChangedSignal()
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

	public static IObservable<GtkTreeStoreHandleSignalStructs.RowDeletedSignal> Signal_RowDeleted(this GtkTreeStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeStoreHandleSignalStructs.RowDeletedSignal> obs) =>
		{
			GtkTreeStoreHandleSignalDelegates.row_deleted handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeStoreHandleSignalStructs.RowDeletedSignal()
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

	public static IObservable<GtkTreeStoreHandleSignalStructs.RowHasChildToggledSignal> Signal_RowHasChildToggled(this GtkTreeStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeStoreHandleSignalStructs.RowHasChildToggledSignal> obs) =>
		{
			GtkTreeStoreHandleSignalDelegates.row_has_child_toggled handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeStoreHandleSignalStructs.RowHasChildToggledSignal()
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

	public static IObservable<GtkTreeStoreHandleSignalStructs.RowInsertedSignal> Signal_RowInserted(this GtkTreeStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeStoreHandleSignalStructs.RowInsertedSignal> obs) =>
		{
			GtkTreeStoreHandleSignalDelegates.row_inserted handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeStoreHandleSignalStructs.RowInsertedSignal()
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

	public static IObservable<GtkTreeStoreHandleSignalStructs.RowsReorderedSignal> Signal_RowsReordered(this GtkTreeStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeStoreHandleSignalStructs.RowsReorderedSignal> obs) =>
		{
			GtkTreeStoreHandleSignalDelegates.rows_reordered handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr new_order,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeStoreHandleSignalStructs.RowsReorderedSignal()
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

	public static IObservable<GtkTreeStoreHandleSignalStructs.SortColumnChangedSignal> Signal_SortColumnChanged(this GtkTreeStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeStoreHandleSignalStructs.SortColumnChangedSignal> obs) =>
		{
			GtkTreeStoreHandleSignalDelegates.sort_column_changed handler = ( MentorLake.Gtk.GtkTreeSortableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeStoreHandleSignalStructs.SortColumnChangedSignal()
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

public static class GtkTreeStoreHandleSignalStructs
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

public static class GtkTreeStoreHandleSignalDelegates
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


public static class GtkTreeStoreHandleExtensions
{
	public static T Append<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_append(tree_store, out iter, parent);
		return tree_store;
	}

	public static T Clear<T>(this T tree_store) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_clear(tree_store);
		return tree_store;
	}

	public static T Insert<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, int position) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert(tree_store, out iter, parent, position);
		return tree_store;
	}

	public static T InsertAfter<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, MentorLake.Gtk.GtkTreeIterHandle sibling) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert_after(tree_store, out iter, parent, sibling);
		return tree_store;
	}

	public static T InsertBefore<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, MentorLake.Gtk.GtkTreeIterHandle sibling) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert_before(tree_store, out iter, parent, sibling);
		return tree_store;
	}

	public static T InsertWithValues<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, int position, IntPtr @__arglist) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert_with_values(tree_store, out iter, parent, position, @__arglist);
		return tree_store;
	}

	public static T InsertWithValuesv<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, int position, int[] columns, MentorLake.GObject.GValue[] values, int n_values) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert_with_valuesv(tree_store, out iter, parent, position, columns, values, n_values);
		return tree_store;
	}

	public static bool IsAncestor(this MentorLake.Gtk.GtkTreeStoreHandle tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle descendant)
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		return GtkTreeStoreHandleExterns.gtk_tree_store_is_ancestor(tree_store, iter, descendant);
	}

	public static int IterDepth(this MentorLake.Gtk.GtkTreeStoreHandle tree_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		return GtkTreeStoreHandleExterns.gtk_tree_store_iter_depth(tree_store, iter);
	}

	public static bool IterIsValid(this MentorLake.Gtk.GtkTreeStoreHandle tree_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		return GtkTreeStoreHandleExterns.gtk_tree_store_iter_is_valid(tree_store, iter);
	}

	public static T MoveAfter<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle position) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_move_after(tree_store, iter, position);
		return tree_store;
	}

	public static T MoveBefore<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle position) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_move_before(tree_store, iter, position);
		return tree_store;
	}

	public static T Prepend<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_prepend(tree_store, out iter, parent);
		return tree_store;
	}

	public static bool Remove(this MentorLake.Gtk.GtkTreeStoreHandle tree_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		return GtkTreeStoreHandleExterns.gtk_tree_store_remove(tree_store, iter);
	}

	public static T Reorder<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle parent, int[] new_order) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_reorder(tree_store, parent, new_order);
		return tree_store;
	}

	public static T Set<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set(tree_store, iter, @__arglist);
		return tree_store;
	}

	public static T SetColumnTypes<T>(this T tree_store, int n_columns, MentorLake.GObject.GType[] types) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set_column_types(tree_store, n_columns, types);
		return tree_store;
	}

	public static T SetValist<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set_valist(tree_store, iter, var_args);
		return tree_store;
	}

	public static T SetValue<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, int column, MentorLake.GObject.GValueHandle value) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set_value(tree_store, iter, column, value);
		return tree_store;
	}

	public static T SetValuesv<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, int[] columns, MentorLake.GObject.GValue[] values, int n_values) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set_valuesv(tree_store, iter, columns, values, n_values);
		return tree_store;
	}

	public static T Swap<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle a, MentorLake.Gtk.GtkTreeIterHandle b) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_swap(tree_store, a, b);
		return tree_store;
	}

}

internal class GtkTreeStoreHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeStoreHandle gtk_tree_store_new(int n_columns, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeStoreHandle gtk_tree_store_newv(int n_columns, MentorLake.GObject.GType[] types);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_insert_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_insert_with_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent, int position, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_insert_with_valuesv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent, int position, int[] columns, MentorLake.GObject.GValue[] values, int n_values);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_store_is_ancestor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle descendant);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_store_iter_depth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_store_iter_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_move_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_move_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_store_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_reorder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent, int[] new_order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_set_column_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, int n_columns, MentorLake.GObject.GType[] types);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_set_valuesv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int[] columns, MentorLake.GObject.GValue[] values, int n_values);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_store_swap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeStoreHandle>))] MentorLake.Gtk.GtkTreeStoreHandle tree_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle b);

}
