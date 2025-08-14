namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkTreeSortable is an interface to be implemented by tree models which
/// support sorting. The #GtkTreeView uses the methods provided by this interface
/// to sort the model.
/// </para>
/// </summary>

public interface GtkTreeSortableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkTreeSortableHandleImpl : BaseSafeHandle, GtkTreeSortableHandle
{
}

public static class GtkTreeSortableHandleExtensions
{
/// <summary>
/// <para>
/// Fills in @sort_column_id and @order with the current sort column and the
/// order. It returns %TRUE unless the @sort_column_id is
/// %GTK_TREE_SORTABLE_DEFAULT_SORT_COLUMN_ID or
/// %GTK_TREE_SORTABLE_UNSORTED_SORT_COLUMN_ID.
/// </para>
/// </summary>

/// <param name="sortable">
/// A #GtkTreeSortable
/// </param>
/// <param name="sort_column_id">
/// The sort column id to be filled in
/// </param>
/// <param name="order">
/// The #GtkSortType to be filled in
/// </param>
/// <return>
/// %TRUE if the sort column is not one of the special sort
///   column ids.
/// </return>

	public static bool GetSortColumnId(this MentorLake.Gtk.GtkTreeSortableHandle sortable, out int sort_column_id, out MentorLake.Gtk.GtkSortType order)
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		return GtkTreeSortableHandleExterns.gtk_tree_sortable_get_sort_column_id(sortable, out sort_column_id, out order);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the model has a default sort function. This is used
/// primarily by GtkTreeViewColumns in order to determine if a model can
/// go back to the default state, or not.
/// </para>
/// </summary>

/// <param name="sortable">
/// A #GtkTreeSortable
/// </param>
/// <return>
/// %TRUE, if the model has a default sort function
/// </return>

	public static bool HasDefaultSortFunc(this MentorLake.Gtk.GtkTreeSortableHandle sortable)
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		return GtkTreeSortableHandleExterns.gtk_tree_sortable_has_default_sort_func(sortable);
	}

/// <summary>
/// <para>
/// Sets the default comparison function used when sorting to be @sort_func.
/// If the current sort column id of @sortable is
/// %GTK_TREE_SORTABLE_DEFAULT_SORT_COLUMN_ID, then the model will sort using
/// this function.
/// </para>
/// <para>
/// If @sort_func is %NULL, then there will be no default comparison function.
/// This means that once the model  has been sorted, it can’t go back to the
/// default state. In this case, when the current sort column id of @sortable
/// is %GTK_TREE_SORTABLE_DEFAULT_SORT_COLUMN_ID, the model will be unsorted.
/// </para>
/// </summary>

/// <param name="sortable">
/// A #GtkTreeSortable
/// </param>
/// <param name="sort_func">
/// The comparison function
/// </param>
/// <param name="user_data">
/// User data to pass to @sort_func, or %NULL
/// </param>
/// <param name="destroy">
/// Destroy notifier of @user_data, or %NULL
/// </param>

	public static T SetDefaultSortFunc<T>(this T sortable, MentorLake.Gtk.GtkTreeIterCompareFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeSortableHandle
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		GtkTreeSortableHandleExterns.gtk_tree_sortable_set_default_sort_func(sortable, sort_func, user_data, destroy);
		return sortable;
	}

/// <summary>
/// <para>
/// Sets the current sort column to be @sort_column_id. The @sortable will
/// resort itself to reflect this change, after emitting a
/// #GtkTreeSortable::sort-column-changed signal. @sort_column_id may either be
/// a regular column id, or one of the following special values:
/// </para>
/// <para>
/// - %GTK_TREE_SORTABLE_DEFAULT_SORT_COLUMN_ID: the default sort function
///   will be used, if it is set
/// </para>
/// <para>
/// - %GTK_TREE_SORTABLE_UNSORTED_SORT_COLUMN_ID: no sorting will occur
/// </para>
/// </summary>

/// <param name="sortable">
/// A #GtkTreeSortable
/// </param>
/// <param name="sort_column_id">
/// the sort column id to set
/// </param>
/// <param name="order">
/// The sort order of the column
/// </param>

	public static T SetSortColumnId<T>(this T sortable, int sort_column_id, MentorLake.Gtk.GtkSortType order) where T : GtkTreeSortableHandle
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		GtkTreeSortableHandleExterns.gtk_tree_sortable_set_sort_column_id(sortable, sort_column_id, order);
		return sortable;
	}

/// <summary>
/// <para>
/// Sets the comparison function used when sorting to be @sort_func. If the
/// current sort column id of @sortable is the same as @sort_column_id, then
/// the model will sort using this function.
/// </para>
/// </summary>

/// <param name="sortable">
/// A #GtkTreeSortable
/// </param>
/// <param name="sort_column_id">
/// the sort column id to set the function for
/// </param>
/// <param name="sort_func">
/// The comparison function
/// </param>
/// <param name="user_data">
/// User data to pass to @sort_func, or %NULL
/// </param>
/// <param name="destroy">
/// Destroy notifier of @user_data, or %NULL
/// </param>

	public static T SetSortFunc<T>(this T sortable, int sort_column_id, MentorLake.Gtk.GtkTreeIterCompareFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeSortableHandle
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		GtkTreeSortableHandleExterns.gtk_tree_sortable_set_sort_func(sortable, sort_column_id, sort_func, user_data, destroy);
		return sortable;
	}

/// <summary>
/// <para>
/// Emits a #GtkTreeSortable::sort-column-changed signal on @sortable.
/// </para>
/// </summary>

/// <param name="sortable">
/// A #GtkTreeSortable
/// </param>

	public static T SortColumnChanged<T>(this T sortable) where T : GtkTreeSortableHandle
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		GtkTreeSortableHandleExterns.gtk_tree_sortable_sort_column_changed(sortable);
		return sortable;
	}

}

internal class GtkTreeSortableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_sortable_get_sort_column_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSortableHandleImpl>))] MentorLake.Gtk.GtkTreeSortableHandle sortable, out int sort_column_id, out MentorLake.Gtk.GtkSortType order);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_sortable_has_default_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSortableHandleImpl>))] MentorLake.Gtk.GtkTreeSortableHandle sortable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_sortable_set_default_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSortableHandleImpl>))] MentorLake.Gtk.GtkTreeSortableHandle sortable, MentorLake.Gtk.GtkTreeIterCompareFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_sortable_set_sort_column_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSortableHandleImpl>))] MentorLake.Gtk.GtkTreeSortableHandle sortable, int sort_column_id, MentorLake.Gtk.GtkSortType order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_sortable_set_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSortableHandleImpl>))] MentorLake.Gtk.GtkTreeSortableHandle sortable, int sort_column_id, MentorLake.Gtk.GtkTreeIterCompareFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_sortable_sort_column_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSortableHandleImpl>))] MentorLake.Gtk.GtkTreeSortableHandle sortable);

}
