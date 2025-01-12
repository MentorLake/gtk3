namespace MentorLake.Gtk3.Gtk3;

public interface GtkTreeDragDestHandle
{
}

internal class GtkTreeDragDestHandleImpl : BaseSafeHandle, GtkTreeDragDestHandle
{
}

public static class GtkTreeDragDestHandleExtensions
{
	public static bool DragDataReceived(this GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest, GtkSelectionDataHandle selection_data)
	{
		return GtkTreeDragDestExterns.gtk_tree_drag_dest_drag_data_received(drag_dest, dest, selection_data);
	}

	public static bool RowDropPossible(this GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest_path, GtkSelectionDataHandle selection_data)
	{
		return GtkTreeDragDestExterns.gtk_tree_drag_dest_row_drop_possible(drag_dest, dest_path, selection_data);
	}

}

internal class GtkTreeDragDestExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_drag_dest_drag_data_received(GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest, GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_drag_dest_row_drop_possible(GtkTreeDragDestHandle drag_dest, GtkTreePathHandle dest_path, GtkSelectionDataHandle selection_data);

}
