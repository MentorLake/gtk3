namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkCellRendererCombo renders text in a cell like #GtkCellRendererText from
/// which it is derived. But while #GtkCellRendererText offers a simple entry to
/// edit the text, #GtkCellRendererCombo offers a #GtkComboBox
/// widget to edit the text. The values to display in the combo box are taken from
/// the tree model specified in the #GtkCellRendererCombo:model property.
/// </para>
/// <para>
/// The combo cell renderer takes care of adding a text cell renderer to the combo
/// box and sets it to display the column specified by its
/// #GtkCellRendererCombo:text-column property. Further properties of the combo box
/// can be set in a handler for the #GtkCellRenderer::editing-started signal.
/// </para>
/// <para>
/// The #GtkCellRendererCombo cell renderer was added in GTK+ 2.6.
/// </para>
/// </summary>

public class GtkCellRendererComboHandle : GtkCellRendererTextHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellRendererCombo.
/// Adjust how text is drawn using object properties.
/// Object properties can be set globally (with g_object_set()).
/// Also, with #GtkTreeViewColumn, you can bind a property to a value
/// in a #GtkTreeModel. For example, you can bind the “text” property
/// on the cell renderer to a string value in the model, thus rendering
/// a different string in each row of the #GtkTreeView.
/// </para>
/// </summary>

/// <return>
/// the new cell renderer
/// </return>

	public static MentorLake.Gtk.GtkCellRendererComboHandle New()
	{
		return GtkCellRendererComboHandleExterns.gtk_cell_renderer_combo_new();
	}

}
public static class GtkCellRendererComboHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted each time after the user selected an item in
/// the combo box, either by using the mouse or the arrow keys.  Contrary
/// to GtkComboBox, GtkCellRendererCombo::changed is not emitted for
/// changes made to a selected item in the entry.  The argument @new_iter
/// corresponds to the newly selected item in the combo box and it is relative
/// to the GtkTreeModel set via the model property on GtkCellRendererCombo.
/// </para>
/// <para>
/// Note that as soon as you change the model displayed in the tree view,
/// the tree view will immediately cease the editing operating.  This
/// means that you most probably want to refrain from changing the model
/// until the combo cell renderer emits the edited or editing_canceled signal.
/// </para>
/// </summary>

	public static IObservable<GtkCellRendererComboHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkCellRendererComboHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererComboHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkCellRendererComboHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkCellRendererComboHandle self,  string path_string,  MentorLake.Gtk.GtkTreeIterHandle new_iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererComboHandleSignalStructs.ChangedSignal()
				{
					Self = self, PathString = path_string, NewIter = new_iter, UserData = user_data
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

public static class GtkCellRendererComboHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gtk.GtkCellRendererComboHandle Self;
/// <summary>
/// <para>
/// a string of the path identifying the edited cell
///               (relative to the tree view model)
/// </para>
/// </summary>

	public string PathString;
/// <summary>
/// <para>
/// the new iter selected in the combo box
///            (relative to the combo box model)
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle NewIter;

	public IntPtr UserData;
}
}

public static class GtkCellRendererComboHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted each time after the user selected an item in
/// the combo box, either by using the mouse or the arrow keys.  Contrary
/// to GtkComboBox, GtkCellRendererCombo::changed is not emitted for
/// changes made to a selected item in the entry.  The argument @new_iter
/// corresponds to the newly selected item in the combo box and it is relative
/// to the GtkTreeModel set via the model property on GtkCellRendererCombo.
/// </para>
/// <para>
/// Note that as soon as you change the model displayed in the tree view,
/// the tree view will immediately cease the editing operating.  This
/// means that you most probably want to refrain from changing the model
/// until the combo cell renderer emits the edited or editing_canceled signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path_string">
/// a string of the path identifying the edited cell
///               (relative to the tree view model)
/// </param>
/// <param name="new_iter">
/// the new iter selected in the combo box
///            (relative to the combo box model)
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererComboHandle>))] MentorLake.Gtk.GtkCellRendererComboHandle self, string path_string, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle new_iter, IntPtr user_data);

}


public static class GtkCellRendererComboHandleExtensions
{
}

internal class GtkCellRendererComboHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererComboHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererComboHandle gtk_cell_renderer_combo_new();

}
