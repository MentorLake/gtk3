namespace MentorLake.Gtk3.Gtk3;

public interface GtkTreeDragSourceHandle
{
}

internal class GtkTreeDragSourceHandleImpl : BaseSafeHandle, GtkTreeDragSourceHandle
{
}

public static class GtkTreeDragSourceHandleExtensions
{
	public static bool DragDataDelete(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path)
	{
		return GtkTreeDragSourceExterns.gtk_tree_drag_source_drag_data_delete(drag_source, path);
	}

	public static bool DragDataGet(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path, GtkSelectionDataHandle selection_data)
	{
		return GtkTreeDragSourceExterns.gtk_tree_drag_source_drag_data_get(drag_source, path, selection_data);
	}

	public static bool RowDraggable(this GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path)
	{
		return GtkTreeDragSourceExterns.gtk_tree_drag_source_row_draggable(drag_source, path);
	}

}

internal class GtkTreeDragSourceExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_drag_source_drag_data_delete(GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_drag_source_drag_data_get(GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path, GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_drag_source_row_draggable(GtkTreeDragSourceHandle drag_source, GtkTreePathHandle path);

}
