namespace MentorLake.Gtk3.Gtk3;

public class GtkListStoreHandle : GObjectHandle, GtkBuildableHandle, GtkTreeDragDestHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
	public static GtkListStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkListStoreExterns.gtk_list_store_new(n_columns, @__arglist);
	}

	public static GtkListStoreHandle Newv(int n_columns, GType[] types)
	{
		return GtkListStoreExterns.gtk_list_store_newv(n_columns, types);
	}

}

public static class GtkListStoreHandleExtensions
{
	public static T Append<T>(this T list_store, out GtkTreeIter iter) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_append(list_store, out iter);
		return list_store;
	}

	public static T Clear<T>(this T list_store) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_clear(list_store);
		return list_store;
	}

	public static T Insert<T>(this T list_store, out GtkTreeIter iter, int position) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_insert(list_store, out iter, position);
		return list_store;
	}

	public static T InsertAfter<T>(this T list_store, out GtkTreeIter iter, GtkTreeIterHandle sibling) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_insert_after(list_store, out iter, sibling);
		return list_store;
	}

	public static T InsertBefore<T>(this T list_store, out GtkTreeIter iter, GtkTreeIterHandle sibling) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_insert_before(list_store, out iter, sibling);
		return list_store;
	}

	public static T InsertWithValues<T>(this T list_store, out GtkTreeIter iter, int position, IntPtr @__arglist) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_insert_with_values(list_store, out iter, position, @__arglist);
		return list_store;
	}

	public static T InsertWithValuesv<T>(this T list_store, out GtkTreeIter iter, int position, int[] columns, GValue[] values, int n_values) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_insert_with_valuesv(list_store, out iter, position, columns, values, n_values);
		return list_store;
	}

	public static bool IterIsValid(this GtkListStoreHandle list_store, GtkTreeIterHandle iter)
	{
		return GtkListStoreExterns.gtk_list_store_iter_is_valid(list_store, iter);
	}

	public static T MoveAfter<T>(this T store, GtkTreeIterHandle iter, GtkTreeIterHandle position) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_move_after(store, iter, position);
		return store;
	}

	public static T MoveBefore<T>(this T store, GtkTreeIterHandle iter, GtkTreeIterHandle position) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_move_before(store, iter, position);
		return store;
	}

	public static T Prepend<T>(this T list_store, out GtkTreeIter iter) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_prepend(list_store, out iter);
		return list_store;
	}

	public static bool Remove(this GtkListStoreHandle list_store, GtkTreeIterHandle iter)
	{
		return GtkListStoreExterns.gtk_list_store_remove(list_store, iter);
	}

	public static T Reorder<T>(this T store, int[] new_order) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_reorder(store, new_order);
		return store;
	}

	public static T Set<T>(this T list_store, GtkTreeIterHandle iter, IntPtr @__arglist) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_set(list_store, iter, @__arglist);
		return list_store;
	}

	public static T SetColumnTypes<T>(this T list_store, int n_columns, GType[] types) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_set_column_types(list_store, n_columns, types);
		return list_store;
	}

	public static T SetValist<T>(this T list_store, GtkTreeIterHandle iter, IntPtr var_args) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_set_valist(list_store, iter, var_args);
		return list_store;
	}

	public static T SetValue<T>(this T list_store, GtkTreeIterHandle iter, int column, GValueHandle value) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_set_value(list_store, iter, column, value);
		return list_store;
	}

	public static T SetValuesv<T>(this T list_store, GtkTreeIterHandle iter, int[] columns, GValue[] values, int n_values) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_set_valuesv(list_store, iter, columns, values, n_values);
		return list_store;
	}

	public static T Swap<T>(this T store, GtkTreeIterHandle a, GtkTreeIterHandle b) where T : GtkListStoreHandle
	{
		GtkListStoreExterns.gtk_list_store_swap(store, a, b);
		return store;
	}

}

internal class GtkListStoreExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkListStoreHandle gtk_list_store_new(int n_columns, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkListStoreHandle gtk_list_store_newv(int n_columns, GType[] types);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_append(GtkListStoreHandle list_store, out GtkTreeIter iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_clear(GtkListStoreHandle list_store);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_insert(GtkListStoreHandle list_store, out GtkTreeIter iter, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_insert_after(GtkListStoreHandle list_store, out GtkTreeIter iter, GtkTreeIterHandle sibling);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_insert_before(GtkListStoreHandle list_store, out GtkTreeIter iter, GtkTreeIterHandle sibling);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_insert_with_values(GtkListStoreHandle list_store, out GtkTreeIter iter, int position, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_insert_with_valuesv(GtkListStoreHandle list_store, out GtkTreeIter iter, int position, int[] columns, GValue[] values, int n_values);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_list_store_iter_is_valid(GtkListStoreHandle list_store, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_move_after(GtkListStoreHandle store, GtkTreeIterHandle iter, GtkTreeIterHandle position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_move_before(GtkListStoreHandle store, GtkTreeIterHandle iter, GtkTreeIterHandle position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_prepend(GtkListStoreHandle list_store, out GtkTreeIter iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_list_store_remove(GtkListStoreHandle list_store, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_reorder(GtkListStoreHandle store, int[] new_order);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_set(GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_set_column_types(GtkListStoreHandle list_store, int n_columns, GType[] types);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_set_valist(GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr var_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_set_value(GtkListStoreHandle list_store, GtkTreeIterHandle iter, int column, GValueHandle value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_set_valuesv(GtkListStoreHandle list_store, GtkTreeIterHandle iter, int[] columns, GValue[] values, int n_values);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_store_swap(GtkListStoreHandle store, GtkTreeIterHandle a, GtkTreeIterHandle b);

}
