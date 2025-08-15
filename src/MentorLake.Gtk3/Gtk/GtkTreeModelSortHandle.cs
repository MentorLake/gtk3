namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkTreeModelSort is a model which implements the #GtkTreeSortable
/// interface.  It does not hold any data itself, but rather is created with
/// a child model and proxies its data.  It has identical column types to
/// this child model, and the changes in the child are propagated.  The
/// primary purpose of this model is to provide a way to sort a different
/// model without modifying it. Note that the sort function used by
/// #GtkTreeModelSort is not guaranteed to be stable.
/// </para>
/// <para>
/// The use of this is best demonstrated through an example.  In the
/// following sample code we create two #GtkTreeView widgets each with a
/// view of the same data.  As the model is wrapped here by a
/// #GtkTreeModelSort, the two #GtkTreeViews can each sort their
/// view of the data without affecting the other.  By contrast, if we
/// simply put the same model in each widget, then sorting the first would
/// sort the second.
/// </para>
/// <para>
/// ## Using a #GtkTreeModelSort
/// </para>
/// <code>
/// {
/// {
///   GtkTreeView *tree_view1;
///   GtkTreeView *tree_view2;
///   GtkTreeModel *sort_model1;
///   GtkTreeModel *sort_model2;
///   GtkTreeModel *child_model;
/// 
///   // get the child model
///   child_model = get_my_model ();
/// 
///   // Create the first tree
///   sort_model1 = gtk_tree_model_sort_new_with_model (child_model);
///   tree_view1 = gtk_tree_view_new_with_model (sort_model1);
/// 
///   // Create the second tree
///   sort_model2 = gtk_tree_model_sort_new_with_model (child_model);
///   tree_view2 = gtk_tree_view_new_with_model (sort_model2);
/// 
///   // Now we can sort the two models independently
///   gtk_tree_sortable_set_sort_column_id (GTK_TREE_SORTABLE (sort_model1),
///                                         COLUMN_1, GTK_SORT_ASCENDING);
///   gtk_tree_sortable_set_sort_column_id (GTK_TREE_SORTABLE (sort_model2),
///                                         COLUMN_1, GTK_SORT_DESCENDING);
/// }
/// </code>
/// <para>
/// To demonstrate how to access the underlying child model from the sort
/// model, the next example will be a callback for the #GtkTreeSelection
/// #GtkTreeSelection::changed signal.  In this callback, we get a string
/// from COLUMN_1 of the model.  We then modify the string, find the same
/// selected row on the child model, and change the row there.
/// </para>
/// <para>
/// ## Accessing the child model of in a selection changed callback
/// </para>
/// <code>
/// void
/// void
/// selection_changed (GtkTreeSelection *selection, gpointer data)
/// {
///   GtkTreeModel *sort_model = NULL;
///   GtkTreeModel *child_model;
///   GtkTreeIter sort_iter;
///   GtkTreeIter child_iter;
///   char *some_data = NULL;
///   char *modified_data;
/// 
///   // Get the current selected row and the model.
///   if (! gtk_tree_selection_get_selected (selection,
///                                          &amp;sort_model,
///                                          &amp;sort_iter))
///     return;
/// 
///   // Look up the current value on the selected row and get
///   // a new value to change it to.
///   gtk_tree_model_get (GTK_TREE_MODEL (sort_model), &amp;sort_iter,
///                       COLUMN_1, &amp;some_data,
///                       -1);
/// 
///   modified_data = change_the_data (some_data);
///   g_free (some_data);
/// 
///   // Get an iterator on the child model, instead of the sort model.
///   gtk_tree_model_sort_convert_iter_to_child_iter (GTK_TREE_MODEL_SORT (sort_model),
///                                                   &amp;child_iter,
///                                                   &amp;sort_iter);
/// 
///   // Get the child model and change the value of the row. In this
///   // example, the child model is a GtkListStore. It could be any other
///   // type of model, though.
///   child_model = gtk_tree_model_sort_get_model (GTK_TREE_MODEL_SORT (sort_model));
///   gtk_list_store_set (GTK_LIST_STORE (child_model), &amp;child_iter,
///                       COLUMN_1, &amp;modified_data,
///                       -1);
///   g_free (modified_data);
/// }
/// </code>
/// </summary>

public class GtkTreeModelSortHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTreeModelSort, with @child_model as the child model.
/// </para>
/// </summary>

/// <param name="child_model">
/// A #GtkTreeModel
/// </param>
/// <return>
/// A new #GtkTreeModelSort.
/// </return>

	public static MentorLake.Gtk.GtkTreeModelSortHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle child_model)
	{
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_new_with_model(child_model);
	}

}
public static class GtkTreeModelSortHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when a row in the model has changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when a row has been deleted.
/// </para>
/// <para>
/// Note that no iterator is passed to the signal handler,
/// since the row is already deleted.
/// </para>
/// <para>
/// This should be called by models after a row has been removed.
/// The location pointed to by @path should be the location that
/// the row previously was at. It may not be a valid location anymore.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when a row has gotten the first child
/// row or lost its last child row.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when a new row has been inserted in
/// the model.
/// </para>
/// <para>
/// Note that the row may still be empty at this point, since
/// it is a common pattern to first insert an empty row, and
/// then fill it with the desired values.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when the children of a node in the
/// #GtkTreeModel have been reordered.
/// </para>
/// <para>
/// Note that this signal is not emitted
/// when rows are reordered by DND, since this is implemented
/// by removing and then reinserting the row.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::sort-column-changed signal is emitted when the sort column
/// or sort order of @sortable is changed. The signal is emitted before
/// the contents of @sortable are resorted.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// a #GtkTreePath-struct identifying the changed row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;
/// <summary>
/// <para>
/// a valid #GtkTreeIter-struct pointing to the changed row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;

	public IntPtr UserData;
}

public class RowDeletedSignal
{

	public MentorLake.Gtk.GtkTreeModelHandle Self;
/// <summary>
/// <para>
/// a #GtkTreePath-struct identifying the row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;

	public IntPtr UserData;
}

public class RowHasChildToggledSignal
{

	public MentorLake.Gtk.GtkTreeModelHandle Self;
/// <summary>
/// <para>
/// a #GtkTreePath-struct identifying the row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;
/// <summary>
/// <para>
/// a valid #GtkTreeIter-struct pointing to the row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;

	public IntPtr UserData;
}

public class RowInsertedSignal
{

	public MentorLake.Gtk.GtkTreeModelHandle Self;
/// <summary>
/// <para>
/// a #GtkTreePath-struct identifying the new row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;
/// <summary>
/// <para>
/// a valid #GtkTreeIter-struct pointing to the new row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;

	public IntPtr UserData;
}

public class RowsReorderedSignal
{

	public MentorLake.Gtk.GtkTreeModelHandle Self;
/// <summary>
/// <para>
/// a #GtkTreePath-struct identifying the tree node whose children
///     have been reordered
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;
/// <summary>
/// <para>
/// a valid #GtkTreeIter-struct pointing to the node whose children
///     have been reordered, or %NULL if the depth of @path is 0
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;
/// <summary>
/// <para>
/// an array of integers mapping the current position
///     of each child to its old position before the re-ordering,
///     i.e. @new_order`[newpos] = oldpos`
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// This signal is emitted when a row in the model has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct identifying the changed row
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the changed row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a row has been deleted.
/// </para>
/// <para>
/// Note that no iterator is passed to the signal handler,
/// since the row is already deleted.
/// </para>
/// <para>
/// This should be called by models after a row has been removed.
/// The location pointed to by @path should be the location that
/// the row previously was at. It may not be a valid location anymore.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct identifying the row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a row has gotten the first child
/// row or lost its last child row.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct identifying the row
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_has_child_toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a new row has been inserted in
/// the model.
/// </para>
/// <para>
/// Note that the row may still be empty at this point, since
/// it is a common pattern to first insert an empty row, and
/// then fill it with the desired values.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct identifying the new row
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the new row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the children of a node in the
/// #GtkTreeModel have been reordered.
/// </para>
/// <para>
/// Note that this signal is not emitted
/// when rows are reordered by DND, since this is implemented
/// by removing and then reinserting the row.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct identifying the tree node whose children
///     have been reordered
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the node whose children
///     have been reordered, or %NULL if the depth of @path is 0
/// </param>
/// <param name="new_order">
/// an array of integers mapping the current position
///     of each child to its old position before the re-ordering,
///     i.e. @new_order`[newpos] = oldpos`
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void rows_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr new_order, IntPtr user_data);


/// <summary>
/// <para>
/// The ::sort-column-changed signal is emitted when the sort column
/// or sort order of @sortable is changed. The signal is emitted before
/// the contents of @sortable are resorted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void sort_column_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSortableHandleImpl>))] MentorLake.Gtk.GtkTreeSortableHandle self, IntPtr user_data);

}


public static class GtkTreeModelSortHandleExtensions
{
/// <summary>
/// <para>
/// This function should almost never be called.  It clears the @tree_model_sort
/// of any cached iterators that haven’t been reffed with
/// gtk_tree_model_ref_node().  This might be useful if the child model being
/// sorted is static (and doesn’t change often) and there has been a lot of
/// unreffed access to nodes.  As a side effect of this function, all unreffed
/// iters will be invalid.
/// </para>
/// </summary>

/// <param name="tree_model_sort">
/// A #GtkTreeModelSort
/// </param>

	public static T ClearCache<T>(this T tree_model_sort) where T : GtkTreeModelSortHandle
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		GtkTreeModelSortHandleExterns.gtk_tree_model_sort_clear_cache(tree_model_sort);
		return tree_model_sort;
	}

/// <summary>
/// <para>
/// Sets @sort_iter to point to the row in @tree_model_sort that corresponds to
/// the row pointed at by @child_iter.  If @sort_iter was not set, %FALSE
/// is returned.  Note: a boolean is only returned since 2.14.
/// </para>
/// </summary>

/// <param name="tree_model_sort">
/// A #GtkTreeModelSort
/// </param>
/// <param name="sort_iter">
/// An uninitialized #GtkTreeIter.
/// </param>
/// <param name="child_iter">
/// A valid #GtkTreeIter pointing to a row on the child model
/// </param>
/// <return>
/// %TRUE, if @sort_iter was set, i.e. if @sort_iter is a
/// valid iterator pointer to a visible row in the child model.
/// </return>

	public static bool ConvertChildIterToIter(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, out MentorLake.Gtk.GtkTreeIter sort_iter, MentorLake.Gtk.GtkTreeIterHandle child_iter)
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_child_iter_to_iter(tree_model_sort, out sort_iter, child_iter);
	}

/// <summary>
/// <para>
/// Converts @child_path to a path relative to @tree_model_sort.  That is,
/// @child_path points to a path in the child model.  The returned path will
/// point to the same row in the sorted model.  If @child_path isn’t a valid
/// path on the child model, then %NULL is returned.
/// </para>
/// </summary>

/// <param name="tree_model_sort">
/// A #GtkTreeModelSort
/// </param>
/// <param name="child_path">
/// A #GtkTreePath to convert
/// </param>
/// <return>
/// A newly allocated #GtkTreePath, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle ConvertChildPathToPath(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreePathHandle child_path)
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_child_path_to_path(tree_model_sort, child_path);
	}

/// <summary>
/// <para>
/// Sets @child_iter to point to the row pointed to by @sorted_iter.
/// </para>
/// </summary>

/// <param name="tree_model_sort">
/// A #GtkTreeModelSort
/// </param>
/// <param name="child_iter">
/// An uninitialized #GtkTreeIter
/// </param>
/// <param name="sorted_iter">
/// A valid #GtkTreeIter pointing to a row on @tree_model_sort.
/// </param>

	public static T ConvertIterToChildIter<T>(this T tree_model_sort, out MentorLake.Gtk.GtkTreeIter child_iter, MentorLake.Gtk.GtkTreeIterHandle sorted_iter) where T : GtkTreeModelSortHandle
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_iter_to_child_iter(tree_model_sort, out child_iter, sorted_iter);
		return tree_model_sort;
	}

/// <summary>
/// <para>
/// Converts @sorted_path to a path on the child model of @tree_model_sort.
/// That is, @sorted_path points to a location in @tree_model_sort.  The
/// returned path will point to the same location in the model not being
/// sorted.  If @sorted_path does not point to a location in the child model,
/// %NULL is returned.
/// </para>
/// </summary>

/// <param name="tree_model_sort">
/// A #GtkTreeModelSort
/// </param>
/// <param name="sorted_path">
/// A #GtkTreePath to convert
/// </param>
/// <return>
/// A newly allocated #GtkTreePath, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle ConvertPathToChildPath(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreePathHandle sorted_path)
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_path_to_child_path(tree_model_sort, sorted_path);
	}

/// <summary>
/// <para>
/// Returns the model the #GtkTreeModelSort is sorting.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModelSort
/// </param>
/// <return>
/// the &quot;child model&quot; being sorted
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_get_model(tree_model);
	}

/// <summary>
/// <para>
/// &amp;gt; This function is slow. Only use it for debugging and/or testing
/// &amp;gt; purposes.
/// </para>
/// <para>
/// Checks if the given iter is a valid iter for this #GtkTreeModelSort.
/// </para>
/// </summary>

/// <param name="tree_model_sort">
/// A #GtkTreeModelSort.
/// </param>
/// <param name="iter">
/// A #GtkTreeIter.
/// </param>
/// <return>
/// %TRUE if the iter is valid, %FALSE if the iter is invalid.
/// </return>

	public static bool IterIsValid(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_model_sort.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelSortHandle)");
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_iter_is_valid(tree_model_sort, iter);
	}

/// <summary>
/// <para>
/// This resets the default sort function to be in the “unsorted” state.  That
/// is, it is in the same order as the child model. It will re-sort the model
/// to be in the same order as the child model only if the #GtkTreeModelSort
/// is in “unsorted” state.
/// </para>
/// </summary>

/// <param name="tree_model_sort">
/// A #GtkTreeModelSort
/// </param>

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
