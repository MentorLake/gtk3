namespace MentorLake.Gtk3.Gtk3;

public interface GtkEditableHandle
{
}

internal class GtkEditableHandleImpl : BaseSafeHandle, GtkEditableHandle
{
}

public static class GtkEditableHandleExtensions
{
	public static T CopyClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_copy_clipboard(editable);
		return editable;
	}

	public static T CutClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_cut_clipboard(editable);
		return editable;
	}

	public static T DeleteSelection<T>(this T editable) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_delete_selection(editable);
		return editable;
	}

	public static T DeleteText<T>(this T editable, int start_pos, int end_pos) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_delete_text(editable, start_pos, end_pos);
		return editable;
	}

	public static string GetChars(this GtkEditableHandle editable, int start_pos, int end_pos)
	{
		return GtkEditableExterns.gtk_editable_get_chars(editable, start_pos, end_pos);
	}

	public static bool GetEditable(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_editable(editable);
	}

	public static int GetPosition(this GtkEditableHandle editable)
	{
		return GtkEditableExterns.gtk_editable_get_position(editable);
	}

	public static bool GetSelectionBounds(this GtkEditableHandle editable, out int start_pos, out int end_pos)
	{
		return GtkEditableExterns.gtk_editable_get_selection_bounds(editable, out start_pos, out end_pos);
	}

	public static T InsertText<T>(this T editable, string new_text, int new_text_length, ref int position) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_insert_text(editable, new_text, new_text_length, ref position);
		return editable;
	}

	public static T PasteClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_paste_clipboard(editable);
		return editable;
	}

	public static T SelectRegion<T>(this T editable, int start_pos, int end_pos) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_select_region(editable, start_pos, end_pos);
		return editable;
	}

	public static T SetEditable<T>(this T editable, bool is_editable) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_set_editable(editable, is_editable);
		return editable;
	}

	public static T SetPosition<T>(this T editable, int position) where T : GtkEditableHandle
	{
		GtkEditableExterns.gtk_editable_set_position(editable, position);
		return editable;
	}

}

internal class GtkEditableExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_copy_clipboard(GtkEditableHandle editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_cut_clipboard(GtkEditableHandle editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_delete_selection(GtkEditableHandle editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_delete_text(GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_editable_get_chars(GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_editable_get_editable(GtkEditableHandle editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_editable_get_position(GtkEditableHandle editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_editable_get_selection_bounds(GtkEditableHandle editable, out int start_pos, out int end_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_insert_text(GtkEditableHandle editable, string new_text, int new_text_length, ref int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_paste_clipboard(GtkEditableHandle editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_select_region(GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_set_editable(GtkEditableHandle editable, bool is_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_editable_set_position(GtkEditableHandle editable, int position);

}
