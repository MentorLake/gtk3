namespace MentorLake.Gtk3.Gtk3;

public class GtkTreeModelSortHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
	public static GtkTreeModelSortHandle NewWithModel(GtkTreeModelHandle child_model)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_new_with_model(child_model);
	}

}

public static class GtkTreeModelSortHandleExtensions
{
	public static T ClearCache<T>(this T tree_model_sort) where T : GtkTreeModelSortHandle
	{
		GtkTreeModelSortExterns.gtk_tree_model_sort_clear_cache(tree_model_sort);
		return tree_model_sort;
	}

	public static bool ConvertChildIterToIter(this GtkTreeModelSortHandle tree_model_sort, out GtkTreeIter sort_iter, GtkTreeIterHandle child_iter)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_child_iter_to_iter(tree_model_sort, out sort_iter, child_iter);
	}

	public static GtkTreePathHandle ConvertChildPathToPath(this GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle child_path)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_child_path_to_path(tree_model_sort, child_path);
	}

	public static T ConvertIterToChildIter<T>(this T tree_model_sort, out GtkTreeIter child_iter, GtkTreeIterHandle sorted_iter) where T : GtkTreeModelSortHandle
	{
		GtkTreeModelSortExterns.gtk_tree_model_sort_convert_iter_to_child_iter(tree_model_sort, out child_iter, sorted_iter);
		return tree_model_sort;
	}

	public static GtkTreePathHandle ConvertPathToChildPath(this GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle sorted_path)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_path_to_child_path(tree_model_sort, sorted_path);
	}

	public static GtkTreeModelHandle GetModel(this GtkTreeModelSortHandle tree_model)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_get_model(tree_model);
	}

	public static bool IterIsValid(this GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle iter)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_iter_is_valid(tree_model_sort, iter);
	}

	public static T ResetDefaultSortFunc<T>(this T tree_model_sort) where T : GtkTreeModelSortHandle
	{
		GtkTreeModelSortExterns.gtk_tree_model_sort_reset_default_sort_func(tree_model_sort);
		return tree_model_sort;
	}

}

internal class GtkTreeModelSortExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelSortHandle gtk_tree_model_sort_new_with_model(GtkTreeModelHandle child_model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_sort_clear_cache(GtkTreeModelSortHandle tree_model_sort);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_sort_convert_child_iter_to_iter(GtkTreeModelSortHandle tree_model_sort, out GtkTreeIter sort_iter, GtkTreeIterHandle child_iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreePathHandle gtk_tree_model_sort_convert_child_path_to_path(GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle child_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_sort_convert_iter_to_child_iter(GtkTreeModelSortHandle tree_model_sort, out GtkTreeIter child_iter, GtkTreeIterHandle sorted_iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreePathHandle gtk_tree_model_sort_convert_path_to_child_path(GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle sorted_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelHandle gtk_tree_model_sort_get_model(GtkTreeModelSortHandle tree_model);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_model_sort_iter_is_valid(GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_model_sort_reset_default_sort_func(GtkTreeModelSortHandle tree_model_sort);

}
