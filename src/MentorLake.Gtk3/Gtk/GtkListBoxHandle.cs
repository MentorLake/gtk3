namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkListBox is a vertical container that contains GtkListBoxRow
/// children. These rows can be dynamically sorted and filtered, and
/// headers can be added dynamically depending on the row content.
/// It also allows keyboard and mouse navigation and selection like
/// a typical list.
/// </para>
/// <para>
/// Using GtkListBox is often an alternative to #GtkTreeView, especially
/// when the list contents has a more complicated layout than what is allowed
/// by a #GtkCellRenderer, or when the contents is interactive (i.e. has a
/// button in it).
/// </para>
/// <para>
/// Although a #GtkListBox must have only #GtkListBoxRow children you can
/// add any kind of widget to it via gtk_container_add(), and a #GtkListBoxRow
/// widget will automatically be inserted between the list and the widget.
/// </para>
/// <para>
/// #GtkListBoxRows can be marked as activatable or selectable. If a row
/// is activatable, #GtkListBox::row-activated will be emitted for it when
/// the user tries to activate it. If it is selectable, the row will be marked
/// as selected when the user tries to select it.
/// </para>
/// <para>
/// The GtkListBox widget was added in GTK+ 3.10.
/// </para>
/// <para>
/// # GtkListBox as GtkBuildable
/// </para>
/// <para>
/// The GtkListBox implementation of the #GtkBuildable interface supports
/// setting a child as the placeholder by specifying “placeholder” as the “type”
/// attribute of a `&amp;lt;child&amp;gt;` element. See gtk_list_box_set_placeholder() for info.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// list
/// list
/// ╰── row[.activatable]
/// </code>
/// <para>
/// GtkListBox uses a single CSS node named list. Each GtkListBoxRow uses
/// a single CSS node named row. The row nodes get the .activatable
/// style class added when appropriate.
/// </para>
/// </summary>

public class GtkListBoxHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkListBox container.
/// </para>
/// </summary>

/// <return>
/// a new #GtkListBox
/// </return>

	public static MentorLake.Gtk.GtkListBoxHandle New()
	{
		return GtkListBoxHandleExterns.gtk_list_box_new();
	}

}
public static class GtkListBoxHandleSignalExtensions
{

	public static IObservable<GtkListBoxHandleSignalStructs.ActivateCursorRowSignal> Signal_ActivateCursorRow(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.ActivateCursorRowSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.activate_cursor_row handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.ActivateCursorRowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-cursor-row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkListBoxHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkListBoxHandle self,  MentorLake.Gtk.GtkMovementStep @object,  int p0,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.MoveCursorSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
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
/// The ::row-activated signal is emitted when a row has been activated by the user.
/// </para>
/// </summary>

	public static IObservable<GtkListBoxHandleSignalStructs.RowActivatedSignal> Signal_RowActivated(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.RowActivatedSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.row_activated handler = ( MentorLake.Gtk.GtkListBoxHandle self,  MentorLake.Gtk.GtkListBoxRowHandle row,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.RowActivatedSignal()
				{
					Self = self, Row = row, UserData = user_data
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
/// The ::row-selected signal is emitted when a new row is selected, or
/// (with a %NULL @row) when the selection is cleared.
/// </para>
/// <para>
/// When the @box is using #GTK_SELECTION_MULTIPLE, this signal will not
/// give you the full picture of selection changes, and you should use
/// the #GtkListBox::selected-rows-changed signal instead.
/// </para>
/// </summary>

	public static IObservable<GtkListBoxHandleSignalStructs.RowSelectedSignal> Signal_RowSelected(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.RowSelectedSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.row_selected handler = ( MentorLake.Gtk.GtkListBoxHandle self,  MentorLake.Gtk.GtkListBoxRowHandle row,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.RowSelectedSignal()
				{
					Self = self, Row = row, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::select-all signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted to select all children of the box, if the selection
/// mode permits it.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-a.
/// </para>
/// </summary>

	public static IObservable<GtkListBoxHandleSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.SelectAllSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.select_all handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.SelectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
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
/// <summary>
/// <para>
/// The ::selected-rows-changed signal is emitted when the
/// set of selected rows changes.
/// </para>
/// </summary>

	public static IObservable<GtkListBoxHandleSignalStructs.SelectedRowsChangedSignal> Signal_SelectedRowsChanged(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.SelectedRowsChangedSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.selected_rows_changed handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.SelectedRowsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selected-rows-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkListBoxHandleSignalStructs.ToggleCursorRowSignal> Signal_ToggleCursorRow(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.ToggleCursorRowSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.toggle_cursor_row handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.ToggleCursorRowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
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
/// <summary>
/// <para>
/// The ::unselect-all signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted to unselect all children of the box, if the selection
/// mode permits it.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-Shift-a.
/// </para>
/// </summary>

	public static IObservable<GtkListBoxHandleSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkListBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxHandleSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkListBoxHandleSignalDelegates.unselect_all handler = ( MentorLake.Gtk.GtkListBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxHandleSignalStructs.UnselectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
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

public static class GtkListBoxHandleSignalStructs
{

public class ActivateCursorRowSignal
{

	public MentorLake.Gtk.GtkListBoxHandle Self;

	public IntPtr UserData;
}

public class MoveCursorSignal
{

	public MentorLake.Gtk.GtkListBoxHandle Self;

	public MentorLake.Gtk.GtkMovementStep Object;

	public int P0;

	public IntPtr UserData;
}

public class RowActivatedSignal
{

	public MentorLake.Gtk.GtkListBoxHandle Self;
/// <summary>
/// <para>
/// the activated row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkListBoxRowHandle Row;

	public IntPtr UserData;
}

public class RowSelectedSignal
{

	public MentorLake.Gtk.GtkListBoxHandle Self;
/// <summary>
/// <para>
/// the selected row
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkListBoxRowHandle Row;

	public IntPtr UserData;
}

public class SelectAllSignal
{

	public MentorLake.Gtk.GtkListBoxHandle Self;

	public IntPtr UserData;
}

public class SelectedRowsChangedSignal
{

	public MentorLake.Gtk.GtkListBoxHandle Self;

	public IntPtr UserData;
}

public class ToggleCursorRowSignal
{

	public MentorLake.Gtk.GtkListBoxHandle Self;

	public IntPtr UserData;
}

public class UnselectAllSignal
{

	public MentorLake.Gtk.GtkListBoxHandle Self;

	public IntPtr UserData;
}
}

public static class GtkListBoxHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="p0">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, MentorLake.Gtk.GtkMovementStep @object, int p0, IntPtr user_data);


/// <summary>
/// <para>
/// The ::row-activated signal is emitted when a row has been activated by the user.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="row">
/// the activated row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, IntPtr user_data);


/// <summary>
/// <para>
/// The ::row-selected signal is emitted when a new row is selected, or
/// (with a %NULL @row) when the selection is cleared.
/// </para>
/// <para>
/// When the @box is using #GTK_SELECTION_MULTIPLE, this signal will not
/// give you the full picture of selection changes, and you should use
/// the #GtkListBox::selected-rows-changed signal instead.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="row">
/// the selected row
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, IntPtr user_data);


/// <summary>
/// <para>
/// The ::select-all signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted to select all children of the box, if the selection
/// mode permits it.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-a.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::selected-rows-changed signal is emitted when the
/// set of selected rows changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selected_rows_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::unselect-all signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted to unselect all children of the box, if the selection
/// mode permits it.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-Shift-a.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle self, IntPtr user_data);

}


public static class GtkListBoxHandleExtensions
{
/// <summary>
/// <para>
/// Binds @model to @box.
/// </para>
/// <para>
/// If @box was already bound to a model, that previous binding is
/// destroyed.
/// </para>
/// <para>
/// The contents of @box are cleared and then filled with widgets that
/// represent items from @model. @box is updated whenever @model changes.
/// If @model is %NULL, @box is left empty.
/// </para>
/// <para>
/// It is undefined to add or remove widgets directly (for example, with
/// gtk_list_box_insert() or gtk_container_add()) while @box is bound to a
/// model.
/// </para>
/// <para>
/// Note that using a model is incompatible with the filtering and sorting
/// functionality in GtkListBox. When using a model, filtering and sorting
/// should be implemented by the model.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="model">
/// the #GListModel to be bound to @box
/// </param>
/// <param name="create_widget_func">
/// a function that creates widgets for items
///   or %NULL in case you also passed %NULL as @model
/// </param>
/// <param name="user_data">
/// user data passed to @create_widget_func
/// </param>
/// <param name="user_data_free_func">
/// function for freeing @user_data
/// </param>

	public static T BindModel<T>(this T box, MentorLake.Gio.GListModelHandle model, MentorLake.Gtk.GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

/// <summary>
/// <para>
/// This is a helper function for implementing DnD onto a #GtkListBox.
/// The passed in @row will be highlighted via gtk_drag_highlight(),
/// and any previously highlighted row will be unhighlighted.
/// </para>
/// <para>
/// The row will also be unhighlighted when the widget gets
/// a drag leave event.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="row">
/// a #GtkListBoxRow
/// </param>

	public static T DragHighlightRow<T>(this T box, MentorLake.Gtk.GtkListBoxRowHandle row) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_drag_highlight_row(box, row);
		return box;
	}

/// <summary>
/// <para>
/// If a row has previously been highlighted via gtk_list_box_drag_highlight_row()
/// it will have the highlight removed.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>

	public static T DragUnhighlightRow<T>(this T box) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_drag_unhighlight_row(box);
		return box;
	}

/// <summary>
/// <para>
/// Returns whether rows activate on single clicks.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <return>
/// %TRUE if rows are activated on single click, %FALSE otherwise
/// </return>

	public static bool GetActivateOnSingleClick(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		return GtkListBoxHandleExterns.gtk_list_box_get_activate_on_single_click(box);
	}

/// <summary>
/// <para>
/// Gets the adjustment (if any) that the widget uses to
/// for vertical scrolling.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <return>
/// the adjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetAdjustment(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		return GtkListBoxHandleExterns.gtk_list_box_get_adjustment(box);
	}

/// <summary>
/// <para>
/// Gets the n-th child in the list (not counting headers).
/// If @_index is negative or larger than the number of items in the
/// list, %NULL is returned.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="index_">
/// the index of the row
/// </param>
/// <return>
/// the child #GtkWidget or %NULL
/// </return>

	public static MentorLake.Gtk.GtkListBoxRowHandle GetRowAtIndex(this MentorLake.Gtk.GtkListBoxHandle box, int index_)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		return GtkListBoxHandleExterns.gtk_list_box_get_row_at_index(box, index_);
	}

/// <summary>
/// <para>
/// Gets the row at the @y position.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="y">
/// position
/// </param>
/// <return>
/// the row or %NULL
///   in case no row exists for the given y coordinate.
/// </return>

	public static MentorLake.Gtk.GtkListBoxRowHandle GetRowAtY(this MentorLake.Gtk.GtkListBoxHandle box, int y)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		return GtkListBoxHandleExterns.gtk_list_box_get_row_at_y(box, y);
	}

/// <summary>
/// <para>
/// Gets the selected row.
/// </para>
/// <para>
/// Note that the box may allow multiple selection, in which
/// case you should use gtk_list_box_selected_foreach() to
/// find all selected rows.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <return>
/// the selected row
/// </return>

	public static MentorLake.Gtk.GtkListBoxRowHandle GetSelectedRow(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		return GtkListBoxHandleExterns.gtk_list_box_get_selected_row(box);
	}

/// <summary>
/// <para>
/// Creates a list of all selected children.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <return>
/// 
///     A #GList containing the #GtkWidget for each selected child.
///     Free with g_list_free() when done.
/// </return>

	public static MentorLake.GLib.GListHandle GetSelectedRows(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		return GtkListBoxHandleExterns.gtk_list_box_get_selected_rows(box);
	}

/// <summary>
/// <para>
/// Gets the selection mode of the listbox.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <return>
/// a #GtkSelectionMode
/// </return>

	public static MentorLake.Gtk.GtkSelectionMode GetSelectionMode(this MentorLake.Gtk.GtkListBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		return GtkListBoxHandleExterns.gtk_list_box_get_selection_mode(box);
	}

/// <summary>
/// <para>
/// Insert the @child into the @box at @position. If a sort function is
/// set, the widget will actually be inserted at the calculated position and
/// this function has the same effect of gtk_container_add().
/// </para>
/// <para>
/// If @position is -1, or larger than the total number of items in the
/// @box, then the @child will be appended to the end.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="child">
/// the #GtkWidget to add
/// </param>
/// <param name="position">
/// the position to insert @child in
/// </param>

	public static T Insert<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_insert(box, child, position);
		return box;
	}

/// <summary>
/// <para>
/// Update the filtering for all rows. Call this when result
/// of the filter function on the @box is changed due
/// to an external factor. For instance, this would be used
/// if the filter function just looked for a specific search
/// string and the entry with the search string has changed.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>

	public static T InvalidateFilter<T>(this T box) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_invalidate_filter(box);
		return box;
	}

/// <summary>
/// <para>
/// Update the separators for all rows. Call this when result
/// of the header function on the @box is changed due
/// to an external factor.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>

	public static T InvalidateHeaders<T>(this T box) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_invalidate_headers(box);
		return box;
	}

/// <summary>
/// <para>
/// Update the sorting for all rows. Call this when result
/// of the sort function on the @box is changed due
/// to an external factor.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>

	public static T InvalidateSort<T>(this T box) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_invalidate_sort(box);
		return box;
	}

/// <summary>
/// <para>
/// Prepend a widget to the list. If a sort function is set, the widget will
/// actually be inserted at the calculated position and this function has the
/// same effect of gtk_container_add().
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="child">
/// the #GtkWidget to add
/// </param>

	public static T Prepend<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_prepend(box, child);
		return box;
	}

/// <summary>
/// <para>
/// Select all children of @box, if the selection mode allows it.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>

	public static T SelectAll<T>(this T box) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_select_all(box);
		return box;
	}

/// <summary>
/// <para>
/// Make @row the currently selected row.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="row">
/// The row to select or %NULL
/// </param>

	public static T SelectRow<T>(this T box, MentorLake.Gtk.GtkListBoxRowHandle row) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_select_row(box, row);
		return box;
	}

/// <summary>
/// <para>
/// Calls a function for each selected child.
/// </para>
/// <para>
/// Note that the selection cannot be modified from within this function.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="func">
/// the function to call for each selected child
/// </param>
/// <param name="data">
/// user data to pass to the function
/// </param>

	public static T SelectedForeach<T>(this T box, MentorLake.Gtk.GtkListBoxForeachFunc func, IntPtr data) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_selected_foreach(box, func, data);
		return box;
	}

/// <summary>
/// <para>
/// If @single is %TRUE, rows will be activated when you click on them,
/// otherwise you need to double-click.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="single">
/// a boolean
/// </param>

	public static T SetActivateOnSingleClick<T>(this T box, bool single) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_set_activate_on_single_click(box, single);
		return box;
	}

/// <summary>
/// <para>
/// Sets the adjustment (if any) that the widget uses to
/// for vertical scrolling. For instance, this is used
/// to get the page size for PageUp/Down key handling.
/// </para>
/// <para>
/// In the normal case when the @box is packed inside
/// a #GtkScrolledWindow the adjustment from that will
/// be picked up automatically, so there is no need
/// to manually do that.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="adjustment">
/// the adjustment, or %NULL
/// </param>

	public static T SetAdjustment<T>(this T box, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_set_adjustment(box, adjustment);
		return box;
	}

/// <summary>
/// <para>
/// By setting a filter function on the @box one can decide dynamically which
/// of the rows to show. For instance, to implement a search function on a list that
/// filters the original list to only show the matching rows.
/// </para>
/// <para>
/// The @filter_func will be called for each row after the call, and it will
/// continue to be called each time a row changes (via gtk_list_box_row_changed()) or
/// when gtk_list_box_invalidate_filter() is called.
/// </para>
/// <para>
/// Note that using a filter function is incompatible with using a model
/// (see gtk_list_box_bind_model()).
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="filter_func">
/// callback that lets you filter which rows to show
/// </param>
/// <param name="user_data">
/// user data passed to @filter_func
/// </param>
/// <param name="destroy">
/// destroy notifier for @user_data
/// </param>

	public static T SetFilterFunc<T>(this T box, MentorLake.Gtk.GtkListBoxFilterFunc filter_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

/// <summary>
/// <para>
/// By setting a header function on the @box one can dynamically add headers
/// in front of rows, depending on the contents of the row and its position in the list.
/// For instance, one could use it to add headers in front of the first item of a
/// new kind, in a list sorted by the kind.
/// </para>
/// <para>
/// The @update_header can look at the current header widget using gtk_list_box_row_get_header()
/// and either update the state of the widget as needed, or set a new one using
/// gtk_list_box_row_set_header(). If no header is needed, set the header to %NULL.
/// </para>
/// <para>
/// Note that you may get many calls @update_header to this for a particular row when e.g.
/// changing things that don’t affect the header. In this case it is important for performance
/// to not blindly replace an existing header with an identical one.
/// </para>
/// <para>
/// The @update_header function will be called for each row after the call, and it will
/// continue to be called each time a row changes (via gtk_list_box_row_changed()) and when
/// the row before changes (either by gtk_list_box_row_changed() on the previous row, or when
/// the previous row becomes a different row). It is also called for all rows when
/// gtk_list_box_invalidate_headers() is called.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="update_header">
/// callback that lets you add row headers
/// </param>
/// <param name="user_data">
/// user data passed to @update_header
/// </param>
/// <param name="destroy">
/// destroy notifier for @user_data
/// </param>

	public static T SetHeaderFunc<T>(this T box, MentorLake.Gtk.GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_set_header_func(box, update_header, user_data, destroy);
		return box;
	}

/// <summary>
/// <para>
/// Sets the placeholder widget that is shown in the list when
/// it doesn&apos;t display any visible children.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="placeholder">
/// a #GtkWidget or %NULL
/// </param>

	public static T SetPlaceholder<T>(this T box, MentorLake.Gtk.GtkWidgetHandle placeholder) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_set_placeholder(box, placeholder);
		return box;
	}

/// <summary>
/// <para>
/// Sets how selection works in the listbox.
/// See #GtkSelectionMode for details.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="mode">
/// The #GtkSelectionMode
/// </param>

	public static T SetSelectionMode<T>(this T box, MentorLake.Gtk.GtkSelectionMode mode) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_set_selection_mode(box, mode);
		return box;
	}

/// <summary>
/// <para>
/// By setting a sort function on the @box one can dynamically reorder the rows
/// of the list, based on the contents of the rows.
/// </para>
/// <para>
/// The @sort_func will be called for each row after the call, and will continue to
/// be called each time a row changes (via gtk_list_box_row_changed()) and when
/// gtk_list_box_invalidate_sort() is called.
/// </para>
/// <para>
/// Note that using a sort function is incompatible with using a model
/// (see gtk_list_box_bind_model()).
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="sort_func">
/// the sort function
/// </param>
/// <param name="user_data">
/// user data passed to @sort_func
/// </param>
/// <param name="destroy">
/// destroy notifier for @user_data
/// </param>

	public static T SetSortFunc<T>(this T box, MentorLake.Gtk.GtkListBoxSortFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

/// <summary>
/// <para>
/// Unselect all children of @box, if the selection mode allows it.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>

	public static T UnselectAll<T>(this T box) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_unselect_all(box);
		return box;
	}

/// <summary>
/// <para>
/// Unselects a single row of @box, if the selection mode allows it.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="row">
/// the row to unselected
/// </param>

	public static T UnselectRow<T>(this T box, MentorLake.Gtk.GtkListBoxRowHandle row) where T : GtkListBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkListBoxHandle)");
		GtkListBoxHandleExterns.gtk_list_box_unselect_row(box, row);
		return box;
	}

}

internal class GtkListBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkListBoxHandle gtk_list_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_bind_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle model, MentorLake.Gtk.GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_drag_highlight_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_drag_unhighlight_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_box_get_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_list_box_get_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))]
	internal static extern MentorLake.Gtk.GtkListBoxRowHandle gtk_list_box_get_row_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, int index_);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))]
	internal static extern MentorLake.Gtk.GtkListBoxRowHandle gtk_list_box_get_row_at_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, int y);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))]
	internal static extern MentorLake.Gtk.GtkListBoxRowHandle gtk_list_box_get_selected_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_list_box_get_selected_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSelectionMode gtk_list_box_get_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_invalidate_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_invalidate_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_invalidate_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_select_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_selected_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkListBoxForeachFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, bool single);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_filter_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkListBoxFilterFunc filter_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_header_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_placeholder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle placeholder);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkSelectionMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_set_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, MentorLake.Gtk.GtkListBoxSortFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_unselect_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

}
