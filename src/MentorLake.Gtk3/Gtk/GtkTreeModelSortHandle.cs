namespace MentorLake.Gtk;

public class GtkTreeModelSortHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
	public static MentorLake.Gtk.GtkTreeModelSortHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle child_model)
	{
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_new_with_model(child_model);
	}

}

public static class GtkTreeModelSortHandleExtensions
{
	public static T ClearCache<T>(this T tree_model_sort) where T : GtkTreeModelSortHandle
	{
		GtkTreeModelSortHandleExterns.gtk_tree_model_sort_clear_cache(tree_model_sort);
		return tree_model_sort;
	}

	public static bool ConvertChildIterToIter(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, out MentorLake.Gtk.GtkTreeIter sort_iter, MentorLake.Gtk.GtkTreeIterHandle child_iter)
	{
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_child_iter_to_iter(tree_model_sort, out sort_iter, child_iter);
	}

	public static MentorLake.Gtk.GtkTreePathHandle ConvertChildPathToPath(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreePathHandle child_path)
	{
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_child_path_to_path(tree_model_sort, child_path);
	}

	public static T ConvertIterToChildIter<T>(this T tree_model_sort, out MentorLake.Gtk.GtkTreeIter child_iter, MentorLake.Gtk.GtkTreeIterHandle sorted_iter) where T : GtkTreeModelSortHandle
	{
		GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_iter_to_child_iter(tree_model_sort, out child_iter, sorted_iter);
		return tree_model_sort;
	}

	public static MentorLake.Gtk.GtkTreePathHandle ConvertPathToChildPath(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreePathHandle sorted_path)
	{
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_convert_path_to_child_path(tree_model_sort, sorted_path);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model)
	{
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_get_model(tree_model);
	}

	public static bool IterIsValid(this MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkTreeModelSortHandleExterns.gtk_tree_model_sort_iter_is_valid(tree_model_sort, iter);
	}

	public static T ResetDefaultSortFunc<T>(this T tree_model_sort) where T : GtkTreeModelSortHandle
	{
		GtkTreeModelSortHandleExterns.gtk_tree_model_sort_reset_default_sort_func(tree_model_sort);
		return tree_model_sort;
	}

}

internal class GtkTreeModelSortHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelSortHandle gtk_tree_model_sort_new_with_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle child_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_sort_clear_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_sort_convert_child_iter_to_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, out MentorLake.Gtk.GtkTreeIter sort_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle child_iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_sort_convert_child_path_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle child_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_sort_convert_iter_to_child_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, out MentorLake.Gtk.GtkTreeIter child_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle sorted_iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_sort_convert_path_to_child_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle sorted_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_tree_model_sort_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_sort_iter_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_sort_reset_default_sort_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelSortHandle>))] MentorLake.Gtk.GtkTreeModelSortHandle tree_model_sort);

}
