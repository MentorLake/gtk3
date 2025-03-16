namespace MentorLake.Gtk;

public interface GtkCellEditableHandle
{
}

internal class GtkCellEditableHandleImpl : BaseSafeHandle, GtkCellEditableHandle
{
}

public static class GtkCellEditableHandleExtensions
{
	public static T EditingDone<T>(this T cell_editable) where T : GtkCellEditableHandle
	{
		GtkCellEditableHandleExterns.gtk_cell_editable_editing_done(cell_editable);
		return cell_editable;
	}

	public static T RemoveWidget<T>(this T cell_editable) where T : GtkCellEditableHandle
	{
		GtkCellEditableHandleExterns.gtk_cell_editable_remove_widget(cell_editable);
		return cell_editable;
	}

	public static T StartEditing<T>(this T cell_editable, MentorLake.Gdk.GdkEventHandle @event) where T : GtkCellEditableHandle
	{
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
