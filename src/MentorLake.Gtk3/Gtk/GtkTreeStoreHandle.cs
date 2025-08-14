namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkTreeStore object is a list model for use with a #GtkTreeView
/// widget.  It implements the #GtkTreeModel interface, and consequentially,
/// can use all of the methods available there.  It also implements the
/// #GtkTreeSortable interface so it can be sorted by the view.  Finally,
/// it also implements the tree
/// [drag and drop][gtk3-GtkTreeView-drag-and-drop]
/// interfaces.
/// </para>
/// <para>
/// # GtkTreeStore as GtkBuildable
/// </para>
/// <para>
/// The GtkTreeStore implementation of the #GtkBuildable interface allows
/// to specify the model columns with a `<columns>` element that may contain
/// multiple `<column>` elements, each specifying one model column. The “type”
/// attribute specifies the data type for the column.
/// </para>
/// <para>
/// An example of a UI Definition fragment for a tree store:
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <object class="GtkTreeStore">
///   <columns>
///     <column type="gchararray"/>
///     <column type="gchararray"/>
///     <column type="gint"/>
///   </columns>
/// </object>
/// ]|
/// </para>
/// </summary>

public class GtkTreeStoreHandle : GObjectHandle, GtkBuildableHandle, GtkTreeDragDestHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
/// <summary>
/// <para>
/// Creates a new tree store as with @n_columns columns each of the types passed
/// in.  Note that only types derived from standard GObject fundamental types
/// are supported.
/// </para>
/// <para>
/// As an example, `gtk_tree_store_new (3, G_TYPE_INT, G_TYPE_STRING,
/// GDK_TYPE_PIXBUF);` will create a new #GtkTreeStore with three columns, of type
/// #gint, #gchararray, and #GdkPixbuf respectively.
/// </para>
/// </summary>

/// <param name="n_columns">
/// number of columns in the tree store
/// </param>
/// <param name="@__arglist">
/// all #GType types for the columns, from first to last
/// </param>
/// <return>
/// a new #GtkTreeStore
/// </return>

	public static MentorLake.Gtk.GtkTreeStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkTreeStoreHandleExterns.gtk_tree_store_new(n_columns, @__arglist);
	}

/// <summary>
/// <para>
/// Non vararg creation function.  Used primarily by language bindings.
/// </para>
/// </summary>

/// <param name="n_columns">
/// number of columns in the tree store
/// </param>
/// <param name="types">
/// an array of #GType types for the columns, from first to last
/// </param>
/// <return>
/// a new #GtkTreeStore
/// </return>

	public static MentorLake.Gtk.GtkTreeStoreHandle Newv(int n_columns, MentorLake.GObject.GType[] types)
	{
		return GtkTreeStoreHandleExterns.gtk_tree_store_newv(n_columns, types);
	}

}
public static class GtkTreeStoreHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when a row in the model has changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when a row has gotten the first child
/// row or lost its last child row.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::sort-column-changed signal is emitted when the sort column
/// or sort order of @sortable is changed. The signal is emitted before
/// the contents of @sortable are resorted.
/// </para>
/// </summary>

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

public static class GtkTreeStoreHandleSignalDelegates
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


public static class GtkTreeStoreHandleExtensions
{
/// <summary>
/// <para>
/// Appends a new row to @tree_store.  If @parent is non-%NULL, then it will append the
/// new row after the last child of @parent, otherwise it will append a row to
/// the top level.  @iter will be changed to point to this new row.  The row will
/// be empty after this function is called.  To fill in values, you need to call
/// gtk_tree_store_set() or gtk_tree_store_set_value().
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the appended row
/// </param>
/// <param name="parent">
/// A valid #GtkTreeIter, or %NULL
/// </param>

	public static T Append<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_append(tree_store, out iter, parent);
		return tree_store;
	}

/// <summary>
/// <para>
/// Removes all rows from @tree_store
/// </para>
/// </summary>

/// <param name="tree_store">
/// a #GtkTreeStore
/// </param>

	public static T Clear<T>(this T tree_store) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_clear(tree_store);
		return tree_store;
	}

/// <summary>
/// <para>
/// Creates a new row at @position.  If parent is non-%NULL, then the row will be
/// made a child of @parent.  Otherwise, the row will be created at the toplevel.
/// If @position is -1 or is larger than the number of rows at that level, then
/// the new row will be inserted to the end of the list.  @iter will be changed
/// to point to this new row.  The row will be empty after this function is
/// called.  To fill in values, you need to call gtk_tree_store_set() or
/// gtk_tree_store_set_value().
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the new row
/// </param>
/// <param name="parent">
/// A valid #GtkTreeIter, or %NULL
/// </param>
/// <param name="position">
/// position to insert the new row, or -1 for last
/// </param>

	public static T Insert<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, int position) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert(tree_store, out iter, parent, position);
		return tree_store;
	}

/// <summary>
/// <para>
/// Inserts a new row after @sibling.  If @sibling is %NULL, then the row will be
/// prepended to @parent ’s children.  If @parent and @sibling are %NULL, then
/// the row will be prepended to the toplevel.  If both @sibling and @parent are
/// set, then @parent must be the parent of @sibling.  When @sibling is set,
/// @parent is optional.
/// </para>
/// <para>
/// @iter will be changed to point to this new row.  The row will be empty after
/// this function is called.  To fill in values, you need to call
/// gtk_tree_store_set() or gtk_tree_store_set_value().
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the new row
/// </param>
/// <param name="parent">
/// A valid #GtkTreeIter, or %NULL
/// </param>
/// <param name="sibling">
/// A valid #GtkTreeIter, or %NULL
/// </param>

	public static T InsertAfter<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, MentorLake.Gtk.GtkTreeIterHandle sibling) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert_after(tree_store, out iter, parent, sibling);
		return tree_store;
	}

/// <summary>
/// <para>
/// Inserts a new row before @sibling.  If @sibling is %NULL, then the row will
/// be appended to @parent ’s children.  If @parent and @sibling are %NULL, then
/// the row will be appended to the toplevel.  If both @sibling and @parent are
/// set, then @parent must be the parent of @sibling.  When @sibling is set,
/// @parent is optional.
/// </para>
/// <para>
/// @iter will be changed to point to this new row.  The row will be empty after
/// this function is called.  To fill in values, you need to call
/// gtk_tree_store_set() or gtk_tree_store_set_value().
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the new row
/// </param>
/// <param name="parent">
/// A valid #GtkTreeIter, or %NULL
/// </param>
/// <param name="sibling">
/// A valid #GtkTreeIter, or %NULL
/// </param>

	public static T InsertBefore<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, MentorLake.Gtk.GtkTreeIterHandle sibling) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert_before(tree_store, out iter, parent, sibling);
		return tree_store;
	}

/// <summary>
/// <para>
/// Creates a new row at @position. @iter will be changed to point to this
/// new row. If @position is -1, or larger than the number of rows on the list, then
/// the new row will be appended to the list. The row will be filled with
/// the values given to this function.
/// </para>
/// <para>
/// Calling
/// `gtk_tree_store_insert_with_values (tree_store, iter, position, ...)`
/// has the same effect as calling
/// |[<!-- language="C" -->
/// gtk_tree_store_insert (tree_store, iter, position);
/// gtk_tree_store_set (tree_store, iter, ...);
/// ]|
/// with the different that the former will only emit a row_inserted signal,
/// while the latter will emit row_inserted, row_changed and if the tree store
/// is sorted, rows_reordered.  Since emitting the rows_reordered signal
/// repeatedly can affect the performance of the program,
/// gtk_tree_store_insert_with_values() should generally be preferred when
/// inserting rows in a sorted tree store.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set the new row, or %NULL.
/// </param>
/// <param name="parent">
/// A valid #GtkTreeIter, or %NULL
/// </param>
/// <param name="position">
/// position to insert the new row, or -1 to append after existing rows
/// </param>
/// <param name="@__arglist">
/// pairs of column number and value, terminated with -1
/// </param>

	public static T InsertWithValues<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, int position, IntPtr @__arglist) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert_with_values(tree_store, out iter, parent, position, @__arglist);
		return tree_store;
	}

/// <summary>
/// <para>
/// A variant of gtk_tree_store_insert_with_values() which takes
/// the columns and values as two arrays, instead of varargs.  This
/// function is mainly intended for language bindings.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set the new row, or %NULL.
/// </param>
/// <param name="parent">
/// A valid #GtkTreeIter, or %NULL
/// </param>
/// <param name="position">
/// position to insert the new row, or -1 for last
/// </param>
/// <param name="columns">
/// an array of column numbers
/// </param>
/// <param name="values">
/// an array of GValues
/// </param>
/// <param name="n_values">
/// the length of the @columns and @values arrays
/// </param>

	public static T InsertWithValuesv<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, int position, int[] columns, MentorLake.GObject.GValue[] values, int n_values) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_insert_with_valuesv(tree_store, out iter, parent, position, columns, values, n_values);
		return tree_store;
	}

/// <summary>
/// <para>
/// Returns %TRUE if @iter is an ancestor of @descendant.  That is, @iter is the
/// parent (or grandparent or great-grandparent) of @descendant.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter
/// </param>
/// <param name="descendant">
/// A valid #GtkTreeIter
/// </param>
/// <return>
/// %TRUE, if @iter is an ancestor of @descendant
/// </return>

	public static bool IsAncestor(this MentorLake.Gtk.GtkTreeStoreHandle tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle descendant)
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		return GtkTreeStoreHandleExterns.gtk_tree_store_is_ancestor(tree_store, iter, descendant);
	}

/// <summary>
/// <para>
/// Returns the depth of @iter.  This will be 0 for anything on the root level, 1
/// for anything down a level, etc.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter
/// </param>
/// <return>
/// The depth of @iter
/// </return>

	public static int IterDepth(this MentorLake.Gtk.GtkTreeStoreHandle tree_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		return GtkTreeStoreHandleExterns.gtk_tree_store_iter_depth(tree_store, iter);
	}

/// <summary>
/// <para>
/// WARNING: This function is slow. Only use it for debugging and/or testing
/// purposes.
/// </para>
/// <para>
/// Checks if the given iter is a valid iter for this #GtkTreeStore.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore.
/// </param>
/// <param name="iter">
/// A #GtkTreeIter.
/// </param>
/// <return>
/// %TRUE if the iter is valid, %FALSE if the iter is invalid.
/// </return>

	public static bool IterIsValid(this MentorLake.Gtk.GtkTreeStoreHandle tree_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		return GtkTreeStoreHandleExterns.gtk_tree_store_iter_is_valid(tree_store, iter);
	}

/// <summary>
/// <para>
/// Moves @iter in @tree_store to the position after @position. @iter and
/// @position should be in the same level. Note that this function only
/// works with unsorted stores. If @position is %NULL, @iter will be moved
/// to the start of the level.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore.
/// </param>
/// <param name="iter">
/// A #GtkTreeIter.
/// </param>
/// <param name="position">
/// A #GtkTreeIter.
/// </param>

	public static T MoveAfter<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle position) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_move_after(tree_store, iter, position);
		return tree_store;
	}

/// <summary>
/// <para>
/// Moves @iter in @tree_store to the position before @position. @iter and
/// @position should be in the same level. Note that this function only
/// works with unsorted stores. If @position is %NULL, @iter will be
/// moved to the end of the level.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore.
/// </param>
/// <param name="iter">
/// A #GtkTreeIter.
/// </param>
/// <param name="position">
/// A #GtkTreeIter or %NULL.
/// </param>

	public static T MoveBefore<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle position) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_move_before(tree_store, iter, position);
		return tree_store;
	}

/// <summary>
/// <para>
/// Prepends a new row to @tree_store.  If @parent is non-%NULL, then it will prepend
/// the new row before the first child of @parent, otherwise it will prepend a row
/// to the top level.  @iter will be changed to point to this new row.  The row
/// will be empty after this function is called.  To fill in values, you need to
/// call gtk_tree_store_set() or gtk_tree_store_set_value().
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the prepended row
/// </param>
/// <param name="parent">
/// A valid #GtkTreeIter, or %NULL
/// </param>

	public static T Prepend<T>(this T tree_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_prepend(tree_store, out iter, parent);
		return tree_store;
	}

/// <summary>
/// <para>
/// Removes @iter from @tree_store.  After being removed, @iter is set to the
/// next valid row at that level, or invalidated if it previously pointed to the
/// last one.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter
/// </param>
/// <return>
/// %TRUE if @iter is still valid, %FALSE if not.
/// </return>

	public static bool Remove(this MentorLake.Gtk.GtkTreeStoreHandle tree_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		return GtkTreeStoreHandleExterns.gtk_tree_store_remove(tree_store, iter);
	}

/// <summary>
/// <para>
/// Reorders the children of @parent in @tree_store to follow the order
/// indicated by @new_order. Note that this function only works with
/// unsorted stores.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="parent">
/// A #GtkTreeIter, or %NULL
/// </param>
/// <param name="new_order">
/// an array of integers mapping the new position of each child
///      to its old position before the re-ordering,
///      i.e. @new_order`[newpos] = oldpos`.
/// </param>

	public static T Reorder<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle parent, int[] new_order) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_reorder(tree_store, parent, new_order);
		return tree_store;
	}

/// <summary>
/// <para>
/// Sets the value of one or more cells in the row referenced by @iter.
/// The variable argument list should contain integer column numbers,
/// each column number followed by the value to be set.
/// The list is terminated by a -1. For example, to set column 0 with type
/// %G_TYPE_STRING to “Foo”, you would write
/// `gtk_tree_store_set (store, iter, 0, "Foo", -1)`.
/// </para>
/// <para>
/// The value will be referenced by the store if it is a %G_TYPE_OBJECT, and it
/// will be copied if it is a %G_TYPE_STRING or %G_TYPE_BOXED.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter for the row being modified
/// </param>
/// <param name="@__arglist">
/// pairs of column number and value, terminated with -1
/// </param>

	public static T Set<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set(tree_store, iter, @__arglist);
		return tree_store;
	}

/// <summary>
/// <para>
/// This function is meant primarily for #GObjects that inherit from
/// #GtkTreeStore, and should only be used when constructing a new
/// #GtkTreeStore.  It will not function after a row has been added,
/// or a method on the #GtkTreeModel interface is called.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="n_columns">
/// Number of columns for the tree store
/// </param>
/// <param name="types">
/// An array of #GType types, one for each column
/// </param>

	public static T SetColumnTypes<T>(this T tree_store, int n_columns, MentorLake.GObject.GType[] types) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set_column_types(tree_store, n_columns, types);
		return tree_store;
	}

/// <summary>
/// <para>
/// See gtk_tree_store_set(); this version takes a va_list for
/// use by language bindings.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter for the row being modified
/// </param>
/// <param name="var_args">
/// va_list of column/value pairs
/// </param>

	public static T SetValist<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set_valist(tree_store, iter, var_args);
		return tree_store;
	}

/// <summary>
/// <para>
/// Sets the data in the cell specified by @iter and @column.
/// The type of @value must be convertible to the type of the
/// column.
/// </para>
/// </summary>

/// <param name="tree_store">
/// a #GtkTreeStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter for the row being modified
/// </param>
/// <param name="column">
/// column number to modify
/// </param>
/// <param name="value">
/// new value for the cell
/// </param>

	public static T SetValue<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, int column, MentorLake.GObject.GValueHandle value) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set_value(tree_store, iter, column, value);
		return tree_store;
	}

/// <summary>
/// <para>
/// A variant of gtk_tree_store_set_valist() which takes
/// the columns and values as two arrays, instead of varargs.  This
/// function is mainly intended for language bindings or in case
/// the number of columns to change is not known until run-time.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter for the row being modified
/// </param>
/// <param name="columns">
/// an array of column numbers
/// </param>
/// <param name="values">
/// an array of GValues
/// </param>
/// <param name="n_values">
/// the length of the @columns and @values arrays
/// </param>

	public static T SetValuesv<T>(this T tree_store, MentorLake.Gtk.GtkTreeIterHandle iter, int[] columns, MentorLake.GObject.GValue[] values, int n_values) where T : GtkTreeStoreHandle
	{
		if (tree_store.IsInvalid) throw new Exception("Invalid handle (GtkTreeStoreHandle)");
		GtkTreeStoreHandleExterns.gtk_tree_store_set_valuesv(tree_store, iter, columns, values, n_values);
		return tree_store;
	}

/// <summary>
/// <para>
/// Swaps @a and @b in the same level of @tree_store. Note that this function
/// only works with unsorted stores.
/// </para>
/// </summary>

/// <param name="tree_store">
/// A #GtkTreeStore.
/// </param>
/// <param name="a">
/// A #GtkTreeIter.
/// </param>
/// <param name="b">
/// Another #GtkTreeIter.
/// </param>

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
