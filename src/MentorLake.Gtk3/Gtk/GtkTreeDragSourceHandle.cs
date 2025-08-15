namespace MentorLake.Gtk;


public interface GtkTreeDragSourceHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkTreeDragSourceHandleImpl : BaseSafeHandle, GtkTreeDragSourceHandle
{
}

public static class GtkTreeDragSourceHandleExtensions
{
/// <summary>
/// <para>
/// Asks the #GtkTreeDragSource to delete the row at @path, because
/// it was moved somewhere else via drag-and-drop. Returns %FALSE
/// if the deletion fails because @path no longer exists, or for
/// some model-specific reason. Should robustly handle a @path no
/// longer found in the model!
/// </para>
/// </summary>

/// <param name="drag_source">
/// a #GtkTreeDragSource
/// </param>
/// <param name="path">
/// row that was being dragged
/// </param>
/// <return>
/// %TRUE if the row was successfully deleted
/// </return>

	public static bool DragDataDelete(this MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (drag_source.IsInvalid) throw new Exception("Invalid handle (GtkTreeDragSourceHandle)");
		return GtkTreeDragSourceHandleExterns.gtk_tree_drag_source_drag_data_delete(drag_source, path);
	}

/// <summary>
/// <para>
/// Asks the #GtkTreeDragSource to fill in @selection_data with a
/// representation of the row at @path. @selection_data-&amp;gt;target gives
/// the required type of the data.  Should robustly handle a @path no
/// longer found in the model!
/// </para>
/// </summary>

/// <param name="drag_source">
/// a #GtkTreeDragSource
/// </param>
/// <param name="path">
/// row that was dragged
/// </param>
/// <param name="selection_data">
/// a #GtkSelectionData to fill with data
///                  from the dragged row
/// </param>
/// <return>
/// %TRUE if data of the required type was provided
/// </return>

	public static bool DragDataGet(this MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (drag_source.IsInvalid) throw new Exception("Invalid handle (GtkTreeDragSourceHandle)");
		return GtkTreeDragSourceHandleExterns.gtk_tree_drag_source_drag_data_get(drag_source, path, selection_data);
	}

/// <summary>
/// <para>
/// Asks the #GtkTreeDragSource whether a particular row can be used as
/// the source of a DND operation. If the source doesn’t implement
/// this interface, the row is assumed draggable.
/// </para>
/// </summary>

/// <param name="drag_source">
/// a #GtkTreeDragSource
/// </param>
/// <param name="path">
/// row on which user is initiating a drag
/// </param>
/// <return>
/// %TRUE if the row can be dragged
/// </return>

	public static bool RowDraggable(this MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (drag_source.IsInvalid) throw new Exception("Invalid handle (GtkTreeDragSourceHandle)");
		return GtkTreeDragSourceHandleExterns.gtk_tree_drag_source_row_draggable(drag_source, path);
	}

}

internal class GtkTreeDragSourceHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_drag_source_drag_data_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeDragSourceHandleImpl>))] MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_drag_source_drag_data_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeDragSourceHandleImpl>))] MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_drag_source_row_draggable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeDragSourceHandleImpl>))] MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

}
