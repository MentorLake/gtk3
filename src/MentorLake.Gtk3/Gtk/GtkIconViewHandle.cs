namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkIconView provides an alternative view on a #GtkTreeModel.
/// It displays the model as a grid of icons with labels. Like
/// #GtkTreeView, it allows to select one or multiple items
/// (depending on the selection mode, see gtk_icon_view_set_selection_mode()).
/// In addition to selection with the arrow keys, #GtkIconView supports
/// rubberband selection, which is controlled by dragging the pointer.
/// </para>
/// <para>
/// Note that if the tree model is backed by an actual tree store (as
/// opposed to a flat list where the mapping to icons is obvious),
/// #GtkIconView will only display the first level of the tree and
/// ignore the tree’s branches.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// iconview.view
/// ╰── [rubberband]
/// ]|
/// </para>
/// <para>
/// GtkIconView has a single CSS node with name iconview and style class .view.
/// For rubberband selection, a subnode with name rubberband is used.
/// </para>
/// </summary>

public class GtkIconViewHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkScrollableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkIconView widget
/// </para>
/// </summary>

/// <return>
/// A newly created #GtkIconView widget
/// </return>

	public static MentorLake.Gtk.GtkIconViewHandle New()
	{
		return GtkIconViewHandleExterns.gtk_icon_view_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkIconView widget using the
/// specified @area to layout cells inside the icons.
/// </para>
/// </summary>

/// <param name="area">
/// the #GtkCellArea to use to layout cells
/// </param>
/// <return>
/// A newly created #GtkIconView widget
/// </return>

	public static MentorLake.Gtk.GtkIconViewHandle NewWithArea(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkIconViewHandleExterns.gtk_icon_view_new_with_area(area);
	}

/// <summary>
/// <para>
/// Creates a new #GtkIconView widget with the model @model.
/// </para>
/// </summary>

/// <param name="model">
/// The model.
/// </param>
/// <return>
/// A newly created #GtkIconView widget.
/// </return>

	public static MentorLake.Gtk.GtkIconViewHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkIconViewHandleExterns.gtk_icon_view_new_with_model(model);
	}

}
public static class GtkIconViewHandleSignalExtensions
{
/// <summary>
/// <para>
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates the currently
/// focused item.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control activation
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal are Space, Return and Enter.
/// </para>
/// </summary>

	public static IObservable<GtkIconViewHandleSignalStructs.ActivateCursorItemSignal> Signal_ActivateCursorItem(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.ActivateCursorItemSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.activate_cursor_item handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.ActivateCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-cursor-item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::item-activated signal is emitted when the method
/// gtk_icon_view_item_activated() is called, when the user double
/// clicks an item with the "activate-on-single-click" property set
/// to %FALSE, or when the user single clicks an item when the
/// "activate-on-single-click" property set to %TRUE. It is also
/// emitted when a non-editable item is selected and one of the keys:
/// Space, Return or Enter is pressed.
/// </para>
/// </summary>

	public static IObservable<GtkIconViewHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkIconViewHandle self,  MentorLake.Gtk.GtkTreePathHandle path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.ItemActivatedSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "item-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::move-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a cursor movement.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal include
/// - Arrow keys which move by individual steps
/// - Home/End keys which move to the first/last item
/// - PageUp/PageDown which move by "pages"
/// All of these will extend the selection when combined with
/// the Shift modifier.
/// </para>
/// </summary>

	public static IObservable<GtkIconViewHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkIconViewHandle self,  MentorLake.Gtk.GtkMovementStep step,  int count,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, UserData = user_data
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
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user selects all items.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control selection
/// programmatically.
/// </para>
/// <para>
/// The default binding for this signal is Ctrl-a.
/// </para>
/// </summary>

	public static IObservable<GtkIconViewHandleSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.SelectAllSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.select_all handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.SelectAllSignal()
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
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user selects the item that is currently
/// focused.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control selection
/// programmatically.
/// </para>
/// <para>
/// There is no default binding for this signal.
/// </para>
/// </summary>

	public static IObservable<GtkIconViewHandleSignalStructs.SelectCursorItemSignal> Signal_SelectCursorItem(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.SelectCursorItemSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.select_cursor_item handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.SelectCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select-cursor-item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::selection-changed signal is emitted when the selection
/// (i.e. the set of selected items) changes.
/// </para>
/// </summary>

	public static IObservable<GtkIconViewHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user toggles whether the currently
/// focused item is selected or not. The exact effect of this
/// depend on the selection mode.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control selection
/// programmatically.
/// </para>
/// <para>
/// There is no default binding for this signal is Ctrl-Space.
/// </para>
/// </summary>

	public static IObservable<GtkIconViewHandleSignalStructs.ToggleCursorItemSignal> Signal_ToggleCursorItem(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.ToggleCursorItemSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.toggle_cursor_item handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.ToggleCursorItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-cursor-item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user unselects all items.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control selection
/// programmatically.
/// </para>
/// <para>
/// The default binding for this signal is Ctrl-Shift-a.
/// </para>
/// </summary>

	public static IObservable<GtkIconViewHandleSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkIconViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconViewHandleSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkIconViewHandleSignalDelegates.unselect_all handler = ( MentorLake.Gtk.GtkIconViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconViewHandleSignalStructs.UnselectAllSignal()
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

public static class GtkIconViewHandleSignalStructs
{

public class ActivateCursorItemSignal
{

	public MentorLake.Gtk.GtkIconViewHandle Self;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class ItemActivatedSignal
{

	public MentorLake.Gtk.GtkIconViewHandle Self;
/// <summary>
/// <para>
/// the #GtkTreePath for the activated item
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreePathHandle Path;

	public IntPtr UserData;
}

public class MoveCursorSignal
{

	public MentorLake.Gtk.GtkIconViewHandle Self;
/// <summary>
/// <para>
/// the granularity of the move, as a #GtkMovementStep
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkMovementStep Step;
/// <summary>
/// <para>
/// the number of @step units to move
/// </para>
/// </summary>

	public int Count;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class SelectAllSignal
{

	public MentorLake.Gtk.GtkIconViewHandle Self;

	public IntPtr UserData;
}

public class SelectCursorItemSignal
{

	public MentorLake.Gtk.GtkIconViewHandle Self;

	public IntPtr UserData;
}

public class SelectionChangedSignal
{

	public MentorLake.Gtk.GtkIconViewHandle Self;

	public IntPtr UserData;
}

public class ToggleCursorItemSignal
{

	public MentorLake.Gtk.GtkIconViewHandle Self;

	public IntPtr UserData;
}

public class UnselectAllSignal
{

	public MentorLake.Gtk.GtkIconViewHandle Self;

	public IntPtr UserData;
}
}

public static class GtkIconViewHandleSignalDelegates
{

/// <summary>
/// <para>
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates the currently
/// focused item.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control activation
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal are Space, Return and Enter.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::item-activated signal is emitted when the method
/// gtk_icon_view_item_activated() is called, when the user double
/// clicks an item with the "activate-on-single-click" property set
/// to %FALSE, or when the user single clicks an item when the
/// "activate-on-single-click" property set to %TRUE. It is also
/// emitted when a non-editable item is selected and one of the keys:
/// Space, Return or Enter is pressed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// the #GtkTreePath for the activated item
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a cursor movement.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal include
/// - Arrow keys which move by individual steps
/// - Home/End keys which move to the first/last item
/// - PageUp/PageDown which move by "pages"
/// All of these will extend the selection when combined with
/// the Shift modifier.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="step">
/// the granularity of the move, as a #GtkMovementStep
/// </param>
/// <param name="count">
/// the number of @step units to move
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, MentorLake.Gtk.GtkMovementStep step, int count, IntPtr user_data);


/// <summary>
/// <para>
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user selects all items.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control selection
/// programmatically.
/// </para>
/// <para>
/// The default binding for this signal is Ctrl-a.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user selects the item that is currently
/// focused.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control selection
/// programmatically.
/// </para>
/// <para>
/// There is no default binding for this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::selection-changed signal is emitted when the selection
/// (i.e. the set of selected items) changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user toggles whether the currently
/// focused item is selected or not. The exact effect of this
/// depend on the selection mode.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control selection
/// programmatically.
/// </para>
/// <para>
/// There is no default binding for this signal is Ctrl-Space.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// A [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user unselects all items.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control selection
/// programmatically.
/// </para>
/// <para>
/// The default binding for this signal is Ctrl-Shift-a.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle self, IntPtr user_data);

}


public static class GtkIconViewHandleExtensions
{
/// <summary>
/// <para>
/// Converts widget coordinates to coordinates for the bin_window,
/// as expected by e.g. gtk_icon_view_get_path_at_pos().
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
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

	public static T ConvertWidgetToBinWindowCoords<T>(this T icon_view, int wx, int wy, out int bx, out int by) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_convert_widget_to_bin_window_coords(icon_view, wx, wy, out bx, out by);
		return icon_view;
	}

/// <summary>
/// <para>
/// Creates a #cairo_surface_t representation of the item at @path.
/// This image is used for a drag icon.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="path">
/// a #GtkTreePath in @icon_view
/// </param>
/// <return>
/// a newly-allocated surface of the drag icon.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle CreateDragIcon(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_create_drag_icon(icon_view, path);
	}

/// <summary>
/// <para>
/// Turns @icon_view into a drop destination for automatic DND. Calling this
/// method sets #GtkIconView:reorderable to %FALSE.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="targets">
/// the table of targets that the drag will
///           support
/// </param>
/// <param name="n_targets">
/// the number of items in @targets
/// </param>
/// <param name="actions">
/// the bitmask of possible actions for a drag to this
///    widget
/// </param>

	public static T EnableModelDragDest<T>(this T icon_view, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_enable_model_drag_dest(icon_view, targets, n_targets, actions);
		return icon_view;
	}

/// <summary>
/// <para>
/// Turns @icon_view into a drag source for automatic DND. Calling this
/// method sets #GtkIconView:reorderable to %FALSE.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="start_button_mask">
/// Mask of allowed buttons to start drag
/// </param>
/// <param name="targets">
/// the table of targets that the drag will
///           support
/// </param>
/// <param name="n_targets">
/// the number of items in @targets
/// </param>
/// <param name="actions">
/// the bitmask of possible actions for a drag from this
///    widget
/// </param>

	public static T EnableModelDragSource<T>(this T icon_view, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_enable_model_drag_source(icon_view, start_button_mask, targets, n_targets, actions);
		return icon_view;
	}

/// <summary>
/// <para>
/// Gets the setting set by gtk_icon_view_set_activate_on_single_click().
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// %TRUE if item-activated will be emitted on a single click
/// </return>

	public static bool GetActivateOnSingleClick(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_activate_on_single_click(icon_view);
	}

/// <summary>
/// <para>
/// Fills the bounding rectangle in widget coordinates for the cell specified by
/// @path and @cell. If @cell is %NULL the main cell area is used.
/// </para>
/// <para>
/// This function is only valid if @icon_view is realized.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="path">
/// a #GtkTreePath
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer or %NULL
/// </param>
/// <param name="rect">
/// rectangle to fill with cell rect
/// </param>
/// <return>
/// %FALSE if there is no such item, %TRUE otherwise
/// </return>

	public static bool GetCellRect(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkCellRendererHandle cell, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_cell_rect(icon_view, path, cell, out rect);
	}

/// <summary>
/// <para>
/// Returns the value of the ::column-spacing property.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the space between columns
/// </return>

	public static int GetColumnSpacing(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_column_spacing(icon_view);
	}

/// <summary>
/// <para>
/// Returns the value of the ::columns property.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the number of columns, or -1
/// </return>

	public static int GetColumns(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_columns(icon_view);
	}

/// <summary>
/// <para>
/// Fills in @path and @cell with the current cursor path and cell.
/// If the cursor isn’t currently set, then *@path will be %NULL.
/// If no cell currently has focus, then *@cell will be %NULL.
/// </para>
/// <para>
/// The returned #GtkTreePath must be freed with gtk_tree_path_free().
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView
/// </param>
/// <param name="path">
/// Return location for the current
///        cursor path, or %NULL
/// </param>
/// <param name="cell">
/// Return location the current
///        focus cell, or %NULL
/// </param>
/// <return>
/// %TRUE if the cursor is set.
/// </return>

	public static bool GetCursor(this MentorLake.Gtk.GtkIconViewHandle icon_view, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_cursor(icon_view, out path, out cell);
	}

/// <summary>
/// <para>
/// Determines the destination item for a given position.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="drag_x">
/// the position to determine the destination item for
/// </param>
/// <param name="drag_y">
/// the position to determine the destination item for
/// </param>
/// <param name="path">
/// Return location for the path of the item,
///    or %NULL.
/// </param>
/// <param name="pos">
/// Return location for the drop position, or %NULL
/// </param>
/// <return>
/// whether there is an item at the given position.
/// </return>

	public static bool GetDestItemAtPos(this MentorLake.Gtk.GtkIconViewHandle icon_view, int drag_x, int drag_y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkIconViewDropPosition pos)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_dest_item_at_pos(icon_view, drag_x, drag_y, out path, out pos);
	}

/// <summary>
/// <para>
/// Gets information about the item that is highlighted for feedback.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="path">
/// Return location for the path of
///        the highlighted item, or %NULL.
/// </param>
/// <param name="pos">
/// Return location for the drop position, or %NULL
/// </param>

	public static T GetDragDestItem<T>(this T icon_view, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkIconViewDropPosition pos) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_get_drag_dest_item(icon_view, out path, out pos);
		return icon_view;
	}

/// <summary>
/// <para>
/// Finds the path at the point (@x, @y), relative to bin_window coordinates.
/// In contrast to gtk_icon_view_get_path_at_pos(), this function also
/// obtains the cell at the specified position. The returned path should
/// be freed with gtk_tree_path_free().
/// See gtk_icon_view_convert_widget_to_bin_window_coords() for converting
/// widget coordinates to bin_window coordinates.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="x">
/// The x position to be identified
/// </param>
/// <param name="y">
/// The y position to be identified
/// </param>
/// <param name="path">
/// Return location for the path, or %NULL
/// </param>
/// <param name="cell">
/// Return location for the renderer
///   responsible for the cell at (@x, @y), or %NULL
/// </param>
/// <return>
/// %TRUE if an item exists at the specified position
/// </return>

	public static bool GetItemAtPos(this MentorLake.Gtk.GtkIconViewHandle icon_view, int x, int y, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkCellRendererHandle cell)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_at_pos(icon_view, x, y, out path, out cell);
	}

/// <summary>
/// <para>
/// Gets the column in which the item @path is currently
/// displayed. Column numbers start at 0.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="path">
/// the #GtkTreePath of the item
/// </param>
/// <return>
/// The column in which the item is displayed
/// </return>

	public static int GetItemColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_column(icon_view, path);
	}

/// <summary>
/// <para>
/// Returns the value of the ::item-orientation property which determines
/// whether the labels are drawn beside the icons instead of below.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the relative position of texts and icons
/// </return>

	public static MentorLake.Gtk.GtkOrientation GetItemOrientation(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_orientation(icon_view);
	}

/// <summary>
/// <para>
/// Returns the value of the ::item-padding property.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the padding around items
/// </return>

	public static int GetItemPadding(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_padding(icon_view);
	}

/// <summary>
/// <para>
/// Gets the row in which the item @path is currently
/// displayed. Row numbers start at 0.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="path">
/// the #GtkTreePath of the item
/// </param>
/// <return>
/// The row in which the item is displayed
/// </return>

	public static int GetItemRow(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_row(icon_view, path);
	}

/// <summary>
/// <para>
/// Returns the value of the ::item-width property.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the width of a single item, or -1
/// </return>

	public static int GetItemWidth(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_item_width(icon_view);
	}

/// <summary>
/// <para>
/// Returns the value of the ::margin property.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the space at the borders
/// </return>

	public static int GetMargin(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_margin(icon_view);
	}

/// <summary>
/// <para>
/// Returns the column with markup text for @icon_view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <return>
/// the markup column, or -1 if it’s unset.
/// </return>

	public static int GetMarkupColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_markup_column(icon_view);
	}

/// <summary>
/// <para>
/// Returns the model the #GtkIconView is based on.  Returns %NULL if the
/// model is unset.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// A #GtkTreeModel, or %NULL if none is
///     currently being used.
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_model(icon_view);
	}

/// <summary>
/// <para>
/// Finds the path at the point (@x, @y), relative to bin_window coordinates.
/// See gtk_icon_view_get_item_at_pos(), if you are also interested in
/// the cell at the specified position.
/// See gtk_icon_view_convert_widget_to_bin_window_coords() for converting
/// widget coordinates to bin_window coordinates.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="x">
/// The x position to be identified
/// </param>
/// <param name="y">
/// The y position to be identified
/// </param>
/// <return>
/// The #GtkTreePath corresponding
/// to the icon or %NULL if no icon exists at that position.
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle GetPathAtPos(this MentorLake.Gtk.GtkIconViewHandle icon_view, int x, int y)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_path_at_pos(icon_view, x, y);
	}

/// <summary>
/// <para>
/// Returns the column with pixbufs for @icon_view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <return>
/// the pixbuf column, or -1 if it’s unset.
/// </return>

	public static int GetPixbufColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_pixbuf_column(icon_view);
	}

/// <summary>
/// <para>
/// Retrieves whether the user can reorder the list via drag-and-drop.
/// See gtk_icon_view_set_reorderable().
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// %TRUE if the list can be reordered.
/// </return>

	public static bool GetReorderable(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_reorderable(icon_view);
	}

/// <summary>
/// <para>
/// Returns the value of the ::row-spacing property.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the space between rows
/// </return>

	public static int GetRowSpacing(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_row_spacing(icon_view);
	}

/// <summary>
/// <para>
/// Creates a list of paths of all selected items. Additionally, if you are
/// planning on modifying the model after calling this function, you may
/// want to convert the returned list into a list of #GtkTreeRowReferences.
/// To do this, you can use gtk_tree_row_reference_new().
/// </para>
/// <para>
/// To free the return value, use:
/// |[<!-- language="C" -->
/// g_list_free_full (list, (GDestroyNotify) gtk_tree_path_free);
/// ]|
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <return>
/// A #GList containing a #GtkTreePath for each selected row.
/// </return>

	public static MentorLake.GLib.GListHandle GetSelectedItems(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_selected_items(icon_view);
	}

/// <summary>
/// <para>
/// Gets the selection mode of the @icon_view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <return>
/// the current selection mode
/// </return>

	public static MentorLake.Gtk.GtkSelectionMode GetSelectionMode(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_selection_mode(icon_view);
	}

/// <summary>
/// <para>
/// Returns the value of the ::spacing property.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the space between cells
/// </return>

	public static int GetSpacing(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_spacing(icon_view);
	}

/// <summary>
/// <para>
/// Returns the column with text for @icon_view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <return>
/// the text column, or -1 if it’s unset.
/// </return>

	public static int GetTextColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_text_column(icon_view);
	}

/// <summary>
/// <para>
/// Returns the column of @icon_view’s model which is being used for
/// displaying tooltips on @icon_view’s rows.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <return>
/// the index of the tooltip column that is currently being
/// used, or -1 if this is disabled.
/// </return>

	public static int GetTooltipColumn(this MentorLake.Gtk.GtkIconViewHandle icon_view)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_tooltip_column(icon_view);
	}

/// <summary>
/// <para>
/// This function is supposed to be used in a #GtkWidget::query-tooltip
/// signal handler for #GtkIconView.  The @x, @y and @keyboard_tip values
/// which are received in the signal handler, should be passed to this
/// function without modification.
/// </para>
/// <para>
/// The return value indicates whether there is an icon view item at the given
/// coordinates (%TRUE) or not (%FALSE) for mouse tooltips. For keyboard
/// tooltips the item returned will be the cursor item. When %TRUE, then any of
/// @model, @path and @iter which have been provided will be set to point to
/// that row and the corresponding model. @x and @y will always be converted
/// to be relative to @icon_view’s bin_window if @keyboard_tooltip is %FALSE.
/// </para>
/// </summary>

/// <param name="icon_view">
/// an #GtkIconView
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
/// a pointer to receive a
///         #GtkTreeModel or %NULL
/// </param>
/// <param name="path">
/// a pointer to receive a #GtkTreePath or %NULL
/// </param>
/// <param name="iter">
/// a pointer to receive a #GtkTreeIter or %NULL
/// </param>
/// <return>
/// whether or not the given tooltip context points to a item
/// </return>

	public static bool GetTooltipContext(this MentorLake.Gtk.GtkIconViewHandle icon_view, ref int x, ref int y, bool keyboard_tip, out MentorLake.Gtk.GtkTreeModelHandle model, out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeIter iter)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_tooltip_context(icon_view, ref x, ref y, keyboard_tip, out model, out path, out iter);
	}

/// <summary>
/// <para>
/// Sets @start_path and @end_path to be the first and last visible path.
/// Note that there may be invisible paths in between.
/// </para>
/// <para>
/// Both paths should be freed with gtk_tree_path_free() after use.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView
/// </param>
/// <param name="start_path">
/// Return location for start of region,
///              or %NULL
/// </param>
/// <param name="end_path">
/// Return location for end of region, or %NULL
/// </param>
/// <return>
/// %TRUE, if valid paths were placed in @start_path and @end_path
/// </return>

	public static bool GetVisibleRange(this MentorLake.Gtk.GtkIconViewHandle icon_view, out MentorLake.Gtk.GtkTreePathHandle start_path, out MentorLake.Gtk.GtkTreePathHandle end_path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_get_visible_range(icon_view, out start_path, out end_path);
	}

/// <summary>
/// <para>
/// Activates the item determined by @path.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView
/// </param>
/// <param name="path">
/// The #GtkTreePath to be activated
/// </param>

	public static T ItemActivated<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_item_activated(icon_view, path);
		return icon_view;
	}

/// <summary>
/// <para>
/// Returns %TRUE if the icon pointed to by @path is currently
/// selected. If @path does not point to a valid location, %FALSE is returned.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="path">
/// A #GtkTreePath to check selection on.
/// </param>
/// <return>
/// %TRUE if @path is selected.
/// </return>

	public static bool PathIsSelected(this MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		return GtkIconViewHandleExterns.gtk_icon_view_path_is_selected(icon_view, path);
	}

/// <summary>
/// <para>
/// Moves the alignments of @icon_view to the position specified by @path.
/// @row_align determines where the row is placed, and @col_align determines
/// where @column is placed.  Both are expected to be between 0.0 and 1.0.
/// 0.0 means left/top alignment, 1.0 means right/bottom alignment, 0.5 means
/// center.
/// </para>
/// <para>
/// If @use_align is %FALSE, then the alignment arguments are ignored, and the
/// tree does the minimum amount of work to scroll the item onto the screen.
/// This means that the item will be scrolled to the edge closest to its current
/// position.  If the item is currently visible on the screen, nothing is done.
/// </para>
/// <para>
/// This function only works if the model is set, and @path is a valid row on
/// the model. If the model changes before the @icon_view is realized, the
/// centered path will be modified to reflect this change.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="path">
/// The path of the item to move to.
/// </param>
/// <param name="use_align">
/// whether to use alignment arguments, or %FALSE.
/// </param>
/// <param name="row_align">
/// The vertical alignment of the item specified by @path.
/// </param>
/// <param name="col_align">
/// The horizontal alignment of the item specified by @path.
/// </param>

	public static T ScrollToPath<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path, bool use_align, float row_align, float col_align) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_scroll_to_path(icon_view, path, use_align, row_align, col_align);
		return icon_view;
	}

/// <summary>
/// <para>
/// Selects all the icons. @icon_view must has its selection mode set
/// to #GTK_SELECTION_MULTIPLE.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>

	public static T SelectAll<T>(this T icon_view) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_select_all(icon_view);
		return icon_view;
	}

/// <summary>
/// <para>
/// Selects the row at @path.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="path">
/// The #GtkTreePath to be selected.
/// </param>

	public static T SelectPath<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_select_path(icon_view, path);
		return icon_view;
	}

/// <summary>
/// <para>
/// Calls a function for each selected icon. Note that the model or
/// selection cannot be modified from within this function.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="func">
/// The function to call for each selected icon.
/// </param>
/// <param name="data">
/// User data to pass to the function.
/// </param>

	public static T SelectedForeach<T>(this T icon_view, MentorLake.Gtk.GtkIconViewForeachFunc func, IntPtr data) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_selected_foreach(icon_view, func, data);
		return icon_view;
	}

/// <summary>
/// <para>
/// Causes the #GtkIconView::item-activated signal to be emitted on
/// a single click instead of a double click.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="single">
/// %TRUE to emit item-activated on a single click
/// </param>

	public static T SetActivateOnSingleClick<T>(this T icon_view, bool single) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_activate_on_single_click(icon_view, single);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the ::column-spacing property which specifies the space
/// which is inserted between the columns of the icon view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="column_spacing">
/// the column spacing
/// </param>

	public static T SetColumnSpacing<T>(this T icon_view, int column_spacing) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_column_spacing(icon_view, column_spacing);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the ::columns property which determines in how
/// many columns the icons are arranged. If @columns is
/// -1, the number of columns will be chosen automatically
/// to fill the available area.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="columns">
/// the number of columns
/// </param>

	public static T SetColumns<T>(this T icon_view, int columns) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_columns(icon_view, columns);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the current keyboard focus to be at @path, and selects it.  This is
/// useful when you want to focus the user’s attention on a particular item.
/// If @cell is not %NULL, then focus is given to the cell specified by
/// it. Additionally, if @start_editing is %TRUE, then editing should be
/// started in the specified cell.
/// </para>
/// <para>
/// This function is often followed by `gtk_widget_grab_focus
/// (icon_view)` in order to give keyboard focus to the widget.
/// Please note that editing can only happen when the widget is realized.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView
/// </param>
/// <param name="path">
/// A #GtkTreePath
/// </param>
/// <param name="cell">
/// One of the cell renderers of @icon_view, or %NULL
/// </param>
/// <param name="start_editing">
/// %TRUE if the specified cell should start being edited.
/// </param>

	public static T SetCursor<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkCellRendererHandle cell, bool start_editing) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_cursor(icon_view, path, cell, start_editing);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the item that is highlighted for feedback.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="path">
/// The path of the item to highlight, or %NULL.
/// </param>
/// <param name="pos">
/// Specifies where to drop, relative to the item
/// </param>

	public static T SetDragDestItem<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkIconViewDropPosition pos) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_drag_dest_item(icon_view, path, pos);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the ::item-orientation property which determines whether the labels
/// are drawn beside the icons instead of below.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="orientation">
/// the relative position of texts and icons
/// </param>

	public static T SetItemOrientation<T>(this T icon_view, MentorLake.Gtk.GtkOrientation orientation) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_item_orientation(icon_view, orientation);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the #GtkIconView:item-padding property which specifies the padding
/// around each of the icon view’s items.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="item_padding">
/// the item padding
/// </param>

	public static T SetItemPadding<T>(this T icon_view, int item_padding) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_item_padding(icon_view, item_padding);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the ::item-width property which specifies the width
/// to use for each item. If it is set to -1, the icon view will
/// automatically determine a suitable item size.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="item_width">
/// the width for each item
/// </param>

	public static T SetItemWidth<T>(this T icon_view, int item_width) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_item_width(icon_view, item_width);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the ::margin property which specifies the space
/// which is inserted at the top, bottom, left and right
/// of the icon view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="margin">
/// the margin
/// </param>

	public static T SetMargin<T>(this T icon_view, int margin) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_margin(icon_view, margin);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the column with markup information for @icon_view to be
/// @column. The markup column must be of type #G_TYPE_STRING.
/// If the markup column is set to something, it overrides
/// the text column set by gtk_icon_view_set_text_column().
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="column">
/// A column in the currently used model, or -1 to display no text
/// </param>

	public static T SetMarkupColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_markup_column(icon_view, column);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the model for a #GtkIconView.
/// If the @icon_view already has a model set, it will remove
/// it before setting the new model.  If @model is %NULL, then
/// it will unset the old model.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="model">
/// The model.
/// </param>

	public static T SetModel<T>(this T icon_view, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_model(icon_view, model);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the column with pixbufs for @icon_view to be @column. The pixbuf
/// column must be of type #GDK_TYPE_PIXBUF
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="column">
/// A column in the currently used model, or -1 to disable
/// </param>

	public static T SetPixbufColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_pixbuf_column(icon_view, column);
		return icon_view;
	}

/// <summary>
/// <para>
/// This function is a convenience function to allow you to reorder models that
/// support the #GtkTreeDragSourceIface and the #GtkTreeDragDestIface.  Both
/// #GtkTreeStore and #GtkListStore support these.  If @reorderable is %TRUE, then
/// the user can reorder the model by dragging and dropping rows.  The
/// developer can listen to these changes by connecting to the model's
/// row_inserted and row_deleted signals. The reordering is implemented by setting up
/// the icon view as a drag source and destination. Therefore, drag and
/// drop can not be used in a reorderable view for any other purpose.
/// </para>
/// <para>
/// This function does not give you any degree of control over the order -- any
/// reordering is allowed.  If more control is needed, you should probably
/// handle drag and drop manually.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="reorderable">
/// %TRUE, if the list of items can be reordered.
/// </param>

	public static T SetReorderable<T>(this T icon_view, bool reorderable) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_reorderable(icon_view, reorderable);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the ::row-spacing property which specifies the space
/// which is inserted between the rows of the icon view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="row_spacing">
/// the row spacing
/// </param>

	public static T SetRowSpacing<T>(this T icon_view, int row_spacing) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_row_spacing(icon_view, row_spacing);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the selection mode of the @icon_view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="mode">
/// The selection mode
/// </param>

	public static T SetSelectionMode<T>(this T icon_view, MentorLake.Gtk.GtkSelectionMode mode) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_selection_mode(icon_view, mode);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the ::spacing property which specifies the space
/// which is inserted between the cells (i.e. the icon and
/// the text) of an item.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="spacing">
/// the spacing
/// </param>

	public static T SetSpacing<T>(this T icon_view, int spacing) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_spacing(icon_view, spacing);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the column with text for @icon_view to be @column. The text
/// column must be of type #G_TYPE_STRING.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="column">
/// A column in the currently used model, or -1 to display no text
/// </param>

	public static T SetTextColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_text_column(icon_view, column);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the tip area of @tooltip to the area which @cell occupies in
/// the item pointed to by @path. See also gtk_tooltip_set_tip_area().
/// </para>
/// <para>
/// See also gtk_icon_view_set_tooltip_column() for a simpler alternative.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="path">
/// a #GtkTreePath
/// </param>
/// <param name="cell">
/// a #GtkCellRenderer or %NULL
/// </param>

	public static T SetTooltipCell<T>(this T icon_view, MentorLake.Gtk.GtkTooltipHandle tooltip, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkCellRendererHandle cell) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_tooltip_cell(icon_view, tooltip, path, cell);
		return icon_view;
	}

/// <summary>
/// <para>
/// If you only plan to have simple (text-only) tooltips on full items, you
/// can use this function to have #GtkIconView handle these automatically
/// for you. @column should be set to the column in @icon_view’s model
/// containing the tooltip texts, or -1 to disable this feature.
/// </para>
/// <para>
/// When enabled, #GtkWidget:has-tooltip will be set to %TRUE and
/// @icon_view will connect a #GtkWidget::query-tooltip signal handler.
/// </para>
/// <para>
/// Note that the signal handler sets the text with gtk_tooltip_set_markup(),
/// so &, <, etc have to be escaped in the text.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="column">
/// an integer, which is a valid column number for @icon_view’s model
/// </param>

	public static T SetTooltipColumn<T>(this T icon_view, int column) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_tooltip_column(icon_view, column);
		return icon_view;
	}

/// <summary>
/// <para>
/// Sets the tip area of @tooltip to be the area covered by the item at @path.
/// See also gtk_icon_view_set_tooltip_column() for a simpler alternative.
/// See also gtk_tooltip_set_tip_area().
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="tooltip">
/// a #GtkTooltip
/// </param>
/// <param name="path">
/// a #GtkTreePath
/// </param>

	public static T SetTooltipItem<T>(this T icon_view, MentorLake.Gtk.GtkTooltipHandle tooltip, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_set_tooltip_item(icon_view, tooltip, path);
		return icon_view;
	}

/// <summary>
/// <para>
/// Unselects all the icons.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>

	public static T UnselectAll<T>(this T icon_view) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_unselect_all(icon_view);
		return icon_view;
	}

/// <summary>
/// <para>
/// Unselects the row at @path.
/// </para>
/// </summary>

/// <param name="icon_view">
/// A #GtkIconView.
/// </param>
/// <param name="path">
/// The #GtkTreePath to be unselected.
/// </param>

	public static T UnselectPath<T>(this T icon_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_unselect_path(icon_view, path);
		return icon_view;
	}

/// <summary>
/// <para>
/// Undoes the effect of gtk_icon_view_enable_model_drag_dest(). Calling this
/// method sets #GtkIconView:reorderable to %FALSE.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>

	public static T UnsetModelDragDest<T>(this T icon_view) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_unset_model_drag_dest(icon_view);
		return icon_view;
	}

/// <summary>
/// <para>
/// Undoes the effect of gtk_icon_view_enable_model_drag_source(). Calling this
/// method sets #GtkIconView:reorderable to %FALSE.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>

	public static T UnsetModelDragSource<T>(this T icon_view) where T : GtkIconViewHandle
	{
		if (icon_view.IsInvalid) throw new Exception("Invalid handle (GtkIconViewHandle)");
		GtkIconViewHandleExterns.gtk_icon_view_unset_model_drag_source(icon_view);
		return icon_view;
	}

}

internal class GtkIconViewHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))]
	internal static extern MentorLake.Gtk.GtkIconViewHandle gtk_icon_view_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))]
	internal static extern MentorLake.Gtk.GtkIconViewHandle gtk_icon_view_new_with_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))]
	internal static extern MentorLake.Gtk.GtkIconViewHandle gtk_icon_view_new_with_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_convert_widget_to_bin_window_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int wx, int wy, out int bx, out int by);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_icon_view_create_drag_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_enable_model_drag_dest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_enable_model_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_cell_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] out MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_dest_item_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int drag_x, int drag_y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkIconViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_get_drag_dest_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkIconViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_item_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] out MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_item_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_icon_view_get_item_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_item_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_item_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_item_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_markup_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_icon_view_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_icon_view_get_path_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_pixbuf_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_icon_view_get_selected_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSelectionMode gtk_icon_view_get_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_icon_view_get_tooltip_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_tooltip_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, ref int x, ref int y, bool keyboard_tip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] out MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_get_visible_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle start_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle end_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_view_path_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_scroll_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, bool use_align, float row_align, float col_align);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_select_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_selected_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkIconViewForeachFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, bool single);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column_spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int columns);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool start_editing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_drag_dest_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkIconViewDropPosition pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_item_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_item_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int item_padding);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_item_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int item_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_markup_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_pixbuf_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, bool reorderable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int row_spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, MentorLake.Gtk.GtkSelectionMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_tooltip_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_tooltip_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_set_tooltip_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_unselect_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_unset_model_drag_dest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_view_unset_model_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view);

}
