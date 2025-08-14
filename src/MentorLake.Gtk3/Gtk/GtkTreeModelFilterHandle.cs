namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkTreeModelFilter is a tree model which wraps another tree model,
/// and can do the following things:
/// </para>
/// <para>
/// - Filter specific rows, based on data from a “visible column”, a column
///   storing booleans indicating whether the row should be filtered or not,
///   or based on the return value of a “visible function”, which gets a
///   model, iter and user_data and returns a boolean indicating whether the
///   row should be filtered or not.
/// </para>
/// <para>
/// - Modify the “appearance” of the model, using a modify function.
///   This is extremely powerful and allows for just changing some
///   values and also for creating a completely different model based
///   on the given child model.
/// </para>
/// <para>
/// - Set a different root node, also known as a “virtual root”. You can pass
///   in a #GtkTreePath indicating the root node for the filter at construction
///   time.
/// </para>
/// <para>
/// The basic API is similar to #GtkTreeModelSort. For an example on its usage,
/// see the section on #GtkTreeModelSort.
/// </para>
/// <para>
/// When using #GtkTreeModelFilter, it is important to realize that
/// #GtkTreeModelFilter maintains an internal cache of all nodes which are
/// visible in its clients. The cache is likely to be a subtree of the tree
/// exposed by the child model. #GtkTreeModelFilter will not cache the entire
/// child model when unnecessary to not compromise the caching mechanism
/// that is exposed by the reference counting scheme. If the child model
/// implements reference counting, unnecessary signals may not be emitted
/// because of reference counting rule 3, see the #GtkTreeModel
/// documentation. (Note that e.g. #GtkTreeStore does not implement
/// reference counting and will always emit all signals, even when
/// the receiving node is not visible).
/// </para>
/// <para>
/// Because of this, limitations for possible visible functions do apply.
/// In general, visible functions should only use data or properties from
/// the node for which the visibility state must be determined, its siblings
/// or its parents. Usually, having a dependency on the state of any child
/// node is not possible, unless references are taken on these explicitly.
/// When no such reference exists, no signals may be received for these child
/// nodes (see reference couting rule number 3 in the #GtkTreeModel section).
/// </para>
/// <para>
/// Determining the visibility state of a given node based on the state
/// of its child nodes is a frequently occurring use case. Therefore,
/// #GtkTreeModelFilter explicitly supports this. For example, when a node
/// does not have any children, you might not want the node to be visible.
/// As soon as the first row is added to the node’s child level (or the
/// last row removed), the node’s visibility should be updated.
/// </para>
/// <para>
/// This introduces a dependency from the node on its child nodes. In order
/// to accommodate this, #GtkTreeModelFilter must make sure the necessary
/// signals are received from the child model. This is achieved by building,
/// for all nodes which are exposed as visible nodes to #GtkTreeModelFilter's
/// clients, the child level (if any) and take a reference on the first node
/// in this level. Furthermore, for every row-inserted, row-changed or
/// row-deleted signal (also these which were not handled because the node
/// was not cached), #GtkTreeModelFilter will check if the visibility state
/// of any parent node has changed.
/// </para>
/// <para>
/// Beware, however, that this explicit support is limited to these two
/// cases. For example, if you want a node to be visible only if two nodes
/// in a child’s child level (2 levels deeper) are visible, you are on your
/// own. In this case, either rely on #GtkTreeStore to emit all signals
/// because it does not implement reference counting, or for models that
/// do implement reference counting, obtain references on these child levels
/// yourself.
/// </para>
/// </summary>

public class GtkTreeModelFilterHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle
{
}
public static class GtkTreeModelFilterHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when a row in the model has changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when a row has gotten the first child
/// row or lost its last child row.
/// </para>
/// </summary>

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
}

public static class GtkTreeModelFilterHandleSignalDelegates
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

}


public static class GtkTreeModelFilterHandleExtensions
{
/// <summary>
/// <para>
/// This function should almost never be called. It clears the @filter
/// of any cached iterators that haven’t been reffed with
/// gtk_tree_model_ref_node(). This might be useful if the child model
/// being filtered is static (and doesn’t change often) and there has been
/// a lot of unreffed access to nodes. As a side effect of this function,
/// all unreffed iters will be invalid.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter.
/// </param>

	public static T ClearCache<T>(this T filter) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_clear_cache(filter);
		return filter;
	}

/// <summary>
/// <para>
/// Sets @filter_iter to point to the row in @filter that corresponds to the
/// row pointed at by @child_iter.  If @filter_iter was not set, %FALSE is
/// returned.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter.
/// </param>
/// <param name="filter_iter">
/// An uninitialized #GtkTreeIter.
/// </param>
/// <param name="child_iter">
/// A valid #GtkTreeIter pointing to a row on the child model.
/// </param>
/// <return>
/// %TRUE, if @filter_iter was set, i.e. if @child_iter is a
/// valid iterator pointing to a visible row in child model.
/// </return>

	public static bool ConvertChildIterToIter(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, out MentorLake.Gtk.GtkTreeIter filter_iter, MentorLake.Gtk.GtkTreeIterHandle child_iter)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_child_iter_to_iter(filter, out filter_iter, child_iter);
	}

/// <summary>
/// <para>
/// Converts @child_path to a path relative to @filter. That is, @child_path
/// points to a path in the child model. The rerturned path will point to the
/// same row in the filtered model. If @child_path isn’t a valid path on the
/// child model or points to a row which is not visible in @filter, then %NULL
/// is returned.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter.
/// </param>
/// <param name="child_path">
/// A #GtkTreePath to convert.
/// </param>
/// <return>
/// A newly allocated #GtkTreePath, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle ConvertChildPathToPath(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, MentorLake.Gtk.GtkTreePathHandle child_path)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_child_path_to_path(filter, child_path);
	}

/// <summary>
/// <para>
/// Sets @child_iter to point to the row pointed to by @filter_iter.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter.
/// </param>
/// <param name="child_iter">
/// An uninitialized #GtkTreeIter.
/// </param>
/// <param name="filter_iter">
/// A valid #GtkTreeIter pointing to a row on @filter.
/// </param>

	public static T ConvertIterToChildIter<T>(this T filter, out MentorLake.Gtk.GtkTreeIter child_iter, MentorLake.Gtk.GtkTreeIterHandle filter_iter) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_iter_to_child_iter(filter, out child_iter, filter_iter);
		return filter;
	}

/// <summary>
/// <para>
/// Converts @filter_path to a path on the child model of @filter. That is,
/// @filter_path points to a location in @filter. The returned path will
/// point to the same location in the model not being filtered. If @filter_path
/// does not point to a location in the child model, %NULL is returned.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter.
/// </param>
/// <param name="filter_path">
/// A #GtkTreePath to convert.
/// </param>
/// <return>
/// A newly allocated #GtkTreePath, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle ConvertPathToChildPath(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, MentorLake.Gtk.GtkTreePathHandle filter_path)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_path_to_child_path(filter, filter_path);
	}

/// <summary>
/// <para>
/// Returns a pointer to the child model of @filter.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter.
/// </param>
/// <return>
/// A pointer to a #GtkTreeModel.
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeModelFilterHandle filter)
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_get_model(filter);
	}

/// <summary>
/// <para>
/// Emits ::row_changed for each row in the child model, which causes
/// the filter to re-evaluate whether a row is visible or not.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter.
/// </param>

	public static T Refilter<T>(this T filter) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_refilter(filter);
		return filter;
	}

/// <summary>
/// <para>
/// With the @n_columns and @types parameters, you give an array of column
/// types for this model (which will be exposed to the parent model/view).
/// The @func, @data and @destroy parameters are for specifying the modify
/// function. The modify function will get called for each
/// data access, the goal of the modify function is to return the data which
/// should be displayed at the location specified using the parameters of the
/// modify function.
/// </para>
/// <para>
/// Note that gtk_tree_model_filter_set_modify_func()
/// can only be called once for a given filter model.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter.
/// </param>
/// <param name="n_columns">
/// The number of columns in the filter model.
/// </param>
/// <param name="types">
/// The #GTypes of the columns.
/// </param>
/// <param name="func">
/// A #GtkTreeModelFilterModifyFunc
/// </param>
/// <param name="data">
/// User data to pass to the modify function, or %NULL.
/// </param>
/// <param name="destroy">
/// Destroy notifier of @data, or %NULL.
/// </param>

	public static T SetModifyFunc<T>(this T filter, int n_columns, MentorLake.GObject.GType[] types, MentorLake.Gtk.GtkTreeModelFilterModifyFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_set_modify_func(filter, n_columns, types, func, data, destroy);
		return filter;
	}

/// <summary>
/// <para>
/// Sets @column of the child_model to be the column where @filter should
/// look for visibility information. @columns should be a column of type
/// %G_TYPE_BOOLEAN, where %TRUE means that a row is visible, and %FALSE
/// if not.
/// </para>
/// <para>
/// Note that gtk_tree_model_filter_set_visible_func() or
/// gtk_tree_model_filter_set_visible_column() can only be called
/// once for a given filter model.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter
/// </param>
/// <param name="column">
/// A #gint which is the column containing the visible information
/// </param>

	public static T SetVisibleColumn<T>(this T filter, int column) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_set_visible_column(filter, column);
		return filter;
	}

/// <summary>
/// <para>
/// Sets the visible function used when filtering the @filter to be @func.
/// The function should return %TRUE if the given row should be visible and
/// %FALSE otherwise.
/// </para>
/// <para>
/// If the condition calculated by the function changes over time (e.g.
/// because it depends on some global parameters), you must call
/// gtk_tree_model_filter_refilter() to keep the visibility information
/// of the model up-to-date.
/// </para>
/// <para>
/// Note that @func is called whenever a row is inserted, when it may still
/// be empty. The visible function should therefore take special care of empty
/// rows, like in the example below.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static gboolean
/// visible_func (GtkTreeModel *model,
///               GtkTreeIter  *iter,
///               gpointer      data)
/// {
///   // Visible if row is non-empty and first column is “HI”
///   gchar *str;
///   gboolean visible = FALSE;
/// </para>
/// <para>
///   gtk_tree_model_get (model, iter, 0, &str, -1);
///   if (str && strcmp (str, "HI") == 0)
///     visible = TRUE;
///   g_free (str);
/// </para>
/// <para>
///   return visible;
/// }
/// ]|
/// </para>
/// <para>
/// Note that gtk_tree_model_filter_set_visible_func() or
/// gtk_tree_model_filter_set_visible_column() can only be called
/// once for a given filter model.
/// </para>
/// </summary>

/// <param name="filter">
/// A #GtkTreeModelFilter
/// </param>
/// <param name="func">
/// A #GtkTreeModelFilterVisibleFunc, the visible function
/// </param>
/// <param name="data">
/// User data to pass to the visible function, or %NULL
/// </param>
/// <param name="destroy">
/// Destroy notifier of @data, or %NULL
/// </param>

	public static T SetVisibleFunc<T>(this T filter, MentorLake.Gtk.GtkTreeModelFilterVisibleFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeModelFilterHandle
	{
		if (filter.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelFilterHandle)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_filter_convert_child_path_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle child_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_convert_iter_to_child_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, out MentorLake.Gtk.GtkTreeIter child_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle filter_iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_filter_convert_path_to_child_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle filter_path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
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
