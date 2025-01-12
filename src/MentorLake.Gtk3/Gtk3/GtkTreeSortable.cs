namespace MentorLake.Gtk3.Gtk3;

public interface GtkTreeSortableHandle
{
}

internal class GtkTreeSortableHandleImpl : BaseSafeHandle, GtkTreeSortableHandle
{
}

public static class GtkTreeSortableHandleExtensions
{
	public static bool GetSortColumnId(this GtkTreeSortableHandle sortable, out int sort_column_id, out GtkSortType order)
	{
		return GtkTreeSortableExterns.gtk_tree_sortable_get_sort_column_id(sortable, out sort_column_id, out order);
	}

	public static bool HasDefaultSortFunc(this GtkTreeSortableHandle sortable)
	{
		return GtkTreeSortableExterns.gtk_tree_sortable_has_default_sort_func(sortable);
	}

	public static T SetDefaultSortFunc<T>(this T sortable, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy) where T : GtkTreeSortableHandle
	{
		GtkTreeSortableExterns.gtk_tree_sortable_set_default_sort_func(sortable, sort_func, user_data, destroy);
		return sortable;
	}

	public static T SetSortColumnId<T>(this T sortable, int sort_column_id, GtkSortType order) where T : GtkTreeSortableHandle
	{
		GtkTreeSortableExterns.gtk_tree_sortable_set_sort_column_id(sortable, sort_column_id, order);
		return sortable;
	}

	public static T SetSortFunc<T>(this T sortable, int sort_column_id, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy) where T : GtkTreeSortableHandle
	{
		GtkTreeSortableExterns.gtk_tree_sortable_set_sort_func(sortable, sort_column_id, sort_func, user_data, destroy);
		return sortable;
	}

	public static T SortColumnChanged<T>(this T sortable) where T : GtkTreeSortableHandle
	{
		GtkTreeSortableExterns.gtk_tree_sortable_sort_column_changed(sortable);
		return sortable;
	}

}

internal class GtkTreeSortableExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_sortable_get_sort_column_id(GtkTreeSortableHandle sortable, out int sort_column_id, out GtkSortType order);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_sortable_has_default_sort_func(GtkTreeSortableHandle sortable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_sortable_set_default_sort_func(GtkTreeSortableHandle sortable, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_sortable_set_sort_column_id(GtkTreeSortableHandle sortable, int sort_column_id, GtkSortType order);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_sortable_set_sort_func(GtkTreeSortableHandle sortable, int sort_column_id, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_sortable_sort_column_changed(GtkTreeSortableHandle sortable);

}
