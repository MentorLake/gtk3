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
	public static bool DragDataDelete(this MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (drag_source.IsInvalid || drag_source.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeDragSourceHandle)");
		return GtkTreeDragSourceHandleExterns.gtk_tree_drag_source_drag_data_delete(drag_source, path);
	}

	public static bool DragDataGet(this MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (drag_source.IsInvalid || drag_source.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeDragSourceHandle)");
		return GtkTreeDragSourceHandleExterns.gtk_tree_drag_source_drag_data_get(drag_source, path, selection_data);
	}

	public static bool RowDraggable(this MentorLake.Gtk.GtkTreeDragSourceHandle drag_source, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (drag_source.IsInvalid || drag_source.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeDragSourceHandle)");
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
