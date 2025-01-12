namespace MentorLake.Gtk3.Gtk3;

public class GtkComboBoxTextHandle : GtkComboBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
	public static GtkComboBoxTextHandle New()
	{
		return GtkComboBoxTextExterns.gtk_combo_box_text_new();
	}

	public static GtkComboBoxTextHandle NewWithEntry()
	{
		return GtkComboBoxTextExterns.gtk_combo_box_text_new_with_entry();
	}

}

public static class GtkComboBoxTextHandleExtensions
{
	public static T Append<T>(this T combo_box, string id, string text) where T : GtkComboBoxTextHandle
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_append(combo_box, id, text);
		return combo_box;
	}

	public static T AppendText<T>(this T combo_box, string text) where T : GtkComboBoxTextHandle
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_append_text(combo_box, text);
		return combo_box;
	}

	public static string GetActiveText(this GtkComboBoxTextHandle combo_box)
	{
		return GtkComboBoxTextExterns.gtk_combo_box_text_get_active_text(combo_box);
	}

	public static T Insert<T>(this T combo_box, int position, string id, string text) where T : GtkComboBoxTextHandle
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_insert(combo_box, position, id, text);
		return combo_box;
	}

	public static T InsertText<T>(this T combo_box, int position, string text) where T : GtkComboBoxTextHandle
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_insert_text(combo_box, position, text);
		return combo_box;
	}

	public static T Prepend<T>(this T combo_box, string id, string text) where T : GtkComboBoxTextHandle
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_prepend(combo_box, id, text);
		return combo_box;
	}

	public static T PrependText<T>(this T combo_box, string text) where T : GtkComboBoxTextHandle
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_prepend_text(combo_box, text);
		return combo_box;
	}

	public static T Remove<T>(this T combo_box, int position) where T : GtkComboBoxTextHandle
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_remove(combo_box, position);
		return combo_box;
	}

	public static T RemoveAll<T>(this T combo_box) where T : GtkComboBoxTextHandle
	{
		GtkComboBoxTextExterns.gtk_combo_box_text_remove_all(combo_box);
		return combo_box;
	}

}

internal class GtkComboBoxTextExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkComboBoxTextHandle gtk_combo_box_text_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkComboBoxTextHandle gtk_combo_box_text_new_with_entry();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_text_append(GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_text_append_text(GtkComboBoxTextHandle combo_box, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_combo_box_text_get_active_text(GtkComboBoxTextHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_text_insert(GtkComboBoxTextHandle combo_box, int position, string id, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_text_insert_text(GtkComboBoxTextHandle combo_box, int position, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_text_prepend(GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_text_prepend_text(GtkComboBoxTextHandle combo_box, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_text_remove(GtkComboBoxTextHandle combo_box, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_text_remove_all(GtkComboBoxTextHandle combo_box);

}
