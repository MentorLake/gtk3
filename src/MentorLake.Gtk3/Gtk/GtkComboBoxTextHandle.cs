namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkComboBoxText is a simple variant of #GtkComboBox that hides
/// the model-view complexity for simple text-only use cases.
/// </para>
/// <para>
/// To create a GtkComboBoxText, use gtk_combo_box_text_new() or
/// gtk_combo_box_text_new_with_entry().
/// </para>
/// <para>
/// You can add items to a GtkComboBoxText with
/// gtk_combo_box_text_append_text(), gtk_combo_box_text_insert_text()
/// or gtk_combo_box_text_prepend_text() and remove options with
/// gtk_combo_box_text_remove().
/// </para>
/// <para>
/// If the GtkComboBoxText contains an entry (via the “has-entry” property),
/// its contents can be retrieved using gtk_combo_box_text_get_active_text().
/// The entry itself can be accessed by calling gtk_bin_get_child() on the
/// combo box.
/// </para>
/// <para>
/// You should not call gtk_combo_box_set_model() or attempt to pack more cells
/// into this combo box via its GtkCellLayout interface.
/// </para>
/// <para>
/// # GtkComboBoxText as GtkBuildable
/// </para>
/// <para>
/// The GtkComboBoxText implementation of the GtkBuildable interface supports
/// adding items directly using the `&amp;lt;items&amp;gt;` element and specifying `&amp;lt;item&amp;gt;`
/// elements for each item. Each `&amp;lt;item&amp;gt;` element can specify the “id”
/// corresponding to the appended text and also supports the regular
/// translation attributes “translatable”, “context” and “comments”.
/// </para>
/// <para>
/// Here is a UI definition fragment specifying GtkComboBoxText items:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkComboBoxText&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkComboBoxText&quot;&amp;gt;
///   &amp;lt;items&amp;gt;
///     &amp;lt;item translatable=&quot;yes&quot; id=&quot;factory&quot;&amp;gt;Factory&amp;lt;/item&amp;gt;
///     &amp;lt;item translatable=&quot;yes&quot; id=&quot;home&quot;&amp;gt;Home&amp;lt;/item&amp;gt;
///     &amp;lt;item translatable=&quot;yes&quot; id=&quot;subway&quot;&amp;gt;Subway&amp;lt;/item&amp;gt;
///   &amp;lt;/items&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// combobox
/// combobox
/// ╰── box.linked
///     ├── entry.combo
///     ├── button.combo
///     ╰── window.popup
/// </code>
/// <para>
/// GtkComboBoxText has a single CSS node with name combobox. It adds
/// the style class .combo to the main CSS nodes of its entry and button
/// children, and the .linked class to the node of its internal box.
/// </para>
/// </summary>

public class GtkComboBoxTextHandle : GtkComboBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkComboBoxText, which is a #GtkComboBox just displaying
/// strings.
/// </para>
/// </summary>

/// <return>
/// A new #GtkComboBoxText
/// </return>

	public static MentorLake.Gtk.GtkComboBoxTextHandle New()
	{
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkComboBoxText, which is a #GtkComboBox just displaying
/// strings. The combo box created by this function has an entry.
/// </para>
/// </summary>

/// <return>
/// a new #GtkComboBoxText
/// </return>

	public static MentorLake.Gtk.GtkComboBoxTextHandle NewWithEntry()
	{
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_new_with_entry();
	}

}
public static class GtkComboBoxTextHandleSignalExtensions
{
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

	public static IObservable<GtkComboBoxTextHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkComboBoxTextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxTextHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkComboBoxTextHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxTextHandleSignalStructs.EditingDoneSignal()
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

	public static IObservable<GtkComboBoxTextHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkComboBoxTextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxTextHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkComboBoxTextHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxTextHandleSignalStructs.RemoveWidgetSignal()
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

public static class GtkComboBoxTextHandleSignalStructs
{

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

public static class GtkComboBoxTextHandleSignalDelegates
{

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


public static class GtkComboBoxTextHandleExtensions
{
/// <summary>
/// <para>
/// Appends @text to the list of strings stored in @combo_box.
/// If @id is non-%NULL then it is used as the ID of the row.
/// </para>
/// <para>
/// This is the same as calling gtk_combo_box_text_insert() with a
/// position of -1.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBoxText
/// </param>
/// <param name="id">
/// a string ID for this value, or %NULL
/// </param>
/// <param name="text">
/// A string
/// </param>

	public static T Append<T>(this T combo_box, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_append(combo_box, id, text);
		return combo_box;
	}

/// <summary>
/// <para>
/// Appends @text to the list of strings stored in @combo_box.
/// </para>
/// <para>
/// This is the same as calling gtk_combo_box_text_insert_text() with a
/// position of -1.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBoxText
/// </param>
/// <param name="text">
/// A string
/// </param>

	public static T AppendText<T>(this T combo_box, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_append_text(combo_box, text);
		return combo_box;
	}

/// <summary>
/// <para>
/// Returns the currently active string in @combo_box, or %NULL
/// if none is selected. If @combo_box contains an entry, this
/// function will return its contents (which will not necessarily
/// be an item from the list).
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBoxText
/// </param>
/// <return>
/// a newly allocated string containing the
///     currently active text. Must be freed with g_free().
/// </return>

	public static string GetActiveText(this MentorLake.Gtk.GtkComboBoxTextHandle combo_box)
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_get_active_text(combo_box);
	}

/// <summary>
/// <para>
/// Inserts @text at @position in the list of strings stored in @combo_box.
/// If @id is non-%NULL then it is used as the ID of the row.  See
/// #GtkComboBox:id-column.
/// </para>
/// <para>
/// If @position is negative then @text is appended.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBoxText
/// </param>
/// <param name="position">
/// An index to insert @text
/// </param>
/// <param name="id">
/// a string ID for this value, or %NULL
/// </param>
/// <param name="text">
/// A string to display
/// </param>

	public static T Insert<T>(this T combo_box, int position, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_insert(combo_box, position, id, text);
		return combo_box;
	}

/// <summary>
/// <para>
/// Inserts @text at @position in the list of strings stored in @combo_box.
/// </para>
/// <para>
/// If @position is negative then @text is appended.
/// </para>
/// <para>
/// This is the same as calling gtk_combo_box_text_insert() with a %NULL
/// ID string.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBoxText
/// </param>
/// <param name="position">
/// An index to insert @text
/// </param>
/// <param name="text">
/// A string
/// </param>

	public static T InsertText<T>(this T combo_box, int position, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_insert_text(combo_box, position, text);
		return combo_box;
	}

/// <summary>
/// <para>
/// Prepends @text to the list of strings stored in @combo_box.
/// If @id is non-%NULL then it is used as the ID of the row.
/// </para>
/// <para>
/// This is the same as calling gtk_combo_box_text_insert() with a
/// position of 0.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="id">
/// a string ID for this value, or %NULL
/// </param>
/// <param name="text">
/// a string
/// </param>

	public static T Prepend<T>(this T combo_box, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_prepend(combo_box, id, text);
		return combo_box;
	}

/// <summary>
/// <para>
/// Prepends @text to the list of strings stored in @combo_box.
/// </para>
/// <para>
/// This is the same as calling gtk_combo_box_text_insert_text() with a
/// position of 0.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="text">
/// A string
/// </param>

	public static T PrependText<T>(this T combo_box, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_prepend_text(combo_box, text);
		return combo_box;
	}

/// <summary>
/// <para>
/// Removes the string at @position from @combo_box.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBox
/// </param>
/// <param name="position">
/// Index of the item to remove
/// </param>

	public static T Remove<T>(this T combo_box, int position) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_remove(combo_box, position);
		return combo_box;
	}

/// <summary>
/// <para>
/// Removes all the text entries from the combo box.
/// </para>
/// </summary>

/// <param name="combo_box">
/// A #GtkComboBoxText
/// </param>

	public static T RemoveAll<T>(this T combo_box) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid) throw new Exception("Invalid handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_remove_all(combo_box);
		return combo_box;
	}

}

internal class GtkComboBoxTextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))]
	internal static extern MentorLake.Gtk.GtkComboBoxTextHandle gtk_combo_box_text_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))]
	internal static extern MentorLake.Gtk.GtkComboBoxTextHandle gtk_combo_box_text_new_with_entry();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_append_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string text);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_text_get_active_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_prepend_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box);

}
