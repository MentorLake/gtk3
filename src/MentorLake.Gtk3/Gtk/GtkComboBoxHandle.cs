namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkComboBox is a widget that allows the user to choose from a list of
/// valid choices. The GtkComboBox displays the selected choice. When
/// activated, the GtkComboBox displays a popup which allows the user to
/// make a new choice. The style in which the selected value is displayed,
/// and the style of the popup is determined by the current theme. It may
/// be similar to a Windows-style combo box.
/// </para>
/// <para>
/// The GtkComboBox uses the model-view pattern; the list of valid choices
/// is specified in the form of a tree model, and the display of the choices
/// can be adapted to the data in the model by using cell renderers, as you
/// would in a tree view. This is possible since GtkComboBox implements the
/// #GtkCellLayout interface. The tree model holding the valid choices is
/// not restricted to a flat list, it can be a real tree, and the popup will
/// reflect the tree structure.
/// </para>
/// <para>
/// To allow the user to enter values not in the model, the “has-entry”
/// property allows the GtkComboBox to contain a #GtkEntry. This entry
/// can be accessed by calling gtk_bin_get_child() on the combo box.
/// </para>
/// <para>
/// For a simple list of textual choices, the model-view API of GtkComboBox
/// can be a bit overwhelming. In this case, #GtkComboBoxText offers a
/// simple alternative. Both GtkComboBox and #GtkComboBoxText can contain
/// an entry.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// combobox
/// combobox
/// ├── box.linked
/// │   ╰── button.combo
/// │       ╰── box
/// │           ├── cellview
/// │           ╰── arrow
/// ╰── window.popup
/// </code>
/// <para>
/// A normal combobox contains a box with the .linked class, a button
/// with the .combo class and inside those buttons, there are a cellview and
/// an arrow.
/// </para>
/// <code>
/// combobox
/// combobox
/// ├── box.linked
/// │   ├── entry.combo
/// │   ╰── button.combo
/// │       ╰── box
/// │           ╰── arrow
/// ╰── window.popup
/// </code>
/// <para>
/// A GtkComboBox with an entry has a single CSS node with name combobox. It
/// contains a box with the .linked class. That box contains an entry and a
/// button, both with the .combo class added.
/// The button also contains another node with name arrow.
/// </para>
/// </summary>

public class GtkComboBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
/// <summary>
/// <para>
/// Creates a new empty #GtkComboBox.
/// </para>
/// </summary>

/// <return>
/// A new #GtkComboBox.
/// </return>

	public static MentorLake.Gtk.GtkComboBoxHandle New()
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new();
	}

/// <summary>
/// <para>
/// Creates a new empty #GtkComboBox using @area to layout cells.
/// </para>
/// </summary>

/// <param name="area">
/// the #GtkCellArea to use to layout cell renderers
/// </param>
/// <return>
/// A new #GtkComboBox.
/// </return>

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithArea(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_area(area);
	}

/// <summary>
/// <para>
/// Creates a new empty #GtkComboBox with an entry.
/// </para>
/// <para>
/// The new combo box will use @area to layout cells.
/// </para>
/// </summary>

/// <param name="area">
/// the #GtkCellArea to use to layout cell renderers
/// </param>
/// <return>
/// A new #GtkComboBox.
/// </return>

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithAreaAndEntry(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_area_and_entry(area);
	}

/// <summary>
/// <para>
/// Creates a new empty #GtkComboBox with an entry.
/// </para>
/// </summary>

/// <return>
/// A new #GtkComboBox.
/// </return>

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithEntry()
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_entry();
	}

/// <summary>
/// <para>
/// Creates a new #GtkComboBox with the model initialized to @model.
/// </para>
/// </summary>

/// <param name="model">
/// A #GtkTreeModel.
/// </param>
/// <return>
/// A new #GtkComboBox.
/// </return>

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_model(model);
	}

/// <summary>
/// <para>
/// Creates a new empty #GtkComboBox with an entry
/// and with the model initialized to @model.
/// </para>
/// </summary>

/// <param name="model">
/// A #GtkTreeModel
/// </param>
/// <return>
/// A new #GtkComboBox
/// </return>

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithModelAndEntry(MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_model_and_entry(model);
	}

}
public static class GtkComboBoxHandleSignalExtensions
{
/// <summary>
/// <para>
/// The changed signal is emitted when the active
/// item is changed. The can be due to the user selecting
/// a different item from the list, or due to a
/// call to gtk_combo_box_set_active_iter().
/// It will also be emitted while typing into the entry of a combo box
/// with an entry.
/// </para>
/// </summary>

	public static IObservable<GtkComboBoxHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.ChangedSignal()
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
/// <summary>
/// <para>
/// For combo boxes that are created with an entry (See GtkComboBox:has-entry).
/// </para>
/// <para>
/// A signal which allows you to change how the text displayed in a combo box&apos;s
/// entry is displayed.
/// </para>
/// <para>
/// Connect a signal handler which returns an allocated string representing
/// @path. That string will then be used to set the text in the combo box&apos;s entry.
/// The default signal handler uses the text from the GtkComboBox::entry-text-column
/// model column.
/// </para>
/// <para>
/// Here&apos;s an example signal handler which fetches data from the model and
/// displays it in the entry.
/// <code>
/// static gchar*
/// static gchar*
/// format_entry_text_callback (GtkComboBox *combo,
///                             const gchar *path,
///                             gpointer     user_data)
/// {
///   GtkTreeIter iter;
///   GtkTreeModel model;
///   gdouble      value;
/// 
///   model = gtk_combo_box_get_model (combo);
/// 
///   gtk_tree_model_get_iter_from_string (model, &amp;iter, path);
///   gtk_tree_model_get (model, &amp;iter,
///                       THE_DOUBLE_VALUE_COLUMN, &amp;value,
///                       -1);
/// 
///   return g_strdup_printf (&quot;%g&quot;, value);
/// }
/// </code>
/// </para>
/// </summary>

	public static IObservable<GtkComboBoxHandleSignalStructs.FormatEntryTextSignal> Signal_FormatEntryText(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.FormatEntryTextSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.format_entry_text handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  string path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.FormatEntryTextSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "format-entry-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::move-active signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to move the active selection.
/// </para>
/// </summary>

	public static IObservable<GtkComboBoxHandleSignalStructs.MoveActiveSignal> Signal_MoveActive(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.MoveActiveSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.move_active handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  MentorLake.Gtk.GtkScrollType scroll_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.MoveActiveSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-active", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::popdown signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to popdown the combo box list.
/// </para>
/// <para>
/// The default bindings for this signal are Alt+Up and Escape.
/// </para>
/// </summary>

	public static IObservable<GtkComboBoxHandleSignalStructs.PopdownSignal> Signal_Popdown(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.PopdownSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.popdown handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.PopdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::popup signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to popup the combo box list.
/// </para>
/// <para>
/// The default binding for this signal is Alt+Down.
/// </para>
/// </summary>

	public static IObservable<GtkComboBoxHandleSignalStructs.PopupSignal> Signal_Popup(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.PopupSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.popup handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.PopupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is a sign for the cell renderer to update its
/// value from the @cell_editable.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing, e.g.
/// #GtkEntry emits this signal when the user presses Enter. Typical things to
/// do in a handler for ::editing-done are to capture the edited value,
/// disconnect the @cell_editable from signals on the #GtkCellRenderer, etc.
/// </para>
/// <para>
/// gtk_cell_editable_editing_done() is a convenience method
/// for emitting #GtkCellEditable::editing-done.
/// </para>
/// </summary>

	public static IObservable<GtkComboBoxHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.EditingDoneSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "editing-done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is meant to indicate that the cell is finished
/// editing, and the @cell_editable widget is being removed and may
/// subsequently be destroyed.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing. It must
/// be emitted after the #GtkCellEditable::editing-done signal,
/// to give the cell renderer a chance to update the cell&apos;s value
/// before the widget is removed.
/// </para>
/// <para>
/// gtk_cell_editable_remove_widget() is a convenience method
/// for emitting #GtkCellEditable::remove-widget.
/// </para>
/// </summary>

	public static IObservable<GtkComboBoxHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.RemoveWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkComboBoxHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gtk.GtkComboBoxHandle Self;

	public IntPtr UserData;
}

public class FormatEntryTextSignal
{

	public MentorLake.Gtk.GtkComboBoxHandle Self;
/// <summary>
/// <para>
/// the GtkTreePath string from the combo box&apos;s current model to format text for
/// </para>
/// </summary>

	public string Path;

	public IntPtr UserData;
/// <summary>
/// <para>
/// a newly allocated string representing @path
/// for the current GtkComboBox model.
/// </para>
/// </summary>

	public string ReturnValue;
}

public class MoveActiveSignal
{

	public MentorLake.Gtk.GtkComboBoxHandle Self;
/// <summary>
/// <para>
/// a #GtkScrollType
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkScrollType ScrollType;

	public IntPtr UserData;
}

public class PopdownSignal
{

	public MentorLake.Gtk.GtkComboBoxHandle Self;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class PopupSignal
{

	public MentorLake.Gtk.GtkComboBoxHandle Self;

	public IntPtr UserData;
}

public class EditingDoneSignal
{

	public MentorLake.Gtk.GtkCellEditableHandle Self;

	public IntPtr UserData;
}

public class RemoveWidgetSignal
{

	public MentorLake.Gtk.GtkCellEditableHandle Self;

	public IntPtr UserData;
}
}

public static class GtkComboBoxHandleSignalDelegates
{

/// <summary>
/// <para>
/// The changed signal is emitted when the active
/// item is changed. The can be due to the user selecting
/// a different item from the list, or due to a
/// call to gtk_combo_box_set_active_iter().
/// It will also be emitted while typing into the entry of a combo box
/// with an entry.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// For combo boxes that are created with an entry (See GtkComboBox:has-entry).
/// </para>
/// <para>
/// A signal which allows you to change how the text displayed in a combo box&apos;s
/// entry is displayed.
/// </para>
/// <para>
/// Connect a signal handler which returns an allocated string representing
/// @path. That string will then be used to set the text in the combo box&apos;s entry.
/// The default signal handler uses the text from the GtkComboBox::entry-text-column
/// model column.
/// </para>
/// <para>
/// Here&apos;s an example signal handler which fetches data from the model and
/// displays it in the entry.
/// <code>
/// static gchar*
/// static gchar*
/// format_entry_text_callback (GtkComboBox *combo,
///                             const gchar *path,
///                             gpointer     user_data)
/// {
///   GtkTreeIter iter;
///   GtkTreeModel model;
///   gdouble      value;
/// 
///   model = gtk_combo_box_get_model (combo);
/// 
///   gtk_tree_model_get_iter_from_string (model, &amp;iter, path);
///   gtk_tree_model_get (model, &amp;iter,
///                       THE_DOUBLE_VALUE_COLUMN, &amp;value,
///                       -1);
/// 
///   return g_strdup_printf (&quot;%g&quot;, value);
/// }
/// </code>
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// the GtkTreePath string from the combo box&apos;s current model to format text for
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// a newly allocated string representing @path
/// for the current GtkComboBox model.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string format_entry_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, string path, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-active signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to move the active selection.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="scroll_type">
/// a #GtkScrollType
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, MentorLake.Gtk.GtkScrollType scroll_type, IntPtr user_data);


/// <summary>
/// <para>
/// The ::popdown signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to popdown the combo box list.
/// </para>
/// <para>
/// The default bindings for this signal are Alt+Up and Escape.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::popup signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to popup the combo box list.
/// </para>
/// <para>
/// The default binding for this signal is Alt+Down.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is a sign for the cell renderer to update its
/// value from the @cell_editable.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing, e.g.
/// #GtkEntry emits this signal when the user presses Enter. Typical things to
/// do in a handler for ::editing-done are to capture the edited value,
/// disconnect the @cell_editable from signals on the #GtkCellRenderer, etc.
/// </para>
/// <para>
/// gtk_cell_editable_editing_done() is a convenience method
/// for emitting #GtkCellEditable::editing-done.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is meant to indicate that the cell is finished
/// editing, and the @cell_editable widget is being removed and may
/// subsequently be destroyed.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing. It must
/// be emitted after the #GtkCellEditable::editing-done signal,
/// to give the cell renderer a chance to update the cell&apos;s value
/// before the widget is removed.
/// </para>
/// <para>
/// gtk_cell_editable_remove_widget() is a convenience method
/// for emitting #GtkCellEditable::remove-widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);

}


public static class GtkComboBoxHandleExtensions
{
/// <summary>
/// <para>
/// Returns the index of the currently active item, or -1 if there’s no
/// active item. If the model is a non-flat treemodel, and the active item
/// is not an immediate child of the root of the tree, this function returns
/// `gtk_tree_path_get_indices (path)[0]`, where
/// `path` is the #GtkTreePath of the active item.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <return>
/// An integer which is the index of the currently active item,
///     or -1 if there’s no active item.
/// </return>

	public static int GetActive(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_active(combo_box);
	}

/// <summary>
/// <para>
/// Returns the ID of the active row of @combo_box.  This value is taken
/// from the active row and the column specified by the #GtkComboBox:id-column
/// property of @combo_box (see gtk_combo_box_set_id_column()).
/// </para>
/// <para>
/// The returned value is an interned string which means that you can
/// compare the pointer by value to other interned strings and that you
/// must not free it.
/// </para>
/// <para>
/// If the #GtkComboBox:id-column property of @combo_box is not set, or if
/// no row is active, or if the active row has a %NULL ID value, then %NULL
/// is returned.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <return>
/// the ID of the active row, or %NULL
/// </return>

	public static string GetActiveId(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_active_id(combo_box);
	}

/// <summary>
/// <para>
/// Sets @iter to point to the currently active item, if any item is active.
/// Otherwise, @iter is left unchanged.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="iter">
/// A #GtkTreeIter
/// </param>
/// <return>
/// %TRUE if @iter was set, %FALSE otherwise
/// </return>

	public static bool GetActiveIter(this MentorLake.Gtk.GtkComboBoxHandle combo_box, out MentorLake.Gtk.GtkTreeIter iter)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_active_iter(combo_box, out iter);
	}

/// <summary>
/// <para>
/// Gets the current value of the :add-tearoffs property.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <return>
/// the current value of the :add-tearoffs property.
/// </return>

	public static bool GetAddTearoffs(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_add_tearoffs(combo_box);
	}

/// <summary>
/// <para>
/// Returns whether the combo box sets the dropdown button
/// sensitive or not when there are no items in the model.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <return>
/// %GTK_SENSITIVITY_ON if the dropdown button
///    is sensitive when the model is empty, %GTK_SENSITIVITY_OFF
///    if the button is always insensitive or
///    %GTK_SENSITIVITY_AUTO if it is only sensitive as long as
///    the model has one item to be selected.
/// </return>

	public static MentorLake.Gtk.GtkSensitivityType GetButtonSensitivity(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_button_sensitivity(combo_box);
	}

/// <summary>
/// <para>
/// Returns the column with column span information for @combo_box.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <return>
/// the column span column.
/// </return>

	public static int GetColumnSpanColumn(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_column_span_column(combo_box);
	}

/// <summary>
/// <para>
/// Returns the column which @combo_box is using to get the strings
/// from to display in the internal entry.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox.
/// </param>
/// <return>
/// A column in the data source model of @combo_box.
/// </return>

	public static int GetEntryTextColumn(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_entry_text_column(combo_box);
	}

/// <summary>
/// <para>
/// Returns whether the combo box grabs focus when it is clicked
/// with the mouse. See gtk_combo_box_set_focus_on_click().
/// </para>
/// </summary>

/// <param name="combo">
/// a #GtkComboBox
/// </param>
/// <return>
/// %TRUE if the combo box grabs focus when it is
///     clicked with the mouse.
/// </return>

	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkComboBoxHandle combo)
	{
		if (combo.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_focus_on_click(combo);
	}

/// <summary>
/// <para>
/// Returns whether the combo box has an entry.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <return>
/// whether there is an entry in @combo_box.
/// </return>

	public static bool GetHasEntry(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_has_entry(combo_box);
	}

/// <summary>
/// <para>
/// Returns the column which @combo_box is using to get string IDs
/// for values from.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <return>
/// A column in the data source model of @combo_box.
/// </return>

	public static int GetIdColumn(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_id_column(combo_box);
	}

/// <summary>
/// <para>
/// Returns the #GtkTreeModel which is acting as data source for @combo_box.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <return>
/// A #GtkTreeModel which was passed
///     during construction.
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_model(combo_box);
	}

/// <summary>
/// <para>
/// Gets the accessible object corresponding to the combo box’s popup.
/// </para>
/// <para>
/// This function is mostly intended for use by accessibility technologies;
/// applications should have little use for it.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <return>
/// the accessible object corresponding
///     to the combo box’s popup.
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetPopupAccessible(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_popup_accessible(combo_box);
	}

/// <summary>
/// <para>
/// Gets whether the popup uses a fixed width matching
/// the allocated width of the combo box.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <return>
/// %TRUE if the popup uses a fixed width
/// </return>

	public static bool GetPopupFixedWidth(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_popup_fixed_width(combo_box);
	}

/// <summary>
/// <para>
/// Returns the current row separator function.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <return>
/// the current row separator function.
/// </return>

	public static MentorLake.Gtk.GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_row_separator_func(combo_box);
	}

/// <summary>
/// <para>
/// Returns the column with row span information for @combo_box.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <return>
/// the row span column.
/// </return>

	public static int GetRowSpanColumn(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_row_span_column(combo_box);
	}

/// <summary>
/// <para>
/// Gets the current title of the menu in tearoff mode. See
/// gtk_combo_box_set_add_tearoffs().
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <return>
/// the menu’s title in tearoff mode. This is an internal copy of the
/// string which must not be freed.
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_title(combo_box);
	}

/// <summary>
/// <para>
/// Returns the wrap width which is used to determine the number of columns
/// for the popup menu. If the wrap width is larger than 1, the combo box
/// is in table mode.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <return>
/// the wrap width.
/// </return>

	public static int GetWrapWidth(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_wrap_width(combo_box);
	}

/// <summary>
/// <para>
/// Hides the menu or dropdown list of @combo_box.
/// </para>
/// <para>
/// This function is mostly intended for use by accessibility technologies;
/// applications should have little use for it.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>

	public static T Popdown<T>(this T combo_box) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_popdown(combo_box);
		return combo_box;
	}

/// <summary>
/// <para>
/// Pops up the menu or dropdown list of @combo_box.
/// </para>
/// <para>
/// This function is mostly intended for use by accessibility technologies;
/// applications should have little use for it.
/// </para>
/// <para>
/// Before calling this, @combo_box must be mapped, or nothing will happen.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>

	public static T Popup<T>(this T combo_box) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_popup(combo_box);
		return combo_box;
	}

/// <summary>
/// <para>
/// Pops up the menu or dropdown list of @combo_box, the popup window
/// will be grabbed so only @device and its associated pointer/keyboard
/// are the only #GdkDevices able to send events to it.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>

	public static T PopupForDevice<T>(this T combo_box, MentorLake.Gdk.GdkDeviceHandle device) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_popup_for_device(combo_box, device);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets the active item of @combo_box to be the item at @index.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="index_">
/// An index in the model passed during construction, or -1 to have
/// no active item
/// </param>

	public static T SetActive<T>(this T combo_box, int index_) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_active(combo_box, index_);
		return combo_box;
	}

/// <summary>
/// <para>
/// Changes the active row of @combo_box to the one that has an ID equal to
/// @active_id, or unsets the active row if @active_id is %NULL.  Rows having
/// a %NULL ID string cannot be made active by this function.
/// </para>
/// <para>
/// If the #GtkComboBox:id-column property of @combo_box is unset or if no
/// row has the given ID then the function does nothing and returns %FALSE.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <param name="active_id">
/// the ID of the row to select, or %NULL
/// </param>
/// <return>
/// %TRUE if a row with a matching ID was found.  If a %NULL
///          @active_id was given to unset the active row, the function
///          always returns %TRUE.
/// </return>

	public static bool SetActiveId(this MentorLake.Gtk.GtkComboBoxHandle combo_box, string active_id)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_set_active_id(combo_box, active_id);
	}

/// <summary>
/// <para>
/// Sets the current active item to be the one referenced by @iter, or
/// unsets the active item if @iter is %NULL.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="iter">
/// The #GtkTreeIter, or %NULL
/// </param>

	public static T SetActiveIter<T>(this T combo_box, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_active_iter(combo_box, iter);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets whether the popup menu should have a tearoff
/// menu item.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <param name="add_tearoffs">
/// %TRUE to add tearoff menu items
/// </param>

	public static T SetAddTearoffs<T>(this T combo_box, bool add_tearoffs) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_add_tearoffs(combo_box, add_tearoffs);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets whether the dropdown button of the combo box should be
/// always sensitive (%GTK_SENSITIVITY_ON), never sensitive (%GTK_SENSITIVITY_OFF)
/// or only if there is at least one item to display (%GTK_SENSITIVITY_AUTO).
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <param name="sensitivity">
/// specify the sensitivity of the dropdown button
/// </param>

	public static T SetButtonSensitivity<T>(this T combo_box, MentorLake.Gtk.GtkSensitivityType sensitivity) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_button_sensitivity(combo_box, sensitivity);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets the column with column span information for @combo_box to be
/// @column_span. The column span column contains integers which indicate
/// how many columns an item should span.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="column_span">
/// A column in the model passed during construction
/// </param>

	public static T SetColumnSpanColumn<T>(this T combo_box, int column_span) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_column_span_column(combo_box, column_span);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets the model column which @combo_box should use to get strings from
/// to be @text_column. The column @text_column in the model of @combo_box
/// must be of type %G_TYPE_STRING.
/// </para>
/// <para>
/// This is only relevant if @combo_box has been created with
/// #GtkComboBox:has-entry as %TRUE.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="text_column">
/// A column in @model to get the strings from for
///     the internal entry
/// </param>

	public static T SetEntryTextColumn<T>(this T combo_box, int text_column) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_entry_text_column(combo_box, text_column);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets whether the combo box will grab focus when it is clicked with
/// the mouse. Making mouse clicks not grab focus is useful in places
/// like toolbars where you don’t want the keyboard focus removed from
/// the main area of the application.
/// </para>
/// </summary>

/// <param name="combo">
/// a #GtkComboBox
/// </param>
/// <param name="focus_on_click">
/// whether the combo box grabs focus when clicked
///    with the mouse
/// </param>

	public static T SetFocusOnClick<T>(this T combo, bool focus_on_click) where T : GtkComboBoxHandle
	{
		if (combo.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_focus_on_click(combo, focus_on_click);
		return combo;
	}

/// <summary>
/// <para>
/// Sets the model column which @combo_box should use to get string IDs
/// for values from. The column @id_column in the model of @combo_box
/// must be of type %G_TYPE_STRING.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="id_column">
/// A column in @model to get string IDs for values from
/// </param>

	public static T SetIdColumn<T>(this T combo_box, int id_column) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_id_column(combo_box, id_column);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets the model used by @combo_box to be @model. Will unset a previously set
/// model (if applicable). If model is %NULL, then it will unset the model.
/// </para>
/// <para>
/// Note that this function does not clear the cell renderers, you have to
/// call gtk_cell_layout_clear() yourself if you need to set up different
/// cell renderers for the new model.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="model">
/// A #GtkTreeModel
/// </param>

	public static T SetModel<T>(this T combo_box, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_model(combo_box, model);
		return combo_box;
	}

/// <summary>
/// <para>
/// Specifies whether the popup’s width should be a fixed width
/// matching the allocated width of the combo box.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <param name="@fixed">
/// whether to use a fixed popup width
/// </param>

	public static T SetPopupFixedWidth<T>(this T combo_box, bool @fixed) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_popup_fixed_width(combo_box, @fixed);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets the row separator function, which is used to determine
/// whether a row should be drawn as a separator. If the row separator
/// function is %NULL, no separators are drawn. This is the default value.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
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

	public static T SetRowSeparatorFunc<T>(this T combo_box, MentorLake.Gtk.GtkTreeViewRowSeparatorFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_row_separator_func(combo_box, func, data, destroy);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets the column with row span information for @combo_box to be @row_span.
/// The row span column contains integers which indicate how many rows
/// an item should span.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox.
/// </param>
/// <param name="row_span">
/// A column in the model passed during construction.
/// </param>

	public static T SetRowSpanColumn<T>(this T combo_box, int row_span) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_row_span_column(combo_box, row_span);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets the menu’s title in tearoff mode.
/// </para>
/// </summary>

/// <param name="combo_box">
/// a #GtkComboBox
/// </param>
/// <param name="title">
/// a title for the menu in tearoff mode
/// </param>

	public static T SetTitle<T>(this T combo_box, string title) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_title(combo_box, title);
		return combo_box;
	}

/// <summary>
/// <para>
/// Sets the wrap width of @combo_box to be @width. The wrap width is basically
/// the preferred number of columns when you want the popup to be layed out
/// in a table.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="width">
/// Preferred number of columns
/// </param>

	public static T SetWrapWidth<T>(this T combo_box, int width) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_wrap_width(combo_box, width);
		return combo_box;
	}

}

internal class GtkComboBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_area_and_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_entry();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_model_and_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_get_active_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_active_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_add_tearoffs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSensitivityType gtk_combo_box_get_button_sensitivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_column_span_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_entry_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_has_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_id_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_combo_box_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle gtk_combo_box_get_popup_accessible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_popup_fixed_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewRowSeparatorFunc gtk_combo_box_get_row_separator_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_row_span_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_wrap_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_popup_for_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_set_active_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, string active_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_active_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_add_tearoffs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, bool add_tearoffs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_button_sensitivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, MentorLake.Gtk.GtkSensitivityType sensitivity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_column_span_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int column_span);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_entry_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int text_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo, bool focus_on_click);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_id_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int id_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_popup_fixed_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, bool @fixed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_row_separator_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, MentorLake.Gtk.GtkTreeViewRowSeparatorFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_row_span_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int row_span);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_wrap_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int width);

}
