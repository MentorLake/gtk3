namespace MentorLake.Gtk3.Gtk3;

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
		GtkCellEditableExterns.gtk_cell_editable_editing_done(cell_editable);
		return cell_editable;
	}

	public static T RemoveWidget<T>(this T cell_editable) where T : GtkCellEditableHandle
	{
		GtkCellEditableExterns.gtk_cell_editable_remove_widget(cell_editable);
		return cell_editable;
	}

	public static T StartEditing<T>(this T cell_editable, GdkEventHandle @event) where T : GtkCellEditableHandle
	{
		GtkCellEditableExterns.gtk_cell_editable_start_editing(cell_editable, @event);
		return cell_editable;
	}

}

internal class GtkCellEditableExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_editable_editing_done(GtkCellEditableHandle cell_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_editable_remove_widget(GtkCellEditableHandle cell_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_editable_start_editing(GtkCellEditableHandle cell_editable, GdkEventHandle @event);

}
