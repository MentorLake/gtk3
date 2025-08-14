namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkFlowBox positions child widgets in sequence according to its
/// orientation.
/// </para>
/// <para>
/// For instance, with the horizontal orientation, the widgets will be
/// arranged from left to right, starting a new row under the previous
/// row when necessary. Reducing the width in this case will require more
/// rows, so a larger height will be requested.
/// </para>
/// <para>
/// Likewise, with the vertical orientation, the widgets will be arranged
/// from top to bottom, starting a new column to the right when necessary.
/// Reducing the height will require more columns, so a larger width will
/// be requested.
/// </para>
/// <para>
/// The size request of a GtkFlowBox alone may not be what you expect; if you
/// need to be able to shrink it along both axes and dynamically reflow its
/// children, you may have to wrap it in a #GtkScrolledWindow to enable that.
/// </para>
/// <para>
/// The children of a GtkFlowBox can be dynamically sorted and filtered.
/// </para>
/// <para>
/// Although a GtkFlowBox must have only #GtkFlowBoxChild children,
/// you can add any kind of widget to it via gtk_container_add(), and
/// a GtkFlowBoxChild widget will automatically be inserted between
/// the box and the widget.
/// </para>
/// <para>
/// Also see #GtkListBox.
/// </para>
/// <para>
/// GtkFlowBox was added in GTK+ 3.12.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// flowbox
/// ├── flowboxchild
/// │   ╰── <child>
/// ├── flowboxchild
/// │   ╰── <child>
/// ┊
/// ╰── [rubberband]
/// ]|
/// </para>
/// <para>
/// GtkFlowBox uses a single CSS node with name flowbox. GtkFlowBoxChild
/// uses a single CSS node with name flowboxchild.
/// For rubberband selection, a subnode with name rubberband is used.
/// </para>
/// </summary>

public class GtkFlowBoxHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a GtkFlowBox.
/// </para>
/// </summary>

/// <return>
/// a new #GtkFlowBox container
/// </return>

	public static MentorLake.Gtk.GtkFlowBoxHandle New()
	{
		return GtkFlowBoxHandleExterns.gtk_flow_box_new();
	}

}
public static class GtkFlowBoxHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::activate-cursor-child signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates the @box.
/// </para>
/// </summary>

	public static IObservable<GtkFlowBoxHandleSignalStructs.ActivateCursorChildSignal> Signal_ActivateCursorChild(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.ActivateCursorChildSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.activate_cursor_child handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.ActivateCursorChildSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-cursor-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::child-activated signal is emitted when a child has been
/// activated by the user.
/// </para>
/// </summary>

	public static IObservable<GtkFlowBoxHandleSignalStructs.ChildActivatedSignal> Signal_ChildActivated(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.ChildActivatedSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.child_activated handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  MentorLake.Gtk.GtkFlowBoxChildHandle child,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.ChildActivatedSignal()
				{
					Self = self, Child = child, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "child-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The default bindings for this signal come in two variants,
/// the variant with the Shift modifier extends the selection,
/// the variant without the Shift modifer does not.
/// There are too many key combinations to list them all here.
/// - Arrow keys move by individual children
/// - Home/End keys move to the ends of the box
/// - PageUp/PageDown keys move vertically by pages
/// </para>
/// </summary>

	public static IObservable<GtkFlowBoxHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  MentorLake.Gtk.GtkMovementStep step,  int count,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.MoveCursorSignal()
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
/// The ::select-all signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to select all children of the box, if
/// the selection mode permits it.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-a.
/// </para>
/// </summary>

	public static IObservable<GtkFlowBoxHandleSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.SelectAllSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.select_all handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.SelectAllSignal()
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
/// The ::selected-children-changed signal is emitted when the
/// set of selected children changes.
/// </para>
/// <para>
/// Use gtk_flow_box_selected_foreach() or
/// gtk_flow_box_get_selected_children() to obtain the
/// selected children.
/// </para>
/// </summary>

	public static IObservable<GtkFlowBoxHandleSignalStructs.SelectedChildrenChangedSignal> Signal_SelectedChildrenChanged(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.SelectedChildrenChangedSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.selected_children_changed handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.SelectedChildrenChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selected-children-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::toggle-cursor-child signal is a
/// [keybinding signal][GtkBindingSignal]
/// which toggles the selection of the child that has the focus.
/// </para>
/// <para>
/// The default binding for this signal is Ctrl-Space.
/// </para>
/// </summary>

	public static IObservable<GtkFlowBoxHandleSignalStructs.ToggleCursorChildSignal> Signal_ToggleCursorChild(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.ToggleCursorChildSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.toggle_cursor_child handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.ToggleCursorChildSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-cursor-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::unselect-all signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to unselect all children of the box, if
/// the selection mode permits it.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-Shift-a.
/// </para>
/// </summary>

	public static IObservable<GtkFlowBoxHandleSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkFlowBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxHandleSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkFlowBoxHandleSignalDelegates.unselect_all handler = ( MentorLake.Gtk.GtkFlowBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxHandleSignalStructs.UnselectAllSignal()
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

public static class GtkFlowBoxHandleSignalStructs
{

public class ActivateCursorChildSignal
{

	public MentorLake.Gtk.GtkFlowBoxHandle Self;

	public IntPtr UserData;
}

public class ChildActivatedSignal
{

	public MentorLake.Gtk.GtkFlowBoxHandle Self;
/// <summary>
/// <para>
/// the child that is activated
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkFlowBoxChildHandle Child;

	public IntPtr UserData;
}

public class MoveCursorSignal
{

	public MentorLake.Gtk.GtkFlowBoxHandle Self;
/// <summary>
/// <para>
/// the granularity fo the move, as a #GtkMovementStep
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
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
/// %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class SelectAllSignal
{

	public MentorLake.Gtk.GtkFlowBoxHandle Self;

	public IntPtr UserData;
}

public class SelectedChildrenChangedSignal
{

	public MentorLake.Gtk.GtkFlowBoxHandle Self;

	public IntPtr UserData;
}

public class ToggleCursorChildSignal
{

	public MentorLake.Gtk.GtkFlowBoxHandle Self;

	public IntPtr UserData;
}

public class UnselectAllSignal
{

	public MentorLake.Gtk.GtkFlowBoxHandle Self;

	public IntPtr UserData;
}
}

public static class GtkFlowBoxHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::activate-cursor-child signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user activates the @box.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_cursor_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::child-activated signal is emitted when a child has been
/// activated by the user.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="child">
/// the child that is activated
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child, IntPtr user_data);


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
/// The default bindings for this signal come in two variants,
/// the variant with the Shift modifier extends the selection,
/// the variant without the Shift modifer does not.
/// There are too many key combinations to list them all here.
/// - Arrow keys move by individual children
/// - Home/End keys move to the ends of the box
/// - PageUp/PageDown keys move vertically by pages
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="step">
/// the granularity fo the move, as a #GtkMovementStep
/// </param>
/// <param name="count">
/// the number of @step units to move
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
/// %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, MentorLake.Gtk.GtkMovementStep step, int count, IntPtr user_data);


/// <summary>
/// <para>
/// The ::select-all signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to select all children of the box, if
/// the selection mode permits it.
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
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::selected-children-changed signal is emitted when the
/// set of selected children changes.
/// </para>
/// <para>
/// Use gtk_flow_box_selected_foreach() or
/// gtk_flow_box_get_selected_children() to obtain the
/// selected children.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selected_children_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::toggle-cursor-child signal is a
/// [keybinding signal][GtkBindingSignal]
/// which toggles the selection of the child that has the focus.
/// </para>
/// <para>
/// The default binding for this signal is Ctrl-Space.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::unselect-all signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to unselect all children of the box, if
/// the selection mode permits it.
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
public delegate void unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle self, IntPtr user_data);

}


public static class GtkFlowBoxHandleExtensions
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
/// gtk_flow_box_insert() or gtk_container_add()) while @box is bound to a
/// model.
/// </para>
/// <para>
/// Note that using a model is incompatible with the filtering and sorting
/// functionality in GtkFlowBox. When using a model, filtering and sorting
/// should be implemented by the model.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="model">
/// the #GListModel to be bound to @box
/// </param>
/// <param name="create_widget_func">
/// a function that creates widgets for items
/// </param>
/// <param name="user_data">
/// user data passed to @create_widget_func
/// </param>
/// <param name="user_data_free_func">
/// function for freeing @user_data
/// </param>

	public static T BindModel<T>(this T box, MentorLake.Gio.GListModelHandle model, MentorLake.Gtk.GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

/// <summary>
/// <para>
/// Returns whether children activate on single clicks.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <return>
/// %TRUE if children are activated on single click,
///     %FALSE otherwise
/// </return>

	public static bool GetActivateOnSingleClick(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_activate_on_single_click(box);
	}

/// <summary>
/// <para>
/// Gets the nth child in the @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="idx">
/// the position of the child
/// </param>
/// <return>
/// the child widget, which will
///     always be a #GtkFlowBoxChild or %NULL in case no child widget
///     with the given index exists.
/// </return>

	public static MentorLake.Gtk.GtkFlowBoxChildHandle GetChildAtIndex(this MentorLake.Gtk.GtkFlowBoxHandle box, int idx)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_child_at_index(box, idx);
	}

/// <summary>
/// <para>
/// Gets the child in the (@x, @y) position.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="x">
/// the x coordinate of the child
/// </param>
/// <param name="y">
/// the y coordinate of the child
/// </param>
/// <return>
/// the child widget, which will
///     always be a #GtkFlowBoxChild or %NULL in case no child widget
///     exists for the given x and y coordinates.
/// </return>

	public static MentorLake.Gtk.GtkFlowBoxChildHandle GetChildAtPos(this MentorLake.Gtk.GtkFlowBoxHandle box, int x, int y)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_child_at_pos(box, x, y);
	}

/// <summary>
/// <para>
/// Gets the horizontal spacing.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <return>
/// the horizontal spacing
/// </return>

	public static uint GetColumnSpacing(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_column_spacing(box);
	}

/// <summary>
/// <para>
/// Returns whether the box is homogeneous (all children are the
/// same size). See gtk_box_set_homogeneous().
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <return>
/// %TRUE if the box is homogeneous.
/// </return>

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_homogeneous(box);
	}

/// <summary>
/// <para>
/// Gets the maximum number of children per line.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <return>
/// the maximum number of children per line
/// </return>

	public static uint GetMaxChildrenPerLine(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_max_children_per_line(box);
	}

/// <summary>
/// <para>
/// Gets the minimum number of children per line.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <return>
/// the minimum number of children per line
/// </return>

	public static uint GetMinChildrenPerLine(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_min_children_per_line(box);
	}

/// <summary>
/// <para>
/// Gets the vertical spacing.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <return>
/// the vertical spacing
/// </return>

	public static uint GetRowSpacing(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_row_spacing(box);
	}

/// <summary>
/// <para>
/// Creates a list of all selected children.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <return>
/// 
///     A #GList containing the #GtkWidget for each selected child.
///     Free with g_list_free() when done.
/// </return>

	public static MentorLake.GLib.GListHandle GetSelectedChildren(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_selected_children(box);
	}

/// <summary>
/// <para>
/// Gets the selection mode of @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <return>
/// the #GtkSelectionMode
/// </return>

	public static MentorLake.Gtk.GtkSelectionMode GetSelectionMode(this MentorLake.Gtk.GtkFlowBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		return GtkFlowBoxHandleExterns.gtk_flow_box_get_selection_mode(box);
	}

/// <summary>
/// <para>
/// Inserts the @widget into @box at @position.
/// </para>
/// <para>
/// If a sort function is set, the widget will actually be inserted
/// at the calculated position and this function has the same effect
/// as gtk_container_add().
/// </para>
/// <para>
/// If @position is -1, or larger than the total number of children
/// in the @box, then the @widget will be appended to the end.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="widget">
/// the #GtkWidget to add
/// </param>
/// <param name="position">
/// the position to insert @child in
/// </param>

	public static T Insert<T>(this T box, MentorLake.Gtk.GtkWidgetHandle widget, int position) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_insert(box, widget, position);
		return box;
	}

/// <summary>
/// <para>
/// Updates the filtering for all children.
/// </para>
/// <para>
/// Call this function when the result of the filter
/// function on the @box is changed due ot an external
/// factor. For instance, this would be used if the
/// filter function just looked for a specific search
/// term, and the entry with the string has changed.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>

	public static T InvalidateFilter<T>(this T box) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_invalidate_filter(box);
		return box;
	}

/// <summary>
/// <para>
/// Updates the sorting for all children.
/// </para>
/// <para>
/// Call this when the result of the sort function on
/// @box is changed due to an external factor.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>

	public static T InvalidateSort<T>(this T box) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_invalidate_sort(box);
		return box;
	}

/// <summary>
/// <para>
/// Select all children of @box, if the selection
/// mode allows it.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>

	public static T SelectAll<T>(this T box) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_select_all(box);
		return box;
	}

/// <summary>
/// <para>
/// Selects a single child of @box, if the selection
/// mode allows it.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="child">
/// a child of @box
/// </param>

	public static T SelectChild<T>(this T box, MentorLake.Gtk.GtkFlowBoxChildHandle child) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_select_child(box, child);
		return box;
	}

/// <summary>
/// <para>
/// Calls a function for each selected child.
/// </para>
/// <para>
/// Note that the selection cannot be modified from within
/// this function.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="func">
/// the function to call for each selected child
/// </param>
/// <param name="data">
/// user data to pass to the function
/// </param>

	public static T SelectedForeach<T>(this T box, MentorLake.Gtk.GtkFlowBoxForeachFunc func, IntPtr data) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_selected_foreach(box, func, data);
		return box;
	}

/// <summary>
/// <para>
/// If @single is %TRUE, children will be activated when you click
/// on them, otherwise you need to double-click.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="single">
/// %TRUE to emit child-activated on a single click
/// </param>

	public static T SetActivateOnSingleClick<T>(this T box, bool single) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_activate_on_single_click(box, single);
		return box;
	}

/// <summary>
/// <para>
/// Sets the horizontal space to add between children.
/// See the #GtkFlowBox:column-spacing property.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="spacing">
/// the spacing to use
/// </param>

	public static T SetColumnSpacing<T>(this T box, uint spacing) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_column_spacing(box, spacing);
		return box;
	}

/// <summary>
/// <para>
/// By setting a filter function on the @box one can decide dynamically
/// which of the children to show. For instance, to implement a search
/// function that only shows the children matching the search terms.
/// </para>
/// <para>
/// The @filter_func will be called for each child after the call, and
/// it will continue to be called each time a child changes (via
/// gtk_flow_box_child_changed()) or when gtk_flow_box_invalidate_filter()
/// is called.
/// </para>
/// <para>
/// Note that using a filter function is incompatible with using a model
/// (see gtk_flow_box_bind_model()).
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="filter_func">
/// callback that
///     lets you filter which children to show
/// </param>
/// <param name="user_data">
/// user data passed to @filter_func
/// </param>
/// <param name="destroy">
/// destroy notifier for @user_data
/// </param>

	public static T SetFilterFunc<T>(this T box, MentorLake.Gtk.GtkFlowBoxFilterFunc filter_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

/// <summary>
/// <para>
/// Hooks up an adjustment to focus handling in @box.
/// The adjustment is also used for autoscrolling during
/// rubberband selection. See gtk_scrolled_window_get_hadjustment()
/// for a typical way of obtaining the adjustment, and
/// gtk_flow_box_set_vadjustment()for setting the vertical
/// adjustment.
/// </para>
/// <para>
/// The adjustments have to be in pixel units and in the same
/// coordinate system as the allocation for immediate children
/// of the box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="adjustment">
/// an adjustment which should be adjusted
///    when the focus is moved among the descendents of @container
/// </param>

	public static T SetHadjustment<T>(this T box, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_hadjustment(box, adjustment);
		return box;
	}

/// <summary>
/// <para>
/// Sets the #GtkFlowBox:homogeneous property of @box, controlling
/// whether or not all children of @box are given equal space
/// in the box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="homogeneous">
/// %TRUE to create equal allotments,
///   %FALSE for variable allotments
/// </param>

	public static T SetHomogeneous<T>(this T box, bool homogeneous) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_homogeneous(box, homogeneous);
		return box;
	}

/// <summary>
/// <para>
/// Sets the maximum number of children to request and
/// allocate space for in @box’s orientation.
/// </para>
/// <para>
/// Setting the maximum number of children per line
/// limits the overall natural size request to be no more
/// than @n_children children long in the given orientation.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="n_children">
/// the maximum number of children per line
/// </param>

	public static T SetMaxChildrenPerLine<T>(this T box, uint n_children) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_max_children_per_line(box, n_children);
		return box;
	}

/// <summary>
/// <para>
/// Sets the minimum number of children to line up
/// in @box’s orientation before flowing.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="n_children">
/// the minimum number of children per line
/// </param>

	public static T SetMinChildrenPerLine<T>(this T box, uint n_children) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_min_children_per_line(box, n_children);
		return box;
	}

/// <summary>
/// <para>
/// Sets the vertical space to add between children.
/// See the #GtkFlowBox:row-spacing property.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="spacing">
/// the spacing to use
/// </param>

	public static T SetRowSpacing<T>(this T box, uint spacing) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_row_spacing(box, spacing);
		return box;
	}

/// <summary>
/// <para>
/// Sets how selection works in @box.
/// See #GtkSelectionMode for details.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="mode">
/// the new selection mode
/// </param>

	public static T SetSelectionMode<T>(this T box, MentorLake.Gtk.GtkSelectionMode mode) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_selection_mode(box, mode);
		return box;
	}

/// <summary>
/// <para>
/// By setting a sort function on the @box, one can dynamically
/// reorder the children of the box, based on the contents of
/// the children.
/// </para>
/// <para>
/// The @sort_func will be called for each child after the call,
/// and will continue to be called each time a child changes (via
/// gtk_flow_box_child_changed()) and when gtk_flow_box_invalidate_sort()
/// is called.
/// </para>
/// <para>
/// Note that using a sort function is incompatible with using a model
/// (see gtk_flow_box_bind_model()).
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
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

	public static T SetSortFunc<T>(this T box, MentorLake.Gtk.GtkFlowBoxSortFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

/// <summary>
/// <para>
/// Hooks up an adjustment to focus handling in @box.
/// The adjustment is also used for autoscrolling during
/// rubberband selection. See gtk_scrolled_window_get_vadjustment()
/// for a typical way of obtaining the adjustment, and
/// gtk_flow_box_set_hadjustment()for setting the horizontal
/// adjustment.
/// </para>
/// <para>
/// The adjustments have to be in pixel units and in the same
/// coordinate system as the allocation for immediate children
/// of the box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="adjustment">
/// an adjustment which should be adjusted
///    when the focus is moved among the descendents of @container
/// </param>

	public static T SetVadjustment<T>(this T box, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_set_vadjustment(box, adjustment);
		return box;
	}

/// <summary>
/// <para>
/// Unselect all children of @box, if the selection
/// mode allows it.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>

	public static T UnselectAll<T>(this T box) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_unselect_all(box);
		return box;
	}

/// <summary>
/// <para>
/// Unselects a single child of @box, if the selection
/// mode allows it.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="child">
/// a child of @box
/// </param>

	public static T UnselectChild<T>(this T box, MentorLake.Gtk.GtkFlowBoxChildHandle child) where T : GtkFlowBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxHandle)");
		GtkFlowBoxHandleExterns.gtk_flow_box_unselect_child(box, child);
		return box;
	}

}

internal class GtkFlowBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkFlowBoxHandle gtk_flow_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_bind_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle model, MentorLake.Gtk.GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_flow_box_get_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))]
	internal static extern MentorLake.Gtk.GtkFlowBoxChildHandle gtk_flow_box_get_child_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, int idx);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))]
	internal static extern MentorLake.Gtk.GtkFlowBoxChildHandle gtk_flow_box_get_child_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_flow_box_get_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_flow_box_get_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_flow_box_get_max_children_per_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_flow_box_get_min_children_per_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_flow_box_get_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_flow_box_get_selected_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSelectionMode gtk_flow_box_get_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_invalidate_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_invalidate_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_select_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_selected_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, MentorLake.Gtk.GtkFlowBoxForeachFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_activate_on_single_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, bool single);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_column_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, uint spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_filter_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, MentorLake.Gtk.GtkFlowBoxFilterFunc filter_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_max_children_per_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, uint n_children);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_min_children_per_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, uint n_children);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_row_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, uint spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_selection_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, MentorLake.Gtk.GtkSelectionMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, MentorLake.Gtk.GtkFlowBoxSortFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_unselect_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

}
