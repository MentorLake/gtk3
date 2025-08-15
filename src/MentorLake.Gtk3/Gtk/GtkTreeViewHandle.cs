namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Widget that displays any object that implements the #GtkTreeModel interface.
/// </para>
/// <para>
/// Please refer to the
/// [tree widget conceptual overview](TreeWidget.html)
/// for an overview of all the objects and data types related
/// to the tree widget and how they work together.
/// </para>
/// <para>
/// Several different coordinate systems are exposed in the GtkTreeView API.
/// These are:
/// </para>
/// <para>
/// ![](tree-view-coordinates.png)
/// </para>
/// <para>
/// Coordinate systems in GtkTreeView API:
/// </para>
/// <para>
/// - Widget coordinates: Coordinates relative to the widget (usually `widget-&amp;gt;window`).
/// </para>
/// <para>
/// - Bin window coordinates: Coordinates relative to the window that GtkTreeView renders to.
/// </para>
/// <para>
/// - Tree coordinates: Coordinates relative to the entire scrollable area of GtkTreeView. These
///   coordinates start at (0, 0) for row 0 of the tree.
/// </para>
/// <para>
/// Several functions are available for converting between the different
/// coordinate systems.  The most common translations are between widget and bin
/// window coordinates and between bin window and tree coordinates. For the
/// former you can use gtk_tree_view_convert_widget_to_bin_window_coords()
/// (and vice versa), for the latter gtk_tree_view_convert_bin_window_to_tree_coords()
/// (and vice versa).
/// </para>
/// <para>
/// # GtkTreeView as GtkBuildable
/// </para>
/// <para>
/// The GtkTreeView implementation of the GtkBuildable interface accepts
/// #GtkTreeViewColumn objects as `&amp;lt;child&amp;gt;` elements and exposes the internal
/// #GtkTreeSelection in UI definitions.
/// </para>
/// <para>
/// An example of a UI definition fragment with GtkTreeView:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkTreeView&quot; id=&quot;treeview&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkTreeView&quot; id=&quot;treeview&quot;&amp;gt;
///   &amp;lt;property name=&quot;model&quot;&amp;gt;liststore1&amp;lt;/property&amp;gt;
///   &amp;lt;child&amp;gt;
///     &amp;lt;object class=&quot;GtkTreeViewColumn&quot; id=&quot;test-column&quot;&amp;gt;
///       &amp;lt;property name=&quot;title&quot;&amp;gt;Test&amp;lt;/property&amp;gt;
///       &amp;lt;child&amp;gt;
///         &amp;lt;object class=&quot;GtkCellRendererText&quot; id=&quot;test-renderer&quot;/&amp;gt;
///         &amp;lt;attributes&amp;gt;
///           &amp;lt;attribute name=&quot;text&quot;&amp;gt;1&amp;lt;/attribute&amp;gt;
///         &amp;lt;/attributes&amp;gt;
///       &amp;lt;/child&amp;gt;
///     &amp;lt;/object&amp;gt;
///   &amp;lt;/child&amp;gt;
///   &amp;lt;child internal-child=&quot;selection&quot;&amp;gt;
///     &amp;lt;object class=&quot;GtkTreeSelection&quot; id=&quot;selection&quot;&amp;gt;
///       &amp;lt;signal name=&quot;changed&quot; handler=&quot;on_treeview_selection_changed&quot;/&amp;gt;
///     &amp;lt;/object&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// treeview.view
/// treeview.view
/// ├── header
/// │   ├── &amp;lt;column header&amp;gt;
/// ┊   ┊
/// │   ╰── &amp;lt;column header&amp;gt;
/// │
/// ╰── [rubberband]
/// </code>
/// <para>
/// GtkTreeView has a main CSS node with name treeview and style class .view.
/// It has a subnode with name header, which is the parent for all the column
/// header widgets&apos; CSS nodes.
/// For rubberband selection, a subnode with name rubberband is used.
/// </para>
/// </summary>

public class GtkTreeViewHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTreeView widget.
/// </para>
/// </summary>

/// <return>
/// A newly created #GtkTreeView widget.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewHandle New()
	{
		return GtkTreeViewHandleExterns.gtk_tree_view_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkTreeView widget with the model initialized to @model.
/// </para>
/// </summary>

/// <param name="model">
/// the model.
/// </param>
/// <return>
/// A newly created #GtkTreeView widget.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkTreeViewHandleExterns.gtk_tree_view_new_with_model(model);
	}

}
public static class GtkTreeViewHandleSignalExtensions
{
/// <summary>
/// <para>
/// The number of columns of the treeview has changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The position of the cursor (focused cell) has changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The #GtkTreeView::move-cursor signal is a [keybinding
/// signal][GtkBindingSignal] which gets emitted when the user
/// presses one of the cursor keys.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically. In contrast to gtk_tree_view_set_cursor() and
/// gtk_tree_view_set_cursor_on_cell() when moving horizontally
/// #GtkTreeView::move-cursor does not reset the current selection.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The &quot;row-activated&quot; signal is emitted when the method
/// gtk_tree_view_row_activated() is called, when the user double
/// clicks a treeview row with the &quot;activate-on-single-click&quot;
/// property set to %FALSE, or when the user single clicks a row when
/// the &quot;activate-on-single-click&quot; property set to %TRUE. It is also
/// emitted when a non-editable row is selected and one of the keys:
/// Space, Shift+Space, Return or Enter is pressed.
/// </para>
/// <para>
/// For selection handling refer to the
/// [tree widget conceptual overview](TreeWidget.html)
/// as well as #GtkTreeSelection.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The given row has been collapsed (child nodes are hidden).
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The given row has been expanded (child nodes are shown).
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The given row is about to be collapsed (hide its children nodes). Use this
/// signal if you need to control the collapsibility of individual rows.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The given row is about to be expanded (show its children nodes). Use this
/// signal if you need to control the expandability of individual rows.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the granularity of the move, as a
/// #GtkMovementStep. %GTK_MOVEMENT_LOGICAL_POSITIONS,
/// %GTK_MOVEMENT_VISUAL_POSITIONS, %GTK_MOVEMENT_DISPLAY_LINES,
/// %GTK_MOVEMENT_PAGES and %GTK_MOVEMENT_BUFFER_ENDS are
/// supported. %GTK_MOVEMENT_LOGICAL_POSITIONS and
/// %GTK_MOVEMENT_VISUAL_POSITIONS are treated identically.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkMovementStep Step;
/// <summary>
/// <para>
/// the direction to move: +1 to move forwards;
/// -1 to move backwards. The resulting movement is
/// undefined for all other values.
/// </para>
/// </summary>

	public int Direction;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if @step is supported, %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class RowActivatedSignal
{

	public MentorLake.Gtk.GtkTreeViewHandle Self;
/// <summary>
/// <para>
/// the #GtkTreePath for the activated row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;
/// <summary>
/// <para>
/// the #GtkTreeViewColumn in which the activation occurred
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeViewColumnHandle Column;

	public IntPtr UserData;
}

public class RowCollapsedSignal
{

	public MentorLake.Gtk.GtkTreeViewHandle Self;
/// <summary>
/// <para>
/// the tree iter of the collapsed row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;
/// <summary>
/// <para>
/// a tree path that points to the row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;

	public IntPtr UserData;
}

public class RowExpandedSignal
{

	public MentorLake.Gtk.GtkTreeViewHandle Self;
/// <summary>
/// <para>
/// the tree iter of the expanded row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;
/// <summary>
/// <para>
/// a tree path that points to the row
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the tree iter of the row to collapse
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;
/// <summary>
/// <para>
/// a tree path that points to the row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %FALSE to allow collapsing, %TRUE to reject
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class TestExpandRowSignal
{

	public MentorLake.Gtk.GtkTreeViewHandle Self;
/// <summary>
/// <para>
/// the tree iter of the row to expand
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;
/// <summary>
/// <para>
/// a tree path that points to the row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %FALSE to allow expansion, %TRUE to reject
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The number of columns of the treeview has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void columns_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The position of the cursor (focused cell) has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cursor_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="p0">
/// </param>
/// <param name="p1">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool expand_collapse_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, bool @object, bool p0, bool p1, IntPtr user_data);


/// <summary>
/// <para>
/// The #GtkTreeView::move-cursor signal is a [keybinding
/// signal][GtkBindingSignal] which gets emitted when the user
/// presses one of the cursor keys.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically. In contrast to gtk_tree_view_set_cursor() and
/// gtk_tree_view_set_cursor_on_cell() when moving horizontally
/// #GtkTreeView::move-cursor does not reset the current selection.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="step">
/// the granularity of the move, as a
/// #GtkMovementStep. %GTK_MOVEMENT_LOGICAL_POSITIONS,
/// %GTK_MOVEMENT_VISUAL_POSITIONS, %GTK_MOVEMENT_DISPLAY_LINES,
/// %GTK_MOVEMENT_PAGES and %GTK_MOVEMENT_BUFFER_ENDS are
/// supported. %GTK_MOVEMENT_LOGICAL_POSITIONS and
/// %GTK_MOVEMENT_VISUAL_POSITIONS are treated identically.
/// </param>
/// <param name="direction">
/// the direction to move: +1 to move forwards;
/// -1 to move backwards. The resulting movement is
/// undefined for all other values.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if @step is supported, %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, MentorLake.Gtk.GtkMovementStep step, int direction, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;row-activated&quot; signal is emitted when the method
/// gtk_tree_view_row_activated() is called, when the user double
/// clicks a treeview row with the &quot;activate-on-single-click&quot;
/// property set to %FALSE, or when the user single clicks a row when
/// the &quot;activate-on-single-click&quot; property set to %TRUE. It is also
/// emitted when a non-editable row is selected and one of the keys:
/// Space, Shift+Space, Return or Enter is pressed.
/// </para>
/// <para>
/// For selection handling refer to the
/// [tree widget conceptual overview](TreeWidget.html)
/// as well as #GtkTreeSelection.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// the #GtkTreePath for the activated row
/// </param>
/// <param name="column">
/// the #GtkTreeViewColumn in which the activation occurred
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, IntPtr user_data);


/// <summary>
/// <para>
/// The given row has been collapsed (child nodes are hidden).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="iter">
/// the tree iter of the collapsed row
/// </param>
/// <param name="path">
/// a tree path that points to the row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_collapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


/// <summary>
/// <para>
/// The given row has been expanded (child nodes are shown).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="iter">
/// the tree iter of the expanded row
/// </param>
/// <param name="path">
/// a tree path that points to the row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_expanded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_cursor_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, bool @object, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool start_interactive_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The given row is about to be collapsed (hide its children nodes). Use this
/// signal if you need to control the collapsibility of individual rows.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="iter">
/// the tree iter of the row to collapse
/// </param>
/// <param name="path">
/// a tree path that points to the row
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %FALSE to allow collapsing, %TRUE to reject
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool test_collapse_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


/// <summary>
/// <para>
/// The given row is about to be expanded (show its children nodes). Use this
/// signal if you need to control the expandability of individual rows.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="iter">
/// the tree iter of the row to expand
/// </param>
/// <param name="path">
/// a tree path that points to the row
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %FALSE to allow expansion, %TRUE to reject
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool test_expand_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool toggle_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle self, IntPtr user_data);

}


public static class GtkTreeViewHandleExtensions
{
/// <summary>
/// <para>
/// Appends @column to the list of columns. If @tree_view has “fixed_height”
/// mode enabled, then @column must have its “sizing” property set to be
/// GTK_TREE_VIEW_COLUMN_FIXED.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="column">
/// The #GtkTreeViewColumn to add.
/// </param>
/// <return>
/// The number of columns in @tree_view after appending.
/// </return>

	public static int AppendColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_append_column(tree_view, column);
	}

/// <summary>
/// <para>
/// Recursively collapses all visible, expanded nodes in @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>

	public static T CollapseAll<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_collapse_all(tree_view);
		return tree_view;
	}

/// <summary>
/// <para>
/// Collapses a row (hides its child rows, if they exist).
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="path">
/// path to a row in the @tree_view
/// </param>
/// <return>
/// %TRUE if the row was collapsed.
/// </return>

	public static bool CollapseRow(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_collapse_row(tree_view, path);
	}

/// <summary>
/// <para>
/// Resizes all columns to their optimal width. Only works after the
/// treeview has been realized.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>

	public static T ColumnsAutosize<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_columns_autosize(tree_view);
		return tree_view;
	}

/// <summary>
/// <para>
/// Converts bin_window coordinates to coordinates for the
/// tree (the full scrollable area of the tree).
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="bx">
/// X coordinate relative to bin_window
/// </param>
/// <param name="by">
/// Y coordinate relative to bin_window
/// </param>
/// <param name="tx">
/// return location for tree X coordinate
/// </param>
/// <param name="ty">
/// return location for tree Y coordinate
/// </param>

	public static T ConvertBinWindowToTreeCoords<T>(this T tree_view, int bx, int by, out int tx, out int ty) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_bin_window_to_tree_coords(tree_view, bx, by, out tx, out ty);
		return tree_view;
	}

/// <summary>
/// <para>
/// Converts bin_window coordinates (see gtk_tree_view_get_bin_window())
/// to widget relative coordinates.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="bx">
/// bin_window X coordinate
/// </param>
/// <param name="by">
/// bin_window Y coordinate
/// </param>
/// <param name="wx">
/// return location for widget X coordinate
/// </param>
/// <param name="wy">
/// return location for widget Y coordinate
/// </param>

	public static T ConvertBinWindowToWidgetCoords<T>(this T tree_view, int bx, int by, out int wx, out int wy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_bin_window_to_widget_coords(tree_view, bx, by, out wx, out wy);
		return tree_view;
	}

/// <summary>
/// <para>
/// Converts tree coordinates (coordinates in full scrollable area of the tree)
/// to bin_window coordinates.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="tx">
/// tree X coordinate
/// </param>
/// <param name="ty">
/// tree Y coordinate
/// </param>
/// <param name="bx">
/// return location for X coordinate relative to bin_window
/// </param>
/// <param name="by">
/// return location for Y coordinate relative to bin_window
/// </param>

	public static T ConvertTreeToBinWindowCoords<T>(this T tree_view, int tx, int ty, out int bx, out int by) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_tree_to_bin_window_coords(tree_view, tx, ty, out bx, out by);
		return tree_view;
	}

/// <summary>
/// <para>
/// Converts tree coordinates (coordinates in full scrollable area of the tree)
/// to widget coordinates.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="tx">
/// X coordinate relative to the tree
/// </param>
/// <param name="ty">
/// Y coordinate relative to the tree
/// </param>
/// <param name="wx">
/// return location for widget X coordinate
/// </param>
/// <param name="wy">
/// return location for widget Y coordinate
/// </param>

	public static T ConvertTreeToWidgetCoords<T>(this T tree_view, int tx, int ty, out int wx, out int wy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_tree_to_widget_coords(tree_view, tx, ty, out wx, out wy);
		return tree_view;
	}

/// <summary>
/// <para>
/// Converts widget coordinates to coordinates for the bin_window
/// (see gtk_tree_view_get_bin_window()).
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="wx">
/// X coordinate relative to the widget
/// </param>
/// <param name="wy">
/// Y coordinate relative to the widget
/// </param>
/// <param name="bx">
/// return location for bin_window X coordinate
/// </param>
/// <param name="by">
/// return location for bin_window Y coordinate
/// </param>

	public static T ConvertWidgetToBinWindowCoords<T>(this T tree_view, int wx, int wy, out int bx, out int by) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_widget_to_bin_window_coords(tree_view, wx, wy, out bx, out by);
		return tree_view;
	}

/// <summary>
/// <para>
/// Converts widget coordinates to coordinates for the
/// tree (the full scrollable area of the tree).
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="wx">
/// X coordinate relative to the widget
/// </param>
/// <param name="wy">
/// Y coordinate relative to the widget
/// </param>
/// <param name="tx">
/// return location for tree X coordinate
/// </param>
/// <param name="ty">
/// return location for tree Y coordinate
/// </param>

	public static T ConvertWidgetToTreeCoords<T>(this T tree_view, int wx, int wy, out int tx, out int ty) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_convert_widget_to_tree_coords(tree_view, wx, wy, out tx, out ty);
		return tree_view;
	}

/// <summary>
/// <para>
/// Creates a #cairo_surface_t representation of the row at @path.
/// This image is used for a drag icon.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="path">
/// a #GtkTreePath in @tree_view
/// </param>
/// <return>
/// a newly-allocated surface of the drag icon.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle CreateRowDragIcon(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_create_row_drag_icon(tree_view, path);
	}

/// <summary>
/// <para>
/// Turns @tree_view into a drop destination for automatic DND. Calling
/// this method sets #GtkTreeView:reorderable to %FALSE.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="targets">
/// the table of targets that
///           the drag will support
/// </param>
/// <param name="n_targets">
/// the number of items in @targets
/// </param>
/// <param name="actions">
/// the bitmask of possible actions for a drag from this
///    widget
/// </param>

	public static T EnableModelDragDest<T>(this T tree_view, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_enable_model_drag_dest(tree_view, targets, n_targets, actions);
		return tree_view;
	}

/// <summary>
/// <para>
/// Turns @tree_view into a drag source for automatic DND. Calling this
/// method sets #GtkTreeView:reorderable to %FALSE.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="start_button_mask">
/// Mask of allowed buttons to start drag
/// </param>
/// <param name="targets">
/// the table of targets that the drag will support
/// </param>
/// <param name="n_targets">
/// the number of items in @targets
/// </param>
/// <param name="actions">
/// the bitmask of possible actions for a drag from this
///    widget
/// </param>

	public static T EnableModelDragSource<T>(this T tree_view, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_enable_model_drag_source(tree_view, start_button_mask, targets, n_targets, actions);
		return tree_view;
	}

/// <summary>
/// <para>
/// Recursively expands all nodes in the @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>

	public static T ExpandAll<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_expand_all(tree_view);
		return tree_view;
	}

/// <summary>
/// <para>
/// Opens the row so its children are visible.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="path">
/// path to a row
/// </param>
/// <param name="open_all">
/// whether to recursively expand, or just expand immediate children
/// </param>
/// <return>
/// %TRUE if the row existed and had children
/// </return>

	public static bool ExpandRow(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreePathHandle path, bool open_all)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_expand_row(tree_view, path, open_all);
	}

/// <summary>
/// <para>
/// Expands the row at @path. This will also expand all parent rows of
/// @path as necessary.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="path">
/// path to a row.
/// </param>

	public static T ExpandToPath<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_expand_to_path(tree_view, path);
		return tree_view;
	}

/// <summary>
/// <para>
/// Gets the setting set by gtk_tree_view_set_activate_on_single_click().
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// %TRUE if row-activated will be emitted on a single click
/// </return>

	public static bool GetActivateOnSingleClick(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_activate_on_single_click(tree_view);
	}

/// <summary>
/// <para>
/// Fills the bounding rectangle in bin_window coordinates for the cell at the
/// row specified by @path and the column specified by @column.  If @path is
/// %NULL, or points to a node not found in the tree, the @y and @height fields of
/// the rectangle will be filled with 0. If @column is %NULL, the @x and @width
/// fields will be filled with 0.  The returned rectangle is equivalent to the
/// @background_area passed to gtk_cell_renderer_render().  These background
/// areas tile to cover the entire bin window.  Contrast with the @cell_area,
/// returned by gtk_tree_view_get_cell_area(), which returns only the cell
/// itself, excluding surrounding borders and the tree expander area.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="path">
/// a #GtkTreePath for the row, or %NULL to get only horizontal coordinates
/// </param>
/// <param name="column">
/// a #GtkTreeViewColumn for the column, or %NULL to get only vertical coordiantes
/// </param>
/// <param name="rect">
/// rectangle to fill with cell background rect
/// </param>

	public static T GetBackgroundArea<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column, out MentorLake.Gdk.GdkRectangle rect) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_background_area(tree_view, path, column, out rect);
		return tree_view;
	}

/// <summary>
/// <para>
/// Returns the window that @tree_view renders to.
/// This is used primarily to compare to `event-&amp;gt;window`
/// to confirm that the event on @tree_view is on the right window.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// A #GdkWindow, or %NULL when @tree_view
/// hasn’t been realized yet.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetBinWindow(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_bin_window(tree_view);
	}

/// <summary>
/// <para>
/// Fills the bounding rectangle in bin_window coordinates for the cell at the
/// row specified by @path and the column specified by @column.  If @path is
/// %NULL, or points to a path not currently displayed, the @y and @height fields
/// of the rectangle will be filled with 0. If @column is %NULL, the @x and @width
/// fields will be filled with 0.  The sum of all cell rects does not cover the
/// entire tree; there are extra pixels in between rows, for example. The
/// returned rectangle is equivalent to the @cell_area passed to
/// gtk_cell_renderer_render().  This function is only valid if @tree_view is
/// realized.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="path">
/// a #GtkTreePath for the row, or %NULL to get only horizontal coordinates
/// </param>
/// <param name="column">
/// a #GtkTreeViewColumn for the column, or %NULL to get only vertical coordinates
/// </param>
/// <param name="rect">
/// rectangle to fill with cell rect
/// </param>

	public static T GetCellArea<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column, out MentorLake.Gdk.GdkRectangle rect) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_cell_area(tree_view, path, column, out rect);
		return tree_view;
	}

/// <summary>
/// <para>
/// Gets the #GtkTreeViewColumn at the given position in the #tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="n">
/// The position of the column, counting from 0.
/// </param>
/// <return>
/// The #GtkTreeViewColumn, or %NULL if the
/// position is outside the range of columns.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewColumnHandle GetColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int n)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_column(tree_view, n);
	}

/// <summary>
/// <para>
/// Returns a #GList of all the #GtkTreeViewColumn s currently in @tree_view.
/// The returned list must be freed with g_list_free ().
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// A list of #GtkTreeViewColumn s
/// </return>

	public static MentorLake.GLib.GListHandle GetColumns(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_columns(tree_view);
	}

/// <summary>
/// <para>
/// Fills in @path and @focus_column with the current path and focus column.  If
/// the cursor isn’t currently set, then *@path will be %NULL.  If no column
/// currently has focus, then *@focus_column will be %NULL.
/// </para>
/// <para>
/// The returned #GtkTreePath must be freed with gtk_tree_path_free() when
/// you are done with it.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="path">
/// A pointer to be
///   filled with the current cursor path, or %NULL
/// </param>
/// <param name="focus_column">
/// A
///   pointer to be filled with the current focus column, or %NULL
/// </param>

	public static T GetCursor<T>(this T tree_view, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewColumnHandle focus_column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_cursor(tree_view, out path, out focus_column);
		return tree_view;
	}

/// <summary>
/// <para>
/// Determines the destination row for a given position.  @drag_x and
/// @drag_y are expected to be in widget coordinates.  This function is only
/// meaningful if @tree_view is realized.  Therefore this function will always
/// return %FALSE if @tree_view is not realized or does not have a model.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="drag_x">
/// the position to determine the destination row for
/// </param>
/// <param name="drag_y">
/// the position to determine the destination row for
/// </param>
/// <param name="path">
/// Return location for the path of
///   the highlighted row, or %NULL.
/// </param>
/// <param name="pos">
/// Return location for the drop position, or
///   %NULL
/// </param>
/// <return>
/// whether there is a row at the given position, %TRUE if this
/// is indeed the case.
/// </return>

	public static bool GetDestRowAtPos(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int drag_x, int drag_y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewDropPosition pos)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_dest_row_at_pos(tree_view, drag_x, drag_y, out path, out pos);
	}

/// <summary>
/// <para>
/// Gets information about the row that is highlighted for feedback.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="path">
/// Return location for the path of the highlighted row, or %NULL.
/// </param>
/// <param name="pos">
/// Return location for the drop position, or %NULL
/// </param>

	public static T GetDragDestRow<T>(this T tree_view, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewDropPosition pos) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_drag_dest_row(tree_view, out path, out pos);
		return tree_view;
	}

/// <summary>
/// <para>
/// Returns whether or not the tree allows to start interactive searching
/// by typing in text.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// whether or not to let the user search interactively
/// </return>

	public static bool GetEnableSearch(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_enable_search(tree_view);
	}

/// <summary>
/// <para>
/// Returns whether or not tree lines are drawn in @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView.
/// </param>
/// <return>
/// %TRUE if tree lines are drawn in @tree_view, %FALSE
/// otherwise.
/// </return>

	public static bool GetEnableTreeLines(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_enable_tree_lines(tree_view);
	}

/// <summary>
/// <para>
/// Returns the column that is the current expander column.
/// This column has the expander arrow drawn next to it.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// The expander column.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewColumnHandle GetExpanderColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_expander_column(tree_view);
	}

/// <summary>
/// <para>
/// Returns whether fixed height mode is turned on for @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// %TRUE if @tree_view is in fixed height mode
/// </return>

	public static bool GetFixedHeightMode(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_fixed_height_mode(tree_view);
	}

/// <summary>
/// <para>
/// Returns which grid lines are enabled in @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// a #GtkTreeViewGridLines value indicating which grid lines
/// are enabled.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewGridLines GetGridLines(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_grid_lines(tree_view);
	}

/// <summary>
/// <para>
/// Gets the #GtkAdjustment currently being used for the horizontal aspect.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// A #GtkAdjustment object, or %NULL
///     if none is currently being used.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_hadjustment(tree_view);
	}

/// <summary>
/// <para>
/// Returns whether all header columns are clickable.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <return>
/// %TRUE if all header columns are clickable, otherwise %FALSE
/// </return>

	public static bool GetHeadersClickable(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_headers_clickable(tree_view);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the headers on the @tree_view are visible.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <return>
/// Whether the headers are visible or not.
/// </return>

	public static bool GetHeadersVisible(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_headers_visible(tree_view);
	}

/// <summary>
/// <para>
/// Returns whether hover expansion mode is turned on for @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// %TRUE if @tree_view is in hover expansion mode
/// </return>

	public static bool GetHoverExpand(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_hover_expand(tree_view);
	}

/// <summary>
/// <para>
/// Returns whether hover selection mode is turned on for @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// %TRUE if @tree_view is in hover selection mode
/// </return>

	public static bool GetHoverSelection(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_hover_selection(tree_view);
	}

/// <summary>
/// <para>
/// Returns the amount, in pixels, of extra indentation for child levels
/// in @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView.
/// </param>
/// <return>
/// the amount of extra indentation for child levels in
/// @tree_view.  A return value of 0 means that this feature is disabled.
/// </return>

	public static int GetLevelIndentation(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_level_indentation(tree_view);
	}

/// <summary>
/// <para>
/// Returns the model the #GtkTreeView is based on.  Returns %NULL if the
/// model is unset.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// A #GtkTreeModel, or %NULL if
/// none is currently being used.
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_model(tree_view);
	}

/// <summary>
/// <para>
/// Queries the number of columns in the given @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// The number of columns in the @tree_view
/// </return>

	public static uint GetNColumns(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_n_columns(tree_view);
	}

/// <summary>
/// <para>
/// Finds the path at the point (@x, @y), relative to bin_window coordinates
/// (please see gtk_tree_view_get_bin_window()).
/// That is, @x and @y are relative to an events coordinates. @x and @y must
/// come from an event on the @tree_view only where `event-&amp;gt;window ==
/// gtk_tree_view_get_bin_window ()`. It is primarily for
/// things like popup menus. If @path is non-%NULL, then it will be filled
/// with the #GtkTreePath at that point.  This path should be freed with
/// gtk_tree_path_free().  If @column is non-%NULL, then it will be filled
/// with the column at that point.  @cell_x and @cell_y return the coordinates
/// relative to the cell background (i.e. the @background_area passed to
/// gtk_cell_renderer_render()).  This function is only meaningful if
/// @tree_view is realized.  Therefore this function will always return %FALSE
/// if @tree_view is not realized or does not have a model.
/// </para>
/// <para>
/// For converting widget coordinates (eg. the ones you get from
/// GtkWidget::query-tooltip), please see
/// gtk_tree_view_convert_widget_to_bin_window_coords().
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="x">
/// The x position to be identified (relative to bin_window).
/// </param>
/// <param name="y">
/// The y position to be identified (relative to bin_window).
/// </param>
/// <param name="path">
/// A pointer to a #GtkTreePath
///   pointer to be filled in, or %NULL
/// </param>
/// <param name="column">
/// A pointer to
///   a #GtkTreeViewColumn pointer to be filled in, or %NULL
/// </param>
/// <param name="cell_x">
/// A pointer where the X coordinate
///   relative to the cell can be placed, or %NULL
/// </param>
/// <param name="cell_y">
/// A pointer where the Y coordinate
///   relative to the cell can be placed, or %NULL
/// </param>
/// <return>
/// %TRUE if a row exists at that coordinate.
/// </return>

	public static bool GetPathAtPos(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int x, int y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewColumnHandle column, out int cell_x, out int cell_y)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_path_at_pos(tree_view, x, y, out path, out column, out cell_x, out cell_y);
	}

/// <summary>
/// <para>
/// Retrieves whether the user can reorder the tree via drag-and-drop. See
/// gtk_tree_view_set_reorderable().
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// %TRUE if the tree can be reordered.
/// </return>

	public static bool GetReorderable(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_reorderable(tree_view);
	}

/// <summary>
/// <para>
/// Returns the current row separator function.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// the current row separator function.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_row_separator_func(tree_view);
	}

/// <summary>
/// <para>
/// Returns whether rubber banding is turned on for @tree_view.  If the
/// selection mode is #GTK_SELECTION_MULTIPLE, rubber banding will allow the
/// user to select multiple rows by dragging the mouse.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// %TRUE if rubber banding in @tree_view is enabled.
/// </return>

	public static bool GetRubberBanding(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_rubber_banding(tree_view);
	}

/// <summary>
/// <para>
/// Gets the setting set by gtk_tree_view_set_rules_hint().
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// %TRUE if the hint is set
/// </return>

	public static bool GetRulesHint(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_rules_hint(tree_view);
	}

/// <summary>
/// <para>
/// Gets the column searched on by the interactive search code.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// the column the interactive search code searches in.
/// </return>

	public static int GetSearchColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_search_column(tree_view);
	}

/// <summary>
/// <para>
/// Returns the #GtkEntry which is currently in use as interactive search
/// entry for @tree_view.  In case the built-in entry is being used, %NULL
/// will be returned.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// the entry currently in use as search entry.
/// </return>

	public static MentorLake.Gtk.GtkEntryHandle GetSearchEntry(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_search_entry(tree_view);
	}

/// <summary>
/// <para>
/// Returns the compare function currently in use.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// the currently used compare function for the search code.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewSearchEqualFunc GetSearchEqualFunc(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_search_equal_func(tree_view);
	}

/// <summary>
/// <para>
/// Returns the positioning function currently in use.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// the currently used function for positioning the search dialog.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewSearchPositionFunc GetSearchPositionFunc(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_search_position_func(tree_view);
	}

/// <summary>
/// <para>
/// Gets the #GtkTreeSelection associated with @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <return>
/// A #GtkTreeSelection object.
/// </return>

	public static MentorLake.Gtk.GtkTreeSelectionHandle GetSelection(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_selection(tree_view);
	}

/// <summary>
/// <para>
/// Returns whether or not expanders are drawn in @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView.
/// </param>
/// <return>
/// %TRUE if expanders are drawn in @tree_view, %FALSE
/// otherwise.
/// </return>

	public static bool GetShowExpanders(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_show_expanders(tree_view);
	}

/// <summary>
/// <para>
/// Returns the column of @tree_view’s model which is being used for
/// displaying tooltips on @tree_view’s rows.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// the index of the tooltip column that is currently being
/// used, or -1 if this is disabled.
/// </return>

	public static int GetTooltipColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_tooltip_column(tree_view);
	}

/// <summary>
/// <para>
/// This function is supposed to be used in a #GtkWidget::query-tooltip
/// signal handler for #GtkTreeView.  The @x, @y and @keyboard_tip values
/// which are received in the signal handler, should be passed to this
/// function without modification.
/// </para>
/// <para>
/// The return value indicates whether there is a tree view row at the given
/// coordinates (%TRUE) or not (%FALSE) for mouse tooltips.  For keyboard
/// tooltips the row returned will be the cursor row.  When %TRUE, then any of
/// @model, @path and @iter which have been provided will be set to point to
/// that row and the corresponding model.  @x and @y will always be converted
/// to be relative to @tree_view’s bin_window if @keyboard_tooltip is %FALSE.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="x">
/// the x coordinate (relative to widget coordinates)
/// </param>
/// <param name="y">
/// the y coordinate (relative to widget coordinates)
/// </param>
/// <param name="keyboard_tip">
/// whether this is a keyboard tooltip or not
/// </param>
/// <param name="model">
/// a pointer to
///         receive a #GtkTreeModel or %NULL
/// </param>
/// <param name="path">
/// a pointer to receive a #GtkTreePath or %NULL
/// </param>
/// <param name="iter">
/// a pointer to receive a #GtkTreeIter or %NULL
/// </param>
/// <return>
/// whether or not the given tooltip context points to a row.
/// </return>

	public static bool GetTooltipContext(this MentorLake.Gtk.GtkTreeViewHandle tree_view, ref int x, ref int y, bool keyboard_tip, out MentorLake.Gtk.GtkTreeModelHandle model, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeIter iter)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_tooltip_context(tree_view, ref x, ref y, keyboard_tip, out model, out path, out iter);
	}

/// <summary>
/// <para>
/// Gets the #GtkAdjustment currently being used for the vertical aspect.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <return>
/// A #GtkAdjustment object, or %NULL
///     if none is currently being used.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_vadjustment(tree_view);
	}

/// <summary>
/// <para>
/// Sets @start_path and @end_path to be the first and last visible path.
/// Note that there may be invisible paths in between.
/// </para>
/// <para>
/// The paths should be freed with gtk_tree_path_free() after use.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="start_path">
/// Return location for start of region,
///              or %NULL.
/// </param>
/// <param name="end_path">
/// Return location for end of region, or %NULL.
/// </param>
/// <return>
/// %TRUE, if valid paths were placed in @start_path and @end_path.
/// </return>

	public static bool GetVisibleRange(this MentorLake.Gtk.GtkTreeViewHandle tree_view, out MentorLake.Gtk.GtkTreePathHandle start_path, out MentorLake.Gtk.GtkTreePathHandle end_path)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_get_visible_range(tree_view, out start_path, out end_path);
	}

/// <summary>
/// <para>
/// Fills @visible_rect with the currently-visible region of the
/// buffer, in tree coordinates. Convert to bin_window coordinates with
/// gtk_tree_view_convert_tree_to_bin_window_coords().
/// Tree coordinates start at 0,0 for row 0 of the tree, and cover the entire
/// scrollable area of the tree.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="visible_rect">
/// rectangle to fill
/// </param>

	public static T GetVisibleRect<T>(this T tree_view, out MentorLake.Gdk.GdkRectangle visible_rect) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_get_visible_rect(tree_view, out visible_rect);
		return tree_view;
	}

/// <summary>
/// <para>
/// This inserts the @column into the @tree_view at @position.  If @position is
/// -1, then the column is inserted at the end. If @tree_view has
/// “fixed_height” mode enabled, then @column must have its “sizing” property
/// set to be GTK_TREE_VIEW_COLUMN_FIXED.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="column">
/// The #GtkTreeViewColumn to be inserted.
/// </param>
/// <param name="position">
/// The position to insert @column in.
/// </param>
/// <return>
/// The number of columns in @tree_view after insertion.
/// </return>

	public static int InsertColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column, int position)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_insert_column(tree_view, column, position);
	}

/// <summary>
/// <para>
/// Creates a new #GtkTreeViewColumn and inserts it into the @tree_view at
/// @position.  If @position is -1, then the newly created column is inserted at
/// the end.  The column is initialized with the attributes given. If @tree_view
/// has “fixed_height” mode enabled, then the new column will have its sizing
/// property set to be GTK_TREE_VIEW_COLUMN_FIXED.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="position">
/// The position to insert the new column in
/// </param>
/// <param name="title">
/// The title to set the header to
/// </param>
/// <param name="cell">
/// The #GtkCellRenderer
/// </param>
/// <param name="@__arglist">
/// A %NULL-terminated list of attributes
/// </param>
/// <return>
/// The number of columns in @tree_view after insertion.
/// </return>

	public static int InsertColumnWithAttributes(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int position, string title, MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_insert_column_with_attributes(tree_view, position, title, cell, @__arglist);
	}

/// <summary>
/// <para>
/// Convenience function that inserts a new column into the #GtkTreeView
/// with the given cell renderer and a #GtkTreeCellDataFunc to set cell renderer
/// attributes (normally using data from the model). See also
/// gtk_tree_view_column_set_cell_data_func(), gtk_tree_view_column_pack_start().
/// If @tree_view has “fixed_height” mode enabled, then the new column will have its
/// “sizing” property set to be GTK_TREE_VIEW_COLUMN_FIXED.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="position">
/// Position to insert, -1 for append
/// </param>
/// <param name="title">
/// column title
/// </param>
/// <param name="cell">
/// cell renderer for column
/// </param>
/// <param name="func">
/// function to set attributes of cell renderer
/// </param>
/// <param name="data">
/// data for @func
/// </param>
/// <param name="dnotify">
/// destroy notifier for @data
/// </param>
/// <return>
/// number of columns in the tree view post-insert
/// </return>

	public static int InsertColumnWithDataFunc(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int position, string title, MentorLake.Gtk.GtkCellRendererHandle cell, MentorLake.Gtk.GtkTreeCellDataFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify dnotify)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_insert_column_with_data_func(tree_view, position, title, cell, func, data, dnotify);
	}

/// <summary>
/// <para>
/// Determine whether the point (@x, @y) in @tree_view is blank, that is no
/// cell content nor an expander arrow is drawn at the location. If so, the
/// location can be considered as the background. You might wish to take
/// special action on clicks on the background, such as clearing a current
/// selection, having a custom context menu or starting rubber banding.
/// </para>
/// <para>
/// The @x and @y coordinate that are provided must be relative to bin_window
/// coordinates.  That is, @x and @y must come from an event on @tree_view
/// where `event-&amp;gt;window == gtk_tree_view_get_bin_window ()`.
/// </para>
/// <para>
/// For converting widget coordinates (eg. the ones you get from
/// GtkWidget::query-tooltip), please see
/// gtk_tree_view_convert_widget_to_bin_window_coords().
/// </para>
/// <para>
/// The @path, @column, @cell_x and @cell_y arguments will be filled in
/// likewise as for gtk_tree_view_get_path_at_pos().  Please see
/// gtk_tree_view_get_path_at_pos() for more information.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="x">
/// The x position to be identified (relative to bin_window)
/// </param>
/// <param name="y">
/// The y position to be identified (relative to bin_window)
/// </param>
/// <param name="path">
/// A pointer to a #GtkTreePath pointer to
///   be filled in, or %NULL
/// </param>
/// <param name="column">
/// A pointer to a
///   #GtkTreeViewColumn pointer to be filled in, or %NULL
/// </param>
/// <param name="cell_x">
/// A pointer where the X coordinate relative to the
///   cell can be placed, or %NULL
/// </param>
/// <param name="cell_y">
/// A pointer where the Y coordinate relative to the
///   cell can be placed, or %NULL
/// </param>
/// <return>
/// %TRUE if the area at the given coordinates is blank,
/// %FALSE otherwise.
/// </return>

	public static bool IsBlankAtPos(this MentorLake.Gtk.GtkTreeViewHandle tree_view, int x, int y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeViewColumnHandle column, out int cell_x, out int cell_y)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_is_blank_at_pos(tree_view, x, y, out path, out column, out cell_x, out cell_y);
	}

/// <summary>
/// <para>
/// Returns whether a rubber banding operation is currently being done
/// in @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <return>
/// %TRUE if a rubber banding operation is currently being
/// done in @tree_view.
/// </return>

	public static bool IsRubberBandingActive(this MentorLake.Gtk.GtkTreeViewHandle tree_view)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_is_rubber_banding_active(tree_view);
	}

/// <summary>
/// <para>
/// Calls @func on all expanded rows.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="func">
/// A function to be called
/// </param>
/// <param name="data">
/// User data to be passed to the function.
/// </param>

	public static T MapExpandedRows<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewMappingFunc func, IntPtr data) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_map_expanded_rows(tree_view, func, data);
		return tree_view;
	}

/// <summary>
/// <para>
/// Moves @column to be after to @base_column.  If @base_column is %NULL, then
/// @column is placed in the first position.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="column">
/// The #GtkTreeViewColumn to be moved.
/// </param>
/// <param name="base_column">
/// The #GtkTreeViewColumn to be moved relative to, or %NULL.
/// </param>

	public static T MoveColumnAfter<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column, MentorLake.Gtk.GtkTreeViewColumnHandle base_column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_move_column_after(tree_view, column, base_column);
		return tree_view;
	}

/// <summary>
/// <para>
/// Removes @column from @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="column">
/// The #GtkTreeViewColumn to remove.
/// </param>
/// <return>
/// The number of columns in @tree_view after removing.
/// </return>

	public static int RemoveColumn(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_remove_column(tree_view, column);
	}

/// <summary>
/// <para>
/// Activates the cell determined by @path and @column.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="path">
/// The #GtkTreePath to be activated.
/// </param>
/// <param name="column">
/// The #GtkTreeViewColumn to be activated.
/// </param>

	public static T RowActivated<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_row_activated(tree_view, path, column);
		return tree_view;
	}

/// <summary>
/// <para>
/// Returns %TRUE if the node pointed to by @path is expanded in @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="path">
/// A #GtkTreePath to test expansion state.
/// </param>
/// <return>
/// %TRUE if #path is expanded.
/// </return>

	public static bool RowExpanded(this MentorLake.Gtk.GtkTreeViewHandle tree_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		return GtkTreeViewHandleExterns.gtk_tree_view_row_expanded(tree_view, path);
	}

/// <summary>
/// <para>
/// Moves the alignments of @tree_view to the position specified by @column and
/// @path.  If @column is %NULL, then no horizontal scrolling occurs.  Likewise,
/// if @path is %NULL no vertical scrolling occurs.  At a minimum, one of @column
/// or @path need to be non-%NULL.  @row_align determines where the row is
/// placed, and @col_align determines where @column is placed.  Both are expected
/// to be between 0.0 and 1.0. 0.0 means left/top alignment, 1.0 means
/// right/bottom alignment, 0.5 means center.
/// </para>
/// <para>
/// If @use_align is %FALSE, then the alignment arguments are ignored, and the
/// tree does the minimum amount of work to scroll the cell onto the screen.
/// This means that the cell will be scrolled to the edge closest to its current
/// position.  If the cell is currently visible on the screen, nothing is done.
/// </para>
/// <para>
/// This function only works if the model is set, and @path is a valid row on the
/// model.  If the model changes before the @tree_view is realized, the centered
/// path will be modified to reflect this change.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="path">
/// The path of the row to move to, or %NULL.
/// </param>
/// <param name="column">
/// The #GtkTreeViewColumn to move horizontally to, or %NULL.
/// </param>
/// <param name="use_align">
/// whether to use alignment arguments, or %FALSE.
/// </param>
/// <param name="row_align">
/// The vertical alignment of the row specified by @path.
/// </param>
/// <param name="col_align">
/// The horizontal alignment of the column specified by @column.
/// </param>

	public static T ScrollToCell<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column, bool use_align, float row_align, float col_align) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_scroll_to_cell(tree_view, path, column, use_align, row_align, col_align);
		return tree_view;
	}

/// <summary>
/// <para>
/// Scrolls the tree view such that the top-left corner of the visible
/// area is @tree_x, @tree_y, where @tree_x and @tree_y are specified
/// in tree coordinates.  The @tree_view must be realized before
/// this function is called.  If it isn&apos;t, you probably want to be
/// using gtk_tree_view_scroll_to_cell().
/// </para>
/// <para>
/// If either @tree_x or @tree_y are -1, then that direction isn’t scrolled.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="tree_x">
/// X coordinate of new top-left pixel of visible area, or -1
/// </param>
/// <param name="tree_y">
/// Y coordinate of new top-left pixel of visible area, or -1
/// </param>

	public static T ScrollToPoint<T>(this T tree_view, int tree_x, int tree_y) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_scroll_to_point(tree_view, tree_x, tree_y);
		return tree_view;
	}

/// <summary>
/// <para>
/// Cause the #GtkTreeView::row-activated signal to be emitted
/// on a single click instead of a double click.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="single">
/// %TRUE to emit row-activated on a single click
/// </param>

	public static T SetActivateOnSingleClick<T>(this T tree_view, bool single) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_activate_on_single_click(tree_view, single);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets a user function for determining where a column may be dropped when
/// dragged.  This function is called on every column pair in turn at the
/// beginning of a column drag to determine where a drop can take place.  The
/// arguments passed to @func are: the @tree_view, the #GtkTreeViewColumn being
/// dragged, the two #GtkTreeViewColumn s determining the drop spot, and
/// @user_data.  If either of the #GtkTreeViewColumn arguments for the drop spot
/// are %NULL, then they indicate an edge.  If @func is set to be %NULL, then
/// @tree_view reverts to the default behavior of allowing all columns to be
/// dropped everywhere.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="func">
/// A function to determine which columns are reorderable, or %NULL.
/// </param>
/// <param name="user_data">
/// User data to be passed to @func, or %NULL
/// </param>
/// <param name="destroy">
/// Destroy notifier for @user_data, or %NULL
/// </param>

	public static T SetColumnDragFunction<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewColumnDropFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_column_drag_function(tree_view, func, user_data, destroy);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the current keyboard focus to be at @path, and selects it.  This is
/// useful when you want to focus the user’s attention on a particular row.  If
/// @focus_column is not %NULL, then focus is given to the column specified by
/// it. Additionally, if @focus_column is specified, and @start_editing is
/// %TRUE, then editing should be started in the specified cell.
/// This function is often followed by @gtk_widget_grab_focus (@tree_view)
/// in order to give keyboard focus to the widget.  Please note that editing
/// can only happen when the widget is realized.
/// </para>
/// <para>
/// If @path is invalid for @model, the current cursor (if any) will be unset
/// and the function will return without failing.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="path">
/// A #GtkTreePath
/// </param>
/// <param name="focus_column">
/// A #GtkTreeViewColumn, or %NULL
/// </param>
/// <param name="start_editing">
/// %TRUE if the specified cell should start being edited.
/// </param>

	public static T SetCursor<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle focus_column, bool start_editing) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_cursor(tree_view, path, focus_column, start_editing);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the current keyboard focus to be at @path, and selects it.  This is
/// useful when you want to focus the user’s attention on a particular row.  If
/// @focus_column is not %NULL, then focus is given to the column specified by
/// it. If @focus_column and @focus_cell are not %NULL, and @focus_column
/// contains 2 or more editable or activatable cells, then focus is given to
/// the cell specified by @focus_cell. Additionally, if @focus_column is
/// specified, and @start_editing is %TRUE, then editing should be started in
/// the specified cell.  This function is often followed by
/// @gtk_widget_grab_focus (@tree_view) in order to give keyboard focus to the
/// widget.  Please note that editing can only happen when the widget is
/// realized.
/// </para>
/// <para>
/// If @path is invalid for @model, the current cursor (if any) will be unset
/// and the function will return without failing.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="path">
/// A #GtkTreePath
/// </param>
/// <param name="focus_column">
/// A #GtkTreeViewColumn, or %NULL
/// </param>
/// <param name="focus_cell">
/// A #GtkCellRenderer, or %NULL
/// </param>
/// <param name="start_editing">
/// %TRUE if the specified cell should start being edited.
/// </param>

	public static T SetCursorOnCell<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle focus_column, MentorLake.Gtk.GtkCellRendererHandle focus_cell, bool start_editing) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_cursor_on_cell(tree_view, path, focus_column, focus_cell, start_editing);
		return tree_view;
	}

/// <summary>
/// <para>
/// This function should almost never be used.  It is meant for private use by
/// ATK for determining the number of visible children that are removed when the
/// user collapses a row, or a row is deleted.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="func">
/// Function to be called when a view row is destroyed, or %NULL
/// </param>
/// <param name="data">
/// User data to be passed to @func, or %NULL
/// </param>
/// <param name="destroy">
/// Destroy notifier for @data, or %NULL
/// </param>

	public static T SetDestroyCountFunc<T>(this T tree_view, MentorLake.Gtk.GtkTreeDestroyCountFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_destroy_count_func(tree_view, func, data, destroy);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the row that is highlighted for feedback.
/// If @path is %NULL, an existing highlight is removed.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="path">
/// The path of the row to highlight, or %NULL
/// </param>
/// <param name="pos">
/// Specifies whether to drop before, after or into the row
/// </param>

	public static T SetDragDestRow<T>(this T tree_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewDropPosition pos) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_drag_dest_row(tree_view, path, pos);
		return tree_view;
	}

/// <summary>
/// <para>
/// If @enable_search is set, then the user can type in text to search through
/// the tree interactively (this is sometimes called &quot;typeahead find&quot;).
/// </para>
/// <para>
/// Note that even if this is %FALSE, the user can still initiate a search
/// using the “start-interactive-search” key binding.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="enable_search">
/// %TRUE, if the user can search interactively
/// </param>

	public static T SetEnableSearch<T>(this T tree_view, bool enable_search) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_enable_search(tree_view, enable_search);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets whether to draw lines interconnecting the expanders in @tree_view.
/// This does not have any visible effects for lists.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="enabled">
/// %TRUE to enable tree line drawing, %FALSE otherwise.
/// </param>

	public static T SetEnableTreeLines<T>(this T tree_view, bool enabled) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_enable_tree_lines(tree_view, enabled);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the column to draw the expander arrow at. It must be in @tree_view.
/// If @column is %NULL, then the expander arrow is always at the first
/// visible column.
/// </para>
/// <para>
/// If you do not want expander arrow to appear in your tree, set the
/// expander column to a hidden column.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="column">
/// %NULL, or the column to draw the expander arrow at.
/// </param>

	public static T SetExpanderColumn<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewColumnHandle column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_expander_column(tree_view, column);
		return tree_view;
	}

/// <summary>
/// <para>
/// Enables or disables the fixed height mode of @tree_view.
/// Fixed height mode speeds up #GtkTreeView by assuming that all
/// rows have the same height.
/// Only enable this option if all rows are the same height and all
/// columns are of type %GTK_TREE_VIEW_COLUMN_FIXED.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="enable">
/// %TRUE to enable fixed height mode
/// </param>

	public static T SetFixedHeightMode<T>(this T tree_view, bool enable) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_fixed_height_mode(tree_view, enable);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets which grid lines to draw in @tree_view.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="grid_lines">
/// a #GtkTreeViewGridLines value indicating which grid lines to
/// enable.
/// </param>

	public static T SetGridLines<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewGridLines grid_lines) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_grid_lines(tree_view, grid_lines);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the #GtkAdjustment for the current horizontal aspect.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="adjustment">
/// The #GtkAdjustment to set, or %NULL
/// </param>

	public static T SetHadjustment<T>(this T tree_view, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_hadjustment(tree_view, adjustment);
		return tree_view;
	}

/// <summary>
/// <para>
/// Allow the column title buttons to be clicked.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="setting">
/// %TRUE if the columns are clickable.
/// </param>

	public static T SetHeadersClickable<T>(this T tree_view, bool setting) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_headers_clickable(tree_view, setting);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the visibility state of the headers.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="headers_visible">
/// %TRUE if the headers are visible
/// </param>

	public static T SetHeadersVisible<T>(this T tree_view, bool headers_visible) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_headers_visible(tree_view, headers_visible);
		return tree_view;
	}

/// <summary>
/// <para>
/// Enables or disables the hover expansion mode of @tree_view.
/// Hover expansion makes rows expand or collapse if the pointer
/// moves over them.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="expand">
/// %TRUE to enable hover selection mode
/// </param>

	public static T SetHoverExpand<T>(this T tree_view, bool expand) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_hover_expand(tree_view, expand);
		return tree_view;
	}

/// <summary>
/// <para>
/// Enables or disables the hover selection mode of @tree_view.
/// Hover selection makes the selected row follow the pointer.
/// Currently, this works only for the selection modes
/// %GTK_SELECTION_SINGLE and %GTK_SELECTION_BROWSE.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="hover">
/// %TRUE to enable hover selection mode
/// </param>

	public static T SetHoverSelection<T>(this T tree_view, bool hover) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_hover_selection(tree_view, hover);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the amount of extra indentation for child levels to use in @tree_view
/// in addition to the default indentation.  The value should be specified in
/// pixels, a value of 0 disables this feature and in this case only the default
/// indentation will be used.
/// This does not have any visible effects for lists.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="indentation">
/// the amount, in pixels, of extra indentation in @tree_view.
/// </param>

	public static T SetLevelIndentation<T>(this T tree_view, int indentation) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_level_indentation(tree_view, indentation);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the model for a #GtkTreeView.  If the @tree_view already has a model
/// set, it will remove it before setting the new model.  If @model is %NULL,
/// then it will unset the old model.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="model">
/// The model.
/// </param>

	public static T SetModel<T>(this T tree_view, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_model(tree_view, model);
		return tree_view;
	}

/// <summary>
/// <para>
/// This function is a convenience function to allow you to reorder
/// models that support the #GtkTreeDragSourceIface and the
/// #GtkTreeDragDestIface.  Both #GtkTreeStore and #GtkListStore support
/// these.  If @reorderable is %TRUE, then the user can reorder the
/// model by dragging and dropping rows. The developer can listen to
/// these changes by connecting to the model’s #GtkTreeModel::row-inserted
/// and #GtkTreeModel::row-deleted signals. The reordering is implemented
/// by setting up the tree view as a drag source and destination.
/// Therefore, drag and drop can not be used in a reorderable view for any
/// other purpose.
/// </para>
/// <para>
/// This function does not give you any degree of control over the order -- any
/// reordering is allowed.  If more control is needed, you should probably
/// handle drag and drop manually.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView.
/// </param>
/// <param name="reorderable">
/// %TRUE, if the tree can be reordered.
/// </param>

	public static T SetReorderable<T>(this T tree_view, bool reorderable) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_reorderable(tree_view, reorderable);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the row separator function, which is used to determine
/// whether a row should be drawn as a separator. If the row separator
/// function is %NULL, no separators are drawn. This is the default value.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="func">
/// a #GtkTreeViewRowSeparatorFunc
/// </param>
/// <param name="data">
/// user data to pass to @func, or %NULL
/// </param>
/// <param name="destroy">
/// destroy notifier for @data, or %NULL
/// </param>

	public static T SetRowSeparatorFunc<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewRowSeparatorFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_row_separator_func(tree_view, func, data, destroy);
		return tree_view;
	}

/// <summary>
/// <para>
/// Enables or disables rubber banding in @tree_view.  If the selection mode
/// is #GTK_SELECTION_MULTIPLE, rubber banding will allow the user to select
/// multiple rows by dragging the mouse.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="enable">
/// %TRUE to enable rubber banding
/// </param>

	public static T SetRubberBanding<T>(this T tree_view, bool enable) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_rubber_banding(tree_view, enable);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets a hint for the theme to draw even/odd rows in the @tree_view
/// with different colors, also known as &quot;zebra striping&quot;.
/// </para>
/// <para>
/// This function tells the GTK+ theme that the user interface for your
/// application requires users to read across tree rows and associate
/// cells with one another.
/// </para>
/// <para>
/// Do not use it just because you prefer the appearance of the ruled
/// tree; that’s a question for the theme. Some themes will draw tree
/// rows in alternating colors even when rules are turned off, and
/// users who prefer that appearance all the time can choose those
/// themes. You should call this function only as a semantic hint to
/// the theme engine that your tree makes alternating colors useful
/// from a functional standpoint (since it has lots of columns,
/// generally).
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="setting">
/// %TRUE if the tree requires reading across rows
/// </param>

	public static T SetRulesHint<T>(this T tree_view, bool setting) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_rules_hint(tree_view, setting);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets @column as the column where the interactive search code should
/// search in for the current model.
/// </para>
/// <para>
/// If the search column is set, users can use the “start-interactive-search”
/// key binding to bring up search popup. The enable-search property controls
/// whether simply typing text will also start an interactive search.
/// </para>
/// <para>
/// Note that @column refers to a column of the current model. The search
/// column is reset to -1 when the model is changed.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="column">
/// the column of the model to search in, or -1 to disable searching
/// </param>

	public static T SetSearchColumn<T>(this T tree_view, int column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_search_column(tree_view, column);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the entry which the interactive search code will use for this
/// @tree_view.  This is useful when you want to provide a search entry
/// in our interface at all time at a fixed position.  Passing %NULL for
/// @entry will make the interactive search code use the built-in popup
/// entry again.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="entry">
/// the entry the interactive search code of @tree_view should use or %NULL
/// </param>

	public static T SetSearchEntry<T>(this T tree_view, MentorLake.Gtk.GtkEntryHandle entry) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_search_entry(tree_view, entry);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the compare function for the interactive search capabilities; note
/// that somewhat like strcmp() returning 0 for equality
/// #GtkTreeViewSearchEqualFunc returns %FALSE on matches.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="search_equal_func">
/// the compare function to use during the search
/// </param>
/// <param name="search_user_data">
/// user data to pass to @search_equal_func, or %NULL
/// </param>
/// <param name="search_destroy">
/// Destroy notifier for @search_user_data, or %NULL
/// </param>

	public static T SetSearchEqualFunc<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewSearchEqualFunc search_equal_func, IntPtr search_user_data, MentorLake.GLib.GDestroyNotify search_destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_search_equal_func(tree_view, search_equal_func, search_user_data, search_destroy);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the function to use when positioning the search dialog.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="func">
/// the function to use to position the search dialog, or %NULL
///    to use the default search position function
/// </param>
/// <param name="data">
/// user data to pass to @func, or %NULL
/// </param>
/// <param name="destroy">
/// Destroy notifier for @data, or %NULL
/// </param>

	public static T SetSearchPositionFunc<T>(this T tree_view, MentorLake.Gtk.GtkTreeViewSearchPositionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_search_position_func(tree_view, func, data, destroy);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets whether to draw and enable expanders and indent child rows in
/// @tree_view.  When disabled there will be no expanders visible in trees
/// and there will be no way to expand and collapse rows by default.  Also
/// note that hiding the expanders will disable the default indentation.  You
/// can set a custom indentation in this case using
/// gtk_tree_view_set_level_indentation().
/// This does not have any visible effects for lists.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="enabled">
/// %TRUE to enable expander drawing, %FALSE otherwise.
/// </param>

	public static T SetShowExpanders<T>(this T tree_view, bool enabled) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_show_expanders(tree_view, enabled);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the tip area of @tooltip to the area @path, @column and @cell have
/// in common.  For example if @path is %NULL and @column is set, the tip
/// area will be set to the full area covered by @column.  See also
/// gtk_tooltip_set_tip_area().
/// </para>
/// <para>
/// Note that if @path is not specified and @cell is set and part of a column
/// containing the expander, the tooltip might not show and hide at the correct
/// position.  In such cases @path must be set to the current node under the
/// mouse cursor for this function to operate correctly.
/// </para>
/// <para>
/// See also gtk_tree_view_set_tooltip_column() for a simpler alternative.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="path">
/// a #GtkTreePath or %NULL
/// </param>
/// <param name="column">
/// a #GtkTreeViewColumn or %NULL
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer or %NULL
/// </param>

	public static T SetTooltipCell<T>(this T tree_view, MentorLake.Gtk.GtkTooltipHandle tooltip, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeViewColumnHandle column, MentorLake.Gtk.GtkCellRendererHandle cell) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_tooltip_cell(tree_view, tooltip, path, column, cell);
		return tree_view;
	}

/// <summary>
/// <para>
/// If you only plan to have simple (text-only) tooltips on full rows, you
/// can use this function to have #GtkTreeView handle these automatically
/// for you. @column should be set to the column in @tree_view’s model
/// containing the tooltip texts, or -1 to disable this feature.
/// </para>
/// <para>
/// When enabled, #GtkWidget:has-tooltip will be set to %TRUE and
/// @tree_view will connect a #GtkWidget::query-tooltip signal handler.
/// </para>
/// <para>
/// Note that the signal handler sets the text with gtk_tooltip_set_markup(),
/// so &amp;, &amp;lt;, etc have to be escaped in the text.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="column">
/// an integer, which is a valid column number for @tree_view’s model
/// </param>

	public static T SetTooltipColumn<T>(this T tree_view, int column) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_tooltip_column(tree_view, column);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the tip area of @tooltip to be the area covered by the row at @path.
/// See also gtk_tree_view_set_tooltip_column() for a simpler alternative.
/// See also gtk_tooltip_set_tip_area().
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>
/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="path">
/// a #GtkTreePath
/// </param>

	public static T SetTooltipRow<T>(this T tree_view, MentorLake.Gtk.GtkTooltipHandle tooltip, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_tooltip_row(tree_view, tooltip, path);
		return tree_view;
	}

/// <summary>
/// <para>
/// Sets the #GtkAdjustment for the current vertical aspect.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="adjustment">
/// The #GtkAdjustment to set, or %NULL
/// </param>

	public static T SetVadjustment<T>(this T tree_view, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_set_vadjustment(tree_view, adjustment);
		return tree_view;
	}

/// <summary>
/// <para>
/// Undoes the effect of
/// gtk_tree_view_enable_model_drag_dest(). Calling this method sets
/// #GtkTreeView:reorderable to %FALSE.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>

	public static T UnsetRowsDragDest<T>(this T tree_view) where T : GtkTreeViewHandle
	{
		if (tree_view.IsInvalid) throw new Exception("Invalid handle (GtkTreeViewHandle)");
		GtkTreeViewHandleExterns.gtk_tree_view_unset_rows_drag_dest(tree_view);
		return tree_view;
	}

/// <summary>
/// <para>
/// Undoes the effect of
/// gtk_tree_view_enable_model_drag_source(). Calling this method sets
/// #GtkTreeView:reorderable to %FALSE.
/// </para>
/// </summary>

/// <param name="tree_view">
/// a #GtkTreeView
/// </param>

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
