namespace MentorLake.Gtk;

public interface GtkTreeModelHandle
{
}

internal class GtkTreeModelHandleImpl : BaseSafeHandle, GtkTreeModelHandle
{
}

public static class GtkTreeModelHandleExtensions
{
	public static MentorLake.Gtk.GtkTreeModelHandle FilterNew(this MentorLake.Gtk.GtkTreeModelHandle child_model, MentorLake.Gtk.GtkTreePathHandle root)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_filter_new(child_model, root);
	}

	public static T Foreach<T>(this T model, MentorLake.Gtk.GtkTreeModelForeachFunc func, IntPtr user_data) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_foreach(model, func, user_data);
		return model;
	}

	public static T Get<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_get(tree_model, iter, @__arglist);
		return tree_model;
	}

	public static MentorLake.GObject.GType GetColumnType(this MentorLake.Gtk.GtkTreeModelHandle tree_model, int index_)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_get_column_type(tree_model, index_);
	}

	public static MentorLake.Gtk.GtkTreeModelFlags GetFlags(this MentorLake.Gtk.GtkTreeModelHandle tree_model)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_get_flags(tree_model);
	}

	public static bool GetIter(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_get_iter(tree_model, out iter, path);
	}

	public static bool GetIterFirst(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_get_iter_first(tree_model, out iter);
	}

	public static bool GetIterFromString(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, string path_string)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_get_iter_from_string(tree_model, out iter, path_string);
	}

	public static int GetNColumns(this MentorLake.Gtk.GtkTreeModelHandle tree_model)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_get_n_columns(tree_model);
	}

	public static MentorLake.Gtk.GtkTreePathHandle GetPath(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_get_path(tree_model, iter);
	}

	public static string GetStringFromIter(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_get_string_from_iter(tree_model, iter);
	}

	public static T GetValist<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_get_valist(tree_model, iter, var_args);
		return tree_model;
	}

	public static T GetValue<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, int column, out MentorLake.GObject.GValue value) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_get_value(tree_model, iter, column, out value);
		return tree_model;
	}

	public static bool IterChildren(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_children(tree_model, out iter, parent);
	}

	public static bool IterHasChild(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_has_child(tree_model, iter);
	}

	public static int IterNChildren(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_n_children(tree_model, iter);
	}

	public static bool IterNext(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_next(tree_model, iter);
	}

	public static bool IterNthChild(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, int n)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_nth_child(tree_model, out iter, parent, n);
	}

	public static bool IterParent(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle child)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_parent(tree_model, out iter, child);
	}

	public static bool IterPrevious(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_previous(tree_model, iter);
	}

	public static T RefNode<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_ref_node(tree_model, iter);
		return tree_model;
	}

	public static T RowChanged<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_row_changed(tree_model, path, iter);
		return tree_model;
	}

	public static T RowDeleted<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_row_deleted(tree_model, path);
		return tree_model;
	}

	public static T RowHasChildToggled<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_row_has_child_toggled(tree_model, path, iter);
		return tree_model;
	}

	public static T RowInserted<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_row_inserted(tree_model, path, iter);
		return tree_model;
	}

	public static T RowsReordered<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter, int new_order) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_rows_reordered(tree_model, path, iter, new_order);
		return tree_model;
	}

	public static T RowsReorderedWithLength<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order, int length) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_rows_reordered_with_length(tree_model, path, iter, new_order, length);
		return tree_model;
	}

	public static T UnrefNode<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		GtkTreeModelHandleExterns.gtk_tree_model_unref_node(tree_model, iter);
		return tree_model;
	}

}

internal class GtkTreeModelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_tree_model_filter_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle child_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle root);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, MentorLake.Gtk.GtkTreeModelForeachFunc func, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_tree_model_get_column_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelFlags gtk_tree_model_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_get_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_get_iter_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_get_iter_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, string path_string);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_model_get_n_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tree_model_get_string_from_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int column, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_has_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_model_iter_n_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_nth_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent, int n);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_previous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_ref_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_row_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_row_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_row_has_child_toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_row_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_rows_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int new_order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_rows_reordered_with_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order, int length);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_unref_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

}
