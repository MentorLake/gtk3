namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkTreeSelection object is a helper object to manage the selection
/// for a #GtkTreeView widget.  The #GtkTreeSelection object is
/// automatically created when a new #GtkTreeView widget is created, and
/// cannot exist independently of this widget.  The primary reason the
/// #GtkTreeSelection objects exists is for cleanliness of code and API.
/// That is, there is no conceptual reason all these functions could not be
/// methods on the #GtkTreeView widget instead of a separate function.
/// </para>
/// <para>
/// The #GtkTreeSelection object is gotten from a #GtkTreeView by calling
/// gtk_tree_view_get_selection().  It can be manipulated to check the
/// selection status of the tree, as well as select and deselect individual
/// rows.  Selection is done completely view side.  As a result, multiple
/// views of the same model can have completely different selections.
/// Additionally, you cannot change the selection of a row on the model that
/// is not currently displayed by the view without expanding its parents
/// first.
/// </para>
/// <para>
/// One of the important things to remember when monitoring the selection of
/// a view is that the #GtkTreeSelection::changed signal is mostly a hint.
/// That is, it may only emit one signal when a range of rows is selected.
/// Additionally, it may on occasion emit a #GtkTreeSelection::changed signal
/// when nothing has happened (mostly as a result of programmers calling
/// select_row on an already selected row).
/// </para>
/// </summary>

public class GtkTreeSelectionHandle : GObjectHandle
{
}
public static class GtkTreeSelectionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted whenever the selection has (possibly) changed. Please note that
/// this signal is mostly a hint.  It may only be emitted once when a range
/// of rows are selected, and it may occasionally be emitted when nothing
/// has happened.
/// </para>
/// </summary>

	public static IObservable<GtkTreeSelectionHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkTreeSelectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeSelectionHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkTreeSelectionHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkTreeSelectionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeSelectionHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTreeSelectionHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gtk.GtkTreeSelectionHandle Self;

	public IntPtr UserData;
}
}

public static class GtkTreeSelectionHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted whenever the selection has (possibly) changed. Please note that
/// this signal is mostly a hint.  It may only be emitted once when a range
/// of rows are selected, and it may occasionally be emitted when nothing
/// has happened.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle self, IntPtr user_data);

}


public static class GtkTreeSelectionHandleExtensions
{
/// <summary>
/// <para>
/// Returns the number of rows that have been selected in @tree.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <return>
/// The number of rows selected.
/// </return>

	public static int CountSelectedRows(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_count_selected_rows(selection);
	}

/// <summary>
/// <para>
/// Gets the selection mode for @selection. See
/// gtk_tree_selection_set_mode().
/// </para>
/// </summary>

/// <param name="selection">
/// a #GtkTreeSelection
/// </param>
/// <return>
/// the current selection mode
/// </return>

	public static MentorLake.Gtk.GtkSelectionMode GetMode(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_mode(selection);
	}

/// <summary>
/// <para>
/// Returns the current selection function.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <return>
/// The function.
/// </return>

	public static MentorLake.Gtk.GtkTreeSelectionFunc GetSelectFunction(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_select_function(selection);
	}

/// <summary>
/// <para>
/// Sets @iter to the currently selected node, if @selection is set to
/// %GTK_SELECTION_SINGLE or %GTK_SELECTION_BROWSE.
/// </para>
/// <para>
/// The @iter argument may be %NULL if you just want to test if @selection
/// has any selected nodes.
/// </para>
/// <para>
/// The @model argument is filled with the current model as a convenience.
/// </para>
/// <para>
/// This function will not work with %GTK_SELECTION_MULTIPLE. See
/// gtk_tree_selection_get_selected_rows() instead.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="model">
/// the model
/// </param>
/// <param name="iter">
/// the iterator for the selected row
/// </param>
/// <return>
/// %TRUE, if there is a selected node.
/// </return>

	public static bool GetSelected(this MentorLake.Gtk.GtkTreeSelectionHandle selection, out MentorLake.Gtk.GtkTreeModelHandle model, out MentorLake.Gtk.GtkTreeIter iter)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_selected(selection, out model, out iter);
	}

/// <summary>
/// <para>
/// Creates a list of path of all selected rows.
/// </para>
/// <para>
/// Additionally, if you are planning on modifying the model after calling
/// this function, you may want to convert the returned list into a list
/// of #GtkTreeRowReferences.
/// </para>
/// <para>
/// To do this, you can use gtk_tree_row_reference_new().
/// </para>
/// <para>
/// To free the return value, use:
/// </para>
/// <code>
/// g_list_free_full (list, (GDestroyNotify) gtk_tree_path_free);
/// g_list_free_full (list, (GDestroyNotify) gtk_tree_path_free);
/// </code>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="model">
/// A pointer to set to the #GtkTreeModel, or %NULL.
/// </param>
/// <return>
/// the selected paths
/// </return>

	public static MentorLake.GLib.GListHandle GetSelectedRows(this MentorLake.Gtk.GtkTreeSelectionHandle selection, out MentorLake.Gtk.GtkTreeModelHandle model)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_selected_rows(selection, out model);
	}

/// <summary>
/// <para>
/// Returns the tree view associated with @selection.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection
/// </param>
/// <return>
/// A #GtkTreeView
/// </return>

	public static MentorLake.Gtk.GtkTreeViewHandle GetTreeView(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_tree_view(selection);
	}

/// <summary>
/// <para>
/// Returns the user data for the selection function.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <return>
/// The user data.
/// </return>

	public static IntPtr GetUserData(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_user_data(selection);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the row at @iter is currently selected.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection
/// </param>
/// <param name="iter">
/// A valid #GtkTreeIter
/// </param>
/// <return>
/// %TRUE, if @iter is selected
/// </return>

	public static bool IterIsSelected(this MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_iter_is_selected(selection, iter);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the row pointed to by @path is currently selected.  If @path
/// does not point to a valid location, %FALSE is returned
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="path">
/// A #GtkTreePath to check selection on.
/// </param>
/// <return>
/// %TRUE if @path is selected.
/// </return>

	public static bool PathIsSelected(this MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_path_is_selected(selection, path);
	}

/// <summary>
/// <para>
/// Selects all the nodes. @selection must be set to #GTK_SELECTION_MULTIPLE
/// mode.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>

	public static T SelectAll<T>(this T selection) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_select_all(selection);
		return selection;
	}

/// <summary>
/// <para>
/// Selects the specified iterator.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="iter">
/// The #GtkTreeIter to be selected.
/// </param>

	public static T SelectIter<T>(this T selection, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_select_iter(selection, iter);
		return selection;
	}

/// <summary>
/// <para>
/// Select the row at @path.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="path">
/// The #GtkTreePath to be selected.
/// </param>

	public static T SelectPath<T>(this T selection, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_select_path(selection, path);
		return selection;
	}

/// <summary>
/// <para>
/// Selects a range of nodes, determined by @start_path and @end_path inclusive.
/// @selection must be set to #GTK_SELECTION_MULTIPLE mode.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="start_path">
/// The initial node of the range.
/// </param>
/// <param name="end_path">
/// The final node of the range.
/// </param>

	public static T SelectRange<T>(this T selection, MentorLake.Gtk.GtkTreePathHandle start_path, MentorLake.Gtk.GtkTreePathHandle end_path) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_select_range(selection, start_path, end_path);
		return selection;
	}

/// <summary>
/// <para>
/// Calls a function for each selected node. Note that you cannot modify
/// the tree or selection from within this function. As a result,
/// gtk_tree_selection_get_selected_rows() might be more useful.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="func">
/// The function to call for each selected node.
/// </param>
/// <param name="data">
/// user data to pass to the function.
/// </param>

	public static T SelectedForeach<T>(this T selection, MentorLake.Gtk.GtkTreeSelectionForeachFunc func, IntPtr data) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_selected_foreach(selection, func, data);
		return selection;
	}

/// <summary>
/// <para>
/// Sets the selection mode of the @selection.  If the previous type was
/// #GTK_SELECTION_MULTIPLE, then the anchor is kept selected, if it was
/// previously selected.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="type">
/// The selection mode
/// </param>

	public static T SetMode<T>(this T selection, MentorLake.Gtk.GtkSelectionMode type) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_set_mode(selection, type);
		return selection;
	}

/// <summary>
/// <para>
/// Sets the selection function.
/// </para>
/// <para>
/// If set, this function is called before any node is selected or unselected,
/// giving some control over which nodes are selected. The select function
/// should return %TRUE if the state of the node may be toggled, and %FALSE
/// if the state of the node should be left unchanged.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="func">
/// The selection function. May be %NULL
/// </param>
/// <param name="data">
/// The selection function’s data. May be %NULL
/// </param>
/// <param name="destroy">
/// The destroy function for user data.  May be %NULL
/// </param>

	public static T SetSelectFunction<T>(this T selection, MentorLake.Gtk.GtkTreeSelectionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_set_select_function(selection, func, data, destroy);
		return selection;
	}

/// <summary>
/// <para>
/// Unselects all the nodes.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>

	public static T UnselectAll<T>(this T selection) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_unselect_all(selection);
		return selection;
	}

/// <summary>
/// <para>
/// Unselects the specified iterator.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="iter">
/// The #GtkTreeIter to be unselected.
/// </param>

	public static T UnselectIter<T>(this T selection, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_unselect_iter(selection, iter);
		return selection;
	}

/// <summary>
/// <para>
/// Unselects the row at @path.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="path">
/// The #GtkTreePath to be unselected.
/// </param>

	public static T UnselectPath<T>(this T selection, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_unselect_path(selection, path);
		return selection;
	}

/// <summary>
/// <para>
/// Unselects a range of nodes, determined by @start_path and @end_path
/// inclusive.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection.
/// </param>
/// <param name="start_path">
/// The initial node of the range.
/// </param>
/// <param name="end_path">
/// The initial node of the range.
/// </param>

	public static T UnselectRange<T>(this T selection, MentorLake.Gtk.GtkTreePathHandle start_path, MentorLake.Gtk.GtkTreePathHandle end_path) where T : GtkTreeSelectionHandle
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (GtkTreeSelectionHandle)");
		GtkTreeSelectionHandleExterns.gtk_tree_selection_unselect_range(selection, start_path, end_path);
		return selection;
	}

}

internal class GtkTreeSelectionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_selection_count_selected_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSelectionMode gtk_tree_selection_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeSelectionFunc gtk_tree_selection_get_select_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_selection_get_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] out MentorLake.Gtk.GtkTreeModelHandle model, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_tree_selection_get_selected_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] out MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeViewHandle gtk_tree_selection_get_tree_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern IntPtr gtk_tree_selection_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_selection_iter_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_selection_path_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_select_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_select_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_select_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle start_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle end_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_selected_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkTreeSelectionForeachFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkSelectionMode type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_set_select_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkTreeSelectionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_unselect_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_unselect_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_unselect_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle start_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle end_path);

}
