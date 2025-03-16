namespace MentorLake.Gtk;

public class GtkTreeModelFilterHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle
{
}

public static class GtkTreeModelFilterHandleExtensions
{
	public static T ClearCache<T>(this T filter) where T : GtkTreeModelFilterHandle
	{
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_clear_cache(filter);
		return filter;
	}

	public static bool ConvertChildIterToIter(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, out MentorLake.Gtk.GtkTreeIter filter_iter, MentorLake.Gtk.GtkTreeIterHandle child_iter)
	{
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_child_iter_to_iter(filter, out filter_iter, child_iter);
	}

	public static MentorLake.Gtk.GtkTreePathHandle ConvertChildPathToPath(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, MentorLake.Gtk.GtkTreePathHandle child_path)
	{
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_child_path_to_path(filter, child_path);
	}

	public static T ConvertIterToChildIter<T>(this T filter, out MentorLake.Gtk.GtkTreeIter child_iter, MentorLake.Gtk.GtkTreeIterHandle filter_iter) where T : GtkTreeModelFilterHandle
	{
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_iter_to_child_iter(filter, out child_iter, filter_iter);
		return filter;
	}

	public static MentorLake.Gtk.GtkTreePathHandle ConvertPathToChildPath(this MentorLake.Gtk.GtkTreeModelFilterHandle filter, MentorLake.Gtk.GtkTreePathHandle filter_path)
	{
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_convert_path_to_child_path(filter, filter_path);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeModelFilterHandle filter)
	{
		return GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_get_model(filter);
	}

	public static T Refilter<T>(this T filter) where T : GtkTreeModelFilterHandle
	{
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_refilter(filter);
		return filter;
	}

	public static T SetModifyFunc<T>(this T filter, int n_columns, MentorLake.GObject.GType[] types, MentorLake.Gtk.GtkTreeModelFilterModifyFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeModelFilterHandle
	{
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_set_modify_func(filter, n_columns, types, func, data, destroy);
		return filter;
	}

	public static T SetVisibleColumn<T>(this T filter, int column) where T : GtkTreeModelFilterHandle
	{
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_set_visible_column(filter, column);
		return filter;
	}

	public static T SetVisibleFunc<T>(this T filter, MentorLake.Gtk.GtkTreeModelFilterVisibleFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeModelFilterHandle
	{
		GtkTreeModelFilterHandleExterns.gtk_tree_model_filter_set_visible_func(filter, func, data, destroy);
		return filter;
	}

}

internal class GtkTreeModelFilterHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_clear_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_filter_convert_child_iter_to_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, out MentorLake.Gtk.GtkTreeIter filter_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle child_iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_filter_convert_child_path_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle child_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_convert_iter_to_child_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, out MentorLake.Gtk.GtkTreeIter child_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle filter_iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_filter_convert_path_to_child_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle filter_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_tree_model_filter_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_refilter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_set_modify_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, int n_columns, MentorLake.GObject.GType[] types, MentorLake.Gtk.GtkTreeModelFilterModifyFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_set_visible_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_filter_set_visible_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelFilterHandle>))] MentorLake.Gtk.GtkTreeModelFilterHandle filter, MentorLake.Gtk.GtkTreeModelFilterVisibleFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

}
