namespace MentorLake.Gtk;


public interface GtkTreeDragDestHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkTreeDragDestHandleImpl : BaseSafeHandle, GtkTreeDragDestHandle
{
}

public static class GtkTreeDragDestHandleExtensions
{
/// <summary>
/// <para>
/// Asks the #GtkTreeDragDest to insert a row before the path @dest,
/// deriving the contents of the row from @selection_data. If @dest is
/// outside the tree so that inserting before it is impossible, %FALSE
/// will be returned. Also, %FALSE may be returned if the new row is
/// not created for some model-specific reason.  Should robustly handle
/// a @dest no longer found in the model!
/// </para>
/// </summary>

/// <param name="drag_dest">
/// a #GtkTreeDragDest
/// </param>
/// <param name="dest">
/// row to drop in front of
/// </param>
/// <param name="selection_data">
/// data to drop
/// </param>
/// <return>
/// whether a new row was created before position @dest
/// </return>

	public static bool DragDataReceived(this MentorLake.Gtk.GtkTreeDragDestHandle drag_dest, MentorLake.Gtk.GtkTreePathHandle dest, MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (drag_dest.IsInvalid) throw new Exception("Invalid handle (GtkTreeDragDestHandle)");
		return GtkTreeDragDestHandleExterns.gtk_tree_drag_dest_drag_data_received(drag_dest, dest, selection_data);
	}

/// <summary>
/// <para>
/// Determines whether a drop is possible before the given @dest_path,
/// at the same depth as @dest_path. i.e., can we drop the data in
/// @selection_data at that location. @dest_path does not have to
/// exist; the return value will almost certainly be %FALSE if the
/// parent of @dest_path doesn’t exist, though.
/// </para>
/// </summary>

/// <param name="drag_dest">
/// a #GtkTreeDragDest
/// </param>
/// <param name="dest_path">
/// destination row
/// </param>
/// <param name="selection_data">
/// the data being dragged
/// </param>
/// <return>
/// %TRUE if a drop is possible before @dest_path
/// </return>

	public static bool RowDropPossible(this MentorLake.Gtk.GtkTreeDragDestHandle drag_dest, MentorLake.Gtk.GtkTreePathHandle dest_path, MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (drag_dest.IsInvalid) throw new Exception("Invalid handle (GtkTreeDragDestHandle)");
		return GtkTreeDragDestHandleExterns.gtk_tree_drag_dest_row_drop_possible(drag_dest, dest_path, selection_data);
	}

}

internal class GtkTreeDragDestHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_drag_dest_drag_data_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeDragDestHandleImpl>))] MentorLake.Gtk.GtkTreeDragDestHandle drag_dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_drag_dest_row_drop_possible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeDragDestHandleImpl>))] MentorLake.Gtk.GtkTreeDragDestHandle drag_dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle dest_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

}
