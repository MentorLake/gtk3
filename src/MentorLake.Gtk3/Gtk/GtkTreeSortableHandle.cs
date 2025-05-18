namespace MentorLake.Gtk;

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
	public static bool GetSortColumnId(this MentorLake.Gtk.GtkTreeSortableHandle sortable, out int sort_column_id, out MentorLake.Gtk.GtkSortType order)
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		return GtkTreeSortableHandleExterns.gtk_tree_sortable_get_sort_column_id(sortable, out sort_column_id, out order);
	}

	public static bool HasDefaultSortFunc(this MentorLake.Gtk.GtkTreeSortableHandle sortable)
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		return GtkTreeSortableHandleExterns.gtk_tree_sortable_has_default_sort_func(sortable);
	}

	public static T SetDefaultSortFunc<T>(this T sortable, MentorLake.Gtk.GtkTreeIterCompareFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeSortableHandle
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		GtkTreeSortableHandleExterns.gtk_tree_sortable_set_default_sort_func(sortable, sort_func, user_data, destroy);
		return sortable;
	}

	public static T SetSortColumnId<T>(this T sortable, int sort_column_id, MentorLake.Gtk.GtkSortType order) where T : GtkTreeSortableHandle
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		GtkTreeSortableHandleExterns.gtk_tree_sortable_set_sort_column_id(sortable, sort_column_id, order);
		return sortable;
	}

	public static T SetSortFunc<T>(this T sortable, int sort_column_id, MentorLake.Gtk.GtkTreeIterCompareFunc sort_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeSortableHandle
	{
		if (sortable.IsInvalid) throw new Exception("Invalid handle (GtkTreeSortableHandle)");
		GtkTreeSortableHandleExterns.gtk_tree_sortable_set_sort_func(sortable, sort_column_id, sort_func, user_data, destroy);
		return sortable;
	}

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
