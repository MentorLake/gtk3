namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkListStore object is a list model for use with a #GtkTreeView
/// widget.  It implements the #GtkTreeModel interface, and consequentialy,
/// can use all of the methods available there.  It also implements the
/// #GtkTreeSortable interface so it can be sorted by the view.
/// Finally, it also implements the tree
/// [drag and drop][gtk3-GtkTreeView-drag-and-drop]
/// interfaces.
/// </para>
/// <para>
/// The #GtkListStore can accept most GObject types as a column type, though
/// it can’t accept all custom types.  Internally, it will keep a copy of
/// data passed in (such as a string or a boxed pointer).  Columns that
/// accept #GObjects are handled a little differently.  The
/// #GtkListStore will keep a reference to the object instead of copying the
/// value.  As a result, if the object is modified, it is up to the
/// application writer to call gtk_tree_model_row_changed() to emit the
/// #GtkTreeModel::row_changed signal.  This most commonly affects lists with
/// #GdkPixbufs stored.
/// </para>
/// <para>
/// An example for creating a simple list store:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// enum {
///   COLUMN_STRING,
///   COLUMN_INT,
///   COLUMN_BOOLEAN,
///   N_COLUMNS
/// };
/// </para>
/// <para>
/// {
///   GtkListStore *list_store;
///   GtkTreePath *path;
///   GtkTreeIter iter;
///   gint i;
/// </para>
/// <para>
///   list_store = gtk_list_store_new (N_COLUMNS,
///                                    G_TYPE_STRING,
///                                    G_TYPE_INT,
///                                    G_TYPE_BOOLEAN);
/// </para>
/// <para>
///   for (i = 0; i < 10; i++)
///     {
///       gchar *some_data;
/// </para>
/// <para>
///       some_data = get_some_data (i);
/// </para>
/// <para>
///       // Add a new row to the model
///       gtk_list_store_append (list_store, &iter);
///       gtk_list_store_set (list_store, &iter,
///                           COLUMN_STRING, some_data,
///                           COLUMN_INT, i,
///                           COLUMN_BOOLEAN,  FALSE,
///                           -1);
/// </para>
/// <para>
///       // As the store will keep a copy of the string internally,
///       // we free some_data.
///       g_free (some_data);
///     }
/// </para>
/// <para>
///   // Modify a particular row
///   path = gtk_tree_path_new_from_string ("4");
///   gtk_tree_model_get_iter (GTK_TREE_MODEL (list_store),
///                            &iter,
///                            path);
///   gtk_tree_path_free (path);
///   gtk_list_store_set (list_store, &iter,
///                       COLUMN_BOOLEAN, TRUE,
///                       -1);
/// }
/// ]|
/// </para>
/// <para>
/// # Performance Considerations
/// </para>
/// <para>
/// Internally, the #GtkListStore was implemented with a linked list with
/// a tail pointer prior to GTK+ 2.6.  As a result, it was fast at data
/// insertion and deletion, and not fast at random data access.  The
/// #GtkListStore sets the #GTK_TREE_MODEL_ITERS_PERSIST flag, which means
/// that #GtkTreeIters can be cached while the row exists.  Thus, if
/// access to a particular row is needed often and your code is expected to
/// run on older versions of GTK+, it is worth keeping the iter around.
/// </para>
/// <para>
/// # Atomic Operations
/// </para>
/// <para>
/// It is important to note that only the methods
/// gtk_list_store_insert_with_values() and gtk_list_store_insert_with_valuesv()
/// are atomic, in the sense that the row is being appended to the store and the
/// values filled in in a single operation with regard to #GtkTreeModel signaling.
/// In contrast, using e.g. gtk_list_store_append() and then gtk_list_store_set()
/// will first create a row, which triggers the #GtkTreeModel::row-inserted signal
/// on #GtkListStore. The row, however, is still empty, and any signal handler
/// connecting to #GtkTreeModel::row-inserted on this particular store should be prepared
/// for the situation that the row might be empty. This is especially important
/// if you are wrapping the #GtkListStore inside a #GtkTreeModelFilter and are
/// using a #GtkTreeModelFilterVisibleFunc. Using any of the non-atomic operations
/// to append rows to the #GtkListStore will cause the
/// #GtkTreeModelFilterVisibleFunc to be visited with an empty row first; the
/// function must be prepared for that.
/// </para>
/// <para>
/// # GtkListStore as GtkBuildable
/// </para>
/// <para>
/// The GtkListStore implementation of the GtkBuildable interface allows
/// to specify the model columns with a `<columns>` element that may contain
/// multiple `<column>` elements, each specifying one model column. The “type”
/// attribute specifies the data type for the column.
/// </para>
/// <para>
/// Additionally, it is possible to specify content for the list store
/// in the UI definition, with the `<data>` element. It can contain multiple
/// `<row>` elements, each specifying to content for one row of the list model.
/// Inside a `<row>`, the `<col>` elements specify the content for individual cells.
/// </para>
/// <para>
/// Note that it is probably more common to define your models in the code,
/// and one might consider it a layering violation to specify the content of
/// a list store in a UI definition, data, not presentation, and common wisdom
/// is to separate the two, as far as possible.
/// </para>
/// <para>
/// An example of a UI Definition fragment for a list store:
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <object class="GtkListStore">
///   <columns>
///     <column type="gchararray"/>
///     <column type="gchararray"/>
///     <column type="gint"/>
///   </columns>
///   <data>
///     <row>
///       <col id="0">John</col>
///       <col id="1">Doe</col>
///       <col id="2">25</col>
///     </row>
///     <row>
///       <col id="0">Johan</col>
///       <col id="1">Dahlin</col>
///       <col id="2">50</col>
///     </row>
///   </data>
/// </object>
/// ]|
/// </para>
/// </summary>

public class GtkListStoreHandle : GObjectHandle, GtkBuildableHandle, GtkTreeDragDestHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
/// <summary>
/// <para>
/// Creates a new list store as with @n_columns columns each of the types passed
/// in.  Note that only types derived from standard GObject fundamental types
/// are supported.
/// </para>
/// <para>
/// As an example, `gtk_list_store_new (3, G_TYPE_INT, G_TYPE_STRING,
/// GDK_TYPE_PIXBUF);` will create a new #GtkListStore with three columns, of type
/// int, string and #GdkPixbuf respectively.
/// </para>
/// </summary>

/// <param name="n_columns">
/// number of columns in the list store
/// </param>
/// <param name="@__arglist">
/// all #GType types for the columns, from first to last
/// </param>
/// <return>
/// a new #GtkListStore
/// </return>

	public static MentorLake.Gtk.GtkListStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkListStoreHandleExterns.gtk_list_store_new(n_columns, @__arglist);
	}

/// <summary>
/// <para>
/// Non-vararg creation function.  Used primarily by language bindings.
/// </para>
/// </summary>

/// <param name="n_columns">
/// number of columns in the list store
/// </param>
/// <param name="types">
/// an array of #GType types for the columns, from first to last
/// </param>
/// <return>
/// a new #GtkListStore
/// </return>

	public static MentorLake.Gtk.GtkListStoreHandle Newv(int n_columns, MentorLake.GObject.GType[] types)
	{
		return GtkListStoreHandleExterns.gtk_list_store_newv(n_columns, types);
	}

}
public static class GtkListStoreHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when a row in the model has changed.
/// </para>
/// </summary>

	public static IObservable<GtkListStoreHandleSignalStructs.RowChangedSignal> Signal_RowChanged(this GtkListStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListStoreHandleSignalStructs.RowChangedSignal> obs) =>
		{
			GtkListStoreHandleSignalDelegates.row_changed handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListStoreHandleSignalStructs.RowChangedSignal()
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

	public static IObservable<GtkListStoreHandleSignalStructs.RowDeletedSignal> Signal_RowDeleted(this GtkListStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListStoreHandleSignalStructs.RowDeletedSignal> obs) =>
		{
			GtkListStoreHandleSignalDelegates.row_deleted handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListStoreHandleSignalStructs.RowDeletedSignal()
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

	public static IObservable<GtkListStoreHandleSignalStructs.RowHasChildToggledSignal> Signal_RowHasChildToggled(this GtkListStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListStoreHandleSignalStructs.RowHasChildToggledSignal> obs) =>
		{
			GtkListStoreHandleSignalDelegates.row_has_child_toggled handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListStoreHandleSignalStructs.RowHasChildToggledSignal()
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

	public static IObservable<GtkListStoreHandleSignalStructs.RowInsertedSignal> Signal_RowInserted(this GtkListStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListStoreHandleSignalStructs.RowInsertedSignal> obs) =>
		{
			GtkListStoreHandleSignalDelegates.row_inserted handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListStoreHandleSignalStructs.RowInsertedSignal()
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

	public static IObservable<GtkListStoreHandleSignalStructs.RowsReorderedSignal> Signal_RowsReordered(this GtkListStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListStoreHandleSignalStructs.RowsReorderedSignal> obs) =>
		{
			GtkListStoreHandleSignalDelegates.rows_reordered handler = ( MentorLake.Gtk.GtkTreeModelHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr new_order,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListStoreHandleSignalStructs.RowsReorderedSignal()
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

	public static IObservable<GtkListStoreHandleSignalStructs.SortColumnChangedSignal> Signal_SortColumnChanged(this GtkListStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListStoreHandleSignalStructs.SortColumnChangedSignal> obs) =>
		{
			GtkListStoreHandleSignalDelegates.sort_column_changed handler = ( MentorLake.Gtk.GtkTreeSortableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListStoreHandleSignalStructs.SortColumnChangedSignal()
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

public static class GtkListStoreHandleSignalStructs
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

public static class GtkListStoreHandleSignalDelegates
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


public static class GtkListStoreHandleExtensions
{
/// <summary>
/// <para>
/// Appends a new row to @list_store.  @iter will be changed to point to this new
/// row.  The row will be empty after this function is called.  To fill in
/// values, you need to call gtk_list_store_set() or gtk_list_store_set_value().
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the appended row
/// </param>

	public static T Append<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_append(list_store, out iter);
		return list_store;
	}

/// <summary>
/// <para>
/// Removes all rows from the list store.
/// </para>
/// </summary>

/// <param name="list_store">
/// a #GtkListStore.
/// </param>

	public static T Clear<T>(this T list_store) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_clear(list_store);
		return list_store;
	}

/// <summary>
/// <para>
/// Creates a new row at @position.  @iter will be changed to point to this new
/// row.  If @position is -1 or is larger than the number of rows on the list,
/// then the new row will be appended to the list. The row will be empty after
/// this function is called.  To fill in values, you need to call
/// gtk_list_store_set() or gtk_list_store_set_value().
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the new row
/// </param>
/// <param name="position">
/// position to insert the new row, or -1 for last
/// </param>

	public static T Insert<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, int position) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_insert(list_store, out iter, position);
		return list_store;
	}

/// <summary>
/// <para>
/// Inserts a new row after @sibling. If @sibling is %NULL, then the row will be
/// prepended to the beginning of the list. @iter will be changed to point to
/// this new row. The row will be empty after this function is called. To fill
/// in values, you need to call gtk_list_store_set() or gtk_list_store_set_value().
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the new row
/// </param>
/// <param name="sibling">
/// A valid #GtkTreeIter, or %NULL
/// </param>

	public static T InsertAfter<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle sibling) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_insert_after(list_store, out iter, sibling);
		return list_store;
	}

/// <summary>
/// <para>
/// Inserts a new row before @sibling. If @sibling is %NULL, then the row will
/// be appended to the end of the list. @iter will be changed to point to this
/// new row. The row will be empty after this function is called. To fill in
/// values, you need to call gtk_list_store_set() or gtk_list_store_set_value().
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the new row
/// </param>
/// <param name="sibling">
/// A valid #GtkTreeIter, or %NULL
/// </param>

	public static T InsertBefore<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle sibling) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_insert_before(list_store, out iter, sibling);
		return list_store;
	}

/// <summary>
/// <para>
/// Creates a new row at @position. @iter will be changed to point to this new
/// row. If @position is -1, or larger than the number of rows in the list, then
/// the new row will be appended to the list. The row will be filled with the
/// values given to this function.
/// </para>
/// <para>
/// Calling
/// `gtk_list_store_insert_with_values (list_store, iter, position...)`
/// has the same effect as calling
/// |[<!-- language="C" -->
/// static void
/// insert_value (GtkListStore *list_store,
///               GtkTreeIter  *iter,
///               int           position)
/// {
///   gtk_list_store_insert (list_store, iter, position);
///   gtk_list_store_set (list_store,
///                       iter
///                       // ...
///                       );
/// }
/// ]|
/// with the difference that the former will only emit a row_inserted signal,
/// while the latter will emit row_inserted, row_changed and, if the list store
/// is sorted, rows_reordered. Since emitting the rows_reordered signal
/// repeatedly can affect the performance of the program,
/// gtk_list_store_insert_with_values() should generally be preferred when
/// inserting rows in a sorted list store.
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the new row, or %NULL
/// </param>
/// <param name="position">
/// position to insert the new row, or -1 to append after existing
///     rows
/// </param>
/// <param name="@__arglist">
/// pairs of column number and value, terminated with -1
/// </param>

	public static T InsertWithValues<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, int position, IntPtr @__arglist) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_insert_with_values(list_store, out iter, position, @__arglist);
		return list_store;
	}

/// <summary>
/// <para>
/// A variant of gtk_list_store_insert_with_values() which
/// takes the columns and values as two arrays, instead of
/// varargs. This function is mainly intended for
/// language-bindings.
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the new row, or %NULL.
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

	public static T InsertWithValuesv<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, int position, int[] columns, MentorLake.GObject.GValue[] values, int n_values) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_insert_with_valuesv(list_store, out iter, position, columns, values, n_values);
		return list_store;
	}

/// <summary>
/// <para>
/// > This function is slow. Only use it for debugging and/or testing
/// > purposes.
/// </para>
/// <para>
/// Checks if the given iter is a valid iter for this #GtkListStore.
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore.
/// </param>
/// <param name="iter">
/// A #GtkTreeIter.
/// </param>
/// <return>
/// %TRUE if the iter is valid, %FALSE if the iter is invalid.
/// </return>

	public static bool IterIsValid(this MentorLake.Gtk.GtkListStoreHandle list_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		return GtkListStoreHandleExterns.gtk_list_store_iter_is_valid(list_store, iter);
	}

/// <summary>
/// <para>
/// Moves @iter in @store to the position after @position. Note that this
/// function only works with unsorted stores. If @position is %NULL, @iter
/// will be moved to the start of the list.
/// </para>
/// </summary>

/// <param name="store">
/// A #GtkListStore.
/// </param>
/// <param name="iter">
/// A #GtkTreeIter.
/// </param>
/// <param name="position">
/// A #GtkTreeIter or %NULL.
/// </param>

	public static T MoveAfter<T>(this T store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle position) where T : GtkListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_move_after(store, iter, position);
		return store;
	}

/// <summary>
/// <para>
/// Moves @iter in @store to the position before @position. Note that this
/// function only works with unsorted stores. If @position is %NULL, @iter
/// will be moved to the end of the list.
/// </para>
/// </summary>

/// <param name="store">
/// A #GtkListStore.
/// </param>
/// <param name="iter">
/// A #GtkTreeIter.
/// </param>
/// <param name="position">
/// A #GtkTreeIter, or %NULL.
/// </param>

	public static T MoveBefore<T>(this T store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle position) where T : GtkListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_move_before(store, iter, position);
		return store;
	}

/// <summary>
/// <para>
/// Prepends a new row to @list_store. @iter will be changed to point to this new
/// row. The row will be empty after this function is called. To fill in
/// values, you need to call gtk_list_store_set() or gtk_list_store_set_value().
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// An unset #GtkTreeIter to set to the prepend row
/// </param>

	public static T Prepend<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_prepend(list_store, out iter);
		return list_store;
	}

/// <summary>
/// <para>
/// Removes the given row from the list store.  After being removed,
/// @iter is set to be the next valid row, or invalidated if it pointed
/// to the last row in @list_store.
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter
/// </param>
/// <return>
/// %TRUE if @iter is valid, %FALSE if not.
/// </return>

	public static bool Remove(this MentorLake.Gtk.GtkListStoreHandle list_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		return GtkListStoreHandleExterns.gtk_list_store_remove(list_store, iter);
	}

/// <summary>
/// <para>
/// Reorders @store to follow the order indicated by @new_order. Note that
/// this function only works with unsorted stores.
/// </para>
/// </summary>

/// <param name="store">
/// A #GtkListStore.
/// </param>
/// <param name="new_order">
/// an array of integers mapping the new
///      position of each child to its old position before the re-ordering,
///      i.e. @new_order`[newpos] = oldpos`. It must have
///      exactly as many items as the list store’s length.
/// </param>

	public static T Reorder<T>(this T store, int[] new_order) where T : GtkListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_reorder(store, new_order);
		return store;
	}

/// <summary>
/// <para>
/// Sets the value of one or more cells in the row referenced by @iter.
/// The variable argument list should contain integer column numbers,
/// each column number followed by the value to be set.
/// The list is terminated by a -1. For example, to set column 0 with type
/// %G_TYPE_STRING to “Foo”, you would write `gtk_list_store_set (store, iter,
/// 0, "Foo", -1)`.
/// </para>
/// <para>
/// The value will be referenced by the store if it is a %G_TYPE_OBJECT, and it
/// will be copied if it is a %G_TYPE_STRING or %G_TYPE_BOXED.
/// </para>
/// </summary>

/// <param name="list_store">
/// a #GtkListStore
/// </param>
/// <param name="iter">
/// row iterator
/// </param>
/// <param name="@__arglist">
/// pairs of column number and value, terminated with -1
/// </param>

	public static T Set<T>(this T list_store, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_set(list_store, iter, @__arglist);
		return list_store;
	}

/// <summary>
/// <para>
/// This function is meant primarily for #GObjects that inherit from #GtkListStore,
/// and should only be used when constructing a new #GtkListStore.  It will not
/// function after a row has been added, or a method on the #GtkTreeModel
/// interface is called.
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="n_columns">
/// Number of columns for the list store
/// </param>
/// <param name="types">
/// An array length n of #GTypes
/// </param>

	public static T SetColumnTypes<T>(this T list_store, int n_columns, MentorLake.GObject.GType[] types) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_set_column_types(list_store, n_columns, types);
		return list_store;
	}

/// <summary>
/// <para>
/// See gtk_list_store_set(); this version takes a va_list for use by language
/// bindings.
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter for the row being modified
/// </param>
/// <param name="var_args">
/// va_list of column/value pairs
/// </param>

	public static T SetValist<T>(this T list_store, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_set_valist(list_store, iter, var_args);
		return list_store;
	}

/// <summary>
/// <para>
/// Sets the data in the cell specified by @iter and @column.
/// The type of @value must be convertible to the type of the
/// column.
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
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

	public static T SetValue<T>(this T list_store, MentorLake.Gtk.GtkTreeIterHandle iter, int column, MentorLake.GObject.GValueHandle value) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_set_value(list_store, iter, column, value);
		return list_store;
	}

/// <summary>
/// <para>
/// A variant of gtk_list_store_set_valist() which
/// takes the columns and values as two arrays, instead of
/// varargs. This function is mainly intended for
/// language-bindings and in case the number of columns to
/// change is not known until run-time.
/// </para>
/// </summary>

/// <param name="list_store">
/// A #GtkListStore
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

	public static T SetValuesv<T>(this T list_store, MentorLake.Gtk.GtkTreeIterHandle iter, int[] columns, MentorLake.GObject.GValue[] values, int n_values) where T : GtkListStoreHandle
	{
		if (list_store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_set_valuesv(list_store, iter, columns, values, n_values);
		return list_store;
	}

/// <summary>
/// <para>
/// Swaps @a and @b in @store. Note that this function only works with
/// unsorted stores.
/// </para>
/// </summary>

/// <param name="store">
/// A #GtkListStore.
/// </param>
/// <param name="a">
/// A #GtkTreeIter.
/// </param>
/// <param name="b">
/// Another #GtkTreeIter.
/// </param>

	public static T Swap<T>(this T store, MentorLake.Gtk.GtkTreeIterHandle a, MentorLake.Gtk.GtkTreeIterHandle b) where T : GtkListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GtkListStoreHandle)");
		GtkListStoreHandleExterns.gtk_list_store_swap(store, a, b);
		return store;
	}

}

internal class GtkListStoreHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))]
	internal static extern MentorLake.Gtk.GtkListStoreHandle gtk_list_store_new(int n_columns, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))]
	internal static extern MentorLake.Gtk.GtkListStoreHandle gtk_list_store_newv(int n_columns, MentorLake.GObject.GType[] types);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert_with_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, int position, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert_with_valuesv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, int position, int[] columns, MentorLake.GObject.GValue[] values, int n_values);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_store_iter_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_move_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_move_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_store_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_reorder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle store, int[] new_order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set_column_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, int n_columns, MentorLake.GObject.GType[] types);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set_valuesv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int[] columns, MentorLake.GObject.GValue[] values, int n_values);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_swap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle b);

}
