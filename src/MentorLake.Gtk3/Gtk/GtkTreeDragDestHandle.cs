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
	public static bool DragDataReceived(this MentorLake.Gtk.GtkTreeDragDestHandle drag_dest, MentorLake.Gtk.GtkTreePathHandle dest, MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (drag_dest.IsInvalid) throw new Exception("Invalid handle (GtkTreeDragDestHandle)");
		return GtkTreeDragDestHandleExterns.gtk_tree_drag_dest_drag_data_received(drag_dest, dest, selection_data);
	}

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
