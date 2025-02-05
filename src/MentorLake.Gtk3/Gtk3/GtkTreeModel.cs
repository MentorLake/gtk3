namespace MentorLake.Gtk3.Gtk3;

public interface GtkTreeModelHandle
{
}

internal class GtkTreeModelHandleImpl : BaseSafeHandle, GtkTreeModelHandle
{
}

public static class GtkTreeModelHandleExtensions
{
	public static GtkTreeModelHandle FilterNew(this GtkTreeModelHandle child_model, GtkTreePathHandle root)
	{
		return GtkTreeModelExterns.gtk_tree_model_filter_new(child_model, root);
	}

	public static T Foreach<T>(this T model, GtkTreeModelForeachFunc func, IntPtr user_data) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_foreach(model, func, user_data);
		return model;
	}

	public static T Get<T>(this T tree_model, GtkTreeIterHandle iter, IntPtr @__arglist) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_get(tree_model, iter, @__arglist);
		return tree_model;
	}

	public static GType GetColumnType(this GtkTreeModelHandle tree_model, int index_)
	{
		return GtkTreeModelExterns.gtk_tree_model_get_column_type(tree_model, index_);
	}

	public static GtkTreeModelFlags GetFlags(this GtkTreeModelHandle tree_model)
	{
		return GtkTreeModelExterns.gtk_tree_model_get_flags(tree_model);
	}

	public static bool GetIter(this GtkTreeModelHandle tree_model, out GtkTreeIter iter, GtkTreePathHandle path)
	{
		return GtkTreeModelExterns.gtk_tree_model_get_iter(tree_model, out iter, path);
	}

	public static bool GetIterFirst(this GtkTreeModelHandle tree_model, out GtkTreeIter iter)
	{
		return GtkTreeModelExterns.gtk_tree_model_get_iter_first(tree_model, out iter);
	}

	public static bool GetIterFromString(this GtkTreeModelHandle tree_model, out GtkTreeIter iter, string path_string)
	{
		return GtkTreeModelExterns.gtk_tree_model_get_iter_from_string(tree_model, out iter, path_string);
	}

	public static int GetNColumns(this GtkTreeModelHandle tree_model)
	{
		return GtkTreeModelExterns.gtk_tree_model_get_n_columns(tree_model);
	}

	public static GtkTreePathHandle GetPath(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
	{
		return GtkTreeModelExterns.gtk_tree_model_get_path(tree_model, iter);
	}

	public static string GetStringFromIter(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
	{
		return GtkTreeModelExterns.gtk_tree_model_get_string_from_iter(tree_model, iter);
	}

	public static T GetValist<T>(this T tree_model, GtkTreeIterHandle iter, IntPtr var_args) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_get_valist(tree_model, iter, var_args);
		return tree_model;
	}

	public static T GetValue<T>(this T tree_model, GtkTreeIterHandle iter, int column, out GValue value) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_get_value(tree_model, iter, column, out value);
		return tree_model;
	}

	public static bool IterChildren(this GtkTreeModelHandle tree_model, out GtkTreeIter iter, GtkTreeIterHandle parent)
	{
		return GtkTreeModelExterns.gtk_tree_model_iter_children(tree_model, out iter, parent);
	}

	public static bool IterHasChild(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
	{
		return GtkTreeModelExterns.gtk_tree_model_iter_has_child(tree_model, iter);
	}

	public static int IterNChildren(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
	{
		return GtkTreeModelExterns.gtk_tree_model_iter_n_children(tree_model, iter);
	}

	public static bool IterNext(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
	{
		return GtkTreeModelExterns.gtk_tree_model_iter_next(tree_model, iter);
	}

	public static bool IterNthChild(this GtkTreeModelHandle tree_model, out GtkTreeIter iter, GtkTreeIterHandle parent, int n)
	{
		return GtkTreeModelExterns.gtk_tree_model_iter_nth_child(tree_model, out iter, parent, n);
	}

	public static bool IterParent(this GtkTreeModelHandle tree_model, out GtkTreeIter iter, GtkTreeIterHandle child)
	{
		return GtkTreeModelExterns.gtk_tree_model_iter_parent(tree_model, out iter, child);
	}

	public static bool IterPrevious(this GtkTreeModelHandle tree_model, GtkTreeIterHandle iter)
	{
		return GtkTreeModelExterns.gtk_tree_model_iter_previous(tree_model, iter);
	}

	public static T RefNode<T>(this T tree_model, GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_ref_node(tree_model, iter);
		return tree_model;
	}

	public static T RowChanged<T>(this T tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_row_changed(tree_model, path, iter);
		return tree_model;
	}

	public static T RowDeleted<T>(this T tree_model, GtkTreePathHandle path) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_row_deleted(tree_model, path);
		return tree_model;
	}

	public static T RowHasChildToggled<T>(this T tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_row_has_child_toggled(tree_model, path, iter);
		return tree_model;
	}

	public static T RowInserted<T>(this T tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_row_inserted(tree_model, path, iter);
		return tree_model;
	}

	public static T RowsReordered<T>(this T tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_rows_reordered(tree_model, path, iter, new_order);
		return tree_model;
	}

	public static T RowsReorderedWithLength<T>(this T tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order, int length) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_rows_reordered_with_length(tree_model, path, iter, new_order, length);
		return tree_model;
	}

	public static T UnrefNode<T>(this T tree_model, GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelExterns.gtk_tree_model_unref_node(tree_model, iter);
		return tree_model;
	}

}

internal class GtkTreeModelExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelHandle gtk_tree_model_filter_new(GtkTreeModelHandle child_model, GtkTreePathHandle root);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_foreach(GtkTreeModelHandle model, GtkTreeModelForeachFunc func, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_get(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern GType gtk_tree_model_get_column_type(GtkTreeModelHandle tree_model, int index_);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelFlags gtk_tree_model_get_flags(GtkTreeModelHandle tree_model);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_get_iter(GtkTreeModelHandle tree_model, out GtkTreeIter iter, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_get_iter_first(GtkTreeModelHandle tree_model, out GtkTreeIter iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_get_iter_from_string(GtkTreeModelHandle tree_model, out GtkTreeIter iter, string path_string);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_model_get_n_columns(GtkTreeModelHandle tree_model);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreePathHandle gtk_tree_model_get_path(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_tree_model_get_string_from_iter(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_get_valist(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, IntPtr var_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_get_value(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, int column, out GValue value);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_iter_children(GtkTreeModelHandle tree_model, out GtkTreeIter iter, GtkTreeIterHandle parent);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_iter_has_child(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_model_iter_n_children(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_iter_next(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_iter_nth_child(GtkTreeModelHandle tree_model, out GtkTreeIter iter, GtkTreeIterHandle parent, int n);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_iter_parent(GtkTreeModelHandle tree_model, out GtkTreeIter iter, GtkTreeIterHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_iter_previous(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_ref_node(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_row_changed(GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_row_deleted(GtkTreeModelHandle tree_model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_row_has_child_toggled(GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_row_inserted(GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_rows_reordered(GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_rows_reordered_with_length(GtkTreeModelHandle tree_model, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order, int length);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_unref_node(GtkTreeModelHandle tree_model, GtkTreeIterHandle iter);

}
