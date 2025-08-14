namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkCellEditable interface must be implemented for widgets to be usable
/// to edit the contents of a #GtkTreeView cell. It provides a way to specify how
/// temporary widgets should be configured for editing, get the new value, etc.
/// </para>
/// </summary>

public interface GtkCellEditableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkCellEditableHandleImpl : BaseSafeHandle, GtkCellEditableHandle
{
}

public static class GtkCellEditableHandleExtensions
{
/// <summary>
/// <para>
/// Emits the #GtkCellEditable::editing-done signal.
/// </para>
/// </summary>

/// <param name="cell_editable">
/// A #GtkCellEditable
/// </param>

	public static T EditingDone<T>(this T cell_editable) where T : GtkCellEditableHandle
	{
		if (cell_editable.IsInvalid) throw new Exception("Invalid handle (GtkCellEditableHandle)");
		GtkCellEditableHandleExterns.gtk_cell_editable_editing_done(cell_editable);
		return cell_editable;
	}

/// <summary>
/// <para>
/// Emits the #GtkCellEditable::remove-widget signal.
/// </para>
/// </summary>

/// <param name="cell_editable">
/// A #GtkCellEditable
/// </param>

	public static T RemoveWidget<T>(this T cell_editable) where T : GtkCellEditableHandle
	{
		if (cell_editable.IsInvalid) throw new Exception("Invalid handle (GtkCellEditableHandle)");
		GtkCellEditableHandleExterns.gtk_cell_editable_remove_widget(cell_editable);
		return cell_editable;
	}

/// <summary>
/// <para>
/// Begins editing on a @cell_editable.
/// </para>
/// <para>
/// The #GtkCellRenderer for the cell creates and returns a #GtkCellEditable from
/// gtk_cell_renderer_start_editing(), configured for the #GtkCellRenderer type.
/// </para>
/// <para>
/// gtk_cell_editable_start_editing() can then set up @cell_editable suitably for
/// editing a cell, e.g. making the Esc key emit #GtkCellEditable::editing-done.
/// </para>
/// <para>
/// Note that the @cell_editable is created on-demand for the current edit; its
/// lifetime is temporary and does not persist across other edits and/or cells.
/// </para>
/// </summary>

/// <param name="cell_editable">
/// A #GtkCellEditable
/// </param>
/// <param name="@event">
/// The #GdkEvent that began the editing process, or
///   %NULL if editing was initiated programmatically
/// </param>

	public static T StartEditing<T>(this T cell_editable, MentorLake.Gdk.GdkEventHandle @event) where T : GtkCellEditableHandle
	{
		if (cell_editable.IsInvalid) throw new Exception("Invalid handle (GtkCellEditableHandle)");
		GtkCellEditableHandleExterns.gtk_cell_editable_start_editing(cell_editable, @event);
		return cell_editable;
	}

}

internal class GtkCellEditableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_editable_editing_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle cell_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_editable_remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle cell_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_editable_start_editing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle cell_editable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

}
